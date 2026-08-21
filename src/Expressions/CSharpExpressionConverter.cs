// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Walks a LINQ expression tree and emits a C# source string suitable for
    /// runtime evaluation by <c>RoslynWorkflowExpressionEvaluator</c>.
    ///
    /// Workflow data references (action outputs, trigger, variables, agent parameters)
    /// are converted to free-function calls (e.g. <c>body("X")</c>, <c>triggerOutputs()</c>)
    /// matching the <c>WorkflowExpressionGlobals</c> API.
    ///
    /// All other C# constructs (operators, method calls, LINQ, BCL) are preserved verbatim
    /// so the full power of C# is available at runtime.
    /// </summary>
    internal class CSharpExpressionVisitor : VisitorBase<string, object>
    {
        private readonly struct VisitResult
        {
            public readonly string Text;
            public readonly bool IsWorkflowData;
            public readonly bool IsAgentParams;

            public VisitResult(string text, bool isWorkflowData, bool isAgentParams)
            {
                Text = text;
                IsWorkflowData = isWorkflowData;
                IsAgentParams = isAgentParams;
            }
        }

        // -------------------- Helpers --------------------

        private static object GetMemberValue(MemberInfo member, object instance)
        {
            return member switch
            {
                PropertyInfo prop => prop.GetValue(instance),
                FieldInfo field => field.GetValue(instance),
                _ => throw new ArgumentException($"Member type {member.GetType()} not supported", nameof(member))
            };
        }

        private static Type GetMemberType(MemberInfo member)
        {
            return member switch
            {
                PropertyInfo prop => prop.PropertyType,
                FieldInfo field => field.FieldType,
                _ => throw new ArgumentException($"Member type {member.GetType()} not supported", nameof(member))
            };
        }

        private static bool IsClosureType(Type type)
        {
            if (type == null) return false;
            var isCompilerGenerated = type.GetCustomAttribute<CompilerGeneratedAttribute>() != null;
            var hasClosureName = type.Name.Contains("<>") || type.Name.StartsWith("<>c__DisplayClass");
            return isCompilerGenerated && hasClosureName && type.IsNested;
        }

        private static bool ImplementsGenericInterface(Type type, Type genericInterfaceType)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceType)
                return true;
            return type.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == genericInterfaceType);
        }

        private static string GetPropertyName(MemberInfo member)
        {
            var jsonPropAttr = member.GetCustomAttribute(typeof(JsonPropertyAttribute));
            if (jsonPropAttr != null)
            {
                var propName = (string)jsonPropAttr.GetType().GetProperty("PropertyName")?.GetValue(jsonPropAttr);
                if (!string.IsNullOrEmpty(propName))
                    return propName;
            }
            return member.Name;
        }

        // -------------------- Literal rendering --------------------

        internal static string RenderLiteral(object value, Type type)
        {
            if (value == null)
                return "null";

            if (TryRenderCollectionLiteral(value, type, out var collectionLiteral))
                return collectionLiteral;

            if (value is string s)
                return $"\"{EscapeString(s)}\"";

            if (value is bool b)
                return b ? "true" : "false";

            if (value is int i)
                return i.ToString(CultureInfo.InvariantCulture);

            if (value is long l)
                return l.ToString(CultureInfo.InvariantCulture) + "L";

            if (value is double d)
            {
                return d.ToString("R", CultureInfo.InvariantCulture);
            }

            if (value is float f)
                return f.ToString("R", CultureInfo.InvariantCulture) + "f";

            if (value is decimal m)
                return m.ToString(CultureInfo.InvariantCulture) + "m";

            if (value is DateTime dt)
                return $"DateTime.Parse(\"{dt.ToString("o", CultureInfo.InvariantCulture)}\")";

            if (value is Guid g)
                return $"Guid.Parse(\"{g}\")";

            if (value is Uri uri)
                return $"new Uri(\"{EscapeString(uri.ToString())}\")";

            if (value is HttpMethod method)
                return $"\"{method.Method}\"";

            if (type != null && type.IsEnum)
            {
                var enumName = value.ToString();
                return $"{GetTypeName(type)}.{enumName}";
            }

            return value.ToString();
        }

        private static bool TryRenderCollectionLiteral(object value, Type type, out string result)
        {
            result = null;
            var valueType = type ?? value.GetType();

            if (valueType.IsArray && value is Array array)
            {
                var elementType = valueType.GetElementType() ?? typeof(object);
                var items = array.Cast<object>()
                    .Select(item => RenderLiteral(item, item?.GetType() ?? elementType))
                    .ToArray();
                var arrayPrefix = elementType == typeof(object)
                    ? $"new {GetTypeName(elementType)}[]"
                    : "new[]";
                result = $"{arrayPrefix} {{ {string.Join(", ", items)} }}";
                return true;
            }

            if (value is IDictionary dictionary)
            {
                var (keyType, dictionaryValueType) = GetDictionaryTypes(valueType);
                var items = new List<string>();
                foreach (DictionaryEntry entry in dictionary)
                {
                    items.Add(
                        $"[{RenderLiteral(entry.Key, entry.Key?.GetType() ?? keyType)}] = {RenderLiteral(entry.Value, entry.Value?.GetType() ?? dictionaryValueType)}");
                }

                result = $"new Dictionary<{GetTypeName(keyType)}, {GetTypeName(dictionaryValueType)}> {{ {string.Join(", ", items)} }}";
                return true;
            }

            return false;
        }

        private static (Type KeyType, Type ValueType) GetDictionaryTypes(Type type)
        {
            if (type != null && type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            {
                var typeArgs = type.GetGenericArguments();
                return (typeArgs[0], typeArgs[1]);
            }

            var candidateTypes = new List<Type>();
            if (type != null)
            {
                candidateTypes.Add(type);
                candidateTypes.AddRange(type.GetInterfaces());
            }

            var dictionaryType = candidateTypes.FirstOrDefault(candidate =>
                candidate.IsGenericType &&
                candidate.GetGenericTypeDefinition() == typeof(IDictionary<,>));

            if (dictionaryType != null)
            {
                var typeArgs = dictionaryType.GetGenericArguments();
                return (typeArgs[0], typeArgs[1]);
            }

            return (typeof(object), typeof(object));
        }

        private static string EscapeString(string s)
        {
            return s.Replace("\\", "\\\\")
                    .Replace("\"", "\\\"")
                    .Replace("\n", "\\n")
                    .Replace("\r", "\\r")
                    .Replace("\t", "\\t")
                    .Replace("\0", "\\0");
        }

        // -------------------- Expression visitors --------------------

        public override string Visit(Expression e, object p)
        {
            throw new NotSupportedException($"Expression type {e.NodeType} ({e.GetType().Name}) not supported.");
        }

        public override string Visit(ConstantExpression e, object p)
        {
            if (e.Value == null && e.Type != typeof(object))
                return $"({GetTypeName(e.Type)})null";

            return RenderLiteral(e.Value, e.Type);
        }

        public override string Visit(ParameterExpression e, object p)
        {
            return e.Name;
        }

        public override string Visit(MemberExpression e, object p)
        {
            return VisitMemberTagged(e, p).Text;
        }

        private VisitResult VisitMemberTagged(MemberExpression e, object p)
        {
            // Static member (no instance expression)
            if (e.Expression == null)
            {
                if (e.Member.DeclaringType != null && e.Member.DeclaringType.IsEnum)
                    return new VisitResult($"{GetTypeName(e.Member.DeclaringType)}.{e.Member.Name}", false, false);

                if (e.Member is PropertyInfo prop)
                {
                    var value = prop.GetValue(null);
                    return new VisitResult(RenderLiteral(value, prop.PropertyType), false, false);
                }
                if (e.Member is FieldInfo field)
                {
                    var value = field.GetValue(null);
                    return new VisitResult(RenderLiteral(value, field.FieldType), false, false);
                }
            }

            var targetResult = VisitTagged(e.Expression, p);
            var target = targetResult.Text;

            // Workflow data members need to be recognized before closure inlining.
            if (TryHandleWorkflowMember(e, targetResult, out var result))
                return result;

            // If target resolved to a closure literal, evaluate the member
            if (e.Expression is ConstantExpression ce && IsClosureType(ce.Type))
            {
                var value = GetMemberValue(e.Member, ce.Value);
                return RenderCapturedValue(value, GetMemberType(e.Member));
            }

            // If target is a MemberExpression on a closure (nested closure capture)
            if (e.Expression is MemberExpression innerMember &&
                innerMember.Expression is ConstantExpression innerCe &&
                IsClosureType(innerCe.Type))
            {
                var innerValue = GetMemberValue(innerMember.Member, innerCe.Value);
                if (innerValue != null && IsClosureType(innerValue.GetType()))
                {
                    var value = GetMemberValue(e.Member, innerValue);
                    return RenderCapturedValue(value, GetMemberType(e.Member));
                }
            }

            // General member access
            return new VisitResult($"{target}.{e.Member.Name}", false, false);
        }

        private VisitResult RenderCapturedValue(object value, Type type)
        {
            if (value == null)
                return new VisitResult("null", false, false);

            if (value is ForEachItemToken)
                return new VisitResult("item()", true, false);

            // For workflow action/trigger objects, return as-is (they'll be handled by parent MemberExpression)
            if (value is IWorkflowAction || value is IWorkflowOperation)
                return new VisitResult(RenderLiteral(value, type), false, false);

            return new VisitResult(RenderLiteral(value, type), false, false);
        }

        private bool TryHandleWorkflowMember(MemberExpression e, VisitResult targetResult, out VisitResult result)
        {
            result = default;
            var target = targetResult.Text;

            // We need the actual object value for workflow types - get it from the closure
            object closureValue = TryExtractClosureValue(e.Expression);

            // IOutputWorkflowAction<T>.Output
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IOutputWorkflowAction<>)))
            {
                if (e.Member.Name == "Output")
                {
                    var actionName = ((IWorkflowAction)closureValue).Name;
                    result = new VisitResult($"outputs(\"{EscapeString(actionName)}\")", true, false);
                    return true;
                }
            }

            // IBodyWorkflowAction<T>.Body
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IBodyWorkflowAction<>)))
            {
                if (e.Member.Name == "Body")
                {
                    var actionName = ((IWorkflowAction)closureValue).Name;
                    result = new VisitResult($"body(\"{EscapeString(actionName)}\")", true, false);
                    return true;
                }
            }

            // IOutputWorkflowTrigger<T>.TriggerOutput
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IOutputWorkflowTrigger<>)))
            {
                if (e.Member.Name == "TriggerOutput")
                {
                    result = new VisitResult("triggerOutputs()", true, false);
                    return true;
                }
            }

            // IBodyWorkflowTrigger<T>.TriggerBody
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IBodyWorkflowTrigger<>)))
            {
                if (e.Member.Name == "TriggerBody")
                {
                    result = new VisitResult("triggerBody()", true, false);
                    return true;
                }
            }

            // IVariableWorkflowAction.Value
            if (closureValue is IVariableWorkflowAction variableAction)
            {
                if (e.Member.Name == "Value")
                {
                    result = new VisitResult($"variables(\"{EscapeString(variableAction.VariableName)}\")", true, false);
                    return true;
                }
            }

            // IAgentToolContext<T>.Parameters
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IAgentToolContext<>)))
            {
                if (e.Member.Name == "Parameters")
                {
                    result = new VisitResult("agentparameters()", false, true);
                    return true;
                }
            }

            // Member access on workflow data results (JToken navigation)
            if (targetResult.IsWorkflowData)
            {
                var propName = GetPropertyName(e.Member);
                result = new VisitResult($"{target}?[\"{EscapeString(propName)}\"]", true, false);
                return true;
            }

            // Agent parameters member access
            if (targetResult.IsAgentParams)
            {
                var propName = GetPropertyName(e.Member);
                result = new VisitResult($"agentparameters(\"{EscapeString(propName)}\")", true, false);
                return true;
            }

            return false;
        }

        private static object TryExtractClosureValue(Expression expr)
        {
            // Direct closure: constant.member
            if (expr is MemberExpression me && me.Expression is ConstantExpression ce && IsClosureType(ce.Type))
            {
                return GetMemberValue(me.Member, ce.Value);
            }

            // Nested closure
            if (expr is MemberExpression me2 && me2.Expression is MemberExpression inner &&
                inner.Expression is ConstantExpression innerCe && IsClosureType(innerCe.Type))
            {
                var innerVal = GetMemberValue(inner.Member, innerCe.Value);
                return GetMemberValue(me2.Member, innerVal);
            }

            // Direct constant (for static values)
            if (expr is ConstantExpression directCe && !IsClosureType(directCe.Type))
            {
                return directCe.Value;
            }

            return null;
        }

        public override string Visit(BinaryExpression e, object p)
        {
            var left = IsNullConstant(e.Left) ? "null" : VisitExpression(e.Left, p);
            var right = IsNullConstant(e.Right) ? "null" : VisitExpression(e.Right, p);

            // Array index
            if (e.NodeType == ExpressionType.ArrayIndex)
            {
                return $"{left}[{right}]";
            }

            // String concatenation via operator
            var concat = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) });
            var concat3 = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string), typeof(string) });

            if (e.Method == concat || e.Method == concat3)
            {
                return $"{left} + {right}";
            }

            var op = e.NodeType switch
            {
                ExpressionType.Add => "+",
                ExpressionType.Subtract => "-",
                ExpressionType.Multiply => "*",
                ExpressionType.Divide => "/",
                ExpressionType.Modulo => "%",
                ExpressionType.Equal => "==",
                ExpressionType.NotEqual => "!=",
                ExpressionType.LessThan => "<",
                ExpressionType.LessThanOrEqual => "<=",
                ExpressionType.GreaterThan => ">",
                ExpressionType.GreaterThanOrEqual => ">=",
                ExpressionType.AndAlso => "&&",
                ExpressionType.OrElse => "||",
                ExpressionType.And => "&",
                ExpressionType.Or => "|",
                ExpressionType.ExclusiveOr => "^",
                ExpressionType.Coalesce => "??",
                ExpressionType.LeftShift => "<<",
                ExpressionType.RightShift => ">>",
                _ => throw new NotSupportedException($"Binary operator {e.NodeType} not supported.")
            };

            // For Add with string concat method, use +
            if (e.NodeType == ExpressionType.Add && e.Method != null && e.Method.Name == "Concat")
            {
                op = "+";
            }

            var parentPrecedence = GetPrecedence(e.NodeType);
            left = ParenthesizeBinaryOperandIfNeeded(e.Left, left, parentPrecedence);
            right = ParenthesizeBinaryOperandIfNeeded(e.Right, right, parentPrecedence);

            return $"{left} {op} {right}";
        }

        public override string Visit(UnaryExpression e, object p)
        {
            var operand = VisitExpression(e.Operand, p);

            switch (e.NodeType)
            {
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                    // For enum-to-int or similar widening, skip
                    if (e.Type == typeof(object))
                        return operand;
                    // For explicit casts needed for disambiguation
                    if (e.Type != e.Operand.Type)
                    {
                        var typeName = GetTypeName(e.Type);
                        return $"({typeName}){operand}";
                    }
                    return operand;

                case ExpressionType.Not:
                    if (StripConvert(e.Operand) is BinaryExpression)
                        operand = $"({operand})";
                    return $"!{operand}";

                case ExpressionType.Negate:
                case ExpressionType.NegateChecked:
                    return $"-{operand}";

                case ExpressionType.ArrayLength:
                    return $"{operand}.Length";

                default:
                    throw new NotSupportedException($"Unary operation {e.NodeType} not supported.");
            }
        }

        public override string Visit(ConditionalExpression e, object p)
        {
            var test = VisitExpression(e.Test, p);
            var ifTrue = VisitExpression(e.IfTrue, p);
            var ifFalse = VisitExpression(e.IfFalse, p);
            return $"{test} ? {ifTrue} : {ifFalse}";
        }

        public override string Visit(MethodCallExpression e, object p)
        {
            var args = e.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();

            // WorkflowFunctions.ToJson -> json()
            if (e.Method.DeclaringType == typeof(WorkflowFunctions) && e.Method.Name == "ToJson")
            {
                return $"json({args[0]})";
            }

            // JToken.ToObject<T>() and JToken.Value<T>() - pass-through
            if (e.Method.IsGenericMethod &&
                (e.Method.Name == "ToObject" || e.Method.Name == "Value") &&
                e.Object != null &&
                typeof(JToken).IsAssignableFrom(StripConvert(e.Object).Type))
            {
                var instance = VisitExpression(e.Object, p);
                var typeArg = GetTypeName(e.Method.GetGenericArguments()[0]);
                return $"{instance}.{e.Method.Name}<{typeArg}>({string.Join(", ", args)})";
            }

            if (e.Method.IsGenericMethod &&
                (e.Method.Name == "ToObject" || e.Method.Name == "Value") &&
                e.Object == null &&
                e.Arguments.Count > 0 &&
                typeof(JToken).IsAssignableFrom(StripConvert(e.Arguments[0]).Type))
            {
                var instance = VisitExpression(e.Arguments[0], p);
                var typeArg = GetTypeName(e.Method.GetGenericArguments()[0]);
                var methodArgs = args.Skip(1).ToArray();
                return $"{instance}.{e.Method.Name}<{typeArg}>({string.Join(", ", methodArgs)})";
            }

            // String methods - static
            if (e.Method.DeclaringType == typeof(string))
            {
                return HandleStringMethod(e, args, p);
            }

            // Math methods
            if (e.Method.DeclaringType == typeof(Math))
            {
                return $"Math.{e.Method.Name}({string.Join(", ", args)})";
            }

            // ToString() on any type
            if (e.Method.Name == "ToString" && e.Arguments.Count == 0 && e.Object != null)
            {
                var instance = VisitExpression(e.Object, p);
                // Wrap numeric literals in parens so "1.ToString()" doesn't parse as "1."
                if (e.Object is ConstantExpression || IsNumericLiteral(instance))
                    return $"({instance}).ToString()";
                return $"{instance}.ToString()";
            }

            if (e.Object != null && e.Method.Name == "get_Item")
            {
                var instance = VisitExpression(e.Object, p);
                return $"{instance}[{string.Join(", ", args)}]";
            }

            // Instance methods (Contains, StartsWith, EndsWith, Substring, ToUpper, etc.)
            if (e.Object != null)
            {
                var instance = VisitExpression(e.Object, p);
                return $"{instance}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}({string.Join(", ", args)})";
            }

            // Extension methods (LINQ: Max(), etc.)
            if (e.Method.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false))
            {
                var target = args[0];
                var remainingArgs = args.Skip(1).ToArray();
                if (remainingArgs.Length > 0)
                    return $"{target}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}({string.Join(", ", remainingArgs)})";
                return $"{target}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}()";
            }

            // Static methods on other types
            if (e.Method.IsStatic && e.Method.DeclaringType != null)
            {
                var typeName = GetTypeName(e.Method.DeclaringType);
                return $"{typeName}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}({string.Join(", ", args)})";
            }

            throw new NotSupportedException($"Method {e.Method.DeclaringType?.Name}.{e.Method.Name} not supported.");
        }

        private string HandleStringMethod(MethodCallExpression e, string[] args, object p)
        {
            switch (e.Method.Name)
            {
                case "Concat":
                    if (TryRenderInterpolatedConcat(e, p, out var concatInterpolation))
                        return concatInterpolation;

                    if (args.Length == 1 && e.Arguments[0] is NewArrayExpression)
                    {
                        // string.Concat(new[] { ... })
                        return $"string.Concat({args[0]})";
                    }
                    return $"string.Concat({string.Join(", ", args)})";

                case "Format":
                    if (TryRenderInterpolatedFormat(e, p, out var interpolatedString))
                        return interpolatedString;

                    return $"string.Format({string.Join(", ", args)})";

                case "Join":
                    return $"string.Join({string.Join(", ", args)})";

                default:
                    if (e.Object != null)
                    {
                        var instance = VisitExpression(e.Object, p);
                        return $"{instance}.{e.Method.Name}({string.Join(", ", args)})";
                    }
                    return $"string.{e.Method.Name}({string.Join(", ", args)})";
            }
        }

        private bool TryRenderInterpolatedFormat(MethodCallExpression e, object p, out string result)
        {
            result = null;

            if (!TryGetConstantStringValue(e.Arguments[0], out var format))
                return false;

            var argExpressions = GetFormatArgumentExpressions(e);
            if (argExpressions.Count == 0 ||
                !TryParseSimpleCompositeFormat(format, argExpressions.Count, out var segments))
            {
                return false;
            }

            var renderedArgs = argExpressions.Select(arg => VisitTagged(arg, p)).ToArray();
            var transformedArgs = new string[renderedArgs.Length];
            var hasWorkflowArg = false;
            var hasSerializedArg = false;

            for (int i = 0; i < argExpressions.Count; i++)
            {
                transformedArgs[i] = TransformInterpolatedArgument(
                    argExpressions[i],
                    renderedArgs[i],
                    out var isWorkflowArg,
                    out var isSerializedArg);
                hasWorkflowArg |= isWorkflowArg;
                hasSerializedArg |= isSerializedArg;
            }

            if (segments.Count == 1 && segments[0].PlaceholderIndex.HasValue)
            {
                result = transformedArgs[segments[0].PlaceholderIndex.Value];
                return true;
            }

            if (!hasWorkflowArg && !hasSerializedArg)
                return false;

            result = BuildInterpolatedString(segments, transformedArgs);
            return true;
        }

        private bool TryRenderInterpolatedConcat(MethodCallExpression e, object p, out string result)
        {
            result = null;

            var argExpressions = GetConcatArgumentExpressions(e);
            if (argExpressions.Count == 0)
                return false;

            var segments = new List<FormatSegment>();
            var transformedArgs = new List<string>();
            var hasWorkflowArg = false;
            var hasSerializedArg = false;

            foreach (var argExpression in argExpressions)
            {
                if (TryGetConstantStringValue(argExpression, out var text))
                {
                    segments.Add(new FormatSegment { Text = text });
                    continue;
                }

                var renderedArg = VisitTagged(argExpression, p);
                var transformedArg = TransformInterpolatedArgument(
                    argExpression,
                    renderedArg,
                    out var isWorkflowArg,
                    out var isSerializedArg);

                hasWorkflowArg |= isWorkflowArg;
                hasSerializedArg |= isSerializedArg;

                segments.Add(new FormatSegment { PlaceholderIndex = transformedArgs.Count });
                transformedArgs.Add(transformedArg);
            }

            if (!hasWorkflowArg && !hasSerializedArg)
                return false;

            if (segments.Count == 1 && segments[0].PlaceholderIndex.HasValue)
            {
                result = transformedArgs[segments[0].PlaceholderIndex.Value];
                return true;
            }

            result = BuildInterpolatedString(segments, transformedArgs.ToArray());
            return true;
        }

        private static List<Expression> GetFormatArgumentExpressions(MethodCallExpression e)
        {
            var args = new List<Expression>();
            for (int i = 1; i < e.Arguments.Count; i++)
            {
                var arg = StripConvert(e.Arguments[i]);
                if (i == 1 && e.Arguments.Count == 2 && arg is NewArrayExpression newArray)
                {
                    args.AddRange(newArray.Expressions.Select(StripConvert));
                    continue;
                }

                args.Add(arg);
            }

            return args;
        }

        private static List<Expression> GetConcatArgumentExpressions(MethodCallExpression e)
        {
            if (e.Arguments.Count == 1 && StripConvert(e.Arguments[0]) is NewArrayExpression newArray)
                return newArray.Expressions.Select(StripConvert).ToList();

            return e.Arguments.Select(StripConvert).ToList();
        }

        private static string TransformInterpolatedArgument(Expression expression, VisitResult renderedValue, out bool isWorkflowArg, out bool isSerializedArg)
        {
            isWorkflowArg = renderedValue.IsWorkflowData;
            isSerializedArg = !isWorkflowArg && NeedsJsonSerialization(expression);

            if (isSerializedArg)
                return $"JsonConvert.SerializeObject({renderedValue.Text})";

            return renderedValue.Text;
        }

        private static bool NeedsJsonSerialization(Expression expression)
        {
            var expressionType = StripConvert(expression).Type;

            if (expressionType == typeof(string) ||
                expressionType.IsPrimitive ||
                expressionType.IsEnum ||
                expressionType.IsValueType ||
                expressionType == typeof(decimal) ||
                expressionType == typeof(Uri) ||
                typeof(JToken).IsAssignableFrom(expressionType))
            {
                return false;
            }

            return true;
        }

        private static string BuildInterpolatedString(IReadOnlyList<FormatSegment> segments, IReadOnlyList<string> transformedArgs)
        {
            var builder = new StringBuilder("$\"");

            foreach (var segment in segments)
            {
                if (segment.PlaceholderIndex.HasValue)
                {
                    builder.Append('{')
                        .Append(transformedArgs[segment.PlaceholderIndex.Value])
                        .Append('}');
                }
                else
                {
                    builder.Append(EscapeInterpolatedStringText(segment.Text));
                }
            }

            builder.Append('"');
            return builder.ToString();
        }

        private static bool TryParseSimpleCompositeFormat(string format, int argumentCount, out List<FormatSegment> segments)
        {
            segments = new List<FormatSegment>();
            var currentText = new StringBuilder();

            for (int i = 0; i < format.Length; i++)
            {
                if (format[i] == '{')
                {
                    if (i + 1 < format.Length && format[i + 1] == '{')
                    {
                        currentText.Append('{');
                        i++;
                        continue;
                    }

                    if (currentText.Length > 0)
                    {
                        segments.Add(new FormatSegment { Text = currentText.ToString() });
                        currentText.Clear();
                    }

                    var start = i + 1;
                    var end = start;
                    while (end < format.Length && char.IsDigit(format[end]))
                        end++;

                    if (end == start ||
                        end >= format.Length ||
                        format[end] != '}' ||
                        !int.TryParse(format.Substring(start, end - start), NumberStyles.None, CultureInfo.InvariantCulture, out var placeholderIndex) ||
                        placeholderIndex < 0 ||
                        placeholderIndex >= argumentCount)
                    {
                        return false;
                    }

                    segments.Add(new FormatSegment { PlaceholderIndex = placeholderIndex });
                    i = end;
                    continue;
                }

                if (format[i] == '}')
                {
                    if (i + 1 < format.Length && format[i + 1] == '}')
                    {
                        currentText.Append('}');
                        i++;
                        continue;
                    }

                    return false;
                }

                currentText.Append(format[i]);
            }

            if (currentText.Length > 0)
                segments.Add(new FormatSegment { Text = currentText.ToString() });

            return segments.Count > 0;
        }

        private static bool TryGetConstantStringValue(Expression expression, out string value)
        {
            expression = StripConvert(expression);

            if (expression is ConstantExpression constant && constant.Value is string constantString)
            {
                value = constantString;
                return true;
            }

            if (TryExtractClosureValue(expression) is string capturedString)
            {
                value = capturedString;
                return true;
            }

            value = null;
            return false;
        }

        private static Expression StripConvert(Expression expression)
        {
            while (expression is UnaryExpression unary &&
                (unary.NodeType == ExpressionType.Convert || unary.NodeType == ExpressionType.ConvertChecked))
            {
                expression = unary.Operand;
            }

            return expression;
        }

        private static string EscapeInterpolatedStringText(string text)
        {
            return (text ?? string.Empty)
                .Replace("\\", "\\\\")
                .Replace("\"", "\\\"")
                .Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t")
                .Replace("\0", "\\0")
                .Replace("{", "{{")
                .Replace("}", "}}");
        }

        public override string Visit(NewExpression e, object p)
        {
            if (e.Type == typeof(Uri))
            {
                var args = e.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();
                return $"new Uri({string.Join(", ", args)})";
            }

            // Anonymous types
            if (ComplexObjectConverter.IsAnonymousType(e.Type))
            {
                var members = new List<string>();
                for (int i = 0; i < e.Arguments.Count; i++)
                {
                    var memberName = e.Members[i].Name;
                    var value = VisitExpression(e.Arguments[i], p);
                    members.Add($"{memberName} = {value}");
                }
                return $"new {{ {string.Join(", ", members)} }}";
            }

            // Dictionary with collection initializer
            if (e.Type.IsGenericType && e.Type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            {
                var typeArgs = e.Type.GetGenericArguments();
                return $"new Dictionary<{GetTypeName(typeArgs[0])}, {GetTypeName(typeArgs[1])}>";
            }

            // Regular constructors
            var ctorArgs = e.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();
            return $"new {GetTypeName(e.Type)}({string.Join(", ", ctorArgs)})";
        }

        public override string Visit(NewArrayExpression e, object p)
        {
            var items = e.Expressions.Select(expr => VisitExpression(expr, p)).ToArray();
            var elementType = e.Type.GetElementType() ?? typeof(object);
            if (elementType == typeof(object))
                return $"new object[] {{ {string.Join(", ", items)} }}";

            return $"new[] {{ {string.Join(", ", items)} }}";
        }

        public override string Visit(MemberInitExpression e, object p)
        {
            var newExpr = e.NewExpression.Arguments.Count == 0
                ? $"new {GetTypeName(e.NewExpression.Type)}"
                : VisitExpression(e.NewExpression, p);
            var bindings = new List<string>();
            foreach (var binding in e.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var value = VisitExpression(assignment.Expression, p);
                    bindings.Add($"{assignment.Member.Name} = {value}");
                }
            }
            return $"{newExpr} {{ {string.Join(", ", bindings)} }}";
        }

        public override string Visit(ListInitExpression e, object p)
        {
            var newExpr = VisitExpression(e.NewExpression, p);
            var inits = new List<string>();
            foreach (var init in e.Initializers)
            {
                var args = init.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();
                if (args.Length == 2)
                {
                    // Dictionary initializer: [key] = value
                    inits.Add($"[{args[0]}] = {args[1]}");
                }
                else
                {
                    inits.Add(string.Join(", ", args));
                }
            }
            return $"{newExpr} {{ {string.Join(", ", inits)} }}";
        }

        public override string Visit(InvocationExpression e, object p)
        {
            var target = VisitExpression(e.Expression, p);
            var args = e.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();
            return $"{target}({string.Join(", ", args)})";
        }

        public override string Visit(LambdaExpression e, object p)
        {
            var body = VisitExpression(e.Body, p);
            var parms = string.Join(", ", e.Parameters.Select(param => param.Name));
            if (e.Parameters.Count == 1)
                return $"{parms} => {body}";
            return $"({parms}) => {body}";
        }

        public override string Visit(IndexExpression e, object p)
        {
            var target = VisitExpression(e.Object, p);
            var args = e.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();
            return $"{target}[{string.Join(", ", args)}]";
        }

        public override string Visit(DefaultExpression e, object p)
        {
            return $"default({GetTypeName(e.Type)})";
        }

        public override string Visit(TypeBinaryExpression e, object p)
        {
            var expr = VisitExpression(e.Expression, p);
            return $"{expr} is {GetTypeName(e.TypeOperand)}";
        }

        // -------------------- Helpers --------------------

        private static bool IsNumericLiteral(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsDigit(s[0]) || (s[0] == '-' && s.Length > 1 && char.IsDigit(s[1]));
        }

        private static int GetPrecedence(ExpressionType nodeType)
        {
            return nodeType switch
            {
                ExpressionType.Multiply or ExpressionType.Divide or ExpressionType.Modulo => 13,
                ExpressionType.Add or ExpressionType.Subtract => 12,
                ExpressionType.LeftShift or ExpressionType.RightShift => 11,
                ExpressionType.LessThan or ExpressionType.LessThanOrEqual or ExpressionType.GreaterThan or ExpressionType.GreaterThanOrEqual => 10,
                ExpressionType.Equal or ExpressionType.NotEqual => 9,
                ExpressionType.And => 8,
                ExpressionType.ExclusiveOr => 7,
                ExpressionType.Or => 6,
                ExpressionType.AndAlso => 5,
                ExpressionType.OrElse => 4,
                ExpressionType.Coalesce => 3,
                _ => int.MaxValue
            };
        }

        private static string ParenthesizeBinaryOperandIfNeeded(Expression operandExpression, string operandText, int parentPrecedence)
        {
            if (StripConvert(operandExpression) is BinaryExpression binaryExpression &&
                GetPrecedence(binaryExpression.NodeType) < parentPrecedence)
            {
                return $"({operandText})";
            }

            return operandText;
        }

        private static string GetGenericMethodTypeArguments(MethodInfo method)
        {
            if (!method.IsGenericMethod)
                return string.Empty;

            var typeArguments = method.GetGenericArguments().Select(GetTypeName);
            return $"<{string.Join(", ", typeArguments)}>";
        }

        internal string VisitExpression(Expression e, object p) => VisitTagged(e, p).Text;

        private VisitResult VisitTagged(Expression e, object p)
        {
            return e switch
            {
                BinaryExpression binary => new VisitResult(Visit(binary, p), false, false),
                UnaryExpression unary => new VisitResult(Visit(unary, p), false, false),
                ConditionalExpression conditional => new VisitResult(Visit(conditional, p), false, false),
                ConstantExpression constant => new VisitResult(Visit(constant, p), false, false),
                DefaultExpression defaultExpression => new VisitResult(Visit(defaultExpression, p), false, false),
                IndexExpression index => new VisitResult(Visit(index, p), false, false),
                InvocationExpression invocation => new VisitResult(Visit(invocation, p), false, false),
                LambdaExpression lambda => new VisitResult(Visit(lambda, p), false, false),
                ListInitExpression listInit => new VisitResult(Visit(listInit, p), false, false),
                MemberExpression member => VisitMemberTagged(member, p),
                MemberInitExpression memberInit => new VisitResult(Visit(memberInit, p), false, false),
                MethodCallExpression methodCall => new VisitResult(Visit(methodCall, p), false, false),
                NewArrayExpression newArray => new VisitResult(Visit(newArray, p), false, false),
                NewExpression @new => new VisitResult(Visit(@new, p), false, false),
                ParameterExpression parameter => new VisitResult(Visit(parameter, p), false, false),
                TypeBinaryExpression typeBinary => new VisitResult(Visit(typeBinary, p), false, false),
                _ => new VisitResult(Visit(e, p), false, false)
            };
        }

        private static bool IsNullConstant(Expression expression)
        {
            return expression is ConstantExpression constant && constant.Value == null;
        }

        private sealed class FormatSegment
        {
            public string Text { get; set; }

            public int? PlaceholderIndex { get; set; }
        }

        private static string GetTypeName(Type type)
        {
            if (type == typeof(string)) return "string";
            if (type == typeof(int)) return "int";
            if (type == typeof(long)) return "long";
            if (type == typeof(double)) return "double";
            if (type == typeof(float)) return "float";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(object)) return "object";
            if (type == typeof(char)) return "char";
            if (type == typeof(byte)) return "byte";
            if (type == typeof(short)) return "short";
            if (type == typeof(void)) return "void";

            if (type.IsGenericType)
            {
                var genericDef = type.GetGenericTypeDefinition();
                var baseName = type.Name.Substring(0, type.Name.IndexOf('`'));
                var args = type.GetGenericArguments().Select(GetTypeName);
                return $"{baseName}<{string.Join(", ", args)}>";
            }

            return type.Name;
        }
    }
}

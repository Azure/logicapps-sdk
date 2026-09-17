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
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Walks a LINQ expression tree and emits a C# source string suitable for
    /// evaluation by the Logic Apps runtime C# expression engine.
    ///
    /// Workflow data references (action outputs, trigger, variables, agent parameters)
    /// are converted to free-function calls (e.g. <c>body("X")</c>, <c>triggerOutputs()</c>)
    /// that use the runtime workflow globals.
    ///
    /// C# constructs using runtime-owned framework types are preserved. Workflow DTOs are
    /// lowered to structural JSON access because their defining assemblies are unavailable
    /// to the runtime expression engine.
    /// </summary>
    internal class LogicConverter : VisitorBase<string, object>
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

        private sealed class VisitContext
        {
            public VisitContext(IEnumerable<ParameterExpression> workflowDataParameters)
            {
                this.WorkflowDataParameters = new HashSet<ParameterExpression>(
                    workflowDataParameters ?? Enumerable.Empty<ParameterExpression>());
            }

            public HashSet<ParameterExpression> WorkflowDataParameters { get; }
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

        private static bool IsDictionaryType(Type type)
        {
            return type != null &&
                (ImplementsGenericInterface(type, typeof(IDictionary<,>)) ||
                 ImplementsGenericInterface(type, typeof(IReadOnlyDictionary<,>)));
        }

        private static bool IsJTokenCompatible(Type type) =>
            type != null && typeof(JToken).IsAssignableFrom(type);

        private static bool IsRuntimeSupportedType(Type type)
        {
            if (type == null)
                return false;

            if (IsJTokenCompatible(type))
                return true;

            var nullableType = Nullable.GetUnderlyingType(type);
            if (nullableType != null)
                return IsRuntimeSupportedType(nullableType);

            if (type.IsEnum)
                return type.Assembly == typeof(object).Assembly;

            if (type.IsPrimitive ||
                type == typeof(object) ||
                type == typeof(string) ||
                type == typeof(decimal) ||
                type == typeof(DateTime) ||
                type == typeof(DateTimeOffset) ||
                type == typeof(TimeSpan) ||
                type == typeof(Guid) ||
                type == typeof(Uri))
            {
                return true;
            }

            if (type.IsArray)
                return IsRuntimeSupportedType(type.GetElementType());

            if (!type.IsGenericType)
                return false;

            var genericType = type.GetGenericTypeDefinition();
            if (genericType != typeof(IEnumerable<>) &&
                genericType != typeof(ICollection<>) &&
                genericType != typeof(IList<>) &&
                genericType != typeof(IReadOnlyCollection<>) &&
                genericType != typeof(IReadOnlyList<>) &&
                genericType != typeof(List<>) &&
                genericType != typeof(IDictionary<,>) &&
                genericType != typeof(IReadOnlyDictionary<,>) &&
                genericType != typeof(Dictionary<,>))
            {
                return false;
            }

            return type.GetGenericArguments().All(IsRuntimeSupportedType);
        }

        private static bool IsRuntimeAssemblyAvailable(Type type)
        {
            if (type == null)
                return false;

            var assembly = type.Assembly;
            return assembly == typeof(object).Assembly ||
                assembly == typeof(Enumerable).Assembly ||
                assembly == typeof(Uri).Assembly ||
                assembly == typeof(JToken).Assembly;
        }

        private static VisitResult RenderWorkflowAccessor(string accessor, Type type)
        {
            if (IsJTokenCompatible(type) || (!IsRuntimeSupportedType(type) && !type.IsEnum))
                return new VisitResult(accessor, true, false);

            if (type.IsEnum && !IsRuntimeSupportedType(type))
                return new VisitResult($"{accessor}.ToObject<string>()", false, false);

            return new VisitResult($"{accessor}.ToObject<{GetTypeName(type)}>()", false, false);
        }

        private static string RenderEnumWireValue(object value, Type type)
        {
            var member = type.GetMember(value.ToString()).FirstOrDefault();
            var enumMember = member?.GetCustomAttribute<EnumMemberAttribute>();
            return $"\"{EscapeString(enumMember?.Value ?? value.ToString())}\"";
        }

        private static void ThrowIfUnsupportedRuntimeType(Type type, string operation)
        {
            if (!IsRuntimeSupportedType(type))
            {
                throw new NotSupportedException(
                    $"{operation} requires CLR type '{type.FullName}', whose assembly is not available to the C# runtime engine. " +
                    "Access workflow DTO values through their JSON properties instead.");
            }
        }

        private static string ParenthesizeWorkflowTarget(Expression expression, string text)
        {
            return expression is ConditionalExpression ||
                expression is BinaryExpression { NodeType: ExpressionType.Coalesce }
                ? $"({text})"
                : text;
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
                if (!IsRuntimeSupportedType(type))
                    return RenderEnumWireValue(value, type);

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
                {
                    var value = ((FieldInfo)e.Member).GetValue(null);
                    return new VisitResult(
                        IsRuntimeSupportedType(e.Member.DeclaringType)
                            ? $"{GetTypeName(e.Member.DeclaringType)}.{e.Member.Name}"
                            : RenderEnumWireValue(value, e.Member.DeclaringType),
                        false,
                        false);
                }

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
                    result = RenderWorkflowAccessor($"outputs(\"{EscapeString(actionName)}\")", e.Type);
                    return true;
                }
            }

            // IBodyWorkflowAction<T>.Body
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IBodyWorkflowAction<>)))
            {
                if (e.Member.Name == "Body")
                {
                    var actionName = ((IWorkflowAction)closureValue).Name;
                    result = RenderWorkflowAccessor($"body(\"{EscapeString(actionName)}\")", e.Type);
                    return true;
                }
            }

            // IOutputWorkflowTrigger<T>.TriggerOutput
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IOutputWorkflowTrigger<>)))
            {
                if (e.Member.Name == "TriggerOutput")
                {
                    result = RenderWorkflowAccessor("triggerOutputs()", e.Type);
                    return true;
                }
            }

            // IBodyWorkflowTrigger<T>.TriggerBody
            if (closureValue != null && ImplementsGenericInterface(closureValue.GetType(), typeof(IBodyWorkflowTrigger<>)))
            {
                if (e.Member.Name == "TriggerBody")
                {
                    result = RenderWorkflowAccessor("triggerBody()", e.Type);
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
                target = ParenthesizeWorkflowTarget(e.Expression, target);
                if ((e.Member.Name == "Count" || e.Member.Name == "Length") &&
                    TryGetEnumerableElementType(e.Expression.Type, out _))
                {
                    result = new VisitResult($"{target}.Count()", false, false);
                    return true;
                }

                var propName = GetPropertyName(e.Member);
                result = RenderWorkflowAccessor(
                    $"{target}?[\"{EscapeString(propName)}\"]",
                    GetMemberType(e.Member));
                return true;
            }

            // Agent parameters member access
            if (targetResult.IsAgentParams)
            {
                var propName = e.Member.Name;
                result = RenderWorkflowAccessor(
                    $"agentparameters(\"{EscapeString(propName)}\")",
                    GetMemberType(e.Member));
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
            return VisitBinaryTagged(e, p).Text;
        }

        private VisitResult VisitBinaryTagged(BinaryExpression e, object p)
        {
            var unavailableEnumType = GetUnavailableEnumType(e.Left) ?? GetUnavailableEnumType(e.Right);
            var leftResult = IsNullConstant(e.Left)
                ? new VisitResult("null", false, false)
                : VisitTagged(e.Left, p);
            var left = unavailableEnumType != null && StripConvert(e.Left) is ConstantExpression
                ? RenderEnumComparisonOperand(e.Left, unavailableEnumType, p)
                : leftResult.Text;
            var right = IsNullConstant(e.Right)
                ? "null"
                : RenderEnumComparisonOperand(e.Right, unavailableEnumType, p);

            // Array index
            if (e.NodeType == ExpressionType.ArrayIndex)
            {
                if (leftResult.IsWorkflowData)
                {
                    left = ParenthesizeWorkflowTarget(e.Left, left);
                    return RenderWorkflowAccessor(
                        $"{left}.Children().ElementAt({right})",
                        e.Type);
                }

                return new VisitResult($"{left}[{right}]", false, false);
            }

            // String concatenation via operator
            var concat = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) });
            var concat3 = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string), typeof(string) });

            if (e.Method == concat || e.Method == concat3)
            {
                return new VisitResult($"{left} + {right}", false, false);
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

            return new VisitResult($"{left} {op} {right}", false, false);
        }

        private static Type GetUnavailableEnumType(Expression expression)
        {
            var type = StripConvert(expression).Type;
            return type.IsEnum && !IsRuntimeSupportedType(type) ? type : null;
        }

        private string RenderEnumComparisonOperand(Expression expression, Type enumType, object p)
        {
            if (enumType != null && StripConvert(expression) is ConstantExpression constant)
            {
                return RenderEnumWireValue(Enum.ToObject(enumType, constant.Value), enumType);
            }

            return VisitExpression(expression, p);
        }

        public override string Visit(UnaryExpression e, object p)
        {
            var operand = VisitExpression(e.Operand, p);

            switch (e.NodeType)
            {
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                    if (e.Operand.Type.IsEnum && !IsRuntimeSupportedType(e.Operand.Type))
                        return operand;

                    // For enum-to-int or similar widening, skip
                    if (e.Type == typeof(object))
                        return operand;
                    // For explicit casts needed for disambiguation
                    if (e.Type != e.Operand.Type)
                    {
                        ThrowIfUnsupportedRuntimeType(e.Type, "A cast");
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
                    if (VisitTagged(e.Operand, p).IsWorkflowData)
                        return $"{operand}.Count()";

                    return $"{operand}.Length";

                default:
                    throw new NotSupportedException($"Unary operation {e.NodeType} not supported.");
            }
        }

        public override string Visit(ConditionalExpression e, object p)
        {
            return VisitConditionalTagged(e, p).Text;
        }

        private VisitResult VisitConditionalTagged(ConditionalExpression e, object p)
        {
            var test = VisitExpression(e.Test, p);
            var ifTrue = VisitTagged(e.IfTrue, p);
            var ifFalse = VisitTagged(e.IfFalse, p);
            var isWorkflowData =
                !IsRuntimeSupportedType(e.Type) &&
                (ifTrue.IsWorkflowData || IsNullConstant(e.IfTrue)) &&
                (ifFalse.IsWorkflowData || IsNullConstant(e.IfFalse));
            return new VisitResult(
                $"{test} ? {ifTrue.Text} : {ifFalse.Text}",
                isWorkflowData,
                false);
        }

        public override string Visit(MethodCallExpression e, object p)
        {
            return VisitMethodCallTagged(e, p).Text;
        }

        private VisitResult VisitMethodCallTagged(MethodCallExpression e, object p)
        {
            if (e.Object != null && e.Method.Name == "get_Item")
            {
                var targetResult = VisitTagged(e.Object, p);
                if (targetResult.IsWorkflowData)
                {
                    var index = VisitExpression(e.Arguments[0], p);
                    var target = ParenthesizeWorkflowTarget(e.Object, targetResult.Text);
                    var accessor = IsJTokenCompatible(e.Object.Type) || IsDictionaryType(e.Object.Type)
                        ? $"{target}[{index}]"
                        : TryGetEnumerableElementType(e.Object.Type, out _)
                        ? $"{target}.Children().ElementAt({index})"
                        : $"{target}?[{index}]";
                    return RenderWorkflowAccessor(accessor, e.Type);
                }
            }

            if (e.Method.IsDefined(typeof(ExtensionAttribute), false) &&
                e.Arguments.Count > 0)
            {
                var sourceResult = VisitTagged(e.Arguments[0], p);
                if (sourceResult.IsWorkflowData &&
                    TryGetEnumerableElementType(e.Arguments[0].Type, out var elementType) &&
                    !IsRuntimeSupportedType(elementType))
                {
                    if (!IsRuntimeSupportedType(e.Type))
                    {
                        throw new NotSupportedException(
                            $"LINQ method '{e.Method.Name}' returns CLR type '{e.Type.FullName}', whose assembly is not available to the C# runtime engine. " +
                            "Project workflow DTO values to runtime-supported leaf types.");
                    }

                    var methodArgs = e.Arguments
                        .Skip(1)
                        .Select(argument => RenderWorkflowCollectionArgument(argument, p))
                        .ToArray();
                    var suffix = methodArgs.Length == 0
                        ? "()"
                        : $"({string.Join(", ", methodArgs)})";
                    var target = ParenthesizeWorkflowTarget(e.Arguments[0], sourceResult.Text);
                    return new VisitResult(
                        $"{target}.Children().{e.Method.Name}{GetRuntimeGenericMethodTypeArguments(e.Method)}{suffix}",
                        false,
                        false);
                }
            }

            if (e.Object != null && !IsRuntimeSupportedType(e.Object.Type))
            {
                throw new NotSupportedException(
                    $"Method '{e.Method.Name}' requires CLR type '{e.Object.Type.FullName}', whose assembly is not available to the C# runtime engine. " +
                    "Access workflow DTO values through their JSON properties instead.");
            }

            foreach (var genericType in e.Method.IsGenericMethod ? e.Method.GetGenericArguments() : Type.EmptyTypes)
                ThrowIfUnsupportedRuntimeType(genericType, $"Generic method '{e.Method.Name}'");

            if (e.Method.DeclaringType != typeof(WorkflowFunctions) &&
                e.Method.DeclaringType != null &&
                !IsRuntimeAssemblyAvailable(e.Method.DeclaringType))
            {
                throw new NotSupportedException(
                    $"Method '{e.Method.Name}' requires assembly '{e.Method.DeclaringType.Assembly.GetName().Name}', " +
                    "which is not available to the C# runtime engine.");
            }

            var args = e.Arguments.Select(arg => VisitExpression(arg, p)).ToArray();

            if (e.Method.DeclaringType == typeof(WorkflowFunctions))
            {
                var functionName = WorkflowFunctions.GetExpressionFunctionName(e.Method.Name);
                return new VisitResult($"{functionName}({string.Join(", ", args)})", false, false);
            }

            // JToken.ToObject<T>() and JToken.Value<T>() - pass-through
            if (e.Method.IsGenericMethod &&
                (e.Method.Name == "ToObject" || e.Method.Name == "Value") &&
                e.Object != null &&
                typeof(JToken).IsAssignableFrom(StripConvert(e.Object).Type))
            {
                var instance = VisitExpression(e.Object, p);
                var typeArg = GetTypeName(e.Method.GetGenericArguments()[0]);
                return new VisitResult($"{instance}.{e.Method.Name}<{typeArg}>({string.Join(", ", args)})", false, false);
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
                return new VisitResult($"{instance}.{e.Method.Name}<{typeArg}>({string.Join(", ", methodArgs)})", false, false);
            }

            // String methods - static
            if (e.Method.DeclaringType == typeof(string))
            {
                return new VisitResult(HandleStringMethod(e, args, p), false, false);
            }

            // Math methods
            if (e.Method.DeclaringType == typeof(Math))
            {
                return new VisitResult($"Math.{e.Method.Name}({string.Join(", ", args)})", false, false);
            }

            // ToString() on any type
            if (e.Method.Name == "ToString" && e.Arguments.Count == 0 && e.Object != null)
            {
                var instance = VisitExpression(e.Object, p);
                // Wrap numeric literals in parens so "1.ToString()" doesn't parse as "1."
                if (e.Object is ConstantExpression || IsNumericLiteral(instance))
                    return new VisitResult($"({instance}).ToString()", false, false);
                return new VisitResult($"{instance}.ToString()", false, false);
            }

            if (e.Object != null && e.Method.Name == "get_Item")
            {
                var instance = VisitExpression(e.Object, p);
                return new VisitResult($"{instance}[{string.Join(", ", args)}]", false, false);
            }

            // Instance methods (Contains, StartsWith, EndsWith, Substring, ToUpper, etc.)
            if (e.Object != null)
            {
                var instance = VisitExpression(e.Object, p);
                return new VisitResult($"{instance}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}({string.Join(", ", args)})", false, false);
            }

            // Extension methods (LINQ: Max(), etc.)
            if (e.Method.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false))
            {
                var target = args[0];
                var remainingArgs = args.Skip(1).ToArray();
                if (remainingArgs.Length > 0)
                    return new VisitResult($"{target}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}({string.Join(", ", remainingArgs)})", false, false);
                return new VisitResult($"{target}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}()", false, false);
            }

            // Static methods on other types
            if (e.Method.IsStatic && e.Method.DeclaringType != null)
            {
                var typeName = GetTypeName(e.Method.DeclaringType);
                return new VisitResult($"{typeName}.{e.Method.Name}{GetGenericMethodTypeArguments(e.Method)}({string.Join(", ", args)})", false, false);
            }

            throw new NotSupportedException($"Method {e.Method.DeclaringType?.Name}.{e.Method.Name} not supported.");
        }

        private string RenderWorkflowCollectionArgument(Expression expression, object p)
        {
            var lambda = StripQuote(expression) as LambdaExpression;
            if (lambda == null)
                return VisitExpression(expression, p);

            var workflowDataParameters = (p as VisitContext)?.WorkflowDataParameters
                ?? Enumerable.Empty<ParameterExpression>();
            var context = new VisitContext(workflowDataParameters.Concat(lambda.Parameters));
            return Visit(lambda, context);
        }

        private static Expression StripQuote(Expression expression)
        {
            while (expression is UnaryExpression unary && unary.NodeType == ExpressionType.Quote)
                expression = unary.Operand;

            return expression;
        }

        private static bool TryGetEnumerableElementType(Type type, out Type elementType)
        {
            if (type.IsArray)
            {
                elementType = type.GetElementType();
                return true;
            }

            var enumerableType = type
                .GetInterfaces()
                .Prepend(type)
                .FirstOrDefault(candidate =>
                    candidate.IsGenericType &&
                    candidate.GetGenericTypeDefinition() == typeof(IEnumerable<>));
            elementType = enumerableType?.GetGenericArguments()[0];
            return elementType != null;
        }

        private static string GetRuntimeGenericMethodTypeArguments(MethodInfo method)
        {
            if (!method.IsGenericMethod)
                return string.Empty;

            var genericTypes = method.GetGenericArguments();
            return genericTypes.All(IsRuntimeSupportedType)
                ? $"<{string.Join(", ", genericTypes.Select(GetTypeName))}>"
                : string.Empty;
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
            isSerializedArg = NeedsJsonSerialization(expression);

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
                ThrowIfUnsupportedRuntimeType(e.Type, "A constructor");
                var typeArgs = e.Type.GetGenericArguments();
                return $"new Dictionary<{GetTypeName(typeArgs[0])}, {GetTypeName(typeArgs[1])}>";
            }

            // Regular constructors
            ThrowIfUnsupportedRuntimeType(e.Type, "A constructor");
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
            ThrowIfUnsupportedRuntimeType(e.Type, "An object initializer");
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
            ThrowIfUnsupportedRuntimeType(e.Type, "A default expression");
            return $"default({GetTypeName(e.Type)})";
        }

        public override string Visit(TypeBinaryExpression e, object p)
        {
            ThrowIfUnsupportedRuntimeType(e.TypeOperand, "A type test");
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
                BinaryExpression binary => VisitBinaryTagged(binary, p),
                UnaryExpression unary => new VisitResult(Visit(unary, p), false, false),
                ConditionalExpression conditional => VisitConditionalTagged(conditional, p),
                ConstantExpression constant => new VisitResult(Visit(constant, p), false, false),
                DefaultExpression defaultExpression => new VisitResult(Visit(defaultExpression, p), false, false),
                IndexExpression index => new VisitResult(Visit(index, p), false, false),
                InvocationExpression invocation => new VisitResult(Visit(invocation, p), false, false),
                LambdaExpression lambda => new VisitResult(Visit(lambda, p), false, false),
                ListInitExpression listInit => new VisitResult(Visit(listInit, p), false, false),
                MemberExpression member => VisitMemberTagged(member, p),
                MemberInitExpression memberInit => new VisitResult(Visit(memberInit, p), false, false),
                MethodCallExpression methodCall => VisitMethodCallTagged(methodCall, p),
                NewArrayExpression newArray => new VisitResult(Visit(newArray, p), false, false),
                NewExpression @new => new VisitResult(Visit(@new, p), false, false),
                ParameterExpression parameter => new VisitResult(
                    Visit(parameter, p),
                    (p as VisitContext)?.WorkflowDataParameters.Contains(parameter) == true,
                    false),
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
            if (type == typeof(sbyte)) return "sbyte";
            if (type == typeof(byte)) return "byte";
            if (type == typeof(short)) return "short";
            if (type == typeof(ushort)) return "ushort";
            if (type == typeof(int)) return "int";
            if (type == typeof(uint)) return "uint";
            if (type == typeof(long)) return "long";
            if (type == typeof(ulong)) return "ulong";
            if (type == typeof(double)) return "double";
            if (type == typeof(float)) return "float";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(object)) return "object";
            if (type == typeof(char)) return "char";
            if (type == typeof(void)) return "void";

            if (type.IsArray)
                return $"{GetTypeName(type.GetElementType())}[{new string(',', type.GetArrayRank() - 1)}]";

            var nullableType = Nullable.GetUnderlyingType(type);
            if (nullableType != null)
                return $"{GetTypeName(nullableType)}?";

            var typeChain = new Stack<Type>();
            for (var current = type; current != null; current = current.DeclaringType)
                typeChain.Push(current);

            var typeArguments = type.IsGenericType
                ? type.GetGenericArguments()
                : Type.EmptyTypes;
            var typeArgumentIndex = 0;
            var segments = new List<string>();

            while (typeChain.Count > 0)
            {
                var current = typeChain.Pop();
                var tickIndex = current.Name.IndexOf('`');
                var segment = tickIndex >= 0 ? current.Name.Substring(0, tickIndex) : current.Name;
                var genericArgumentCount = tickIndex >= 0
                    ? int.Parse(current.Name.Substring(tickIndex + 1), CultureInfo.InvariantCulture)
                    : 0;

                if (genericArgumentCount > 0)
                {
                    var arguments = typeArguments
                        .Skip(typeArgumentIndex)
                        .Take(genericArgumentCount)
                        .Select(GetTypeName);
                    segment = $"{segment}<{string.Join(", ", arguments)}>";
                    typeArgumentIndex += genericArgumentCount;
                }

                segments.Add(segment);
            }

            var name = string.Join(".", segments);
            if (type.Namespace == "System" ||
                (type.Namespace != null && type.Namespace.StartsWith("System.", StringComparison.Ordinal)))
                return name;

            return string.IsNullOrEmpty(type.Namespace)
                ? $"global::{name}"
                : $"global::{type.Namespace}.{name}";
        }
    }
}

// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Compiles expression-tree authoring lambdas into workflow expression descriptors.
    /// </summary>
    internal static class WorkflowExpressionCompiler
    {
        private static readonly IReadOnlyDictionary<string, string> WorkflowFunctionNames =
            new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["ToJson"] = "json",
                ["Actions"] = "actions",
                ["Trigger"] = "trigger",
                ["ListCallbackUrl"] = "listCallbackUrl",
                ["AppSetting"] = "appsetting",
                ["Action"] = "action",
                ["CurrentRequest"] = "currentRequest",
                ["Binary"] = "binary",
                ["Base64ToBinary"] = "base64ToBinary",
                ["DataUriToBinary"] = "dataUriToBinary",
                ["MultipartBody"] = "multipartBody",
                ["FormDataValue"] = "formDataValue",
                ["FormDataMultiValues"] = "formDataMultiValues",
                ["TriggerMultipartBody"] = "triggerMultipartBody",
                ["TriggerFormDataValue"] = "triggerFormDataValue",
                ["TriggerFormDataMultiValues"] = "triggerFormDataMultiValues",
            };

        internal static WorkflowExpression<T> Compile<T>(Expression<Func<T>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            if (!IsAnonymous(typeof(T)))
                ValidateRuntimeType(typeof(T));

            if (TryReadValue(expression.Body, out var literal) &&
                (literal == null || CanUseWorkflowLiteral(typeof(T))))
            {
                return WorkflowExpression.Literal((T)literal);
            }

            var writer = new Writer();
            var source = writer.WriteRoot(expression.Body);
            var segments = new List<string>();
            var orderedBindings = new List<WorkflowExpressionBinding>();
            var cursor = 0;
            foreach (Match match in Regex.Matches(source, @"__binding(?<index>\d+)"))
            {
                segments.Add(source.Substring(cursor, match.Index - cursor));
                orderedBindings.Add(writer.Bindings[int.Parse(match.Groups["index"].Value, CultureInfo.InvariantCulture)]);
                cursor = match.Index + match.Length;
            }
            segments.Add(source.Substring(cursor));
            return WorkflowExpression.Create<T>(segments.ToArray(), orderedBindings.ToArray());
        }

        private static bool CanUseWorkflowLiteral(Type type) =>
            type.IsPrimitive && !type.IsEnum || type == typeof(string) || type == typeof(decimal);

        private static string Quote(string text) => JsonConvert.ToString(text);

        private static bool Implements(Type type, Type definition) =>
            (type.IsGenericType && type.GetGenericTypeDefinition() == definition) ||
            type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == definition);

        private static bool IsAnonymous(Type type) =>
            type.IsDefined(typeof(CompilerGeneratedAttribute), false) && type.Name.Contains("AnonymousType");

        // Only read stored values, never invoke a captured lambda, arbitrary getter or method.
        private static bool TryReadValue(Expression expression, out object value)
        {
            value = null;
            if (expression is ConstantExpression constant)
            {
                value = constant.Value;
                return true;
            }

            if (expression is MemberExpression member && member.Member is FieldInfo field &&
                (field.IsLiteral || (member.Expression != null && TryReadValue(member.Expression, out value))))
            {
                value = field.IsLiteral ? field.GetRawConstantValue() : field.GetValue(value);
                if (field.FieldType.IsEnum && !(value is Enum))
                    value = Enum.ToObject(field.FieldType, value);
                return true;
            }

            if (expression is MemberExpression propertyMember &&
                propertyMember.Member is PropertyInfo property &&
                propertyMember.Expression != null &&
                TryReadValue(propertyMember.Expression, out var instance) &&
                instance != null &&
                property.GetMethod?.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false) == true)
            {
                var backingField = property.DeclaringType.GetField(
                    "<" + property.Name + ">k__BackingField",
                    BindingFlags.Instance | BindingFlags.NonPublic);
                if (backingField?.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false) == true)
                {
                    value = backingField.GetValue(instance);
                    return true;
                }
            }

            value = null;
            return false;
        }

        private static void ValidateRuntimeType(Type type)
        {
            if (!IsRuntimeTypeAvailable(type))
                throw new NotSupportedException(
                    $"Runtime type '{type}' is unavailable. Use framework/SDK types or move custom code into a CustomCode action.");
        }

        private static bool IsRuntimeTypeAvailable(Type type)
        {
            if (type.IsArray)
                return IsRuntimeTypeAvailable(type.GetElementType());
            if (type.IsGenericParameter ||
                type.Namespace?.StartsWith("System.Threading.Tasks", StringComparison.Ordinal) == true)
                return false;

            var assembly = type.Assembly.GetName().Name;
            if (assembly is not ("System.Private.CoreLib" or "mscorlib" or "System.Runtime" or "netstandard" or
                "System.Linq" or "System.Collections" or "System.Net.Http" or "System.Net.Primitives" or
                "System.Private.Uri" or "System.Runtime.Numerics" or "Newtonsoft.Json" or "Microsoft.Azure.Workflows.Sdk"))
                return false;

            return !type.IsGenericType || type.GetGenericArguments().All(IsRuntimeTypeAvailable);
        }

        private static string TypeName(Type type)
        {
            ValidateRuntimeType(type);
            if (type == typeof(string)) return "string";
            if (type == typeof(object)) return "object";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(int)) return "int";
            if (type == typeof(long)) return "long";
            if (type == typeof(double)) return "double";
            if (type == typeof(float)) return "float";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(char)) return "char";
            if (type == typeof(byte)) return "byte";
            if (type == typeof(sbyte)) return "sbyte";
            if (type == typeof(short)) return "short";
            if (type == typeof(ushort)) return "ushort";
            if (type == typeof(uint)) return "uint";
            if (type == typeof(ulong)) return "ulong";
            if (type.IsArray) return TypeName(type.GetElementType()) + "[" + new string(',', type.GetArrayRank() - 1) + "]";
            if (Nullable.GetUnderlyingType(type) is Type underlying) return TypeName(underlying) + "?";
            if (type.IsNested)
            {
                var arguments = type.GetGenericArguments();
                var declaring = type.DeclaringType;
                var parentCount = declaring.GetGenericArguments().Length;
                if (declaring.IsGenericTypeDefinition)
                    declaring = declaring.MakeGenericType(arguments.Take(parentCount).ToArray());
                var nestedName = Identifier(type.Name.Split('`')[0]);
                var ownArguments = arguments.Skip(parentCount).ToArray();
                return TypeName(declaring) + "." + nestedName +
                    (ownArguments.Length == 0 ? "" : "<" + string.Join(", ", ownArguments.Select(TypeName)) + ">");
            }

            var name = Identifier(type.Name.Split('`')[0]);
            var prefix = string.IsNullOrEmpty(type.Namespace) ? "" : "global::" + type.Namespace + ".";
            return prefix + (type.IsGenericType ? name + "<" + string.Join(", ", type.GetGenericArguments().Select(TypeName)) + ">" : name);
        }

        private static string Identifier(string name)
        {
            if (string.IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[\p{L}_][\p{L}\p{Nd}_]*$"))
                throw new NotSupportedException($"Cannot emit C# identifier '{name}'.");
            return Keywords.Contains(name) ? "@" + name : name;
        }

        private static readonly HashSet<string> Keywords = new HashSet<string>(
            ("abstract as base bool break byte case catch char checked class const continue decimal default delegate " +
             "do double else enum event explicit extern false finally fixed float for foreach goto if implicit in int " +
             "interface internal is lock long namespace new null object operator out override params private protected " +
             "public readonly ref return sbyte sealed short sizeof stackalloc static string struct switch this throw " +
             "true try typeof uint ulong unchecked unsafe ushort using virtual void volatile while").Split(' '),
            StringComparer.Ordinal);

        private sealed class SourceFragment
        {
            public string Source { get; }

            public SourceFragment(string source)
            {
                this.Source = source;
            }

            public string Parenthesized => "(" + this.Source + ")";
        }

        private sealed class Writer
        {
            private readonly HashSet<ParameterExpression> parameters = new HashSet<ParameterExpression>();
            private readonly List<WorkflowExpressionBinding> bindings = new List<WorkflowExpressionBinding>();

            internal IReadOnlyList<WorkflowExpressionBinding> Bindings => this.bindings;
            internal string WriteRoot(Expression expression) => this.Typed(expression).Source;

            private SourceFragment BindRaw(WorkflowExpressionBinding binding)
            {
                var placeholder = "__binding" + this.bindings.Count.ToString(CultureInfo.InvariantCulture);
                this.bindings.Add(binding);
                return new SourceFragment(placeholder);
            }

            public SourceFragment Write(Expression expression)
            {
                if (this.TryCustomWorkflowPath(expression, out var customPath))
                {
                    return customPath;
                }

                if (this.TryWorkflowTokenSource(expression, out var workflowSource))
                {
                    return ReadWorkflowValue(workflowSource, expression.Type);
                }

                if (TryReadValue(expression, out var value))
                {
                    return this.Literal(value, expression.Type);
                }

                switch (expression)
                {
                    case MemberExpression member: return this.Member(member);
                    case BinaryExpression binary: return this.Binary(binary);
                    case UnaryExpression unary: return this.Unary(unary);
                    case MethodCallExpression call: return this.Call(call);
                    case ConditionalExpression conditional:
                        return new SourceFragment(
                            this.Typed(conditional.Test).Parenthesized + " ? " +
                            this.Typed(conditional.IfTrue).Parenthesized + " : " +
                            this.Typed(conditional.IfFalse).Parenthesized);
                    case NewArrayExpression array:
                        if (array.NodeType == ExpressionType.NewArrayBounds)
                        {
                            return new SourceFragment("new " + TypeName(array.Type.GetElementType()) + "[" +
                                string.Join(", ", array.Expressions.Select(e => this.Typed(e).Source)) + "]");
                        }

                        var elements = array.Expressions.Select(e => this.Typed(e).Source).ToArray();
                        var inferred = elements.Any(e => e != "null") && array.Type.GetElementType() != typeof(object) &&
                            array.Expressions.All(e => e.Type == array.Type.GetElementType());
                        return new SourceFragment((inferred ? "new[]" : "new " + TypeName(array.Type)) +
                            " { " + string.Join(", ", elements) + " }");
                    case NewExpression creation: return this.New(creation);
                    case MemberInitExpression initializer:
                        return new SourceFragment((initializer.NewExpression.Arguments.Count == 0 ?
                            "new " + TypeName(initializer.Type) : this.New(initializer.NewExpression).Source) +
                            " { " + string.Join(", ", initializer.Bindings.Select(this.Binding)) + " }");
                    case ListInitExpression list:
                        return new SourceFragment(this.New(list.NewExpression).Source + " { " +
                            string.Join(", ", list.Initializers.Select(i =>
                                i.Arguments.Count == 1 ? this.Typed(i.Arguments[0]).Source :
                                "{ " + string.Join(", ", i.Arguments.Select(a => this.Typed(a).Source)) + " }")) + " }");
                    case ParameterExpression parameter when this.parameters.Contains(parameter):
                        return new SourceFragment(Identifier(parameter.Name));
                    case LambdaExpression lambda:
                        foreach (var parameter in lambda.Parameters) this.parameters.Add(parameter);
                        var body = this.Typed(lambda.Body);
                        foreach (var parameter in lambda.Parameters) this.parameters.Remove(parameter);
                        return new SourceFragment("(" + string.Join(", ", lambda.Parameters.Select(p => TypeName(p.Type) + " " + Identifier(p.Name))) +
                            ") => " + body.Source);
                    case IndexExpression index:
                        return new SourceFragment(this.Write(index.Object).Parenthesized + "[" +
                            string.Join(", ", index.Arguments.Select(a => this.Typed(a).Source)) + "]");
                    case DefaultExpression defaultExpression:
                        return new SourceFragment("default(" + TypeName(defaultExpression.Type) + ")");
                    case TypeBinaryExpression typeTest when typeTest.NodeType == ExpressionType.TypeIs:
                        return new SourceFragment(
                            this.Write(typeTest.Expression).Parenthesized + " is " + TypeName(typeTest.TypeOperand));
                    default:
                        throw new NotSupportedException($"C# serialization does not support {expression.NodeType}: {expression}");
                }
            }

            private SourceFragment Typed(Expression expression)
                => this.Write(expression);

            private SourceFragment Literal(object value, Type type)
            {
                if (value is ForEachItemToken item)
                    return this.BindRaw(WorkflowExpressionBinding.Item(item));
                if (value is Array or IDictionary or JToken)
                    throw new NotSupportedException("Capture immutable scalar values, not mutable objects or collections.");
                if (value == null) return Cast(type, new SourceFragment("null"));

                if (Nullable.GetUnderlyingType(type) is Type underlying)
                    return Cast(type, this.Literal(value, underlying));

                var runtimeType = value.GetType();
                if (runtimeType != type && type.IsAssignableFrom(runtimeType))
                    return Cast(type, this.Literal(value, runtimeType));

                if (value is string text) return new SourceFragment(Quote(text));
                if (value is bool flag) return new SourceFragment(flag ? "true" : "false");
                if (value is char character)
                {
                    var escaped = Quote(character.ToString());
                    return new SourceFragment("'" + escaped.Substring(1, escaped.Length - 2).Replace("'", "\\'").Replace("\\\"", "\"") + "'");
                }

                if (value is Enum enumeration)
                {
                    var name = Enum.GetName(value.GetType(), value);
                    if (name != null)
                        return new SourceFragment(TypeName(value.GetType()) + "." + name);

                    var enumUnderlyingType = Enum.GetUnderlyingType(value.GetType());
                    var enumValue = System.Convert.ChangeType(value, enumUnderlyingType, CultureInfo.InvariantCulture);
                    return Cast(value.GetType(), this.Literal(enumValue, enumUnderlyingType));
                }

                if (value is DateTime date)
                {
                    return new SourceFragment(
                        $"new global::System.DateTime({date.Ticks}L, global::System.DateTimeKind.{date.Kind})");
                }

                if (value is DateTimeOffset offset)
                    return new SourceFragment(
                        $"new global::System.DateTimeOffset({offset.Ticks}L, new global::System.TimeSpan({offset.Offset.Ticks}L))");
                if (value is TimeSpan span)
                    return new SourceFragment($"new global::System.TimeSpan({span.Ticks}L)");
                if (value is Guid guid)
                    return new SourceFragment("new global::System.Guid(" + Quote(guid.ToString("D")) + ")");
                if (value is Uri uri)
                    return new SourceFragment(
                        "new global::System.Uri(" + Quote(uri.OriginalString) + ", global::System.UriKind.RelativeOrAbsolute)");
                if (value is HttpMethod method)
                    return new SourceFragment(
                        "new global::System.Net.Http.HttpMethod(" + Quote(method.Method) + ")");

                if (value is double number)
                {
                    if (double.IsNaN(number)) return new SourceFragment("double.NaN");
                    if (double.IsPositiveInfinity(number)) return new SourceFragment("double.PositiveInfinity");
                    if (double.IsNegativeInfinity(number)) return new SourceFragment("double.NegativeInfinity");
                    if (number == 0 && BitConverter.DoubleToInt64Bits(number) < 0) return new SourceFragment("-0.0d");
                    return new SourceFragment(number.ToString("R", CultureInfo.InvariantCulture) + "d");
                }

                if (value is float single)
                {
                    if (float.IsNaN(single)) return new SourceFragment("float.NaN");
                    if (float.IsPositiveInfinity(single)) return new SourceFragment("float.PositiveInfinity");
                    if (float.IsNegativeInfinity(single)) return new SourceFragment("float.NegativeInfinity");
                    if (single == 0 && BitConverter.ToInt32(BitConverter.GetBytes(single), 0) < 0)
                        return new SourceFragment("-0.0f");
                    return new SourceFragment(single.ToString("R", CultureInfo.InvariantCulture) + "f");
                }

                if (value is decimal || value is long || value is ulong || value is uint ||
                    value is int || value is short || value is ushort || value is byte || value is sbyte)
                {
                    var suffix = value is decimal ? "m" : value is long ? "L" : value is ulong ? "UL" : value is uint ? "U" : "";
                    var source = System.Convert.ToString(value, CultureInfo.InvariantCulture) + suffix;
                    var literal = new SourceFragment(source);
                    return value is byte or sbyte or short or ushort
                        ? Cast(value.GetType(), literal)
                        : literal;
                }

                throw new NotSupportedException($"Cannot serialize captured value of type {value.GetType()}. Construct the object inside the lambda instead.");
            }

            private static SourceFragment Cast(Type type, SourceFragment value) =>
                new SourceFragment("(" + TypeName(type) + ")" + value.Parenthesized);

            private static SourceFragment ReadWorkflowValue(SourceFragment source, Type type)
            {
                if (typeof(JToken).IsAssignableFrom(type))
                    return source;

                ValidateRuntimeType(type);
                return new SourceFragment(source.Parenthesized + ".ToObject<" + TypeName(type) + ">()");
            }

            private SourceFragment Member(MemberExpression member)
            {
                if (member.Expression == null)
                {
                    if (member.Member.DeclaringType == typeof(HttpMethod) && member.Member is PropertyInfo httpProperty)
                        return this.Literal(httpProperty.GetValue(null), typeof(HttpMethod));
                    return new SourceFragment(TypeName(member.Member.DeclaringType) + "." + Identifier(member.Member.Name));
                }

                return new SourceFragment(
                    this.Receiver(member.Expression).Parenthesized + "." + Identifier(member.Member.Name));
            }

            private bool TryCustomWorkflowPath(Expression expression, out SourceFragment code)
            {
                code = null;
                var properties = new List<PropertyInfo>();
                if (!this.TryCollectCustomWorkflowPath(expression, properties, out var root) ||
                    properties.Count == 0)
                {
                    return false;
                }

                code = root;
                foreach (var property in properties)
                {
                    var jsonName = property.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? property.Name;
                    code = new SourceFragment(code.Parenthesized + "[" + Quote(jsonName) + "]");
                }

                code = ReadWorkflowValue(code, expression.Type);
                return true;
            }

            private bool TryCollectCustomWorkflowPath(
                Expression expression,
                List<PropertyInfo> properties,
                out SourceFragment root)
            {
                if (expression is MemberExpression workflowMember &&
                    TryCreateWorkflowBinding(workflowMember, out var binding))
                {
                    root = this.BindRaw(binding);
                    return true;
                }

                if (expression is MethodCallExpression call &&
                    this.TryWriteWorkflowFunction(call, out root, out var returnsToken) &&
                    returnsToken)
                    return true;

                if (expression is not MemberExpression member ||
                    member.Member is not PropertyInfo property ||
                    IsRuntimeTypeAvailable(property.DeclaringType) ||
                    !IsStoredDtoProperty(property) ||
                    !this.TryCollectCustomWorkflowPath(member.Expression, properties, out root))
                {
                    root = null;
                    return false;
                }

                properties.Add(property);
                return true;
            }

            private static bool IsStoredDtoProperty(PropertyInfo property) =>
                property.GetMethod?.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false) == true;

            private bool TryWorkflowTokenSource(Expression expression, out SourceFragment code)
            {
                if (expression is MemberExpression member && TryCreateWorkflowBinding(member, out var binding))
                {
                    code = this.BindRaw(binding);
                    return true;
                }

                if (expression is MethodCallExpression call &&
                    TryWriteWorkflowFunction(call, out code, out var returnsToken) &&
                    returnsToken)
                {
                    return true;
                }

                code = null;
                return false;
            }

            private static bool TryCreateWorkflowBinding(
                MemberExpression member,
                out WorkflowExpressionBinding binding)
            {
                binding = null;
                if (member.Expression != null && TryReadValue(member.Expression, out var instance) && instance != null)
                {
                    var type = instance.GetType();
                    if (Implements(type, typeof(IOutputWorkflowTrigger<>)) && member.Member.Name == "TriggerOutput")
                        binding = WorkflowExpressionBinding.Trigger((IWorkflowTrigger)instance, body: false);
                    else if (Implements(type, typeof(IBodyWorkflowTrigger<>)) && member.Member.Name == "TriggerBody")
                        binding = WorkflowExpressionBinding.Trigger((IWorkflowTrigger)instance, body: true);
                    else if (Implements(type, typeof(IOutputWorkflowAction<>)) && member.Member.Name == "Output")
                        binding = WorkflowExpressionBinding.Output((IWorkflowAction)instance);
                    else if (Implements(type, typeof(IBodyWorkflowAction<>)) && member.Member.Name == "Body")
                        binding = WorkflowExpressionBinding.Body((IWorkflowAction)instance);
                    else if (instance is IVariableWorkflowAction variable && member.Member.Name == "Value")
                        binding = WorkflowExpressionBinding.Variable(variable);
                }

                if (binding != null)
                    return true;

                if (member.Expression is MemberExpression
                    {
                        Member.Name: "Parameters",
                        Expression: not null,
                    } parameters &&
                    TryReadValue(parameters.Expression, out var context) &&
                    context != null &&
                    Implements(context.GetType(), typeof(IAgentToolContext<>)))
                {
                    var jsonName = member.Member.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ??
                        member.Member.Name;
                    binding = WorkflowExpressionBinding.AgentParameter(context, jsonName);
                    return true;
                }

                return false;
            }

            private SourceFragment Binary(BinaryExpression binary)
            {
                if (binary.NodeType == ExpressionType.ArrayIndex)
                    return new SourceFragment(
                        this.Typed(binary.Left).Parenthesized + "[" + this.Typed(binary.Right).Source + "]");
                if (binary.Conversion != null)
                    throw new NotSupportedException("Coalesce conversion lambdas are not supported.");

                var op = Operator(binary.NodeType);
                var left = this.Typed(binary.Left);
                var right = this.Typed(binary.Right);
                var source = left.Parenthesized + " " + op + " " + right.Parenthesized;
                if (binary.NodeType == ExpressionType.AddChecked || binary.NodeType == ExpressionType.SubtractChecked ||
                    binary.NodeType == ExpressionType.MultiplyChecked)
                    return new SourceFragment("checked(" + source + ")");
                return new SourceFragment(source);
            }

            private static string Operator(ExpressionType type)
            {
                switch (type)
                {
                    case ExpressionType.Coalesce: return "??";
                    case ExpressionType.OrElse: return "||";
                    case ExpressionType.AndAlso: return "&&";
                    case ExpressionType.Or: return "|";
                    case ExpressionType.ExclusiveOr: return "^";
                    case ExpressionType.And: return "&";
                    case ExpressionType.Equal: return "==";
                    case ExpressionType.NotEqual: return "!=";
                    case ExpressionType.LessThan: return "<";
                    case ExpressionType.LessThanOrEqual: return "<=";
                    case ExpressionType.GreaterThan: return ">";
                    case ExpressionType.GreaterThanOrEqual: return ">=";
                    case ExpressionType.LeftShift: return "<<";
                    case ExpressionType.RightShift: return ">>";
                    case ExpressionType.Add:
                    case ExpressionType.AddChecked: return "+";
                    case ExpressionType.Subtract:
                    case ExpressionType.SubtractChecked: return "-";
                    case ExpressionType.Multiply:
                    case ExpressionType.MultiplyChecked: return "*";
                    case ExpressionType.Divide: return "/";
                    case ExpressionType.Modulo: return "%";
                    default: throw new NotSupportedException($"Unsupported C# binary operator: {type}");
                }
            }

            private SourceFragment Unary(UnaryExpression unary)
            {
                if (unary.NodeType == ExpressionType.Quote) return this.Write(unary.Operand);
                var operand = this.Typed(unary.Operand);
                switch (unary.NodeType)
                {
                    case ExpressionType.Convert:
                    case ExpressionType.ConvertChecked:
                        var cast = new SourceFragment("(" + TypeName(unary.Type) + ")" + operand.Parenthesized);
                        return unary.NodeType == ExpressionType.ConvertChecked ? new SourceFragment("checked(" + cast.Source + ")") : cast;
                    case ExpressionType.Negate: return new SourceFragment("-" + operand.Parenthesized);
                    case ExpressionType.NegateChecked: return new SourceFragment("checked(-" + operand.Parenthesized + ")");
                    case ExpressionType.UnaryPlus: return new SourceFragment("+" + operand.Parenthesized);
                    case ExpressionType.Not:
                        return new SourceFragment((unary.Type == typeof(bool) || Nullable.GetUnderlyingType(unary.Type) == typeof(bool) ?
                            "!" : "~") + operand.Parenthesized);
                    case ExpressionType.TypeAs:
                        return new SourceFragment(operand.Parenthesized + " as " + TypeName(unary.Type));
                    default: throw new NotSupportedException($"Unsupported C# unary operator: {unary.NodeType}");
                }
            }

            private SourceFragment Call(MethodCallExpression call)
            {
                ValidateRuntimeType(call.Method.DeclaringType);
                if (!call.Method.IsPublic)
                    throw new NotSupportedException($"Expression runtime member must be public: {call.Method}");

                if (TryWriteWorkflowFunction(call, out var workflowFunction, out var returnsToken))
                    return returnsToken
                        ? ReadWorkflowValue(workflowFunction, call.Type)
                        : workflowFunction;

                if (call.Method.DeclaringType == typeof(string) && call.Method.Name == "Format")
                    return this.Format(call);

                if (call.Method.Name == "get_Item" && call.Object != null)
                {
                    var indexed = this.Typed(call.Object);
                    return new SourceFragment(
                        indexed.Parenthesized + "[" +
                        string.Join(", ", call.Arguments.Select(a => this.Typed(a).Source)) + "]");
                }

                var extension = call.Method.IsDefined(typeof(ExtensionAttribute), false);
                var targetExpression = extension ? call.Arguments[0] : call.Object;
                var target = targetExpression == null
                    ? TypeName(call.Method.DeclaringType)
                    : this.Receiver(targetExpression).Parenthesized;

                if (call.Method.GetParameters().Any(p => p.ParameterType.IsByRef))
                    throw new NotSupportedException($"Calls with ref/out arguments are not supported: {call.Method}");
                var arguments = call.Arguments.Skip(extension ? 1 : 0).Select(a => this.Typed(a).Source);
                var inferGenerics = call.Method.IsGenericMethod && call.Method.DeclaringType == typeof(Enumerable) &&
                    call.Method.GetGenericMethodDefinition().GetGenericArguments().All(parameter =>
                        call.Method.GetGenericMethodDefinition().GetParameters().Any(p => ContainsType(p.ParameterType, parameter)));
                var generic = call.Method.IsGenericMethod && !inferGenerics ?
                    "<" + string.Join(", ", call.Method.GetGenericArguments().Select(TypeName)) + ">" : "";
                return new SourceFragment(
                    target + "." + Identifier(call.Method.Name) + generic + "(" + string.Join(", ", arguments) + ")");
            }

            private bool TryWriteWorkflowFunction(
                MethodCallExpression call,
                out SourceFragment code,
                out bool returnsToken)
            {
                code = null;
                returnsToken = false;
                if (call.Method.DeclaringType != typeof(WorkflowFunctions))
                    return false;
                if (!WorkflowFunctionNames.TryGetValue(call.Method.Name, out var function))
                    throw new NotSupportedException($"Unsupported workflow function: {call.Method.Name}");

                code = new SourceFragment(
                    function + "(" +
                    string.Join(", ", call.Arguments.Select(argument => this.Typed(argument).Source)) +
                    ")");
                returnsToken = call.Method.ReturnType != typeof(string) &&
                    call.Method.ReturnType != typeof(bool);
                return true;
            }

            private static bool ContainsType(Type type, Type parameter) =>
                type == parameter || (type.HasElementType && ContainsType(type.GetElementType(), parameter)) ||
                (type.IsGenericType && type.GetGenericArguments().Any(t => ContainsType(t, parameter)));

            private SourceFragment Receiver(Expression expression)
            {
                var code = this.Typed(expression);
                return code.Source == "null" ? new SourceFragment("((" + TypeName(expression.Type) + ")null)") : code;
            }

            private SourceFragment Format(MethodCallExpression call)
            {
                var formatIndex = call.Arguments[0].Type == typeof(string) ? 0 : 1;
                if (!(call.Arguments[formatIndex] is ConstantExpression constant) || !(constant.Value is string format))
                    return this.PlainFormat(call);
                var values = call.Arguments.Skip(formatIndex + 1).ToArray();
                if (values.Length == 1 && values[0] is NewArrayExpression array) values = array.Expressions.ToArray();
                values = values.Select(Unbox).ToArray();
                var codes = values.Select(this.Write).ToArray();
                if (formatIndex != 0 || format.Contains("{{") || format.Contains("}}") ||
                    Regex.Replace(format, @"\{\d+\}", "").IndexOfAny(new[] { '{', '}' }) >= 0)
                    return this.PlainFormat(call);
                if (format == "{0}" && codes.Length == 1)
                {
                    if (values[0] is NewExpression creation && !IsAnonymous(creation.Type) || values[0] is MemberInitExpression)
                        return new SourceFragment("JsonConvert.SerializeObject(" + codes[0].Source + ")");
                    return codes[0];
                }

                return this.PlainFormat(call);
            }

            private static Expression Unbox(Expression expression) =>
                expression is UnaryExpression unary && unary.NodeType == ExpressionType.Convert && unary.Type == typeof(object) ?
                    unary.Operand : expression;

            private SourceFragment PlainFormat(MethodCallExpression call)
            {
                var arguments = call.Arguments.Select(argument =>
                {
                    if (argument is NewArrayExpression array && array.Type == typeof(object[]))
                        return "new object[] { " + string.Join(", ", array.Expressions.Select(e => this.Write(Unbox(e)).Source)) + " }";
                    return this.Write(Unbox(argument)).Source;
                });
                return new SourceFragment("string.Format(" + string.Join(", ", arguments) + ")");
            }

            private SourceFragment New(NewExpression creation)
            {
                if (IsAnonymous(creation.Type))
                {
                    return new SourceFragment("new { " + string.Join(", ", creation.Arguments.Select((argument, index) =>
                    {
                        var value = this.Typed(argument);
                        var source = value.Source == "null" ? "(" + TypeName(argument.Type) + ")null" : value.Source;
                        return Identifier(creation.Members[index].Name) + " = " + source;
                    })) + " }");
                }

                return new SourceFragment("new " + TypeName(creation.Type) + "(" +
                    string.Join(", ", creation.Arguments.Select(a => this.Typed(a).Source)) + ")");
            }

            private string Binding(MemberBinding binding)
            {
                if (!(binding is MemberAssignment assignment))
                    throw new NotSupportedException($"Unsupported object initializer binding: {binding.BindingType}");
                return Identifier(binding.Member.Name) + " = " + this.Typed(assignment.Expression).Source;
            }
        }
    }
}

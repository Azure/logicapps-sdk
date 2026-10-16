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
    /// Reconstructs supported LINQ expression-tree nodes as late-bound C# source programs.
    /// </summary>
    internal sealed class WorkflowExpressionVisitor : IExpressionVisitor<SourceProgram>
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

        internal static bool CanUseWorkflowLiteral(Type type) =>
            type.IsPrimitive && !type.IsEnum || type == typeof(string) || type == typeof(decimal);

        private static string Quote(string text) => JsonConvert.ToString(text);

        private static bool Implements(Type type, Type definition) =>
            (type.IsGenericType && type.GetGenericTypeDefinition() == definition) ||
            type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == definition);

        internal static bool IsAnonymous(Type type) =>
            type.IsDefined(typeof(CompilerGeneratedAttribute), false) && type.Name.Contains("AnonymousType");

        // Only read stored values, never invoke a captured lambda, arbitrary getter or method.
        internal static bool TryReadValue(Expression expression, out object value)
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

        internal static void ValidateRuntimeType(Type type)
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

        private readonly HashSet<ParameterExpression> parameters = new HashSet<ParameterExpression>();

        private SourceProgram BindRaw(WorkflowExpressionBinding binding) =>
            SourceProgram.Binding(binding);

        internal SourceProgram Visit(Expression expression)
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

            return expression switch
            {
                BinaryExpression node => this.Visit(node),
                UnaryExpression node => this.Visit(node),
                ConstantExpression node => this.Visit(node),
                ParameterExpression node => this.Visit(node),
                MethodCallExpression node => this.Visit(node),
                ConditionalExpression node => this.Visit(node),
                InvocationExpression node => this.Visit(node),
                LambdaExpression node => this.Visit(node),
                ListInitExpression node => this.Visit(node),
                MemberExpression node => this.Visit(node),
                MemberInitExpression node => this.Visit(node),
                NewExpression node => this.Visit(node),
                NewArrayExpression node => this.Visit(node),
                TypeBinaryExpression node => this.Visit(node),
                BlockExpression node => this.Visit(node),
                DebugInfoExpression node => this.Visit(node),
                DefaultExpression node => this.Visit(node),
                DynamicExpression node => this.Visit(node),
                GotoExpression node => this.Visit(node),
                IndexExpression node => this.Visit(node),
                LabelExpression node => this.Visit(node),
                RuntimeVariablesExpression node => this.Visit(node),
                SwitchExpression node => this.Visit(node),
                TryExpression node => this.Visit(node),
                _ => throw Unsupported(expression),
            };
        }

        private SourceProgram Typed(Expression expression)
            => this.Visit(expression);

        public SourceProgram Visit(BinaryExpression expression) => this.Binary(expression);

        public SourceProgram Visit(UnaryExpression expression) => this.Unary(expression);

        public SourceProgram Visit(ConstantExpression expression) =>
            this.Literal(expression.Value, expression.Type);

        public SourceProgram Visit(ParameterExpression expression) =>
            this.parameters.Contains(expression)
                ? SourceProgram.Text(Identifier(expression.Name))
                : throw Unsupported(expression);

        public SourceProgram Visit(MethodCallExpression expression) => this.Call(expression);

        public SourceProgram Visit(ConditionalExpression expression) =>
            SourceProgram.Concat(
                this.Typed(expression.Test).Parenthesized(),
                SourceProgram.Text(" ? "),
                this.Typed(expression.IfTrue).Parenthesized(),
                SourceProgram.Text(" : "),
                this.Typed(expression.IfFalse).Parenthesized());

        public SourceProgram Visit(InvocationExpression expression) => throw Unsupported(expression);

        public SourceProgram Visit(LambdaExpression expression)
        {
            foreach (var parameter in expression.Parameters)
                this.parameters.Add(parameter);

            try
            {
                return SourceProgram.Concat(
                    SourceProgram.Text(
                        string.Join(", ", expression.Parameters.Select(
                            parameter => TypeName(parameter.Type) + " " + Identifier(parameter.Name))))
                        .Parenthesized(),
                    SourceProgram.Text(" => "),
                    this.Typed(expression.Body));
            }
            finally
            {
                foreach (var parameter in expression.Parameters)
                    this.parameters.Remove(parameter);
            }
        }

        public SourceProgram Visit(ListInitExpression expression) =>
            SourceProgram.Concat(
                this.New(expression.NewExpression),
                SourceProgram.Text(" "),
                SourceProgram.CommaSeparated(expression.Initializers.Select(initializer =>
                    initializer.Arguments.Count == 1
                        ? this.Typed(initializer.Arguments[0])
                        : SourceProgram.CommaSeparated(initializer.Arguments.Select(this.Typed)).Braced()))
                    .Braced());

        public SourceProgram Visit(MemberExpression expression) => this.Member(expression);

        public SourceProgram Visit(MemberInitExpression expression) =>
            SourceProgram.Concat(
                expression.NewExpression.Arguments.Count == 0
                    ? SourceProgram.Text("new " + TypeName(expression.Type))
                    : this.New(expression.NewExpression),
                SourceProgram.Text(" "),
                SourceProgram.CommaSeparated(expression.Bindings.Select(this.Binding)).Braced());

        public SourceProgram Visit(NewExpression expression) => this.New(expression);

        public SourceProgram Visit(NewArrayExpression expression)
        {
            if (expression.NodeType == ExpressionType.NewArrayBounds)
            {
                return SourceProgram.Concat(
                    SourceProgram.Text("new " + TypeName(expression.Type.GetElementType())),
                    SourceProgram.CommaSeparated(expression.Expressions.Select(this.Typed)).Bracketed());
            }

            var elements = expression.Expressions.Select(this.Typed).ToArray();
            var inferred = elements.Any(element => !element.IsText("null")) &&
                expression.Type.GetElementType() != typeof(object) &&
                expression.Expressions.All(element => element.Type == expression.Type.GetElementType());
            return SourceProgram.Concat(
                SourceProgram.Text((inferred ? "new[]" : "new " + TypeName(expression.Type)) + " "),
                SourceProgram.CommaSeparated(elements).Braced());
        }

        public SourceProgram Visit(TypeBinaryExpression expression)
        {
            if (expression.NodeType != ExpressionType.TypeIs)
                throw Unsupported(expression);

            return SourceProgram.Concat(
                this.Visit(expression.Expression).Parenthesized(),
                SourceProgram.Text(" is " + TypeName(expression.TypeOperand)));
        }

        public SourceProgram Visit(DefaultExpression expression) =>
            SourceProgram.Text("default(" + TypeName(expression.Type) + ")");

        public SourceProgram Visit(IndexExpression expression) =>
            SourceProgram.Concat(
                this.Visit(expression.Object).Parenthesized(),
                SourceProgram.CommaSeparated(expression.Arguments.Select(this.Typed)).Bracketed());

        public SourceProgram Visit(BlockExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(DebugInfoExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(DynamicExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(GotoExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(LabelExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(RuntimeVariablesExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(SwitchExpression expression) => throw Unsupported(expression);
        public SourceProgram Visit(TryExpression expression) => throw Unsupported(expression);

        private static NotSupportedException Unsupported(Expression expression) =>
            new NotSupportedException($"C# serialization does not support {expression.NodeType}: {expression}");

            private SourceProgram Literal(object value, Type type)
            {
                if (value is ForEachItemToken item)
                    return this.BindRaw(WorkflowExpressionBinding.Item(item));
                if (value is Array or IDictionary or JToken)
                    throw new NotSupportedException("Capture immutable scalar values, not mutable objects or collections.");
                if (value == null) return Cast(type, SourceProgram.Text("null"));

                if (Nullable.GetUnderlyingType(type) is Type underlying)
                    return Cast(type, this.Literal(value, underlying));

                var runtimeType = value.GetType();
                if (runtimeType != type && type.IsAssignableFrom(runtimeType))
                    return Cast(type, this.Literal(value, runtimeType));

                if (value is string text) return SourceProgram.Text(Quote(text));
                if (value is bool flag) return SourceProgram.Text(flag ? "true" : "false");
                if (value is char character)
                {
                    var escaped = Quote(character.ToString());
                    return SourceProgram.Text(
                        "'" + escaped.Substring(1, escaped.Length - 2).Replace("'", "\\'").Replace("\\\"", "\"") + "'");
                }

                if (value is Enum enumeration)
                {
                    var name = Enum.GetName(value.GetType(), value);
                    if (name != null)
                        return SourceProgram.Text(TypeName(value.GetType()) + "." + name);

                    var enumUnderlyingType = Enum.GetUnderlyingType(value.GetType());
                    var enumValue = System.Convert.ChangeType(value, enumUnderlyingType, CultureInfo.InvariantCulture);
                    return Cast(value.GetType(), this.Literal(enumValue, enumUnderlyingType));
                }

                if (value is DateTime date)
                {
                    return SourceProgram.Text(
                        $"new global::System.DateTime({date.Ticks}L, global::System.DateTimeKind.{date.Kind})");
                }

                if (value is DateTimeOffset offset)
                    return SourceProgram.Text(
                        $"new global::System.DateTimeOffset({offset.Ticks}L, new global::System.TimeSpan({offset.Offset.Ticks}L))");
                if (value is TimeSpan span)
                    return SourceProgram.Text($"new global::System.TimeSpan({span.Ticks}L)");
                if (value is Guid guid)
                    return SourceProgram.Text("new global::System.Guid(" + Quote(guid.ToString("D")) + ")");
                if (value is Uri uri)
                    return SourceProgram.Text(
                        "new global::System.Uri(" + Quote(uri.OriginalString) + ", global::System.UriKind.RelativeOrAbsolute)");
                if (value is HttpMethod method)
                    return SourceProgram.Text(
                        "new global::System.Net.Http.HttpMethod(" + Quote(method.Method) + ")");

                if (value is double number)
                {
                    if (double.IsNaN(number)) return SourceProgram.Text("double.NaN");
                    if (double.IsPositiveInfinity(number)) return SourceProgram.Text("double.PositiveInfinity");
                    if (double.IsNegativeInfinity(number)) return SourceProgram.Text("double.NegativeInfinity");
                    if (number == 0 && BitConverter.DoubleToInt64Bits(number) < 0) return SourceProgram.Text("-0.0d");
                    return SourceProgram.Text(number.ToString("R", CultureInfo.InvariantCulture) + "d");
                }

                if (value is float single)
                {
                    if (float.IsNaN(single)) return SourceProgram.Text("float.NaN");
                    if (float.IsPositiveInfinity(single)) return SourceProgram.Text("float.PositiveInfinity");
                    if (float.IsNegativeInfinity(single)) return SourceProgram.Text("float.NegativeInfinity");
                    if (single == 0 && BitConverter.ToInt32(BitConverter.GetBytes(single), 0) < 0)
                        return SourceProgram.Text("-0.0f");
                    return SourceProgram.Text(single.ToString("R", CultureInfo.InvariantCulture) + "f");
                }

                if (value is decimal || value is long || value is ulong || value is uint ||
                    value is int || value is short || value is ushort || value is byte || value is sbyte)
                {
                    var suffix = value is decimal ? "m" : value is long ? "L" : value is ulong ? "UL" : value is uint ? "U" : "";
                    var source = System.Convert.ToString(value, CultureInfo.InvariantCulture) + suffix;
                    var literal = SourceProgram.Text(source);
                    return value is byte or sbyte or short or ushort
                        ? Cast(value.GetType(), literal)
                        : literal;
                }

                throw new NotSupportedException($"Cannot serialize captured value of type {value.GetType()}. Construct the object inside the lambda instead.");
            }

            private static SourceProgram Cast(Type type, SourceProgram value) =>
                SourceProgram.Concat(
                    SourceProgram.Text(TypeName(type)).Parenthesized(),
                    value.Parenthesized());

            private static SourceProgram ReadWorkflowValue(SourceProgram source, Type type)
            {
                if (typeof(JToken).IsAssignableFrom(type))
                    return source;

                ValidateRuntimeType(type);
                return SourceProgram.Concat(
                    source.Parenthesized(),
                    SourceProgram.Text(".ToObject<" + TypeName(type) + ">()"));
            }

            private SourceProgram Member(MemberExpression member)
            {
                if (member.Expression == null)
                {
                    if (member.Member.DeclaringType == typeof(HttpMethod) && member.Member is PropertyInfo httpProperty)
                        return this.Literal(httpProperty.GetValue(null), typeof(HttpMethod));
                    return SourceProgram.Text(TypeName(member.Member.DeclaringType) + "." + Identifier(member.Member.Name));
                }

                return SourceProgram.Concat(
                    this.Receiver(member.Expression).Parenthesized(),
                    SourceProgram.Text("." + Identifier(member.Member.Name)));
            }

            private bool TryCustomWorkflowPath(Expression expression, out SourceProgram code)
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
                    code = SourceProgram.Concat(
                        code.Parenthesized(),
                        SourceProgram.Text(Quote(jsonName)).Bracketed());
                }

                code = ReadWorkflowValue(code, expression.Type);
                return true;
            }

            private bool TryCollectCustomWorkflowPath(
                Expression expression,
                List<PropertyInfo> properties,
                out SourceProgram root)
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

            private bool TryWorkflowTokenSource(Expression expression, out SourceProgram code)
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

            private SourceProgram Binary(BinaryExpression binary)
            {
                if (binary.NodeType == ExpressionType.ArrayIndex)
                    return SourceProgram.Concat(
                        this.Typed(binary.Left).Parenthesized(),
                        this.Typed(binary.Right).Bracketed());
                if (binary.Conversion != null)
                    throw new NotSupportedException("Coalesce conversion lambdas are not supported.");

                var op = Operator(binary.NodeType);
                var left = this.Typed(binary.Left);
                var right = this.Typed(binary.Right);
                var source = SourceProgram.Concat(
                    left.Parenthesized(),
                    SourceProgram.Text(" " + op + " "),
                    right.Parenthesized());
                if (binary.NodeType == ExpressionType.AddChecked || binary.NodeType == ExpressionType.SubtractChecked ||
                    binary.NodeType == ExpressionType.MultiplyChecked)
                    return SourceProgram.Concat(
                        SourceProgram.Text("checked"),
                        source.Parenthesized());
                return source;
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

            private SourceProgram Unary(UnaryExpression unary)
            {
                if (unary.NodeType == ExpressionType.Quote) return this.Visit(unary.Operand);
                var operand = this.Typed(unary.Operand);
                switch (unary.NodeType)
                {
                    case ExpressionType.Convert:
                    case ExpressionType.ConvertChecked:
                        var cast = SourceProgram.Concat(
                            SourceProgram.Text(TypeName(unary.Type)).Parenthesized(),
                            operand.Parenthesized());
                        return unary.NodeType == ExpressionType.ConvertChecked
                            ? SourceProgram.Concat(SourceProgram.Text("checked"), cast.Parenthesized())
                            : cast;
                    case ExpressionType.Negate:
                        return SourceProgram.Concat(SourceProgram.Text("-"), operand.Parenthesized());
                    case ExpressionType.NegateChecked:
                        return SourceProgram.Concat(
                            SourceProgram.Text("checked"),
                            SourceProgram.Concat(SourceProgram.Text("-"), operand.Parenthesized()).Parenthesized());
                    case ExpressionType.UnaryPlus:
                        return SourceProgram.Concat(SourceProgram.Text("+"), operand.Parenthesized());
                    case ExpressionType.Not:
                        return SourceProgram.Concat(
                            SourceProgram.Text(
                                unary.Type == typeof(bool) || Nullable.GetUnderlyingType(unary.Type) == typeof(bool)
                                    ? "!"
                                    : "~"),
                            operand.Parenthesized());
                    case ExpressionType.TypeAs:
                        return SourceProgram.Concat(
                            operand.Parenthesized(),
                            SourceProgram.Text(" as " + TypeName(unary.Type)));
                    default: throw new NotSupportedException($"Unsupported C# unary operator: {unary.NodeType}");
                }
            }

            private SourceProgram Call(MethodCallExpression call)
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
                    return SourceProgram.Concat(
                        indexed.Parenthesized(),
                        SourceProgram.CommaSeparated(call.Arguments.Select(this.Typed)).Bracketed());
                }

                var extension = call.Method.IsDefined(typeof(ExtensionAttribute), false);
                var targetExpression = extension ? call.Arguments[0] : call.Object;
                var target = targetExpression == null
                    ? SourceProgram.Text(TypeName(call.Method.DeclaringType))
                    : this.Receiver(targetExpression).Parenthesized();

                if (call.Method.GetParameters().Any(p => p.ParameterType.IsByRef))
                    throw new NotSupportedException($"Calls with ref/out arguments are not supported: {call.Method}");
                var arguments = call.Arguments.Skip(extension ? 1 : 0).Select(this.Typed);
                var inferGenerics = call.Method.IsGenericMethod && call.Method.DeclaringType == typeof(Enumerable) &&
                    call.Method.GetGenericMethodDefinition().GetGenericArguments().All(parameter =>
                        call.Method.GetGenericMethodDefinition().GetParameters().Any(p => ContainsType(p.ParameterType, parameter)));
                var generic = call.Method.IsGenericMethod && !inferGenerics ?
                    "<" + string.Join(", ", call.Method.GetGenericArguments().Select(TypeName)) + ">" : "";
                return SourceProgram.Concat(
                    target,
                    SourceProgram.Text("." + Identifier(call.Method.Name) + generic),
                    SourceProgram.CommaSeparated(arguments).Parenthesized());
            }

            private bool TryWriteWorkflowFunction(
                MethodCallExpression call,
                out SourceProgram code,
                out bool returnsToken)
            {
                code = null;
                returnsToken = false;
                if (call.Method.DeclaringType != typeof(WorkflowFunctions))
                    return false;
                if (!WorkflowFunctionNames.TryGetValue(call.Method.Name, out var function))
                    throw new NotSupportedException($"Unsupported workflow function: {call.Method.Name}");

                code = SourceProgram.Concat(
                    SourceProgram.Text(function),
                    SourceProgram.CommaSeparated(call.Arguments.Select(this.Typed)).Parenthesized());
                returnsToken = call.Method.ReturnType != typeof(string) &&
                    call.Method.ReturnType != typeof(bool);
                return true;
            }

            private static bool ContainsType(Type type, Type parameter) =>
                type == parameter || (type.HasElementType && ContainsType(type.GetElementType(), parameter)) ||
                (type.IsGenericType && type.GetGenericArguments().Any(t => ContainsType(t, parameter)));

            private SourceProgram Receiver(Expression expression)
            {
                var code = this.Typed(expression);
                return code.IsText("null")
                    ? SourceProgram.Text("((" + TypeName(expression.Type) + ")null)")
                    : code;
            }

            private SourceProgram Format(MethodCallExpression call)
            {
                var formatIndex = call.Arguments[0].Type == typeof(string) ? 0 : 1;
                if (!(call.Arguments[formatIndex] is ConstantExpression constant) || !(constant.Value is string format))
                    return this.PlainFormat(call);
                var values = call.Arguments.Skip(formatIndex + 1).ToArray();
                if (values.Length == 1 && values[0] is NewArrayExpression array) values = array.Expressions.ToArray();
                values = values.Select(Unbox).ToArray();
                var codes = values.Select(this.Visit).ToArray();
                if (formatIndex != 0 || format.Contains("{{") || format.Contains("}}") ||
                    Regex.Replace(format, @"\{\d+\}", "").IndexOfAny(new[] { '{', '}' }) >= 0)
                    return this.PlainFormat(call);
                if (format == "{0}" && codes.Length == 1)
                {
                    if (values[0] is NewExpression creation && !IsAnonymous(creation.Type) || values[0] is MemberInitExpression)
                        return SourceProgram.Concat(
                            SourceProgram.Text("JsonConvert.SerializeObject"),
                            codes[0].Parenthesized());
                    return codes[0];
                }

                return this.PlainFormat(call);
            }

            private static Expression Unbox(Expression expression) =>
                expression is UnaryExpression unary && unary.NodeType == ExpressionType.Convert && unary.Type == typeof(object) ?
                    unary.Operand : expression;

            private SourceProgram PlainFormat(MethodCallExpression call)
            {
                var arguments = call.Arguments.Select<Expression, SourceProgram>(argument =>
                {
                    if (argument is NewArrayExpression array && array.Type == typeof(object[]))
                        return SourceProgram.Concat(
                            SourceProgram.Text("new object[] "),
                            SourceProgram.CommaSeparated(
                                array.Expressions.Select(expression => this.Visit(Unbox(expression))))
                                .Braced());
                    return this.Visit(Unbox(argument));
                });
                return SourceProgram.Concat(
                    SourceProgram.Text("string.Format"),
                    SourceProgram.CommaSeparated(arguments).Parenthesized());
            }

            private SourceProgram New(NewExpression creation)
            {
                if (IsAnonymous(creation.Type))
                {
                    return SourceProgram.Concat(
                        SourceProgram.Text("new "),
                        SourceProgram.CommaSeparated(creation.Arguments.Select((argument, index) =>
                            {
                                var value = this.Typed(argument);
                                return SourceProgram.Concat(
                                    SourceProgram.Text(Identifier(creation.Members[index].Name) + " = "),
                                    value.IsText("null")
                                        ? SourceProgram.Concat(
                                            SourceProgram.Text(TypeName(argument.Type)).Parenthesized(),
                                            SourceProgram.Text("null"))
                                        : value);
                            }))
                            .Braced());
                }

                return SourceProgram.Concat(
                    SourceProgram.Text("new " + TypeName(creation.Type)),
                    SourceProgram.CommaSeparated(creation.Arguments.Select(this.Typed)).Parenthesized());
            }

            private SourceProgram Binding(MemberBinding binding)
            {
                if (!(binding is MemberAssignment assignment))
                    throw new NotSupportedException($"Unsupported object initializer binding: {binding.BindingType}");
                return SourceProgram.Concat(
                    SourceProgram.Text(Identifier(binding.Member.Name) + " = "),
                    this.Typed(assignment.Expression));
        }
    }
}

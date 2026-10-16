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
        internal static bool CanUseWorkflowLiteral(Type type) =>
            type.IsPrimitive && !type.IsEnum || type == typeof(string) || type == typeof(decimal);

        private static string Quote(string text) => JsonConvert.ToString(text);

        private static bool Implements(Type type, Type definition) =>
            (type.IsGenericType && type.GetGenericTypeDefinition() == definition) ||
            type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == definition);

        internal static bool IsAnonymous(Type type) =>
            type.IsDefined(typeof(CompilerGeneratedAttribute), false) && type.Name.Contains("AnonymousType");

        private static bool ContainsAnonymousType(Type type) =>
            IsAnonymous(type) ||
            type.HasElementType && ContainsAnonymousType(type.GetElementType()) ||
            type.IsGenericType && type.GetGenericArguments().Any(ContainsAnonymousType);

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

        public SourceProgram Visit(BinaryExpression binaryExpression)
        {
            if (binaryExpression.NodeType == ExpressionType.ArrayIndex)
                return SourceProgram.Concat(
                    this.Visit(binaryExpression.Left).Parenthesized(),
                    this.Visit(binaryExpression.Right).Bracketed());
            if (binaryExpression.Conversion != null)
                throw new NotSupportedException("Coalesce conversion lambdas are not supported.");

            var op = Operator(binaryExpression.NodeType);
            var left = this.Visit(binaryExpression.Left);
            var right = this.Visit(binaryExpression.Right);
            var source = SourceProgram.Concat(
                left.Parenthesized(),
                SourceProgram.Text(" " + op + " "),
                right.Parenthesized());
            if (binaryExpression.NodeType == ExpressionType.AddChecked || binaryExpression.NodeType == ExpressionType.SubtractChecked ||
                binaryExpression.NodeType == ExpressionType.MultiplyChecked)
                return SourceProgram.Concat(
                    SourceProgram.Text("checked"),
                    source.Parenthesized());
            return source;
        }

        public SourceProgram Visit(UnaryExpression unaryExpression)
        {
            if (unaryExpression.NodeType == ExpressionType.Quote) return this.Visit(unaryExpression.Operand);
            var operand = this.Visit(unaryExpression.Operand);
            switch (unaryExpression.NodeType)
            {
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                    var cast = SourceProgram.Concat(
                        SourceProgram.Text(TypeName(unaryExpression.Type)).Parenthesized(),
                        operand.Parenthesized());
                    return unaryExpression.NodeType == ExpressionType.ConvertChecked
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
                            unaryExpression.Type == typeof(bool) || Nullable.GetUnderlyingType(unaryExpression.Type) == typeof(bool)
                                ? "!"
                                : "~"),
                        operand.Parenthesized());
                case ExpressionType.TypeAs:
                    return SourceProgram.Concat(
                        operand.Parenthesized(),
                        SourceProgram.Text(" as " + TypeName(unaryExpression.Type)));
                default: throw new NotSupportedException($"Unsupported C# unary operator: {unaryExpression.NodeType}");
            }
        }

        public SourceProgram Visit(ConstantExpression constantExpression) =>
            this.Literal(constantExpression.Value, constantExpression.Type);

        public SourceProgram Visit(ParameterExpression parameterExpression) =>
            this.parameters.Contains(parameterExpression)
                ? SourceProgram.Text(Identifier(parameterExpression.Name))
                : throw Unsupported(parameterExpression);

        public SourceProgram Visit(MethodCallExpression methodCallExpression)
        {
            ValidateRuntimeType(methodCallExpression.Method.DeclaringType);
            if (!methodCallExpression.Method.IsPublic)
                throw new NotSupportedException($"Expression runtime member must be public: {methodCallExpression.Method}");

            if (TryWriteWorkflowFunction(methodCallExpression, out var workflowFunction, out var returnsToken))
                return returnsToken
                    ? ReadWorkflowValue(workflowFunction, methodCallExpression.Type)
                    : workflowFunction;

            if (methodCallExpression.Method.Name == "get_Item" && methodCallExpression.Object != null)
            {
                var indexed = this.Visit(methodCallExpression.Object);
                return SourceProgram.Concat(
                    indexed.Parenthesized(),
                    SourceProgram.CommaSeparated(methodCallExpression.Arguments.Select(this.Visit)).Bracketed());
            }

            var target = methodCallExpression.Object == null
                ? SourceProgram.Text(TypeName(methodCallExpression.Method.DeclaringType))
                : this.Receiver(methodCallExpression.Object).Parenthesized();

            if (methodCallExpression.Method.GetParameters().Any(p => p.ParameterType.IsByRef))
                throw new NotSupportedException($"Calls with ref/out arguments are not supported: {methodCallExpression.Method}");
            var parameters = methodCallExpression.Method.GetParameters();
            var overloaded = methodCallExpression.Method.DeclaringType.GetMethods()
                .Count(method => method.Name == methodCallExpression.Method.Name) > 1;
            var arguments = methodCallExpression.Arguments.Select(
                (argument, index) => this.Argument(argument, parameters[index].ParameterType, overloaded));
            var generic = this.GenericArguments(methodCallExpression.Method);
            return SourceProgram.Concat(
                target,
                SourceProgram.Text("." + Identifier(methodCallExpression.Method.Name) + generic),
                SourceProgram.CommaSeparated(arguments).Parenthesized());
        }

        private string GenericArguments(MethodInfo method)
        {
            if (!method.IsGenericMethod)
                return string.Empty;

            var arguments = method.GetGenericArguments();
            var canRender = true;
            foreach (var argument in arguments)
            {
                if (ContainsAnonymousType(argument))
                    canRender = false;
                else
                    ValidateRuntimeType(argument);
            }

            return canRender
                ? "<" + string.Join(", ", arguments.Select(TypeName)) + ">"
                : string.Empty;
        }

        public SourceProgram Visit(ConditionalExpression conditionalExpression) =>
            SourceProgram.Concat(
                this.Visit(conditionalExpression.Test).Parenthesized(),
                SourceProgram.Text(" ? "),
                this.Visit(conditionalExpression.IfTrue).Parenthesized(),
                SourceProgram.Text(" : "),
                this.Visit(conditionalExpression.IfFalse).Parenthesized());

        public SourceProgram Visit(InvocationExpression invocationExpression) => throw Unsupported(invocationExpression);

        public SourceProgram Visit(LambdaExpression lambdaExpression)
        {
            // NOTE(aeldridge): Lambda parameters must be available to the visitor at child nodes, so they are
            // tracked in this.parameters and removed after visiting the body
            foreach (var parameter in lambdaExpression.Parameters)
                this.parameters.Add(parameter);

            try
            {
                return SourceProgram.Concat(
                    SourceProgram.Text(
                        string.Join(", ", lambdaExpression.Parameters.Select(
                            parameter => TypeName(parameter.Type) + " " + Identifier(parameter.Name))))
                        .Parenthesized(),
                    SourceProgram.Text(" => "),
                    this.Visit(lambdaExpression.Body));
            }
            finally
            {
                foreach (var parameter in lambdaExpression.Parameters)
                    this.parameters.Remove(parameter);
            }
        }

        public SourceProgram Visit(ListInitExpression listInitExpression) =>
            SourceProgram.Concat(
                this.Visit(listInitExpression.NewExpression),
                SourceProgram.Text(" "),
                SourceProgram.CommaSeparated(listInitExpression.Initializers.Select(initializer =>
                {
                    if (!initializer.AddMethod.IsPublic || initializer.AddMethod.IsStatic)
                        throw new NotSupportedException(
                            $"Collection initializer method must be a public instance method: {initializer.AddMethod}");

                    var parameters = initializer.AddMethod.GetParameters();
                    var overloaded = initializer.AddMethod.DeclaringType.GetMethods()
                        .Count(method => method.Name == initializer.AddMethod.Name) > 1;
                    var arguments = initializer.Arguments.Select(
                        (argument, index) => this.Argument(argument, parameters[index].ParameterType, overloaded));
                    return initializer.Arguments.Count == 1
                        ? arguments.Single()
                        : SourceProgram.CommaSeparated(arguments).Braced();
                }))
                    .Braced());

        public SourceProgram Visit(MemberExpression memberExpression)
        {
            if (memberExpression.Expression == null)
            {
                return SourceProgram.Text(TypeName(memberExpression.Member.DeclaringType) + "." + Identifier(memberExpression.Member.Name));
            }

            return SourceProgram.Concat(
                this.Receiver(memberExpression.Expression).Parenthesized(),
                SourceProgram.Text("." + Identifier(memberExpression.Member.Name)));
        }

        public SourceProgram Visit(MemberInitExpression memberInitExpression) =>
            SourceProgram.Concat(
                memberInitExpression.NewExpression.Arguments.Count == 0
                    ? SourceProgram.Text("new " + TypeName(memberInitExpression.Type))
                    : this.Visit(memberInitExpression.NewExpression),
                SourceProgram.Text(" "),
                SourceProgram.CommaSeparated(memberInitExpression.Bindings.Select(this.Binding)).Braced());
        
        private SourceProgram Binding(MemberBinding binding)
        {
            if (!(binding is MemberAssignment assignment))
                throw new NotSupportedException($"Unsupported object initializer binding: {binding.BindingType}");
            
            return SourceProgram.Concat(
                SourceProgram.Text(Identifier(binding.Member.Name) + " = "),
                this.Visit(assignment.Expression));
        }

        public SourceProgram Visit(NewExpression newExpression)
        {
            if (IsAnonymous(newExpression.Type))
            {
                return SourceProgram.Concat(
                    SourceProgram.Text("new "),
                    SourceProgram.CommaSeparated(newExpression.Arguments.Select((argument, index) =>
                        {
                            var value = this.Visit(argument);
                            return SourceProgram.Concat(
                                SourceProgram.Text(Identifier(newExpression.Members[index].Name) + " = "),
                                value.IsText("null")
                                    ? SourceProgram.Concat(
                                        SourceProgram.Text(TypeName(argument.Type)).Parenthesized(),
                                        SourceProgram.Text("null"))
                                    : value);
                        }))
                        .Braced());
            }

            var parameters = newExpression.Constructor?.GetParameters() ?? Array.Empty<ParameterInfo>();
            var overloaded = newExpression.Constructor != null &&
                newExpression.Type.GetConstructors().Length > 1;
            
            return SourceProgram.Concat(
                SourceProgram.Text("new " + TypeName(newExpression.Type)),
                SourceProgram.CommaSeparated(newExpression.Arguments.Select(
                    (argument, index) => this.Argument(argument, parameters[index].ParameterType, overloaded)))
                    .Parenthesized());
        }

        public SourceProgram Visit(NewArrayExpression newArrayExpression)
        {
            if (newArrayExpression.NodeType == ExpressionType.NewArrayBounds)
            {
                return SourceProgram.Concat(
                    SourceProgram.Text("new " + TypeName(newArrayExpression.Type.GetElementType())),
                    SourceProgram.CommaSeparated(newArrayExpression.Expressions.Select(this.Visit)).Bracketed());
            }

            var elements = newArrayExpression.Expressions.Select(this.Visit);
            var elementType = newArrayExpression.Type.GetElementType();
            return SourceProgram.Concat(
                SourceProgram.Text(
                    ContainsAnonymousType(elementType)
                        ? "new[] "
                        : "new " + TypeName(newArrayExpression.Type) + " "),
                SourceProgram.CommaSeparated(elements).Braced());
        }

        public SourceProgram Visit(TypeBinaryExpression typeBinaryExpression)
        {
            if (typeBinaryExpression.NodeType != ExpressionType.TypeIs)
                throw Unsupported(typeBinaryExpression);

            return SourceProgram.Concat(
                this.Visit(typeBinaryExpression.Expression).Parenthesized(),
                SourceProgram.Text(" is " + TypeName(typeBinaryExpression.TypeOperand)));
        }

        public SourceProgram Visit(DefaultExpression defaultExpression) =>
            SourceProgram.Text("default(" + TypeName(defaultExpression.Type) + ")");

        public SourceProgram Visit(IndexExpression indexExpression) =>
            SourceProgram.Concat(
                this.Visit(indexExpression.Object).Parenthesized(),
                SourceProgram.CommaSeparated(indexExpression.Arguments.Select(this.Visit)).Bracketed());

        public SourceProgram Visit(BlockExpression blockExpression) => throw Unsupported(blockExpression);
        public SourceProgram Visit(DebugInfoExpression debugInfoExpression) => throw Unsupported(debugInfoExpression);
        public SourceProgram Visit(DynamicExpression dynamicExpression) => throw Unsupported(dynamicExpression);
        public SourceProgram Visit(GotoExpression gotoExpression) => throw Unsupported(gotoExpression);
        public SourceProgram Visit(LabelExpression labelExpression) => throw Unsupported(labelExpression);
        public SourceProgram Visit(RuntimeVariablesExpression runtimeVariablesExpression) => throw Unsupported(runtimeVariablesExpression);
        public SourceProgram Visit(SwitchExpression switchExpression) => throw Unsupported(switchExpression);
        public SourceProgram Visit(TryExpression tryExpression) => throw Unsupported(tryExpression);

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

        private bool TryWriteWorkflowFunction(
            MethodCallExpression call,
            out SourceProgram code,
            out bool returnsToken)
        {
            code = null;
            returnsToken = false;
            if (call.Method.DeclaringType != typeof(WorkflowFunctions))
                return false;
            var metadata = call.Method.GetCustomAttribute<WorkflowFunctionAttribute>() ??
                (call.Method.IsGenericMethod
                    ? call.Method.GetGenericMethodDefinition().GetCustomAttribute<WorkflowFunctionAttribute>()
                    : null) ??
                throw new NotSupportedException(
                    $"Workflow function '{call.Method.Name}' has no runtime mapping.");

            code = SourceProgram.Concat(
                SourceProgram.Text(metadata.Name),
                SourceProgram.CommaSeparated(call.Arguments.Select(this.Visit)).Parenthesized());
            returnsToken = call.Method.ReturnType != typeof(string) &&
                call.Method.ReturnType != typeof(bool);
            return true;
        }

        private SourceProgram Argument(Expression expression, Type parameterType, bool forceType)
        {
            var source = this.Visit(expression);
            if (!forceType || expression.Type == parameterType || ContainsAnonymousType(parameterType))
                return source;

            ValidateRuntimeType(parameterType);
            return Cast(parameterType, source);
        }

        private SourceProgram Receiver(Expression expression)
        {
            var code = this.Visit(expression);
            return code.IsText("null")
                ? SourceProgram.Text("((" + TypeName(expression.Type) + ")null)")
                : code;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq.Expressions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal static class CSharpSyntaxGenerator
    {
        private static readonly HashSet<string> Keywords = new HashSet<string>(
            ("abstract as base bool break byte case catch char checked class const continue decimal default delegate " +
             "do double else enum event explicit extern false finally fixed float for foreach goto if implicit in int interface " +
             "internal is lock long namespace new null object operator out override params private protected public " +
             "readonly ref return sbyte sealed short sizeof stackalloc static string struct switch this throw true try " +
             "typeof uint ulong unchecked unsafe ushort using virtual void volatile while").Split(' '),
            StringComparer.Ordinal);

        internal static string Identifier(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new NotSupportedException("Cannot emit a C# identifier without a name.");

            return Keywords.Contains(name) ? "@" + name : name;
        }

        internal static string TypeName(Type type)
        {
            WorkflowExpressionTypePolicy.Validate(type);
            return TypeNameCore(type);
        }

        private static string TypeNameCore(Type type)
        {
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
            if (type.IsArray)
                return TypeNameCore(type.GetElementType()) + "[" + new string(',', type.GetArrayRank() - 1) + "]";
            if (Nullable.GetUnderlyingType(type) is Type underlying)
                return TypeNameCore(underlying) + "?";
            if (type.IsNested)
            {
                var arguments = type.GetGenericArguments();
                var declaring = type.DeclaringType;
                var parentCount = declaring.GetGenericArguments().Length;
                if (declaring.IsGenericTypeDefinition)
                    declaring = declaring.MakeGenericType(arguments.Take(parentCount).ToArray());
                var nestedName = Identifier(type.Name.Split('`')[0]);
                var ownArguments = arguments.Skip(parentCount).ToArray();
                return TypeNameCore(declaring) + "." + nestedName +
                    (ownArguments.Length == 0 ? "" : "<" + string.Join(", ", ownArguments.Select(TypeNameCore)) + ">");
            }

            var name = Identifier(type.Name.Split('`')[0]);
            var prefix = string.IsNullOrEmpty(type.Namespace) ? "" : "global::" + type.Namespace + ".";
            return prefix +
                (type.IsGenericType
                    ? name + "<" + string.Join(", ", type.GetGenericArguments().Select(TypeNameCore)) + ">"
                    : name);
        }

        internal static string BinaryOperator(ExpressionType type)
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

        internal static WorkflowExpressionFragment Binary(
            WorkflowExpressionFragment left,
            string operatorToken,
            WorkflowExpressionFragment right,
            bool isChecked = false)
        {
            var source = WorkflowExpressionFragment.Concat(
                left.Parenthesized(),
                WorkflowExpressionFragment.Text(" " + operatorToken + " "),
                right.Parenthesized());
            return isChecked ? Checked(source) : source;
        }

        internal static WorkflowExpressionFragment Unary(string operatorToken, WorkflowExpressionFragment operand) =>
            WorkflowExpressionFragment.Concat(WorkflowExpressionFragment.Text(operatorToken), operand.Parenthesized());

        internal static WorkflowExpressionFragment Cast(Type type, WorkflowExpressionFragment operand, bool isChecked = false)
        {
            var source = WorkflowExpressionFragment.Concat(
                WorkflowExpressionFragment.Text(TypeName(type)).Parenthesized(),
                operand.Parenthesized());
            return isChecked ? Checked(source) : source;
        }

        internal static WorkflowExpressionFragment Checked(WorkflowExpressionFragment expression) =>
            WorkflowExpressionFragment.Concat(WorkflowExpressionFragment.Text("checked"), expression.Parenthesized());

        internal static WorkflowExpressionFragment Conditional(
            WorkflowExpressionFragment test,
            WorkflowExpressionFragment whenTrue,
            WorkflowExpressionFragment whenFalse) =>
            WorkflowExpressionFragment.Concat(
                test.Parenthesized(),
                WorkflowExpressionFragment.Text(" ? "),
                whenTrue.Parenthesized(),
                WorkflowExpressionFragment.Text(" : "),
                whenFalse.Parenthesized());

        internal static WorkflowExpressionFragment MemberAccess(WorkflowExpressionFragment receiver, string memberName) =>
            WorkflowExpressionFragment.Concat(
                receiver.Parenthesized(),
                WorkflowExpressionFragment.Text("." + Identifier(memberName)));

        internal static WorkflowExpressionFragment StaticMemberAccess(Type declaringType, string memberName) =>
            WorkflowExpressionFragment.Text(TypeName(declaringType) + "." + Identifier(memberName));

        internal static WorkflowExpressionFragment ElementAccess(
            WorkflowExpressionFragment receiver,
            IEnumerable<WorkflowExpressionFragment> arguments) =>
            WorkflowExpressionFragment.Concat(
                receiver.Parenthesized(),
                WorkflowExpressionFragment.CommaSeparated(arguments).Bracketed());

        internal static WorkflowExpressionFragment Invocation(
            WorkflowExpressionFragment target,
            IEnumerable<Type> genericArguments,
            IEnumerable<WorkflowExpressionFragment> arguments)
        {
            var types = genericArguments?.ToArray() ?? Array.Empty<Type>();
            var generic = types.Length == 0
                ? string.Empty
                : "<" + string.Join(", ", types.Select(TypeName)) + ">";
            return WorkflowExpressionFragment.Concat(
                target,
                WorkflowExpressionFragment.Text(generic),
                WorkflowExpressionFragment.CommaSeparated(arguments).Parenthesized());
        }

        internal static WorkflowExpressionFragment ObjectCreation(
            Type type,
            IEnumerable<WorkflowExpressionFragment> arguments) =>
            Invocation(
                WorkflowExpressionFragment.Text("new " + TypeName(type)),
                Array.Empty<Type>(),
                arguments);

        internal static WorkflowExpressionFragment ArrayCreation(
            Type arrayType,
            IEnumerable<WorkflowExpressionFragment> elements) =>
            Initializer(
                WorkflowExpressionFragment.Text("new " + TypeName(arrayType)),
                elements);

        internal static WorkflowExpressionFragment InferredArrayCreation(
            IEnumerable<WorkflowExpressionFragment> elements) =>
            Initializer(
                WorkflowExpressionFragment.Text("new[]"),
                elements);

        internal static WorkflowExpressionFragment ArrayBoundsCreation(
            Type elementType,
            IEnumerable<WorkflowExpressionFragment> bounds) =>
            WorkflowExpressionFragment.Concat(
                WorkflowExpressionFragment.Text("new " + TypeName(elementType)),
                WorkflowExpressionFragment.CommaSeparated(bounds).Bracketed());

        internal static WorkflowExpressionFragment Initializer(
            WorkflowExpressionFragment target,
            IEnumerable<WorkflowExpressionFragment> entries) =>
            WorkflowExpressionFragment.Concat(
                target,
                WorkflowExpressionFragment.Text(" "),
                WorkflowExpressionFragment.CommaSeparated(entries).Braced());

        internal static WorkflowExpressionFragment Assignment(string memberName, WorkflowExpressionFragment value) =>
            WorkflowExpressionFragment.Concat(
                WorkflowExpressionFragment.Text(Identifier(memberName) + " = "),
                value);

        internal static WorkflowExpressionFragment MemberInitializer(
            string memberName,
            IEnumerable<WorkflowExpressionFragment> entries) =>
            Assignment(
                memberName,
                WorkflowExpressionFragment.CommaSeparated(entries).Braced());

        internal static WorkflowExpressionFragment Lambda(
            IEnumerable<(Type Type, string Name)> parameters,
            WorkflowExpressionFragment body)
        {
            var parameterArray = parameters.ToArray();
            var useImplicitParameters = parameterArray.Any(
                parameter => WorkflowExpressionTypePolicy.ContainsAnonymous(parameter.Type));
            var declarations = useImplicitParameters
                ? parameterArray.Select(parameter => Identifier(parameter.Name))
                : parameterArray.Select(
                    parameter => TypeName(parameter.Type) + " " + Identifier(parameter.Name));
            return WorkflowExpressionFragment.Concat(
                WorkflowExpressionFragment.Text(string.Join(", ", declarations)).Parenthesized(),
                WorkflowExpressionFragment.Text(" => "),
                body);
        }

        internal static WorkflowExpressionFragment TypeTest(WorkflowExpressionFragment expression, Type type) =>
            TypeOperation(expression, "is", type);

        internal static WorkflowExpressionFragment TypeAs(WorkflowExpressionFragment expression, Type type) =>
            TypeOperation(expression, "as", type);

        private static WorkflowExpressionFragment TypeOperation(
            WorkflowExpressionFragment expression,
            string operatorToken,
            Type type) =>
            WorkflowExpressionFragment.Concat(
                expression.Parenthesized(),
                WorkflowExpressionFragment.Text(" " + operatorToken + " " + TypeName(type)));

        internal static WorkflowExpressionFragment Default(Type type) =>
            WorkflowExpressionFragment.Text("default(" + TypeName(type) + ")");

        internal static WorkflowExpressionFragment TypedNull(Type type) =>
            Cast(type, WorkflowExpressionFragment.Text("null"));

        internal static WorkflowExpressionFragment Literal(object value, Type declaredType)
        {
            if (value is Array or IDictionary or JToken)
                throw new NotSupportedException("Capture immutable scalar values, not mutable objects or collections.");
            if (value == null)
                return Cast(declaredType, WorkflowExpressionFragment.Text("null"));

            if (Nullable.GetUnderlyingType(declaredType) is Type underlying)
                return Cast(declaredType, Literal(value, underlying));

            var runtimeType = value.GetType();
            if (runtimeType != declaredType && declaredType.IsAssignableFrom(runtimeType))
                return Cast(declaredType, Literal(value, runtimeType));

            if (value is string text) return WorkflowExpressionFragment.Text(JsonConvert.ToString(text));
            if (value is bool flag) return WorkflowExpressionFragment.Text(flag ? "true" : "false");
            if (value is char character)
            {
                var escaped = JsonConvert.ToString(character.ToString());
                return WorkflowExpressionFragment.Text(
                    "'" + escaped.Substring(1, escaped.Length - 2).Replace("'", "\\'").Replace("\\\"", "\"") + "'");
            }

            if (value is Enum enumeration)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                    return WorkflowExpressionFragment.Text(CSharpSyntaxGenerator.TypeName(value.GetType()) + "." + name);

                var enumUnderlyingType = Enum.GetUnderlyingType(value.GetType());
                var enumValue = Convert.ChangeType(value, enumUnderlyingType, CultureInfo.InvariantCulture);
                return Cast(value.GetType(), Literal(enumValue, enumUnderlyingType));
            }

            if (value is DateTime date)
                return ObjectCreation(
                    typeof(DateTime),
                    new[]
                    {
                        Literal(date.Ticks, typeof(long)),
                        Literal(date.Kind, typeof(DateTimeKind)),
                    });
            if (value is DateTimeOffset offset)
                return ObjectCreation(
                    typeof(DateTimeOffset),
                    new[]
                    {
                        Literal(offset.Ticks, typeof(long)),
                        ObjectCreation(
                            typeof(TimeSpan),
                            new[] { Literal(offset.Offset.Ticks, typeof(long)) }),
                    });
            if (value is TimeSpan span)
                return ObjectCreation(
                    typeof(TimeSpan),
                    new[] { Literal(span.Ticks, typeof(long)) });
            if (value is Guid guid)
                return ObjectCreation(
                    typeof(Guid),
                    new[] { Literal(guid.ToString("D"), typeof(string)) });
            if (value is Uri uri)
                return ObjectCreation(
                    typeof(Uri),
                    new[]
                    {
                        Literal(uri.OriginalString, typeof(string)),
                        Literal(UriKind.RelativeOrAbsolute, typeof(UriKind)),
                    });
            if (value is HttpMethod method)
                return ObjectCreation(
                    typeof(HttpMethod),
                    new[] { Literal(method.Method, typeof(string)) });

            if (value is double number)
            {
                if (double.IsNaN(number)) return WorkflowExpressionFragment.Text("double.NaN");
                if (double.IsPositiveInfinity(number)) return WorkflowExpressionFragment.Text("double.PositiveInfinity");
                if (double.IsNegativeInfinity(number)) return WorkflowExpressionFragment.Text("double.NegativeInfinity");
                if (number == 0 && BitConverter.DoubleToInt64Bits(number) < 0)
                    return WorkflowExpressionFragment.Text("-0.0d");

                return WorkflowExpressionFragment.Text(number.ToString("R", CultureInfo.InvariantCulture) + "d");
            }

            if (value is float single)
            {
                if (float.IsNaN(single)) return WorkflowExpressionFragment.Text("float.NaN");
                if (float.IsPositiveInfinity(single)) return WorkflowExpressionFragment.Text("float.PositiveInfinity");
                if (float.IsNegativeInfinity(single)) return WorkflowExpressionFragment.Text("float.NegativeInfinity");
                if (single == 0 && BitConverter.ToInt32(BitConverter.GetBytes(single), 0) < 0)
                    return WorkflowExpressionFragment.Text("-0.0f");

                return WorkflowExpressionFragment.Text(single.ToString("R", CultureInfo.InvariantCulture) + "f");
            }

            if (value is decimal or long or ulong or uint or int or short or ushort or byte or sbyte)
            {
                var suffix = value is decimal ? "m" : value is long ? "L" :
                    value is ulong ? "UL" : value is uint ? "U" : "";
                var source = Convert.ToString(value, CultureInfo.InvariantCulture) + suffix;
                var literal = WorkflowExpressionFragment.Text(source);
                return value is byte or sbyte or short or ushort
                    ? Cast(value.GetType(), literal)
                    : literal;
            }

            throw new NotSupportedException(
                $"Cannot serialize captured value of type {value.GetType()}. Construct the object inside the lambda instead.");
        }

    }
}

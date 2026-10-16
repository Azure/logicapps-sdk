// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Text.RegularExpressions;
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
            if (string.IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[\p{L}_][\p{L}\p{Nd}_]*$"))
                throw new NotSupportedException($"Cannot emit C# identifier '{name}'.");
            
            return Keywords.Contains(name) ? "@" + name : name;
        }

        internal static string TypeName(Type type)
        {
            WorkflowExpressionTypePolicy.Validate(type);
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
                return TypeName(type.GetElementType()) + "[" + new string(',', type.GetArrayRank() - 1) + "]";
            if (Nullable.GetUnderlyingType(type) is Type underlying)
                return TypeName(underlying) + "?";
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
            return prefix +
                (type.IsGenericType
                    ? name + "<" + string.Join(", ", type.GetGenericArguments().Select(TypeName)) + ">"
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

        internal static SourceProgram Literal(object value, Type declaredType)
        {
            if (value is Array or IDictionary or JToken)
                throw new NotSupportedException("Capture immutable scalar values, not mutable objects or collections.");
            if (value == null)
                return Cast(declaredType, SourceProgram.Text("null"));

            if (Nullable.GetUnderlyingType(declaredType) is Type underlying)
                return Cast(declaredType, Literal(value, underlying));

            var runtimeType = value.GetType();
            if (runtimeType != declaredType && declaredType.IsAssignableFrom(runtimeType))
                return Cast(declaredType, Literal(value, runtimeType));

            if (value is string text) return SourceProgram.Text(JsonConvert.ToString(text));
            if (value is bool flag) return SourceProgram.Text(flag ? "true" : "false");
            if (value is char character)
            {
                var escaped = JsonConvert.ToString(character.ToString());
                return SourceProgram.Text(
                    "'" + escaped.Substring(1, escaped.Length - 2).Replace("'", "\\'").Replace("\\\"", "\"") + "'");
            }

            if (value is Enum enumeration)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                    return SourceProgram.Text(CSharpSyntaxGenerator.TypeName(value.GetType()) + "." + name);

                var enumUnderlyingType = Enum.GetUnderlyingType(value.GetType());
                var enumValue = Convert.ChangeType(value, enumUnderlyingType, CultureInfo.InvariantCulture);
                return Cast(value.GetType(), Literal(enumValue, enumUnderlyingType));
            }

            if (value is DateTime date)
                return SourceProgram.Text(
                    $"new global::System.DateTime({date.Ticks}L, global::System.DateTimeKind.{date.Kind})");
            if (value is DateTimeOffset offset)
                return SourceProgram.Text(
                    $"new global::System.DateTimeOffset({offset.Ticks}L, new global::System.TimeSpan({offset.Offset.Ticks}L))");
            if (value is TimeSpan span)
                return SourceProgram.Text($"new global::System.TimeSpan({span.Ticks}L)");
            if (value is Guid guid)
                return SourceProgram.Text(
                    "new global::System.Guid(" + JsonConvert.ToString(guid.ToString("D")) + ")");
            if (value is Uri uri)
                return SourceProgram.Text(
                    "new global::System.Uri(" + JsonConvert.ToString(uri.OriginalString) +
                    ", global::System.UriKind.RelativeOrAbsolute)");
            if (value is HttpMethod method)
                return SourceProgram.Text(
                    "new global::System.Net.Http.HttpMethod(" + JsonConvert.ToString(method.Method) + ")");

            if (value is double number)
            {
                if (double.IsNaN(number)) return SourceProgram.Text("double.NaN");
                if (double.IsPositiveInfinity(number)) return SourceProgram.Text("double.PositiveInfinity");
                if (double.IsNegativeInfinity(number)) return SourceProgram.Text("double.NegativeInfinity");
                if (number == 0 && BitConverter.DoubleToInt64Bits(number) < 0)
                    return SourceProgram.Text("-0.0d");
                
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

            if (value is decimal or long or ulong or uint or int or short or ushort or byte or sbyte)
            {
                var suffix = value is decimal ? "m" : value is long ? "L" :
                    value is ulong ? "UL" : value is uint ? "U" : "";
                var source = Convert.ToString(value, CultureInfo.InvariantCulture) + suffix;
                var literal = SourceProgram.Text(source);
                return value is byte or sbyte or short or ushort
                    ? Cast(value.GetType(), literal)
                    : literal;
            }

            throw new NotSupportedException(
                $"Cannot serialize captured value of type {value.GetType()}. Construct the object inside the lambda instead.");
        }

        private static SourceProgram Cast(Type type, SourceProgram value) =>
            SourceProgram.Concat(
                SourceProgram.Text(CSharpSyntaxGenerator.TypeName(type)).Parenthesized(),
                value.Parenthesized());
    }
}

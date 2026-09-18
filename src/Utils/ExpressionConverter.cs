// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Net.Http;
    using System.Reflection;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts SDK expression trees into workflow literals or native C# expressions.
    /// </summary>
    internal static class ExpressionConverter
    {
        private const string CSharpExpressionPrefix = "@csharp{";
        private static readonly LogicConverter Converter = new LogicConverter();

        public static string Convert(Expression<Func<string>> expression) =>
            ConvertScalar(expression);

        internal static string ConvertGenerated(Func<string> expression)
        {
            return ConvertGeneratedScalar(expression);
        }

        public static string Convert(Func<string> expression) =>
            ConvertGenerated(expression);

        public static string Convert(Func<Uri> expression) =>
            ConvertGenerated(expression);

        public static string Convert(Func<HttpMethod> expression) =>
            ConvertGenerated(expression);

        public static string Convert(Func<int> expression) =>
            ConvertGenerated(expression);

        public static string Convert(Func<double> expression) =>
            ConvertGenerated(expression);

        public static string Convert(Func<bool> expression) =>
            ConvertGenerated(expression);

        public static string Convert<T>(Func<T> expression)
            where T : Enum =>
            ConvertGenerated(expression);

        internal static string ConvertGenerated<T>(Func<T> expression)
        {
            return ConvertGeneratedScalar(expression);
        }

        private static string ConvertGeneratedScalar(Delegate expression)
        {
            var token = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToWorkflowToken();
            if (token.Type == JTokenType.Null)
                return null;

            return token.Type == JTokenType.String
                ? token.Value<string>()
                : token.ToString(Newtonsoft.Json.Formatting.None);
        }

        public static string Convert(Expression<Func<Uri>> expression) =>
            ConvertScalar(expression);

        public static string Convert(Expression<Func<HttpMethod>> expression) =>
            ConvertScalar(expression);

        public static string Convert(Expression<Func<int>> expression) =>
            ConvertScalar(expression);

        public static string Convert(Expression<Func<double>> expression) =>
            ConvertScalar(expression);

        public static string Convert(Expression<Func<bool>> expression) =>
            ConvertScalar(expression);

        public static JArray Convert(Expression<Func<string[]>> expression)
        {
            return ConvertO(expression) as JArray
                ?? throw new NotSupportedException("A runtime C# expression cannot be represented as a build-time JArray.");
        }

        public static string Convert<T>(Expression<Func<T>> expression)
            where T : Enum
        {
            var value = expression.Compile().Invoke();
            return Utility.GetEnumMemberValue(value);
        }

        public static string ConvertWithUrlEncoding(Expression<Func<string>> expression, int times)
        {
            if (expression == null)
                return string.Empty;

            return WrapInlineTemplate(
                WrapFunction(new InlineTemplateExpressionConverter().Convert(expression.Body), "encodeURIComponent", times));
        }

        public static string ConvertWithUrlEncodingWithInt(Expression<Func<int>> expression, int times)
        {
            if (expression == null)
                return string.Empty;

            return WrapInlineTemplate(
                WrapFunction(new InlineTemplateExpressionConverter().Convert(expression.Body), "encodeURIComponent", times));
        }

        public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> expression, int times)
            where T : Enum
        {
            var value = $"'{EscapeTemplateString(Convert(expression))}'";
            return WrapInlineTemplate(WrapFunction(value, "encodeURIComponent", times));
        }

        public static JToken ConvertO<T>(Expression<Func<T>> expression)
        {
            if (expression == null)
                return null;

            var converter = new ComplexObjectConverter();
            return expression.Body.Visit(converter, null);
        }

        internal static JToken ConvertGeneratedO<T>(Func<T> expression) =>
            GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToWorkflowToken();

        public static JToken ConvertO<T>(Func<T> expression) =>
            ConvertGeneratedO(expression);

        internal static string ConvertGeneratedWithUrlEncoding(
            Func<string> expression,
            int times)
        {
            var source = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToInlineTemplate();
            return WrapInlineTemplate(WrapFunction(source, "encodeURIComponent", times));
        }

        public static string ConvertWithUrlEncoding(
            Func<string> expression,
            int times) =>
            ConvertGeneratedWithUrlEncoding(expression, times);

        internal static string ConvertGeneratedWithUrlEncodingWithInt(
            Func<int> expression,
            int times)
        {
            var source = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToInlineTemplate();
            return WrapInlineTemplate(WrapFunction(source, "encodeURIComponent", times));
        }

        public static string ConvertWithUrlEncodingWithInt(
            Func<int> expression,
            int times) =>
            ConvertGeneratedWithUrlEncodingWithInt(expression, times);

        public static string ConvertWithUrlEncoding<T>(
            Func<T> expression,
            int times)
            where T : Enum
        {
            var source = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToInlineTemplate();
            return WrapInlineTemplate(WrapFunction(source, "encodeURIComponent", times));
        }

        public static string ConvertOWithBase64<T>(Expression<Func<T>> expression) =>
            WrapCSharp($"base64({ConvertToCSharp(expression)})");

        public static string ConvertOWithBase64<T>(Func<T> expression) =>
            WrapCSharp(
                $"base64({GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToCSharpSource()})");

        public static TResult ConvertObject<TResult>(Expression<Func<TResult>> expression)
        {
            var converter = new ObjectExpressionConverter();
            var converted = converter.Visit(expression.Body);
            return Expression.Lambda<Func<TResult>>(converted, expression.Parameters).Compile().Invoke();
        }

        internal static string ConvertToCSharp<T>(Expression<Func<T>> expression)
        {
            if (expression == null)
                return string.Empty;

            return Converter.VisitExpression(expression.Body, null);
        }

        internal static string ConvertToCSharpWithUrlEncoding(Expression<Func<string>> expression, int times) =>
            WrapFunction(ConvertToCSharp(expression), "encodeURIComponent", times);

        internal static string ConvertToCSharpWithUrlEncodingWithInt(Expression<Func<int>> expression, int times) =>
            WrapFunction(ConvertToCSharp(expression), "encodeURIComponent", times);

        internal static string ConvertEnumToCSharp<T>(Expression<Func<T>> expression)
            where T : Enum =>
            $"\"{EscapeString(Utility.GetEnumMemberValue(expression.Compile().Invoke()))}\"";

        internal static string ConvertToCSharpWithBase64<T>(Expression<Func<T>> expression) =>
            $"base64({ConvertToCSharp(expression)})";

        internal static JToken ConvertExpression(Expression expression)
        {
            if (TryConvertLiteral(expression, out var literal))
                return literal;

            return new JValue(WrapCSharp(Converter.VisitExpression(expression, null)));
        }

        internal static bool TryConvertLiteral(Expression expression, out JToken literal)
        {
            expression = StripConvert(expression);
            if (TryEvaluateLiteral(expression, out var value))
            {
                literal = ToLiteralToken(value, expression.Type);
                return true;
            }

            literal = null;
            return false;
        }

        private static string ConvertScalar<T>(Expression<Func<T>> expression)
        {
            if (expression == null)
                return string.Empty;

            if (TryConvertLiteral(expression.Body, out var literal))
            {
                if (literal.Type == JTokenType.Null)
                    return null;

                return literal.Type == JTokenType.String
                    ? literal.Value<string>()
                    : System.Convert.ToString(((JValue)literal).Value, CultureInfo.InvariantCulture);
            }

            return WrapCSharp(Converter.VisitExpression(expression.Body, null));
        }

        private static bool TryEvaluateLiteral(Expression expression, out object value)
        {
            if (expression is ConstantExpression constant)
            {
                value = constant.Value;
                return true;
            }

            if (expression is MemberExpression member)
            {
                if (member.Expression == null)
                {
                    value = GetMemberValue(member.Member, null);
                    return true;
                }

                if (TryEvaluateLiteral(StripConvert(member.Expression), out var instance) &&
                    instance is not IWorkflowOperation &&
                    !ImplementsGenericInterface(instance?.GetType(), typeof(IAgentToolContext<>)))
                {
                    var memberValue = GetMemberValue(member.Member, instance);
                    if (memberValue is not ForEachItemToken &&
                        memberValue is not IWorkflowOperation &&
                        !ImplementsGenericInterface(memberValue?.GetType(), typeof(IAgentToolContext<>)))
                    {
                        value = memberValue;
                        return true;
                    }
                }
            }

            value = null;
            return false;
        }

        private static object GetMemberValue(MemberInfo member, object instance)
        {
            return member switch
            {
                PropertyInfo property => property.GetValue(instance),
                FieldInfo field => field.GetValue(instance),
                _ => throw new NotSupportedException($"Member type '{member.MemberType}' cannot be evaluated as a literal."),
            };
        }

        private static bool ImplementsGenericInterface(Type type, Type genericInterface)
        {
            if (type == null)
                return false;

            return type.IsGenericType && type.GetGenericTypeDefinition() == genericInterface ||
                type.GetInterfaces().Any(candidate =>
                    candidate.IsGenericType &&
                    candidate.GetGenericTypeDefinition() == genericInterface);
        }

        private static JToken ToLiteralToken(object value, Type type)
        {
            if (value == null)
                return JValue.CreateNull();

            if (value is JToken token)
                return token;

            if (value is HttpMethod method)
                return new JValue(method.Method);

            if (value is Uri uri)
                return new JValue(uri.ToString());

            if (type.IsEnum)
                return new JValue(Utility.GetEnumMemberValue((Enum)value));

            return JToken.FromObject(value);
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

        private static string WrapFunction(string expression, string functionName, int times)
        {
            while (times-- > 0)
                expression = $"{functionName}({expression})";

            return expression;
        }

        private static string WrapCSharp(string expression) =>
            $"{CSharpExpressionPrefix}{expression}}}";

        private static string WrapInlineTemplate(string expression) =>
            $"@{{{expression}}}";

        private static string EscapeString(string value) =>
            value.Replace("\\", "\\\\").Replace("\"", "\\\"");

        private static string EscapeTemplateString(string value) =>
            value.Replace("'", "''");

        private sealed class ObjectExpressionConverter : ExpressionVisitor
        {
            protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
            {
                var isStringMember =
                    node.Member is PropertyInfo property && property.PropertyType == typeof(string) ||
                    node.Member is FieldInfo field && field.FieldType == typeof(string);

                if (!isStringMember)
                    return base.VisitMemberAssignment(node);

                var value = ConvertExpression(node.Expression);
                return Expression.Bind(
                    node.Member,
                    Expression.Constant(value.Type == JTokenType.Null ? null : value.Value<string>(), typeof(string)));
            }
        }
    }
}

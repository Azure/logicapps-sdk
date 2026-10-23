// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>Formats workflow descriptor boundaries.</summary>
    internal static class ExpressionConverter
    {
        public static JToken ConvertO<T>(WorkflowExpression<T> value)
        {
            if (value == null) return null;
            var literal = value.LiteralToken;
            if (literal != null) return Escape(literal);
            return WrapExpression(value.Render());
        }

        public static string Convert<T>(WorkflowExpression<T> value)
        {
            if (value == null) return null;
            if (value.LiteralToken is JToken literal) return literal.Type == JTokenType.Null ? null :
                literal.Type == JTokenType.String ? Escape(literal).Value<string>() : literal.ToString(Formatting.None);
            return WrapExpressionText(value.Render());
        }

        public static string ConvertCondition(WorkflowExpression<bool> value) =>
            WrapExpressionText(value.Render());

        public static JToken ConvertStatusCode(WorkflowExpression<System.Net.HttpStatusCode> value) =>
            value == null ? new JValue(200) : value.LiteralToken is JToken token ?
                new JValue((int)Enum.Parse(typeof(System.Net.HttpStatusCode), token.Value<string>())) :
                ConvertO(value.Cast<int>());

        public static string LiteralName(WorkflowExpression<string> value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value.LiteralToken?.Type != JTokenType.String) throw new NotSupportedException("Referenced variable names must be literal or captured strings.");
            return value.LiteralToken.Value<string>();
        }

        private static JValue WrapExpression(string source) =>
            new JValue(WrapExpressionText(source));

        private static string WrapExpressionText(string source) =>
            $"#{{{source}}}";

        private static JToken Escape(JToken token)
        {
            if (token.Type != JTokenType.String) return token;
            var text = token.Value<string>();
            if (text.StartsWith("#{", StringComparison.Ordinal) || text.Contains("@{"))
                return WrapExpression(CSharpSyntaxGenerator.Literal(text, typeof(string)).Render());
            return text.StartsWith("@", StringComparison.Ordinal) ? new JValue("@" + text) : token;
        }
    }
}

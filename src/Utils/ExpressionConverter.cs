// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Net.Http;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts source-generated workflow expressions into serialized workflow values.
    /// </summary>
    internal static class ExpressionConverter
    {
        private const string CSharpExpressionPrefix = "@csharp{";

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

        public static JToken ConvertO<T>(Func<T> expression) =>
            ConvertGeneratedO(expression);

        public static string ConvertWithUrlEncoding(
            Func<string> expression,
            int times) =>
            ConvertGeneratedWithUrlEncoding(expression, times);

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

        public static string ConvertOWithBase64<T>(Func<T> expression) =>
            WrapCSharp(
                $"base64({GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToCSharpSource()})");

        internal static string ConvertGenerated<T>(Func<T> expression)
        {
            var token = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToWorkflowToken();
            if (token.Type == JTokenType.Null)
                return null;

            return token.Type == JTokenType.String
                ? token.Value<string>()
                : token.ToString(Newtonsoft.Json.Formatting.None);
        }

        internal static JToken ConvertGeneratedO<T>(Func<T> expression) =>
            GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToWorkflowToken();

        internal static string ConvertGeneratedWithUrlEncoding(
            Func<string> expression,
            int times)
        {
            var source = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToInlineTemplate();
            return WrapInlineTemplate(WrapFunction(source, "encodeURIComponent", times));
        }

        internal static string ConvertGeneratedWithUrlEncodingWithInt(
            Func<int> expression,
            int times)
        {
            var source = GeneratedWorkflowExpressionRegistry.GetRequired(expression).ToInlineTemplate();
            return WrapInlineTemplate(WrapFunction(source, "encodeURIComponent", times));
        }

        private static string WrapFunction(
            string expression,
            string functionName,
            int times)
        {
            while (times-- > 0)
                expression = $"{functionName}({expression})";

            return expression;
        }

        private static string WrapCSharp(string expression) =>
            $"{CSharpExpressionPrefix}{expression}}}";

        private static string WrapInlineTemplate(string expression) =>
            $"@{{{expression}}}";
    }
}

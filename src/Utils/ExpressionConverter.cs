// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>Formats descriptor boundaries without interpreting authored C#.</summary>
    internal static class ExpressionConverter
    {
        public static JToken ConvertO<T>(WorkflowExpression<T> value)
        {
            if (value == null) return null;
            var literal = value.LiteralToken;
            if (literal != null) return Escape(literal);
            // Standard Newtonsoft serialization preserves SDK JSON attributes and enum wire names.
            var serializer = "new global::Newtonsoft.Json.JsonSerializer { Culture = global::System.Globalization.CultureInfo.InvariantCulture, " +
                "Converters = { new global::Newtonsoft.Json.Converters.StringEnumConverter() } }";
            return new JValue($"#{{((global::System.Func<global::Newtonsoft.Json.Linq.JToken>)(() => {{ object result = {value.Render()}; " +
                $"return result == null ? global::Newtonsoft.Json.Linq.JValue.CreateNull() : global::Newtonsoft.Json.Linq.JToken.FromObject(result, {serializer}); }}))()}}");
        }
        public static string Convert<T>(WorkflowExpression<T> value)
        {
            if (value == null) return null;
            if (value.LiteralToken is JToken literal) return literal.Type == JTokenType.Null ? null :
                literal.Type == JTokenType.String ? Escape(literal).Value<string>() : literal.ToString(Formatting.None);
            if (typeof(T) == typeof(Uri)) return $"#{{({value.Render()})?.OriginalString}}";
            if (typeof(T) == typeof(HttpMethod)) return $"#{{({value.Render()})?.Method}}";
            var tokenSource = ConvertO(value).Value<string>();
            return $"#{{((global::System.Func<string>)(() => {{ var token = {tokenSource.Substring(2, tokenSource.Length - 3)}; " +
                "return token.Type == global::Newtonsoft.Json.Linq.JTokenType.Null ? null : token.Type == global::Newtonsoft.Json.Linq.JTokenType.String ? " +
                "token.Value<string>() : token.ToString(global::Newtonsoft.Json.Formatting.None); }))()}";
        }
        public static string ConvertCondition(WorkflowExpression<bool> value) =>
            value.LiteralToken is JToken token ? (token.Value<bool>() ? "#{true}" : "#{false}") : "#{" + value.Render() + "}";
        public static JToken ConvertStatusCode(WorkflowExpression<System.Net.HttpStatusCode> value) =>
            value == null ? new JValue(200) : value.LiteralToken is JToken token ?
                new JValue((int)Enum.Parse(typeof(System.Net.HttpStatusCode), token.Value<string>())) : new JValue("#{" + "(int)(" + value.Render() + ")}");
        public static string LiteralName(WorkflowExpression<string> value)
        {
            WorkflowExpression.Validate(value, nameof(value), true);
            if (value.LiteralToken?.Type != JTokenType.String) throw new NotSupportedException("Referenced variable names must be literal or captured strings.");
            return value.LiteralToken.Value<string>();
        }
        public static string ConvertWithUrlEncoding<T>(WorkflowExpression<T> value, int times)
        {
            if (times < 0) throw new ArgumentOutOfRangeException(nameof(times));
            var source = Convert(value);
            source = source.StartsWith("#{", StringComparison.Ordinal) ? source.Substring(2, source.Length - 3) : JsonConvert.ToString(source);
            for (var index = 0; index < times; index++) source = "encodeURIComponent(" + source + ")";
            return "#{" + source + "}";
        }
        public static string ConvertOWithBase64<T>(WorkflowExpression<T> value)
        {
            if (value == null) return null;
            if (value.LiteralToken is JToken literal)
            {
                if (typeof(T) == typeof(byte[])) return literal.Value<string>("$content");
                return "#{" + "base64(" + JsonConvert.ToString(literal.Type == JTokenType.String ? literal.Value<string>() : literal.ToString(Formatting.None)) + ")}";
            }
            return typeof(T) == typeof(byte[]) ? "#{global::System.Convert.ToBase64String(" + value.Render() + ")}" :
                "#{base64(" + Strip(Convert(value)) + ")}";
        }
        public static string ConvertGeneratedPath(string format, params string[] arguments)
        {
            var sources = arguments.Select(argument => argument.StartsWith("#{", StringComparison.Ordinal) ? Strip(argument) : JsonConvert.ToString(argument)).ToArray();
            var pieces = new List<string>();
            var text = new System.Text.StringBuilder();
            for (var index = 0; index < format.Length; index++)
            {
                if (format[index] != '{') { text.Append(format[index]); continue; }
                var end = format.IndexOf('}', index);
                if (end < 0 || !int.TryParse(format.Substring(index + 1, end - index - 1), out var position) || position >= sources.Length)
                    throw new FormatException("Invalid generated connector path.");
                if (text.Length != 0) { pieces.Add(JsonConvert.ToString(text.ToString())); text.Clear(); }
                pieces.Add("(" + sources[position] + ")");
                index = end;
            }
            if (text.Length != 0) pieces.Add(JsonConvert.ToString(text.ToString()));
            return "#{" + string.Join(" + ", pieces) + "}";
        }
        private static string Strip(string source) => source.Substring(2, source.Length - 3);
        private static JToken Escape(JToken token)
        {
            if (token.Type != JTokenType.String) return token;
            var text = token.Value<string>();
            if (text.StartsWith("#{", StringComparison.Ordinal) || text.Contains("@{")) return new JValue("#{" + JsonConvert.ToString(text) + "}");
            return text.StartsWith("@", StringComparison.Ordinal) ? new JValue("@" + text) : token;
        }
    }
}

// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>Renders descriptors at workflow input boundaries without running their programs.</summary>
    internal static class ExpressionConverter
    {
        private const string Runtime = "global::Microsoft.Azure.Workflows.Sdk.WorkflowExpressionRuntime";

        public static JToken ConvertO<T>(WorkflowValue<T> value)
        {
            if (value == null) return null;
            if (value.IsLiteral) return EscapeLiteral(value.LiteralToken);
            return new JValue($"#{{{Runtime}.ToWire(1, ({value.RenderSource()}))}}");
        }

        public static string Convert<T>(WorkflowValue<T> value)
        {
            if (value == null) return null;
            if (!value.IsLiteral) return $"#{{{Runtime}.ToText(1, ({value.RenderSource()}))}}";
            var token = value.LiteralToken;
            var text = token.Type == JTokenType.Null ? null : token.Type == JTokenType.String ? token.Value<string>() : token.ToString(Newtonsoft.Json.Formatting.None);
            return text == null ? null : EscapeLiteral(new JValue(text)).Value<string>();
        }

        public static JToken ConvertObject<T>(WorkflowValue<T> value) => ConvertO(value);

        public static JToken ConvertCondition(WorkflowValue<bool> value) =>
            value.IsLiteral ? new JValue(value.LiteralToken.Value<bool>() ? "#{true}" : "#{false}") : ConvertO(value);

        public static string ConvertWithUrlEncoding<T>(WorkflowValue<T> value, int times)
        {
            if (times < 0) throw new ArgumentOutOfRangeException(nameof(times));
            WorkflowValue.Validate(value, nameof(value), required: true);
            var source = TextSource(value);
            for (var count = 0; count < times; count++) source = $"encodeURIComponent({source})";
            return $"#{{{source}}}";
        }

        public static string ConvertWithUrlEncodingWithInt(WorkflowValue<int> value, int times) => ConvertWithUrlEncoding(value, times);

        public static string ConvertGeneratedPath(string format, params string[] arguments)
        {
            var sources = arguments.Select(argument =>
                argument != null && argument.StartsWith("#{", StringComparison.Ordinal) && argument.EndsWith("}", StringComparison.Ordinal)
                    ? argument.Substring(2, argument.Length - 3)
                    : WorkflowValue.Quote(argument)).ToArray();
            var segments = new List<string>();
            var literal = new System.Text.StringBuilder();
            for (var index = 0; index < format.Length; index++)
            {
                if (index + 1 < format.Length && (format[index] == '{' || format[index] == '}') && format[index + 1] == format[index])
                {
                    literal.Append(format[index++]);
                }
                else if (format[index] == '{')
                {
                    var end = format.IndexOf('}', index + 1);
                    if (end < 0 || !int.TryParse(format.Substring(index + 1, end - index - 1), out var argumentIndex) ||
                        argumentIndex < 0 || argumentIndex >= sources.Length)
                        throw new FormatException("Connector paths require numbered argument placeholders.");
                    if (literal.Length > 0)
                    {
                        segments.Add(WorkflowValue.Quote(literal.ToString()));
                        literal.Clear();
                    }
                    segments.Add("(" + sources[argumentIndex] + ")");
                    index = end;
                }
                else if (format[index] == '}')
                    throw new FormatException("Unexpected closing brace in connector path.");
                else
                    literal.Append(format[index]);
            }
            if (literal.Length > 0) segments.Add(WorkflowValue.Quote(literal.ToString()));
            return $"#{{{string.Join(" + ", segments)}}}";
        }

        public static string ConvertOWithBase64<T>(WorkflowValue<T> value)
        {
            if (value == null) return null;
            if (value.IsLiteral)
            {
                if (typeof(T) == typeof(byte[]) && value.LiteralToken is JObject binary)
                    return binary.Value<string>("$content");
                return $"#{{base64({WorkflowValue.Quote(value.LiteralToken.Type == JTokenType.String ? value.LiteralToken.Value<string>() : value.LiteralToken.ToString(Newtonsoft.Json.Formatting.None))})}}";
            }
            return $"#{{{Runtime}.ToBase64(1, ({value.RenderSource()}))}}";
        }

        public static JToken ConvertStatusCode(WorkflowValue<System.Net.HttpStatusCode> value)
        {
            if (value == null) return new JValue(200);
            if (value.IsLiteral)
            {
                var status = (System.Net.HttpStatusCode)Enum.Parse(typeof(System.Net.HttpStatusCode), value.LiteralToken.Value<string>());
                if ((int)status == 0) throw new ArgumentOutOfRangeException(nameof(value), "Response status code cannot be zero.");
                return new JValue((int)status);
            }
            return new JValue($"#{{(int)({value.RenderSource()})}}");
        }

        internal static string LiteralName(WorkflowValue<string> name)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            if (!name.IsLiteral) throw new NotSupportedException("A referenced variable name must be a literal or captured string.");
            return name.LiteralToken.Value<string>();
        }

        private static string TextSource<T>(WorkflowValue<T> value) =>
            value.IsLiteral
                ? WorkflowValue.Quote(value.LiteralToken.Type == JTokenType.String ? value.LiteralToken.Value<string>() : value.LiteralToken.ToString(Newtonsoft.Json.Formatting.None))
                : $"{Runtime}.ToText(1, ({value.RenderSource()}))";

        private static JToken EscapeLiteral(JToken token)
        {
            if (token.Type == JTokenType.String)
            {
                var text = token.Value<string>();
                if (text.StartsWith("#{", StringComparison.Ordinal) || text.Contains("@{"))
                    return new JValue($"#{{{WorkflowValue.Quote(text)}}}");
                if (text.StartsWith("@", StringComparison.Ordinal)) return new JValue("@" + text);
            }
            return token;
        }
    }
}

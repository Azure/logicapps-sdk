// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Represents content serialized as a base64 string for connector inputs.
    /// </summary>
    [JsonConverter(typeof(WorkflowBinaryContentConverter))]
    public sealed class WorkflowBinaryContent
    {
        private readonly ContentKind kind;
        private readonly object value;

        private WorkflowBinaryContent(ContentKind kind, object value)
        {
            this.kind = kind;
            this.value = value;
        }

        /// <summary>
        /// Creates binary content from a workflow value, including a content envelope.
        /// </summary>
        public static WorkflowBinaryContent FromWorkflowContent(object value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            return value as WorkflowBinaryContent ?? new WorkflowBinaryContent(ContentKind.Workflow, value);
        }

        /// <summary>
        /// Creates binary content from raw bytes.
        /// </summary>
        public static WorkflowBinaryContent FromBytes(byte[] value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            return new WorkflowBinaryContent(ContentKind.Bytes, (byte[])value.Clone());
        }

        /// <summary>
        /// Creates binary content from an existing base64 string.
        /// </summary>
        public static WorkflowBinaryContent FromBase64(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            ValidateBase64(value);
            return new WorkflowBinaryContent(ContentKind.Base64, value);
        }

        /// <inheritdoc/>
        public override string ToString() => this.GetBase64();

        internal string GetBase64()
        {
            return this.kind switch
            {
                ContentKind.Base64 => (string)this.value,
                ContentKind.Bytes => Convert.ToBase64String((byte[])this.value),
                ContentKind.Workflow => EncodeWorkflowValue(this.value),
                _ => throw new InvalidOperationException($"Unsupported binary content kind '{this.kind}'."),
            };
        }

        private static string EncodeWorkflowValue(object value)
        {
            if (value is byte[] bytes)
            {
                return Convert.ToBase64String(bytes);
            }

            var token = value as JToken ?? JToken.FromObject(value, CreateSerializer());
            if (TryGetEnvelopeContent(token, out var envelopeContent))
            {
                ValidateBase64(envelopeContent);
                return envelopeContent;
            }

            return token.Type switch
            {
                JTokenType.Bytes => Convert.ToBase64String(token.Value<byte[]>()),
                JTokenType.String => Convert.ToBase64String(Encoding.UTF8.GetBytes(token.Value<string>())),
                JTokenType.Object or JTokenType.Array => Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(token.ToString(Formatting.None))),
                _ => throw new NotSupportedException(
                    $"Workflow binary content does not support values of type '{token.Type}'."),
            };
        }

        private static JsonSerializer CreateSerializer()
        {
            var serializer = new JsonSerializer
            {
                Culture = System.Globalization.CultureInfo.InvariantCulture,
                TypeNameHandling = TypeNameHandling.None,
            };
            serializer.Converters.Add(new StringEnumConverter());
            return serializer;
        }

        private static bool TryGetEnvelopeContent(JToken token, out string content)
        {
            if (token is JObject envelope &&
                envelope["$content-type"]?.Type == JTokenType.String &&
                envelope["$content"]?.Type == JTokenType.String)
            {
                content = envelope["$content"].Value<string>();
                return true;
            }

            content = null;
            return false;
        }

        private static void ValidateBase64(string value)
        {
            try
            {
                Convert.FromBase64String(value);
            }
            catch (FormatException exception)
            {
                throw new ArgumentException("The value must be a valid base64 string.", nameof(value), exception);
            }
        }

        private enum ContentKind
        {
            Workflow,
            Bytes,
            Base64,
        }
    }

    internal sealed class WorkflowBinaryContentConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(WorkflowBinaryContent);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((WorkflowBinaryContent)value).GetBase64());
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            if (reader.TokenType != JsonToken.String)
            {
                throw new JsonSerializationException("Workflow binary content must be a base64 string.");
            }

            return WorkflowBinaryContent.FromBase64((string)reader.Value);
        }
    }
}

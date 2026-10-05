// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections;
    using System.Globalization;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;

    /// <summary>Defines the shared versioned value contract for SDK and host expression execution.</summary>
    public static class WorkflowExpressionRuntime
    {
        public const int ContractVersion = 1;

        public static void CheckVersion(int version)
        {
            if (version != ContractVersion)
                throw new NotSupportedException($"Workflow expression contract {version} is unsupported; the host supports {ContractVersion}.");
        }

        public static T Run<T>(int version, Func<T> program)
        {
            CheckVersion(version);
            return program();
        }

        public static JToken ToWire<T>(int version, T value)
        {
            CheckVersion(version);
            if (value == null) return JValue.CreateNull();
            if (value is HttpMethod method) return new JValue(method.Method);
            if (value is Uri uri) return new JValue(uri.OriginalString);
            var token = JToken.FromObject(value, CreateSerializer(wireEnums: true));
            ValidateJson(token);
            return NormalizeWireToken(token);
        }

        public static string ToText<T>(int version, T value)
        {
            var token = ToWire(version, value);
            if (token.Type == JTokenType.Null) return null;
            return token.Type == JTokenType.String
                ? token.Value<string>()
                : token.ToString(Formatting.None);
        }

        public static string ToBase64<T>(int version, T value)
        {
            CheckVersion(version);
            if (value == null) return null;
            return value is byte[] bytes
                ? Convert.ToBase64String(bytes)
                : Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ToText(version, value)));
        }

        public static T DecodeCapture<T>(int version, string json)
        {
            CheckVersion(version);
            ValidateCaptureType(typeof(T));
            using var reader = new JsonTextReader(new System.IO.StringReader(json)) { DateParseHandling = DateParseHandling.None };
            return CreateSerializer(wireEnums: false).Deserialize<T>(reader);
        }

        internal static string EncodeCapture<T>(T value)
        {
            ValidateCaptureType(typeof(T));
            ValidateCaptureValue(value, new HashSet<object>(ReferenceComparer.Instance));
            var serializer = CreateSerializer(wireEnums: false);
            using var writer = new System.IO.StringWriter(CultureInfo.InvariantCulture);
            using var jsonWriter = new JsonTextWriter(writer);
            serializer.Serialize(jsonWriter, value, typeof(T));
            return writer.ToString();
        }

        private static void ValidateCaptureType(Type type)
        {
            if (Nullable.GetUnderlyingType(type) is Type underlying)
            {
                ValidateCaptureType(underlying);
                return;
            }
            if (type == typeof(string) || type == typeof(char) || type == typeof(bool) ||
                type == typeof(byte) || type == typeof(sbyte) || type == typeof(short) || type == typeof(ushort) ||
                type == typeof(int) || type == typeof(uint) || type == typeof(long) || type == typeof(ulong) ||
                type == typeof(float) || type == typeof(double) || type == typeof(decimal) ||
                type == typeof(Uri) || type == typeof(HttpMethod) || type == typeof(Guid) ||
                type == typeof(DateTime) || type == typeof(DateTimeOffset) || type == typeof(TimeSpan) ||
                (type.Assembly == typeof(JToken).Assembly && typeof(JToken).IsAssignableFrom(type)) ||
                (type.IsEnum && (type.Assembly == typeof(WorkflowValue).Assembly || type.Assembly == typeof(int).Assembly)))
                return;
            if (type.IsArray && type.GetArrayRank() == 1)
            {
                ValidateCaptureType(type.GetElementType());
                return;
            }
            if (type.IsGenericType)
            {
                var definition = type.GetGenericTypeDefinition();
                if (definition == typeof(List<>) || definition == typeof(IReadOnlyList<>) || definition == typeof(IEnumerable<>))
                {
                    ValidateCaptureType(type.GetGenericArguments()[0]);
                    return;
                }
                if ((definition == typeof(Dictionary<,>) || definition == typeof(IReadOnlyDictionary<,>)) &&
                    type.GetGenericArguments()[0] == typeof(string))
                {
                    ValidateCaptureType(type.GetGenericArguments()[1]);
                    return;
                }
            }
            throw new NotSupportedException($"Captured type '{type}' is unsupported. Capture typed scalar values, JSON, arrays, lists or string-keyed dictionaries.");
        }

        private static void ValidateCaptureValue(object value, HashSet<object> active)
        {
            if (value == null) return;
            var type = value.GetType();
            ValidateCaptureType(type);
            if (value is JToken token)
            {
                ValidateJson(token);
                return;
            }
            if (value is double number && (double.IsNaN(number) || double.IsInfinity(number)) ||
                value is float single && (float.IsNaN(single) || float.IsInfinity(single)))
                throw new NotSupportedException("Non-finite captured numbers are not JSON values.");
            if (value is string || !(value is IEnumerable values)) return;
            if (!active.Add(value)) throw new NotSupportedException("Cyclic captured collections are unsupported.");
            try
            {
                if (value is IDictionary dictionary)
                {
                    foreach (DictionaryEntry entry in dictionary) ValidateCaptureValue(entry.Value, active);
                }
                else
                    foreach (var item in values) ValidateCaptureValue(item, active);
            }
            finally { active.Remove(value); }
        }

        private static void ValidateJson(JToken token)
        {
            if (token is JValue value)
            {
                if (value.Type == JTokenType.Raw || value.Type == JTokenType.Undefined ||
                    value.Value is double number && (double.IsNaN(number) || double.IsInfinity(number)) ||
                    value.Value is float single && (float.IsNaN(single) || float.IsInfinity(single)))
                    throw new NotSupportedException("The expression contains a value that cannot be represented as workflow JSON.");
            }
            foreach (var child in token.Children()) ValidateJson(child);
        }

        private static JToken NormalizeWireToken(JToken token)
        {
            if (token is JObject obj)
                return new JObject(obj.Properties().Select(property => new JProperty(property.Name, NormalizeWireToken(property.Value))));
            if (token is JArray array)
                return new JArray(array.Select(NormalizeWireToken));
            if (token is JValue value)
            {
                if (value.Value is byte[] bytes)
                    return new JObject { ["$content-type"] = "application/octet-stream", ["$content"] = Convert.ToBase64String(bytes) };
                if (value.Value is DateTime date)
                    return new JValue(date.ToString("O", CultureInfo.InvariantCulture));
                if (value.Value is DateTimeOffset offset)
                    return new JValue(offset.ToString("O", CultureInfo.InvariantCulture));
            }
            return token.DeepClone();
        }

        private static JsonSerializer CreateSerializer(bool wireEnums)
        {
            var serializer = new JsonSerializer
            {
                Culture = CultureInfo.InvariantCulture,
                TypeNameHandling = TypeNameHandling.None,
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
                DateParseHandling = DateParseHandling.None,
                FloatParseHandling = FloatParseHandling.Decimal,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                ReferenceLoopHandling = ReferenceLoopHandling.Error,
                ContractResolver = new ExpressionContractResolver(),
            };
            if (wireEnums) serializer.Converters.Add(new StringEnumConverter());
            serializer.Converters.Add(new HttpMethodConverter());
            return serializer;
        }

        private sealed class ExpressionContractResolver : DefaultContractResolver
        {
            protected override JsonContract CreateContract(Type type)
            {
                if (typeof(Delegate).IsAssignableFrom(type) || typeof(Type).IsAssignableFrom(type) ||
                    typeof(System.Threading.Tasks.Task).IsAssignableFrom(type) || typeof(System.IO.Stream).IsAssignableFrom(type))
                    throw new NotSupportedException($"Type '{type}' cannot be a workflow value.");
                return base.CreateContract(type);
            }
        }

        private sealed class HttpMethodConverter : JsonConverter
        {
            public override bool CanConvert(Type type) => type == typeof(HttpMethod);
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
                writer.WriteValue(((HttpMethod)value)?.Method);
            public override object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer) =>
                reader.TokenType == JsonToken.Null ? null : new HttpMethod((string)reader.Value);
        }

        private sealed class ReferenceComparer : IEqualityComparer<object>
        {
            internal static readonly ReferenceComparer Instance = new ReferenceComparer();
            public new bool Equals(object left, object right) => ReferenceEquals(left, right);
            public int GetHashCode(object value) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(value);
        }
    }
}

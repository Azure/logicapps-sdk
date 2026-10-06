// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;

    /// <summary>Wire conversions used when emitted workflow expressions execute at runtime.</summary>
    public static class WorkflowWireRuntime
    {
        internal static string EnumWire(Enum value)
        {
            var type = value.GetType();
            var numeric = value.ToString("D");
            var names = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => ((Enum)f.GetValue(null)).ToString("D") == numeric)
                .Select(f => f.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? f.Name)
                .Distinct(StringComparer.Ordinal).ToArray();
            if (names.Length > 1) throw new NotSupportedException($"Enum '{type.FullName}' has conflicting wire aliases for {numeric}.");
            return names.Length == 1 ? names[0] : value.ToString();
        }

        internal static bool IsNumber(Type type) =>
            type != typeof(bool) && type != typeof(char) && type != typeof(IntPtr) && type != typeof(UIntPtr) && type.IsPrimitive || type == typeof(decimal);

        /// <summary>Normalizes one evaluated nullable or token value under its explicit destination schema.</summary>
        public static string NormalizeAndEncode(object value, string schema)
        {
            var destination = WorkflowDestination.Parse(schema);
            if (value is JValue scalar) value = scalar.Value;
            if (value == null)
            {
                if (!destination.Nullable) throw WorkflowDestination.Error(destination.Name, "A required non-null value cannot be null.");
                return null;
            }
            var type = value.GetType();
            var numeric = IsNumber(type);
            if (destination.Kind == "text" && !(value is string || value is char) ||
                destination.Kind == "number" && !numeric ||
                destination.Kind == "boolean" && !(value is bool) ||
                destination.Kind == "bytes" && !(value is byte[]) ||
                destination.Kind == "uri" && !(value is Uri) ||
                destination.Kind == "httpMethod" && !(value is System.Net.Http.HttpMethod) ||
                destination.Kind == "enum" && !(value is Enum))
                throw new NotSupportedException($"Destination '{destination.Name}' does not support encoding normalization of '{type.FullName}'.");
            string text;
            var binary = value as byte[];
            if (value is Enum choice)
                text = RequireEnumWire(EnumWire(choice),
                    destination.EnumValues == null ? null : System.Linq.Enumerable.ToArray(destination.EnumValues),
                    destination.Nullable, destination.Name);
            else if (value is string str) text = str;
            else if (value is char character) text = character.ToString();
            else if (value is bool boolean) text = boolean ? "true" : "false";
            else if (value is Uri uri) text = uri.OriginalString;
            else if (value is System.Net.Http.HttpMethod method) text = method.Method;
            else if (numeric)
            {
                if (value is double d && (double.IsNaN(d) || double.IsInfinity(d)) ||
                    value is float f && (float.IsNaN(f) || float.IsInfinity(f)))
                    throw WorkflowDestination.Error(destination.Name, "Non-finite numbers cannot be normalized.");
                text = System.Convert.ToString(value, CultureInfo.InvariantCulture);
            }
            else if (binary != null) text = null;
            else if (destination.SerializerProfile == "compact-json-v1") text = ToCompactJson(value);
            else throw new NotSupportedException($"Destination '{destination.Name}' has no serialization profile for '{type.FullName}'.");
            foreach (var transform in destination.Transforms)
            {
                if (transform == "base64")
                {
                    if (destination.InputEncoding == "base64") continue;
                    text = System.Convert.ToBase64String(binary ?? System.Text.Encoding.UTF8.GetBytes(text));
                    binary = null;
                }
                else
                {
                    if (binary != null) throw WorkflowDestination.Error(destination.Name, "Raw binary requires base64 before URL encoding.");
                    text = Uri.EscapeDataString(text);
                }
            }
            if (binary != null) throw WorkflowDestination.Error(destination.Name, "Raw binary requires an explicit base64 transform.");
            return text;
        }

        /// <summary>
        /// Serializes a runtime value with a fixed compact JSON profile and SDK enum wire names.
        /// Custom converters, custom naming strategies, raw JSON, and non-finite numbers are unsupported.
        /// This method must not be used to evaluate authored delegates during definition generation.
        /// </summary>
        public static string ToCompactJson(object value)
        {
            var serializer = new JsonSerializer
            {
                Culture = CultureInfo.InvariantCulture,
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                ContractResolver = new WireContractResolver(),
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
                TypeNameHandling = TypeNameHandling.None,
                StringEscapeHandling = StringEscapeHandling.Default,
                FloatFormatHandling = FloatFormatHandling.String,
                ReferenceLoopHandling = ReferenceLoopHandling.Error,
                PreserveReferencesHandling = PreserveReferencesHandling.None
            };
            serializer.Converters.Add(new WireEnumConverter());

            using (var text = new StringWriter(CultureInfo.InvariantCulture))
            using (var writer = new WireJsonWriter(text))
            {
                serializer.Serialize(writer, value);
                writer.Flush();
                return text.ToString();
            }
        }

        /// <summary>Validates a wire string against an optional, ordinal closed set of allowed values.</summary>
        public static string RequireEnumWire(string value, string[] allowed, bool nullable, string destination)
        {
            RequireText(value, nullable, destination);
            if (value == null || allowed == null)
                return value;

            foreach (var candidate in allowed)
            {
                if (string.Equals(value, candidate, StringComparison.Ordinal))
                    return value;
            }

            throw new ArgumentException(
                $"Wire value '{value}' is not allowed for '{destination}'. Allowed values: {string.Join(", ", allowed)}.",
                destination);
        }

        /// <summary>Validates the nullability of a runtime text value without changing its contents.</summary>
        public static string RequireText(string value, bool nullable, string destination)
        {
            if (value == null && !nullable)
                throw new ArgumentException($"A non-null wire value is required for '{destination}'.", destination);
            return value;
        }

        private sealed class WireContractResolver : DefaultContractResolver
        {
            internal WireContractResolver()
            {
                NamingStrategy = new DefaultNamingStrategy();
            }

            protected override JsonContract CreateContract(Type objectType)
            {
                RejectConverter(objectType, objectType.FullName);
                var attribute = objectType.GetCustomAttribute<JsonContainerAttribute>(inherit: true);
                if (attribute?.ItemConverterType != null)
                    throw Unsupported("item converter", objectType.FullName);
                if (attribute?.NamingStrategyType != null)
                    throw Unsupported("naming strategy", objectType.FullName);

                var contract = base.CreateContract(objectType);
                contract.IsReference = false;
                if (contract is JsonContainerContract container)
                {
                    container.ItemIsReference = false;
                    container.ItemTypeNameHandling = TypeNameHandling.None;
                }
                if (contract is JsonObjectContract objectContract)
                    objectContract.ItemNullValueHandling = NullValueHandling.Include;
                return contract;
            }

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var destination = member.DeclaringType.FullName + "." + member.Name;
                RejectConverter(member, destination);
                var attribute = member.GetCustomAttribute<JsonPropertyAttribute>(inherit: true);
                if (attribute?.ItemConverterType != null)
                    throw Unsupported("item converter", destination);
                if (attribute?.NamingStrategyType != null)
                    throw Unsupported("naming strategy", destination);

                var property = base.CreateProperty(member, memberSerialization);
                property.NullValueHandling = NullValueHandling.Include;
                property.DefaultValueHandling = DefaultValueHandling.Include;
                property.TypeNameHandling = TypeNameHandling.None;
                property.ItemTypeNameHandling = TypeNameHandling.None;
                property.IsReference = false;
                property.ItemIsReference = false;
                return property;
            }

            private static void RejectConverter(MemberInfo member, string destination)
            {
                if (member.IsDefined(typeof(JsonConverterAttribute), inherit: true))
                    throw Unsupported("converter", destination);
            }

            private static NotSupportedException Unsupported(string feature, string destination) =>
                new NotSupportedException($"Custom JSON {feature} on '{destination}' is unsupported by the workflow wire profile.");
        }

        private sealed class WireEnumConverter : JsonConverter
        {
            public override bool CanRead => false;

            public override bool CanConvert(Type objectType) =>
                (Nullable.GetUnderlyingType(objectType) ?? objectType).IsEnum;

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                if (value == null)
                    writer.WriteNull();
                else
                    writer.WriteValue(EnumWire((Enum)value));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) =>
                throw new NotSupportedException("Workflow wire conversion only supports serialization.");
        }

        // Validate at the writer boundary so JValue numbers cannot bypass the finite-number check.
        private sealed class WireJsonWriter : JsonTextWriter
        {
            internal WireJsonWriter(TextWriter writer) : base(writer) { }

            public override void WriteValue(double value)
            {
                if (double.IsNaN(value) || double.IsInfinity(value))
                    throw new JsonSerializationException("Non-finite numbers are unsupported by the workflow wire profile.");
                base.WriteValue(value);
            }

            public override void WriteValue(float value)
            {
                if (float.IsNaN(value) || float.IsInfinity(value))
                    throw new JsonSerializationException("Non-finite numbers are unsupported by the workflow wire profile.");
                base.WriteValue(value);
            }

            public override void WriteValue(double? value)
            {
                if (value.HasValue)
                    WriteValue(value.Value);
                else
                    WriteNull();
            }

            public override void WriteValue(float? value)
            {
                if (value.HasValue)
                    WriteValue(value.Value);
                else
                    WriteNull();
            }

            public override void WriteRaw(string json) =>
                throw new NotSupportedException("Raw JSON is unsupported by the workflow wire profile.");

            public override void WriteRawValue(string json) =>
                throw new NotSupportedException("Raw JSON is unsupported by the workflow wire profile.");
        }
    }
}

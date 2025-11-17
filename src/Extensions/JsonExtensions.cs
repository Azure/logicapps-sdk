// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// The json extensions.
    /// </summary>
    public static class JsonExtensions
    {
        /// <summary>
        /// The max depth for serialization.
        /// </summary>
        public const int JsonSerializationMaxDepth = 512;

        /// <summary>
        /// The JSON object type serializer.
        /// </summary>
        public static readonly JsonSerializer JsonObjectTypeSerializer = JsonSerializer.Create(JsonExtensions.ObjectSerializationSettings);

        /// <summary>
        /// The JSON object serialization settings.
        /// </summary>
        public static readonly JsonSerializerSettings ObjectSerializationSettings = new JsonSerializerSettings
        {
            MaxDepth = JsonSerializationMaxDepth,
            TypeNameHandling = TypeNameHandling.None,

            DateParseHandling = DateParseHandling.None,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,

            NullValueHandling = NullValueHandling.Ignore,

            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters =
            {
                new StringEnumConverter(),
                new VersionConverter(),
            }
        };

        /// <summary>
        /// Serialize object to JToken.
        /// </summary>
        /// <param name="value">The object.</param>
        public static JToken ToJToken(this object value)
        {
            return JToken.FromObject(value, JsonExtensions.JsonObjectTypeSerializer);
        }

        /// <summary>
        /// Serialize object to JToken.
        /// </summary>
        /// <param name="value">The object.</param>
        public static string ToJson(this object value)
        {
            return JsonConvert.SerializeObject(value, JsonExtensions.ObjectSerializationSettings);
        }
    }
}

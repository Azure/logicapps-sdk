// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Serializes run-after statuses using the uppercase values required by workflow definitions.
    /// </summary>
    internal sealed class FlowStatusDictionaryJsonConverter : JsonConverter
    {
        public override bool CanRead => false;

        public override bool CanConvert(Type objectType)
        {
            return typeof(Dictionary<string, FlowStatus[]>).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var runAfter = (Dictionary<string, FlowStatus[]>)value;
            writer.WriteStartObject();
            foreach (var dependency in runAfter)
            {
                writer.WritePropertyName(dependency.Key);
                writer.WriteStartArray();
                foreach (var status in dependency.Value)
                {
                    writer.WriteValue(status.ToString().ToUpperInvariant());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}

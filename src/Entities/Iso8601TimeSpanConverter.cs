// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Globalization;
    using System.Xml;
    using Newtonsoft.Json;

    internal sealed class Iso8601TimeSpanConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteValue(XmlConvert.ToString((TimeSpan)value));
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null && objectType == typeof(TimeSpan?))
            {
                return null;
            }

            if (reader.TokenType != JsonToken.String)
            {
                throw new JsonSerializationException(
                    $"Expected an ISO 8601 duration string but found {reader.TokenType}.");
            }

            try
            {
                return XmlConvert.ToTimeSpan(Convert.ToString(reader.Value, CultureInfo.InvariantCulture));
            }
            catch (FormatException exception)
            {
                throw new JsonSerializationException("The value is not a valid ISO 8601 duration.", exception);
            }
        }
    }
}

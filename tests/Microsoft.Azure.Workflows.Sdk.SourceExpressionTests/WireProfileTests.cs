// Copyright (c) Microsoft Corporation. All rights reserved.

#nullable disable
namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

[Collection("Runtime serialization globals")]
public class WireProfileTests
{
    [Fact]
    public void CompactProfileDoesNotConsultAmbientSettings()
    {
        var original = JsonConvert.DefaultSettings;
        var calls = 0;
        try
        {
            JsonConvert.DefaultSettings = () =>
            {
                calls++;
                return new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.All,
                    StringEscapeHandling = StringEscapeHandling.EscapeHtml,
                    Culture = CultureInfo.GetCultureInfo("fr-FR"),
                    Converters = { new UnexpectedConverter() }
                };
            };

            Assert.Equal("{\"PascalName\":\"<tag>\",\"Missing\":null,\"Count\":0,\"Number\":1.5}",
                WorkflowWireRuntime.ToCompactJson(new { PascalName = "<tag>", Missing = (string)null, Count = 0, Number = 1.5 }));
            Assert.Equal(0, calls);
        }
        finally
        {
            JsonConvert.DefaultSettings = original;
        }
    }

    [Fact]
    public void EnumValuesUseMetadataWhileNumericValuesRemainNumbers()
    {
        Assert.Equal("[\"first /+\",1,\"Second\",null]",
            WorkflowWireRuntime.ToCompactJson(new object[] { Choice.First, (int)Choice.First, Choice.Second, (Choice?)null }));
        Assert.Equal("\"first /+\"", WorkflowWireRuntime.ToCompactJson((Choice?)Choice.First));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(99)]
    [InlineData(null)]
    public void Literal_and_runtime_enum_normalization_share_the_same_wire_policy(int? number)
    {
        Choice? value = number.HasValue ? (Choice)number.Value : null;
        var action = WorkflowActions.BuiltIn.Compose(SourceExpression.Literal(1, value));
        var literal = ConsumerCompilation.Token(action.GetActionDefinition("Enum")).Value<string>();
        Assert.Equal(literal, JToken.Parse(WorkflowWireRuntime.ToCompactJson(value)).Value<string>());
        var expected = literal == null ? null : Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(literal));
        Assert.Equal(expected, WorkflowWireRuntime.NormalizeAndEncode(value, """
            {"version":1,"destination":"choice","kind":"enum","enumPolicy":"open",
             "nullable":true,"optional":false,"transforms":["base64"],"inputEncoding":"raw"}
            """));
    }

    [Fact]
    public void ConflictingEnumAliasesFailRatherThanChoosingOne()
    {
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(AmbiguousChoice.First));
    }

    [Fact]
    public void DeclaredNamesArePreservedButPropertyProfileOverridesAreNot()
    {
        Assert.Equal("{\"wire-name\":null,\"Count\":0}", WorkflowWireRuntime.ToCompactJson(new NamedPayload()));
    }

    [Fact]
    public void DatesAndNumbersUseInvariantCompactProfile()
    {
        var original = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
            Assert.Equal("[\"2026-09-18T10:00:00Z\",1.25]",
                WorkflowWireRuntime.ToCompactJson(new object[] { new DateTime(2026, 9, 18, 10, 0, 0, DateTimeKind.Utc), 1.25m }));
        }
        finally
        {
            CultureInfo.CurrentCulture = original;
        }
    }

    [Fact]
    public void NullRootIsJsonNull()
    {
        Assert.Equal("null", WorkflowWireRuntime.ToCompactJson(null));
    }

    [Fact]
    public void RuntimeValueAndPropertyAreEvaluatedOnce()
    {
        var calls = 0;
        var payload = new CountingPayload();
        CountingPayload Next()
        {
            calls++;
            return payload;
        }

        Assert.Equal("{\"Value\":\"first /+\"}", WorkflowWireRuntime.ToCompactJson(Next()));
        Assert.Equal(1, calls);
        Assert.Equal(1, payload.Reads);
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void NonFiniteNumbersFailIncludingTokens(double value)
    {
        Assert.Throws<JsonSerializationException>(() => WorkflowWireRuntime.ToCompactJson(value));
        Assert.Throws<JsonSerializationException>(() => WorkflowWireRuntime.ToCompactJson(new { Value = (float)value }));
        Assert.Throws<JsonSerializationException>(() => WorkflowWireRuntime.ToCompactJson(new JArray(new JValue(value))));
    }

    [Fact]
    public void RawJsonCannotBypassCompactProfile()
    {
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new JRaw("{ \"indented\": true }")));
    }

    [Fact]
    public void CustomConvertersFailBeforeBeingConstructed()
    {
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new ConvertedPayload()));
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new ConvertedPropertyPayload()));
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new ConvertedItemsPayload()));
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new ConvertedContainerPayload()));
    }

    [Fact]
    public void CustomNamingStrategiesFailRatherThanChangingNames()
    {
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new CustomNamingPayload()));
        Assert.Throws<NotSupportedException>(() => WorkflowWireRuntime.ToCompactJson(new CustomPropertyNamingPayload()));
    }

    [Theory]
    [InlineData("first /+")]
    [InlineData("Second")]
    public void ClosedEnumWirePreservesAllowedText(string value)
    {
        Assert.Same(value, WorkflowWireRuntime.RequireEnumWire(value, new[] { "first /+", "Second" }, false, "body.choice"));
    }

    [Theory]
    [InlineData("First")]
    [InlineData("1")]
    [InlineData("second")]
    [InlineData("")]
    public void ClosedEnumWireRejectsUnmappedText(string value)
    {
        var error = Assert.Throws<ArgumentException>(() =>
            WorkflowWireRuntime.RequireEnumWire(value, new[] { "first /+", "Second" }, false, "body.choice"));
        Assert.Equal("body.choice", error.ParamName);
        Assert.Contains("not allowed", error.Message);
    }

    [Fact]
    public void NullabilityAndOpenWireValuesAreValidatedIndependently()
    {
        Assert.Null(WorkflowWireRuntime.RequireEnumWire(null, Array.Empty<string>(), true, "body.choice"));
        Assert.Null(WorkflowWireRuntime.RequireEnumWire(null, null, true, "body.choice"));
        Assert.Equal("unmapped", WorkflowWireRuntime.RequireEnumWire("unmapped", null, false, "body.choice"));
        Assert.Equal("", WorkflowWireRuntime.RequireEnumWire("", null, false, "body.choice"));
        Assert.Throws<ArgumentException>(() => WorkflowWireRuntime.RequireEnumWire("value", Array.Empty<string>(), true, "body.choice"));
        foreach (var allowed in new[] { null, new[] { "first /+" } })
        {
            var error = Assert.Throws<ArgumentException>(() =>
                WorkflowWireRuntime.RequireEnumWire(null, allowed, false, "body.choice"));
            Assert.Equal("body.choice", error.ParamName);
            Assert.Contains("non-null", error.Message);
        }
        Assert.Null(WorkflowWireRuntime.RequireText(null, true, "body.text"));
        Assert.Equal("", WorkflowWireRuntime.RequireText("", false, "body.text"));
        Assert.Equal("body.text", Assert.Throws<ArgumentException>(() =>
            WorkflowWireRuntime.RequireText(null, false, "body.text")).ParamName);
    }

    private enum Choice
    {
        [EnumMember(Value = "first /+")]
        First = 1,
        Second = 2
    }

    private enum AmbiguousChoice
    {
        [EnumMember(Value = "one")]
        First = 1,
        [EnumMember(Value = "another")]
        Alias = 1
    }

    private sealed class NamedPayload
    {
        [JsonProperty("wire-name", NullValueHandling = NullValueHandling.Ignore, Order = 0)]
        public string ClrName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, Order = 1)]
        public int Count { get; set; }
    }

    private sealed class CountingPayload
    {
        [JsonIgnore]
        public int Reads { get; private set; }

        public Choice Value
        {
            get
            {
                Reads++;
                return Choice.First;
            }
        }
    }

    [JsonConverter(typeof(UnconstructableConverter))]
    private sealed class ConvertedPayload { }

    private sealed class ConvertedPropertyPayload
    {
        [JsonConverter(typeof(UnconstructableConverter))]
        public string Value => "value";
    }

    private sealed class ConvertedItemsPayload
    {
        [JsonProperty(ItemConverterType = typeof(UnconstructableConverter))]
        public string[] Values => new[] { "value" };
    }

    [JsonObject(ItemConverterType = typeof(UnconstructableConverter))]
    private sealed class ConvertedContainerPayload
    {
        public string Value => "value";
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    private sealed class CustomNamingPayload
    {
        public string PascalName => "value";
    }

    private sealed class CustomPropertyNamingPayload
    {
        [JsonProperty(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
        public string PascalName => "value";
    }

    public sealed class UnconstructableConverter : UnexpectedConverter
    {
        public UnconstructableConverter() => throw new InvalidOperationException("Converter construction is forbidden.");
    }

    public class UnexpectedConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) =>
            throw new InvalidOperationException("Unexpected converter.");
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
            throw new InvalidOperationException("Unexpected converter.");
    }
}

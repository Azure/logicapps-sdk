namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Build;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using static ConsumerCompilation;
using static SchemaConsumerCompilation;

[Collection("Runtime serialization globals")]
public sealed class SchemaDestinationCatalogTests
{
    [Theory]
    [InlineData("Q04", "new PayloadModel { Name = source.Output }", true)]
    [InlineData("Q04b", "new PayloadModel { Name = source.Output, Enabled = false }", false)]
    public void Generated_model_defaults_are_schema_values_not_constructor_evaluation(string catalog, string expression, bool enabled)
    {
        Assert.NotEmpty(catalog);
        var result = SchemaConsumerCompilation.Build($"CatalogDestinations.Payload(content: () => {expression})");
        Assert.Equal("@outputs('Source')", result.Value["display_name"]!.Value<string>());
        Assert.Equal(enabled, result.Value["enabled"]!.Value<bool>());
        Assert.Equal(2, ((JObject)result.Value).Count);
        Assert.Contains("SourceExpression.Model<", result.Transformation.Sources["Consumer.cs"]);
        Assert.DoesNotContain("=> new PayloadModel", result.Transformation.Sources["Consumer.cs"]);
    }

    [Fact, Trait("Catalog", "Q04c")]
    public void Conflicting_schema_default_versions_are_rejected_before_source_generation()
    {
        var schema = JObject.Parse(Fixture);
        var conflicting = schema["models"]![0]!.DeepClone();
        conflicting["schema"]!["version"] = 2;
        conflicting["schema"]!["properties"]!["enabled"]!["default"] = false;
        ((JArray)schema["models"]!).Add(conflicting);
        var error = Assert.Throws<InvalidDataException>(() => WorkflowSchemaGenerator.Generate(schema.ToString()));
        Assert.Contains("PayloadModel", error.Message);
        Assert.Contains("Duplicate", error.Message);
    }

    [Fact, Trait("Catalog", "Q06b")]
    public void Explicit_runtime_object_profile_keeps_factory_opaque_until_execution()
    {
        var result = SchemaConsumerCompilation.Build("CatalogDestinations.Headers(headers: () => RuntimeValues.CreateHeaders())");
        EqualSource("@csharp{RuntimeValues.CreateHeaders()}", result.Value.Value<string>()!);
        var executed = LocalNativeHost.Evaluate(result.Value.Value<string>()!, new());
        Assert.Equal("value", Assert.IsType<Dictionary<string, string>>(executed.Value)["X"]);
        Assert.Equal(1, executed.Calls);
    }

    [Fact, Trait("Catalog", "Q09")]
    public void Generated_fields_keep_independent_literal_template_and_native_values()
    {
        var result = SchemaConsumerCompilation.Build("""
            CatalogDestinations.Fields(name: () => source.Output, count: () => 3, label: () => other.Output.ToUpperInvariant())
            """);
        Assert.Equal("@outputs('Source')", result.Value["name"]!.Value<string>());
        Assert.Equal(JTokenType.Integer, result.Value["count"]!.Type);
        Assert.Equal(3, result.Value["count"]!.Value<int>());
        EqualSource("@csharp{outputs(\"Other\").ToObject<string>().ToUpperInvariant()}", result.Value["label"]!.Value<string>()!);
    }

    [Theory]
    [InlineData("E09b", "(WireChoice)99", "", "99")]
    [InlineData("E13e", "access", "var access = Access.Read | Access.Write;", "Read, Write")]
    [InlineData("E13f", "choice", "WireChoice? choice = null;", "null")]
    public void Closed_and_required_enum_schemas_reject_invalid_values(string catalog, string expression, string setup, string detail)
    {
        Assert.NotEmpty(catalog);
        var method = catalog == "E13f" ? "RequiredEnum" : "ClosedEnum";
        var error = Assert.Throws<ArgumentException>(() =>
            SchemaConsumerCompilation.Build($"CatalogDestinations.{method}(content: () => {expression})", setup));
        Assert.Equal("content", error.ParamName);
        Assert.Contains(detail, error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("B08", "EncodeEnum", "WireChoice.First", "", "@base64('first /+')")]
    [InlineData("B13", "EncodeUri", "uri", "var uri = new Uri(\"https://example.com/api\");", "@base64('https://example.com/api')")]
    [InlineData("B13b", "EncodeMethod", "System.Net.Http.HttpMethod.Get", "", "@base64('GET')")]
    [InlineData("B15", "EncodeJson", "new { n = 1 }", "", "@base64('{\"n\":1}')")]
    [InlineData("B15b", "EncodeJson", "new[] { 1, 2 }", "", "@base64('[1,2]')")]
    [InlineData("B19b", "AlreadyEncoded", "\"aGVsbG8=\"", "", "aGVsbG8=")]
    public void Explicit_normalization_profiles_produce_exact_literal_wire_values(
        string catalog, string method, string expression, string setup, string expected)
    {
        Assert.NotEmpty(catalog);
        Assert.Equal(expected, SchemaConsumerCompilation.Build($"CatalogDestinations.{method}(content: () => {expression})", setup).Value.Value<string>());
    }

    [Theory]
    [InlineData("B09", "flag.Output ? WireChoice.First : WireChoice.Second", "base64(outputs(\"Flag\").ToObject<bool>() ? \"first /+\" : \"second\")")]
    [InlineData("B10", "RuntimeValues.NextChoice()", "base64(RuntimeValues.NextChoice() switch { (WireChoice)0 => \"first /+\", (WireChoice)1 => \"second\", (WireChoice)2 => \"Unannotated\", var value => value.ToString() })")]
    public void Encoded_enums_keep_the_typed_source_and_map_only_at_the_wire_boundary(string catalog, string expression, string expected)
    {
        var result = SchemaConsumerCompilation.Build($"CatalogDestinations.EncodeEnum(content: () => {expression})").Value.Value<string>()!;
        EqualSource("@csharp{" + expected + "}", result);
        var local = LocalNativeHost.Evaluate(result, new() { ["Flag"] = new JValue(true) });
        Assert.Equal(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("first /+")), local.Value);
        Assert.Equal(catalog == "B10" ? 1 : 0, local.Calls);
        if (catalog == "B09")
            Assert.Equal(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("second")),
                LocalNativeHost.Evaluate(result, new() { ["Flag"] = new JValue(false) }).Value);
    }

    [Fact, Trait("Catalog", "B15c")]
    public void Schema_encoding_uses_fixed_compact_bytes_despite_ambient_serializer_settings()
    {
        var previous = JsonConvert.DefaultSettings;
        try
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() },
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            Assert.Equal("@base64('{\"n\":1}')", SchemaConsumerCompilation.Build(
                "CatalogDestinations.EncodeJson(content: () => token)", "JToken token = JObject.Parse(\"{\\\"n\\\":1}\");").Value.Value<string>());
            Assert.Equal("@base64('{\"n\":1}')", SchemaConsumerCompilation.Build(
                "CatalogDestinations.EncodeJson(content: () => new { n = 1 })").Value.Value<string>());
            Assert.Equal("@base64('[1,2]')", SchemaConsumerCompilation.Build(
                "CatalogDestinations.EncodeJson(content: () => new[] { 1, 2 })").Value.Value<string>());
        }
        finally { JsonConvert.DefaultSettings = previous; }
    }

    [Fact, Trait("Catalog", "B17")]
    public void Missing_optional_encoded_field_is_omitted_not_encoded_as_null()
    {
        Assert.Empty((JObject)SchemaConsumerCompilation.Build("CatalogDestinations.OptionalContent()").Value);
        Assert.Empty((JObject)SchemaConsumerCompilation.Build("CatalogDestinations.OptionalContent(content: null)").Value);
    }

    [Fact, Trait("Catalog", "B17c")]
    public void Explicit_required_null_encoded_field_names_the_destination()
    {
        var error = Assert.Throws<ArgumentException>(() =>
            SchemaConsumerCompilation.Build("CatalogDestinations.RequiredContent(content: () => (string)null)"));
        Assert.Equal("content", error.ParamName);
        Assert.Contains("null", error.Message);
    }

    [Fact, Trait("Catalog", "B18"), Trait("Catalog", "F07")]
    public void Text_only_schema_rejects_captured_stream_without_reading_it()
    {
        var error = Assert.Throws<NotSupportedException>(() => SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeText(content: () => stream)", "var stream = new System.IO.MemoryStream();"));
        Assert.Contains("content", error.Message);
        Assert.Contains("MemoryStream", error.Message);
        Assert.Contains("normalization", error.Message);
        Assert.Contains("not read", error.Message);
    }

    [Fact, Trait("Catalog", "B19c")]
    public void Raw_only_schema_rejects_requested_already_encoded_mode()
    {
        var schema = JObject.Parse(Fixture);
        var operation = schema["operations"]!.Single(o => o["name"]!.Value<string>() == "EncodeText");
        operation["parameters"]![0]!["schema"]!["inputEncoding"] = "base64";
        var error = Assert.Throws<InvalidDataException>(() => WorkflowSchemaGenerator.Generate(schema.ToString()));
        Assert.Contains("content", error.Message);
        Assert.Contains("Already-encoded", error.Message);
        Assert.Equal("@base64('aGVsbG8=')", SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeText(content: () => \"aGVsbG8=\")").Value.Value<string>());
    }

    [Fact]
    public void Generated_binary_boundary_preserves_literal_and_captured_raw_bytes()
    {
        Assert.Equal("AAH/", SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeValue(content: () => new byte[] { 0, 1, 255 })").Value.Value<string>());
        Assert.Equal("AAH/", SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeValue(content: () => bytes)", "byte[] bytes = { 0, 1, 255 };").Value.Value<string>());
    }

    [Fact]
    public void Nullable_native_encoding_preserves_null_and_required_null_is_rejected()
    {
        var emitted = SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeValue(content: () => nullableCount.Output + 1)").Value.Value<string>()!;
        Assert.Null(LocalNativeHost.Evaluate(emitted, new() { ["NullableCount"] = JValue.CreateNull() }).Value);
        Assert.Equal("NA==", LocalNativeHost.Evaluate(emitted, new() { ["NullableCount"] = new JValue(3) }).Value);
        var schema = JObject.Parse(Fixture)["operations"]!.Single(o => o["name"]!.Value<string>() == "EncodeValue")["parameters"]![0]!["schema"]!;
        schema["nullable"] = false;
        var error = Assert.Throws<ArgumentException>(() => WorkflowWireRuntime.NormalizeAndEncode(null!, schema.ToString()));
        Assert.Equal("content", error.ParamName);
    }

    [Fact, Trait("Catalog", "B21"), Trait("Catalog", "IN15")]
    public void Generated_schema_encodes_only_the_declared_field()
    {
        var result = SchemaConsumerCompilation.Build("""
            CatalogDestinations.EncodedFields(
                ContentData: () => trigger.TriggerOutput.Body["content"],
                ContentType: () => "text/plain",
                Label: () => source.Output.ToUpperInvariant())
            """);
        Assert.Equal("@base64(triggerBody()['content'])", result.Value["ContentData"]!.Value<string>());
        Assert.Equal("text/plain", result.Value["ContentType"]!.Value<string>());
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}", result.Value["Label"]!.Value<string>()!);
        Assert.Equal(3, ((JObject)result.Value).Count);
    }

    [Fact, Trait("Catalog", "B22"), Trait("Catalog", "IN15")]
    public void Nested_schema_applies_member_encoding_once_without_whole_object_encoding()
    {
        var result = SchemaConsumerCompilation.Build("""
            CatalogDestinations.Nested(content: () => new
            {
                items = new[] { new { content = "hello", label = "plain" }, new { content = source.Output, label = "reference" } },
                enabled = true
            })
            """).Value;
        Assert.True(JToken.DeepEquals(JObject.Parse("""
            {"items":[{"content":"@base64('hello')","label":"plain"},{"content":"@base64(outputs('Source'))","label":"reference"}],"enabled":true}
            """), result));
    }

    [Fact, Trait("Catalog", "IN16")]
    public void Conflicting_whole_and_member_transforms_fail_closed()
    {
        var schema = JObject.Parse(Fixture);
        var destination = schema["operations"]!.Single(o => o["name"]!.Value<string>() == "Nested")["parameters"]![0]!["schema"]!;
        destination["transforms"] = new JArray("base64");
        destination["inputEncoding"] = "raw";
        destination["serializerProfile"] = "compact-json-v1";
        var error = Assert.Throws<InvalidDataException>(() => WorkflowSchemaGenerator.Generate(schema.ToString()));
        Assert.Contains("payload", error.Message);
        Assert.Contains("Conflicting whole-value and member", error.Message);
        var runtimeError = Assert.Throws<ArgumentException>(() => WorkflowDestination.Parse(destination.ToString()));
        Assert.Equal("payload", runtimeError.ParamName);
    }

    [Theory]
    [InlineData("U04", "EnumPath", "WireChoice.First", "@{encodeURIComponent('first /+')}")]
    [InlineData("U05", "DoubleEnumPath", "WireChoice.First", "@{encodeURIComponent(encodeURIComponent('first /+'))}")]
    [InlineData("U08", "Base64Path", "\"hello\"", "@{encodeURIComponent(base64('hello'))}")]
    public void Generated_path_transform_count_and_order_come_only_from_schema(string catalog, string method, string expression, string expected)
    {
        Assert.NotEmpty(catalog);
        Assert.Equal("/items/" + expected, SchemaConsumerCompilation.Build(
            $"CatalogDestinations.{method}(content: () => {expression})").Value.Value<string>());
    }

    [Fact, Trait("Catalog", "U06")]
    public void Generated_two_argument_path_retains_template_arguments_and_final_names()
    {
        var value = SchemaConsumerCompilation.Build(
            "CatalogDestinations.Path(first: () => source.Output, second: () => other.Output)").Value.Value<string>();
        Assert.Equal("/items/@{encodeURIComponent(outputs('Source'))}/@{encodeURIComponent(outputs('Other'))}", value);
        Assert.Equal("/items/@{encodeURIComponent(outputs('Renamed'))}/@{encodeURIComponent(outputs('Other'))}",
            SchemaConsumerCompilation.Build("CatalogDestinations.Path(first: () => source.Output, second: () => other.Output)",
                after: "source.WithName(\"Renamed\");").Value.Value<string>());
    }

    [Theory]
    [InlineData("U07", "source.Output.ToUpperInvariant()", "string.Format(\"/items/{0}/{1}\", encodeURIComponent(outputs(\"Source\").ToObject<string>().ToUpperInvariant()), encodeURIComponent(outputs(\"Other\").ToObject<string>()))", "/items/A%20%2F/B")]
    [InlineData("U09", "RuntimeValues.NextText()", "string.Format(\"/items/{0}/{1}\", encodeURIComponent(RuntimeValues.NextText()), encodeURIComponent(outputs(\"Source\").ToObject<string>()))", "/items/hello/a%20%2F")]
    public void Generated_mixed_path_preserves_native_arguments_and_single_evaluation(string catalog, string first, string expected, string value)
    {
        var second = catalog == "U09" ? "source.Output" : "other.Output";
        var emitted = SchemaConsumerCompilation.Build($"CatalogDestinations.Path(first: () => {first}, second: () => {second})").Value.Value<string>()!;
        EqualSource("@csharp{" + expected + "}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("a /"), ["Other"] = new JValue("B") });
        Assert.Equal(value, local.Value);
        Assert.Equal(catalog == "U09" ? 1 : 0, local.Calls);
        Assert.Equal(catalog == "U09" ? ["Source"] : new[] { "Source", "Other" }, local.Reads);
    }

    [Fact, Trait("Catalog", "IN11")]
    public void Generated_single_argument_path_matches_the_original_items_schema()
    {
        var emitted = SchemaConsumerCompilation.Build(
            "CatalogDestinations.SinglePath(content: () => source.Output.ToUpperInvariant())").Value.Value<string>()!;
        EqualSource("@csharp{string.Format(\"/items/{0}\", encodeURIComponent(outputs(\"Source\").ToObject<string>().ToUpperInvariant()))}", emitted);
        Assert.Equal("/items/A%20%2F", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("a /") }).Value);
    }

    [Fact, Trait("LocalContract", "X06")]
    public void Calculated_JSON_payload_uses_the_fixed_runtime_profile_once_without_claiming_backend_verification()
    {
        var emitted = SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeJson(content: () => new { Next = count.Output + 1, Label = source.Output })").Value.Value<string>()!;
        Assert.DoesNotContain("Microsoft.Azure.Workflows.Sdk", emitted);
        Assert.Contains("global::Newtonsoft.Json.JsonSerializer.Create(", emitted);
        var previous = JsonConvert.DefaultSettings;
        try
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() }
            };
            var local = LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3), ["Source"] = new JValue("A") });
            Assert.Equal("{\"Next\":4,\"Label\":\"A\"}", System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Assert.IsType<string>(local.Value))));
            Assert.Equal(["Count", "Source"], local.Reads);
            Assert.Equal(0, local.Calls);
        }
        finally { JsonConvert.DefaultSettings = previous; }
    }
}

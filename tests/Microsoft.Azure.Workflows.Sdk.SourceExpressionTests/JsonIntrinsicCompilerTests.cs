namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class JsonIntrinsicCompilerTests
{
    [Fact, Trait("Catalog", "U10")]
    public void Actual_generic_sdk_ToJson_lowers_to_template_json()
    {
        Assert.Equal("@json(outputs('Source'))",
            Input("WorkflowFunctions.ToJson<JObject>(source.Output)", resultType: "JObject")!.Value<string>());
    }

    [Fact]
    public void Actual_nongeneric_sdk_ToJson_lowers_to_template_json_and_binds_final_name()
    {
        Assert.Equal("@json(outputs('Renamed'))",
            Input("WorkflowFunctions.ToJson(source.Output)", after: "source.WithName(\"Renamed\");",
                resultType: "JToken")!.Value<string>());
    }

    [Fact, Trait("Catalog", "U11")]
    public void Actual_generic_sdk_ToJson_keeps_native_input_without_root_materialization() =>
        VerifyNativeRoot("WorkflowFunctions.ToJson<JObject>(source.Output.ToUpperInvariant())", "JObject");

    [Fact]
    public void Actual_nongeneric_sdk_ToJson_keeps_native_input_without_root_materialization() =>
        VerifyNativeRoot("WorkflowFunctions.ToJson(source.Output.ToUpperInvariant())", "JToken");

    [Theory]
    [InlineData("WorkflowFunctions.ToJson(source.Output)[\"x\"].Value<int>()",
        "json(outputs(\"Source\").ToObject<string>())[\"x\"].Value<int>()")]
    [InlineData("WorkflowFunctions.ToJson<JObject>(source.Output)[\"x\"].Value<int>()",
        "json(outputs(\"Source\").ToObject<string>()).ToObject<Newtonsoft.Json.Linq.JObject>()[\"x\"].Value<int>()")]
    public void Json_native_consumers_materialize_only_their_actual_result_type(string input, string expectedBody)
    {
        var emitted = Native(input);
        EqualSource("@csharp{" + expectedBody + "}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("""{"x":3}""") });
        Assert.Equal(3, Assert.IsType<int>(local.Value));
        Assert.Equal(["Source"], local.Reads);
    }

    [Fact]
    public void Typed_json_result_materializes_before_native_property_arithmetic()
    {
        var emitted = Native("WorkflowFunctions.ToJson<OrderSummary>(source.Output).Total * 1.2m");
        EqualSource("@csharp{json(outputs(\"Source\").ToObject<string>()).ToObject<OrderSummary>().Total * 1.2m}", emitted);
        Assert.Equal(120m, Assert.IsType<decimal>(LocalNativeHost.Evaluate(emitted,
            new() { ["Source"] = new JValue("""{"Total":100}""") }).Value));
    }

    [Fact]
    public void Native_input_and_nested_typed_json_consumer_keep_one_native_envelope()
    {
        var emitted = Native("WorkflowFunctions.ToJson<JObject>(source.Output.ToUpperInvariant()).ContainsKey(\"X\")");
        EqualSource("@csharp{json(outputs(\"Source\").ToObject<string>().ToUpperInvariant()).ToObject<Newtonsoft.Json.Linq.JObject>().ContainsKey(\"X\")}", emitted);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted,
            new() { ["Source"] = new JValue("""{"x":3}""") }).Value);
    }

    [Theory]
    [InlineData("WorkflowFunctions.ToJson(\"not-json\")", "JToken")]
    [InlineData("WorkflowFunctions.ToJson<JObject>(\"not-json\")", "JObject")]
    public void Malformed_literal_json_is_not_parsed_or_returned_as_default_during_generation(string input, string type)
    {
        Assert.Equal("@json('not-json')", Input(input, resultType: type)!.Value<string>());
    }

    private static void VerifyNativeRoot(string input, string type)
    {
        var emitted = Native(input, resultType: type);
        EqualSource("@csharp{json(outputs(\"Source\").ToObject<string>().ToUpperInvariant())}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("""{"name":"alice"}""") });
        Assert.True(JToken.DeepEquals(JObject.Parse("""{"NAME":"ALICE"}"""), Assert.IsType<JObject>(local.Value)));
        Assert.Equal(["Source"], local.Reads);
    }
}

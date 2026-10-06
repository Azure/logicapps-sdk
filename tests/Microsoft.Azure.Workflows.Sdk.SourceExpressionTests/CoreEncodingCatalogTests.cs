namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CoreEncodingCatalogTests
{
    [Theory]
    [InlineData("B01", "\"hello\"", "", "#{base64(\"hello\")}")]
    [InlineData("B02", "source.Output", "", "#{base64(outputs(\"Source\").ToObject<string>())}")]
    [InlineData("B03", "trigger.TriggerOutput.Body[\"content\"]", "", "#{base64(triggerBody()[\"content\"])}")]
    [InlineData("B06", "$\"Name: {source.Output}\"", "", "#{base64($\"Name: {outputs(\"Source\").ToObject<string>()}\")}")]
    [InlineData("IN10", "$\"Name: {source.Output}\"", "", "#{base64($\"Name: {outputs(\"Source\").ToObject<string>()}\")}")]
    [InlineData("B12", "42", "", "#{base64(\"42\")}")]
    [InlineData("B12b", "true", "", "#{base64(\"true\")}")]
    [InlineData("B14", "token", "JToken token = new JValue(\"hello\");", "#{base64(\"hello\")}")]
    [InlineData("B14b", "token", "JToken token = JObject.Parse(\"{\\\"n\\\":1}\");", "#{base64(\"{\\\"n\\\":1}\")}")]
    [InlineData("B16", "\"\"", "", "#{base64(\"\")}")]
    [InlineData("B16b", "\"\\u00e9\"", "", "#{base64(\"é\")}")]
    [InlineData("B19", "\"aGVsbG8=\"", "", "#{base64(\"aGVsbG8=\")}")]
    public void Generated_base64_destination_always_uses_native_envelope(
        string catalog, string input, string setup, string expected)
    {
        Assert.NotEmpty(catalog);
        var result = Encode(input, setup);
        Assert.Equal(expected, Token(result.Definition)["body"]!["ContentData"]!.Value<string>());
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
    }

    [Theory]
    [InlineData("B04", "source.Output.ToUpperInvariant()", "base64(outputs(\"Source\").ToObject<string>().ToUpperInvariant())", "SEVMTE8=")]
    [InlineData("F09", "source.Output.ToUpperInvariant()", "base64(outputs(\"Source\").ToObject<string>().ToUpperInvariant())", "SEVMTE8=")]
    [InlineData("B05", "(count.Output + 1).ToString()", "base64((outputs(\"Count\").ToObject<int>() + 1).ToString())", "NA==")]
    [InlineData("B07", "$\"Next: {count.Output + 1}\"", "base64($\"Next: {outputs(\"Count\").ToObject<int>() + 1}\")", "TmV4dDogNA==")]
    [InlineData("B12c", "amount.Output + 1m", "base64((outputs(\"Amount\").ToObject<decimal>() + 1m).ToString(System.Globalization.CultureInfo.InvariantCulture))", "My41")]
    [InlineData("B20", "RuntimeValues.NextText()", "base64(RuntimeValues.NextText())", "aGVsbG8=")]
    public void Generated_base64_native_values_preserve_one_envelope_and_runtime_evaluation(
        string catalog, string input, string expectedBody, string expected)
    {
        Assert.NotEmpty(catalog);
        var result = Encode(input);
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(result.Definition)["body"]!["ContentData"]!.Value<string>()!;
        EqualSource("#{" + expectedBody + "}", emitted);
        var local = LocalNativeHost.Evaluate(emitted,
            new() { ["Source"] = new JValue("hello"), ["Count"] = new JValue(3), ["Amount"] = new JValue(2.5m) });
        Assert.Equal(expected, local.Value);
        Assert.Equal(catalog == "B20" ? 1 : 0, local.Calls);
    }

    [Theory]
    [InlineData("B11", "byte[] bytes = { 0, 1, 255 };", "AAH/")]
    [InlineData("B16c", "byte[] bytes = { 0, 0 };", "AAA=")]
    public void Raw_binary_capture_is_encoded_as_bytes_not_array_json(string catalog, string setup, string expected)
    {
        Assert.NotEmpty(catalog);
        Assert.Equal(expected, Token(Encode("bytes", setup).Definition)["body"]!["ContentData"]!.Value<string>());
    }

    [Fact, Trait("Catalog", "B17b")]
    public void Explicit_optional_null_content_remains_json_null()
    {
        var token = Token(Encode("(string)null").Definition);
        Assert.Equal(JTokenType.Null, token["body"]!["ContentData"]!.Type);
    }

    [Fact, Trait("Catalog", "U01"), Trait("Catalog", "U02")]
    public void Real_connector_path_metadata_applies_one_and_two_encodings_to_correct_arguments()
    {
        var result = Build(Source(Handles + """
            return new Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus.ServicebusActions("connection")
                .CloseSessionInQueue(queueName: () => source.Output, sessionId: () => source.Output)
                .GetActionDefinition("Catalog");
            """));
        var path = Token(result.Definition)["path"]!.Value<string>()!;
        Assert.Equal("#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/{0}/sessions/{1}/close\", encodeURIComponent(encodeURIComponent(outputs(\"Source\").ToObject<string>())), encodeURIComponent(outputs(\"Source\").ToObject<string>()))}", path);
    }

    [Fact, Trait("Catalog", "U03")]
    public void Real_connector_native_path_argument_is_encoded_once_inside_native_expression()
    {
        var result = Build(Source(Handles + """
            return new Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus.ServicebusActions("connection")
                .CloseSessionInQueue(queueName: () => "queue", sessionId: () => source.Output.ToUpperInvariant())
                .GetActionDefinition("Catalog");
            """));
        var emitted = Token(result.Definition)["path"]!.Value<string>()!;
        var invocation = Assert.IsType<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>(
            Microsoft.CodeAnalysis.CSharp.SyntaxFactory.ParseExpression(ConsumerCompilation.NativeBody(emitted)));
        var encodedArgument = invocation.ArgumentList.Arguments.Last().Expression.ToString();
        EqualSource("#{encodeURIComponent(outputs(\"Source\").ToObject<string>().ToUpperInvariant())}",
            "#{" + encodedArgument + "}");
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("a /") });
        Assert.Equal("/queue/sessions/A%20%2F/close", local.Value);
        Assert.Equal(["Source"], local.Reads);
    }

    [Theory]
    [InlineData("\"98058\"", "\"98058\"", "/current/98058")]
    [InlineData("\"a /\"", "\"a /\"", "/current/a%20%2F")]
    [InlineData("source.Output.ToUpperInvariant()", "outputs(\"Source\").ToObject<string>().ToUpperInvariant()", "/current/A%20%2F")]
    public void Weather_connector_retains_native_encoded_route_and_literal_query(
        string input, string nativeArgument, string expectedPath)
    {
        var result = Build(Source(Handles + $$"""
            return new MsnweatherActions("connection")
                .CurrentWeather(() => {{input}}, () => unitsInput.Imperial)
                .GetActionDefinition("Weather");
            """, imports: "using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;"));
        var inputs = Token(result.Definition);
        var path = inputs["path"]!.Value<string>()!;
        Assert.Equal(
            "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/current/{0}\", encodeURIComponent(" +
            nativeArgument + "))}", path);
        Assert.Equal("get", inputs["method"]!.Value<string>());
        Assert.Equal("I", inputs["queries"]!["units"]!.Value<string>());
        var local = LocalNativeHost.Evaluate(path, new() { ["Source"] = new JValue("a /") });
        Assert.Equal(expectedPath, local.Value);
    }

    private static (FlowTemplateAction Definition, System.Reflection.Assembly Assembly,
        global::Microsoft.Azure.Workflows.Sdk.Build.TransformationResult Transformation)
        Encode(string input, string setup = "") =>
        Build(Source(Handles + CoreHandles + setup + $$"""
            return new Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus.ServicebusActions("connection")
                .SendMessage(entityName: () => "queue", messagecontent: () => {{input}})
                .GetActionDefinition("Catalog");
            """));
}

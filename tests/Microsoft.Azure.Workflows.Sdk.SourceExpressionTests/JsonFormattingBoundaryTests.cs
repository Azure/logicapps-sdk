namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

[Collection("Runtime serialization globals")]
public sealed class JsonFormattingBoundaryTests
{
    private const string WeatherSetup = """
        var weather = new Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.MsnweatherActions("connection")
            .CurrentWeather(() => "98058",
                () => Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.unitsInput.Imperial)
            .WithName("Weather");
        """;

    private const string WeatherJson = """
        {"responses":{"source":{"location":"98058","unknown":[1,true,null]}},"extra":{"preserved":true}}
        """;

    [Theory]
    [InlineData("$\"{weather.Body}\" + \"something\"")]
    [InlineData("$@\"{weather.Body}\" + \"something\"")]
    [InlineData("$$\"\"\"{{weather.Body}}\"\"\" + \"something\"")]
    [InlineData("weather.Body + \"something\"")]
    [InlineData("string.Format(\"{0}something\", weather.Body)")]
    [InlineData("string.Concat(weather.Body, \"something\")")]
    [InlineData("string.Format(\"{0}{1}{2}{3}\", \"\", \"\", weather.Body, \"something\")")]
    [InlineData("string.Format(\"{0}something\", new object[] { weather.Body })")]
    [InlineData("string.Concat(new object[] { weather.Body, \"something\" })")]
    [InlineData("System.Convert.ToString(weather.Body) + \"something\"")]
    [InlineData("new System.Text.StringBuilder().Append(weather.Body).Append(\"something\").ToString()")]
    [InlineData("weather.Body.ToString() + \"something\"")]
    [InlineData("$\"{(object)weather.Body}\" + \"something\"")]
    [InlineData("$\"{(flag.Output ? weather.Body : null)}\" + \"something\"")]
    [InlineData("$\"{(weather.Body ?? new Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.CurrentWeather())}\" + \"something\"")]
    public void Workflow_model_formatting_preserves_the_full_JSON_payload(string expression)
    {
        var emitted = Native(expression, WeatherSetup);
        var weather = JObject.Parse(WeatherJson);
        var evaluated = LocalNativeHost.Evaluate(emitted,
            new() { ["Weather"] = weather, ["Flag"] = new JValue(true) });

        Assert.Equal(weather.ToString() + "something", evaluated.Value);
        Assert.Equal(expression.Contains("flag.Output", StringComparison.Ordinal)
            ? ["Flag", "Weather"] : ["Weather"], evaluated.Reads);
        Assert.DoesNotContain("ToObject<global::Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.CurrentWeather>", emitted);
    }

    [Theory]
    [InlineData("string.Concat(weather.Body)")]
    [InlineData("string.Format(\"{0}\", weather.Body)")]
    [InlineData("$\"{weather.Body}\"")]
    public void Null_model_formatting_is_empty_text(string expression)
    {
        var emitted = Native(expression, WeatherSetup);
        Assert.Equal("", LocalNativeHost.Evaluate(emitted,
            new() { ["Weather"] = JValue.CreateNull() }).Value);
    }

    [Theory]
    [InlineData("$\"{weather.Body.Responses.Source}\"")]
    [InlineData("string.Concat(weather.Body.Responses.Source)")]
    public void Nested_JSON_model_formatting_retains_wire_names_and_unknown_fields(string expression)
    {
        var emitted = Native(expression, WeatherSetup);
        var weather = JObject.Parse(WeatherJson);
        Assert.Equal(weather["responses"]!["source"]!.ToString(),
            LocalNativeHost.Evaluate(emitted, new() { ["Weather"] = weather }).Value);
    }

    [Theory]
    [InlineData("$\"{values.Output}\"")]
    [InlineData("string.Format(\"{0}\", values.Output)")]
    [InlineData("string.Concat((object)values.Output)")]
    public void Workflow_array_formatting_preserves_JSON_instead_of_collection_type_names(string expression)
    {
        var emitted = Native(expression, CoreHandles);
        var values = new JArray(1, 2, 3);
        Assert.Equal(values.ToString(),
            LocalNativeHost.Evaluate(emitted, new() { ["Values"] = values }).Value);
    }

    [Theory]
    [InlineData("Newtonsoft.Json.JsonConvert.SerializeObject(weather.Body)")]
    [InlineData("WorkflowWireRuntime.ToCompactJson(weather.Body)")]
    public void Explicit_JSON_serialization_does_not_drop_unknown_workflow_fields(string expression)
    {
        var emitted = Native(expression, WeatherSetup);
        Assert.Equal(JObject.Parse(WeatherJson).ToString(Formatting.None),
            LocalNativeHost.Evaluate(emitted,
                new() { ["Weather"] = JObject.Parse(WeatherJson) }).Value);
    }

    [Fact]
    public void Typed_JSON_intrinsic_formatting_preserves_the_parsed_document()
    {
        var built = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(
                () => $"{WorkflowFunctions.ToJson<OrderSummary>(source.Output)}").GetActionDefinition("Format");
            """));
        var emitted = Token(built.Definition).Value<string>()!;
        Assert.DoesNotContain(built.Transformation.Dependencies, dependency => dependency.MetadataTypeName == "OrderSummary");
        var json = JObject.Parse("""{"Total":3.5,"extra":true}""");
        Assert.Equal(json.ToString(), LocalNativeHost.Evaluate(emitted,
            new() { ["Source"] = new JValue(json.ToString(Formatting.None)) }).Value);
    }

    [Theory]
    [InlineData("EncodeJson", "weather.Body")]
    [InlineData("EncodeValue", "weather.Body")]
    [InlineData("EncodeJson", "WorkflowFunctions.ToJson<Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.CurrentWeather>(source.Output)")]
    public void Schema_JSON_encoding_preserves_the_document_before_base64(string method, string expression)
    {
        var emitted = SchemaConsumerCompilation.Build(
            $"CatalogDestinations.{method}(content: () => {expression})", WeatherSetup).Value.Value<string>()!;
        var encoded = Assert.IsType<string>(LocalNativeHost.Evaluate(emitted, new()
        {
            ["Weather"] = JObject.Parse(WeatherJson),
            ["Source"] = new JValue(WeatherJson),
        }).Value);
        Assert.Equal(JObject.Parse(WeatherJson).ToString(Formatting.None),
            System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encoded)));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("{}")]
    public void Null_coalescing_keeps_its_null_semantics_and_reads_once(string json)
    {
        var emitted = Native("$\"{((object)weather.Body ?? \"fallback\")}\"", WeatherSetup);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["Weather"] = JToken.Parse(json) });
        Assert.Equal(json == "null" ? "fallback" : "{}", result.Value);
        Assert.Equal(["Weather"], result.Reads);
    }

    [Theory]
    [InlineData("OrderSummary", """{"Total":3.5,"extra":true}""", "{\n  \"Total\": 3.5,\n  \"extra\": true\n}")]
    [InlineData("int", "3", "3")]
    [InlineData("DisplayModel", """{"Id":3}""", "Display:3")]
    public void Generic_workflow_formatting_uses_the_bound_type_contract(string type, string json, string expected)
    {
        var result = Build(Source($$"""
            var value = WorkflowActions.BuiltIn.Compose<{{type}}>(() => default({{type}})).WithName("Generic");
            return Format(value).GetActionDefinition("Format");
            """, """
            private static IOutputWorkflowAction<string> Format<T>(IOutputWorkflowAction<T> value)
                => WorkflowActions.BuiltIn.Compose<string>(() => $"{value.Output}");
            """));
        Assert.Equal(expected.Replace("\n", Environment.NewLine),
            LocalNativeHost.Evaluate(Token(result.Definition).Value<string>()!,
                new() { ["Generic"] = JToken.Parse(json) }).Value);
    }

    [Fact]
    public void Generic_scalar_formatting_preserves_DateTime_format_specifiers()
    {
        var result = Build(Source("""
            var value = WorkflowActions.BuiltIn.Compose<DateTime>(() => default(DateTime)).WithName("Date");
            return Format(value).GetActionDefinition("Format");
            """, """
            private static IOutputWorkflowAction<string> Format<T>(IOutputWorkflowAction<T> value)
                => WorkflowActions.BuiltIn.Compose<string>(() => $"{value.Output:yyyy-MM-dd}");
            """));
        Assert.Equal("2020-01-02", LocalNativeHost.Evaluate(Token(result.Definition).Value<string>()!,
            new() { ["Date"] = new JValue(new DateTime(2020, 1, 2)) }).Value);
    }

    [Fact]
    public void JSON_formatting_does_not_consult_ambient_serializer_settings()
    {
        var emitted = Native("$\"{weather.Body}\"", WeatherSetup);
        var previous = JsonConvert.DefaultSettings;
        try
        {
            JsonConvert.DefaultSettings = () => throw new InvalidOperationException("Ambient settings were consulted.");
            var weather = JObject.Parse(WeatherJson);
            Assert.Equal(weather.ToString(), LocalNativeHost.Evaluate(emitted,
                new() { ["Weather"] = weather }).Value);
        }
        finally
        {
            JsonConvert.DefaultSettings = previous;
        }
    }

    [Fact]
    public void Explicit_typed_operations_still_materialize_the_model()
    {
        var emitted = Native("weather.Body.GetType().Name", WeatherSetup);
        Assert.Contains("ToObject<global::Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather.CurrentWeather>", emitted);
        Assert.Equal("CurrentWeather", LocalNativeHost.Evaluate(emitted,
            new() { ["Weather"] = JObject.Parse(WeatherJson) }).Value);
    }

    [Fact]
    public void An_unselected_JSON_branch_does_not_read_the_workflow_body()
    {
        var emitted = Native("$\"{(flag.Output ? weather.Body : null)}\"", WeatherSetup);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(false) });
        Assert.Equal("", result.Value);
        Assert.Equal(["Flag"], result.Reads);
    }

    [Fact]
    public void Generic_formatting_binding_rejects_nonmetadata_delegates_without_execution()
    {
        var calls = 0;
        Func<JToken> raw = () => { calls++; return new JObject(); };
        Assert.Throws<NotSupportedException>(() => SourceBinding.FormatJson(raw, typeof(object)));
        Assert.Throws<ArgumentException>(() =>
            SourceBinding.FormatJson(SourceExpression.Literal<JToken>(1, new JObject()), typeof(object)));
        Assert.Throws<ArgumentNullException>(() =>
            SourceBinding.FormatJson(SourceExpression.Literal<JToken>(1, new JObject()), null!));
        Assert.Equal(0, calls);
    }

    [Theory]
    [InlineData("$\"{summary.Body.Total:0.00}\"", "3.50")]
    [InlineData("string.Join(\",\", values.Output)", "1,2,3")]
    [InlineData("string.Concat(values.Output)", "123")]
    [InlineData("$\"{new DisplayModel { Id = count.Output }}\"", "Display:3")]
    [InlineData("$\"{display.Output}\"", "Display:3")]
    [InlineData("summary.Body.Total.ToString(\"0.00\", System.Globalization.CultureInfo.InvariantCulture)", "3.50")]
    public void CLR_formatting_and_collection_operations_remain_typed(string expression, string expected)
    {
        var emitted = Native(expression, CoreHandles + """
            var display = WorkflowActions.BuiltIn.Compose<DisplayModel>(() => null).WithName("Display");
            """);
        Assert.Equal(expected, LocalNativeHost.Evaluate(emitted, new()
        {
            ["GetSummary"] = JObject.Parse("""{"Total":3.5}"""),
            ["Values"] = new JArray(1, 2, 3),
            ["Count"] = new JValue(3),
            ["Display"] = JObject.Parse("""{"Id":3}"""),
        }).Value);
    }
}

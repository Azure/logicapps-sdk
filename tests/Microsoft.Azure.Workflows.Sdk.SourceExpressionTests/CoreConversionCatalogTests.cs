namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CoreConversionCatalogTests
{
    [Theory]
    [InlineData("M01", "trigger.TriggerOutput.Body[\"value\"].Value<int>() + 2", "triggerBody()[\"value\"].Value<int>() + 2", "{\"value\":3}", "5", "System.Int32")]
    [InlineData("M02", "trigger.TriggerOutput.Body[\"value\"].ToObject<int>() + 2", "triggerBody()[\"value\"].ToObject<int>() + 2", "{\"value\":3}", "5", "System.Int32")]
    [InlineData("M03", "trigger.TriggerOutput.Body[\"name\"].Value<string>().ToUpperInvariant()", "triggerBody()[\"name\"].Value<string>().ToUpperInvariant()", "{\"name\":\"alice\"}", "\"ALICE\"", "System.String")]
    [InlineData("M04", "trigger.TriggerOutput.Body[\"count\"].Value<int>() >= 10", "triggerBody()[\"count\"].Value<int>() >= 10", "{\"count\":9}", "false", "System.Boolean")]
    [InlineData("M04", "trigger.TriggerOutput.Body[\"count\"].Value<int>() >= 10", "triggerBody()[\"count\"].Value<int>() >= 10", "{\"count\":10}", "true", "System.Boolean")]
    public void Explicit_json_conversions_keep_authored_operation_and_result_type(
        string catalog, string input, string expectedBody, string body, string expectedJson, string expectedType)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(input);
        EqualSource("#{" + expectedBody + "}", emitted);
        var value = LocalNativeHost.Evaluate(emitted, new() { ["Trigger"] = JObject.Parse(body) }).Value!;
        Assert.Equal(expectedType, value.GetType().FullName);
        Assert.True(JToken.DeepEquals(JToken.Parse(expectedJson), JToken.FromObject(value)));
    }

    [Fact, Trait("Catalog", "M05")]
    public void Conditional_conversion_does_not_read_unselected_count()
    {
        var emitted = Native("flag.Output ? count.Output + 1 : 0");
        EqualSource("#{outputs(\"Flag\").ToObject<bool>() ? outputs(\"Count\").ToObject<int>() + 1 : 0}", emitted);
        var noCount = LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(false) });
        Assert.Equal(0, Assert.IsType<int>(noCount.Value));
        Assert.Equal(["Flag"], noCount.Reads);
        Assert.Equal(4, LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(true), ["Count"] = new JValue(3) }).Value);
    }

    [Fact, Trait("Catalog", "M06")]
    public void Unsupported_JToken_arithmetic_is_a_user_compilation_error()
    {
        var diagnostics = Compile(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<object>(input: () => trigger.TriggerOutput.Body["value"] + 2).GetActionDefinition("Catalog");
            """)).GetDiagnostics();
        Assert.Contains(diagnostics, d => d.Severity == DiagnosticSeverity.Error && d.Id == "CS0019");
    }

    [Fact, Trait("Catalog", "M09")]
    public void Nullable_Value_conversion_returns_clr_null()
    {
        var emitted = Native("trigger.TriggerOutput.Body[\"value\"].Value<int?>()");
        EqualSource("#{triggerBody()[\"value\"].Value<int?>()}", emitted);
        Assert.Null(LocalNativeHost.Evaluate(emitted, new() { ["Trigger"] = JObject.Parse("""{"value":null}""") }).Value);
    }

    [Fact, Trait("Catalog", "M09b")]
    public void ToObject_on_missing_property_preserves_null_receiver_failure()
    {
        var emitted = Native("trigger.TriggerOutput.Body[\"value\"].ToObject<int>()");
        EqualSource("#{triggerBody()[\"value\"].ToObject<int>()}", emitted);
        Assert.Throws<NullReferenceException>(() => LocalNativeHost.Evaluate(emitted, new() { ["Trigger"] = new JObject() }));
    }
}

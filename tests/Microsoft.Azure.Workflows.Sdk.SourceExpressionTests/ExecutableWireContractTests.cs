namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class ExecutableWireContractTests
{
    [Theory]
    [InlineData("#{1}", "1")]
    [InlineData("#{12 + 3}", "12 + 3")]
    [InlineData("#{\n1 + 2\n}", "\n1 + 2\n")]
    [InlineData("#{\"#{nested}\"}", "\"#{nested}\"")]
    public void Native_source_extraction_removes_exactly_the_two_character_prefix_and_final_brace(
        string envelope, string expectedBody) =>
        Assert.Equal(expectedBody, NativeBody(envelope));

    [Theory]
    [InlineData("@csharp{1}")]
    [InlineData("#{1")]
    [InlineData("1}")]
    [InlineData("#{}")]
    [InlineData("#{ \t\r\n}")]
    [InlineData("##{1}")]
    [InlineData(" #{1}")]
    [InlineData("#{1} ")]
    public void Native_source_extraction_rejects_old_or_incomplete_envelopes(string envelope) =>
        Assert.ThrowsAny<Xunit.Sdk.XunitException>(() => NativeBody(envelope));

    [Fact]
    public void Local_native_execution_uses_the_entire_short_hash_expression()
    {
        var executed = LocalNativeHost.Evaluate("#{1}", new());
        Assert.Equal(1, Assert.IsType<int>(executed.Value));
        Assert.Empty(executed.Reads);
    }

    [Theory]
    [InlineData("@outputs('Source')")]
    [InlineData("@body('Source')")]
    [InlineData("@variables('message')")]
    [InlineData("@triggerBody()")]
    [InlineData("@triggerOutputs()")]
    [InlineData("@item()")]
    [InlineData("@agentparameters('Name')")]
    [InlineData("@base64('hello')")]
    [InlineData("@json('{}')")]
    [InlineData("@encodeURIComponent('a b')")]
    [InlineData("@listCallbackUrl()")]
    [InlineData("@{outputs('Source')}")]
    [InlineData("Name: @{outputs('Source')}")]
    [InlineData("@csharp{outputs(\"Source\")}")]
    public void Shared_guard_rejects_template_expressions_at_nested_leaves(string expression)
    {
        var token = new JObject { ["nested"] = new JArray(new JObject { ["value"] = expression }) };
        Assert.ThrowsAny<Xunit.Sdk.XunitException>(() => AssertNoTemplateExpressions(token));
    }

    [Theory]
    [InlineData("@@outputs('Source')")]
    [InlineData("@@{outputs('Source')}")]
    [InlineData("@@csharp{1 + 2}")]
    [InlineData("#{outputs(\"Source\")}")]
    [InlineData("#{outputs(\"Source\").ToObject<string>()}")]
    [InlineData("#{\"@{literal}\"}")]
    [InlineData("mail@example.test")]
    [InlineData("##{1 + 2}")]
    [InlineData("prefix #{1 + 2}")]
    [InlineData("#{\"#{1 + 2}\"}")]
    public void Shared_guard_accepts_native_expressions_and_escaped_literals(string expression) =>
        AssertNoTemplateExpressions(new JObject
        {
            ["text"] = expression,
            ["number"] = 3,
            ["enabled"] = true,
            ["nothing"] = JValue.CreateNull(),
        });

    [Fact]
    public void Direct_reference_preserves_JSON_value_and_executes_with_final_identity()
    {
        var emitted = Native("count.Output", after: "count.WithName(\"FinalCount\");", resultType: "int");
        EqualSource("#{outputs(\"FinalCount\")}", emitted);
        var value = new JValue(7);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["FinalCount"] = value });
        Assert.Same(value, result.Value);
        Assert.Equal(JTokenType.Integer, Assert.IsType<JValue>(result.Value).Type);
        Assert.Equal(["FinalCount"], result.Reads);
    }

    [Fact]
    public void Direct_interpolation_preserves_CSharp_braces_and_repeated_reference_evaluation()
    {
        var emitted = Native("$\"{{Name}}: {source.Output}; again: {source.Output}\"", resultType: "string");
        EqualSource("#{$\"{{Name}}: {outputs(\"Source\").ToObject<string>()}; again: {outputs(\"Source\").ToObject<string>()}\"}", emitted);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("hello") });
        Assert.Equal("{Name}: hello; again: hello", result.Value);
        Assert.Equal(["Source", "Source"], result.Reads);
    }

    [Fact]
    public void Typed_model_pass_through_preserves_unknown_JSON_members_without_model_materialization()
    {
        var emitted = Native("summary.Body", CoreHandles, resultType: "OrderSummary");
        EqualSource("#{body(\"GetSummary\")}", emitted);
        var value = JObject.Parse("""{"Total":12.5,"extra":{"items":[1,true,null]}}""");
        var result = LocalNativeHost.Evaluate(emitted, new() { ["GetSummary"] = value });
        Assert.Same(value, result.Value);
        Assert.Equal(["GetSummary"], result.Reads);
    }

    [Fact]
    public void JSON_pass_through_and_typed_encoding_and_parsing_operands_bind_the_same_final_identity()
    {
        var built = Build(Source(Handles + """
            var pass = WorkflowActions.BuiltIn.Compose<string>(() => source.Output);
            var encoded = new Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus.ServicebusActions("connection")
                .SendMessage(entityName: () => "queue", messagecontent: () => source.Output);
            var parsed = WorkflowActions.BuiltIn.Compose<JToken>(() => WorkflowFunctions.ToJson(source.Output));
            source.WithName("Final");
            return new FlowTemplateAction
            {
                Inputs = new JObject
                {
                    ["wire"] = pass.GetActionDefinition("Pass").Inputs.ToJToken(),
                    ["encoded"] = encoded.GetActionDefinition("Encoded").Inputs.ToJToken()["body"]["ContentData"],
                    ["parsed"] = parsed.GetActionDefinition("Parsed").Inputs.ToJToken()
                }
            };
            """));
        var token = Token(built.Definition);
        EqualSource("#{outputs(\"Final\")}", token["wire"]!.Value<string>()!);
        EqualSource("#{base64(outputs(\"Final\").ToObject<string>())}", token["encoded"]!.Value<string>()!);
        EqualSource("#{json(outputs(\"Final\").ToObject<string>())}", token["parsed"]!.Value<string>()!);
        const string text = """{"n":1}""";
        var value = new JValue(text);
        var values = new Dictionary<string, JToken?> { ["Final"] = value };
        var wire = LocalNativeHost.Evaluate(token["wire"]!.Value<string>()!, values);
        var encoded = LocalNativeHost.Evaluate(token["encoded"]!.Value<string>()!, values);
        var parsed = LocalNativeHost.Evaluate(token["parsed"]!.Value<string>()!, values);
        Assert.Same(value, wire.Value);
        Assert.Equal(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text)), encoded.Value);
        Assert.True(JToken.DeepEquals(JObject.Parse(text), Assert.IsType<JObject>(parsed.Value)));
        Assert.Equal(["Final"], wire.Reads);
        Assert.Equal(["Final"], encoded.Reads);
        Assert.Equal(["Final"], parsed.Reads);
    }
}

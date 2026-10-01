#nullable disable
namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Newtonsoft.Json.Linq;

public class RuntimeJsonIntrinsicTests
{
    private static Func<T> Literal<T>(T value) => SourceExpression.Literal(1, value);
    private static string Render<T>(Func<T> expression) =>
        ((JValue)WorkflowActions.BuiltIn.Compose(expression).GetActionDefinition("test").Inputs).Value<string>();

    [Fact]
    public void UntransformedIntrinsicsThrowRatherThanReturnDefaults()
    {
        Assert.Contains("source compiler", Assert.Throws<NotSupportedException>(() => WorkflowFunctions.ToJson("{}")).Message);
        Assert.Contains("source compiler", Assert.Throws<NotSupportedException>(() => WorkflowFunctions.ToJson<JObject>("{}")).Message);
    }

    [Fact]
    public void LegacyReferenceEmitsNativeJsonHelperWithFinalName()
    {
        var source = WorkflowActions.BuiltIn.Compose(Literal("{}")).WithName("Initial");
        var input = SourceExpression.Create<string>(1, "template", ["@", ""], [SourceBinding.Output(source, "string")]);
        var action = WorkflowActions.BuiltIn.Compose(SourceExpression.Json<JObject>(1, input));
        source.Name = "Final";
        var first = action.GetActionDefinition("test");
        source.Name = "Later";
        Assert.Equal("#{json(outputs(\"Final\").ToObject<string>())}", ((JValue)first.Inputs).Value<string>());
        Assert.Equal("#{json(outputs(\"Later\").ToObject<string>())}", ((JValue)action.GetActionDefinition("test").Inputs).Value<string>());
    }

    [Fact]
    public void NativeInputEmitsOneNativeJsonEnvelopeWithoutRootMaterialization()
    {
        var source = WorkflowActions.BuiltIn.Compose(Literal("{}")).WithName("Source");
        var input = SourceExpression.Create<string>(1, "native", ["", ".ToUpperInvariant()"], [SourceBinding.Output(source, "string")]);
        var expression = Render(SourceExpression.Json<JObject>(1, input));
        Assert.Equal("#{json(outputs(\"Source\").ToObject<string>().ToUpperInvariant())}", expression);
        Assert.DoesNotContain("ToObject<global::Newtonsoft.Json.Linq.JObject>", expression);
    }

    [Fact]
    public void InterpolatedInputUsesOneJsonTransform()
    {
        var source = WorkflowActions.BuiltIn.Compose(Literal("value")).WithName("Source");
        var input = SourceExpression.Create<string>(1, "template", ["{\"x\":\"@{", "}\"}"],
            [SourceBinding.Output(source, "string")], nativeSegments: ["$\"{{\\\"x\\\":\\\"{", "}\\\"}}\""]);
        Assert.Equal("#{json($\"{{\\\"x\\\":\\\"{outputs(\"Source\").ToObject<string>()}\\\"}}\")}",
            Render(SourceExpression.Json<JToken>(1, input)));
    }

    [Theory]
    [InlineData("{\"x\":1}", "#{json(\"{\\\"x\\\":1}\")}")]
    [InlineData("{\"name\":\"O'Brien\"}", "#{json(\"{\\\"name\\\":\\\"O'Brien\\\"}\")}")]
    [InlineData("not-json", "#{json(\"not-json\")}")]
    [InlineData(null, "#{json(null)}")]
    public void LiteralInputIsNotParsedOrEvaluatedDuringGeneration(string input, string expected) =>
        Assert.Equal(expected, Render(SourceExpression.Json<JToken>(1, Literal(input))));

    [Fact]
    public void JsonDescriptorRejectsRawInputDelegatesWithoutExecution()
    {
        var calls = 0;
        Func<string> input = () => { calls++; return "{}"; };
        Assert.Throws<NotSupportedException>(() => SourceExpression.Json<JToken>(1, input));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.Json<JToken>(1, null));
        Assert.Throws<NotSupportedException>(() => SourceExpression.Json<JToken>(2, Literal("{}")));
        Assert.Equal(0, calls);
        var descriptor = SourceExpression.Json<JToken>(1, Literal("{}"));
        Assert.Throws<InvalidOperationException>(() => descriptor());
    }

    [Fact]
    public void NativeConsumerMaterializesTypedJsonResult()
    {
        var parsed = SourceExpression.Json<JObject>(1, Literal("{\"x\":1}"));
        var expression = SourceExpression.Create<bool>(1, "native", ["", ".ContainsKey(\"x\")"],
            [SourceBinding.Json(parsed, "global::Newtonsoft.Json.Linq.JObject")]);
        Assert.Equal("#{json(\"{\\\"x\\\":1}\").ToObject<global::Newtonsoft.Json.Linq.JObject>().ContainsKey(\"x\")}",
            Render(expression));
    }

    [Fact]
    public void NativeJTokenConsumerDoesNotAddMaterialization()
    {
        var parsed = SourceExpression.Json<JToken>(1, Literal("{\"x\":1}"));
        var expression = SourceExpression.Create<int>(1, "native", ["", "[\"x\"].Value<int>()"],
            [SourceBinding.Json(parsed, "global::Newtonsoft.Json.Linq.JToken")]);
        Assert.Equal("#{json(\"{\\\"x\\\":1}\")[\"x\"].Value<int>()}", Render(expression));
    }

    [Fact]
    public void NestedNativeJsonMaterializesItsStringInputOnly()
    {
        var input = SourceExpression.Create<string>(1, "native", ["RuntimeValues.NextText()"], []);
        var parsedString = SourceExpression.Json<string>(1, input);
        Assert.Equal("#{json(json(RuntimeValues.NextText()).ToObject<global::System.String>())}",
            Render(SourceExpression.Json<JObject>(1, parsedString)));
    }

    [Fact]
    public void LegacyInterpolationWithNativeSourceMaterializesTypedJsonHelper()
    {
        var parsed = SourceExpression.Json<JObject>(1, Literal("{}"));
        var expression = SourceExpression.Create<string>(1, "template", ["JSON @{", "}"],
            [SourceBinding.Json(parsed, "global::Newtonsoft.Json.Linq.JObject")], nativeSegments: ["$\"JSON {", "}\""]);
        Assert.Equal("#{$\"JSON {json(\"{}\").ToObject<global::Newtonsoft.Json.Linq.JObject>()}\"}", Render(expression));
    }

    [Fact]
    public void JsonBindingRejectsWrongDescriptorsAndMixedLanguageTemplates()
    {
        Assert.Throws<ArgumentException>(() => SourceBinding.Json(Literal("{}"), "string"));
        var calls = 0;
        Func<JToken> raw = () => { calls++; return new JObject(); };
        Assert.Throws<NotSupportedException>(() => SourceBinding.Json(raw, "JToken"));
        Assert.Equal(0, calls);
        var input = SourceExpression.Create<string>(1, "native", ["RuntimeValues.NextText()"], []);
        var parsed = SourceExpression.Json<JObject>(1, input);
        var mixed = SourceExpression.Create<string>(1, "template", ["JSON @{", "}"],
            [SourceBinding.Json(parsed, "global::Newtonsoft.Json.Linq.JObject")]);
        Assert.Throws<NotSupportedException>(() => Render(mixed));
    }

    [Fact]
    public void GeneratedMixedPathMaterializesJsonStringConsumer()
    {
        var native = SourceExpression.Create<string>(1, "native", ["RuntimeValues.NextText()"], []);
        var parsed = SourceExpression.Json<string>(1, Literal("\"session\""));
        var action = new ServicebusActions("connection").CloseSessionInQueue(native, parsed);
        var path = action.GetActionDefinition("test").Inputs.ToJToken()["path"].Value<string>();
        Assert.Contains("encodeURIComponent(json(\"\\\"session\\\"\").ToObject<global::System.String>())", path);
        Assert.DoesNotContain("@json", path);
    }
}

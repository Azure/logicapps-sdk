namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class RuntimeValueDescriptorTests
{
    private static Func<T> Native<T>(string[] segments, params SourceBinding[] bindings) =>
        SourceExpression.Create<T>(1, "native", segments, bindings);

    [Fact]
    public void Dual_descriptor_preserves_JSON_wire_and_typed_encoding_and_parsing()
    {
        var source = WorkflowActions.BuiltIn.Compose(SourceExpression.Literal(1, "{}")).WithName("Initial");
        var value = SourceExpression.Value(1,
            Native<string>(["", ""], SourceBinding.Output(source, "string")),
            Native<JToken>(["", ""], SourceBinding.Output(source, "Newtonsoft.Json.Linq.JToken")));
        var pass = WorkflowActions.BuiltIn.Compose(value);
        var adapted = WorkflowActions.BuiltIn.Compose(SourceExpression.Token(1, value));
        var parsed = WorkflowActions.BuiltIn.Compose(SourceExpression.Json<JToken>(1, value));
        var encoded = new ServicebusActions("connection").SendMessage(
            SourceExpression.Literal(1, "queue"), SourceExpression.Token(1, value));
        source.WithName("Final");
        Assert.Equal("#{outputs(\"Final\")}", Token(pass.GetActionDefinition("Pass")).Value<string>());
        Assert.Equal("#{outputs(\"Final\")}", Token(adapted.GetActionDefinition("Adapted")).Value<string>());
        Assert.Equal("#{json(outputs(\"Final\").ToObject<string>())}", Token(parsed.GetActionDefinition("Parsed")).Value<string>());
        Assert.Equal("#{base64(outputs(\"Final\").ToObject<string>())}",
            Token(encoded.GetActionDefinition("Encoded"))["body"]!["ContentData"]!.Value<string>());
        Assert.Throws<InvalidOperationException>(() => value());
    }

    [Fact]
    public void Returned_wire_definition_is_a_snapshot_while_both_representations_resolve_late()
    {
        var source = WorkflowActions.BuiltIn.Compose(SourceExpression.Literal(1, "{}")).WithName("Initial");
        var value = SourceExpression.Value(1,
            Native<string>(["", ""], SourceBinding.Output(source, "string")),
            Native<JToken>(["", ""], SourceBinding.Output(source, "Newtonsoft.Json.Linq.JToken")));
        var action = WorkflowActions.BuiltIn.Compose(value);
        var first = action.GetActionDefinition("Pass");
        source.WithName("Later");
        Assert.Equal("#{outputs(\"Initial\")}", Token(first).Value<string>());
        Assert.Equal("#{outputs(\"Later\")}", Token(action.GetActionDefinition("Pass")).Value<string>());
        Assert.Equal("#{json(outputs(\"Later\").ToObject<string>())}",
            Token(WorkflowActions.BuiltIn.Compose(SourceExpression.Json<JToken>(1, value)).GetActionDefinition("Parsed")).Value<string>());
    }

    [Fact]
    public void Raw_or_null_delegates_are_rejected_without_execution()
    {
        var calls = 0;
        Func<string> rawNative = () => { calls++; return "unsafe"; };
        Func<JToken> rawWire = () => { calls++; return new JValue("unsafe"); };
        var native = Native<string>(["\"safe\""]);
        var wire = Native<JToken>(["new global::Newtonsoft.Json.Linq.JValue(\"safe\")"]);
        Assert.Throws<NotSupportedException>(() => SourceExpression.Value(1, rawNative, wire));
        Assert.Throws<NotSupportedException>(() => SourceExpression.Value(1, native, rawWire));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.Value<string>(1, null!, wire));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.Value(1, native, null!));
        Assert.Equal(0, calls);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    public void Unsupported_versions_are_explicit(int version) =>
        Assert.Throws<NotSupportedException>(() => SourceExpression.Value(version,
            Native<string>(["\"safe\""]), Native<JToken>(["new global::Newtonsoft.Json.Linq.JValue(\"safe\")"])));

    [Fact]
    public void Both_representations_must_be_native_descriptors()
    {
        var native = Native<string>(["\"safe\""]);
        var wire = Native<JToken>(["new global::Newtonsoft.Json.Linq.JValue(\"safe\")"]);
        Assert.Throws<ArgumentException>(() => SourceExpression.Value(1, SourceExpression.Literal(1, "safe"), wire));
        Assert.Throws<ArgumentException>(() => SourceExpression.Value(1, native, SourceExpression.Literal<JToken>(1, new JValue("safe"))));
        var legacy = SourceExpression.Create<string>(1, "template", ["safe"], [], nativeSegments: ["\"safe\""]);
        Assert.Throws<ArgumentException>(() => SourceExpression.Value(1, legacy, wire));
    }
}

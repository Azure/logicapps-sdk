#nullable disable
namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Newtonsoft.Json.Linq;

public class RuntimeTokenDescriptorTests
{
    private static Func<T> Literal<T>(T value) => SourceExpression.Literal(1, value);
    private static string Content<T>(Func<T> input) =>
        new ServicebusActions("connection").SendMessage(Literal("queue"), SourceExpression.Token(1, input))
            .GetActionDefinition("test").Inputs.ToJToken()["body"]["ContentData"]?.Value<string>();

    [Fact]
    public void RejectsRawDelegatesWithoutExecutionAndChecksVersion()
    {
        var calls = 0;
        Func<int> raw = () => { calls++; return 42; };
        Assert.Throws<NotSupportedException>(() => SourceExpression.Token(1, raw));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.Token<int>(1, null));
        Assert.Throws<NotSupportedException>(() => SourceExpression.Token(2, Literal(42)));
        Assert.Equal(0, calls);
        var descriptor = SourceExpression.Token(1, Literal(42));
        Assert.Throws<InvalidOperationException>(() => descriptor());
    }

    [Fact]
    public void PreservesPrimitiveLiteralsWithoutNativeCasts()
    {
        Assert.Equal("#{base64(\"42\")}", Content(Literal(42)));
        Assert.Equal("#{base64(\"true\")}", Content(Literal(true)));
        Assert.Equal("#{base64(\"hello\")}", Content(Literal("hello")));
        Assert.Null(Content(Literal<string>(null)));
        var output = WorkflowActions.BuiltIn.Compose(SourceExpression.Token(1, Literal(42)))
            .GetActionDefinition("test").Inputs.ToJToken();
        Assert.Equal(JTokenType.Integer, output.Type);
        Assert.Equal(42, output.Value<int>());
    }

    [Fact]
    public void PreservesNativePrimitiveTypesForBase64Normalization()
    {
        var number = SourceExpression.Create<int>(1, "native", ["RuntimeValues.Number"], []);
        var boolean = SourceExpression.Create<bool>(1, "native", ["RuntimeValues.Flag"], []);
        Assert.Equal("#{base64((RuntimeValues.Number).ToString(global::System.Globalization.CultureInfo.InvariantCulture))}", Content(number));
        Assert.Equal("#{base64((RuntimeValues.Flag).ToString().ToLowerInvariant())}", Content(boolean));
    }

    [Fact]
    public void PreservesSnapshottedBytesWithoutDoubleEncoding()
    {
        var bytes = new byte[] { 0, 1, 255 };
        var input = Literal(bytes);
        bytes[0] = 42;
        Assert.Equal("AAH/", Content(input));
        var native = SourceExpression.Create<byte[]>(1, "native", ["RuntimeValues.Bytes"], []);
        Assert.Equal("#{base64(RuntimeValues.Bytes)}", Content(native));
    }

    [Fact]
    public void PreservesDeferredLegacyBindingsInsideNativeEnvelope()
    {
        var source = WorkflowActions.BuiltIn.Compose(Literal("value")).WithName("Initial");
        var input = SourceExpression.Create<string>(1, "template", ["@", ""], [SourceBinding.Output(source, "string")]);
        var action = new ServicebusActions("connection").SendMessage(Literal("queue"), SourceExpression.Token(1, input));
        source.Name = "Final";
        Assert.Equal("#{base64(outputs(\"Final\").ToObject<string>())}",
            action.GetActionDefinition("test").Inputs.ToJToken()["body"]["ContentData"].Value<string>());
    }

    [Fact]
    public void NestedAdaptersRetainJsonDescriptorIdentity()
    {
        var parsed = SourceExpression.Json<JToken>(1, Literal("{}"));
        var token = SourceExpression.Token(1, SourceExpression.Token(1, parsed));
        var expression = SourceExpression.Create<JToken>(1, "native", ["", ""], [SourceBinding.Json(token, "JToken")]);
        Assert.Equal("#{json(\"{}\")}",
            WorkflowActions.BuiltIn.Compose(expression).GetActionDefinition("test").Inputs.ToJToken().Value<string>());
    }
}

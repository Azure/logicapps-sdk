#nullable disable
namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Net;
using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json.Linq;

public class RuntimeEnumDescriptorTests
{
    private static Func<T> Literal<T>(T value) => SourceExpression.Literal(1, value);
    private static Func<T> Native<T>(string text) => SourceExpression.Create<T>(1, "native", [text], []);
    private static string Render<T>(Func<T> expression) =>
        WorkflowActions.BuiltIn.Compose(expression).GetActionDefinition("test").Inputs.ToJToken().Value<string>();

    private static Func<sortbyInput> Conditional()
    {
        var value = Native<sortbyInput>("RuntimeValues.Flag ? global::Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip.sortbyInput.Popularity : global::Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip.sortbyInput.Alphabetically");
        var wire = SourceExpression.Create<string>(1, "native", ["RuntimeValues.Flag ? ", " : ", ""],
            [SourceBinding.EnumWire(Literal(sortbyInput.Popularity)), SourceBinding.EnumWire(Literal(sortbyInput.Alphabetically))]);
        return SourceExpression.Enum(1, value, wire);
    }

    [Fact]
    public void BranchSpecificWireSourceIsNotMappedTwice()
    {
        Assert.Equal("#{RuntimeValues.Flag ? \"p\" : \"a\"}", Render(Conditional()));
        var action = new AbbreviationsipActions("connection").AbbrGet(Literal("term"), sortby: Conditional());
        Assert.Equal("#{RuntimeValues.Flag ? \"p\" : \"a\"}",
            action.GetActionDefinition("test").Inputs.ToJToken()["queries"]["sortby"].Value<string>());
    }

    [Fact]
    public void Base64UsesBranchSpecificWireSourceThroughTokenAdapter()
    {
        var action = new ServicebusActions("connection").SendMessage(Literal("queue"), SourceExpression.Token(1, Conditional()));
        Assert.Equal("#{base64(RuntimeValues.Flag ? \"p\" : \"a\")}",
            action.GetActionDefinition("test").Inputs.ToJToken()["body"]["ContentData"].Value<string>());
    }

    [Fact]
    public void NumericResponseRetainsOriginalTypedSource()
    {
        const string typed = "RuntimeValues.Flag ? global::System.Net.HttpStatusCode.Accepted : global::System.Net.HttpStatusCode.BadRequest";
        var descriptor = SourceExpression.Enum(1, Native<HttpStatusCode>(typed),
            Native<string>("RuntimeValues.Flag ? \"Accepted\" : \"BadRequest\""));
        var response = WorkflowActions.BuiltIn.Response(statusCode: descriptor);
        Assert.Equal("#{(int)(" + typed + ")}",
            response.GetActionDefinition("test").Inputs.ToJToken()["statusCode"].Value<string>());
    }

    [Fact]
    public void NullableEnumLeafRetainsLiteralNull()
    {
        var wire = SourceExpression.Create<string>(1, "native", ["RuntimeValues.Flag ? ", " : ", ""],
            [SourceBinding.EnumWire(Literal<sortbyInput?>(sortbyInput.Popularity)), SourceBinding.EnumWire(Literal<sortbyInput?>(null))]);
        var descriptor = SourceExpression.Enum(1, Native<sortbyInput?>("RuntimeValues.NullableChoice"), wire);
        Assert.Equal("#{RuntimeValues.Flag ? \"p\" : null}", Render(descriptor));
    }

    [Theory]
    [InlineData("flag.Output ? (WireChoice?)RuntimeValues.NextChoice() : null", true, "first /+", 1)]
    [InlineData("flag.Output ? (WireChoice?)RuntimeValues.NextChoice() : null", false, null, 0)]
    [InlineData("(flag.Output ? (WireChoice?)RuntimeValues.NextChoice() : null)", true, "first /+", 1)]
    [InlineData("(flag.Output ? (WireChoice?)RuntimeValues.NextChoice() : null)", false, null, 0)]
    [InlineData("flag.Output ? null : (WireChoice?)RuntimeValues.NextChoice()", true, null, 0)]
    [InlineData("flag.Output ? null : (WireChoice?)RuntimeValues.NextChoice()", false, "first /+", 1)]
    [InlineData("(WireChoice?)(flag.Output ? WireChoice.First : WireChoice.Second)", true, "first /+", 0)]
    [InlineData("(WireChoice?)(flag.Output ? WireChoice.First : WireChoice.Second)", false, "second", 0)]
    public void CompiledNullableConditionalsPreserveBranchesAndLaziness(string source, bool flag, string expected, int calls)
    {
        var expression = ConsumerCompilation.Native(source, resultType: "WireChoice?");
        var syntax = SyntaxFactory.ParseExpression(ConsumerCompilation.NativeBody(expression));
        while (syntax is ParenthesizedExpressionSyntax parentheses)
            syntax = parentheses.Expression;
        var actual = LocalNativeHost.Evaluate(expression, new() { ["Flag"] = flag });
        Assert.Equal(expected, actual.Value);
        Assert.Equal(calls, actual.Calls);
        Assert.Equal(new[] { "Flag" }, actual.Reads);
        Assert.True(syntax is ConditionalExpressionSyntax,
            "Expected branch-specific enum wire source, got: " + expression);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(sortbyInput.Popularity, "p")]
    [InlineData(sortbyInput.Alphabetically, "a")]
    public void NullableEnumWireSurvivesNestedTokenWrappers(sortbyInput? value, string expected)
    {
        var original = Literal(value);
        var wire = SourceExpression.Create<string>(1, "native", ["", ""], [SourceBinding.EnumWire(original)]);
        var descriptor = SourceExpression.Enum(1, original, wire);
        var wrapped = SourceExpression.Token(1, SourceExpression.Token(1, descriptor));
        var actual = LocalNativeHost.Evaluate(Render(wrapped), new());
        Assert.Equal(expected, actual.Value);
        Assert.Equal(0, actual.Calls);
        Assert.Empty(actual.Reads);
    }

    [Theory]
    [InlineData(true, 0)]
    [InlineData(false, 1)]
    public void CompiledEnumOperandRetainsNumericSemantics(bool flag, int expected)
    {
        var expression = ConsumerCompilation.Native(
            "(int)(flag.Output ? WireChoice.First : WireChoice.Second)", resultType: "int");
        var actual = LocalNativeHost.Evaluate(expression, new() { ["Flag"] = flag });
        Assert.Equal(expected, actual.Value);
        Assert.Equal(0, actual.Calls);
        Assert.Equal(new[] { "Flag" }, actual.Reads);
    }

    [Fact]
    public void OpaqueEnumLeafKeepsExistingSingleEvaluationMapping()
    {
        var source = SourceExpression.Create<string>(1, "native", ["", ""],
            [SourceBinding.EnumWire(Native<sortbyInput>("RuntimeValues.NextChoice()"))]);
        var expression = Render(source);
        Assert.StartsWith("#{(RuntimeValues.NextChoice()) switch {", expression);
        Assert.Contains("=> \"p\"", expression);
        Assert.Contains("=> \"a\"", expression);
        Assert.Contains("var value => value.ToString()", expression);
        Assert.Equal(2, expression.Split("RuntimeValues.NextChoice()").Length);
    }

    [Fact]
    public void RejectsRawDelegatesWithoutExecution()
    {
        var calls = 0;
        Func<sortbyInput> raw = () => { calls++; return sortbyInput.Popularity; };
        Func<string> rawWire = () => { calls++; return "p"; };
        Assert.Throws<NotSupportedException>(() => SourceExpression.Enum(1, raw, Literal("p")));
        Assert.Throws<NotSupportedException>(() => SourceExpression.Enum(1, Literal(sortbyInput.Popularity), rawWire));
        Assert.Throws<NotSupportedException>(() => SourceBinding.EnumWire(raw));
        Assert.Equal(0, calls);
        var descriptor = Conditional();
        Assert.Throws<InvalidOperationException>(() => descriptor());
    }

    [Fact]
    public void ValidatesVersionEnumTypesAndNullInputs()
    {
        Assert.Throws<NotSupportedException>(() => SourceExpression.Enum(2, Literal(sortbyInput.Popularity), Literal("p")));
        Assert.Throws<ArgumentException>(() => SourceExpression.Enum(1, Literal(42), Literal("42")));
        Assert.Throws<ArgumentException>(() => SourceBinding.EnumWire(Literal(42)));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.Enum<sortbyInput>(1, null, Literal("p")));
        Assert.Throws<ArgumentNullException>(() => SourceExpression.Enum(1, Literal(sortbyInput.Popularity), null));
        Assert.Throws<ArgumentNullException>(() => SourceBinding.EnumWire(null));
    }
}

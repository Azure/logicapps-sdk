namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ConsumerCompilation;

public sealed class CoreEnumCatalogTests
{
    [Theory]
    [InlineData("E01", "WireChoice.First", "", "WireChoice", "first /+")]
    [InlineData("E02", "WireChoice.Second", "", "WireChoice", "second")]
    [InlineData("E03", "WireChoice.Unannotated", "", "WireChoice", "Unannotated")]
    [InlineData("E04", "choice", "var choice = WireChoice.First;", "WireChoice", "first /+")]
    [InlineData("E09", "(WireChoice)99", "", "WireChoice", "99")]
    [InlineData("E13b", "access", "var access = Access.Read | Access.Write;", "Access", "Read, Write")]
    [InlineData("E13d", "EquivalentAlias.A", "", "EquivalentAlias", "a")]
    public void Open_enum_wire_values_preserve_approved_mapping_and_fallback(
        string catalog, string input, string setup, string type, string expected)
    {
        Assert.NotEmpty(catalog);
        var token = Input(input, setup, resultType: type);
        Assert.Equal(JTokenType.String, token!.Type);
        Assert.Equal(expected, token.Value<string>());
    }

    [Fact, Trait("Catalog", "E13")]
    public void Conflicting_enum_aliases_fail_explicitly()
    {
        var exception = Assert.Throws<NotSupportedException>(() => Input("AliasChoice.A", resultType: "AliasChoice"));
        Assert.Contains("conflict", exception.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact, Trait("Catalog", "E13c")]
    public void Nullable_enum_capture_retains_json_null()
    {
        Assert.Equal(JTokenType.Null, Input("choice", "WireChoice? choice = null;", resultType: "WireChoice?")!.Type);
    }

    [Theory]
    [InlineData("E05", "flag.Output ? WireChoice.First : WireChoice.Second",
        "outputs(\"Flag\").ToObject<bool>() ? \"first /+\" : \"second\"")]
    [InlineData("IN08", "flag.Output ? WireChoice.First : WireChoice.Second",
        "outputs(\"Flag\").ToObject<bool>() ? \"first /+\" : \"second\"")]
    [InlineData("E06", "flag.Output ? WireChoice.First : (otherFlag.Output ? WireChoice.Second : WireChoice.Unannotated)",
        "outputs(\"Flag\").ToObject<bool>() ? \"first /+\" : (outputs(\"OtherFlag\").ToObject<bool>() ? \"second\" : \"Unannotated\")")]
    public void Known_enum_branches_use_selected_wire_strings_without_posthoc_mapping(
        string catalog, string input, string expectedBody)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(input, CoreHandles, resultType: "WireChoice");
        Assert.Equal("first /+", LocalNativeHost.Evaluate(emitted,
            new() { ["Flag"] = new JValue(true), ["OtherFlag"] = new JValue(false) }).Value);
        EqualSource("@csharp{" + expectedBody + "}", emitted);
    }

    [Fact, Trait("Catalog", "E07")]
    public void Runtime_enum_method_maps_once_without_generation_invocation()
    {
        var built = Build(Source("""
            return WorkflowActions.BuiltIn.Compose<WireChoice>(input: () => RuntimeValues.NextChoice()).GetActionDefinition("Catalog");
            """));
        Assert.Equal(0, built.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(built.Definition).Value<string>()!;
        Assert.StartsWith("@csharp{", emitted);
        Assert.Equal(1, emitted.Split("RuntimeValues.NextChoice()").Length - 1);
        Assert.Contains("\"first /+\"", emitted);
        Assert.Contains("\"second\"", emitted);
        Assert.Contains("\"Unannotated\"", emitted);
        Assert.Contains("value.ToString()", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new());
        Assert.Equal("first /+", local.Value);
        Assert.Equal(1, local.Calls);
    }

    [Fact, Trait("Catalog", "E08"), Trait("Catalog", "X03")]
    public void Enum_conditional_preserves_laziness_and_branch_specific_mapping()
    {
        var built = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<WireChoice>(input: () => flag.Output ? WireChoice.First : RuntimeValues.NextChoice()).GetActionDefinition("Catalog");
            """));
        Assert.Equal(0, built.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(built.Definition).Value<string>()!;
        var selected = LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(true) });
        Assert.Equal("first /+", selected.Value);
        Assert.Equal(0, selected.Calls);
        var conditional = Assert.IsType<ConditionalExpressionSyntax>(SyntaxFactory.ParseExpression(emitted[8..^1]));
        EqualSource("@csharp{outputs(\"Flag\").ToObject<bool>()}", "@csharp{" + conditional.Condition + "}");
        Assert.Equal("first /+", Assert.IsType<LiteralExpressionSyntax>(conditional.WhenTrue).Token.ValueText);
        // The catalog permits an equivalent runtime helper instead of a particular opaque-result switch.
        foreach (var (choice, expected) in new[] { (0, "first /+"), (1, "second"), (2, "Unannotated"), (99, "99") })
        {
            var fallback = LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(false) }, initialize: assembly =>
            {
                var field = assembly.GetType("RuntimeValues")!.GetField("ChoiceResult")!;
                field.SetValue(null, Enum.ToObject(field.FieldType, choice));
            });
            Assert.Equal(expected, fallback.Value);
            Assert.Equal(1, fallback.Calls);
        }
    }

    [Fact, Trait("Catalog", "E10")]
    public void Enum_comparison_does_not_wire_map_native_operands()
    {
        var emitted = Native("choiceAction.Output == WireChoice.First", CoreHandles);
        EqualSource("@csharp{outputs(\"Choice\").ToObject<WireChoice>() == WireChoice.First}", emitted);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new() { ["Choice"] = new JValue("First") }).Value);
        Assert.Equal(false, LocalNativeHost.Evaluate(emitted, new() { ["Choice"] = new JValue("Second") }).Value);
    }

    [Fact, Trait("Catalog", "E11")]
    public void Enum_native_argument_keeps_clr_enum_type()
    {
        var emitted = Native("RuntimeValues.Accept(choiceAction.Output)", CoreHandles);
        EqualSource("@csharp{RuntimeValues.Accept(outputs(\"Choice\").ToObject<WireChoice>())}", emitted);
        Assert.Equal("First", LocalNativeHost.Evaluate(emitted, new() { ["Choice"] = new JValue("First") }).Value);
    }

    [Fact, Trait("Catalog", "E12")]
    public void Enum_ToString_is_not_replaced_by_wire_metadata()
    {
        var emitted = Native("WireChoice.First.ToString()");
        EqualSource("@csharp{WireChoice.First.ToString()}", emitted);
        Assert.Equal("First", LocalNativeHost.Evaluate(emitted, new()).Value);
    }

    [Fact]
    public void Nullable_to_enum_cast_preserves_failure_in_wire_and_numeric_consumers()
    {
        const string value = "(WireChoice)(flag.Output ? (WireChoice?)WireChoice.Second : null)";
        var wire = Native(value, resultType: "WireChoice");
        Assert.Equal("second", LocalNativeHost.Evaluate(wire, new() { ["Flag"] = new JValue(true) }).Value);
        Assert.Throws<InvalidOperationException>(() =>
            LocalNativeHost.Evaluate(wire, new() { ["Flag"] = new JValue(false) }));

        var numeric = Native("(int)" + value, resultType: "int");
        EqualSource("@csharp{(int)(WireChoice)(outputs(\"Flag\").ToObject<bool>() ? (WireChoice?)WireChoice.Second : null)}", numeric);
        Assert.Equal(1, Assert.IsType<int>(LocalNativeHost.Evaluate(numeric, new() { ["Flag"] = new JValue(true) }).Value));
        Assert.Throws<InvalidOperationException>(() =>
            LocalNativeHost.Evaluate(numeric, new() { ["Flag"] = new JValue(false) }));
    }
}

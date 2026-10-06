namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CoreOperatorCatalogTests
{
    [Theory]
    [InlineData("O12", "-count.Output", "-outputs(\"Count\").ToObject<int>()", -5)]
    [InlineData("O15", "(count.Output + 2) * 3", "(outputs(\"Count\").ToObject<int>() + 2) * 3", 21)]
    [InlineData("O16", "count.Output - (quantity.Output - 1)", "outputs(\"Count\").ToObject<int>() - (outputs(\"Quantity\").ToObject<int>() - 1)", 3)]
    [InlineData("O17b", "count.Output & 3", "outputs(\"Count\").ToObject<int>() & 3", 1)]
    [InlineData("O17c", "count.Output | 3", "outputs(\"Count\").ToObject<int>() | 3", 7)]
    [InlineData("O17d", "count.Output ^ 3", "outputs(\"Count\").ToObject<int>() ^ 3", 6)]
    [InlineData("O17e", "~count.Output", "~outputs(\"Count\").ToObject<int>()", -6)]
    [InlineData("O19", "(int)amount.Output", "(int)outputs(\"Amount\").ToObject<decimal>()", 2)]
    public void Integer_operator_source_and_runtime_types(string catalog, string input, string expectedBody, int expected)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(input, CoreHandles);
        EqualSource("#{" + expectedBody + "}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new()
        {
            ["Count"] = new JValue(5), ["Quantity"] = new JValue(3), ["Amount"] = new JValue(2.75m),
        });
        Assert.Equal(expected, Assert.IsType<int>(local.Value));
    }

    [Theory]
    [InlineData("O06", "count.Output == 5", "outputs(\"Count\").ToObject<int>() == 5", true)]
    [InlineData("O07", "count.Output != 5", "outputs(\"Count\").ToObject<int>() != 5", false)]
    [InlineData("O08", "count.Output < 5", "outputs(\"Count\").ToObject<int>() < 5", false)]
    [InlineData("O08b", "count.Output <= 5", "outputs(\"Count\").ToObject<int>() <= 5", true)]
    [InlineData("O08c", "count.Output > 5", "outputs(\"Count\").ToObject<int>() > 5", false)]
    [InlineData("O08d", "count.Output >= 5", "outputs(\"Count\").ToObject<int>() >= 5", true)]
    [InlineData("O11", "!flag.Output", "!outputs(\"Flag\").ToObject<bool>()", false)]
    public void Boolean_operator_source_and_runtime_types(string catalog, string input, string expectedBody, bool expected)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(input);
        EqualSource("#{" + expectedBody + "}", emitted);
        Assert.Equal(expected, Assert.IsType<bool>(LocalNativeHost.Evaluate(emitted,
            new() { ["Count"] = new JValue(5), ["Flag"] = new JValue(true) }).Value));
    }

    [Theory]
    [InlineData("O09", "&&", false, true, false, 1)]
    [InlineData("O09", "&&", true, true, true, 2)]
    [InlineData("O10", "||", true, false, true, 1)]
    [InlineData("O10", "||", false, true, true, 2)]
    [InlineData("O10b", "&", false, true, false, 2)]
    [InlineData("O10c", "|", true, false, true, 2)]
    public void Logical_operators_preserve_short_circuit_and_eager_evaluation(
        string catalog, string op, bool left, bool right, bool expected, int reads)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native($"flag.Output {op} otherFlag.Output", CoreHandles);
        EqualSource($"#{{outputs(\"Flag\").ToObject<bool>() {op} outputs(\"OtherFlag\").ToObject<bool>()}}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(left), ["OtherFlag"] = new JValue(right) });
        Assert.Equal(expected, Assert.IsType<bool>(local.Value));
        Assert.Equal(reads == 1 ? ["Flag"] : new[] { "Flag", "OtherFlag" }, local.Reads);
    }

    [Fact, Trait("Catalog", "O13")]
    public void Conditional_keeps_both_native_branches()
    {
        var emitted = Native("flag.Output ? \"yes\" : \"no\"");
        EqualSource("#{outputs(\"Flag\").ToObject<bool>() ? \"yes\" : \"no\"}", emitted);
        foreach (var flag in new[] { true, false })
            Assert.Equal(flag ? "yes" : "no", LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(flag) }).Value);
    }

    [Fact, Trait("Catalog", "O14")]
    public void Coalescing_materializes_workflow_json_null_as_clr_null()
    {
        var emitted = Native("source.Output ?? \"default\"");
        EqualSource("#{outputs(\"Source\").ToObject<string>() ?? \"default\"}", emitted);
        Assert.Equal("default", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = JValue.CreateNull() }).Value);
        Assert.Equal("value", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("value") }).Value);
    }

    [Fact, Trait("Catalog", "O20")]
    public void User_operator_is_preserved_and_invoked_locally()
    {
        var emitted = Native("money.Output + new Money(2m)", CoreHandles);
        EqualSource("#{outputs(\"Money\").ToObject<Money>() + new Money(2m)}", emitted);
        var value = LocalNativeHost.Evaluate(emitted, new() { ["Money"] = JObject.Parse("""{"Value":3}""") }).Value!;
        Assert.Equal(5m, (decimal)value.GetType().GetProperty("Value")!.GetValue(value)!);
        Assert.Equal(1, value.GetType().GetField("OperatorCalls")!.GetValue(null));
    }

    [Fact, Trait("Catalog", "O21")]
    public void Lifted_nullable_arithmetic_keeps_null_and_integer_values()
    {
        var emitted = Native("nullableCount.Output + 2", CoreHandles);
        EqualSource("#{outputs(\"NullableCount\").ToObject<int?>() + 2}", emitted);
        Assert.Null(LocalNativeHost.Evaluate(emitted, new() { ["NullableCount"] = JValue.CreateNull() }).Value);
        Assert.Equal(5, Assert.IsType<int>(LocalNativeHost.Evaluate(emitted, new() { ["NullableCount"] = new JValue(3) }).Value));
    }

    [Fact, Trait("Catalog", "O22"), Trait("Catalog", "O22b"), Trait("Catalog", "O22d")]
    public void JToken_native_equality_keeps_reference_and_clr_null_semantics()
    {
        var emitted = Native("tokenSource.Output == tokenOther.Output", CoreHandles);
        EqualSource("#{outputs(\"TokenSource\") == outputs(\"TokenOther\")}", emitted);
        var same = JObject.Parse("""{"n":1}""");
        Assert.Equal(false, Equal(same, JObject.Parse("""{"n":1}""")));
        Assert.Equal(true, Equal(same, same));
        Assert.Equal(true, Equal(null, null));
        Assert.Equal(false, Equal(null, same));
        Assert.Equal(false, Equal(same, JObject.Parse("""{"n":2}""")));
        Assert.Equal(false, Equal(JValue.CreateNull(), null));
        object? Equal(JToken? left, JToken? right) =>
            LocalNativeHost.Evaluate(emitted, new() { ["TokenSource"] = left, ["TokenOther"] = right }).Value;
    }

    [Fact, Trait("Catalog", "O22c")]
    public void Explicit_deep_equality_remains_distinct_from_native_equality()
    {
        var emitted = Native("JToken.DeepEquals(tokenSource.Output, tokenOther.Output)", CoreHandles);
        EqualSource("#{Newtonsoft.Json.Linq.JToken.DeepEquals(outputs(\"TokenSource\"), outputs(\"TokenOther\"))}", emitted);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new()
        {
            ["TokenSource"] = JObject.Parse("""{"n":1}"""), ["TokenOther"] = JObject.Parse("""{"n":1}"""),
        }).Value);
    }
}

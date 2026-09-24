namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using static ConsumerCompilation;

public sealed class SourceComparisonTests
{
    [Fact]
    public void Qualified_interpolation_grouping_does_not_change_the_source_contract()
    {
        EqualSource(
            """#{$"Model: {new DisplayModel { Id = 3 }}"}""",
            """#{$"Model: {(new global::DisplayModel { Id = 3 })}"}""");
    }

    [Fact]
    public void Native_comparison_retains_interior_precedence_and_literal_contents()
    {
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("#{x * (y + z)}", "#{x * y + z}"));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("""#{"global::System.Int32"}""", """#{"int"}"""));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("""#{$"{(x * (y + z))}"}""", """#{$"{x * y + z}"}"""));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("#{x - (y - z)}", "#{(x - y) - z}"));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("#{1}", "#{1L}"));
    }

    [Fact]
    public void Transparent_grouping_preserves_recursive_operator_structure()
    {
        EqualSource("#{x * (y + z)}", "#{(x) * ((y + z))}");
    }

    [Fact]
    public void Conditional_switch_and_its_governing_expression_allow_harmless_grouping()
    {
        EqualSource(
            """#{flag ? "known" : (Next() switch { 0 => "zero", _ => "other" })}""",
            """#{flag ? "known" : (Next()) switch { 0 => "zero", _ => "other" }}""");
    }
}

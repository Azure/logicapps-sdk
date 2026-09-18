namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using static ConsumerCompilation;

public sealed class SourceComparisonTests
{
    [Fact]
    public void Qualified_interpolation_grouping_does_not_change_the_source_contract()
    {
        EqualSource(
            """@csharp{$"Model: {new DisplayModel { Id = 3 }}"}""",
            """@csharp{$"Model: {(new global::DisplayModel { Id = 3 })}"}""");
    }

    [Fact]
    public void Native_comparison_retains_interior_precedence_and_literal_contents()
    {
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("@csharp{x * (y + z)}", "@csharp{x * y + z}"));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("""@csharp{"global::System.Int32"}""", """@csharp{"int"}"""));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("""@csharp{$"{(x * (y + z))}"}""", """@csharp{$"{x * y + z}"}"""));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("@csharp{x - (y - z)}", "@csharp{(x - y) - z}"));
        Assert.Throws<Xunit.Sdk.TrueException>(() =>
            EqualSource("@csharp{1}", "@csharp{1L}"));
    }

    [Fact]
    public void Transparent_grouping_preserves_recursive_operator_structure()
    {
        EqualSource("@csharp{x * (y + z)}", "@csharp{(x) * ((y + z))}");
    }

    [Fact]
    public void Conditional_switch_and_its_governing_expression_allow_harmless_grouping()
    {
        EqualSource(
            """@csharp{flag ? "known" : (Next() switch { 0 => "zero", _ => "other" })}""",
            """@csharp{flag ? "known" : (Next()) switch { 0 => "zero", _ => "other" }}""");
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using GeneratedConnectorParity;

public class GeneratedConnectorParityTests
{
    private const string Baseline = """
        namespace Connectors {
            public class Actions(string connection) {
                public string Send([WorkflowExpression] System.Func<string> value = null) {
                    Validate(value);
                    string Build() { return ConvertToken(value); }
                    return Build();
                }
            }
        }
        """;

    [Fact]
    public void WhitespaceAndCommentsAreNotContractDifferences()
    {
        var result = Compare(Baseline.Replace("Validate(value);", "// comment\n Validate ( value ) ;"));
        Assert.False(result.ExactMatch);
        Assert.True(result.TokenMatch);
        Assert.Empty(result.ApiDifferences);
        Assert.Empty(result.ImplementationDifferences);
    }

    [Theory]
    [InlineData("[WorkflowExpression]", "")]
    [InlineData("value = null", "value")]
    [InlineData("public string Send", "public object Send")]
    [InlineData("value = null", "renamed = null")]
    [InlineData("string connection", "int connection")]
    public void PublicSignatureChangesAreDetected(string before, string after)
    {
        Assert.NotEmpty(Compare(Baseline.Replace(before, after)).ApiDifferences);
    }

    [Theory]
    [InlineData("Validate(value);", "")]
    [InlineData("ConvertToken(value)", "ConvertO(value)")]
    [InlineData("return Build();", "return value();")]
    public void ValidationConversionAndEagerExecutionChangesAreDetected(string before, string after)
    {
        var result = Compare(Baseline.Replace(before, after));
        Assert.Empty(result.ApiDifferences);
        Assert.NotEmpty(result.ImplementationDifferences);
    }

    [Fact]
    public void ImportChangesAreNotReportedAsEquivalentApis()
    {
        var result = ConnectorComparison.CompareSource("test.cs",
            "using Value = System.String;\n" + Baseline,
            "using Value = System.Int32;\n" + Baseline);
        Assert.True(result.ContextChanged);
        Assert.False(result.TokenMatch);
        Assert.Contains(result.CandidateContext, item => item.Contains("Int32"));
    }

    [Fact]
    public void CommentsInsideImportsDoNotChangeContext()
    {
        var result = ConnectorComparison.CompareSource("test.cs",
            "using System;\n" + Baseline, "using /* explanation */ System ;\n" + Baseline);
        Assert.True(result.TokenMatch);
        Assert.False(result.ContextChanged);
    }

    [Fact]
    public void DirectivesAndDisabledCodeAreNotIgnoredAsComments()
    {
        var result = ConnectorComparison.CompareSource("test.cs", "#nullable enable\n" + Baseline, "#nullable disable\n" + Baseline);
        Assert.True(result.ContextChanged);
        Assert.False(result.TokenMatch);
        result = ConnectorComparison.CompareSource("test.cs", Baseline + "\n#if false\none\n#endif", Baseline + "\n#if false\ntwo\n#endif");
        Assert.False(result.TokenMatch);
    }

    [Fact]
    public void LiteralWhitespaceAndEnumWireNamesAreSignificant()
    {
        var baseline = """public enum Mode { [EnumMember(Value="a b")] First, Second }""";
        var candidate = baseline.Replace("a b", "ab");
        Assert.NotEmpty(ConnectorComparison.CompareSource("test.cs", baseline, candidate).ApiDifferences);
        Assert.NotEmpty(ConnectorComparison.CompareSource("test.cs", "public enum Mode { First, Second }",
            "public enum Mode { Second, First }").ApiDifferences);
    }

    [Fact]
    public void ModelWireNamesAndSetterAccessibilityAreApiChanges()
    {
        var baseline = """public class Model { [JsonProperty("wire")] public string Value { get; set; } }""";
        Assert.NotEmpty(ConnectorComparison.CompareSource("test.cs", baseline, baseline.Replace("\"wire\"", "\"changed\"")).ApiDifferences);
        Assert.NotEmpty(ConnectorComparison.CompareSource("test.cs", baseline, baseline.Replace("set;", "private set;")).ApiDifferences);
    }

    [Fact]
    public void PrivateHelpersAreImplementationNotPublicApiChanges()
    {
        var baseline = "public class A { private int Helper() => 1; }";
        var result = ConnectorComparison.CompareSource("test.cs", baseline, baseline.Replace("=> 1", "=> 2"));
        Assert.Empty(result.ApiDifferences);
        Assert.NotEmpty(result.ImplementationDifferences);
    }

    [Fact]
    public void NamespacesAndOverloadsHaveDistinctMemberIdentities()
    {
        var baseline = "namespace A { public class C { public void M(int x) {} public void M(string x) {} } }";
        var result = ConnectorComparison.CompareSource("test.cs", baseline, baseline.Replace("M(string x)", "M(string y)"));
        Assert.Single(result.ApiDifferences);
        Assert.NotEmpty(ConnectorComparison.CompareSource("test.cs", baseline, baseline.Replace("namespace A", "namespace B")).ApiDifferences);
    }

    [Fact]
    public void MalformedSourcesCannotPassEvenAgainstThemselves()
    {
        var result = ConnectorComparison.CompareSource("test.cs", "public class {", "public class {");
        Assert.NotEmpty(result.Errors);
        Assert.False(result.TokenMatch);
    }

    [Fact]
    public void MemberReorderingDoesNotHideBehindAnExactSourceMatch()
    {
        var result = ConnectorComparison.CompareSource("test.cs",
            "public class A { public int First() => 1; public int Second() => 2; }",
            "public class A { public int Second() => 2; public int First() => 1; }");
        Assert.False(result.TokenMatch);
        Assert.Empty(result.ApiDifferences);
        Assert.Empty(result.ImplementationDifferences);
    }

    [Fact]
    public void PartialCoverageIsExplicitAndCannotPassFullMatch()
    {
        var root = Path.Combine(Path.GetTempPath(), "connector-parity-" + Guid.NewGuid().ToString("N"));
        var baseline = Path.Combine(root, "baseline");
        var candidate = Path.Combine(root, "candidate");
        try
        {
            Directory.CreateDirectory(Path.Combine(baseline, "managed"));
            Directory.CreateDirectory(Path.Combine(baseline, "serviceProviders"));
            Directory.CreateDirectory(Path.Combine(candidate, "managed"));
            File.WriteAllText(Path.Combine(baseline, "managed", "A.cs"), Baseline);
            File.WriteAllText(Path.Combine(baseline, "serviceProviders", "B.cs"), Baseline);
            File.WriteAllText(Path.Combine(candidate, "managed", "A.cs"), Baseline);
            File.WriteAllText(Path.Combine(candidate, "managed", "Extra.cs"), Baseline);
            var result = ConnectorComparison.CompareDirectories(baseline, candidate);
            Assert.False(result.IsFullMatch);
            Assert.Equal(Path.Combine("serviceProviders", "B.cs"), Assert.Single(result.NotGenerated));
            Assert.Equal(Path.Combine("managed", "Extra.cs"), Assert.Single(result.CandidateOnly));
            Assert.Equal(0, result.Coverage.Single(item => item.Family == "serviceProviders").ComparedFiles);
            Assert.True(Assert.Single(result.Files).ExactMatch);
            Assert.All(result.BaselineInventory, item => Assert.Equal(64, item.Sha256.Length));
            Assert.True(ConnectorComparison.CompareDirectories(baseline, baseline).IsFullMatch);
            File.Delete(Path.Combine(candidate, "managed", "A.cs"));
            File.Delete(Path.Combine(candidate, "managed", "Extra.cs"));
            Assert.Throws<InvalidDataException>(() => ConnectorComparison.CompareDirectories(baseline, candidate));
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    private static FileComparison Compare(string candidate) => ConnectorComparison.CompareSource("test.cs", Baseline, candidate);
}

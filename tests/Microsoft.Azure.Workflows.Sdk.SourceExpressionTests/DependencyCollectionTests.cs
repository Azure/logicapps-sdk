namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Build;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ConsumerCompilation;

public sealed class DependencyCollectionTests
{
    [Fact]
    public void Native_static_helper_is_recorded_with_source_location_without_execution()
    {
        var result = Inspect("RuntimeValues.NextText()");
        var dependency = Assert.Single(result.Dependencies.Where(d => d.MetadataTypeName == "RuntimeValues" && d.Member == "NextText"));
        Assert.Equal("Consumer.cs", dependency.SourceFile);
        Assert.True(dependency.SourceLine > 0);
        Assert.True(dependency.Accessible);
        Assert.StartsWith("SourceConsumer_", dependency.Assembly);
    }

    [Fact]
    public void Native_SDK_helper_is_a_deployment_dependency_not_an_assumed_host_assembly()
    {
        var result = Inspect("WorkflowWireRuntime.ToCompactJson(count.Output)", Handles);
        Assert.Contains(result.Dependencies, d =>
            d.Assembly == "Microsoft.Azure.Workflows.Sdk" &&
            d.MetadataTypeName == "Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime" &&
            d.Member == "ToCompactJson");
    }

    [Fact]
    public void Workflow_binding_records_the_actual_materialized_CLR_type()
    {
        var result = Inspect("typed.Output.Child.Text",
            "IOutputWorkflowAction<LocalModel> typed = null;");
        Assert.Contains(result.Dependencies, d => d.MetadataTypeName == "LocalModel" && d.Member == null);
        Assert.DoesNotContain(result.Dependencies, d => d.Assembly == "Microsoft.Azure.Workflows.Sdk");
    }

    [Theory]
    [InlineData("WireChoice.First", "")]
    [InlineData("choice", "const WireChoice choice = WireChoice.First;")]
    [InlineData("choice", "WireChoice choice = WireChoice.First;")]
    [InlineData("choices", "var choices = new[] { WireChoice.First };")]
    [InlineData("RuntimeValues.Accept(choice)", "const WireChoice choice = WireChoice.First;")]
    public void Enum_literals_captures_collections_and_native_constants_retain_type_dependencies(string expression, string setup)
    {
        var result = Inspect(expression, setup);
        Assert.Contains(result.Dependencies, d => d.MetadataTypeName == "WireChoice" && d.Member == null);
    }

    [Fact]
    public void Snapshot_substitution_does_not_record_captured_object_getters_or_leak_another_scope()
    {
        Assert.Contains(Inspect("RuntimeValues.NextText()").Dependencies, d => d.MetadataTypeName == "RuntimeValues");
        var captured = Inspect("model.Child.Text",
            "var model = new LocalModel { Child = new LocalLeaf { Text = \"snapshot\" } };");
        Assert.Empty(captured.Dependencies);
    }

    [Fact]
    public async Task Concurrent_transformations_keep_dependency_ownership_and_source_output_isolated()
    {
        var compilations = Enumerable.Range(0, 4).Select(index => Compile(Source($$"""
            return WorkflowActions.BuiltIn.Compose<string>(input: () => Dependency{{index}}.Read()).GetActionDefinition("Dependencies");
            """) + $$"""
            public static class Dependency{{index}} { public static string Read() => "value"; }
            """)).ToArray();
        var expected = compilations.Select(ExpressionCompilationTransformer.Transform).ToArray();
        var actual = await Task.WhenAll(compilations.Select(compilation =>
            Task.Run(() => ExpressionCompilationTransformer.Transform(compilation))));

        for (var index = 0; index < compilations.Length; index++)
        {
            Assert.Empty(actual[index].Diagnostics);
            Assert.Equal(expected[index].Dependencies.ToArray(), actual[index].Dependencies.ToArray());
            Assert.Equal(expected[index].Sources["Consumer.cs"], actual[index].Sources["Consumer.cs"]);
            Assert.Equal(2, actual[index].Dependencies.Length);
            Assert.All(actual[index].Dependencies, dependency =>
            {
                Assert.Equal("Dependency" + index, dependency.MetadataTypeName);
                Assert.Equal(compilations[index].AssemblyName, dependency.Assembly);
            });
        }
    }

    [Fact]
    public void Failed_transform_does_not_leak_partial_dependencies_into_the_next_transform()
    {
        var failed = Transform(Source("""
            var captured = 1;
            return WorkflowActions.BuiltIn.Compose<string>(input: () => RuntimeValues.NextText() + ++captured)
                .GetActionDefinition("Dependencies");
            """));
        Assert.Contains(failed.Diagnostics, diagnostic => diagnostic.Id == "WFBUILD003");
        Assert.Contains(failed.Dependencies, dependency => dependency.Member == "NextText");
        Assert.Empty(Inspect("42").Dependencies);
    }

    [Fact]
    public void Repeated_dependency_retains_first_source_location_and_deterministic_order()
    {
        var compilation = Compile(Source("""
            return WorkflowActions.BuiltIn.Compose<string>(
                input: () => RuntimeValues.NextText() + RuntimeValues.CurrentText + RuntimeValues.NextText())
                .GetActionDefinition("Dependencies");
            """));
        var firstCall = compilation.SyntaxTrees.Single().GetRoot().DescendantNodes()
            .OfType<InvocationExpressionSyntax>().First(call => call.Expression.ToString() == "RuntimeValues.NextText");
        var result = ExpressionCompilationTransformer.Transform(compilation);
        Assert.Empty(result.Diagnostics);
        Assert.Equal([null, "CurrentText", "NextText"], result.Dependencies.Select(dependency => dependency.Member));
        var method = Assert.Single(result.Dependencies.Where(dependency => dependency.Member == "NextText"));
        Assert.Equal(firstCall.SyntaxTree.FilePath, method.SourceFile);
        Assert.Equal(firstCall.GetLocation().GetLineSpan().StartLinePosition.Line + 1, method.SourceLine);
        Assert.Equal(result.Dependencies.ToArray(),
            ExpressionCompilationTransformer.Transform(compilation).Dependencies.ToArray());
    }

    [Fact]
    public void Unsupported_capture_diagnostic_retains_its_exact_source_span()
    {
        var compilation = Compile(Source("""
            var captured = 1;
            return WorkflowActions.BuiltIn.Compose<int>(input: () => ++captured).GetActionDefinition("Dependencies");
            """));
        var result = ExpressionCompilationTransformer.Transform(compilation);
        var diagnostic = Assert.Single(result.Diagnostics);
        Assert.Equal("WFBUILD003", diagnostic.Id);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Equal("Consumer.cs", diagnostic.Location.SourceTree!.FilePath);
        Assert.Equal("captured", diagnostic.Location.SourceTree.GetText().ToString(diagnostic.Location.SourceSpan));
    }

    private static TransformationResult Inspect(string expression, string setup = "")
    {
        var transformed = Transform(Source(setup + $$"""
            return WorkflowActions.BuiltIn.Compose<object>(input: () => {{expression}}).GetActionDefinition("Dependencies");
            """));
        Assert.Empty(transformed.Diagnostics);
        return transformed;
    }
}

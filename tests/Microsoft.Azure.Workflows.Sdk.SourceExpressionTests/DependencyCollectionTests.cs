namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Build;
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

    private static TransformationResult Inspect(string expression, string setup = "")
    {
        var transformed = Transform(Source(setup + $$"""
            return WorkflowActions.BuiltIn.Compose<object>(input: () => {{expression}}).GetActionDefinition("Dependencies");
            """));
        Assert.Empty(transformed.Diagnostics);
        return transformed;
    }
}

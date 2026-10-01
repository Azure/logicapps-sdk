using Microsoft.CodeAnalysis;

[Generator]
public sealed class WorkflowGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(output => output.AddSource("GeneratedWorkflow.cs", @"
using Microsoft.Azure.Workflows.Sdk;
public static class GeneratedWorkflow
{
    public static object Create() =>
        WorkflowActions.BuiltIn.Compose(inputs: () => ""generated"");
}"));
    }
}

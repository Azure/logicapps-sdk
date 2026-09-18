using Microsoft.Azure.Workflows.Sdk;

internal static class FixtureWorkflow
{
    public static object Run()
    {
        var suffix = "!";
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "source").WithName("Source");
        var compose = WorkflowActions.BuiltIn.Compose(inputs: () => source.Output.ToUpperInvariant() + suffix);
        return new { input = FixtureAssert.Input(compose) };
    }
}

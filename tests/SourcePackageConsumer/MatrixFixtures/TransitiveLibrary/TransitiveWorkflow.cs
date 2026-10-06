using Microsoft.Azure.Workflows.Sdk;

public static class TransitiveWorkflow
{
    public static IOutputWorkflowAction<string> Build() =>
        WorkflowActions.BuiltIn.Compose<string>(() => "indirect package reference");
}

using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static partial class CaptureCases
{
    [WorkflowCase("SourceVisibleFactory", "HELLO", FailureIds = new[] { "F028" })]
    public static FlowDefinition SourceVisibleFactory()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<string>(input: Make(source));
        return Finish("SourceVisibleFactory", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }
    private static Func<string> Make(IOutputWorkflowAction<string> source) => () => source.Output.ToUpperInvariant();
}

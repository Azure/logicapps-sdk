using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static partial class CaptureCases
{
    [WorkflowCase("SourceVisibleDelegate", "hello", FailureIds = new[] { "F012" })]
    public static FlowDefinition SourceVisibleDelegate()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        Func<string> e = () => source.Output;
        var result = WorkflowActions.BuiltIn.Compose(inputs: e);
        return Finish("SourceVisibleDelegate", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }
}

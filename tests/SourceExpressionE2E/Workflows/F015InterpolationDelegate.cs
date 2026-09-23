using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static partial class CaptureCases
{
    [WorkflowCase("InterpolationDelegate", "hello{}", FailureIds = new[] { "F015" })]
    public static FlowDefinition InterpolationDelegate()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        Func<string> message = () => $"hello{trigger.TriggerOutput.Body}";
        var result = WorkflowActions.BuiltIn.Compose(inputs: message);
        return Finish("InterpolationDelegate", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }
}

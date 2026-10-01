using Microsoft.Azure.Workflows.Sdk;
using Newtonsoft.Json.Linq;

public static class WorkflowHelper
{
    public static IOutputWorkflowAction<JToken> Build(IOutputWorkflowAction<string> action, string ending) =>
        WorkflowActions.BuiltIn.Compose(inputs: () => action.Output + ending);
}

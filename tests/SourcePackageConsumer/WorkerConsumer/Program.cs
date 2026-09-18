using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Workflows.Sdk;

var result = WorkflowProbe.Run(null)
    .Replace("ToObject<global::System.String>()", "ToObject<string>()", StringComparison.Ordinal);
if (result != "@csharp{outputs(\"WorkerSource\").ToObject<string>().ToUpperInvariant()}")
{
    throw new InvalidOperationException($"Worker function workflow was not transformed: {result}");
}

Console.WriteLine(result);

public static class WorkflowProbe
{
    [Function("WorkflowProbe")]
    public static string Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData request)
    {
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "input").WithName("WorkerSource");
        var action = WorkflowActions.BuiltIn.Compose(inputs: () => source.Output.ToUpperInvariant());
        return ((WorkflowActionBase)action).GetActionDefinition("WorkerConsumer").Inputs.ToString();
    }
}

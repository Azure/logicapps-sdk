using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Extensions.Hosting;
using NativeHost.Generated;
using Newtonsoft.Json.Linq;

if (args is ["--export", var destination])
{
    foreach (var workflow in new NativeProbeWorkflows().GetWorkflows())
    {
        var directory = Path.Combine(destination, workflow.Name);
        Directory.CreateDirectory(directory);
        File.WriteAllText(Path.Combine(directory, "workflow.json"), workflow.ToJson());
    }
    return;
}

new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        WorkflowFactory.ConfigureServices(services);
        services.AddWorkflowProvider<NativeProbeWorkflows>();
    })
    .Build()
    .Run();

public sealed class NativeProbeWorkflows : IWorkflowProvider
{
    public FlowDefinition[] GetWorkflows() => [Native(), Condition(), ConditionTemplateControl(), EncodedJson(), JsonIntrinsic()];

    private static FlowDefinition Native()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 2).WithName("Count");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => count.Output + 1).WithName("Response");
        trigger.Then(count).Then(response);
        return WorkflowFactory.CreateStatelessWorkflow("NativeProbe", trigger);
    }

    private static FlowDefinition Condition()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => trigger.TriggerOutput.Body.Value<int>()).WithName("Count");
        var condition = WorkflowActions.BuiltIn.Control.Condition(expression: () => count.Output == 3,
            trueBranch: () => WorkflowActions.BuiltIn.Response(responseBody: () => "yes").WithName("Yes"),
            falseBranch: () => WorkflowActions.BuiltIn.Response(responseBody: () => "no").WithName("No")).WithName("Check");
        trigger.Then(count).Then(condition);
        return WorkflowFactory.CreateStatelessWorkflow("ConditionProbe", trigger);
    }

    private static FlowDefinition EncodedJson()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "A").WithName("Source");
        var encoded = NativeHostDestinations.EncodeJson(
            content: () => new { Next = count.Output + 1, Label = source.Output }).WithName("Encoded");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => encoded.Output).WithName("Response");
        trigger.Then(count).Then(source).Then(encoded).Then(response);
        return WorkflowFactory.CreateStatelessWorkflow("EncodedJsonProbe", trigger);
    }

    private static FlowDefinition ConditionTemplateControl()
    {
        var workflow = Condition();
        workflow.Name = "ConditionTemplateControl";
        // A separate positive control isolates host context loading; this is not an SDK fallback.
        workflow.Definition.Actions["Check"].Expression = new JValue("@equals(outputs('Count'), 3)");
        return workflow;
    }

    private static FlowDefinition JsonIntrinsic()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "{\"label\":\"a\"}").WithName("Source");
        var response = WorkflowActions.BuiltIn.Response(
            responseBody: () => WorkflowFunctions.ToJson<JObject>(source.Output.ToUpperInvariant())).WithName("Response");
        trigger.Then(source).Then(response);
        return WorkflowFactory.CreateStatelessWorkflow("JsonIntrinsicProbe", trigger);
    }
}

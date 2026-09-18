using Microsoft.Azure.Workflows.Sdk;
using Newtonsoft.Json.Linq;

if (args.Length != 1) throw new ArgumentException("Pass the isolated host output directory.");
var directory = Path.GetFullPath(args[0]);
var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
Write("TemplateProbe", WorkflowActions.BuiltIn.Response(responseBody: () => $"Received request: {trigger.TriggerOutput.Body}").WithName("Response"));
Write("LiteralProbe", WorkflowActions.BuiltIn.Response(responseBody: () => "@csharp{1 + 2}").WithName("Response"));

var count = WorkflowActions.BuiltIn.Compose<int>(input: () => 2).WithName("Count");
var native = WorkflowActions.BuiltIn.Response(responseBody: () => count.Output + 1).WithName("Response");
count.Then(native);
Write("NativeProbe", count, native);

var conditionCount = WorkflowActions.BuiltIn.Compose<int>(input: () => 3).WithName("Count");
var condition = WorkflowActions.BuiltIn.Control.Condition(expression: () => conditionCount.Output == 3,
    trueBranch: () => WorkflowActions.BuiltIn.Response(responseBody: () => "yes").WithName("Yes"),
    falseBranch: () => WorkflowActions.BuiltIn.Response(responseBody: () => "no").WithName("No")).WithName("Check");
conditionCount.Then(condition);
Write("ConditionProbe", conditionCount, condition);

void Write(string name, params IWorkflowAction[] actions)
{
    var actionDefinitions = new JObject();
    for (var index = 0; index < actions.Length; index++)
    {
        var definition = JObject.Parse(actions[index].GetActionDefinition(name).ToJson());
        var actionName = actions.Length == 1 ? "Response" : index == 0 ? "Count" : name == "ConditionProbe" ? "Check" : "Response";
        actionDefinitions[actionName] = definition;
    }
    var workflow = new JObject
    {
        ["definition"] = new JObject
        {
            ["$schema"] = "https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#",
            ["contentVersion"] = "1.0.0.0",
            ["triggers"] = new JObject { ["manual"] = JObject.Parse(trigger.GetTriggerDefinition().ToJson()) },
            ["actions"] = actionDefinitions,
            ["outputs"] = new JObject(),
        },
        ["kind"] = "Stateless",
    };
    var path = Path.Combine(directory, name);
    Directory.CreateDirectory(path);
    File.WriteAllText(Path.Combine(path, "workflow.json"), workflow.ToString());
}

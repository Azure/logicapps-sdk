using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.Tests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

IWorkflowProvider[] providers =
[
    new AgentWorkflow(), new AgenticWorkflow(), new AzureQueuesWorkflow(),
    new ComplexBranchWorkflow(), new ControlWorkflows(), new CustomCodeWorkflow(),
    new EmailWorkflow(), new HttpWorkflow(), new NestedWorkflow(),
    new NullableNodeWorkflow(), new ParallelBranchWorkflow(), new RecruitmentWorkflow(),
    new RecurrenceWorkflow(), new ServiceBusSendMessageWorkflow(), new ServiceBusWorkflow(),
    new ServiceNowWorkflow(), new StatelessWorkflow(), new VariablesWorkflow(),
    new WeatherWorkflow(),
];

var documents = new JObject();
var failures = new List<Exception>();
var definitionCount = 0;
foreach (var provider in providers)
{
    var name = provider.GetType().Name;
    try
    {
        var definitions = provider.GetWorkflows();
        if (definitions.Length == 0)
            throw new InvalidOperationException("No workflow definitions were produced.");
        var serialized = new JArray();
        foreach (var definition in definitions)
        {
            if (definition.Definition?.Actions?.Count is not > 0)
                throw new InvalidOperationException($"{definition.Name} has no actions.");
            var document = JObject.Parse(definition.ToJson());
            foreach (var messages in document.Descendants().OfType<JProperty>()
                .Where(property => property.Name.Equals("messages", StringComparison.OrdinalIgnoreCase)))
            {
                if (messages.Value is not JArray entries || entries.Any(entry => entry is not JObject))
                    throw new InvalidOperationException("Agent messages must serialize as structured objects, not native whole-object expressions.");
            }
            serialized.Add(document);
        }
        if (name is nameof(AgentWorkflow) or nameof(AgenticWorkflow) or nameof(RecruitmentWorkflow) &&
            !serialized.Descendants().OfType<JProperty>()
                .Any(property => property.Name.Equals("messages", StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("The Agent sample did not produce structured messages.");
        documents[name] = serialized;
        definitionCount += definitions.Length;
        Console.WriteLine($"{name}: {definitions.Length} definitions generated and serialized.");
    }
    catch (Exception error)
    {
        failures.Add(new InvalidOperationException($"{name}: {error.Message}", error));
    }
}

if (args.Length == 1)
    File.WriteAllText(args[0], documents.ToString(Formatting.Indented));
if (failures.Count != 0)
    throw new AggregateException("Existing workflow definition generation failed.", failures);
Console.WriteLine($"Existing workflow samples passed: {providers.Length} providers, {definitionCount} definitions.");

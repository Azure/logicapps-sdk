using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var suffix = "!";
var previous = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(() => new() { MessageId = "first", ContentData = "hello" });
var action = WorkflowActions.ServiceProviders.ServiceBus("serviceBus").SendMessage(
    entityName: () => "queue",
    message: () =>
    {
        var message = previous.Output;
        string Upper(string text) => text.ToUpperInvariant();
        message.MessageId = Upper(message.MessageId) + suffix;
        return message;
    });
suffix = "?";
previous.WithName("Prepare");
var source = JObject.FromObject(action.GetActionDefinition("flow").Inputs)["parameters"]["message"].Value<string>();
if (!source.Contains("outputs(\"Prepare\")") || !source.Contains("ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>") ||
    source.Contains("JsonTextReader") || source.Contains("workflowValue"))
    throw new InvalidOperationException("The packaged compiler did not preserve the native expression boundary.");
var fixture = new JObject
{
    ["code"] = source.Substring(2, source.Length - 3),
    ["context"] = JObject.Parse("""{"actions":{"Prepare":{"outputs":{"messageId":"first","contentData":"hello"}}}}"""),
    ["expected"] = JObject.FromObject(new SendMessageInputMessageType { MessageId = "FIRST!", ContentData = "hello" }, new JsonSerializer()),
};
if (args.Length > 0) File.WriteAllText(args[0], fixture.ToString());
Console.WriteLine(fixture);

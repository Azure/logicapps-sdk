using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
using Newtonsoft.Json.Linq;

var prefix = "message-";
var previous = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(
    () => new() { ContentData = "hello", MessageId = "first" });
var send = WorkflowActions.ServiceProviders.ServiceBus("serviceBus").SendMessage(
    entityName: () => "queue",
    message: () =>
    {
        var message = previous.Output;
        message.MessageId = prefix + message.MessageId;
        return message;
    });
prefix = "changed-";
previous.WithName("Prepare");

var definition = JObject.FromObject(send.GetActionDefinition("consumer").Inputs);
var source = definition["parameters"]["message"].Value<string>();
if (!source.StartsWith("#{") || !source.Contains("outputs(\"Prepare\")") ||
    !source.Contains("DecodeCapture") || source.Contains("changed-") ||
    !source.Contains("SendMessageInputMessageType"))
{
    throw new InvalidOperationException("The packaged compiler did not preserve the workflow expression contract.");
}

var expressions = new JObject
{
    ["code"] = source.Substring(2, source.Length - 3),
    ["context"] = JObject.Parse("""{"actions":{"Prepare":{"outputs":{"contentData":"hello","messageId":"first"}}}}"""),
    ["expectedMessageId"] = "message-first",
};
Console.WriteLine(expressions.ToString());
if (args.Length == 1) File.WriteAllText(args[0], expressions.ToString());

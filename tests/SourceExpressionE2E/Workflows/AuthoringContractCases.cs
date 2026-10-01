using Newtonsoft.Json.Linq;
using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

// These methods check real SDK definitions before returning a codeless proof workflow.
// They are NOT evidence that a managed connector or a rejected expression executed.
public static class AuthoringContractCases
{
    private static JToken Inputs(IWorkflowAction action) => JToken.Parse(action.GetActionDefinition("Contract").Inputs.ToJson());
    private static void Content(IWorkflowAction action, string expected)
        => Require((string?)Inputs(action)["body"]?["ContentData"] == expected, "AUTHORING-contract: unexpected Service Bus ContentData.");
    private static void NativeContent(IWorkflowAction action, params string[] fragments)
    {
        var text = (string?)Inputs(action)["body"]?["ContentData"] ?? "";
        Require(text.StartsWith("#{", StringComparison.Ordinal) && text.Contains("base64("),
            "AUTHORING-contract: native content must have one C# encoding envelope.");
        Require(text.IndexOf("#{", 1, StringComparison.Ordinal) < 0, "AUTHORING-contract: nested C# envelope.");
        foreach (var fragment in fragments) Require(text.Contains(fragment, StringComparison.Ordinal),
            "AUTHORING-contract: missing native content fragment: " + fragment);
    }

    [WorkflowCase("OutputGetterGuard", "authoring-contract passed", FailureIds = new[] { "F135" },
        Description = "AUTHORING-contract; direct SDK Output getter must throw before any runtime expression is evaluated.")]
    public static FlowDefinition OutputGetterGuard()
    {
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var guarded = false;
        try { _ = source.Output; }
        catch (InvalidOperationException) { guarded = true; }
        Require(guarded, "AUTHORING-contract: workflow Output getter must not return a runtime value.");
        return Proof("OutputGetterGuard");
    }

    [WorkflowCase("AgentCallbackGuard", "authoring-contract passed", FailureIds = new[] { "F017" }, Description = "AUTHORING-contract; Agent callback must be rejected without invocation.")]
    public static FlowDefinition AgentCallbackGuard()
    {
        RuntimeValues.Calls = 0;
        var rejected = false;
        try
        {
            WorkflowActions.BuiltIn.Agent(agentModelType: default, deploymentId: "test",
                agentModelSettings: null, connectionName: "test", messages: () => RuntimeValues.NextMessages()).GetActionDefinition("Contract");
        }
        catch (NotSupportedException) { rejected = true; }
        Require(RuntimeValues.Calls == 0, "Agent callback ran during generation.");
        Require(rejected, "AUTHORING-contract: Agent callback was not rejected.");
        return Proof("AgentCallbackGuard");
    }

    [WorkflowCase("ResponseCallbackGuard", "authoring-contract passed", FailureIds = new[] { "F026" }, Description = "AUTHORING-contract; status callback serialized, never invoked here.")]
    public static FlowDefinition ResponseCallbackGuard()
    {
        RuntimeValues.Calls = 0;
        var action = WorkflowActions.BuiltIn.Response(statusCode: () => RuntimeValues.NextStatus());
        var input = Inputs(action);
        Require(RuntimeValues.Calls == 0, "Response status callback ran during generation.");
        Require(((string?)input["statusCode"])?.StartsWith("#{", StringComparison.Ordinal) == true,
            "AUTHORING-contract: Response status callback was not retained as native source.");
        return Proof("ResponseCallbackGuard");
    }

    [WorkflowCase("HeadersCallbackGuard", "authoring-contract passed", FailureIds = new[] { "F079" }, Description = "AUTHORING-contract; headers callback rejected without invocation.")]
    public static FlowDefinition HeadersCallbackGuard()
    {
        RuntimeValues.Calls = 0;
        var rejected = false;
        try { WorkflowActions.BuiltIn.Response(headers: () => RuntimeValues.CreateHeaders()).GetActionDefinition("Contract"); }
        catch (NotSupportedException exception) { rejected = exception.Message.Contains("expression", StringComparison.OrdinalIgnoreCase); }
        Require(RuntimeValues.Calls == 0, "Headers callback ran during generation.");
        Require(rejected, "AUTHORING-contract: executable headers were not explicitly rejected.");
        return Proof("HeadersCallbackGuard");
    }

    [WorkflowCase("RequiredNameGuard", "authoring-contract passed", FailureIds = new[] { "F080" }, Description = "AUTHORING-contract; null variable name must report name.")]
    public static FlowDefinition RequiredNameGuard()
    {
        var rejected = false;
        try { WorkflowActions.BuiltIn.Variables.InitializeVariable<string>(name: () => (string)null!, value: () => "value").GetActionDefinition("Contract"); }
        catch (ArgumentException exception) { rejected = exception.ParamName == "name"; }
        Require(rejected, "AUTHORING-contract: missing required-name guard.");
        return Proof("RequiredNameGuard");
    }

    [WorkflowCase("ConflictingEnumAliasGuard", "authoring-contract passed", FailureIds = new[] { "F062" }, Description = "AUTHORING-contract; conflicting wire aliases are rejected.")]
    public static FlowDefinition ConflictingEnumAliasGuard()
    {
        var rejected = false;
        try { WorkflowActions.BuiltIn.Compose<AliasChoice>(() => AliasChoice.A).GetActionDefinition("Contract"); }
        catch (NotSupportedException exception) { rejected = exception.Message.Contains("conflict", StringComparison.OrdinalIgnoreCase); }
        Require(rejected, "AUTHORING-contract: conflicting enum aliases silently accepted.");
        return Proof("ConflictingEnumAliasGuard");
    }

    [WorkflowCase("HttpDestinationNormalization", "authoring-contract passed", FailureIds = new[] { "F116" }, Description = "AUTHORING-contract; does not send an HTTP request to example.com.")]
    public static FlowDefinition HttpDestinationNormalization()
    {
        var uri = new Uri("https://example.com/api");
        var action = WorkflowActions.BuiltIn.HttpAction(uri: () => uri, method: () => System.Net.Http.HttpMethod.Get);
        var input = Inputs(action);
        Require((string?)input["uri"] == "https://example.com/api" && (string?)input["method"] == "GET",
            "AUTHORING-contract: URI/HttpMethod destinations were not normalized.");
        return Proof("HttpDestinationNormalization");
    }

    [WorkflowCase("ManagedTriggerBodyContract", "authoring-contract passed", FailureIds = new[] { "F075" }, Description = "AUTHORING-contract; managed Azure Queue trigger is not connected or polled.")]
    public static FlowDefinition ManagedTriggerBodyContract()
    {
        var managedTrigger = WorkflowTriggers.Managed.Azurequeues("connection")
            .OnMessagesV2(storageAccountName: () => "account", queueName: () => "queue");
        var action = WorkflowActions.BuiltIn.Compose<object>(() => managedTrigger.TriggerBody);
        Require((string?)Inputs(action) == "#{triggerBody()}",
            "AUTHORING-contract: managed trigger body is not a JSON-native C# reference.");
        return Proof("ManagedTriggerBodyContract");
    }

    [WorkflowCase("ConnectorFormattedPath", "authoring-contract passed", FailureIds = new[] { "F022" }, Description = "AUTHORING-contract; no Service Bus request.")]
    public static FlowDefinition ConnectorFormattedPath()
    {
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var action = new ServicebusActions("connection").CloseSessionInQueue(queueName: () => "queue", sessionId: () => $"{count.Output:D4}");
        var path = (string?)Inputs(action)["path"] ?? "";
        Require(path.StartsWith("#{", StringComparison.Ordinal) && path.Contains(":D4"), "AUTHORING-contract: connector format D4 was lost.");
        return Proof("ConnectorFormattedPath");
    }

    [WorkflowCase("ConnectorNativePath", "authoring-contract passed", FailureIds = new[] { "F061" }, Description = "AUTHORING-contract; verifies native encoding placement, no Service Bus request.")]
    public static FlowDefinition ConnectorNativePath()
    {
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "a /").WithName("Source");
        var action = new ServicebusActions("connection").CloseSessionInQueue(queueName: () => "queue", sessionId: () => source.Output.ToUpperInvariant());
        var path = (string?)Inputs(action)["path"] ?? "";
        Require(path.StartsWith("#{", StringComparison.Ordinal) && path.Contains("encodeURIComponent(outputs(\"Source\").ToObject<string>().ToUpperInvariant())"),
            "AUTHORING-contract: native path argument is not encoded once after typed conversion.");
        return Proof("ConnectorNativePath");
    }

    [WorkflowCase("OptionalNullContent", "authoring-contract passed", FailureIds = new[] { "F041" }, Description = "AUTHORING-contract; optional connector field, not invalid null Compose.")]
    public static FlowDefinition OptionalNullContent()
    {
        var action = new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => (string)null!);
        Require(Inputs(action)["body"]?["ContentData"]?.Type == JTokenType.Null, "AUTHORING-contract: optional content must remain JSON null.");
        return Proof("OptionalNullContent");
    }

    [WorkflowCase("EncodingLiteral", "authoring-contract passed", FailureIds = new[] { "F042" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingLiteral()
    {
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => "hello"), "#{base64(\"hello\")}");
        return Proof("EncodingLiteral");
    }

    [WorkflowCase("EncodingReference", "authoring-contract passed", FailureIds = new[] { "F043" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingReference()
    {
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => source.Output), "#{base64(outputs(\"Source\").ToObject<string>())}");
        return Proof("EncodingReference");
    }

    [WorkflowCase("EncodingTriggerPath", "authoring-contract passed", FailureIds = new[] { "F044" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingTriggerPath()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => trigger.TriggerOutput.Body["content"]), "#{base64(triggerBody()[\"content\"])}");
        return Proof("EncodingTriggerPath");
    }

    [WorkflowCase("EncodingInterpolation", "authoring-contract passed", FailureIds = new[] { "F045", "F053" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingInterpolation()
    {
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => $"Name: {source.Output}"), "#{base64($\"Name: {outputs(\"Source\").ToObject<string>()}\")}");
        return Proof("EncodingInterpolation");
    }

    [WorkflowCase("EncodingInteger", "authoring-contract passed", FailureIds = new[] { "F046" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingInteger()
    {
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => 42), "#{base64(\"42\")}");
        return Proof("EncodingInteger");
    }

    [WorkflowCase("EncodingBoolean", "authoring-contract passed", FailureIds = new[] { "F047" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingBoolean()
    {
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => true), "#{base64(\"true\")}");
        return Proof("EncodingBoolean");
    }

    [WorkflowCase("EncodingJValue", "authoring-contract passed", FailureIds = new[] { "F048" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingJValue()
    {
        JToken token = new JValue("hello");
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => token), "#{base64(\"hello\")}");
        return Proof("EncodingJValue");
    }

    [WorkflowCase("EncodingJObject", "authoring-contract passed", FailureIds = new[] { "F049" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingJObject()
    {
        JToken token = JObject.Parse("{\"n\":1}");
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => token), "#{base64(\"{\\\"n\\\":1}\")}");
        return Proof("EncodingJObject");
    }

    [WorkflowCase("EncodingEmpty", "authoring-contract passed", FailureIds = new[] { "F050" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingEmpty()
    {
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => ""), "#{base64(\"\")}");
        return Proof("EncodingEmpty");
    }

    [WorkflowCase("EncodingUnicode", "authoring-contract passed", FailureIds = new[] { "F051" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingUnicode()
    {
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => "\u00e9"), "#{base64(\"é\")}");
        return Proof("EncodingUnicode");
    }

    [WorkflowCase("EncodingAlreadyEncoded", "authoring-contract passed", FailureIds = new[] { "F052" }, Description = "AUTHORING-contract; generated Service Bus base64 destination.")]
    public static FlowDefinition EncodingAlreadyEncoded()
    {
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => "aGVsbG8="), "#{base64(\"aGVsbG8=\")}");
        return Proof("EncodingAlreadyEncoded");
    }

    [WorkflowCase("EncodingNativeUpper", "authoring-contract passed", FailureIds = new[] { "F054", "F058" }, Description = "AUTHORING-contract; does not execute emitted native source.")]
    public static FlowDefinition EncodingNativeUpper()
    {
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        NativeContent(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => source.Output.ToUpperInvariant()),
            "outputs(\"Source\").ToObject<string>().ToUpperInvariant()");
        return Proof("EncodingNativeUpper");
    }

    [WorkflowCase("EncodingNativeInteger", "authoring-contract passed", FailureIds = new[] { "F055" }, Description = "AUTHORING-contract; does not execute emitted native source.")]
    public static FlowDefinition EncodingNativeInteger()
    {
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        NativeContent(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => (count.Output + 1).ToString()),
            "ToObject<int>()", "+ 1", ".ToString()");
        return Proof("EncodingNativeInteger");
    }

    [WorkflowCase("EncodingNativeInterpolation", "authoring-contract passed", FailureIds = new[] { "F056" }, Description = "AUTHORING-contract; does not execute emitted native source.")]
    public static FlowDefinition EncodingNativeInterpolation()
    {
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        NativeContent(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => $"Next: {count.Output + 1}"),
            "ToObject<int>()", "Next:", "+ 1");
        return Proof("EncodingNativeInterpolation");
    }

    [WorkflowCase("EncodingNativeDecimal", "authoring-contract passed", FailureIds = new[] { "F057" }, Description = "AUTHORING-contract; does not execute emitted native source.")]
    public static FlowDefinition EncodingNativeDecimal()
    {
        var amount = WorkflowActions.BuiltIn.Compose<decimal>(() => 2.5m).WithName("Amount");
        NativeContent(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => amount.Output + 1m),
            "ToObject<decimal>()", "InvariantCulture");
        return Proof("EncodingNativeDecimal");
    }

    [WorkflowCase("EncodingBinary", "authoring-contract passed", FailureIds = new[] { "F059" }, Description = "AUTHORING-contract; captured bytes, not array JSON.")]
    public static FlowDefinition EncodingBinary()
    {
        byte[] bytes = { 0, 1, 255 };
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => bytes), "AAH/");
        return Proof("EncodingBinary");
    }

    [WorkflowCase("EncodingZeroBytes", "authoring-contract passed", FailureIds = new[] { "F060" }, Description = "AUTHORING-contract; captured zero bytes, not an empty string.")]
    public static FlowDefinition EncodingZeroBytes()
    {
        byte[] bytes = { 0, 0 };
        Content(new ServicebusActions("connection").SendMessage(entityName: () => "queue", messagecontent: () => bytes), "AAA=");
        return Proof("EncodingZeroBytes");
    }
}

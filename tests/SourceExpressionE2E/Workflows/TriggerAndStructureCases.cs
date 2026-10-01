using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class TriggerAndStructureCases
{
    [WorkflowCase("TriggerValueInt", "5", FailureIds = new[] { "F034", "F165" }, InputJson = "{\"value\":3}")]
    public static FlowDefinition TriggerValueInt()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["value"].Value<int>() + 2);
        return Finish("TriggerValueInt", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerToObjectInt", "5", FailureIds = new[] { "F035" }, InputJson = "{\"value\":3}")]
    public static FlowDefinition TriggerToObjectInt()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["value"].ToObject<int>() + 2);
        return Finish("TriggerToObjectInt", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerUppercase", "ALICE", FailureIds = new[] { "F036" }, InputJson = "{\"name\":\"alice\"}")]
    public static FlowDefinition TriggerUppercase()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["name"].Value<string>().ToUpperInvariant());
        return Finish("TriggerUppercase", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerBoundaryTen", "true", FailureIds = new[] { "F037" }, InputJson = "{\"count\":10}")]
    public static FlowDefinition TriggerBoundaryTen()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["count"].Value<int>() >= 10);
        return Finish("TriggerBoundaryTen", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerBoundaryNine", "false", FailureIds = new[] { "F038" }, InputJson = "{\"count\":9}")]
    public static FlowDefinition TriggerBoundaryNine()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["count"].Value<int>() >= 10);
        return Finish("TriggerBoundaryNine", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerNullableValue", "{\"value\":null}", FailureIds = new[] { "F039" }, InputJson = "{\"value\":null}")]
    public static FlowDefinition TriggerNullableValue()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { value = trigger.TriggerOutput.Body["value"].Value<int?>() });
        return Finish("TriggerNullableValue", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("MissingToObject", "", FailureIds = new[] { "F040" }, ExpectedRunStatus = "Failed",
        ExpectedHttpStatus = 502, ExpectedActionError = "Object reference not set to an instance of an object.")]
    public static FlowDefinition MissingToObject()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["value"].ToObject<int>());
        return Finish("MissingToObject", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("InvalidValueConversion", "", FailureIds = new[] { "F158" }, ExpectedRunStatus = "Failed", InputJson = "{\"value\":\"abc\"}",
        ExpectedHttpStatus = 502, ExpectedActionError = "The input string 'abc' was not in a correct format.")]
    public static FlowDefinition InvalidValueConversion()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["value"].Value<int>());
        return Finish("InvalidValueConversion", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("NestedStructuralPayload", "{\"nested\":{\"body\":{\"n\":1}},\"labels\":[\"a\",\"b\"]}",
        FailureIds = new[] { "F082" }, InputJson = "{\"n\":1}")]
    public static FlowDefinition NestedStructuralPayload()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { nested = new { body = trigger.TriggerOutput.Body }, labels = new[] { "a", "b" } });
        return Finish("NestedStructuralPayload", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerBodyDirect", "{\"name\":\"alice\",\"customer\":{\"name\":\"bob\"}}", FailureIds = new[] { "F144" },
        InputJson = "{\"name\":\"alice\",\"customer\":{\"name\":\"bob\"}}")]
    public static FlowDefinition TriggerBodyDirect()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body);
        return Finish("TriggerBodyDirect", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"));
    }

    [WorkflowCase("TriggerPaths", "{\"name\":\"alice\",\"customer\":\"bob\",\"formatted\":\"Name: alice\"}", FailureIds = new[] { "F146", "F147", "F150" },
        InputJson = "{\"name\":\"alice\",\"customer\":{\"name\":\"bob\"}}")]
    public static FlowDefinition TriggerPaths()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var name = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["name"]).WithName("Name");
        var customer = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput.Body["customer"]["name"]).WithName("Customer");
        var formatted = WorkflowActions.BuiltIn.Compose<object>(() => $"Name: {trigger.TriggerOutput.Body["name"]}").WithName("Formatted");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { name = name.Output, customer = customer.Output, formatted = formatted.Output });
        return Finish("TriggerPaths", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), name, customer, formatted);
    }

    [WorkflowCase("TriggerInterpolation", "{\"hello\":\"hello{}\",\"request\":\"Received request: {}\",\"received\":\"Received: {}\",\"format\":\"Received: {}\"}",
        FailureIds = new[] { "F142", "F148", "F152", "F168" })]
    public static FlowDefinition TriggerInterpolation()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var hello = WorkflowActions.BuiltIn.Compose<object>(() => $"hello{trigger.TriggerOutput.Body}").WithName("Hello");
        var request = WorkflowActions.BuiltIn.Compose<object>(() => $"Received request: {trigger.TriggerOutput.Body}").WithName("Request");
        var received = WorkflowActions.BuiltIn.Compose<object>(() => $"Received: {trigger.TriggerOutput.Body}").WithName("Received");
        var format = WorkflowActions.BuiltIn.Compose<object>(() => string.Format("Received: {0}", trigger.TriggerOutput.Body)).WithName("Format");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { hello = hello.Output, request = request.Output, received = received.Output, format = format.Output });
        return Finish("TriggerInterpolation", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), hello, request, received, format);
    }

    [WorkflowCase("TriggerOutputEnvelope", "{\"n\":1}", FailureIds = new[] { "F143" }, InputJson = "{\"n\":1}",
        Description = "Return the body after preserving the full trigger-output expression in its own action; request headers are nondeterministic.")]
    public static FlowDefinition TriggerOutputEnvelope()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var envelope = WorkflowActions.BuiltIn.Compose<object>(() => trigger.TriggerOutput).WithName("Envelope");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => ((JObject)envelope.Output)["body"]);
        return Finish("TriggerOutputEnvelope", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), envelope);
    }

    [WorkflowCase("JsonDeepEquality", "true", FailureIds = new[] { "F096" }, InputJson = "{\"n\":1}")]
    public static FlowDefinition JsonDeepEquality()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var tokenSource = WorkflowActions.BuiltIn.Compose<JToken>(() => trigger.TriggerOutput.Body).WithName("TokenSource");
        var tokenOther = WorkflowActions.BuiltIn.Compose<JToken>(() => trigger.TriggerOutput.Body).WithName("TokenOther");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => JToken.DeepEquals(tokenSource.Output, tokenOther.Output));
        return Finish("JsonDeepEquality", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), tokenSource, tokenOther);
    }

    [WorkflowCase("ObjectTypeString", "true", FailureIds = new[] { "F134" })]
    public static FlowDefinition ObjectTypeString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var raw = WorkflowActions.BuiltIn.Compose<object>(() => "text").WithName("Raw");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => raw.Output is string);
        return Finish("ObjectTypeString", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), raw);
    }

    [WorkflowCase("ObjectTypeInteger", "false", FailureIds = new[] { "F134" })]
    public static FlowDefinition ObjectTypeInteger()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var raw = WorkflowActions.BuiltIn.Compose<object>(() => 3).WithName("Raw");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => raw.Output is string);
        return Finish("ObjectTypeInteger", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), raw);
    }

    [WorkflowCase("NativeUri", "https://example.com/api", FailureIds = new[] { "F138" },
        Description = "Known end-to-end failure: URI construction succeeds, but the scalar URI Response body is unsupported. The original success expectation is retained; no normalization or ToString fallback is applied.")]
    public static FlowDefinition NativeUri()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "https://example.com/api").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new Uri(source.Output));
        return Finish("NativeUri", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("UtcClock", "", FailureIds = new[] { "F139" }, ResponseContract = "UtcTimestamp",
        Description = "Original DateTime.UtcNow value is returned directly; each run checks UTC/window validity, never paired timestamp equality.")]
    public static FlowDefinition UtcClock()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var now = WorkflowActions.BuiltIn.Compose<object>(() => DateTime.UtcNow).WithName("Now");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => now.Output).WithName("Response");
        trigger.Then(now).Then(response);
        return WorkflowFactory.CreateStatefulWorkflow("UtcClock", trigger);
    }

    [WorkflowCase("RenamedReferenceEquality", "false", FailureIds = new[] { "F195" })]
    public static FlowDefinition RenamedReferenceEquality()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "hello").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => object.ReferenceEquals(source.Output, null));
        source.WithName("Renamed");
        return Finish("RenamedReferenceEquality", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }
}

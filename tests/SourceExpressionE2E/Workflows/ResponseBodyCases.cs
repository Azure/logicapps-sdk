using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class ResponseBodyCases
{
    [WorkflowCase("NativeUriFallbackResponse", "recovered",
        ResponseContract = "HandledResponseFailure",
        ExpectedFailedAction = "InvalidResponse",
        ExpectedActionErrorCode = "InvalidResponseBody",
        ExpectedActionError = "The response body contains a value that can't be converted to supported response content. Update the response body to use a supported value.")]
    public static FlowDefinition FallbackResponse()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "https://example.com/api").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new Uri(source.Output)).WithName("Result");
        var invalid = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("InvalidResponse");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => "recovered").WithName("Response");
        trigger.Then(source).Then(result).Then(invalid).Then(response, runAfter: new[] { FlowStatus.Failed });
        return WorkflowFactory.CreateStatefulWorkflow("NativeUriFallbackResponse", trigger);
    }

    [WorkflowCase("NativeUriExplicitString", "https://example.com/api")]
    public static FlowDefinition ExplicitString()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "https://example.com/api").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new Uri(source.Output)).WithName("Result");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output.ToString()).WithName("Response");
        return Finish("NativeUriExplicitString", trigger, result, response, source);
    }

    [WorkflowCase("NativeUriStringToken", "https://example.com/api")]
    public static FlowDefinition StringToken()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "https://example.com/api").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new Uri(source.Output)).WithName("Result");
        var response = WorkflowActions.BuiltIn.Response(
            responseBody: () => JToken.FromObject(result.Output.ToString())).WithName("Response");
        return Finish("NativeUriStringToken", trigger, result, response, source);
    }

    [WorkflowCase("NativeUriObjectBody", """{"uri":"https://example.com/api"}""")]
    public static FlowDefinition ObjectBody()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "https://example.com/api").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new Uri(source.Output)).WithName("Result");
        var response = WorkflowActions.BuiltIn.Response(
            responseBody: () => new JObject { ["uri"] = JToken.FromObject(result.Output) }).WithName("Response");
        return Finish("NativeUriObjectBody", trigger, result, response, source);
    }

    [WorkflowCase("NativeUriArrayBody", """["https://example.com/api"]""")]
    public static FlowDefinition ArrayBody()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "https://example.com/api").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new Uri(source.Output)).WithName("Result");
        var response = WorkflowActions.BuiltIn.Response(
            responseBody: () => new JArray(JToken.FromObject(result.Output))).WithName("Response");
        return Finish("NativeUriArrayBody", trigger, result, response, source);
    }
}

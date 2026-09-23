using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class NestedJsonComposeCases
{
    private const string OrderJson = """{"order":"1001","items":[{"item":"abc","quantity":10},{"item":"def","quantity":5}]}""";
    private const string Expected = """{"payload":{"order":"1001","items":[{"item":"abc","quantity":10},{"item":"def","quantity":5}]},"order":"1001","firstItem":"abc","firstQuantity":10,"secondItem":"def","secondQuantity":5,"indexedItem":"def","total":15}""";

    [WorkflowCase("NestedJsonCapturedJObject", Expected)]
    public static FlowDefinition CapturedJObject()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var snapshot = JObject.Parse(OrderJson);
        var payload = WorkflowActions.BuiltIn.Compose<JObject>(() => snapshot).WithName("Payload");
        snapshot["order"] = "changed";
        snapshot["items"][0]["quantity"] = 999;
        var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
        var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
        return FinishOrder("NestedJsonCapturedJObject", trigger, payload, forwarded, order);
    }

    [WorkflowCase("NestedJsonCapturedJToken", Expected)]
    public static FlowDefinition CapturedJToken()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        JToken snapshot = JToken.Parse(OrderJson);
        var payload = WorkflowActions.BuiltIn.Compose<JToken>(() => snapshot).WithName("Payload");
        snapshot["order"] = "changed";
        snapshot["items"][0]["quantity"] = 999;
        var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
        var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
        return FinishOrder("NestedJsonCapturedJToken", trigger, payload, forwarded, order);
    }

    [WorkflowCase("NestedJsonInlineParseJObject", Expected)]
    public static FlowDefinition InlineParseJObject()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var payload = WorkflowActions.BuiltIn.Compose<JObject>(() =>
            JObject.Parse("""{"order":"1001","items":[{"item":"abc","quantity":10},{"item":"def","quantity":5}]}""")).WithName("Payload");
        var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
        var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
        return FinishOrder("NestedJsonInlineParseJObject", trigger, payload, forwarded, order);
    }

    [WorkflowCase("NestedJsonInlineParseJToken", Expected)]
    public static FlowDefinition InlineParseJToken()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var payload = WorkflowActions.BuiltIn.Compose<JToken>(() =>
            JToken.Parse("""{"order":"1001","items":[{"item":"abc","quantity":10},{"item":"def","quantity":5}]}""")).WithName("Payload");
        var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
        var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
        return FinishOrder("NestedJsonInlineParseJToken", trigger, payload, forwarded, order);
    }

    [WorkflowCase("NestedJsonInlineInitializerJObject", Expected)]
    public static FlowDefinition InlineInitializerJObject()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var payload = WorkflowActions.BuiltIn.Compose<JObject>(() => new JObject
        {
            ["order"] = "1001",
            ["items"] = new JArray(
                new JObject { ["item"] = "abc", ["quantity"] = 10 },
                new JObject { ["item"] = "def", ["quantity"] = 5 })
        }).WithName("Payload");
        var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
        var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
        return FinishOrder("NestedJsonInlineInitializerJObject", trigger, payload, forwarded, order);
    }

    [WorkflowCase("NestedJsonInlineInitializerJToken", Expected)]
    public static FlowDefinition InlineInitializerJToken()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var payload = WorkflowActions.BuiltIn.Compose<JToken>(() => new JObject
        {
            ["order"] = "1001",
            ["items"] = new JArray(
                new JObject { ["item"] = "abc", ["quantity"] = 10 },
                new JObject { ["item"] = "def", ["quantity"] = 5 })
        }).WithName("Payload");
        var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
        var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
        return FinishOrder("NestedJsonInlineInitializerJToken", trigger, payload, forwarded, order);
    }

    private static FlowDefinition FinishOrder(string name, IWorkflowTrigger trigger, IWorkflowAction payload,
        IOutputWorkflowAction<JToken> forwarded, IOutputWorkflowAction<JToken> order)
    {
        var items = WorkflowActions.BuiltIn.Compose<JToken>(() => forwarded.Output["items"]).WithName("Items");
        var second = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[1]).WithName("Second");
        var firstItem = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[0]["item"]).WithName("FirstItem");
        var firstQuantity = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[0]["quantity"]).WithName("FirstQuantity");
        var index = WorkflowActions.BuiltIn.Compose<int>(() => 1).WithName("Index");
        var indexed = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[index.Output]["item"]).WithName("Indexed");
        var total = WorkflowActions.BuiltIn.Compose<int>(() =>
            items.Output[0]["quantity"].Value<int>() + second.Output["quantity"].Value<int>()).WithName("Total");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new
        {
            payload = forwarded.Output, order = order.Output,
            firstItem = firstItem.Output, firstQuantity = firstQuantity.Output,
            secondItem = second.Output["item"], secondQuantity = second.Output["quantity"],
            indexedItem = indexed.Output, total = total.Output
        }).WithName("Result");
        var response = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response");
        return Finish(name, trigger, result, response, payload, forwarded, order, items, second, firstItem, firstQuantity, index, indexed, total);
    }
}

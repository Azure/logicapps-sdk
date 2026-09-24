namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Build;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class NestedJsonComposeTests
{
    private const string OrderJson = """{"order":"1001","items":[{"item":"abc","quantity":10},{"item":"def","quantity":5}]}""";
    private const string Initializer = """
        new JObject
        {
            ["order"] = "1001",
            ["items"] = new JArray(
                new JObject { ["item"] = "abc", ["quantity"] = 10 },
                new JObject { ["item"] = "def", ["quantity"] = 5 })
        }
        """;

    [Theory]
    [InlineData("JObject", "Captured")]
    [InlineData("JToken", "Captured")]
    [InlineData("JObject", "InlineParse")]
    [InlineData("JToken", "InlineParse")]
    [InlineData("JObject", "InlineInitializer")]
    [InlineData("JToken", "InlineInitializer")]
    public void Nested_order_preserves_json_types_and_downstream_accessors(string type, string construction)
    {
        var parse = $"{type}.Parse({JsonConvert.SerializeObject(OrderJson)})";
        var setup = construction == "Captured" ? $"{type} snapshot = {parse};" : "";
        var input = construction switch
        {
            "Captured" => "snapshot",
            "InlineParse" => parse,
            "InlineInitializer" => Initializer,
            _ => throw new ArgumentOutOfRangeException(nameof(construction)),
        };
        var mutate = construction == "Captured"
            ? """snapshot["order"] = "changed"; snapshot["items"][0]["quantity"] = 999;"""
            : "";
        var source = Source($$"""
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
            {{setup}}
            var payload = WorkflowActions.BuiltIn.Compose<{{type}}>(() => {{input}}).WithName("Payload");
            {{mutate}}
            var forwarded = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output).WithName("Forwarded");
            var order = WorkflowActions.BuiltIn.Compose<JToken>(() => payload.Output["order"]).WithName("Order");
            var items = WorkflowActions.BuiltIn.Compose<JToken>(() => forwarded.Output["items"]).WithName("Items");
            var second = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[1]).WithName("Second");
            var firstItem = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[0]["item"]).WithName("FirstItem");
            var firstQuantity = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[0]["quantity"]).WithName("FirstQuantity");
            var index = WorkflowActions.BuiltIn.Compose<int>(() => 1).WithName("Index");
            var indexed = WorkflowActions.BuiltIn.Compose<JToken>(() => items.Output[index.Output]["item"]).WithName("Indexed");
            var total = WorkflowActions.BuiltIn.Compose<int>(() => items.Output[0]["quantity"].Value<int>() + second.Output["quantity"].Value<int>()).WithName("Total");
            var result = WorkflowActions.BuiltIn.Compose<object>(() => new
            {
                payload = forwarded.Output, order = order.Output,
                firstItem = firstItem.Output, firstQuantity = firstQuantity.Output,
                secondItem = second.Output["item"], secondQuantity = second.Output["quantity"],
                indexedItem = indexed.Output, total = total.Output
            }).WithName("Result");
            var response = WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response");
            trigger.Then(payload).Then(forwarded).Then(order).Then(items).Then(second).Then(firstItem).Then(firstQuantity).Then(index).Then(indexed).Then(total).Then(result).Then(response);
            return new FlowTemplateAction { Inputs = JObject.Parse(WorkflowFactory.CreateStatefulWorkflow("Order", trigger).ToJson()) };
            """);
        var built = Build(source);
        var workflow = Token(built.Definition);
        Assert.Equal("Stateful", workflow["kind"]!.Value<string>());
        var actions = Assert.IsType<JObject>(workflow["definition"]!["actions"]);
        var inputToken = actions["Payload"]!["inputs"]!;
        JToken payload;
        if (construction == "Captured")
        {
            payload = Assert.IsType<JObject>(inputToken);
        }
        else
        {
            var runtime = LocalNativeHost.Evaluate(inputToken.Value<string>()!, new());
            Assert.Empty(runtime.Reads);
            payload = Assert.IsType<JObject>(runtime.Value);
        }
        payload = JToken.Parse(payload.ToString(Formatting.None));
        Assert.True(JToken.DeepEquals(JObject.Parse(OrderJson), payload));
        Assert.Equal(JTokenType.String, payload["order"]!.Type);
        Assert.Equal(JTokenType.Array, payload["items"]!.Type);
        Assert.Equal(2, payload["items"]!.Count());
        Assert.Equal(JTokenType.Integer, payload["items"]![0]!["quantity"]!.Type);
        Assert.Equal(JTokenType.Integer, payload["items"]![1]!["quantity"]!.Type);

        Assert.Equal("#{outputs(\"Payload\")}", actions["Forwarded"]!["inputs"]!.Value<string>());
        Assert.Equal("#{outputs(\"Payload\")[\"order\"]}", actions["Order"]!["inputs"]!.Value<string>());
        Assert.Equal("#{outputs(\"Forwarded\")[\"items\"]}", actions["Items"]!["inputs"]!.Value<string>());
        EqualSource("#{outputs(\"Items\")[1]}", actions["Second"]!["inputs"]!.Value<string>()!);
        Assert.Equal(1, actions["Index"]!["inputs"]!.Value<int>());
        var projection = actions["Result"]!["inputs"]!;
        var expectedProjection = JObject.Parse("""
            {
                "payload":"#{outputs(\"Forwarded\")}","order":"#{outputs(\"Order\")}",
                "firstItem":"#{outputs(\"FirstItem\")}","firstQuantity":"#{outputs(\"FirstQuantity\")}",
                "secondItem":"#{outputs(\"Second\")[\"item\"]}","secondQuantity":"#{outputs(\"Second\")[\"quantity\"]}",
                "indexedItem":"#{outputs(\"Indexed\")}","total":"#{outputs(\"Total\")}"
            }
            """);
        Assert.Equal(8, Assert.IsType<JObject>(projection).Count);
        foreach (var property in expectedProjection.Properties())
            Assert.True(JToken.DeepEquals(property.Value, projection[property.Name]), property.Name);
        EqualSource("#{outputs(\"Items\")[0][\"item\"]}", actions["FirstItem"]!["inputs"]!.Value<string>()!);
        EqualSource("#{outputs(\"Items\")[0][\"quantity\"]}", actions["FirstQuantity"]!["inputs"]!.Value<string>()!);
        Assert.Equal("#{outputs(\"Result\")}", actions["Response"]!["inputs"]!["body"]!.Value<string>());

        var values = new Dictionary<string, JToken?>
        {
            ["Items"] = payload["items"], ["Index"] = new JValue(1),
        };
        var second = LocalNativeHost.Evaluate(actions["Second"]!["inputs"]!.Value<string>()!, values);
        Assert.Equal(["Items"], second.Reads);
        values["Second"] = JToken.Parse(JsonConvert.SerializeObject(Assert.IsType<JObject>(second.Value)));
        Assert.True(JToken.DeepEquals(JObject.Parse("""{"item":"def","quantity":5}"""), values["Second"]));
        var firstItem = LocalNativeHost.Evaluate(actions["FirstItem"]!["inputs"]!.Value<string>()!, values);
        Assert.Equal("abc", Assert.IsType<JValue>(firstItem.Value).Value<string>());
        var firstQuantity = LocalNativeHost.Evaluate(actions["FirstQuantity"]!["inputs"]!.Value<string>()!, values);
        Assert.Equal(JTokenType.Integer, Assert.IsType<JValue>(firstQuantity.Value).Type);
        Assert.Equal(10, ((JValue)firstQuantity.Value!).Value<int>());
        var indexed = LocalNativeHost.Evaluate(actions["Indexed"]!["inputs"]!.Value<string>()!, values);
        Assert.Equal("def", Assert.IsAssignableFrom<JToken>(indexed.Value).Value<string>());
        Assert.Equal(["Items", "Index"], indexed.Reads);
        values["Index"] = new JValue(0);
        Assert.Equal("abc", Assert.IsAssignableFrom<JToken>(
            LocalNativeHost.Evaluate(actions["Indexed"]!["inputs"]!.Value<string>()!, values).Value).Value<string>());
        var total = LocalNativeHost.Evaluate(actions["Total"]!["inputs"]!.Value<string>()!, values);
        Assert.Equal(15, Assert.IsType<int>(total.Value));
        Assert.Equal(["Items", "Second"], total.Reads);
        values["Items"] = JArray.Parse("""[{"item":"other","quantity":7},{"item":"last","quantity":2}]""");
        values["Second"] = values["Items"]![1];
        Assert.Equal(9, Assert.IsType<int>(
            LocalNativeHost.Evaluate(actions["Total"]!["inputs"]!.Value<string>()!, values).Value));
    }
}

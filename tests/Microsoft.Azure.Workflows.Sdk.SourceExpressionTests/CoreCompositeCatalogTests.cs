namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CoreCompositeCatalogTests
{
    [Fact, Trait("Catalog", "X01")]
    public void Composite_arithmetic_preserves_precedence_and_integer_division()
    {
        var emitted = Native("(count.Output + 2) * 3 - quantity.Output / 2");
        EqualSource("@csharp{(outputs(\"Count\").ToObject<int>() + 2) * 3 - outputs(\"Quantity\").ToObject<int>() / 2}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(4), ["Quantity"] = new JValue(5) });
        Assert.Equal(16, Assert.IsType<int>(local.Value));
        Assert.Equal(["Count", "Quantity"], local.Reads);
    }

    [Fact, Trait("Catalog", "X02")]
    public void Native_null_guard_preserves_short_circuiting()
    {
        var emitted = Native("source.Output != null && source.Output.StartsWith(\"A\")");
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>() != null && outputs(\"Source\").ToObject<string>().StartsWith(\"A\")}", emitted);
        var missing = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = JValue.CreateNull() });
        Assert.Equal(false, missing.Value);
        Assert.Equal(["Source"], missing.Reads);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("Alice") }).Value);
        Assert.Equal(false, LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("Bob") }).Value);
    }

    [Fact, Trait("Catalog", "X04")]
    public void Two_typed_bodies_keep_decimal_boundary_results()
    {
        var emitted = Native("first.Body.Total + second.Body.Total >= 1000m", """
            var first = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(_ => Task.FromResult<OrderSummary>(null)).WithName("First");
            var second = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(_ => Task.FromResult<OrderSummary>(null)).WithName("Second");
            """);
        EqualSource("@csharp{body(\"First\").ToObject<OrderSummary>().Total + body(\"Second\").ToObject<OrderSummary>().Total >= 1000m}", emitted);
        Assert.Equal(false, LocalNativeHost.Evaluate(emitted, new()
        {
            ["First"] = JObject.Parse("""{"Total":500}"""), ["Second"] = JObject.Parse("""{"Total":499.99}"""),
        }).Value);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new()
        {
            ["First"] = JObject.Parse("""{"Total":500}"""), ["Second"] = JObject.Parse("""{"Total":500}"""),
        }).Value);
    }

    [Fact, Trait("Catalog", "X05")]
    public void Typed_body_nested_linq_preserves_order_empty_results_and_conversion_errors()
    {
        var emitted = Native("""
            sharepoint.Body.Value
                .Where(entry => entry.DynamicProperties["active"].Value<bool>())
                .Select(entry => entry.DynamicProperties["name"].Value<string>())
                .ToArray()
            """, """
            var sharepoint = WorkflowActions.BuiltIn.CustomCode<ItemsList>(_ => Task.FromResult<ItemsList>(null)).WithName("GetItems");
            """);
        EqualSource("""
            @csharp{body("GetItems").ToObject<ItemsList>().Value.Where(entry => entry.DynamicProperties["active"].Value<bool>()).Select(entry => entry.DynamicProperties["name"].Value<string>()).ToArray()}
            """, emitted);
        var value = JObject.Parse("""
            {"value":[
                {"DynamicProperties":{"active":true,"name":"A"}},
                {"DynamicProperties":{"active":false,"name":"ignored"}},
                {"DynamicProperties":{"active":true,"name":"B"}}
            ]}
            """);
        Assert.Equal(["A", "B"], Assert.IsType<string[]>(LocalNativeHost.Evaluate(emitted, new() { ["GetItems"] = value }).Value));
        Assert.Empty(Assert.IsType<string[]>(LocalNativeHost.Evaluate(emitted,
            new() { ["GetItems"] = JObject.Parse("""{"value":[]}""") }).Value));
        Assert.Throws<FormatException>(() => LocalNativeHost.Evaluate(emitted,
            new() { ["GetItems"] = JObject.Parse("""{"value":[{"DynamicProperties":{"active":"invalid","name":"A"}}]}""") }));
    }
}

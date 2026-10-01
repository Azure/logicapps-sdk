using Newtonsoft.Json.Linq;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class TypedModelCases
{
    [WorkflowCase("DecimalBodiesBelowBoundary", "false", FailureIds = new[] { "F031" })]
    public static FlowDefinition DecimalBodiesBelowBoundary()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var first = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(SeedSummary500).WithName("First");
        var second = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(SeedSummary49999).WithName("Second");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => first.Body.Total + second.Body.Total >= 1000m);
        return Finish("DecimalBodiesBelowBoundary", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), first, second);
    }

    [WorkflowCase("DecimalBodiesAtBoundary", "true", FailureIds = new[] { "F031" })]
    public static FlowDefinition DecimalBodiesAtBoundary()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var first = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(SeedSummary500).WithName("First");
        var second = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(SeedSummary500).WithName("Second");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => first.Body.Total + second.Body.Total >= 1000m);
        return Finish("DecimalBodiesAtBoundary", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), first, second);
    }

    [WorkflowCase("TypedBodyLinq", "[\"A\",\"B\"]", FailureIds = new[] { "F032" })]
    public static FlowDefinition TypedBodyLinq()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var sharepoint = WorkflowActions.BuiltIn.CustomCode<ItemsList>(SeedItems).WithName("GetItems");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => sharepoint.Body.Value
            .Where(entry => entry.DynamicProperties["active"].Value<bool>())
            .Select(entry => entry.DynamicProperties["name"].Value<string>()).ToArray());
        return Finish("TypedBodyLinq", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), sharepoint);
    }

    [WorkflowCase("TypedBodyLinqEmpty", "[]", FailureIds = new[] { "F032" })]
    public static FlowDefinition TypedBodyLinqEmpty()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var sharepoint = WorkflowActions.BuiltIn.CustomCode<ItemsList>(SeedEmptyItems).WithName("GetItems");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => sharepoint.Body.Value
            .Where(entry => entry.DynamicProperties["active"].Value<bool>())
            .Select(entry => entry.DynamicProperties["name"].Value<string>()).ToArray());
        return Finish("TypedBodyLinqEmpty", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), sharepoint);
    }

    [WorkflowCase("TypedBodyLinqInvalid", "", FailureIds = new[] { "F032" }, ExpectedRunStatus = "Failed",
        ExpectedHttpStatus = 502, ExpectedActionError = "String 'invalid' was not recognized as a valid Boolean.")]
    public static FlowDefinition TypedBodyLinqInvalid()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var sharepoint = WorkflowActions.BuiltIn.CustomCode<ItemsList>(SeedInvalidItems).WithName("GetItems");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => sharepoint.Body.Value
            .Where(entry => entry.DynamicProperties["active"].Value<bool>())
            .Select(entry => entry.DynamicProperties["name"].Value<string>()).ToArray());
        return Finish("TypedBodyLinqInvalid", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), sharepoint);
    }

    public static ItemsList Items(bool invalid) => new()
    {
        Value = new[]
        {
            new ListItem { DynamicProperties = new() { ["active"] = invalid ? new JValue("invalid") : new JValue(true), ["name"] = new JValue("A") } },
            new ListItem { DynamicProperties = new() { ["active"] = new JValue(false), ["name"] = new JValue("ignored") } },
            new ListItem { DynamicProperties = new() { ["active"] = new JValue(true), ["name"] = new JValue("B") } }
        }
    };

    [WorkflowCase("JsonPropertyNavigation", "[{\"dynamicProperties\":{\"active\":true,\"name\":\"A\"}},{\"dynamicProperties\":{\"active\":false,\"name\":\"ignored\"}},{\"dynamicProperties\":{\"active\":true,\"name\":\"B\"}}]",
        FailureIds = new[] { "F084" })]
    public static FlowDefinition JsonPropertyNavigation()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var sharepoint = WorkflowActions.BuiltIn.CustomCode<ItemsList>(SeedItems).WithName("GetItems");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => sharepoint.Body.Value);
        return Finish("JsonPropertyNavigation", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), sharepoint);
    }

    [WorkflowCase("TypedDecimalBody", "120.0", FailureIds = new[] { "F136" })]
    public static FlowDefinition TypedDecimalBody()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var summary = WorkflowActions.BuiltIn.CustomCode<OrderSummary>(SeedSummary100).WithName("GetSummary");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => summary.Body.Total * 1.2m);
        return Finish("TypedDecimalBody", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), summary);
    }

    // ScriptExecutor invokes MethodInfo with a null target, so seed callbacks must be named static methods.
    public static Task<OrderSummary> SeedSummary500(WorkflowContext _) => Task.FromResult(new OrderSummary { Total = 500m });
    public static Task<OrderSummary> SeedSummary49999(WorkflowContext _) => Task.FromResult(new OrderSummary { Total = 499.99m });
    public static Task<OrderSummary> SeedSummary100(WorkflowContext _) => Task.FromResult(new OrderSummary { Total = 100m });
    public static Task<ItemsList> SeedItems(WorkflowContext _) => Task.FromResult(Items(false));
    public static Task<ItemsList> SeedEmptyItems(WorkflowContext _) => Task.FromResult(new ItemsList());
    public static Task<ItemsList> SeedInvalidItems(WorkflowContext _) => Task.FromResult(Items(true));

    [WorkflowCase("NativeLinq", "[4,6]", FailureIds = new[] { "F133", "F184", "F188" })]
    public static FlowDefinition NativeLinq()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var values = WorkflowActions.BuiltIn.Compose<List<int>>(() => new List<int> { 1, 2, 3 }).WithName("Values");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => values.Output.Where(x => x > 1).Select(x => x * 2).ToArray());
        return Finish("NativeLinq", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), values);
    }

    [WorkflowCase("NativeLinqEmpty", "[]", FailureIds = new[] { "F133", "F184", "F188" })]
    public static FlowDefinition NativeLinqEmpty()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var values = WorkflowActions.BuiltIn.Compose<List<int>>(() => new List<int>()).WithName("Values");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => values.Output.Where(x => x > 1).Select(x => x * 2).ToArray());
        return Finish("NativeLinqEmpty", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), values);
    }

    [WorkflowCase("ListJoinAndIndex", "{\"join\":\"1,2,3\",\"index\":2}", FailureIds = new[] { "F126", "F137" })]
    public static FlowDefinition ListJoinAndIndex()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var values = WorkflowActions.BuiltIn.Compose<List<int>>(() => new List<int> { 1, 2, 3 }).WithName("Values");
        var join = WorkflowActions.BuiltIn.Compose<object>(() => string.Join(",", values.Output)).WithName("Join");
        var index = WorkflowActions.BuiltIn.Compose<object>(() => values.Output[1]).WithName("Index");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { join = join.Output, index = index.Output });
        return Finish("ListJoinAndIndex", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), values, join, index);
    }

    [WorkflowCase("NestedLambdaCapture", "[3,4,5]", FailureIds = new[] { "F141" })]
    public static FlowDefinition NestedLambdaCapture()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var values = WorkflowActions.BuiltIn.Compose<List<int>>(() => new List<int> { 1, 2, 3 }).WithName("Values");
        int increment = 2;
        var result = WorkflowActions.BuiltIn.Compose<object>(() => values.Output.Select(x => x + increment).ToArray());
        increment = 100;
        return Finish("NestedLambdaCapture", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), values);
    }

    [WorkflowCase("UserDefinedOperator", "{\"Value\":5.0}", FailureIds = new[] { "F112" })]
    public static FlowDefinition UserDefinedOperator()
    {
        Money.ConstructorCalls = 0;
        Money.OperatorCalls = 0;
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var money = WorkflowActions.BuiltIn.Compose<Money>(() => new Money(3m)).WithName("Money");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => money.Output + new Money(2m));
        return Finish("UserDefinedOperator", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), money);
    }

    [WorkflowCase("NativeConstructor", "{\"Value\":2.75}", FailureIds = new[] { "F118" })]
    public static FlowDefinition NativeConstructor()
    {
        Money.ConstructorCalls = 0;
        Money.OperatorCalls = 0;
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var amount = WorkflowActions.BuiltIn.Compose<decimal>(() => 2.75m).WithName("Amount");
        var result = WorkflowActions.BuiltIn.Compose<Money>(() => new Money(amount.Output));
        var definition = Finish("NativeConstructor", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), amount);
        Require(Money.ConstructorCalls == 0, "Money constructor executed during generation.");
        return definition;
    }
}

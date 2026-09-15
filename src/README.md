Azure LogicApps SDK
===

The **Azure Logic Apps SDK** is a framework that simplifies the creation of workflows using code.

Strongly typed action results in custom code
---

Custom code can deserialize an action's complete outputs or its body to a .NET type. Use
`GetBody<T>()` with the generated response types exposed by managed connector actions:

```csharp
public static async Task<CustomerSummary> RunAsync(WorkflowContext context)
{
    var actionResult = await context.GetActionResults("Get_customer");
    var customer = actionResult.GetBody<GetCustomerResponse>();

    return new CustomerSummary
    {
        Name = customer.Name,
    };
}
```

For actions whose output is not wrapped in a `body` property, use `GetOutputs<T>()` instead:

```csharp
var actionResult = await context.GetActionResults("Compose_customer");
var customer = actionResult.GetOutputs<CustomerSummary>();
```

## Generated managed connectors

The connector wrappers in `generated/managed` are committed generated output. Their generator and templates are maintained outside this repository; this is separate from the user-authored `Workflow.cs` files that call these wrappers. Generated workflow input lambdas must be serialized with `CSharpExpressionConverter`; dynamic path parameters must be combined with `ConvertFormattedString` so the stored path is one complete C# expression. Apply equivalent changes to the external generator before refreshing these files.

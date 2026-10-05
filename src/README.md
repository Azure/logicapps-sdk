Azure LogicApps SDK
===

The **Azure Logic Apps SDK** is a framework that simplifies the creation of workflows using code.

## C# workflow expression inputs

Value lambdas support expression bodies and synchronous blocks. The .NET 8 source
compiler creates explicit descriptors; it never runs the authoring delegate.
The Logic Apps host must include the matching SDK expression contract and approved
SDK model reference. See [C# expression architecture](CSharpExpressionArchitecture.md)
for the build, capture, rendering, runtime, and package contracts.

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

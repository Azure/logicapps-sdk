Azure LogicApps SDK
===

The **Azure Logic Apps SDK** is a framework that simplifies the creation of workflows using code.

Workflow expression inputs
---

Managed connector and service-provider inputs use source-generated `Func<T>` expressions.
Generated JSON input objects are lowered to JSON construction expressions, including
`DefaultValue` metadata for omitted properties; explicitly assigned values take precedence.
Their CLR types are not loaded by the workflow runtime. Parameterized/custom constructors
and customer helper methods remain unsupported in workflow expressions.

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

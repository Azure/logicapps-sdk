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

The connector wrappers in `generated\managed` and `generated\serviceProviders` are committed generated output. Their generator and templates are maintained outside this repository; this is separate from user-authored workflow files. After refreshing generated output, run `node eng\Migrate-SourceExpressions.cjs` from the repository root. The pass is idempotent; equivalent changes should also be applied to the external generator.

## Source-preserving workflow expressions

Workflow expression parameters are `[WorkflowExpression] Func<T>`. They require
SDK compiler-produced, version-1 `SourceExpression` metadata. An ordinary delegate
or expression tree is not a compatibility path: the runtime rejects untransformed
delegates without executing them or inspecting their closure fields.

The runtime preserves native source and substitutes only explicit `SourceBinding`
references. Literal and approved collection captures are copied when the descriptor
is constructed. Action and variable handles are resolved when `GetActionDefinition`
is called; trigger payloads are resolved at `GetTriggerDefinition`. A definition
already returned is a snapshot and does not change when the graph is subsequently
renamed. SDK-owned deferred payload builders do not re-run user graph factories.

`SourceBinding.CapturePath` snapshots compiler-approved instance field and
auto-property paths by validating and reading their backing storage, never their
getters. Static storage, custom getters, compiler-generated closure objects,
ambiguous hidden members, and null intermediate receivers are rejected.
`Create` with kind `capture`, two empty segments, and one capture binding retains
the snapshot's JSON token type. Captured foreach placeholders instead render
`@item()` (or typed `item()` access in native source).

Structured descriptors use `SourceExpression.Object<T>` and `Array<T>` with explicit
child descriptors. `Create`, `Object`, and `Array` also accept a trailing
`Func<T> typeWitness` solely to infer anonymous result types. This witness is never
invoked or retained; the supplied descriptor is the only expression representation.
`SourceExpression.TypeName(Type)` supplies fully qualified C# names for concrete
binding types, including nested generics and arrays; open and pointer types fail
explicitly.
Template descriptors may supply `nativeSegments` to either `Create` overload.
These compiler-preserved source segments use the same binding order and permit
native generated-path composition without reverse-translating template text.
Headers and other generation-time objects reject native
expressions instead of invoking constructors, getters, or methods. Captured custom
objects, unsupported descriptor versions, block/async bodies, and template-to-native
promotions without adequate source metadata fail explicitly.

The historical expression-tree visitors remain temporarily for migration of legacy
tests; the workflow-authoring APIs do not use them. Runtime descriptor tests are not
verification of native expression support in the deployed execution host.

Captured native values retain their compiler-declared CLR type for overload
resolution, including interfaces and nullable types. Finite floating-point values
use invariant round-trip formatting; non-finite captures are explicitly rejected
as unsupported JSON values. SDK JSON output uses its explicit serializer settings
without inheriting `JsonConvert.DefaultSettings`; captured custom serializers,
callbacks, and getters are not invoked.

`WorkflowFunctions.ToJson` is a source-compiler intrinsic, not an executable JSON
parser. The compiler emits `SourceExpression.Json<T>(1, inputDescriptor)` and uses
`SourceBinding.Json` when the parsed value is consumed by surrounding native code.
The runtime emits `json(...)`, preserves final workflow bindings, and materializes
the declared CLR type only for native consumers. Direct calls to the untransformed
intrinsic throw instead of returning a misleading default value.

For semantically verified Newtonsoft `JToken` implicit conversions, the compiler
uses `SourceExpression.Token<T>(1, inputDescriptor)`. This adapter retains the
original descriptor and source type, so destination transforms can distinguish
strings, numbers, booleans, and raw bytes without executing a conversion delegate.

`SourceExpression.Enum<T>(1, valueDescriptor, wireDescriptor)` retains both typed
native enum source and compiler-supplied wire source. Numeric consumers such as
Response status codes use the former; enum wire destinations use the latter
without a second mapping. `SourceBinding.EnumWire` renders individual enum leaves,
allowing the compiler to preserve conditional source and branch evaluation.

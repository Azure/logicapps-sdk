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

## Generated connectors

The wrappers in `generated\managed` and `generated\serviceProviders` are committed
output from BPM's `src\tools\CodefulSdkGenerator`. The active C# targets are
`ManagedConnectorSdk\CSharpTargetGenerator.cs` and
`ServiceProviderSdk\LogicAppsSdkServiceProviderTargetGenerator.cs`; the legacy
service-provider/DurableTask target does not generate these SDK wrappers.

Use a generator revision that emits `[WorkflowExpression] Func<T>` parameters,
immediate `SourceExpression.Validate` calls, the appropriate
`SourceExpressionConverter` methods, and deferred `BuildSourceInput` factories.
These sources compile into the SDK assembly and can use its internal APIs.
This connector generation is separate from the consuming project's workflow
source-expression compiler.

Pin the generator revision and Swagger/service-provider manifest inputs.
Generate into a separate directory, review operation inventories, skipped
operations and API differences, and compile fresh output against this SDK before
replacing committed sources. Do not replace the complete managed navigator
registry with output from a filtered connector run. Input-schema changes and
emitter changes must be reviewed separately.

Check per-operation errors and explicit skip diagnostics as well as per-connector
results: a generated file can omit operations even when generation returned
successfully. The managed C# target deliberately excludes unsupported multipart
operations, and internal/deprecated operations can disappear during a refresh.
Review those API losses rather than treating successful file generation as
complete operation coverage.

Preserve existing files for which no replacement was generated, and report them
as retained rather than regenerated. Keeping an older wrapper instead of a
partially generated replacement is a separate compatibility decision; an approved
full refresh applies the available generated files, including reviewed operation
removals. New catalog connectors are separate additions and must be included in
the SDK compilation check, not just compared with existing paths.
Runtime-static service-provider metadata must be identified as such; it does not
certify the catalog of a deployed Standard app.

The active managed and modern service-provider C# targets use deterministic LF
line endings and omit the extra blank line before a deferred factory's final
return. This formatting policy preserves comments and tokens and does not change
other generator targets. Older committed files may still have CRLF line endings.

Use the [generated connector parity test](../tests/GeneratedConnectorParity/README.md)
to compare fresh output with these sources. It reports managed/provider coverage,
API and implementation-syntax differences separately, and includes an isolated
actual-SDK compilation hook. Missing inputs are reported as untested coverage,
not assumed matches.

Regeneration must preserve public model-property names and serialized defaults,
not just method signatures. The managed C# target retains the SDK's model-property
acronym casing without changing the shared naming policy for other targets.
Hidden query defaults remain strings except for the explicit typed
`Sharepointonline.GetFileMetadataByPath` / `queryParametersSingleEncoded`
compatibility rule. Generated managed object bodies retain the historical
`propCount > 0` omission check: no populated properties means no body, even if
the Swagger body parameter is marked required. Required argument validation
still runs before the deferred payload factory; it is separate from this
body-presence check. Public operation version selection must not let an
internal-only newer version erase an existing public method; internal operations
must still be retained for subscription and metadata references.

Hidden path defaults use descriptor-backed `SourceExpression.Literal(1, value)`
arguments and the declared path encoding, not undeclared public parameters or
ordinary lambdas. Required hidden parameters without usable defaults still fail
generation. Public parameter identifiers and nested body locals must be allocated
without collisions while preserving their original serialized wire names.

Full-catalog generation needs managed API **export** documents and expanded
service-provider operation manifests for the intended subscription/region and
Standard runtime. Raw API-test Swagger files are not interchangeable with those
inputs. Preserve the original cache and request/input inventory when possible;
a new live capture is a new schema snapshot, not proof of historical parity.
The generator CLI's cache can fetch on misses, so a cache path alone is not a
fail-closed offline mode.

`eng\Migrate-SourceExpressions.cjs` remains a temporary bridge for earlier
CSharpExpressionConverter-based output, not a required regeneration step or a
complete migration from the original ExpressionConverter. It does not supply
all path, callback, base64 and typed-default adaptations. Current generator
output must satisfy the SDK contract without this postprocessing pass.

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

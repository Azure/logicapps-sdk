# Native C# workflow expressions

Workflow values are authored as `Func<T>` lambdas. A Roslyn build-time call
rewriter replaces operation calls with generated `__Build...` entry points taking
real `WorkflowExpression<T>` descriptors. The authoring delegates are never
invoked and are not used to disguise source descriptors.

## Expression boundary

The compiler preserves expression/block bodies, loops, local functions, nested
lambdas, constructors and ordinary CLR operations. It rewrites only workflow data
references and SDK workflow-function calls. For example:

```csharp
var email = readEmail.Body;
return email.Subject.ToUpperInvariant();
```

becomes the same C# with the root replaced by
`body("ReadEmail").ToObject<GraphClientReceiveMessage>()`. Subsequent properties,
dictionary mutation and model/enum operations remain native C#. SDK models are
not lowered to JSON objects or dictionaries, and enums are not replaced by wire
strings inside the program.

The existing host globals provide context accessors and bounded function invokers.
`WorkflowFunctions.ToJson<T>` becomes `json(...).ToObject<T>()`. Explicit typed
casts at an object/JSON workflow boundary become typed `ToObject<T>` conversions.
Simple property paths through source-visible customer/anonymous output DTOs may
use JSON navigation; other customer types/helpers are not expression dependencies
and belong in `CustomCode`.

## Source transport and captures

A descriptor holds source segments and bindings. Bindings retain operation handles
until final names are assigned and snapshot external values at argument evaluation.
Graph-building callbacks still execute once during construction. Action input
rendering is deferred until definition export so `.WithName(...)` remains effective.

Synchronous blocks use a framework `Func<T>` invocation, not an SDK execution
helper. Scalar captures emit literals or straightforward GUID/date/time/URI/HTTP
method constructors. Captures are immutable snapshots, not executable closures.
Mutable collection/object captures, implicit instance state, external local
functions and async/task-returning values fail authoring. Expression-local values
remain normal mutable C# objects.

The operation boundary uses standard Newtonsoft serialization with enum wire
conventions; constructor defaults and JSON attributes come from the actual SDK
types. No schemas, generated model codecs, descriptor versions or host conversion
protocol are involved. Dynamic dictionaries/status codes are stored as expression
tokens rather than coerced into authoring-time values.

## Runtime references

The codeful app deploys its own SDK at:

```text
lib\codeful\Microsoft.Azure.Workflows.Sdk.dll
```

The host resolves that exact path and supplies it through the BPM engine's generic
additional-reference-path API. The engine itself has no app-layout policy. It uses
the supplied path for expression analysis, compilation and execution through
Roslyn's normal metadata/reference loader. Each app engine owns its loader and
runner caches. SDK replacement requires a process/host restart.
Framework and Newtonsoft references are shared with
the host. The host does not take a fixed SDK package dependency and does not scan
arbitrary customer assemblies.
Missing/incompatible SDKs fail explicitly.

SDK model versions therefore need not match a bundle's build-time dependencies.
The engine still requires compatible framework/Newtonsoft APIs and retains its
existing cooperative cancellation, not an execution sandbox or hard timeout.

## Generation and validation

Managed and service-provider generators emit both surfaces from one operation.
Descriptor arguments are validated; optional omission retains manifest defaults.
The SDK package carries the .NET 8 compiler and transitive build target.
Consumers need only the SDK package; no interceptor preview configuration is needed.

`eng\Test-PackageConsumer.ps1` verifies an isolated package consumer and can export
a fixture using `-ExpressionOutputPath`. SDK tests cover native model identity,
mutations, enum operations, blocks, captures and late names. BPM tests cover
app isolation, restart-based replacement, missing SDKs and existing host behavior.

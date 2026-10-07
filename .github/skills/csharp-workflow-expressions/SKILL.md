---
name: csharp-workflow-expressions
description: Guidance for implementing or reviewing native C# workflow expressions, source descriptors, connector factories, captures, and BPM runtime SDK references.
---

# Native C# workflow expressions

Use this skill when changing workflow-expression authoring, connector factory
generation, the SDK source compiler, or BPM C# runtime references.

## Design invariants

Workflow values are authored as `Func<T>` lambdas. A Roslyn build-time call
rewriter replaces operation calls with generated `__Build...` entry points taking
real `WorkflowExpression<T>` descriptors. Never execute authoring delegates or
use placeholder delegates to transport source descriptors.

## Expression boundary

Preserve expression/block bodies, loops, local functions, nested lambdas,
constructors, and ordinary CLR operations. Rewrite only workflow-data references
and SDK workflow-function calls.

For example:

```csharp
var email = readEmail.Body;
return email.Subject.ToUpperInvariant();
```

becomes the same C# with the root replaced by:

```csharp
body("ReadEmail").ToObject<GraphClientReceiveMessage>()
```

Subsequent properties, dictionary mutation, and model/enum operations remain
native C#. Do not lower SDK models to JSON objects/dictionaries or replace SDK
enums with wire strings inside the program.

Use existing host globals for context accessors and bounded function invokers.
`WorkflowFunctions.ToJson<T>` becomes `json(...).ToObject<T>()`. Explicit typed
casts at an object/JSON workflow boundary become typed `ToObject<T>` conversions.
Simple property paths through source-visible customer/anonymous output DTOs may
use JSON navigation. Other customer types/helpers belong in `CustomCode`.

## Source transport and captures

A descriptor contains source segments and bindings. Bindings retain operation
handles until final names are assigned and snapshot external values at argument
evaluation. Graph-building callbacks execute once during construction. Defer
action-input rendering until definition export so `.WithName(...)` remains
effective.

Synchronous blocks use framework `Func<T>` invocation, not an SDK execution
helper. Scalar captures emit literals or direct GUID/date/time/URI/HTTP-method
constructors. Captures are immutable snapshots, not executable closures.

Reject mutable collection/object captures, implicit instance state, external
local functions, and async/task-returning workflow values. Expression-local
values remain normal mutable C# objects.

Preserve computed CLR results in generated C# and let BPM's
`WorkflowValueNormalizer` perform the sole CLR-to-workflow conversion after
evaluation. The SDK must not emit `JToken.FromObject`, serializer settings, or
enum wire conversion around rendered source. Runtime normalization preserves SDK
JSON attributes, SDK enum wire names, binary content envelopes, and supported
framework value conventions recursively. Do not introduce model schemas,
generated read/write codecs, descriptor versions, or parallel conversion
protocols.

## Runtime references

The codeful app deploys its SDK at:

```text
lib\codeful\Microsoft.Azure.Workflows.Sdk.dll
```

The host resolves this path and supplies it through BPM's generic additional
reference paths. The C# engine must not know app-directory layout or SDK filename
policy. Analysis, compilation, and execution use the same Roslyn options and
per-engine `InteractiveAssemblyLoader`.

Validate all additional paths and fail explicitly. Do not scan arbitrary customer
assemblies or silently omit invalid references. Dispose the loader if constructor
setup fails. SDK replacement requires process/host restart.

Framework and Newtonsoft assemblies are host references. The runtime remains
cooperatively cancellable, not sandboxed and not guaranteed to enforce a hard
timeout.

## Generation and validation

Managed and service-provider generators emit the authoring and descriptor methods
from one operation. Validate descriptors and preserve manifest defaults.

Generated trigger factories expose operation inputs and execution configuration
such as polling recurrence, but no naming metadata. Unnamed deferred triggers use
`WorkflowTriggerBase`'s unique name; `.WithName(...)` is the only explicit naming
API for generated triggers.

The SDK package carries the .NET 8 source compiler and transitive build target.
Consumers need only the SDK package and no interceptor preview configuration.

Keep package-only validation focused on package wiring. SDK tests should cover
native model identity, mutation, enum operations, blocks, captures, and late
names. BPM tests should cover additional-reference loading, app isolation,
missing/invalid paths, and existing host behavior.

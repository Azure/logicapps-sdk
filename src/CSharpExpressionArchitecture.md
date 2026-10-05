# C# workflow expressions

Workflow value parameters use `[WorkflowExpression] Func<T>` at the authoring
surface. The delegate is not executed. The SDK's .NET 8 build tool replaces the
call with a compiler-facing `__Build...` method that accepts `WorkflowValue<T>`.
`WorkflowExpressionFactoryAttribute` identifies the entry point. Both signatures
come from the same connector operation; only the entry point builds the action.
Calling an authoring method without transformation fails explicitly.

## Pipeline

1. Roslyn resolves the factory call and captures each value lambda's source.
   Expression and synchronous block bodies are supported. Statements, constructors,
   operators, local functions and LINQ remain C#; they are not translated into a
   template-language instruction set.
2. Workflow output, trigger, variable, foreach-item and agent-parameter references
   become typed bindings. SDK models keep their CLR identity. Simple property paths
   through custom-code output DTOs can use JSON navigation without loading the
   customer type. Other customer type usage is rejected.
3. External locals become explicit snapshots at their argument position. The
   compiler emits one local per capture inside the runtime lambda, so repeated
   uses share that value during one evaluation. Expression-local variables are
   never captures. Reassigning an external capture or passing it by reference is
   rejected; mutating a supported captured collection mutates the per-evaluation
   copy, not authoring state.
4. The ordinary C# build compiles descriptor-construction code. Anonymous result
   types use a nonexecuted type-witness lambda for inference; the descriptor never
   stores that delegate.
5. The worker builds the action graph. Graph-building callbacks execute once;
   descriptors hold source, capture data and workflow handles.
6. `GetActionDefinition` renders each descriptor using final operation names.
   SDK-owned deferred builders create fresh input objects. Literals become JSON;
   programs become one `#{...}` value. The worker registers JSON with the host,
   not executable authoring delegates.
7. The host compiles expressions during loading, checks the contract version and
   finds workflow references without executing the program. Each run supplies fresh
   globals, executes the compiled script and normalizes the result.

## Runtime contract

`WorkflowExpressionRuntime` defines version 1. `Run<T>` gives expression and block
bodies their declared return type. `ToWire` and `ToText` apply connector-boundary
conversion; enum wire names are distinct from enum arithmetic inside the program.
`DecodeCapture<T>` restores data from a JSON snapshot rather than reconstructing
C# constructors for each captured type.

The host references the SDK as a product dependency. It does not find or load DLLs
from customer directories. This package and a host containing the matching contract
must ship together. Framework/JSON references and generated SDK model types are
allowed; customer helpers and implicit instance state are not. A customer helper
belongs in `CustomCode`, not a workflow-value expression.

Capture serialization supports typed scalars, enums, URI/HTTP method/GUID/date/time
values, JSON tokens, one-dimensional arrays, lists and string-keyed dictionaries.
Unsupported runtime subclasses, custom objects, cycles and non-finite values fail
explicitly. JSON serialization never uses ambient `JsonConvert.DefaultSettings`.
This is a value-copy contract, not closure or cross-variable object-identity
serialization.

Referenced variable names must be literals or captured strings. They must be known
at definition generation so the host can statically load variable dependencies.
Async/task/stream values and arbitrary runtime-created delegates are unsupported.
The script runner remains in-process: its cancellation is cooperative, not a
sandbox or a hard execution deadline.

## Paths, triggers and monitoring

Generated connector path formatting uses numbered placeholders and produces a
canonical concatenation:

```text
#{"/current/" + (encodeURIComponent(...))}
```

Literal path text stays distinct from parenthesized encoded values. This retains
the shape used by the earlier LogicAppsUX codeful-path parser for both swagger
operation matching and parameter extraction. Do not replace it with another
format without updating that UX contract. The SDK does not evaluate C# to discover
paths. Generated callback and split-on values use C# wrappers as well.

## Generation and packaging

The managed and service-provider generators in BPM now use `WorkflowFactorySyntax`
to emit both API surfaces and defer input construction. Do not regenerate with a
generator version that only emits expression-tree methods.

The NuGet package contains the build tool and transitive MSBuild targets; consumers
need only the SDK package reference and .NET SDK 8.0.4xx. No analyzer reference or
interceptor settings are needed. The SDK and build tool remain separate: the host
excludes build assets when it references the package. The local preview version is
`1.0.0-preview.3-csharp.1` and must be made available to the runtime package feed
before building outside these worktrees.

`eng\Test-PackageConsumer.ps1` restores the packed SDK into an isolated cache and
builds/runs a package-only consumer. The runtime tests compile and evaluate typed
SDK blocks, captures, and contract failures. Existing workflow results and
service-provider-default tests remain in the normal SDK suite.

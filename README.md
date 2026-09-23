Azure LogicApps SDK
===

The **Azure Logic Apps SDK** is a framework that simplifies the creation of workflows using code.

## Source expressions (preview migration)

Workflow value lambdas are analyzed during the consumer's build. The SDK build
tool preserves their C# source and replaces workflow references and supported
captures with explicit bindings. It does not reconstruct C# from expression
trees or execute authoring lambdas to discover their values.

```csharp
var suffix = "!";
var result = WorkflowActions.BuiltIn.Compose(
    inputs: () => source.Output.ToUpperInvariant() + suffix)
    .WithName("Upper");
```

The emitted native expression is equivalent to
`@csharp{outputs("Source").ToObject<string>().ToUpperInvariant() + "!"}`.
Ordinary captures are snapshotted when the action is constructed; workflow
handles remain bound until definition generation so later action names resolve.

Literals, Roslyn-proven constants, direct workflow references, and simple
reference-only interpolated strings remain codeless. Explicit `string.Format`,
`string.Concat`, arithmetic, and other native computations remain C#. The
SDK's `WorkflowFunctions.ToJson` intrinsic remains a workflow JSON helper.
Implicit primitive-to-`JToken` conversions preserve the original value type
for destination encoding rather than forcing native C#.
The package includes the build tool and `buildTransitive` integration; users do not
write binding metadata or maintain a separate transformation script. The build
tool currently requires .NET 9; the runtime SDK remains `netstandard2.0`.

The compiler-facing `SourceExpression` APIs are versioned build infrastructure,
not an alternative authoring API. Calling an untransformed workflow value
delegate fails explicitly instead of executing it. Ordinary graph-building
callbacks and `CustomCode` callbacks retain their distinct execution behavior.
The retired expression-tree converters are excluded from the shipped assembly;
their preserved sources are linked only into historical characterization tests.

Enum-wire destinations normalize conditional result branches without changing
enum operands or numeric Response status. Response owns the omitted-status
default of 200 and rejects an explicitly supplied literal zero.

### Verification and current limits

Executable compiler and SDK regression tests live in
`tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests`; package-consumer
checks live in `tests\SourcePackageConsumer`, and actual-host workflows live in
`tests\SourceExpressionE2E`. Historical reports and recorded output snapshots
are kept outside the repository. Local test passes do not establish backend
support; the E2E suite retains its known failing contracts.

Block/async workflow values are rejected until an execution-host transport is
verified. Dynamically selected delegates, runtime-created expression trees,
arbitrary captured getters, and implicit instance state are not reconstructed
or executed. Bounded source-visible local lambda reuse is handled by the build
tool, not by a runtime expression-tree fallback.
Complete, plain generated-model initializers can be structural JSON; this does
not imply support for inferred model defaults or arbitrary constructor execution.

Local Roslyn compilation is not backend certification. Real-host validation is
still required for helper signatures/materialization, Condition/designer
support, literal-marker escaping, serializer/encoding contracts, dependency
deployment, and host language features. The build integration rejects unverified source
generators; the narrowly verified Functions Worker generator combination is
documented in the package-consumer fixtures.

### Deployment preflight

Builds emit assembly-specific `*.workflow-expressions.json` dependency sidecars.
When a publish output contains workflow definitions, the SDK validates those
definitions and sidecars before reporting a successful publish. Custom native
dependencies require explicit, SHA256-pinned approval and matching executable
assemblies/types in the deployment. Validation reads metadata; it does not load
or execute dependency assemblies.

Set `WorkflowExpressionHostProfile` to an explicitly reviewed JSON profile for
the target host. Version 1 profiles identify `host` and `evidence`, and can declare
`nativeExpressionsVerified`, `nativeConditionsVerified`,
`literalMarkerEscapingVerified`, `languageVersion`, `namespaceImports`, and
`approvedDependencies` (objects containing `assembly` and `sha256`). Missing
capabilities are denied, not inferred from local compilation. A profile is an
operator's recorded approval; the SDK does not manufacture backend certification.

Actual local-host probes found that public Workflow bundles **1.170.43 and
1.170.91 reject `@csharp{...}` expressions**. Ordinary C# action support does not
establish inline-expression support. Do not approve native-expression deployment
to those versions. Reproducible host probes live in `tests\SourceHostConsumer`.

Versioned schema generation supplies authoritative destination metadata for
defaults, closed enums, nullability, and ordered nested encoding. Bounded,
source-visible factories preserve argument evaluation and use the consuming
destination's contract; arbitrary runtime factories remain unsupported.
Dependency discovery and deployment approval are enforced by the preflight
described above.

The expanded Windows package-consumer matrix covers schema
regeneration, compilation contexts, transitive dependencies, and deployment
rejections. Actual Windows VS Code checks cover completion, hover, original-source
diagnostics, integrated builds, and the no-authoring-execution contract.
Other platform/IDE combinations and a supporting native-Condition
runtime/designer remain release gates. Local compiler execution and design-time
MSBuild checks alone are not IDE or backend certification. Actual bundle 1.170.91
probes verified simple interpolation and escaped literals in both en-US and
fr-FR; they did not establish native-expression or native-Condition support.

Separate codeful preview-host probes execute native arithmetic, the JSON
intrinsic, and the catalog's encoded calculated JSON payload. Bounded scalar,
array, and anonymous-object JSON shapes use explicit Newtonsoft serializer
settings without ambient defaults or an SDK helper dependency. Shapes requiring
SDK wire helpers still need explicit host/assembly approval; deploying the SDK
with the authoring worker does not make it available to the host's expression
compiler. Preflight rejects missing helper dependency records as well.
Native Conditions fail on the tested preview host while equivalent template
controls succeed. No template substitution is used to hide that failure.
Reproduction sources live in `tests\SourceNativeHostConsumer`.

## License

This project is under the benevolent umbrella of the [.NET Foundation](http://www.dotnetfoundation.org/) and is licensed under [the MIT License](https://github.com/Azure/azure-webjobs-sdk/blob/master/LICENSE.txt)

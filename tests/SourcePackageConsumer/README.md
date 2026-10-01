# Source package-consumer validation

The latest completed package gate is **`7F1BC5DE...`**, containing SDK
`D5547536...` and compiler `42F0284B...`. Its authorized no-build pack, all 97
expanded commands, original Worker, independent build-asset checks, and actual
VS Code validation passed. Evidence is under `obj\host-json-fix-validation`.
No approval gates or host-profile expectations were weakened.
Historical package and language-service/editor snapshots are archived outside
the repository. Run the validators below to produce current observations;
package and editor validation do not certify an execution backend.

The SDK runtime remains `netstandard2.0`. Source compilation currently requires
`dotnet build` on .NET SDK 9 (with the .NET 9 runtime). Full-framework MSBuild
is rejected. No machine-specific SDK path is embedded in the package.

Build/pack the SDK, then pass the actual package to the isolated consumer:

```powershell
.\tests\SourcePackageConsumer\Validate.ps1 -PackagePath .\out\pkg\Release\Microsoft.Azure.Workflows.Sdk.1.0.0-preview.2.nupkg
```

For the bounded package/Worker gate without the unrelated existing-sample
definition-generation stage, pass `-SkipExistingSamples`. The log explicitly
records that scope; it does not count the omitted sample stage as passing.
The final package gate uses Release and this switch. The original repository
Worker is also built directly in Debug with `--no-restore`,
`BuildProjectReferences=false`, `GeneratePackageOnBuild=false`, and an empty
`LogicAppFolderToPublish`, avoiding shared SDK rebuilds and deployment copies.

The script restores through configured NuGet feeds plus the local package feed to
a fixture-local package cache, verifies that the supplied package was selected,
uses only PackageReference, checks package contents, executes the consumer twice,
compares transformed compiler inputs and hashes the original source,
and checks published output for leaked compiler assemblies. Build artifacts stay
under this directory's ignored `obj`/`bin` directories. Empty local Directory.Build
props and targets isolate the fixture from repository engineering/import behavior.
`ConnectorConsumer` additionally references only the packaged runtime, explicitly
excluding package build targets and analyzers. It checks immediate required-null
and raw-delegate rejection, exact parameter names, reflection calls and a valid
descriptor without any consumer rewriting. The shared BuildTasks targets file
must be included in the package; Roslyn must remain absent from runtime references.
The validation log records the supplied package SHA256, exact dotnet argument
arrays, exit codes (including the expected generator rejection), and completed
check markers. These are external package evidence, not xUnit/TRX results.
Map only completed checks to the exact catalog requirement; a later sample-stage
failure does not erase preceding checks or make the complete matrix successful.
Before workflow assertions, the consumer reflects over the packaged runtime to
require SourceExpression.TypeName(Type) and Create overload parameters named
nativeSegments/typeWitness, plus the final Json, Token, Enum and EnumWire APIs.
This catches stale pre-ABI-change packages that could
otherwise pass the basic Compose smoke.
The fixture also verifies frozen escaped captures, escaped interpolation braces,
generic workflow-reference CLR types, and nested anonymous objects/arrays. Its transformed
inputs must actually call the nativeSegments/typeWitness/TypeName APIs, so a
fresh runtime packaged with an older compiler cannot pass by reflection alone.
An implicit string-to-JToken expression must also use SourceExpression.Token
while retaining the exact inner native source.
It also rebuilds with the real xUnit analyzer package to verify analyzer-only
acceptance, then adds a real generator project that emits a workflow authoring method and
requires the package build to reject it explicitly with WFSDK1002 (PK12).
Finally it builds/runs a real Functions Worker package consumer, verifies generated
function metadata and dispatch output, and checks that generator outputs were not
fed into the workflow transformer.
The `SamplesConsumer` additionally links all existing UnitTests workflow-provider
sources without editing them, constructs all 19 providers (including Agent and
Agentic samples), and serializes their definitions. Agent messages must remain
structured arrays of objects. The script hashes linked source files and saves
generated definitions under `obj\package-validation\existing-sample-definitions.json`.
The current all-samples stage intentionally remains failing on the unchanged
`ParallelBranchWorkflow`: its first example assigns run-after statuses directly
after a trigger, which `WorkflowTriggerBase.Then` rejects. The other 18 providers
generate and serialize 25 definitions, including all Agent examples. This
pre-existing sample-validation failure is not suppressed or presented as a green
full package/sample matrix; the preceding package/Worker checks pass.

Independent build-asset checks (no SDK or compiler build required):

```powershell
.\tests\SourcePackageConsumer\Validate-BuildAssets.ps1
dotnet msbuild .\tests\SourcePackageConsumer\BuildAssets.proj -t:ValidateAnalyzerMetadata -p:AnalyzerPath=C:\path\to\analyzer.dll
```

## Expanded local matrix

`Validate.ps1` now also runs `Validate-Matrix.ps1` before the optional sample
stage. The final integrated run completed all 97 expanded commands with zero
unexpected failures, producing 39 case records (including the explicitly
partial MSBuild-only design-time record). These are external package checks,
not an xUnit test count. Earlier snapshots are historical only.

The runner copies `MatrixFixtures` into the isolated `obj/package-validation/matrix
workspace` directory (deliberately containing a space), then mutates only that
copy. It records exact commands, exits, per-command logs and hashes, fixture
hashes, completed case checks, and failure details in
`obj/package-validation/expanded-pk-evidence.json`. Cases are recorded only after
their assertions succeed. Failures remain visible and fail the overall gate;
independent diagnostic probes can continue without turning a failure into a pass.

The package matrix exercises the following scenarios. Case IDs are stable labels
for the executable fixtures, not dependencies on an archived coverage catalog:

| Cases | Executable fixture |
| --- | --- |
| PK02 | Exact CB01 plus a workflow-output getter counter at the first body operation; zero reads through serialization and a positive counter control |
| PK05–PK06 | Change the capture initializer, rename the source file, then delete the calls; rebuild the same project and check output and generated inputs |
| PK07–PK09 | LABEL_A/LABEL_B configurations, one net8.0/net9.0 multi-target project with distinct parse/reference inputs, and two projects linking the same physical source |
| PK10 | Two real Compose calls on one source line, returning A and B |
| PK11, PK18 | Pack a CB08 helper library and an SDK-indirect library; consume only the packages with their original source files unavailable |
| PK14 | Missing identifier must report CS0103 at the exact original file/line |
| PK19 | Change a referenced helper signature, require a changed reference hash and CS1503, then correct the caller and rebuild |
| PK20 | Explicit generic SDK action inside named ordinary arguments; counters require exactly one evaluation in lexical C# order and the original typed result |
| PK13 (partial only) | Real MSBuild design-time compile with a missing tool, explicit WFSDK1004 notice, unchanged original inputs and no generated-input duplicates |

Schema-driven APIs are included with ordinary project items:

```xml
<ItemGroup>
  <WorkflowExpressionSchema Include="Schemas\operations.json" />
</ItemGroup>
```

The manifest carries absolute `schemaFiles` paths. The production CLI generates
API/model sources before semantic transformation, so consumers do not author
workflow attributes. `compiled-files.txt` retains the original transformed
inputs first, in source order, followed by generated inputs inside the isolated
output directory. Only declared-schema builds may append these generated files.
Normal builds always regenerate; schema content changes, item removal and
renamed generated classes cannot reuse the prior output directory. Missing
declared files fail with WFSDK1014. Schema items also contribute
`UpToDateCheckInput`; actual IDE fast-up-to-date behavior is not certified here.
Design-time transformation remains deferred, including schema generation; run a
normal build for generated API diagnostics.

The new production-package schema fixture checks generated API and model
metadata, exact runtime output, unchanged schema files, deterministic repeats,
schema-only default changes, API rename, missing files, and removal of schema
items. These scenarios passed through the production packaged CLI.

Additional compilation-context cases cover nullable diagnostics,
checked/unchecked overflow, unsafe permission, language-version rejection and
acceptance, extern aliases, delay/public signing, signed friend-assembly access,
x64, Exe/WinExe/Library, and
selection among two entry points. The independent build-assets runner checks
the complete JSON option shape, reference aliases and EmbedInteropTypes
metadata, default/null signing fields, metadata preservation, missing-tool
errors, duplicate compiler-input rejection, and design-time behavior.
These checks are not real COM interop, IDE, other-platform, or backend execution
certification. No shared SDK/compiler rebuild occurs in either fixture runner.

## Installed language-service follow-up

`Validate-LanguageService.ps1` uses an already installed production Roslyn
language server and the exact package/cache from the package validator. It
copies `LanguageServiceFixture` into a new ignored evidence directory; it does
not install extensions, change user settings, or interact with existing editor
processes. Node.js drives actual LSP requests using `Probe-LanguageService.cjs`.
Pass the installed server DLL explicitly:

```powershell
.\tests\SourcePackageConsumer\Validate-LanguageService.ps1 `
  -PackagePath .\tests\SourcePackageConsumer\obj\package-layout\Microsoft.Azure.Workflows.Sdk.1.0.0-preview.2.nupkg `
  -LanguageServerPath "$env:USERPROFILE\.vscode\extensions\ms-dotnettools.csharp-2.160.4-win32-x64\.roslyn\Microsoft.CodeAnalysis.LanguageServer.dll"
```

The Windows follow-up passed against the server shipped in C# extension
**2.160.4**, using frozen package SHA256 `0E3B667C...`. Before any normal build,
the real server resolved the packaged `Compose(Func<string>)` hover and
`Compose`/`ToUpperInvariant` completions. Valid CB01 had no errors; an unsaved
`missingName` edit produced exactly one CS0103 at the original identifier range,
and reverting it cleared the error. The same checks passed in a second server
session after the package generated real transformed inputs under `obj`.
Neither session invoked the authoring getter or modified the original source.
The separate CLI build/run emitted exact CB01, and the getter positive control
wrote exactly one sentinel entry.

Full LSP transcripts, command arrays/exits, source/server/package/runtime/compiler
hashes, script snapshots, and log hashes are preserved in
`obj\ide-platform-validation\final-language-service\provenance.json` and its
adjacent files. This is **actual installed-language-service evidence**, not
another MSBuild-only check, but it is not VS Code UI, Visual Studio integration,
or all-IDE certification. That standalone-server evidence alone is scoped/partial;
the subsequent actual VS Code check below supplies separate editor evidence.
The original final package evidence is preserved unchanged.

### Actual VS Code window and integrated build

`Validate-VsCode.ps1` and `VsCodeProbe` exercise the real editor extension host,
not a replacement LSP client. The runner requires an explicit package SHA256,
copies existing C# and .NET runtime-acquisition extensions into an artifact-only
`--extensions-dir`, and creates an artifact-only `--user-data-dir`. Updates,
Settings Sync, telemetry, Git integration, and AI features are disabled only in
that isolated profile. Existing user settings, extensions and editor processes
are not changed.

The installed editor was blocked by an existing `vscode-updating` mutex. Rather
than stop the user's updater or bypass its lock, the successful run used the
matching official Microsoft **VS Code 1.137.0 ZIP** in the artifact directory.
Its download SHA256 and executable signature were verified. C# **2.160.4** was
copied from the existing installation; its server used the existing dotnet host.

The actual editor passed CB01 hover, action/string completions, an unsaved
missing-identifier diagnostic at the exact original range, and clearing that
diagnostic on revert. The original file was visible in an editor and remained
unchanged on disk. These checks passed before and after a real
`vscode.tasks.executeTask` integrated-terminal `dotnet build`, without a manual
transformation script. The built app produced exact CB01 with zero getter
execution; a positive control wrote one entry. No duplicate generated-source
errors appeared. VS Code, the build task and both app invocations exited zero.

The successful historical-package run is preserved at
`obj\actual-ide-validation\attempt6\provenance.json`, with actual hover/completion
values, diagnostics, task arguments/exits and output in
`actual-ide-evidence.json`. `obj\actual-ide-validation\pk13-pk17-evidence.json`
maps that scoped historical evidence to the catalog. The same actual-editor
checks were rerun successfully on the new `7F1BC5DE...` package; their current
records are `obj\host-json-fix-validation\actual-ide\provenance.json` and
`actual-ide-evidence.json`. **PK13 is verified for this Windows VS Code
configuration and tested packages**, not Visual Studio or every editor.
PK17 has Windows CLI/editor evidence but still lacks other-platform builds.

Alternate-platform discovery found Docker client **29.1.3** and WSL **2.6.3**,
but no usable Linux build environment. Both Docker engine pipes were absent.
A bounded startup of existing Docker Desktop failed because its backend could
not rename existing `desktop-linux` context metadata (`Access is denied`);
only the processes created by that probe were closed afterward. WSL listed
only the stopped `docker-desktop` distribution, not a separate developer Linux
distribution. No Podman or nerdctl was found on PATH. No tools/distributions
were installed or user settings edited. Availability commands, exits and the
backend error are preserved under `obj\ide-platform-validation`. **PK17 remains
unverified for other platforms**; the unavailable environment is not a pass or
a narrower support declaration.

## Dependency requirements and publish gates

Each successful transformation must emit `expression-dependencies.json`. Missing
reports fail with WFSDK1009; they are never replaced with an empty success
document. Build output receives the opaque report as
`<assembly-name>.workflow-expressions.json`. Library packages include that
sidecar next to the matching DLL under `lib/<tfm>/`. Consumers discover sidecars
beside their actual resolved copy-local DLLs, including transitive library
dependencies, and copy them to build/publish output. This does not rely on
transitive NuGet `contentFiles` behavior.

After publish, `ValidateWorkflowExpressionDeployment` searches the resolved
publish directory recursively for `workflow.json`. When present, it requires
the current assembly sidecar in both build and publish output, then calls:

```text
dotnet <packaged-tool.dll> validate-deployment <publish-directory> <publish-directory> [host-profile.json]
```

The first directory argument merges all `*.workflow-expressions.json` sidecars.
`WorkflowExpressionHostProfile` supplies the optional profile path, resolved
against the caller project. Profiles pass through unchanged to the compiler
CLI; missing files and nonzero WFDEP diagnostics fail publication. No authoring
application or dependency assembly is executed by this MSBuild target. Projects
whose custom targets produce workflows during publication should append those
target names to `WorkflowExpressionPublishValidationDependsOn`, ensuring their
artifacts exist before the scan.

No workflows means **WFSDK1008: not validated**, not deployment success or host
certification. Successful artifact checks emit WFSDK1013 and still do not
certify an execution backend. An absent profile does not approve custom
dependencies, native expressions, or unverified transport/Condition capabilities.

The documented version-1 profile fields are `version`, `host`, `evidence`,
`literalMarkerEscapingVerified`, `nativeExpressionsVerified`,
`nativeConditionsVerified`, `languageVersion`, `namespaceImports`,
and `approvedDependencies` entries containing `assembly` and a 64-hex `sha256`.
Approvals must describe the actual deployment host and binary; a locally
calculated hash alone is not evidence of host compatibility. The CLI's
capability requirements remain authoritative; the targets do not manufacture
approval flags or downgrade its diagnostics.

The expanded matrix also checks real NuGet sidecar entries and transitive
copies, codeless publish validation, profile forwarding, invalid aggregate
sidecars, missing/unapproved/hash-mismatched custom DLLs, marker/Condition/syntax
rejections, ordinary native-expression rejection (WFDEP009) with no profile or
an explicitly false capability, missing custom-extension namespace imports
(WFDEP008), and explicit no-workflow behavior. No fixture
enables native host capabilities or claims backend certification. An execution sentinel with a
positive control checks that publication never launches the authoring app.
These integrated cases passed. Native capability tests verify rejection, not
execution-host support.

## Build contract and limitations

The tool receives the JSON manifest path and output directory. The manifest
contains the actual ordered, deduplicated Compile and resolved reference paths, defines,
language version, nullable/checked/unsafe settings, output kind, platform,
startup object and assembly name. Resolved reference aliases and
EmbedInteropTypes metadata are carried in `referenceAliases` and
`embedInteropReferences`; those fields use absolute reference paths.
It also carries signing identity: `signAssembly`, `delaySign`, `publicSign`,
the absolute `keyFile` resolved from KeyOriginatorFile/AssemblyOriginatorKeyFile,
and `keyContainer` (empty key/container values serialize as JSON null). The
compiler must use that identity for semantic friend-
assembly checks; it must not analyze signed projects as unsigned assemblies.
`compiled-files.txt` must start with exactly one absolute replacement path for
each original source, in the same order. Declared schema builds may append
generated C# paths within the tool output directory; other builds retain the
exact-count contract. Original Compile metadata is retained on replacement items.
The main SDK project does not import these consumer targets or transform itself.
The repository Tests, Tests.Worker, UnitTests, ExpressionTests and
CSharpExpressionTests fixtures receive the same targets
through the root `Directory.Build.targets`; additional project-reference fixtures
can set `WorkflowRepositoryConsumer=true`. The compiler path is discovered from its
project output rather than hard-coded. The migrated ExpressionTests and
CSharpExpressionTests projects exercise source-compiled SDK authoring rather than
linking retired expression-tree converters. The SourceExpressionTests
compiler/runtime-contract harness remains untransformed because it invokes the
compiler explicitly and tests missing-transform behavior.
The consumer assertion accepts either the C# `string` alias or
`global::System.String` in the generated ToObject type argument; all other output
text is compared exactly.

The ten retired expression-tree implementation files and their test-only source
links have been deleted. Applicable tests are migrated to source-compiled authoring;
obsolete lowering assertions are removed. The package consumer still reflects
over the shipped SDK to prevent reintroducing legacy converters or expression-node types.
Transformation always regenerates from original Compile items before CoreCompile.
The dedicated intermediate directory is cleared before each invocation. This is
deliberately conservative, not an incremental-performance claim: changed source,
references, options and tool versions are rebound every time. Original Compile
items are restored afterward, preventing subsequent invocations from consuming
previously transformed input. Configuration and target framework directories are
isolated, including projects overriding IntermediateOutputPath.

Generator ordering is **not solved**. The target inspects third-party analyzer PE
type-reference metadata without loading or executing those assemblies. Ordinary
analyzer-only assemblies are allowed; references to Roslyn GeneratorAttribute,
ISourceGenerator or IIncrementalGenerator are rejected with WFSDK1002 rather than
silently leaving generated workflow calls untransformed. This is conservative:
an analyzer that references generator APIs without implementing a generator is
also rejected. Unreadable analyzer metadata fails explicitly. Only named SDK platform analyzers/generators from the active SDK or targeting-pack
roots and the SDK's transitive Microsoft.Extensions.Logging.Abstractions 6.0.0
logging generator are allowed; these generators do not emit workflow authoring
calls. The logging exception checks assembly name, package ID, and package version.
Move workflow authoring to a library without unsupported source generators as a
workaround. Aliased references are forwarded to the compiler rather than
discarded; the expanded integration fixture exercises an extern-alias-only
project reference.

Design-time builds intentionally retain original source and delegate-based APIs
and emit WFSDK1004 explaining that source-only rewrites and their diagnostics
require a normal build. This is not full IDE diagnostic parity. The executable
MSBuild check does not certify IntelliSense inside an actual IDE. Missing tool
files on a normal build fail with WFSDK1001. Setting
`WorkflowSourceTransformEnabled=false` deliberately disables transformation;
untransformed runtime authoring entry points must fail rather than execute lambdas.

## Acceptance coverage

| Cases | Evidence / remaining gate |
| --- | --- |
| PK01, PK03, PK04 | Final isolated Release consumer run passed on Windows/.NET SDK 9.0.318; exact tested package/DLL hashes and command exits are in `obj/host-json-fix-validation/final-validation-provenance.json` |
| PK02 | Exact CB01 output and zero first-operation output reads through serialization passed; counter positive control passed |
| PK05–PK09 | Capture mutation, source rename/removal, defines, net8.0/net9.0 multi-targeting, and linked-source builds passed |
| PK10 | Same-line A/B actions produced distinct correct inputs |
| PK11 | Packaged CB08 helper worked without access to its original source |
| PK12 | Real generated-workflow fixture rejected with WFSDK1002; arbitrary-generator positive support remains unverified. Ordinary xUnit analyzer accepted |
| PK13 | Current package passed actual isolated VS Code 1.137.0 / C# 2.160.4 completion, hover, original-source diagnostics, no-execution checks and integrated build; Visual Studio/other editor configurations are not certified |
| PK14 | Missing identifier produced CS0103 at the exact original file/line |
| PK15–PK16 | Separate compiler/runtime diagnostic evidence required; missing packaged tool explicitly rejected |
| PK17 | Windows dotnet and actual VS Code passed on the current package; Docker startup blocked by context-metadata access denial, WSL has only stopped docker-desktop, and other platforms/IDE hosts remain unverified |
| PK18 | Library with only an indirect SDK package reference transformed, packed and executed correctly |
| PK19 | Changed helper signature invalidated the reference hash, failed the old caller, and accepted the corrected caller |
| PK20 | Explicit generic action preserved typed result and exactly-once lexical argument-counter order |

`obj/host-json-fix-validation/final-pk-evidence.json` maps every PK case to the final
external evidence or its precise gap; it does not replace independent xUnit
evidence. Without `-SkipExistingSamples`, the full validation script exits
nonzero at the known ParallelBranch sample failure. The final bounded gate uses
that switch and separately builds the original repository Worker. Both final
gates exit zero. Exact packaged runtime/compiler hashes match the frozen shared
binaries before and after validation. `final-validation-provenance.json` records
the package hash, timestamps, commands, exit codes and log hashes.
`expanded` preserves the expanded case evidence, 97 command logs, scripts
and fixture sources. Earlier Enum, D06, typed-ForEach, `0E3B667C...`, and failed
integration attempts remain separate historical snapshots; their results are
not relabeled.

## Verified Functions Worker generator contract

Worker SDK **1.17.1** resolves Worker SDK Generators **1.2.1**, whose NuGet
repository commit is
[`084df40fb53fef3eb6bd2cbc5f1ab2ab624d1adb`](https://github.com/Azure/azure-functions-dotnet-worker/tree/084df40fb53fef3eb6bd2cbc5f1ab2ab624d1adb/sdk/Sdk.Generators).
The exception checks package ID, exact version, assembly filename, and SHA256
`C5C2999D6F46E92E59CB5DFE635446D1DFDEAAF55F721F3A797B43FD547206EF`.
It is not a filename-only allowance.

The source at that commit was inspected:

- `FunctionMethodSyntaxReceiver.OnVisitSyntaxNode` selects attributed method
  declarations; it does not copy or regenerate method bodies.
- `FunctionMetadataProviderGenerator.Execute` and its emitter construct function
  metadata and registration from function/binding attributes and symbols.
- `FunctionExecutorGenerator.Parser.GetFunctions` reads method signatures;
  `Emitter.EmitFastPath` emits dispatch calls to existing function methods,
  not the workflow lambdas in their bodies.
- `ExtensionStartupRunnerGenerator` reads extension startup assembly attributes
  and emits registration calls.

Those generators remain in `@(Analyzer)` and run only in the ordinary Csc
invocation **after** workflow source transformation. The workflow tool does not
load them, run a generator prepass, or execute generators a second time. Source
that depends on generator-produced symbols before transformation remains outside
this contract. New Worker versions require renewed source/output verification.

The repository Worker's ASP.NET reference pack **8.0.31** also contributes logging
and options-validation generators. Those two exact binaries are fingerprint-bound
in the target. They generate implementations from
[LoggerMessage](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging/source-generation)
and [options-validation](https://learn.microsoft.com/en-us/dotnet/core/extensions/options-validation-generator)
metadata, not workflow value lambdas. Other versions are not silently permitted.
Arbitrary workflow-emitting generators still fail with WFSDK1002.

Validation evidence:

- The package-only `WorkerConsumer` builds successfully with normal Worker
  metadata/executor generation enabled, emits one metadata-provider and one
  executor file, produces `functions.metadata` for `WorkflowProbe`, and directly
  runs that function to verify its workflow lambda was transformed.
- The generated executor dispatches to `WorkflowProbe.Run`; generated files
  contain no workflow authoring or source-descriptor calls.
- The original repository `Microsoft.Azure.Workflows.Sdk.Tests.Worker` also builds
  successfully with the final packaged compiler/runtime snapshot: zero warnings/errors, transformation and
  generators enabled. Project references were already built; the validation
  command used `BuildProjectReferences=false` and `GeneratePackageOnBuild=false`
  to avoid rebuilding shared SDK/compiler outputs, and an empty
  `LogicAppFolderToPublish` to avoid the deployment-copy side effect.
  Initial source-compiler failures on generated getter paths and instance syntax
  were resolved in the compiler before the successful final rerun. No old
  examples were edited or excluded to conceal those failures.

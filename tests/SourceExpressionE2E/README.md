# Source-expression workflow end-to-end regression

These are SDK-authored `.cs` workflows registered with an actual local Logic Apps
runtime. They are not evaluations using mock `outputs()` helpers. The same source
files build against the repository SDK or a separately supplied comparison SDK
and source generator.

`case-coverage.json` maps the failed-comparison IDs to workflow scenarios or
negative compilation/authoring contracts. Read its coverage level: representative
coverage is not proof for every input of the original parameterized test.
Some tests intentionally cannot produce a valid executable workflow.

Custom-type declaration extraction, bundle provisioning, and runtime activation
have been removed. The 19 custom-type scenarios and their original expectations
remain as regression coverage; their former successful runs do not describe the
current runtime's capabilities. The ordinary C# engine, nested JSON cases, and
Response error-reporting regressions remain in place. The standard version-1
expression-dependency sidecar is still used; it does not embed custom declarations.

`Workflows\NestedJsonComposeCases.cs` adds six nested-order regressions: captured,
inline-parsed, and inline-initialized objects, each exposed as `JObject` and
`JToken`. They verify downstream object fields, array indexes, a runtime-selected
index, multi-hop Compose outputs, numeric conversions/addition, and a Response
containing both the original payload and projected values. Captured cases mutate
the original object after action construction to check deep snapshot isolation.
These cases require no application-defined model or declaration bundle.
Captured payloads remain literal JSON. All runtime expressions now use
`#{...}`, including forwarding, string-key navigation, interpolation, and
Response body references. Pass-through JSON uses raw runtime helpers without
materializing application or generated model types. Inline parsing/construction,
numeric indexing, and typed arithmetic also remain C#. Every exported workflow
is checked for forbidden standalone template expressions and interpolation.
The native envelope is now `#{...}`; it is not backward-compatible with hosts
expecting `@csharp{...}`. Five additional cases preserve old-envelope literals,
double hashes, embedded hash/template markers, and directive-looking C# strings.
Literal `#{...}` text is returned through a C# string expression; `##` is not an
escape sequence.

## Requirements

- Windows, PowerShell 7, the repository's .NET SDK, and .NET 8 runtime.
- An isolated local Logic Apps runtime supporting inline C# expressions.
  Public bundles that lack that capability cannot provide this comparison.
- Core Tools and Azurite, installed outside the repository.
- A separately prepared host directory per SDK, with runtime extensions under
  `bin`, a `host.json` using those local extensions, and `local.settings.json`
  pointing explicitly to loopback Azurite blob, queue, and table endpoints.

Never commit runtime bundles, credentials, generated host settings, or run history.
The harness rejects cloud storage and external connector/action execution. It
permits core local actions, a single HTTP request trigger, and the nine reviewed
in-memory seed callbacks listed under `customCodeSeedSafety` in the manifest.
Six additional service-provider workflows use only isolated local Azurite through
the dedicated runner below. Managed-connector definition contracts remain
authoring-time checks, not requests to live services.
This guard is not a C# sandbox; new expressions and callbacks still require review.

## Build the repository variant

Build the repository SDK/compiler first using the normal repository build. Then:

```powershell
dotnet build .\tests\SourceExpressionE2E\SourceExpressionE2E.csproj `
  -p:BuildProjectReferences=false -p:GeneratePackageOnBuild=false

dotnet run --project .\tests\SourceExpressionE2E\SourceExpressionE2E.csproj `
  --no-build -- --self-test

dotnet run --project .\tests\SourceExpressionE2E\SourceExpressionE2E.csproj `
  --no-build -- --export C:\e2e\ours-export
```

Copy the entire worker output to a separate immutable staging directory before
building another variant. Obtain its path rather than assuming a layout:

```powershell
dotnet msbuild .\tests\SourceExpressionE2E\SourceExpressionE2E.csproj -getProperty:TargetDir
```

The export records generation failures explicitly and returns nonzero when
generation violates an expected contract. A rejected factory is not a successful
workflow run. Other successfully generated cases remain available for execution.

## Build a comparison variant

Supply its already-built SDK and generator; no comparison product code is patched.
Restore with the same properties before building because the dependency graph
differs from the repository variant.

```powershell
$properties = @(
  '-p:ComparisonSdkAssembly=C:\comparison\Microsoft.Azure.Workflows.Sdk.dll',
  '-p:ComparisonGeneratorAssembly=C:\comparison\Microsoft.Azure.Workflows.Sdk.Generators.dll'
)
dotnet restore .\tests\SourceExpressionE2E\SourceExpressionE2E.csproj @properties
dotnet build .\tests\SourceExpressionE2E\SourceExpressionE2E.csproj `
  --no-restore @properties -p:GeneratePackageOnBuild=false
```

Stage this output separately as well. Use the same runtime binaries, workflow
sources, input cases, and expectations for both variants. Do not replace a rejected
native expression with a corrected one and attribute it to the original SDK.

### SDKs that reject individual workflow sources

Some SDK generators reject non-inline expression arguments at compilation. Do not
suppress those diagnostics to make the combined worker build. The three isolated
factories are listed under `isolatedCompileCases` in the manifest. After restoring
the comparison variant, reproduce each rejection with its unchanged source:

```powershell
.\tests\SourceExpressionE2E\Test-IsolatedCases.ps1 `
  -OutputDirectory C:\e2e\compile-isolated `
  -BaselineGenerationManifest C:\e2e\ours-export\generation-results.json `
  -ComparisonSdkAssembly C:\comparison\Microsoft.Azure.Workflows.Sdk.dll `
  -ComparisonGeneratorAssembly C:\comparison\Microsoft.Azure.Workflows.Sdk.Generators.dll
```

The script requires a source-specific diagnostic in each actual build log. It
prints an `E2EExcludedSources` build property: use that property for the subsequent
comparison worker build, excluding only the separately rejected files. Pass its
`compile-rejections.json` to `Run-Local.ps1 -CompileRejectionsPath`. Those cases
remain in the comparison as **CompileRejected**, not executed or passed. Without
the evidence import, the final comparison rejects the unequal case sets.

## Run on the actual host

Start loopback-only Azurite separately. `Run-Local.ps1` owns only the host process it
starts; it never stops an existing listener or takes ownership of your emulator.
Use a new results directory for each invocation.

```powershell
.\tests\SourceExpressionE2E\Run-Local.ps1 `
  -FuncPath C:\tools\func.exe `
  -HostDirectory C:\e2e\host-ours `
  -WorkerDirectory C:\e2e\worker-ours `
  -ResultsDirectory C:\e2e\runs\ours-001 `
  -Port 18571
```

Repeat for the comparison worker/host. `-CaseIds` selects a subset. Normal mode
fails if any expected generation/runtime result is violated. `-RecordOnly` is
available for exploratory differential runs: it retains every failure, but does
not turn those failures into passes.

The probe waits for host readiness, host-lock acquisition, and a real successful
readiness workflow before running the selected cases. It records:

- Definition-generation and registration rejections.
- HTTP status/body, run status/ID, and per-action input/output content and errors.
- Run/action timestamps and request duration (not a controlled benchmark).
- Worker/SDK/runtime binary and source fingerprints.

Signed callback and history URLs stay in memory, not in the result artifact.
`Run-Local.ps1` restores the host settings and terminates its own process tree.

## Azure Blob and Azure Queues service providers

`Workflows\ServiceProviderCases.cs` adds six actual service-provider round trips,
not managed-connector calls or mock evaluations. Export includes all 162 workflows.
Ordinary `Run-Local.ps1` runs exclude these six unless explicitly enabled by the
dedicated runner; the original 151 non-provider cases remain, plus five syntax
and literal-preservation regressions.

| Cases | Operations and runtime contract |
| --- | --- |
| `ServiceProviderBlobLiteral`, `ServiceProviderBlobTemplate`, `ServiceProviderBlobNative` | Upload text, read it back, return the exact content, delete the blob, and verify `blobExists` returns false. |
| `ServiceProviderQueueLiteral`, `ServiceProviderQueueTemplate`, `ServiceProviderQueueNative` | Create a queue, send text, receive exactly one message, capture its content, delete it using its returned ID and pop receipt, verify a subsequent read is empty, and return the exact content. |

Each provider has a literal payload, a direct Compose-output reference, and a
`ToUpperInvariant()` payload. Generation checks require the literal to stay
literal, the direct reference to be `#{outputs("Source")}`, and the method
call to use `#{outputs("Source").ToObject<string>().ToUpperInvariant()}`.
The `Template` case IDs are retained for historical comparisons; they now exercise
C# references, not template expressions. Blob read-content navigation is
`#{body("Read")["content"]}`. Queue foreach collections use
`#{body("Read")}` and item conversions remain native C#.
There are two C# expressions in BlobLiteral, three in BlobTemplate/BlobNative,
six in QueueLiteral, and seven in QueueTemplate/QueueNative.
No generated CLR model deployment is required for these pass-through paths.

The former `@csharp{...}` run satisfied 133 of 157 contracts. Queue cases exposed
missing Foreach dependency discovery: `body("Read")` could not access the preceding
action. Keep that historical evidence separate from current runtime results.

With `#{...}` and the rebuilt Andrew-based runtime (base
`4a67469c61ed5c6386ee3167843eeb69a5b0c2f4` plus the local Foreach/Repeat and Response
diagnostic fixes), all six provider cases pass on the isolated Core Tools host.
The full run satisfies 142 of 162 contracts: the 19 unavailable custom-type cases
and `NativeUri` remain failing. All previously passing cases still pass;
`NativeUriFallbackResponse` now meets its recovery contract, and all five new
literal/syntax cases pass. A strict 19-case representative run also passes.
Queue metadata verifies zero remaining messages, cleanup deletes all six resources,
and the owned host/emulator processes are stopped. No template fallback,
custom-type deployment, or URI normalization is used.

The subsequent simplified runtime removes the redundant Foreach/Repeat expression
filter while retaining C# dependency registration. Its rebuilt payload passes the
same strict 19-case host run, including all six providers and URI fallback recovery.
That run preserves the user's revised `InvalidResponseBody` diagnostic wording
(`can not`). The 142/162 full-run result above belongs to the earlier payload;
the complete catalog was not rerun for this simplification.

The prepared host must include the Azure Blob and Azure Queue provider extensions
as well as the native-C# engine. Pass the Azurite JavaScript entry point, not its
Windows command shim:

```powershell
.\tests\SourceExpressionE2E\Run-ServiceProviders.ps1 `
  -FuncPath C:\tools\func.exe `
  -AzuritePath C:\tools\node_modules\azurite\dist\src\azurite.js `
  -HostDirectory C:\e2e\host-ours `
  -WorkerDirectory C:\e2e\worker-ours `
  -ResultsDirectory C:\e2e\runs\providers-001
```

Use a nonexistent results directory outside the repository. The runner starts its
own Azurite process with fresh storage, binds only to `127.0.0.1`, and refuses
occupied ports. Defaults are host 18571, Blob 18581, Queue 18582, Table 18583;
each has a corresponding `-Port`, `-BlobPort`, `-QueuePort`, or `-TablePort` option.
Do not start another emulator on those ports first.
`-AdditionalCaseIds` runs other catalog cases alongside the six provider cases
on the same isolated host, useful for checking expression migrations.

The runner temporarily installs `e2eAzureBlob` and `e2eAzureQueues` connections
using `@appsetting('AzureWebJobsStorage')`. Only the development account with
explicit loopback endpoints is permitted. Resource names have a fresh
`sdke2e-<run-id>` prefix, and definition validation restricts each action to its
reviewed provider, operation, connection, and exact resource.
Containers are provisioned by the runner; queues are created by the workflows.

`results.json` requires the exact response, successful persisted action history
(including queue Capture/Delete), and deletion-check outputs. `queue-counts.json`
independently verifies zero messages, including invisible messages, before cleanup;
an empty receive alone would not prove deletion during the visibility timeout.
`resource-cleanup.json` records container/queue deletion. The runner restores
settings and connections byte-for-byte and stops only its owned host/emulator.
Azurite data and execution evidence remain under the results directory, never in
the repository. Normal mode fails unmet contracts; `-RecordOnly` retains failures
for investigation but does not suppress provisioning or cleanup errors.

`--self-test` includes negative checks for unapproved connections, operations,
resources, missing/failed actions, and undeleted data. Every export also checks
provider payload expression shapes and native-expression counts.

## Compare and retain evidence

Use a built worker to compare both result files:

```powershell
dotnet C:\e2e\worker-ours\SourceExpressionE2E.dll --compare `
  C:\e2e\runs\ours-001\results.json `
  C:\e2e\runs\comparison-001\results.json `
  C:\e2e\runs\comparison.json

.\tests\SourceExpressionE2E\Write-Report.ps1 `
  -ComparisonPath C:\e2e\runs\comparison.json `
  -OursCompileResults C:\e2e\compile-ours\compile-results.json `
  -ComparisonCompileResults C:\e2e\compile-comparison\compile-results.json `
  -OutputPath C:\e2e\runs\comparison.md
```

Comparison requires matching case IDs and backend fingerprints. Equal HTTP bodies
are checked against the Response action's persisted inputs and outputs as well.
JSON object ordering and equivalent numeric spellings are ignored only for
JSON-valued responses; strings, whitespace, and JSON string-versus-number types
remain distinct. Original wire text is retained in the evidence.
Clock scenarios use a UTC time-window contract instead of claiming that two
sequential `DateTime.UtcNow` calls should return the same value.
Intentional runtime-failure cases require the expected HTTP/run status and a
matching persisted action error, rather than comparing request-specific tracking
IDs in a `NoResponse` body.
Both-failed cases are never labeled runtime-equivalent. Coverage mappings retain
whether each scenario is exact, representative, an authoring contract, or blocked.

Negative source files under `CompileCases` use `.cs.txt` so they do not break
normal builds. Compile one in isolation using `-p:E2ECompileCase=<absolute-path>`;
its required diagnostic is described in the coverage manifest. `E2EFrameworkOnly`
builds just the harness for its classifier self-tests, not workflow regression.

```powershell
.\tests\SourceExpressionE2E\Test-CompileCases.ps1 -OutputDirectory C:\e2e\compile-ours
```

Local execution does not certify cloud deployment, designer behavior, custom
runtime dependencies, or production performance. Unexpected failures remain
regressions/capability gaps to investigate; do not weaken expected values to make
the suite green.

### Verify Response error diagnostics separately from URI support

**F138 / `NativeUri` is a known failing end-to-end case, not a fixed scenario.**
URI construction and local JSON serialization succeed, but returning the URI as
the entire Response body fails. On the diagnostic-patched host, the caller gets
HTTP 502 / `InvalidResponseBody`; Source and Result succeed and Response fails.
`System.Uri` is a framework type, so this is independent of the removed
custom-type support. No automatic `ToString()` fallback is implemented.

`NativeUri` retains its original workflow and success expectation. A runtime
diagnostic fix must not be reported as URI normalization or a newly successful
workflow. `Test-ResponseErrorDiagnostics.ps1` checks the narrower error-reporting
contract against before/after actual-host evidence:

- The same `NativeUri` definition still fails, with Source and Result unchanged.
- Response history records action code `BadRequest`, error code
  `InvalidResponseBody`, and the exact safe message.
- The caller receives HTTP 502 with that specific error code/message, rather than
  opaque `NoResponse`. No exception details or body contents are forwarded.
- The selected supported-body controls retain their results, and unrelated
  failure controls retain their caller error codes.

`Workflows\ResponseBodyCases.cs` adds four successful controls: explicit
`result.Output.ToString()`, a token created from that string, and a URI nested in
an object or array body. These distinguish the failing scalar body conversion
from existing JSON container serialization. They do not change `NativeUri`.
The additional `NativeUriFallbackResponse` case executes a valid Response after
the invalid Response fails. Its `HandledResponseFailure` contract requires exactly
the named diagnostic failure, a successful final Response with body `recovered`,
and no other failed actions. This checks that error reporting does not prematurely
answer the caller or override a workflow's own recovery Response.

The host must include the corresponding native-runtime diagnostic changes.
Use the same worker and case selection for both runs, including at least one
successful supported-body control. Run `Run-Local.ps1` with `-RecordOnly` to retain
the original failing URI success contract, then execute this independent oracle:

```powershell
# Pass -CaseIds $caseIds to each before/after Run-Local.ps1 invocation.
$caseIds = @(
  'NativeUri', 'NativeUriExplicitString', 'NativeUriStringToken',
  'NativeUriObjectBody', 'NativeUriArrayBody', 'InvalidValueConversion'
)

.\tests\SourceExpressionE2E\Test-ResponseErrorDiagnostics.ps1 -SelfTest

.\tests\SourceExpressionE2E\Test-ResponseErrorDiagnostics.ps1 `
  -BaselineResultsPath C:\e2e\runs\before\results.json `
  -ResultsPath C:\e2e\runs\after\results.json `
  -ExpectedErrorCode InvalidResponseBody `
  -ExpectedErrorMessage "The response body contains a value that can't be converted to supported response content. Update the response body to use a supported value."
```

Run `-CaseIds NativeUriFallbackResponse` separately on the patched host in normal
mode. Unlike the paired controls above, its specific diagnostic contract requires
the new runtime behavior and is not expected to pass on the baseline host.

The exact message above is the English diagnostic. HTTP 502 continues to describe
a workflow that failed to deliver its response; it does not classify the incoming
request as malformed. Passing this oracle establishes error visibility, not
support for a raw URI response body.

## Known runtime limitations

The 19 custom-type scenarios require types that are not provisioned for the
native compiler, and F138 / `NativeUri` fails at the scalar Response-body
boundary. The fixtures retain their intended expectations rather than treating
these capability gaps as passes.

Historical comparison reports, frozen host/package observations, and the review
exporter for the removed declaration-bundle prototype are not test inputs. Keep
them outside the repository; use fresh results from the commands above to assess
the current SDK and runtime.

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
Captured payloads remain literal JSON and string-key navigation remains template
expressions. The current compiler retains inline parsing/construction, numeric
indexing, and typed arithmetic as native C#; the regressions exercise those
expressions rather than assuming every JSON accessor lowers to a template.

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
in-memory seed callbacks listed under `customCodeSeedSafety` in the manifest. Connector-definition
contracts must be inspected at authoring time, not sent to live services.
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

### Export a source-linked review package

```powershell
.\tests\SourceExpressionE2E\Write-ReviewPackage.ps1 `
  -ResultsDirectory C:\e2e\runs\ours-001 `
  -OutputDirectory C:\e2e\review-001

```

The default selection is the 19 custom-type scenarios. Optional `-CaseIds`,
`-BaselineResultsDirectory`, and `-DeclarationManifestPath` select other cases,
add independent baseline evidence, or include a previously frozen historical
declaration manifest. Current SDK builds no longer generate declaration bundles.
The optional historical reader does not compile declarations or activate a host.
The output must not exist. Run from the exact source snapshot recorded in each
run's `source-fingerprints.json`: missing/mismatched source or definition hashes
are rejected rather than silently exporting today's source or regenerating JSON.

Open `report.md` for linked and expanded original C# files, declarations/seed
callbacks, exact generated definitions, full observations, and per-action raw
inputs/outputs. `package-manifest.json` inventories file hashes. Original JSON
files are preserved; pretty JSON is display-only. Historical manifests with
SDK v2 `declarationBundles` are autodetected: embedded `.cs` content hashes and
bundle IDs are verified using the former `WorkflowDeclarationBundle.ComputeId` canonical
System.Text.Json serialization. Simple filenames only are extracted under
`declarations\<bundleId>\`; the report includes compiler settings, types, reference
identities/aliases/interop flags, and the exact outer manifest hash.
A supplied SDK manifest is bound to the current run's `manifestSha256` when
`implementation-provenance.json` exists; mismatches are rejected. That provenance
is copied exactly and expanded with its recorded runtime fingerprints and
private-reflection hooks. Without it, the manifest remains supplemental;
historical prototype hashes cannot authenticate an SDK manifest.
Credential-free `host-profile.json` is included as supplemental metadata only.
Neither profile capabilities nor recorded startup claims are independent
production certification. Local-path `declaration-binding.json`, private runtime
backups, and referenced paths are not copied or followed.
Historical `Sources: [{ File, Sha256 }]` manifests still include hash-verified
`.cs` files. References remain metadata-only; no DLLs are loaded or packaged.
Unrecognized manifest formats are retained as metadata only.
Baseline SDK/runtime, exporter, and README changes do not require matching hashes;
the original copied workflow/harness inputs must still match the recorded sources.
Contracts met and successful runs are counted separately: NullableEnumFailure
and TypedBodyLinqInvalid intentionally expect failures. No host is started, ZIP
created, or binaries/logs/private host settings collected. Review recorded bodies before
sharing; this is an unredacted review collection, not a standalone build.

## Recorded comparison baseline

The initial full comparison used repository commit
`58e8c0f5e219709bec2d337a214166995fbb9397`, PR #51 SDK/generator commit
`7e3fd9cd3c2f453557353f29da298113952fe20d`, and local native runtime
`1.187.0.10`. The 140 scenarios include 112 runtime-expression scenarios and 28
authoring-contract proofs; two negative compiler fixtures are additional.

Expected contracts were satisfied in 120 repository scenarios and 22 comparison
scenarios. Among runtime-expression scenarios, 20 had matching Response values,
6 returned different values despite both runs succeeding, 60 had different
execution outcomes, 24 remained failed/blocked on both sides, one satisfied the
same expected failure contract, and one satisfied the clock-window contract.

This is **not an all-green baseline**. The repository variant has 19 native
compilation blockers involving custom types unavailable to this host's C#
compiler, plus one URI-valued Response serialization failure. The fixtures retain
their intended expectations rather than treating these capability gaps as passes.

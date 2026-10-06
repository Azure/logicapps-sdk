# Local SDK, Logic Apps Bundle, and VS Code candidate

`New-ExtensionCandidate.ps1` prepares a hash-pinned handoff for the Logic Apps
extension. It never writes the user's installed bundle or SDK cache, deletes an
existing output directory, or publishes packages. Every run requires a new output
directory. The manifest contains absolute paths; rerun preparation if moving a
candidate to another machine.

An installed candidate root is sealed to its manifest. To test a revised SDK,
prepare a new package version and manifest in a new root rather than replacing
the previous package or editing its receipt. Use a separate copy of the test
project with the matching SDK reference and package source; preserve the original
workspace and let the user choose when to switch.

Prerequisites are PowerShell 7, this repository's .NET SDK plus the .NET 9 runtime,
and the Logic Apps Bundle/LogicAppsUX candidate scripts described below. A candidate SDK is the
**entire nupkg**, not its runtime DLL: preserve `buildTransitive` and
`tools/workflow-build`. The LSP server is a separate application; the nupkg does
not replace it.

## Agent entry point: three-repository testing

This is the central runbook for testing SDK, Logic Apps Bundle, and LogicAppsUX
changes together. The repository-specific guides below own their build details;
this guide owns the handoff and acceptance contract. A repository path alone
does not install prerequisites, authenticate package feeds, select a compatible
runtime revision, or prove that the companion scripts exist.

| Repository | Responsibility | Guide and executable entry point |
| --- | --- | --- |
| SDK (this checkout) | Compiler, descriptors, complete SDK nupkg, pair manifest, expression regressions | This guide; `tests\ExtensionE2E\New-ExtensionCandidate.ps1`; `tests\SourceExpressionE2E\README.md` |
| Logic Apps Bundle | Genuine runtime ZIP, workers, runtime reference approval, producer provenance | `tools\devtools\be-functions-runtime\README.md`; `scripts\Build-CandidateWorkflowBundle.ps1` beneath that directory |
| LogicAppsUX | Built extension/webview, private installation, SDK/LSP selection, candidate task/host staging, designer metadata | `apps\vs-code-designer\scripts\run-candidate-e2e.md`; adjacent `run-candidate-e2e.js` |

Use the user-supplied checkout paths. Check out the intended revisions using the
user's normal repository workflow; these scripts do not obtain or switch them.
Unmerged companion changes may be required. Do not infer runtime capabilities
from branch names, a public bundle version, or the presence of a C# action.
Record each checkout's HEAD and relevant working-tree changes when producing
artifacts. An imported archive's source provenance must come from its producer.

### Inputs and bootstrap

Before building, establish:

- SDK, Logic Apps Bundle, and LogicAppsUX checkout paths.
- A fresh output parent outside the repositories, with no whitespace when
  building the Logic Apps Bundle; distinct paths for each build and test run.
- A unique prerelease SDK version and the intended bundle version.
- Full paths to VS Code, dotnet, Core Tools, and any required Node executable.
  The VS Code distribution must not be in the middle of a shared update.
- The read-only extension/dependency source and any prepared package feed
  required by the UX runner. A NuGet feed is not the complete LSP payload.
- The intended test scope: offline pickup, a user-owned local project,
  isolated local runtime regressions, or an explicitly authorized managed
  connector test. These scopes have different authentication requirements.

Start in PowerShell 7. For source-building the bundle, use Visual Studio's x64
Developer PowerShell so native and full MSBuild tools share the same process
environment. Probe the environment before installation or restore:

```powershell
$PSVersionTable.PSVersion
Get-Command dotnet, node, msbuild.exe, javac.exe, mvn.cmd
dotnet --info
dotnet --list-sdks
dotnet --list-runtimes
node --version
javac -version
mvn.cmd --version
```

In the SDK checkout, `global.json` currently requests SDK `9.0.307` with
`latestFeature` roll-forward; inspect the file at the revision being tested.
The packaged compiler requires the .NET 9 runtime. A candidate in-process .NET 8
host additionally requires .NET 8; its framework/worker configuration is owned
by the selected runtime, not by the compiler's target framework.
The current Logic Apps Bundle checkout instead selects a .NET 10 SDK through
its own `global.json` and documents a Visual Studio 18 x64 Developer Shell plus
.NET Framework targeting packs. Check that checkout's current requirements:
installing only the SDK repository's .NET 9 tooling is not sufficient to build
the bundle. Resolve the installed Visual Studio edition/path rather than copying
another machine's Developer Shell path. Check `dotnet --version` from each
repository directory, not only from the directory where the agent started.

Follow the bundle guide for Visual Studio components, Java/Maven configuration,
the actual JavaScript worker restore command, and authenticated package-feed
access. Follow the UX guide and its manifests for the supported Node/pnpm
versions, dependency installation, extension build, and webview packaging.
Do not guess private feed URLs, copy another user's credentials, or permanently
change global authentication/tool settings to satisfy a local probe.
Install/restore only when required dependencies are missing or manifests change.
Keep feed authentication interactive or in the organization's approved mechanism;
never write tokens into a candidate manifest, command log, or repository.
The bundle's candidate-build-only path does not require a running host,
KeyVault secret resolution, or the full-host agent-loop configuration.
Those are separate procedures in the bundle guide; do not acquire certificates
or resolve application secrets simply to build an archive.

### Prepared-environment build and link

From the SDK checkout, substitute supplied paths and chosen versions:

```powershell
$ErrorActionPreference = 'Stop'
$bundleRepo = 'D:\dev\logic-apps-bundle'
$uxRepo = 'D:\dev\LogicAppsUX'
$pairRoot = 'D:\candidates\integration-001'
$sdkVersion = '1.0.0-e2e.mychange'
$bundleVersion = '1.999.1'

Get-Item (Join-Path $bundleRepo 'tools\devtools\be-functions-runtime\scripts\Build-CandidateWorkflowBundle.ps1')
Get-Item (Join-Path $uxRepo 'apps\vs-code-designer\scripts\run-candidate-e2e.js')

.\tests\ExtensionE2E\New-ExtensionCandidate.ps1 `
  -BpmRepository $bundleRepo `
  -BundleVersion $bundleVersion `
  -SdkPackageVersion $sdkVersion `
  -OutputDirectory $pairRoot

if ($LASTEXITCODE -ne 0) { throw 'Candidate preparation failed; inspect its logs.' }
.\tests\ExtensionE2E\New-ExtensionCandidate.ps1 `
  -VerifyManifest (Join-Path $pairRoot 'candidate.json')
```

The historical `-BpmRepository` parameter names the Logic Apps Bundle checkout.
The producer supplies a real ZIP and receipt; the SDK script builds the entire
nupkg and links both immutable archives through `candidate.json`. A `publish`
directory or one copied engine/SDK DLL is not interchangeable with those inputs.
For an already built runtime, use `-BundleReceiptPath` as documented below
instead of rebuilding it. Changing only the SDK still requires a new package
version, pair directory, installed candidate root, and rebuild of the consumer.

If the source builder reports missing JavaScript worker dependencies, its
documented restore is the locked dependency-generator install:

```powershell
Push-Location (Join-Path $bundleRepo 'src\functions\Scripts\Function.JavaScriptDependencyGenerator')
try {
  npm ci
  if ($LASTEXITCODE -ne 0) { throw 'JavaScript dependency-generator restore failed.' }
} finally {
  Pop-Location
}
```

The builder checks for that generator's `node_modules\isolated-vm\package.json`;
a dependency install in an unrelated worker directory does not satisfy it.
After repairing a prerequisite failure, choose a new output directory for the
retry and preserve the failed run's logs rather than overwriting/deleting it.

Build the UX extension and complete webview using its companion guide, then pass
this exact manifest to its runner. The optional `-RunExtension` route below can
also perform that handoff during preparation. The resulting private project must
select the same package version/feed, restored compiler, SDK library, and LSP SDK
path; the design-time and F5 hosts must use the same bundle archive.

## Portable manual project handoff

The reusable manual tools live in the LogicAppsUX repository under
`apps\vs-code-designer\scripts`. They replace the need to recover a previous
agent's private source-copy/launcher files. Follow that repository's
`run-candidate-e2e.md` for the maintained option details.

First install the manifest through the existing runner, using a new run
envelope and the complete built extension. The runner opens its own private
test editor, so running this step also requires the user's launch permission:

```powershell
$runRoot = Join-Path $pairRoot 'extension-run'
$nodeExe = (Get-Command node -ErrorAction Stop).Source
$dotnetExe = 'C:\Program Files\dotnet\dotnet.exe'
$funcExe = 'C:\tools\FuncCoreTools\func.exe'
$codeExe = 'C:\tools\VSCode\Code.exe'
$offlineFeed = 'D:\candidates\offline-nuget-feed'
$builtExtension = Join-Path $uxRepo 'apps\vs-code-designer\dist'

node (Join-Path $uxRepo 'apps\vs-code-designer\scripts\run-candidate-e2e.js') `
  --manifest (Join-Path $pairRoot 'candidate.json') `
  --root $runRoot --scope activation `
  --node $nodeExe --dotnet $dotnetExe --func $funcExe --code $codeExe `
  --extension $builtExtension `
  --extensions "$env:USERPROFILE\.vscode\extensions" `
  --nuget-source $offlineFeed --timeout-ms 600000
if ($LASTEXITCODE -ne 0) { throw 'Candidate installation failed; preserve runner evidence.' }
```

Use this instead of, not after, a `-RunExtension` invocation using the same
root. The runner owns initial installation; do not prepopulate or repair its
sealed candidate directory by hand. Activation scope establishes installation,
not project creation, debugger attachment, or workflow execution.
`--extension` selects the complete built extension under test; the separate
`--extensions` directory is only a read-only source of its offline extension
dependencies. It does not select or build the candidate extension.

Save any pending edits in the source project. The manual launcher requires a
fully installed, sealed root with a matching manifest/receipt, not an arbitrary
directory containing extracted DLLs. An envelope/runner receipt alone is not
proof that the bundle and SDK were installed: verify the candidate's installed
payload/receipt before creating any project beneath it, so project copying
cannot make an empty candidate directory look like a completed installation.
The launcher checks `candidate\.logicapps-local-candidate.json` before copying:
its schema, exact manifest path, and SHA256 of the manifest bytes must match the
product installer's completion marker. This does not replace the payload/hash
and runtime acceptance gates below. Substitute the source workspace/project and
a fresh destination **inside** the installed candidate:

```powershell
$sourceProject = 'D:\workflows\my-codeful-workspace'
$copiedProject = Join-Path $runRoot 'candidate\manual-workspace\my-codeful-workspace'

node (Join-Path $uxRepo 'apps\vs-code-designer\scripts\launch-candidate-workspace.js') `
  --source $sourceProject --dest $copiedProject `
  --manifest (Join-Path $pairRoot 'candidate.json') --root $runRoot `
  --node $nodeExe --dotnet $dotnetExe --func $funcExe --code $codeExe `
  --nuget-source $offlineFeed
if ($LASTEXITCODE -ne 0) { throw 'Manual candidate launch refused or failed; inspect its explicit error.' }
```

Run the launch command only after user approval. If the private profile is
already active, the launcher refuses to reuse it; the user must save/close only
that private window before a full relaunch. Never terminate unrelated editors,
tasks, or listeners. If the original source has changed since copying, prepare
a new verified copy/root rather than bypassing the original-source drift check.
Edits made intentionally in the selected copied project are retained; they are
not mistaken for changes in the original.

The composed handoff:

- Copies authored files and project configuration without modifying the original.
  Excludes generated `bin`, `obj`, cache/debug-host output, and the specific
  `lib\codeful` subtree; unrelated `lib` files and authored folders named
  `codeful` must survive. It records original-source SHA256 fingerprints.
- Retargets the copied SDK `PackageReference` and NuGet source to the sealed
  candidate. Cache invalidation alone does not update an existing project's
  package version; fresh-project templates are not rerun for a copied project.
  SDK/LSP selection and F5 task migration also use the selected root.
- Revalidates original source before launch, checks installed layout and
  manifest agreement, and refuses an active private profile without killing it.
- Reuses the runner's isolated HOME, APPDATA, temp, NuGet, and executable
  environment, preserving required Windows architecture metadata. Manual mode
  removes test-only Mocha/auth suppression and uses normal product metadata
  and interactive sign-in rather than offline connection mocks.

The separate `copy-candidate-workspace.js` and
`retarget-candidate-workspace.js` commands are filesystem preparation utilities,
not substitutes for the sealed installation and guarded launch. Copying to a
nonexistent destination is overwrite protection; only comparison with original
fingerprints detects subsequent original-source edits.

After the private editor opens, inspect package/LSP pickup and build results,
then use F5 and the acceptance gates below. A helper's guard tests use stubbed
spawn/process enumeration; they do not establish actual UI, debugger, or
managed-connector execution. The original session-specific receipts remain
historical evidence, not inputs required by this portable workflow.

## Acceptance checklist and retained evidence

Maintain a per-run record outside the repositories. Use
`passed`, `failed`, `blocked`, or `not-run` for each gate rather than one
undifferentiated "E2E passed" label.

| Gate | Required evidence | Not sufficient |
| --- | --- | --- |
| Source and artifacts | Three revisions, relevant changes, producer receipt, manifest, archive hashes and required payloads | HEAD recorded beside an imported binary without producer provenance |
| Extension installation | Installed payload/asset identities, private root/profile, actual activated extension | A successful TypeScript emit or files present on disk |
| SDK pickup/build | LSP SDK path, project reference/version/feed, restored compiler and library hashes, complete build output and PDBs | Repository-project-reference tests or a replaced runtime DLL |
| Definition semantics | Serialize the actual copied provider's definitions; assert literal/native shapes and JSON behavior | Source text contains an expected helper name |
| F5 host readiness | Owned task -> wrapper -> func/inproc8 ancestry, selected port listener ownership, selected engine/worker paths, startup/registration evidence | Another endpoint reports `Running`, shell PID cached, or a function name is listed |
| Debugger | Attached debugger to the candidate's actual process and usable symbols | Task started, host healthy, or successful PID discovery |
| Workflow execution | Authorized invocation, workflow version/run/action status, resolved inputs, expected response, loaded artifact identities | Successful compilation or definition export |
| Designer/run view | Actual operation details and initialized parameters for the selected definition/Swagger | Runtime connector execution alone or historical Swagger without current cache equivalence |

Definition-only inspection may call the copied provider's `GetWorkflows()` and
each returned definition's `ToJson()` using a separate bounded helper. Do not
invoke the worker's `Program.Main` or start a host merely to serialize a
definition. Do not execute authoring value delegates.

Keep build/restore logs, manifests, SDK/compiler/engine/application hashes,
source-copy fingerprints, and PDB identity. Keep user configuration and run
content private; redact connection secrets, callback URL signatures, storage
keys, and tokens from shareable receipts. Do not commit candidate binaries,
private profiles, credentials, `local.settings.json`, or run history.

The packaged regression mode in `tests\SourceExpressionE2E\README.md` checks the
same compiler/build assets as the UX project. Its `--self-test` and `--export`
operations do not establish execution-host or debugger support. The separate
`Run-Local.ps1` starts a host and invokes workflows: use it only with authorized,
isolated loopback/Azurite settings, reviewed cases, the whole worker output,
and a fresh results directory. It is not a managed-weather connector runner.
Do not invoke `Probe.ps1` as a supposedly read-only status probe; it includes
workflow invocation and content retrieval.

### SDK checks before host execution

From the SDK checkout, run the existing expression suites and packaging guards:

```powershell
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests --verbosity quiet
if ($LASTEXITCODE -ne 0) { throw 'Source-expression tests failed.' }
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests --verbosity quiet
if ($LASTEXITCODE -ne 0) { throw 'Connector/C# expression tests failed.' }
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.ExpressionTests --verbosity quiet
if ($LASTEXITCODE -ne 0) { throw 'Expression tests failed.' }
.\tests\ExtensionE2E\Test-CandidateKit.ps1 `
  -OutputDirectory D:\candidates\kit-checks-001 -TestExtensionCompanion
```

Choose a new guard-test output directory each time. The guard tests use synthetic
archives and stub producers/runners: they establish interface and fail-closed
behavior, not engine compatibility or actual VS Code execution. If the selected
command fails for missing dependencies, restore them using the repository's
configured feeds and retry; do not manufacture a successful test result.
Use the companion guides for bundle runtime and UX tests. A targeted unit pass
does not replace compiling/inspecting the actual restored candidate project.

## Semantic checks learned from integration failures

Use the actual source/definition and evaluated payload together. The durable
[serialization examples](../../serialization-test-cases.md) and
`JsonFormattingBoundaryTests` cover the weather formatting regression:

```csharp
responseBody: () => $"{weather.Body}" + "something"
```

The result must contain the complete weather JSON followed by `something`,
not a generated-model type name. Unknown model fields must survive.
Default-object formatting uses the JSON representation and a fresh
`JsonSerializer.Create()` bridge; numeric/date formatting, custom formatters,
typed methods, and collection operations retain their CLR semantics.
Binding-generated qualified types inside interpolation must be protected so
the `global::` colons are not treated as C# format separators; retain the
ordinary, verbatim, raw, generic, and captured-value compiler regressions.
JSON null formats as empty text; explicitly calling `ToString()` on null still
has ordinary C# null behavior. Do not normalize away that distinction.
Direct body forwarding remains a JSON value. Explicit JSON serialization and
schema JSON/base64 tests must compare the full document after decoding, not
just a known model field.

The weather route's native invariant-culture `string.Format`/`encodeURIComponent`
wrapper can execute correctly while designer Swagger inference fails. Runtime
action success and designer metadata are separate surfaces. UX's bounded static
decoder never evaluates C#: ordinary/verbatim strings and balanced nested
calls/indexers/collection literals are supported, while nested interpolated
strings (including the ServiceBus fixture), raw strings, comments, top-level
generic arguments, nonliteral format templates, unsupported format specifiers,
and ambiguous Swagger routes fail explicitly. Fixing operation inference alone
is insufficient; dependent path-input initialization must share the decoder.

## Troubleshooting and safety boundaries

| Symptom | Bounded check/action |
| --- | --- |
| `dotnet --info` fails in VS Code but succeeds in a terminal | Inspect the actual caller's environment and working directory. `process.cwd()` may select a different SDK via `global.json`. Preserve `PROCESSOR_ARCHITECTURE`; a main-process environment change needs a user-controlled full private relaunch, not Reload Window. |
| Child-process lookup times out or chooses a shell | Use direct bounded PowerShell/CIM discovery and explicit errors; wait for owned func/inproc8. Do not extend timeouts blindly or fall back to cached shell/active-terminal PIDs. |
| Candidate says healthy but port belongs to another host | Require listener owner to match owned process ancestry before HTTP readiness. Report the conflicting PID; never kill it or silently choose a different port. |
| A screenshot or old run disagrees with the current listener | Compare process creation times and immutable workflow versions. A newer listener cannot identify the owner of an older run; distinguish design-time hosts from the F5 wrapper/worker. |
| Worker or engine comes from an old app/cache | Inspect loaded paths/hashes, both application-root settings, and the complete private host staging. Do not repair by changing shared bundle caches or copying loose DLLs. |
| Expression cannot reference a generated SDK model/helper | For runtimes supporting it, use the explicit SDK path/hash approval pair with the library verified against the selected nupkg. It must agree for compile/execute. Worker references and dependency sidecars alone are not approval. |
| Candidate source changed after preparation | Preserve edits and prepare a new verified copy/selection. Do not overwrite the source, silently refresh a sealed root, or bypass a stale-source guard. |
| Designer route is unsupported/ambiguous | Preserve the definition, report the static decoder boundary, and compare existing Swagger safely. Do not evaluate arbitrary C#, guess an operation, or fetch new ARM/connector metadata merely to hide a mismatch. |
| Full solution/sample compilation fails on a missing connector operation | Compare with the baseline and run the relevant SDK/package suites separately. The recorded `RecruitmentWorkflow.cs` / `CommondataserviceActions.ListRecords` failure is not proof that the candidate compiler failed; do not label the whole solution green or fix unrelated sample APIs to conceal it. |

Save unsaved edits before any user-approved switch. Never stop user tasks,
close/reload windows, restart the editor, change ports, resubmit workflows,
or perform Azure sign-in/connector calls without authorization. Do not copy
authentication caches or sign-in tokens between profiles or bypass workspace
trust. Preserved project settings/connections remain private, local test data;
they must not appear in committed fixtures or shareable receipts. A manual profile must
retain ordinary metadata/sign-in behavior rather than test-only offline mocks.

Custom-type declaration extraction/provisioning and the temporary Response
validation workaround were removed. Do not restore them to make a test pass.
Historic suite counts, succeeded runs, and candidate hashes are evidence for
their specific source/runtime pair, not acceptance of a newly built pair.
Some full-runtime custom-type/URI cases remain unsupported. Likewise, extension
bundling success does not erase separately reported TypeScript diagnostics.
Report the actual current results, baseline failures, and unrun gates.

## Prepare from an existing genuine bundle

```powershell
.\tests\ExtensionE2E\New-ExtensionCandidate.ps1 `
  -BundlePath D:\candidates\Microsoft.Azure.Functions.ExtensionBundle.Workflows.1.999.1_any-any.zip `
  -SdkPackageVersion 1.0.0-e2e.mychange `
  -OutputDirectory D:\candidates\mychange-001
```

This builds and packs the SDK in isolated Release artifact directories. Restore
is attempted only after the build reports missing assets. Alternatively pass
`-SdkPackagePath <exact.nupkg>` to import an already built package. Imported
package source provenance must be supplied by its producer; the current checkout
HEAD recorded in the preparation receipt is not proof of an imported binary's
source.

Prefer `-BundleReceiptPath <producer-output>\bundle-receipt.json` instead of
`-BundlePath` when the Logic Apps Bundle companion has already run. This resolves the archive
from its producer receipt, verifies its version and hash, and preserves the
original receipt alongside the handoff. The original receipt's producer paths
are retained as historical evidence; consumers use the copied archive paths in
`candidate.json`.

The supplied bundle must be the real Logic Apps Bundle ZIP, including `bundle.json`,
`bin\function.deps.json`, `bin\extensions.json`, the C# engine, language assets,
and worker directories. A `Tests.Flow.WebJobs.App.v4` publish directory is not
interchangeable with this artifact. Archive checks here establish identity and
required layout, not complete runtime compatibility. Extension health checks and
actual execution remain required.

## Build the Logic Apps Bundle artifact as part of preparation

```powershell
.\tests\ExtensionE2E\New-ExtensionCandidate.ps1 `
  -BpmRepository D:\dev\my-isolated-logic-apps-bundle-checkout `
  -BundleVersion 1.999.1 `
  -SdkPackageVersion 1.0.0-e2e.mychange `
  -OutputDirectory D:\candidates\mychange-002
```

The script parameter remains named `-BpmRepository`; pass the path to the
Logic Apps Bundle repository.

This invokes the Logic Apps Bundle companion
`tools\devtools\be-functions-runtime\scripts\Build-CandidateWorkflowBundle.ps1`
with `-BuildFromSource` and a new output directory, then verifies
`bundle-receipt.json`. The Logic Apps Bundle script owns source-build prerequisites and isolated
bundle staging. Run this combined command from a Visual Studio x64 Developer
PowerShell with full `msbuild.exe` available. For Logic Apps Bundle builds, the output path must
also be outside the Logic Apps Bundle checkout and contain no whitespace: the existing bundle
builder does not quote all of its child-process paths. SDK/archive-only preparation
supports paths containing spaces.

The source-build route also requires JDK 17 or later (`javac.exe`), Maven
(`mvn.cmd`), Node.js, restored JavaScript worker dependencies, and authenticated
access to the Logic Apps Bundle package feeds. Follow the Logic Apps Bundle companion's prerequisite setup.
Do not accept a package built after the legacy Java build reported that it
skipped Maven: an empty or missing `JAR` payload is rejected.

Select the runtime revision explicitly: SDK source preservation
does not imply that a runtime includes output normalization or custom-type
support. No branches are switched or merged by this script.

## Run the development extension

Add these arguments to either preparation command:

```powershell
  -LogicAppsUxRepository D:\dev\my-logicappsux-checkout -RunExtension `
  -ExtensionRunnerArguments @(
    '--code', 'C:\tools\VSCode\Code.exe',
    '--dotnet', 'C:\Program Files\dotnet\dotnet.exe',
    '--func', 'C:\tools\FuncCoreTools\func.exe',
    '--extensions', "$env:USERPROFILE\.vscode\extensions",
    '--nuget-source', 'D:\candidates\offline-nuget-feed',
    '--timeout-ms', '600000'
  )
```

The companion LogicAppsUX checkout must contain
`apps\vs-code-designer\scripts\run-candidate-e2e.js`. Preparation invokes it with:

```powershell
node (Join-Path $uxRepo 'apps\vs-code-designer\scripts\run-candidate-e2e.js') `
  --manifest (Join-Path $pairRoot 'candidate.json') `
  --root (Join-Path $pairRoot 'extension-run') `
  --code 'C:\tools\VSCode\Code.exe' `
  --dotnet 'C:\Program Files\dotnet\dotnet.exe' `
  --func 'C:\tools\FuncCoreTools\func.exe' `
  --extensions "$env:USERPROFILE\.vscode\extensions" `
  --nuget-source 'D:\candidates\offline-nuget-feed' `
  --timeout-ms 600000
```

Replace the example paths with existing executables and a prepared offline feed.
The runner requires `--code`, `--dotnet`, and `--func`. `--extensions` identifies
the read-only installed-extension source from which it copies product dependencies.
Optional `--extension` overrides the built product's default
`apps\vs-code-designer\dist` directory; `--node` overrides the current Node.js
executable. `--timeout-ms` defaults to 180000 and cannot exceed 1800000. Consult
the companion's `run-candidate-e2e.md` for build prerequisites and details.
The extension directory must include the complete built webview:
`vs-code-react\index.html` and its referenced JavaScript, CSS, and other assets.
Compiling only the extension-host TypeScript is not a complete UI build. Use
`pnpm run build:extension` from the LogicAppsUX repository root and follow the
companion's packaging instructions; successful activation alone does not prove
that the workspace-creation screen can open.
Use 600000 for a full local bundle: cold extension activation can exceed three
minutes before candidate inspection begins.
Arguments are passed without shell evaluation; overriding `--manifest` or
`--root` is rejected. Node.js is required when running the extension companion.

The default `pickup` scope opens a private workspace and requires normal VS Code
workspace-trust approval in that test window. It does not grant trust or disable
the trust feature. Add `'--scope', 'activation'` to the argument array for a
workspace-free activation/install check instead; that scope cannot establish
project creation, LSP startup, build, F5, or workflow execution. If the installed
editor is being updated, use a verified standalone VS Code distribution rather
than stopping the shared updater.

The runner owns extension installation/activation and its test-scoped dependency
and bundle roots. Do not substitute the ordinary stock SDK reseeding fixture or
disable health checks. Check the runner receipt for the exact observed scope:
archive preparation, activation, build, F5 launch, workflow execution, and Overview
inspection are different gates. A zero task-start result is not workflow success.
The current runner automates activation/install, or create/build/reopen/LSP
selection after trust approval. It does **not** automate F5, an HTTP workflow run,
or Overview assertions; those remain additional acceptance steps. The separate
runtime regression below is not evidence of extension-driven F5 execution.
The run root is an envelope: candidate installs live under its `candidate`
subdirectory, while the isolated home and temporary directories are siblings.
The extension installer creates the candidate root; do not prepopulate it.

When creating a workspace manually in the candidate window, select a destination
under `<run-root>\candidate`, for example
`<run-root>\candidate\manual-workspace\my-codeful-app`. An ordinary destination
elsewhere on disk is rejected by the candidate-isolation guard, even when the
extension is fully installed. This restriction applies to the opt-in candidate
setup, not normal released-extension workspace creation.

An automated offline test profile is not interchangeable with a manual Azure
connector test profile. Manual testing must retain the normal connector metadata
and interactive sign-in flow rather than inherit test-only authentication
suppression or disabled metadata responses. Keep archive selection and isolation
enabled in either mode. Do not copy credentials from another profile; any Azure
sign-in, subscription selection, or connection creation remains user-controlled.

On Windows, the isolated environment must retain required platform metadata,
including `PROCESSOR_ARCHITECTURE`. Validate `dotnet --info` in the debugger's
actual environment and working directory: a successful build does not prove
that the SDK's Windows workload-information initialization succeeds. Changes to
the main process environment require a full private VS Code relaunch, not just
Reload Window.

SDK candidate selection must agree across the LSP `--sdk` argument, generated
project `PackageReference`, restore cache, and packaged build tool. Bundle selection
must agree across health checks, design-time host, and actual runtime; never
silently fall back to a public bundle. The extension-selected dotnet must support
the tool's .NET 9 runtime as well as the application runtime.

Do not infer in-process .NET 8 startup from a successful Node design-time host.
Older Core Tools can override the configured bundle download directory and
`ensureLatest` setting, even with private home-directory environment variables.
Do not enable downloads into the shared cache to bypass this limitation.

The candidate-only F5 path prepares a fresh private application host **after**
the current clean/build: the complete verified bundle plus the complete current
application output at the host root and under `lib\codeful`. Only the derived
host configuration omits bundle resolution; preserve the source project's
configuration, original bundle files, application PDBs, and previous host
directories. Pin both `WORKFLOW_APPLICATION_ROOT_DIRECTORY` and
`ProjectDirectoryPath` in the derived host configuration/environment; inherited
project paths can otherwise start a worker from a previous deployment. A new
SDK requires rebuilding through its packaged compiler, not
replacing a runtime DLL. Verify the loaded engine and application identities and
actual workflow registration: `/admin/host/status` can report `Running` even
after bundle startup fails, and `/operationGroups` alone does not prove that the
user's workflow registered or that a debugger attached.

Typed native operations can require the SDK assembly in the expression compiler,
not just in the codeful worker. For a runtime supporting explicit SDK approval,
the private host wrapper supplies `LOGIC_APPS_CSHARP_SDK_ASSEMBLY_PATH` and
`LOGIC_APPS_CSHARP_SDK_ASSEMBLY_SHA256` together. The approved DLL must match the
SDK library asset inside the manifest-verified nupkg; hashing an arbitrary output
DLL is not sufficient. The setting pair selects one SDK assembly at host startup,
not arbitrary application dependencies. A dependency sidecar is not runtime
reference registration, and copying assemblies into the host does not replace
this approval.

For the existing workflow regression suite, use its
[packaged candidate variant](../SourceExpressionE2E/README.md#build-the-packaged-candidate-variant)
with the same SDK version and artifact feed. Its default repository
`ProjectReference` build does not establish package-plus-host coverage.

## Receipts and verification

Preparation writes:

- `candidate.json`: schemaVersion 1; `bundle` has absolute `path`, `version`, and
  `sha256`; `sdk` additionally has `packageId`.
- `artifacts`: copied ZIP/nupkg, byte-verified against their inputs.
- `commands.json` and build/runner logs: exact argument arrays and exit codes,
  including expected missing-assets probes.
- `bundle-receipt.json` when importing a Logic Apps Bundle receipt or building the Logic Apps Bundle in this
  invocation; source builds also retain `bpm\bundle-receipt.json`.
- `extension-run`: actual consumer evidence when requested.

```powershell
.\tests\ExtensionE2E\New-ExtensionCandidate.ps1 -VerifyManifest D:\candidates\mychange-001\candidate.json
.\tests\ExtensionE2E\Test-CandidateKit.ps1 -OutputDirectory D:\candidates\kit-tests-001
```

The guard tests use synthetic archives and never launch their placeholder
binaries. Add `-TestExtensionCompanion` (requires Node.js) to exercise argument
passing and receipt handling with a stub consumer, not VS Code. Keep real-artifact
and extension execution evidence separate.

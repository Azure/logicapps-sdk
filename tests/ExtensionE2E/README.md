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
node <runner> --manifest <output>\candidate.json --root <output>\extension-run
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

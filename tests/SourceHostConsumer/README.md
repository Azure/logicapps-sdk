# Actual Logic Apps host probes

This consumer generates probe definitions through the real SDK source compiler.
It is separate from the local Roslyn harness: Core Tools loads the actual
Microsoft.Azure.Functions.ExtensionBundle.Workflows runtime and executes HTTP
requests against its workflow engine.

Use an isolated host directory and a localhost-only Azurite instance. Do not use
production storage, deploy these probes to an existing app, or reuse unrelated
developer processes. Core Tools and Azurite are external test prerequisites, not
SDK runtime dependencies.

Build `SourceHostConsumer.csproj` and run it with the isolated host directory as
its sole argument. Configure that directory's `host.json` with an explicit
Workflow bundle version and `local.settings.json` with the isolated emulator
endpoints, `APP_KIND=workflowapp`, and `FUNCTIONS_WORKER_RUNTIME=node`.

Build `CultureHook\CultureHook.csproj`. For each `en-US` and `fr-FR` host process,
set process-scoped environment variables:

- `DOTNET_STARTUP_HOOKS`: absolute path to the built culture-hook DLL.
- `WORKFLOW_PROBE_CULTURE`: the culture being measured.
- `WORKFLOW_PROBE_CULTURE_EVIDENCE`: a separate JSON output file for that process.
- `FUNCTIONS_CORE_TOOLS_TELEMETRY_OPTOUT=1`.

Start Core Tools with `host start --address 127.0.0.1 --port <isolated-port>`.
Run `Probe.ps1` with `BaseUri`, `CultureEvidence`, `HostDirectory`, and
`OutputPath`. It checks that the culture evidence names the process actually
listening on the endpoint, records the engine/bundle versions and definition
hashes, measures all six catalog S14 token kinds, and asserts literal-marker
transport for F08. Callback credentials are used in memory and never written to
the evidence.

NativeProbe and ConditionProbe deliberately exercise the SDK's native envelope.
Public bundles 1.170.43 and 1.170.91 reject these definitions during validation.
Preserve the actual error as an unsupported-host result; do not count it as a
passing native execution case or rewrite it into another expression language.
SDK deployment preflight must reject native publication to an unverified host.
For a runtime with codeful inline-expression support, use
`tests\SourceNativeHostConsumer` instead: it starts an actual SDK registration
worker and compares native execution with independent template controls.
Merely loading a newer extension with codeless settings does not enable its
codeful expression evaluator.

The earlier SDK literal-escaping failure is also retained as historical evidence:
an unescaped literal marker was rejected, whereas the correctly escaped marker
returns the original text, not an evaluated result.

Stop only the host/emulator processes created for this test when finished.
Local results do not certify cloud deployment or designer compatibility.

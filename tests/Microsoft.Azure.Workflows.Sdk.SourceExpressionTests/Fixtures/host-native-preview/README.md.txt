# Native expression execution-host probes

This is a real codeful Functions worker, not a local Roslyn mock. It registers
SDK-authored workflows with the Logic Apps runtime through
`WorkflowFactory.ConfigureServices`. The versioned schema generates the
base64-of-JSON destination used by catalog X06.

Build with the repository SDK/compiler already built:

```powershell
dotnet build .\tests\SourceNativeHostConsumer\SourceNativeHostConsumer.csproj -p:BuildProjectReferences=false -p:GeneratePackageOnBuild=false
dotnet run --project .\tests\SourceNativeHostConsumer\SourceNativeHostConsumer.csproj --no-build -- --export C:\isolated-probe\definitions
```

Use only a separately supplied runtime that implements inline C# expressions.
Public bundles 1.170.43 and 1.170.91 do not. Private runtime packages and
credentials must remain outside the repository.

In an isolated host directory, install the runtime's extension binaries under
`bin` and copy this worker's build output under `lib\codeful`. Use a `host.json`
without an `extensionBundle` when loading those local extension binaries.
The worker configuration emitted by this project declares language `dotnet`,
as required by the codeful registration path.

Set these values in the isolated app's `local.settings.json`:

- `APP_KIND=workflowapp`
- `WORKFLOW_CODEFUL_ENABLED=true`
- `FUNCTIONS_WORKER_RUNTIME=dotnet`
- `FUNCTIONS_INPROC_NET8_ENABLED=1`
- `AzureWebJobsSecretStorageType=Files`
- `AzureWebJobsStorage` pointing only to a separately started local emulator

The .NET 8 selector must be in local settings for Core Tools to select its
in-process host. Set process-scoped `WORKFLOW_APPLICATION_ROOT_DIRECTORY` to
the isolated app directory and disable Core Tools telemetry. Start Core Tools
with `host start --address 127.0.0.1 --port <isolated-port> --no-build`.

Run `Probe.ps1` with `BaseUri`, `HostDirectory`, `DefinitionsDirectory`, and
`OutputPath`. It verifies the local listener, uses callback credentials only
in memory, records definition and runtime/worker assembly hashes, and checks:

- Native arithmetic produces a number rather than returning the source string.
- Native Condition selects both branches.
- A separate ordinary-template Condition can access the same preceding output.
- X06 serializes the calculated object and base64-encodes it exactly once.
- The JSON intrinsic executes inside a native expression.

The template Condition is a diagnostic control, never an SDK fallback.
Every failed observation is retained and makes the script fail. Do not mark an
unsupported native Condition as passing because its template control succeeds.
Likewise, arithmetic success does not establish availability of every helper
assembly or permission to deploy arbitrary dependencies.

Stop only the host and emulator processes created for the probe. Local runtime
execution does not certify the designer or cloud deployment.

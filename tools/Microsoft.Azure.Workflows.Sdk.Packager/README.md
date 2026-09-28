# Logic Apps SDK Packager

`Microsoft.Azure.Workflows.Sdk.Packager` is the initial headless CI packaging
command for SDK-based Logic App Standard projects. It publishes the .NET worker,
assembles a clean Logic App deployment root, validates the minimum package
contract, and produces a deterministic ZIP.

## Install

Build and install the tool package:

```powershell
dotnet pack .\tools\Microsoft.Azure.Workflows.Sdk.Packager\Microsoft.Azure.Workflows.Sdk.Packager.csproj -c Release
dotnet tool install --global --add-source .\out\pkg\release Microsoft.Azure.Workflows.Sdk.Packager
```

## Usage

```powershell
logicapps-sdk-pack `
  --project .\src\MyLogicApp\MyLogicApp.csproj `
  --output .\artifacts\MyLogicApp.zip
```

The command:

1. Runs `dotnet publish` for the specified project.
2. Disables the project's `LogicAppFolderToPublish` side effect for that publish.
3. Copies deployment-safe project assets into an isolated staging directory.
4. Places the published worker under `lib\codeful`.
5. Rewrites `worker.config.json` from `dotnet-isolated` to `dotnet` when needed.
6. Validates `host.json`, worker configuration, and the worker entry assembly.
7. Creates a ZIP with sorted entries and normalized timestamps.

Run `logicapps-sdk-pack --help` for all options.

## Current assumptions

- Only .NET 8 projects (`net8` or `net8.0`) are supported. The target framework
  is inferred from the project unless `--framework` is supplied.
- The project must be an SDK-based code-first worker with package or project references to
  `Microsoft.Azure.Workflows.Sdk` and `Microsoft.Azure.Functions.Worker.Sdk`.
  Traditional projects based on `Microsoft.NET.Sdk.Functions` and
  `Microsoft.Azure.Workflows.WebJobs.Extension` use the standard Logic App
  publish and ZIP flow instead.
- The Logic App root defaults to the directory containing the worker project.
- The retained ZIP is environment-neutral.
- Managed API connection resolution, access-policy creation, application
  settings, and Azure deployment belong to the CD stage.
- `.funcignore` controls project-asset exclusions. Built-in safety exclusions
  always remove source files, build output, editor metadata, generated
  `lib\codeful` output, and `local.settings.json`.
- Package parity is defined by normalized contents, not the original file
  timestamps.

## Current limitations

- The `.funcignore` implementation supports comments, negation, `*`, `**`,
  `?`, root-anchored patterns, and directory patterns. Contract-parity testing
  against the deployment library remains follow-up work.
- This command does not provision infrastructure, rewrite connections for a
  target environment, configure access policies, upload application settings,
  or deploy the ZIP.
- Hybrid Logic Apps and non-ZIP SCM deployment paths are not included in this
  initial implementation.

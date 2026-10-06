# Generated connector parity test

Compare freshly emitted Logic Apps Bundle `CodefulSdkGenerator` sources with the generated
managed connectors and service providers in this SDK checkout. No ARM calls,
generation, migration, or source replacement occurs in the comparison itself.

Both input roots use `managed\*.cs` and `serviceProviders\*.cs`. Keep generator
revision/source hashes, raw input hashes, preprocessing and generation
failures/skips with the candidate export. Different schema snapshots are not
evidence of a generator regression.

From the repository root:

```powershell
dotnet run --project .\tests\GeneratedConnectorParity -- `
  .\src\generated C:\artifacts\fresh-generated C:\artifacts\parity-report
```

The report directory must be new and outside both input trees. `comparison.json`
contains every source SHA256, uncovered/extra file, parse error, and declaration
or implementation difference. `comparison.md` summarizes coverage and examples.

The comparison has three levels:

- Byte equality and token equality (ignoring only ordinary comments/whitespace).
- Public/protected declaration equality, including names, types, defaults,
  attributes, model properties and enum order/values.
- Implementation syntax equality, including validation, conversion calls,
  deferred factories and private helpers. Renaming a local or making an
  equivalent rewrite still counts as a difference.

Imports, directives and assembly attributes are tracked separately: identical
member tokens can bind differently. This is a Roslyn **syntax** comparison, not a
semantic equivalence proof. Files pair by relative path; unmatched baseline
files are *not generated*, not assumed to be removed. A partial export cannot
pass full parity. The tool does not assume an absent service-provider directory
means that service providers match.

Normal report mode exits 0 when comparison completes, even with differences.
Add `--require-match` to exit 1 unless every baseline file has a token-equal
candidate and there are no extra files. Invalid input or C# parse errors exit 2.

## Compile the candidate inside the actual SDK

Generated sources use internal SDK APIs, so compile them inside the SDK rather
than against a stand-in implementation. This hook replaces only the matching
compile items, without overwriting committed sources. Use a separate artifacts
directory; keep project-reference builds enabled.

```powershell
$fresh = 'C:\artifacts\fresh-generated'
$isolated = 'C:\artifacts\candidate-sdk'
$hook = (Resolve-Path .\tests\GeneratedConnectorParity\CompileGeneratedSources.targets).Path
dotnet restore .\src\Microsoft.Azure.Workflows.Sdk.csproj -p:ArtifactsPath=$isolated
dotnet build .\src\Microsoft.Azure.Workflows.Sdk.csproj --no-restore `
  -p:GeneratePackageOnBuild=false -p:ArtifactsPath=$isolated `
  -p:CustomBeforeMicrosoftCommonTargets=$hook -p:GeneratedConnectorDirectory=$fresh
```

`parity-generated-sources.txt` in the isolated intermediate output records the
included files. Compilation does not certify runtime behavior or imply that the
input schemas match the original SDK export.
Source substitution runs before compile-dependency caching so changing the
candidate inventory also invalidates the SDK's incremental compilation inputs.
The SDK then injects method-entry validation into obj-only sources. Candidate
wrappers must contain WorkflowExpression annotations but no explicit
SourceExpression.Validate statements. The hook's GeneratedFamily metadata
allows injection to include these external compiler inputs; it does not restrict
injection to the repository's physical generated directories.

Exercise the actual SDK injection targets in a small isolated build fixture:

```powershell
.\tests\GeneratedConnectorParity\Validate-ConnectorInjection.ps1 `
  -OutputDirectory C:\artifacts\connector-injection
```

The output directory must not exist. The runner checks normal and repeated builds,
source/signature changes, add/delete/rename, missing outputs, failed analysis,
package receipts, Debug/Release isolation, design-time behavior, missing tools and
clean/rebuild. It uses a copy of InjectionFixture and does not mutate its source.

Run the comparison tool's regression tests:

```powershell
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests `
  --filter FullyQualifiedName~GeneratedConnectorParityTests
```

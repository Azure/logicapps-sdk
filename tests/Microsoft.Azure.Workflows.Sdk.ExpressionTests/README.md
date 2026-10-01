# Source-compiled expression consumer tests

This project authors ordinary SDK workflow lambdas and exercises the repository's
MSBuild source transformation. It does not compile legacy converter sources,
construct expression trees, or manually assemble source descriptors. Assertions
inspect generated definitions; they do not claim backend execution coverage.

The former 68 converter-characterization tests have been reduced to eight focused
consumer-build regressions. The larger active `Microsoft.Azure.Workflows.Sdk.SourceExpressionTests`
suite already covers most of their meaningful language behavior.

## Migration and retirement map

| Former coverage | Current coverage |
| --- | --- |
| `ComplexObjectConverterTests`: object/array literals and mixed scalar types | This project retains the mixed Boolean/long/double/decimal/enum/null payload. `SourceRoutingTests`, `SurfaceTests`, and `CoreLiteralAndStructureCatalogTests` cover arrays and nested structural JSON. |
| POCO member initialization and `JsonProperty` names | This project preserves native POCO construction and checks the renamed property on typed body navigation. Ordinary POCO construction is not forcibly lowered to template JSON concatenation. |
| `ExpressionConverterTests`: comparisons, arithmetic, logic, conditional, strings and literals | `SourceRoutingTests`, `CoreOperatorCatalogTests`, `CoreCompositeCatalogTests`, and `CoreStringAndMethodCatalogTests` cover native source and local execution. Boolean/numeric literals retain JSON types, not stringified converter-overload results. |
| `ExpressionConverterOverloadTests`: HTTP method, enum and encoding overloads | This project retains one/two integer URL encodings using actual SharePoint destinations. `CoreStringAndMethodCatalogTests` covers HTTP normalization; `CoreEnumCatalogTests`, `CoreEncodingCatalogTests`, and `SchemaDestinationCatalogTests` cover enum wire policy, numeric base64 encoding, and enum/string URL encodings at generated destinations. Converter-only overload dispatch is retired. |
| `FunctionMappingTests`: formatting, concatenation, `ToString`, JSON and token conversion | `CoreStringAndMethodCatalogTests`, `CoreConversionCatalogTests`, and `JsonIntrinsicCompilerTests` cover preserved native operations. DateTime/Guid capture-success cases are retired: current authored captures fail with `WFBUILD003` because the compiler's approved capture types exclude both. Lower-level snapshot support is not source-authoring support. WDL function names and ISO dates emitted as unquoted template arguments are also retired. |
| `TriggerAndActionExpressionTests`: trigger, body/output, variable and agent parameter references | This project retains variable interpolation, managed-trigger interpolation, actual SharePoint-body/Compose interpolation, and trigger/action token equality. `SourceRoutingTests`, `CoreLiteralAndStructureCatalogTests`, and `SurfaceTests` cover standalone references and actual agent-tool callbacks. |
| `KnownLimitationsTests`: malformed array/dictionary rendering, rejected numeric captures, `Value<T>`, arrays and format strings | Retired bug-preservation assertions. `CoreStringAndMethodCatalogTests`, `CoreConversionCatalogTests`, `BindingTests`, and `SourceRoutingTests` cover working native equivalents and snapshot semantics. Whole-agent-parameter partial-node rendering is an obsolete converter-internal failure, not a current API contract. |

Run from the repository root after building the SDK and source compiler:

```powershell
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.ExpressionTests\Microsoft.Azure.Workflows.Sdk.ExpressionTests.csproj --no-restore -p:BuildProjectReferences=false -p:GeneratePackageOnBuild=false
```

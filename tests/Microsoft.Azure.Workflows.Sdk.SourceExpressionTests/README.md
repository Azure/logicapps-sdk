# Source-expression regression tests

These tests compile current workflow source with the repository's Roslyn build
tool, inspect SDK-generated definitions, and evaluate supported native expressions
in a local test fixture. They cover literal/template/native routing, typed
workflow references, source preservation, schema-driven destinations, encoding,
diagnostics, dependency discovery, and deployment preflight.

Run from the repository root:

```powershell
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests.csproj
```

`Fixtures\catalog-destinations.schema.json` is an executable schema-test input.
Historical coverage ledgers, recorded host/package/IDE output, and tests that
only authenticate those recordings are not part of this project's regression
suite. Keep new run reports outside the repository.

Related executable harnesses:

- `tests\SourcePackageConsumer`: packaged-SDK, compilation-matrix, language-service,
  and VS Code validation.
- `tests\SourceHostConsumer`: local Logic Apps host probes.
- `tests\SourceNativeHostConsumer`: native-expression host probes.
- `tests\SourceExpressionE2E`: actual-host workflow regressions, including nested
  JSON and Response-body controls.

Local compilation and fixture execution are not backend certification. In
particular, successful URI construction and local JSON serialization do not
establish support for a scalar URI Response body. F138 / `NativeUri` remains a
known failing end-to-end case; the E2E workflow keeps its original success
expectation rather than masking the limitation.

# Source-expression regression tests

These tests compile current workflow source with the repository's Roslyn build
tool, inspect SDK-generated definitions, and evaluate supported native expressions
in a local test fixture. They cover literal/structured-JSON/native routing, typed
workflow references, source preservation, schema-driven destinations, encoding,
diagnostics, dependency discovery, and deployment preflight.

Executable values must be a single `#{...}` expression. Direct workflow
references, interpolations, JSON parsing, and encoding all follow this rule;
standalone template functions, `@{...}` interpolations, and the retired
`@csharp{...}` envelope are not emitted.
Structural JSON retains independently compiled leaves, and authored strings
starting with `@` remain escaped as `@@`. Shared consumer assertions reject
template expressions without rejecting those escaped literals. Legacy descriptor
tests verify that complex templates require native source rather than falling
back to the old template language.

Authored literals beginning with the reserved `#{` prefix use a C# string
expression: literal `#{1 + 2}` is emitted as `#{"#{1 + 2}"}` and evaluated once
to string data. There is no `##` escape: `##{1 + 2}` remains two hashes.
Leading whitespace and embedded `#{...}` do not select native evaluation.
Authored text containing legacy `@{...}` interpolation is also emitted as a
quoted C# string expression, so literal data cannot activate template evaluation.

Pass-through workflow outputs and recognized JSON-property paths retain raw JSON
values inside C# envelopes, without materializing SDK or custom model types.
Native operations, interpolation, and encoding operands retain their original
typed C# source. Dual wire/native descriptors are checked at both boundaries;
JSON-native pass-through does not imply deployed custom-type support.

Deployment preflight coverage requires `WFDEP010` for legacy template expressions,
including nested inputs and control/trigger fields. Escaped `@@` literals and
legacy-looking text quoted inside native C# remain valid. Deployment fixtures use
project-local `out\test-workspaces` directories and clean up after each test.
Native-source extraction removes the two-character `#{` prefix and final brace.
Preflight rejects `#r` and `#load` directives without resolving files, while
quoted directive-looking strings remain ordinary C# values.

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

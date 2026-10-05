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
CLR operations retain typed C# source, but default object formatting consumes
workflow-backed JSON rather than materializing a model with a type-name
`ToString()`. Dual wire/native descriptors are checked at both boundaries;
JSON-native pass-through does not imply deployed custom-type support.

Interpolation regressions compile and execute typed and generic workflow
bindings, captured collections, alignment, formatting, and raw/verbatim strings.
Binding-generated `global::` type names are protected by parentheses so their
colons cannot be parsed as interpolation format separators.
The generated Msnweather body regression checks the emitted interpolation, the
actual weather JSON plus suffix (including unknown fields), and absence of an
unneeded `CurrentWeather` runtime dependency. Actual SDK helper/type operations
still require explicit host approval; shipping the worker's SDK DLL or dependency
sidecar does not register a runtime expression compiler reference.

`JsonFormattingBoundaryTests` audits interpolation (including raw/verbatim
strings), concatenation, object-formatting overloads and expanded arguments,
default `ToString()`, nested JSON model properties, collections, conditionals,
null coalescing, generic type binding, JSON parsing, explicit serialization, and
schema-directed JSON/base64 encoding. Assertions compare resulting payloads,
unknown fields, null handling, and accessor reads, not only emitted source.
Negative controls retain scalar/date formatting, custom formatters, typed model
operations, and collection joining/concatenation. JSON decoding ignores ambient
serializer defaults. This is consumer-aware handling, not blanket removal of
`ToObject<T>()`: arbitrary methods, explicit CLR operations, and unsupported
navigation shapes continue to require typed materialization.

Msnweather route regressions pin the invariant-culture `string.Format` shape,
runtime URL encoding of literal and workflow-derived locations, and literal
method/query values. The emitted path is native code, not a literal Swagger
route; designer operation inference must not execute its arguments.

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

## Generated connector validation contract

`ConnectorValidationContractTests` characterizes observable behavior, not the
presence of `SourceExpression.Validate` in generated source. Any replacement
must pass these tests unchanged. The parameter matrix covers managed actions,
managed triggers, service-provider actions and service-provider triggers, with
path/query/body/header inputs and string/object/array/enum/integer delegates.

| Boundary | Required behavior |
| --- | --- |
| Required null delegate | `ArgumentNullException` with the connector parameter name, before an action or trigger is returned. |
| Required literal null | Exact `ArgumentException` with the connector parameter name, including JSON-null and boxed/token-wrapped nulls. |
| Optional null and valid defaults | Accepted; omitted optional queries stay omitted, and empty strings and numeric zero are not newly rejected. |
| Raw or multicast delegates | Immediate `NotSupportedException`, without invoking any delegate, for required and optional parameters alike. |
| Invocation paths | Validation also applies to direct calls, method groups, reflection and separately compiled, untransformed callers. Transformed inline, captured-null and source-factory arguments retain the same contract. |
| Timing and error precedence | All call arguments are evaluated before validation; argument-evaluation exceptions win, then invalid parameters fail in declaration order rather than named-argument order. |
| Deferred expressions | Native expressions and workflow references are not evaluated or rejected based on their eventual runtime value. Captures remain snapshots; renamed workflow references resolve when rendered. |

Run this focused gate with:

```powershell
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests `
  --filter FullyQualifiedName~ConnectorValidationContractTests
```

These cases were also run against a removal-only SDK before injection was added:
63 of the 98 independent cases failed, while the valid-input controls remained
green. There is deliberately no normal-build switch that produces an
unvalidated SDK. Do not change these assertions to accept deferred errors or
missing exceptions.

`ConnectorValidationTransformerTests` and `ConnectorValidationCommandTests`
exercise symbol binding, parameter order, unsupported inputs, original error
locations, write-if-changed output and stale-manifest rejection. The real MSBuild
integration fixture is documented in `tests\GeneratedConnectorParity\README.md`.
Generated source substitution remains available through the parity hook and
passes through SDK-build injection.

The pre-existing regression cases are
`RuntimeDescriptorTests.RawDelegatesFailWithoutExecuting`,
`RuntimeDescriptorTests.RequiredArgumentsRejectNullButOptionalFieldsAreOmitted`,
and, in the CSharpExpressionTests project,
`GeneratedConnectorCSharpExpressionTests.Office365ReplyTo_BodyOmissionDoesNotSkipRequiredArgumentValidation`.
The independent matrix cases prevent one failed assertion from hiding other
connector families or optional-argument failures.

This is a representative behavioral gate, not an exhaustive catalog proof or a
hosted E2E run. A replacement still needs the full expression suites and E2E
definition comparison. If it derives requiredness from method signatures, audit
that rule against the entire generated catalog rather than assuming it matches
the existing validation flags.

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

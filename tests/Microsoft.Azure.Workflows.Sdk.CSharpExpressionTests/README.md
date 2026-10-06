# Source-compiled C# action regressions

This project authors inline lambdas at the SDK's `[WorkflowExpression]` parameters.
The repository build targets run the real source compiler before the test assembly
is built. Assertions inspect serialized action, trigger, or workflow definitions;
executable values use a single `#{...}` envelope, not template-language fallback.
`EmittedExpressionCompiler` only evaluates already-emitted C# in a local fixture. It
does not generate descriptors, translate expression trees, or certify backend support.

Run from the repository root:

```powershell
dotnet test .\tests\Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests\Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.csproj
```

## Coverage retained and migrated

- `BuiltInActionSerializationTests`, `StatefulActionSerializationTests`, and
  `GeneratedConnectorCSharpExpressionTests` retain the existing designer-schema,
  workflow graph, custom-code registration, optional-input, header/query/body,
  trigger fetch/subscribe, enum, path, and base64 regressions. Executable-header
  rejection now goes through an actual Response action.
- `SourceExpressionSelectionTests` migrates the hybrid suite's meaningful cases:
  typed receivers/operands, collections, conditional receivers, local names that
  resemble workflow members, JSON token types, and native equality. It explicitly
  checks that native token/object equality is **not** rewritten to deep equality.
- `NativeMethodSerializationTests` migrates additional string/array overloads,
  predicates, Math/LINQ calls, generic calls, and DateTime/Guid typed input semantics.
  Legacy DateTime/Guid captures are rejected by the current compiler (`WFBUILD003`);
  those equality cases now use workflow values and authored native constructors.
- `SourceEdgeCaseSerializationTests` preserves escaping and control characters,
  workflow-looking strings, null comparison, omitted versus explicit-null inputs,
  and boxed numeric casts through serialized action definitions.
- `StructuredInputSerializationTests` preserves renamed properties when a native
  POCO initializer is evaluated and serialized, plus structural nested JSON,
  primitive types, null, and enum wire values.
- `RuntimeReferenceSerializationTests` preserves real generated action bodies,
  distinct trigger outputs/body, and explicit variable token conversions.
- `RuntimeSourceSerializationTests` migrates static getters/fields, changing runtime
  state, enum single evaluation, actual connector query/path and service-provider
  enum inputs, and construction-time auto-property/field snapshots.

## Retired legacy assertions and active equivalents

The old converter classes and `LegacyExpressionSources.props` import are gone.
These tests no longer compile private converter source into the test assembly.
Duplicate catalogs were removed rather than copying the source compiler's catalog:

| Retired cases | Existing active coverage in `..\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests` |
| --- | --- |
| `CSharpExpressionConverterTests`: scalar constants, folded arithmetic, comparisons, logical/arithmetic operators, interpolation, arrays | `SourceRoutingTests` literal/reference/native-operator theories; `CoreOperatorCatalogTests`; `CoreStringAndMethodCatalogTests`; `SurfaceTests.Q01_Structural_payload_keeps_json_types_and_leaf_routes` |
| `CSharpExpressionConverterOverloadTests`: HTTP method, enum wire values, URI/base64/path transforms | `CoreStringAndMethodCatalogTests.Http_boundary_normalizes_approved_uri_and_method_values`; `CoreEnumCatalogTests`; `CoreEncodingCatalogTests`; `SchemaDestinationCatalogTests` path transform and mixed-path cases; actual generated paths retained here |
| `CSharpImprovedBehaviorTests`: array/dictionary indexing, typed JSON reads, captured null | `CoreStringAndMethodCatalogTests.Captured_collections_are_native_value_snapshots`; `CoreConversionCatalogTests`; `BindingTests.Approved_captures_are_typed_snapshots`; explicit variable reads and null comparisons migrated here |
| Repeated native string/property, coalescing, precedence and bitwise cases | `CoreStringAndMethodCatalogTests`, `CoreOperatorCatalogTests`, `CoreCompositeCatalogTests`; additional native methods migrated here |
| Repeated object/array initialization and JSON intrinsic cases | `SurfaceTests.Q01_Structural_payload_keeps_json_types_and_leaf_routes`; `CoreLiteralAndStructureCatalogTests`; `JsonIntrinsicCompilerTests`; renamed model and mixed-type payloads migrated here |
| Standalone trigger/action/variable references and agent parameters | `SourceRoutingTests.References_preserve_JSON_and_interpolation_preserves_typed_native_source`; `CoreLiteralAndStructureCatalogTests.Actual_managed_trigger_body_is_a_reference`; `SurfaceTests.R07_Variable_reference_uses_variable_name_not_action_name` and actual agent-tool tests; generated body/trigger distinctions migrated here |
| `RuntimeDependentConversionContractTests` and repeated converter-surface runtime cases | Migrated runtime tests here; `BindingTests` capture/static-getter tests; `CoreEnumCatalogTests` conditional, laziness and runtime-method tests; `DiagnosticTests.CB12_Custom_getter_is_rejected_at_its_source_location`; `FinalCatalogGapTests.Captured_instance_service_method_is_rejected_without_invocation` |
| `HybridTemplateCompatibilityTests`: meaningful structured payload, boxed primitive, optional/null and encoding behavior | Migrated action-boundary cases here; `SurfaceTests`; `CoreLiteralAndStructureCatalogTests`; `SourceRoutingTests`; `CoreEncodingCatalogTests`; `SchemaDestinationCatalogTests` |

Assertions requiring WDL selection/interpolation, converter formatting overload
validation, private expression-tree visitor rendering, single-hole interpolation
collapse, implicit object-to-JSON interpolation, or automatic `DeepEquals` rewrites
were retired: those are obsolete behavior, not the current source contract.
Current native interpolation and explicit deep equality remain covered by
`CoreStringAndMethodCatalogTests` and `CoreOperatorCatalogTests`.

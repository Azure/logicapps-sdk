# Source expression contract tests

Run:

```powershell
dotnet test tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests.csproj
```

`ConsumerCompilation` compiles authoring snippets against the real SDK assembly,
calls `ExpressionCompilationTransformer.Transform`, compiles its output, invokes
the consumer's definition-producing entry point, and serializes the real
`FlowTemplateAction.Inputs` with the SDK JSON profile. Successful definition tests
do not substitute a mock SDK or invoke an expression-tree converter.

`LocalNativeHost` separately compiles the emitted expression and supplies real
Newtonsoft `JToken` values through instrumented local workflow accessors. This
verifies local C# semantics, exceptions, and accessor order. It is **not** evidence
of deployed Logic Apps helper behavior, backend formatting, dependency deployment,
or block/async transport support.

`RuntimeDescriptorTests` tests the runtime descriptor API directly; these are not
compiler end-to-end tests and do not implicitly establish catalog coverage.

`LiteralWireEscapingTests` covers the separate raw-value and wire-rendering
paths. Literal strings beginning with `@` receive exactly one additional `@`
at scalar, header, captured-JSON, and structural-member output boundaries.
Known template/native descriptors are not escaped. Reusing a descriptor does
not mutate its snapshot, and native operands, JSON intrinsic inputs, base64
input bytes, and URI argument text retain their raw values. The leading-`@`
transport follows the actual-host literal probe; it does not certify native
C# execution on that host.

## Catalog inventory

`Fixtures\approved-catalog.md` is an unchanged copy of the approved 326-case
catalog. `catalog-coverage.json` retains every original case, its heading and input,
the exact original row or example block, and executable test mappings:

- `locally-covered`: the mapped executable test verifies the local contract;
  this never means backend verified.
- `externally-verified`: preserved package-script or actual-host evidence verifies
  the exact outcome; no local xUnit execution is invented.
- `backend-required`: this local project cannot establish the required backend
  behavior.
- `not-implemented`: no passing executable coverage is claimed here. Mapped
  tests may exist while validation or an implementation fix is pending. This
  label describes missing **passing test coverage**, not necessarily missing
  product implementation. `testResult` distinguishes missing execution from
  observed contract failures.

Catalog IDs are recorded in `Trait("Catalog", "...")` for individual tests and
the first `InlineData` argument for catalog-driven theories. The inventory test
checks the exact original ID set and validates mappings in both directions.
Expectations come from the approved catalog, not from current compiler output.
Native-source assertions compare recursive syntax structure after normalizing
namespace qualification, insignificant trivia, and transparent parenthesized
expression nodes. The trees are never flattened or reparsed after normalization:
operator nesting and associativity remain significant, including within
interpolation holes and switch governing expressions. Literal/template strings,
alignment, formatting, and JSON token types remain significant. Native source
must also parse without syntax errors.

The `Core*CatalogTests` systematically exercise the original literal, reference,
string, operator, conversion, method, structured, enum, encoding, path, and
composite families. They use real SDK actions and preserved catalog source,
including typed local runtime checks, lazy branches, nulls, conversion failures,
and constructor/method call counts. Schema-specific and backend-only gaps remain
explicit; a failing catalog regression is not counted as locally covered.

After a complete test run, regenerate the derived inventory with:

```powershell
node tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\update-catalog-coverage.mjs TestResults\preview-host-json-fix-green.trx
dotnet test tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests.csproj --filter FullyQualifiedName~CatalogCoverageTests
```

The inventory generator reads the existing original catalog records, test
attributes, and actual TRX outcomes. It does not change catalog expectations or
turn a failed/skipped/unexecuted test into passing coverage. A partial TRX cannot
establish coverage for tests missing from that run.

## Current local checkpoint and case-level host evidence

The integrated run `TestResults\preview-host-json-fix-green.trx` finished at
2026-09-18T05:38:01.4184631-07:00 with **635 passed, zero failed, zero skipped**.
The imported run is bound to SDK SHA256
`D55475362C464A21E2DA2A8BE12A96D893208C07AC2DFD14512A2C8559773067`
and compiler SHA256
`42F0284B176BBE875BCA2890DE5FC7B5259AECF7B05B40026C4E5FF486C4897C`.
The 600-, 612-, and 617-test baselines remain in validation history. Five CLI
entry-point regressions cover the final boundary fixes, including reporting an
invalid sidecar version as a diagnostic rather than an uncaught exception.

The current ledger has **304 locally-covered IDs**, **20 externally-verified
IDs (17 package/IDE results and three actual-host results)**,
**1 without complete passing coverage**, and **1 backend-required ID**:
exactly **326 original catalog IDs**, with no changed expectations.
DG02c's existing passing factory test now carries its
explicit catalog trait; its input and assertions were not changed.
IN06 now passes against the real Acceptmission connector's reversed named
string/int arguments, including exact emitted fields and local `hello!`/`4`
results. No non-package local integration cases remain unverified.

The final package matches the current 635-test SDK/compiler pair. Actual Windows
VS Code evidence verifies PK13 for the measured editor configuration, separately
from the command-line design-time simulation. S14/F08 retain their public-host
evidence and X06 has separate local preview-host evidence. The remaining concrete
catalog gates are:

| ID | Remaining evidence |
| --- | --- |
| PK17 | Remaining supported command-line/platform/IDE-host matrix. Windows dotnet SDK 9.0.318 and the measured VS Code configuration passed; Linux/macOS and other IDE configurations remain unverified. |
| I04 | Positive native Condition host/designer support. The preview host returned HTTP 502 NoResponse for both native branches while independent template controls passed yes/no. The older public host instead rejected the native envelope. |

Successful local execution or an unsupported-host rejection is not native-expression
certification. PK17 retains `not-implemented` coverage status despite its partial
external result; this is not an assertion that its production implementation is absent.

## Versioned schema implementation

`Fixtures\catalog-destinations.schema.json` is the explicit version-1 source for
`WorkflowSchemaGenerator.Generate(string)`. Generated APIs use real SDK
`WorkflowExpressionAttribute` parameters and forward descriptors to
`WorkflowSchemaRuntime`; callers keep ordinary lambdas and never add encoding
annotations themselves. `SchemaConsumerCompilation` compiles those generated
files and authored consumers against real SDK metadata before transformation.

Every destination declares its kind, nullability, omission policy, and ordered
transforms. JSON normalization names `compact-json-v1`; closed enums enumerate
their allowed wire values. Raw versus already-encoded input is explicit.
Missing versions, unknown metadata, conflicting whole/member transforms, and
unsupported pass-through are rejected rather than inferred from field names.
Generated model metadata is authoritative for wire names and defaults; it is
not inferred from CLR constructors or `DefaultValueAttribute`.

`SchemaDestinationCatalogTests` maps the new model, encoding, enum, path, and
nested-field fixtures to the original cases. `SchemaGeneratorTests` covers
invalid schema mutations and generated source integrity. `WireProfileTests`
covers the production fixed serializer independently of ambient JSON settings.
X06 retains a separate `LocalContract` test; its `externally-verified` status
comes from the preserved real preview-host response, not that local test.

The schema, generator, fixed-profile, literal-escaping, factory, and dependency
tests pass in the integrated 635-test run above. The 425-test result and archived
package evidence are historical baselines, not validation of the new ABI.

The compiler-driver contract calls `WorkflowSchemaGenerator.Generate` on
declared schema inputs and add its output to the compilation before expression
transformation. For traced/factory delegates, pass the destination parameter to
`SourceDescriptorBuilder.Build(resultType, parameter)` so the generated
destination's source-type and normalization metadata survive provenance tracing.
The existing inline path also resolves that metadata directly. The deployment
gate must approve the generated model dependencies and SDK wire helpers;
declaring a schema does not establish a backend capability.

`DependencyCollectionTests` checks compiler dependency collection after workflow
and capture substitution: helper symbols and actual binding/enum/JSON CLR types
are recorded, but snapshotted object getters are not runtime dependencies.
Candidates include native alternatives; deployment validation must filter them
against actual emitted C# before applying approval policy.

For subsequent validation after a coordinated SDK/compiler build, run:

```powershell
dotnet test tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests.csproj --no-restore -p:BuildProjectReferences=false -p:GeneratePackageOnBuild=false --filter "FullyQualifiedName~SchemaDestinationCatalogTests|FullyQualifiedName~SchemaGeneratorTests|FullyQualifiedName~WireProfileTests"
dotnet test tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests.csproj --no-restore -p:BuildProjectReferences=false -p:GeneratePackageOnBuild=false --logger "trx;LogFileName=source-expression-schema.trx" --results-directory tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\TestResults
node tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\update-catalog-coverage.mjs TestResults\source-expression-schema.trx
```

## Historical expanded core checkpoint

The earlier bounded last-gap run contained **425 tests: 425 passed, zero failed or
skipped**. Its inventory recorded **260 locally-covered IDs, 4 externally-verified
IDs, 58 without passing coverage, and 4 backend-required IDs**. Missing coverage
is not an assertion that product support is absent.
All original 205 tests still pass, and the earlier 198-test baseline is retained.

At that checkpoint, the remaining 62 IDs were classified as follows. These are
historical gap counts, superseded by the current local checkpoint above:

| Classification | Count | Meaning |
| --- | ---: | --- |
| Uncovered local variants | 4 | Missing exact-case coverage; implementation support is not assessed. |
| Unverified local feature targets | 1 | DG02c source-visible factory tracing remains unverified. |
| External schema fixtures | 32 | Matching real metadata/destination fixtures are missing; no mock-schema success. |
| External build integration | 14 | Additional package, CLI, IDE, or build-matrix evidence is missing; PK02 is only partial. |
| External deployment evidence | 4 | Approved/denied/missing dependency deployment must be verified. |
| External backend/host-capability evidence | 7 | Four require actual backend evidence; three need an unsupported-host capability/deployment fixture. |

B15c was a local serializer-profile/schema-fixture gap, not an inherently
backend-required case. Its full object/array variants now pass in the 617-test run.

Verified unsupported local forms are recorded separately, **within passing
coverage**, as `unsupported-form-rejection-verified`:
L14, P04c, Q06, Q08, F02, F03, F04, SR13, SR14, CB10, CB12, DG01b, DG02b, DG03,
DG04, DG06, DG10, DG11. These 18 cases prove the specified rejection, not execution support for
the rejected form. Ordinary validation rejections are distinguished separately.

Full results are in `TestResults\source-expression-response-final.trx`; per-ID outcomes
and observed referenced-assembly hashes are persisted in the inventory. This
checkpoint follows coordinated fresh compiler and SDK builds; the final test run
used `BuildProjectReferences=false` against those outputs. The checked-in catalog
snapshot remains byte-identical to the approved original.
Per-run assembly hashes are retained when regenerating the ledger, so later
shared-output rebuilds cannot silently relabel an older result's provenance.

The previous 329-test checkpoint had 20 failures. Its 16 generated Servicebus
base64 conversion, raw-byte, and null failures now pass unchanged after the fresh
build. The runtime JSON-intrinsic contribution also builds and passes.
S11 now compiles and executes the unchanged catalog input and expected result;
its source comparison permits the qualification-required interpolation grouping.
Dedicated comparison tests verify that this does not ignore interior arithmetic
precedence or change literal contents.
Enum ABI integration now passes. E08/X03 require a direct known wire-string
branch, lazy evaluation, all declared wire values, the undefined-value fallback,
and exactly one opaque enum-method call on the selected branch. As permitted by
the catalog, equivalent opaque-result mapping does not require identical switch
syntax.
The nullable-to-nonnullable enum cast regression additionally verifies that a
null selected value still throws `InvalidOperationException`, both at enum-wire
boundaries and within numeric consumers; the original native cast is retained.

The subsequent D16 guard regression checks non-`async` lambdas returning
`Task<string>`, `Task`, `ValueTask<string>`, and `ValueTask`. Each original consumer
must compile, then transformation must report `WFBUILD006` at the lambda.
The four new cases and four existing block/async cases passed together against
a fresh compiler build (`TestResults\task-result-guard.trx`). They use
`Trait("Decision", "D16")`, not a fabricated catalog case ID. The existing
catalog-authored block/async cases additionally establish DG06 coverage.

Additional source-fidelity regressions cover single-line and multiline raw
interpolation, including `$$$"""{{Name}}: {{{source.Output}}}"""`, alongside
regular and verbatim interpolation. Raw literal double braces stay doubled;
regular/verbatim escaped braces collapse once. These four cases and thirteen
existing reference/interpolation cases passed after a fresh compiler build
(`TestResults\raw-interpolation.trx`). They do not invent new catalog IDs.

`JsonIntrinsicCompilerTests` uses the actual SDK generic and nongeneric
`WorkflowFunctions.ToJson` methods. U10/U11 verify template/native lowering;
additional cases cover final names, nested native consumers, typed DTO
materialization, and malformed literals that must not be parsed at generation.
The local host's lowercase `json` function only executes emitted helper syntax;
it does not substitute a fake authoring API or claim backend verification.

`FieldAndCaptureSafetyTests` verifies actual SDK action handles held in static,
local-holder, and instance fields. Prefix/postfix increments, assignments, and
`ref`/`out`/`in` use of captured locals must report `WFBUILD003` before snapshot
substitution. These regression variants are not assigned invented catalog IDs.

## Last bounded pass and concrete remaining failures

The requested cases now passing are P04, DG01, DG01b, F03, F09, I03, I05, I06,
I07, I08, I10, SR20, CB11, CB15, IN05, IN08, IN09, IN10, IN12, IN13, DG08, DG10,
U10, U11. The final two
already had actual SDK intrinsic tests before this pass.

The earlier P04/DG01 Expression-local compatibility and I07/I08/IN12 typed
ForEach API failures now pass unchanged against the matching updated SDK and
compiler. No JToken conversion wrapper or substitute collection type was
inserted in these tests. I10/IN05 require an unwrapped meaningful
`ArgumentOutOfRangeException` and no emitted definition for explicit status zero;
both omitted and explicit-null status arguments retain the default 200.

B18/F07 were uncovered in this checkpoint: the available Servicebus base64 surface accepts
`Func<JToken>`, not raw `MemoryStream`, and does not supply the catalog's
text-only destination-aware rejection fixture. An **unmapped** API probe records
that limitation. IN11 was uncovered because the exact generated
`/items/{0}` path fixture was not found; the different Servicebus path tests are
not relabeled as that case. Both now have passing explicit versioned-schema
tests in the integrated 617-test run.

## Actual local Logic Apps host evidence

`Fixtures\host-runtime-1.170.91` preserves the actual `en-US` and `fr-FR`
observations from Functions **4.1052.200.26352**, Workflow bundle **1.170.91**,
completed at **2026-09-18T11:08:46.5852718Z** and
**2026-09-18T11:10:06.7231829Z**, respectively. These are workflow-engine HTTP
results, not the local Roslyn execution host and not xUnit host execution.

S14's SDK-generated body is exactly `Received request: @{triggerBody()}`.
Both instrumented host cultures returned HTTP 200 and these measured strings:

| JSON request | Exact response body |
| --- | --- |
| `null` | `"Received request: "` (retains the trailing space) |
| `"hello"` | `"Received request: hello"` |
| `42` | `"Received request: 42"` |
| `true` | `"Received request: True"` |
| `{"n":1}` | `"Received request: {\"n\":1}"` |
| `[1,2]` | `"Received request: [1,2]"` |

F08's SDK-generated definition stores `@@csharp{1 + 2}`. Both host processes
returned the exact literal `@csharp{1 + 2}`, not `3`.
S14 and F08 are therefore `externally-verified` for this measured local profile.
Neither result certifies cloud deployment, designer compatibility, or execution
of native C# expressions.

The manifest hashes both result files, all four probe definitions, the exact
original-input generator `Program.cs`, reproduction projects, `Probe.ps1`, and
the culture startup-hook source. The probe checks that the instrumentation PID
owns the listening loopback endpoint before requests are made. SDK/consumer
assembly hashes are explicitly **observed at import**; definition hashes bind
the actual host results. The older `hostlab\culture-hook` source differs from
the repository's evidence-writing hook and is not mislabeled as that source.

Only two plain `NativeProbe`/`ConditionProbe` validation-error lines were
extracted into `native-validation.log.txt`. No callback credentials, host
settings, or full boot logs are preserved. The actual parser rejected the native
envelope's `{` character. I04 and X06 were blocked on this public profile.
The separate preview-host X06 result below does not change that historical
observation or establish native execution on the public bundle.

`host-evidence.mjs` verifies hashes, exact definitions, both cultures, all twelve
S14 responses, both F08 responses, and the bounded negative excerpt before
ledger promotion. The xUnit evidence-integrity check verifies these files;
it does not claim to run the workflow engine. It now passes in the 617-test
integrated run, which supersedes the initial missing-reference build blocker.

## Actual local preview-host X06 evidence

`Fixtures\host-native-preview` preserves a sanitized observation file, five
hash-matched workflow definitions, and repository `SourceNativeHostConsumer`
source/project/schema/probe snapshots. The measured Functions runtime was
**4.51.100.26305**, with preview workflow components **1.187.0.10**; the probe
completed at **2026-09-18T12:39:10.3241777Z**. This is a separately supplied
codeful runtime, not public bundle 1.170.91, and not cloud/designer certification.

X06's real generated Compose action receives Count `3` and Source `"A"`,
serializes `new { Next = count.Output + 1, Label = source.Output }`, and encodes
it once. HTTP 200 returned exactly `eyJOZXh0Ijo0LCJMYWJlbCI6IkEifQ==`,
whose UTF-8 decoded bytes are exactly `{"Next":4,"Label":"A"}`.
The native fragment uses `JToken.FromObject` with explicit
`JsonSerializer.Create(settings)` and no generated SDK helper reference.

**The complete probe failed with reported exit code 1:** five observations
passed and two native Condition observations failed. Both native Condition
branches returned HTTP 502 `NoResponse`; their independent template controls
returned `yes`/`no`. Arithmetic returned `3` and the JSON intrinsic returned
`{"LABEL":"A"}`, but those additional observations promote no other catalog rows.
I04 remains blocked, including designer verification.

The snapshot removes private runtime assembly inventory entries and redacts
failure request-tracking identifiers, while retaining every outcome and
definition hash. No private binaries, archives, acquisition/internal PR URLs,
branch details, or callback credentials are copied. The manifest records the
original probe hash and sanitization steps. SDK deployment identity is present
in the probe; compiler and repository-source hashes are explicitly observed at
import, not independently attested at definition generation.

`native-host-evidence.mjs` verifies the artifact hashes, exact X06 operands and
response bytes, and both failures/controls before case-level promotion.
The evidence-integrity assertions inspect preserved files; they do not run
the host. This new evidence-import revision awaits the parent's integrity rerun.

## External package evidence

The final package/IDE evidence completed at **2026-09-18T13:26:55.3793675Z**.
Its package SHA256 is
`7F1BC5DE34316BF878DD4280C2B4E03459FD3D6755A7A041E05AEEBB539C1DFA`,
with the SDK/compiler hashes from the current 635-test run. The package was
created with `pack --no-build --no-restore -c Debug`; the consumer validation
used Release. No newer compilation is inferred from packaging alone.
The expanded command-line evidence
records **97 commands, 39 case records (38 passed and one partial), and zero
failed checks**. These include additional non-catalog checks; 39 is not a count
of passing catalog rows. Expected negative commands retain their nonzero exits.

PK01-PK11, PK13-PK14, and PK18-PK20 are externally verified. PK12 is externally
verified only for the catalog-permitted generator-rejection outcome, not for
arbitrary-generator positive support. PK15 and PK16 remain independently
locally covered; package records that leave them unverified do not replace their
passing source-test evidence. The command-line matrix's PK13 record remains
partial; the independent actual VS Code evidence establishes its tested IDE
contract. PK17 remains partial overall, not a passing catalog row.

PK02 now verifies exact CB01 output, zero reads at the first authoring
expression-body operation through serialization, and a positive counter control
that observes one read. Its source hash is preserved with the executed consumer
command, exit code, and log; it is no longer inferred only from matching output.

`Fixtures\package-*` preserves exact provenance, per-PK mapping, aggregate log,
validator bytes, and the successful repository Worker log.
`Fixtures\package-expanded` preserves the expanded manifest, all 97 command logs,
validators, and original source fixtures. The project explicitly excludes those
fixture `.cs` files from compilation and copies them as evidence instead.
`Fixtures\package-support` preserves the finalization, pack, build-assets, and
other supporting text artifacts. `Fixtures\package-ide` preserves the actual
editor observations/provenance, logs, package-only consumer, extension-host
probe source, and counter-control sentinel. No VS Code binaries, installed
extensions, or user-data directories are copied.
`package-final-snapshot.json` records hashes for all 166 supplied artifact copies,
verified against the source files at import; it is not a separate execution
attestation. A narrowly scoped `.gitignore` exception keeps the evidence logs
available for version control rather than silently dropping them.
Fixture `.gitattributes` disables line-ending conversion so checkout cannot
invalidate byte-exact catalog or evidence hashes.
Original absolute paths remain unchanged in the supplied JSON; persistent
snapshot locations are recorded in the ledger's `artifacts` object.
`package-evidence.mjs` resolves those paths to the preserved log/source snapshots
and verifies their hashes, catalog rows, command/exit associations, package
identity, and remaining limitations before promoting coverage.

The package hash was independently checked at import; the binary package is not
copied into this test project. The xUnit integrity test verifies preserved files,
**not** execution of the package matrix or editor as xUnit. Updating these
evidence checks does not retroactively claim they ran in the recorded 635-test
baseline; the parent owns the subsequent integrity/full-suite rerun.

This evidence applies to the pinned package, not arbitrary later binaries.
The old `0E3B667C...`, `04977273...`, and `0DB62EAC...` snapshots remain under
`Fixtures\package-history`. Existing sample generation was explicitly excluded;
earlier failing ParallelBranch sample evidence is not converted into a passing
full-sample claim. Real COM interop execution for `EmbedInteropTypes` also remains
unverified; metadata plumbing checks are not a substitute.

### Actual Windows VS Code evidence

The isolated **VS Code 1.137.0 / C# extension 2.160.4** run completed at
**2026-09-18T13:20:19.7754893Z** against the final pinned package. Before and
after an actual `vscode.tasks.executeTask` integrated build, the extension-host
probe measured the semantic SDK Compose hover, Compose and ToUpperInvariant
completions, and exactly one error for an unsaved `missingName` edit at the
original source range. Reverting restored clean error diagnostics; no duplicate
generated-source errors or authoring getter execution occurred.

The built application returned exact CB01. Its authoring-execution sentinel
remained absent until the explicit positive-control run, which wrote exactly
`read\n`. The preserved test source, source hash, command exits, diagnostics,
completions, hover results, and sentinel are checked by `ide-evidence.mjs`
before PK13 promotion. This is real editor execution, not a mocked LSP or a
command-line design-time build relabeled as IDE coverage.

The result covers the measured Windows VS Code configuration only. Visual
Studio, other editor configurations, Linux, and macOS are not certified.
PK17's remaining platform evidence is still pending; alternative investigations
do not count as completed validation.

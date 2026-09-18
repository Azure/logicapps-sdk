import fs from 'node:fs';
import path from 'node:path';
import { createHash } from 'node:crypto';
import { fileURLToPath } from 'node:url';
import { readHostEvidence } from './host-evidence.mjs';
import { readPackageEvidence } from './package-evidence.mjs';
import { readNativeHostEvidence } from './native-host-evidence.mjs';

const root = path.dirname(fileURLToPath(import.meta.url));
if (process.argv.length !== 3) throw new Error('Usage: node update-catalog-coverage.mjs <project-relative TRX>');
const trxPath = path.resolve(root, process.argv[2]);
const trx = fs.readFileSync(trxPath, 'utf8');
const ledgerPath = path.join(root, 'catalog-coverage.json');
const ledger = JSON.parse(fs.readFileSync(ledgerPath, 'utf8'));
const catalogIds = new Set(ledger.cases.map(row => row.id));
const methods = new Map();
const mappings = new Map();
const { files: externalFiles, provenance: externalProvenance, cases: externalCases, expanded, ide } = readPackageEvidence(root);
const packageCases = new Map(externalCases.cases.map(row => [row.id, row]));
const hostEvidence = readHostEvidence(root);
const nativeHostEvidence = readNativeHostEvidence(root);
const backendEvidence = new Set(['S14', 'F08', 'I04', 'X06']);
const hostCapabilityEvidence = new Set(['F08b', 'I04b', 'DG07']);
const schemaFixtures = new Set([
    'Q04', 'Q04b', 'Q04c', 'Q06b', 'Q09', 'E09b', 'E13e', 'E13f',
    'B08', 'B09', 'B10', 'B13', 'B13b', 'B15', 'B15b', 'B15c', 'B17c',
    'B18', 'B19b', 'B19c', 'B22', 'U04', 'U05', 'U06', 'U07', 'U08', 'U09',
    'F07', 'IN06', 'IN11', 'IN15', 'IN16',
]);
const deploymentEvidence = new Set(['SC03', 'SC03b', 'SC04', 'DG05']);
const localFeatureTargets = new Set(['P04', 'DG01', 'DG02c']);
const unsupportedForms = new Map([
    ...['F02', 'SR13', 'SR14', 'CB10', 'DG06'].map(id => [id, 'Unverified block/async execution-host transport']),
    ...['L14', 'F04', 'CB12', 'DG04'].map(id => [id, 'Captured custom getter evaluation']),
    ['P04c', 'Runtime-loaded delegate source recovery'],
    ['Q06', 'Executable expression at generation-time dictionary boundary'],
    ['Q08', 'Whole captured POCO without supported serialization boundary'],
    ['DG02b', 'Ambiguous delegate origin'],
    ['DG03', 'Captured stream'],
    ['DG11', 'Executable action-handle resolution'],
    ['DG10', 'Captured instance/service invocation without an approved binding'],
    ['F03', 'Runtime-constructed expression-tree authoring'],
    ['DG01b', 'Runtime-loaded expression-tree authoring'],
]);
const validationRejections = new Set(['F01', 'DG12', 'M06', 'E13', 'PK15', 'I10', 'IN05']);
const decode = value => value.replace(/&quot;/g, '"').replace(/&apos;/g, "'")
    .replace(/&lt;/g, '<').replace(/&gt;/g, '>').replace(/&amp;/g, '&');

for (const file of fs.readdirSync(root).filter(name => name.endsWith('Tests.cs'))) {
    const source = fs.readFileSync(path.join(root, file), 'utf8');
    for (const match of source.matchAll(/\[(?:Fact|Theory)\b([\s\S]*?)\bpublic\s+(?:async\s+)?(?:void|Task)\s+(\w+)\s*\(/g)) {
        const method = file.slice(0, -3) + '.' + match[2];
        const traits = [...match[1].matchAll(/Trait\("Catalog",\s*"([A-Z]+\d+[a-z]?)"\)/g)].map(m => m[1]);
        const inline = [...match[1].matchAll(/InlineData\(\s*"([A-Z]+\d+[a-z]?)"/g)].map(m => m[1]);
        const variants = [...match[1].matchAll(/InlineData\(/g)].length || 1;
        methods.set(method, { traits, inline, variants });
        for (const id of [...traits, ...inline]) {
            if (!catalogIds.has(id)) throw new Error(`Unknown catalog ID ${id}: ${method}`);
            if (!mappings.has(id)) mappings.set(id, new Set());
            mappings.get(id).add(method);
        }
    }
}

const observations = new Map();
for (const match of trx.matchAll(/<UnitTestResult\b([^>]+?)(?:\/>|>([\s\S]*?)<\/UnitTestResult>)/g)) {
    const name = decode(match[1].match(/\btestName="([^"]+)"/)?.[1] ?? '');
    const outcome = match[1].match(/\boutcome="([^"]+)"/)?.[1];
    const message = decode(match[2]?.match(/<Message>([\s\S]*?)<\/Message>/)?.[1] ?? '');
    if (!name || !outcome) throw new Error('TRX result is missing testName or outcome.');
    const method = name.split('(')[0].split('.').slice(-2).join('.');
    const attributes = methods.get(method);
    if (!attributes) continue;
    const inlineId = name.match(/\([^:]+:\s*"([A-Z]+\d+[a-z]?)"/)?.[1];
    const ids = new Set(attributes.traits);
    if (inlineId && attributes.inline.includes(inlineId)) ids.add(inlineId);
    for (const id of ids) {
        if (!observations.has(id)) observations.set(id, []);
        observations.get(id).push({ method, outcome, message });
    }
}

for (const row of ledger.cases) {
    row.tests = [...(mappings.get(row.id) ?? [])].sort();
    const results = observations.get(row.id) ?? [];
    const complete = row.tests.length > 0 && row.tests.every(method => {
        const attributes = methods.get(method);
        const expected = attributes.traits.includes(row.id)
            ? attributes.variants : attributes.inline.filter(id => id === row.id).length;
        return results.filter(result => result.method === method).length === expected;
    });
    const passed = results.filter(result => result.outcome === 'Passed').length;
    const failed = results.filter(result => result.outcome === 'Failed').length;
    const other = results.length - passed - failed;
    const outcome = failed ? 'failed' : complete && !other ? 'passed' : 'not-verified';
    row.testResult = { outcome, passed, failed, other, evidence: path.relative(root, trxPath) };
    if (failed) row.testResult.failures = results.filter(result => result.outcome === 'Failed')
        .map(({ method, message }) => ({ method, message }));
    if (backendEvidence.has(row.id)) {
        row.status = 'backend-required';
        row.verification = 'The approved case requires actual host behavior or deployment evidence; local helper execution does not establish that contract.';
    } else if (outcome === 'passed') {
        row.status = 'locally-covered';
        row.verification = 'Passing executable local compiler/real-SDK definition or explicitly local runtime assertion; no backend verification.';
    } else {
        row.status = 'not-implemented';
        row.verification = failed
            ? 'An executable local regression fails the approved contract; see the TRX failure. Passing coverage is not claimed.'
            : 'Passing executable coverage is missing or was not observed in this run. Product implementation support is not inferred from this coverage status.';
    }
    row.externalValidation = packageCases.has(row.id) ? {
        evidenceKind: externalCases.evidenceKind,
        ...packageCases.get(row.id),
        artifacts: externalFiles,
        completedUtc: externalProvenance.completedUtc,
        packageSha256: externalProvenance.packageSha256,
        runtimeSha256: externalCases.runtimeSha256,
        compilerSha256: externalCases.compilerSha256,
    } : null;
    if (hostEvidence.cases.has(row.id))
        row.externalValidation = hostEvidence.cases.get(row.id);
    if (nativeHostEvidence.cases.has(row.id))
        row.externalValidation = nativeHostEvidence.cases.get(row.id);
    if (row.status !== 'locally-covered' && ['passed', 'negative-case-passed'].includes(row.externalValidation?.status)) {
        row.status = 'externally-verified';
        row.verification = row.externalValidation.evidenceKind === 'actual-local-logicapps-codeful-runtime'
            ? 'X06 verified by exact HTTP response and decoded JSON on the measured local preview codeful host, with hash-checked definitions and sanitized evidence. The complete probe failed its two native Condition cases; no overall probe, public-bundle, cloud, or designer success is claimed.'
            : row.externalValidation.evidenceKind === 'actual-local-logicapps-runtime'
            ? 'Verified by preserved actual local Logic Apps host observations in en-US and fr-FR, with hashed generated definitions and reproduction provenance. Not mocked, not xUnit host execution, and not cloud/designer or native-expression certification.'
            : 'Verified by the preserved external package script, commands, exit codes, and hashed logs; not an xUnit/local-source-test coverage claim.';
    }
    row.localFeatureState = row.status === 'externally-verified' ? 'external-contract-verified'
        : row.status !== 'locally-covered' ? (failed ? 'contract-failure-observed' : 'not-assessed')
        : unsupportedForms.has(row.id) ? 'unsupported-form-rejection-verified'
        : validationRejections.has(row.id) ? 'validation-rejection-verified' : 'contract-verified';
    row.unsupportedForm = row.localFeatureState === 'unsupported-form-rejection-verified'
        ? unsupportedForms.get(row.id) : null;
    row.coverageGap = null;
    if (row.status !== 'locally-covered' && row.status !== 'externally-verified') {
        let category = 'uncovered-local-variant';
        let reason = 'This exact case has no recorded passing executable coverage here; no product-support conclusion is drawn.';
        if (backendEvidence.has(row.id) || hostCapabilityEvidence.has(row.id)) {
            category = 'external-backend-gate';
            reason = 'Requires documented actual-host behavior or an unsupported-host capability/deployment fixture, not an assumed local .NET equivalent.';
        } else if (schemaFixtures.has(row.id)) {
            category = 'external-schema-gate';
            reason = 'Requires a matching real destination/schema fixture with the specified field types, names, encoding order, validation policy, or authoritative metadata. No mock-schema success is claimed.';
        } else if (/^PK\d+$/.test(row.id)) {
            category = 'external-build-gate';
            reason = 'Requires package/CLI/IDE/build-matrix execution outside this local source-test harness. Other workstreams are not silently counted as local test coverage.';
        } else if (deploymentEvidence.has(row.id)) {
            category = 'external-deployment-gate';
            reason = 'Requires an approved/denied/missing helper dependency deployment fixture and evidence of the specified deployment or host failure.';
        } else if (localFeatureTargets.has(row.id)) {
            category = 'local-feature-target-unverified';
            reason = 'The requested source-provenance/unchanged-authoring compatibility target is not verified here. This is not merely a literal/operator variant, nor proof of current product support or rejection.';
        }
        if (row.id === 'B15c') reason = 'Ambient serializer-profile independence is locally testable, not inherently a backend gate. The full case still needs matching real encoded object/array destination fixtures for B15/B15b; direct runtime safety tests alone do not establish that source-pipeline coverage.';
        if (row.id === 'B18' || row.id === 'F07') reason = 'No matching text-only encoded destination fixture is established. The available Servicebus Func<JToken> content API rejects raw MemoryStream with CS0029 before destination normalization; the unmapped API probe does not prove the catalog-required destination-aware NotSupportedException.';
        if (row.id === 'IN11') reason = 'No matching real generated /items/{0} path fixture was found. Existing Servicebus path tests use a different path and are deliberately not relabeled as this exact case.';
        if (row.tests.some(test => test.startsWith('SchemaDestinationCatalogTests.'))) {
            category = 'local-feature-target-unverified';
            reason = 'An explicit version-1 schema, SDK-owned generator/runtime, and matching real-SDK source-pipeline test now exist. Passing integration execution against the new SDK/compiler ABI is not yet recorded; historical assembly/package results do not validate these changes.';
        }
        if (row.externalValidation?.status === 'unsupported-host' || row.externalValidation?.status === 'blocked-host')
            reason = row.externalValidation.reason;
        if (/^PK\d+$/.test(row.id) && row.externalValidation)
            reason = row.externalValidation.unverified ?? row.externalValidation.reason ?? reason;
        if (failed) {
            category = 'observed-local-contract-gap';
            reason = 'The exact executable case currently fails its approved contract; see testResult.failures. ' + reason;
        }
        row.coverageGap = { category, reason, implementationSupport: failed ? 'observed-contract-gap' : 'not-assessed' };
    }
}

ledger.statusMeaning = {
    'locally-covered': 'Matching executable local tests passed. No backend verification is implied.',
    'externally-verified': 'Exact approved outcome verified by preserved external package/script or actual-host provenance, not by an invented local xUnit test.',
    'not-implemented': 'Passing executable test coverage is missing; this does not necessarily mean missing product implementation. testResult identifies observed failures.',
    'backend-required': 'The required backend assertion is not established by this local host.',
};
ledger.coverageSummary = {
    catalogCases: ledger.cases.length,
    locallyCovered: ledger.cases.filter(row => row.status === 'locally-covered').length,
    externallyVerified: ledger.cases.filter(row => row.status === 'externally-verified').map(row => row.id),
    notImplementedCoverage: ledger.cases.filter(row => row.status === 'not-implemented').length,
    backendRequired: ledger.cases.filter(row => row.status === 'backend-required').length,
    verifiedUnsupportedForms: ledger.cases.filter(row => row.localFeatureState === 'unsupported-form-rejection-verified')
        .map(row => row.id),
    gapsByCategory: Object.fromEntries([...new Set(ledger.cases.filter(row => row.coverageGap)
        .map(row => row.coverageGap.category))].sort().map(category => {
        const ids = ledger.cases.filter(row => row.coverageGap?.category === category).map(row => row.id);
        return [category, { count: ids.length, ids }];
    })),
};
const counters = trx.match(/<Counters\b([^>]+)\/>/)?.[1];
if (!counters) throw new Error('TRX counters missing.');
const count = name => Number(counters.match(new RegExp(`\\b${name}="(\\d+)"`))?.[1] ?? 0);
const finish = trx.match(/<Times\b[^>]*\bfinish="([^"]+)"/)?.[1];
const validation = {
    evidence: path.relative(root, trxPath),
    finished: finish,
    total: count('total'),
    passed: count('passed'),
    failed: count('failed'),
    notExecuted: count('notExecuted'),
    note: 'Actual local TRX results. Coverage requires all mapped methods to have observed passing results.',
};
ledger.validationHistory ??= [];
if (ledger.validation?.validatedAt && !ledger.validationHistory.some(entry =>
    entry.validatedAt === ledger.validation.validatedAt || entry.finished === ledger.validation.validatedAt))
    ledger.validationHistory.push({ ...ledger.validation, evidence: ledger.validation.evidence ?? 'TestResults\\source-expression.trx' });
if (!ledger.validationHistory.some(entry => entry.evidence === validation.evidence && entry.finished === finish))
    ledger.validationHistory.push(validation);
for (const entry of ledger.validationHistory) {
    if (entry.evidence === validation.evidence && (entry.finished ?? entry.validatedAt) !== finish)
        entry.evidenceSuperseded = true;
}
ledger.latestValidation = validation;
ledger.validation = {
    validatedAt: finish,
    projectTests: validation.total,
    passed: validation.passed,
    failed: validation.failed,
    notExecuted: validation.notExecuted,
    evidence: validation.evidence,
    notes: 'Current local test outcomes; not backend verification. Earlier completed baselines are retained in validationHistory.',
};
const storage = trx.match(/<UnitTest\b[^>]*\bstorage="([^"]+)"/)?.[1];
if (!storage) throw new Error('TRX test assembly storage path missing.');
const output = path.dirname(decode(storage));
const recordedRun = ledger.validationHistory.find(entry => entry.evidence === validation.evidence && entry.finished === finish);
recordedRun.assemblyHashesObservedAfterRun ??= Object.fromEntries(
    ['Microsoft.Azure.Workflows.Sdk.dll', 'Microsoft.Azure.Workflows.Sdk.Build.dll'].map(name => {
        const file = path.join(output, name);
        return [name, { path: path.relative(root, file), sha256: createHash('sha256').update(fs.readFileSync(file)).digest('hex') }];
    }));
ledger.referencedAssembliesObservedAfterRun = recordedRun.assemblyHashesObservedAfterRun;
ledger.externalPackageEvidence = {
    artifacts: externalFiles,
    completedUtc: externalProvenance.completedUtc,
    packageSha256: externalProvenance.packageSha256,
    runtimeSha256: externalCases.runtimeSha256,
    compilerSha256: externalCases.compilerSha256,
    expandedCommandCount: expanded.commands.length,
    expandedCaseCount: expanded.cases.length,
    expandedCaseStatuses: Object.fromEntries([...new Set(expanded.cases.map(row => row.status))]
        .map(status => [status, expanded.cases.filter(row => row.status === status).length])),
    failedChecks: expanded.failedChecks,
    unverifiedContracts: externalCases.remainingGaps,
    matrixUnverifiedContracts: expanded.unverifiedContracts,
    actualIde: ide,
    matchesLatestLocalAssemblies:
        externalCases.runtimeSha256.toLowerCase() === ledger.referencedAssembliesObservedAfterRun['Microsoft.Azure.Workflows.Sdk.dll'].sha256 &&
        externalCases.compilerSha256.toLowerCase() === ledger.referencedAssembliesObservedAfterRun['Microsoft.Azure.Workflows.Sdk.Build.dll'].sha256,
    scope: 'Pinned external package snapshot only; never inferred as verification of later binaries.',
};
ledger.externalHostEvidence = hostEvidence.summary;
ledger.externalNativeHostEvidence = nativeHostEvidence.summary;
fs.writeFileSync(ledgerPath, JSON.stringify(ledger, null, 2) + '\n');
console.log(JSON.stringify({
    ...validation,
    coverage: Object.fromEntries(['locally-covered', 'externally-verified', 'not-implemented', 'backend-required']
        .map(status => [status, ledger.cases.filter(row => row.status === status).length])),
    failingIds: ledger.cases.filter(row => row.testResult.outcome === 'failed').map(row => row.id),
}, null, 2));

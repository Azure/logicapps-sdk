import fs from 'node:fs';
import path from 'node:path';
import { createHash } from 'node:crypto';

const relativeDirectory = 'Fixtures\\host-native-preview';
const names = ['NativeProbe', 'ConditionProbe', 'ConditionTemplateControl', 'EncodedJsonProbe', 'JsonIntrinsicProbe'];
const files = [
    'observations.json', ...names.map(name => `${name}.workflow.json`),
    'Program.cs.txt', 'Probe.ps1.txt', 'SourceNativeHostConsumer.csproj.txt',
    'destinations.schema.json.txt', 'README.md.txt', 'reproduction.txt',
];

/** Imports case-level observations, never the unsuccessful probe as an overall pass. */
export function readNativeHostEvidence(root) {
    const directory = path.join(root, relativeDirectory);
    const read = file => fs.readFileSync(path.join(directory, file), 'utf8').replace(/^\uFEFF/, '');
    const json = file => JSON.parse(read(file));
    const hash = file => createHash('sha256').update(fs.readFileSync(path.join(directory, file))).digest('hex').toUpperCase();
    const require = (condition, detail) => { if (!condition) throw new Error(`Native host evidence validation failed: ${detail}`); };
    const manifest = json('manifest.json');
    const record = json('observations.json');
    require(manifest.version === 1 && manifest.evidenceKind === 'actual-local-logicapps-codeful-runtime' &&
        record.evidenceKind === manifest.evidenceKind && record.version === 1, 'version/kind');
    require(JSON.stringify(manifest.artifacts.map(item => item.file).sort()) === JSON.stringify([...files].sort()), 'safe artifact set');
    for (const artifact of manifest.artifacts)
        require(hash(artifact.file) === artifact.sha256, `hash for ${artifact.file}`);
    require(record.runtime === '4.51.100.26305' && manifest.previewComponentVersion === '1.187.0.10', 'measured runtime versions');
    require(manifest.reportedProbeExitCode === 1 && manifest.overallOutcome === 'failed', 'overall probe remains failed');
    require(record.processIds.length > 0 && record.processIds.every(pid => Number.isInteger(pid) && pid > 0), 'listener process IDs');
    require(record.definitions.length === names.length && new Set(record.definitions.map(item => item.name)).size === names.length, 'definition set');
    for (const definition of record.definitions)
        require(names.includes(definition.name) && definition.sha256 === hash(`${definition.name}.workflow.json`), `observed ${definition.name}`);
    require(record.assemblies.length === 2 &&
        record.assemblies.every(item => ['lib\\codeful\\Microsoft.Azure.Workflows.Sdk.dll', 'lib\\codeful\\SourceNativeHostConsumer.dll'].includes(item.path)),
        'only SDK/consumer assembly metadata is preserved');
    const sdk = record.assemblies.find(item => item.path.endsWith('\\Microsoft.Azure.Workflows.Sdk.dll'));
    require(sdk?.sha256 === manifest.generationProvenance.sdkSha256, 'observed deployed SDK hash');
    const results = new Map(record.results.map(item => [item.name, item]));
    require(record.results.length === 7 && results.size === 7 &&
        record.results.filter(item => item.passed === true).length === 5 &&
        record.results.filter(item => item.passed === false).length === 2, 'mixed probe outcomes');
    for (const [name, body] of [
        ['native-arithmetic', '3'], ['encoded-json', 'eyJOZXh0Ijo0LCJMYWJlbCI6IkEifQ=='],
        ['json-intrinsic', '{"LABEL":"A"}'],
        ['template-condition-control-true', 'yes'], ['template-condition-control-false', 'no'],
    ]) {
        const result = results.get(name);
        require(result?.status === 200 && result.passed === true && result.body === body && result.expected === body, `${name} exact response`);
    }
    for (const [name, input, expected] of [['condition-true', '3', 'yes'], ['condition-false', '4', 'no']]) {
        const result = results.get(name);
        require(result?.status === 502 && result.passed === false && result.input === input && result.expected === expected &&
            JSON.parse(result.body).error.code === 'NoResponse', `${name} failure retained`);
    }
    const observation = results.get('encoded-json');
    require(observation.workflow === 'EncodedJsonProbe' && observation.input === '{}' &&
        Buffer.from(observation.body, 'base64').toString('utf8') === '{"Next":4,"Label":"A"}', 'X06 decoded bytes');
    const definition = json('EncodedJsonProbe.workflow.json').definition;
    require(definition.actions.Count.inputs === 3 && definition.actions.Source.inputs === 'A', 'X06 original operands');
    const expression = definition.actions.Encoded.inputs;
    require(expression.startsWith('@csharp{base64(') && expression.includes('JsonSerializer.Create(') &&
        expression.includes('new { Next = outputs("Count").ToObject<int>() + 1, Label = outputs("Source").ToObject<string>() }') &&
        !expression.includes('Microsoft.Azure.Workflows.Sdk') && !expression.includes('JsonConvert'), 'portable X06 fragment');
    require(definition.actions.Response.inputs.body === "@outputs('Encoded')" &&
        JSON.stringify(definition.actions.Response.runAfter) === JSON.stringify({ Encoded: ['SUCCEEDED'] }), 'response consumes encoded action output');
    const schema = json('destinations.schema.json.txt').operations.find(operation => operation.name === 'EncodeJson').parameters[0].schema;
    require(schema.version === 1 && schema.serializerProfile === 'compact-json-v1' &&
        JSON.stringify(schema.transforms) === '["base64"]' && schema.nullable === false && schema.optional === false, 'real versioned destination');
    require(read('Program.cs.txt').includes('content: () => new { Next = count.Output + 1, Label = source.Output }'), 'original X06 authoring input');
    require(read('Probe.ps1.txt').includes('if (-not $uri.IsLoopback)') &&
        read('Probe.ps1.txt').includes('Where-Object { -not $_.passed }'), 'local-only probe retains overall failure');
    require(!/https?:\/\/|sig=|code=|password|bearer\s/i.test(read('observations.json')), 'sanitized observations contain no endpoints/credentials');
    const common = {
        evidenceKind: manifest.evidenceKind,
        completedUtc: record.completedUtc,
        runtime: record.runtime,
        runtimeProfile: 'separately-supplied-local-preview-codeful',
        previewComponentVersion: manifest.previewComponentVersion,
        reportedProbeExitCode: manifest.reportedProbeExitCode,
        overallProbeOutcome: manifest.overallOutcome,
        scope: 'Measured local preview host only; not public-bundle, cloud, designer, or arbitrary helper deployment certification.',
        artifacts: { manifest: path.join(relativeDirectory, 'manifest.json'), observations: path.join(relativeDirectory, 'observations.json') },
    };
    return {
        summary: { ...common, manifestSha256: hash('manifest.json'), passedObservations: 5, failedObservations: 2, generationProvenance: manifest.generationProvenance },
        cases: new Map([
            ['X06', { ...common, id: 'X06', status: 'passed', observations: [observation], decodedJson: '{"Next":4,"Label":"A"}' }],
            ['I04', { ...common, id: 'I04', status: 'unsupported-host',
                observations: [results.get('condition-true'), results.get('condition-false')],
                controls: [results.get('template-condition-control-true'), results.get('template-condition-control-false')],
                reason: 'Both native Condition probes returned HTTP 502 NoResponse while the corresponding independent template controls returned yes/no. Positive native Condition and designer support remain blocked.' }],
        ]),
    };
}

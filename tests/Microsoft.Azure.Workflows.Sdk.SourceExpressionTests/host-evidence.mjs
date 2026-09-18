import fs from 'node:fs';
import path from 'node:path';
import { createHash } from 'node:crypto';

const relativeDirectory = 'Fixtures\\host-runtime-1.170.91';
const expectedSamples = [
    ['null', 'null', 'Received request: '],
    ['string', '"hello"', 'Received request: hello'],
    ['integer', '42', 'Received request: 42'],
    ['boolean', 'true', 'Received request: True'],
    ['object', '{"n":1}', 'Received request: {"n":1}'],
    ['array', '[1,2]', 'Received request: [1,2]'],
];
const files = [
    'en-US.json', 'fr-FR.json',
    'TemplateProbe.workflow.json', 'LiteralProbe.workflow.json',
    'NativeProbe.workflow.json', 'ConditionProbe.workflow.json',
    'Probe.ps1.txt', 'Program.cs.txt', 'SourceHostConsumer.csproj.txt',
    'CultureHook.StartupHook.cs.txt', 'CultureHook.csproj.txt', 'reproduction.txt',
    'native-validation.log.txt',
];

/** Checks preserved measurements; this never starts a host or fabricates test execution. */
export function readHostEvidence(root) {
    const directory = path.join(root, relativeDirectory);
    const read = file => fs.readFileSync(path.join(directory, file), 'utf8').replace(/^\uFEFF/, '');
    const json = file => JSON.parse(read(file));
    const hash = file => createHash('sha256').update(fs.readFileSync(path.join(directory, file))).digest('hex').toUpperCase();
    const require = (condition, detail) => { if (!condition) throw new Error(`Host evidence validation failed: ${detail}`); };
    const manifest = json('manifest.json');
    require(manifest.version === 1 && manifest.evidenceKind === 'actual-local-logicapps-runtime', 'manifest version/kind');
    require(JSON.stringify(manifest.cultures) === JSON.stringify(['en-US', 'fr-FR']), 'declared cultures');
    require(JSON.stringify(manifest.artifacts.map(item => item.file).sort()) === JSON.stringify([...files].sort()), 'exact safe artifact set');
    for (const artifact of manifest.artifacts)
        require(hash(artifact.file) === artifact.sha256, `hash for ${artifact.file}`);

    const names = ['TemplateProbe', 'LiteralProbe', 'NativeProbe', 'ConditionProbe'];
    const definitions = Object.fromEntries(names.map(name => [name, json(`${name}.workflow.json`)]));
    require(definitions.TemplateProbe.definition.actions.Response.inputs.body === 'Received request: @{triggerBody()}', 'S14 generated definition');
    require(definitions.LiteralProbe.definition.actions.Response.inputs.body === '@@csharp{1 + 2}', 'F08 generated definition');
    require(definitions.NativeProbe.definition.actions.Response.inputs.body === '@csharp{outputs("Count").ToObject<int>() + 1}', 'native negative definition');
    require(definitions.ConditionProbe.definition.actions.Check.expression === '@csharp{outputs("Count").ToObject<int>() == 3}', 'condition negative definition');
    const program = read('Program.cs.txt');
    require(program.includes('responseBody: () => $"Received request: {trigger.TriggerOutput.Body}"'), 'original S14 authoring input');
    require(program.includes('responseBody: () => "@csharp{1 + 2}"'), 'original F08 authoring input');
    const probe = read('Probe.ps1.txt');
    require(probe.includes('$culture.processId -notin $listeners.OwningProcess'), 'listener PID verification');
    require(probe.includes('if (-not $uri.IsLoopback)'), 'localhost-only verification');
    const hook = read('CultureHook.StartupHook.cs.txt');
    require(hook.includes('CultureInfo.DefaultThreadCurrentCulture = culture;') &&
        hook.includes('CultureInfo.CurrentCulture = culture;') && hook.includes('processId = Environment.ProcessId'), 'in-process culture instrumentation');
    const negativeLines = read('native-validation.log.txt').trim().split(/\r?\n/);
    require(negativeLines.length === 2 && !negativeLines.some(line => /https?:\/\/|callback|sig=|code=|secret|password/i.test(line)), 'safe negative-only excerpt');
    for (const name of ['NativeProbe', 'ConditionProbe'])
        require(negativeLines.some(line => line.includes(`Workflow '${name}' validation and creation failed.`) &&
            line.includes("character '{'") && line.includes('not expected')), `${name} native parser rejection`);

    const runs = manifest.cultures.map(culture => {
        const record = json(`${culture}.json`);
        require(record.version === 1 && record.evidenceKind === manifest.evidenceKind, `${culture} evidence version/kind`);
        require(record.runtime === '4.1052.200.26352' &&
            record.extensionBundle.id === 'Microsoft.Azure.Functions.ExtensionBundle.Workflows' &&
            record.extensionBundle.version === '1.170.91', `${culture} measured engine/bundle`);
        require(record.cultureInstrumentation.culture === culture &&
            record.cultureInstrumentation.defaultThreadCulture === culture &&
            Number.isInteger(record.cultureInstrumentation.processId) && record.cultureInstrumentation.processId > 0, `${culture} instrumentation`);
        require(record.definitions.length === names.length &&
            new Set(record.definitions.map(item => item.name)).size === names.length, `${culture} exact definitions`);
        for (const definition of record.definitions)
            require(names.includes(definition.name) && definition.sha256 === hash(`${definition.name}.workflow.json`),
                `${culture} observed definition ${definition.name}`);
        require(record.templateResults.length === expectedSamples.length, `${culture} six formatting measurements`);
        for (const [inputKind, inputJson, body] of expectedSamples) {
            const matching = record.templateResults.filter(item => item.inputKind === inputKind);
            require(matching.length === 1 && matching[0].inputJson === inputJson && matching[0].body === body &&
                matching[0].status === 200 && matching[0].passed === true, `${culture} exact ${inputKind} observation`);
        }
        require(record.literalResult.status === 200 && record.literalResult.passed === true &&
            record.literalResult.body === '@csharp{1 + 2}', `${culture} F08 literal response`);
        require(Number.isFinite(Date.parse(record.completedUtc)) &&
            Date.parse(record.cultureInstrumentation.startedUtc) < Date.parse(record.completedUtc), `${culture} run timestamps`);
        return record;
    });
    require(runs[0].cultureInstrumentation.processId !== runs[1].cultureInstrumentation.processId, 'separate culture host processes');
    const artifacts = { manifest: path.join(relativeDirectory, 'manifest.json'), results: manifest.cultures.map(c => path.join(relativeDirectory, `${c}.json`)) };
    const common = {
        evidenceKind: manifest.evidenceKind,
        completedUtc: runs.map(run => run.completedUtc).sort().at(-1),
        runtime: runs[0].runtime,
        extensionBundle: runs[0].extensionBundle,
        cultures: manifest.cultures,
        scope: manifest.scope,
        artifacts,
    };
    return {
        manifest, runs,
        summary: { ...common, manifestSha256: hash('manifest.json'), generationProvenance: manifest.generationProvenance },
        cases: new Map([
            ['S14', { ...common, id: 'S14', status: 'passed', observations: runs.map(run => ({ culture: run.cultureInstrumentation.culture, results: run.templateResults })) }],
            ['F08', { ...common, id: 'F08', status: 'passed', observations: runs.map(run => ({ culture: run.cultureInstrumentation.culture, result: run.literalResult })) }],
            ['I04', { ...common, id: 'I04', status: 'unsupported-host', negativeEvidence: path.join(relativeDirectory, 'native-validation.log.txt'), reason: 'ConditionProbe native expression was rejected by the actual host template parser; the positive contract remains blocked.' }],
            ['X06', { ...common, id: 'X06', status: 'blocked-host', negativeEvidence: path.join(relativeDirectory, 'native-validation.log.txt'), reason: 'X06 was not executed on the actual host. NativeProbe establishes a native-envelope capability blocker, not a passing X06 result.' }],
        ]),
    };
}

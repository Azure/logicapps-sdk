import fs from 'node:fs';
import path from 'node:path';
import { createHash } from 'node:crypto';
import { readIdeEvidence } from './ide-evidence.mjs';

export function readPackageEvidence(root) {
    const files = {
        provenance: 'Fixtures\\package-final-provenance.json',
        cases: 'Fixtures\\package-final-pk-evidence.json',
        log: 'Fixtures\\package-final-validation.log.txt',
        validator: 'Fixtures\\package-validator.ps1.txt',
        repositoryWorkerLog: 'Fixtures\\package-final-repository-worker.log.txt',
        expanded: 'Fixtures\\package-expanded\\expanded-pk-evidence.json',
        expandedDirectory: 'Fixtures\\package-expanded',
        snapshot: 'Fixtures\\package-final-snapshot.json',
        ideProvenance: 'Fixtures\\package-ide\\provenance.json',
        ideObservations: 'Fixtures\\package-ide\\actual-ide-evidence.json',
        supportingDirectory: 'Fixtures\\package-support',
    };
    const read = file => fs.readFileSync(path.join(root, file), 'utf8');
    const hash = file => createHash('sha256').update(fs.readFileSync(path.join(root, file))).digest('hex').toUpperCase();
    const require = (condition, message) => {
        if (!condition) throw new Error(`External package evidence: ${message}`);
    };
    const verify = (file, expected) => require(hash(file) === expected, `hash mismatch: ${file}`);
    const snapshot = JSON.parse(read(files.snapshot));
    require(snapshot.version === 1 && snapshot.evidenceKind === 'artifact-import-hashes' &&
        snapshot.artifactCount === 166 && snapshot.artifacts.length === snapshot.artifactCount &&
        new Set(snapshot.artifacts.map(file => file.file)).size === snapshot.artifactCount,
        'imported artifact inventory differs.');
    for (const artifact of snapshot.artifacts) {
        require(artifact.file.startsWith('Fixtures\\package-') &&
            path.win32.normalize(artifact.file) === artifact.file && !artifact.file.split('\\').includes('..'),
            `invalid imported artifact path: ${artifact.file}`);
        verify(artifact.file, artifact.sha256);
    }
    const provenance = JSON.parse(read(files.provenance));
    const cases = JSON.parse(read(files.cases));
    const imported = new Map(snapshot.artifacts.map(file => [file.original.toLowerCase(), file.file]));
    const resolve = original => {
        const file = imported.get(original.toLowerCase());
        require(file !== undefined, `missing persistent snapshot: ${original}`);
        return file;
    };
    for (const artifact of provenance.artifacts) verify(resolve(artifact.path), artifact.sha256);
    verify(files.provenance, cases.provenanceSha256);
    verify(files.log, provenance.validation.logSha256);
    require(cases.logSha256 === provenance.validation.logSha256, 'aggregate log identity differs.');
    verify(files.validator, provenance.validatorSha256);
    verify(files.repositoryWorkerLog, provenance.repositoryWorker.logSha256);
    verify(files.expanded, provenance.expandedEvidenceSha256);
    verify(path.join(files.expandedDirectory, 'validator.ps1.txt'), provenance.validatorSha256);
    verify(path.join(files.expandedDirectory, 'matrix-validator.ps1.txt'), provenance.matrixValidatorSha256);
    verify('Fixtures\\approved-catalog.md', cases.catalogSha256);
    verify(files.ideProvenance, provenance.actualIdeSha256);
    require(provenance.validation.exitCode === 0 && provenance.repositoryWorker.exitCode === 0 &&
        provenance.pack.exitCode === 0 && provenance.buildAssets.exitCode === 0 &&
        provenance.sharedOutputsUnchanged === true, 'validation failed or shared outputs changed.');
    for (const name of ['packageSha256', 'runtimeSha256', 'compilerSha256'])
        require(cases[name] === provenance[name] && cases[name] === provenance.pack[name], `${name} package/provenance mismatch.`);
    require(provenance.failedChecks.length === 0, 'failed checks must not be promoted.');
    const ide = readIdeEvidence(root, cases, resolve, verify);
    const catalog = read('Fixtures\\approved-catalog.md');
    const records = new Map(cases.cases.map(row => [row.id, row]));
    require(records.size === 20 && cases.cases.length === 20 &&
        Array.from({ length: 20 }, (_, index) => `PK${String(index + 1).padStart(2, '0')}`).every(id => records.has(id)),
        'package catalog ID set differs.');
    const log = read(files.log).split(/\r?\n/);
    for (const row of cases.cases) {
        require(catalog.includes(row.original), `catalog input or expectation changed: ${row.id}`);
        if (['passed', 'negative-case-passed'].includes(row.status) && row.id !== 'PK13')
            require(row.logLines.length > 0 && row.logLines.every(line => log[line - 1]?.startsWith('CHECK ')),
                `missing successful check locations: ${row.id}`);
    }
    const expanded = JSON.parse(read(files.expanded));
    require(expanded.outcome === 'passed' && expanded.failedChecks.length === 0 &&
        expanded.packageSha256 === cases.packageSha256 && expanded.runtimeSha256 === cases.runtimeSha256 &&
        expanded.compilerSha256 === cases.compilerSha256 && expanded.validatorSha256 === provenance.matrixValidatorSha256,
        'expanded validation disagrees with final package.');
    require(expanded.commands.length === 97 && expanded.commands.length === provenance.expandedCommandCount &&
        expanded.cases.length === 39 && expanded.cases.length === provenance.expandedCaseCount,
        'expanded command/case inventory differs.');
    require(new Set(expanded.cases.map(row => row.id)).size === expanded.cases.length,
        'duplicate expanded case records.');
    require(new Set(expanded.commands.map(command => path.win32.basename(command.log))).size === 97, 'command log inventory differs.');
    for (const command of expanded.commands) {
        verify(path.join(files.expandedDirectory, 'logs', path.win32.basename(command.log)), command.logSha256);
    }
    for (const row of expanded.cases) {
        require(['passed', 'partial'].includes(row.status), `unverified expanded outcome: ${row.id}`);
        const command = expanded.commands[row.commandCount - 1];
        require(command?.log === row.log && command.exitCode === row.exitCode,
            `case command/exit mismatch: ${row.id}`);
        if (row.id === 'PK13')
            require(row.status === 'partial' && records.get(row.id).status === 'passed' && ide.status === 'passed',
                'matrix-only IDE gap requires separate actual IDE evidence.');
        else if (records.has(row.id))
            require(records.get(row.id).status === row.status, `package/expanded status mismatch: ${row.id}`);
    }
    for (const [original, expected] of Object.entries(expanded.fixtureSha256)) {
        const marker = '\\MatrixFixtures\\';
        const relative = original.includes(marker)
            ? 'MatrixFixtures\\' + original.split(marker)[1]
            : original.endsWith('\\Consumer\\Program.cs') ? 'Consumer.Program.cs.txt' : null;
        require(relative !== null && path.win32.normalize(relative) === relative &&
            !relative.split('\\').includes('..'), `unrecognized source snapshot: ${original}`);
        verify(path.join(files.expandedDirectory, relative), expected);
    }
    const pk02 = records.get('PK02');
    require(pk02.status === 'passed' && pk02.exitCode === 0 &&
        pk02.checks.includes('Zero reads at the first expression-body operation through serialization') &&
        pk02.checks.includes('Positive counter control observes one read'), 'PK02 invocation proof is missing.');
    verify(path.join(files.expandedDirectory, 'Consumer.Program.cs.txt'), pk02.details.consumerSourceSha256);
    require(records.get('PK12').status === 'negative-case-passed' &&
        records.get('PK13').status === 'passed' && records.get('PK17').status === 'partial' &&
        records.get('PK17').unverified.includes('Other CLI/IDE platforms'),
        'generator/IDE/platform limitations were incorrectly promoted.');
    return { files, provenance, cases, expanded, ide };
}

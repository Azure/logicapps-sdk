import fs from 'node:fs';
import path from 'node:path';
import { createHash } from 'node:crypto';

/** Validates preserved actual editor observations, not a simulated language service. */
export function readIdeEvidence(root, expected, resolve, verify) {
    const directory = 'Fixtures\\package-ide';
    const read = file => fs.readFileSync(path.join(root, directory, file), 'utf8');
    const provenance = JSON.parse(read('provenance.json'));
    const evidence = JSON.parse(read('actual-ide-evidence.json'));
    const require = (condition, message) => { if (!condition) throw new Error(`Actual IDE evidence: ${message}`); };
    require(provenance.evidenceKind === 'actual-ide-package-validation' &&
        evidence.evidenceKind === 'actual-vscode-extension-host-validation' &&
        provenance.status === 'passed' && evidence.status === 'passed', 'successful real editor run missing.');
    for (const name of ['packageSha256', 'runtimeSha256', 'compilerSha256'])
        require(provenance[name] === expected[name], `${name} differs from final package.`);
    require(provenance.restore.exitCode === 0 && provenance.launch.exitCode === 0 &&
        provenance.launch.argv.includes('--extensionTestsPath') && provenance.launch.argv.includes('--extensions-dir'),
        'isolated editor launch or restore failed.');
    require(provenance.codeVersion === '1.137.0' && evidence.vscodeVersion === provenance.codeVersion &&
        evidence.extension.id === 'ms-dotnettools.csharp' && evidence.extension.version === '2.160.4',
        'measured editor/extension versions differ.');
    for (const artifact of provenance.artifacts) verify(resolve(artifact.path), artifact.sha256);
    verify(path.join(directory, 'validator.ps1.txt'), provenance.validatorSha256);
    const source = read('LanguageServiceFixture\\Program.cs');
    const hash = createHash('sha256').update(fs.readFileSync(path.join(root, directory, 'LanguageServiceFixture\\Program.cs'))).digest('hex');
    require(hash === evidence.sourceSha256, 'original source hash differs.');
    const sourceArtifact = provenance.artifacts.find(item => item.path.endsWith('\\LanguageServiceFixture\\Program.cs'));
    require(sourceArtifact?.sha256.toLowerCase() === hash, 'source snapshot is not in the IDE manifest.');
    const project = read('LanguageServiceFixture\\LanguageServiceFixture.csproj');
    require(project.includes('PackageReference Include="Microsoft.Azure.Workflows.Sdk"') && !project.includes('ProjectReference'),
        'consumer must use the package, not repository project references.');
    const broken = source.replace('+ suffix', '+ missingName');
    const index = broken.indexOf('missingName');
    require(index >= 0 && source.includes('source.Output.ToUpperInvariant() + suffix'), 'exact original CB01 source missing.');
    const prefix = broken.slice(0, index).split(/\r?\n/);
    const line = prefix.length - 1;
    const character = prefix.at(-1).length;
    for (const stage of ['beforeBuild', 'afterBuild']) {
        require(evidence[`${stage}HoverWord`] === 'Compose' &&
            JSON.stringify(evidence[`${stage}Hover`]).includes('WorkflowBuiltInActions.Compose(Func<string> inputs)'),
            `${stage} semantic SDK hover missing.`);
        for (const label of ['Compose', 'ToUpperInvariant'])
            require(evidence[`${stage}${label}Completion`].some(item => item.label === label), `${stage} ${label} completion missing.`);
        const errors = evidence[`${stage}InvalidDiagnostics`].filter(item => item.severity === 0);
        require(errors.length === 1 && errors[0].code === 'CS0103', `${stage} unexpected/duplicate errors.`);
        const error = errors[0];
        const uri = new URL(error.uri);
        const original = decodeURIComponent(uri.pathname).replace(/^\/([A-Za-z]:)/, '$1').replaceAll('/', '\\');
        require(uri.protocol === 'file:' && original.toLowerCase() === sourceArtifact.path.toLowerCase() &&
            error.range.start.line === line && error.range.start.character === character &&
            error.range.end.line === line && error.range.end.character === character + 'missingName'.length,
            `${stage} diagnostic is not on the exact original identifier.`);
        require(evidence.checks.some(check => check.startsWith(`${stage}:`) &&
            check.includes('clean revert, no duplicate obj errors or authoring execution')), `${stage} revert/sentinel checks missing.`);
    }
    require(evidence.commands.length === 3 && evidence.commands.every(command => command.exitCode === 0), 'editor/build/run commands failed.');
    require(evidence.commands[0].surface === 'vscode.tasks.executeTask' && evidence.commands[0].argv[0] === 'build',
        'build did not run through the actual integrated editor task.');
    const cb01 = '@csharp{outputs("Source").ToObject<string>().ToUpperInvariant() + "!"}';
    require(evidence.commands[1].stdout.replace(/\r?\n$/, '') === cb01 && evidence.commands[1].stderr === '',
        'built package consumer CB01 output differs.');
    require(evidence.commands[2].argv.at(-1) === 'counter-control' &&
        read('authoring-executed.txt') === 'read\n', 'invocation-counter positive control missing.');
    const validator = read('VsCodeProbe\\tests.cjs');
    for (const assertion of [
        'vscode.executeHoverProvider', 'vscode.executeCompletionItemProvider',
        'vscode.workspace.applyEdit', 'workbench.action.files.revert', 'vscode.tasks.executeTask',
        "check(!fs.existsSync(sentinel), 'IDE language features executed the authoring getter.')",
        "check(!fs.existsSync(sentinel), 'CB01 invoked authoring getter.')",
    ]) require(validator.includes(assertion), `preserved validator lacks ${assertion}`);
    require(evidence.checks.length === 4 &&
        evidence.checks.includes('Built application emits exact CB01 without getter execution; explicit getter positive control writes one entry.'),
        'final counter/serialization check missing.');
    return {
        evidenceKind: evidence.evidenceKind,
        completedUtc: provenance.completedUtc,
        vscodeVersion: evidence.vscodeVersion,
        csharpExtensionVersion: evidence.extension.version,
        status: 'passed',
        scope: 'Tested Windows VS Code configuration only; not Visual Studio or the remaining platform/IDE-host matrix.',
        artifacts: { provenance: path.join(directory, 'provenance.json'), observations: path.join(directory, 'actual-ide-evidence.json') },
    };
}

const vscode = require('vscode');
const fs = require('node:fs');
const path = require('node:path');
const { createHash } = require('node:crypto');
const { execFile } = require('node:child_process');

const hash = value => createHash('sha256').update(value).digest('hex');
const pause = milliseconds => new Promise(resolve => setTimeout(resolve, milliseconds));
function check(condition, message) { if (!condition) throw new Error(message); }
function isWithin(root, child) {
    const relative = path.relative(root, child);
    return relative !== '' && relative !== '..' && !relative.startsWith(`..${path.sep}`) && !path.isAbsolute(relative);
}
async function eventually(action, accept, label) {
    for (let attempt = 0; attempt < 90; attempt++) {
        const value = await action();
        if (accept(value)) return value;
        await pause(2000);
    }
    throw new Error(`Timed out waiting for ${label}.`);
}
function diagnosticRecords() {
    return vscode.languages.getDiagnostics().flatMap(([uri, entries]) => entries.map(item => ({
        uri: uri.toString(), code: typeof item.code === 'object' ? item.code.value : item.code,
        severity: item.severity, message: item.message,
        range: { start: item.range.start, end: item.range.end }
    })));
}
exports.run = async () => {
    const evidence = process.env.WORKFLOW_IDE_EVIDENCE;
    check(evidence, 'WORKFLOW_IDE_EVIDENCE is required.');
    const result = {
        evidenceKind: 'actual-vscode-extension-host-validation',
        vscodeVersion: vscode.version,
        scope: 'Isolated actual VS Code window, installed C# extension, editor language-feature APIs and integrated build task. Explicitly pinned package only.',
        checks: [], commands: []
    };
    const sentinel = process.env.WORKFLOW_LSP_SENTINEL;
    const dotnet = process.env.WORKFLOW_IDE_DOTNET;
    let document;
    try {
        const folder = vscode.workspace.workspaceFolders?.[0];
        check(folder && vscode.workspace.workspaceFolders.length === 1, 'Expected one isolated workspace.');
        check(isWithin(evidence, folder.uri.fsPath), 'Workspace is outside artifact directory.');
        const sourcePath = path.join(folder.uri.fsPath, 'Program.cs');
        const original = fs.readFileSync(sourcePath, 'utf8');
        result.sourceSha256 = hash(original);
        const extension = vscode.extensions.getExtension('ms-dotnettools.csharp');
        check(extension, 'C# extension is not installed in the isolated extension directory.');
        check(isWithin(path.join(evidence, 'extensions'), extension.extensionPath),
            'C# extension came from the default user extensions directory.');
        result.extension = { id: extension.id, version: extension.packageJSON.version, path: extension.extensionPath };
        const api = await extension.activate();
        check(typeof api.initializationFinished === 'function', 'Installed C# extension has no readiness API.');
        result.projectStates = [];
        const projectEvents = api.experimental.languageServerEvents.onServerStateChange(event => result.projectStates.push(event));
        try {
            await api.initializationFinished();
            await eventually(() => result.projectStates, states => states.some(state => state.state === 3), 'C# project initialization');
        } finally {
            projectEvents.dispose();
        }
        document = await vscode.workspace.openTextDocument(sourcePath);
        const editor = await vscode.window.showTextDocument(document);
        check(editor.document.uri.toString() === document.uri.toString(), 'Original source is not displayed in the editor.');
        const at = (marker, offset = 0) => {
            const index = document.getText().indexOf(marker);
            check(index >= 0, `Missing source marker: ${marker}`);
            return document.positionAt(index + offset);
        };
        async function semanticChecks(stage) {
            const hoverPosition = at('BuiltIn.Compose', 10);
            result[`${stage}HoverPosition`] = hoverPosition;
            result[`${stage}HoverWord`] = document.getText(document.getWordRangeAtPosition(hoverPosition));
            const hover = await eventually(
                async () => {
                    const raw = await vscode.commands.executeCommand('vscode.executeHoverProvider', document.uri, hoverPosition);
                    const value = raw?.map(item => ({
                        range: item.range,
                        contents: item.contents.map(content => typeof content === 'string'
                            ? content : { value: content.value, language: content.language })
                    }));
                    result[`${stage}LastHover`] = value;
                    return value;
                },
                value => value?.some(item => JSON.stringify(item.contents).includes('Compose')),
                `${stage} Compose hover`);
            result[`${stage}Hover`] = hover;
            for (const [marker, label] of [['BuiltIn.', 'Compose'], ['source.Output.', 'ToUpperInvariant']]) {
                const completion = await eventually(
                    () => vscode.commands.executeCommand('vscode.executeCompletionItemProvider', document.uri, at(marker, marker.length)),
                    value => value?.items.some(item => (typeof item.label === 'string' ? item.label : item.label.label) === label),
                    `${stage} ${label} completion`);
                result[`${stage}${label}Completion`] = completion.items
                    .filter(item => (typeof item.label === 'string' ? item.label : item.label.label) === label)
                    .map(item => ({ label: item.label, detail: item.detail, kind: item.kind }));
            }
            await eventually(() => diagnosticRecords(), values => !values.some(item => item.severity === vscode.DiagnosticSeverity.Error),
                `${stage} clean original diagnostics`);
            const broken = original.replace('+ suffix', '+ missingName');
            const edit = new vscode.WorkspaceEdit();
            edit.replace(document.uri, new vscode.Range(document.positionAt(0), document.positionAt(document.getText().length)), broken);
            check(await vscode.workspace.applyEdit(edit), 'Unsaved edit was rejected.');
            const expected = document.positionAt(broken.indexOf('missingName'));
            const invalid = await eventually(() => diagnosticRecords(), values => values.some(item =>
                String(item.code) === 'CS0103' && item.uri === document.uri.toString()),
                `${stage} original-source CS0103`);
            const errors = invalid.filter(item => item.severity === vscode.DiagnosticSeverity.Error);
            check(errors.length === 1, `Duplicate or unrelated errors: ${JSON.stringify(errors)}`);
            check(errors[0].range.start.line === expected.line && errors[0].range.start.character === expected.character,
                'CS0103 does not point to the exact original identifier.');
            result[`${stage}InvalidDiagnostics`] = invalid;
            await vscode.commands.executeCommand('workbench.action.files.revert');
            check(document.getText() === original, 'Editor did not revert to original source.');
            await eventually(() => diagnosticRecords(), values => !values.some(item => item.severity === vscode.DiagnosticSeverity.Error),
                `${stage} corrected diagnostics`);
            check(!fs.existsSync(sentinel), 'IDE language features executed the authoring getter.');
            check(hash(fs.readFileSync(sourcePath)) === result.sourceSha256, 'IDE edited original source on disk.');
            result.checks.push(`${stage}: visible original document, semantic Compose hover, Compose/string completions, exactly one original-range CS0103 on unsaved edit, clean revert, no duplicate obj errors or authoring execution.`);
        }
        await semanticChecks('beforeBuild');
        const project = path.join(folder.uri.fsPath, 'LanguageServiceFixture.csproj');
        const buildArgs = ['build', project, '--no-restore', '--verbosity', 'minimal',
            `-flp:logfile=${path.join(evidence, 'ide-build.log')};verbosity=normal`];
        const task = new vscode.Task(
            { type: 'process', task: 'workflow-package-build' }, folder,
            'Workflow package build', 'Workflow package validation',
            new vscode.ProcessExecution(dotnet, buildArgs), ['$msCompile']);
        task.presentationOptions = { reveal: vscode.TaskRevealKind.Always, panel: vscode.TaskPanelKind.New };
        let execution;
        const buildExit = await new Promise(async (resolve, reject) => {
            const timeout = setTimeout(() => {
                subscription.dispose();
                execution?.terminate();
                reject(new Error('IDE build task timed out.'));
            }, 180000);
            const subscription = vscode.tasks.onDidEndTaskProcess(event => {
                if (event.execution.task.name !== task.name) return;
                clearTimeout(timeout);
                subscription.dispose();
                resolve(event.exitCode);
            });
            try { execution = await vscode.tasks.executeTask(task); }
            catch (error) { clearTimeout(timeout); subscription.dispose(); reject(error); }
        });
        result.commands.push({ surface: 'vscode.tasks.executeTask', executable: dotnet, argv: buildArgs, exitCode: buildExit });
        check(buildExit === 0, `Actual VS Code build task failed: ${buildExit}`);
        result.checks.push('Actual VS Code integrated-terminal process task built the PackageReference-only project successfully.');
        await semanticChecks('afterBuild');
        const assembly = path.join(folder.uri.fsPath, 'bin', 'Debug', 'net9.0', 'LanguageServiceFixture.dll');
        async function run(args) {
            const output = await new Promise((resolve, reject) => execFile(dotnet, args,
                { cwd: folder.uri.fsPath, timeout: 60000 }, (error, stdout, stderr) => {
                    result.commands.push({ executable: dotnet, argv: args, exitCode: error ? error.code : 0, stdout, stderr });
                    if (error) reject(error);
                    else resolve(stdout);
                }));
            return output;
        }
        const output = await run([assembly]);
        check(output.trim() === '@csharp{outputs("Source").ToObject<string>().ToUpperInvariant() + "!"}', 'CB01 output differs.');
        check(!fs.existsSync(sentinel), 'CB01 invoked authoring getter.');
        await run([assembly, 'counter-control']);
        check(fs.readFileSync(sentinel, 'utf8') === 'read\n', 'Getter positive control failed.');
        result.checks.push('Built application emits exact CB01 without getter execution; explicit getter positive control writes one entry.');
        result.status = 'passed';
    } catch (error) {
        result.status = 'failed';
        result.error = error.stack;
        result.failureDiagnostics = diagnosticRecords();
        throw error;
    } finally {
        result.completedUtc = new Date().toISOString();
        fs.writeFileSync(path.join(evidence, 'actual-ide-evidence.json'), JSON.stringify(result, null, 2));
    }
};

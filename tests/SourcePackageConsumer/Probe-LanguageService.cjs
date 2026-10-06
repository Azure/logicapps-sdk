// Exercises the installed production Roslyn language server, not a mock compiler.
const { spawn } = require('node:child_process');
const fs = require('node:fs');
const path = require('node:path');
const { pathToFileURL } = require('node:url');
const { createHash } = require('node:crypto');

const [server, workspace, evidence, dotnet = 'dotnet'] = process.argv.slice(2);
if (!server || !workspace || !evidence) {
    throw new Error('Usage: node Probe-LanguageService.cjs <server.dll> <workspace> <evidence-directory> [dotnet]');
}
fs.mkdirSync(evidence, { recursive: true });
const sourcePath = path.join(workspace, 'Program.cs');
const original = fs.readFileSync(sourcePath, 'utf8');
const uri = pathToFileURL(sourcePath).href;
const hash = value => createHash('sha256').update(value).digest('hex');
const sourceHash = hash(original);
const sentinel = path.join(evidence, 'authoring-executed.txt');
if (fs.existsSync(sentinel)) throw new Error(`Sentinel already exists: ${sentinel}`);
const transcript = fs.createWriteStream(path.join(evidence, 'lsp-transcript.jsonl'));
const errors = fs.createWriteStream(path.join(evidence, 'server-stderr.log'));
const argv = [server, '--stdio', '--autoLoadProjects', '--logLevel', 'Information',
    '--telemetryLevel', 'off', '--extensionLogDirectory', path.join(evidence, 'server-logs')];
const child = spawn(dotnet, argv, {
    cwd: workspace,
    env: { ...process.env, WORKFLOW_LSP_SENTINEL: sentinel, DOTNET_CLI_TELEMETRY_OPTOUT: '1' },
    stdio: ['pipe', 'pipe', 'pipe']
});
const pending = new Map();
let sequence = 0;
let buffer = Buffer.alloc(0);
let exited = false;
const exitPromise = new Promise(resolve => child.once('exit', (code, signal) => {
    exited = true;
    for (const entry of pending.values()) {
        clearTimeout(entry.timer);
        entry.reject(new Error(`Language server exited: ${code}/${signal}`));
    }
    pending.clear();
    resolve({ code, signal });
}));
child.stderr.pipe(errors);
function record(direction, message) {
    transcript.write(JSON.stringify({ utc: new Date().toISOString(), direction, message }) + '\n');
}
function send(message) {
    record('client', message);
    const body = Buffer.from(JSON.stringify({ jsonrpc: '2.0', ...message }));
    child.stdin.write(`Content-Length: ${body.length}\r\n\r\n`);
    child.stdin.write(body);
}
function notify(method, params) { send({ method, params }); }
function request(method, params) {
    const id = ++sequence;
    return new Promise((resolve, reject) => {
        const timer = setTimeout(() => {
            pending.delete(id);
            reject(new Error(`Timed out: ${method}`));
        }, 45000);
        pending.set(id, { resolve, reject, timer });
        send({ id, method, params });
    });
}
child.stdout.on('data', chunk => {
    buffer = Buffer.concat([buffer, chunk]);
    while (true) {
        const split = buffer.indexOf('\r\n\r\n');
        if (split < 0) return;
        const match = /Content-Length:\s*(\d+)/i.exec(buffer.subarray(0, split).toString());
        if (!match) throw new Error('Invalid LSP frame header.');
        const size = Number(match[1]);
        if (buffer.length < split + 4 + size) return;
        const message = JSON.parse(buffer.subarray(split + 4, split + 4 + size).toString());
        buffer = buffer.subarray(split + 4 + size);
        record('server', message);
        if (message.method && message.id !== undefined) {
            if (message.method === 'workspace/configuration') {
                send({ id: message.id, result: message.params.items.map(item =>
                    ['projects.dotnet_enable_automatic_restore', 'projects.dotnet_enable_file_based_programs']
                        .includes(item.section) ? false : null) });
            } else if (['client/registerCapability', 'window/workDoneProgress/create',
                'workspace/diagnostic/refresh', 'workspace/inlayHint/refresh',
                'workspace/semanticTokens/refresh', 'workspace/codeLens/refresh'].includes(message.method)) {
                send({ id: message.id, result: null });
            } else {
                send({ id: message.id, error: { code: -32601, message: `Unsupported probe client request: ${message.method}` } });
            }
        } else if (message.id !== undefined && pending.has(message.id)) {
            const entry = pending.get(message.id);
            pending.delete(message.id);
            clearTimeout(entry.timer);
            if (message.error) entry.reject(new Error(JSON.stringify(message.error)));
            else entry.resolve(message.result);
        }
    }
});
function position(text, needle, offset = 0) {
    const index = text.indexOf(needle);
    if (index < 0) throw new Error(`Missing source marker: ${needle}`);
    const prefix = text.slice(0, index + offset).split('\n');
    return { line: prefix.length - 1, character: prefix.at(-1).length };
}
function check(condition, message) { if (!condition) throw new Error(message); }
const pause = milliseconds => new Promise(resolve => setTimeout(resolve, milliseconds));
const result = {
    evidenceKind: 'installed-language-service-validation',
    scope: 'Production Roslyn server shipped in the installed VS Code C# extension, driven over actual LSP; not VS Code UI or Visual Studio certification.',
    command: { executable: dotnet, argv },
    serverSha256: hash(fs.readFileSync(server)), sourceSha256: sourceHash, checks: []
};
const deadline = setTimeout(() => child.kill(), 180000);
(async () => {
    try {
        const initialized = await request('initialize', {
            processId: process.pid,
            clientInfo: { name: 'Workflow package LSP acceptance probe', version: '1' },
            rootUri: pathToFileURL(workspace).href,
            workspaceFolders: [{ uri: pathToFileURL(workspace).href, name: 'Workflow package fixture' }],
            capabilities: {
                workspace: { configuration: true, workspaceFolders: true },
                textDocument: {
                    hover: { contentFormat: ['markdown', 'plaintext'] },
                    completion: { completionItem: { snippetSupport: true } },
                    diagnostic: { dynamicRegistration: false }
                }
            }
        });
        result.serverInfo = initialized.serverInfo;
        result.capabilities = initialized.capabilities;
        notify('initialized', {});
        notify('project/open', {
            projects: [pathToFileURL(path.join(workspace, 'LanguageServiceFixture.csproj')).href]
        });
        notify('textDocument/didOpen', {
            textDocument: { uri, languageId: 'csharp', version: 1, text: original }
        });
        let hover;
        for (let attempt = 0; attempt < 45; attempt++) {
            hover = await request('textDocument/hover', {
                textDocument: { uri }, position: position(original, 'BuiltIn.Compose', 'BuiltIn.'.length + 2)
            });
            if (hover && JSON.stringify(hover).includes('Compose')) break;
            await pause(2000);
        }
        check(hover && JSON.stringify(hover).includes('Compose'), 'No semantic Compose hover from the installed server.');
        result.hover = hover;
        result.checks.push('Semantic hover resolves packaged Compose API from original CB01 source.');
        for (const [marker, expected] of [['BuiltIn.', 'Compose'], ['source.Output.', 'ToUpperInvariant']]) {
            const completion = await request('textDocument/completion', {
                textDocument: { uri }, position: position(original, marker, marker.length),
                context: { triggerKind: 1 }
            });
            const items = Array.isArray(completion) ? completion : completion?.items;
            check(items?.some(item => item.label === expected), `Missing semantic completion ${expected}.`);
            result.checks.push(`Actual LSP completion contains ${expected}.`);
        }
        const diagnostics = () => request('textDocument/diagnostic', { textDocument: { uri } });
        const clean = await diagnostics();
        check(clean.kind === 'full' && clean.items.every(item => item.severity !== 1),
            `Valid CB01 has language-service errors: ${JSON.stringify(clean)}`);
        result.cleanDiagnostics = clean;
        result.checks.push('Valid original CB01 has no language-service errors.');
        const broken = original.replace('+ suffix', '+ missingName');
        notify('textDocument/didChange', { textDocument: { uri, version: 2 }, contentChanges: [{ text: broken }] });
        const invalid = await diagnostics();
        const error = invalid.items?.find(item => String(item.code) === 'CS0103');
        const expected = position(broken, 'missingName');
        check(error && error.range.start.line === expected.line && error.range.start.character === expected.character,
            `Missing original-source CS0103 range: ${JSON.stringify(invalid)}`);
        check(invalid.items.filter(item => item.severity === 1).length === 1,
            'Expected exactly one error, not duplicated/generated-input errors.');
        result.invalidDiagnostics = invalid;
        result.diagnosticUri = uri;
        result.checks.push('Unsaved edit produces exactly one CS0103 at the original file and exact identifier range.');
        notify('textDocument/didChange', { textDocument: { uri, version: 3 }, contentChanges: [{ text: original }] });
        const restored = await diagnostics();
        check(restored.kind === 'full' && restored.items.every(item => item.severity !== 1),
            'Corrected unsaved source retained errors.');
        result.checks.push('Reverting the unsaved edit clears errors.');
        check(!fs.existsSync(sentinel), 'Language-service processing executed user code.');
        check(hash(fs.readFileSync(sourcePath)) === sourceHash, 'Language-service probe changed original source.');
        result.checks.push('No authoring getter invocation or original-source mutation during language-service processing.');
        await request('shutdown');
        notify('exit');
        const exit = await Promise.race([exitPromise, pause(10000).then(() => null)]);
        check(exit?.code === 0, `Language server did not exit cleanly: ${JSON.stringify(exit)}`);
        result.serverExit = exit;
        result.status = 'passed';
    } catch (error) {
        result.status = 'failed';
        result.error = error.stack;
        process.exitCode = 1;
    } finally {
        clearTimeout(deadline);
        if (!exited) child.kill();
        result.completedUtc = new Date().toISOString();
        fs.writeFileSync(path.join(evidence, 'language-service-evidence.json'), JSON.stringify(result, null, 2));
        transcript.end();
        errors.end();
        console.log(JSON.stringify({ status: result.status, checks: result.checks, error: result.error }, null, 2));
    }
})();

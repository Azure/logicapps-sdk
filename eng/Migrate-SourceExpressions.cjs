// The upstream connector generator is external. Run this idempotent pass after
// regenerating src\generated to apply the versioned source-expression ABI.
const fs = require('node:fs');
const path = require('node:path');
const root = path.resolve(__dirname, '..');

function annotate(text) {
    let position = 0;
    for (;;) {
        const start = text.indexOf('Expression<Func<', position);
        if (start < 0) return text;
        let end = start + 'Expression<'.length, depth = 1;
        while (depth) {
            if (text[end] === '<') depth++;
            else if (text[end] === '>') depth--;
            end++;
        }
        const replacement = '[WorkflowExpression] ' + text.slice(start + 'Expression<'.length, end - 1);
        text = text.slice(0, start) + replacement + text.slice(end);
        position = start + replacement.length;
    }
}

function parameters(signature) {
    const result = [];
    for (const match of signature.matchAll(/\[WorkflowExpression\]\s+Func</g)) {
        let end = match.index + match[0].length, depth = 1;
        while (depth) {
            if (signature[end] === '<') depth++;
            else if (signature[end] === '>') depth--;
            end++;
        }
        const tail = signature.slice(end);
        const name = /^\s+(@?\w+)/.exec(tail)?.[1];
        if (!name) throw new Error(signature);
        result.push({ name, optional: /^\s+@?\w+\s*=\s*null/.test(tail) });
    }
    return result;
}

function migrate(file) {
    const original = fs.readFileSync(file, 'utf8');
    let text = annotate(original.replace(/\r\n/g, '\n')).replaceAll('CSharpExpressionConverter.', 'SourceExpressionConverter.');
    text = text.replace(/(        public [^\n]+\([^\n]*\)\n)        \{\n([\s\S]*?)\n        \}/g,
        (whole, signature, body) => {
            if (body.includes('BuildSourceInput')) return whole;
            const final = /            return new ([^\n(]+)\((\w+)([^\n]*)\);\s*$/.exec(body);
            if (!final || !/Action|Trigger/.test(final[1])) return whole;
            const [, type, argument, rest] = final;
            const creation = new RegExp('\\bvar ' + argument + ' = new (\\w+)\\b').exec(body);
            if (!creation) throw new Error(`Cannot identify payload type: ${file}: ${signature}`);
            const checks = parameters(signature).map(p =>
                `            SourceExpression.Validate(${p.name}, nameof(${p.name}), required: ${!p.optional});\n`).join('');
            const payload = (body.slice(0, final.index).trimEnd() + `\n            return ${argument};`)
                .split('\n').map(line => line ? '    ' + line : line).join('\n');
            return signature + '        {\n' + checks +
                `            ${creation[1]} BuildSourceInput()\n            {\n` + payload +
                '\n            }\n\n' +
                `            return new ${type}(BuildSourceInput${rest});\n        }`;
        });
    if (text === original.replace(/\r\n/g, '\n')) return false;
    fs.writeFileSync(file, text);
    return true;
}

function files(directory) {
    return fs.readdirSync(directory, { withFileTypes: true }).flatMap(entry => {
        const full = path.join(directory, entry.name);
        return entry.isDirectory() ? files(full) : entry.name.endsWith('.cs') ? [full] : [];
    });
}

if (require.main === module) {
    console.log(`Migrated ${files(path.join(root, 'src', 'generated')).filter(migrate).length} connector files.`);
}
module.exports = { annotate, parameters };

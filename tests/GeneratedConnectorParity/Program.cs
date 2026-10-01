// Copyright (c) Microsoft Corporation. All rights reserved.

using System.Text;
using System.Text.Json;
using GeneratedConnectorParity;

if (args.Length is not (3 or 4) || args.Length == 4 && args[3] != "--require-match")
{
    Console.Error.WriteLine("Usage: GeneratedConnectorParity <baseline generated root> <candidate generated root> <new report directory> [--require-match]");
    return 2;
}

try
{
    var baseline = Path.GetFullPath(args[0]);
    var candidate = Path.GetFullPath(args[1]);
    var output = Path.GetFullPath(args[2]);
    if (Directory.Exists(output) || File.Exists(output))
        throw new IOException("Use a new report directory; existing evidence will not be overwritten.");
    if (Inside(output, baseline) || Inside(output, candidate))
        throw new IOException("The report directory must be outside both source roots.");
    var report = ConnectorComparison.CompareDirectories(baseline, candidate);
    var markdown = new StringBuilder("# Generated connector source comparison\n\n")
        .AppendLine($"Baseline: `{baseline}`\n\nCandidate: `{candidate}`\n")
        .AppendLine("Source-syntax comparison, not proof of behavioral equivalence. Input-schema/version drift may explain differences.")
        .AppendLine("Files match by relative path. Missing candidate files are **not generated**, not asserted to be removed APIs.\n")
        .AppendLine("| Family | Baseline | Candidate | Paired | Byte exact | Trivia only | API declarations equal | Implementation syntax equal |")
        .AppendLine("|---|---:|---:|---:|---:|---:|---:|---:|");
    foreach (var coverage in report.Coverage)
        markdown.AppendLine($"| {coverage.Family} | {coverage.BaselineFiles} | {coverage.CandidateFiles} | {coverage.ComparedFiles} | {coverage.ExactMatches} | {coverage.TriviaOnlyMatches} | {coverage.ApiMatches} | {coverage.ImplementationMatches} |");
    markdown.AppendLine($"\nNot generated: **{report.NotGenerated.Length}**. Candidate-only files: **{report.CandidateOnly.Length}**.")
        .AppendLine("\n## Compared files\n")
        .AppendLine("| File | Token equal | Context changed | Baseline / candidate declarations | API differences | Implementation differences | Parse errors |")
        .AppendLine("|---|---|---|---:|---:|---:|---:|");
    foreach (var file in report.Files)
        markdown.AppendLine($"| {file.Path} | {file.TokenMatch} | {file.ContextChanged} | {file.BaselinePublicDeclarations} / {file.CandidatePublicDeclarations} | {file.ApiDifferences.Length} | {file.ImplementationDifferences.Length} | {file.Errors.Length} |");
    foreach (var file in report.Files.Where(file => !file.TokenMatch))
    {
        markdown.AppendLine($"\n### {file.Path}\n");
        if (file.ContextChanged)
        {
            markdown.AppendLine("Context changed (including ordering if no additions/removals follow):\n");
            foreach (var removed in file.BaselineContext.Except(file.CandidateContext, StringComparer.Ordinal))
                markdown.AppendLine("- Removed: `" + Escape(removed) + "`");
            foreach (var added in file.CandidateContext.Except(file.BaselineContext, StringComparer.Ordinal))
                markdown.AppendLine("- Added: `" + Escape(added) + "`");
        }
        foreach (var error in file.Errors)
            markdown.AppendLine("- " + Escape(error));
        foreach (var group in new[] { ("API", file.ApiDifferences), ("Implementation", file.ImplementationDifferences) })
        {
            markdown.AppendLine($"\n{group.Item1}: {group.Item2.Length} differences; first 10 below. Complete details are in `comparison.json`.\n");
            foreach (var difference in group.Item2.Take(10))
                markdown.AppendLine($"- **{difference.Change}** `{Escape(difference.Member)}`\n  - Before: `{Escape(difference.Baseline ?? "(absent)")}`\n  - After: `{Escape(difference.Candidate ?? "(absent)")}`");
        }
    }
    markdown.AppendLine("\n## Interpretation\n")
        .AppendLine("- API comparison includes public/protected declarations, parameter names/defaults/attributes, model properties and enum order/values.")
        .AppendLine("- Implementation comparison includes method bodies and non-public members; local renaming and equivalent rewrites still count as differences.")
        .AppendLine("- Imports, directives and assembly attributes are tracked separately because token-similar members may bind differently.")
        .AppendLine("- Declaration/body match counts do not imply equivalent binding when the file's context changed.")
        .AppendLine("- Only comments and whitespace are ignored for token equality. Literal contents and preprocessor/disabled text are retained.")
        .AppendLine("- The comparer does not execute code, compile the candidate SDK, fetch inputs, or attribute mismatches to generator bugs.")
        .AppendLine("- Full match requires every baseline file and no extra candidate files, with token equality and no parse errors.");
    Directory.CreateDirectory(output);
    File.WriteAllText(Path.Combine(output, "comparison.json"), JsonSerializer.Serialize(report, new JsonSerializerOptions { WriteIndented = true }));
    File.WriteAllText(Path.Combine(output, "comparison.md"), markdown.ToString());
    foreach (var coverage in report.Coverage)
        Console.WriteLine($"{coverage.Family}: {coverage.ComparedFiles}/{coverage.BaselineFiles} files compared; {coverage.ExactMatches} exact, {coverage.TriviaOnlyMatches} trivia-only, {coverage.ApiMatches} API-declaration matches.");
    Console.WriteLine($"Report: {Path.Combine(output, "comparison.md")}");
    return report.HasErrors ? 2 : args.Length == 4 && !report.IsFullMatch ? 1 : 0;
}
catch (Exception exception) when (exception is IOException or InvalidDataException or UnauthorizedAccessException or ArgumentException)
{
    Console.Error.WriteLine(exception.Message);
    return 2;
}

static bool Inside(string path, string root) => path.Equals(root, StringComparison.OrdinalIgnoreCase)
    || path.StartsWith(Path.TrimEndingDirectorySeparator(root) + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase);
static string Escape(string text) => text.Replace("`", "'").Replace("\r", " ").Replace("\n", " ").Replace("|", "\\|");

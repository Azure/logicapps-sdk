// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

internal static class Program
{
    private sealed class Manifest
    {
        public string[] Sources { get; set; } = [];
        public string[] References { get; set; } = [];
        public string Defines { get; set; } = "";
        public bool CheckOverflow { get; set; }
        public string LanguageVersion { get; set; } = "";
    }
    private static int Main(string[] args)
    {
        try
        {
            if (args.Length != 2) throw new ArgumentException("Expected compilation manifest and output directory.");
            var manifest = JsonSerializer.Deserialize<Manifest>(File.ReadAllText(args[0]), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
            var options = new CSharpParseOptions(
                ResolveLanguageVersion(manifest.LanguageVersion),
                preprocessorSymbols: manifest.Defines.Split(';', StringSplitOptions.RemoveEmptyEntries));
            var trees = manifest.Sources.Select(path => CSharpSyntaxTree.ParseText(File.ReadAllText(path), options, path)).ToArray();
            var references = manifest.References.Distinct(StringComparer.OrdinalIgnoreCase).Select(path => MetadataReference.CreateFromFile(path));
            var result = ExpressionCompiler.Transform(CSharpCompilation.Create("WorkflowAuthoring", trees, references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, checkOverflow: manifest.CheckOverflow)));
            if (result.Diagnostics.Count != 0)
            {
                foreach (var diagnostic in result.Diagnostics)
                {
                    var location = diagnostic.Location.GetLineSpan();
                    Console.Error.WriteLine($"{location.Path}({location.StartLinePosition.Line + 1},{location.StartLinePosition.Character + 1}): error {diagnostic.Id}: {diagnostic.GetMessage()}");
                }
                return 1;
            }
            Directory.CreateDirectory(args[1]);
            var outputs = new List<string>();
            var index = 0;
            foreach (var source in result.Sources)
            {
                var path = Path.Combine(args[1], index++ + "_" + Path.GetFileName(source.Key));
                File.WriteAllText(path, "#line 1 " + ExpressionCompiler.Quote(source.Key) + Environment.NewLine + source.Value);
                outputs.Add(path);
            }
            File.WriteAllLines(Path.Combine(args[1], "compiled-files.txt"), outputs);
            return 0;
        }
        catch (Exception error) when (error is IOException or ArgumentException or JsonException)
        {
            Console.Error.WriteLine("error LAEXP002: " + error.Message);
            return 1;
        }
    }

    internal static LanguageVersion ResolveLanguageVersion(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return LanguageVersion.CSharp12;
        if (LanguageVersionFacts.TryParse(value.Trim(), out var languageVersion)) return languageVersion;
        throw new ArgumentException(
            $"The workflow expression compiler does not support C# language version '{value}'. " +
            "Upgrade Microsoft.Azure.Workflows.Sdk or select a supported language version.");
    }
}

// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Text;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

internal static class Program
{
    private static int Main(string[] args)
    {
        try
        {
            if (args.Length != 2) throw new ArgumentException("Expected a compilation manifest and output directory.");
            var manifest = JsonSerializer.Deserialize<CompilationManifest>(File.ReadAllText(args[0]),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? throw new ArgumentException("Empty compilation manifest.");
            var sources = manifest.SourcesFile == null ? manifest.Sources : File.ReadAllLines(manifest.SourcesFile);
            var references = manifest.ReferencesFile == null ? manifest.References : File.ReadAllLines(manifest.ReferencesFile);
            if (!LanguageVersionFacts.TryParse(manifest.LanguageVersion, out var language))
                throw new ArgumentException($"Unknown C# language version '{manifest.LanguageVersion}'.");
            var options = new CSharpParseOptions(language, preprocessorSymbols: manifest.Defines.Where(define => define.Length != 0));
            var trees = sources.Distinct(StringComparer.OrdinalIgnoreCase).Select(path =>
                CSharpSyntaxTree.ParseText(File.ReadAllText(path), options, path, Encoding.UTF8));
            var metadata = references.Distinct(StringComparer.OrdinalIgnoreCase).Select(path =>
                MetadataReference.CreateFromFile(path, MetadataReferenceProperties.Assembly
                    .WithAliases(manifest.ReferenceAliases.TryGetValue(path, out var aliases) ? aliases : [])
                    .WithEmbedInteropTypes(manifest.EmbedInteropReferences.Contains(path))));
            var compilationOptions = new CSharpCompilationOptions(
                manifest.OutputKind.Equals("Library", StringComparison.OrdinalIgnoreCase) ? OutputKind.DynamicallyLinkedLibrary : OutputKind.ConsoleApplication,
                allowUnsafe: manifest.AllowUnsafe, checkOverflow: manifest.CheckOverflow,
                nullableContextOptions: manifest.Nullable == "enable" ? NullableContextOptions.Enable : NullableContextOptions.Disable);
            if (manifest.SignAssembly)
                compilationOptions = compilationOptions.WithCryptoKeyFile(manifest.KeyFile).WithDelaySign(manifest.DelaySign)
                    .WithPublicSign(manifest.PublicSign).WithStrongNameProvider(new DesktopStrongNameProvider());
            var compilation = CSharpCompilation.Create(manifest.AssemblyName, trees, metadata, compilationOptions);
            var result = ExpressionCompiler.Transform(compilation);
            foreach (var diagnostic in result.Diagnostics) Console.Error.WriteLine(diagnostic);
            if (result.Diagnostics.Any(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)) return 1;
            Directory.CreateDirectory(args[1]);
            var files = new List<string>();
            foreach (var entry in result.Sources)
            {
                var hash = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes(entry.Key)))[..16];
                var path = Path.GetFullPath(Path.Combine(args[1], hash + "_" + Path.GetFileName(entry.Key)));
                File.WriteAllText(path, "#line 1 " + ExpressionCompiler.Quote(entry.Key) + Environment.NewLine + entry.Value, new UTF8Encoding(false));
                files.Add(path);
            }
            File.WriteAllLines(Path.Combine(args[1], "compiled-files.txt"), files);
            return 0;
        }
        catch (Exception error) when (error is IOException or ArgumentException or JsonException or UnauthorizedAccessException)
        {
            Console.Error.WriteLine("error LAEXP002: " + error.Message);
            return 1;
        }
    }

    private sealed class CompilationManifest
    {
        public string[] Sources { get; set; } = [];
        public string? SourcesFile { get; set; }
        public string[] References { get; set; } = [];
        public string? ReferencesFile { get; set; }
        public Dictionary<string, string[]> ReferenceAliases { get; set; } = [];
        public string[] EmbedInteropReferences { get; set; } = [];
        public string[] Defines { get; set; } = [];
        public string LanguageVersion { get; set; } = "12.0";
        public string Nullable { get; set; } = "";
        public string AssemblyName { get; set; } = "Workflow";
        public string OutputKind { get; set; } = "Library";
        public bool AllowUnsafe { get; set; }
        public bool CheckOverflow { get; set; }
        public bool SignAssembly { get; set; }
        public bool DelaySign { get; set; }
        public bool PublicSign { get; set; }
        public string? KeyFile { get; set; }
    }
}

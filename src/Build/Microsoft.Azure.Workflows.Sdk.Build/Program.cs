// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

internal static class Program
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
        WriteIndented = true,
    };

    public static int Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "validate-deployment")
        {
            return RunDeploymentValidation(args);
        }

        if (args.Length != 2)
        {
            Console.Error.WriteLine("error WFBUILD100: Expected a compilation manifest and output directory.");
            return 1;
        }

        try
        {
            var manifest = JsonSerializer.Deserialize<CompilationManifest>(
                File.ReadAllText(args[0]), JsonOptions)
                ?? throw new InvalidDataException("Compilation manifest is empty.");
            return RunSourceTransformation(manifest, args[1]);
        }
        catch (Exception error) when (error is IOException or InvalidDataException or UnauthorizedAccessException or JsonException or ArgumentException)
        {
            Console.Error.WriteLine($"error WFBUILD100: {error.Message}");
            return 1;
        }
    }

    private static int RunDeploymentValidation(string[] args)
    {
        if (args.Length is not (3 or 4))
        {
            Console.Error.WriteLine("error WFDEP001: Expected validate-deployment <requirements.json> <deployment-directory> [host-profile.json].");
            return 1;
        }

        try
        {
            var files = Directory.Exists(args[1])
                ? Directory.GetFiles(args[1], "*.workflow-expressions.json", SearchOption.TopDirectoryOnly)
                : [args[1]];
            if (files.Length == 0) throw new InvalidDataException("No dependency manifests were found.");
            var manifests = files.Select(file =>
                JsonSerializer.Deserialize<WorkflowDependencyManifest>(File.ReadAllText(file), JsonOptions)
                    ?? throw new InvalidDataException($"Empty dependency manifest '{file}'.")).ToArray();
            if (manifests.Any(m => m.Version != 1 || m.Dependencies == null))
                throw new InvalidDataException("Unsupported or invalid dependency manifest.");
            var requirements = new WorkflowDependencyManifest
            {
                AssemblyName = string.Join(", ", manifests.Select(m => m.AssemblyName)),
                Dependencies = manifests.SelectMany(m => m.Dependencies).Distinct().ToArray(),
            };
            var profile = args.Length == 4
                ? JsonSerializer.Deserialize<WorkflowHostProfile>(File.ReadAllText(args[3]), JsonOptions)
                    ?? throw new InvalidDataException("Empty host profile.")
                : null;
            var diagnostics = WorkflowDeploymentValidator.Validate(requirements, args[2], profile);
            foreach (var diagnostic in diagnostics)
                Console.Error.WriteLine($"{diagnostic.File}: error {diagnostic.Code}: {diagnostic.Message}");
            return diagnostics.Count == 0 ? 0 : 1;
        }
        catch (Exception error) when (error is IOException or InvalidDataException or UnauthorizedAccessException or JsonException or ArgumentException or BadImageFormatException)
        {
            Console.Error.WriteLine($"error WFDEP001: {error.Message}");
            return 1;
        }
    }

    private static int RunSourceTransformation(CompilationManifest manifest, string outputDirectory)
    {
        var (compilation, generatedOriginals) = CreateCompilation(manifest, outputDirectory);
        var result = ExpressionCompilationTransformer.Transform(compilation);
        foreach (var diagnostic in result.Diagnostics)
        {
            Console.Error.WriteLine(diagnostic);
        }

        if (result.Diagnostics.Any(d => d.Severity == DiagnosticSeverity.Error))
        {
            return 1;
        }

        WriteBuildOutputs(manifest.AssemblyName, outputDirectory, generatedOriginals, result);
        return 0;
    }

    private static (CSharpCompilation Compilation, Dictionary<string, string> GeneratedOriginals) CreateCompilation(
        CompilationManifest manifest, string outputDirectory)
    {
        if (manifest.SourcesFile != null)
        {
            manifest.Sources = File.ReadAllLines(manifest.SourcesFile);
        }

        if (manifest.ReferencesFile != null)
        {
            manifest.References = File.ReadAllLines(manifest.ReferencesFile);
        }

        if (manifest.Sources == null || manifest.Sources.Length == 0 ||
            manifest.References == null || manifest.Defines == null || manifest.ReferenceAliases == null || manifest.SchemaFiles == null ||
            manifest.EmbedInteropReferences == null || manifest.ReferenceAliases.Values.Any(a => a == null || a.Any(string.IsNullOrWhiteSpace)) ||
            manifest.Nullable == null || manifest.Platform == null || manifest.OutputKind == null)
        {
            throw new InvalidDataException("The compilation manifest must provide source files and non-null reference/define lists.");
        }

        if (!LanguageVersionFacts.TryParse(manifest.LanguageVersion, out var languageVersion))
        {
            throw new ArgumentException($"Unsupported C# language version '{manifest.LanguageVersion}'.");
        }

        var parseOptions = new CSharpParseOptions(languageVersion,
            preprocessorSymbols: manifest.Defines.Where(d => !string.IsNullOrWhiteSpace(d)));
        var pathComparer = OperatingSystem.IsWindows() ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;
        var referenceAliases = manifest.ReferenceAliases.ToDictionary(p => Path.GetFullPath(p.Key), p => p.Value, pathComparer);
        var embedInteropReferences = manifest.EmbedInteropReferences.Select(Path.GetFullPath).ToHashSet(pathComparer);
        var paths = manifest.Sources.Select(Path.GetFullPath).Distinct(pathComparer).ToArray();
        var trees = paths.Select(path => CSharpSyntaxTree.ParseText(
            File.ReadAllText(path), parseOptions, path, Encoding.UTF8)).ToList();
        var generatedOriginals = new Dictionary<string, string>(pathComparer);
        foreach (var schemaPath in manifest.SchemaFiles.Select(Path.GetFullPath).Distinct(pathComparer))
        {
            var prefix = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(schemaPath)))[..16];
            foreach (var source in WorkflowSchemaGenerator.Generate(File.ReadAllText(schemaPath)))
            {
                var generatedPath = Path.GetFullPath(Path.Combine(outputDirectory, "schema-" + prefix + "-" + source.Key));
                generatedOriginals.Add(generatedPath, source.Value);
                trees.Add(CSharpSyntaxTree.ParseText(source.Value, parseOptions, generatedPath, Encoding.UTF8));
            }
        }
        var references = manifest.References.Select(Path.GetFullPath).Distinct(pathComparer).Select(path =>
            MetadataReference.CreateFromFile(path, MetadataReferenceProperties.Assembly
                .WithAliases(referenceAliases.TryGetValue(path, out var aliases) ? aliases : [])
                .WithEmbedInteropTypes(embedInteropReferences.Contains(path)))).ToArray();
        var nullable = manifest.Nullable.ToLowerInvariant() switch
        {
            "enable" => NullableContextOptions.Enable,
            "warnings" => NullableContextOptions.Warnings,
            "annotations" => NullableContextOptions.Annotations,
            "" or "disable" => NullableContextOptions.Disable,
            _ => throw new ArgumentException($"Unsupported nullable context '{manifest.Nullable}'."),
        };
        var outputKind = manifest.OutputKind.ToLowerInvariant() switch
        {
            "exe" => OutputKind.ConsoleApplication,
            "winexe" => OutputKind.WindowsApplication,
            "library" => OutputKind.DynamicallyLinkedLibrary,
            "module" => OutputKind.NetModule,
            _ => throw new ArgumentException($"Unsupported output kind '{manifest.OutputKind}'."),
        };
        if (!Enum.TryParse<Platform>(manifest.Platform.Replace("-", ""), ignoreCase: true, out var platform))
            throw new ArgumentException($"Unsupported platform '{manifest.Platform}'.");
        var options = new CSharpCompilationOptions(outputKind,
            checkOverflow: manifest.CheckOverflow,
            allowUnsafe: manifest.AllowUnsafe,
            nullableContextOptions: nullable,
            platform: platform,
            mainTypeName: string.IsNullOrEmpty(manifest.StartupObject) ? null : manifest.StartupObject);
        if (manifest.SignAssembly)
        {
            options = options
                .WithCryptoKeyFile(manifest.KeyFile)
                .WithCryptoKeyContainer(manifest.KeyContainer)
                .WithDelaySign(manifest.DelaySign)
                .WithPublicSign(manifest.PublicSign)
                .WithStrongNameProvider(new DesktopStrongNameProvider());
        }

        return (CSharpCompilation.Create(manifest.AssemblyName, trees, references, options), generatedOriginals);
    }

    private static void WriteBuildOutputs(string assemblyName, string outputDirectory,
        IReadOnlyDictionary<string, string> generatedOriginals, TransformationResult result)
    {
        Directory.CreateDirectory(outputDirectory);
        foreach (var original in generatedOriginals)
        {
            if (!File.Exists(original.Key) || File.ReadAllText(original.Key) != original.Value)
                File.WriteAllText(original.Key, original.Value, new UTF8Encoding(false));
        }
        var compiledFiles = new List<string>();
        foreach (var entry in result.Sources)
        {
            var hash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(entry.Key)))[..16];
            var outputPath = Path.GetFullPath(Path.Combine(outputDirectory, hash + "_" + Path.GetFileName(entry.Key)));
            var content = "#line 1 " + ExpressionCompilationTransformer.Quote(entry.Key) + Environment.NewLine + entry.Value;
            if (!File.Exists(outputPath) || File.ReadAllText(outputPath) != content)
            {
                File.WriteAllText(outputPath, content, new UTF8Encoding(false));
            }

            compiledFiles.Add(outputPath);
        }

        // Replace the manifest only after all analysis succeeded, so a failed build never consumes stale inputs.
        File.WriteAllText(Path.Combine(outputDirectory, "expression-dependencies.json"),
            JsonSerializer.Serialize(new WorkflowDependencyManifest
            {
                AssemblyName = assemblyName,
                Dependencies = result.Dependencies.ToArray(),
            }, JsonOptions), new UTF8Encoding(false));
        File.WriteAllLines(Path.Combine(outputDirectory, "compiled-files.txt"), compiledFiles);
    }
}

internal sealed class CompilationManifest
{
    public string[] Sources { get; set; } = [];
    public string[] References { get; set; } = [];
    public string[] SchemaFiles { get; set; } = [];
    public Dictionary<string, string[]> ReferenceAliases { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public string[] EmbedInteropReferences { get; set; } = [];
    public string? SourcesFile { get; set; }
    public string? ReferencesFile { get; set; }
    public string[] Defines { get; set; } = [];
    public string LanguageVersion { get; set; } = "latest";
    public string Nullable { get; set; } = "disable";
    public bool AllowUnsafe { get; set; }
    public bool CheckOverflow { get; set; }
    public bool SignAssembly { get; set; }
    public bool DelaySign { get; set; }
    public bool PublicSign { get; set; }
    public string? KeyFile { get; set; }
    public string? KeyContainer { get; set; }
    public string OutputKind { get; set; } = "Library";
    public string Platform { get; set; } = "AnyCpu";
    public string? StartupObject { get; set; }
    public string AssemblyName { get; set; } = "WorkflowAuthoring";
}

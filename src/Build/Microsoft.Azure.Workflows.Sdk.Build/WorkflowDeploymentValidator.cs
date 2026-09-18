// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public sealed class WorkflowDependencyManifest
{
    public int Version { get; set; } = 1;
    public string AssemblyName { get; set; } = "";
    public WorkflowDependency[] Dependencies { get; set; } = [];
}

public sealed class WorkflowHostProfile
{
    public int Version { get; set; } = 1;
    public string Host { get; set; } = "";
    public string Evidence { get; set; } = "";
    public bool LiteralMarkerEscapingVerified { get; set; }
    public bool NativeExpressionsVerified { get; set; }
    public bool NativeConditionsVerified { get; set; }
    public string? LanguageVersion { get; set; }
    public string[] NamespaceImports { get; set; } = [];
    public WorkflowApprovedDependency[] ApprovedDependencies { get; set; } = [];
}

public sealed class WorkflowApprovedDependency
{
    public string Assembly { get; set; } = "";
    public string Sha256 { get; set; } = "";
}

public sealed record WorkflowDeploymentDiagnostic(string Code, string Message, string File);

/// <summary>Validates deployment artifacts; it does not certify or simulate an execution host.</summary>
public static class WorkflowDeploymentValidator
{
    public static IReadOnlyList<WorkflowDeploymentDiagnostic> Validate(
        WorkflowDependencyManifest requirements, string deploymentDirectory, WorkflowHostProfile? profile = null)
    {
        ArgumentNullException.ThrowIfNull(requirements);
        ArgumentException.ThrowIfNullOrWhiteSpace(deploymentDirectory);
        var diagnostics = new List<WorkflowDeploymentDiagnostic>();
        if (requirements.Version != 1 || requirements.Dependencies == null ||
            requirements.Dependencies.Any(d => d == null || string.IsNullOrWhiteSpace(d.Assembly) ||
                string.IsNullOrWhiteSpace(d.AssemblyIdentity) || string.IsNullOrWhiteSpace(d.MetadataTypeName) ||
                string.IsNullOrWhiteSpace(d.TypeIdentifier)))
        {
            diagnostics.Add(new("WFDEP001", "Unsupported or invalid expression dependency manifest.", deploymentDirectory));
            return diagnostics;
        }

        profile ??= new WorkflowHostProfile();
        if (profile.Version != 1 || profile.ApprovedDependencies == null || profile.NamespaceImports == null ||
            profile.NamespaceImports.Any(string.IsNullOrWhiteSpace) ||
            profile.ApprovedDependencies.Any(d => d == null || string.IsNullOrWhiteSpace(d.Assembly) ||
                d.Sha256 == null || d.Sha256.Length != 64 || d.Sha256.Any(c => !Uri.IsHexDigit(c))) ||
            profile.ApprovedDependencies.Select(d => d.Assembly).Distinct(StringComparer.OrdinalIgnoreCase).Count() !=
                profile.ApprovedDependencies.Length ||
            (profile.LiteralMarkerEscapingVerified || profile.NativeConditionsVerified || profile.NativeExpressionsVerified) &&
                (string.IsNullOrWhiteSpace(profile.Host) || string.IsNullOrWhiteSpace(profile.Evidence)))
        {
            diagnostics.Add(new("WFDEP001", "A host profile requires unique hash-pinned approvals and host/evidence identifiers for verified capabilities.", deploymentDirectory));
            return diagnostics;
        }

        var parseOptions = CSharpParseOptions.Default;
        if (profile.LanguageVersion != null)
        {
            if (!LanguageVersionFacts.TryParse(profile.LanguageVersion, out var languageVersion))
            {
                diagnostics.Add(new("WFDEP001", $"Unknown host language version '{profile.LanguageVersion}'.", deploymentDirectory));
                return diagnostics;
            }
            parseOptions = parseOptions.WithLanguageVersion(languageVersion);
        }

        var enumeration = new EnumerationOptions { RecurseSubdirectories = true, AttributesToSkip = FileAttributes.ReparsePoint };
        var identifiers = new HashSet<string>(StringComparer.Ordinal);
        var sdkHelperFiles = new HashSet<string>(StringComparer.Ordinal);
        var workflows = Directory.EnumerateFiles(deploymentDirectory, "workflow.json", enumeration).ToArray();
        if (workflows.Length == 0)
        {
            diagnostics.Add(new("WFDEP007", "No workflow.json deployment artifacts were found; no workflow deployment has been validated.", deploymentDirectory));
            return diagnostics;
        }
        foreach (var workflow in workflows)
        {
            using var document = JsonDocument.Parse(File.ReadAllText(workflow));
            Inspect(document.RootElement, workflow);
        }

        if (!requirements.Dependencies.Any(d => d.Assembly == ExpressionCompilationTransformer.SdkAssembly &&
                d.MetadataTypeName == ExpressionCompilationTransformer.SdkAssembly + ".WorkflowWireRuntime"))
        {
            foreach (var file in sdkHelperFiles)
                diagnostics.Add(new("WFDEP003",
                    "Native SDK wire helpers require an SDK dependency manifest and explicit host/assembly approval. Rebuild the authoring library; worker-side SDK deployment alone does not make it available to the expression compiler.",
                    file));
        }

        var used = requirements.Dependencies.Where(d => identifiers.Contains(d.TypeIdentifier) ||
            d.IsExtension && d.Member != null && identifiers.Contains(d.Member)).ToArray();
        foreach (var dependency in used)
        {
            if (!dependency.Accessible)
                diagnostics.Add(new("WFDEP003", $"Native dependency '{dependency.TypeName}.{dependency.Member}' is not publicly accessible to the execution host.", dependency.SourceFile));
            if (dependency.IsExtension && !identifiers.Contains(dependency.TypeIdentifier) &&
                !profile.NamespaceImports.Contains(dependency.Namespace, StringComparer.Ordinal))
                diagnostics.Add(new("WFDEP008", $"The host must import namespace '{dependency.Namespace}' for extension '{dependency.TypeName}.{dependency.Member}'.", dependency.SourceFile));
        }
        foreach (var group in used.GroupBy(d => d.AssemblyIdentity, StringComparer.Ordinal))
        {
            var requirement = group.First();
            var approval = profile.ApprovedDependencies.SingleOrDefault(d =>
                string.Equals(d.Assembly, requirement.Assembly, StringComparison.OrdinalIgnoreCase));
            if (approval == null)
            {
                diagnostics.Add(new("WFDEP002",
                    $"Native dependency '{requirement.Assembly}' ({requirement.TypeName}) is not explicitly approved for deployment.",
                    requirement.SourceFile));
                continue;
            }

            var matches = new List<string>();
            foreach (var file in Directory.EnumerateFiles(deploymentDirectory, "*.dll", enumeration))
            {
                AssemblyName identity;
                try
                {
                    identity = AssemblyName.GetAssemblyName(file);
                }
                catch (BadImageFormatException)
                {
                    // Native DLLs are not candidates for a managed expression dependency.
                    continue;
                }
                if (string.Equals(identity.FullName, requirement.AssemblyIdentity, StringComparison.Ordinal))
                {
                    matches.Add(file);
                }
            }

            if (matches.Count == 0)
            {
                diagnostics.Add(new("WFDEP003",
                    $"Missing deployed assembly '{requirement.AssemblyIdentity}' for '{requirement.TypeName}'.",
                    requirement.SourceFile));
                continue;
            }

            foreach (var file in matches)
            {
                using var stream = File.OpenRead(file);
                var actual = Convert.ToHexString(SHA256.HashData(stream));
                if (!string.Equals(actual, approval.Sha256, StringComparison.OrdinalIgnoreCase))
                {
                    diagnostics.Add(new("WFDEP003", $"Deployed assembly '{requirement.Assembly}' does not match its approved SHA256.", file));
                    continue;
                }

                stream.Position = 0;
                using var pe = new PEReader(stream);
                var metadata = pe.GetMetadataReader();
                if (IsReferenceAssembly(metadata))
                {
                    diagnostics.Add(new("WFDEP003", $"'{requirement.Assembly}' is a reference assembly, not an executable deployment dependency.", file));
                    continue;
                }

                var types = metadata.TypeDefinitions.Select(h => FullName(metadata, h)).ToHashSet(StringComparer.Ordinal);
                foreach (var dependency in group)
                {
                    if (!types.Contains(dependency.MetadataTypeName))
                        diagnostics.Add(new("WFDEP003", $"Deployed '{requirement.Assembly}' lacks type '{dependency.MetadataTypeName}'.", file));
                }
            }
        }
        return diagnostics;

        void Inspect(JsonElement value, string file)
        {
            if (value.ValueKind == JsonValueKind.Object)
            {
                if (value.TryGetProperty("type", out var type) && type.ValueKind == JsonValueKind.String &&
                    string.Equals(type.GetString(), "If", StringComparison.OrdinalIgnoreCase) &&
                    value.TryGetProperty("expression", out var condition) && condition.ValueKind == JsonValueKind.String &&
                    IsNative(condition.GetString()!) && !profile.NativeConditionsVerified)
                {
                    diagnostics.Add(new("WFDEP005", "The selected host/designer has no verified native Condition expression capability.", file));
                }
                foreach (var property in value.EnumerateObject()) Inspect(property.Value, file);
            }
            else if (value.ValueKind == JsonValueKind.Array)
            {
                foreach (var element in value.EnumerateArray()) Inspect(element, file);
            }
            else if (value.ValueKind == JsonValueKind.String)
            {
                var text = value.GetString()!;
                if (text.StartsWith("@@csharp{", StringComparison.Ordinal) && !profile.LiteralMarkerEscapingVerified)
                {
                    diagnostics.Add(new("WFDEP004", "Literal @csharp data requires a host with verified leading-@ escaping; deployment is blocked.", file));
                }
                if (text.StartsWith("@csharp{", StringComparison.Ordinal) && !IsNative(text))
                    diagnostics.Add(new("WFDEP006", "Malformed native expression envelope.", file));
                if (IsNative(text))
                {
                    if (!profile.NativeExpressionsVerified)
                        diagnostics.Add(new("WFDEP009", "The selected execution host has no verified @csharp expression capability; deployment is blocked.", file));
                    var syntax = SyntaxFactory.ParseExpression(text[8..^1], options: parseOptions);
                    foreach (var diagnostic in syntax.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error))
                        diagnostics.Add(new("WFDEP006", "Native expression is invalid for the selected host language: " + diagnostic.GetMessage(), file));
                    foreach (var token in syntax.DescendantTokens().Where(t => t.IsKind(SyntaxKind.IdentifierToken)))
                        identifiers.Add(token.ValueText);
                    if (syntax.DescendantNodesAndSelf().OfType<MemberAccessExpressionSyntax>().Any(access =>
                        QualifiedName(access.Expression) == ExpressionCompilationTransformer.SdkAssembly + ".WorkflowWireRuntime"))
                        sdkHelperFiles.Add(file);
                }
            }
        }
    }

    private static bool IsNative(string text) =>
        text.StartsWith("@csharp{", StringComparison.Ordinal) && text.EndsWith("}", StringComparison.Ordinal);

    private static string? QualifiedName(SyntaxNode node) => node switch
    {
        IdentifierNameSyntax identifier => identifier.Identifier.ValueText,
        AliasQualifiedNameSyntax alias when alias.Alias.Identifier.ValueText == "global" => QualifiedName(alias.Name),
        QualifiedNameSyntax qualified when QualifiedName(qualified.Left) is { } left =>
            left + "." + QualifiedName(qualified.Right),
        MemberAccessExpressionSyntax member when QualifiedName(member.Expression) is { } parent =>
            parent + "." + QualifiedName(member.Name),
        _ => null,
    };

    private static string FullName(MetadataReader reader, TypeDefinitionHandle handle)
    {
        var definition = reader.GetTypeDefinition(handle);
        var parent = definition.GetDeclaringType();
        return parent.IsNil
            ? (reader.GetString(definition.Namespace) is { Length: > 0 } ns ? ns + "." : "") + reader.GetString(definition.Name)
            : FullName(reader, parent) + "+" + reader.GetString(definition.Name);
    }

    private static bool IsReferenceAssembly(MetadataReader reader)
    {
        foreach (var handle in reader.GetAssemblyDefinition().GetCustomAttributes())
        {
            var attribute = reader.GetCustomAttribute(handle);
            if (attribute.Constructor.Kind != HandleKind.MemberReference) continue;
            var constructor = reader.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
            if (constructor.Parent.Kind != HandleKind.TypeReference) continue;
            var type = reader.GetTypeReference((TypeReferenceHandle)constructor.Parent);
            if (reader.GetString(type.Namespace) == "System.Runtime.CompilerServices" &&
                reader.GetString(type.Name) == "ReferenceAssemblyAttribute") return true;
        }
        return false;
    }
}

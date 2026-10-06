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
            InspectWorkflowValue(document.RootElement, workflow, profile, parseOptions, identifiers, sdkHelperFiles, diagnostics);
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
            ValidateDeployedAssembly(group, deploymentDirectory, enumeration, profile, diagnostics);
        }
        return diagnostics;
    }

    private static void ValidateDeployedAssembly(IGrouping<string, WorkflowDependency> dependencies,
        string deploymentDirectory, EnumerationOptions enumeration, WorkflowHostProfile profile,
        List<WorkflowDeploymentDiagnostic> diagnostics)
    {
        var requirement = dependencies.First();
        var approval = profile.ApprovedDependencies.SingleOrDefault(d =>
            string.Equals(d.Assembly, requirement.Assembly, StringComparison.OrdinalIgnoreCase));
        if (approval == null)
        {
            diagnostics.Add(new("WFDEP002",
                $"Native dependency '{requirement.Assembly}' ({requirement.TypeName}) is not explicitly approved for deployment.",
                requirement.SourceFile));
            return;
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
            return;
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

            var types = metadata.TypeDefinitions.Select(h => GetMetadataTypeName(metadata, h)).ToHashSet(StringComparer.Ordinal);
            foreach (var dependency in dependencies)
            {
                if (!types.Contains(dependency.MetadataTypeName))
                    diagnostics.Add(new("WFDEP003", $"Deployed '{requirement.Assembly}' lacks type '{dependency.MetadataTypeName}'.", file));
            }
        }
    }

    private static void InspectWorkflowValue(JsonElement value, string file, WorkflowHostProfile profile,
        CSharpParseOptions parseOptions, HashSet<string> identifiers, HashSet<string> sdkHelperFiles,
        List<WorkflowDeploymentDiagnostic> diagnostics)
    {
        if (value.ValueKind == JsonValueKind.Object)
        {
            if (value.TryGetProperty("type", out var type) && type.ValueKind == JsonValueKind.String &&
                string.Equals(type.GetString(), "If", StringComparison.OrdinalIgnoreCase) &&
                value.TryGetProperty("expression", out var condition) && condition.ValueKind == JsonValueKind.String &&
                HasNativeExpressionEnvelope(condition.GetString()!) && !profile.NativeConditionsVerified)
            {
                diagnostics.Add(new("WFDEP005", "The selected host/designer has no verified native Condition expression capability.", file));
            }
            foreach (var property in value.EnumerateObject())
                InspectWorkflowValue(property.Value, file, profile, parseOptions, identifiers, sdkHelperFiles, diagnostics);
        }
        else if (value.ValueKind == JsonValueKind.Array)
        {
            foreach (var element in value.EnumerateArray())
                InspectWorkflowValue(element, file, profile, parseOptions, identifiers, sdkHelperFiles, diagnostics);
        }
        else if (value.ValueKind == JsonValueKind.String)
        {
            var text = value.GetString()!;
            if (!text.StartsWith("@@", StringComparison.Ordinal) &&
                !text.StartsWith("#{", StringComparison.Ordinal) &&
                (text.StartsWith("@", StringComparison.Ordinal) || text.Contains("@{", StringComparison.Ordinal)))
            {
                diagnostics.Add(new("WFDEP010",
                    "Standalone template expressions and template interpolation are unsupported. Rebuild with C# expressions or escape literal leading-@ data.",
                    file));
            }
            if (text.StartsWith("@@", StringComparison.Ordinal) && !profile.LiteralMarkerEscapingVerified)
            {
                diagnostics.Add(new("WFDEP004", "Literal leading-@ data requires a host with verified escaping; deployment is blocked.", file));
            }
            if (text.StartsWith("#{", StringComparison.Ordinal) && !HasNativeExpressionEnvelope(text))
                diagnostics.Add(new("WFDEP006", "Malformed native expression envelope.", file));
            if (HasNativeExpressionEnvelope(text))
            {
                if (!profile.NativeExpressionsVerified)
                    diagnostics.Add(new("WFDEP009", "The selected execution host has no verified #{...} expression capability; deployment is blocked.", file));
                var source = text[NativePrefix.Length..^1];
                var syntax = SyntaxFactory.ParseExpression(source, options: parseOptions);
                var script = CSharpSyntaxTree.ParseText(source, parseOptions.WithKind(SourceCodeKind.Script));
                if (script.GetRoot().DescendantTrivia(descendIntoTrivia: true).Any(trivia =>
                    trivia.GetStructure() is ReferenceDirectiveTriviaSyntax or LoadDirectiveTriviaSyntax))
                    diagnostics.Add(new("WFDEP006", "Native expressions cannot use #r or #load directives.", file));
                foreach (var diagnostic in syntax.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error))
                    diagnostics.Add(new("WFDEP006", "Native expression is invalid for the selected host language: " + diagnostic.GetMessage(), file));
                foreach (var token in syntax.DescendantTokens().Where(t => t.IsKind(SyntaxKind.IdentifierToken)))
                    identifiers.Add(token.ValueText);
                if (syntax.DescendantNodesAndSelf().OfType<MemberAccessExpressionSyntax>().Any(access =>
                    GetQualifiedSyntaxName(access.Expression) == ExpressionCompilationTransformer.SdkAssembly + ".WorkflowWireRuntime"))
                    sdkHelperFiles.Add(file);
            }
        }
    }

    private const string NativePrefix = "#{";

    private static bool HasNativeExpressionEnvelope(string text) =>
        text.StartsWith(NativePrefix, StringComparison.Ordinal) && text.EndsWith("}", StringComparison.Ordinal);

    private static string? GetQualifiedSyntaxName(SyntaxNode node) => node switch
    {
        IdentifierNameSyntax identifier => identifier.Identifier.ValueText,
        AliasQualifiedNameSyntax alias when alias.Alias.Identifier.ValueText == "global" => GetQualifiedSyntaxName(alias.Name),
        QualifiedNameSyntax qualified when GetQualifiedSyntaxName(qualified.Left) is { } left =>
            left + "." + GetQualifiedSyntaxName(qualified.Right),
        MemberAccessExpressionSyntax member when GetQualifiedSyntaxName(member.Expression) is { } parent =>
            parent + "." + GetQualifiedSyntaxName(member.Name),
        _ => null,
    };

    private static string GetMetadataTypeName(MetadataReader reader, TypeDefinitionHandle handle)
    {
        var definition = reader.GetTypeDefinition(handle);
        var parent = definition.GetDeclaringType();
        return parent.IsNil
            ? (reader.GetString(definition.Namespace) is { Length: > 0 } ns ? ns + "." : "") + reader.GetString(definition.Name)
            : GetMetadataTypeName(reader, parent) + "+" + reader.GetString(definition.Name);
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

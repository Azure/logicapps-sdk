// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

public sealed record WorkflowDependency(
    string Assembly,
    string AssemblyIdentity,
    string TypeName,
    string MetadataTypeName,
    string TypeIdentifier,
    string? Member,
    bool IsExtension,
    string SourceFile,
    int SourceLine,
    string Namespace,
    bool Accessible);

internal sealed class WorkflowDependencyCollector
{
    private readonly Dictionary<string, WorkflowDependency> dependencies = new(StringComparer.Ordinal);

    internal ImmutableArray<WorkflowDependency> Dependencies =>
        dependencies.Values.OrderBy(d => d.AssemblyIdentity, StringComparer.Ordinal)
            .ThenBy(d => d.MetadataTypeName, StringComparer.Ordinal)
            .ThenBy(d => d.Member, StringComparer.Ordinal).ToImmutableArray();

    internal void RecordSymbol(ISymbol? symbol, SyntaxNode node)
    {
        if (symbol is INamedTypeSymbol type)
        {
            RecordType(type, node);
            return;
        }

        if (symbol is IMethodSymbol method)
        {
            AddDependency(method.ContainingType, method.MetadataName,
                method.IsExtensionMethod || method.ReducedFrom != null, node, method.DeclaredAccessibility == Accessibility.Public);
            foreach (var argument in method.TypeArguments) RecordType(argument, node);
        }
        else if (symbol is IPropertySymbol or IFieldSymbol)
        {
            AddDependency(symbol.ContainingType, symbol.MetadataName, false, node, symbol.DeclaredAccessibility == Accessibility.Public);
        }
    }

    internal void RecordType(ITypeSymbol? type, SyntaxNode node)
    {
        if (type is IArrayTypeSymbol array)
        {
            RecordType(array.ElementType, node);
        }
        else if (type is INamedTypeSymbol named)
        {
            if (!named.IsAnonymousType) AddDependency(named, null, false, node);
            foreach (var argument in named.TypeArguments) RecordType(argument, node);
        }
    }

    private void AddDependency(INamedTypeSymbol? type, string? member, bool isExtension, SyntaxNode node, bool accessible = true)
    {
        if (type == null || type.IsAnonymousType || type.ContainingAssembly == null ||
            IsImplicitHostAssembly(type.ContainingAssembly.Identity))
        {
            return;
        }

        var assembly = type.ContainingAssembly.Identity;
        var metadataName = GetMetadataTypeName(type.OriginalDefinition);
        var key = assembly + "|" + metadataName + "|" + member;
        dependencies.TryAdd(key, new WorkflowDependency(assembly.Name, assembly.ToString(),
            type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
            metadataName, type.Name, member, isExtension, node.SyntaxTree.FilePath,
            node.GetLocation().GetLineSpan().StartLinePosition.Line + 1, type.ContainingNamespace.ToDisplayString(),
            accessible && IsPubliclyAccessibleType(type)));
    }

    private static bool IsPubliclyAccessibleType(INamedTypeSymbol type) =>
        type.DeclaredAccessibility == Accessibility.Public && (type.ContainingType == null || IsPubliclyAccessibleType(type.ContainingType));

    private static string GetMetadataTypeName(INamedTypeSymbol type) =>
        type.ContainingType is { } parent
            ? GetMetadataTypeName(parent) + "+" + type.MetadataName
            : (type.ContainingNamespace.IsGlobalNamespace ? "" : type.ContainingNamespace + ".") + type.MetadataName;

    private static bool IsImplicitHostAssembly(AssemblyIdentity identity)
    {
        if (identity.Name == "Newtonsoft.Json")
        {
            return true;
        }

        var token = Convert.ToHexString(identity.PublicKeyToken.AsSpan());
        return (identity.Name is "mscorlib" or "netstandard" or "System" or "Microsoft.CSharp" ||
                identity.Name.StartsWith("System.", StringComparison.Ordinal)) &&
            token is "B77A5C561934E089" or "B03F5F7F11D50A3A" or "7CEC85D7BEA7798E" or "CC7B13FFCD2DDD51";
    }
}

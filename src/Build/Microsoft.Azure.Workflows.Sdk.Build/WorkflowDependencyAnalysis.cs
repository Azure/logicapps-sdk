// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

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

internal static class WorkflowDependencyAnalysis
{
    private static readonly AsyncLocal<Scope?> Current = new();

    internal static Scope Begin(CSharpCompilation compilation) => new(compilation);

    internal static void Record(ISymbol? symbol, SyntaxNode node)
    {
        if (symbol is INamedTypeSymbol type)
        {
            RecordType(type, node);
            return;
        }

        if (symbol is IMethodSymbol method)
        {
            Current.Value?.Add(method.ContainingType, method.MetadataName,
                method.IsExtensionMethod || method.ReducedFrom != null, node, method.DeclaredAccessibility == Accessibility.Public);
            foreach (var argument in method.TypeArguments) RecordType(argument, node);
        }
        else if (symbol is IPropertySymbol or IFieldSymbol)
        {
            Current.Value?.Add(symbol.ContainingType, symbol.MetadataName, false, node, symbol.DeclaredAccessibility == Accessibility.Public);
        }
    }

    internal static void RecordType(ITypeSymbol? type, SyntaxNode node)
    {
        if (type is IArrayTypeSymbol array)
        {
            RecordType(array.ElementType, node);
        }
        else if (type is INamedTypeSymbol named)
        {
            if (!named.IsAnonymousType) Current.Value?.Add(named, null, false, node);
            foreach (var argument in named.TypeArguments) RecordType(argument, node);
        }
    }

    internal sealed class Scope : IDisposable
    {
        private readonly Scope? parent;
        private readonly Dictionary<string, WorkflowDependency> dependencies = new(StringComparer.Ordinal);

        internal Scope(CSharpCompilation compilation)
        {
            ArgumentNullException.ThrowIfNull(compilation);
            parent = Current.Value;
            Current.Value = this;
        }

        internal ImmutableArray<WorkflowDependency> Dependencies =>
            dependencies.Values.OrderBy(d => d.AssemblyIdentity, StringComparer.Ordinal)
                .ThenBy(d => d.MetadataTypeName, StringComparer.Ordinal)
                .ThenBy(d => d.Member, StringComparer.Ordinal).ToImmutableArray();

        internal void Add(INamedTypeSymbol? type, string? member, bool isExtension, SyntaxNode node, bool accessible = true)
        {
            if (type == null || type.IsAnonymousType || type.ContainingAssembly == null ||
                IsPlatformAssembly(type.ContainingAssembly.Identity))
            {
                return;
            }

            var assembly = type.ContainingAssembly.Identity;
            var metadataName = MetadataName(type.OriginalDefinition);
            var key = assembly + "|" + metadataName + "|" + member;
            dependencies.TryAdd(key, new WorkflowDependency(assembly.Name, assembly.ToString(),
                type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                metadataName, type.Name, member, isExtension, node.SyntaxTree.FilePath,
                node.GetLocation().GetLineSpan().StartLinePosition.Line + 1, type.ContainingNamespace.ToDisplayString(),
                accessible && PublicType(type)));
        }

        private static bool PublicType(INamedTypeSymbol type) =>
            type.DeclaredAccessibility == Accessibility.Public && (type.ContainingType == null || PublicType(type.ContainingType));

        public void Dispose() => Current.Value = parent;
    }

    private static string MetadataName(INamedTypeSymbol type) =>
        type.ContainingType is { } parent
            ? MetadataName(parent) + "+" + type.MetadataName
            : (type.ContainingNamespace.IsGlobalNamespace ? "" : type.ContainingNamespace + ".") + type.MetadataName;

    private static bool IsPlatformAssembly(AssemblyIdentity identity)
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

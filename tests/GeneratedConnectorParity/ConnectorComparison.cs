// Copyright (c) Microsoft Corporation. All rights reserved.

namespace GeneratedConnectorParity;

using System.Security.Cryptography;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public sealed record MemberDifference(string Member, string Change, string? Baseline, string? Candidate);

public sealed record FileComparison(
    string Path,
    string BaselineSha256,
    string CandidateSha256,
    bool ExactMatch,
    bool TokenMatch,
    bool ContextChanged,
    string[] BaselineContext,
    string[] CandidateContext,
    int BaselinePublicDeclarations,
    int CandidatePublicDeclarations,
    MemberDifference[] ApiDifferences,
    MemberDifference[] ImplementationDifferences,
    string[] Errors);

public sealed record SourceInventory(string Path, string Sha256);

public sealed record FamilyCoverage(
    string Family,
    int BaselineFiles,
    int CandidateFiles,
    int ComparedFiles,
    int ExactMatches,
    int TriviaOnlyMatches,
    int ApiMatches,
    int ImplementationMatches);

public sealed record ComparisonReport(
    string BaselineDirectory,
    string CandidateDirectory,
    SourceInventory[] BaselineInventory,
    SourceInventory[] CandidateInventory,
    FamilyCoverage[] Coverage,
    string[] NotGenerated,
    string[] CandidateOnly,
    FileComparison[] Files)
{
    public bool HasErrors => Files.Any(file => file.Errors.Length != 0);
    public bool IsFullMatch => !HasErrors && NotGenerated.Length == 0 && CandidateOnly.Length == 0
        && Files.All(file => file.TokenMatch);
}

public static class ConnectorComparison
{
    public static readonly string[] Families = ["managed", "serviceProviders"];

    public static ComparisonReport CompareDirectories(string baselineDirectory, string candidateDirectory)
    {
        var baseline = Inventory(baselineDirectory);
        var candidate = Inventory(candidateDirectory);
        if (baseline.Length == 0 || candidate.Length == 0)
            throw new InvalidDataException("Both roots must contain C# sources under managed or serviceProviders.");

        var left = baseline.ToDictionary(item => item.Path, StringComparer.OrdinalIgnoreCase);
        var right = candidate.ToDictionary(item => item.Path, StringComparer.OrdinalIgnoreCase);
        var files = left.Keys.Intersect(right.Keys, StringComparer.OrdinalIgnoreCase)
            .Order(StringComparer.Ordinal).Select(path =>
            {
                var result = CompareSource(path,
                    File.ReadAllText(Path.Combine(baselineDirectory, path)),
                    File.ReadAllText(Path.Combine(candidateDirectory, right[path].Path)));
                return result with
                {
                    BaselineSha256 = left[path].Sha256,
                    CandidateSha256 = right[path].Sha256,
                    ExactMatch = left[path].Sha256 == right[path].Sha256,
                };
            }).ToArray();

        var coverage = Families.Select(family =>
        {
            bool InFamily(string path) => path.StartsWith(family + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase);
            var paired = files.Where(file => InFamily(file.Path)).ToArray();
            return new FamilyCoverage(family, baseline.Count(item => InFamily(item.Path)),
                candidate.Count(item => InFamily(item.Path)), paired.Length,
                paired.Count(file => file.ExactMatch && file.Errors.Length == 0),
                paired.Count(file => !file.ExactMatch && file.TokenMatch && file.Errors.Length == 0),
                paired.Count(file => file.ApiDifferences.Length == 0 && file.Errors.Length == 0),
                paired.Count(file => file.ImplementationDifferences.Length == 0 && file.Errors.Length == 0));
        }).ToArray();

        return new ComparisonReport(Path.GetFullPath(baselineDirectory), Path.GetFullPath(candidateDirectory),
            baseline, candidate, coverage,
            left.Keys.Except(right.Keys, StringComparer.OrdinalIgnoreCase).Order(StringComparer.Ordinal).ToArray(),
            right.Keys.Except(left.Keys, StringComparer.OrdinalIgnoreCase).Order(StringComparer.Ordinal).ToArray(), files);
    }

    public static FileComparison CompareSource(string path, string baseline, string candidate)
    {
        var options = new CSharpParseOptions(LanguageVersion.CSharp13);
        var left = CSharpSyntaxTree.ParseText(baseline, options, path).GetCompilationUnitRoot();
        var right = CSharpSyntaxTree.ParseText(candidate, options, path).GetCompilationUnitRoot();
        var errors = left.GetDiagnostics().Where(item => item.Severity == DiagnosticSeverity.Error)
            .Select(item => "Baseline: " + item)
            .Concat(right.GetDiagnostics().Where(item => item.Severity == DiagnosticSeverity.Error)
                .Select(item => "Candidate: " + item)).ToArray();
        var baselineApi = Members(left, publicOnly: true, headersOnly: true);
        var candidateApi = Members(right, publicOnly: true, headersOnly: true);
        var baselineContext = Context(left);
        var candidateContext = Context(right);
        return new FileComparison(path, Hash(baseline), Hash(candidate), baseline == candidate,
            errors.Length == 0 && Fingerprint(left) == Fingerprint(right),
            !baselineContext.SequenceEqual(candidateContext, StringComparer.Ordinal), baselineContext, candidateContext,
            baselineApi.Count, candidateApi.Count, Differences(baselineApi, candidateApi),
            Differences(Members(left, publicOnly: false, headersOnly: false), Members(right, publicOnly: false, headersOnly: false)),
            errors);
    }

    public static string Hash(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value)));

    private static SourceInventory[] Inventory(string root)
    {
        if (!Directory.Exists(root))
            throw new DirectoryNotFoundException(root);
        return Families.Select(family => Path.Combine(root, family)).Where(Directory.Exists)
            .SelectMany(directory => Directory.EnumerateFiles(directory, "*.cs", SearchOption.AllDirectories))
            .Order(StringComparer.Ordinal).Select(path =>
            {
                using var stream = File.OpenRead(path);
                return new SourceInventory(Path.GetRelativePath(root, path), Convert.ToHexString(SHA256.HashData(stream)));
            }).ToArray();
    }

    private static string Fingerprint(SyntaxNode node)
    {
        var result = new StringBuilder();
        foreach (var token in node.DescendantTokens())
        {
            MeaningfulTrivia(result, token.LeadingTrivia);
            result.Append(token.RawKind).Append(':').Append(token.Text.Length).Append(':').Append(token.Text);
            MeaningfulTrivia(result, token.TrailingTrivia);
        }
        return Hash(result.ToString());
    }

    private static void MeaningfulTrivia(StringBuilder result, SyntaxTriviaList trivia)
    {
        foreach (var item in trivia)
        {
            if (item.IsDirective || item.IsKind(SyntaxKind.DisabledTextTrivia) || item.IsKind(SyntaxKind.SkippedTokensTrivia))
                result.Append('|').Append(item.RawKind).Append(':').Append(item.ToFullString().Length).Append(':').Append(item.ToFullString());
        }
    }

    private static string[] Context(CompilationUnitSyntax root) =>
        root.DescendantNodes().Where(node => node is UsingDirectiveSyntax or ExternAliasDirectiveSyntax
            || node is AttributeListSyntax { Parent: CompilationUnitSyntax })
            .Select(node => Owner(node) + ": " + string.Join(" ", node.DescendantTokens().Select(token => token.Text)))
            .Concat(root.DescendantTrivia().Where(trivia => trivia.IsDirective || trivia.IsKind(SyntaxKind.DisabledTextTrivia))
                .Select(trivia => trivia.ToFullString())).ToArray();

    private static Dictionary<string, Entry> Members(CompilationUnitSyntax root, bool publicOnly, bool headersOnly)
    {
        var members = root.DescendantNodes().OfType<MemberDeclarationSyntax>()
            .Where(node => node is not BaseNamespaceDeclarationSyntax and not EnumMemberDeclarationSyntax)
            .Where(node => !publicOnly || Visible(node))
            .Select(node => (Key: Key(node), Node: headersOnly ? Header(node) : Implementation(node)))
            .Where(item => item.Node != null);
        return members.GroupBy(item => item.Key, StringComparer.Ordinal).ToDictionary(group => group.Key, group =>
        {
            var nodes = group.Select(item => item.Node!).OrderBy(Fingerprint, StringComparer.Ordinal).ToArray();
            return new Entry(string.Join("|", nodes.Select(Fingerprint)),
                nodes.SelectMany(node => node.DescendantTokens().Select(token => token.Text)).ToArray());
        }, StringComparer.Ordinal);
    }

    private static bool Visible(MemberDeclarationSyntax node)
    {
        if (node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any(type => !Accessible(type)))
            return false;
        return Accessible(node);
    }

    private static bool Accessible(MemberDeclarationSyntax node) =>
        node.Modifiers.Any(SyntaxKind.PublicKeyword) || node.Modifiers.Any(SyntaxKind.ProtectedKeyword)
        || node.Parent is InterfaceDeclarationSyntax && !node.Modifiers.Any(SyntaxKind.PrivateKeyword);

    private static string Owner(SyntaxNode node) => string.Join(".", node.Ancestors().Reverse().Select(ancestor => ancestor switch
    {
        BaseNamespaceDeclarationSyntax space => Compact(space.Name),
        TypeDeclarationSyntax type => type.Identifier.ValueText + "`" + (type.TypeParameterList?.Parameters.Count ?? 0),
        EnumDeclarationSyntax type => type.Identifier.ValueText,
        _ => null,
    }).Where(name => name != null));

    private static string Key(MemberDeclarationSyntax node)
    {
        string Parameters(BaseParameterListSyntax? list) => list == null ? "" : string.Join(",",
            list.Parameters.Select(parameter => string.Concat(parameter.Modifiers
                .Where(token => token.IsKind(SyntaxKind.RefKeyword) || token.IsKind(SyntaxKind.OutKeyword) || token.IsKind(SyntaxKind.InKeyword))
                .Select(token => token.Text + " ")) + Compact(parameter.Type)));
        var name = node switch
        {
            TypeDeclarationSyntax type => type.Identifier.ValueText + "`" + (type.TypeParameterList?.Parameters.Count ?? 0),
            EnumDeclarationSyntax type => type.Identifier.ValueText,
            MethodDeclarationSyntax method => Compact(method.ExplicitInterfaceSpecifier) + method.Identifier.ValueText
                + "`" + (method.TypeParameterList?.Parameters.Count ?? 0) + "(" + Parameters(method.ParameterList) + ")",
            ConstructorDeclarationSyntax constructor => constructor.Identifier.ValueText + "(" + Parameters(constructor.ParameterList) + ")",
            PropertyDeclarationSyntax property => Compact(property.ExplicitInterfaceSpecifier) + property.Identifier.ValueText,
            IndexerDeclarationSyntax indexer => "this(" + Parameters(indexer.ParameterList) + ")",
            FieldDeclarationSyntax field => string.Join(",", field.Declaration.Variables.Select(variable => variable.Identifier.ValueText)),
            EventFieldDeclarationSyntax field => string.Join(",", field.Declaration.Variables.Select(variable => variable.Identifier.ValueText)),
            DelegateDeclarationSyntax declaration => declaration.Identifier.ValueText + "(" + Parameters(declaration.ParameterList) + ")",
            _ => Compact(Header(node)),
        };
        return Owner(node) + "/" + node.Kind() + "/" + name;
    }

    private static SyntaxNode Header(MemberDeclarationSyntax node) => node switch
    {
        TypeDeclarationSyntax type => type.WithMembers(default),
        MethodDeclarationSyntax method => method.WithBody(null).WithExpressionBody(null).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
        ConstructorDeclarationSyntax constructor => constructor.WithBody(null).WithExpressionBody(null).WithInitializer(null)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
        PropertyDeclarationSyntax property => property.WithInitializer(null).WithExpressionBody(null)
            .WithAccessorList(Accessors(property.AccessorList)).WithSemicolonToken(default),
        IndexerDeclarationSyntax indexer => indexer.WithExpressionBody(null).WithAccessorList(Accessors(indexer.AccessorList)).WithSemicolonToken(default),
        _ => node,
    };

    private static AccessorListSyntax Accessors(AccessorListSyntax? accessors) => SyntaxFactory.AccessorList(
        SyntaxFactory.List((accessors?.Accessors ?? SyntaxFactory.SingletonList(SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)))
            .Select(accessor => accessor.WithBody(null).WithExpressionBody(null).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)))));

    private static SyntaxNode? Implementation(MemberDeclarationSyntax node) => node switch
    {
        TypeDeclarationSyntax => null,
        MethodDeclarationSyntax method => (SyntaxNode?)method.Body ?? method.ExpressionBody,
        ConstructorDeclarationSyntax => node,
        _ => node,
    };

    private static MemberDifference[] Differences(Dictionary<string, Entry> baseline, Dictionary<string, Entry> candidate) =>
        baseline.Keys.Union(candidate.Keys, StringComparer.Ordinal).Order(StringComparer.Ordinal)
            .Where(key => !baseline.TryGetValue(key, out var left) || !candidate.TryGetValue(key, out var right) || left.Hash != right.Hash)
            .Select(key =>
            {
                baseline.TryGetValue(key, out var left);
                candidate.TryGetValue(key, out var right);
                var common = 0;
                while (left != null && right != null && common < left.Tokens.Length && common < right.Tokens.Length
                    && left.Tokens[common] == right.Tokens[common])
                    common++;
                string? Excerpt(Entry? entry) => entry == null ? null : string.Join(" ",
                    entry.Tokens.Skip(Math.Max(0, common - 6)).Take(24));
                return new MemberDifference(key, left == null ? "added" : right == null ? "removed" : "changed",
                    Excerpt(left), Excerpt(right));
            }).ToArray();

    private static string Compact(SyntaxNode? node) => node == null ? "" : string.Concat(node.DescendantTokens().Select(token => token.Text));

    private sealed record Entry(string Hash, string[] Tokens);
}

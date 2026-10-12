// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal sealed class SourceBindingBuilder(LambdaExpressionSyntax lambda)
{
    private readonly Dictionary<string, string> bindingFactorySourcesByPlaceholder = new(StringComparer.Ordinal);
    private readonly Dictionary<ISymbol, string> captureNamesBySymbol = new(SymbolEqualityComparer.Default);
    private readonly List<string> declarations = [];
    private readonly HashSet<string> identifiers = lambda.DescendantTokens().Select(token => token.ValueText).ToHashSet(StringComparer.Ordinal);

    internal IReadOnlyDictionary<string, string> BindingFactorySourcesByPlaceholder => bindingFactorySourcesByPlaceholder;
    internal IReadOnlyList<string> Declarations => declarations;

    internal string Bind(string bindingFactorySource)
    {
        var name = Unique("__binding");
        bindingFactorySourcesByPlaceholder.Add(name, bindingFactorySource);
        return name;
    }

    internal ExpressionSyntax Capture(ExpressionSyntax node, ISymbol symbol, ITypeSymbol type, string source)
    {
        if (IsWrite(node))
            throw new ExpressionError("External captures are snapshots and cannot be assigned or passed by reference.", node);

        WorkflowExpressionTypePolicy.ValidateCapture(type, node);
        if (!captureNamesBySymbol.TryGetValue(symbol, out var name))
        {
            name = Unique("__capture");
            captureNamesBySymbol.Add(symbol, name);
            var slot = Bind($"{Prefix}WorkflowExpressionBinding.Capture<{TypeName(type)}>({source})");
            declarations.Add(
                $"{(type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String || type.TypeKind == TypeKind.Enum ? "const " : "")}" +
                $"{TypeName(type)} {name} = {slot};");
        }

        return SyntaxFactory.IdentifierName(name).WithTriviaFrom(node);
    }

    internal string Unique(string prefix)
    {
        var index = 0;
        while (!identifiers.Add(prefix + index)) index++;
        return prefix + index;
    }

    private static bool IsWrite(ExpressionSyntax node) =>
        node.Parent is AssignmentExpressionSyntax assignment && assignment.Left == node ||
        node.Parent is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None) ||
        node.Parent is PrefixUnaryExpressionSyntax prefix && prefix.Kind() is SyntaxKind.PreIncrementExpression or SyntaxKind.PreDecrementExpression ||
        node.Parent is PostfixUnaryExpressionSyntax postfix && postfix.Kind() is SyntaxKind.PostIncrementExpression or SyntaxKind.PostDecrementExpression;
}

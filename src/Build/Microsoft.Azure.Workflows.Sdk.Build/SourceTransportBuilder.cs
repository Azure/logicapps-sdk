// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal sealed class SourceTransportBuilder(
    SemanticModel model,
    LambdaExpressionSyntax lambda,
    ITypeSymbol resultType,
    SourceBindingBuilder bindingBuilder)
{
    internal string Build(SyntaxNode body)
    {
        var declarations = string.Join(" ", bindingBuilder.Declarations);
        var block = body is BlockSyntax statements
            ? statements.WithStatements(statements.Statements.InsertRange(
                    0,
                    ((BlockSyntax)SyntaxFactory.ParseStatement("{" + declarations + "}")).Statements))
                .NormalizeWhitespace().ToFullString()
            : "{ " + declarations + " return " + body.NormalizeWhitespace().ToFullString() + "; }";
        var source = $"((global::System.Func<{(Anonymous(resultType) ? "object" : TypeName(resultType))}>)(() => {block}))()";
        var checkedContext = lambda.Ancestors().FirstOrDefault(node => node is CheckedStatementSyntax or CheckedExpressionSyntax);

        if (checkedContext is CheckedStatementSyntax checkedStatement && checkedStatement.Keyword.IsKind(SyntaxKind.CheckedKeyword) ||
            checkedContext is CheckedExpressionSyntax checkedExpression && checkedExpression.Keyword.IsKind(SyntaxKind.CheckedKeyword) ||
            checkedContext == null && model.Compilation.Options.CheckOverflow)
            source = "checked(" + source + ")";

        // Collects segments and bindings from source
        var segments = new List<string>();
        var bindingFactorySources = new List<string>();
        var cursor = 0;
        foreach (var node in SyntaxFactory.ParseExpression(source).DescendantNodesAndSelf().OfType<IdentifierNameSyntax>())
        {
            if (!bindingBuilder.BindingFactorySourcesByPlaceholder.TryGetValue(
                    node.Identifier.ValueText,
                    out var bindingFactorySource))
                continue;

            segments.Add(Quote(source.Substring(cursor, node.SpanStart - cursor)));
            bindingFactorySources.Add(bindingFactorySource);
            cursor = node.Span.End;
        }

        // Creates source for WorkflowExpression factory method:
        // WorkflowExpression.Program<T>(string[] segments, WorkflowExpressionBinding[] bindings, Func<T> typeWitness)
        segments.Add(Quote(source[cursor..]));
        return $"{Prefix}WorkflowExpression.Program{(Anonymous(resultType) ? "" : "<" + TypeName(resultType) + ">")}" +
            $"(new string[] {{ {string.Join(", ", segments)} }}, new {Prefix}WorkflowExpressionBinding[] {{ {string.Join(", ", bindingFactorySources)} }}" +
            (Anonymous(resultType) ? $", typeWitness: {lambda}" : "") + ")";
    }
}

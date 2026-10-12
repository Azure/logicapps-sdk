// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class ExpressionCompiler
{
    internal const string Sdk = "Microsoft.Azure.Workflows.Sdk";
    internal const string Prefix = "global::" + Sdk + ".";
    internal static string TypeName(ITypeSymbol type) => type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
    internal static string Quote(string text) => SymbolDisplay.FormatLiteral(text, true);
    internal static bool Anonymous(ITypeSymbol type) => type.IsAnonymousType || type is IArrayTypeSymbol array && Anonymous(array.ElementType) ||
        type is INamedTypeSymbol named && named.TypeArguments.Any(Anonymous);

    public static (IReadOnlyDictionary<string, string> Sources, IReadOnlyList<Diagnostic> Diagnostics) Transform(CSharpCompilation compilation)
    {
        var diagnostics = new List<Diagnostic>();
        var sources = new Dictionary<string, string>();
        foreach (var tree in compilation.SyntaxTrees)
            sources.Add(tree.FilePath, new CallRewriter(compilation.GetSemanticModel(tree), diagnostics).Visit(tree.GetRoot())!.ToFullString());
        return (sources, diagnostics);
    }

    private sealed class CallRewriter(SemanticModel model, List<Diagnostic> diagnostics) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            if (model.GetSymbolInfo(node).Symbol is not IMethodSymbol method) return base.VisitInvocationExpression(node);
            var entry = method.GetAttributes().FirstOrDefault(attribute =>
                attribute.AttributeClass?.ToDisplayString() == Sdk + ".WorkflowExpressionFactoryAttribute")?.ConstructorArguments.FirstOrDefault().Value as string;
            if (entry == null) return base.VisitInvocationExpression(node);
            try
            {
                var arguments = new List<ArgumentSyntax>();
                foreach (var argument in node.ArgumentList.Arguments)
                {
                    var parameter = argument.NameColon == null ? method.Parameters[node.ArgumentList.Arguments.IndexOf(argument)] :
                        method.Parameters.Single(candidate => candidate.Name == argument.NameColon.Name.Identifier.ValueText);
                    if (!parameter.GetAttributes().Any(attribute => attribute.AttributeClass?.ToDisplayString() == Sdk + ".WorkflowExpressionAttribute") ||
                        argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                    {
                        arguments.Add((ArgumentSyntax)Visit(argument)!);
                        continue;
                    }
                    var lambda = ResolveLambda(argument.Expression);
                    var resultType = ((INamedTypeSymbol)parameter.Type).DelegateInvokeMethod!.ReturnType;
                    arguments.Add(argument.WithExpression(SyntaxFactory.ParseExpression(new SourceProgram(model, lambda, resultType).Build())));
                }
                SimpleNameSyntax name = method.IsGenericMethod && !method.TypeArguments.Any(Anonymous)
                    ? SyntaxFactory.GenericName(entry).WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                        SyntaxFactory.SeparatedList(method.TypeArguments.Select(type => SyntaxFactory.ParseTypeName(TypeName(type))))))
                    : SyntaxFactory.IdentifierName(entry);
                var target = node.Expression is MemberAccessExpressionSyntax member ? member.WithName(name) : (ExpressionSyntax)name;
                return node.WithExpression(target).WithArgumentList(node.ArgumentList.WithArguments(SyntaxFactory.SeparatedList(arguments)));
            }
            catch (ExpressionError error)
            {
                diagnostics.Add(error.Diagnostic);
                return node;
            }
        }

        private LambdaExpressionSyntax ResolveLambda(ExpressionSyntax expression)
        {
            if (expression is ParenthesizedExpressionSyntax parentheses) return ResolveLambda(parentheses.Expression);
            if (expression is LambdaExpressionSyntax lambda) return lambda;
            if (model.GetSymbolInfo(expression).Symbol is ILocalSymbol local &&
                local.DeclaringSyntaxReferences.SingleOrDefault()?.GetSyntax() is VariableDeclaratorSyntax { Initializer.Value: LambdaExpressionSyntax stored } &&
                stored.SyntaxTree == expression.SyntaxTree && stored.SpanStart < expression.SpanStart &&
                !expression.SyntaxTree.GetRoot().DescendantNodes().Any(node =>
                    node is AssignmentExpressionSyntax assignment && SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(assignment.Left).Symbol, local) ||
                    node is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None) &&
                    SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(argument.Expression).Symbol, local)))
                return stored;
            throw new ExpressionError("Use an inline lambda or an unreassigned source-visible local lambda.", expression);
        }
    }
}

internal sealed class ExpressionError(string message, SyntaxNode node) : Exception(message)
{
    internal Diagnostic Diagnostic => Diagnostic.Create(
        new DiagnosticDescriptor("LAEXP001", "Unsupported workflow expression", "{0}", "WorkflowExpressions", DiagnosticSeverity.Error, true),
        node.GetLocation(), Message);
}

// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public sealed record TransformationResult(
    IReadOnlyDictionary<string, string> Sources,
    ImmutableArray<Diagnostic> Diagnostics)
{
    public ImmutableArray<WorkflowDependency> Dependencies { get; init; } = [];
}

public static class ExpressionCompilationTransformer
{
    internal const string SdkAssembly = "Microsoft.Azure.Workflows.Sdk";
    internal const string Runtime = "global::Microsoft.Azure.Workflows.Sdk.";

    public static TransformationResult Transform(CSharpCompilation compilation)
    {
        ArgumentNullException.ThrowIfNull(compilation);
        var dependencies = new WorkflowDependencyCollector();
        var sources = new Dictionary<string, string>(StringComparer.Ordinal);
        var diagnostics = ImmutableArray.CreateBuilder<Diagnostic>();
        foreach (var diagnostic in compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error))
        {
            if (!IsSourceReuseConversionDiagnostic(compilation, diagnostic))
            {
                diagnostics.Add(diagnostic);
            }
        }

        if (diagnostics.Count != 0)
        {
            return new TransformationResult(sources, diagnostics.ToImmutable());
        }

        var factories = SourceFactoryPlan.Create(compilation, diagnostics, dependencies);
        foreach (var tree in compilation.SyntaxTrees)
        {
            var rewriter = new CallRewriter(compilation.GetSemanticModel(tree), diagnostics, factories, dependencies);
            var root = rewriter.Visit(tree.GetRoot())!;
            sources.Add(tree.FilePath, root.ToFullString());
        }

        return new TransformationResult(sources, diagnostics.ToImmutable())
        {
            Dependencies = dependencies.Dependencies,
        };
    }

    private static bool IsSourceReuseConversionDiagnostic(CSharpCompilation compilation, Diagnostic diagnostic)
    {
        if (diagnostic.Id is not ("CS1503" or "CS0411") || diagnostic.Location.SourceTree is not { } tree)
        {
            return false;
        }

        var model = compilation.GetSemanticModel(tree);
        var node = tree.GetRoot().FindNode(diagnostic.Location.SourceSpan, getInnermostNodeForTie: true);
        var invocation = node.AncestorsAndSelf().OfType<InvocationExpressionSyntax>().FirstOrDefault();
        if (invocation == null)
        {
            return false;
        }

        var method = ResolveInvocationMethod(model, invocation);
        return method != null && method.Parameters.Any(IsWorkflowExpressionParameter) &&
            invocation.ArgumentList.Arguments.Any(a =>
                model.GetSymbolInfo(a.Expression).Symbol is ILocalSymbol local &&
                local.Type is INamedTypeSymbol type &&
                type.OriginalDefinition.ToDisplayString() == "System.Linq.Expressions.Expression<TDelegate>" &&
                local.DeclaringSyntaxReferences.SingleOrDefault()?.GetSyntax() is VariableDeclaratorSyntax
                { Initializer.Value: LambdaExpressionSyntax });
    }

    internal static IMethodSymbol? ResolveInvocationMethod(SemanticModel model, InvocationExpressionSyntax invocation)
    {
        var info = model.GetSymbolInfo(invocation);
        if (info.Symbol is IMethodSymbol method) return method;
        var candidates = info.CandidateSymbols.OfType<IMethodSymbol>()
            .Where(m => m.Parameters.Any(IsWorkflowExpressionParameter))
            .Where(m => invocation.ArgumentList.Arguments.All(a =>
                a.NameColon == null || m.Parameters.Any(p => p.Name == a.NameColon.Name.Identifier.ValueText)))
            .ToArray();
        return candidates.Length == 1 ? candidates[0] : null;
    }

    internal static bool IsWorkflowExpressionParameter(IParameterSymbol parameter) =>
        parameter.GetAttributes().Any(a =>
            a.AttributeClass?.ToDisplayString() == SdkAssembly + ".WorkflowExpressionAttribute" &&
            a.AttributeClass.ContainingAssembly.Name == SdkAssembly);

    internal static IParameterSymbol? ResolveArgumentParameter(IMethodSymbol method, ArgumentSyntax argument) =>
        argument.NameColon is { } name
            ? method.Parameters.FirstOrDefault(p => p.Name == name.Name.Identifier.ValueText)
            : argument.Parent is ArgumentListSyntax arguments
                ? method.Parameters.ElementAtOrDefault(arguments.Arguments.IndexOf(argument))
                : null;

    internal static string Quote(string text) => SymbolDisplay.FormatLiteral(text, quote: true);

    internal static ExpressionSyntax CreateDescriptorSyntax(string descriptor, ExpressionSyntax original)
    {
        var replacement = SyntaxFactory.ParseExpression(descriptor).WithTriviaFrom(original);
        var missingLines = original.ToFullString().Count(c => c == '\n') -
            replacement.ToFullString().Count(c => c == '\n');
        if (missingLines > 0)
        {
            replacement = replacement.WithTrailingTrivia(replacement.GetTrailingTrivia().AddRange(
                Enumerable.Repeat(SyntaxFactory.EndOfLine("\n"), missingLines)));
        }
        return replacement;
    }

    private sealed class CallRewriter(
        SemanticModel model,
        ImmutableArray<Diagnostic>.Builder diagnostics,
        SourceFactoryPlan factories,
        WorkflowDependencyCollector dependencies) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node) =>
            factories.GetReplacementSyntax(node) ?? base.VisitSimpleLambdaExpression(node);

        public override SyntaxNode? VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node) =>
            factories.GetReplacementSyntax(node) ?? base.VisitParenthesizedLambdaExpression(node);

        public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var info = model.GetSymbolInfo(node);
            var method = ResolveInvocationMethod(model, node);

            if (method == null || !method.Parameters.Any(IsWorkflowExpressionParameter))
            {
                return base.VisitInvocationExpression(node);
            }

            var arguments = new List<ArgumentSyntax>();
            for (var index = 0; index < node.ArgumentList.Arguments.Count; index++)
            {
                var argument = node.ArgumentList.Arguments[index];
                var parameter = ResolveArgumentParameter(method, argument);
                if (parameter == null || !IsWorkflowExpressionParameter(parameter) ||
                    argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                {
                    arguments.Add((ArgumentSyntax)Visit(argument)!);
                    continue;
                }

                try
                {
                    var invoke = (parameter.Type as INamedTypeSymbol)?.DelegateInvokeMethod;
                    if (invoke == null || invoke.Parameters.Length != 0)
                    {
                        throw new SourceDiagnosticException("WFBUILD002", "Only parameterless workflow value delegates are supported.", argument);
                    }

                    if (factories.IsFactoryArgument(argument.Expression))
                    {
                        arguments.Add((ArgumentSyntax)Visit(argument)!);
                        continue;
                    }

                    var lambda = ResolveSourceLambda(argument.Expression, node.SpanStart);
                    var resultType = invoke.ReturnType;
                    if (resultType is ITypeParameterSymbol { TypeParameterKind: TypeParameterKind.Method } &&
                        info.Symbol == null)
                    {
                        var storedType = model.GetTypeInfo(lambda).ConvertedType as INamedTypeSymbol;
                        if (storedType?.OriginalDefinition.ToDisplayString() == "System.Linq.Expressions.Expression<TDelegate>")
                        {
                            storedType = storedType.TypeArguments[0] as INamedTypeSymbol;
                        }

                        resultType = storedType?.DelegateInvokeMethod?.ReturnType ?? resultType;
                    }

                    var builder = new SourceDescriptorBuilder(model, lambda, node.SpanStart, dependencies);
                    var descriptor = builder.BuildDescriptorSource(resultType, parameter);
                    var replacement = CreateDescriptorSyntax(descriptor, argument.Expression);
                    arguments.Add(argument.WithExpression(replacement));
                }
                catch (SourceDiagnosticException exception)
                {
                    diagnostics.Add(exception.ToDiagnostic());
                    arguments.Add(argument);
                }
            }

            return node.WithArgumentList(node.ArgumentList.WithArguments(
                SyntaxFactory.SeparatedList(arguments, node.ArgumentList.Arguments.GetSeparators())));
        }

        private LambdaExpressionSyntax ResolveSourceLambda(ExpressionSyntax expression, int callPosition)
        {
            if (expression is LambdaExpressionSyntax lambda)
            {
                return lambda;
            }

            if (expression is ParenthesizedExpressionSyntax parenthesized)
            {
                return ResolveSourceLambda(parenthesized.Expression, callPosition);
            }

            if (model.GetSymbolInfo(expression).Symbol is ILocalSymbol local &&
                local.DeclaringSyntaxReferences.SingleOrDefault()?.GetSyntax() is VariableDeclaratorSyntax
                { Initializer.Value: LambdaExpressionSyntax stored } declaration &&
                declaration.SyntaxTree == expression.SyntaxTree && declaration.SpanStart < callPosition)
            {
                var writes = expression.SyntaxTree.GetRoot().DescendantNodes()
                    .Where(n => n is AssignmentExpressionSyntax or ArgumentSyntax)
                    .Any(n =>
                    {
                        var target = n switch
                        {
                            AssignmentExpressionSyntax assignment => assignment.Left,
                            ArgumentSyntax argument when !argument.RefKindKeyword.IsKind(SyntaxKind.None) => argument.Expression,
                            _ => null,
                        };
                        return target != null &&
                            SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(target).Symbol, local);
                    });
                if (!writes)
                {
                    return stored;
                }
            }

            throw new SourceDiagnosticException("WFBUILD001",
                "Workflow source must be an inline lambda or a source-visible, single-origin local lambda without reassignment. Runtime Expression objects and dynamically selected delegates cannot be rendered.", expression);
        }
    }
}

internal sealed class SourceDiagnosticException(string code, string message, SyntaxNode node) : Exception(message)
{
    public Diagnostic ToDiagnostic() => Diagnostic.Create(
        new DiagnosticDescriptor(code, "Workflow source compilation", "{0}", "WorkflowSource",
            DiagnosticSeverity.Error, isEnabledByDefault: true),
        node.GetLocation(), Message);
}

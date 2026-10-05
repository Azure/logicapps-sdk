// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class ExpressionCompiler
{
    internal const string Sdk = "Microsoft.Azure.Workflows.Sdk";
    internal const string Runtime = "global::" + Sdk + ".";

    public static (IReadOnlyDictionary<string, string> Sources, IReadOnlyList<Diagnostic> Diagnostics) Transform(CSharpCompilation compilation)
    {
        var diagnostics = new List<Diagnostic>();
        var sources = new Dictionary<string, string>();
        foreach (var tree in compilation.SyntaxTrees)
        {
            var rewriter = new CallRewriter(compilation.GetSemanticModel(tree), diagnostics);
            sources.Add(tree.FilePath, rewriter.Visit(tree.GetRoot())!.ToFullString());
        }
        return (sources, diagnostics);
    }

    internal static string TypeName(ITypeSymbol type) =>
        type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

    internal static string Quote(string value) => SymbolDisplay.FormatLiteral(value, quote: true);

    internal static string FormatConstant(object? value) => value switch
    {
        null => "null",
        string text => Quote(text),
        char character => SymbolDisplay.FormatLiteral(character, quote: true),
        bool flag => flag ? "true" : "false",
        decimal number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "m",
        float number when float.IsNaN(number) => "global::System.Single.NaN",
        float number when float.IsPositiveInfinity(number) => "global::System.Single.PositiveInfinity",
        float number when float.IsNegativeInfinity(number) => "global::System.Single.NegativeInfinity",
        float number => number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "f",
        double number when double.IsNaN(number) => "global::System.Double.NaN",
        double number when double.IsPositiveInfinity(number) => "global::System.Double.PositiveInfinity",
        double number when double.IsNegativeInfinity(number) => "global::System.Double.NegativeInfinity",
        double number => number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "d",
        ulong number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "UL",
        long number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "L",
        uint number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "U",
        _ => Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture)!,
    };

    internal static bool IsExpressionParameter(IParameterSymbol parameter) =>
        parameter.GetAttributes().Any(attribute =>
            attribute.AttributeClass?.ToDisplayString() == Sdk + ".WorkflowExpressionAttribute" &&
            attribute.AttributeClass.ContainingAssembly.Name == Sdk);

    private sealed class CallRewriter(SemanticModel model, List<Diagnostic> diagnostics) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var symbolInfo = model.GetSymbolInfo(node);
            if (symbolInfo.Symbol is not IMethodSymbol method)
            {
                if (symbolInfo.CandidateSymbols.OfType<IMethodSymbol>().Any(candidate =>
                    candidate.GetAttributes().Any(attribute => attribute.AttributeClass?.ToDisplayString() == Sdk + ".WorkflowExpressionFactoryAttribute")))
                {
                    diagnostics.Add(new ExpressionDiagnostic(
                        "The workflow factory could not be resolved before compilation. Check argument types; workflow authoring cannot depend on types generated later in CoreCompile.", node).Diagnostic);
                }
                return base.VisitInvocationExpression(node);
            }
            var entryPoint = method.GetAttributes().FirstOrDefault(attribute =>
                attribute.AttributeClass?.ToDisplayString() == Sdk + ".WorkflowExpressionFactoryAttribute" &&
                attribute.AttributeClass.ContainingAssembly.Name == Sdk)?.ConstructorArguments.FirstOrDefault().Value as string;
            if (entryPoint == null) return base.VisitInvocationExpression(node);

            try
            {
                var arguments = new List<ArgumentSyntax>();
                foreach (var argument in node.ArgumentList.Arguments)
                {
                    var parameter = argument.NameColon == null
                        ? method.Parameters.ElementAtOrDefault(node.ArgumentList.Arguments.IndexOf(argument))
                        : method.Parameters.FirstOrDefault(candidate => candidate.Name == argument.NameColon.Name.Identifier.ValueText);
                    if (parameter == null || !IsExpressionParameter(parameter) || argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                    {
                        arguments.Add((ArgumentSyntax)Visit(argument)!);
                        continue;
                    }

                    var lambda = ResolveLambda(argument.Expression);
                    var resultType = ((INamedTypeSymbol)parameter.Type).DelegateInvokeMethod!.ReturnType;
                    var descriptor = new ProgramBuilder(model, lambda, resultType).Build();
                    arguments.Add(argument.WithExpression(SyntaxFactory.ParseExpression(descriptor).WithTriviaFrom(argument.Expression)));
                }

                SimpleNameSyntax name = method.IsGenericMethod && !method.TypeArguments.Any(ContainsAnonymousType)
                    ? SyntaxFactory.GenericName(entryPoint).WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                        SyntaxFactory.SeparatedList(method.TypeArguments.Select(type => SyntaxFactory.ParseTypeName(TypeName(type))))))
                    : SyntaxFactory.IdentifierName(entryPoint);
                var target = node.Expression switch
                {
                    MemberAccessExpressionSyntax member => member.WithName(name),
                    SimpleNameSyntax => (ExpressionSyntax)name,
                    _ => throw new ExpressionDiagnostic("Unsupported workflow factory call syntax.", node),
                };
                return node.WithExpression(target).WithArgumentList(
                    node.ArgumentList.WithArguments(SyntaxFactory.SeparatedList(arguments, node.ArgumentList.Arguments.GetSeparators())));
            }
            catch (ExpressionDiagnostic error)
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
                local.DeclaringSyntaxReferences.SingleOrDefault()?.GetSyntax() is VariableDeclaratorSyntax
                {
                    Initializer.Value: LambdaExpressionSyntax stored,
                } declaration && declaration.SyntaxTree == expression.SyntaxTree && declaration.SpanStart < expression.SpanStart)
            {
                var writes = expression.SyntaxTree.GetRoot().DescendantNodes().Any(node =>
                    node is AssignmentExpressionSyntax assignment && SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(assignment.Left).Symbol, local) ||
                    node is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None) &&
                    SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(argument.Expression).Symbol, local));
                if (!writes) return stored;
            }
            throw new ExpressionDiagnostic("Use an inline lambda or an unreassigned source-visible local lambda for a workflow value.", expression);
        }
    }

    internal static bool ContainsAnonymousType(ITypeSymbol type) =>
        type.IsAnonymousType ||
        type is IArrayTypeSymbol array && ContainsAnonymousType(array.ElementType) ||
        type is INamedTypeSymbol named && named.TypeArguments.Any(ContainsAnonymousType);
}

internal sealed class ExpressionDiagnostic(string message, SyntaxNode node) : Exception(message)
{
    internal Diagnostic Diagnostic => Diagnostic.Create(
        new DiagnosticDescriptor("LAEXP001", "Unsupported workflow expression", "{0}", "WorkflowExpressions",
            DiagnosticSeverity.Error, isEnabledByDefault: true),
        node.GetLocation(), Message);
}

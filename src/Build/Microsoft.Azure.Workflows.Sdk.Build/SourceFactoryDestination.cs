// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompilationTransformer;

internal static class SourceFactoryDestination
{
    internal static string? Contract(IParameterSymbol parameter, SyntaxNode location)
    {
        var attributes = parameter.GetAttributes().Where(a =>
            a.AttributeClass?.ContainingAssembly.Name == SdkAssembly &&
            a.AttributeClass.ToDisplayString() == SdkAssembly + ".WorkflowDestinationAttribute").ToArray();
        if (attributes.Length == 0) return null;
        if (attributes.Length == 1 && attributes[0].ConstructorArguments is [{ Value: string schema }])
            return schema;
        throw new SourceDiagnosticException("WFBUILD009", "A factory destination requires one authoritative schema.",
            location);
    }

    internal static bool IsSupportedBoundary(IParameterSymbol parameter, CSharpCompilation compilation, SyntaxNode location)
    {
        if (parameter.ContainingAssembly.Name == SdkAssembly) return true;
        if (Contract(parameter, location) == null || parameter.ContainingSymbol is not IMethodSymbol method ||
            !method.IsStatic || method.IsAsync || method.IsGenericMethod || method.IsVirtual || method.IsAbstract ||
            method.IsOverride || method.DeclaringSyntaxReferences.Length != 1 ||
            method.DeclaringSyntaxReferences[0].GetSyntax() is not MethodDeclarationSyntax
            { ExpressionBody.Expression: InvocationExpressionSyntax call, Body: null } declaration)
            return false;

        // Generated schema APIs may live in the consuming assembly. Prove their exact
        // forwarding body instead of trusting an attribute on arbitrary executable code.
        var model = compilation.GetSemanticModel(declaration.SyntaxTree);
        if (model.GetSymbolInfo(call).Symbol is not IMethodSymbol runtime ||
            runtime.ContainingAssembly.Name != SdkAssembly ||
            runtime.ContainingType.ToDisplayString() != SdkAssembly + ".WorkflowSchemaRuntime" ||
            method.Parameters.Any(p => !IsExpressionParameter(p) || Contract(p, declaration) == null))
            return false;
        var args = call.ArgumentList.Arguments;
        if (args.Any(a => a.NameColon != null || a.RefKindKeyword.RawKind != 0)) return false;
        if (runtime.Name == "Value" && method.Parameters.Length == 1 && args.Count == 2)
            return Text(args[0].Expression) == Contract(parameter, declaration) &&
                IsParameter(args[1].Expression, parameter, model);
        if (runtime.Name is not ("Object" or "Path") || args.Count != 3) return false;

        var schemas = Elements(args[1].Expression, SpecialType.System_String, model);
        var values = Elements(args[2].Expression, SpecialType.System_Delegate, model);
        if (schemas == null || values == null || schemas.Count != method.Parameters.Length ||
            values.Count != method.Parameters.Length) return false;
        for (var i = 0; i < method.Parameters.Length; i++)
        {
            if (Text(schemas[i]) != Contract(method.Parameters[i], declaration) ||
                !IsParameter(values[i], method.Parameters[i], model)) return false;
        }
        if (runtime.Name == "Path") return Text(args[0].Expression) != null;
        var names = Elements(args[0].Expression, SpecialType.System_String, model);
        return names != null && names.Count == method.Parameters.Length &&
            names.Select(Text).SequenceEqual(method.Parameters.Select(p => p.Name), StringComparer.Ordinal);
    }

    private static string? Text(ExpressionSyntax expression) =>
        expression is LiteralExpressionSyntax { Token.Value: string value } ? value : null;

    private static bool IsParameter(ExpressionSyntax expression, IParameterSymbol parameter, SemanticModel model) =>
        expression is IdentifierNameSyntax &&
        SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(expression).Symbol, parameter);

    private static IReadOnlyList<ExpressionSyntax>? Elements(ExpressionSyntax expression, SpecialType elementType, SemanticModel model)
    {
        if (expression is not ArrayCreationExpressionSyntax { Initializer: { } initializer } array ||
            array.Type.RankSpecifiers.Any(rank => rank.Sizes.Any(size => size is not OmittedArraySizeExpressionSyntax)) ||
            model.GetTypeInfo(array).Type is not IArrayTypeSymbol { Rank: 1 } type ||
            type.ElementType.SpecialType != elementType) return null;
        return initializer.Expressions.ToArray();
    }
}

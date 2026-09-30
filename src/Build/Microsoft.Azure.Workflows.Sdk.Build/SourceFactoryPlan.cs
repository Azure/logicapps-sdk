// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using static ExpressionCompilationTransformer;

/// <summary>Proves closed, source-visible factory uses before replacing any factory return.</summary>
internal sealed class SourceFactoryPlan(CSharpCompilation compilation, WorkflowDependencyCollector dependencies)
{
    private const int MaxAliasDepth = 16;
    private readonly HashSet<(SyntaxTree, TextSpan)> arguments = [];
    private readonly Dictionary<(SyntaxTree, TextSpan), string> replacements = [];
    private readonly Dictionary<IMethodSymbol, string?> prepared = new(SymbolEqualityComparer.Default);

    internal static SourceFactoryPlan Create(CSharpCompilation compilation, ImmutableArray<Diagnostic>.Builder diagnostics,
        WorkflowDependencyCollector dependencies)
    {
        var plan = new SourceFactoryPlan(compilation, dependencies);
        foreach (var tree in compilation.SyntaxTrees)
        {
            var model = compilation.GetSemanticModel(tree);
            foreach (var call in tree.GetRoot().DescendantNodes().OfType<InvocationExpressionSyntax>())
            {
                var method = ResolveInvocationMethod(model, call);
                if (method == null || !method.Parameters.Any(IsWorkflowExpressionParameter)) continue;
                foreach (var argument in call.ArgumentList.Arguments)
                {
                    var destination = ResolveArgumentParameter(method, argument);
                    if (destination == null || !IsWorkflowExpressionParameter(destination)) continue;
                    var origin = plan.FindFactoryInvocation(argument.Expression, model, 0);
                    if (origin == null) continue;
                    plan.arguments.Add((argument.Expression.SyntaxTree, argument.Expression.Span));
                    try
                    {
                        plan.ValidateAndPlanFactory(origin, model, destination);
                    }
                    catch (SourceDiagnosticException exception)
                    {
                        diagnostics.Add(exception.ToDiagnostic());
                    }
                }
            }
        }
        return plan;
    }

    internal bool IsFactoryArgument(ExpressionSyntax expression) =>
        this.arguments.Contains((expression.SyntaxTree, expression.Span));

    internal ExpressionSyntax? GetReplacementSyntax(LambdaExpressionSyntax lambda) =>
        this.replacements.TryGetValue((lambda.SyntaxTree, lambda.Span), out var descriptor)
            ? CreateDescriptorSyntax(descriptor, lambda)
            : null;

    private InvocationExpressionSyntax? FindFactoryInvocation(ExpressionSyntax expression, SemanticModel model, int depth)
    {
        if (depth > MaxAliasDepth) return null;
        expression = UnwrapParentheses(expression);
        if (expression is InvocationExpressionSyntax call) return call;
        if (model.GetSymbolInfo(expression).Symbol is ILocalSymbol local &&
            GetLocalInitializer(local) is { } initializer && IsLocalUnmodified(local, model))
            return this.FindFactoryInvocation(initializer, model, depth + 1);
        return null;
    }

    private void ValidateAndPlanFactory(InvocationExpressionSyntax call, SemanticModel callerModel, IParameterSymbol destination)
    {
        if (callerModel.GetSymbolInfo(call).Symbol is not IMethodSymbol called)
            throw Reject("A factory must resolve to one source method.", call);
        var method = GetOriginalMethodDefinition(called);
        var contract = SourceFactoryDestination.GetDestinationSchema(destination, call);
        if (this.prepared.TryGetValue(method, out var previous))
        {
            RequireMatchingDestinationSchema(previous, contract, call);
            return;
        }
        if (method.IsAsync || method.IsVirtual || method.IsAbstract || method.IsOverride ||
            method.Parameters.Any(p => p.RefKind != RefKind.None) ||
            method.MethodKind != MethodKind.LocalFunction &&
                (!method.IsStatic || method.DeclaredAccessibility != Accessibility.Private))
            throw Reject("Only private static or local, non-virtual value factories can be traced.", call);

        if (method.ReturnType is not INamedTypeSymbol { DelegateInvokeMethod: { } invoke } delegateType ||
            delegateType.OriginalDefinition.ToDisplayString() != "System.Func<TResult>" ||
            invoke.Parameters.Length != 0)
            throw Reject("A traced factory must return a parameterless Func<T>.", call);
        if (method.DeclaringSyntaxReferences.Length != 1)
            throw Reject("Factory source is unavailable or has multiple declarations.", call);

        var declaration = method.DeclaringSyntaxReferences[0].GetSyntax();
        var returned = declaration switch
        {
            MethodDeclarationSyntax m => GetSingleReturnExpression(m.ExpressionBody, m.Body),
            LocalFunctionStatementSyntax f => GetSingleReturnExpression(f.ExpressionBody, f.Body),
            _ => null,
        };
        if (returned == null || UnwrapParentheses(returned) is not LambdaExpressionSyntax lambda)
            throw Reject("A source-traceable factory must consist only of a single returned lambda; executable setup, selection, and recursive forwarding are unsupported.", declaration);

        // Immutable value parameters and deferred handles have the same meaning even when
        // a descriptor-producing factory result is stored before its SDK consumption.
        if (method.Parameters.Any(p => !IsSupportedFactoryParameterType(p.Type)))
            throw Reject("Factory parameters must be immutable scalar values or SDK workflow handles; mutable captures require an inline expression.", declaration);
        var model = compilation.GetSemanticModel(lambda.SyntaxTree);
        if (lambda.DescendantNodes().Any(n => n is ThisExpressionSyntax or BaseExpressionSyntax))
            throw Reject("Factory lambdas cannot capture instance state.", lambda);
        foreach (var identifier in lambda.DescendantNodes().OfType<IdentifierNameSyntax>())
        {
            var symbol = model.GetSymbolInfo(identifier).Symbol;
            if (symbol is ILocalSymbol { IsConst: false } local && !IsDeclaredInsideLambda(local, lambda) ||
                symbol is IParameterSymbol parameter && !IsDeclaredInsideLambda(parameter, lambda) &&
                    !SymbolEqualityComparer.Default.Equals(parameter.ContainingSymbol, method) ||
                symbol is IFieldSymbol { IsStatic: false } or IPropertySymbol { IsStatic: false } or
                    IMethodSymbol { IsStatic: false, MethodKind: MethodKind.Ordinary } &&
                    identifier.Parent is not (MemberAccessExpressionSyntax or NameEqualsSyntax or NameColonSyntax) &&
                    !IsObjectInitializerTarget(identifier))
                throw Reject("Factory lambdas cannot capture mutable enclosing locals, enclosing parameters, or implicit instance state.", identifier);
        }

        foreach (var tree in compilation.SyntaxTrees)
        {
            var useModel = compilation.GetSemanticModel(tree);
            foreach (var name in tree.GetRoot().DescendantNodes().OfType<SimpleNameSyntax>()
                .Where(n => n.Identifier.ValueText == method.Name))
            {
                var reference = useModel.GetSymbolInfo(name);
                if (!(reference.Symbol is IMethodSymbol referenced &&
                    SymbolEqualityComparer.Default.Equals(GetOriginalMethodDefinition(referenced), method)) &&
                    !reference.CandidateSymbols.OfType<IMethodSymbol>().Any(candidate =>
                        SymbolEqualityComparer.Default.Equals(GetOriginalMethodDefinition(candidate), method))) continue;
                ExpressionSyntax target = name;
                if (name.Parent is MemberAccessExpressionSyntax member && member.Name == name) target = member;
                if (target.Parent is not InvocationExpressionSyntax use || use.Expression != target ||
                    !this.IsSupportedConsumerFlow(use, useModel, new HashSet<ILocalSymbol>(SymbolEqualityComparer.Default), 0, contract))
                    throw Reject("Every factory result must flow only to SDK expression parameters through unreassigned locals; ordinary invocation, escape, and ambiguous consumers are unsupported.", name);
            }
        }

        var descriptor = new SourceDescriptorBuilder(model, lambda, lambda.SpanStart, dependencies).BuildDescriptorSource(invoke.ReturnType, destination);
        this.replacements.Add((lambda.SyntaxTree, lambda.Span), descriptor);
        this.prepared.Add(method, contract);
    }

    private bool IsSupportedConsumerFlow(ExpressionSyntax expression, SemanticModel model, HashSet<ILocalSymbol> visiting, int depth, string? contract)
    {
        if (depth > MaxAliasDepth) return false;
        while (expression.Parent is ParenthesizedExpressionSyntax parentheses) expression = parentheses;
        if (expression.Parent is ArgumentSyntax argument && argument.Expression == expression &&
            argument.Parent is ArgumentListSyntax { Parent: InvocationExpressionSyntax call })
        {
            var method = ResolveInvocationMethod(model, call);
            var destination = method == null ? null : ResolveArgumentParameter(method, argument);
            if (destination == null || !IsWorkflowExpressionParameter(destination) ||
                !SourceFactoryDestination.IsSupportedFactoryDestination(destination, compilation, argument)) return false;
            RequireMatchingDestinationSchema(contract, SourceFactoryDestination.GetDestinationSchema(destination, argument), argument);
            return true;
        }
        if (expression.Parent is not EqualsValueClauseSyntax { Parent: VariableDeclaratorSyntax declaration } ||
            model.GetDeclaredSymbol(declaration) is not ILocalSymbol local ||
            !IsLocalUnmodified(local, model) || !visiting.Add(local)) return false;

        var uses = declaration.SyntaxTree.GetRoot().DescendantNodes().OfType<IdentifierNameSyntax>()
            .Where(n => n.Identifier.ValueText == local.Name &&
                SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(n).Symbol, local)).ToArray();
        var safe = uses.Length != 0 && uses.All(use => this.IsSupportedConsumerFlow(use, model, visiting, depth + 1, contract));
        visiting.Remove(local);
        return safe;
    }

    private static void RequireMatchingDestinationSchema(string? expected, string? actual, SyntaxNode node)
    {
        if (!string.Equals(expected, actual, StringComparison.Ordinal))
            throw new SourceDiagnosticException("WFBUILD009",
                "A shared factory has conflicting workflow destination contracts. Use separate factories for distinct schema destinations.", node);
    }

    private static ExpressionSyntax? GetSingleReturnExpression(ArrowExpressionClauseSyntax? expression, BlockSyntax? body) =>
        expression?.Expression ?? (body?.Statements is [ReturnStatementSyntax statement] ? statement.Expression : null);

    private static ExpressionSyntax UnwrapParentheses(ExpressionSyntax expression)
    {
        while (expression is ParenthesizedExpressionSyntax parentheses) expression = parentheses.Expression;
        return expression;
    }

    private static ExpressionSyntax? GetLocalInitializer(ILocalSymbol local) =>
        local.DeclaringSyntaxReferences.SingleOrDefault()?.GetSyntax() is VariableDeclaratorSyntax declaration
            ? declaration.Initializer?.Value : null;

    private static bool IsLocalUnmodified(ILocalSymbol local, SemanticModel model) =>
        !model.SyntaxTree.GetRoot().DescendantNodes().OfType<IdentifierNameSyntax>().Any(identifier =>
        {
            if (!SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(identifier).Symbol, local)) return false;
            SyntaxNode target = identifier;
            while (target.Parent is ParenthesizedExpressionSyntax or TupleExpressionSyntax ||
                target.Parent is ArgumentSyntax { Parent: TupleExpressionSyntax })
                target = target.Parent;
            return target.Parent is AssignmentExpressionSyntax assignment && assignment.Left == target ||
                target.Parent is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None) ||
                target.Parent is PrefixUnaryExpressionSyntax or PostfixUnaryExpressionSyntax;
        });

    private static bool IsDeclaredInsideLambda(ISymbol symbol, LambdaExpressionSyntax lambda) =>
        symbol.DeclaringSyntaxReferences.Any(r => r.SyntaxTree == lambda.SyntaxTree && lambda.Span.Contains(r.Span));

    private static bool IsObjectInitializerTarget(IdentifierNameSyntax identifier) =>
        identifier.Parent is AssignmentExpressionSyntax assignment && assignment.Left == identifier &&
        assignment.Parent is InitializerExpressionSyntax initializer &&
        initializer.IsKind(SyntaxKind.ObjectInitializerExpression);

    private static IMethodSymbol GetOriginalMethodDefinition(IMethodSymbol method) =>
        (method.ReducedFrom ?? method).OriginalDefinition;

    private static bool IsSupportedFactoryParameterType(ITypeSymbol type)
    {
        if (type is INamedTypeSymbol named)
        {
            if (named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T)
                return IsSupportedFactoryParameterType(named.TypeArguments[0]);
            if (named.AllInterfaces.Prepend(named).Any(i => i.Name == "IWorkflowOperation" &&
                i.ContainingNamespace.ToDisplayString() == SdkAssembly && i.ContainingAssembly.Name == SdkAssembly))
                return true;
        }
        return type.TypeKind == TypeKind.Enum ||
            type.SpecialType is SpecialType.System_String or SpecialType.System_Boolean or SpecialType.System_Char or
                SpecialType.System_Byte or SpecialType.System_SByte or SpecialType.System_Int16 or SpecialType.System_UInt16 or
                SpecialType.System_Int32 or SpecialType.System_UInt32 or SpecialType.System_Int64 or SpecialType.System_UInt64 or
                SpecialType.System_Single or SpecialType.System_Double or SpecialType.System_Decimal ||
            type.ContainingAssembly?.Name is "System.Private.CoreLib" or "mscorlib" or "System.Runtime" &&
                type.ToDisplayString() is "System.Guid" or "System.DateTime" or "System.DateTimeOffset" or "System.TimeSpan";
    }

    private static SourceDiagnosticException Reject(string message, SyntaxNode node) =>
        new("WFBUILD001", message, node);
}

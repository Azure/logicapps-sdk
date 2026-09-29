// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Generators;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal static class RuntimeDependencyValidator
{
    internal static UnsupportedRuntimeDependency? FindFirst(
        SemanticModel semanticModel,
        ExpressionSyntax expression)
    {
        if (semanticModel.GetConstantValue(expression).HasValue)
            return null;

        var walker = new Walker(semanticModel);
        walker.Visit(expression);
        return walker.UnsupportedDependency;
    }

    private sealed class Walker : CSharpSyntaxWalker
    {
        private readonly SemanticModel semanticModel;
        private readonly HashSet<IAssemblySymbol> approvedAssemblies =
            new(SymbolEqualityComparer.Default);

        internal Walker(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
            this.AddApprovedAssembly(semanticModel.Compilation.GetSpecialType(SpecialType.System_Object));
            this.AddApprovedAssembly(semanticModel.Compilation.GetTypeByMetadataName("System.Linq.Enumerable"));
            this.AddApprovedAssembly(semanticModel.Compilation.GetTypeByMetadataName("System.Uri"));
            this.AddApprovedAssembly(semanticModel.Compilation.GetTypeByMetadataName("Newtonsoft.Json.Linq.JToken"));
        }

        internal UnsupportedRuntimeDependency? UnsupportedDependency { get; private set; }

        public override void VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            if (this.UnsupportedDependency != null)
                return;

            if (this.semanticModel.GetSymbolInfo(node).Symbol is IMethodSymbol method &&
                !this.IsApprovedWorkflowFunction(method) &&
                !this.IsApprovedAssembly(method.ContainingAssembly))
            {
                this.UnsupportedDependency = Create(method, node);
                return;
            }

            base.VisitInvocationExpression(node);
        }

        public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            if (this.UnsupportedDependency != null)
                return;

            if (this.semanticModel.GetSymbolInfo(node).Symbol is IMethodSymbol constructor &&
                !this.IsApprovedAssembly(constructor.ContainingAssembly) &&
                !WorkflowExpressionSyntaxRewriter.CanRewriteObjectCreation(this.semanticModel, node))
            {
                this.UnsupportedDependency = Create(constructor.ContainingType, node);
                return;
            }

            base.VisitObjectCreationExpression(node);
        }

        public override void VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node)
        {
            if (this.UnsupportedDependency != null)
                return;

            if (this.semanticModel.GetSymbolInfo(node).Symbol is IMethodSymbol constructor &&
                !this.IsApprovedAssembly(constructor.ContainingAssembly) &&
                !WorkflowExpressionSyntaxRewriter.CanRewriteObjectCreation(this.semanticModel, node))
            {
                this.UnsupportedDependency = Create(constructor.ContainingType, node);
                return;
            }

            base.VisitImplicitObjectCreationExpression(node);
        }

        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            if (!this.ValidateType(node.Type))
                return;

            base.VisitCastExpression(node);
        }

        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            if (!this.ValidateType(node.Type))
                return;

            base.VisitTypeOfExpression(node);
        }

        public override void VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            if (!this.ValidateType(node.Type))
                return;

            base.VisitDefaultExpression(node);
        }

        public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
        {
            if (!this.ValidateType(node.Type))
                return;

            base.VisitDeclarationPattern(node);
        }

        public override void VisitTypePattern(TypePatternSyntax node)
        {
            if (!this.ValidateType(node.Type))
                return;

            base.VisitTypePattern(node);
        }

        public override void VisitGenericName(GenericNameSyntax node)
        {
            if (this.UnsupportedDependency != null)
                return;

            foreach (var typeArgument in node.TypeArgumentList.Arguments)
            {
                if (!this.ValidateType(typeArgument))
                    return;
            }

            base.VisitGenericName(node);
        }

        public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            if (this.UnsupportedDependency != null)
                return;

            var symbol = this.semanticModel.GetSymbolInfo(node).Symbol;
            if (symbol is IFieldSymbol { IsStatic: true } field &&
                field.ContainingType.TypeKind != TypeKind.Enum &&
                !this.IsApprovedAssembly(field.ContainingAssembly))
            {
                this.UnsupportedDependency = Create(field, node);
                return;
            }

            if (symbol is IPropertySymbol { IsStatic: true } property &&
                !this.IsSupportedHttpMethod(property) &&
                !this.IsApprovedAssembly(property.ContainingAssembly))
            {
                this.UnsupportedDependency = Create(property, node);
                return;
            }

            base.VisitMemberAccessExpression(node);
        }

        private bool ValidateType(TypeSyntax syntax)
        {
            if (this.UnsupportedDependency != null)
                return false;

            var type = this.semanticModel.GetTypeInfo(syntax).Type;
            if (type != null &&
                !type.IsAnonymousType &&
                !this.IsApprovedType(type))
            {
                this.UnsupportedDependency = Create(type, syntax);
                return false;
            }

            return true;
        }

        private bool IsApprovedType(ITypeSymbol type)
        {
            if (type is IArrayTypeSymbol array)
                return this.IsApprovedType(array.ElementType);

            if (type is INamedTypeSymbol named && named.IsGenericType)
            {
                return this.IsApprovedAssembly(named.ContainingAssembly) &&
                    named.TypeArguments.All(this.IsApprovedType);
            }

            return type is ITypeParameterSymbol ||
                this.IsApprovedAssembly(type.ContainingAssembly);
        }

        private bool IsApprovedWorkflowFunction(IMethodSymbol method) =>
            method.ContainingType.ToDisplayString() ==
                "Microsoft.Azure.Workflows.Sdk.WorkflowFunctions" &&
            method.ContainingAssembly.Name == "Microsoft.Azure.Workflows.Sdk";

        private bool IsSupportedHttpMethod(IPropertySymbol property) =>
            property.ContainingType.ToDisplayString() == "System.Net.Http.HttpMethod" &&
            property.Name is "Get" or "Post" or "Put" or "Delete" or "Head" or "Options" or "Trace" or "Patch";

        private bool IsApprovedAssembly(IAssemblySymbol assembly) =>
            assembly != null && this.approvedAssemblies.Contains(assembly);

        private void AddApprovedAssembly(ITypeSymbol? type)
        {
            if (type?.ContainingAssembly != null)
                this.approvedAssemblies.Add(type.ContainingAssembly);
        }

        private static UnsupportedRuntimeDependency Create(
            ISymbol symbol,
            SyntaxNode node) =>
            new(
                node.GetLocation(),
                symbol.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat),
                symbol.ContainingAssembly?.Name ?? "<unknown>");
    }
}

internal sealed class UnsupportedRuntimeDependency
{
    internal UnsupportedRuntimeDependency(
        Location location,
        string symbol,
        string assembly)
    {
        this.Location = location;
        this.Symbol = symbol;
        this.Assembly = assembly;
    }

    internal Location Location { get; }

    internal string Symbol { get; }

    internal string Assembly { get; }
}

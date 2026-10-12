// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal static class WorkflowExpressionTypePolicy
{
    internal static void ValidateRuntimeType(ITypeSymbol type, SyntaxNode node)
    {
        if (type.IsAnonymousType) return;
        if (type is IArrayTypeSymbol array)
        {
            ValidateRuntimeType(array.ElementType, node);
            return;
        }

        var assembly = type.ContainingAssembly?.Name;
        if (type is ITypeParameterSymbol || assembly is not ("System.Private.CoreLib" or "mscorlib" or "System.Runtime" or "netstandard" or
            "System.Linq" or "System.Collections" or "System.Net.Http" or "System.Net.Primitives" or "System.Private.Uri" or
            "System.Runtime.Numerics" or "Newtonsoft.Json" or Sdk) || type.ToDisplayString().StartsWith("System.Threading.Tasks.", StringComparison.Ordinal))
            throw new ExpressionError($"Runtime type '{type}' is unavailable. Use framework/SDK types or move custom code into a CustomCode action.", node);

        if (type is INamedTypeSymbol named)
            foreach (var argument in named.TypeArguments)
                ValidateRuntimeType(argument, node);
    }

    internal static void ValidateCapture(ITypeSymbol type, SyntaxNode node)
    {
        ValidateRuntimeType(type, node);
        if (type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String || type.TypeKind == TypeKind.Enum ||
            type.ToDisplayString() is "System.Guid" or "System.DateTime" or "System.DateTimeOffset" or "System.TimeSpan" or "System.Uri" or "System.Net.Http.HttpMethod")
            return;

        if (type is INamedTypeSymbol named && named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T)
        {
            ValidateCapture(named.TypeArguments[0], node);
            return;
        }

        throw new ExpressionError("Capture immutable scalar values, not mutable objects or collections.", node);
    }

    internal static bool CanUseWorkflowLiteral(ITypeSymbol type) =>
        type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String;

    internal static bool IsAutomaticProperty(IPropertySymbol property) => property.ContainingType.IsAnonymousType ||
        property.DeclaringSyntaxReferences.Any(reference =>
            reference.GetSyntax() is PropertyDeclarationSyntax { ExpressionBody: null, AccessorList: { } list } &&
            list.Accessors.All(accessor => accessor.Body == null && accessor.ExpressionBody == null));
}

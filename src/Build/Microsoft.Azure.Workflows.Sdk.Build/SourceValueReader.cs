// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal static class SourceValueReader
{
    internal static ExpressionSyntax Read(ITypeSymbol type, string source, bool defaultIfMissing = false)
    {
        WorkflowExpressionTypePolicy.ValidateRuntimeType(type, SyntaxFactory.ParseExpression(source));
        if (type.ToDisplayString() == "Newtonsoft.Json.Linq.JToken") return SyntaxFactory.ParseExpression(source);
        return SyntaxFactory.ParseExpression(defaultIfMissing
            ? $"({source})?.ToObject<{TypeName(type)}>() ?? default({TypeName(type)})"
            : $"({source}).ToObject<{TypeName(type)}>()");
    }
}

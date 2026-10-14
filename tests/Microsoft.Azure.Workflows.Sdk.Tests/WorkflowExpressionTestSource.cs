// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Newtonsoft.Json.Linq;
    using Xunit;

    internal static class WorkflowExpressionTestSource
    {
        internal static string Input(IWorkflowAction action)
        {
            var source = ((JToken)action.GetActionDefinition("flow").Inputs).Value<string>();
            ProgramExpression(source);
            return source;
        }

        internal static ExpressionSyntax ProgramExpression(string source)
        {
            Assert.StartsWith("#{", source);
            Assert.EndsWith("}", source);
            var expression = SyntaxFactory.ParseExpression(source.Substring(2, source.Length - 3));
            Assert.DoesNotContain(expression.GetDiagnostics(), diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
            return expression;
        }

        internal static ExpressionSyntax ReturnExpression(string source) => ProgramExpression(source);

        internal static void AssertReturnExpression(string expected, string source) =>
            Assert.Equal(NormalizeExpression(expected), NormalizeNode(ReturnExpression(source)));

        internal static string NormalizeExpression(string source)
        {
            var expression = SyntaxFactory.ParseExpression(source);
            Assert.DoesNotContain(expression.GetDiagnostics(), diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
            return NormalizeNode(expression);
        }

        internal static string NormalizeNode(SyntaxNode node) => node.NormalizeWhitespace().ToFullString();

    }
}

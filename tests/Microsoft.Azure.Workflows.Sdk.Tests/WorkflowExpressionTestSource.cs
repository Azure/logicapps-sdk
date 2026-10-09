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

        internal static BlockSyntax ProgramBody(string source) =>
            (BlockSyntax)ProgramExpression(source).DescendantNodesAndSelf()
                .OfType<ParenthesizedLambdaExpressionSyntax>()
                .First(lambda => lambda.Body is BlockSyntax).Body;

        internal static ExpressionSyntax ReturnExpression(string source) =>
            ProgramBody(source).Statements.OfType<ReturnStatementSyntax>().Single().Expression;

        internal static void AssertReturnExpression(string expected, string source) =>
            Assert.Equal(NormalizeExpression(expected), NormalizeNode(ReturnExpression(source)));

        internal static string[] CaptureInitializers(string source) =>
            ProgramBody(source).Statements.OfType<LocalDeclarationStatementSyntax>()
                .SelectMany(statement => statement.Declaration.Variables)
                .Where(variable => variable.Identifier.ValueText.StartsWith("__capture", StringComparison.Ordinal))
                .Select(variable => NormalizeNode(variable.Initializer.Value))
                .ToArray();

        internal static string[] RenderPrograms(string transformedSource, string binding)
        {
            var root = CSharpSyntaxTree.ParseText(transformedSource).GetRoot();
            return root.DescendantNodes().OfType<InvocationExpressionSyntax>()
                .Where(invocation => invocation.Expression.ToString().Contains("WorkflowExpression.Program", StringComparison.Ordinal))
                .Select(invocation =>
                {
                    var segments = ((ArrayCreationExpressionSyntax)invocation.ArgumentList.Arguments[0].Expression)
                        .Initializer.Expressions.Cast<LiteralExpressionSyntax>()
                        .Select(segment => segment.Token.ValueText)
                        .ToArray();
                    return "#{" + string.Join(binding, segments) + "}";
                })
                .ToArray();
        }

        internal static string NormalizeExpression(string source)
        {
            var expression = SyntaxFactory.ParseExpression(source);
            Assert.DoesNotContain(expression.GetDiagnostics(), diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
            return NormalizeNode(expression);
        }

        internal static string NormalizeNode(SyntaxNode node) => node.NormalizeWhitespace().ToFullString();

        internal static IEnumerable<MetadataReference> References() =>
            ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")).Split(Path.PathSeparator)
                .Append(typeof(WorkflowExpression).Assembly.Location)
                .Append(typeof(JToken).Assembly.Location)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Select(path => MetadataReference.CreateFromFile(path));
    }
}

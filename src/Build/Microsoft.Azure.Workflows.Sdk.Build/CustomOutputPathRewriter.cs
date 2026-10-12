// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal delegate bool WorkflowReferenceResolver(ExpressionSyntax expression, out string bindingFactorySource);

internal readonly record struct JsonPathSegment(string Key, bool ConditionalReceiver);

internal sealed class CustomOutputPathRewriter(
    SemanticModel model,
    SourceBindingBuilder bindingBuilder,
    WorkflowReferenceResolver resolveWorkflowReference)
{
    internal bool TryRewrite(ExpressionSyntax expression, out ExpressionSyntax replacement)
    {
        var segments = new List<JsonPathSegment>();
        var bindingFactorySource = "";
        if (!Collect(expression, segments, ref bindingFactorySource, conditionalReceiver: false) ||
            bindingFactorySource.Length == 0 ||
            segments.Count == 0)
        {
            replacement = null!;
            return false;
        }

        replacement = Read(model.GetTypeInfo(expression).Type!, bindingFactorySource, segments).WithTriviaFrom(expression);
        return true;
    }

    private bool Collect(
        ExpressionSyntax expression,
        List<JsonPathSegment> segments,
        ref string bindingFactorySource,
        bool conditionalReceiver)
    {
        if (expression is MemberAccessExpressionSyntax member)
        {
            if (resolveWorkflowReference(member, out bindingFactorySource)) return true;
            if (!Collect(member.Expression, segments, ref bindingFactorySource, conditionalReceiver) ||
                model.GetSymbolInfo(member).Symbol is not IPropertySymbol property ||
                !IsCustomPathProperty(property))
                return false;

            segments.Add(new JsonPathSegment(WireName(property), ConditionalReceiver: false));
            return true;
        }

        if (expression is MemberBindingExpressionSyntax binding)
        {
            if (model.GetSymbolInfo(binding).Symbol is not IPropertySymbol property || !IsCustomPathProperty(property))
                return false;

            segments.Add(new JsonPathSegment(WireName(property), conditionalReceiver));
            return true;
        }

        if (expression is ConditionalAccessExpressionSyntax conditional)
        {
            return Collect(conditional.Expression, segments, ref bindingFactorySource, conditionalReceiver) &&
                Collect(conditional.WhenNotNull, segments, ref bindingFactorySource, conditionalReceiver: true);
        }

        return false;
    }

    private ExpressionSyntax Read(
        ITypeSymbol type,
        string bindingFactorySource,
        List<JsonPathSegment> segments)
    {
        var root = bindingBuilder.Bind(bindingFactorySource);
        if (!segments.Any(segment => segment.ConditionalReceiver))
        {
            var source = root + string.Concat(segments.Select(segment => "[" + Quote(segment.Key) + "]"));
            return SourceValueReader.Read(type, source, defaultIfMissing: true);
        }

        WorkflowExpressionTypePolicy.ValidateRuntimeType(type, SyntaxFactory.ParseExpression(root));
        var token = bindingBuilder.Unique("__path");
        var sourceBuilder = new System.Text.StringBuilder(
            $"((global::System.Func<{TypeName(type)}>)(() => {{ global::Newtonsoft.Json.Linq.JToken {token} = {root}; ");

        foreach (var segment in segments)
        {
            if (segment.ConditionalReceiver)
            {
                sourceBuilder.Append(
                    $"if ({token} == null || {token}.Type is global::Newtonsoft.Json.Linq.JTokenType.Null or " +
                    $"global::Newtonsoft.Json.Linq.JTokenType.Undefined) return default({TypeName(type)}); ");
            }
            sourceBuilder.Append($"{token} = {token}[{Quote(segment.Key)}]; ");
        }

        sourceBuilder.Append(type.ToDisplayString() == "Newtonsoft.Json.Linq.JToken"
            ? $"return {token}; }}))()"
            : $"return {token}?.ToObject<{TypeName(type)}>() ?? default({TypeName(type)}); }}))()");
        return SyntaxFactory.ParseExpression(sourceBuilder.ToString());
    }

    private static bool IsCustomPathProperty(IPropertySymbol property) =>
        property.ContainingAssembly.Name != Sdk &&
        !property.ContainingAssembly.Name.StartsWith("System", StringComparison.Ordinal) &&
        property.ContainingAssembly.Name != "Newtonsoft.Json" &&
        WorkflowExpressionTypePolicy.IsAutomaticProperty(property);

    private static string WireName(IPropertySymbol property) =>
        property.GetAttributes().FirstOrDefault(attribute =>
            attribute.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute")
            ?.ConstructorArguments.FirstOrDefault().Value as string ?? property.Name;
}

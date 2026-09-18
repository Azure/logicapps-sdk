// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Generators;

using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal static class InlineTemplateSyntaxRenderer
{
    public static bool TryRender(ExpressionSyntax expression, out string source)
    {
        try
        {
            source = Render(expression);
            return true;
        }
        catch (NotSupportedException)
        {
            return TryRenderStructuralWorkflowAccess(expression, out source);
        }
    }

    private static bool TryRenderStructuralWorkflowAccess(
        ExpressionSyntax expression,
        out string source)
    {
        source = expression.WithoutTrivia().NormalizeWhitespace().ToFullString();
        source = Regex.Replace(
            source,
            @"\.Children\(\)\.ElementAt\(([^()]*)\)",
            "[$1]");
        source = Regex.Replace(
            source,
            @"\.(?:ToObject|Value)<[^>]+>\(\)",
            string.Empty);
        source = Regex.Replace(
            source,
            @"(\??)\[\""((?:\\.|[^\""])*)\""\]",
            match => $"{match.Groups[1].Value}['{match.Groups[2].Value.Replace("'", "''")}']");
        source = Regex.Replace(
            source,
            @"\b(body|outputs|variables|agentparameters|actions)\(\""((?:\\.|[^\""])*)\""\)",
            match => $"{match.Groups[1].Value}('{match.Groups[2].Value.Replace("'", "''")}')");

        if (source.IndexOf(".Children()", StringComparison.Ordinal) >= 0 ||
            source.IndexOf(".ToObject<", StringComparison.Ordinal) >= 0 ||
            source.IndexOf(".Value<", StringComparison.Ordinal) >= 0 ||
            source.IndexOf("\"", StringComparison.Ordinal) >= 0)
        {
            source = null!;
            return false;
        }

        return true;
    }

    private static string Render(ExpressionSyntax expression)
    {
        return expression switch
        {
            LiteralExpressionSyntax literal => RenderLiteral(literal),
            IdentifierNameSyntax identifier when
                identifier.Identifier.ValueText.StartsWith("__logicapps_capture_", StringComparison.Ordinal) =>
                identifier.Identifier.ValueText,
            ParenthesizedExpressionSyntax parenthesized => Render(parenthesized.Expression),
            CastExpressionSyntax cast => Render(cast.Expression),
            BinaryExpressionSyntax binary => RenderBinary(binary),
            ConditionalExpressionSyntax conditional =>
                $"if({Render(conditional.Condition)}, {Render(conditional.WhenTrue)}, {Render(conditional.WhenFalse)})",
            PrefixUnaryExpressionSyntax unary when unary.IsKind(SyntaxKind.LogicalNotExpression) =>
                $"not({Render(unary.Operand)})",
            InvocationExpressionSyntax invocation => RenderInvocation(invocation),
            ElementAccessExpressionSyntax elementAccess =>
                $"{Render(elementAccess.Expression)}[{RenderArguments(elementAccess.ArgumentList.Arguments)}]",
            ConditionalAccessExpressionSyntax conditionalAccess =>
                RenderConditionalAccess(conditionalAccess),
            InterpolatedStringExpressionSyntax interpolated => RenderInterpolatedString(interpolated),
            _ => throw new NotSupportedException(),
        };
    }

    private static string RenderInvocation(InvocationExpressionSyntax invocation)
    {
        if (invocation.Expression is IdentifierNameSyntax identifier)
        {
            return $"{identifier.Identifier.ValueText}({RenderArguments(invocation.ArgumentList.Arguments)})";
        }

        if (invocation.Expression is MemberAccessExpressionSyntax member)
        {
            var methodName = member.Name.Identifier.ValueText;
            if (methodName == "ElementAt" &&
                invocation.ArgumentList.Arguments.Count == 1 &&
                member.Expression is InvocationExpressionSyntax childrenInvocation &&
                childrenInvocation.Expression is MemberAccessExpressionSyntax childrenMember &&
                childrenMember.Name.Identifier.ValueText == "Children")
            {
                return $"{Render(childrenMember.Expression)}[{Render(invocation.ArgumentList.Arguments[0].Expression)}]";
            }
            if (methodName == "Children" && invocation.ArgumentList.Arguments.Count == 0)
                return Render(member.Expression);
            if (methodName is "ToObject" or "Value")
                return Render(member.Expression);
            if (methodName == "ToString" && invocation.ArgumentList.Arguments.Count == 0)
                return $"string({Render(member.Expression)})";
        }

        throw new NotSupportedException();
    }

    private static string RenderConditionalAccess(ConditionalAccessExpressionSyntax conditionalAccess)
    {
        var target = Render(conditionalAccess.Expression);
        if (conditionalAccess.WhenNotNull is ElementBindingExpressionSyntax elementBinding)
            return $"{target}?[{RenderArguments(elementBinding.ArgumentList.Arguments)}]";

        throw new NotSupportedException();
    }

    private static string RenderBinary(BinaryExpressionSyntax binary)
    {
        var left = Render(binary.Left);
        var right = Render(binary.Right);
        var functionName = binary.Kind() switch
        {
            SyntaxKind.AddExpression => "add",
            SyntaxKind.SubtractExpression => "subtract",
            SyntaxKind.MultiplyExpression => "multiply",
            SyntaxKind.DivideExpression => "divide",
            SyntaxKind.ModuloExpression => "mod",
            SyntaxKind.EqualsExpression => "equals",
            SyntaxKind.NotEqualsExpression => null,
            SyntaxKind.LessThanExpression => "less",
            SyntaxKind.LessThanOrEqualExpression => "lessOrEquals",
            SyntaxKind.GreaterThanExpression => "greater",
            SyntaxKind.GreaterThanOrEqualExpression => "greaterOrEquals",
            SyntaxKind.LogicalAndExpression or SyntaxKind.BitwiseAndExpression => "and",
            SyntaxKind.LogicalOrExpression or SyntaxKind.BitwiseOrExpression => "or",
            SyntaxKind.CoalesceExpression => "coalesce",
            _ => throw new NotSupportedException(),
        };

        if (binary.IsKind(SyntaxKind.NotEqualsExpression))
            return $"not(equals({left}, {right}))";

        return $"{functionName}({left}, {right})";
    }

    private static string RenderInterpolatedString(InterpolatedStringExpressionSyntax interpolated)
    {
        var arguments = new List<string>();
        foreach (var content in interpolated.Contents)
        {
            switch (content)
            {
                case InterpolatedStringTextSyntax text when text.TextToken.ValueText.Length > 0:
                    arguments.Add(Quote(text.TextToken.ValueText));
                    break;
                case InterpolationSyntax interpolation:
                    arguments.Add(Render(interpolation.Expression));
                    break;
            }
        }

        return arguments.Count switch
        {
            0 => "''",
            1 => arguments[0],
            _ => $"concat({string.Join(", ", arguments)})",
        };
    }

    private static string RenderArguments(
        SeparatedSyntaxList<ArgumentSyntax> arguments) =>
        string.Join(", ", arguments.Select(argument => Render(argument.Expression)));

    private static string RenderLiteral(LiteralExpressionSyntax literal)
    {
        if (literal.IsKind(SyntaxKind.StringLiteralExpression) ||
            literal.IsKind(SyntaxKind.CharacterLiteralExpression))
        {
            return Quote(literal.Token.ValueText);
        }

        return literal.Token.Text.ToLowerInvariant();
    }

    private static string Quote(string value) =>
        $"'{value.Replace("'", "''")}'";
}

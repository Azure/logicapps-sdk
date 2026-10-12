// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal sealed class SourceProgram(SemanticModel model, LambdaExpressionSyntax lambda, ITypeSymbol resultType) : CSharpSyntaxRewriter
{
    private static readonly IReadOnlyDictionary<string, string> WorkflowFunctions = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        ["ToJson"] = "json", ["Actions"] = "actions", ["Trigger"] = "trigger", ["ListCallbackUrl"] = "listCallbackUrl",
        ["AppSetting"] = "appsetting", ["Action"] = "action", ["CurrentRequest"] = "currentRequest",
        ["Binary"] = "binary", ["Base64ToBinary"] = "base64ToBinary", ["DataUriToBinary"] = "dataUriToBinary",
        ["MultipartBody"] = "multipartBody", ["FormDataValue"] = "formDataValue", ["FormDataMultiValues"] = "formDataMultiValues",
        ["TriggerMultipartBody"] = "triggerMultipartBody", ["TriggerFormDataValue"] = "triggerFormDataValue",
        ["TriggerFormDataMultiValues"] = "triggerFormDataMultiValues",
    };

    private readonly SourceBindingBuilder bindingBuilder = new(lambda);

    private CustomOutputPathRewriter? customOutputPaths;

    internal string Build()
    {
        if (!lambda.AsyncKeyword.IsKind(SyntaxKind.None)) throw Error("Workflow value lambdas must be synchronous.", lambda);

        WorkflowExpressionTypePolicy.ValidateRuntimeType(resultType, lambda);
        if (lambda.Body is ExpressionSyntax expression &&
            model.GetConstantValue(expression) is { HasValue: true } constant &&
            (constant.Value == null || WorkflowExpressionTypePolicy.CanUseWorkflowLiteral(resultType)))
        {
            var value = Constant(constant.Value);
            return $"{Prefix}WorkflowExpression.Literal<{TypeName(resultType)}>(({TypeName(resultType)})({value}))";
        }

        if (lambda.Body is IdentifierNameSyntax capturedExpression &&
            model.GetSymbolInfo(capturedExpression).Symbol is ILocalSymbol capturedLocal && !Local(capturedLocal) &&
            SymbolEqualityComparer.Default.Equals(capturedLocal.Type, resultType) &&
            WorkflowExpressionTypePolicy.CanUseWorkflowLiteral(resultType))
        {
            WorkflowExpressionTypePolicy.ValidateCapture(capturedLocal.Type, capturedExpression);
            return $"{Prefix}WorkflowExpression.Literal<{TypeName(resultType)}>({capturedExpression})";
        }

        var body = Visit(lambda.Body)!;
        return new SourceTransportBuilder(model, lambda, resultType, bindingBuilder).Build(body);
    }

    public override SyntaxNode? Visit(SyntaxNode? node)
    {
        if (node is ExpressionSyntax path &&
            (customOutputPaths ??= new CustomOutputPathRewriter(model, bindingBuilder, TryWorkflowReference))
                .TryRewrite(path, out var customPath))
        {
            return customPath;
        }

        if (node is ExpressionSyntax expression && TryWorkflowReference(expression, out var bindingFactorySource))
            return SourceValueReader.Read(
                model.GetTypeInfo(expression).Type!,
                bindingBuilder.Bind(bindingFactorySource)).WithTriviaFrom(node);

        if (node is MemberAccessExpressionSyntax { Expression: ThisExpressionSyntax or BaseExpressionSyntax } instanceMember &&
            model.GetSymbolInfo(instanceMember).Symbol is ISymbol instanceSymbol)
            return CaptureInstanceMember(instanceMember, instanceSymbol);

        if (node is ThisExpressionSyntax or BaseExpressionSyntax)
            throw Error("Capture supported instance data rather than referring to the authoring object.", node);

        if (node is TypeSyntax typeSyntax && node is not IdentifierNameSyntax { Identifier.ValueText: "var" } &&
            node.Parent is not QualifiedNameSyntax and not AliasQualifiedNameSyntax &&
            !(node.Parent is MemberAccessExpressionSyntax access && access.Name == node) &&
            model.GetSymbolInfo(typeSyntax).Symbol is INamedTypeSymbol type && !type.IsAnonymousType)
        {
            WorkflowExpressionTypePolicy.ValidateRuntimeType(type, node);
            return SyntaxFactory.ParseTypeName(TypeName(type)).WithTriviaFrom(node);
        }

        return base.Visit(node);
    }

    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
    {
        if (node.Parent is MemberAccessExpressionSyntax member && member.Name == node || node.Parent is NameEqualsSyntax or NameColonSyntax)
            return node;

        if (node.Parent is AssignmentExpressionSyntax initializerAssignment && initializerAssignment.Left == node &&
            initializerAssignment.Parent is InitializerExpressionSyntax)
            return node;

        var symbol = model.GetSymbolInfo(node).Symbol;
        if (symbol is ILocalSymbol or IParameterSymbol && !Local(symbol))
        {
            if (symbol is ILocalSymbol { IsConst: true } constant) return Parse(Constant(constant.ConstantValue), node);
            var type = symbol is ILocalSymbol local ? local.Type : ((IParameterSymbol)symbol).Type;
            return bindingBuilder.Capture(node, symbol, type, "@" + symbol.Name);
        }

        if (symbol is IFieldSymbol { IsStatic: false } instanceField && !Local(instanceField))
            return bindingBuilder.Capture(node, instanceField, instanceField.Type, node.ToString());

        if (symbol is IPropertySymbol { IsStatic: false } instanceProperty && !Local(instanceProperty))
            return CaptureInstanceMember(node, instanceProperty);

        if (symbol is IMethodSymbol { IsStatic: false, MethodKind: MethodKind.Ordinary } && node.Parent is InvocationExpressionSyntax)
            throw Error($"Instance method '{symbol.Name}' cannot run in the workflow host. Invoke it before creating the workflow expression and capture its result.", node);

        if (symbol is IMethodSymbol { IsStatic: true, MethodKind: not MethodKind.LocalFunction } method && node.Parent is InvocationExpressionSyntax)
            return Parse(TypeName(method.ContainingType) + "." + node, node);

        if (symbol is IFieldSymbol { IsStatic: true } field)
            return Parse(TypeName(field.ContainingType) + "." + node, node);

        if (symbol is IPropertySymbol { IsStatic: true } property)
            return Parse(TypeName(property.ContainingType) + "." + node, node);

        return base.VisitIdentifierName(node);
    }

    public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
    {
        if (model.GetSymbolInfo(node).Symbol is IPropertySymbol property) WorkflowExpressionTypePolicy.ValidateRuntimeType(property.ContainingType, node);
        if (model.GetSymbolInfo(node).Symbol is IFieldSymbol field) WorkflowExpressionTypePolicy.ValidateRuntimeType(field.ContainingType, node);
        return base.VisitMemberAccessExpression(node);
    }

    public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
    {
        if (node.Expression is IdentifierNameSyntax { Identifier.ValueText: "nameof" } &&
            model.GetConstantValue(node) is { HasValue: true, Value: string text }) return Parse(Quote(text), node);

        if (model.GetSymbolInfo(node).Symbol is not IMethodSymbol method) return base.VisitInvocationExpression(node);

        if (!method.IsStatic && method.MethodKind == MethodKind.Ordinary &&
            (node.Expression is IdentifierNameSyntax ||
             node.Expression is MemberAccessExpressionSyntax { Expression: ThisExpressionSyntax or BaseExpressionSyntax }))
            throw Error($"Instance method '{method.Name}' cannot run in the workflow host. Invoke it before creating the workflow expression and capture its result.", node);

        if (method.ContainingType.ToDisplayString() == Sdk + ".WorkflowFunctions")
        {
            if (!WorkflowFunctions.TryGetValue(method.Name, out var function)) throw Error("Unsupported workflow function.", node);
            var call = SyntaxFactory.InvocationExpression(SyntaxFactory.IdentifierName(function),
                node.ArgumentList.WithArguments(SyntaxFactory.SeparatedList(node.ArgumentList.Arguments.Select(argument => (ArgumentSyntax)Visit(argument)!))));
            return (method.IsGenericMethod ? SourceValueReader.Read(method.TypeArguments[0], call.ToString()) : call).WithTriviaFrom(node);
        }

        if (method.MethodKind == MethodKind.LocalFunction && !Local(method))
            throw Error("Declare the local function inside the workflow value lambda.", node);

        if (!Local(method))
        {
            WorkflowExpressionTypePolicy.ValidateRuntimeType(method.ContainingType, node);
            if (method.DeclaredAccessibility != Accessibility.Public && method.MethodKind != MethodKind.AnonymousFunction)
                throw Error("Expression runtime members must be public.", node);
        }

        foreach (var type in method.TypeArguments) WorkflowExpressionTypePolicy.ValidateRuntimeType(type, node);

        return base.VisitInvocationExpression(node);
    }

    public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
    {
        if (TryWorkflowReference(node.Expression, out var bindingFactorySource))
        {
            var sourceType = model.GetTypeInfo(node.Expression).Type;
            var target = model.GetTypeInfo(node.Type).Type!;
            if (sourceType?.SpecialType == SpecialType.System_Object || sourceType?.ToDisplayString() == "Newtonsoft.Json.Linq.JToken")
                return SourceValueReader.Read(target, bindingBuilder.Bind(bindingFactorySource)).WithTriviaFrom(node);
        }

        return base.VisitCastExpression(node);
    }

    public override SyntaxNode? VisitInterpolation(InterpolationSyntax node)
    {
        var rewritten = (InterpolationSyntax)base.VisitInterpolation(node)!;
        return rewritten.WithExpression(SyntaxFactory.ParenthesizedExpression(rewritten.Expression));
    }

    private bool TryWorkflowReference(ExpressionSyntax expression, out string bindingFactorySource)
    {
        bindingFactorySource = "";
        if (expression is IdentifierNameSyntax && model.GetSymbolInfo(expression).Symbol is IParameterSymbol item && !Local(item))
        {
            var parent = item.DeclaringSyntaxReferences.FirstOrDefault()?.GetSyntax().Ancestors().OfType<LambdaExpressionSyntax>().FirstOrDefault();
            if (parent?.Parent is ArgumentSyntax { Parent.Parent: InvocationExpressionSyntax call } &&
                model.GetSymbolInfo(call).Symbol is IMethodSymbol { Name: "ForEach", ContainingAssembly.Name: Sdk })
            {
                bindingFactorySource = $"{Prefix}WorkflowExpressionBinding.Item({expression})";
                return true;
            }
        }

        if (expression is not MemberAccessExpressionSyntax member || model.GetSymbolInfo(member).Symbol is not IPropertySymbol property) return false;
        var receiver = model.GetTypeInfo(member.Expression).Type;
        var function = property.Name switch
        {
            "Output" when Implements(receiver, "IOutputWorkflowAction") => "Output",
            "Body" when Implements(receiver, "IBodyWorkflowAction") => "Body",
            "TriggerOutput" when Implements(receiver, "IOutputWorkflowTrigger") => "Trigger",
            "TriggerBody" when Implements(receiver, "IBodyWorkflowTrigger") => "Trigger",
            "Value" when Implements(receiver, "IVariableWorkflowAction") => "Variable",
            _ => null,
        };

        if (function != null)
        {
            var handle = model.GetSymbolInfo(member.Expression).Symbol;
            if (handle is not (ILocalSymbol or IParameterSymbol or IFieldSymbol) || Local(handle))
                throw Error("Workflow handles must be locals, parameters or fields outside the value lambda.", member.Expression);
            bindingFactorySource = $"{Prefix}WorkflowExpressionBinding.{function}({member.Expression}" +
                (function == "Trigger" ? ", " + (property.Name == "TriggerBody" ? "true" : "false") : "") + ")";
            return true;
        }

        if (member.Expression is MemberAccessExpressionSyntax { Name.Identifier.ValueText: "Parameters" } parameters &&
            Implements(model.GetTypeInfo(parameters.Expression).Type, "IAgentToolContext"))
        {
            bindingFactorySource = $"{Prefix}WorkflowExpressionBinding.AgentParameter({parameters.Expression}, {Quote(property.Name)})";
            return true;
        }

        return false;
    }

    private ExpressionSyntax CaptureInstanceMember(ExpressionSyntax node, ISymbol symbol)
    {
        var type = symbol switch
        {
            IFieldSymbol field => field.Type,
            IPropertySymbol property when WorkflowExpressionTypePolicy.IsAutomaticProperty(property) => property.Type,
            IPropertySymbol property => throw Error(
                $"Instance property '{property.Name}' has an executable getter. Read it before creating the workflow expression and capture the result.",
                node),
            _ => throw Error("Only instance fields and auto-properties can be captured.", node),
        };
        return bindingBuilder.Capture(node, symbol, type, node.ToString());
    }

    private bool Local(ISymbol symbol) => symbol.DeclaringSyntaxReferences.Any(reference =>
        reference.SyntaxTree == lambda.SyntaxTree && lambda.Span.Contains(reference.Span));

    private static bool Implements(ITypeSymbol? type, string name) => type != null && type.AllInterfaces.Prepend(type)
        .Any(candidate => candidate.Name == name && candidate.ContainingNamespace.ToDisplayString() == Sdk);

    private static ExpressionSyntax Parse(string source, SyntaxNode node) => SyntaxFactory.ParseExpression(source).WithTriviaFrom(node);

    private static ExpressionError Error(string text, SyntaxNode node) => new(text, node);

    private static string Constant(object? value) => value switch
    {
        null => "null", string text => Quote(text), char ch => "(char)" + (int)ch, bool flag => flag ? "true" : "false",
        decimal number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "m",
        double number when double.IsNaN(number) => "global::System.Double.NaN",
        double number when double.IsInfinity(number) => number > 0 ? "global::System.Double.PositiveInfinity" : "global::System.Double.NegativeInfinity",
        float number when float.IsNaN(number) => "global::System.Single.NaN",
        float number when float.IsInfinity(number) => number > 0 ? "global::System.Single.PositiveInfinity" : "global::System.Single.NegativeInfinity",
        double number => number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "d",
        float number => number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "f",
        long number => number + "L", ulong number => number + "UL", uint number => number + "U",
        _ => Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture)!,
    };
}

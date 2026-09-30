// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Generators;

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal sealed class WorkflowExpressionSyntaxRewriter : CSharpSyntaxRewriter
{
    private const string WorkflowDataAnnotationKind = "WorkflowData";
    private readonly SemanticModel semanticModel;
    private readonly Dictionary<string, WorkflowOperationRegistration> operationRegistrations =
        new(StringComparer.Ordinal);
    private readonly HashSet<string> capturedValueNames =
        new(StringComparer.Ordinal);
    private readonly HashSet<IParameterSymbol> workflowDataParameters =
        new(SymbolEqualityComparer.Default);

    public WorkflowExpressionSyntaxRewriter(SemanticModel semanticModel)
    {
        this.semanticModel = semanticModel;
    }

    public ImmutableArray<WorkflowOperationRegistration> OperationRegistrations =>
        this.operationRegistrations.Values.ToImmutableArray();

    public ImmutableArray<string> CapturedValueNames =>
        this.capturedValueNames.ToImmutableArray();

    internal static bool CanRewriteObjectCreation(
        SemanticModel semanticModel,
        BaseObjectCreationExpressionSyntax node)
    {
        if (semanticModel.GetSymbolInfo(node).Symbol is not IMethodSymbol constructor ||
            constructor.Parameters.Length != 0 ||
            !IsJsonObjectType(constructor.ContainingType) ||
            (!constructor.IsImplicitlyDeclared &&
                constructor.ContainingAssembly.Name != "Microsoft.Azure.Workflows.Sdk"))
        {
            return false;
        }

        return node.Initializer == null ||
            node.Initializer.Expressions.All(expression =>
                expression is AssignmentExpressionSyntax assignment &&
                assignment.IsKind(SyntaxKind.SimpleAssignmentExpression) &&
                semanticModel.GetSymbolInfo(assignment.Left).Symbol is IPropertySymbol);
    }

    internal static bool IsJsonObjectType(ITypeSymbol type) =>
        type.TypeKind == TypeKind.Class &&
        GetObjectProperties(type).Any(property => property.GetAttributes().Any(attribute =>
            attribute.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute"));

    public override SyntaxNode? VisitObjectCreationExpression(ObjectCreationExpressionSyntax node) =>
        CanRewriteObjectCreation(this.semanticModel, node)
            ? this.RewriteObjectCreation(node)
            : base.VisitObjectCreationExpression(node);

    public override SyntaxNode? VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node) =>
        CanRewriteObjectCreation(this.semanticModel, node)
            ? this.RewriteObjectCreation(node)
            : base.VisitImplicitObjectCreationExpression(node);

    public override SyntaxNode? VisitArrayCreationExpression(ArrayCreationExpressionSyntax node) =>
        node.Initializer != null &&
        this.semanticModel.GetTypeInfo(node).Type is IArrayTypeSymbol array &&
        IsJsonObjectType(array.ElementType)
            ? this.RewriteObjectArray(node.Initializer).WithTriviaFrom(node)
            : base.VisitArrayCreationExpression(node);

    public override SyntaxNode? VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node) =>
        this.semanticModel.GetTypeInfo(node).Type is IArrayTypeSymbol array &&
        IsJsonObjectType(array.ElementType)
            ? this.RewriteObjectArray(node.Initializer).WithTriviaFrom(node)
            : base.VisitImplicitArrayCreationExpression(node);

    private ExpressionSyntax RewriteObjectArray(InitializerExpressionSyntax initializer) =>
        WorkflowData(
            $"new global::Newtonsoft.Json.Linq.JArray {{ {string.Join(", ", initializer.Expressions.Select(expression => this.Visit(expression)!.WithoutTrivia().NormalizeWhitespace().ToFullString()))} }}");

    private ExpressionSyntax RewriteObjectCreation(BaseObjectCreationExpressionSyntax node)
    {
        var properties = new List<string>();
        var boundMembers = new HashSet<string>(StringComparer.Ordinal);
        if (node.Initializer != null)
        {
            foreach (var assignment in node.Initializer.Expressions.Cast<AssignmentExpressionSyntax>())
            {
                var property = (IPropertySymbol)this.semanticModel.GetSymbolInfo(assignment.Left).Symbol!;
                boundMembers.Add(property.Name);
                AddProperty(property, (ExpressionSyntax)this.Visit(assignment.Right)!);
            }
        }

        // Defaults are metadata, not constructor execution: customer CLR types never reach the runtime.
        var type = this.semanticModel.GetTypeInfo(node).Type!;
        foreach (var property in GetObjectProperties(type))
        {
            if (boundMembers.Contains(property.Name))
                continue;

            var attribute = property.GetAttributes().FirstOrDefault(candidate =>
                candidate.AttributeClass?.ToDisplayString() == "System.ComponentModel.DefaultValueAttribute");
            if (attribute?.ConstructorArguments.Length == 1)
            {
                AddProperty(property, RenderDefaultValue(property.Type, attribute.ConstructorArguments[0].Value));
            }
        }

        return WorkflowData($"new global::Newtonsoft.Json.Linq.JObject({string.Join(", ", properties)})")
            .WithTriviaFrom(node);

        void AddProperty(IPropertySymbol property, ExpressionSyntax value)
        {
            var name = SymbolDisplay.FormatLiteral(GetJsonPropertyName(property, property.Name), quote: true);
            properties.Add(
                $"new global::Newtonsoft.Json.Linq.JProperty({name}, {value.WithoutTrivia().NormalizeWhitespace()})");
        }
    }

    private static IEnumerable<IPropertySymbol> GetObjectProperties(ITypeSymbol type)
    {
        var names = new HashSet<string>(StringComparer.Ordinal);
        for (var current = type; current != null; current = current.BaseType)
        {
            foreach (var property in current.GetMembers().OfType<IPropertySymbol>())
            {
                if (!property.IsStatic && !property.IsIndexer &&
                    property.DeclaredAccessibility == Accessibility.Public &&
                    names.Add(property.Name))
                {
                    yield return property;
                }
            }
        }
    }

    private static ExpressionSyntax RenderDefaultValue(ITypeSymbol type, object? value)
    {
        if (type is INamedTypeSymbol named &&
            named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T)
        {
            type = named.TypeArguments[0];
        }

        if (value != null && type.TypeKind == TypeKind.Enum)
        {
            var member = type.GetMembers().OfType<IFieldSymbol>()
                .FirstOrDefault(field => field.HasConstantValue && Equals(field.ConstantValue, value));
            if (member != null)
                return RenderConstant(GetEnumWireValue(member));
        }

        if (value is string json && IsJToken(type))
        {
            return SyntaxFactory.ParseExpression(
                $"global::Newtonsoft.Json.Linq.JToken.Parse({SymbolDisplay.FormatLiteral(json, quote: true)})");
        }

        return RenderConstant(value);
    }

    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
    {
        if (node.Parent is MemberAccessExpressionSyntax memberAccess &&
            memberAccess.Name == node)
        {
            return node;
        }

        var symbol = semanticModel.GetSymbolInfo(node).Symbol;
        if (symbol is ILocalSymbol { IsConst: true } constantLocal)
        {
            return RenderConstant(constantLocal.ConstantValue).WithTriviaFrom(node);
        }

        if (symbol is ILocalSymbol local &&
            !IsWorkflowOperation(local.Type))
        {
            this.capturedValueNames.Add(local.Name);
            return SyntaxFactory.IdentifierName(GetCaptureMarker(local.Name))
                .WithTriviaFrom(node);
        }

        if (symbol is IParameterSymbol parameter &&
            !this.workflowDataParameters.Contains(parameter))
        {
            this.capturedValueNames.Add(parameter.Name);
            return SyntaxFactory.IdentifierName(GetCaptureMarker(parameter.Name))
                .WithTriviaFrom(node);
        }

        return base.VisitIdentifierName(node);
    }

    public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
    {
        if (semanticModel.GetSymbolInfo(node).Symbol is IPropertySymbol
            {
                IsStatic: true,
                ContainingType.Name: "HttpMethod",
            } httpMethod &&
            httpMethod.ContainingType.ContainingNamespace.ToDisplayString() == "System.Net.Http")
        {
            return SyntaxFactory.LiteralExpression(
                    SyntaxKind.StringLiteralExpression,
                    SyntaxFactory.Literal(httpMethod.Name.ToUpperInvariant()))
                .WithTriviaFrom(node);
        }

        if (node.Expression is MemberAccessExpressionSyntax
            {
                Name.Identifier.ValueText: "Parameters",
            } parametersAccess &&
            Implements(
                semanticModel.GetTypeInfo(parametersAccess.Expression).Type,
                "IAgentToolContext",
                arity: 1))
        {
            var propertyName = GetJsonPropertyName(
                semanticModel.GetSymbolInfo(node).Symbol as IPropertySymbol,
                node.Name.Identifier.ValueText);
            return RenderWorkflowAccessor(
                    SyntaxFactory.ParseExpression(
                        $"agentparameters({SymbolDisplay.FormatLiteral(propertyName, quote: true)})"),
                    semanticModel.GetTypeInfo(node).Type)
                .WithTriviaFrom(node);
        }

        if (semanticModel.GetSymbolInfo(node).Symbol is IFieldSymbol
            {
                ContainingType.TypeKind: TypeKind.Enum,
                HasConstantValue: true,
            } enumMember &&
            !IsRuntimeSupportedType(enumMember.ContainingType))
        {
            return SyntaxFactory.LiteralExpression(
                    SyntaxKind.StringLiteralExpression,
                    SyntaxFactory.Literal(GetEnumWireValue(enumMember)))
                .WithTriviaFrom(node);
        }

        if (TryRewriteWorkflowBoundary(node, out var boundary))
            return boundary.WithTriviaFrom(node);

        var receiver = (ExpressionSyntax)Visit(node.Expression)!;
        if (semanticModel.GetSymbolInfo(node.Expression).Symbol is IParameterSymbol parameter &&
            this.workflowDataParameters.Contains(parameter))
        {
            receiver = receiver.WithAdditionalAnnotations(
                new SyntaxAnnotation(WorkflowDataAnnotationKind));
        }

        if (receiver.HasAnnotations(WorkflowDataAnnotationKind))
        {
            if (node.Name.Identifier.ValueText is "Count" or "Length" &&
                IsSequenceType(semanticModel.GetTypeInfo(node.Expression).Type))
            {
                return SyntaxFactory.ParseExpression(
                        $"{receiver.WithoutTrivia().NormalizeWhitespace()}.Count()")
                    .WithTriviaFrom(node);
            }

            var propertyName = GetJsonPropertyName(
                semanticModel.GetSymbolInfo(node).Symbol as IPropertySymbol,
                node.Name.Identifier.ValueText);
            var access = SyntaxFactory.ParseExpression(
                $"{receiver.WithoutTrivia().NormalizeWhitespace()}?[{SymbolDisplay.FormatLiteral(propertyName, quote: true)}]");
            var resultType = semanticModel.GetTypeInfo(node).Type;
            return RenderWorkflowAccessor(access, resultType).WithTriviaFrom(node);
        }

        return node.Update(
            receiver,
            node.OperatorToken,
            (SimpleNameSyntax)Visit(node.Name)!);
    }

    public override SyntaxNode? VisitElementAccessExpression(ElementAccessExpressionSyntax node)
    {
        var receiver = (ExpressionSyntax)Visit(node.Expression)!;
        var arguments = (BracketedArgumentListSyntax)Visit(node.ArgumentList)!;
        if (!receiver.HasAnnotations(WorkflowDataAnnotationKind))
            return node.Update(receiver, arguments);

        var resultType = semanticModel.GetTypeInfo(node).Type;
        var receiverType = semanticModel.GetTypeInfo(node.Expression).Type;
        ExpressionSyntax access;
        if (IsSequenceType(receiverType) &&
            arguments.Arguments.Count == 1 &&
            IsNumericType(semanticModel.GetTypeInfo(node.ArgumentList.Arguments[0].Expression).Type))
        {
            access = SyntaxFactory.ParseExpression(
                $"{receiver.WithoutTrivia().NormalizeWhitespace()}.Children().ElementAt({arguments.Arguments[0].Expression.WithoutTrivia().NormalizeWhitespace()})");
        }
        else
        {
            access = SyntaxFactory.ParseExpression(
                $"{receiver.WithoutTrivia().NormalizeWhitespace()}{arguments.WithoutTrivia().NormalizeWhitespace()}");
        }

        return RenderWorkflowAccessor(access, resultType).WithTriviaFrom(node);
    }

    public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
    {
            var method = semanticModel.GetSymbolInfo(node).Symbol as IMethodSymbol;
            if (method?.ContainingType.ToDisplayString() == "Microsoft.Azure.Workflows.Sdk.WorkflowFunctions")
            {
                var arguments = node.ArgumentList.Arguments
                    .Select(argument => argument.WithExpression((ExpressionSyntax)Visit(argument.Expression)!));
                var functionName = GetWorkflowFunctionName(method.Name);
                return SyntaxFactory.InvocationExpression(
                        SyntaxFactory.IdentifierName(functionName),
                        SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(arguments)))
                    .WithTriviaFrom(node);
            }

            if (node.Expression is MemberAccessExpressionSyntax member)
            {
                var receiver = (ExpressionSyntax)Visit(member.Expression)!;
                var receiverType = semanticModel.GetTypeInfo(member.Expression).Type;
                if (receiver.HasAnnotations(WorkflowDataAnnotationKind) &&
                    TryGetSequenceElementType(receiverType, out var elementType) &&
                    !IsRuntimeSupportedType(elementType) &&
                    method?.ReducedFrom?.ContainingType.ToDisplayString() == "System.Linq.Enumerable")
                {
                    var arguments = node.ArgumentList.Arguments
                        .Select(RewriteWorkflowCollectionArgument)
                        .ToArray();
                    var invocation = SyntaxFactory.ParseExpression(
                        $"{receiver.WithoutTrivia().NormalizeWhitespace()}.Children().{member.Name.WithoutTrivia().NormalizeWhitespace()}({string.Join(", ", arguments.Select(argument => argument.WithoutTrivia().NormalizeWhitespace()))})");
                    var resultType = semanticModel.GetTypeInfo(node).Type;
                    return (!IsRuntimeSupportedType(resultType!) ?
                        invocation.WithAdditionalAnnotations(new SyntaxAnnotation(WorkflowDataAnnotationKind)) :
                        invocation).WithTriviaFrom(node);
                }

                if (member.Name.Identifier.ValueText is "ToObject" or "Value" &&
                    receiver.HasAnnotations(WorkflowDataAnnotationKind))
                {
                    var arguments = node.ArgumentList.Arguments
                        .Select(argument => argument.WithExpression((ExpressionSyntax)Visit(argument.Expression)!));
                    return node.Update(
                        member.Update(receiver, member.OperatorToken, member.Name),
                        node.ArgumentList.WithArguments(SyntaxFactory.SeparatedList(arguments)));
                }

                var rewrittenArguments = node.ArgumentList.Arguments
                    .Select(argument => argument.WithExpression((ExpressionSyntax)Visit(argument.Expression)!));
                return node.Update(
                    member.Update(receiver, member.OperatorToken, member.Name),
                    node.ArgumentList.WithArguments(SyntaxFactory.SeparatedList(rewrittenArguments)));
            }

            return base.VisitInvocationExpression(node);
    }

    public override SyntaxNode? VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
    {
            var parameter = semanticModel.GetDeclaredSymbol(node.Parameter);
            if (parameter == null || IsRuntimeSupportedType(parameter.Type))
                return base.VisitSimpleLambdaExpression(node);

            this.workflowDataParameters.Add(parameter);
            try
            {
                return node.WithBody((CSharpSyntaxNode)Visit(node.Body)!);
            }
            finally
            {
                this.workflowDataParameters.Remove(parameter);
            }
    }

    public override SyntaxNode? VisitParenthesizedLambdaExpression(
            ParenthesizedLambdaExpressionSyntax node)
    {
            var parameters = node.ParameterList.Parameters
                .Select(parameter => semanticModel.GetDeclaredSymbol(parameter))
                .Where(parameter => parameter != null && !IsRuntimeSupportedType(parameter.Type))
                .Cast<IParameterSymbol>()
                .ToArray();
            if (parameters.Length == 0)
                return base.VisitParenthesizedLambdaExpression(node);

            foreach (var parameter in parameters)
                this.workflowDataParameters.Add(parameter);
            try
            {
                return node.WithBody((CSharpSyntaxNode)Visit(node.Body)!);
            }
            finally
            {
                foreach (var parameter in parameters)
                    this.workflowDataParameters.Remove(parameter);
            }
    }

    private ArgumentSyntax RewriteWorkflowCollectionArgument(ArgumentSyntax argument)
    {
            if (argument.Expression is SimpleLambdaExpressionSyntax simpleLambda)
            {
                var parameter = semanticModel.GetDeclaredSymbol(simpleLambda.Parameter);
                if (parameter != null)
                    this.workflowDataParameters.Add(parameter);
                try
                {
                    return argument.WithExpression(
                        simpleLambda.WithBody((CSharpSyntaxNode)Visit(simpleLambda.Body)!));
                }
                finally
                {
                    if (parameter != null)
                        this.workflowDataParameters.Remove(parameter);
                }
            }

            if (argument.Expression is ParenthesizedLambdaExpressionSyntax parenthesizedLambda)
            {
                var parameters = parenthesizedLambda.ParameterList.Parameters
                    .Select(parameter => semanticModel.GetDeclaredSymbol(parameter))
                    .Where(parameter => parameter != null)
                    .Cast<IParameterSymbol>()
                    .ToArray();
                foreach (var parameter in parameters)
                    this.workflowDataParameters.Add(parameter);
                try
                {
                    return argument.WithExpression(
                        parenthesizedLambda.WithBody(
                            (CSharpSyntaxNode)Visit(parenthesizedLambda.Body)!));
                }
                finally
                {
                    foreach (var parameter in parameters)
                        this.workflowDataParameters.Remove(parameter);
                }
            }

            return argument.WithExpression((ExpressionSyntax)Visit(argument.Expression)!);
    }

    private bool TryRewriteWorkflowBoundary(
        MemberAccessExpressionSyntax node,
        out ExpressionSyntax expression)
    {
        var receiverType = semanticModel.GetTypeInfo(node.Expression).Type;
        var memberName = node.Name.Identifier.ValueText;

        if (memberName == "TriggerOutput" &&
            Implements(receiverType, "IOutputWorkflowTrigger", arity: 1))
        {
            expression = WorkflowData("triggerOutputs()");
            return true;
        }

        if (memberName == "TriggerBody" &&
            Implements(receiverType, "IBodyWorkflowTrigger", arity: 1))
        {
            expression = WorkflowData("triggerBody()");
            return true;
        }

        if (memberName == "Parameters" &&
            Implements(receiverType, "IAgentToolContext", arity: 1))
        {
            expression = WorkflowData("agentparameters()");
            return true;
        }

        if (memberName == "Output" &&
            Implements(receiverType, "IOutputWorkflowAction", arity: 1) &&
            TryResolveOperation(node.Expression, out var outputOperationId))
        {
            expression = WorkflowData(
                $"outputs({SymbolDisplay.FormatLiteral(GetOperationMarker(outputOperationId), quote: true)})");
            return true;
        }

        if (memberName == "Body" &&
            Implements(receiverType, "IBodyWorkflowAction", arity: 1) &&
            TryResolveOperation(node.Expression, out var bodyOperationId))
        {
            expression = WorkflowData(
                $"body({SymbolDisplay.FormatLiteral(GetOperationMarker(bodyOperationId), quote: true)})");
            return true;
        }

        expression = null!;
        return false;
    }

    private bool TryResolveOperation(ExpressionSyntax receiver, out string operationId)
    {
        var symbol = semanticModel.GetSymbolInfo(receiver).Symbol;
        var initializers = symbol?.DeclaringSyntaxReferences
            .Select(reference => reference.GetSyntax())
            .Select(declaration => declaration switch
            {
                VariableDeclaratorSyntax variable => variable.Initializer?.Value,
                PropertyDeclarationSyntax property => property.Initializer?.Value,
                _ => null,
            })
            .Where(initializer => initializer != null)
            .Cast<ExpressionSyntax>()
            .ToArray();

        if (initializers == null || initializers.Length == 0)
            initializers = [receiver];

        foreach (var initializer in initializers)
        {
            var operationInvocation = initializer
                .DescendantNodesAndSelf()
                .OfType<InvocationExpressionSyntax>()
                .Select(invocation => (
                    Invocation: invocation,
                    Method: semanticModel.GetSymbolInfo(invocation).Symbol as IMethodSymbol))
                .Where(candidate =>
                    candidate.Method != null &&
                    candidate.Method.Name != "WithName" &&
                    IsWorkflowOperation(candidate.Method.ReturnType))
                .OrderBy(candidate => candidate.Invocation.Span.Length)
                .FirstOrDefault();
            if (operationInvocation.Method == null)
                continue;

            var location = semanticModel.GetInterceptableLocation(operationInvocation.Invocation);
            if (location == null || operationInvocation.Method.IsStatic)
                continue;

            operationId = CreateOperationId(operationInvocation.Invocation);
            this.operationRegistrations[operationId] = new WorkflowOperationRegistration(
                operationId,
                location.GetInterceptsLocationAttributeSyntax(),
                operationInvocation.Method);
            return true;
        }

        operationId = string.Empty;
        return false;
    }

    private ExpressionSyntax RenderWorkflowAccessor(
        ExpressionSyntax access,
        ITypeSymbol? resultType)
    {
        if (resultType == null || IsJToken(resultType) || !IsRuntimeSupportedType(resultType))
        {
            if (resultType?.TypeKind == TypeKind.Enum)
            {
                return SyntaxFactory.ParseExpression(
                    $"{access.WithoutTrivia().NormalizeWhitespace()}.ToObject<string>()");
            }

            return access.WithAdditionalAnnotations(new SyntaxAnnotation(WorkflowDataAnnotationKind));
        }

        return SyntaxFactory.ParseExpression(
            $"{access.WithoutTrivia().NormalizeWhitespace()}.ToObject<{GetTypeName(resultType)}>()");
    }

    private static ExpressionSyntax WorkflowData(string source) =>
        SyntaxFactory.ParseExpression(source)
            .WithAdditionalAnnotations(new SyntaxAnnotation(WorkflowDataAnnotationKind));

    private static bool Implements(
        ITypeSymbol? type,
        string interfaceName,
        int arity)
    {
        if (type == null)
            return false;

        return type is INamedTypeSymbol namedType &&
            IsMatchingInterface(namedType, interfaceName, arity) ||
            type.AllInterfaces.Any(@interface =>
                IsMatchingInterface(@interface, interfaceName, arity));
    }

    private static bool IsMatchingInterface(
        INamedTypeSymbol type,
        string interfaceName,
        int arity) =>
        type.TypeKind == TypeKind.Interface &&
        type.Name == interfaceName &&
        type.Arity == arity &&
        type.ContainingNamespace.ToDisplayString() == "Microsoft.Azure.Workflows.Sdk";

    private static bool IsRuntimeSupportedType(ITypeSymbol type)
    {
        if (IsJToken(type))
            return true;

        if (type.TypeKind == TypeKind.Enum)
            return type.ContainingAssembly?.Name is
                "System.Private.CoreLib" or
                "System.Runtime" or
                "mscorlib";

        if (type is IArrayTypeSymbol arrayType)
            return IsRuntimeSupportedType(arrayType.ElementType);

        if (type is INamedTypeSymbol { IsGenericType: true } namedType &&
            namedType.ContainingNamespace.ToDisplayString() == "System.Collections.Generic" &&
            namedType.Name is
                "IEnumerable" or
                "ICollection" or
                "IList" or
                "IReadOnlyCollection" or
                "IReadOnlyList" or
                "List" or
                "IDictionary" or
                "IReadOnlyDictionary" or
                "Dictionary")
        {
            return namedType.TypeArguments.All(IsRuntimeSupportedType);
        }

        if (type.SpecialType != SpecialType.None)
            return true;

        var fullName = type.ToDisplayString();
        return fullName is
            "System.DateTime" or
            "System.DateTimeOffset" or
            "System.TimeSpan" or
            "System.Guid" or
            "System.Uri" or
            "System.Decimal";
    }

    private static bool IsJToken(ITypeSymbol type)
    {
        for (var current = type; current != null; current = current.BaseType)
        {
            if (current.ToDisplayString() == "Newtonsoft.Json.Linq.JToken")
                return true;
        }

        return false;
    }

    private static bool IsSequenceType(ITypeSymbol? type)
    {
        if (type is IArrayTypeSymbol)
            return true;

        return type?.AllInterfaces.Any(@interface =>
            @interface.OriginalDefinition.SpecialType == SpecialType.System_Collections_Generic_IEnumerable_T) == true;
    }

    private static bool TryGetSequenceElementType(
        ITypeSymbol? type,
        out ITypeSymbol elementType)
    {
        if (type is IArrayTypeSymbol arrayType)
        {
            elementType = arrayType.ElementType;
            return true;
        }

        var enumerableType = type?
            .AllInterfaces
            .FirstOrDefault(@interface =>
                @interface.OriginalDefinition.SpecialType ==
                SpecialType.System_Collections_Generic_IEnumerable_T);
        if (enumerableType != null)
        {
            elementType = enumerableType.TypeArguments[0];
            return true;
        }

        elementType = null!;
        return false;
    }

    private static bool IsWorkflowOperation(ITypeSymbol type) =>
        type.AllInterfaces.Any(@interface =>
            @interface.Name == "IWorkflowOperation" &&
            @interface.ContainingNamespace.ToDisplayString() == "Microsoft.Azure.Workflows.Sdk") ||
        type.Name == "IWorkflowOperation" &&
        type.ContainingNamespace.ToDisplayString() == "Microsoft.Azure.Workflows.Sdk";

    private static bool IsNumericType(ITypeSymbol? type) =>
        type?.SpecialType is
            SpecialType.System_Byte or
            SpecialType.System_SByte or
            SpecialType.System_Int16 or
            SpecialType.System_UInt16 or
            SpecialType.System_Int32 or
            SpecialType.System_UInt32 or
            SpecialType.System_Int64 or
            SpecialType.System_UInt64;

    private static string GetJsonPropertyName(
        IPropertySymbol? property,
        string fallback)
    {
        var attribute = property?.GetAttributes().FirstOrDefault(candidate =>
            candidate.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute");
        if (attribute == null)
            return fallback;

        if (attribute.ConstructorArguments.Length > 0 &&
            attribute.ConstructorArguments[0].Value is string constructorName &&
            !string.IsNullOrEmpty(constructorName))
        {
            return constructorName;
        }

        var namedName = attribute.NamedArguments.FirstOrDefault(argument =>
            argument.Key == "PropertyName").Value.Value as string;
        return string.IsNullOrEmpty(namedName) ? fallback : namedName!;
    }

    private static string GetEnumWireValue(IFieldSymbol enumMember)
    {
        var attribute = enumMember.GetAttributes().FirstOrDefault(candidate =>
            candidate.AttributeClass?.ToDisplayString() ==
            "System.Runtime.Serialization.EnumMemberAttribute");
        var value = attribute?.NamedArguments.FirstOrDefault(argument =>
            argument.Key == "Value").Value.Value as string;
        return string.IsNullOrEmpty(value) ? enumMember.Name : value!;
    }

    private static string GetTypeName(ITypeSymbol type) =>
        type.ToDisplayString(
            SymbolDisplayFormat.FullyQualifiedFormat
                .WithMiscellaneousOptions(
                    SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                    SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                    SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier));

    private static string GetWorkflowFunctionName(string methodName) =>
        methodName switch
        {
            "ToJson" => "json",
            "Actions" => "actions",
            "Trigger" => "trigger",
            "ListCallbackUrl" => "listCallbackUrl",
            "AppSetting" => "appsetting",
            "Action" => "action",
            "CurrentRequest" => "currentRequest",
            "Binary" => "binary",
            "Base64ToBinary" => "base64ToBinary",
            "DataUriToBinary" => "dataUriToBinary",
            "MultipartBody" => "multipartBody",
            "FormDataValue" => "formDataValue",
            "FormDataMultiValues" => "formDataMultiValues",
            "TriggerMultipartBody" => "triggerMultipartBody",
            "TriggerFormDataValue" => "triggerFormDataValue",
            "TriggerFormDataMultiValues" => "triggerFormDataMultiValues",
            _ => throw new NotSupportedException(
                $"Workflow function '{methodName}' is not mapped."),
        };

    private string CreateOperationId(InvocationExpressionSyntax invocation)
    {
        var value = $"{semanticModel.SyntaxTree.FilePath}:{invocation.SpanStart}";
        var hash = 14695981039346656037UL;
        foreach (var character in value)
        {
            hash ^= character;
            hash *= 1099511628211UL;
        }

        return hash.ToString("x16");
    }

    private static string GetOperationMarker(string operationId) =>
        $"__logicapps_operation_{operationId}__";

    private static string GetCaptureMarker(string capturedValueName) =>
        $"__logicapps_capture_{capturedValueName}__";

    private static ExpressionSyntax RenderConstant(object? value)
    {
        return value switch
        {
            null => SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression),
            string text => SyntaxFactory.LiteralExpression(
                SyntaxKind.StringLiteralExpression,
                SyntaxFactory.Literal(text)),
            char character => SyntaxFactory.LiteralExpression(
                SyntaxKind.CharacterLiteralExpression,
                SyntaxFactory.Literal(character)),
            bool boolean => SyntaxFactory.LiteralExpression(
                boolean ? SyntaxKind.TrueLiteralExpression : SyntaxKind.FalseLiteralExpression),
            _ => SyntaxFactory.ParseExpression(
                Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture) ?? "null"),
        };
    }
}

internal sealed class WorkflowOperationRegistration
{
    public WorkflowOperationRegistration(
        string operationId,
        string attributeSyntax,
        IMethodSymbol method)
    {
        this.OperationId = operationId;
        this.AttributeSyntax = attributeSyntax;
        this.Method = method;
    }

    public string OperationId { get; }

    public string AttributeSyntax { get; }

    public IMethodSymbol Method { get; }
}

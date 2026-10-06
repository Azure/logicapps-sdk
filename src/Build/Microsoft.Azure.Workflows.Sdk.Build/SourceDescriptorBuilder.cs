// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using System.Text.Json;
using static ExpressionCompilationTransformer;

internal sealed class SourceDescriptorBuilder(
    SemanticModel model,
    LambdaExpressionSyntax lambda,
    int callPosition,
    WorkflowDependencyCollector dependencies)
{
    private string? destinationName;

    private static string GetQualifiedTypeName(ITypeSymbol type) =>
        type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

    private static string BuildBindingTypeExpression(ITypeSymbol type) =>
        ContainsTypeParameter(type)
            ? $"{Runtime}SourceExpression.TypeName(typeof({GetQualifiedTypeName(type)}))"
            : Quote(GetQualifiedTypeName(type));

    public string BuildDescriptorSource(ITypeSymbol resultType, IParameterSymbol destinationParameter)
    {
        var destinationAttribute = destinationParameter.GetAttributes().FirstOrDefault(a =>
            a.AttributeClass?.ContainingAssembly.Name == SdkAssembly &&
            a.AttributeClass.ToDisplayString() == SdkAssembly + ".WorkflowDestinationAttribute");
        if (destinationAttribute?.ConstructorArguments.FirstOrDefault().Value is string destinationSchema)
        {
            dependencies.RecordType(
                model.Compilation.GetTypeByMetadataName(SdkAssembly + ".WorkflowWireRuntime"), lambda);
            try
            {
                using var schema = JsonDocument.Parse(destinationSchema);
                destinationName = schema.RootElement.GetProperty("destination").GetString();
            }
            catch (JsonException exception) { throw Error("WFBUILD009", "Invalid destination schema: " + exception.Message, lambda); }
            catch (KeyNotFoundException) { throw Error("WFBUILD009", "Destination schema does not identify its destination.", lambda); }
        }
        if (!lambda.AsyncKeyword.IsKind(SyntaxKind.None) || lambda.Body is BlockSyntax)
        {
            throw Error("WFBUILD006",
                "Block and async workflow expressions require a verified execution-host transport. This SDK supports expression bodies only.", lambda);
        }

        if (resultType is INamedTypeSymbol named &&
            named.ContainingNamespace.ToDisplayString() == "System.Threading.Tasks" &&
            named.Name is "Task" or "ValueTask")
        {
            throw Error("WFBUILD006",
                "Task-returning workflow expressions require a verified execution-host transport; a Task cannot be serialized as its awaited result.", lambda);
        }

        return BuildExpressionDescriptorSource((ExpressionSyntax)lambda.Body, resultType);
    }

    private string BuildExpressionDescriptorSource(ExpressionSyntax body, ITypeSymbol resultType)
    {
        var actualType = model.GetTypeInfo(body).Type;
        if (destinationName != null && actualType != null && resultType.SpecialType == SpecialType.System_Object &&
            actualType.SpecialType != SpecialType.System_Object && actualType.TypeKind != TypeKind.Error)
            return $"{Runtime}SourceExpression.Box(1, {BuildExpressionDescriptorSource(body, actualType)})";
        if (destinationName != null && actualType != null && IsStreamType(actualType) &&
            model.GetSymbolInfo(body).Symbol is ILocalSymbol or IParameterSymbol)
            return $"{Runtime}SourceExpression.Unsupported<{GetQualifiedTypeName(resultType)}>(1, {Quote(destinationName)}, {Quote(GetQualifiedTypeName(actualType))})";
        var conversion = model.ClassifyConversion(body, resultType);
        if (conversion.IsUserDefined && conversion.IsImplicit &&
            conversion.MethodSymbol is { Name: "op_Implicit", ContainingAssembly.Name: "Newtonsoft.Json" } tokenConversion &&
            tokenConversion.ContainingType.ToDisplayString() == "Newtonsoft.Json.Linq.JToken")
        {
            var sourceType = model.GetTypeInfo(body).Type!;
            return $"{Runtime}SourceExpression.Token(1, {BuildExpressionDescriptorSource(body, sourceType)})";
        }

        if (conversion.IsUserDefined)
        {
            var converted = BuildNativeSource(body);
            converted.Segments[0] = "(" + GetQualifiedTypeName(resultType) + ")(" + converted.Segments[0];
            converted.Segments[^1] += ")";
            return BuildDescriptorFactoryCall(resultType, "native", converted.Segments, converted.Bindings, body);
        }

        var constant = model.GetConstantValue(body);
        if (constant.HasValue)
        {
            var sourceType = model.GetTypeInfo(body).Type ?? resultType;
            dependencies.RecordType(sourceType, body);
            var expression = "((" + GetQualifiedTypeName(sourceType) + ")" + FormatConstantLiteral(constant.Value) + ")";
            return $"{Runtime}SourceExpression.Literal<{GetQualifiedTypeName(resultType)}>(1, {expression})";
        }

        if (body is CastExpressionSyntax cast && resultType.SpecialType == SpecialType.System_Object &&
            model.GetConstantValue(cast.Expression).HasValue)
        {
            return $"{Runtime}SourceExpression.Literal<{GetQualifiedTypeName(resultType)}>(1, {BuildNativeSource(body).UnboundSource})";
        }

        if (body is ObjectCreationExpressionSyntax uri &&
            model.GetTypeInfo(uri).Type?.ToDisplayString() == "System.Uri" &&
            uri.ArgumentList?.Arguments.Count == 1 &&
            model.GetConstantValue(uri.ArgumentList.Arguments[0].Expression) is { HasValue: true, Value: string uriText })
        {
            return $"{Runtime}SourceExpression.Literal<{GetQualifiedTypeName(resultType)}>(1, new global::System.Uri({Quote(uriText)}))";
        }

        if (model.GetSymbolInfo(body).Symbol is IPropertySymbol { IsStatic: true } httpMethod &&
            httpMethod.ContainingType.ToDisplayString() == "System.Net.Http.HttpMethod" &&
            httpMethod.Name is "Get" or "Post" or "Put" or "Delete" or "Head" or "Options" or "Trace" or "Patch")
        {
            return $"{Runtime}SourceExpression.Literal<{GetQualifiedTypeName(resultType)}>(1, global::System.Net.Http.HttpMethod.{httpMethod.Name})";
        }

        if (IsJsonIntrinsicCall(body))
        {
            return BuildJsonDescriptorSource((InvocationExpressionSyntax)body, resultType);
        }

        if (TryBuildJsonNavigation(body, out _, out _))
        {
            return BuildWorkflowValueDescriptorSource(body, resultType);
        }

        if (TryBuildCaptureBinding(body, out var capture))
        {
            return BuildDescriptorFactoryCall(resultType, "capture", ["", ""], [capture], body);
        }

        if (TryBuildSchemaModelDescriptorSource(body, resultType, out var schemaModel))
        {
            return schemaModel;
        }

        if (TryGetCompleteConnectorModelMembers(body, out var modelMembers))
        {
            return BuildObjectDescriptorSource(resultType, modelMembers, body);
        }

        if (IsAgentMessageCreation(body) && body is ObjectCreationExpressionSyntax message)
        {
            var members = message.Initializer!.Expressions.Select(e =>
            {
                if (e is not AssignmentExpressionSyntax { Left: IdentifierNameSyntax name } assignment)
                {
                    throw Error("WFBUILD003", "Agent messages require explicit property assignments.", e);
                }

                var wireName = name.Identifier.ValueText switch
                {
                    "Role" => "role",
                    "Content" => "content",
                    _ => throw Error("WFBUILD003", "Unknown agent message property.", name),
                };
                return (wireName, assignment.Right);
            });
            return BuildObjectDescriptorSource(resultType, members, body);
        }

        if (body is AnonymousObjectCreationExpressionSyntax anonymous &&
            anonymous.Initializers.All(i => CanBuildStructuralDescriptor(i.Expression)))
        {
            return BuildObjectDescriptorSource(resultType, anonymous.Initializers.Select(i =>
                (i.NameEquals?.Name.Identifier.ValueText ??
                 (i.Expression as IdentifierNameSyntax)?.Identifier.ValueText ??
                 (i.Expression as MemberAccessExpressionSyntax)?.Name.Identifier.ValueText ??
                 throw Error("WFBUILD003", "Cannot resolve structural member name.", i),
                 i.Expression)), body);
        }

        if (body is ArrayCreationExpressionSyntax { Initializer: { } initializer } &&
            initializer.Expressions.All(CanBuildStructuralDescriptor))
        {
            return BuildArrayDescriptorSource(resultType, initializer.Expressions, body);
        }

        if (body is ImplicitArrayCreationExpressionSyntax array && array.Initializer.Expressions.All(CanBuildStructuralDescriptor))
        {
            return BuildArrayDescriptorSource(resultType, array.Initializer.Expressions, body);
        }

        if (body is ObjectCreationExpressionSyntax dictionary &&
            model.GetTypeInfo(body).Type is INamedTypeSymbol dictionaryType &&
            dictionaryType.OriginalDefinition.ToDisplayString() == "System.Collections.Generic.Dictionary<TKey, TValue>" &&
            dictionaryType.TypeArguments[0].SpecialType == SpecialType.System_String &&
            (dictionary.ArgumentList == null || dictionary.ArgumentList.Arguments.Count == 0) && dictionary.Initializer != null)
        {
            var entries = new List<(string, ExpressionSyntax)>();
            foreach (var element in dictionary.Initializer.Expressions)
            {
                var pair = element as InitializerExpressionSyntax;
                var assignment = element as AssignmentExpressionSyntax;
                var key = pair?.Expressions.FirstOrDefault() ??
                    (assignment?.Left as ImplicitElementAccessSyntax)?.ArgumentList.Arguments.SingleOrDefault()?.Expression;
                var value = pair?.Expressions.LastOrDefault() ?? assignment?.Right;
                if (key == null || value == null || model.GetConstantValue(key).Value is not string name)
                {
                    throw Error("WFBUILD003", "Static dictionaries require constant string keys.", element);
                }

                entries.Add((name, value));
            }

            return BuildObjectDescriptorSource(resultType, entries, body);
        }

        if ((resultType.TypeKind == TypeKind.Enum ||
             resultType is INamedTypeSymbol { OriginalDefinition.SpecialType: SpecialType.System_Nullable_T } nullableEnum &&
             nullableEnum.TypeArguments[0].TypeKind == TypeKind.Enum) && FindConditionalEnumExpression(body) is { } conditionalResult)
        {
            var original = BuildNativeSource(body);
            var wire = BuildNativeSource(conditionalResult, enumWireType: resultType);
            return $"{Runtime}SourceExpression.Enum(1, " +
                BuildDescriptorFactoryCall(resultType, "native", original.Segments, original.Bindings, body) + ", " +
                BuildDescriptorFactoryCall(model.Compilation.GetSpecialType(SpecialType.System_String), "native", wire.Segments, wire.Bindings, body) + ")";
        }

        return BuildNativeDescriptorSource(body, resultType);
    }

    private string BuildObjectDescriptorSource(ITypeSymbol type, IEnumerable<(string Name, ExpressionSyntax Value)> entries, ExpressionSyntax body)
    {
        var members = entries.ToArray();
        var source = BuildNativeSource(body);
        return $"{Runtime}SourceExpression.Object{FormatTypeArgumentList(type)}(1, new string[] {{ {string.Join(", ", members.Select(m => Quote(m.Name)))} }}, " +
            $"new global::System.Delegate[] {{ {string.Join(", ", members.Select(m => BuildExpressionDescriptorSource(m.Value, GetStructuralResultType(m.Value))))} }}" +
            ", preserveSource: true, nativeSource: " + BuildDescriptorFactoryCall(type, "native", source.Segments, source.Bindings, body) + ")";
    }

    private string BuildArrayDescriptorSource(ITypeSymbol type, IEnumerable<ExpressionSyntax> values, ExpressionSyntax body)
    {
        var source = BuildNativeSource(body);
        return $"{Runtime}SourceExpression.Array{FormatTypeArgumentList(type)}(1, new global::System.Delegate[] {{ " +
            string.Join(", ", values.Select(v => BuildExpressionDescriptorSource(v, GetStructuralResultType(v)))) +
            " }, preserveSource: true, nativeSource: " + BuildDescriptorFactoryCall(type, "native", source.Segments, source.Bindings, body) + ")";
    }

    private ITypeSymbol GetStructuralResultType(ExpressionSyntax value)
    {
        var type = model.GetTypeInfo(value).Type;
        return type == null || ContainsAnonymousType(type)
            ? model.Compilation.GetSpecialType(SpecialType.System_Object)
            : type;
    }

    private bool CanBuildStructuralDescriptor(ExpressionSyntax expression) =>
        model.GetConstantValue(expression).HasValue ||
        IsJsonIntrinsicCall(expression) ||
        TryBuildJsonNavigation(expression, out _, out _) ||
        TryBuildCaptureBinding(expression, out _) ||
        IsSchemaModelCreation(expression) ||
        TryGetCompleteConnectorModelMembers(expression, out _) ||
        IsAgentMessageCreation(expression) ||
        expression is InterpolatedStringExpressionSyntax interpolation && IsReferenceInterpolation(interpolation) ||
        expression is AnonymousObjectCreationExpressionSyntax anonymous && anonymous.Initializers.All(i => CanBuildStructuralDescriptor(i.Expression)) ||
        expression is ImplicitArrayCreationExpressionSyntax array && array.Initializer.Expressions.All(CanBuildStructuralDescriptor);

    private static bool IsStreamType(ITypeSymbol type) =>
        type.ToDisplayString() == "System.IO.Stream" || type is INamedTypeSymbol { BaseType: { } parent } && IsStreamType(parent);

    private bool IsSchemaModelCreation(ExpressionSyntax expression) =>
        expression is ObjectCreationExpressionSyntax &&
        model.GetTypeInfo(expression).Type?.GetAttributes().Any(IsModelSchemaAttribute) == true;

    private static bool IsModelSchemaAttribute(AttributeData attribute) =>
        attribute.AttributeClass?.ContainingAssembly.Name == SdkAssembly &&
        attribute.AttributeClass.ToDisplayString() == SdkAssembly + ".WorkflowModelSchemaAttribute";

    private bool TryBuildSchemaModelDescriptorSource(ExpressionSyntax expression, ITypeSymbol resultType, out string descriptor)
    {
        descriptor = "";
        if (expression is not ObjectCreationExpressionSyntax creation ||
            model.GetTypeInfo(expression).Type is not INamedTypeSymbol type)
            return false;
        var attributes = type.GetAttributes().Where(IsModelSchemaAttribute).ToArray();
        if (attributes.Length == 0) return false;
        if (attributes.Length != 1 || attributes[0].ConstructorArguments.Length != 2 ||
            attributes[0].ConstructorArguments[0].Value is not 1 ||
            attributes[0].ConstructorArguments[1].Value is not string schemaText)
            throw Error("WFBUILD009", "Conflicting or unsupported authoritative model metadata versions for " + type.Name + ".", expression);
        if (creation.ArgumentList?.Arguments.Count > 0 || type.BaseType?.SpecialType != SpecialType.System_Object ||
            type.GetMembers().OfType<IFieldSymbol>().Any(f => !f.IsStatic && !f.IsImplicitlyDeclared))
            throw Error("WFBUILD009", "Schema models require parameterless structural initialization and explicit property metadata.", expression);
        try
        {
            using var schema = JsonDocument.Parse(schemaText);
            var properties = type.GetMembers().OfType<IPropertySymbol>().Where(p => !p.IsStatic).ToArray();
            WorkflowSchemaGenerator.ValidateModelSchema(schema.RootElement,
                properties.Select(p => p.Type.Name).Append(type.Name));
            if (properties.Any(p => !IsAutoProperty(p)))
                throw Error("WFBUILD009", "Schema models cannot require custom getters or setters.", expression);
            var assignments = new Dictionary<string, ExpressionSyntax>(StringComparer.Ordinal);
            foreach (var initializer in creation.Initializer?.Expressions ?? default)
            {
                if (initializer is not AssignmentExpressionSyntax assignment ||
                    !assignment.IsKind(SyntaxKind.SimpleAssignmentExpression) ||
                    model.GetSymbolInfo(assignment.Left).Symbol is not IPropertySymbol property ||
                    !properties.Contains(property, SymbolEqualityComparer.Default) ||
                    !assignments.TryAdd(property.Name, assignment.Right))
                    throw Error("WFBUILD009", "Schema model initializers require unique direct property assignments.", initializer);
            }
            var names = new List<string>();
            var values = new List<string>();
            var matched = new HashSet<string>(StringComparer.Ordinal);
            foreach (var member in schema.RootElement.GetProperty("properties").EnumerateObject())
            {
                var clrName = member.Value.GetProperty("clrName").GetString()!;
                var property = properties.SingleOrDefault(p => p.Name == clrName);
                if (property == null || !matched.Add(clrName))
                    throw Error("WFBUILD009", "Schema property metadata is missing or conflicting: " + clrName, expression);
                var declaredClrType = member.Value.GetProperty("clrType").GetString()!;
                var expectedType = model.GetSpeculativeTypeInfo(expression.SpanStart,
                    SyntaxFactory.ParseTypeName(declaredClrType), SpeculativeBindingOption.BindAsTypeOrNamespace).Type;
                if (!SymbolEqualityComparer.Default.Equals(expectedType, property.Type) &&
                    !(property.Type.Name == declaredClrType && property.Type.GetAttributes().Any(IsModelSchemaAttribute)))
                    throw Error("WFBUILD009", "Schema and generated CLR property types conflict for " + clrName, expression);
                var wireNames = property.GetAttributes().Where(a =>
                    a.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute" &&
                    a.AttributeClass.ContainingAssembly.Name == "Newtonsoft.Json").ToArray();
                if (wireNames.Length != 1 || wireNames[0].ConstructorArguments.FirstOrDefault().Value as string != member.Name)
                    throw Error("WFBUILD009", "Schema and generated CLR wire names conflict for " + clrName, expression);
                if (assignments.TryGetValue(clrName, out var value))
                {
                    names.Add(member.Name);
                    values.Add(BuildExpressionDescriptorSource(value, property.Type));
                }
                else if (member.Value.TryGetProperty("default", out var defaultValue))
                {
                    names.Add(member.Name);
                    var literal = WorkflowSchemaGenerator.FormatModelDefaultLiteral(defaultValue, declaredClrType, member.Name);
                    values.Add($"{Runtime}SourceExpression.Literal<{GetQualifiedTypeName(property.Type)}>(1, {literal})");
                }
                else if (!member.Value.GetProperty("optional").GetBoolean())
                    throw Error("WFBUILD009", "Required schema member is missing: " + member.Name, expression);
            }
            if (matched.Count != properties.Length)
                throw Error("WFBUILD009", "The model contains properties without authoritative schema metadata.", expression);
            var native = BuildNativeSource(expression);
            descriptor = $"{Runtime}SourceExpression.Model<{GetQualifiedTypeName(resultType)}>(1, {Quote(schemaText)}, " +
                $"new string[] {{ {string.Join(", ", names.Select(Quote))} }}, new global::System.Delegate[] {{ {string.Join(", ", values)} }}, " +
                BuildDescriptorFactoryCall(resultType, "native", native.Segments, native.Bindings, expression) + ")";
            return true;
        }
        catch (JsonException exception) { throw Error("WFBUILD009", "Invalid model schema: " + exception.Message, expression); }
        catch (InvalidDataException exception) { throw Error("WFBUILD009", exception.Message, expression); }
    }

    private bool IsJsonIntrinsicCall(ExpressionSyntax expression) =>
        expression is InvocationExpressionSyntax { ArgumentList.Arguments.Count: 1 } &&
        model.GetSymbolInfo(expression).Symbol is IMethodSymbol { IsStatic: true, Name: "ToJson" } method &&
        method.ContainingAssembly.Name == SdkAssembly &&
        method.ContainingType.ToDisplayString() == SdkAssembly + ".WorkflowFunctions";

    private string BuildJsonDescriptorSource(InvocationExpressionSyntax expression, ITypeSymbol resultType, bool recordDependency = true)
    {
        if (recordDependency) dependencies.RecordType(resultType, expression);
        return $"{Runtime}SourceExpression.Json<{GetQualifiedTypeName(resultType)}>(1, " +
            BuildExpressionDescriptorSource(expression.ArgumentList.Arguments[0].Expression,
                model.Compilation.GetSpecialType(SpecialType.System_String)) + ")";
    }

    private bool TryGetCompleteConnectorModelMembers(ExpressionSyntax expression, out List<(string Name, ExpressionSyntax Value)> members)
    {
        members = [];
        if (expression is not ObjectCreationExpressionSyntax { Initializer: { } initializer } creation ||
            creation.ArgumentList?.Arguments.Count > 0 ||
            model.GetTypeInfo(expression).Type is not INamedTypeSymbol type ||
            type.ContainingAssembly.Name != SdkAssembly ||
            type.BaseType?.SpecialType != SpecialType.System_Object ||
            !(type.ContainingNamespace.ToDisplayString().StartsWith(SdkAssembly + ".Connectors.", StringComparison.Ordinal) ||
              type.ContainingNamespace.ToDisplayString().StartsWith(SdkAssembly + ".ServiceProviders.", StringComparison.Ordinal)) ||
            type.GetAttributes().Length != 0 ||
            type.GetMembers().OfType<IFieldSymbol>().Any(f => !f.IsStatic && f.DeclaredAccessibility == Accessibility.Public))
        {
            return false;
        }

        var properties = type.GetMembers().OfType<IPropertySymbol>()
            .Where(p => !p.IsStatic && p.DeclaredAccessibility == Accessibility.Public).ToArray();
        // Complete generated DTO initializers do not require inferred schema defaults.
        if (properties.Length != initializer.Expressions.Count || properties.Any(p => !IsAutoProperty(p)))
        {
            return false;
        }

        foreach (var item in initializer.Expressions)
        {
            if (item is not AssignmentExpressionSyntax assignment || !assignment.IsKind(SyntaxKind.SimpleAssignmentExpression) ||
                model.GetSymbolInfo(assignment.Left).Symbol is not IPropertySymbol property ||
                !properties.Contains(property, SymbolEqualityComparer.Default))
            {
                return false;
            }

            var attributes = property.GetAttributes();
            if (attributes.Length != 1 ||
                attributes[0].AttributeClass?.ToDisplayString() != "Newtonsoft.Json.JsonPropertyAttribute" ||
                attributes[0].AttributeClass?.ContainingAssembly.Name != "Newtonsoft.Json" ||
                attributes[0].NamedArguments.Length != 0 ||
                attributes[0].ConstructorArguments.FirstOrDefault().Value is not string wireName)
            {
                return false;
            }

            members.Add((wireName, assignment.Right));
        }

        return true;
    }

    private bool IsAgentMessageCreation(ExpressionSyntax expression) =>
        expression is ObjectCreationExpressionSyntax { Initializer: not null } created &&
        (created.ArgumentList == null || created.ArgumentList.Arguments.Count == 0) &&
        model.GetTypeInfo(created).Type is { } type && type.ContainingAssembly.Name == SdkAssembly &&
        type.ToDisplayString() == SdkAssembly + ".AgentPromptMessage";

    private string BuildNativeDescriptorSource(ExpressionSyntax body, ITypeSymbol resultType)
    {
        var native = BuildNativeSource(body);
        return BuildDescriptorFactoryCall(resultType, "native", native.Segments, native.Bindings, body);
    }

    private string BuildWorkflowValueDescriptorSource(ExpressionSyntax body, ITypeSymbol resultType)
    {
        if (!TryBuildJsonNavigation(body, out var binding, out var suffix))
            throw Error("WFBUILD003", "Workflow value is not a recognized JSON reference path.", body);
        var tokenType = model.Compilation.GetTypeByMetadataName("Newtonsoft.Json.Linq.JToken")!;
        var wire = BuildDescriptorFactoryCall(tokenType, "native", ["", suffix], [binding], body);
        return $"{Runtime}SourceExpression.Value(1, {BuildNativeDescriptorSource(body, resultType)}, {wire})";
    }

    private static string BuildDescriptorFactoryCall(ITypeSymbol resultType, string kind, IEnumerable<string> segments, IEnumerable<string> bindings,
        ExpressionSyntax body) =>
        $"{Runtime}SourceExpression.Create{FormatTypeArgumentList(resultType)}(1, {Quote(kind)}, " +
        $"new string[] {{ {string.Join(", ", segments.Select(Quote))} }}, " +
        $"new {Runtime}SourceBinding[] {{ {string.Join(", ", bindings)} }}" +
        BuildTypeWitnessArgument(resultType, body) + ")";

    private static string FormatTypeArgumentList(ITypeSymbol type) => ContainsAnonymousType(type) ? "" : "<" + GetQualifiedTypeName(type) + ">";

    private static string BuildTypeWitnessArgument(ITypeSymbol type, ExpressionSyntax body) =>
        ContainsAnonymousType(type) ? ", typeWitness: () => " + body : "";

    private static bool ContainsAnonymousType(ITypeSymbol type) =>
        type.IsAnonymousType ||
        type is IArrayTypeSymbol array && ContainsAnonymousType(array.ElementType) ||
        type is INamedTypeSymbol named && named.TypeArguments.Any(ContainsAnonymousType);

    private bool IsReferenceInterpolation(InterpolatedStringExpressionSyntax source)
    {
        var holes = source.Contents.OfType<InterpolationSyntax>().ToArray();
        return holes.Length != 0 && holes.All(hole => hole.AlignmentClause == null && hole.FormatClause == null &&
            TryBuildJsonNavigation(hole.Expression, out _, out _));
    }

    private bool IsCapturedObjectPath(ExpressionSyntax expression)
    {
        var node = expression;
        while (node is MemberAccessExpressionSyntax access)
        {
            if (TryBuildWorkflowBinding(node, out _))
            {
                return false;
            }

            node = access.Expression;
        }

        var symbol = model.GetSymbolInfo(node).Symbol;
        var type = symbol switch
        {
            ILocalSymbol local => local.Type,
            IParameterSymbol parameter => parameter.Type,
            _ => null,
        };
        return type != null && !IsDeclaredInsideLambda(symbol!) && !IsSupportedCaptureType(type);
    }

    private bool TryBuildJsonNavigation(ExpressionSyntax node, out string binding, out string suffix)
    {
        suffix = "";
        if (TryBuildWorkflowBinding(node, out binding, jsonValue: true))
        {
            return true;
        }

        if (node is ElementAccessExpressionSyntax element &&
            element.ArgumentList.Arguments.Count == 1 &&
            model.GetConstantValue(element.ArgumentList.Arguments[0].Expression) is { HasValue: true, Value: string key } &&
            TryBuildJsonNavigation(element.Expression, out binding, out var parent))
        {
            suffix = parent + "[" + Quote(key) + "]";
            return true;
        }

        if (node is MemberAccessExpressionSyntax member &&
            model.GetSymbolInfo(member).Symbol is IPropertySymbol property &&
            property.Name != "Length" && property.Name != "Count" &&
            (IsAutoProperty(property) || property.ContainingType.IsAnonymousType) &&
            property.ContainingType.SpecialType == SpecialType.None &&
            !property.ContainingNamespace.ToDisplayString().StartsWith("System", StringComparison.Ordinal) &&
            !property.ContainingNamespace.ToDisplayString().StartsWith("Newtonsoft", StringComparison.Ordinal) &&
            TryBuildJsonNavigation(member.Expression, out binding, out var parentSuffix))
        {
            var jsonName = property.GetAttributes().FirstOrDefault(a =>
                a.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute")
                ?.ConstructorArguments.FirstOrDefault().Value as string ?? property.Name;
            suffix = parentSuffix + "[" + Quote(jsonName) + "]";
            return true;
        }

        binding = "";
        return false;
    }

    private bool ConsumesJsonValue(ExpressionSyntax expression, out bool formatting)
    {
        formatting = true;
        if (model.GetConversion(expression).IsUserDefined) return false;
        SyntaxNode value = expression;
        var arrayElement = false;
        while (true)
        {
            switch (value.Parent)
            {
                case ParenthesizedExpressionSyntax parenthesized:
                    value = parenthesized;
                    continue;
                case CastExpressionSyntax cast when model.GetTypeInfo(cast.Type).Type?.SpecialType == SpecialType.System_Object &&
                    !model.ClassifyConversion(cast.Expression, model.GetTypeInfo(cast.Type).Type!).IsUserDefined:
                    value = cast;
                    continue;
                case ConditionalExpressionSyntax conditional when value != conditional.Condition:
                    value = conditional;
                    continue;
                case BinaryExpressionSyntax coalesce when coalesce.IsKind(SyntaxKind.CoalesceExpression):
                    value = coalesce;
                    continue;
                case SwitchExpressionArmSyntax arm when value == arm.Expression:
                    value = arm.Parent!;
                    continue;
                case InitializerExpressionSyntax initializer when
                    initializer.Parent is ExpressionSyntax array &&
                    model.GetTypeInfo(array).Type is IArrayTypeSymbol { ElementType.SpecialType: SpecialType.System_Object }:
                    arrayElement = true;
                    value = array;
                    continue;
            }
            break;
        }

        if (value.Parent is ArgumentSyntax argument &&
            argument.Parent?.Parent is InvocationExpressionSyntax invocation &&
            model.GetSymbolInfo(invocation).Symbol is IMethodSymbol method)
        {
            var parameter = (model.GetOperation(argument) as IArgumentOperation)?.Parameter ??
                method.Parameters.LastOrDefault(p => p.IsParams &&
                    invocation.ArgumentList.Arguments.IndexOf(argument) >= p.Ordinal);
            if (parameter == null) return false;
            var owner = method.ContainingType.ToDisplayString();
            if (parameter.Ordinal == 0 &&
                (owner == SdkAssembly + ".WorkflowWireRuntime" && method.Name == "ToCompactJson" ||
                 owner == "Newtonsoft.Json.JsonConvert" && method.Name == "SerializeObject" && method.Parameters.Length == 1))
            {
                formatting = false;
                return true;
            }

            var objectParams = parameter.Type is IArrayTypeSymbol { ElementType.SpecialType: SpecialType.System_Object } ||
                parameter.Type is INamedTypeSymbol { Name: "ReadOnlySpan", TypeArguments.Length: 1 } span &&
                span.ContainingNamespace.ToDisplayString() == "System" &&
                span.TypeArguments[0].SpecialType == SpecialType.System_Object;
            var objectArgument = parameter.Type.SpecialType == SpecialType.System_Object ||
                parameter.IsParams && objectParams &&
                (arrayElement || !model.ClassifyConversion(argument.Expression, parameter.Type).IsImplicit);
            return objectArgument && UsesDefaultObjectFormatting(model.GetTypeInfo(expression).Type) &&
                (owner == "string" && method.Name is "Format" or "Concat" or "Join" ||
                 owner == "System.Convert" && method.Name == "ToString" ||
                 owner == "System.Text.StringBuilder" && method.Name is "Append" or "AppendFormat");
        }

        if (!UsesDefaultObjectFormatting(model.GetTypeInfo(expression).Type))
            return false;

        return value.Parent is InterpolationSyntax interpolation &&
                model.GetTypeInfo((ExpressionSyntax)interpolation.Parent!).ConvertedType?.SpecialType is
                    SpecialType.System_String or SpecialType.System_Object ||
            value.Parent is BinaryExpressionSyntax binary && binary.IsKind(SyntaxKind.AddExpression) &&
                model.GetOperation(binary) is IBinaryOperation { OperatorMethod: null, Type.SpecialType: SpecialType.System_String } ||
            value.Parent is MemberAccessExpressionSyntax member && member.Expression == value &&
                member.Parent is InvocationExpressionSyntax call && call.ArgumentList.Arguments.Count == 0 &&
                model.GetSymbolInfo(call).Symbol is IMethodSymbol
                {
                    Name: "ToString", ContainingType.SpecialType: SpecialType.System_Object,
                };
    }

    private static bool UsesDefaultObjectFormatting(ITypeSymbol? type)
    {
        if (type is ITypeParameterSymbol) return true;
        if (type is null || !type.IsReferenceType || type.TypeKind == TypeKind.Dynamic)
            return false;
        if (type.AllInterfaces.Any(i => i.ToDisplayString() == "System.IFormattable"))
            return false;
        for (var current = type; current != null && current.SpecialType != SpecialType.System_Object; current = current.BaseType)
        {
            if (current.GetMembers("ToString").OfType<IMethodSymbol>().Any(m =>
                !m.IsStatic && m.Arity == 0 && m.Parameters.Length == 0 && m.DeclaredAccessibility == Accessibility.Public))
                return false;
        }
        return true;
    }

    private bool TryBuildWorkflowBinding(ExpressionSyntax expression, out string binding, bool jsonValue = false)
    {
        binding = "";
        if (expression is IdentifierNameSyntax &&
            model.GetSymbolInfo(expression).Symbol is IParameterSymbol item && IsForEachItemParameter(item))
        {
            ValidateHandleReceiver(expression);
            if (!jsonValue) dependencies.RecordType(item.Type, expression);
            var itemType = jsonValue ? Quote("global::Newtonsoft.Json.Linq.JToken") : BuildBindingTypeExpression(item.Type);
            binding = $"{Runtime}SourceBinding.Item({expression}, {itemType})";
            return true;
        }

        if (expression is not MemberAccessExpressionSyntax member ||
            model.GetSymbolInfo(member).Symbol is not IPropertySymbol property)
        {
            return false;
        }

        var type = jsonValue ? Quote("global::Newtonsoft.Json.Linq.JToken") : BuildBindingTypeExpression(property.Type);
        if (member.Expression is MemberAccessExpressionSyntax { Name.Identifier.ValueText: "Parameters" } parameters &&
            model.GetSymbolInfo(parameters).Symbol is IPropertySymbol parameterProperty &&
            parameterProperty.ContainingType.AllInterfaces.Prepend(parameterProperty.ContainingType).Any(i =>
                i.ContainingAssembly.Name == SdkAssembly && i.OriginalDefinition.MetadataName == "IAgentToolContext`1"))
        {
            ValidateHandleReceiver(parameters.Expression);
            if (!jsonValue) dependencies.RecordType(property.Type, expression);
            binding = $"{Runtime}SourceBinding.AgentParameter({parameters.Expression}, {Quote(property.Name)}, {type})";
            return true;
        }

        if (IsWorkflowProperty(property, "IOutputWorkflowAction<T>", "Output") ||
            IsWorkflowProperty(property, "IBodyWorkflowAction<T>", "Body"))
        {
            ValidateHandleReceiver(member.Expression);
            if (!jsonValue) dependencies.RecordType(property.Type, expression);
            binding = $"{Runtime}SourceBinding.{property.Name}({member.Expression}, {type})";
            return true;
        }

        if (IsWorkflowProperty(property, "IVariableWorkflowAction", "Value"))
        {
            ValidateHandleReceiver(member.Expression);
            if (!jsonValue) dependencies.RecordType(property.Type, expression);
            binding = $"{Runtime}SourceBinding.Variable({member.Expression}, {type})";
            return true;
        }

        if (property.ContainingAssembly.Name == SdkAssembly && property.Name == "Body" &&
            member.Expression is MemberAccessExpressionSyntax triggerOutput &&
            model.GetSymbolInfo(triggerOutput).Symbol is IPropertySymbol triggerProperty &&
            triggerProperty.ContainingAssembly.Name == SdkAssembly && triggerProperty.Name == "TriggerOutput")
        {
            ValidateHandleReceiver(triggerOutput.Expression);
            if (!jsonValue) dependencies.RecordType(property.Type, expression);
            binding = $"{Runtime}SourceBinding.Trigger({triggerOutput.Expression}, \"triggerBody\", {type})";
            return true;
        }

        if (property.ContainingAssembly.Name == SdkAssembly &&
            property.Name is "TriggerOutput" or "TriggerBody")
        {
            ValidateHandleReceiver(member.Expression);
            if (!jsonValue) dependencies.RecordType(property.Type, expression);
            var helper = property.Name == "TriggerBody" ? "triggerBody" : "triggerOutputs";
            binding = $"{Runtime}SourceBinding.Trigger({member.Expression}, {Quote(helper)}, {type})";
            return true;
        }

        return false;
    }

    private bool IsForEachItemParameter(IParameterSymbol parameter)
    {
        if (IsDeclaredInsideLambda(parameter))
        {
            return false;
        }

        var callback = parameter.DeclaringSyntaxReferences.FirstOrDefault()?.GetSyntax()
            .AncestorsAndSelf().OfType<LambdaExpressionSyntax>().FirstOrDefault();
        return callback?.Parent is ArgumentSyntax argument &&
            argument.Parent?.Parent is InvocationExpressionSyntax invocation &&
            model.GetSymbolInfo(invocation).Symbol is IMethodSymbol method &&
            method.ContainingAssembly.Name == SdkAssembly && method.Name == "ForEach" &&
            method.ContainingType.Name == "WorkflowControlActions" &&
            (argument.NameColon?.Name.Identifier.ValueText == "actions" ||
             argument.NameColon == null && invocation.ArgumentList.Arguments.IndexOf(argument) == 1);
    }

    private static bool IsWorkflowProperty(IPropertySymbol property, string interfaceName, string memberName)
    {
        if (property.Name != memberName)
        {
            return false;
        }

        var interfaces = property.ContainingType.AllInterfaces.Prepend(property.ContainingType);
        return interfaces.Any(i => i.ContainingAssembly.Name == SdkAssembly &&
            i.OriginalDefinition.ToDisplayString() == SdkAssembly + "." + interfaceName &&
            i.GetMembers(memberName).Any(m =>
                SymbolEqualityComparer.Default.Equals(m, property) ||
                SymbolEqualityComparer.Default.Equals(property.ContainingType.FindImplementationForInterfaceMember(m), property)));
    }

    private void ValidateHandleReceiver(ExpressionSyntax receiver)
    {
        var symbol = model.GetSymbolInfo(receiver).Symbol;
        if (symbol is IFieldSymbol && IsSupportedFieldReceiver(receiver))
        {
            return;
        }

        if (symbol is not (ILocalSymbol or IParameterSymbol) || IsDeclaredInsideLambda(symbol) ||
            model.LookupSymbols(callPosition, name: symbol.Name).All(s => !SymbolEqualityComparer.Default.Equals(s, symbol)))
        {
            throw Error("WFBUILD004", "Workflow handles must be fields, locals or parameters visible at the SDK call; runtime-lambda handles and executable handle resolution are not allowed.", receiver);
        }
    }

    private bool IsSupportedFieldReceiver(ExpressionSyntax expression)
    {
        if (model.GetSymbolInfo(expression).Symbol is INamedTypeSymbol)
        {
            return true;
        }

        if (expression is ThisExpressionSyntax or BaseExpressionSyntax)
        {
            return true;
        }

        if (expression is IdentifierNameSyntax identifier)
        {
            var symbol = model.GetSymbolInfo(identifier).Symbol;
            return symbol is IFieldSymbol ||
                symbol is ILocalSymbol or IParameterSymbol && !IsDeclaredInsideLambda(symbol) &&
                model.LookupSymbols(callPosition, name: symbol.Name).Any(s => SymbolEqualityComparer.Default.Equals(s, symbol));
        }

        return expression is MemberAccessExpressionSyntax member &&
            model.GetSymbolInfo(member).Symbol is IFieldSymbol &&
            IsSupportedFieldReceiver(member.Expression);
    }

    private bool TryBuildCaptureBinding(ExpressionSyntax expression, out string binding)
    {
        binding = "";
        var symbol = model.GetSymbolInfo(expression).Symbol;
        if (symbol is ILocalSymbol { IsConst: true })
        {
            return false;
        }

        var node = expression;
        var members = new List<string>();
        while (node is MemberAccessExpressionSyntax access)
        {
            if (TryBuildWorkflowBinding(node, out _))
            {
                return false;
            }

            var member = model.GetSymbolInfo(access).Symbol;
            if (member is IFieldSymbol { IsStatic: false } field)
            {
                members.Insert(0, field.Name);
            }
            else if (member is IPropertySymbol { IsStatic: false } property && IsAutoProperty(property))
            {
                members.Insert(0, property.Name);
            }
            else
            {
                if (member is IPropertySymbol { IsStatic: false } getter &&
                    IsCapturedObjectPath(access.Expression))
                {
                    throw Error("WFBUILD003", $"Captured custom getter '{getter.Name}' cannot be evaluated during workflow construction.", expression);
                }

                return false;
            }

            node = access.Expression;
        }

        var root = model.GetSymbolInfo(node).Symbol;
        if (root is not (ILocalSymbol or IParameterSymbol) || IsDeclaredInsideLambda(root))
        {
            return false;
        }

        if (model.LookupSymbols(callPosition, name: root.Name).All(s => !SymbolEqualityComparer.Default.Equals(s, root)))
        {
            throw Error("WFBUILD008", "A reused lambda capture is not in scope at this SDK call.", expression);
        }

        var type = model.GetTypeInfo(expression).Type!;
        if (!IsSupportedCaptureType(type))
        {
            throw Error("WFBUILD003", $"Unsupported captured value of type '{type}'. Use a workflow binding or an explicitly deployed static runtime dependency.", expression);
        }

        dependencies.RecordType(type, expression);
        binding = members.Count == 0
            ? $"{Runtime}SourceBinding.Capture({node}, {Quote(GetQualifiedTypeName(type))})"
            : $"{Runtime}SourceBinding.CapturePath({node}, new string[] {{ {string.Join(", ", members.Select(Quote))} }}, {Quote(GetQualifiedTypeName(type))})";
        return true;
    }

    private static bool IsSupportedCaptureType(ITypeSymbol type) =>
        type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String ||
        type.TypeKind == TypeKind.Enum ||
        type is IArrayTypeSymbol array && IsSupportedCaptureType(array.ElementType) ||
        type is INamedTypeSymbol named &&
        ((named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T && IsSupportedCaptureType(named.TypeArguments[0])) ||
         (named.OriginalDefinition.ToDisplayString() == "System.Collections.Generic.List<T>" &&
          named.TypeArguments.All(IsSupportedCaptureType)) ||
         (named.OriginalDefinition.ToDisplayString() == "System.Collections.Generic.Dictionary<TKey, TValue>" &&
          named.TypeArguments[0].SpecialType == SpecialType.System_String && IsSupportedCaptureType(named.TypeArguments[1])) ||
         named.ToDisplayString() is "Newtonsoft.Json.Linq.JToken" or "Newtonsoft.Json.Linq.JObject" or "Newtonsoft.Json.Linq.JArray" or "Newtonsoft.Json.Linq.JValue" or "System.Uri");

    private static bool IsAutoProperty(IPropertySymbol property) =>
        property.DeclaringSyntaxReferences.Any(r => r.GetSyntax() is PropertyDeclarationSyntax
        { ExpressionBody: null, AccessorList: { } accessors } &&
            accessors.Accessors.All(a => a.Body == null && a.ExpressionBody == null)) ||
        property.DeclaringSyntaxReferences.Length == 0 &&
        property.GetMethod?.GetAttributes().Any(a =>
            a.AttributeClass?.ToDisplayString() == "System.Runtime.CompilerServices.CompilerGeneratedAttribute") == true;

    private bool IsDeclaredInsideLambda(ISymbol symbol) =>
        symbol.DeclaringSyntaxReferences.Any(r => r.SyntaxTree == lambda.SyntaxTree && lambda.Span.Contains(r.Span));

    private ConditionalExpressionSyntax? FindConditionalEnumExpression(ExpressionSyntax expression)
    {
        if (expression is ConditionalExpressionSyntax conditional) return conditional;
        if (expression is ParenthesizedExpressionSyntax parenthesized) return FindConditionalEnumExpression(parenthesized.Expression);
        if (expression is CastExpressionSyntax cast &&
            model.GetTypeInfo(cast.Expression).Type is { TypeKind: TypeKind.Enum } source &&
            model.GetTypeInfo(cast).Type is INamedTypeSymbol { OriginalDefinition.SpecialType: SpecialType.System_Nullable_T } target &&
            SymbolEqualityComparer.Default.Equals(source, target.TypeArguments[0]))
        {
            return FindConditionalEnumExpression(cast.Expression);
        }

        return null;
    }

    private NativeSource BuildNativeSource(ExpressionSyntax body, ITypeSymbol? enumWireType = null)
    {
        var replacements = new List<(TextSpan Span, string? Binding, string? Text)>();
        var protectedInterpolations = new HashSet<InterpolationSyntax>();
        var enumLeaves = new HashSet<ExpressionSyntax>();
        if (enumWireType != null) CollectEnumLeaves(body);
        CollectSourceReplacements(body);
        var segments = new List<string>();
        var bindings = new List<string>();
        var text = body.ToString();
        var cursor = 0;
        var current = "";
        foreach (var replacement in replacements.OrderBy(r => r.Span.Start).ThenBy(r => r.Span.Length))
        {
            var start = replacement.Span.Start - body.SpanStart;
            current += text.Substring(cursor, start - cursor);
            if (replacement.Binding != null)
            {
                segments.Add(current);
                bindings.Add(replacement.Binding);
                current = "";
            }
            else
            {
                current += replacement.Text;
            }

            cursor = start + replacement.Span.Length;
        }

        current += text[cursor..];
        segments.Add(current);
        var checkedContext = body.Ancestors().FirstOrDefault(n => n is CheckedStatementSyntax or CheckedExpressionSyntax);
        var checkOverflow = checkedContext switch
        {
            CheckedStatementSyntax statement => statement.Keyword.IsKind(SyntaxKind.CheckedKeyword),
            CheckedExpressionSyntax expression => expression.Keyword.IsKind(SyntaxKind.CheckedKeyword),
            _ => model.Compilation.Options.CheckOverflow,
        };
        if (checkOverflow)
        {
            segments[0] = "checked(" + segments[0];
            segments[^1] += ")";
        }

        return new NativeSource(segments, bindings);

        void CollectEnumLeaves(ExpressionSyntax expression)
        {
            if (expression is ParenthesizedExpressionSyntax parenthesized)
            {
                CollectEnumLeaves(parenthesized.Expression);
            }
            else if (expression is ConditionalExpressionSyntax conditional)
            {
                CollectEnumLeaves(conditional.WhenTrue);
                CollectEnumLeaves(conditional.WhenFalse);
            }
            else
            {
                enumLeaves.Add(expression);
            }
        }

        void ParenthesizeInterpolationHole(SyntaxNode node)
        {
            var hole = node.Ancestors().OfType<InterpolationSyntax>()
                .FirstOrDefault(i => i.Expression.Span.Contains(node.Span) && body.Span.Contains(i.Span));
            if (hole == null || hole.Expression is ParenthesizedExpressionSyntax || !protectedInterpolations.Add(hole))
            {
                return;
            }

            // Alias qualification uses ':'; parentheses keep it out of interpolation-format syntax.
            replacements.Add((new TextSpan(hole.Expression.SpanStart, 0), null, "("));
            replacements.Add((new TextSpan(hole.Expression.Span.End, 0), null, ")"));
        }

        void ParenthesizeBindingInterpolation(ExpressionSyntax expression)
        {
            if (model.GetTypeInfo(expression).Type is not { } type)
                return;
            var typeName = GetQualifiedTypeName(type);
            if (typeName != "global::Newtonsoft.Json.Linq.JToken" &&
                (ContainsTypeParameter(type) || type is IArrayTypeSymbol ||
                 typeName.Contains("global::", StringComparison.Ordinal)))
                ParenthesizeInterpolationHole(expression);
        }

        void CollectSourceReplacements(SyntaxNode node)
        {
            if (node is ExpressionSyntax expression)
            {
                if (enumLeaves.Contains(expression))
                {
                    ParenthesizeBindingInterpolation(expression);
                    replacements.Add((node.Span,
                        $"{Runtime}SourceBinding.EnumWire({BuildExpressionDescriptorSource(expression, enumWireType!)})", null));
                    return;
                }

                if (IsJsonIntrinsicCall(expression))
                {
                    var resultType = model.GetTypeInfo(expression).Type!;
                    var jsonValue = ConsumesJsonValue(expression, out var formatting);
                    if (jsonValue)
                    {
                        var formatType = formatting && resultType is ITypeParameterSymbol ? GetQualifiedTypeName(resultType) : "object";
                        if (formatType != "object") ParenthesizeBindingInterpolation(expression);
                        replacements.Add((node.Span,
                            $"{Runtime}SourceBinding.FormatJson({BuildJsonDescriptorSource((InvocationExpressionSyntax)expression, resultType, recordDependency: formatType != "object")}, typeof({formatType}))", null));
                        return;
                    }
                    ParenthesizeBindingInterpolation(expression);
                    replacements.Add((node.Span,
                        $"{Runtime}SourceBinding.Json({BuildJsonDescriptorSource((InvocationExpressionSyntax)expression, resultType)}, {BuildBindingTypeExpression(resultType)})", null));
                    return;
                }

                if (ConsumesJsonValue(expression, out var formatJson) && TryBuildJsonNavigation(expression, out var jsonBinding, out var suffix))
                {
                    var tokenType = model.Compilation.GetTypeByMetadataName("Newtonsoft.Json.Linq.JToken")!;
                    var jsonSource = BuildDescriptorFactoryCall(tokenType, "native", ["", suffix], [jsonBinding], expression);
                    var formatType = formatJson && model.GetTypeInfo(expression).Type is ITypeParameterSymbol typeParameter
                        ? GetQualifiedTypeName(typeParameter) : "object";
                    if (formatType != "object")
                        ParenthesizeBindingInterpolation(expression);
                    replacements.Add((node.Span,
                        $"{Runtime}SourceBinding.FormatJson({jsonSource}, typeof({formatType}))", null));
                    return;
                }

                if (TryBuildWorkflowBinding(expression, out var workflow))
                {
                    ParenthesizeBindingInterpolation(expression);
                    replacements.Add((node.Span, workflow, null));
                    return;
                }

                if (model.GetConstantValue(expression) is { HasValue: true } constant &&
                    expression is IdentifierNameSyntax &&
                    model.GetSymbolInfo(expression).Symbol is ILocalSymbol { IsConst: true } localConstant)
                {
                    dependencies.RecordType(localConstant.Type, expression);
                    replacements.Add((node.Span, null, "((" + GetQualifiedTypeName(localConstant.Type) + ")" + FormatConstantLiteral(constant.Value) + ")"));
                    return;
                }

                if (expression is InvocationExpressionSyntax { Expression: IdentifierNameSyntax { Identifier.ValueText: "nameof" } } &&
                    model.GetConstantValue(expression) is { HasValue: true, Value: string name })
                {
                    replacements.Add((node.Span, null, Quote(name)));
                    return;
                }

                if (TryBuildCaptureBinding(expression, out var capture))
                {
                    if (IsWriteOrByReferenceUse(expression))
                    {
                        throw Error("WFBUILD003", "Captured values are construction-time snapshots, not writable runtime variables or by-reference arguments.", expression);
                    }

                    ParenthesizeBindingInterpolation(expression);
                    replacements.Add((node.Span, capture, null));
                    return;
                }

                var symbol = model.GetSymbolInfo(expression).Symbol;
                dependencies.RecordSymbol(symbol, node);
                if (symbol is IMethodSymbol or IFieldSymbol or IPropertySymbol &&
                    symbol.DeclaredAccessibility is Accessibility.Private or Accessibility.Protected or Accessibility.ProtectedAndInternal &&
                    !IsDeclaredInsideLambda(symbol))
                {
                    throw Error("WFBUILD007", "Runtime source cannot access a private or protected dependency from the execution host.", node);
                }

                if (expression is IdentifierNameSyntax &&
                    symbol is { IsStatic: false } &&
                    (symbol is IFieldSymbol or IPropertySymbol ||
                     symbol is IMethodSymbol && node.Parent is InvocationExpressionSyntax) &&
                    !(node.Parent is MemberAccessExpressionSyntax or MemberBindingExpressionSyntax or NameEqualsSyntax or NameColonSyntax) &&
                    !(node.Parent is AssignmentExpressionSyntax assignment && assignment.Left == node &&
                      assignment.Parent is InitializerExpressionSyntax))
                {
                    throw Error("WFBUILD005", "Implicit instance state cannot be transported to the workflow execution host.", node);
                }

                if (symbol is INamedTypeSymbol named &&
                    !(node.Parent is QualifiedNameSyntax or AliasQualifiedNameSyntax) &&
                    !(node.Parent is MemberAccessExpressionSyntax member && member.Name == node))
                {
                    ParenthesizeInterpolationHole(node);
                    replacements.Add((node.Span, null, GetQualifiedTypeName(named)));
                    return;
                }

                if (expression is IdentifierNameSyntax identifier &&
                    symbol is IMethodSymbol { IsStatic: true } method &&
                    node.Parent is InvocationExpressionSyntax)
                {
                    ParenthesizeInterpolationHole(node);
                    replacements.Add((node.Span, null, GetQualifiedTypeName(method.ContainingType) + "." + identifier));
                    return;
                }

                if (expression is IdentifierNameSyntax staticName &&
                    symbol is IFieldSymbol { IsStatic: true } or IPropertySymbol { IsStatic: true } &&
                    !(node.Parent is MemberAccessExpressionSyntax staticMember && staticMember.Name == node))
                {
                    ParenthesizeInterpolationHole(node);
                    replacements.Add((node.Span, null, GetQualifiedTypeName(symbol.ContainingType!) + "." + staticName));
                    return;
                }

                if (expression is ThisExpressionSyntax or BaseExpressionSyntax ||
                    symbol is IMethodSymbol { MethodKind: MethodKind.LocalFunction })
                {
                    throw Error("WFBUILD005", "Instance state and local-function dependencies cannot be implicitly deployed.", node);
                }
            }

            foreach (var child in node.ChildNodes())
            {
                CollectSourceReplacements(child);
            }
        }
    }

    private static string FormatConstantLiteral(object? value) => value switch
    {
        null => "null",
        string text => Quote(text),
        char character => SymbolDisplay.FormatLiteral(character, quote: true),
        bool boolean => boolean ? "true" : "false",
        uint number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "U",
        long number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "L",
        ulong number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "UL",
        float number when float.IsNaN(number) => "global::System.Single.NaN",
        float number when float.IsPositiveInfinity(number) => "global::System.Single.PositiveInfinity",
        float number when float.IsNegativeInfinity(number) => "global::System.Single.NegativeInfinity",
        float number => number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "F",
        double number when double.IsNaN(number) => "global::System.Double.NaN",
        double number when double.IsPositiveInfinity(number) => "global::System.Double.PositiveInfinity",
        double number when double.IsNegativeInfinity(number) => "global::System.Double.NegativeInfinity",
        double number => number.ToString("R", System.Globalization.CultureInfo.InvariantCulture) + "D",
        decimal number => number.ToString(System.Globalization.CultureInfo.InvariantCulture) + "M",
        byte number => "(byte)" + number.ToString(System.Globalization.CultureInfo.InvariantCulture),
        sbyte number => "(sbyte)" + number.ToString(System.Globalization.CultureInfo.InvariantCulture),
        short number => "(short)" + number.ToString(System.Globalization.CultureInfo.InvariantCulture),
        ushort number => "(ushort)" + number.ToString(System.Globalization.CultureInfo.InvariantCulture),
        IFormattable number => number.ToString(null, System.Globalization.CultureInfo.InvariantCulture),
        _ => throw new InvalidOperationException("Unexpected compiler constant."),
    };

    private static bool ContainsTypeParameter(ITypeSymbol type) =>
        type is ITypeParameterSymbol ||
        type is IArrayTypeSymbol array && ContainsTypeParameter(array.ElementType) ||
        type is INamedTypeSymbol named && named.TypeArguments.Any(ContainsTypeParameter);

    private static bool IsWriteOrByReferenceUse(ExpressionSyntax expression)
    {
        SyntaxNode node = expression;
        while (node.Parent is ParenthesizedExpressionSyntax parenthesized)
        {
            node = parenthesized;
        }

        return node.Parent is AssignmentExpressionSyntax assignment && assignment.Left == node ||
            node.Parent is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None) ||
            node.Parent is PrefixUnaryExpressionSyntax prefix &&
                (prefix.IsKind(SyntaxKind.PreIncrementExpression) || prefix.IsKind(SyntaxKind.PreDecrementExpression) ||
                 prefix.IsKind(SyntaxKind.AddressOfExpression)) ||
            node.Parent is PostfixUnaryExpressionSyntax postfix &&
                (postfix.IsKind(SyntaxKind.PostIncrementExpression) || postfix.IsKind(SyntaxKind.PostDecrementExpression));
    }

    private static SourceDiagnosticException Error(string code, string message, SyntaxNode node) => new(code, message, node);

    private sealed record NativeSource(List<string> Segments, List<string> Bindings)
    {
        public string UnboundSource => Bindings.Count == 0
            ? Segments[0]
            : throw new InvalidOperationException("A compiler constant cannot contain runtime bindings.");
    }
}

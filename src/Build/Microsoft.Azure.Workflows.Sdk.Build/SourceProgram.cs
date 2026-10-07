// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ExpressionCompiler;

internal sealed class SourceProgram(SemanticModel model, LambdaExpressionSyntax lambda, ITypeSymbol resultType) : CSharpSyntaxRewriter
{
    private readonly Dictionary<string, string> bindings = new(StringComparer.Ordinal);
    private readonly Dictionary<ISymbol, string> captures = new(SymbolEqualityComparer.Default);
    private readonly List<string> declarations = [];
    private readonly HashSet<string> identifiers = lambda.DescendantTokens().Select(token => token.ValueText).ToHashSet(StringComparer.Ordinal);
    private readonly Dictionary<string, string> functions = new(StringComparer.Ordinal)
    {
        ["ToJson"] = "json", ["Actions"] = "actions", ["Trigger"] = "trigger", ["ListCallbackUrl"] = "listCallbackUrl",
        ["AppSetting"] = "appsetting", ["Action"] = "action", ["CurrentRequest"] = "currentRequest",
        ["Binary"] = "binary", ["Base64ToBinary"] = "base64ToBinary", ["DataUriToBinary"] = "dataUriToBinary",
        ["MultipartBody"] = "multipartBody", ["FormDataValue"] = "formDataValue", ["FormDataMultiValues"] = "formDataMultiValues",
        ["TriggerMultipartBody"] = "triggerMultipartBody", ["TriggerFormDataValue"] = "triggerFormDataValue",
        ["TriggerFormDataMultiValues"] = "triggerFormDataMultiValues",
    };

    internal string Build()
    {
        if (!lambda.AsyncKeyword.IsKind(SyntaxKind.None)) throw Error("Workflow value lambdas must be synchronous.", lambda);
        ValidateType(resultType, lambda);
        if (lambda.Body is ExpressionSyntax expression &&
            model.GetConstantValue(expression) is { HasValue: true } constant &&
            (constant.Value == null || CanUseWorkflowLiteral(resultType)))
        {
            var value = Constant(constant.Value);
            return $"{Prefix}WorkflowExpression.Literal<{TypeName(resultType)}>(({TypeName(resultType)})({value}))";
        }
        if (lambda.Body is IdentifierNameSyntax capturedExpression &&
            model.GetSymbolInfo(capturedExpression).Symbol is ILocalSymbol capturedLocal && !Local(capturedLocal) &&
            SymbolEqualityComparer.Default.Equals(capturedLocal.Type, resultType) &&
            CanUseWorkflowLiteral(resultType))
        {
            ValidateCapture(capturedLocal.Type, capturedExpression);
            return $"{Prefix}WorkflowExpression.Literal<{TypeName(resultType)}>({capturedExpression})";
        }
        var body = Visit(lambda.Body)!;
        var captured = string.Join(" ", declarations);
        var block = body is BlockSyntax statements
            ? statements.WithStatements(statements.Statements.InsertRange(0, ((BlockSyntax)SyntaxFactory.ParseStatement("{" + captured + "}")).Statements))
                .NormalizeWhitespace().ToFullString()
            : "{ " + captured + " return " + body.NormalizeWhitespace().ToFullString() + "; }";
        var source = $"((global::System.Func<{(Anonymous(resultType) ? "object" : TypeName(resultType))}>)(() => {block}))()";
        var checkedContext = lambda.Ancestors().FirstOrDefault(node => node is CheckedStatementSyntax or CheckedExpressionSyntax);
        if (checkedContext is CheckedStatementSyntax checkedStatement && checkedStatement.Keyword.IsKind(SyntaxKind.CheckedKeyword) ||
            checkedContext is CheckedExpressionSyntax checkedExpression && checkedExpression.Keyword.IsKind(SyntaxKind.CheckedKeyword) ||
            checkedContext == null && model.Compilation.Options.CheckOverflow) source = "checked(" + source + ")";
        var segments = new List<string>();
        var factories = new List<string>();
        var cursor = 0;
        foreach (var node in SyntaxFactory.ParseExpression(source).DescendantNodesAndSelf().OfType<IdentifierNameSyntax>())
        {
            if (!bindings.TryGetValue(node.Identifier.ValueText, out var factory)) continue;
            segments.Add(Quote(source.Substring(cursor, node.SpanStart - cursor)));
            factories.Add(factory);
            cursor = node.Span.End;
        }
        segments.Add(Quote(source[cursor..]));
        return $"{Prefix}WorkflowExpression.Program{(Anonymous(resultType) ? "" : "<" + TypeName(resultType) + ">")}" +
            $"(new string[] {{ {string.Join(", ", segments)} }}, new {Prefix}WorkflowExpressionBinding[] {{ {string.Join(", ", factories)} }}" +
            (Anonymous(resultType) ? $", typeWitness: {lambda}" : "") + ")";
    }

    public override SyntaxNode? Visit(SyntaxNode? node)
    {
        if (node is MemberAccessExpressionSyntax path && TryCustomOutputPath(path, out var factoryPath, out var keys))
        {
            var source = Bind(factoryPath) + string.Concat(keys.Select(key => "[" + Quote(key) + "]"));
            return Read(model.GetTypeInfo(path).Type!, source, defaultIfMissing: true).WithTriviaFrom(node);
        }
        if (node is ExpressionSyntax expression && TryWorkflowReference(expression, out var factory))
            return Read(model.GetTypeInfo(expression).Type!, Bind(factory)).WithTriviaFrom(node);
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
            ValidateType(type, node);
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
            return Capture(node, symbol, type, "@" + symbol.Name);
        }
        if (symbol is IFieldSymbol { IsStatic: false } instanceField && !Local(instanceField))
            return Capture(node, instanceField, instanceField.Type, node.ToString());
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
        if (model.GetSymbolInfo(node).Symbol is IPropertySymbol property) ValidateType(property.ContainingType, node);
        if (model.GetSymbolInfo(node).Symbol is IFieldSymbol field) ValidateType(field.ContainingType, node);
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
            if (!functions.TryGetValue(method.Name, out var function)) throw Error("Unsupported workflow function.", node);
            var call = SyntaxFactory.InvocationExpression(SyntaxFactory.IdentifierName(function),
                node.ArgumentList.WithArguments(SyntaxFactory.SeparatedList(node.ArgumentList.Arguments.Select(argument => (ArgumentSyntax)Visit(argument)!))));
            return (method.IsGenericMethod ? Read(method.TypeArguments[0], call.ToString()) : call).WithTriviaFrom(node);
        }
        if (method.MethodKind == MethodKind.LocalFunction && !Local(method))
            throw Error("Declare the local function inside the workflow value lambda.", node);
        if (!Local(method))
        {
            ValidateType(method.ContainingType, node);
            if (method.DeclaredAccessibility != Accessibility.Public && method.MethodKind != MethodKind.AnonymousFunction)
                throw Error("Expression runtime members must be public.", node);
        }
        foreach (var type in method.TypeArguments) ValidateType(type, node);
        return base.VisitInvocationExpression(node);
    }

    public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
    {
        if (TryWorkflowReference(node.Expression, out var factory))
        {
            var sourceType = model.GetTypeInfo(node.Expression).Type;
            var target = model.GetTypeInfo(node.Type).Type!;
            if (sourceType?.SpecialType == SpecialType.System_Object || sourceType?.ToDisplayString() == "Newtonsoft.Json.Linq.JToken")
                return Read(target, Bind(factory)).WithTriviaFrom(node);
        }
        return base.VisitCastExpression(node);
    }

    public override SyntaxNode? VisitInterpolation(InterpolationSyntax node)
    {
        var rewritten = (InterpolationSyntax)base.VisitInterpolation(node)!;
        return rewritten.WithExpression(SyntaxFactory.ParenthesizedExpression(rewritten.Expression));
    }

    private bool TryWorkflowReference(ExpressionSyntax expression, out string factory)
    {
        factory = "";
        if (expression is IdentifierNameSyntax && model.GetSymbolInfo(expression).Symbol is IParameterSymbol item && !Local(item))
        {
            var parent = item.DeclaringSyntaxReferences.FirstOrDefault()?.GetSyntax().Ancestors().OfType<LambdaExpressionSyntax>().FirstOrDefault();
            if (parent?.Parent is ArgumentSyntax { Parent.Parent: InvocationExpressionSyntax call } &&
                model.GetSymbolInfo(call).Symbol is IMethodSymbol { Name: "ForEach", ContainingAssembly.Name: Sdk })
            {
                factory = $"{Prefix}WorkflowExpressionBinding.Item({expression})";
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
            factory = $"{Prefix}WorkflowExpressionBinding.{function}({member.Expression}" +
                (function == "Trigger" ? ", " + (property.Name == "TriggerBody" ? "true" : "false") : "") + ")";
            return true;
        }
        if (member.Expression is MemberAccessExpressionSyntax { Name.Identifier.ValueText: "Parameters" } parameters &&
            Implements(model.GetTypeInfo(parameters.Expression).Type, "IAgentToolContext"))
        {
            factory = $"{Prefix}WorkflowExpressionBinding.AgentParameter({parameters.Expression}, {Quote(property.Name)})";
            return true;
        }
        return false;
    }

    private bool TryCustomOutputPath(MemberAccessExpressionSyntax expression, out string factory, out List<string> keys)
    {
        factory = "";
        keys = [];
        if (model.GetSymbolInfo(expression).Symbol is not IPropertySymbol leaf ||
            leaf.ContainingAssembly.Name == Sdk || leaf.ContainingAssembly.Name.StartsWith("System", StringComparison.Ordinal) ||
            leaf.ContainingAssembly.Name == "Newtonsoft.Json") return false;
        ExpressionSyntax current = expression;
        while (current is MemberAccessExpressionSyntax member && model.GetSymbolInfo(member).Symbol is IPropertySymbol property)
        {
            if (TryWorkflowReference(member, out factory)) return keys.Count > 0;
            if (!Automatic(property)) return false;
            var wireName = property.GetAttributes().FirstOrDefault(attribute =>
                attribute.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute")?.ConstructorArguments.FirstOrDefault().Value as string;
            keys.Insert(0, wireName ?? property.Name);
            current = member.Expression;
        }
        return false;
    }

    private static ExpressionSyntax Read(ITypeSymbol type, string source, bool defaultIfMissing = false)
    {
        ValidateType(type, SyntaxFactory.ParseExpression(source));
        if (type.ToDisplayString() == "Newtonsoft.Json.Linq.JToken") return SyntaxFactory.ParseExpression(source);
        return SyntaxFactory.ParseExpression(defaultIfMissing
            ? $"({source})?.ToObject<{TypeName(type)}>() ?? default({TypeName(type)})"
            : $"({source}).ToObject<{TypeName(type)}>()");
    }
    private string Bind(string factory)
    {
        var name = Unique("__binding");
        bindings.Add(name, factory);
        return name;
    }
    private ExpressionSyntax CaptureInstanceMember(ExpressionSyntax node, ISymbol symbol)
    {
        var type = symbol switch
        {
            IFieldSymbol field => field.Type,
            IPropertySymbol property when Automatic(property) => property.Type,
            IPropertySymbol property => throw Error(
                $"Instance property '{property.Name}' has an executable getter. Read it before creating the workflow expression and capture the result.",
                node),
            _ => throw Error("Only instance fields and auto-properties can be captured.", node),
        };
        return Capture(node, symbol, type, node.ToString());
    }
    private ExpressionSyntax Capture(ExpressionSyntax node, ISymbol symbol, ITypeSymbol type, string source)
    {
        if (IsWrite(node)) throw Error("External captures are snapshots and cannot be assigned or passed by reference.", node);
        ValidateCapture(type, node);
        if (!captures.TryGetValue(symbol, out var name))
        {
            name = Unique("__capture");
            captures.Add(symbol, name);
            var slot = Bind($"{Prefix}WorkflowExpressionBinding.Capture<{TypeName(type)}>({source})");
            declarations.Add($"{(type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String || type.TypeKind == TypeKind.Enum ? "const " : "")}{TypeName(type)} {name} = {slot};");
        }
        return SyntaxFactory.IdentifierName(name).WithTriviaFrom(node);
    }
    private string Unique(string prefix)
    {
        var index = 0;
        while (!identifiers.Add(prefix + index)) index++;
        return prefix + index;
    }
    private bool Local(ISymbol symbol) => symbol.DeclaringSyntaxReferences.Any(reference =>
        reference.SyntaxTree == lambda.SyntaxTree && lambda.Span.Contains(reference.Span));
    private static bool Automatic(IPropertySymbol property) => property.ContainingType.IsAnonymousType ||
        property.DeclaringSyntaxReferences.Any(reference =>
            reference.GetSyntax() is PropertyDeclarationSyntax { ExpressionBody: null, AccessorList: { } list } &&
            list.Accessors.All(accessor => accessor.Body == null && accessor.ExpressionBody == null));
    private static bool Implements(ITypeSymbol? type, string name) => type != null && type.AllInterfaces.Prepend(type)
        .Any(candidate => candidate.Name == name && candidate.ContainingNamespace.ToDisplayString() == Sdk);
    private static bool IsWrite(ExpressionSyntax node) =>
        node.Parent is AssignmentExpressionSyntax assignment && assignment.Left == node ||
        node.Parent is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None) ||
        node.Parent is PrefixUnaryExpressionSyntax prefix && prefix.Kind() is SyntaxKind.PreIncrementExpression or SyntaxKind.PreDecrementExpression ||
        node.Parent is PostfixUnaryExpressionSyntax postfix && postfix.Kind() is SyntaxKind.PostIncrementExpression or SyntaxKind.PostDecrementExpression;
    private static ExpressionSyntax Parse(string source, SyntaxNode node) => SyntaxFactory.ParseExpression(source).WithTriviaFrom(node);
    private static ExpressionError Error(string text, SyntaxNode node) => new(text, node);
    private static void ValidateType(ITypeSymbol type, SyntaxNode node)
    {
        if (type.IsAnonymousType) return;
        if (type is IArrayTypeSymbol array) { ValidateType(array.ElementType, node); return; }
        var assembly = type.ContainingAssembly?.Name;
        if (type is ITypeParameterSymbol || assembly is not ("System.Private.CoreLib" or "mscorlib" or "System.Runtime" or "netstandard" or
            "System.Linq" or "System.Collections" or "System.Net.Http" or "System.Net.Primitives" or "System.Private.Uri" or
            "System.Runtime.Numerics" or "Newtonsoft.Json" or Sdk) || type.ToDisplayString().StartsWith("System.Threading.Tasks.", StringComparison.Ordinal))
            throw Error($"Runtime type '{type}' is unavailable. Use framework/SDK types or move custom code into a CustomCode action.", node);
        if (type is INamedTypeSymbol named) foreach (var argument in named.TypeArguments) ValidateType(argument, node);
    }
    private static void ValidateCapture(ITypeSymbol type, SyntaxNode node)
    {
        ValidateType(type, node);
        if (type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String || type.TypeKind == TypeKind.Enum ||
            type.ToDisplayString() is "System.Guid" or "System.DateTime" or "System.DateTimeOffset" or "System.TimeSpan" or "System.Uri" or "System.Net.Http.HttpMethod")
            return;
        if (type is INamedTypeSymbol named && named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T)
        { ValidateCapture(named.TypeArguments[0], node); return; }
        throw Error("Capture immutable scalar values, not mutable objects or collections.", node);
    }
    private static bool CanUseWorkflowLiteral(ITypeSymbol type) =>
        type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String;
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

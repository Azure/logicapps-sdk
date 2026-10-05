// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using static ExpressionCompiler;

internal sealed class ProgramBuilder(SemanticModel model, LambdaExpressionSyntax lambda, ITypeSymbol resultType)
{
    private readonly List<(TextSpan Span, string Source)> replacements = [];
    private readonly List<(string Name, string Type, string Binding)> captures = [];
    private readonly Dictionary<ISymbol, string> capturedSymbols = new(SymbolEqualityComparer.Default);
    private readonly List<(TextSpan Span, string Binding)> bindings = [];
    private readonly HashSet<string> identifiers = lambda.DescendantTokens()
        .Where(token => token.IsKind(SyntaxKind.IdentifierToken)).Select(token => token.ValueText).ToHashSet(StringComparer.Ordinal);

    internal string Build()
    {
        if (!lambda.AsyncKeyword.IsKind(SyntaxKind.None) ||
            resultType.ToDisplayString().StartsWith("System.Threading.Tasks.", StringComparison.Ordinal))
            throw new ExpressionDiagnostic("Workflow value lambdas must be synchronous and return a workflow value, not a task.", lambda);
        ValidateType(resultType, lambda);
        var body = lambda.Body;
        if (body is ExpressionSyntax expression && model.GetConstantValue(expression) is { HasValue: true } constant &&
            resultType.TypeKind != TypeKind.Enum)
        {
            var literal = FormatConstant(constant.Value);
            return $"{Runtime}WorkflowValue.Literal<{TypeName(resultType)}>(1, ({TypeName(resultType)})({literal}))";
        }
        if (body is IdentifierNameSyntax captureExpression &&
            model.GetSymbolInfo(captureExpression).Symbol is ILocalSymbol captured &&
            !IsLocalToExpression(captured) &&
            SymbolEqualityComparer.Default.Equals(resultType, captured.Type))
        {
            ValidateCaptureType(captured.Type, body);
            return $"{Runtime}WorkflowValue.Captured<{TypeName(resultType)}>(1, {captureExpression})";
        }

        Visit(body);
        var segments = new List<string>();
        var bindingSources = new List<string>();
        var anonymous = ContainsAnonymousType(resultType);
        var returnType = anonymous ? "object" : TypeName(resultType);
        var prefix = $"{Runtime}WorkflowExpressionRuntime.Run<{returnType}>(1, () => {{ ";
        foreach (var capture in captures)
        {
            segments.Add(prefix + $"{capture.Type} {capture.Name} = ");
            bindingSources.Add(capture.Binding);
            prefix = "; ";
        }
        if (body is not BlockSyntax) prefix += "return ";
        var text = body.ToString();
        var cursor = 0;
        var current = prefix;
        var edits = replacements.Select(edit => (edit.Span, Text: (string?)edit.Source, Binding: (string?)null))
            .Concat(bindings.Select(edit => (edit.Span, Text: (string?)null, Binding: (string?)edit.Binding)))
            .OrderBy(edit => edit.Span.Start).ThenBy(edit => edit.Span.Length);
        foreach (var edit in edits)
        {
            var start = edit.Span.Start - body.SpanStart;
            if (start < cursor) throw new ExpressionDiagnostic("Overlapping workflow substitutions are unsupported.", body);
            current += text.Substring(cursor, start - cursor);
            if (edit.Binding != null)
            {
                segments.Add(current);
                bindingSources.Add(edit.Binding);
                current = "";
            }
            else current += edit.Text;
            cursor = start + edit.Span.Length;
        }
        current += text[cursor..];
        if (body is BlockSyntax) current += " })";
        else current += "; })";
        var checkedContext = body.Ancestors().FirstOrDefault(node => node is CheckedStatementSyntax or CheckedExpressionSyntax);
        var checkedMode = checkedContext switch
        {
            CheckedStatementSyntax statement => statement.Keyword.IsKind(SyntaxKind.CheckedKeyword),
            CheckedExpressionSyntax checkedExpression => checkedExpression.Keyword.IsKind(SyntaxKind.CheckedKeyword),
            _ => model.Compilation.Options.CheckOverflow,
        };
        if (checkedMode)
        {
            if (segments.Count == 0) current = "checked(" + current;
            else segments[0] = "checked(" + segments[0];
            current += ")";
        }
        segments.Add(current);
        var typeArgument = anonymous ? "" : $"<{TypeName(resultType)}>";
        var witness = anonymous ? $", typeWitness: {lambda}" : "";
        return $"{Runtime}WorkflowValue.Program{typeArgument}(1, new string[] {{ {string.Join(", ", segments.Select(Quote))} }}, " +
            $"new {Runtime}WorkflowBinding[] {{ {string.Join(", ", bindingSources)} }}{witness})";
    }

    private void Visit(SyntaxNode node)
    {
        if (node is InterpolationSyntax hole && hole.Expression is not ParenthesizedExpressionSyntax)
        {
            replacements.Add((new TextSpan(hole.Expression.SpanStart, 0), "("));
            replacements.Add((new TextSpan(hole.Expression.Span.End, 0), ")"));
        }
        if (node is ThisExpressionSyntax or BaseExpressionSyntax)
            throw new ExpressionDiagnostic("Implicit instance state cannot be used in a workflow expression. Capture supported values in locals.", node);
        if (node is ExpressionSyntax expression)
        {
            if (expression is InvocationExpressionSyntax { Expression: IdentifierNameSyntax { Identifier.ValueText: "nameof" } } &&
                model.GetConstantValue(expression) is { HasValue: true, Value: string nameValue })
            {
                replacements.Add((node.Span, Quote(nameValue)));
                return;
            }
            if (TryWorkflowBinding(expression, out var binding))
            {
                bindings.Add((node.Span, binding));
                return;
            }
            var symbol = model.GetSymbolInfo(expression).Symbol;
            if (symbol is ILocalSymbol or IParameterSymbol && !IsLocalToExpression(symbol))
            {
                if (symbol is ILocalSymbol { IsConst: true } constant)
                {
                    replacements.Add((node.Span, $"({TypeName(constant.Type)})({FormatConstant(constant.ConstantValue)})"));
                    return;
                }
                if (IsWrite(expression))
                    throw new ExpressionDiagnostic("Captured values are snapshots and cannot be assigned or passed by reference.", expression);
                var type = symbol is ILocalSymbol local ? local.Type : ((IParameterSymbol)symbol).Type;
                ValidateCaptureType(type, expression);
                if (!capturedSymbols.TryGetValue(symbol, out var name))
                {
                    var index = captures.Count;
                    do { name = "__workflowCapture" + index++; } while (!identifiers.Add(name));
                    capturedSymbols.Add(symbol, name);
                    captures.Add((name, TypeName(type), $"{Runtime}WorkflowBinding.Capture<{TypeName(type)}>(@{symbol.Name}, {Quote(TypeName(type))})"));
                }
                replacements.Add((node.Span, name));
                return;
            }
            if (expression is InvocationExpressionSyntax invocation && symbol is IMethodSymbol intrinsic &&
                intrinsic.ContainingType.ToDisplayString() == Sdk + ".WorkflowFunctions")
            {
                var name = WorkflowFunction(intrinsic.Name);
                if (name == null) throw new ExpressionDiagnostic("This workflow helper is not supported.", expression);
                replacements.Add((invocation.Expression.Span, name));
                foreach (var argument in invocation.ArgumentList.Arguments) Visit(argument.Expression);
                if (intrinsic.IsGenericMethod)
                {
                    ValidateType(intrinsic.TypeArguments[0], invocation);
                    replacements.Add((new TextSpan(invocation.Span.End, 0), $".ToObject<{TypeName(intrinsic.TypeArguments[0])}>()"));
                }
                return;
            }
            if (symbol is IMethodSymbol method)
            {
                if (method.MethodKind == MethodKind.LocalFunction && !IsLocalToExpression(method))
                    throw new ExpressionDiagnostic("A workflow expression cannot call an enclosing local function.", expression);
                if (!IsLocalToExpression(method)) ValidateType(method.ContainingType, expression);
                foreach (var type in method.TypeArguments) ValidateType(type, expression);
                if (method.DeclaredAccessibility != Accessibility.Public && !IsLocalToExpression(method) &&
                    method.MethodKind != MethodKind.AnonymousFunction)
                    throw new ExpressionDiagnostic("A workflow expression cannot call a nonpublic runtime member.", expression);
            }
            if (symbol is IFieldSymbol field && !IsLocalToExpression(field)) ValidateType(field.ContainingType, expression);
            if (symbol is IPropertySymbol property && !IsLocalToExpression(property)) ValidateType(property.ContainingType, expression);
            if (symbol is INamedTypeSymbol named && !named.IsAnonymousType &&
                node.Parent is not QualifiedNameSyntax && node.Parent is not AliasQualifiedNameSyntax &&
                !(node.Parent is MemberAccessExpressionSyntax member && member.Name == node))
            {
                ValidateType(named, expression);
                replacements.Add((node.Span, TypeName(named)));
                return;
            }
            if (expression is IdentifierNameSyntax identifier &&
                symbol is IMethodSymbol { IsStatic: true, MethodKind: not MethodKind.LocalFunction } staticMethod && node.Parent is InvocationExpressionSyntax)
            {
                replacements.Add((node.Span, TypeName(staticMethod.ContainingType) + "." + identifier));
                return;
            }
            if (expression is IdentifierNameSyntax staticName &&
                symbol is IFieldSymbol { IsStatic: true } or IPropertySymbol { IsStatic: true } &&
                !(node.Parent is MemberAccessExpressionSyntax access && access.Name == node))
            {
                replacements.Add((node.Span, TypeName(symbol.ContainingType!) + "." + staticName));
                return;
            }
        }
        foreach (var child in node.ChildNodes()) Visit(child);
    }

    private bool TryWorkflowBinding(ExpressionSyntax expression, out string binding)
    {
        binding = "";
        if (expression is IdentifierNameSyntax &&
            model.GetSymbolInfo(expression).Symbol is IParameterSymbol item && !IsLocalToExpression(item))
        {
            var enclosing = item.DeclaringSyntaxReferences.FirstOrDefault()?.GetSyntax().Ancestors().OfType<LambdaExpressionSyntax>().FirstOrDefault();
            if (enclosing?.Parent is ArgumentSyntax { Parent.Parent: InvocationExpressionSyntax call } &&
                model.GetSymbolInfo(call).Symbol is IMethodSymbol { Name: "ForEach", ContainingAssembly.Name: Sdk })
            {
                binding = $"{Runtime}WorkflowBinding.Item({expression})";
                return true;
            }
        }
        if (expression is not MemberAccessExpressionSyntax member || model.GetSymbolInfo(member).Symbol is not IPropertySymbol property)
            return false;
        var receiverType = model.GetTypeInfo(member.Expression).Type;
        string? factory = property.Name switch
        {
            "Output" when Implements(receiverType, "IOutputWorkflowAction") => "Output",
            "Body" when Implements(receiverType, "IBodyWorkflowAction") => "Body",
            "TriggerBody" when Implements(receiverType, "IBodyWorkflowTrigger") => "Trigger",
            "TriggerOutput" when Implements(receiverType, "IOutputWorkflowTrigger") => "Trigger",
            "Value" when Implements(receiverType, "IVariableWorkflowAction") => "Variable",
            _ => null,
        };
        if (factory != null)
        {
            RequireHandle(member.Expression);
            ValidateType(property.Type, expression);
            var typeName = TypeName(property.Type);
            binding = factory switch
            {
                "Trigger" => $"{Runtime}WorkflowBinding.Trigger({member.Expression}, {Quote(property.Name == "TriggerBody" ? "triggerBody" : "triggerOutputs")}, {Quote(typeName)})",
                "Variable" => $"{Runtime}WorkflowBinding.Variable({member.Expression})",
                _ => $"{Runtime}WorkflowBinding.{factory}({member.Expression}, {Quote(typeName)})",
            };
            return true;
        }
        if (property.ContainingAssembly.Name != Sdk &&
            !property.ContainingAssembly.Name.StartsWith("System", StringComparison.Ordinal) &&
            property.ContainingAssembly.Name != "Newtonsoft.Json" &&
            TryJsonOutputPath(member, out var root, out var path))
        {
            RequireHandle(root.Expression);
            ValidateType(property.Type, expression);
            var access = root.Name.Identifier.ValueText == "Body" ? "Body" : "Output";
            binding = $"{Runtime}WorkflowBinding.{access}({root.Expression}, {Quote(TypeName(property.Type))}, new string[] {{ {string.Join(", ", path.Select(Quote))} }})";
            return true;
        }
        if (member.Expression is MemberAccessExpressionSyntax { Name.Identifier.ValueText: "Parameters" } parameters &&
            Implements(model.GetTypeInfo(parameters.Expression).Type, "IAgentToolContext"))
        {
            RequireHandle(parameters.Expression);
            ValidateType(property.Type, expression);
            binding = $"{Runtime}WorkflowBinding.AgentParameter({parameters.Expression}, {Quote(property.Name)}, {Quote(TypeName(property.Type))})";
            return true;
        }
        return false;
    }

    private bool TryJsonOutputPath(MemberAccessExpressionSyntax member, out MemberAccessExpressionSyntax root, out List<string> path)
    {
        path = [];
        ExpressionSyntax current = member;
        while (current is MemberAccessExpressionSyntax access && model.GetSymbolInfo(access).Symbol is IPropertySymbol property)
        {
            if ((property.Name == "Body" && Implements(model.GetTypeInfo(access.Expression).Type, "IBodyWorkflowAction")) ||
                (property.Name == "Output" && Implements(model.GetTypeInfo(access.Expression).Type, "IOutputWorkflowAction")))
            {
                root = access;
                return path.Count > 0;
            }
            var autoProperty = property.DeclaringSyntaxReferences.Any(reference =>
                reference.GetSyntax() is PropertyDeclarationSyntax { ExpressionBody: null, AccessorList: { } list } &&
                list.Accessors.All(accessor => accessor.Body == null && accessor.ExpressionBody == null));
            if (!autoProperty && !property.ContainingType.IsAnonymousType) break;
            var jsonName = property.GetAttributes().FirstOrDefault(attribute =>
                attribute.AttributeClass?.ToDisplayString() == "Newtonsoft.Json.JsonPropertyAttribute")?.ConstructorArguments.FirstOrDefault().Value as string;
            path.Insert(0, jsonName ?? property.Name);
            current = access.Expression;
        }
        root = null!;
        return false;
    }

    private void RequireHandle(ExpressionSyntax expression)
    {
        var symbol = model.GetSymbolInfo(expression).Symbol;
        if (symbol is not (ILocalSymbol or IParameterSymbol or IFieldSymbol) || IsLocalToExpression(symbol))
            throw new ExpressionDiagnostic("Workflow handles must be source-visible locals, parameters or fields outside the value lambda.", expression);
    }

    private bool IsLocalToExpression(ISymbol symbol) =>
        symbol.DeclaringSyntaxReferences.Any(reference => reference.SyntaxTree == lambda.SyntaxTree && lambda.Span.Contains(reference.Span));

    private static bool Implements(ITypeSymbol? type, string name) =>
        type != null && type.AllInterfaces.Prepend(type).Any(candidate =>
            candidate.Name == name && candidate.ContainingNamespace.ToDisplayString() == Sdk);

    private static bool IsWrite(ExpressionSyntax expression) =>
        expression.Parent is AssignmentExpressionSyntax assignment && assignment.Left == expression ||
        expression.Parent is PrefixUnaryExpressionSyntax prefix && (prefix.IsKind(SyntaxKind.PreIncrementExpression) || prefix.IsKind(SyntaxKind.PreDecrementExpression)) ||
        expression.Parent is PostfixUnaryExpressionSyntax postfix && (postfix.IsKind(SyntaxKind.PostIncrementExpression) || postfix.IsKind(SyntaxKind.PostDecrementExpression)) ||
        expression.Parent is ArgumentSyntax argument && !argument.RefKindKeyword.IsKind(SyntaxKind.None);

    private static void ValidateType(ITypeSymbol type, SyntaxNode node)
    {
        if (type is IArrayTypeSymbol array) { ValidateType(array.ElementType, node); return; }
        if (type.IsAnonymousType) return;
        if (type is ITypeParameterSymbol) throw new ExpressionDiagnostic("Open runtime expression types are unsupported.", node);
        var name = type.ToDisplayString();
        var assembly = type.ContainingAssembly?.Name ?? "";
        var approved = assembly is "System.Private.CoreLib" or "mscorlib" or "System.Runtime" or "netstandard" or
            "System.Linq" or "System.Collections" or "System.Net.Primitives" or "System.Net.Http" or
            "System.Runtime.Numerics" or "System.Private.Uri" or "Newtonsoft.Json";
        if (assembly == Sdk)
            approved = name.StartsWith(Sdk + ".Connectors.", StringComparison.Ordinal) ||
                name.StartsWith(Sdk + ".ServiceProviders.", StringComparison.Ordinal) ||
                type.Name is "AgentPromptMessage" or "HttpRequestTriggerOutput" or "FlowStatus" or "MessageRole";
        if (!approved || name.StartsWith("System.Threading.Tasks.", StringComparison.Ordinal) ||
            name is "System.IO.Stream" or "System.Threading.Thread")
            throw new ExpressionDiagnostic($"Runtime type '{name}' is not in the approved expression reference set.", node);
        if (type is INamedTypeSymbol named)
            foreach (var argument in named.TypeArguments) ValidateType(argument, node);
    }

    private static void ValidateCaptureType(ITypeSymbol type, SyntaxNode node)
    {
        ValidateType(type, node);
        if (type.SpecialType is >= SpecialType.System_Boolean and <= SpecialType.System_String ||
            type.TypeKind == TypeKind.Enum || type is IArrayTypeSymbol ||
            type.ToDisplayString() is "System.Uri" or "System.Net.Http.HttpMethod" or "System.Guid" or
                "System.DateTime" or "System.DateTimeOffset" or "System.TimeSpan" ||
            type.ContainingNamespace.ToDisplayString() == "Newtonsoft.Json.Linq")
            return;
        if (type is INamedTypeSymbol named && (named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T ||
            named.ContainingNamespace.ToDisplayString() == "System.Collections.Generic" &&
            named.Name is "List" or "Dictionary" or "IReadOnlyList" or "IReadOnlyDictionary" or "IEnumerable"))
            return;
        throw new ExpressionDiagnostic($"Captured type '{type}' is unsupported. Capture approved scalar values or JSON instead.", node);
    }

    private static string? WorkflowFunction(string name) => name switch
    {
        "ToJson" => "json",
        "AppSetting" => "appsetting",
        _ => name.Length > 0 ? char.ToLowerInvariant(name[0]) + name[1..] : null,
    };
}

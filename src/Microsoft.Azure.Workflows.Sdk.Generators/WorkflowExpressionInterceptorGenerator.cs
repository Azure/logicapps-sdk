// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Generators;

using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

[Generator(LanguageNames.CSharp)]
public sealed class WorkflowExpressionInterceptorGenerator : IIncrementalGenerator
{
    private const string WorkflowExpressionAttributeName =
        "Microsoft.Azure.Workflows.Sdk.WorkflowExpressionAttribute";
    private static readonly DiagnosticDescriptor DirectLambdaRequired = new(
        id: "LAEXP001",
        title: "Workflow expression must be a lambda",
        messageFormat: "Workflow expression argument '{0}' must be provided directly as a lambda expression",
        category: "LogicAppsSdk",
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true,
        description:
            "The source generator must inspect the lambda syntax at the workflow factory call site. " +
            "Delegate-returning method calls and delegate variables are not supported.");
    private static readonly DiagnosticDescriptor UnsupportedRuntimeDependency = new(
        id: "LAEXP003",
        title: "C# expression dependency is not available at runtime",
        messageFormat: "Workflow expression symbol '{0}' requires assembly '{1}', which is not in the runtime-approved reference set",
        category: "LogicAppsSdk",
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true,
        description:
            "Workflow C# expressions can use only the framework, JSON, and workflow-global references " +
            "explicitly approved by the runtime. Customer-defined types and helpers are unavailable.");

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var interceptedCalls = context.SyntaxProvider.CreateSyntaxProvider(
                static (node, _) => node is InvocationExpressionSyntax,
                static (generatorContext, cancellationToken) =>
                    CreateInterceptedCall(generatorContext, cancellationToken))
            .Where(static call => call is not null)
            .Select(static (call, _) => call!);

        context.RegisterSourceOutput(
            interceptedCalls.Collect(),
            static (sourceContext, calls) => EmitInterceptors(sourceContext, calls));

        var invalidArguments = context.SyntaxProvider.CreateSyntaxProvider(
                static (node, _) => node is InvocationExpressionSyntax,
                static (generatorContext, cancellationToken) =>
                    FindInvalidWorkflowExpressionArgument(generatorContext, cancellationToken))
            .Where(static diagnostic => diagnostic is not null)
            .Select(static (diagnostic, _) => diagnostic!);
        context.RegisterSourceOutput(
            invalidArguments,
            static (sourceContext, diagnostic) => sourceContext.ReportDiagnostic(diagnostic));

        var unsupportedDependencies = context.SyntaxProvider.CreateSyntaxProvider(
                static (node, _) => node is InvocationExpressionSyntax,
                static (generatorContext, cancellationToken) =>
                    FindUnsupportedRuntimeDependency(generatorContext, cancellationToken))
            .Where(static diagnostic => diagnostic is not null)
            .Select(static (diagnostic, _) => diagnostic!);
        context.RegisterSourceOutput(
            unsupportedDependencies,
            static (sourceContext, diagnostic) => sourceContext.ReportDiagnostic(diagnostic));
    }

    private static InterceptedCall? CreateInterceptedCall(
        GeneratorSyntaxContext context,
        CancellationToken cancellationToken)
    {
        var invocation = (InvocationExpressionSyntax)context.Node;
        if (context.SemanticModel.GetSymbolInfo(invocation, cancellationToken).Symbol
            is not IMethodSymbol method)
        {
            return null;
        }

        var expressionParameters = method.Parameters
            .Where(IsWorkflowExpressionParameter)
            .Select(parameter => parameter.Ordinal)
            .ToImmutableArray();
        if (expressionParameters.IsDefaultOrEmpty)
            return null;

        var expressions = ImmutableArray.CreateBuilder<GeneratedExpression>(expressionParameters.Length);
        var operationRegistrations = ImmutableArray.CreateBuilder<WorkflowOperationRegistration>();
        foreach (var parameterIndex in expressionParameters)
        {
            var argument = FindArgument(invocation, method.Parameters[parameterIndex]);
            if (argument == null || argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                continue;

            if (argument.Expression is not LambdaExpressionSyntax lambda ||
                lambda.Body is not ExpressionSyntax body)
            {
                return null;
            }

            var rewriter = new WorkflowExpressionSyntaxRewriter(context.SemanticModel);
            var rewrittenBody = (ExpressionSyntax)rewriter.Visit(body)!;
            operationRegistrations.AddRange(rewriter.OperationRegistrations);
            var constantValue = context.SemanticModel.GetConstantValue(body, cancellationToken);
            var hasRewrittenLiteral = TryRenderRewrittenLiteral(rewrittenBody, out var rewrittenLiteral);
            var isLiteral = constantValue.HasValue || hasRewrittenLiteral;
            expressions.Add(new GeneratedExpression(
                parameterIndex,
                constantValue.HasValue
                    ? RenderLiteral(constantValue.Value, context.SemanticModel.GetTypeInfo(body).ConvertedType)
                    : hasRewrittenLiteral
                        ? rewrittenLiteral
                    : rewrittenBody.WithoutTrivia().NormalizeWhitespace().ToFullString(),
                isLiteral,
                rewriter.OperationRegistrations
                    .Select(registration => registration.OperationId)
                    .ToImmutableArray(),
                rewriter.CapturedValueNames));
        }

        var location = context.SemanticModel.GetInterceptableLocation(invocation, cancellationToken);
        if (location is null)
            return null;

        return new InterceptedCall(
            location.GetInterceptsLocationAttributeSyntax(),
            method,
            expressions.ToImmutable(),
            operationRegistrations.ToImmutable());
    }

    private static bool IsWorkflowExpressionParameter(IParameterSymbol parameter) =>
        parameter.GetAttributes().Any(attribute =>
            attribute.AttributeClass?.ToDisplayString() == WorkflowExpressionAttributeName);

    private static Diagnostic? FindInvalidWorkflowExpressionArgument(
        GeneratorSyntaxContext context,
        CancellationToken cancellationToken)
    {
        var invocation = (InvocationExpressionSyntax)context.Node;
        if (context.SemanticModel.GetSymbolInfo(invocation, cancellationToken).Symbol
            is not IMethodSymbol method)
        {
            return null;
        }

        foreach (var parameter in method.Parameters.Where(IsWorkflowExpressionParameter))
        {
            var argument = FindArgument(invocation, parameter);
            if (argument != null &&
                argument.Expression is not LambdaExpressionSyntax &&
                !argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
            {
                return Diagnostic.Create(
                    DirectLambdaRequired,
                    argument.Expression.GetLocation(),
                    parameter.Name);
            }
        }

        return null;
    }

    private static Diagnostic? FindUnsupportedRuntimeDependency(
        GeneratorSyntaxContext context,
        CancellationToken cancellationToken)
    {
        var invocation = (InvocationExpressionSyntax)context.Node;
        if (context.SemanticModel.GetSymbolInfo(invocation, cancellationToken).Symbol
            is not IMethodSymbol method)
        {
            return null;
        }

        foreach (var parameter in method.Parameters.Where(IsWorkflowExpressionParameter))
        {
            var argument = FindArgument(invocation, parameter);
            if (argument?.Expression is not LambdaExpressionSyntax lambda ||
                lambda.Body is not ExpressionSyntax body)
            {
                continue;
            }

            var unsupported = RuntimeDependencyValidator.FindFirst(
                context.SemanticModel,
                body);
            if (unsupported != null)
            {
                return Diagnostic.Create(
                    UnsupportedRuntimeDependency,
                    unsupported.Location,
                    unsupported.Symbol,
                    unsupported.Assembly);
            }
        }

        return null;
    }

    private static ArgumentSyntax? FindArgument(
        InvocationExpressionSyntax invocation,
        IParameterSymbol parameter)
    {
        foreach (var argument in invocation.ArgumentList.Arguments)
        {
            if (argument.NameColon?.Name.Identifier.ValueText == parameter.Name)
                return argument;
        }

        var positionalOrdinal = 0;
        foreach (var argument in invocation.ArgumentList.Arguments)
        {
            if (argument.NameColon != null)
                continue;

            if (positionalOrdinal == parameter.Ordinal)
                return argument;

            positionalOrdinal++;
        }

        return null;
    }

    private static void EmitInterceptors(
        SourceProductionContext context,
        ImmutableArray<InterceptedCall> calls)
    {
        if (calls.IsDefaultOrEmpty)
            return;

        var interceptors = MergeInterceptors(calls);

        var source = new StringBuilder(
            """
            // <auto-generated/>
            #nullable enable

            namespace System.Runtime.CompilerServices
            {
                [global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
                file sealed class InterceptsLocationAttribute : global::System.Attribute
                {
                    public InterceptsLocationAttribute(int version, string data)
                    {
                    }
                }
            }

            namespace Microsoft.Azure.Workflows.Sdk.GeneratedInterceptors
            {
                file static class WorkflowExpressionInterceptors
                {
            """);

        for (var index = 0; index < interceptors.Count; index++)
            AppendInterceptor(source, interceptors[index], index);

        source.AppendLine(
            """
                }
            }
            """);

        context.AddSource(
            "WorkflowExpressionInterceptors.g.cs",
            SourceText.From(source.ToString(), Encoding.UTF8));
    }

    private static void AppendInterceptor(
        StringBuilder source,
        MergedInterceptor call,
        int index)
    {
        var method = call.Method.OriginalDefinition;
        var receiverType = method.ReceiverType ?? method.ContainingType;
        var parameters = method.Parameters
            .Select(parameter =>
                $"{GetTypeName(parameter.Type)} {EscapeIdentifier(parameter.Name)}")
            .ToArray();
        var arguments = method.Parameters
            .Select(parameter => EscapeIdentifier(parameter.Name))
            .ToArray();

        source.Append("        ")
            .AppendLine(call.AttributeSyntax)
            .Append("        internal static ")
            .Append(GetTypeName(method.ReturnType))
            .Append(" Intercept_")
            .Append(index);

        if (method.TypeParameters.Length > 0)
        {
            source.Append('<')
                .Append(string.Join(", ", method.TypeParameters.Select(parameter => parameter.Name)))
                .Append('>');
        }

        source
            .Append("(this ")
            .Append(GetTypeName(receiverType))
            .Append(" receiver");

        if (parameters.Length > 0)
            source.Append(", ").Append(string.Join(", ", parameters));

        source.AppendLine(")")
            .AppendLine("        {");

        foreach (var expression in call.Expressions)
        {
            source.Append("            global::Microsoft.Azure.Workflows.Sdk.GeneratedWorkflowExpressionRegistry.Register(")
                .Append(arguments[expression.ParameterIndex])
                .Append(", global::Microsoft.Azure.Workflows.Sdk.GeneratedWorkflowExpression.")
                .Append(expression.IsLiteral ? "FromLiteral(" : "FromCSharp(")
                .Append(expression.IsLiteral ? expression.Source : ToStringLiteral(expression.Source));
            if (!expression.IsLiteral)
            {
                source.Append(", ")
                    .Append(RenderStringArray(expression.OperationIds))
                    .Append(", ")
                    .Append(RenderStringArray(expression.CapturedValueNames));
            }

            source
                .AppendLine("));");
        }

        if (call.OperationIds.Count > 0)
            source.Append("            var result = receiver.");
        else
            source.Append("            return receiver.");

        source
            .Append(EscapeIdentifier(method.Name))
            .Append('(')
            .Append(string.Join(", ", arguments))
            .AppendLine(");");

        foreach (var operationId in call.OperationIds)
        {
            source.Append("            global::Microsoft.Azure.Workflows.Sdk.GeneratedWorkflowOperationRegistry.Register(")
                .Append(ToStringLiteral(operationId))
                .AppendLine(", result);");
        }

        if (call.OperationIds.Count > 0)
            source.AppendLine("            return result;");

        source.AppendLine("        }");
    }

    private static List<MergedInterceptor> MergeInterceptors(
        ImmutableArray<InterceptedCall> calls)
    {
        var interceptors = new Dictionary<string, MergedInterceptor>(StringComparer.Ordinal);
        foreach (var call in calls)
        {
            if (!interceptors.TryGetValue(call.AttributeSyntax, out var expressionInterceptor))
            {
                expressionInterceptor = new MergedInterceptor(call.AttributeSyntax, call.Method);
                interceptors.Add(call.AttributeSyntax, expressionInterceptor);
            }

            expressionInterceptor.Expressions.AddRange(call.Expressions);

            foreach (var operation in call.OperationRegistrations)
            {
                if (!interceptors.TryGetValue(operation.AttributeSyntax, out var operationInterceptor))
                {
                    operationInterceptor = new MergedInterceptor(
                        operation.AttributeSyntax,
                        operation.Method);
                    interceptors.Add(operation.AttributeSyntax, operationInterceptor);
                }

                if (!operationInterceptor.OperationIds.Contains(operation.OperationId))
                    operationInterceptor.OperationIds.Add(operation.OperationId);
            }
        }

        return interceptors.Values.ToList();
    }

    private static string GetTypeName(ITypeSymbol type) =>
        type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

    private static string EscapeIdentifier(string identifier) =>
        SyntaxFacts.GetKeywordKind(identifier) == SyntaxKind.None ? identifier : $"@{identifier}";

    private static string ToStringLiteral(string value) =>
        SymbolDisplay.FormatLiteral(value, quote: true);

    private static string RenderStringArray(IEnumerable<string> values) =>
        $"new string[] {{ {string.Join(", ", values.Select(ToStringLiteral))} }}";

    private static string RenderLiteral(object? value, ITypeSymbol? type)
    {
        if (value == null)
            return "null";

        if (type?.TypeKind == TypeKind.Enum)
        {
            var enumField = type.GetMembers()
                .OfType<IFieldSymbol>()
                .FirstOrDefault(field =>
                    field.HasConstantValue &&
                    Equals(field.ConstantValue, value));
            var enumMemberValue = enumField?.GetAttributes()
                .FirstOrDefault(attribute =>
                    attribute.AttributeClass?.ToDisplayString() ==
                    "System.Runtime.Serialization.EnumMemberAttribute")
                ?.NamedArguments
                .FirstOrDefault(argument => argument.Key == "Value")
                .Value.Value as string;
            return ToStringLiteral(enumMemberValue ?? enumField?.Name ?? value.ToString()!);
        }

        return value switch
        {
            string text => ToStringLiteral(text),
            char character => SymbolDisplay.FormatLiteral(character, quote: true),
            bool boolean => boolean ? "true" : "false",
            float number => number.ToString("R", CultureInfo.InvariantCulture) + "f",
            double number => number.ToString("R", CultureInfo.InvariantCulture),
            decimal number => number.ToString(CultureInfo.InvariantCulture) + "m",
            long number => number.ToString(CultureInfo.InvariantCulture) + "L",
            ulong number => number.ToString(CultureInfo.InvariantCulture) + "UL",
            uint number => number.ToString(CultureInfo.InvariantCulture) + "U",
            _ => System.Convert.ToString(value, CultureInfo.InvariantCulture) ?? "null",
        };
    }

    private static bool TryRenderRewrittenLiteral(
        ExpressionSyntax expression,
        out string literal)
    {
        if (expression is LiteralExpressionSyntax literalExpression)
        {
            literal = literalExpression.IsKind(SyntaxKind.StringLiteralExpression)
                ? ToStringLiteral(literalExpression.Token.ValueText)
                : literalExpression.Token.Text;
            return true;
        }

        literal = null!;
        return false;
    }

    private sealed class InterceptedCall
    {
        public InterceptedCall(
            string attributeSyntax,
            IMethodSymbol method,
            ImmutableArray<GeneratedExpression> expressions,
            ImmutableArray<WorkflowOperationRegistration> operationRegistrations)
        {
            this.AttributeSyntax = attributeSyntax;
            this.Method = method;
            this.Expressions = expressions;
            this.OperationRegistrations = operationRegistrations;
        }

        public string AttributeSyntax { get; }

        public IMethodSymbol Method { get; }

        public ImmutableArray<GeneratedExpression> Expressions { get; }

        public ImmutableArray<WorkflowOperationRegistration> OperationRegistrations { get; }
    }

    private sealed class GeneratedExpression
    {
        public GeneratedExpression(
            int parameterIndex,
            string source,
            bool isLiteral,
            ImmutableArray<string> operationIds,
            ImmutableArray<string> capturedValueNames)
        {
            this.ParameterIndex = parameterIndex;
            this.Source = source;
            this.IsLiteral = isLiteral;
            this.OperationIds = operationIds;
            this.CapturedValueNames = capturedValueNames;
        }

        public int ParameterIndex { get; }

        public string Source { get; }

        public bool IsLiteral { get; }

        public ImmutableArray<string> OperationIds { get; }

        public ImmutableArray<string> CapturedValueNames { get; }
    }

    private sealed class MergedInterceptor
    {
        public MergedInterceptor(string attributeSyntax, IMethodSymbol method)
        {
            this.AttributeSyntax = attributeSyntax;
            this.Method = method;
        }

        public string AttributeSyntax { get; }

        public IMethodSymbol Method { get; }

        public List<GeneratedExpression> Expressions { get; } = new();

        public List<string> OperationIds { get; } = new();
    }
}

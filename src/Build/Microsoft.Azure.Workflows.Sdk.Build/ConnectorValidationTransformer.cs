// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

/// <summary>Adds method-entry validation while compiling the SDK's generated connectors.</summary>
public static class ConnectorValidationTransformer
{
#pragma warning disable RS2008 // These diagnostics belong to a command-line build tool, not an analyzer.
    private static readonly DiagnosticDescriptor InvalidContract = new(
        "WFSDK1100", "Invalid connector validation contract", "{0}", "WorkflowBuild",
        DiagnosticSeverity.Error, isEnabledByDefault: true);
#pragma warning restore RS2008

    public static ConnectorValidationResult Transform(CSharpCompilation compilation, IReadOnlyCollection<string> connectorPaths)
    {
        var comparer = OperatingSystem.IsWindows() ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;
        var paths = connectorPaths.Select(Path.GetFullPath).ToHashSet(comparer);
        var sources = new Dictionary<string, string>(comparer);
        var diagnostics = new List<Diagnostic>();
        var validationCount = 0;
        var methodCount = 0;
        void Error(SyntaxNode? node, string message) =>
            diagnostics.Add(Diagnostic.Create(InvalidContract, node?.GetLocation() ?? Location.None, message));

        var attribute = compilation.GetTypeByMetadataName("Microsoft.Azure.Workflows.Sdk.WorkflowExpressionAttribute");
        var sourceExpression = compilation.GetTypeByMetadataName("Microsoft.Azure.Workflows.Sdk.SourceExpression");
        var func = compilation.GetTypeByMetadataName("System.Func`1");
        var validationMethods = sourceExpression?.GetMembers("Validate").OfType<IMethodSymbol>().Where(m =>
            m.IsStatic && m.ReturnsVoid && m.Parameters.Length == 3 &&
            m.Parameters[0].Type.SpecialType == SpecialType.System_Delegate &&
            m.Parameters[1].Type.SpecialType == SpecialType.System_String &&
            m.Parameters[2].Type.SpecialType == SpecialType.System_Boolean).ToArray() ?? [];
        var validate = validationMethods.Length == 1 ? validationMethods[0] : null;
        if (attribute == null || func == null || validate == null ||
            !SymbolEqualityComparer.Default.Equals(attribute.ContainingAssembly, compilation.Assembly) ||
            !SymbolEqualityComparer.Default.Equals(sourceExpression!.ContainingAssembly, compilation.Assembly))
        {
            Error(null, "Connector injection requires the SDK's own WorkflowExpressionAttribute and SourceExpression.Validate definitions.");
            return new(sources, diagnostics, 0, 0);
        }

        if (paths.Count == 0 || paths.Count != connectorPaths.Count)
            Error(null, "Connector injection requires a nonempty, unique list of connector compiler inputs.");
        foreach (var tree in compilation.SyntaxTrees)
        {
            if (!paths.Remove(Path.GetFullPath(tree.FilePath))) continue;
            var model = compilation.GetSemanticModel(tree);
            var text = tree.GetText();
            var changes = new List<TextChange>();
            foreach (var parameterSyntax in tree.GetRoot().DescendantNodes().OfType<ParameterSyntax>())
            {
                if (model.GetDeclaredSymbol(parameterSyntax) is IParameterSymbol parameter &&
                    parameter.GetAttributes().Any(a => SymbolEqualityComparer.Default.Equals(a.AttributeClass, attribute)) &&
                    parameterSyntax.Parent?.Parent is not MethodDeclarationSyntax)
                    Error(parameterSyntax, "WorkflowExpression annotations in generated connectors must belong to supported method declarations.");
            }
            foreach (var method in tree.GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>())
            {
                var symbol = model.GetDeclaredSymbol(method);
                if (symbol == null)
                {
                    Error(method, "Cannot resolve a generated connector method.");
                    continue;
                }

                var parameters = symbol.Parameters.Where(p => p.GetAttributes().Any(a =>
                    SymbolEqualityComparer.Default.Equals(a.AttributeClass, attribute))).ToArray();
                if (parameters.Length == 0) continue;
                if (method.Body == null || symbol.IsAsync || symbol.ReturnsByRef || symbol.ReturnsByRefReadonly ||
                    method.Body.DescendantNodes().OfType<YieldStatementSyntax>().Any())
                {
                    Error(method, "Annotated connector methods must have a synchronous, non-iterator block body.");
                    continue;
                }

                foreach (var invocation in method.DescendantNodes().OfType<InvocationExpressionSyntax>())
                {
                    if (SymbolEqualityComparer.Default.Equals(model.GetSymbolInfo(invocation).Symbol, validate))
                        Error(invocation, "Generated connector sources must not contain explicit SourceExpression.Validate calls. Validation is injected by the SDK build.");
                }

                var statements = new List<string>();
                foreach (var parameter in parameters)
                {
                    var syntax = method.ParameterList.Parameters[parameter.Ordinal];
                    if (parameter.RefKind != RefKind.None || parameter.Type is not INamedTypeSymbol type ||
                        !SymbolEqualityComparer.Default.Equals(type.OriginalDefinition, func) ||
                        parameter.IsOptional != parameter.HasExplicitDefaultValue ||
                        parameter.IsOptional && parameter.ExplicitDefaultValue != null)
                    {
                        Error(syntax, "WorkflowExpression parameters must be ordinary Func<T> parameters with either no default or a null default.");
                        continue;
                    }
                    statements.Add($"global::Microsoft.Azure.Workflows.Sdk.SourceExpression.Validate({syntax.Identifier.Text}, " +
                        $"nameof({syntax.Identifier.Text}), required: {(parameter.IsOptional ? "false" : "true")});");
                }

                // Reset to the original brace line: the remaining source starts immediately after that brace.
                var position = method.Body.OpenBraceToken.Span.End;
                var originalLine = text.Lines.GetLineFromPosition(position);
                var line = originalLine.LineNumber + 1;
                var padding = position < originalLine.End ? new string(' ', position - originalLine.Start) : "";
                var insertion = "\n#line hidden\n" + string.Join("\n", statements) +
                    $"\n#line {line} {SymbolDisplay.FormatLiteral(tree.FilePath, quote: true)}\n{padding}";
                changes.Add(new TextChange(new TextSpan(position, 0), insertion));
                validationCount += statements.Count;
                methodCount++;
            }
            if (changes.Count > 0)
                sources.Add(tree.FilePath, "#line 1 " + SymbolDisplay.FormatLiteral(tree.FilePath, quote: true) +
                    "\n" + text.WithChanges(changes).ToString());
        }
        foreach (var path in paths)
            Error(null, $"Connector source is not in the compilation: {path}");
        if (methodCount == 0)
            Error(null, "No annotated connector methods were found; refusing to compile an unvalidated SDK.");
        return new(sources, diagnostics, validationCount, methodCount);
    }
}

public sealed record ConnectorValidationResult(
    IReadOnlyDictionary<string, string> Sources,
    IReadOnlyList<Diagnostic> Diagnostics,
    int ValidationCount,
    int MethodCount);

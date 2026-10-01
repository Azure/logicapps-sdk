namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Build;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public sealed class ConnectorValidationTransformerTests
{
    private const string Definitions = """
        namespace Microsoft.Azure.Workflows.Sdk {
            [System.AttributeUsage(System.AttributeTargets.Parameter)]
            public sealed class WorkflowExpressionAttribute : System.Attribute {}
            public static class SourceExpression {
                public static readonly System.Collections.Generic.List<string> Seen = new();
                internal static void Validate(System.Delegate expression, string parameterName, bool required = false) {
                    Seen.Add(parameterName);
                    if (expression == null && required) throw new System.ArgumentNullException(parameterName);
                }
            }
        }
        """;

    private static CSharpCompilation Compile(string members) => ConsumerCompilation.Compile("""
        using System;
        using Microsoft.Azure.Workflows.Sdk;
        using ExpressionMarker = Microsoft.Azure.Workflows.Sdk.WorkflowExpressionAttribute;
        """ + Definitions + "public class Connector {" + members + "}");

    private static ConnectorValidationResult Transform(CSharpCompilation compilation) =>
        ConnectorValidationTransformer.Transform(compilation, ["Consumer.cs"]);

    [Theory]
    [InlineData("WorkflowExpression")]
    [InlineData("WorkflowExpressionAttribute")]
    [InlineData("ExpressionMarker")]
    [InlineData("global::Microsoft.Azure.Workflows.Sdk.WorkflowExpressionAttribute")]
    public void Recognizes_bound_attribute_and_preserves_parameter_order(string attribute)
    {
        var input = Compile($$"""
            public object Call([{{attribute}}] Func<string> @event, [{{attribute}}] Func<int> count = null, string name = null)
            {
                return name;
            }
            """);
        var result = Transform(input);
        Assert.Empty(result.Diagnostics);
        Assert.Equal(2, result.ValidationCount);
        Assert.Equal(1, result.MethodCount);
        var output = CSharpSyntaxTree.ParseText(result.Sources["Consumer.cs"]);
        var method = output.GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>().Single(m => m.Identifier.Text == "Call");
        Assert.Contains("Validate(@event, nameof(@event), required: true)", method.Body!.Statements[0].ToString());
        Assert.Contains("Validate(count, nameof(count), required: false)", method.Body.Statements[1].ToString());
        Assert.Equal("return name;", method.Body.Statements[2].ToString());
        var assembly = ConsumerCompilation.Load(input.RemoveAllSyntaxTrees().AddSyntaxTrees(output));
        var instance = Activator.CreateInstance(assembly.GetType("Connector")!);
        var error = Assert.Throws<System.Reflection.TargetInvocationException>(() =>
            instance!.GetType().GetMethod("Call")!.Invoke(instance, [null, null, null]));
        Assert.Equal("event", Assert.IsType<ArgumentNullException>(error.InnerException).ParamName);
    }

    [Fact]
    public void Ignores_same_named_foreign_attribute_and_ordinary_parameters()
    {
        var compilation = Compile("""
            [AttributeUsage(AttributeTargets.Parameter)]
            public class WorkflowExpressionAttribute : Attribute {}
            public object Ignored([WorkflowExpression] Func<string> raw) => raw;
            public object Kept([ExpressionMarker] Func<string> value) { return value; }
            """);
        var result = Transform(compilation);
        Assert.Empty(result.Diagnostics);
        Assert.Equal(1, result.ValidationCount);
        Assert.Contains("public object Ignored([WorkflowExpression] Func<string> raw) => raw;", result.Sources["Consumer.cs"]);
    }

    [Theory]
    [InlineData("public object Call([WorkflowExpression] Func<string> value) => value;")]
    [InlineData("public async System.Threading.Tasks.Task<object> Call([WorkflowExpression] Func<string> value) { await System.Threading.Tasks.Task.Yield(); return value; }")]
    [InlineData("public System.Collections.Generic.IEnumerable<object> Call([WorkflowExpression] Func<string> value) { yield return value; }")]
    [InlineData("public object Call([WorkflowExpression] ref Func<string> value) { return value; }")]
    [InlineData("public object Call([WorkflowExpression] string value) { return value; }")]
    [InlineData("public Connector([WorkflowExpression] Func<string> value) {}")]
    [InlineData("public object Call([WorkflowExpression] Func<string> value) { SourceExpression.Validate(value, nameof(value), true); return value; }")]
    public void Rejects_unsupported_or_already_validated_contracts(string method)
    {
        var result = Transform(Compile(method));
        Assert.NotEmpty(result.Diagnostics);
        Assert.All(result.Diagnostics, d =>
        {
            Assert.Equal("WFSDK1100", d.Id);
            Assert.Equal(DiagnosticSeverity.Error, d.Severity);
        });
    }

    [Fact]
    public void Rejects_missing_duplicate_or_empty_source_inventory()
    {
        var compilation = Compile("public object Call([WorkflowExpression] Func<string> value) { return value; }");
        foreach (var paths in new string[][] { [], ["absent.cs"], ["Consumer.cs", "Consumer.cs"] })
            Assert.NotEmpty(ConnectorValidationTransformer.Transform(compilation, paths).Diagnostics);
    }

    [Fact]
    public void Refuses_to_inject_a_consumer_assembly()
    {
        var compilation = ConsumerCompilation.Compile("""
            using System;
            using Microsoft.Azure.Workflows.Sdk;
            public class Consumer {
                public object Call([WorkflowExpression] Func<string> value) { return value; }
            }
            """);
        Assert.Contains(Transform(compilation).Diagnostics, d => d.GetMessage().Contains("SDK's own"));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Requiredness_uses_the_active_compilation_defines(bool optional)
    {
        var compilation = Compile("""
            public object Call([WorkflowExpression] Func<string> value
            #if OPTIONAL
                = null
            #endif
            ) { return value; }
            """);
        var original = compilation.SyntaxTrees.Single();
        string[] defines = optional ? ["OPTIONAL"] : [];
        var options = ((CSharpParseOptions)original.Options).WithPreprocessorSymbols(defines);
        compilation = compilation.ReplaceSyntaxTree(original, CSharpSyntaxTree.ParseText(
            original.GetText(), options, original.FilePath));
        var result = Transform(compilation);
        Assert.Empty(result.Diagnostics);
        Assert.Equal(1, result.ValidationCount);
        Assert.Contains($"nameof(value), required: {(optional ? "false" : "true")}", result.Sources["Consumer.cs"]);
        Assert.Contains("#if OPTIONAL", result.Sources["Consumer.cs"]);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Preserves_original_error_locations_after_injection(bool singleLine)
    {
        var method = """
            public object Call([WorkflowExpression] Func<string> value)
            {
                return MissingName;
            }
            """;
        var compilation = Compile(singleLine ? method.Replace("\r", "").Replace("\n", " ") : method);
        var original = Assert.Single(compilation.GetDiagnostics().Where(d => d.Id == "CS0103")).Location.GetLineSpan();
        var transformed = Transform(compilation);
        Assert.Empty(transformed.Diagnostics);
        var output = compilation.RemoveAllSyntaxTrees().AddSyntaxTrees(CSharpSyntaxTree.ParseText(transformed.Sources["Consumer.cs"]));
        var actual = Assert.Single(output.GetDiagnostics().Where(d => d.Id == "CS0103")).Location.GetMappedLineSpan();
        Assert.Equal(original.Path, actual.Path);
        Assert.Equal(original.StartLinePosition, actual.StartLinePosition);
    }

    [Fact]
    public void Preserves_body_tokens_and_leaves_unselected_files_unchanged()
    {
        var compilation = Compile("""
            public object Call([WorkflowExpression] Func<string> value)
            {
                object BuildSourceInput() => value;
                return BuildSourceInput;
            }
            """).AddSyntaxTrees(CSharpSyntaxTree.ParseText("public class Model {}", path: "Model.cs"));
        var result = Transform(compilation);
        Assert.Empty(result.Diagnostics);
        Assert.Single(result.Sources);
        var before = compilation.SyntaxTrees.First().GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>().Last();
        var after = CSharpSyntaxTree.ParseText(result.Sources["Consumer.cs"]).GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>().Last();
        Assert.Equal(
            before.Body!.Statements.Select(s => s.ToString()),
            after.Body!.Statements.Skip(1).Select(s => s.ToString()));
        Assert.Equal(
            result.Sources["Consumer.cs"],
            Transform(compilation).Sources["Consumer.cs"]);
    }
}

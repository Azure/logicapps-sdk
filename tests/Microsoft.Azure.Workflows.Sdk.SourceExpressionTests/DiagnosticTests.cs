namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class DiagnosticTests
{
    [Theory, Trait("Catalog", "DG06")]
    [InlineData("SR13", "() => { var text = source.Output; return text[..2].ToUpperInvariant(); }", "string")]
    [InlineData("SR14", "async () => (await Task.FromResult(source.Output)).ToUpperInvariant()", "Task<string>")]
    [InlineData("CB10", "() => { string suffix = \"local\"; return source.Output + suffix; }", "string")]
    [InlineData("F02", "() => { return count.Output + 1; }", "int")]
    public void Unverified_block_and_async_capabilities_are_explicit_rejections(string catalog, string lambda, string resultType)
    {
        Assert.NotEmpty(catalog);
        var source = Source(Handles + $$"""
            var action = WorkflowActions.BuiltIn.Compose<{{resultType}}>(input: {{lambda}});
            return action.GetActionDefinition("Catalog");
            """);
        Assert.Empty(Compile(source).GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        var diagnostic = Assert.Single(Transform(source).Diagnostics);
        Assert.Equal("WFBUILD006", diagnostic.Id);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("host", diagnostic.GetMessage(), StringComparison.OrdinalIgnoreCase);
        Assert.Equal("Consumer.cs", diagnostic.Location.GetLineSpan().Path);
    }

    [Theory, Trait("Decision", "D16")]
    [InlineData("Task<string>", "Task.FromResult(source.Output)")]
    [InlineData("Task", "Task.CompletedTask")]
    [InlineData("ValueTask<string>", "new ValueTask<string>(source.Output)")]
    [InlineData("ValueTask", "new ValueTask()")]
    public void Task_results_without_async_keyword_require_verified_host_transport(string resultType, string expression)
    {
        var source = Source(Handles + $$"""
            return WorkflowActions.BuiltIn.Compose<{{resultType}}>(input: () => {{expression}}).GetActionDefinition("Catalog");
            """);
        var compilation = Compile(source);
        Assert.Empty(compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        var diagnostic = Assert.Single(global::Microsoft.Azure.Workflows.Sdk.Build.ExpressionCompilationTransformer.Transform(compilation).Diagnostics);
        Assert.Equal("WFBUILD006", diagnostic.Id);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("host", diagnostic.GetMessage(), StringComparison.OrdinalIgnoreCase);
        Assert.Contains("Task", diagnostic.GetMessage(), StringComparison.Ordinal);
        Assert.Contains("() => " + expression,
            compilation.SyntaxTrees.Single().GetText().ToString(diagnostic.Location.SourceSpan));
    }

    [Fact, Trait("Catalog", "P04c")]
    public void P04c_Runtime_loaded_delegate_is_rejected_without_loading_or_invoking_it()
    {
        var source = Source("""
            Func<string> message = LoadDelegateFromExternalConfiguration();
            var action = WorkflowActions.BuiltIn.Compose(inputs: message);
            return action.GetActionDefinition("Catalog");
            """, """
            private static Func<string> LoadDelegateFromExternalConfiguration()
                => throw new InvalidOperationException("Must not execute source discovery");
            """);
        var diagnostic = Assert.Single(Transform(source).Diagnostics);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("source", diagnostic.GetMessage(), StringComparison.OrdinalIgnoreCase);
    }

    [Fact, Trait("Catalog", "DG02b")]
    public void DG02b_Ambiguous_delegate_is_rejected()
    {
        var result = Transform(Source("""
            bool flagFromConfiguration = DateTime.UtcNow.Ticks > 0;
            Func<string> firstDelegate = () => "first";
            Func<string> secondDelegate = () => "second";
            Func<string> e = flagFromConfiguration ? firstDelegate : secondDelegate;
            return WorkflowActions.BuiltIn.Compose(inputs: e).GetActionDefinition("Catalog");
            """));
        Assert.Equal(DiagnosticSeverity.Error, Assert.Single(result.Diagnostics).Severity);
    }

    [Fact, Trait("Catalog", "CB12"), Trait("Catalog", "DG04"), Trait("Catalog", "L14"), Trait("Catalog", "F04")]
    public void CB12_Custom_getter_is_rejected_at_its_source_location()
    {
        var source = Source("""
            var model = Captured = new GetterModel();
            return WorkflowActions.BuiltIn.Compose(inputs: () => model.Text).GetActionDefinition("Catalog");
            """, "public static GetterModel Captured;");
        var compilation = Compile(source);
        var result = Microsoft.Azure.Workflows.Sdk.Build.ExpressionCompilationTransformer.Transform(compilation);
        var diagnostic = Assert.Single(result.Diagnostics);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("Text", diagnostic.GetMessage());
        Assert.Contains("model.Text", compilation.SyntaxTrees.Single().GetText().ToString(diagnostic.Location.SourceSpan));
        // The rejected original must remain safe even if someone bypasses the build diagnostic.
        var assembly = Load(compilation);
        Assert.Throws<NotSupportedException>(() => Invoke(assembly, "Consumer", "Build"));
        var captured = assembly.GetType("Consumer")!.GetField("Captured")!.GetValue(null)!;
        Assert.Equal(0, captured.GetType().GetField("Calls")!.GetValue(captured));
    }

    [Fact, Trait("Catalog", "DG03")]
    public void DG03_Stream_capture_is_not_evaluated()
    {
        var result = Transform(Source("""
            var capturedStream = new System.IO.MemoryStream();
            return WorkflowActions.BuiltIn.Compose<int>(input: () => capturedStream.ReadByte()).GetActionDefinition("Catalog");
            """));
        var diagnostic = Assert.Single(result.Diagnostics);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("MemoryStream", diagnostic.GetMessage());
    }

    [Fact, Trait("Catalog", "DG11")]
    public void DG11_Executable_handle_resolution_is_rejected()
    {
        var result = Transform(Source("""
            return WorkflowActions.BuiltIn.Compose<string>(input: () => GetAction().Output).GetActionDefinition("Catalog");
            """, """
            public static int Calls;
            private static IOutputWorkflowAction<string> GetAction()
            {
                Calls++;
                throw new InvalidOperationException("Handle getter executed");
            }
            """));
        var diagnostic = Assert.Single(result.Diagnostics);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("handle", diagnostic.GetMessage(), StringComparison.OrdinalIgnoreCase);
    }

    [Fact, Trait("Catalog", "DG09")]
    public void DG09_Unrelated_Compose_is_untouched_and_executes_normally()
    {
        var source = Source("""
            return new FlowTemplateAction { Inputs = Compose(() => "local") };
            """, """private static string Compose(Func<string> value) => value();""");
        var result = Transform(source);
        Assert.Empty(result.Diagnostics);
        Assert.Equal(source, result.Sources["Consumer.cs"]);
        var definition = (FlowTemplateAction)Invoke(Load(Compile(result.Sources["Consumer.cs"])), "Consumer", "Build")!;
        Assert.Equal("local", Token(definition).Value<string>());
    }

    [Fact, Trait("Catalog", "DG12"), Trait("Catalog", "F01")]
    public void DG12_Invalid_user_lambda_fails_normal_compilation()
    {
        var errors = Compile(Source("""
            Func<int> invalid = () => "text";
            return WorkflowActions.BuiltIn.Compose<int>(input: invalid).GetActionDefinition("Catalog");
            """)).GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Contains(errors, d => d.Id == "CS0029");
        Assert.All(errors, d => Assert.Equal("Consumer.cs", d.Location.GetLineSpan().Path));
    }

    [Fact, Trait("Catalog", "PK16")]
    public void PK16_Missing_transform_rejects_without_invoking_authoring_lambda()
    {
        var assembly = Load(Compile(Source("""
            return WorkflowActions.BuiltIn.Compose(inputs: () => RuntimeValues.NextText()).GetActionDefinition("Catalog");
            """)));
        var exception = Assert.Throws<NotSupportedException>(() => Invoke(assembly, "Consumer", "Build"));
        Assert.Contains("source", exception.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Equal(0, assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
    }

    [Fact, Trait("Catalog", "PK15")]
    public void PK15_Unsupported_descriptor_version_names_both_versions()
    {
        var exception = Assert.Throws<NotSupportedException>(() => SourceExpression.Literal(999, "value"));
        Assert.Contains("999", exception.Message);
        Assert.Contains("1", exception.Message);
        Assert.Contains("version", exception.Message, StringComparison.OrdinalIgnoreCase);
    }
}

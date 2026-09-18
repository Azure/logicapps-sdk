namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class FieldAndCaptureSafetyTests
{
    [Fact]
    public void Static_field_handle_resolves_final_name_without_reading_Output()
    {
        var built = Build(Source("""
            HeldSource = WorkflowActions.BuiltIn.Compose<string>(input: () => "seed").WithName("Initial");
            var action = WorkflowActions.BuiltIn.Compose<string>(input: () => HeldSource.Output);
            HeldSource.WithName("Renamed");
            return action.GetActionDefinition("Catalog");
            """, "public static IOutputWorkflowAction<string> HeldSource;"));
        Assert.Equal("@outputs('Renamed')", Token(built.Definition).Value<string>());
    }

    [Fact]
    public void Local_holder_field_is_a_real_action_binding_not_a_POCO_snapshot()
    {
        var built = Build(Source("""
            var holder = new Holder();
            holder.Source = WorkflowActions.BuiltIn.Compose<string>(input: () => "seed").WithName("Initial");
            var action = WorkflowActions.BuiltIn.Compose<string>(input: () => holder.Source.Output.ToUpperInvariant());
            holder.Source.WithName("Renamed");
            return action.GetActionDefinition("Catalog");
            """, "public sealed class Holder { public IOutputWorkflowAction<string> Source; }"));
        var emitted = Token(built.Definition).Value<string>()!;
        EqualSource("@csharp{outputs(\"Renamed\").ToObject<string>().ToUpperInvariant()}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Renamed"] = new JValue("hello") });
        Assert.Equal("HELLO", local.Value);
        Assert.Equal(["Renamed"], local.Reads);
    }

    [Fact]
    public void Instance_field_in_authoring_method_is_not_an_executable_instance_dependency()
    {
        var built = Build(Source("""
            var holder = new Holder();
            holder.Source = WorkflowActions.BuiltIn.Compose<string>(input: () => "seed").WithName("FieldSource");
            return holder.Define();
            """, """
            public sealed class Holder
            {
                public IOutputWorkflowAction<string> Source;
                public FlowTemplateAction Define() =>
                    WorkflowActions.BuiltIn.Compose<string>(input: () => this.Source.Output).GetActionDefinition("Catalog");
            }
            """));
        Assert.Equal("@outputs('FieldSource')", Token(built.Definition).Value<string>());
    }

    [Theory]
    [InlineData("++captured")]
    [InlineData("captured++")]
    [InlineData("captured += 1")]
    [InlineData("captured = 3")]
    [InlineData("Mutate(ref captured)")]
    [InlineData("Assign(out captured)")]
    [InlineData("Read(in captured)")]
    public void Captured_writes_and_by_reference_arguments_fail_before_snapshot_substitution(string expression)
    {
        var source = Source($$"""
            int captured = 1;
            return WorkflowActions.BuiltIn.Compose<int>(input: () => {{expression}}).GetActionDefinition("Catalog");
            """, """
            public static int Mutate(ref int value) => ++value;
            public static int Assign(out int value) { value = 7; return value; }
            public static int Read(in int value) => value;
            """);
        var compilation = Compile(source);
        Assert.Empty(compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        var transformed = global::Microsoft.Azure.Workflows.Sdk.Build.ExpressionCompilationTransformer.Transform(compilation);
        var diagnostic = Assert.Single(transformed.Diagnostics);
        Assert.Equal("WFBUILD003", diagnostic.Id);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("captured", compilation.SyntaxTrees.Single().GetText().ToString(diagnostic.Location.SourceSpan));
    }
}

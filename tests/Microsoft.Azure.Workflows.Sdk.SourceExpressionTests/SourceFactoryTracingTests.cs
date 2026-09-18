namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Azure.Workflows.Sdk.Build;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class SourceFactoryTracingTests
{
    private const string Factory = """
        private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
            => () => action.Output + suffix;
        """;

    [Fact, Trait("Catalog", "DG02c")]
    public void DG02c_Source_visible_factory_binds_parameters_without_inlining_its_call()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(input: Factory(source, "!")).GetActionDefinition("Catalog");
            """, Factory));
        EqualSource("""@csharp{outputs("Source").ToObject<string>() + "!"}""",
            Token(result.Definition).Value<string>()!);
        var transformed = result.Transformation.Sources["Consumer.cs"];
        Assert.Contains("input: Factory(source, \"!\")", transformed);
        Assert.Contains("SourceBinding.Capture(suffix", transformed);
        Assert.Equal("value!", LocalNativeHost.Evaluate(Token(result.Definition).Value<string>()!,
            new() { ["Source"] = "value" }).Value);
    }

    [Fact]
    public void Named_factory_arguments_keep_order_count_and_lazy_runtime_calls()
    {
        var source = Source(Handles + """
            var action = WorkflowActions.BuiltIn.Compose<string>(
                input: Factory(suffix: ReadSuffix(), action: ReadAction(source)));
            source.Name = "Final";
            return action.GetActionDefinition("Catalog");
            """, """
            public static List<string> Events = new();
            private static string ReadSuffix() { Events.Add("suffix"); RuntimeValues.Calls++; return "!"; }
            private static IOutputWorkflowAction<string> ReadAction(IOutputWorkflowAction<string> value)
            { Events.Add("action"); RuntimeValues.Calls++; return value; }
            private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
                => () => action.Output + suffix + RuntimeValues.NextText();
            """);
        var prepared = Prepare(source);
        Assert.Equal(0, prepared.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var definition = (FlowTemplateAction)Invoke(prepared.Assembly, "Consumer", "Build")!;
        Assert.Contains(prepared.Transformation.Dependencies,
            dependency => dependency.TypeIdentifier == "RuntimeValues" && dependency.Member == "NextText");
        Assert.DoesNotContain(prepared.Transformation.Dependencies, dependency => dependency.Member == "Factory");
        Assert.Equal(2, prepared.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        Assert.Equal(["suffix", "action"],
            (List<string>)prepared.Assembly.GetType("Consumer")!.GetField("Events")!.GetValue(null)!);
        var actual = LocalNativeHost.Evaluate(Token(definition).Value<string>()!, new() { ["Final"] = "value" });
        Assert.Equal("value!hello", actual.Value);
        Assert.Equal(1, actual.Calls);
        Assert.Equal(["Final"], actual.Reads);
    }

    [Theory]
    [InlineData(true, "value!", 0)]
    [InlineData(false, "hello", 1)]
    public void Factory_value_branches_remain_lazy(bool selected, string expected, int calls)
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(input: Factory(flag, source, "!")).GetActionDefinition("Catalog");
            """, """
            private static Func<string> Factory(IOutputWorkflowAction<bool> flag, IOutputWorkflowAction<string> action, string suffix)
                => () => flag.Output ? action.Output + suffix : RuntimeValues.NextText();
            """));
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var actual = LocalNativeHost.Evaluate(Token(result.Definition).Value<string>()!,
            new() { ["Flag"] = selected, ["Source"] = "value" });
        Assert.Equal(expected, actual.Value);
        Assert.Equal(calls, actual.Calls);
        Assert.Equal(selected ? ["Flag", "Source"] : new[] { "Flag" }, actual.Reads);
    }

    [Fact]
    public void Local_single_return_factory_supports_single_origin_aliases_and_final_names()
    {
        var result = Build(Source(Handles + """
            Func<string> Make(IOutputWorkflowAction<string> action, string suffix)
            {
                return () => action.Output + suffix;
            }
            var suffix = "!";
            var expression = Make(source, suffix);
            var alias = expression;
            suffix = "?";
            source.Name = "Final";
            return WorkflowActions.BuiltIn.Compose<string>(input: alias).GetActionDefinition("Catalog");
            """));
        EqualSource("""@csharp{outputs("Final").ToObject<string>() + "!"}""",
            Token(result.Definition).Value<string>()!);
    }

    [Fact]
    public void Generic_factory_keeps_concrete_binding_types()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<int>(input: Factory(count)).GetActionDefinition("Catalog");
            """, """
            private static Func<T> Factory<T>(IOutputWorkflowAction<T> action) => () => action.Output;
            """));
        Assert.Equal("@outputs('Count')", Token(result.Definition).Value<string>());
    }

    [Fact]
    public void Factory_definition_can_be_in_another_source_tree()
    {
        var source = Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(input: Factory(source, "!")).GetActionDefinition("Catalog");
            """).Replace("public static class Consumer", "public static partial class Consumer");
        var factorySource = """
            using System;
            using Microsoft.Azure.Workflows.Sdk;
            public static partial class Consumer
            {
                private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
                    => () => action.Output + suffix;
            }
            """;
        var original = Compile(source).AddSyntaxTrees(CSharpSyntaxTree.ParseText(factorySource,
            new CSharpParseOptions(LanguageVersion.CSharp13), "Factory.cs"));
        Assert.Empty(original.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        var transformed = ExpressionCompilationTransformer.Transform(original);
        Assert.Empty(transformed.Diagnostics);
        Assert.Contains("SourceExpression.", transformed.Sources["Factory.cs"]);
        var assembly = Load(Compile(transformed.Sources["Consumer.cs"]).AddSyntaxTrees(
            CSharpSyntaxTree.ParseText(transformed.Sources["Factory.cs"],
                new CSharpParseOptions(LanguageVersion.CSharp13), "Factory.cs")));
        var definition = (FlowTemplateAction)Invoke(assembly, "Consumer", "Build")!;
        EqualSource("""@csharp{outputs("Source").ToObject<string>() + "!"}""", Token(definition).Value<string>()!);
    }

    [Theory]
    [InlineData("""
        private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
        { RuntimeValues.Calls++; return () => action.Output + suffix; }
        """)]
    [InlineData("""
        private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
            => Factory(action, suffix);
        """)]
    [InlineData("""
        private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
            => suffix.Length > 0 ? () => action.Output : () => suffix;
        """)]
    [InlineData("""
        private static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
            => throw new InvalidOperationException("Must never execute during transformation.");
        """)]
    [InlineData("""
        public static Func<string> Factory(IOutputWorkflowAction<string> action, string suffix)
            => () => action.Output + suffix;
        """)]
    public void Rejects_unproven_factory_origins_without_execution(string factory)
    {
        var result = Transform(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(input: Factory(source, "!")).GetActionDefinition("Catalog");
            """, factory));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Theory]
    [InlineData("""var other = Factory(source, "!"); _ = other();""")]
    [InlineData("""var other = Factory(source, "!"); Console.WriteLine(other);""")]
    [InlineData("""Func<IOutputWorkflowAction<string>, string, Func<string>> escaped = Factory;""")]
    [InlineData("""var other = Factory(source, "!"); other = () => "replacement";""")]
    [InlineData("""var other = Factory(source, "!"); var saved = other; saved();""")]
    public void Rejects_non_sdk_consumers_method_groups_and_reassignment(string otherUse)
    {
        var result = Transform(Source("""
            var source = WorkflowActions.BuiltIn.Compose<string>(input: () => "seed").WithName("Source");
            """ + otherUse + """
            return WorkflowActions.BuiltIn.Compose<string>(input: Factory(source, "!")).GetActionDefinition("Catalog");
            """, Factory));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Fact]
    public void Rejects_mutable_factory_capture_timing()
    {
        var result = Transform(Source(Handles + """
            var values = new[] { "!" };
            var expression = Factory(source, values);
            values[0] = "?";
            return WorkflowActions.BuiltIn.Compose<string>(input: expression).GetActionDefinition("Catalog");
            """, """
            private static Func<string> Factory(IOutputWorkflowAction<string> action, string[] suffixes)
                => () => action.Output + suffixes[0];
            """));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Theory]
    [InlineData("Activator.CreateInstance<Func<string>>()")]
    [InlineData("selector()")]
    public void Rejects_unavailable_or_indirect_factory_origins(string expression)
    {
        var result = Transform(Source($$"""
            Func<Func<string>> selector = () => () => RuntimeValues.NextText();
            return WorkflowActions.BuiltIn.Compose<string>(input: {{expression}}).GetActionDefinition("Catalog");
            """));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Fact]
    public void Rejects_ambiguous_factory_selection()
    {
        var result = Transform(Source(Handles + """
            var selected = flag.Output ? Factory(source, "!") : Factory(source, "?");
            return WorkflowActions.BuiltIn.Compose<string>(input: selected).GetActionDefinition("Catalog");
            """, Factory));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Fact]
    public void Rejects_factory_alias_deconstruction_writes()
    {
        var result = Transform(Source(Handles + """
            var first = Factory(source, "!");
            var second = Factory(source, "?");
            (first, second) = (second, first);
            return WorkflowActions.BuiltIn.Compose<string>(input: first).GetActionDefinition("Catalog");
            """, Factory));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Fact]
    public void Rejects_enclosing_local_capture_in_local_factory()
    {
        var result = Transform(Source(Handles + """
            var suffix = "!";
            Func<string> Factory(IOutputWorkflowAction<string> action) => () => action.Output + suffix;
            var expression = Factory(source);
            suffix = "?";
            return WorkflowActions.BuiltIn.Compose<string>(input: expression).GetActionDefinition("Catalog");
            """));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Fact]
    public void Rejects_annotated_non_sdk_consumer_of_factory_result()
    {
        var result = Transform(Source(Handles + """
            Execute(Factory(source, "!"));
            return WorkflowActions.BuiltIn.Compose<string>(input: Factory(source, "!")).GetActionDefinition("Catalog");
            """, Factory + """
            private static void Execute([WorkflowExpression] Func<string> expression) => expression();
            """));
        Assert.Contains(result.Diagnostics, d => d.Id == "WFBUILD001");
    }

    [Fact]
    public void Unused_factories_and_ordinary_delegates_are_not_rewritten()
    {
        var result = Build(Source("""
            Func<string> ordinary = () => "ordinary";
            var value = ordinary();
            return WorkflowActions.BuiltIn.Compose<string>(input: () => value).GetActionDefinition("Catalog");
            """, Factory));
        Assert.Equal("ordinary", Token(result.Definition).Value<string>());
        Assert.Contains("=> () => action.Output + suffix", result.Transformation.Sources["Consumer.cs"]);
        Assert.Contains("Func<string> ordinary = () => \"ordinary\"", result.Transformation.Sources["Consumer.cs"]);
    }
}

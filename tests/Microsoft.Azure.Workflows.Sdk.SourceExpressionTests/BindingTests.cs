namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class BindingTests
{
    [Theory]
    [InlineData("L08", "message", "string message = \"hello\";", "\"hello\"")]
    [InlineData("L09", "n", "int n = 7;", "7")]
    [InlineData("L10", "model.Child.Text", "var model = new LocalModel { Child = new LocalLeaf { Text = \"hello\" } };", "\"hello\"")]
    [InlineData("L13", "model.Text", "var model = new LocalLeaf { Text = null };", "null")]
    [InlineData("SC06", "unrelated.Body", "var unrelated = new NamedBody { Body = \"local\" };", "\"local\"")]
    [InlineData("CB14", "message", "var local = new JValue(\"world\"); var message = \"hello\" + local;", "\"helloworld\"")]
    public void Approved_captures_are_typed_snapshots(string catalog, string expression, string setup, string expected)
    {
        Assert.NotEmpty(catalog);
        Assert.True(JToken.DeepEquals(JToken.Parse(expected), Input(expression, setup) ?? JValue.CreateNull()));
    }

    [Fact, Trait("Catalog", "CB01"), Trait("Catalog", "CB02")]
    public void CB02_Scalar_capture_is_frozen_at_construction()
    {
        EqualSource(
            "@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant() + \"!\"}",
            Native("source.Output.ToUpperInvariant() + suffix", "string suffix = \"!\";", "suffix = \"changed\";"));
    }

    [Fact, Trait("Catalog", "L12")]
    public void L12_Auto_property_capture_is_frozen_at_construction()
    {
        Assert.Equal("hello", Input("model.Child.Text",
            "var model = new LocalModel { Child = new LocalLeaf { Text = \"hello\" } };",
            "model.Child.Text = \"changed\";")!.Value<string>());
    }

    [Fact, Trait("Catalog", "CB03")]
    public void CB03_Workflow_handle_uses_final_name()
    {
        EqualSource("@csharp{outputs(\"Renamed\").ToObject<string>().ToUpperInvariant()}",
            Native("source.Output.ToUpperInvariant()", after: "source.WithName(\"Renamed\");"));
    }

    [Fact, Trait("Catalog", "CB04")]
    public void CB04_Escaped_capture_is_not_identifier_substitution()
    {
        var emitted = Native("source.Output + suffix", """string suffix = "\"\\source.Output";""");
        EqualSource("""@csharp{outputs("Source").ToObject<string>() + "\"\\source.Output"}""", emitted);
        Assert.Equal("A\"\\source.Output", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("A") }).Value);
    }

    [Fact, Trait("Catalog", "R13"), Trait("Catalog", "R13b")]
    public void R13_Final_name_escaping_depends_on_language()
    {
        Assert.Equal("@outputs('O''Brien')", Input("source.Output", after: "source.WithName(\"O'Brien\");")!.Value<string>());
        EqualSource("@csharp{outputs(\"O'Brien\").ToObject<string>().ToUpperInvariant()}",
            Native("source.Output.ToUpperInvariant()", after: "source.WithName(\"O'Brien\");"));
    }

    [Fact, Trait("Catalog", "CB06")]
    public void CB06_Static_method_is_not_executed_during_definition_generation()
    {
        var result = Build(Source("""
            var action = WorkflowActions.BuiltIn.Compose<string>(
                input: () => string.Format("{0}/{0}", RuntimeValues.NextText()));
            return action.GetActionDefinition("Catalog");
            """));
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{string.Format(\"{0}/{0}\", RuntimeValues.NextText())}", emitted);
        var runtime = LocalNativeHost.Evaluate(emitted, new());
        Assert.Equal("hello/hello", runtime.Value);
        Assert.Equal(1, runtime.Calls);
    }

    [Fact, Trait("Catalog", "N08")]
    public void N08_Static_getter_is_not_executed_until_local_runtime()
    {
        var result = Build(Source("""
            var action = WorkflowActions.BuiltIn.Compose<string>(input: () => RuntimeValues.CurrentText);
            return action.GetActionDefinition("Catalog");
            """));
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{RuntimeValues.CurrentText}", emitted);
        var runtime = LocalNativeHost.Evaluate(emitted, new());
        Assert.Equal("hello", runtime.Value);
        Assert.Equal(1, runtime.Calls);
    }

    [Fact, Trait("Catalog", "CB07")]
    public void CB07_Loop_creates_separate_construction_snapshots()
    {
        var result = Build(Source("""
            var actions = new List<IOutputWorkflowAction<int>>();
            for (int i = 0; i < 3; i++)
                actions.Add(WorkflowActions.BuiltIn.Compose<int>(input: () => i + 1));
            return new FlowTemplateAction
            {
                Inputs = new JArray(actions.Select(a => a.GetActionDefinition("Catalog").Inputs))
            };
            """));
        var values = Assert.IsType<JArray>(result.Definition.Inputs);
        Assert.Equal(3, values.Count);
        for (var i = 0; i < 3; i++)
        {
            var emitted = values[i].Value<string>()!;
            EqualSource($"@csharp{{{i} + 1}}", emitted);
            Assert.Equal(i + 1, LocalNativeHost.Evaluate(emitted, new()).Value);
        }
    }

    [Fact, Trait("Catalog", "CB08")]
    public void CB08_Helper_parameters_bind_without_source_name_assumptions()
    {
        var result = Build(Source(Handles + """
            return Create(source, "!").GetActionDefinition("Catalog");
            """, """
            private static IOutputWorkflowAction<string> Create(IOutputWorkflowAction<string> action, string ending)
                => WorkflowActions.BuiltIn.Compose<string>(input: () => action.Output + ending);
            """));
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>() + \"!\"}", Token(result.Definition).Value<string>()!);
    }

    [Fact, Trait("Catalog", "CB13")]
    public void CB13_Same_initial_names_do_not_merge_handle_identity()
    {
        var result = Build(Source("""
            var first = WorkflowActions.BuiltIn.Compose<string>(input: () => "a").WithName("Temporary");
            var second = WorkflowActions.BuiltIn.Compose<string>(input: () => "b").WithName("Temporary");
            var a = WorkflowActions.BuiltIn.Compose<int>(input: () => first.Output.Length);
            var b = WorkflowActions.BuiltIn.Compose<int>(input: () => second.Output.Length);
            first.WithName("A");
            second.WithName("B");
            return new FlowTemplateAction
            {
                Inputs = new JArray(a.GetActionDefinition("Catalog").Inputs, b.GetActionDefinition("Catalog").Inputs)
            };
            """));
        EqualSource("@csharp{outputs(\"A\").ToObject<string>().Length}", Token(result.Definition)[0]!.Value<string>()!);
        EqualSource("@csharp{outputs(\"B\").ToObject<string>().Length}", Token(result.Definition)[1]!.Value<string>()!);
    }

    [Fact, Trait("Catalog", "DG02")]
    public void DG02_Source_visible_single_origin_delegate_is_traced()
    {
        var result = Build(Source(Handles + """
            Func<string> e = () => source.Output;
            var action = WorkflowActions.BuiltIn.Compose(inputs: e);
            return action.GetActionDefinition("Catalog");
            """));
        Assert.Equal("@outputs('Source')", Token(result.Definition).Value<string>());
    }

    [Fact, Trait("Catalog", "P04b")]
    public void P04b_Source_visible_interpolation_delegate_is_traced()
    {
        var result = Build(Source(Handles + """
            Func<string> message = () => $"hello{trigger.TriggerOutput.Body}";
            var action = WorkflowActions.BuiltIn.Compose(inputs: message);
            return action.GetActionDefinition("Catalog");
            """));
        Assert.Equal("hello@{triggerBody()}", Token(result.Definition).Value<string>());
    }

    [Fact, Trait("Catalog", "IN01")]
    public void IN01_Real_sdk_fluent_authoring_retains_action_name()
    {
        var result = Build(Source(Handles + """
            var action = WorkflowActions.BuiltIn.Compose(inputs: () => source.Output.ToUpperInvariant()).WithName("Upper");
            if (action.Name != "Upper") throw new InvalidOperationException("Action name lost.");
            return action.GetActionDefinition("Catalog");
            """));
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}", Token(result.Definition).Value<string>()!);
    }
}

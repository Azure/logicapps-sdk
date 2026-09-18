namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CoreLiteralAndStructureCatalogTests
{
    [Fact, Trait("Catalog", "L11")]
    public void Captured_auto_property_can_feed_a_native_method()
    {
        var emitted = Native("model.Child.Text.ToUpperInvariant()",
            """var model = new LocalModel { Child = new LocalLeaf { Text = "hello" } };""");
        EqualSource("@csharp{\"hello\".ToUpperInvariant()}", emitted);
        Assert.Equal("HELLO", LocalNativeHost.Evaluate(emitted, new()).Value);
    }

    [Fact, Trait("Catalog", "L15")]
    public void Literal_escaping_preserves_quotes_backslashes_and_template_looking_text()
    {
        Assert.Equal("say \"hi\" at C:\\temp {triggerBody()}",
            Input("\"say \\\"hi\\\" at C:\\\\temp {triggerBody()}\"")!.Value<string>());
    }

    [Fact, Trait("Catalog", "L18")]
    public void Explicit_null_required_name_reports_the_destination()
    {
        var exception = Assert.Throws<ArgumentException>(() => Build(Source("""
            return WorkflowActions.BuiltIn.Variables.InitializeVariable<string>(
                name: () => (string)null, value: () => "value").GetActionDefinition("Catalog");
            """)));
        Assert.Equal("name", exception.ParamName);
    }

    [Fact, Trait("Catalog", "P01"), Trait("Catalog", "P02")]
    public void Precomputed_string_provenance_is_not_invented()
    {
        const string setup = """var localBody = new JValue("world"); var message = "hello" + localBody;""";
        Assert.Equal("helloworld", Input("message", setup)!.Value<string>());
        var emitted = Native("message.ToUpperInvariant()", setup);
        EqualSource("@csharp{\"helloworld\".ToUpperInvariant()}", emitted);
        Assert.Equal("HELLOWORLD", LocalNativeHost.Evaluate(emitted, new()).Value);
    }

    [Fact, Trait("Catalog", "P05")]
    public void User_invoked_expression_tree_result_is_only_a_value_snapshot()
    {
        var result = Input("result", """
            var localBody = new JValue("world");
            System.Linq.Expressions.Expression<Func<string>> e = () => "hello" + localBody;
            var result = e.Compile().Invoke();
            """);
        Assert.Equal("helloworld", result!.Value<string>());
    }

    [Fact, Trait("Catalog", "R03")]
    public void Actual_managed_trigger_body_is_a_reference()
    {
        Assert.Equal("@triggerBody()", Input("managedTrigger.TriggerBody", """
            var managedTrigger = WorkflowTriggers.Managed.Azurequeues("connection")
                .OnMessages(storageAccountName: () => "account", queueName: () => "queue");
            """)!.Value<string>());
    }

    [Fact, Trait("Catalog", "R05"), Trait("Catalog", "R06")]
    public void Typed_body_navigation_honors_declared_json_property_name()
    {
        const string setup = """
            var sharepoint = WorkflowActions.BuiltIn.CustomCode<ItemsList>(
                _ => Task.FromResult<ItemsList>(null)).WithName("GetItems");
            """;
        Assert.Equal("@body('GetItems')", Input("sharepoint.Body", setup)!.Value<string>());
        Assert.Equal("@body('GetItems')['value']", Input("sharepoint.Body.Value", setup)!.Value<string>());
    }

    [Fact, Trait("Catalog", "R12")]
    public void Local_properties_named_like_workflow_members_are_not_workflow_references()
    {
        Assert.Equal("local", Input("model.TriggerOutput.Body", """
            var model = new TriggerNamedModel { TriggerOutput = new NamedBody { Body = "local" } };
            """)!.Value<string>());
    }

    [Fact, Trait("Catalog", "Q03")]
    public void Nested_structural_payload_preserves_reference_and_literal_array_leaves()
    {
        var actual = Input("""new { nested = new { body = trigger.TriggerOutput.Body }, labels = new[] { "a", "b" } }""");
        Assert.True(JToken.DeepEquals(JObject.Parse("""{"nested":{"body":"@triggerBody()"},"labels":["a","b"]}"""), actual));
    }

    [Fact, Trait("Catalog", "Q06")]
    public void Executable_headers_expression_is_rejected_without_invocation()
    {
        var prepared = Prepare(Source("""
            return WorkflowActions.BuiltIn.Response(headers: () => RuntimeValues.CreateHeaders()).GetActionDefinition("Catalog");
            """));
        var exception = Assert.Throws<NotSupportedException>(() => Invoke(prepared.Assembly, "Consumer", "Build"));
        Assert.Contains("expression", exception.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Equal(0, prepared.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
    }

    [Fact, Trait("Catalog", "Q07")]
    public void Captured_JObject_is_an_independent_snapshot()
    {
        var actual = Input("payload", """var payload = JObject.Parse("{\"n\":1}");""", """payload["n"] = 2;""");
        Assert.True(JToken.DeepEquals(JObject.Parse("""{"n":1}"""), actual));
    }

    [Fact, Trait("Catalog", "Q07b")]
    public void Captured_JArray_is_cloned_not_aliased()
    {
        var actual = Input("payload", "var payload = new JArray(1, 2);", "payload[0] = 9;");
        Assert.True(JToken.DeepEquals(new JArray(1, 2), actual));
    }

    [Fact, Trait("Catalog", "Q08")]
    public void Unsupported_captured_POCO_is_a_source_error_not_ToString()
    {
        var result = Transform(Source("""
            var model = new DisplayModel { Id = 1 };
            return WorkflowActions.BuiltIn.Compose<object>(input: () => model).GetActionDefinition("Catalog");
            """));
        var diagnostic = Assert.Single(result.Diagnostics);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("DisplayModel", diagnostic.GetMessage());
    }

    [Fact, Trait("Catalog", "F10")]
    public void Captured_escaped_text_keeps_source_and_json_escaping_separate()
    {
        var emitted = Native("text.ToUpperInvariant()", """string text = "a\"b\\c";""");
        EqualSource("""@csharp{"a\"b\\c".ToUpperInvariant()}""", emitted);
        Assert.Equal("""A"B\C""", LocalNativeHost.Evaluate(emitted, new()).Value);
        Assert.Equal(emitted, JToken.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(emitted)).Value<string>());
    }
}

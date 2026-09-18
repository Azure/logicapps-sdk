namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class FinalCatalogGapTests
{
    [Theory]
    [InlineData("P04", "$\"hello{trigger.TriggerOutput.Body}\"", "hello@{triggerBody()}")]
    [InlineData("DG01", "source.Output", "@outputs('Source')")]
    public void Source_visible_Expression_local_requires_unchanged_authoring_compatibility(
        string catalog, string input, string expected)
    {
        Assert.NotEmpty(catalog);
        var original = Compile(Source(Handles + $$"""
            Expression<Func<string>> e = () => {{input}};
            return WorkflowActions.BuiltIn.Compose(inputs: e).GetActionDefinition("Catalog");
            """, imports: "using System.Linq.Expressions;"));
        Assert.All(original.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error), d => Assert.Equal("CS1503", d.Id));
        var transformed = global::Microsoft.Azure.Workflows.Sdk.Build.ExpressionCompilationTransformer.Transform(original);
        Assert.Empty(transformed.Diagnostics);
        var definition = (FlowTemplateAction)Invoke(Load(Compile(transformed.Sources["Consumer.cs"])), "Consumer", "Build")!;
        Assert.Equal(expected, Token(definition).Value<string>());
    }

    [Theory]
    [InlineData("F03", "Expression.Lambda<Func<int>>(Expression.Block(Expression.Constant(1)))", "int")]
    [InlineData("DG01b", "LoadExpressionAtRuntime()", "string")]
    public void Runtime_expression_trees_are_rejected_by_real_API_or_source_diagnostics(string catalog, string input, string type)
    {
        Assert.NotEmpty(catalog);
        var source = Source($$"""
            Expression<Func<{{type}}>> e = {{input}};
            return WorkflowActions.BuiltIn.Compose<{{type}}>(input: e).GetActionDefinition("Catalog");
            """, """
            public static Expression<Func<string>> LoadExpressionAtRuntime() =>
                throw new InvalidOperationException("Runtime expression loader must not execute.");
            """, "using System.Linq.Expressions;");
        var transformed = Transform(source);
        var errors = transformed.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Contains(errors, d => d.Id == "CS1503" || d.Id == "WFBUILD001");
        Assert.All(transformed.Sources.Values, emitted => Assert.DoesNotContain(".Compile(", emitted));
    }

    [Fact, Trait("Catalog", "I03")]
    public void Response_status_cast_is_native_numeric_not_enum_wire_text()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Response(statusCode: () => (System.Net.HttpStatusCode)count.Output).GetActionDefinition("Catalog");
            """));
        var emitted = Token(result.Definition)["statusCode"]!.Value<string>()!;
        EqualSource("@csharp{(int)(System.Net.HttpStatusCode)outputs(\"Count\").ToObject<int>()}", emitted);
        Assert.Equal(202, Assert.IsType<int>(LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(202) }).Value));
    }

    [Fact, Trait("Catalog", "I10"), Trait("Catalog", "IN05")]
    public void Explicit_zero_Response_status_is_rejected_instead_of_defaulted()
    {
        JToken? emitted = null;
        var error = Assert.Throws<ArgumentOutOfRangeException>(() => emitted = Token(Build(Source("""
            return WorkflowActions.BuiltIn.Response(statusCode: () => default(System.Net.HttpStatusCode)).GetActionDefinition("Catalog");
            """)).Definition));
        Assert.Equal("statusCode", error.ParamName);
        Assert.Contains("zero", error.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Null(emitted);
    }

    [Fact, Trait("Catalog", "I05")]
    public void Until_uses_native_predicate_without_a_Condition_host_claim()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Control.Until(expression: () => count.Output >= 3,
                actions: () => WorkflowActions.BuiltIn.Compose(inputs: () => "loop")).GetActionDefinition("Catalog");
            """));
        var emitted = result.Definition.Expression.Value<string>()!;
        EqualSource("@csharp{outputs(\"Count\").ToObject<int>() >= 3}", emitted);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3) }).Value);
        Assert.Equal(false, LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(2) }).Value);
    }

    [Fact, Trait("Catalog", "I06")]
    public void Switch_selector_keeps_native_integer_calculation()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Control.Switch(on: () => count.Output + 1,
                cases: () => new Dictionary<string, SwitchCase>()).GetActionDefinition("Catalog");
            """));
        var emitted = result.Definition.Expression.Value<string>()!;
        EqualSource("@csharp{outputs(\"Count\").ToObject<int>() + 1}", emitted);
        Assert.Equal(4, Assert.IsType<int>(LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3) }).Value));
    }

    [Fact, Trait("Catalog", "I07")]
    public void Typed_list_ForEach_reference_keeps_catalog_collection_type()
    {
        var result = Build(Source(Handles + CoreHandles + """
            return WorkflowActions.BuiltIn.Control.ForEach(items: () => values.Output,
                actions: item => WorkflowActions.BuiltIn.Compose(inputs: () => "item")).GetActionDefinition("Catalog");
            """));
        Assert.Equal("@outputs('Values')", result.Definition.Foreach.Value<string>());
    }

    [Fact, Trait("Catalog", "I08"), Trait("Catalog", "IN12")]
    public void Typed_list_ForEach_native_filter_keeps_catalog_collection_type()
    {
        var result = Build(Source(Handles + CoreHandles + """
            return WorkflowActions.BuiltIn.Control.ForEach(items: () => values.Output.Where(x => x > 1).ToArray(),
                actions: item => WorkflowActions.BuiltIn.Compose(inputs: () => "item")).GetActionDefinition("Catalog");
            """));
        var emitted = result.Definition.Foreach.Value<string>()!;
        EqualSource("@csharp{outputs(\"Values\").ToObject<System.Collections.Generic.List<int>>().Where(x => x > 1).ToArray()}", emitted);
        Assert.Equal([2, 3], Assert.IsType<int[]>(LocalNativeHost.Evaluate(emitted, new() { ["Values"] = new JArray(1, 2, 3) }).Value));
    }

    [Fact, Trait("Catalog", "SR20")]
    public void Null_conditional_string_access_materializes_CLR_null()
    {
        var emitted = Native("source.Output?.ToUpperInvariant() ?? \"none\"");
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>()?.ToUpperInvariant() ?? \"none\"}", emitted);
        Assert.Equal("none", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = JValue.CreateNull() }).Value);
        Assert.Equal("HELLO", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("hello") }).Value);
    }

    [Fact, Trait("Catalog", "CB15")]
    public void Explicit_trigger_value_conversion_is_preserved_in_arithmetic()
    {
        var emitted = Native("trigger.TriggerOutput.Body[\"value\"].Value<int>() + 2");
        EqualSource("@csharp{triggerBody()[\"value\"].Value<int>() + 2}", emitted);
        Assert.Equal(5, Assert.IsType<int>(LocalNativeHost.Evaluate(emitted,
            new() { ["Trigger"] = JObject.Parse("""{"value":3}""") }).Value));
    }

    [Fact, Trait("Catalog", "IN13")]
    public void Ordinary_boolean_input_retains_native_predicate()
    {
        var emitted = Native("count.Output == 3", resultType: "bool");
        EqualSource("@csharp{outputs(\"Count\").ToObject<int>() == 3}", emitted);
        Assert.True(Assert.IsType<bool>(LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3) }).Value));
        Assert.False(Assert.IsType<bool>(LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(2) }).Value));
    }

    [Fact, Trait("Catalog", "IN09")]
    public void Generated_base64_native_content_does_not_encode_unmarked_sibling()
    {
        var result = Build(Source(Handles + """
            return new Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus.ServicebusActions("connection")
                .SendMessage(entityName: () => "queue", messagecontent: () => source.Output.ToUpperInvariant(),
                    messagecontentType: () => "text/plain").GetActionDefinition("Catalog");
            """));
        var body = Token(result.Definition)["body"]!;
        Assert.Equal("text/plain", body["ContentType"]!.Value<string>());
        EqualSource("@csharp{base64(outputs(\"Source\").ToObject<string>().ToUpperInvariant())}", body["ContentData"]!.Value<string>()!);
    }

    [Fact, Trait("Catalog", "DG08")]
    public void Literal_zero_divisor_fails_only_at_native_execution()
    {
        var emitted = Native("count.Output / 0");
        EqualSource("@csharp{outputs(\"Count\").ToObject<int>() / 0}", emitted);
        Assert.Throws<DivideByZeroException>(() => LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3) }));
    }

    [Fact, Trait("Catalog", "DG10")]
    public void Captured_instance_service_method_is_rejected_without_invocation()
    {
        var source = Source("return new Author().Define();", """
            public static int Calls;
            public sealed class Service { public string Read() => throw new InvalidOperationException("Service invoked"); }
            public sealed class Author
            {
                private readonly Service service = new Service();
                public string Secret() { Calls++; return service.Read(); }
                public FlowTemplateAction Define() =>
                    WorkflowActions.BuiltIn.Compose(inputs: () => this.Secret()).GetActionDefinition("Catalog");
            }
            """);
        var diagnostic = Assert.Single(Transform(source).Diagnostics);
        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains(diagnostic.Id, new[] { "WFBUILD003", "WFBUILD005", "WFBUILD008" });
        Assert.Contains("this", Compile(source).SyntaxTrees.Single().GetText().ToString(diagnostic.Location.SourceSpan));
        var original = Load(Compile(source));
        Assert.Throws<NotSupportedException>(() => Invoke(original, "Consumer", "Build"));
        Assert.Equal(0, original.GetType("Consumer")!.GetField("Calls")!.GetValue(null));
    }

    [Fact]
    public void Available_base64_surface_cannot_supply_the_catalog_text_only_Stream_fixture()
    {
        var source = Source("""
            var stream = new System.IO.MemoryStream();
            return new Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus.ServicebusActions("connection")
                .SendMessage(entityName: () => "queue", messagecontent: () => stream).GetActionDefinition("Catalog");
            """);
        var errors = Compile(source).GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Contains(errors, d => d.Id == "CS0029" && d.GetMessage().Contains("MemoryStream") && d.GetMessage().Contains("JToken"));
    }
}

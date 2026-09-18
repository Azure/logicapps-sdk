namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CoreStringAndMethodCatalogTests
{
    [Theory]
    [InlineData("S04", "$\"Next: {count.Output + 1}\"", "$\"Next: {outputs(\"Count\").ToObject<int>() + 1}\"", "Next: 4")]
    [InlineData("S05", "string.Format(\"{0:00}\", count.Output)", "string.Format(\"{0:00}\", outputs(\"Count\").ToObject<int>())", "03")]
    [InlineData("S06", "string.Format(System.Globalization.CultureInfo.InvariantCulture, \"{0:N2}\", amount.Output)", "string.Format(System.Globalization.CultureInfo.InvariantCulture, \"{0:N2}\", outputs(\"Amount\").ToObject<decimal>())", "1,234.50")]
    [InlineData("S07", "string.Concat(source.Output.ToUpperInvariant(), other.Output)", "string.Concat(outputs(\"Source\").ToObject<string>().ToUpperInvariant(), outputs(\"Other\").ToObject<string>())", "HELLOworld")]
    [InlineData("S08", "string.Join(\",\", values.Output)", "string.Join(\",\", outputs(\"Values\").ToObject<System.Collections.Generic.List<int>>())", "1,2,3")]
    [InlineData("S09b", "string.Format(\"{1}/{0}/{1}\", source.Output, other.Output)", "string.Format(\"{1}/{0}/{1}\", outputs(\"Source\").ToObject<string>(), outputs(\"Other\").ToObject<string>())", "world/hello/world")]
    [InlineData("S09c", "string.Format(\"{{{0,5:00}}}\", count.Output)", "string.Format(\"{{{0,5:00}}}\", outputs(\"Count\").ToObject<int>())", "{   03}")]
    [InlineData("S11", "$\"Model: {new DisplayModel { Id = count.Output }}\"", "$\"Model: {new DisplayModel { Id = outputs(\"Count\").ToObject<int>() }}\"", "Model: Display:3")]
    [InlineData("S13", "\"Name: \" + source.Output", "\"Name: \" + outputs(\"Source\").ToObject<string>()", "Name: hello")]
    [InlineData("S13b", "string.Concat(\"Name: \", source.Output)", "string.Concat(\"Name: \", outputs(\"Source\").ToObject<string>())", "Name: hello")]
    [InlineData("S15", "$\"Count: {count.Output,5:00}\"", "$\"Count: {outputs(\"Count\").ToObject<int>(),5:00}\"", "Count:    03")]
    [InlineData("N01", "source.Output.ToUpperInvariant()", "outputs(\"Source\").ToObject<string>().ToUpperInvariant()", "HELLO")]
    [InlineData("N03", "source.Output.Substring(1, 2)", "outputs(\"Source\").ToObject<string>().Substring(1, 2)", "el")]
    [InlineData("N04", "count.Output.ToString()", "outputs(\"Count\").ToObject<int>().ToString()", "3")]
    [InlineData("N07", "RuntimeValues.Text.ToUpperInvariant()", "RuntimeValues.Text.ToUpperInvariant()", "HELLO")]
    [InlineData("N10", "RuntimeValues.ReadonlyText", "RuntimeValues.ReadonlyText", "readonly")]
    public void Native_formatting_and_string_methods_execute_from_preserved_source(
        string catalog, string input, string expectedBody, string expected)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(input, CoreHandles);
        var local = LocalNativeHost.Evaluate(emitted, new()
        {
            ["Source"] = new JValue("hello"), ["Other"] = new JValue("world"), ["Count"] = new JValue(3),
            ["Amount"] = new JValue(1234.5m), ["Values"] = new JArray(1, 2, 3),
        });
        EqualSource("@csharp{" + expectedBody + "}", emitted);
        Assert.Equal(expected, Assert.IsType<string>(local.Value));
        if (catalog == "S09b") Assert.Equal(["Source", "Other"], local.Reads);
    }

    [Fact, Trait("Catalog", "S10")]
    public void Captured_string_ToString_remains_native()
    {
        var emitted = Native("text.ToString()", """string text = "x";""");
        EqualSource("@csharp{\"x\".ToString()}", emitted);
        Assert.Equal("x", LocalNativeHost.Evaluate(emitted, new()).Value);
    }

    [Fact, Trait("Catalog", "N02"), Trait("Catalog", "CB11")]
    public void String_length_retains_integer_runtime_result()
    {
        var built = Build(Source(Handles + """
            ObservedSource = source;
            return WorkflowActions.BuiltIn.Compose<int>(input: () => source.Output.Length).GetActionDefinition("Catalog");
            """, "public static IOutputWorkflowAction<string> ObservedSource;"));
        var handle = (IOutputWorkflowAction<string>)built.Assembly.GetType("Consumer")!.GetField("ObservedSource")!.GetValue(null)!;
        Assert.Throws<InvalidOperationException>(() => handle.Output);
        var emitted = Token(built.Definition).Value<string>()!;
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>().Length}", emitted);
        Assert.Equal(5, Assert.IsType<int>(LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("hello") }).Value));
    }

    [Fact, Trait("Catalog", "N05")]
    public void Math_round_uses_decimal_materialization()
    {
        var emitted = Native("Math.Round(amount.Output, 2)", CoreHandles);
        EqualSource("@csharp{System.Math.Round(outputs(\"Amount\").ToObject<decimal>(), 2)}", emitted);
        Assert.Equal(2.76m, Assert.IsType<decimal>(LocalNativeHost.Evaluate(emitted, new() { ["Amount"] = new JValue(2.755m) }).Value));
    }

    [Fact, Trait("Catalog", "N06")]
    public void UtcNow_is_evaluated_only_in_the_local_runtime()
    {
        var emitted = Native("DateTime.UtcNow");
        EqualSource("@csharp{System.DateTime.UtcNow}", emitted);
        var before = DateTime.UtcNow;
        var result = Assert.IsType<DateTime>(LocalNativeHost.Evaluate(emitted, new()).Value);
        Assert.InRange(result, before, DateTime.UtcNow);
        Assert.Equal(DateTimeKind.Utc, result.Kind);
    }

    [Fact, Trait("Catalog", "N11")]
    public void Typed_workflow_list_indexing_stays_native()
    {
        var emitted = Native("values.Output[1]", CoreHandles);
        EqualSource("@csharp{outputs(\"Values\").ToObject<System.Collections.Generic.List<int>>()[1]}", emitted);
        Assert.Equal(2, Assert.IsType<int>(LocalNativeHost.Evaluate(emitted, new() { ["Values"] = new JArray(1, 2, 3) }).Value));
    }

    [Fact, Trait("Catalog", "N12")]
    public void Nested_linq_parameters_and_result_array_keep_their_native_types()
    {
        var emitted = Native("values.Output.Where(x => x > 1).Select(x => x * 2).ToArray()", CoreHandles);
        EqualSource("@csharp{outputs(\"Values\").ToObject<System.Collections.Generic.List<int>>().Where(x => x > 1).Select(x => x * 2).ToArray()}", emitted);
        Assert.Equal([4, 6], Assert.IsType<int[]>(LocalNativeHost.Evaluate(emitted, new() { ["Values"] = new JArray(1, 2, 3) }).Value));
    }

    [Theory]
    [InlineData("N13", "var numbers = new[] { 1, 2 };", "numbers[0]", "numbers", "1", "System.Int32")]
    [InlineData("N14", "var names = new List<string> { \"a\", \"b\" };", "names[1]", "names", "\"b\"", "System.String")]
    [InlineData("N14b", "var lookup = new Dictionary<string, int> { [\"k\"] = 7 };", "lookup[\"k\"]", "lookup", "7", "System.Int32")]
    public void Captured_collections_are_native_value_snapshots(
        string catalog, string setup, string input, string captureName, string expectedJson, string expectedType)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(input, setup);
        Assert.StartsWith("@csharp{", emitted);
        var syntax = Assert.IsType<ElementAccessExpressionSyntax>(SyntaxFactory.ParseExpression(emitted[8..^1]));
        Assert.DoesNotContain(syntax.DescendantNodes().OfType<IdentifierNameSyntax>(), n => n.Identifier.ValueText == captureName);
        var local = LocalNativeHost.Evaluate(emitted, new()).Value!;
        Assert.Equal(expectedType, local.GetType().FullName);
        Assert.True(JToken.DeepEquals(JToken.Parse(expectedJson), JToken.FromObject(local)));
    }

    [Fact, Trait("Catalog", "N15"), Trait("Catalog", "CB16")]
    public void Typed_custom_code_body_property_preserves_decimal_calculation()
    {
        var emitted = Native("summary.Body.Total * 1.2m", CoreHandles);
        EqualSource("@csharp{body(\"GetSummary\").ToObject<OrderSummary>().Total * 1.2m}", emitted);
        Assert.Equal(120m, Assert.IsType<decimal>(LocalNativeHost.Evaluate(emitted,
            new() { ["GetSummary"] = JObject.Parse("""{"Total":100}""") }).Value));
    }

    [Fact, Trait("Catalog", "N16")]
    public void Uri_constructor_remains_native_and_result_is_serializable()
    {
        var emitted = Native("new Uri(source.Output)");
        EqualSource("@csharp{new System.Uri(outputs(\"Source\").ToObject<string>())}", emitted);
        var value = Assert.IsType<Uri>(LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("https://example.com/api") }).Value);
        Assert.Equal("https://example.com/api", value.AbsoluteUri);
        Assert.Equal("https://example.com/api", JToken.Parse(JsonConvert.SerializeObject(value)).Value<string>());
    }

    [Fact, Trait("Catalog", "N17"), Trait("Catalog", "N17b")]
    public void Http_boundary_normalizes_approved_uri_and_method_values()
    {
        var result = Build(Source("""
            var uri = new Uri("https://example.com/api");
            return WorkflowActions.BuiltIn.HttpAction(uri: () => uri, method: () => System.Net.Http.HttpMethod.Get).GetActionDefinition("Catalog");
            """));
        Assert.Equal("https://example.com/api", Token(result.Definition)["uri"]!.Value<string>());
        Assert.Equal("GET", Token(result.Definition)["method"]!.Value<string>());
    }

    [Fact, Trait("Catalog", "N18")]
    public void Object_materialization_precedes_native_type_test()
    {
        var emitted = Native("raw.Output is string", CoreHandles);
        EqualSource("@csharp{outputs(\"Raw\").ToObject<object>() is string}", emitted);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new() { ["Raw"] = new JValue("text") }).Value);
        Assert.Equal(false, LocalNativeHost.Evaluate(emitted, new() { ["Raw"] = new JValue(3) }).Value);
    }

    [Fact, Trait("Catalog", "N18b")]
    public void Money_constructor_is_not_executed_during_definition_generation()
    {
        var result = Build(Source(Handles + CoreHandles + """
            return WorkflowActions.BuiltIn.Compose<Money>(input: () => new Money(amount.Output)).GetActionDefinition("Catalog");
            """));
        Assert.Equal(0, result.Assembly.GetType("Money")!.GetField("ConstructorCalls")!.GetValue(null));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{new Money(outputs(\"Amount\").ToObject<decimal>())}", emitted);
        var value = LocalNativeHost.Evaluate(emitted, new() { ["Amount"] = new JValue(2.75m) }).Value!;
        Assert.Equal(2.75m, value.GetType().GetProperty("Value")!.GetValue(value));
        Assert.Equal(1, value.GetType().GetField("ConstructorCalls")!.GetValue(null));
    }
}

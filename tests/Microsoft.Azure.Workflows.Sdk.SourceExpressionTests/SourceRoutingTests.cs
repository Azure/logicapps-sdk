namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class SourceRoutingTests
{
    [Theory]
    [InlineData("L01", "\"Hello world\"", "\"Hello world\"")]
    [InlineData("L02", "\"\"", "\"\"")]
    [InlineData("L03", "5", "5")]
    [InlineData("L04", "true", "true")]
    [InlineData("L05", "2.5", "2.5")]
    [InlineData("L06", "(object)5", "5")]
    [InlineData("L06b", "(object)true", "true")]
    [InlineData("L07", "(string)null", "null")]
    [InlineData("L17", "1 + 2", "3")]
    [InlineData("SR16", "1 + 2", "3")]
    [InlineData("SR17", "RuntimeValues.ConstantText", "\"constant\"")]
    [InlineData("N09", "RuntimeValues.ConstantText", "\"constant\"")]
    [InlineData("N18c", "default(int)", "0")]
    public void Literal_preserves_json_type(string catalog, string expression, string expectedJson)
    {
        Assert.NotEmpty(catalog);
        var expected = JToken.Parse(expectedJson);
        var actual = Input(expression);
        Assert.Equal(expected.Type, actual?.Type ?? JTokenType.Null);
        Assert.True(JToken.DeepEquals(expected, actual ?? JValue.CreateNull()));
    }

    [Theory]
    [InlineData("R04", "source.Output", "#{outputs(\"Source\")}")]
    [InlineData("R02", "trigger.TriggerOutput.Body", "#{triggerBody()}")]
    [InlineData("R01", "trigger.TriggerOutput", "#{triggerOutputs()}")]
    [InlineData("R08", "trigger.TriggerOutput.Body[\"name\"]", "#{triggerBody()[\"name\"]}")]
    [InlineData("R09", "trigger.TriggerOutput.Body[\"customer\"][\"name\"]", "#{triggerBody()[\"customer\"][\"name\"]}")]
    [InlineData("SR01", "$\"Name: {source.Output}\"", "#{$\"Name: {outputs(\"Source\").ToObject<string>()}\"}")]
    [InlineData("SR03", "$\"{{Name}}: {source.Output}; again: {source.Output}\"", "#{$\"{{Name}}: {outputs(\"Source\").ToObject<string>()}; again: {outputs(\"Source\").ToObject<string>()}\"}")]
    [InlineData("S02", "$\"First: {source.Output}; second: {other.Output}\"", "#{$\"First: {outputs(\"Source\").ToObject<string>()}; second: {outputs(\"Other\").ToObject<string>()}\"}")]
    [InlineData("S03", "$\"Name: {trigger.TriggerOutput.Body[\"name\"]}\"", "#{$\"Name: {triggerBody()[\"name\"]}\"}")]
    [InlineData("S12", "$\"Received: {trigger.TriggerOutput.Body}\"", "#{$\"Received: {triggerBody()}\"}")]
    [InlineData("S01", "$\"Received request: {trigger.TriggerOutput.Body}\"", "#{$\"Received request: {triggerBody()}\"}")]
    [InlineData("S09", "$\"{{Name}}: {source.Output}; again: {source.Output}\"", "#{$\"{{Name}}: {outputs(\"Source\").ToObject<string>()}; again: {outputs(\"Source\").ToObject<string>()}\"}")]
    [InlineData("P03", "$\"hello{trigger.TriggerOutput.Body}\"", "#{$\"hello{triggerBody()}\"}")]
    public void References_preserve_JSON_and_interpolation_preserves_typed_native_source(string catalog, string expression, string expected)
    {
        Assert.NotEmpty(catalog);
        Assert.Equal(expected, Input(expression)!.Value<string>());
    }

    [Theory]
    [InlineData("$$$\"\"\"{{Name}}: {{{source.Output}}}\"\"\"", "#{$$$\"\"\"{{Name}}: {{{outputs(\"Source\").ToObject<string>()}}}\"\"\"}")]
    [InlineData("$$$\"\"\"\n{{Name}}: {{{source.Output}}}\n\"\"\"", "#{$$$\"\"\"\n{{Name}}: {{{outputs(\"Source\").ToObject<string>()}}}\n\"\"\"}")]
    [InlineData("$\"{{Name}}: {source.Output}\"", "#{$\"{{Name}}: {outputs(\"Source\").ToObject<string>()}\"}")]
    [InlineData("$@\"{{Name}}: {source.Output}\"", "#{$@\"{{Name}}: {outputs(\"Source\").ToObject<string>()}\"}")]
    public void Raw_and_regular_interpolation_preserve_literal_braces(string expression, string expected)
    {
        var token = Input(expression);
        Assert.Equal(JTokenType.String, token!.Type);
        Assert.Equal(expected, token.Value<string>());
    }

    [Theory]
    [InlineData("SR02", "string.Format(\"Name: {0}\", source.Output)", "#{string.Format(\"Name: {0}\", outputs(\"Source\").ToObject<string>())}")]
    [InlineData("SR05", "\"Name: \" + source.Output", "#{\"Name: \" + outputs(\"Source\").ToObject<string>()}")]
    [InlineData("SR06", "string.Concat(\"Name: \", source.Output)", "#{string.Concat(\"Name: \", outputs(\"Source\").ToObject<string>())}")]
    [InlineData("SR07", "$\"Next: {count.Output + 1}\"", "#{$\"Next: {outputs(\"Count\").ToObject<int>() + 1}\"}")]
    [InlineData("SR09", "(count.Output + 2) * 3", "#{(outputs(\"Count\").ToObject<int>() + 2) * 3}")]
    [InlineData("SR15", "count.Output switch { > 0 => \"positive\", _ => \"other\" }", "#{outputs(\"Count\").ToObject<int>() switch { > 0 => \"positive\", _ => \"other\" }}")]
    [InlineData("N01", "source.Output.ToUpperInvariant()", "#{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}")]
    [InlineData("N02", "source.Output.Length", "#{outputs(\"Source\").ToObject<string>().Length}")]
    [InlineData("S12b", "string.Format(\"Received: {0}\", trigger.TriggerOutput.Body)", "#{string.Format(\"Received: {0}\", triggerBody())}")]
    [InlineData("M07", "trigger.TriggerOutput.Body[\"value\"].Value<int>() + 2", "#{triggerBody()[\"value\"].Value<int>() + 2}")]
    public void Native_source_is_preserved(string catalog, string expression, string expected)
    {
        Assert.NotEmpty(catalog);
        EqualSource(expected, Native(expression));
    }

    [Theory]
    [InlineData("O01", "count.Output + 2", "#{outputs(\"Count\").ToObject<int>() + 2}", 7)]
    [InlineData("O02", "count.Output - 2", "#{outputs(\"Count\").ToObject<int>() - 2}", 3)]
    [InlineData("O03", "count.Output * 3", "#{outputs(\"Count\").ToObject<int>() * 3}", 15)]
    [InlineData("O04", "count.Output / 2", "#{outputs(\"Count\").ToObject<int>() / 2}", 2)]
    [InlineData("O05", "count.Output % 2", "#{outputs(\"Count\").ToObject<int>() % 2}", 1)]
    [InlineData("O17", "count.Output << 1", "#{outputs(\"Count\").ToObject<int>() << 1}", 10)]
    public void Native_integer_operators_execute_locally(string catalog, string expression, string expected, int value)
    {
        Assert.NotEmpty(catalog);
        var emitted = Native(expression);
        EqualSource(expected, emitted);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(5) });
        Assert.Equal(value, Assert.IsType<int>(result.Value));
        Assert.Equal(["Count"], result.Reads);
    }

    [Fact, Trait("Catalog", "SR04")]
    public void SR04_Explicit_format_preserves_argument_order_and_single_reads()
    {
        var emitted = Native("string.Format(\"{1}/{0}/{1}\", source.Output, other.Output)");
        EqualSource("#{string.Format(\"{1}/{0}/{1}\", outputs(\"Source\").ToObject<string>(), outputs(\"Other\").ToObject<string>())}", emitted);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("A"), ["Other"] = new JValue("B") });
        Assert.Equal("B/A/B", result.Value);
        Assert.Equal(["Source", "Other"], result.Reads);
    }

    [Fact, Trait("Catalog", "SR08")]
    public void SR08_Invariant_format_remains_native()
    {
        var emitted = Native("string.Format(System.Globalization.CultureInfo.InvariantCulture, \"{0:00}\", count.Output)");
        EqualSource("#{string.Format(System.Globalization.CultureInfo.InvariantCulture, \"{0:00}\", outputs(\"Count\").ToObject<int>())}", emitted);
        Assert.Equal("03", LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3) }).Value);
    }

    [Fact, Trait("Catalog", "SR10"), Trait("Catalog", "O18")]
    public void SR10_Checked_overflow_is_runtime_not_generation_time()
    {
        var emitted = Native("checked(count.Output + 1)");
        EqualSource("#{checked(outputs(\"Count\").ToObject<int>() + 1)}", emitted);
        Assert.Throws<OverflowException>(() => LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(int.MaxValue) }));
    }

    [Fact, Trait("Catalog", "SR11")]
    public void SR11_Property_pattern_executes_locally()
    {
        var emitted = Native("source.Output is { Length: > 2 }");
        EqualSource("#{outputs(\"Source\").ToObject<string>() is { Length: > 2 }}", emitted);
        Assert.Equal(true, LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("hello") }).Value);
    }

    [Fact, Trait("Catalog", "SR12")]
    public void SR12_Range_executes_locally()
    {
        var emitted = Native("source.Output[..2]");
        EqualSource("#{outputs(\"Source\").ToObject<string>()[..2]}", emitted);
        Assert.Equal("he", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("hello") }).Value);
    }

    [Fact, Trait("Catalog", "CB05")]
    public void CB05_Unselected_branch_does_not_read_source()
    {
        var emitted = Native("flag.Output ? source.Output.ToUpperInvariant() : \"skip\"");
        EqualSource("#{outputs(\"Flag\").ToObject<bool>() ? outputs(\"Source\").ToObject<string>().ToUpperInvariant() : \"skip\"}", emitted);
        var result = LocalNativeHost.Evaluate(emitted, new() { ["Flag"] = new JValue(false) });
        Assert.Equal("skip", result.Value);
        Assert.Equal(["Flag"], result.Reads);
    }

    [Fact, Trait("Catalog", "F06")]
    public void F06_Runtime_divide_by_zero_is_not_swallowed()
    {
        var emitted = Native("count.Output / quantity.Output");
        EqualSource("#{outputs(\"Count\").ToObject<int>() / outputs(\"Quantity\").ToObject<int>()}", emitted);
        Assert.Throws<DivideByZeroException>(() => LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3), ["Quantity"] = new JValue(0) }));
    }

    [Fact, Trait("Catalog", "M08")]
    public void M08_Explicit_value_conversion_keeps_runtime_failure()
    {
        var emitted = Native("trigger.TriggerOutput.Body[\"value\"].Value<int>()");
        EqualSource("#{triggerBody()[\"value\"].Value<int>()}", emitted);
        Assert.Throws<FormatException>(() => LocalNativeHost.Evaluate(emitted, new() { ["Trigger"] = JObject.Parse("""{"value":"abc"}""") }));
    }

    [Fact, Trait("Catalog", "SR19")]
    public void SR19_Linq_preserves_inner_lambda_parameters()
    {
        var emitted = Native("values.Output.Where(x => x > 1).Select(x => x * 2).ToArray()",
            """var values = WorkflowActions.BuiltIn.Compose<List<int>>(input: () => new List<int>()).WithName("Values");""");
        EqualSource("#{outputs(\"Values\").ToObject<System.Collections.Generic.List<int>>().Where(x => x > 1).Select(x => x * 2).ToArray()}", emitted);
        Assert.Equal([4, 6], Assert.IsType<int[]>(LocalNativeHost.Evaluate(emitted,
            new() { ["Values"] = new JArray(1, 2, 3) }).Value));
    }

    [Fact, Trait("Catalog", "CB09")]
    public void CB09_Outer_capture_is_substituted_but_inner_parameter_is_not()
    {
        var emitted = Native("values.Output.Select(x => x + increment).ToArray()", """
            int increment = 2;
            var values = WorkflowActions.BuiltIn.Compose<List<int>>(input: () => new List<int>()).WithName("Values");
            """);
        EqualSource("#{outputs(\"Values\").ToObject<System.Collections.Generic.List<int>>().Select(x => x + 2).ToArray()}", emitted);
        Assert.Equal([3, 4, 5], Assert.IsType<int[]>(LocalNativeHost.Evaluate(emitted,
            new() { ["Values"] = new JArray(1, 2, 3) }).Value));
    }

    [Fact, Trait("Catalog", "SR18")]
    public void SR18_Static_runtime_state_is_not_frozen_during_generation()
    {
        var emitted = Native("RuntimeValues.Text.ToUpperInvariant()");
        EqualSource("#{RuntimeValues.Text.ToUpperInvariant()}", emitted);
        var assembly = Load(Compile($$"""
            using System;
            public static class NativeState
            {
                public static string Run() => {{ConsumerCompilation.NativeBody(emitted)}};
            }
            {{Fixtures}}
            """));
        Assert.Equal("HELLO", Invoke(assembly, "NativeState", "Run"));
        assembly.GetType("RuntimeValues")!.GetField("Text")!.SetValue(null, "changed");
        Assert.Equal("CHANGED", Invoke(assembly, "NativeState", "Run"));
    }
}

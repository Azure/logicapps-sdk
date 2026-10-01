namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class CompilerRegressionTests
{
    [Theory]
    [InlineData("byte", "2", "Byte")]
    [InlineData("short", "2", "Int16")]
    [InlineData("uint", "2U", "UInt32")]
    [InlineData("long", "2L", "Int64")]
    [InlineData("ulong", "2UL", "UInt64")]
    [InlineData("float", "2F", "Single")]
    [InlineData("double", "2D", "Double")]
    [InlineData("decimal", "2M", "Decimal")]
    public void Native_local_constants_preserve_declared_numeric_types(string type, string literal, string expected)
    {
        var emitted = Native("value.GetType().Name", $"const {type} value = {literal};");
        Assert.Contains("GetType().Name", emitted);
        Assert.Equal(expected, LocalNativeHost.Evaluate(emitted, new()).Value);
    }

    [Fact]
    public void Native_local_enum_constant_preserves_enum_semantics()
    {
        var emitted = Native("day.ToString() + source.Output", "const DayOfWeek day = DayOfWeek.Monday;");
        Assert.Equal("MondayA", LocalNativeHost.Evaluate(emitted,
            new() { ["Source"] = new JValue("A") }).Value);
    }

    [Fact]
    public void Native_local_null_constant_keeps_receiver_type()
    {
        var emitted = Native("text?.ToUpperInvariant() ?? \"none\"", "const string text = null;");
        Assert.Equal("none", LocalNativeHost.Evaluate(emitted, new()).Value);
    }

    [Theory]
    [InlineData("")]
    [InlineData("()")]
    public void Dictionary_initializers_support_both_constructor_spellings(string parentheses)
    {
        var result = Build(Source(Handles + $$"""
            return WorkflowActions.BuiltIn.Response(headers: () => new Dictionary<string, string>{{parentheses}}
            {
                ["X-Name"] = source.Output,
                ["X-Upper"] = other.Output.ToUpperInvariant()
            }).GetActionDefinition("Catalog");
            """));
        var headers = Assert.IsType<JObject>(Token(result.Definition)["headers"]);
        Assert.Equal("#{outputs(\"Source\")}", headers["X-Name"]!.Value<string>());
        EqualSource("#{outputs(\"Other\").ToObject<string>().ToUpperInvariant()}", headers["X-Upper"]!.Value<string>()!);
    }

    [Theory]
    [InlineData("hello", true)]
    [InlineData("a", false)]
    public void Property_pattern_name_is_not_an_implicit_this_capture(string value, bool expected)
    {
        var emitted = Native("source.Output is { Length: > 2 }");
        Assert.Equal(expected, LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue(value) }).Value);
    }

    [Fact]
    public void Nested_anonymous_structural_members_compile_without_unnameable_generic_arguments()
    {
        var token = Input("""
            new
            {
                outer = new { enabled = true, name = source.Output },
                entries = new[] { new { label = "a" }, new { label = "b" } }
            }
            """);
        Assert.True(JToken.DeepEquals(JObject.Parse("""
            {
                "outer": { "enabled": true, "name": "#{outputs(\"Source\")}" },
                "entries": [ { "label": "a" }, { "label": "b" } ]
            }
            """), token));
    }

    [Fact]
    public void Generic_native_binding_resolves_concrete_runtime_type()
    {
        var result = Build(Source("""
            var source = WorkflowActions.BuiltIn.Compose<int>(input: () => 3).WithName("Source");
            return Create(source).GetActionDefinition("Catalog");
            """, """
            private static IOutputWorkflowAction<string> Create<T>(IOutputWorkflowAction<T> action)
                => WorkflowActions.BuiltIn.Compose<string>(input: () => action.Output.ToString());
            """));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("#{outputs(\"Source\").ToObject<int>().ToString()}", emitted);
        Assert.DoesNotContain("<T>", emitted);
        Assert.Equal("3", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue(3) }).Value);
    }

    [Fact]
    public void Mixed_connector_path_preserves_original_interpolation_as_native_source()
    {
        var result = Build(Source(Handles + """
            return new ServicebusActions("connection").CloseSessionInQueue(
                queueName: () => source.Output.ToUpperInvariant(),
                sessionId: () => $"prefix {other.Output}").GetActionDefinition("Catalog");
            """, imports: "using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;"));
        Assert.Contains("\"native\"", result.Transformation.Sources["Consumer.cs"]);
        var emitted = Token(result.Definition)["path"]!.Value<string>()!;
        EqualSource("""
            #{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "/{0}/sessions/{1}/close", encodeURIComponent(encodeURIComponent(outputs("Source").ToObject<string>().ToUpperInvariant())), encodeURIComponent($"prefix {outputs("Other").ToObject<string>()}"))}
            """, emitted);
        Assert.DoesNotContain("@{", emitted);
        Assert.Equal(1, emitted.Split("#{").Length - 1);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("q /"), ["Other"] = new JValue("a b") });
        Assert.Equal("/Q%2520%252F/sessions/prefix%20a%20b/close", local.Value);
        Assert.Equal(["Source", "Other"], local.Reads);
    }

    [Theory]
    [InlineData("$\"{{prefix}} {source.Output}\"")]
    [InlineData("$@\"{{prefix}} {source.Output}\"")]
    [InlineData("$$\"\"\"{prefix} {{source.Output}}\"\"\"")]
    public void Structural_interpolation_uses_authored_CSharp_without_template_segments(string expression)
    {
        var result = Build(Source(Handles + $$"""
            return WorkflowActions.BuiltIn.Compose(() => new { label = {{expression}} }).GetActionDefinition("Catalog");
            """));
        var source = result.Transformation.Sources["Consumer.cs"];
        Assert.DoesNotContain("\"template\"", source);
        Assert.DoesNotContain("nativeSegments:", source);
        var label = Assert.IsType<JObject>(Token(result.Definition))["label"]!.Value<string>()!;
        Assert.Equal("{prefix} A", LocalNativeHost.Evaluate(label, new() { ["Source"] = new JValue("A") }).Value);
    }

    [Fact]
    public void Constant_user_defined_result_conversion_is_not_executed_during_generation()
    {
        const string conversionType = """
            public sealed class CountedValue
            {
                public int Value { get; set; }
                public static implicit operator CountedValue(int value)
                {
                    RuntimeValues.Calls++;
                    return new CountedValue { Value = value };
                }
            }
            """;
        var result = Build(Source("""
            return WorkflowActions.BuiltIn.Compose<CountedValue>(input: () => 7).GetActionDefinition("Catalog");
            """, conversionType));
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("#{(global::Consumer.CountedValue)(7)}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new(), "public static class Consumer { " + conversionType + " }");
        Assert.Equal(1, local.Calls);
        Assert.Equal(7, JToken.FromObject(local.Value!)["Value"]!.Value<int>());
    }

    [Fact]
    public void Private_constant_is_rendered_as_semantic_literal_without_private_dependency()
    {
        var result = Build(Source("""
            return WorkflowActions.BuiltIn.Compose<int>(input: () => Secret).GetActionDefinition("Catalog");
            """, "private const int Secret = 7;"));
        Assert.Equal(7, Token(result.Definition).Value<int>());
    }

    [Fact]
    public void Nameof_private_symbol_folds_without_accessing_private_dependency()
    {
        const string privateProperty = """private static int Secret => throw new InvalidOperationException("Never read.");""";
        var literal = Build(Source("""
            return WorkflowActions.BuiltIn.Compose<string>(input: () => nameof(Secret)).GetActionDefinition("Catalog");
            """, privateProperty));
        Assert.Equal("Secret", Token(literal.Definition).Value<string>());
        var native = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<string>(input: () => source.Output + nameof(Secret)).GetActionDefinition("Catalog");
            """, privateProperty));
        var emitted = Token(native.Definition).Value<string>()!;
        EqualSource("#{outputs(\"Source\").ToObject<string>() + \"Secret\"}", emitted);
        Assert.Equal("ASecret", LocalNativeHost.Evaluate(emitted, new() { ["Source"] = new JValue("A") }).Value);
    }
}

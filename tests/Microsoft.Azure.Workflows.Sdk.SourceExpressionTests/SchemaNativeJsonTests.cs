namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

[Collection("Runtime serialization globals")]
public sealed class SchemaNativeJsonTests
{
    [Theory]
    [InlineData("new { Next = count.Output + 1, Label = source.Output }", "{\"Next\":4,\"Label\":\"A\"}", "Count,Source")]
    [InlineData("new[] { count.Output + 1, count.Output + 2 }", "[4,5]", "Count,Count")]
    [InlineData("new { Nested = new { Label = source.Output }, Missing = (string)null, Zero = count.Output - 3, Enabled = false, Amount = 1.25m }",
        "{\"Nested\":{\"Label\":\"A\"},\"Missing\":null,\"Zero\":0,\"Enabled\":false,\"Amount\":1.25}", "Source,Count")]
    [InlineData("new { Text = source.Output, Escaped = \"@\\\"\\\\<tag>\" }", "{\"Text\":\"A\",\"Escaped\":\"@\\\"\\\\<tag>\"}", "Source")]
    public void Generated_compact_JSON_executes_with_framework_and_Newtonsoft_references_only(
        string expression, string expected, string reads)
    {
        var emitted = SchemaConsumerCompilation.Build($"CatalogDestinations.EncodeJson(content: () => {expression})").Value.Value<string>()!;
        Assert.DoesNotContain("Microsoft.Azure.Workflows.Sdk", emitted);
        Assert.DoesNotContain("JsonConvert", emitted);
        Assert.Contains("JsonSerializer.Create(", emitted);
        var result = ExecuteWithoutSdk(emitted);
        Assert.Equal(expected, System.Text.Encoding.UTF8.GetString(Convert.FromBase64String((string)result[0])));
        Assert.Equal(reads.Split(','), (string[])result[1]);
    }

    [Fact]
    public void Fixed_profile_ignores_ambient_converters_naming_defaults_and_formatting()
    {
        var emitted = SchemaConsumerCompilation.Build(
            "CatalogDestinations.EncodeJson(content: () => new { Text = RuntimeValues.NextText(), Missing = (string)null, Zero = 0 })").Value.Value<string>()!;
        var previous = JsonConvert.DefaultSettings;
        try
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() },
                DefaultValueHandling = DefaultValueHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                Converters = { new RejectAllConverter() }
            };
            var result = ExecuteWithoutSdk(emitted);
            Assert.Equal("{\"Text\":\"hello\",\"Missing\":null,\"Zero\":0}",
                System.Text.Encoding.UTF8.GetString(Convert.FromBase64String((string)result[0])));
            Assert.Equal(1, (int)result[2]);
        }
        finally { JsonConvert.DefaultSettings = previous; }
    }

    [Theory]
    [InlineData("new { Value = RuntimeValues.NextChoice() }")]
    [InlineData("new { Value = (double)count.Output }")]
    [InlineData("new { Value = (float)count.Output }")]
    [InlineData("new { Value = (object)count.Output }")]
    [InlineData("new { Value = tokenSource.Output }")]
    [InlineData("new { Value = new NamedBody { Body = source.Output } }")]
    public void Shapes_requiring_SDK_validation_retain_an_explicit_dependency_gate(string expression)
    {
        var emitted = SchemaConsumerCompilation.Build($"CatalogDestinations.EncodeJson(content: () => {expression})").Value.Value<string>()!;
        Assert.Contains("Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime.ToCompactJson(", emitted);
        Assert.DoesNotContain("JsonSerializer.Create(", emitted);
    }

    [Fact]
    public void Null_array_is_evaluated_once_and_keeps_the_existing_JSON_null_text_contract()
    {
        var type = typeof(int[]);
        var method = typeof(WorkflowWireRuntime).GetMethod("CompactJsonExpression", BindingFlags.Static | BindingFlags.NonPublic)!;
        var fragment = (string)method.Invoke(null, [type, "Next()"])!;
        Assert.DoesNotContain("Microsoft.Azure.Workflows.Sdk", fragment);
        var result = ExecuteWithoutSdk("#{" + fragment + "}", """
            static int[] Next() { RuntimeValues.Calls++; return null; }
            """);
        Assert.Equal("null", result[0]);
        Assert.Equal(1, result[2]);
    }

    private static object[] ExecuteWithoutSdk(string envelope, string extra = "")
    {
        Assert.StartsWith("#{", envelope);
        var source = $$"""
            using System;
            using System.Collections.Generic;
            using Newtonsoft.Json.Linq;
            public static class Probe
            {
                public static object[] Run()
                {
                    var reads = new List<string>();
                    JToken outputs(string name) { reads.Add(name); return name == "Count" ? new JValue(3) : new JValue("A"); }
                    string base64(string value) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
                    var result = (object)({{ConsumerCompilation.NativeBody(envelope)}});
                    return new object[] { result, reads.ToArray(), RuntimeValues.Calls };
                }
                {{extra}}
            }
            {{ConsumerCompilation.Fixtures}}
            """;
        var compilation = ConsumerCompilation.Compile(source);
        var frameworkDirectory = Path.GetDirectoryName(typeof(object).Assembly.Location);
        var jsonAssembly = typeof(JToken).Assembly.Location;
        compilation = compilation.RemoveReferences(compilation.References.Where(reference =>
            !string.Equals(Path.GetDirectoryName(reference.Display), frameworkDirectory, StringComparison.OrdinalIgnoreCase) &&
            !string.Equals(reference.Display, jsonAssembly, StringComparison.OrdinalIgnoreCase)));
        Assert.DoesNotContain(compilation.References, reference =>
            Path.GetFileName(reference.Display)?.StartsWith("Microsoft.Azure.Workflows.Sdk", StringComparison.OrdinalIgnoreCase) == true);
        Assert.Contains(compilation.References, reference => reference.Display == jsonAssembly);
        Assert.Empty(compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error));
        return (object[])ConsumerCompilation.Invoke(ConsumerCompilation.Load(compilation), "Probe", "Run")!;
    }

    private sealed class RejectAllConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) =>
            throw new InvalidOperationException("Ambient converter must not execute.");
        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) =>
            throw new InvalidOperationException("Ambient converter must not execute.");
    }
}

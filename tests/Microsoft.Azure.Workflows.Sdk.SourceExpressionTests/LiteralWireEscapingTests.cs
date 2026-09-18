namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class LiteralWireEscapingTests
{
    [Theory]
    [InlineData("@csharp{1 + 2}", "@@csharp{1 + 2}")]
    [InlineData("@outputs('Source')", "@@outputs('Source')")]
    [InlineData("@{1 + 2}", "@@{1 + 2}")]
    [InlineData("@@already", "@@@already")]
    [InlineData("@", "@@")]
    [InlineData("mail@example.test", "mail@example.test")]
    public void Authored_and_captured_literal_strings_are_escaped_once_at_the_wire_boundary(string value, string expected)
    {
        Assert.Equal(expected, Input(JsonConvert.ToString(value))!.Value<string>());
        Assert.Equal(expected, Input("text", "string text = " + JsonConvert.ToString(value) + ";")!.Value<string>());
        var descriptor = SourceExpression.Literal(1, value);
        for (int i = 0; i < 2; i++)
            Assert.Equal(expected, Token(WorkflowActions.BuiltIn.Compose(descriptor).GetActionDefinition("Escaping")).Value<string>());
    }

    [Fact]
    public void Response_body_and_headers_escape_literals_but_not_generated_expressions()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Response(
                responseBody: () => "@csharp{1 + 2}",
                headers: () => new Dictionary<string, string>
                {
                    ["X-Literal"] = "@outputs('Source')",
                    ["X-Reference"] = source.Output,
                    ["X-Native"] = other.Output.ToUpperInvariant()
                }).GetActionDefinition("Escaping");
            """));
        var token = Token(result.Definition);
        Assert.Equal("@@csharp{1 + 2}", token["body"]!.Value<string>());
        Assert.Equal("@@outputs('Source')", token["headers"]!["X-Literal"]!.Value<string>());
        Assert.Equal("@outputs('Source')", token["headers"]!["X-Reference"]!.Value<string>());
        EqualSource("@csharp{outputs(\"Other\").ToObject<string>().ToUpperInvariant()}", token["headers"]!["X-Native"]!.Value<string>()!);
    }

    [Fact]
    public void Mixed_nested_structures_retain_literal_versus_expression_provenance()
    {
        var input = Input("""
            new Dictionary<string, object>
            {
                ["literal"] = "@csharp{1 + 2}",
                ["reference"] = source.Output,
                ["native"] = count.Output + 1,
                ["nested"] = new { labels = new[] { "@first", source.Output } },
                ["captured"] = snapshot
            }
            """, """
            JToken snapshot = JObject.Parse("{\"@key\":[\"@csharp{1 + 2}\",\"@@raw\",7,null]}");
            """)!;
        Assert.Equal("@@csharp{1 + 2}", input["literal"]!.Value<string>());
        Assert.Equal("@outputs('Source')", input["reference"]!.Value<string>());
        EqualSource("@csharp{outputs(\"Count\").ToObject<int>() + 1}", input["native"]!.Value<string>()!);
        Assert.Equal("@@first", input["nested"]!["labels"]![0]!.Value<string>());
        Assert.Equal("@outputs('Source')", input["nested"]!["labels"]![1]!.Value<string>());
        Assert.True(JToken.DeepEquals(JObject.Parse("{\"@key\":[\"@@csharp{1 + 2}\",\"@@@raw\",7,null]}"), input["captured"]));
    }

    [Fact]
    public void Reusing_a_descriptor_for_wire_output_does_not_change_encoded_bytes()
    {
        const string value = "@csharp{1 + 2}";
        var descriptor = SourceExpression.Literal(1, value);
        Assert.Equal("@" + value, Token(WorkflowActions.BuiltIn.Compose(descriptor).GetActionDefinition("Escaping")).Value<string>());
        var encoded = new ServicebusActions("connection").SendMessage(
            entityName: SourceExpression.Literal(1, "queue"),
            messagecontent: SourceExpression.Token(1, descriptor));
        Assert.Equal("@base64('@csharp{1 + 2}')", Token(encoded.GetActionDefinition("Escaping"))["body"]!["ContentData"]!.Value<string>());
        Assert.Equal("@" + value, Token(WorkflowActions.BuiltIn.Compose(descriptor).GetActionDefinition("Again")).Value<string>());
    }

    [Fact]
    public void Native_operands_and_JSON_intrinsic_inputs_keep_raw_literal_contents()
    {
        var emitted = Native("text.Trim()", "string text = \"@csharp{1 + 2}\";", resultType: "string");
        EqualSource("@csharp{\"@csharp{1 + 2}\".Trim()}", emitted);
        Assert.Equal("@csharp{1 + 2}", LocalNativeHost.Evaluate(emitted, new()).Value);
        Assert.Equal("@json('{\"text\":\"@csharp{1 + 2}\"}')",
            Input("""WorkflowFunctions.ToJson("{\"text\":\"@csharp{1 + 2}\"}")""")!.Value<string>());
    }

    [Fact]
    public void Generated_encoded_and_unencoded_fields_do_not_double_escape()
    {
        var value = SchemaConsumerCompilation.Build("""
            Catalog.Generated.CatalogDestinations.EncodedFields(
                ContentData: () => "@csharp{1 + 2}",
                ContentType: () => "@literal",
                Label: () => source.Output)
            """).Value;
        Assert.Equal("@base64('@csharp{1 + 2}')", value["ContentData"]!.Value<string>());
        Assert.Equal("@@literal", value["ContentType"]!.Value<string>());
        Assert.Equal("@outputs('Source')", value["Label"]!.Value<string>());
        var nested = SchemaConsumerCompilation.Build("""
            Catalog.Generated.CatalogDestinations.Nested(content: () => new
            {
                items = new[] { new { content = "@data", label = "@label" }, new { content = source.Output, label = "@@label" } },
                enabled = true
            })
            """).Value;
        Assert.Equal("@base64('@data')", nested["items"]![0]!["content"]!.Value<string>());
        Assert.Equal("@@label", nested["items"]![0]!["label"]!.Value<string>());
        Assert.Equal("@base64(outputs('Source'))", nested["items"]![1]!["content"]!.Value<string>());
        Assert.Equal("@@@label", nested["items"]![1]!["label"]!.Value<string>());
    }

    [Fact]
    public void Whole_JSON_and_URI_encoding_receive_raw_values_not_wire_escapes()
    {
        Assert.Equal("@base64('{\"Text\":\"@csharp{1 + 2}\"}')",
            SchemaConsumerCompilation.Build("""Catalog.Generated.CatalogDestinations.EncodeJson(content: () => new { Text = "@csharp{1 + 2}" })""").Value.Value<string>());
        Assert.Equal("/items/@{encodeURIComponent('@raw')}",
            SchemaConsumerCompilation.Build("""Catalog.Generated.CatalogDestinations.SinglePath(content: () => "@raw")""").Value.Value<string>());
        var schema = JObject.Parse(SchemaConsumerCompilation.Fixture);
        var operation = schema["operations"]!.Single(o => o["name"]!.Value<string>() == "SinglePath");
        operation["parameters"]![0]!["schema"]!["transforms"] = new JArray();
        Assert.Equal("/items/@raw", SchemaConsumerCompilation.Build(
            """Catalog.Generated.CatalogDestinations.SinglePath(content: () => "@raw")""", schema: schema.ToString()).Value.Value<string>());
        operation["mode"] = "value";
        ((JObject)operation).Remove("path");
        Assert.Equal("@@raw", SchemaConsumerCompilation.Build(
            """Catalog.Generated.CatalogDestinations.SinglePath(content: () => "@raw")""", schema: schema.ToString()).Value.Value<string>());
    }

    [Fact]
    public void Generated_model_default_and_assigned_values_keep_wire_escape_provenance()
    {
        var value = SchemaConsumerCompilation.Build("""
            Catalog.Generated.CatalogDestinations.Payload(content: () => new PayloadModel { Name = "@model" })
            """).Value;
        Assert.Equal("@@model", value["display_name"]!.Value<string>());
        Assert.True(value["enabled"]!.Value<bool>());
    }
}

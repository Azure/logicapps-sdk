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
    [InlineData("#{1 + 2}", "#{\"#{1 + 2}\"}")]
    [InlineData("#{}", "#{\"#{}\"}")]
    [InlineData("#{ }", "#{\"#{ }\"}")]
    [InlineData("#{a\"b\\c}", "#{\"#{a\\\"b\\\\c}\"}")]
    [InlineData("#{\n1\n}", "#{\"#{\\n1\\n}\"}")]
    [InlineData("#{RuntimeValues.NextText()}", "#{\"#{RuntimeValues.NextText()}\"}")]
    [InlineData("##{1 + 2}", "##{1 + 2}")]
    [InlineData("###{}", "###{}")]
    [InlineData("prefix #{1 + 2}", "prefix #{1 + 2}")]
    [InlineData(" #{1 + 2}", " #{1 + 2}")]
    [InlineData("prefix @{1 + 2}", "#{\"prefix @{1 + 2}\"}")]
    [InlineData("@name @{1 + 2}", "@@name @{1 + 2}")]
    public void Authored_and_captured_literal_strings_use_the_correct_wire_representation(string value, string expected)
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
        Assert.Equal("#{outputs(\"Source\")}", token["headers"]!["X-Reference"]!.Value<string>());
        EqualSource("#{outputs(\"Other\").ToObject<string>().ToUpperInvariant()}", token["headers"]!["X-Native"]!.Value<string>()!);
    }

    [Fact]
    public void Mixed_nested_structures_retain_literal_versus_expression_provenance()
    {
        var input = Input("""
            new Dictionary<string, object>
            {
                ["literal"] = "@csharp{1 + 2}",
                ["hashLiteral"] = "#{1 + 2}",
                ["doubleHash"] = "##{1 + 2}",
                ["reference"] = source.Output,
                ["native"] = count.Output + 1,
                ["nested"] = new { labels = new[] { "@first", source.Output } },
                ["captured"] = snapshot
            }
            """, """
            JToken snapshot = JObject.Parse("{\"@key\":[\"@csharp{1 + 2}\",\"@@raw\",7,null]}");
            """)!;
        Assert.Equal("@@csharp{1 + 2}", input["literal"]!.Value<string>());
        Assert.Equal("#{\"#{1 + 2}\"}", input["hashLiteral"]!.Value<string>());
        Assert.Equal("##{1 + 2}", input["doubleHash"]!.Value<string>());
        Assert.Equal("#{outputs(\"Source\")}", input["reference"]!.Value<string>());
        EqualSource("#{outputs(\"Count\").ToObject<int>() + 1}", input["native"]!.Value<string>()!);
        Assert.Equal("@@first", input["nested"]!["labels"]![0]!.Value<string>());
        Assert.Equal("#{outputs(\"Source\")}", input["nested"]!["labels"]![1]!.Value<string>());
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
        Assert.Equal("#{base64(\"@csharp{1 + 2}\")}", Token(encoded.GetActionDefinition("Escaping"))["body"]!["ContentData"]!.Value<string>());
        Assert.Equal("@" + value, Token(WorkflowActions.BuiltIn.Compose(descriptor).GetActionDefinition("Again")).Value<string>());
    }

    [Fact]
    public void Native_operands_and_JSON_intrinsic_inputs_keep_raw_literal_contents()
    {
        var emitted = Native("text.Trim()", "string text = \"@csharp{1 + 2}\";", resultType: "string");
        EqualSource("#{\"@csharp{1 + 2}\".Trim()}", emitted);
        Assert.Equal("@csharp{1 + 2}", LocalNativeHost.Evaluate(emitted, new()).Value);
        Assert.Equal("#{json(\"{\\\"text\\\":\\\"@csharp{1 + 2}\\\"}\")}",
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
        Assert.Equal("#{base64(\"@csharp{1 + 2}\")}", value["ContentData"]!.Value<string>());
        Assert.Equal("@@literal", value["ContentType"]!.Value<string>());
        Assert.Equal("#{outputs(\"Source\")}", value["Label"]!.Value<string>());
        var nested = SchemaConsumerCompilation.Build("""
            Catalog.Generated.CatalogDestinations.Nested(content: () => new
            {
                items = new[] { new { content = "@data", label = "@label" }, new { content = source.Output, label = "@@label" } },
                enabled = true
            })
            """).Value;
        Assert.Equal("#{base64(\"@data\")}", nested["items"]![0]!["content"]!.Value<string>());
        Assert.Equal("@@label", nested["items"]![0]!["label"]!.Value<string>());
        Assert.Equal("#{base64(outputs(\"Source\").ToObject<string>())}", nested["items"]![1]!["content"]!.Value<string>());
        Assert.Equal("@@@label", nested["items"]![1]!["label"]!.Value<string>());
    }

    [Fact]
    public void Whole_JSON_and_URI_encoding_receive_raw_values_not_wire_escapes()
    {
        Assert.Equal("#{base64(\"{\\\"Text\\\":\\\"@csharp{1 + 2}\\\"}\")}",
            SchemaConsumerCompilation.Build("""Catalog.Generated.CatalogDestinations.EncodeJson(content: () => new { Text = "@csharp{1 + 2}" })""").Value.Value<string>());
        Assert.Equal("#{string.Format(\"/items/{0}\", encodeURIComponent(\"@raw\"))}",
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

    [Theory]
    [InlineData("@model", "@@model")]
    [InlineData("#{model}", "#{\"#{model}\"}")]
    [InlineData("##{model}", "##{model}")]
    public void Generated_model_assigned_values_keep_wire_escape_provenance(string value, string expected)
    {
        var result = SchemaConsumerCompilation.Build(
            "Catalog.Generated.CatalogDestinations.Payload(content: () => new PayloadModel { Name = " +
            JsonConvert.ToString(value) + " })").Value;
        Assert.Equal(expected, result["display_name"]!.Value<string>());
        Assert.True(result["enabled"]!.Value<bool>());
    }

    [Fact]
    public void Generated_model_hash_default_uses_a_string_expression_without_changing_other_defaults()
    {
        var schema = JObject.Parse(SchemaConsumerCompilation.Fixture);
        schema["models"]![0]!["schema"]!["properties"]!["display_name"]!["default"] = "#{default}";
        var result = SchemaConsumerCompilation.Build(
            "Catalog.Generated.CatalogDestinations.Payload(content: () => new PayloadModel { })", schema: schema.ToString()).Value;
        Assert.Equal("#{\"#{default}\"}", result["display_name"]!.Value<string>());
        Assert.True(result["enabled"]!.Value<bool>());
    }

    [Theory]
    [InlineData("#{RuntimeValues.NextText()}", "#{\"#{RuntimeValues.NextText()}\"}")]
    [InlineData("prefix @{RuntimeValues.NextText()}", "#{\"prefix @{RuntimeValues.NextText()}\"}")]
    public void Literal_expression_looking_text_evaluates_once_to_string_data_without_executing_its_contents(
        string literal, string expected)
    {
        var emitted = Input(JsonConvert.ToString(literal), resultType: "string")!.Value<string>()!;
        Assert.Equal(expected, emitted);
        var result = LocalNativeHost.Evaluate(emitted, new());
        Assert.Equal(literal, result.Value);
        Assert.Equal(0, result.Calls);
        Assert.Empty(result.Reads);
    }

    [Fact]
    public void Captured_JSON_wraps_reserved_hash_values_but_preserves_keys_and_double_hashes()
    {
        var value = Input("snapshot", """
            JToken snapshot = JObject.Parse("{\"#{key}\":[\"#{1 + 2}\",\"##{1 + 2}\",\"prefix @{1 + 2}\",3,null]}");
            """);
        Assert.True(JToken.DeepEquals(JObject.Parse("""
            {"#{key}":["#{\"#{1 + 2}\"}","##{1 + 2}","#{\"prefix @{1 + 2}\"}",3,null]}
            """), value));
    }

    [Fact]
    public void Literal_hash_wire_rendering_does_not_change_base64_input_or_mutate_the_descriptor()
    {
        const string value = "#{1 + 2}";
        var descriptor = SourceExpression.Literal(1, value);
        var pass = WorkflowActions.BuiltIn.Compose(descriptor);
        Assert.Equal("#{\"#{1 + 2}\"}", Token(pass.GetActionDefinition("Before")).Value<string>());
        var encoded = new ServicebusActions("connection").SendMessage(
            SourceExpression.Literal(1, "queue"), SourceExpression.Token(1, descriptor));
        var emitted = Token(encoded.GetActionDefinition("Encoded"))["body"]!["ContentData"]!.Value<string>()!;
        Assert.Equal("#{base64(\"#{1 + 2}\")}", emitted);
        Assert.Equal(Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value)),
            LocalNativeHost.Evaluate(emitted, new()).Value);
        Assert.Equal("#{\"#{1 + 2}\"}", Token(pass.GetActionDefinition("After")).Value<string>());
    }

    [Fact]
    public void JSON_and_URI_helpers_receive_raw_hash_literals_not_wire_wrapper_expressions()
    {
        var encoded = SchemaConsumerCompilation.Build("""
            Catalog.Generated.CatalogDestinations.EncodeJson(content: () => new { Text = "#{1 + 2}" })
            """).Value.Value<string>()!;
        Assert.Equal("#{base64(\"{\\\"Text\\\":\\\"#{1 + 2}\\\"}\")}", encoded);
        Assert.Equal("""{"Text":"#{1 + 2}"}""", System.Text.Encoding.UTF8.GetString(
            Convert.FromBase64String(Assert.IsType<string>(LocalNativeHost.Evaluate(encoded, new()).Value))));
        var parsed = Input("""WorkflowFunctions.ToJson("{\"text\":\"#{1 + 2}\"}")""")!.Value<string>()!;
        Assert.Equal("#{json(\"{\\\"text\\\":\\\"#{1 + 2}\\\"}\")}", parsed);
        Assert.Equal("#{1 + 2}", Assert.IsType<JObject>(LocalNativeHost.Evaluate(parsed, new()).Value)["text"]!.Value<string>());
        var path = SchemaConsumerCompilation.Build("""
            Catalog.Generated.CatalogDestinations.SinglePath(content: () => "#{raw}")
            """).Value.Value<string>()!;
        Assert.Equal("#{string.Format(\"/items/{0}\", encodeURIComponent(\"#{raw}\"))}", path);
        Assert.Equal("/items/%23%7Braw%7D", LocalNativeHost.Evaluate(path, new()).Value);
    }

    [Theory]
    [InlineData("#{raw}", "#{\"#{raw}\"}", "#{string.Format(\"/{0}\", \"#{raw}\")}")]
    [InlineData("##{raw}", "##{raw}", "/##{raw}")]
    [InlineData("literal@{value}", "#{\"literal@{value}\"}", "#{\"/literal@{value}\"}")]
    public void URI_literals_and_untransformed_paths_apply_literal_protection_without_changing_data(
        string literal, string expected, string expectedPath)
    {
        Assert.Equal(expected, Input("uri",
            "var uri = new Uri(" + JsonConvert.ToString(literal) + ", UriKind.Relative);")!.Value<string>());
        var schema = JObject.Parse(SchemaConsumerCompilation.Fixture);
        var operation = schema["operations"]!.Single(o => o["name"]!.Value<string>() == "SinglePath");
        operation["path"] = "/{0}";
        operation["parameters"]![0]!["schema"]!["transforms"] = new JArray();
        var emitted = SchemaConsumerCompilation.Build(
            "Catalog.Generated.CatalogDestinations.SinglePath(content: () => " + JsonConvert.ToString(literal) + ")",
            schema: schema.ToString()).Value.Value<string>();
        Assert.Equal(expectedPath, emitted);
        if (expectedPath.StartsWith("#{", StringComparison.Ordinal))
            Assert.Equal("/" + literal, LocalNativeHost.Evaluate(emitted!, new()).Value);
        else
            Assert.Equal("/" + literal, emitted);
    }
}

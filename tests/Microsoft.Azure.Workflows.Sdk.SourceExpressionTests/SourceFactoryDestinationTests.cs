namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class SourceFactoryDestinationTests
{
    [Fact]
    public void Reused_lambda_receives_the_bound_destination_parameter()
    {
        var result = SchemaConsumerCompilation.Build("CatalogDestinations.EncodeText(content: expression)",
            """Func<object> expression = () => "hello";""");
        Assert.Equal("@base64('hello')", result.Value.Value<string>());
        Assert.Contains("SourceExpression.Box", result.Transformation.Sources["Consumer.cs"]);
    }

    [Fact]
    public void Factory_descriptor_is_built_with_its_destination_metadata()
    {
        var result = SchemaConsumerCompilation.Build("CatalogDestinations.EncodeText(content: Factory(source, \"!\"))",
            """
            Func<object> Factory(IOutputWorkflowAction<string> action, string suffix)
                => () => action.Output + suffix;
            """);
        Assert.Contains("SourceExpression.Box", result.Transformation.Sources["Consumer.cs"]);
        EqualSource("""@csharp{base64(outputs("Source").ToObject<string>() + "!")}""", result.Value.Value<string>()!);
    }

    [Fact]
    public void Factory_model_initializer_preserves_authoritative_defaults()
    {
        var result = SchemaConsumerCompilation.Build("CatalogDestinations.Payload(content: Factory(source))",
            """
            Func<PayloadModel> Factory(IOutputWorkflowAction<string> action)
                => () => new PayloadModel { Name = action.Output };
            """);
        Assert.Equal("@outputs('Source')", result.Value["display_name"]!.Value<string>());
        Assert.True(result.Value["enabled"]!.Value<bool>());
        Assert.Contains("SourceExpression.Model<", result.Transformation.Sources["Consumer.cs"]);
    }

    [Fact]
    public void Multiple_consumers_of_the_same_schema_share_a_factory_descriptor()
    {
        var result = SchemaConsumerCompilation.Build("CatalogDestinations.EncodeText(content: expression)",
            """
            Func<object> Factory() => () => "hello";
            var expression = Factory();
            _ = CatalogDestinations.EncodeText(content: expression);
            """);
        Assert.Equal("@base64('hello')", result.Value.Value<string>());
    }

    [Fact]
    public void Generated_object_forwarder_preserves_the_factory_field()
    {
        var result = SchemaConsumerCompilation.Build(
            """CatalogDestinations.Fields(name: Factory(), count: () => 3, label: () => "label")""",
            """Func<object> Factory() => () => "hello";""");
        Assert.Equal("hello", result.Value["name"]!.Value<string>());
        Assert.Equal(3, result.Value["count"]!.Value<int>());
        Assert.Equal("label", result.Value["label"]!.Value<string>());
    }

    [Fact]
    public void Generated_path_forwarder_preserves_the_factory_value()
    {
        var result = SchemaConsumerCompilation.Build("CatalogDestinations.SinglePath(content: Factory())",
            """Func<object> Factory() => () => "a b";""");
        Assert.Equal("/items/@{encodeURIComponent('a b')}", result.Value.Value<string>());
    }

    [Theory]
    [InlineData("""
        var expression = Factory();
        _ = CatalogDestinations.EncodeText(content: expression);
        return CatalogDestinations.AlreadyEncoded(content: expression).GetActionDefinition("Catalog");
        """)]
    [InlineData("""
        _ = CatalogDestinations.EncodeText(content: Factory());
        return CatalogDestinations.AlreadyEncoded(content: Factory()).GetActionDefinition("Catalog");
        """)]
    [InlineData("""
        var expression = Factory();
        _ = WorkflowActions.BuiltIn.Compose<object>(input: expression);
        return CatalogDestinations.EncodeText(content: expression).GetActionDefinition("Catalog");
        """)]
    public void Conflicting_factory_destinations_are_diagnosed_before_execution(string body)
    {
        var result = SchemaConsumerCompilation.Transform("""Func<object> Factory() => () => "hello";""" + body);
        Assert.Contains(result.Transformation.Diagnostics,
            diagnostic => diagnostic.Id == "WFBUILD009" &&
                diagnostic.GetMessage().Contains("conflicting workflow destination contracts", StringComparison.Ordinal));
    }

    [Fact]
    public void Destination_attribute_does_not_authorize_an_executable_non_sdk_consumer()
    {
        var result = SchemaConsumerCompilation.Transform("""
            Func<object> Factory() => () => RuntimeValues.NextText();
            static object Execute(
                [WorkflowExpression, WorkflowDestination("{\"version\":1,\"destination\":\"content\",\"kind\":\"text\",\"nullable\":false,\"optional\":false,\"transforms\":[]}")]
                Func<object> expression) => expression();
            _ = Execute(Factory());
            return CatalogDestinations.EncodeText(content: Factory()).GetActionDefinition("Catalog");
            """);
        Assert.Contains(result.Transformation.Diagnostics, diagnostic => diagnostic.Id == "WFBUILD001");
    }
}

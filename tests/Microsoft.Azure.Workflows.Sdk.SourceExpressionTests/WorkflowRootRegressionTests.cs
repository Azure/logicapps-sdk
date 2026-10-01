namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class WorkflowRootRegressionTests
{
    private const string GeneratedHandles = """
        var queueTrigger = WorkflowTriggers.ServiceProviders.Azurequeues("connection")
            .ReceiveQueueMessages(queueName: () => "queue").WithName("QueueTrigger");
        var sent = WorkflowActions.ServiceProviders.Azurequeues("connection")
            .PutMessage(queueName: () => "queue", message: () => "message").WithName("Sent");
        var queues = WorkflowActions.ServiceProviders.Azurequeues("connection")
            .ListQueues(prefix: () => "prefix").WithName("Queues");
        """;

    [Theory]
    [InlineData(true, "#{triggerOutputs()?[\"body\"]}")]
    [InlineData(false, null)]
    public void Managed_trigger_splitOn_uses_one_native_envelope_only_when_enabled(bool enabled, string? expected)
    {
        var trigger = (ApiConnectionTrigger)Activator.CreateInstance(
            typeof(ApiConnectionTrigger),
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
            binder: null,
            args: [new Func<ApiConnectionActionInput>(() => new ApiConnectionActionInput("/queue", "get", "connection")), "QueueTrigger", null, enabled],
            culture: null)!;
        var definition = trigger.GetTriggerDefinition();
        Assert.Equal(expected, definition.SplitOn);
        var serialized = JObject.Parse(definition.ToJson());
        Assert.Equal(expected, serialized["splitOn"]?.Value<string>());
        AssertNoTemplateExpressions(serialized);
    }

    [Fact]
    public void Generated_webhook_callback_default_is_an_executable_CSharp_expression_not_an_escaped_literal()
    {
        var built = Build(Source("""
            var trigger = WorkflowTriggers.Managed.Signinghubwebhooks("connection")
                .WebhookSubscribeTrigger(
                    bodyeventType: () => Microsoft.Azure.Workflows.Sdk.Connectors.Signinghubwebhooks.bodyeventTypeInput.SIGNED);
            return new FlowTemplateAction { Inputs = trigger.GetTriggerDefinition().Inputs };
            """));
        var inputs = Token(built.Definition);
        Assert.Equal("/powerautomate/webhook/subscribe", inputs["path"]!.Value<string>());
        Assert.Equal("post", inputs["method"]!.Value<string>());
        Assert.Equal("#{listCallbackUrl()}", inputs["body"]!["callbackUrl"]!.Value<string>());
        Assert.Equal("SIGNED", inputs["body"]!["eventType"]!.Value<string>());
        Assert.Equal(2, Assert.IsType<JObject>(inputs["body"]).Count);
    }

    [Theory]
    [InlineData("queueTrigger.TriggerBody.MessageId",
        "#{triggerBody()[\"messageId\"]}",
        "triggerBody().ToObject<Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues.ReceiveQueueMessagesOutput>().MessageId",
        "Trigger", """{"messageId":"abc"}""")]
    [InlineData("sent.Output.MessageId",
        "#{outputs(\"Sent\")[\"messageId\"]}",
        "outputs(\"Sent\").ToObject<Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues.PutMessageOutput>().MessageId",
        "Sent", """{"messageId":"abc"}""")]
    [InlineData("queues.Body.ContinuationToken",
        "#{body(\"Queues\")[\"continuationToken\"]}",
        "body(\"Queues\").ToObject<Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues.ListQueuesOutput>().ContinuationToken",
        "Queues", """{"continuationToken":"abc"}""")]
    public void Generated_workflow_paths_are_JSON_native_while_operations_preserve_typed_source(
        string expression, string wireExpression, string nativeRoot, string helperKey, string json)
    {
        var wire = Input(expression, GeneratedHandles)!.Value<string>()!;
        EqualSource(wireExpression, wire);
        var passedThrough = LocalNativeHost.Evaluate(wire, new() { [helperKey] = JToken.Parse(json) });
        Assert.Equal("abc", Assert.IsType<JValue>(passedThrough.Value).Value<string>());
        Assert.Equal([helperKey], passedThrough.Reads);
        var emitted = Native(expression + ".ToUpperInvariant()", GeneratedHandles);
        EqualSource("#{" + nativeRoot + ".ToUpperInvariant()}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { [helperKey] = JToken.Parse(json) });
        Assert.Equal("ABC", local.Value);
        Assert.Equal([helperKey], local.Reads);
    }

    [Fact]
    public void Typed_object_initializer_member_names_are_not_implicit_instance_captures()
    {
        const string fixture = """
            public sealed class RuntimePayload
            {
                public RuntimePayload() { RuntimeValues.Calls++; }
                public string Label { get; set; }
                public int Count { get; set; }
            }
            """;
        var result = Build(Source(Handles + """
            var action = WorkflowActions.BuiltIn.Compose<RuntimePayload>(input: () => new RuntimePayload
            {
                Label = source.Output.ToUpperInvariant(),
                Count = count.Output + 1
            });
            return action.GetActionDefinition("Catalog");
            """, fixture));
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("""
            #{new global::Consumer.RuntimePayload
            {
                Label = outputs("Source").ToObject<string>().ToUpperInvariant(),
                Count = outputs("Count").ToObject<int>() + 1
            }}
            """, emitted);
        var local = LocalNativeHost.Evaluate(emitted,
            new() { ["Source"] = new JValue("abc"), ["Count"] = new JValue(3) },
            "public static class Consumer { " + fixture + " }");
        Assert.Equal(1, local.Calls);
        Assert.True(JToken.DeepEquals(JObject.Parse("""{"Label":"ABC","Count":4}"""), JToken.FromObject(local.Value!)));
    }

    [Theory]
    [InlineData("new AgentPromptMessage[]")]
    [InlineData("new[]")]
    public void Actual_agent_message_initializers_preserve_structural_roles_and_content(string arrayCreation)
    {
        var result = Build(Source(Handles + $$"""
            return WorkflowActions.BuiltIn.Agent(
                agentModelType: default,
                deploymentId: "deployment",
                agentModelSettings: null,
                connectionName: "connection",
                messages: () => {{arrayCreation}}
                {
                    new AgentPromptMessage { Role = MessageRole.System, Content = "You are helpful." },
                    new AgentPromptMessage { Role = MessageRole.User, Content = $"Name: {source.Output}" },
                    new AgentPromptMessage { Role = MessageRole.Assistant, Content = source.Output.ToUpperInvariant() }
                }).GetActionDefinition("Catalog");
            """));
        var messages = Assert.IsType<JArray>(Token(result.Definition)["parameters"]!["messages"]);
        Assert.Equal(3, messages.Count);
        Assert.Equal("System", messages[0]["role"]!.Value<string>());
        Assert.Equal("You are helpful.", messages[0]["content"]!.Value<string>());
        Assert.Equal("User", messages[1]["role"]!.Value<string>());
        Assert.Equal("#{$\"Name: {outputs(\"Source\").ToObject<string>()}\"}", messages[1]["content"]!.Value<string>());
        Assert.Equal("Assistant", messages[2]["role"]!.Value<string>());
        EqualSource("#{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}", messages[2]["content"]!.Value<string>()!);
        Assert.Contains("SourceExpression.Array<", result.Transformation.Sources["Consumer.cs"]);
        Assert.Contains("SourceExpression.Object<", result.Transformation.Sources["Consumer.cs"]);
    }

    [Fact]
    public void Workflow_computed_getter_remains_native_and_is_not_invoked_during_generation()
    {
        const string fixture = """
            public sealed class ComputedModel
            {
                public string Text { get; set; }
                public string Upper
                {
                    get { RuntimeValues.Calls++; return Text.ToUpperInvariant(); }
                }
            }
            """;
        var result = Build(Source("""
            var model = WorkflowActions.BuiltIn.Compose<ComputedModel>(input: () => new ComputedModel()).WithName("Model");
            return WorkflowActions.BuiltIn.Compose<string>(input: () => model.Output.Upper).GetActionDefinition("Catalog");
            """, fixture));
        Assert.Equal(0, result.Assembly.GetType("RuntimeValues")!.GetField("Calls")!.GetValue(null));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("#{outputs(\"Model\").ToObject<global::Consumer.ComputedModel>().Upper}", emitted);
        var local = LocalNativeHost.Evaluate(emitted,
            new() { ["Model"] = JObject.Parse("""{"Text":"abc"}""") },
            "public static class Consumer { " + fixture + " }");
        Assert.Equal("ABC", local.Value);
        Assert.Equal(1, local.Calls);
    }
}

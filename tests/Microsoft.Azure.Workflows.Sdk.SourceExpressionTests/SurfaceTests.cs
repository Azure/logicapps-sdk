namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using Newtonsoft.Json.Linq;
using static ConsumerCompilation;

public sealed class SurfaceTests
{
    [Fact, Trait("Catalog", "R07")]
    public void R07_Variable_reference_uses_variable_name_not_action_name()
    {
        var result = Build(Source("""
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable<string>(name: () => "message", value: () => "initial")
                .WithName("Initialize");
            return WorkflowActions.BuiltIn.Compose<object>(input: () => variable.Value).GetActionDefinition("Catalog");
            """));
        Assert.Equal("@variables('message')", Token(result.Definition).Value<string>());
    }

    [Fact, Trait("Catalog", "IN02")]
    public void IN02_Response_body_uses_source_descriptor()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Response(responseBody: () => source.Output.ToUpperInvariant()).GetActionDefinition("Catalog");
            """));
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}", Token(result.Definition)["body"]!.Value<string>()!);
    }

    [Fact, Trait("Catalog", "IN03"), Trait("Catalog", "I02")]
    public void IN03_Response_enum_status_is_numeric()
    {
        var result = Build(Source("""
            return WorkflowActions.BuiltIn.Response(statusCode: () => System.Net.HttpStatusCode.Accepted).GetActionDefinition("Catalog");
            """));
        Assert.Equal(JTokenType.Integer, Token(result.Definition)["statusCode"]!.Type);
        Assert.Equal(202, Token(result.Definition)["statusCode"]!.Value<int>());
    }

    [Fact, Trait("Catalog", "IN04"), Trait("Catalog", "I01"), Trait("Catalog", "L16")]
    public void IN04_Absent_status_defaults_while_absent_headers_remain_omitted()
    {
        // No expression is supplied here: absence must not manufacture a descriptor.
        var source = Source("""return WorkflowActions.BuiltIn.Response(headers: null).GetActionDefinition("Catalog");""");
        var result = Transform(source);
        Assert.Empty(result.Diagnostics);
        var definition = (FlowTemplateAction)Invoke(Load(Compile(result.Sources["Consumer.cs"])), "Consumer", "Build")!;
        Assert.Equal(200, Token(definition)["statusCode"]!.Value<int>());
        Assert.Null(Token(definition)["headers"]);
    }

    [Fact]
    public void Explicit_null_Response_status_argument_still_defaults_to_200()
    {
        var source = Source("""
            return WorkflowActions.BuiltIn.Response(statusCode: null).GetActionDefinition("Catalog");
            """);
        var transformed = Transform(source);
        Assert.Empty(transformed.Diagnostics);
        var definition = (FlowTemplateAction)Invoke(Load(Compile(transformed.Sources["Consumer.cs"])), "Consumer", "Build")!;
        Assert.Equal(200, Token(definition)["statusCode"]!.Value<int>());
    }

    [Fact, Trait("Catalog", "IN06")]
    public void IN06_Reversed_named_connector_arguments_keep_their_typed_destinations()
    {
        var result = Build(Source(Handles + """
            return new Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission.AcceptmissionActions("connection")
                .Postdepartments(bodyposition: () => count.Output + 1,
                    bodytitle: () => source.Output + "!").GetActionDefinition("Catalog");
            """));
        var body = Assert.IsType<JObject>(Token(result.Definition)["body"]);
        Assert.Equal(2, body.Count);
        var title = body["title"]!.Value<string>()!;
        var position = body["position"]!.Value<string>()!;
        EqualSource("@csharp{outputs(\"Source\").ToObject<string>() + \"!\"}", title);
        EqualSource("@csharp{outputs(\"Count\").ToObject<int>() + 1}", position);
        var inputs = new Dictionary<string, JToken?>
        {
            ["Source"] = new JValue("hello"),
            ["Count"] = new JValue(3),
        };
        Assert.Equal("hello!", LocalNativeHost.Evaluate(title, inputs).Value);
        Assert.Equal(4, Assert.IsType<int>(LocalNativeHost.Evaluate(position, inputs).Value));
    }

    [Fact, Trait("Catalog", "IN07"), Trait("Catalog", "Q05")]
    public void IN07_Headers_have_independent_reference_and_native_values()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Response(headers: () => new Dictionary<string, string>
            {
                { "X-Name", source.Output },
                { "X-Upper", other.Output.ToUpperInvariant() }
            }).GetActionDefinition("Catalog");
            """));
        var headers = Assert.IsType<JObject>(Token(result.Definition)["headers"]);
        Assert.Equal(2, headers.Count);
        Assert.Equal("@outputs('Source')", headers["X-Name"]!.Value<string>());
        EqualSource("@csharp{outputs(\"Other\").ToObject<string>().ToUpperInvariant()}", headers["X-Upper"]!.Value<string>()!);
    }

    [Fact, Trait("Catalog", "Q01")]
    public void Q01_Structural_payload_keeps_json_types_and_leaf_routes()
    {
        var result = Input("""
            new
            {
                enabled = true,
                count = 3,
                body = trigger.TriggerOutput.Body,
                message = $"Output: {source.Output}",
                labels = new[] { "a", "b" }
            }
            """);
        Assert.True(JToken.DeepEquals(JObject.Parse("""
            {
                "enabled": true,
                "count": 3,
                "body": "@triggerBody()",
                "message": "Output: @{outputs('Source')}",
                "labels": ["a", "b"]
            }
            """), result));
    }

    [Fact, Trait("Catalog", "SC01")]
    public void SC01_Type_alias_is_resolved_for_standalone_native_source()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<int>(input: () => MathAlias.Abs(count.Output)).GetActionDefinition("Catalog");
            """, imports: "using MathAlias = System.Math;"));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{global::System.Math.Abs(outputs(\"Count\").ToObject<int>())}", emitted);
        Assert.Equal(3, LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(-3) }).Value);
    }

    [Fact, Trait("Catalog", "SC02")]
    public void SC02_Static_import_is_resolved_for_standalone_native_source()
    {
        var result = Build(Source(Handles + """
            return WorkflowActions.BuiltIn.Compose<int>(input: () => Abs(count.Output)).GetActionDefinition("Catalog");
            """, imports: "using static System.Math;"));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{global::System.Math.Abs(outputs(\"Count\").ToObject<int>())}", emitted);
        Assert.Equal(3, LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(-3) }).Value);
    }

    [Fact, Trait("Catalog", "SC05")]
    public void SC05_Ambient_checked_context_survives_extraction()
    {
        var result = Build(Source(Handles + """
            checked
            {
                return WorkflowActions.BuiltIn.Compose<int>(input: () => count.Output + 1).GetActionDefinition("Catalog");
            }
            """));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{checked(outputs(\"Count\").ToObject<int>() + 1)}", emitted);
        Assert.Throws<OverflowException>(() => LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(int.MaxValue) }));
    }

    [Fact, Trait("Catalog", "R11")]
    public void R11_Actual_foreach_callback_item_is_a_workflow_reference()
    {
        var result = Build(Source(Handles + """
            int factories = 0;
            var loop = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => trigger.TriggerOutput.Body["rows"],
                actions: item =>
                {
                    factories++;
                    return WorkflowActions.BuiltIn.Compose<JToken>(input: () => item["name"]).WithName("ReadName");
                });
            var definition = loop.GetActionDefinition("Catalog");
            _ = loop.GetActionDefinition("Catalog");
            if (factories != 1) throw new InvalidOperationException("Graph factory executed more than once.");
            return definition;
            """));
        Assert.Contains("SourceBinding.Item(", result.Transformation.Sources["Consumer.cs"]);
        Assert.Equal("@triggerBody()['rows']", result.Definition.Foreach.Value<string>());
        var nested = Assert.Single(result.Definition.Actions);
        Assert.Equal("ReadName", nested.Key);
        Assert.Equal("@item()['name']", Token(nested.Value).Value<string>());
    }

    [Fact, Trait("Catalog", "R10")]
    public void R10_Actual_agent_tool_context_produces_parameter_reference()
    {
        var result = BuildAgentTool("ctx.Parameters.Name");
        Assert.Contains("SourceBinding.AgentParameter(", result.Transformation.Sources["Consumer.cs"]);
        var branch = Assert.Single(result.Definition.Tools).Value;
        Assert.Equal("@agentparameters('Name')", Token(Assert.Single(branch.Actions).Value).Value<string>());
    }

    [Fact, Trait("Catalog", "I09"), Trait("Catalog", "IN14")]
    public void IN14_Actual_agent_tool_native_parameter_consumer_is_typed()
    {
        var result = BuildAgentTool("ctx.Parameters.Name.ToUpperInvariant()");
        Assert.Contains("SourceBinding.AgentParameter(", result.Transformation.Sources["Consumer.cs"]);
        var branch = Assert.Single(result.Definition.Tools).Value;
        var emitted = Token(Assert.Single(branch.Actions).Value).Value<string>()!;
        EqualSource("@csharp{agentparameters(\"Name\").ToObject<string>().ToUpperInvariant()}", emitted);
        var local = LocalNativeHost.Evaluate(emitted, new() { ["Name"] = new JValue("alice") });
        Assert.Equal("ALICE", local.Value);
        Assert.Equal(["agent:Name"], local.Reads);
    }

    [Fact, Trait("Catalog", "Q02")]
    public void Q02_Inferred_anonymous_compose_preserves_output_type_and_calculation()
    {
        var result = Build(Source(Handles + """
            var action = WorkflowActions.BuiltIn.Compose(input: () => new
            {
                Next = count.Output + 1,
                Accepted = flag.Output && count.Output > 0
            });
            Func<int> verifyOutputStillHasAnonymousType = () => action.Output.Next;
            return action.GetActionDefinition("Catalog");
            """));
        var emitted = Token(result.Definition).Value<string>()!;
        EqualSource("@csharp{new { Next = outputs(\"Count\").ToObject<int>() + 1, Accepted = outputs(\"Flag\").ToObject<bool>() && outputs(\"Count\").ToObject<int>() > 0 }}", emitted);
        var value = LocalNativeHost.Evaluate(emitted, new() { ["Count"] = new JValue(3), ["Flag"] = new JValue(true) }).Value;
        Assert.True(JToken.DeepEquals(JObject.Parse("""{"Next":4,"Accepted":true}"""), JToken.FromObject(value!)));
    }

    [Fact, Trait("Catalog", "SC08")]
    public void SC08_Generic_factory_preserves_direct_reference_with_concrete_call_type()
    {
        var result = Build(Source("""
            var source = WorkflowActions.BuiltIn.Compose<int>(input: () => 3).WithName("Source");
            return Create(source).GetActionDefinition("Catalog");
            """, """
            private static IOutputWorkflowAction<T> Create<T>(IOutputWorkflowAction<T> action)
                => WorkflowActions.BuiltIn.Compose<T>(input: () => action.Output);
            """));
        Assert.Equal("@outputs('Source')", Token(result.Definition).Value<string>());
    }

    private static (FlowTemplateAction Definition, System.Reflection.Assembly Assembly,
        global::Microsoft.Azure.Workflows.Sdk.Build.TransformationResult Transformation) BuildAgentTool(string expression) =>
        Build(Source($$"""
            int factories = 0;
            var agent = WorkflowActions.BuiltIn.Agent(default, "deployment", null, "connection", null)
                .AddTool<ToolParameters>(ctx =>
                {
                    factories++;
                    return (IWorkflowAction)WorkflowActions.BuiltIn.Compose(inputs: () => {{expression}}).WithName("ToolAction");
                }, "description", new ToolParameters { Name = "Generation-time schema value" });
            var definition = agent.GetActionDefinition("Catalog");
            _ = agent.GetActionDefinition("Catalog");
            if (factories != 1) throw new InvalidOperationException("Graph factory executed more than once.");
            return definition;
            """, "public class ToolParameters { public string Name { get; set; } }"));
}

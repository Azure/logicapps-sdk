// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests;

using Newtonsoft.Json.Linq;

/// <summary>
/// Consumer-build regressions authored through SDK lambdas, transformed by the
/// repository's normal MSBuild source-compilation targets.
/// </summary>
public sealed class SourceCompiledExpressionTests
{
    [Fact]
    public void Structured_payload_preserves_mixed_literal_types_and_enum_wire_value()
    {
        var action = WorkflowActions.BuiltIn.Compose(input: () => new
        {
            b = true,
            l = 10L,
            d = 1.5,
            dec = 2.5m,
            e = FlowStatus.Running,
            n = (string)null,
        });

        Assert.True(JToken.DeepEquals(
            JObject.Parse("""{"b":true,"l":10,"d":1.5,"dec":2.5,"e":"Running","n":null}"""),
            Input(action)));
    }

    [Fact]
    public void Ordinary_model_initializer_preserves_native_construction()
    {
        var action = WorkflowActions.BuiltIn.Compose(input: () => new Poco { Name = "hi", Count = 3, Tag = "t" });
        var expression = Native(action);

        Assert.Contains("new ", expression);
        Assert.Contains("Poco", expression);
        Assert.Contains("Name = \"hi\"", expression);
        Assert.Contains("Count = 3", expression);
        Assert.Contains("Tag = \"t\"", expression);
        Assert.DoesNotContain("\"renamed\"", expression);
    }

    [Fact]
    public void Typed_model_body_navigation_respects_JsonProperty_without_materializing_model()
    {
        var source = WorkflowActions.BuiltIn.CustomCode<Poco>(_ => Task.FromResult<Poco>(null))
            .WithName("Model");
        var action = WorkflowActions.BuiltIn.Compose(input: () => source.Body.Tag);

        Assert.Equal("#{body(\"Model\")[\"renamed\"]}", Native(action));
    }

    [Fact]
    public void Variable_interpolation_uses_variable_name_and_native_string_source()
    {
        var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
            name: () => "myVar", value: () => "v").WithName("Initialize");
        var action = WorkflowActions.BuiltIn.Compose(inputs: () => $"prefix-{variable.Value}");

        Assert.Equal("#{$\"prefix-{variables(\"myVar\")}\"}", Native(action));
    }

    [Fact]
    public void Managed_trigger_interpolation_remains_one_native_expression()
    {
        var trigger = WorkflowTriggers.Managed.Azurequeues("connection")
            .OnMessages(storageAccountName: () => "account", queueName: () => "queue");
        var action = WorkflowActions.BuiltIn.Compose(inputs: () => $"Message: {trigger.TriggerBody}");

        var expression = Native(action);
        Assert.StartsWith("#{$\"Message: {triggerBody()", expression);
        Assert.EndsWith("}\"}", expression);
    }

    [Fact]
    public void Mixed_compose_and_managed_body_interpolation_keeps_both_runtime_references()
    {
        var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
        var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint")
            .GetItems(dataset: () => "d", table: () => "t").WithName("GetItems");
        var action = WorkflowActions.BuiltIn.Compose(inputs: () => $"a {compose.Output} b {sharepoint.Body}");

        var expression = Native(action);
        Assert.StartsWith("#{$\"a {outputs(\"ComposeInput\")} b {body(\"GetItems\")", expression);
        Assert.EndsWith("}\"}", expression);
    }

    [Fact]
    public void Trigger_and_action_token_comparison_preserves_CSharp_equality_not_template_equals()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        var compose = WorkflowActions.BuiltIn.Compose<JToken>(input: () => (JToken)null).WithName("ComposeInput");
        var action = WorkflowActions.BuiltIn.Compose(input: () => trigger.TriggerOutput.Body == compose.Output);

        Assert.Equal("#{triggerBody() == outputs(\"ComposeInput\")}", Native(action));
    }

    [Fact]
    public void Integer_connector_path_uses_destination_specific_single_and_double_encoding()
    {
        var single = WorkflowActions.Managed.Sharepointonline("sharepoint")
            .GetItem(dataset: () => "d", table: () => "t", id: () => 42);
        var twice = WorkflowActions.Managed.Sharepointonline("sharepoint")
            .CheckOutFile(dataset: () => "d", table: () => "t", id: () => 42);

        Assert.Equal(
            "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}/tables/{1}/items/{2}\", encodeURIComponent(encodeURIComponent(\"d\")), encodeURIComponent(encodeURIComponent(\"t\")), encodeURIComponent(42))}",
            Input(single)["path"].Value<string>());
        Assert.Equal(
            "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}/tables/{1}/items/{2}/checkoutfile\", encodeURIComponent(encodeURIComponent(\"d\")), encodeURIComponent(encodeURIComponent(\"t\")), encodeURIComponent(encodeURIComponent(42)))}",
            Input(twice)["path"].Value<string>());
    }

    private static JToken Input(IWorkflowAction action)
    {
        var input = action.GetActionDefinition("Result").Inputs;
        return JToken.Parse(input.ToJson());
    }

    private static string Native(IWorkflowAction action)
    {
        var token = Input(action);
        Assert.Equal(JTokenType.String, token.Type);
        var expression = token.Value<string>();
        Assert.StartsWith("#{", expression);
        Assert.EndsWith("}", expression);
        Assert.DoesNotContain("@{", expression);
        return expression;
    }
}

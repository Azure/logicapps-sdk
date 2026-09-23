// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;

    public class ExpressionConverterTests
    {
        [Fact]
        public void Compose_InterceptorPreservesArbitraryCSharpSyntax()
        {
            var compose = WorkflowActions.BuiltIn.Compose(
                () => DateTime.UtcNow.DayOfWeek switch
                {
                    DayOfWeek.Saturday or DayOfWeek.Sunday => "weekend",
                    _ => "weekday",
                });

            Assert.Equal(
                "#{DateTime.UtcNow.DayOfWeek switch\r\n{\r\n    DayOfWeek.Saturday or DayOfWeek.Sunday => \"weekend\",\r\n    _ => \"weekday\",\r\n}}",
                (string)(Newtonsoft.Json.Linq.JToken)compose.GetActionDefinition("flow").Inputs);
        }

        [Fact]
        public void Compose_InterceptorBindsFinalWorkflowOperationName()
        {
            var finalName = "DynamicallyNamed";
            var source = WorkflowActions.BuiltIn.Compose(() => "value").WithName(finalName);
            var target = WorkflowActions.BuiltIn.Compose(() => $"{source.Output}");

            Assert.Equal(
                "#{$\"{outputs(\"DynamicallyNamed\")}\"}",
                (string)(Newtonsoft.Json.Linq.JToken)target.GetActionDefinition("flow").Inputs);
        }

        [Fact]
        public void Interceptor_BindsCapturedScalarValues()
        {
            var threshold = 5;
            var dataset = "captured-dataset";
            var compose = WorkflowActions.BuiltIn.Compose(() => threshold + 1);
            var getItems = WorkflowActions.Managed.Sharepointonline("sharepoint").GetItems(
                dataset: () => dataset,
                table: () => "items");

            Assert.Equal(
                "#{5 + 1}",
                (string)(Newtonsoft.Json.Linq.JToken)compose.GetActionDefinition("flow").Inputs);
            var path = GetPath(getItems);
            Assert.StartsWith("#{", path);
            Assert.Contains(
                "encodeURIComponent(encodeURIComponent(\"captured-dataset\"))",
                path);
            Assert.Contains("encodeURIComponent(\"items\")", path);
        }

        [Fact]
        public void ManagedConnectorPath_PreservesArbitraryCSharpSyntax()
        {
            var getItems = WorkflowActions.Managed.Sharepointonline("sharepoint").GetItems(
                dataset: () => DateTime.UtcNow.DayOfWeek switch
                {
                    DayOfWeek.Saturday or DayOfWeek.Sunday => "weekend",
                    _ => "weekday",
                },
                table: () => "items");

            var path = GetPath(getItems);
            Assert.StartsWith("#{", path);
            Assert.Contains("DateTime.UtcNow.DayOfWeek switch", path);
            Assert.Contains("encodeURIComponent(\"items\")", path);
        }

        [Fact]
        public void ApiConnectionPath_DoesNotInterpretUnregisteredMarkers()
        {
            const string Path = "/literal/__logicapps_csharp_string_00000000000000000000000000000000__";

            var input = new ApiConnectionActionInput(
                Path,
                method: "get",
                connectionId: "connection");

            Assert.Equal(Path, input.Path);
        }

        [Fact]
        public void ApiConnectionTriggerInput_UsesCSharpSplitOn()
        {
            var input = new ApiConnectionTriggerInput(
                path: "/items",
                method: "get",
                connectionId: "connection",
                recurrence: new FlowRecurrence(),
                enableSplitOn: true);

            Assert.Equal("#{triggerOutputs()?[\"body\"]}", input.SplitOn);
        }

        [Fact]
        public void ManagedConnectorWebhook_UsesCSharpCallbackUrl()
        {
            var trigger = WorkflowTriggers.Managed
                .Activityinfo("connection")
                .AddRecordTrigger(
                    formId: () => "form",
                    bodylabel: () => "label");
            var definition = Newtonsoft.Json.Linq.JObject.FromObject(
                trigger.GetTriggerDefinition());
            var inputs = (Newtonsoft.Json.Linq.JObject)definition.GetValue(
                "inputs",
                StringComparison.OrdinalIgnoreCase);
            var body = (Newtonsoft.Json.Linq.JObject)inputs.GetValue(
                "body",
                StringComparison.OrdinalIgnoreCase);
            var action = (Newtonsoft.Json.Linq.JObject)body.GetValue(
                "action",
                StringComparison.OrdinalIgnoreCase);

            Assert.Equal("#{listCallbackUrl()}", (string)action["url"]);
        }

        private static string GetPath(IWorkflowAction action)
        {
            var actionDefinition = Newtonsoft.Json.Linq.JObject.FromObject(
                action.GetActionDefinition("flow"));
            var inputs = (Newtonsoft.Json.Linq.JObject)actionDefinition.GetValue(
                "inputs",
                StringComparison.OrdinalIgnoreCase);
            return (string)inputs.GetValue("path", StringComparison.OrdinalIgnoreCase);
        }
    }
}

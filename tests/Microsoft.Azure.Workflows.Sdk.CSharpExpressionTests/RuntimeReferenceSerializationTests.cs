// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Newtonsoft.Json.Linq;

    public class RuntimeReferenceSerializationTests
    {
        [Fact]
        public void GeneratedActionBody_PreservesJsonReferenceWithoutMaterializingConnectorModel()
        {
            var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint")
                .GetItems(dataset: () => "d", table: () => "t").WithName("GetItems");
            var response = WorkflowActions.BuiltIn.Response(responseBody: () => sharepoint.Body);

            var body = JObject.Parse(response.GetActionDefinition("workflow").ToJson())["inputs"]["body"];

            Assert.Equal("#{body(\"GetItems\")}", body.Value<string>());
        }

        [Fact]
        public void TriggerOutputAndBody_RemainDistinctReferencesInStructuredPayload()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("HttpTrigger");
            var response = WorkflowActions.BuiltIn.Response(
                responseBody: () => new { output = trigger.TriggerOutput, body = trigger.TriggerOutput.Body });
            var body = JObject.Parse(response.GetActionDefinition("workflow").ToJson())["inputs"]["body"];

            Assert.Equal("#{triggerOutputs()}", body["output"].Value<string>());
            Assert.Equal("#{triggerBody()}", body["body"].Value<string>());
        }

        [Fact]
        public void TypedTokenConversions_RemainNativeOnVariableReferences()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "myVar", value: () => "v");
            var objectRead = WorkflowActions.BuiltIn.Compose(() => variable.Value.ToObject<string>());
            var valueRead = WorkflowActions.BuiltIn.Compose(() => variable.Value.Value<string>());

            Assert.Equal("#{variables(\"myVar\").ToObject<string>()}",
                JObject.Parse(objectRead.GetActionDefinition("workflow").ToJson())["inputs"].Value<string>());
            Assert.Equal("#{variables(\"myVar\").Value<string>()}",
                JObject.Parse(valueRead.GetActionDefinition("workflow").ToJson())["inputs"].Value<string>());
        }
    }
}

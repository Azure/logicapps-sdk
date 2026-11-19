// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Xunit;

    public class NestedWorkflowActionTests
    {
        [Fact]
        public void NestedWorkflowSerializesLiteralReferenceAndExpressionInputs()
        {
            var action = WorkflowActions.BuiltIn.NestedWorkflow(
                workflowReferenceName: "ChildWorkflow",
                requestBody: () => new { value = "body" },
                headers: () => new Dictionary<string, string>
                {
                    { "x-test", "value" },
                });

            var definition = action.GetActionDefinition("flow", FlowKind.Stateful).ToJToken();

            Assert.Equal("ChildWorkflow", definition["inputs"]?["host"]?["workflow"]?["id"]?.ToObject<string>());
            Assert.StartsWith("#{", definition["inputs"]?["body"]?.ToObject<string>());
            Assert.StartsWith("#{", definition["inputs"]?["headers"]?.ToObject<string>());
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void NestedWorkflowRejectsMissingReferenceName(string workflowReferenceName)
        {
            var exception = Assert.Throws<ArgumentException>(
                () => WorkflowActions.BuiltIn.NestedWorkflow(workflowReferenceName));

            Assert.Equal("workflowReferenceName", exception.ParamName);
        }
    }
}

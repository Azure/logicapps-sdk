// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Xunit;

    public class AgentWorkflowActionTests
    {
        [Fact]
        public void AgentToolsBuildOnceAndRemainStableAcrossRendering()
        {
            var callbackCount = 0;
            var agent = WorkflowActions.BuiltIn.Agent(
                agentModelType: AgentModelType.AzureOpenAI,
                deploymentId: "deployment",
                agentModelSettings: new AgentModelSettings(),
                connectionName: "connection",
                messages: () => new[]
                {
                    new AgentPromptMessage
                    {
                        Role = MessageRole.System,
                        Content = "system",
                    },
                });

            agent.AddTool<ToolParameters>(
                _ =>
                {
                    callbackCount++;
                    return WorkflowActions.BuiltIn.Compose(() => "first").WithName("FirstToolAction");
                },
                description: "First tool",
                parameters: new ToolParameters());

            agent.AddTool<ToolParameters>(
                _ =>
                {
                    callbackCount++;
                    var first = WorkflowActions.BuiltIn.Compose(() => "first").WithName("ChainStart");
                    var second = WorkflowActions.BuiltIn.Compose(() => "second").WithName("ChainEnd");
                    return first.Then(second);
                },
                description: "Second tool",
                parameters: new ToolParameters());

            Assert.Equal(2, callbackCount);

            var firstDefinition = agent.GetActionDefinition("flow", FlowKind.Agentic);
            Assert.Equal(2, firstDefinition.Tools.Count);
            Assert.Contains("FirstToolAction", firstDefinition.Tools["Tool1"].Actions.Keys);
            Assert.Contains("ChainStart", firstDefinition.Tools["Tool2"].Actions.Keys);
            Assert.Contains("ChainEnd", firstDefinition.Tools["Tool2"].Actions.Keys);
            Assert.Equal("First tool", firstDefinition.Tools["Tool1"].Description);
            Assert.Equal("Second tool", firstDefinition.Tools["Tool2"].Description);

            var secondDefinition = agent.GetActionDefinition("flow", FlowKind.Agentic);
            Assert.Equal(2, secondDefinition.Tools.Count);
            Assert.Equal(2, callbackCount);
        }

        private sealed class ToolParameters
        {
            public string Name { get; set; }
        }
    }
}

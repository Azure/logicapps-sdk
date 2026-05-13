// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json;

    /// <summary>
    /// Nested workflow class.
    /// </summary>
    public static class NestedWorkflow
    {
        /// <summary>
        /// Adds the nested workflow.
        /// </summary>
        public static void AddNestedWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateConversationalAgentTrigger();

            var agent = WorkflowActions.BuiltIn.Agent(
                agentModelType: AgentModelType.AzureOpenAI,
                deploymentId: "gpt-4.1",
                agentModelSettings: new AgentModelSettings
                {
                    AgentChatCompletionSettings = new AgentChatCompletionSettings
                    {
                        MaxTokens = 3000,
                        Temperature = 0.7,
                        FrequencyPenalty = 0.1,
                        PresencePenalty = 0.1,
                        TopP = 0.1,
                    },
                    DeploymentModelProperties = new AgentDeploymentModelProperties
                    {
                        Name = "gpt-4o",
                        Format = "OpenAI",
                        Version = "2024-11-20"
                    }
                },
                connectionName: "agent",
                messages: () => new AgentPromptMessage[]
                {
                    new AgentPromptMessage
                    {
                        Role = MessageRole.System,
                        Content = "You are an agent to respond the weather to the user and send an email"
                    }
                }
            );

            agent.AddTool(toolContext =>
                {
                    var nestedWorkflow = WorkflowActions.BuiltIn.NestedWorkflow(
                        workflowReferenceName: () => "HttpRequestResponse",
                        requestBody: () => toolContext.Parameters.Location);
                    return nestedWorkflow;
                },
               description: "This tool gets the weather",
               parameters: new WeatherObject());

            agent.AddTool(toolContext =>
                {
                    var composeAction = WorkflowActions.BuiltIn.Compose(inputs: () => "Sending HTTP Request after getting weather");
                    var http = WorkflowActions.BuiltIn.HttpAction(
                        uri: () => new Uri("https://google.com"),
                        method: () => HttpMethod.Post);
                    return composeAction.Then(http);
                },
               description: "This tool will send a message",
               parameters: new WeatherObject());

            agent.AddTool(toolContext =>
                {
                    var sendEmailAction = WorkflowActions.Managed.Office365("connectionId").SendEmail(
                        emailMessageto: () => "apseth@microsoft.com",
                        emailMessagesubject: () => "Interview Scheduled",
                        emailMessagebody: () => "An interview has been scheduled.");
                    return sendEmailAction;
                },
               description: "This tool will send an email",
               parameters: new WeatherObject());

            trigger.Then(agent);

            WorkflowFactory.CreateAgentWorkflow("NestedWorkflow", trigger);
        }
    }

    /// <summary>
    /// My object class.
    /// </summary>
    public class WeatherObject
    {
        /// <summary>
        /// location property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Location { get; set; }
    }
}

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
            var nestedWorkflowBuilder = WorkflowBuilderFactory.CreateConversationalAgent("NestedWorkflow");

            var agent = new AgentBuilder
            {
                AgentModelType = AgentModelType.AzureOpenAI,
                DeploymentId = "gpt-4.1",
                AgentModelSettings = new AgentModelSettings
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
                Messages = new AgentPromptMessage[]
                    {
                        new AgentPromptMessage
                        {
                            Role = MessageRole.System,
                            Content = "You are an agent to respond the weather to the user and send an email"
                        }
                    },
                ConnectionName = "agent",
            };

            var toolBuilder = new AgentTool<MyObject>();

            agent.AddTool(toolBuilder =>
                {
                    var nestedWorkflow = WorkflowActions.BuiltIn.NestedWorkflow(
                        workflowReferenceName: () => "HttpRequestResponse",
                        requestBody: () => toolBuilder.Parameters.Location);
                    toolBuilder.AddAction(nestedWorkflow);
                },
               description: "This tool gets the weather",
               parameters: new WeatherObject());

            agent.AddTool(toolBuilder =>
                {
                    var composeAction = WorkflowActions.BuiltIn.Compose(inputs: () => "Sending HTTP Request after getting weather");
                    var http = WorkflowActions.BuiltIn.HttpAction(
                        uri: () => new Uri("https://google.com"),
                        method: () => HttpMethod.Post);
                        toolBuilder.AddAction(http,
                            runAfterSpecifications: new RunAfterSpecification[]
                            {
                                new RunAfterSpecification
                                {
                                    Action = composeAction,
                                    Status = new FlowStatus[] { FlowStatus.Succeeded }
                                }
                            });
                },
               description: "This tool will send a message",
               parameters: new WeatherObject());

            agent.AddTool(toolBuilder =>
                {
                    var sendEmailAction = WorkflowActions.ManagedConnectors.Office365("connectionId").SendEmailV2(
                        emailMessageto: () => "apseth@microsoft.com",
                        emailMessagesubject: () => "Interview Scheduled",
                        emailMessagebody: () => "An interview has been scheduled.");
                    toolBuilder.AddAction(action: sendEmailAction);
                },
               description: "This tool will send an email",
               parameters: new WeatherObject());

            nestedWorkflowBuilder.AddAgent(agent);
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

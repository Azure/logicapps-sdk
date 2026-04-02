// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk.Agents;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors;
    using Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Office365;

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
            var trigger = WorkflowFactory.CreateConversationalAgent("NestedWorkflow");

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

            agent.AddTool(tool =>
                {
                    var nestedWorkflow = WorkflowActions.BuiltIn.NestedWorkflow(
                        workflowReferenceName: () => "HttpRequestResponse",
                        requestBody: () => tool.Parameters.Location);
                    return nestedWorkflow;
                },
               description: "This tool gets the weather",
               parameters: new WeatherObject());

            agent.AddTool(tool =>
                {
                    var composeAction = WorkflowActions.BuiltIn.Compose(inputs: () => "Sending HTTP Request after getting weather");
                    var http = WorkflowActions.BuiltIn.HttpAction(
                        uri: () => new Uri("https://google.com"),
                        method: () => HttpMethod.Post);
                    composeAction.Then(http);
                    return composeAction;
                },
               description: "This tool will send a message",
               parameters: new WeatherObject());

            agent.AddTool(tool =>
                {
                    var sendEmailAction = WorkflowActions.ManagedConnectors.Office365("office365-2").SendEmailV2(emailMessage: () => new ClientSendHtmlMessage()
                    {
                        To = "apseth@microsoft.com",
                        Subject = "Interview Scheduled",
                        Body = "An interview has been scheduled."
                    });
                    return sendEmailAction;
                },
               description: "This tool will send an email",
               parameters: new WeatherObject());

            trigger.Then(agent);
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
        public string Location { get; set; }
    }
}

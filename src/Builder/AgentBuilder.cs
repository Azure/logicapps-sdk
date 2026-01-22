// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Entities;
    using Newtonsoft.Json;

    /// <summary>
    /// The agent entity that represents a model deployment and its settings.
    /// </summary>
    public class AgentBuilder : IWorkflowAction, IAgentActionBuilder
    {
        /// <summary>
        /// The tools for the agent action.
        /// </summary>
        private Dictionary<string, FlowTemplateActionToolBranch> Tools = new Dictionary<string, FlowTemplateActionToolBranch>();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the operation run after.
        /// </summary>
        public Dictionary<string, FlowStatus[]> RunAfterDictionary { get; private set; }

        /// <summary>
        /// Gets or sets the model deployment id.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Gets or sets the agent model type.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentModelType AgentModelType { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentPromptMessage[] Messages { get; set; }

        /// <summary>
        /// Gets or sets the agent model settings.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentModelSettings AgentModelSettings { get; set; }

        /// <summary>
        /// Gets or sets the connection name.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        [Agent(Type = ConnectorType.AgentConnection, ConnectorName = "agent", Id = "connectionProviders/agent")]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Adds a tool to the agent action.
        /// </summary>
        /// <param name="toolBuilder">The action.</param>
        /// <param name="description"> The description of the tool.</param>
        /// <param name="parameters">The schema.</param>
        public IAgentActionBuilder AddTool<T>(Action<IAgentToolBuilder<T>> toolBuilder, string description, T parameters) where T : class
        {
            var tool = new AgentTool<T>
            {
                Name = "Tool" + (this.Tools.Count + 1),
                Description = description,
                Parameters = parameters
            };

            toolBuilder(tool);

            var (name, toolBranch) = tool.GetFlowTemplateActionToolBranch();
            this.Tools.Add(name, toolBranch);

            return this;
        }

        /// <summary>
        /// Gets the action definition for the agent.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public FlowTemplateAction GetActionDefinition(string flowName)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Agent,
                Tools = this.Tools,
                Inputs = new AgentActionInput
                {
                    Parameters = new AgentActionInputParameters
                    {
                        AgentModelSettings = this.AgentModelSettings,
                        AgentModelType = this.AgentModelType,
                        DeploymentId = this.DeploymentId,
                        Messages = this.Messages,
                    },
                    ModelConfigurations = new Dictionary<string, AgentModelConfiguration>
                    {
                        { "model1", new AgentModelConfiguration { ReferenceName = this.ConnectionName } },
                    }
                },
                RunAfter = this.RunAfterDictionary,
            };
        }
    }
}

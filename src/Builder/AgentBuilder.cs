// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Entities;
    using Microsoft.Azure.Workflows.Sdk.Runtime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The agent entity that represents a model deployment and its settings.
    /// </summary>
    public class AgentBuilder : WorkflowActionBase
    {
        /// <summary>
        /// The tools for the agent action.
        /// </summary>
        private Dictionary<string, FlowTemplateActionToolBranch> Tools = new Dictionary<string, FlowTemplateActionToolBranch>();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

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
        /// Adds a tool to the agent action. The lambda receives parameters and returns the root action node of the tool chain.
        /// </summary>
        /// <param name="toolBuilder">A function that receives tool parameters and returns the root action node.</param>
        /// <param name="description">The description of the tool.</param>
        /// <param name="parameters">The schema parameters.</param>
        public AgentBuilder AddTool<T>(Func<IAgentToolParameters<T>, IWorkflowAction> toolBuilder, string description, T parameters) where T : class
        {
            var toolParams = new AgentToolParameters<T>(parameters);
            var rootAction = toolBuilder(toolParams);

            var toolName = "Tool" + (this.Tools.Count + 1);
            var toolBranch = BuildToolBranch(rootAction, description, parameters);
            this.Tools.Add(toolName, toolBranch);

            return this;
        }

        /// <summary>
        /// Gets the action definition for the agent.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
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
                RunAfter = this.RunAfterConfig.Count > 0 ? new Dictionary<string, FlowStatus[]>(this.RunAfterConfig) : null,
            };
        }

        /// <summary>
        /// Builds a FlowTemplateActionToolBranch by walking the action node graph.
        /// </summary>
        private static FlowTemplateActionToolBranch BuildToolBranch<T>(IWorkflowAction rootAction, string description, T parameters) where T : class
        {
            var actions = new Dictionary<string, FlowTemplateAction>();
            var visited = new HashSet<string>();
            var queue = new Queue<IWorkflowAction>();
            queue.Enqueue(rootAction);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (string.IsNullOrEmpty(node.Name))
                {
                    node.Name = Utility.GetUniqueActionName();
                }

                if (visited.Contains(node.Name))
                {
                    continue;
                }

                visited.Add(node.Name);

                var definition = node.GetActionDefinition(null);

                if (node.RunAfterConfig.Count > 0)
                {
                    definition.RunAfter = new Dictionary<string, FlowStatus[]>(node.RunAfterConfig);
                }

                actions[node.Name] = definition;

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            var toolBranch = new FlowTemplateActionToolBranch
            {
                Actions = actions,
                Description = description,
            };

            if (parameters != null)
            {
                var desc = new JObject();
                var schema = TypeGenerator.GenerateSchema(parameters.GetType(), desc);
                toolBranch.AgentParameterSchema = schema;
            }

            return toolBranch;
        }
    }
}

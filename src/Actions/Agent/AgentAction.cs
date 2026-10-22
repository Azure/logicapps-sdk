// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Azure.Workflows.Sdk.Entities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public sealed class AgentActionConfiguration :
        IWorkflowOperationConfiguration,
        IRetryPolicyConfigurationHolder,
        ITrackedPropertiesConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    /// <summary>
    /// The agent entity that represents a model deployment and its settings.
    /// </summary>
    public class AgentAction : WorkflowActionBase<AgentActionConfiguration>
    {
        /// <summary>
        /// Gets or sets the agent model type.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentModelType AgentModelType { get; set; }

        /// <summary>
        /// Gets or sets the model deployment id.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string DeploymentId { get; set; }

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
        /// Gets or sets the messages.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public object Messages { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAction"/> class.
        /// </summary>
        /// <param name="agentModelType">The agent model type.</param>
        /// <param name="deploymentId">The model deployment id.</param>
        /// <param name="agentModelSettings">The agent model settings.</param>
        /// <param name="connectionName">The agent connection name.</param>
        /// <param name="messages">The agent prompt messages.</param>
        internal AgentAction(
            AgentModelType agentModelType,
            string deploymentId,
            AgentModelSettings agentModelSettings,
            string connectionName,
            object messages)
        {
            this.AgentModelType = agentModelType;
            this.DeploymentId = deploymentId;
            this.AgentModelSettings = agentModelSettings;
            this.ConnectionName = connectionName;
            this.Messages = messages;
        }

        /// <summary>
        /// Gets the action definition for the agent.
        /// TODO(aeldridge): Make limit configurable.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        internal override FlowTemplateAction BuildActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Agent,
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
                Limit = flowKind == FlowKind.Stateful || flowKind == FlowKind.Agentic
                    ? new JObject
                    {
                        ["count"] = 100
                    }
                    : null
            };
        }
    }
}

// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The agent model settings.
    /// </summary>
    public class AgentModelSettings
    {
        /// <summary>
        /// Gets or sets the agent deployment model properties.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentDeploymentModelProperties DeploymentModelProperties { get; set; }

        /// <summary>
        /// Gets or sets the agent chat completion settings.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentChatCompletionSettings AgentChatCompletionSettings { get; set; }

        /// <summary>
        /// Gets or sets the agent history reduction settings.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentHistoryReductionSettings AgentHistoryReductionSettings { get; set; }
    }
}

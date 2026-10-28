//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The workflow agent parameters.
    /// </summary>
    public class AgentActionInputParameters
    {
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
        public object Messages { get; set; }

        /// <summary>
        /// Gets or sets the agent model settings.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentModelSettings AgentModelSettings { get; set; }
    }
}

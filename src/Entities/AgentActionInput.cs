//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The agent action input.
    /// </summary>
    public class AgentActionInput
    {
        /// <summary>
        /// Gets or sets the agent parameters.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public AgentActionInputParameters Parameters { get; set; }

        /// <summary>
        /// Gets or sets the agent model configuration.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, AgentModelConfiguration> ModelConfigurations { get; set; }
    }
}

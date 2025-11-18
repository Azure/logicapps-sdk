// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The agent deployment model properties.
    /// </summary>
    public class AgentDeploymentModelProperties
    {
        /// <summary>
        /// Gets or sets the agent deployment model name.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the agent deployment model format.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the agent deployment model version.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Version { get; set; }
    }
}

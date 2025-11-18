//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The agent model configuration.
    /// </summary>
    public class AgentModelConfiguration
    {
        /// <summary>
        /// Gets or sets the model connection reference name.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string ReferenceName { get; set; }
    }
}

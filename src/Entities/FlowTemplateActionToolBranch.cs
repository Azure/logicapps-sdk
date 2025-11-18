// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow template action tool branch.
    /// </summary>
    public class FlowTemplateActionToolBranch : FlowTemplateActionBranch
    {
        /// <summary>
        /// Gets or sets the tool branch description.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the agent parameter schema.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken AgentParameterSchema { get; set; }
    }
}

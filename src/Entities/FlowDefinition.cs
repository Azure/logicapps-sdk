//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The flow definition.
    /// </summary>
    public class FlowDefinition
    {
        /// <summary>
        /// Gets or sets the workflow name used as the registration key.
        /// This property is not serialized to JSON.
        /// </summary>
        [JsonIgnore]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the flow kind.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public FlowKind? Kind { get; set; }
        
        /// <summary>
        /// Gets or sets the flow definition.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public FlowTemplate Definition { get; set; }
    }
}

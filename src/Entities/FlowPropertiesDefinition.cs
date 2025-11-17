//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The flow properties definition.
    /// </summary>
    public class FlowPropertiesDefinition
    {
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

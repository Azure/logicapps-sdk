//-----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//-----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow definition operation.
    /// </summary>
    public class FlowTemplateOperation
    {
        /// <summary>
        /// Gets or sets the operation metadata.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Metadata { get; set; }

        /// <summary>
        /// Gets or sets the type of the flow operation.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public FlowTemplateOperationType? Type { get; set; }

        /// <summary>
        /// Gets or sets the kind of the flow operation.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public FlowTemplateOperationKind? Kind { get; set; }

        /// <summary>
        /// Gets or sets the operation inputs.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public object Inputs { get; set; }
    }
}

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The runtime configuration for a flow template action.
    /// </summary>
    public class FlowTemplateRuntimeConfiguration
    {
        /// <summary>
        /// Gets or sets the content transfer configuration.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public FlowTemplateContentTransferConfiguration ContentTransfer { get; set; }
    }

    /// <summary>
    /// The content transfer configuration for a flow template action.
    /// </summary>
    public class FlowTemplateContentTransferConfiguration
    {
        /// <summary>
        /// Gets or sets the content transfer mode.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public FlowTemplateContentTransferMode TransferMode { get; set; }
    }

    /// <summary>
    /// The content transfer mode for a flow template action.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowTemplateContentTransferMode
    {
        /// <summary>
        /// Transfer content in chunks.
        /// </summary>
        Chunked,
    }
}

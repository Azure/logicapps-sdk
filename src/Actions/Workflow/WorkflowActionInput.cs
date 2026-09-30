//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow action input.
    /// </summary>
    internal class WorkflowActionInput : RetryableActionInput
    {
        /// <summary>
        /// Gets or sets the workflow host.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        internal WorkflowActionInputHost Host { get; set; }

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        internal JToken Body { get; set; }

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        internal JToken Headers { get; set; }
    }
}

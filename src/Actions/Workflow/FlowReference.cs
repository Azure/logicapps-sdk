// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Flow reference for referencing another workflow within a workflow.
    /// </summary>
    internal class FlowReference
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        internal string id { get; set; }
    }
}

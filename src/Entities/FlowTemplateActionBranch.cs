// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The flow template action branch.
    /// </summary>
    public class FlowTemplateActionBranch
    {
        /// <summary>
        /// Gets or sets the actions.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, FlowTemplateAction> Actions { get; set; }
    }
}

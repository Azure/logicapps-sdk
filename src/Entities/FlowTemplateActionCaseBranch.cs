// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Represents a single case in a Switch action, containing the case match value and its actions.
    /// </summary>
    public class FlowTemplateActionCaseBranch : FlowTemplateActionBranch
    {
        /// <summary>
        /// Gets or sets the case.
        /// </summary>
        [JsonProperty(PropertyName = "case", Required = Required.Always)]
        public JToken Case { get; set; }
    }
}

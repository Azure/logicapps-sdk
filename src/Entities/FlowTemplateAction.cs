//-----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//-----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow definition action.
    /// </summary>
    public class FlowTemplateAction : FlowTemplateOperation
    {
        /// <summary>
        /// Gets or sets foreach expression.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Foreach { get; set; }

        /// <summary>
        /// Gets or sets repeat expression.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Repeat { get; set; }

        /// <summary>
        /// Gets or sets the actions.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, FlowTemplateAction> Actions { get; set; }

        /// <summary>
        /// Gets or sets the expression.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Expression { get; set; }

        /// <summary>
        /// Gets or sets the tracked properties.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken TrackedProperties { get; set; }

        /// <summary>
        /// Gets or sets the until limit.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Limit { get; set; }

        /// <summary>
        /// Gets or sets the operation run after.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, FlowStatus[]> RunAfter { get; set; }

        /// <summary>
        /// Gets or sets the tools.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, FlowTemplateActionToolBranch> Tools { get; set; }
    }
}

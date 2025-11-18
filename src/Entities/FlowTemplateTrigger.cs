// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow template trigger.
    /// </summary>
    public class FlowTemplateTrigger : FlowTemplateOperation
    {
        /// <summary>
        /// Gets or sets the recurrence of the flow template trigger.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1721:Property names", Justification = "By design to match the recurrence on the workflow definition.")]
        public FlowRecurrence Recurrence { get; set; }

        /// <summary>
        /// Gets or sets the evaluated recurrence of the flow template trigger.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken EvaluatedRecurrence { get; set; }

        /// <summary>
        /// Gets or sets the trigger split on.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string SplitOn { get; set; }
    }
}

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The workflow action input host.
    /// </summary>
    internal class WorkflowActionInputHost
    {
        /// <summary>
        /// Gets or sets the trigger name.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        internal string TriggerName { get; set; }

        /// <summary>
        /// Gets or sets the workflowreferencename.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        internal string WorkflowReferenceName { get; set; }

        /// <summary>
        /// Gets or sets the workflow.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public FlowReference Workflow { get; set; }
    }
}

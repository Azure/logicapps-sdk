// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow operation result definition.
    /// </summary>
    public class WorkflowOperationResult
    {
        /// <summary>
        /// Gets or sets the operation name.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the operation execution inputs.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Inputs { get; set; }

        /// <summary>
        /// Gets or sets the operation execution outputs.
        /// </summary>
        [JsonProperty]
        public JToken Outputs { get; set; }

        /// <summary>
        /// Gets or sets the operation start time.
        /// </summary>
        [JsonProperty]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the operation end time.
        /// </summary>
        [JsonProperty]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the operation scheduled time.
        /// </summary>
        [JsonProperty]
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the origin history for spliton trigger.
        /// </summary>
        [JsonProperty]
        public string OriginHistoryName { get; set; }

        /// <summary>
        /// Gets or sets the name of the source history for resubmitted trigger.
        /// </summary>
        [JsonProperty]
        public string SourceHistoryName { get; set; }

        /// <summary>
        /// Gets or sets the operation tracking Id.
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string OperationTrackingId { get; set; }

        /// <summary>
        /// Gets or sets the operation code.
        /// </summary>
        [JsonProperty]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the operation status.
        /// </summary>
        [JsonProperty]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the operation error.
        /// </summary>
        [JsonProperty]
        public JToken Error { get; set; }

        /// <summary>
        /// Gets or sets the tracked properties.
        /// </summary>
        [JsonProperty]
        public JToken TrackedProperties { get; set; }
    }
}

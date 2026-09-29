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
        /// Deserializes the operation outputs to the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the operation outputs.</typeparam>
        /// <returns>The strongly-typed operation outputs, or <c>default(T)</c> when outputs are missing or null.</returns>
        public T GetOutputs<T>()
        {
            return this.Outputs == null || this.Outputs.Type == JTokenType.Null
                ? default
                : this.Outputs.ToObject<T>();
        }

        /// <summary>
        /// Deserializes the operation output body to the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the operation output body.</typeparam>
        /// <returns>The strongly-typed operation output body.</returns>
        public T GetBody<T>()
        {
            var body = this.Outputs?.Type == JTokenType.Object
                ? this.Outputs["body"]
                : null;
            return body == null || body.Type == JTokenType.Null
                ? default
                : body.ToObject<T>();
        }

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

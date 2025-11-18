// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The flow recurrence.
    /// </summary>
    public class FlowRecurrence
    {
        /// <summary>
        /// Gets or sets the recurrence frequency.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public FlowRecurrenceFrequency Frequency { get; set; }

        /// <summary>
        /// Gets or sets the recurrence interval.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or sets the recurrence count.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the recurrence start time.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        [JsonConverter(typeof(RoundtripKindIsoDateTimeConverter))]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the recurrence end time.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        [JsonConverter(typeof(RoundtripKindIsoDateTimeConverter))]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the recurrence time zone.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string TimeZone { get; set; }
    }
}

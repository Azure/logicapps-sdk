// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The flow recurrence frequency.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowRecurrenceFrequency
    {
        /// <summary>
        /// The type of recurrence interval is not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// The recurrence interval measured in seconds.
        /// </summary>
        Second,

        /// <summary>
        /// The recurrence interval measured in minutes.
        /// </summary>
        Minute,

        /// <summary>
        /// The recurrence interval measured in hours.
        /// </summary>
        Hour,

        /// <summary>
        /// The recurrence interval measured in days.
        /// </summary>
        Day,

        /// <summary>
        /// The recurrence interval measured in weeks.
        /// </summary>
        Week,

        /// <summary>
        /// The recurrence interval measured in months.
        /// </summary>
        Month,

        /// <summary>
        /// The recurrence interval measured in years.
        /// </summary>
        Year,
    }
}

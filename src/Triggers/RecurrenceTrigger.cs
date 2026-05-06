// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow recurrence trigger.
    /// Encapsulates recurrence configuration such as frequency, interval, count, start time, and time zone.
    /// </summary>
    public class RecurrenceTrigger : WorkflowTriggerBase
    {
        /// <summary>
        /// Gets or sets the frequency of the recurrence (e.g., Minute, Hour, Day).
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        private FlowRecurrenceFrequency Frequency { get; set; }

        /// <summary>
        /// Gets or sets the interval between each recurrence.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        private int Interval { get; set; }

        /// <summary>
        /// Gets or sets the start time for the recurrence schedule.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        private DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time zone in which the recurrence is scheduled.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        private TimeZoneInfo TimeZone { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceTrigger"/> class.
        /// </summary>
        /// <param name="name">The name to assign to the recurrence trigger.</param>
        /// <param name="frequency">The frequency of the recurrence (e.g., Minute, Hour, Day).</param>
        /// <param name="interval">The interval between recurrences.</param>
        /// <param name="startTime">The start time for the recurrence schedule.</param>
        /// <param name="timeZone">The time zone for the recurrence schedule.</param>
        public RecurrenceTrigger(
            string name,
            FlowRecurrenceFrequency frequency,
            int interval,
            DateTime? startTime,
            TimeZoneInfo timeZone)
        {
            this.Name = name;
            this.Frequency = frequency;
            this.Interval = interval;
            this.StartTime = startTime;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// Gets the trigger definition for the recurrence trigger.
        /// </summary>
        public override FlowTemplateTrigger GetTriggerDefinition()
        {
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.Recurrence,
                Recurrence = new FlowRecurrence
                {
                    Frequency = this.Frequency,
                    Interval = this.Interval,
                    StartTime = this.StartTime,
                    TimeZone = this.TimeZone?.Id,
                },
            };
        }

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        public RecurrenceTrigger WithName(string name)
        {
            this.Name = name;
            return this;
        }
    }
}

// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides factory methods for creating built-in workflow triggers. Built-in triggers are first-party
    /// operations that run directly in the Logic Apps runtime without requiring external API connections.
    /// </summary>
    /// <remarks>
    /// Access this class through <c>WorkflowTriggers.BuiltIn</c>. Available trigger types include:
    /// <list type="bullet">
    ///   <item><description><see cref="CreateHttpTrigger"/> — Fires when an HTTP request is received.</description></item>
    ///   <item><description><see cref="CreateRecurrenceTrigger"/> — Fires on a recurring schedule.</description></item>
    ///   <item><description><see cref="CreateConversationalAgentTrigger"/> — Fires when a new conversational chat session starts.</description></item>
    /// </list>
    /// </remarks>
    /// <seealso cref="WorkflowTriggers"/>
    public class WorkflowBuiltInTriggers
    {
        /// <summary>
        /// Service provider triggers (e.g., Service Bus, SQL, Event Hub).
        /// Service provider triggers are auto-generated from service provider operation manifests.
        /// </summary>
        public WorkflowServiceProviderTriggers ServiceProviders { get; } = new WorkflowServiceProviderTriggers();

        /// <summary>
        /// Adds an HTTP trigger to the flow.
        /// </summary>
        /// <param name="method">The HTTP method to use for the request (optional).</param>
        /// <param name="requestBodyJsonSchema">The request body JSON schema (optional).</param>
        /// <param name="relativePath">The relative path (optional).</param>
        public IOutputWorkflowTrigger<HttpRequestTriggerOutput> CreateHttpTrigger(
            HttpMethod method = null,
            JToken requestBodyJsonSchema = null,
            string relativePath = null)
        {
            return new HttpRequestTrigger(
                method: method,
                requestBodyJsonSchema: requestBodyJsonSchema,
                relativePath: relativePath);
        }

        /// <summary>
        /// Adds a conversational agent trigger to the flow.
        /// </summary>
        public ConversationalFlowTrigger CreateConversationalAgentTrigger()
        {
            return new ConversationalFlowTrigger();
        }

        /// <summary>
        /// Adds a recurrence trigger to the flow.
        /// </summary>
        /// <param name="frequency">The frequency of the recurrence (e.g., Minute, Hour, Day). Defaults to Minute.</param>
        /// <param name="interval">The interval between recurrences. Defaults to 1.</param>
        /// <param name="startTime">The start time for the recurrence schedule. Defaults to UTC now.</param>
        /// <param name="timeZone">The time zone for the recurrence schedule. Defaults to UTC.</param>
        /// <returns>An output workflow trigger for the recurrence.</returns>
        public IWorkflowTrigger CreateRecurrenceTrigger(
            FlowRecurrenceFrequency frequency = FlowRecurrenceFrequency.Minute,
            int interval = 1,
            DateTime? startTime = null,
            TimeZoneInfo timeZone = null)
        {
            return new RecurrenceTrigger(
                frequency: frequency,
                interval: interval,
                startTime: startTime,
                timeZone: timeZone ?? TimeZoneInfo.Utc);
        }
    }
}

// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Built-in triggers for workflow.
    /// </summary>
    public class WorkflowBuiltInTriggers
    {
        /// <summary>
        /// Adds an HTTP trigger to the flow.
        /// </summary>
        /// <param name="name">The name to assign to the HTTP trigger. Defaults to "when_an_HTTP_request_is_received".</param>
        /// <param name="method">The HTTP method to use for the request (optional).</param>
        /// <param name="requestBodyJsonSchema">The request body JSON schema (optional).</param>
        /// <param name="relativePath">The relative path (optional).</param>
        public IOutputWorkflowTrigger<HttpRequestTriggerOutput> CreateHttpTrigger(
            string name = "when_an_HTTP_request_is_received",
            HttpMethod method = null,
            JToken requestBodyJsonSchema = null,
            string relativePath = null)
        {
            var httpRequestTrigger = new HttpRequestTrigger(
                method: method,
                requestBodyJsonSchema: requestBodyJsonSchema,
                relativePath: relativePath);
            httpRequestTrigger.Name = name;

            return httpRequestTrigger;
        }

        /// <summary>
        /// Adds a conversational agent trigger to the flow.
        /// </summary>
        /// <param name="name">The name to assign to the conversational flow trigger. Defaults to "When_a_new_chat_session_starts".</param>
        public ConversationalFlowTrigger CreateAgentTrigger(string name = "When_a_new_chat_session_starts")
        {
            var agentTrigger = new ConversationalFlowTrigger();
            agentTrigger.Name = name;

            return agentTrigger;
        }

        /// <summary>
        /// Adds a recurrence trigger to the flow.
        /// </summary>
        /// <param name="name">The name to assign to the recurrence trigger. Defaults to "recurrence".</param>
        /// <param name="frequency">The frequency of the recurrence (e.g., Minute, Hour, Day). Defaults to Minute.</param>
        /// <param name="interval">The interval between recurrences. Defaults to 1.</param>
        /// <param name="startTime">The start time for the recurrence schedule. Defaults to UTC now.</param>
        /// <param name="timeZone">The time zone for the recurrence schedule. Defaults to UTC.</param>
        /// <returns>An output workflow trigger for the recurrence.</returns>
        public IWorkflowTrigger CreateRecurrenceTrigger(
            string name = "recurrence",
            FlowRecurrenceFrequency frequency = FlowRecurrenceFrequency.Minute,
            int interval = 1,
            DateTime? startTime = null,
            TimeZoneInfo timeZone = null)
        {
            var recurrenceTrigger = new RecurrenceTrigger(
                name: name,
                frequency: frequency,
                interval: interval,
                startTime: startTime,
                timeZone: timeZone ?? TimeZoneInfo.Utc);
            return recurrenceTrigger;
        }
    }
}

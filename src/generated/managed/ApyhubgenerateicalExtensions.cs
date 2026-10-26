//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubgenerateical
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubgenerateicalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> File(Expression<Func<string>> output = null, Expression<Func<FilePostInput>> body = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<URLPostResponse, ApiConnectionActionConfiguration> URL(Expression<Func<string>> output = null, Expression<Func<URLPostInput>> body = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<URLPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<URLPostResponse>(callPayload);
            });
        }
    }

    public class ApyhubgenerateicalTriggers([ConnectionName] string connectionId)
    {
    }

    public class FilePostInput
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("organizer_email")]
        public string OrganizerEmail { get; set; }

        [JsonProperty("attendees_emails")]
        public string[] AttendeesEmails { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("meeting_date")]
        public string MeetingDate { get; set; }

        [JsonProperty("recurring")]
        public bool? Recurring { get; set; }

        [JsonProperty("recurrence")]
        public FilePostInputRecurrenceType Recurrence { get; set; }
    }

    public class FilePostInputRecurrenceType
    {
        [JsonProperty("frequency")]
        public FilePostInputRecurrenceTypeFrequencyType? Frequency { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilePostInputRecurrenceTypeFrequencyType
    {
        DAILY,
        WEEKLY,
        MONTHLY,
        YEARLY
    }

    public class URLPostResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class URLPostInput
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("organizer_email")]
        public string OrganizerEmail { get; set; }

        [JsonProperty("attendees_emails")]
        public string[] AttendeesEmails { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("meeting_date")]
        public string MeetingDate { get; set; }

        [JsonProperty("recurring")]
        public bool? Recurring { get; set; }

        [JsonProperty("recurrence")]
        public URLPostInputRecurrenceType Recurrence { get; set; }
    }

    public class URLPostInputRecurrenceType
    {
        [JsonProperty("frequency")]
        public URLPostInputRecurrenceTypeFrequencyType? Frequency { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum URLPostInputRecurrenceTypeFrequencyType
    {
        DAILY,
        WEEKLY,
        MONTHLY,
        YEARLY
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubgenerateical;

    public partial class WorkflowManagedActions
    {
        public ApyhubgenerateicalActions Apyhubgenerateical(string connectionId) => new ApyhubgenerateicalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApyhubgenerateicalTriggers Apyhubgenerateical(string connectionId) => new ApyhubgenerateicalTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciscowebexmeetings
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CiscowebexmeetingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciscowebexmeetings")]
        public IBodyWorkflowAction<NewMeetingResponse> NewMeeting(Expression<Func<string>> bodytopic, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string>> bodyattendees = null, Expression<Func<string>> bodyagenda = null)
        {
            var __workflow_bodytopic = WorkflowExpression.Compile(bodytopic, nameof(bodytopic), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: true);
            var __workflow_bodyattendees = WorkflowExpression.Compile(bodyattendees, nameof(bodyattendees), required: false);
            var __workflow_bodyagenda = WorkflowExpression.Compile(bodyagenda, nameof(bodyagenda), required: false);
            return new DeferredBodyAction<NewMeetingResponse>(() =>
            {
                var apiCallPath = "/workflow/meetings/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = ExpressionConverter.ConvertO(__workflow_bodytopic);
                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                if (__workflow_bodyattendees != null)
                {
                    body["attendees"] = ExpressionConverter.ConvertO(__workflow_bodyattendees);
                    bodypropCount++;
                }

                if (__workflow_bodyagenda != null)
                {
                    body["agenda"] = ExpressionConverter.ConvertO(__workflow_bodyagenda);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewMeetingResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class CiscowebexmeetingsTriggers([ConnectionName] string connectionId)
    {
    }

    public class NewMeetingResponse
    {
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("hostKey")]
        public string HostKey { get; set; }

        [JsonProperty("joinMeetingLink")]
        public string JoinMeetingLink { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingId { get; set; }

        [JsonProperty("meetingNumber")]
        public int MeetingNumber { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ciscowebexmeetings;

    public partial class WorkflowManagedActions
    {
        public CiscowebexmeetingsActions Ciscowebexmeetings(string connectionId) => new CiscowebexmeetingsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CiscowebexmeetingsTriggers Ciscowebexmeetings(string connectionId) => new CiscowebexmeetingsTriggers(connectionId);
    }
}

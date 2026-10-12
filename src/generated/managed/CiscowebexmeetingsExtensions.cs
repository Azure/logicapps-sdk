//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciscowebexmeetings
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CiscowebexmeetingsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciscowebexmeetings")]
        [WorkflowExpressionFactory(nameof(__BuildNewMeeting))]
        public IBodyWorkflowAction<NewMeetingResponse> NewMeeting([WorkflowExpression] Func<string> bodytopic, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string> bodyattendees = null, [WorkflowExpression] Func<string> bodyagenda = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewMeetingResponse> __BuildNewMeeting(WorkflowExpression<string> bodytopic, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyendTime, WorkflowExpression<string> bodyattendees = null, WorkflowExpression<string> bodyagenda = null)
        {
            WorkflowExpression.Validate(bodytopic, nameof(bodytopic), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            WorkflowExpression.Validate(bodyattendees, nameof(bodyattendees), required: false);
            WorkflowExpression.Validate(bodyagenda, nameof(bodyagenda), required: false);
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
                body["topic"] = ExpressionConverter.ConvertO(bodytopic);
                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                if (bodyattendees != null)
                {
                    body["attendees"] = ExpressionConverter.ConvertO(bodyattendees);
                    bodypropCount++;
                }

                if (bodyagenda != null)
                {
                    body["agenda"] = ExpressionConverter.ConvertO(bodyagenda);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewMeetingResponse>(callPayload);
            });
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
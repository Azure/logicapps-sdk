//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciscowebexmeetings
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CiscowebexmeetingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciscowebexmeetings")]
        public IBodyWorkflowAction<NewMeetingResponse> NewMeeting([WorkflowExpression] Func<string> bodytopic, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string> bodyattendees = null, [WorkflowExpression] Func<string> bodyagenda = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflow/meetings/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = SourceExpressionConverter.ConvertToken(bodytopic);
                bodypropCount++;
                body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                if (bodyattendees != null)
                {
                    body["attendees"] = SourceExpressionConverter.ConvertToken(bodyattendees);
                    bodypropCount++;
                }

                if (bodyagenda != null)
                {
                    body["agenda"] = SourceExpressionConverter.ConvertToken(bodyagenda);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NewMeetingResponse>(BuildSourceInput);
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
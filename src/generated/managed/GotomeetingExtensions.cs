//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gotomeeting
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GotomeetingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IBodyWorkflowAction<MeetingArrayItem[]> GetUpcomingMeetings()
        {
            var apiCallPath = "/upcomingMeetings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MeetingArrayItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IBodyWorkflowAction<Meeting> GetMeeting([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> meetingId)
        {
            var apiCallPath = String.Format("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(meetingId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Meeting>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IWorkflowAction UpdateMeeting([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> meetingId, [WorkflowExpression] Func<string> meetingsubject, [WorkflowExpression] Func<string> meetingstartTime, [WorkflowExpression] Func<string> meetingendTime, [WorkflowExpression] Func<bool> meetingrequiresPassword, [WorkflowExpression] Func<meetingconferenceCallInfoInput> meetingconferenceCallInfo, [WorkflowExpression] Func<meetingmeetingTypeInput> meetingmeetingType = null)
        {
            var apiCallPath = String.Format("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(meetingId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var meeting = new JObject();
            var meetingpropCount = 0;
            meetingpropCount++;
            meeting["subject"] = ExpressionConverter.ConvertO(meetingsubject);
            meetingpropCount++;
            meeting["starttime"] = ExpressionConverter.ConvertO(meetingstartTime);
            meetingpropCount++;
            meeting["endtime"] = ExpressionConverter.ConvertO(meetingendTime);
            meetingpropCount++;
            meeting["passwordrequired"] = ExpressionConverter.ConvertO(meetingrequiresPassword);
            meetingpropCount++;
            meeting["conferencecallinfo"] = ExpressionConverter.ConvertO(meetingconferenceCallInfo);
            if (meetingmeetingType != null)
            {
                meeting["meetingtype"] = ExpressionConverter.ConvertO(meetingmeetingType);
                meetingpropCount++;
            }

            if (meetingpropCount > 0)
            {
                callPayload.Body = meeting;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IBodyWorkflowAction<Attendee[]> GetMeetingAttendees([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> meetingId)
        {
            var apiCallPath = String.Format("/meetings/{0}/attendees", ExpressionConverter.ConvertWithUrlEncoding(meetingId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Attendee[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IBodyWorkflowAction<NewMeetingResponse> CreateMeeting([WorkflowExpression] Func<string> newMeetingsubject, [WorkflowExpression] Func<string> newMeetingstartTime, [WorkflowExpression] Func<string> newMeetingendTime, [WorkflowExpression] Func<bool> newMeetingrequiresPassword, [WorkflowExpression] Func<newMeetingconferenceCallInfoInput> newMeetingconferenceCallInfo, [WorkflowExpression] Func<newMeetingmeetingTypeInput> newMeetingmeetingType)
        {
            var apiCallPath = "/v2/meetings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newMeeting = new JObject();
            var newMeetingpropCount = 0;
            newMeetingpropCount++;
            newMeeting["subject"] = ExpressionConverter.ConvertO(newMeetingsubject);
            newMeetingpropCount++;
            newMeeting["starttime"] = ExpressionConverter.ConvertO(newMeetingstartTime);
            newMeetingpropCount++;
            newMeeting["endtime"] = ExpressionConverter.ConvertO(newMeetingendTime);
            newMeetingpropCount++;
            newMeeting["passwordrequired"] = ExpressionConverter.ConvertO(newMeetingrequiresPassword);
            newMeetingpropCount++;
            newMeeting["conferencecallinfo"] = ExpressionConverter.ConvertO(newMeetingconferenceCallInfo);
            newMeetingpropCount++;
            newMeeting["meetingtype"] = ExpressionConverter.ConvertO(newMeetingmeetingType);
            if (newMeetingpropCount > 0)
            {
                callPayload.Body = newMeeting;
            }

            return new ApiConnectionAction<NewMeetingResponse>(callPayload);
        }
    }

    public class GotomeetingTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MeetingArrayItem[]> OnNewMeeting(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_meeting_trigger/upcomingMeetings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<MeetingArrayItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MeetingArrayItem[]> OnMeetingComplete(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/completed_meeting_trigger/historicalMeetings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<MeetingArrayItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class MeetingArrayItem
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("firstName")]
        public string OrganizerFirstName { get; set; }

        [JsonProperty("lastName")]
        public string OrganizerLastName { get; set; }

        [JsonProperty("email")]
        public string OrganizerEmail { get; set; }

        [JsonProperty("conferenceCallInfo")]
        public string ConferenceCallInfo { get; set; }

        [JsonProperty("passwordRequired")]
        public string RequiresPassword { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("locale")]
        public string LocationCode { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingId { get; set; }

        [JsonProperty("meetingType")]
        public string MeetingType { get; set; }
    }

    public class Meeting
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("firstName")]
        public string OrganizerFirstName { get; set; }

        [JsonProperty("lastName")]
        public string OrganizerLastName { get; set; }

        [JsonProperty("email")]
        public string OrganizerEmail { get; set; }

        [JsonProperty("conferenceCallInfo")]
        public string ConferenceCallInfo { get; set; }

        [JsonProperty("passwordRequired")]
        public string RequiresPassword { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("locale")]
        public string LocationCode { get; set; }

        [JsonProperty("meetingId")]
        public int MeetingId { get; set; }

        [JsonProperty("meetingType")]
        public string MeetingType { get; set; }
    }

    public enum meetingconferenceCallInfoInput
    {
        PSTN,
        Free,
        Hybrid,
        Private,
        VoIP
    }

    public enum meetingmeetingTypeInput
    {
        [EnumMember(Value = "immediate")]
        Immediate,
        [EnumMember(Value = "recurring")]
        Recurring,
        [EnumMember(Value = "scheduled")]
        Scheduled
    }

    public class Attendee
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("attendeeName")]
        public string Name { get; set; }

        [JsonProperty("joinTime")]
        public string JoinTime { get; set; }

        [JsonProperty("leaveTime")]
        public string LeaveTime { get; set; }

        [JsonProperty("attendeeEmail")]
        public string AttendeeEmail { get; set; }
    }

    public class NewMeetingResponse
    {
        [JsonProperty("joinURL")]
        public string JoinURL { get; set; }

        [JsonProperty("meetingid")]
        public int MeetingId { get; set; }

        [JsonProperty("maxParticipants")]
        public int MaxParticipants { get; set; }

        [JsonProperty("conferenceCallInfo")]
        public string ConferenceCallInfo { get; set; }
    }

    public enum newMeetingconferenceCallInfoInput
    {
        PSTN,
        Free,
        Hybrid,
        Private,
        VoIP
    }

    public enum newMeetingmeetingTypeInput
    {
        [EnumMember(Value = "immediate")]
        Immediate,
        [EnumMember(Value = "recurring")]
        Recurring,
        [EnumMember(Value = "scheduled")]
        Scheduled
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gotomeeting;

    public partial class WorkflowManagedActions
    {
        public GotomeetingActions Gotomeeting(string connectionId) => new GotomeetingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GotomeetingTriggers Gotomeeting(string connectionId) => new GotomeetingTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gotomeeting
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
        public IBodyWorkflowAction<Meeting> GetMeeting(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredBodyAction<Meeting>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meetings/{0}", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Meeting>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IWorkflowAction UpdateMeeting(Expression<Func<string>> meetingId, Expression<Func<string>> meetingsubject, Expression<Func<string>> meetingstartTime, Expression<Func<string>> meetingendTime, Expression<Func<bool>> meetingrequiresPassword, Expression<Func<meetingconferenceCallInfoInput>> meetingconferenceCallInfo, Expression<Func<meetingmeetingTypeInput>> meetingmeetingType = null)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_meetingsubject = WorkflowExpression.Compile(meetingsubject, nameof(meetingsubject), required: true);
            var __workflow_meetingstartTime = WorkflowExpression.Compile(meetingstartTime, nameof(meetingstartTime), required: true);
            var __workflow_meetingendTime = WorkflowExpression.Compile(meetingendTime, nameof(meetingendTime), required: true);
            var __workflow_meetingrequiresPassword = WorkflowExpression.Compile(meetingrequiresPassword, nameof(meetingrequiresPassword), required: true);
            var __workflow_meetingconferenceCallInfo = WorkflowExpression.Compile(meetingconferenceCallInfo, nameof(meetingconferenceCallInfo), required: true);
            var __workflow_meetingmeetingType = WorkflowExpression.Compile(meetingmeetingType, nameof(meetingmeetingType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meetings/{0}", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var meeting = new JObject();
                var meetingpropCount = 0;
                meetingpropCount++;
                meeting["subject"] = ExpressionConverter.ConvertO(__workflow_meetingsubject);
                meetingpropCount++;
                meeting["starttime"] = ExpressionConverter.ConvertO(__workflow_meetingstartTime);
                meetingpropCount++;
                meeting["endtime"] = ExpressionConverter.ConvertO(__workflow_meetingendTime);
                meetingpropCount++;
                meeting["passwordrequired"] = ExpressionConverter.ConvertO(__workflow_meetingrequiresPassword);
                meetingpropCount++;
                meeting["conferencecallinfo"] = ExpressionConverter.ConvertO(__workflow_meetingconferenceCallInfo);
                if (__workflow_meetingmeetingType != null)
                {
                    meeting["meetingtype"] = ExpressionConverter.ConvertO(__workflow_meetingmeetingType);
                    meetingpropCount++;
                }

                if (meetingpropCount > 0)
                {
                    callPayload.Body = meeting;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IBodyWorkflowAction<Attendee[]> GetMeetingAttendees(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredBodyAction<Attendee[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meetings/{0}/attendees", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Attendee[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotomeeting")]
        public IBodyWorkflowAction<NewMeetingResponse> CreateMeeting(Expression<Func<string>> newMeetingsubject, Expression<Func<string>> newMeetingstartTime, Expression<Func<string>> newMeetingendTime, Expression<Func<bool>> newMeetingrequiresPassword, Expression<Func<newMeetingconferenceCallInfoInput>> newMeetingconferenceCallInfo, Expression<Func<newMeetingmeetingTypeInput>> newMeetingmeetingType)
        {
            var __workflow_newMeetingsubject = WorkflowExpression.Compile(newMeetingsubject, nameof(newMeetingsubject), required: true);
            var __workflow_newMeetingstartTime = WorkflowExpression.Compile(newMeetingstartTime, nameof(newMeetingstartTime), required: true);
            var __workflow_newMeetingendTime = WorkflowExpression.Compile(newMeetingendTime, nameof(newMeetingendTime), required: true);
            var __workflow_newMeetingrequiresPassword = WorkflowExpression.Compile(newMeetingrequiresPassword, nameof(newMeetingrequiresPassword), required: true);
            var __workflow_newMeetingconferenceCallInfo = WorkflowExpression.Compile(newMeetingconferenceCallInfo, nameof(newMeetingconferenceCallInfo), required: true);
            var __workflow_newMeetingmeetingType = WorkflowExpression.Compile(newMeetingmeetingType, nameof(newMeetingmeetingType), required: true);
            return new DeferredBodyAction<NewMeetingResponse>(() =>
            {
                var apiCallPath = "/v2/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newMeeting = new JObject();
                var newMeetingpropCount = 0;
                newMeetingpropCount++;
                newMeeting["subject"] = ExpressionConverter.ConvertO(__workflow_newMeetingsubject);
                newMeetingpropCount++;
                newMeeting["starttime"] = ExpressionConverter.ConvertO(__workflow_newMeetingstartTime);
                newMeetingpropCount++;
                newMeeting["endtime"] = ExpressionConverter.ConvertO(__workflow_newMeetingendTime);
                newMeetingpropCount++;
                newMeeting["passwordrequired"] = ExpressionConverter.ConvertO(__workflow_newMeetingrequiresPassword);
                newMeetingpropCount++;
                newMeeting["conferencecallinfo"] = ExpressionConverter.ConvertO(__workflow_newMeetingconferenceCallInfo);
                newMeetingpropCount++;
                newMeeting["meetingtype"] = ExpressionConverter.ConvertO(__workflow_newMeetingmeetingType);
                if (newMeetingpropCount > 0)
                {
                    callPayload.Body = newMeeting;
                }

                return new ApiConnectionAction<NewMeetingResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class GotomeetingTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MeetingArrayItem[]> OnNewMeeting(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_meeting_trigger/upcomingMeetings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<MeetingArrayItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<MeetingArrayItem[]> OnMeetingComplete(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/completed_meeting_trigger/historicalMeetings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<MeetingArrayItem[]>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum meetingconferenceCallInfoInput
    {
        PSTN,
        Free,
        Hybrid,
        Private,
        VoIP
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum newMeetingconferenceCallInfoInput
    {
        PSTN,
        Free,
        Hybrid,
        Private,
        VoIP
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

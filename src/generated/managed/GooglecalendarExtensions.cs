//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlecalendar
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecalendarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<CalendarList, ApiConnectionActionConfiguration> ListCalendars(Expression<Func<minAccessRoleInput>> minAccessRole = null)
        {
            var __workflow_minAccessRole = WorkflowExpression.Compile(minAccessRole, nameof(minAccessRole), required: false);
            return new DeferredBodyAction<CalendarList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users/me/calendarList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_minAccessRole != null)
                    callPayload.Queries["minAccessRole"] = ExpressionConverter.Convert(__workflow_minAccessRole);
                return new ApiConnectionAction<CalendarList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<CalendarEventList, ApiConnectionActionConfiguration> ListEvents(Expression<Func<string>> calendarId, Expression<Func<string>> timeMin = null, Expression<Func<string>> timeMax = null, Expression<Func<string>> q = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_timeMin = WorkflowExpression.Compile(timeMin, nameof(timeMin), required: false);
            var __workflow_timeMax = WorkflowExpression.Compile(timeMax, nameof(timeMax), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<CalendarEventList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeMin != null)
                    callPayload.Queries["timeMin"] = ExpressionConverter.Convert(__workflow_timeMin);
                if (__workflow_timeMax != null)
                    callPayload.Queries["timeMax"] = ExpressionConverter.Convert(__workflow_timeMax);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<CalendarEventList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent, ApiConnectionActionConfiguration> CreateEvent(Expression<Func<string>> calendarId, Expression<Func<CreateEventInput>> newEvent)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_newEvent = WorkflowExpression.Compile(newEvent, nameof(newEvent), required: true);
            return new DeferredBodyAction<ResponseEvent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newEvent);
                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent, ApiConnectionActionConfiguration> GetEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<ResponseEvent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calendars/{0}/events/{1}", __workflow_calendarId.WithUrlEncoding(1), __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calendars/{0}/events/{1}", __workflow_calendarId.WithUrlEncoding(1), __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent, ApiConnectionActionConfiguration> UpdateEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId, Expression<Func<UpdateEventInput>> updatedEvent)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_updatedEvent = WorkflowExpression.Compile(updatedEvent, nameof(updatedEvent), required: true);
            return new DeferredBodyAction<ResponseEvent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calendars/{0}/events/{1}", __workflow_calendarId.WithUrlEncoding(1), __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updatedEvent);
                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }
    }

    public class GooglecalendarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventList, ApiConnectionTriggerConfiguration> OnNewEventInCalendar(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger1/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventList, ApiConnectionTriggerConfiguration> OnUpdatedEventInCalendar(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger2/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventList, ApiConnectionTriggerConfiguration> OnDeletedEventInCalendar(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger3/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventChangedList, ApiConnectionTriggerConfiguration> OnChangedEventInCalendar(Expression<Func<string>> calendarId, Expression<Func<bool>> singleEvents = null, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_singleEvents = WorkflowExpression.Compile(singleEvents, nameof(singleEvents), required: false);
            return new DeferredBodyTrigger<CalendarEventChangedList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger4/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_singleEvents != null)
                    callPayload.Queries["singleEvents"] = ExpressionConverter.Convert(__workflow_singleEvents);
                return new ApiConnectionTrigger<CalendarEventChangedList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventList, ApiConnectionTriggerConfiguration> OnEventStarted(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/eventstarted/calendars/{0}/events", __workflow_calendarId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CalendarList
    {
        [JsonProperty("items")]
        public CalendarListEntry[] Items { get; set; }
    }

    public class CalendarListEntry
    {
        [JsonProperty("id")]
        public string CalendarId { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum minAccessRoleInput
    {
        [EnumMember(Value = "freeBusyReader")]
        FreeBusyReader,
        [EnumMember(Value = "reader")]
        Reader,
        [EnumMember(Value = "writer")]
        Writer,
        [EnumMember(Value = "owner")]
        Owner
    }

    public class CalendarEventList
    {
        [JsonProperty("items")]
        public ResponseEvent[] Items { get; set; }
    }

    public class ResponseEvent
    {
        [JsonProperty("summary")]
        public string Title { get; set; }

        [JsonProperty("start")]
        public string StartDateTime { get; set; }

        [JsonProperty("end")]
        public string EndDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("htmlLink")]
        public string HTMLLink { get; set; }

        [JsonProperty("id")]
        public string EventId { get; set; }

        [JsonProperty("attendees")]
        public string Attendees { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("endTimeUnspecified")]
        public bool EndTimeUnspecified { get; set; }
    }

    public class CreateEventInput
    {
        [JsonProperty("summary")]
        public string Title { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("attendees")]
        public string Attendees { get; set; }

        [JsonProperty("status")]
        public CreateEventInputStatusType? Status { get; set; }

        [JsonProperty("isAllDay")]
        public bool? IsAllDay { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEventInputStatusType
    {
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class UpdateEventInput
    {
        [JsonProperty("summary")]
        public string Title { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("attendees")]
        public string Attendees { get; set; }

        [JsonProperty("status")]
        public UpdateEventInputStatusType? Status { get; set; }

        [JsonProperty("isAllDay")]
        public bool? IsAllDay { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEventInputStatusType
    {
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class CalendarEventChangedList
    {
        [JsonProperty("items")]
        public ResponseEventWithActionType[] Items { get; set; }
    }

    public class ResponseEventWithActionType
    {
        [JsonProperty("actionType")]
        public ResponseEventWithActionTypeActionTypeType ActionType { get; set; }

        [JsonProperty("summary")]
        public string Title { get; set; }

        [JsonProperty("start")]
        public string StartDateTime { get; set; }

        [JsonProperty("end")]
        public string EndDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("htmlLink")]
        public string HTMLLink { get; set; }

        [JsonProperty("id")]
        public string EventId { get; set; }

        [JsonProperty("attendees")]
        public string Attendees { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("updated")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("endTimeUnspecified")]
        public bool EndTimeUnspecified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResponseEventWithActionTypeActionTypeType
    {
        [EnumMember(Value = "added")]
        Added,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "deleted")]
        Deleted
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlecalendar;

    public partial class WorkflowManagedActions
    {
        public GooglecalendarActions Googlecalendar(string connectionId) => new GooglecalendarActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglecalendarTriggers Googlecalendar(string connectionId) => new GooglecalendarTriggers(connectionId);
    }
}
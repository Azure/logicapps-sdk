//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlecalendar
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecalendarActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [WorkflowExpressionFactory(nameof(__BuildListCalendars))]
        public IBodyWorkflowAction<CalendarList> ListCalendars([WorkflowExpression] Func<minAccessRoleInput> minAccessRole = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarList> __BuildListCalendars(WorkflowExpression<minAccessRoleInput> minAccessRole = null)
        {
            WorkflowExpression.Validate(minAccessRole, nameof(minAccessRole), required: false);
            return new DeferredBodyAction<CalendarList>(() =>
            {
                var apiCallPath = "/users/me/calendarList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (minAccessRole != null)
                    callPayload.Queries["minAccessRole"] = ExpressionConverter.Convert(minAccessRole);
                return new ApiConnectionAction<CalendarList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [WorkflowExpressionFactory(nameof(__BuildListEvents))]
        public IBodyWorkflowAction<CalendarEventList> ListEvents([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> timeMin = null, [WorkflowExpression] Func<string> timeMax = null, [WorkflowExpression] Func<string> q = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarEventList> __BuildListEvents(WorkflowExpression<string> calendarId, WorkflowExpression<string> timeMin = null, WorkflowExpression<string> timeMax = null, WorkflowExpression<string> q = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(timeMin, nameof(timeMin), required: false);
            WorkflowExpression.Validate(timeMax, nameof(timeMax), required: false);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            return new DeferredBodyAction<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeMin != null)
                    callPayload.Queries["timeMin"] = ExpressionConverter.Convert(timeMin);
                if (timeMax != null)
                    callPayload.Queries["timeMax"] = ExpressionConverter.Convert(timeMax);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<CalendarEventList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEvent))]
        public IBodyWorkflowAction<ResponseEvent> CreateEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> newEventstartTime, [WorkflowExpression] Func<string> newEventendTime, [WorkflowExpression] Func<string> newEventtitle = null, [WorkflowExpression] Func<string> newEventdescription = null, [WorkflowExpression] Func<string> newEventlocation = null, [WorkflowExpression] Func<string> newEventattendees = null, [WorkflowExpression] Func<newEventstatusInput> newEventstatus = null, [WorkflowExpression] Func<bool> newEventisAllDay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEvent> __BuildCreateEvent(WorkflowExpression<string> calendarId, WorkflowExpression<string> newEventstartTime, WorkflowExpression<string> newEventendTime, WorkflowExpression<string> newEventtitle = null, WorkflowExpression<string> newEventdescription = null, WorkflowExpression<string> newEventlocation = null, WorkflowExpression<string> newEventattendees = null, WorkflowExpression<newEventstatusInput> newEventstatus = null, WorkflowExpression<bool> newEventisAllDay = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(newEventstartTime, nameof(newEventstartTime), required: true);
            WorkflowExpression.Validate(newEventendTime, nameof(newEventendTime), required: true);
            WorkflowExpression.Validate(newEventtitle, nameof(newEventtitle), required: false);
            WorkflowExpression.Validate(newEventdescription, nameof(newEventdescription), required: false);
            WorkflowExpression.Validate(newEventlocation, nameof(newEventlocation), required: false);
            WorkflowExpression.Validate(newEventattendees, nameof(newEventattendees), required: false);
            WorkflowExpression.Validate(newEventstatus, nameof(newEventstatus), required: false);
            WorkflowExpression.Validate(newEventisAllDay, nameof(newEventisAllDay), required: false);
            return new DeferredBodyAction<ResponseEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newEvent = new JObject();
                var newEventpropCount = 0;
                if (newEventtitle != null)
                {
                    newEvent["summary"] = ExpressionConverter.ConvertO(newEventtitle);
                    newEventpropCount++;
                }

                newEventpropCount++;
                newEvent["start"] = ExpressionConverter.ConvertO(newEventstartTime);
                newEventpropCount++;
                newEvent["end"] = ExpressionConverter.ConvertO(newEventendTime);
                if (newEventdescription != null)
                {
                    newEvent["description"] = ExpressionConverter.ConvertO(newEventdescription);
                    newEventpropCount++;
                }

                if (newEventlocation != null)
                {
                    newEvent["location"] = ExpressionConverter.ConvertO(newEventlocation);
                    newEventpropCount++;
                }

                if (newEventattendees != null)
                {
                    newEvent["attendees"] = ExpressionConverter.ConvertO(newEventattendees);
                    newEventpropCount++;
                }

                if (newEventstatus != null)
                {
                    newEvent["status"] = ExpressionConverter.ConvertO(newEventstatus);
                    newEventpropCount++;
                }

                if (newEventisAllDay != null)
                {
                    newEvent["isAllDay"] = ExpressionConverter.ConvertO(newEventisAllDay);
                    newEventpropCount++;
                }

                if (newEventpropCount > 0)
                {
                    callPayload.Body = newEvent;
                }

                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [WorkflowExpressionFactory(nameof(__BuildGetEvent))]
        public IBodyWorkflowAction<ResponseEvent> GetEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEvent> __BuildGetEvent(WorkflowExpression<string> calendarId, WorkflowExpression<string> eventId)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<ResponseEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1), ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEvent))]
        public IBodyWorkflowAction<JToken> DeleteEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteEvent(WorkflowExpression<string> calendarId, WorkflowExpression<string> eventId)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1), ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEvent))]
        public IBodyWorkflowAction<ResponseEvent> UpdateEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> updatedEventtitle = null, [WorkflowExpression] Func<string> updatedEventstartTime = null, [WorkflowExpression] Func<string> updatedEventendTime = null, [WorkflowExpression] Func<string> updatedEventdescription = null, [WorkflowExpression] Func<string> updatedEventlocation = null, [WorkflowExpression] Func<string> updatedEventattendees = null, [WorkflowExpression] Func<updatedEventstatusInput> updatedEventstatus = null, [WorkflowExpression] Func<bool> updatedEventisAllDay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEvent> __BuildUpdateEvent(WorkflowExpression<string> calendarId, WorkflowExpression<string> eventId, WorkflowExpression<string> updatedEventtitle = null, WorkflowExpression<string> updatedEventstartTime = null, WorkflowExpression<string> updatedEventendTime = null, WorkflowExpression<string> updatedEventdescription = null, WorkflowExpression<string> updatedEventlocation = null, WorkflowExpression<string> updatedEventattendees = null, WorkflowExpression<updatedEventstatusInput> updatedEventstatus = null, WorkflowExpression<bool> updatedEventisAllDay = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(eventId, nameof(eventId), required: true);
            WorkflowExpression.Validate(updatedEventtitle, nameof(updatedEventtitle), required: false);
            WorkflowExpression.Validate(updatedEventstartTime, nameof(updatedEventstartTime), required: false);
            WorkflowExpression.Validate(updatedEventendTime, nameof(updatedEventendTime), required: false);
            WorkflowExpression.Validate(updatedEventdescription, nameof(updatedEventdescription), required: false);
            WorkflowExpression.Validate(updatedEventlocation, nameof(updatedEventlocation), required: false);
            WorkflowExpression.Validate(updatedEventattendees, nameof(updatedEventattendees), required: false);
            WorkflowExpression.Validate(updatedEventstatus, nameof(updatedEventstatus), required: false);
            WorkflowExpression.Validate(updatedEventisAllDay, nameof(updatedEventisAllDay), required: false);
            return new DeferredBodyAction<ResponseEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1), ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updatedEvent = new JObject();
                var updatedEventpropCount = 0;
                if (updatedEventtitle != null)
                {
                    updatedEvent["summary"] = ExpressionConverter.ConvertO(updatedEventtitle);
                    updatedEventpropCount++;
                }

                if (updatedEventstartTime != null)
                {
                    updatedEvent["start"] = ExpressionConverter.ConvertO(updatedEventstartTime);
                    updatedEventpropCount++;
                }

                if (updatedEventendTime != null)
                {
                    updatedEvent["end"] = ExpressionConverter.ConvertO(updatedEventendTime);
                    updatedEventpropCount++;
                }

                if (updatedEventdescription != null)
                {
                    updatedEvent["description"] = ExpressionConverter.ConvertO(updatedEventdescription);
                    updatedEventpropCount++;
                }

                if (updatedEventlocation != null)
                {
                    updatedEvent["location"] = ExpressionConverter.ConvertO(updatedEventlocation);
                    updatedEventpropCount++;
                }

                if (updatedEventattendees != null)
                {
                    updatedEvent["attendees"] = ExpressionConverter.ConvertO(updatedEventattendees);
                    updatedEventpropCount++;
                }

                if (updatedEventstatus != null)
                {
                    updatedEvent["status"] = ExpressionConverter.ConvertO(updatedEventstatus);
                    updatedEventpropCount++;
                }

                if (updatedEventisAllDay != null)
                {
                    updatedEvent["isAllDay"] = ExpressionConverter.ConvertO(updatedEventisAllDay);
                    updatedEventpropCount++;
                }

                if (updatedEventpropCount > 0)
                {
                    callPayload.Body = updatedEvent;
                }

                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }
    }

    public class GooglecalendarTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventList> OnNewEventInCalendar([WorkflowExpression] Func<string> calendarId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnNewEventInCalendar(WorkflowExpression<string> calendarId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger1/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventList> OnUpdatedEventInCalendar([WorkflowExpression] Func<string> calendarId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnUpdatedEventInCalendar(WorkflowExpression<string> calendarId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnDeletedEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventList> OnDeletedEventInCalendar([WorkflowExpression] Func<string> calendarId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnDeletedEventInCalendar(WorkflowExpression<string> calendarId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger3/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnChangedEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventChangedList> OnChangedEventInCalendar([WorkflowExpression] Func<string> calendarId,[WorkflowExpression] Func<bool> singleEvents = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventChangedList> __BuildOnChangedEventInCalendar(WorkflowExpression<string> calendarId,WorkflowExpression<bool> singleEvents = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(singleEvents, nameof(singleEvents), required: false);
            return new DeferredBodyTrigger<CalendarEventChangedList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger4/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (singleEvents != null)
                    callPayload.Queries["singleEvents"] = ExpressionConverter.Convert(singleEvents);
                return new ApiConnectionTrigger<CalendarEventChangedList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnEventStarted))]
        public IBodyWorkflowTrigger<CalendarEventList> OnEventStarted([WorkflowExpression] Func<string> calendarId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnEventStarted(WorkflowExpression<string> calendarId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/eventstarted/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
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
        public string CalendarID { get; set; }

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
        public string EventID { get; set; }

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
    public enum newEventstatusInput
    {
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum updatedEventstatusInput
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
        public string EventID { get; set; }

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
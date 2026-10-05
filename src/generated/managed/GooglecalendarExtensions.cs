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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarList> __BuildListCalendars(WorkflowValue<minAccessRoleInput> minAccessRole = null)
        {
            WorkflowValue.Validate(minAccessRole, nameof(minAccessRole), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarEventList> __BuildListEvents(WorkflowValue<string> calendarId, WorkflowValue<string> timeMin = null, WorkflowValue<string> timeMax = null, WorkflowValue<string> q = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(timeMin, nameof(timeMin), required: false);
            WorkflowValue.Validate(timeMax, nameof(timeMax), required: false);
            WorkflowValue.Validate(q, nameof(q), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEvent> __BuildCreateEvent(WorkflowValue<string> calendarId, WorkflowValue<string> newEventstartTime, WorkflowValue<string> newEventendTime, WorkflowValue<string> newEventtitle = null, WorkflowValue<string> newEventdescription = null, WorkflowValue<string> newEventlocation = null, WorkflowValue<string> newEventattendees = null, WorkflowValue<newEventstatusInput> newEventstatus = null, WorkflowValue<bool> newEventisAllDay = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(newEventstartTime, nameof(newEventstartTime), required: true);
            WorkflowValue.Validate(newEventendTime, nameof(newEventendTime), required: true);
            WorkflowValue.Validate(newEventtitle, nameof(newEventtitle), required: false);
            WorkflowValue.Validate(newEventdescription, nameof(newEventdescription), required: false);
            WorkflowValue.Validate(newEventlocation, nameof(newEventlocation), required: false);
            WorkflowValue.Validate(newEventattendees, nameof(newEventattendees), required: false);
            WorkflowValue.Validate(newEventstatus, nameof(newEventstatus), required: false);
            WorkflowValue.Validate(newEventisAllDay, nameof(newEventisAllDay), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEvent> __BuildGetEvent(WorkflowValue<string> calendarId, WorkflowValue<string> eventId)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteEvent(WorkflowValue<string> calendarId, WorkflowValue<string> eventId)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEvent> __BuildUpdateEvent(WorkflowValue<string> calendarId, WorkflowValue<string> eventId, WorkflowValue<string> updatedEventtitle = null, WorkflowValue<string> updatedEventstartTime = null, WorkflowValue<string> updatedEventendTime = null, WorkflowValue<string> updatedEventdescription = null, WorkflowValue<string> updatedEventlocation = null, WorkflowValue<string> updatedEventattendees = null, WorkflowValue<updatedEventstatusInput> updatedEventstatus = null, WorkflowValue<bool> updatedEventisAllDay = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(updatedEventtitle, nameof(updatedEventtitle), required: false);
            WorkflowValue.Validate(updatedEventstartTime, nameof(updatedEventstartTime), required: false);
            WorkflowValue.Validate(updatedEventendTime, nameof(updatedEventendTime), required: false);
            WorkflowValue.Validate(updatedEventdescription, nameof(updatedEventdescription), required: false);
            WorkflowValue.Validate(updatedEventlocation, nameof(updatedEventlocation), required: false);
            WorkflowValue.Validate(updatedEventattendees, nameof(updatedEventattendees), required: false);
            WorkflowValue.Validate(updatedEventstatus, nameof(updatedEventstatus), required: false);
            WorkflowValue.Validate(updatedEventisAllDay, nameof(updatedEventisAllDay), required: false);
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
        public IBodyWorkflowTrigger<CalendarEventList> OnNewEventInCalendar([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnNewEventInCalendar(WorkflowValue<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger1/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventList> OnUpdatedEventInCalendar([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnUpdatedEventInCalendar(WorkflowValue<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnDeletedEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventList> OnDeletedEventInCalendar([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnDeletedEventInCalendar(WorkflowValue<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger3/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnChangedEventInCalendar))]
        public IBodyWorkflowTrigger<CalendarEventChangedList> OnChangedEventInCalendar([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<bool> singleEvents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventChangedList> __BuildOnChangedEventInCalendar(WorkflowValue<string> calendarId, WorkflowValue<bool> singleEvents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(singleEvents, nameof(singleEvents), required: false);
            return new DeferredBodyTrigger<CalendarEventChangedList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger4/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (singleEvents != null)
                    callPayload.Queries["singleEvents"] = ExpressionConverter.Convert(singleEvents);
                return new ApiConnectionTrigger<CalendarEventChangedList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnEventStarted))]
        public IBodyWorkflowTrigger<CalendarEventList> OnEventStarted([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventList> __BuildOnEventStarted(WorkflowValue<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/eventstarted/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum newEventstatusInput
    {
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

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

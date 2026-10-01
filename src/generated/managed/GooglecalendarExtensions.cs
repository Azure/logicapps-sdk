//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlecalendar
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecalendarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<CalendarList> ListCalendars([WorkflowExpression] Func<minAccessRoleInput> minAccessRole = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/me/calendarList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (minAccessRole != null)
                    callPayload.Queries["minAccessRole"] = SourceExpressionConverter.Convert(minAccessRole);
                return callPayload;
            }

            return new ApiConnectionAction<CalendarList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<CalendarEventList> ListEvents([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> timeMin = null, [WorkflowExpression] Func<string> timeMax = null, [WorkflowExpression] Func<string> q = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeMin != null)
                    callPayload.Queries["timeMin"] = SourceExpressionConverter.ConvertO(timeMin);
                if (timeMax != null)
                    callPayload.Queries["timeMax"] = SourceExpressionConverter.ConvertO(timeMax);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<CalendarEventList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> CreateEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> newEventstartTime, [WorkflowExpression] Func<string> newEventendTime, [WorkflowExpression] Func<string> newEventtitle = null, [WorkflowExpression] Func<string> newEventdescription = null, [WorkflowExpression] Func<string> newEventlocation = null, [WorkflowExpression] Func<string> newEventattendees = null, [WorkflowExpression] Func<newEventstatusInput> newEventstatus = null, [WorkflowExpression] Func<bool> newEventisAllDay = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newEvent = new JObject();
                var newEventpropCount = 0;
                if (newEventtitle != null)
                {
                    newEvent["summary"] = SourceExpressionConverter.ConvertToken(newEventtitle);
                    newEventpropCount++;
                }

                newEventpropCount++;
                newEvent["start"] = SourceExpressionConverter.ConvertToken(newEventstartTime);
                newEventpropCount++;
                newEvent["end"] = SourceExpressionConverter.ConvertToken(newEventendTime);
                if (newEventdescription != null)
                {
                    newEvent["description"] = SourceExpressionConverter.ConvertToken(newEventdescription);
                    newEventpropCount++;
                }

                if (newEventlocation != null)
                {
                    newEvent["location"] = SourceExpressionConverter.ConvertToken(newEventlocation);
                    newEventpropCount++;
                }

                if (newEventattendees != null)
                {
                    newEvent["attendees"] = SourceExpressionConverter.ConvertToken(newEventattendees);
                    newEventpropCount++;
                }

                if (newEventstatus != null)
                {
                    newEvent["status"] = SourceExpressionConverter.Convert(newEventstatus);
                    newEventpropCount++;
                }

                if (newEventisAllDay != null)
                {
                    newEvent["isAllDay"] = SourceExpressionConverter.ConvertToken(newEventisAllDay);
                    newEventpropCount++;
                }

                if (newEventpropCount > 0)
                {
                    callPayload.Body = newEvent;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEvent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> GetEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEvent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<JToken> DeleteEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> UpdateEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> updatedEventtitle = null, [WorkflowExpression] Func<string> updatedEventstartTime = null, [WorkflowExpression] Func<string> updatedEventendTime = null, [WorkflowExpression] Func<string> updatedEventdescription = null, [WorkflowExpression] Func<string> updatedEventlocation = null, [WorkflowExpression] Func<string> updatedEventattendees = null, [WorkflowExpression] Func<updatedEventstatusInput> updatedEventstatus = null, [WorkflowExpression] Func<bool> updatedEventisAllDay = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updatedEvent = new JObject();
                var updatedEventpropCount = 0;
                if (updatedEventtitle != null)
                {
                    updatedEvent["summary"] = SourceExpressionConverter.ConvertToken(updatedEventtitle);
                    updatedEventpropCount++;
                }

                if (updatedEventstartTime != null)
                {
                    updatedEvent["start"] = SourceExpressionConverter.ConvertToken(updatedEventstartTime);
                    updatedEventpropCount++;
                }

                if (updatedEventendTime != null)
                {
                    updatedEvent["end"] = SourceExpressionConverter.ConvertToken(updatedEventendTime);
                    updatedEventpropCount++;
                }

                if (updatedEventdescription != null)
                {
                    updatedEvent["description"] = SourceExpressionConverter.ConvertToken(updatedEventdescription);
                    updatedEventpropCount++;
                }

                if (updatedEventlocation != null)
                {
                    updatedEvent["location"] = SourceExpressionConverter.ConvertToken(updatedEventlocation);
                    updatedEventpropCount++;
                }

                if (updatedEventattendees != null)
                {
                    updatedEvent["attendees"] = SourceExpressionConverter.ConvertToken(updatedEventattendees);
                    updatedEventpropCount++;
                }

                if (updatedEventstatus != null)
                {
                    updatedEvent["status"] = SourceExpressionConverter.Convert(updatedEventstatus);
                    updatedEventpropCount++;
                }

                if (updatedEventisAllDay != null)
                {
                    updatedEvent["isAllDay"] = SourceExpressionConverter.ConvertToken(updatedEventisAllDay);
                    updatedEventpropCount++;
                }

                if (updatedEventpropCount > 0)
                {
                    callPayload.Body = updatedEvent;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEvent>(BuildSourceInput);
        }
    }

    public class GooglecalendarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventList> OnNewEventInCalendar([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger1/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnUpdatedEventInCalendar([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger2/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnDeletedEventInCalendar([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger3/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventChangedList> OnChangedEventInCalendar([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<bool> singleEvents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger4/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (singleEvents != null)
                    callPayload.Queries["singleEvents"] = SourceExpressionConverter.ConvertO(singleEvents);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventChangedList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnEventStarted([WorkflowExpression] Func<string> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/eventstarted/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventList>(BuildSourceInput, triggerName, recurrence);
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
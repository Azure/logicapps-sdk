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
        public IBodyWorkflowAction<CalendarList> ListCalendars(Expression<Func<minAccessRoleInput>> minAccessRole = null)
        {
            var apiCallPath = "/users/me/calendarList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (minAccessRole != null)
                callPayload.Queries["minAccessRole"] = CSharpExpressionConverter.Convert(minAccessRole);
            return new ApiConnectionAction<CalendarList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<CalendarEventList> ListEvents(Expression<Func<string>> calendarId, Expression<Func<string>> timeMin = null, Expression<Func<string>> timeMax = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeMin != null)
                callPayload.Queries["timeMin"] = CSharpExpressionConverter.ConvertO(timeMin);
            if (timeMax != null)
                callPayload.Queries["timeMax"] = CSharpExpressionConverter.ConvertO(timeMax);
            if (q != null)
                callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            return new ApiConnectionAction<CalendarEventList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> CreateEvent(Expression<Func<string>> calendarId, Expression<Func<string>> newEventstartTime, Expression<Func<string>> newEventendTime, Expression<Func<string>> newEventtitle = null, Expression<Func<string>> newEventdescription = null, Expression<Func<string>> newEventlocation = null, Expression<Func<string>> newEventattendees = null, Expression<Func<newEventstatusInput>> newEventstatus = null, Expression<Func<bool>> newEventisAllDay = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newEvent = new JObject();
            var newEventpropCount = 0;
            if (newEventtitle != null)
            {
                newEvent["summary"] = CSharpExpressionConverter.ConvertToken(newEventtitle);
                newEventpropCount++;
            }

            newEventpropCount++;
            newEvent["start"] = CSharpExpressionConverter.ConvertToken(newEventstartTime);
            newEventpropCount++;
            newEvent["end"] = CSharpExpressionConverter.ConvertToken(newEventendTime);
            if (newEventdescription != null)
            {
                newEvent["description"] = CSharpExpressionConverter.ConvertToken(newEventdescription);
                newEventpropCount++;
            }

            if (newEventlocation != null)
            {
                newEvent["location"] = CSharpExpressionConverter.ConvertToken(newEventlocation);
                newEventpropCount++;
            }

            if (newEventattendees != null)
            {
                newEvent["attendees"] = CSharpExpressionConverter.ConvertToken(newEventattendees);
                newEventpropCount++;
            }

            if (newEventstatus != null)
            {
                newEvent["status"] = CSharpExpressionConverter.Convert(newEventstatus);
                newEventpropCount++;
            }

            if (newEventisAllDay != null)
            {
                newEvent["isAllDay"] = CSharpExpressionConverter.ConvertToken(newEventisAllDay);
                newEventpropCount++;
            }

            if (newEventpropCount > 0)
            {
                callPayload.Body = newEvent;
            }

            return new ApiConnectionAction<ResponseEvent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> GetEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseEvent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<JToken> DeleteEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> UpdateEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId, Expression<Func<string>> updatedEventtitle = null, Expression<Func<string>> updatedEventstartTime = null, Expression<Func<string>> updatedEventendTime = null, Expression<Func<string>> updatedEventdescription = null, Expression<Func<string>> updatedEventlocation = null, Expression<Func<string>> updatedEventattendees = null, Expression<Func<updatedEventstatusInput>> updatedEventstatus = null, Expression<Func<bool>> updatedEventisAllDay = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updatedEvent = new JObject();
            var updatedEventpropCount = 0;
            if (updatedEventtitle != null)
            {
                updatedEvent["summary"] = CSharpExpressionConverter.ConvertToken(updatedEventtitle);
                updatedEventpropCount++;
            }

            if (updatedEventstartTime != null)
            {
                updatedEvent["start"] = CSharpExpressionConverter.ConvertToken(updatedEventstartTime);
                updatedEventpropCount++;
            }

            if (updatedEventendTime != null)
            {
                updatedEvent["end"] = CSharpExpressionConverter.ConvertToken(updatedEventendTime);
                updatedEventpropCount++;
            }

            if (updatedEventdescription != null)
            {
                updatedEvent["description"] = CSharpExpressionConverter.ConvertToken(updatedEventdescription);
                updatedEventpropCount++;
            }

            if (updatedEventlocation != null)
            {
                updatedEvent["location"] = CSharpExpressionConverter.ConvertToken(updatedEventlocation);
                updatedEventpropCount++;
            }

            if (updatedEventattendees != null)
            {
                updatedEvent["attendees"] = CSharpExpressionConverter.ConvertToken(updatedEventattendees);
                updatedEventpropCount++;
            }

            if (updatedEventstatus != null)
            {
                updatedEvent["status"] = CSharpExpressionConverter.Convert(updatedEventstatus);
                updatedEventpropCount++;
            }

            if (updatedEventisAllDay != null)
            {
                updatedEvent["isAllDay"] = CSharpExpressionConverter.ConvertToken(updatedEventisAllDay);
                updatedEventpropCount++;
            }

            if (updatedEventpropCount > 0)
            {
                callPayload.Body = updatedEvent;
            }

            return new ApiConnectionAction<ResponseEvent>(callPayload);
        }
    }

    public class GooglecalendarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventList> OnNewEventInCalendar(Expression<Func<string>> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger1/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnUpdatedEventInCalendar(Expression<Func<string>> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger2/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnDeletedEventInCalendar(Expression<Func<string>> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger3/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventChangedList> OnChangedEventInCalendar(Expression<Func<string>> calendarId, Expression<Func<bool>> singleEvents = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger4/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (singleEvents != null)
                callPayload.Queries["singleEvents"] = CSharpExpressionConverter.ConvertO(singleEvents);
            return new ApiConnectionTrigger<CalendarEventChangedList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnEventStarted(Expression<Func<string>> calendarId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/eventstarted/calendars/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CalendarEventList>(callPayload, triggerName, recurrence);
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
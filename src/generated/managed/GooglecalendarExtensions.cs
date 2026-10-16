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
        public IBodyWorkflowAction<CalendarList> ListCalendars(Expression<Func<minAccessRoleInput>> minAccessRole = null)
        {
            var __workflow_minAccessRole = WorkflowExpression.Compile(minAccessRole, nameof(minAccessRole), required: false);
            return new DeferredBodyAction<CalendarList>(() =>
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
        public IBodyWorkflowAction<CalendarEventList> ListEvents(Expression<Func<string>> calendarId, Expression<Func<string>> timeMin = null, Expression<Func<string>> timeMax = null, Expression<Func<string>> q = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_timeMin = WorkflowExpression.Compile(timeMin, nameof(timeMin), required: false);
            var __workflow_timeMax = WorkflowExpression.Compile(timeMax, nameof(timeMax), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
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
        public IBodyWorkflowAction<ResponseEvent> CreateEvent(Expression<Func<string>> calendarId, Expression<Func<string>> newEventstartTime, Expression<Func<string>> newEventendTime, Expression<Func<string>> newEventtitle = null, Expression<Func<string>> newEventdescription = null, Expression<Func<string>> newEventlocation = null, Expression<Func<string>> newEventattendees = null, Expression<Func<newEventstatusInput>> newEventstatus = null, Expression<Func<bool>> newEventisAllDay = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_newEventstartTime = WorkflowExpression.Compile(newEventstartTime, nameof(newEventstartTime), required: true);
            var __workflow_newEventendTime = WorkflowExpression.Compile(newEventendTime, nameof(newEventendTime), required: true);
            var __workflow_newEventtitle = WorkflowExpression.Compile(newEventtitle, nameof(newEventtitle), required: false);
            var __workflow_newEventdescription = WorkflowExpression.Compile(newEventdescription, nameof(newEventdescription), required: false);
            var __workflow_newEventlocation = WorkflowExpression.Compile(newEventlocation, nameof(newEventlocation), required: false);
            var __workflow_newEventattendees = WorkflowExpression.Compile(newEventattendees, nameof(newEventattendees), required: false);
            var __workflow_newEventstatus = WorkflowExpression.Compile(newEventstatus, nameof(newEventstatus), required: false);
            var __workflow_newEventisAllDay = WorkflowExpression.Compile(newEventisAllDay, nameof(newEventisAllDay), required: false);
            return new DeferredBodyAction<ResponseEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newEvent = new JObject();
                var newEventpropCount = 0;
                if (__workflow_newEventtitle != null)
                {
                    newEvent["summary"] = ExpressionConverter.ConvertO(__workflow_newEventtitle);
                    newEventpropCount++;
                }

                newEventpropCount++;
                newEvent["start"] = ExpressionConverter.ConvertO(__workflow_newEventstartTime);
                newEventpropCount++;
                newEvent["end"] = ExpressionConverter.ConvertO(__workflow_newEventendTime);
                if (__workflow_newEventdescription != null)
                {
                    newEvent["description"] = ExpressionConverter.ConvertO(__workflow_newEventdescription);
                    newEventpropCount++;
                }

                if (__workflow_newEventlocation != null)
                {
                    newEvent["location"] = ExpressionConverter.ConvertO(__workflow_newEventlocation);
                    newEventpropCount++;
                }

                if (__workflow_newEventattendees != null)
                {
                    newEvent["attendees"] = ExpressionConverter.ConvertO(__workflow_newEventattendees);
                    newEventpropCount++;
                }

                if (__workflow_newEventstatus != null)
                {
                    newEvent["status"] = ExpressionConverter.ConvertO(__workflow_newEventstatus);
                    newEventpropCount++;
                }

                if (__workflow_newEventisAllDay != null)
                {
                    newEvent["isAllDay"] = ExpressionConverter.ConvertO(__workflow_newEventisAllDay);
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
        public IBodyWorkflowAction<ResponseEvent> GetEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<ResponseEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<JToken> DeleteEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecalendar")]
        public IBodyWorkflowAction<ResponseEvent> UpdateEvent(Expression<Func<string>> calendarId, Expression<Func<string>> eventId, Expression<Func<string>> updatedEventtitle = null, Expression<Func<string>> updatedEventstartTime = null, Expression<Func<string>> updatedEventendTime = null, Expression<Func<string>> updatedEventdescription = null, Expression<Func<string>> updatedEventlocation = null, Expression<Func<string>> updatedEventattendees = null, Expression<Func<updatedEventstatusInput>> updatedEventstatus = null, Expression<Func<bool>> updatedEventisAllDay = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_updatedEventtitle = WorkflowExpression.Compile(updatedEventtitle, nameof(updatedEventtitle), required: false);
            var __workflow_updatedEventstartTime = WorkflowExpression.Compile(updatedEventstartTime, nameof(updatedEventstartTime), required: false);
            var __workflow_updatedEventendTime = WorkflowExpression.Compile(updatedEventendTime, nameof(updatedEventendTime), required: false);
            var __workflow_updatedEventdescription = WorkflowExpression.Compile(updatedEventdescription, nameof(updatedEventdescription), required: false);
            var __workflow_updatedEventlocation = WorkflowExpression.Compile(updatedEventlocation, nameof(updatedEventlocation), required: false);
            var __workflow_updatedEventattendees = WorkflowExpression.Compile(updatedEventattendees, nameof(updatedEventattendees), required: false);
            var __workflow_updatedEventstatus = WorkflowExpression.Compile(updatedEventstatus, nameof(updatedEventstatus), required: false);
            var __workflow_updatedEventisAllDay = WorkflowExpression.Compile(updatedEventisAllDay, nameof(updatedEventisAllDay), required: false);
            return new DeferredBodyAction<ResponseEvent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updatedEvent = new JObject();
                var updatedEventpropCount = 0;
                if (__workflow_updatedEventtitle != null)
                {
                    updatedEvent["summary"] = ExpressionConverter.ConvertO(__workflow_updatedEventtitle);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventstartTime != null)
                {
                    updatedEvent["start"] = ExpressionConverter.ConvertO(__workflow_updatedEventstartTime);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventendTime != null)
                {
                    updatedEvent["end"] = ExpressionConverter.ConvertO(__workflow_updatedEventendTime);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventdescription != null)
                {
                    updatedEvent["description"] = ExpressionConverter.ConvertO(__workflow_updatedEventdescription);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventlocation != null)
                {
                    updatedEvent["location"] = ExpressionConverter.ConvertO(__workflow_updatedEventlocation);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventattendees != null)
                {
                    updatedEvent["attendees"] = ExpressionConverter.ConvertO(__workflow_updatedEventattendees);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventstatus != null)
                {
                    updatedEvent["status"] = ExpressionConverter.ConvertO(__workflow_updatedEventstatus);
                    updatedEventpropCount++;
                }

                if (__workflow_updatedEventisAllDay != null)
                {
                    updatedEvent["isAllDay"] = ExpressionConverter.ConvertO(__workflow_updatedEventisAllDay);
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
        public IBodyWorkflowTrigger<CalendarEventList> OnNewEventInCalendar(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger1/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnUpdatedEventInCalendar(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnDeletedEventInCalendar(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger3/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CalendarEventList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventChangedList> OnChangedEventInCalendar(Expression<Func<string>> calendarId, Expression<Func<bool>> singleEvents = null, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_singleEvents = WorkflowExpression.Compile(singleEvents, nameof(singleEvents), required: false);
            return new DeferredBodyTrigger<CalendarEventChangedList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger4/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_singleEvents != null)
                    callPayload.Queries["singleEvents"] = ExpressionConverter.Convert(__workflow_singleEvents);
                return new ApiConnectionTrigger<CalendarEventChangedList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventList> OnEventStarted(Expression<Func<string>> calendarId, FlowRecurrence recurrence = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            return new DeferredBodyTrigger<CalendarEventList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/eventstarted/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarId, 1));
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

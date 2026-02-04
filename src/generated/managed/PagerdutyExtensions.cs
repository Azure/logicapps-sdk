//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pagerduty
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PagerdutyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<Incident> GetIncidentByKey(Expression<Func<string>> incidentKey)
        {
            var apiCallPath = "/action8/incidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["incident_key"] = ExpressionConverter.Convert(incidentKey);
            return new ApiConnectionAction<Incident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<User> GetUser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<User>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<AddNoteResponse> AddNoteToIncident(Expression<Func<string>> incidentId, Expression<Func<string>> requestaddedBy, Expression<Func<string>> requestnote)
        {
            var apiCallPath = String.Format("/incidents/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["userId"] = ExpressionConverter.ConvertO(requestaddedBy);
            requestpropCount++;
            request["note"] = ExpressionConverter.ConvertO(requestnote);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<AddNoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<SingleIncident> AcknowledgeIncident(Expression<Func<string>> incidentId, Expression<Func<string>> requestacknowledgedBy)
        {
            var apiCallPath = String.Format("/action1/incidents/{0}", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["userId"] = ExpressionConverter.ConvertO(requestacknowledgedBy);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SingleIncident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<SingleIncident> ResolveIncident(Expression<Func<string>> incidentId, Expression<Func<string>> requestresolvedBy)
        {
            var apiCallPath = String.Format("/action2/incidents/{0}", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["userId"] = ExpressionConverter.ConvertO(requestresolvedBy);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SingleIncident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<SingleIncident> ReassignIncident(Expression<Func<string>> incidentId, Expression<Func<string>> requestfromUser, Expression<Func<string>> requesttoUser)
        {
            var apiCallPath = String.Format("/action3/incidents/{0}", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["userId"] = ExpressionConverter.ConvertO(requestfromUser);
            requestpropCount++;
            request["reassignUserId"] = ExpressionConverter.ConvertO(requesttoUser);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SingleIncident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<SingleIncident> SnoozeIncident(Expression<Func<string>> incidentId, Expression<Func<string>> requestsnoozedBy, Expression<Func<int>> requestsnooze)
        {
            var apiCallPath = String.Format("/action4/incidents/{0}/snooze", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["userId"] = ExpressionConverter.ConvertO(requestsnoozedBy);
            requestpropCount++;
            request["duration"] = ExpressionConverter.ConvertO(requestsnooze);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SingleIncident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<SingleIncident> EscalateIncident(Expression<Func<string>> incidentId, Expression<Func<string>> requestescalatedBy, Expression<Func<string>> requestescalationPolicy)
        {
            var apiCallPath = String.Format("/action5/incidents/{0}", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["userId"] = ExpressionConverter.ConvertO(requestescalatedBy);
            requestpropCount++;
            request["policyId"] = ExpressionConverter.ConvertO(requestescalationPolicy);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SingleIncident>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagerduty")]
        public IBodyWorkflowAction<NewIncident> CreateIncident(Expression<Func<string>> requestserviceKey, Expression<Func<string>> requestdescription)
        {
            var apiCallPath = "/incidents/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["service_key"] = ExpressionConverter.ConvertO(requestserviceKey);
            requestpropCount++;
            request["description"] = ExpressionConverter.ConvertO(requestdescription);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<NewIncident>(callPayload);
        }
    }

    public class PagerdutyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NotesResponse> OnNewIncidentNote(Expression<Func<string>> incidentId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger1/incidents/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NotesResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncidentsResponse> OnNewIncidentCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/incidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<IncidentsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncidentsResponse> OnIncidentAssigned(Expression<Func<string>> userId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger3/incidents/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<IncidentsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncidentsResponse> OnIncidentAcknowledged(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger4/incidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<IncidentsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncidentsResponse> OnIncidentResolved(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger5/incidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<IncidentsResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class Incident
    {
        [JsonProperty("id")]
        public string IncidentId { get; set; }

        [JsonProperty("type")]
        public string IncidentType { get; set; }

        [JsonProperty("summary")]
        public string IncidentTitle { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string IncidentDetailUrl { get; set; }

        [JsonProperty("incident_number")]
        public int IncidentNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreateDate { get; set; }

        [JsonProperty("status")]
        public string CurrentStatus { get; set; }

        [JsonProperty("pending_actions")]
        public PendingAction[] ListOfPendingActions { get; set; }

        [JsonProperty("incident_key")]
        public string IncidentKey { get; set; }

        [JsonProperty("service")]
        public Service Service { get; set; }

        [JsonProperty("assignments")]
        public Assignment[] ListOfAllAssignmentsForThisIncident { get; set; }

        [JsonProperty("assignedUserId")]
        public string AssignedUserID { get; set; }

        [JsonProperty("acknowledgements")]
        public Acknowledgement[] ListOfAllAcknowledgementsForThisIncident { get; set; }

        [JsonProperty("last_status_change_at")]
        public string LastStatusChange { get; set; }

        [JsonProperty("last_status_change_by")]
        public LastStatusChangeBy LastStatusChangeBy { get; set; }

        [JsonProperty("first_trigger_log_entry")]
        public FirstTriggerLogEntry FirstTriggerLogEntry { get; set; }

        [JsonProperty("escalation_policy")]
        public EscalationPolicy EscalationPolicy { get; set; }

        [JsonProperty("teams")]
        public Team[] TeamsInvolvedInTheIncidentLifecycle { get; set; }

        [JsonProperty("urgency")]
        public string CurrentUrgency { get; set; }
    }

    public class PendingAction
    {
        [JsonProperty("type")]
        public string PendingActionType { get; set; }

        [JsonProperty("at")]
        public string CreateDate { get; set; }
    }

    public class Service
    {
        [JsonProperty("id")]
        public string ServiceId { get; set; }

        [JsonProperty("type")]
        public string ServiceType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class Assignment
    {
        [JsonProperty("at")]
        public string TimeAssignmentWasCreated { get; set; }

        [JsonProperty("assignee")]
        public Assignee Assignee { get; set; }
    }

    public class Assignee
    {
        [JsonProperty("id")]
        public string AssigneeId { get; set; }

        [JsonProperty("type")]
        public string AssigneeType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class Acknowledgement
    {
        [JsonProperty("at")]
        public string TimeAcknowledgementWasCreated { get; set; }

        [JsonProperty("acknowledger")]
        public Acknowledger Acknowledger { get; set; }
    }

    public class Acknowledger
    {
        [JsonProperty("id")]
        public string AcknowledgerId { get; set; }

        [JsonProperty("type")]
        public string AcknowledgerType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class LastStatusChangeBy
    {
        [JsonProperty("id")]
        public string LastStatusChangeId { get; set; }

        [JsonProperty("type")]
        public string LastStatusChangeType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class FirstTriggerLogEntry
    {
        [JsonProperty("id")]
        public string LogEntryId { get; set; }

        [JsonProperty("type")]
        public string LogEntryType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class EscalationPolicy
    {
        [JsonProperty("id")]
        public string PolicyId { get; set; }

        [JsonProperty("type")]
        public string PolicyType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class Team
    {
        [JsonProperty("id")]
        public string TeamId { get; set; }

        [JsonProperty("type")]
        public string TeamType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class User
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EMailAddress { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("color")]
        public string ScheduleColor { get; set; }

        [JsonProperty("avatar_url")]
        public string UserAvatarUrl { get; set; }

        [JsonProperty("billed")]
        public bool UserIsBilled { get; set; }

        [JsonProperty("role")]
        public string TheUserRole { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("invitation_sent")]
        public bool OutstandingInvitationForTheUser { get; set; }

        [JsonProperty("contact_methods")]
        public ContactMethod[] ContactMethodsForTheUser { get; set; }

        [JsonProperty("notification_rules")]
        public NotificationRule[] NotificationRulesForTheUser { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("teams")]
        public JToken[] TeamsToWhichTheUserBelongs { get; set; }

        [JsonProperty("coordinated_incidents")]
        public JToken[] ListOfIncidentsForThisUser { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("type")]
        public string UserType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class ContactMethod
    {
        [JsonProperty("id")]
        public string ContactMethodId { get; set; }

        [JsonProperty("type")]
        public string ContactMethodType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HTMLURL { get; set; }
    }

    public class NotificationRule
    {
        [JsonProperty("id")]
        public string NotificationRuleId { get; set; }

        [JsonProperty("type")]
        public string RuleType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HTMLURL { get; set; }
    }

    public class AddNoteResponse
    {
        [JsonProperty("user")]
        public UserResponse User { get; set; }

        [JsonProperty("note")]
        public NoteResponse Note { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("type")]
        public string UserType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("self")]
        public string TheAPIShowURLAtWhichTheObjectIsAccessible { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }

    public class NoteResponse
    {
        [JsonProperty("id")]
        public string UniqueIdentifierOfTheUser { get; set; }

        [JsonProperty("user")]
        public UserResponse User { get; set; }

        [JsonProperty("content")]
        public string NoteContent { get; set; }

        [JsonProperty("created_at")]
        public string DateAndTimeTheNoteWasCreated { get; set; }
    }

    public class SingleIncident
    {
        [JsonProperty("incident")]
        public Incident Incident { get; set; }
    }

    public class NewIncident
    {
        [JsonProperty("incident_key")]
        public string Key { get; set; }
    }

    public class NotesResponse
    {
        [JsonProperty("notes")]
        public Note[] Notes { get; set; }
    }

    public class Note
    {
        [JsonProperty("content")]
        public string NoteContent { get; set; }
    }

    public class IncidentsResponse
    {
        [JsonProperty("incidents")]
        public Incident[] ListOfIncidents { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pagerduty;

    public partial class WorkflowManagedActions
    {
        public PagerdutyActions Pagerduty(string connectionId) => new PagerdutyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PagerdutyTriggers Pagerduty(string connectionId) => new PagerdutyTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freshdesk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreshdeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshdesk")]
        public IBodyWorkflowAction<CreateTicket200Response> CreateTicket(Expression<Func<string>> bodysubject, Expression<Func<string>> bodydescription, Expression<Func<string>> bodyemail, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydueBy = null, Expression<Func<string>> bodyfirstResponseDueBy = null, Expression<Func<int>> bodyagent = null, Expression<Func<int>> bodyproduct = null)
        {
            var apiCallPath = "/api/v2/tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["priority"] = ExpressionConverter.ConvertO(bodypriority);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodydueBy != null)
            {
                body["due_by"] = ExpressionConverter.ConvertO(bodydueBy);
                bodypropCount++;
            }

            if (bodyfirstResponseDueBy != null)
            {
                body["fr_due_by"] = ExpressionConverter.ConvertO(bodyfirstResponseDueBy);
                bodypropCount++;
            }

            if (bodyagent != null)
            {
                body["responder_id"] = ExpressionConverter.ConvertO(bodyagent);
                bodypropCount++;
            }

            if (bodyproduct != null)
            {
                body["product_id"] = ExpressionConverter.ConvertO(bodyproduct);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTicket200Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshdesk")]
        public IBodyWorkflowAction<AddNote200Response> AddNote(Expression<Func<int>> ticketId, Expression<Func<string>> bodycontent, Expression<Func<bool>> bodyprivate = null)
        {
            var apiCallPath = String.Format("/api/v2/tickets/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodycontent);
            if (bodyprivate != null)
            {
                body["private"] = ExpressionConverter.ConvertO(bodyprivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddNote200Response>(callPayload);
        }
    }

    public class FreshdeskTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateTicket200Response[]> TriggerTicketCreated(Expression<Func<bool>> includeDescription = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/ticketcreated/api/v2/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["updated_since"] = Convert.ToString("2016-08-19T02:00:00Z");
            callPayload.Queries["includeDescription"] = Convert.ToString(false);
            if (includeDescription != null)
                callPayload.Queries["includeDescription"] = ExpressionConverter.Convert(includeDescription);
            return new ApiConnectionTrigger<CreateTicket200Response[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CreateTicket200Response[]> TriggerTicketAssignedToAgent(Expression<Func<int>> agentId, Expression<Func<bool>> includeDescription = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/ticketassignedtoagent/api/v2/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["agentId"] = ExpressionConverter.Convert(agentId);
            callPayload.Queries["updated_since"] = Convert.ToString("2016-08-19T02:00:00Z");
            callPayload.Queries["includeDescription"] = Convert.ToString(false);
            if (includeDescription != null)
                callPayload.Queries["includeDescription"] = ExpressionConverter.Convert(includeDescription);
            return new ApiConnectionTrigger<CreateTicket200Response[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CreateTicket200Response[]> TriggerTicketUpdated(Expression<Func<int>> ticketId = null, Expression<Func<bool>> includeDescription = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/ticketupdated/api/v2/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ticketId != null)
                callPayload.Queries["ticketId"] = ExpressionConverter.Convert(ticketId);
            callPayload.Queries["updated_since"] = Convert.ToString("2016-08-19T02:00:00Z");
            callPayload.Queries["includeDescription"] = Convert.ToString(false);
            if (includeDescription != null)
                callPayload.Queries["includeDescription"] = ExpressionConverter.Convert(includeDescription);
            return new ApiConnectionTrigger<CreateTicket200Response[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CreateTicket200Response> TriggerTicketStatusChanged(Expression<Func<int>> ticketId, Expression<Func<statusInput>> status = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/ticketstatuschanged/api/v2/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionTrigger<CreateTicket200Response>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetAgents200ResponseItem[]> TriggerAgentAdded(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/agentadded/api/v2/agents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetAgents200ResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetContacts200ResponseItem[]> TriggerContactAdded(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/contactadded/api/v2/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetContacts200ResponseItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class CreateTicket200Response
    {
        [JsonProperty("spam")]
        public bool Spam { get; set; }

        [JsonProperty("priority")]
        public CreateTicket200ResponsePriorityType Priority { get; set; }

        [JsonProperty("requester_id")]
        public int RequesterId { get; set; }

        [JsonProperty("responder_id")]
        public int AgentId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("id")]
        public int TicketId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("due_by")]
        public string DueBy { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_text")]
        public string DescriptionText { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public enum CreateTicket200ResponsePriorityType
    {
        Urgent,
        High,
        Medium,
        Low
    }

    public enum bodypriorityInput
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum bodystatusInput
    {
        Open,
        Pending,
        Resolved,
        Closed,
        [EnumMember(Value = "Waiting on Customer")]
        WaitingOnCustomer,
        [EnumMember(Value = "Waiting on Third Party")]
        WaitingOnThirdParty
    }

    public class AddNote200Response
    {
        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("body")]
        public string Content { get; set; }

        [JsonProperty("body_text")]
        public string ContentText { get; set; }

        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdateAt { get; set; }
    }

    public enum statusInput
    {
        Open,
        Pending,
        Resolved,
        Closed,
        [EnumMember(Value = "Waiting on Customer")]
        WaitingOnCustomer,
        [EnumMember(Value = "Waiting on Third Party")]
        WaitingOnThirdParty
    }

    public class GetAgents200ResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ticket_scope")]
        public int TicketScope { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("contact")]
        public GetAgents200ResponseItemContactType Contact { get; set; }
    }

    public class GetAgents200ResponseItemContactType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class GetContacts200ResponseItem
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Freshdesk;

    public partial class WorkflowManagedActions
    {
        public FreshdeskActions Freshdesk(string connectionId) => new FreshdeskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FreshdeskTriggers Freshdesk(string connectionId) => new FreshdeskTriggers(connectionId);
    }
}
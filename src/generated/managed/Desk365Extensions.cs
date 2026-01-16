//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Desk365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Desk365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<GetAllTicketsResponse> GetAllTickets(Expression<Func<int>> offset = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<orderTypeInput>> orderType = null, Expression<Func<string>> updatedSince = null, Expression<Func<includeDescriptionInput>> includeDescription = null)
        {
            var apiCallPath = "/power_automate/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            callPayload.Queries["order_by"] = Convert.ToString("created_time");
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            callPayload.Queries["order_type"] = Convert.ToString("desc");
            if (orderType != null)
                callPayload.Queries["order_type"] = ExpressionConverter.Convert(orderType);
            callPayload.Queries["updated_since"] = Convert.ToString("");
            if (updatedSince != null)
                callPayload.Queries["updated_since"] = ExpressionConverter.Convert(updatedSince);
            callPayload.Queries["include_description"] = Convert.ToString("No");
            if (includeDescription != null)
                callPayload.Queries["include_description"] = ExpressionConverter.Convert(includeDescription);
            callPayload.Queries["src"] = Convert.ToString(2);
            return new ApiConnectionAction<GetAllTicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket(Expression<Func<int>> ticketNumber = null)
        {
            var apiCallPath = "/power_automate/tickets/details";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ticketNumber != null)
                callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(ticketNumber);
            callPayload.Queries["src"] = Convert.ToString(2);
            return new ApiConnectionAction<GetTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket(Expression<Func<string>> bodyEmail, Expression<Func<string>> bodyDescription, Expression<Func<string>> bodySubject, Expression<Func<string>> bodyAgent = null, Expression<Func<string>> bodyCategory = null, Expression<Func<bodyPriorityInput>> bodyPriority = null, Expression<Func<string>> bodyStatus = null, Expression<Func<bodyTypeInput>> bodyType = null)
        {
            var apiCallPath = "/power_automate/tickets/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["src"] = Convert.ToString(2);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAgent != null)
            {
                body["Agent"] = ExpressionConverter.ConvertO(bodyAgent);
                bodypropCount++;
            }

            if (bodyCategory != null)
            {
                body["Category"] = ExpressionConverter.ConvertO(bodyCategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            bodypropCount++;
            body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            bodypropCount++;
            body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
            if (bodyType != null)
            {
                body["Type"] = ExpressionConverter.ConvertO(bodyType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<UpdateTicketResponse> UpdateTicket(Expression<Func<int>> ticketNumber, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyassignTo = null, Expression<Func<string>> bodycategory = null)
        {
            var apiCallPath = "/power_automate/tickets/update";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(ticketNumber);
            callPayload.Queries["src"] = Convert.ToString(2);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyassignTo != null)
            {
                body["assign_to"] = ExpressionConverter.ConvertO(bodyassignTo);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<AddNoteResponse> AddNote(Expression<Func<int>> ticketNumber, Expression<Func<string>> bodyContent, Expression<Func<string>> bodyAgentEmail = null, Expression<Func<string>> bodyNotifyAgent = null, Expression<Func<bodyPrivateInput>> bodyPrivate = null)
        {
            var apiCallPath = "/power_automate/tickets/add_note";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(ticketNumber);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Content"] = ExpressionConverter.ConvertO(bodyContent);
            if (bodyAgentEmail != null)
            {
                body["AgentEmail"] = ExpressionConverter.ConvertO(bodyAgentEmail);
                bodypropCount++;
            }

            if (bodyNotifyAgent != null)
            {
                body["NotifyAgent"] = ExpressionConverter.ConvertO(bodyNotifyAgent);
                bodypropCount++;
            }

            if (bodyPrivate != null)
            {
                body["Private"] = ExpressionConverter.ConvertO(bodyPrivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddNoteResponse>(callPayload);
        }
    }

    public class Desk365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTicketWebhook(Expression<Func<string>> bodyContactEmail = null, Expression<Func<string>> bodySubject = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodyAgent = null, Expression<Func<string>> bodyGroup = null, string triggerName = null)
        {
            var apiCallPath = "/power_automate/tickets/create_ticket_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContactEmail != null)
            {
                body["ContactEmail"] = ExpressionConverter.ConvertO(bodyContactEmail);
                bodypropCount++;
            }

            if (bodySubject != null)
            {
                body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyAgent != null)
            {
                body["Agent"] = ExpressionConverter.ConvertO(bodyAgent);
                bodypropCount++;
            }

            if (bodyGroup != null)
            {
                body["Group"] = ExpressionConverter.ConvertO(bodyGroup);
                bodypropCount++;
            }

            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UpdateTicketWebhook(Expression<Func<string>> bodyContactEmail = null, Expression<Func<string>> bodySubject = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodyAgent = null, Expression<Func<string>> bodyGroup = null, string triggerName = null)
        {
            var apiCallPath = "/power_automate/tickets/update_ticket_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContactEmail != null)
            {
                body["ContactEmail"] = ExpressionConverter.ConvertO(bodyContactEmail);
                bodypropCount++;
            }

            if (bodySubject != null)
            {
                body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyAgent != null)
            {
                body["Agent"] = ExpressionConverter.ConvertO(bodyAgent);
                bodypropCount++;
            }

            if (bodyGroup != null)
            {
                body["Group"] = ExpressionConverter.ConvertO(bodyGroup);
                bodypropCount++;
            }

            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger AddNoteWebhook(Expression<Func<string>> bodyAgent = null, Expression<Func<string>> bodyContent = null, Expression<Func<bodyPrivateInput>> bodyPrivate = null, string triggerName = null)
        {
            var apiCallPath = "/power_automate/tickets/add_note_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAgent != null)
            {
                body["Agent"] = ExpressionConverter.ConvertO(bodyAgent);
                bodypropCount++;
            }

            if (bodyContent != null)
            {
                body["Content"] = ExpressionConverter.ConvertO(bodyContent);
                bodypropCount++;
            }

            if (bodyPrivate != null)
            {
                body["Private"] = ExpressionConverter.ConvertO(bodyPrivate);
                bodypropCount++;
            }

            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger AddReplyWebhook(Expression<Func<string>> bodyContent = null, Expression<Func<bodyResponseTypeInput>> bodyResponseType = null, string triggerName = null)
        {
            var apiCallPath = "/power_automate/tickets/add_reply_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContent != null)
            {
                body["Content"] = ExpressionConverter.ConvertO(bodyContent);
                bodypropCount++;
            }

            if (bodyResponseType != null)
            {
                body["ResponseType"] = ExpressionConverter.ConvertO(bodyResponseType);
                bodypropCount++;
            }

            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class GetAllTicketsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("tickets")]
        public GetAllTicketsResponseTicketsTypeItem[] Tickets { get; set; }
    }

    public class GetAllTicketsResponseTicketsTypeItem
    {
        public int TicketNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string DescriptionText { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string Agent { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string ResolvedOn { get; set; }
        public string ClosedOn { get; set; }
    }

    public enum orderByInput
    {
        [EnumMember(Value = "created_time")]
        CreatedTime,
        [EnumMember(Value = "updated_time")]
        UpdatedTime
    }

    public enum orderTypeInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public enum includeDescriptionInput
    {
        Yes,
        No
    }

    public class GetTicketResponse
    {
        public string Agent { get; set; }
        public string Category { get; set; }
        public string ClosedOn { get; set; }
        public string ContactEmail { get; set; }
        public string CreatedOn { get; set; }
        public string Description { get; set; }
        public string DescriptionText { get; set; }
        public string Group { get; set; }
        public string Priority { get; set; }
        public string ResolvedOn { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string Subcategory { get; set; }
        public string Subject { get; set; }
        public int TicketNumber { get; set; }
        public string Type { get; set; }
        public string UpdatedOn { get; set; }
    }

    public class CreateTicketResponse
    {
        public string Agent { get; set; }
        public string Category { get; set; }
        public string ContactEmail { get; set; }
        public string CreatedOn { get; set; }
        public string Description { get; set; }
        public string DescriptionText { get; set; }
        public string Group { get; set; }
        public string Priority { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string Subcategory { get; set; }
        public string Subject { get; set; }
        public int TicketNumber { get; set; }
        public string Type { get; set; }
        public string UpdatedOn { get; set; }
        public string ResolvedOn { get; set; }
        public string ClosedOn { get; set; }
    }

    public enum bodyPriorityInput
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum bodyTypeInput
    {
        Question,
        Incident,
        Problem,
        Request
    }

    public class UpdateTicketResponse
    {
        public string Agent { get; set; }
        public string Category { get; set; }
        public string ClosedOn { get; set; }
        public string ContactEmail { get; set; }
        public string CreatedOn { get; set; }
        public string Description { get; set; }
        public string DescriptionText { get; set; }
        public string Group { get; set; }
        public string Priority { get; set; }
        public string ResolvedOn { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string Subcategory { get; set; }
        public string Subject { get; set; }
        public int TicketNumber { get; set; }
        public string Type { get; set; }

        [JsonProperty("Updated On")]
        public string UpdatedOn { get; set; }
    }

    public enum bodypriorityInput
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum bodytypeInput
    {
        Question,
        Incident,
        Problem,
        Request
    }

    public class AddNoteResponse
    {
        public int TicketNumber { get; set; }
        public string Content { get; set; }
        public string ContentText { get; set; }
        public string NotifiedAgents { get; set; }
        public string CreatedBy { get; set; }
        public string ContactEmail { get; set; }
        public string CreatedOn { get; set; }
        public string Private { get; set; }
    }

    public enum bodyPrivateInput
    {
        Yes,
        No
    }

    public enum bodyResponseTypeInput
    {
        Agent,
        Contact
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Desk365;

    public partial class WorkflowManagedActions
    {
        public Desk365Actions Desk365(string connectionId) => new Desk365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Desk365Triggers Desk365(string connectionId) => new Desk365Triggers(connectionId);
    }
}
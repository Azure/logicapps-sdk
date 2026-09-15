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
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            callPayload.Queries["order_by"] = Convert.ToString("created_time");
            if (orderBy != null)
                callPayload.Queries["order_by"] = CSharpExpressionConverter.Convert(orderBy);
            callPayload.Queries["order_type"] = Convert.ToString("desc");
            if (orderType != null)
                callPayload.Queries["order_type"] = CSharpExpressionConverter.Convert(orderType);
            callPayload.Queries["updated_since"] = Convert.ToString("");
            if (updatedSince != null)
                callPayload.Queries["updated_since"] = CSharpExpressionConverter.ConvertO(updatedSince);
            callPayload.Queries["include_description"] = Convert.ToString("No");
            if (includeDescription != null)
                callPayload.Queries["include_description"] = CSharpExpressionConverter.Convert(includeDescription);
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
                callPayload.Queries["ticket_number"] = CSharpExpressionConverter.ConvertO(ticketNumber);
            callPayload.Queries["src"] = Convert.ToString(2);
            return new ApiConnectionAction<GetTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket(Expression<Func<string>> bodyemail, Expression<Func<string>> bodydescription, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodycategory = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodytypeInput>> bodytype = null)
        {
            var apiCallPath = "/power_automate/tickets/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["src"] = Convert.ToString(2);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyagent != null)
            {
                body["Agent"] = CSharpExpressionConverter.ConvertToken(bodyagent);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            bodypropCount++;
            body["Subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
            if (bodytype != null)
            {
                body["Type"] = CSharpExpressionConverter.Convert(bodytype);
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
            callPayload.Queries["ticket_number"] = CSharpExpressionConverter.ConvertO(ticketNumber);
            callPayload.Queries["src"] = Convert.ToString(2);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.Convert(bodytype);
                bodypropCount++;
            }

            if (bodyassignTo != null)
            {
                body["assign_to"] = CSharpExpressionConverter.ConvertToken(bodyassignTo);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<AddNoteResponse> AddNote(Expression<Func<int>> ticketNumber, Expression<Func<string>> bodycontent, Expression<Func<string>> bodyagentEmail = null, Expression<Func<string>> bodynotifyAgent = null, Expression<Func<bodyprivateInput>> bodyprivate = null)
        {
            var apiCallPath = "/power_automate/tickets/add_note";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ticket_number"] = CSharpExpressionConverter.ConvertO(ticketNumber);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
            if (bodyagentEmail != null)
            {
                body["AgentEmail"] = CSharpExpressionConverter.ConvertToken(bodyagentEmail);
                bodypropCount++;
            }

            if (bodynotifyAgent != null)
            {
                body["NotifyAgent"] = CSharpExpressionConverter.ConvertToken(bodynotifyAgent);
                bodypropCount++;
            }

            if (bodyprivate != null)
            {
                if (bodyprivate != null)
                {
                    body["Private"] = CSharpExpressionConverter.Convert(bodyprivate);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["Private"] = "Yes";
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
        public IWorkflowTrigger CreateTicketWebhook(Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/power_automate/tickets/create_ticket_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactEmail != null)
            {
                body["ContactEmail"] = CSharpExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["Subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodyagent != null)
            {
                body["Agent"] = CSharpExpressionConverter.ConvertToken(bodyagent);
                bodypropCount++;
            }

            if (bodygroup != null)
            {
                body["Group"] = CSharpExpressionConverter.ConvertToken(bodygroup);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UpdateTicketWebhook(Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/power_automate/tickets/update_ticket_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactEmail != null)
            {
                body["ContactEmail"] = CSharpExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["Subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodyagent != null)
            {
                body["Agent"] = CSharpExpressionConverter.ConvertToken(bodyagent);
                bodypropCount++;
            }

            if (bodygroup != null)
            {
                body["Group"] = CSharpExpressionConverter.ConvertToken(bodygroup);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AddNoteWebhook(Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodycontent = null, Expression<Func<bodyprivateInput>> bodyprivate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/power_automate/tickets/add_note_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyagent != null)
            {
                body["Agent"] = CSharpExpressionConverter.ConvertToken(bodyagent);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["Content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodyprivate != null)
            {
                body["Private"] = CSharpExpressionConverter.Convert(bodyprivate);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AddReplyWebhook(Expression<Func<string>> bodycontent = null, Expression<Func<bodyresponseTypeInput>> bodyresponseType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/power_automate/tickets/add_reply_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontent != null)
            {
                body["Content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodyresponseType != null)
            {
                body["ResponseType"] = CSharpExpressionConverter.Convert(bodyresponseType);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public enum bodyprivateInput
    {
        Yes,
        No
    }

    public enum bodyresponseTypeInput
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
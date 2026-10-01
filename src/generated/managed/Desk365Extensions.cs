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
        public IBodyWorkflowAction<GetAllTicketsResponse> GetAllTickets([WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderTypeInput> orderType = null, [WorkflowExpression] Func<string> updatedSince = null, [WorkflowExpression] Func<includeDescriptionInput> includeDescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                callPayload.Queries["order_by"] = Convert.ToString("created_time");
                if (orderBy != null)
                    callPayload.Queries["order_by"] = SourceExpressionConverter.Convert(orderBy);
                callPayload.Queries["order_type"] = Convert.ToString("desc");
                if (orderType != null)
                    callPayload.Queries["order_type"] = SourceExpressionConverter.Convert(orderType);
                callPayload.Queries["updated_since"] = Convert.ToString("");
                if (updatedSince != null)
                    callPayload.Queries["updated_since"] = SourceExpressionConverter.ConvertO(updatedSince);
                callPayload.Queries["include_description"] = Convert.ToString("No");
                if (includeDescription != null)
                    callPayload.Queries["include_description"] = SourceExpressionConverter.Convert(includeDescription);
                callPayload.Queries["src"] = Convert.ToString(2);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllTicketsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket([WorkflowExpression] Func<int> ticketNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/details";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ticketNumber != null)
                    callPayload.Queries["ticket_number"] = SourceExpressionConverter.ConvertO(ticketNumber);
                callPayload.Queries["src"] = Convert.ToString(2);
                return callPayload;
            }

            return new ApiConnectionAction<GetTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodyagent = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["src"] = Convert.ToString(2);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyagent != null)
                {
                    body["Agent"] = SourceExpressionConverter.ConvertToken(bodyagent);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodytype != null)
                {
                    body["Type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<UpdateTicketResponse> UpdateTicket([WorkflowExpression] Func<int> ticketNumber, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodyassignTo = null, [WorkflowExpression] Func<string> bodycategory = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = SourceExpressionConverter.ConvertO(ticketNumber);
                callPayload.Queries["src"] = Convert.ToString(2);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyassignTo != null)
                {
                    body["assign_to"] = SourceExpressionConverter.ConvertToken(bodyassignTo);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<AddNoteResponse> AddNote([WorkflowExpression] Func<int> ticketNumber, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<string> bodyagentEmail = null, [WorkflowExpression] Func<string> bodynotifyAgent = null, [WorkflowExpression] Func<bodyPrivateInput> bodyPrivate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/add_note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = SourceExpressionConverter.ConvertO(ticketNumber);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                if (bodyagentEmail != null)
                {
                    body["AgentEmail"] = SourceExpressionConverter.ConvertToken(bodyagentEmail);
                    bodypropCount++;
                }

                if (bodynotifyAgent != null)
                {
                    body["NotifyAgent"] = SourceExpressionConverter.ConvertToken(bodynotifyAgent);
                    bodypropCount++;
                }

                if (bodyPrivate != null)
                {
                    if (bodyPrivate != null)
                    {
                        body["Private"] = SourceExpressionConverter.Convert(bodyPrivate);
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
                return callPayload;
            }

            return new ApiConnectionAction<AddNoteResponse>(BuildSourceInput);
        }
    }

    public class Desk365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTicketWebhook([WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyagent = null, [WorkflowExpression] Func<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/create_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactEmail != null)
                {
                    body["ContactEmail"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyagent != null)
                {
                    body["Agent"] = SourceExpressionConverter.ConvertToken(bodyagent);
                    bodypropCount++;
                }

                if (bodygroup != null)
                {
                    body["Group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UpdateTicketWebhook([WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyagent = null, [WorkflowExpression] Func<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/update_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactEmail != null)
                {
                    body["ContactEmail"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyagent != null)
                {
                    body["Agent"] = SourceExpressionConverter.ConvertToken(bodyagent);
                    bodypropCount++;
                }

                if (bodygroup != null)
                {
                    body["Group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AddNoteWebhook([WorkflowExpression] Func<string> bodyagent = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<bodyPrivateInput> bodyPrivate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/add_note_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyagent != null)
                {
                    body["Agent"] = SourceExpressionConverter.ConvertToken(bodyagent);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["Content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyPrivate != null)
                {
                    body["Private"] = SourceExpressionConverter.Convert(bodyPrivate);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AddReplyWebhook([WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<bodyresponseTypeInput> bodyresponseType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power_automate/tickets/add_reply_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["Content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyresponseType != null)
                {
                    body["ResponseType"] = SourceExpressionConverter.Convert(bodyresponseType);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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

    public enum bodyPrivateInput
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
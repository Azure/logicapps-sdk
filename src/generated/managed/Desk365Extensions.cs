//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Desk365
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Desk365Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllTickets))]
        public IBodyWorkflowAction<GetAllTicketsResponse> GetAllTickets([WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderTypeInput> orderType = null, [WorkflowExpression] Func<string> updatedSince = null, [WorkflowExpression] Func<includeDescriptionInput> includeDescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllTicketsResponse> __BuildGetAllTickets(WorkflowExpression<int> offset = null, WorkflowExpression<orderByInput> orderBy = null, WorkflowExpression<orderTypeInput> orderType = null, WorkflowExpression<string> updatedSince = null, WorkflowExpression<includeDescriptionInput> includeDescription = null)
        {
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            WorkflowExpression.Validate(orderType, nameof(orderType), required: false);
            WorkflowExpression.Validate(updatedSince, nameof(updatedSince), required: false);
            WorkflowExpression.Validate(includeDescription, nameof(includeDescription), required: false);
            return new DeferredBodyAction<GetAllTicketsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [WorkflowExpressionFactory(nameof(__BuildGetTicket))]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket([WorkflowExpression] Func<int> ticketNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTicketResponse> __BuildGetTicket(WorkflowExpression<int> ticketNumber = null)
        {
            WorkflowExpression.Validate(ticketNumber, nameof(ticketNumber), required: false);
            return new DeferredBodyAction<GetTicketResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/details";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ticketNumber != null)
                    callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(ticketNumber);
                callPayload.Queries["src"] = Convert.ToString(2);
                return new ApiConnectionAction<GetTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTicket))]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodyagent = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTicketResponse> __BuildCreateTicket(WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodydescription, WorkflowExpression<string> bodysubject, WorkflowExpression<string> bodyagent = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodytypeInput> bodytype = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowExpression.Validate(bodyagent, nameof(bodyagent), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<CreateTicketResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["src"] = Convert.ToString(2);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(bodyagent);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
                body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Subject"] = ExpressionConverter.ConvertO(bodysubject);
                if (bodytype != null)
                {
                    body["Type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTicket))]
        public IBodyWorkflowAction<UpdateTicketResponse> UpdateTicket([WorkflowExpression] Func<int> ticketNumber, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodyassignTo = null, [WorkflowExpression] Func<string> bodycategory = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateTicketResponse> __BuildUpdateTicket(WorkflowExpression<int> ticketNumber, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodypriorityInput> bodypriority = null, WorkflowExpression<bodytypeInput> bodytype = null, WorkflowExpression<string> bodyassignTo = null, WorkflowExpression<string> bodycategory = null)
        {
            WorkflowExpression.Validate(ticketNumber, nameof(ticketNumber), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyassignTo, nameof(bodyassignTo), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            return new DeferredBodyAction<UpdateTicketResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [WorkflowExpressionFactory(nameof(__BuildAddNote))]
        public IBodyWorkflowAction<AddNoteResponse> AddNote([WorkflowExpression] Func<int> ticketNumber, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<string> bodyagentEmail = null, [WorkflowExpression] Func<string> bodynotifyAgent = null, [WorkflowExpression] Func<bodyprivateInput> bodyprivate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddNoteResponse> __BuildAddNote(WorkflowExpression<int> ticketNumber, WorkflowExpression<string> bodycontent, WorkflowExpression<string> bodyagentEmail = null, WorkflowExpression<string> bodynotifyAgent = null, WorkflowExpression<bodyprivateInput> bodyprivate = null)
        {
            WorkflowExpression.Validate(ticketNumber, nameof(ticketNumber), required: true);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            WorkflowExpression.Validate(bodyagentEmail, nameof(bodyagentEmail), required: false);
            WorkflowExpression.Validate(bodynotifyAgent, nameof(bodynotifyAgent), required: false);
            WorkflowExpression.Validate(bodyprivate, nameof(bodyprivate), required: false);
            return new DeferredBodyAction<AddNoteResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(ticketNumber);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Content"] = ExpressionConverter.ConvertO(bodycontent);
                if (bodyagentEmail != null)
                {
                    body["AgentEmail"] = ExpressionConverter.ConvertO(bodyagentEmail);
                    bodypropCount++;
                }

                if (bodynotifyAgent != null)
                {
                    body["NotifyAgent"] = ExpressionConverter.ConvertO(bodynotifyAgent);
                    bodypropCount++;
                }

                if (bodyprivate != null)
                {
                    if (bodyprivate != null)
                    {
                        body["Private"] = ExpressionConverter.ConvertO(bodyprivate);
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
            });
        }
    }

    public class Desk365Triggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCreateTicketWebhook))]
        public IWorkflowTrigger CreateTicketWebhook([WorkflowExpression] Func<string> bodycontactEmail = null,[WorkflowExpression] Func<string> bodysubject = null,[WorkflowExpression] Func<string> bodystatus = null,[WorkflowExpression] Func<string> bodypriority = null,[WorkflowExpression] Func<string> bodyagent = null,[WorkflowExpression] Func<string> bodygroup = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateTicketWebhook(WorkflowExpression<string> bodycontactEmail = null,WorkflowExpression<string> bodysubject = null,WorkflowExpression<string> bodystatus = null,WorkflowExpression<string> bodypriority = null,WorkflowExpression<string> bodyagent = null,WorkflowExpression<string> bodygroup = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyagent, nameof(bodyagent), required: false);
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/create_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactEmail != null)
                {
                    body["ContactEmail"] = ExpressionConverter.ConvertO(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(bodyagent);
                    bodypropCount++;
                }

                if (bodygroup != null)
                {
                    body["Group"] = ExpressionConverter.ConvertO(bodygroup);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildUpdateTicketWebhook))]
        public IWorkflowTrigger UpdateTicketWebhook([WorkflowExpression] Func<string> bodycontactEmail = null,[WorkflowExpression] Func<string> bodysubject = null,[WorkflowExpression] Func<string> bodystatus = null,[WorkflowExpression] Func<string> bodypriority = null,[WorkflowExpression] Func<string> bodyagent = null,[WorkflowExpression] Func<string> bodygroup = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUpdateTicketWebhook(WorkflowExpression<string> bodycontactEmail = null,WorkflowExpression<string> bodysubject = null,WorkflowExpression<string> bodystatus = null,WorkflowExpression<string> bodypriority = null,WorkflowExpression<string> bodyagent = null,WorkflowExpression<string> bodygroup = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodycontactEmail, nameof(bodycontactEmail), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyagent, nameof(bodyagent), required: false);
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/update_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactEmail != null)
                {
                    body["ContactEmail"] = ExpressionConverter.ConvertO(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(bodyagent);
                    bodypropCount++;
                }

                if (bodygroup != null)
                {
                    body["Group"] = ExpressionConverter.ConvertO(bodygroup);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAddNoteWebhook))]
        public IWorkflowTrigger AddNoteWebhook([WorkflowExpression] Func<string> bodyagent = null,[WorkflowExpression] Func<string> bodycontent = null,[WorkflowExpression] Func<bodyprivateInput> bodyprivate = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAddNoteWebhook(WorkflowExpression<string> bodyagent = null,WorkflowExpression<string> bodycontent = null,WorkflowExpression<bodyprivateInput> bodyprivate = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyagent, nameof(bodyagent), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyprivate, nameof(bodyprivate), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_note_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(bodyagent);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["Content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyprivate != null)
                {
                    body["Private"] = ExpressionConverter.ConvertO(bodyprivate);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAddReplyWebhook))]
        public IWorkflowTrigger AddReplyWebhook([WorkflowExpression] Func<string> bodycontent = null,[WorkflowExpression] Func<bodyresponseTypeInput> bodyresponseType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAddReplyWebhook(WorkflowExpression<string> bodycontent = null,WorkflowExpression<bodyresponseTypeInput> bodyresponseType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyresponseType, nameof(bodyresponseType), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_reply_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["Content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyresponseType != null)
                {
                    body["ResponseType"] = ExpressionConverter.ConvertO(bodyresponseType);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
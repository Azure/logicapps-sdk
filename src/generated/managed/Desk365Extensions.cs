//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Desk365
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Desk365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<GetAllTicketsResponse> GetAllTickets(Expression<Func<int>> offset = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<orderTypeInput>> orderType = null, Expression<Func<string>> updatedSince = null, Expression<Func<includeDescriptionInput>> includeDescription = null)
        {
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_orderBy = orderBy == null ? null : WorkflowExpression.Compile(orderBy);
            WorkflowExpression.Validate(__workflow_orderBy, nameof(orderBy), required: false);
            var __workflow_orderType = orderType == null ? null : WorkflowExpression.Compile(orderType);
            WorkflowExpression.Validate(__workflow_orderType, nameof(orderType), required: false);
            var __workflow_updatedSince = updatedSince == null ? null : WorkflowExpression.Compile(updatedSince);
            WorkflowExpression.Validate(__workflow_updatedSince, nameof(updatedSince), required: false);
            var __workflow_includeDescription = includeDescription == null ? null : WorkflowExpression.Compile(includeDescription);
            WorkflowExpression.Validate(__workflow_includeDescription, nameof(includeDescription), required: false);
            return new DeferredBodyAction<GetAllTicketsResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("created_time");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["order_type"] = Convert.ToString("desc");
                if (__workflow_orderType != null)
                    callPayload.Queries["order_type"] = ExpressionConverter.Convert(__workflow_orderType);
                callPayload.Queries["updated_since"] = Convert.ToString("");
                if (__workflow_updatedSince != null)
                    callPayload.Queries["updated_since"] = ExpressionConverter.Convert(__workflow_updatedSince);
                callPayload.Queries["include_description"] = Convert.ToString("No");
                if (__workflow_includeDescription != null)
                    callPayload.Queries["include_description"] = ExpressionConverter.Convert(__workflow_includeDescription);
                callPayload.Queries["src"] = Convert.ToString(2);
                return new ApiConnectionAction<GetAllTicketsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket(Expression<Func<int>> ticketNumber = null)
        {
            var __workflow_ticketNumber = ticketNumber == null ? null : WorkflowExpression.Compile(ticketNumber);
            WorkflowExpression.Validate(__workflow_ticketNumber, nameof(ticketNumber), required: false);
            return new DeferredBodyAction<GetTicketResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/details";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ticketNumber != null)
                    callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(__workflow_ticketNumber);
                callPayload.Queries["src"] = Convert.ToString(2);
                return new ApiConnectionAction<GetTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket(Expression<Func<string>> bodyemail, Expression<Func<string>> bodydescription, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodycategory = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodytypeInput>> bodytype = null)
        {
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodyagent = bodyagent == null ? null : WorkflowExpression.Compile(bodyagent);
            WorkflowExpression.Validate(__workflow_bodyagent, nameof(bodyagent), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<CreateTicketResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["src"] = Convert.ToString(2);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(__workflow_bodyagent);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodytype != null)
                {
                    body["Type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
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
        public IBodyWorkflowAction<UpdateTicketResponse> UpdateTicket(Expression<Func<int>> ticketNumber, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyassignTo = null, Expression<Func<string>> bodycategory = null)
        {
            var __workflow_ticketNumber = ticketNumber == null ? null : WorkflowExpression.Compile(ticketNumber);
            WorkflowExpression.Validate(__workflow_ticketNumber, nameof(ticketNumber), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodyassignTo = bodyassignTo == null ? null : WorkflowExpression.Compile(bodyassignTo);
            WorkflowExpression.Validate(__workflow_bodyassignTo, nameof(bodyassignTo), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            return new DeferredBodyAction<UpdateTicketResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(__workflow_ticketNumber);
                callPayload.Queries["src"] = Convert.ToString(2);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyassignTo != null)
                {
                    body["assign_to"] = ExpressionConverter.ConvertO(__workflow_bodyassignTo);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
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
        public IBodyWorkflowAction<AddNoteResponse> AddNote(Expression<Func<int>> ticketNumber, Expression<Func<string>> bodycontent, Expression<Func<string>> bodyagentEmail = null, Expression<Func<string>> bodynotifyAgent = null, Expression<Func<bodyprivateInput>> bodyprivate = null)
        {
            var __workflow_ticketNumber = ticketNumber == null ? null : WorkflowExpression.Compile(ticketNumber);
            WorkflowExpression.Validate(__workflow_ticketNumber, nameof(ticketNumber), required: true);
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: true);
            var __workflow_bodyagentEmail = bodyagentEmail == null ? null : WorkflowExpression.Compile(bodyagentEmail);
            WorkflowExpression.Validate(__workflow_bodyagentEmail, nameof(bodyagentEmail), required: false);
            var __workflow_bodynotifyAgent = bodynotifyAgent == null ? null : WorkflowExpression.Compile(bodynotifyAgent);
            WorkflowExpression.Validate(__workflow_bodynotifyAgent, nameof(bodynotifyAgent), required: false);
            var __workflow_bodyprivate = bodyprivate == null ? null : WorkflowExpression.Compile(bodyprivate);
            WorkflowExpression.Validate(__workflow_bodyprivate, nameof(bodyprivate), required: false);
            return new DeferredBodyAction<AddNoteResponse>(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(__workflow_ticketNumber);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                if (__workflow_bodyagentEmail != null)
                {
                    body["AgentEmail"] = ExpressionConverter.ConvertO(__workflow_bodyagentEmail);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyAgent != null)
                {
                    body["NotifyAgent"] = ExpressionConverter.ConvertO(__workflow_bodynotifyAgent);
                    bodypropCount++;
                }

                if (__workflow_bodyprivate != null)
                {
                    if (__workflow_bodyprivate != null)
                    {
                        body["Private"] = ExpressionConverter.ConvertO(__workflow_bodyprivate);
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
        public IWorkflowTrigger CreateTicketWebhook(Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodygroup = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycontactEmail = bodycontactEmail == null ? null : WorkflowExpression.Compile(bodycontactEmail);
            WorkflowExpression.Validate(__workflow_bodycontactEmail, nameof(bodycontactEmail), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyagent = bodyagent == null ? null : WorkflowExpression.Compile(bodyagent);
            WorkflowExpression.Validate(__workflow_bodyagent, nameof(bodyagent), required: false);
            var __workflow_bodygroup = bodygroup == null ? null : WorkflowExpression.Compile(bodygroup);
            WorkflowExpression.Validate(__workflow_bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/create_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontactEmail != null)
                {
                    body["ContactEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(__workflow_bodyagent);
                    bodypropCount++;
                }

                if (__workflow_bodygroup != null)
                {
                    body["Group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
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

        public IWorkflowTrigger UpdateTicketWebhook(Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodygroup = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycontactEmail = bodycontactEmail == null ? null : WorkflowExpression.Compile(bodycontactEmail);
            WorkflowExpression.Validate(__workflow_bodycontactEmail, nameof(bodycontactEmail), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyagent = bodyagent == null ? null : WorkflowExpression.Compile(bodyagent);
            WorkflowExpression.Validate(__workflow_bodyagent, nameof(bodyagent), required: false);
            var __workflow_bodygroup = bodygroup == null ? null : WorkflowExpression.Compile(bodygroup);
            WorkflowExpression.Validate(__workflow_bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/update_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontactEmail != null)
                {
                    body["ContactEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(__workflow_bodyagent);
                    bodypropCount++;
                }

                if (__workflow_bodygroup != null)
                {
                    body["Group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
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

        public IWorkflowTrigger AddNoteWebhook(Expression<Func<string>> bodyagent = null, Expression<Func<string>> bodycontent = null, Expression<Func<bodyprivateInput>> bodyprivate = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyagent = bodyagent == null ? null : WorkflowExpression.Compile(bodyagent);
            WorkflowExpression.Validate(__workflow_bodyagent, nameof(bodyagent), required: false);
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyprivate = bodyprivate == null ? null : WorkflowExpression.Compile(bodyprivate);
            WorkflowExpression.Validate(__workflow_bodyprivate, nameof(bodyprivate), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_note_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyagent != null)
                {
                    body["Agent"] = ExpressionConverter.ConvertO(__workflow_bodyagent);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["Content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyprivate != null)
                {
                    body["Private"] = ExpressionConverter.ConvertO(__workflow_bodyprivate);
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

        public IWorkflowTrigger AddReplyWebhook(Expression<Func<string>> bodycontent = null, Expression<Func<bodyresponseTypeInput>> bodyresponseType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyresponseType = bodyresponseType == null ? null : WorkflowExpression.Compile(bodyresponseType);
            WorkflowExpression.Validate(__workflow_bodyresponseType, nameof(bodyresponseType), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_reply_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["Content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseType != null)
                {
                    body["ResponseType"] = ExpressionConverter.ConvertO(__workflow_bodyresponseType);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderByInput
    {
        [EnumMember(Value = "created_time")]
        CreatedTime,
        [EnumMember(Value = "updated_time")]
        UpdatedTime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderTypeInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypriorityInput
    {
        Low,
        Medium,
        High,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyprivateInput
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Desk365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Desk365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<GetAllTicketsResponse, ApiConnectionActionConfiguration> GetAllTickets(Expression<Func<int>> offset = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<orderTypeInput>> orderType = null, Expression<Func<string>> updatedSince = null, Expression<Func<includeDescriptionInput>> includeDescription = null)
        {
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_orderType = WorkflowExpression.Compile(orderType, nameof(orderType), required: false);
            var __workflow_updatedSince = WorkflowExpression.Compile(updatedSince, nameof(updatedSince), required: false);
            var __workflow_includeDescription = WorkflowExpression.Compile(includeDescription, nameof(includeDescription), required: false);
            return new DeferredBodyAction<GetAllTicketsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetTicketResponse, ApiConnectionActionConfiguration> GetTicket(Expression<Func<int>> ticketNumber = null)
        {
            var __workflow_ticketNumber = WorkflowExpression.Compile(ticketNumber, nameof(ticketNumber), required: false);
            return new DeferredBodyAction<GetTicketResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateTicketResponse, ApiConnectionActionConfiguration> CreateTicket(Expression<Func<CreateTicketInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTicketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["src"] = Convert.ToString(2);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<UpdateTicketResponse, ApiConnectionActionConfiguration> UpdateTicket(Expression<Func<int>> ticketNumber, Expression<Func<UpdateTicketInput>> body = null)
        {
            var __workflow_ticketNumber = WorkflowExpression.Compile(ticketNumber, nameof(ticketNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateTicketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(__workflow_ticketNumber);
                callPayload.Queries["src"] = Convert.ToString(2);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "desk365")]
        public IBodyWorkflowAction<AddNoteResponse, ApiConnectionActionConfiguration> AddNote(Expression<Func<int>> ticketNumber, Expression<Func<AddNoteInput>> body = null)
        {
            var __workflow_ticketNumber = WorkflowExpression.Compile(ticketNumber, nameof(ticketNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ticket_number"] = ExpressionConverter.Convert(__workflow_ticketNumber);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddNoteResponse>(callPayload);
            });
        }
    }

    public class Desk365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateTicketWebhook(Expression<Func<CreateTicketWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/create_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UpdateTicketWebhook(Expression<Func<UpdateTicketWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/update_ticket_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddNoteWebhook(Expression<Func<AddNoteWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_note_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddReplyWebhook(Expression<Func<AddReplyWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/power_automate/tickets/add_reply_webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateTicketInput
    {
        public string Agent { get; set; }
        public string Category { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }
        public CreateTicketInputPriorityType? Priority { get; set; }
        public string Status { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }
        public CreateTicketInputTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketInputPriorityType
    {
        Low,
        Medium,
        High,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketInputTypeType
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

    public class UpdateTicketInput
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public UpdateTicketInputPriorityType? Priority { get; set; }

        [JsonProperty("type")]
        public UpdateTicketInputTypeType? Type { get; set; }

        [JsonProperty("assign_to")]
        public string AssignTo { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketInputPriorityType
    {
        Low,
        Medium,
        High,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketInputTypeType
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

    public class AddNoteInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
        public string AgentEmail { get; set; }
        public string NotifyAgent { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AddNoteInputPrivateType? Private { get; set; } = AddNoteInputPrivateType.Yes;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddNoteInputPrivateType
    {
        Yes,
        No
    }

    public class CreateTicketWebhookInput
    {
        public string ContactEmail { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Agent { get; set; }
        public string Group { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class UpdateTicketWebhookInput
    {
        public string ContactEmail { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Agent { get; set; }
        public string Group { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class AddNoteWebhookInput
    {
        public string Agent { get; set; }
        public string Content { get; set; }
        public AddNoteWebhookInputPrivateType? Private { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddNoteWebhookInputPrivateType
    {
        Yes,
        No
    }

    public class AddReplyWebhookInput
    {
        public string Content { get; set; }
        public AddReplyWebhookInputResponseTypeType? ResponseType { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddReplyWebhookInputResponseTypeType
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
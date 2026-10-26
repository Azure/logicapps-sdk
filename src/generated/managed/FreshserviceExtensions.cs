//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freshservice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreshserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<AddNoteResponseV2, ApiConnectionActionConfiguration> AddNote(Expression<Func<int>> ticketId, Expression<Func<AddNoteV2Input>> body)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddNoteResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/tickets/{0}/notes", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddNoteResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration> CreateTicket(Expression<Func<CreateTicketV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateTicketResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration> UpdateTicket(Expression<Func<int>> ticketId, Expression<Func<UpdateTicketV2Input>> body)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateTicketResponseV2>(callPayload);
            });
        }
    }

    public class FreshserviceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTicketResponseV2[], ApiConnectionTriggerConfiguration> OnTicketCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListTicketResponseV2[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/v2/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListTicketResponseV2[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddNoteResponseV2
    {
        [JsonProperty("conversation")]
        public AddNoteResponseV2ConversationType Conversation { get; set; }
    }

    public class AddNoteResponseV2ConversationType
    {
        [JsonProperty("created_at")]
        public string CreatedAtDateTime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAtDateTime { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("body_text")]
        public string Body { get; set; }

        [JsonProperty("body")]
        public string BodyHTML { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }
    }

    public class AddNoteV2Input
    {
        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Note { get; set; }

        [JsonProperty("private")]
        public bool? IsPrivate { get; set; }
    }

    public class CreateUpdateTicketResponseV2
    {
        [JsonProperty("ticket")]
        public CreateUpdateTicketResponseV2TicketType Ticket { get; set; }
    }

    public class CreateUpdateTicketResponseV2TicketType
    {
        [JsonProperty("created_at")]
        public string CreatedAtDateTime { get; set; }

        [JsonProperty("department_id")]
        public int DepartmentId { get; set; }

        [JsonProperty("due_by")]
        public string DueByDateTime { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("requester_id")]
        public int RequesterId { get; set; }

        [JsonProperty("responder_id")]
        public int ResponderId { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("spam")]
        public bool Spam { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("type")]
        public string TicketType { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAtDateTime { get; set; }

        [JsonProperty("description_text")]
        public string Description { get; set; }

        [JsonProperty("description")]
        public string DescriptionHTML { get; set; }

        [JsonProperty("to_emails")]
        public string[] ToEmails { get; set; }
    }

    public class CreateTicketV2Input
    {
        [JsonProperty("requester_id")]
        public int? RequesterId { get; set; }

        [JsonProperty("email")]
        public string RequesterEmail { get; set; }

        [JsonProperty("phone")]
        public string RequesterPhone { get; set; }

        [JsonProperty("name")]
        public string RequesterName { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTicketV2InputStatusType Status { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTicketV2InputPriorityType Priority { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("urgency")]
        public CreateTicketV2InputUrgencyType? Urgency { get; set; }

        [JsonProperty("impact")]
        public CreateTicketV2InputImpactType? Impact { get; set; }

        [JsonProperty("source")]
        public CreateTicketV2InputSourceType? Source { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketV2InputStatusType
    {
        Open,
        Pending,
        Resolved,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketV2InputPriorityType
    {
        Low,
        Medium,
        High,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketV2InputUrgencyType
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketV2InputImpactType
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTicketV2InputSourceType
    {
        Email,
        Portal,
        Phone,
        Chat
    }

    public class UpdateTicketV2Input
    {
        [JsonProperty("requester_id")]
        public int? RequesterId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("status")]
        public UpdateTicketV2InputStatusType? Status { get; set; }

        [JsonProperty("priority")]
        public UpdateTicketV2InputPriorityType? Priority { get; set; }

        [JsonProperty("urgency")]
        public UpdateTicketV2InputUrgencyType? Urgency { get; set; }

        [JsonProperty("impact")]
        public UpdateTicketV2InputImpactType? Impact { get; set; }

        [JsonProperty("source")]
        public UpdateTicketV2InputSourceType? Source { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketV2InputStatusType
    {
        Open,
        Pending,
        Resolved,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketV2InputPriorityType
    {
        Low,
        Medium,
        High,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketV2InputUrgencyType
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketV2InputImpactType
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTicketV2InputSourceType
    {
        Email,
        Portal,
        Phone,
        Chat
    }

    public class ListTicketResponseV2
    {
        [JsonProperty("created_at")]
        public string CreatedAtDateTime { get; set; }

        [JsonProperty("department_id")]
        public int DepartmentId { get; set; }

        [JsonProperty("due_by")]
        public string DueByDateTime { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("requester_id")]
        public int RequesterId { get; set; }

        [JsonProperty("responder_id")]
        public int ResponderId { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("spam")]
        public bool Spam { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("type")]
        public string TicketType { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAtDateTime { get; set; }

        [JsonProperty("description_text")]
        public string Description { get; set; }

        [JsonProperty("description")]
        public string DescriptionHTML { get; set; }

        [JsonProperty("to_emails")]
        public string[] ToEmails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Freshservice;

    public partial class WorkflowManagedActions
    {
        public FreshserviceActions Freshservice(string connectionId) => new FreshserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FreshserviceTriggers Freshservice(string connectionId) => new FreshserviceTriggers(connectionId);
    }
}
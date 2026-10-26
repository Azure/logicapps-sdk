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
        public IBodyWorkflowAction<AddNoteResponseV2, ApiConnectionActionConfiguration> AddNote(Expression<Func<int>> ticketId, Expression<Func<string>> bodynote, Expression<Func<bool>> bodyisPrivate = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: true);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            return new DeferredBodyAction<AddNoteResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/tickets/{0}/notes", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                if (__workflow_bodyisPrivate != null)
                {
                    body["private"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddNoteResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration> CreateTicket(Expression<Func<string>> bodysubject, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<string>> bodydescription, Expression<Func<int>> bodyrequesterId = null, Expression<Func<string>> bodyrequesterEmail = null, Expression<Func<string>> bodyrequesterPhone = null, Expression<Func<string>> bodyrequesterName = null, Expression<Func<bodyurgencyInput>> bodyurgency = null, Expression<Func<bodyimpactInput>> bodyimpact = null, Expression<Func<bodysourceInput>> bodysource = null)
        {
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyrequesterId = WorkflowExpression.Compile(bodyrequesterId, nameof(bodyrequesterId), required: false);
            var __workflow_bodyrequesterEmail = WorkflowExpression.Compile(bodyrequesterEmail, nameof(bodyrequesterEmail), required: false);
            var __workflow_bodyrequesterPhone = WorkflowExpression.Compile(bodyrequesterPhone, nameof(bodyrequesterPhone), required: false);
            var __workflow_bodyrequesterName = WorkflowExpression.Compile(bodyrequesterName, nameof(bodyrequesterName), required: false);
            var __workflow_bodyurgency = WorkflowExpression.Compile(bodyurgency, nameof(bodyurgency), required: false);
            var __workflow_bodyimpact = WorkflowExpression.Compile(bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            return new DeferredBodyAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequesterId != null)
                {
                    body["requester_id"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterId);
                    bodypropCount++;
                }

                if (__workflow_bodyrequesterEmail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyrequesterPhone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyrequesterName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                bodypropCount++;
                body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (__workflow_bodyurgency != null)
                {
                    body["urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUpdateTicketResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration> UpdateTicket(Expression<Func<int>> ticketId, Expression<Func<int>> bodyrequesterId = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<bodyurgencyInput>> bodyurgency = null, Expression<Func<bodyimpactInput>> bodyimpact = null, Expression<Func<bodysourceInput>> bodysource = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_bodyrequesterId = WorkflowExpression.Compile(bodyrequesterId, nameof(bodyrequesterId), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyurgency = WorkflowExpression.Compile(bodyurgency, nameof(bodyurgency), required: false);
            var __workflow_bodyimpact = WorkflowExpression.Compile(bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            return new DeferredBodyAction<CreateUpdateTicketResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequesterId != null)
                {
                    body["requester_id"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterId);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
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

                if (__workflow_bodyurgency != null)
                {
                    body["urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Open,
        Pending,
        Resolved,
        Closed
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
    public enum bodyurgencyInput
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyimpactInput
    {
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysourceInput
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
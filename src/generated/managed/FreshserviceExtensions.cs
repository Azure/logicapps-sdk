//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freshservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreshserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2> CreateTicketV2(Expression<Func<string>> bodysubject, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<bodypriorityInput>> bodypriority, Expression<Func<string>> bodydescription, Expression<Func<int>> bodyrequesterId = null, Expression<Func<string>> bodyrequesterEmail = null, Expression<Func<string>> bodyrequesterPhone = null, Expression<Func<string>> bodyrequesterName = null, Expression<Func<bodyurgencyInput>> bodyurgency = null, Expression<Func<bodyimpactInput>> bodyimpact = null, Expression<Func<bodysourceInput>> bodysource = null)
        {
            var apiCallPath = "/api/v2/tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequesterId != null)
            {
                body["requester_id"] = ExpressionConverter.ConvertO(bodyrequesterId);
                bodypropCount++;
            }

            if (bodyrequesterEmail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyrequesterEmail);
                bodypropCount++;
            }

            if (bodyrequesterPhone != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyrequesterPhone);
                bodypropCount++;
            }

            if (bodyrequesterName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyrequesterName);
                bodypropCount++;
            }

            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            bodypropCount++;
            body["priority"] = ExpressionConverter.ConvertO(bodypriority);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            if (bodyurgency != null)
            {
                body["urgency"] = ExpressionConverter.ConvertO(bodyurgency);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUpdateTicketResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2> UpdateTicketV2(Expression<Func<int>> ticketId, Expression<Func<int>> bodyrequesterId = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<bodyurgencyInput>> bodyurgency = null, Expression<Func<bodyimpactInput>> bodyimpact = null, Expression<Func<bodysourceInput>> bodysource = null)
        {
            var apiCallPath = String.Format("/api/v2/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequesterId != null)
            {
                body["requester_id"] = ExpressionConverter.ConvertO(bodyrequesterId);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
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

            if (bodyurgency != null)
            {
                body["urgency"] = ExpressionConverter.ConvertO(bodyurgency);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUpdateTicketResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<AddNoteResponseV2> AddNoteV2(Expression<Func<int>> ticketId, Expression<Func<string>> bodynote, Expression<Func<bool>> bodyisPrivate = null)
        {
            var apiCallPath = String.Format("/api/v2/tickets/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodynote);
            if (bodyisPrivate != null)
            {
                body["private"] = ExpressionConverter.ConvertO(bodyisPrivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddNoteResponseV2>(callPayload);
        }
    }

    public class FreshserviceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTicketResponseV2[]> OnTicketCreatedV2(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/api/v2/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListTicketResponseV2[]>(callPayload, triggerName, recurrence);
        }
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

    public enum bodystatusInput
    {
        Open,
        Pending,
        Resolved,
        Closed
    }

    public enum bodypriorityInput
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum bodyurgencyInput
    {
        Low,
        Medium,
        High
    }

    public enum bodyimpactInput
    {
        Low,
        Medium,
        High
    }

    public enum bodysourceInput
    {
        Email,
        Portal,
        Phone,
        Chat
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
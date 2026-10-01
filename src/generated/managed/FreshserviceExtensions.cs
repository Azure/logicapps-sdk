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
        public IBodyWorkflowAction<AddNoteResponseV2> AddNote([WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<string> bodynote, [WorkflowExpression] Func<bool> bodyisPrivate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/tickets/{0}/notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodynote);
                if (bodyisPrivate != null)
                {
                    body["private"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddNoteResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2> CreateTicket([WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<bodypriorityInput> bodypriority, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<int> bodyrequesterId = null, [WorkflowExpression] Func<string> bodyrequesterEmail = null, [WorkflowExpression] Func<string> bodyrequesterPhone = null, [WorkflowExpression] Func<string> bodyrequesterName = null, [WorkflowExpression] Func<bodyurgencyInput> bodyurgency = null, [WorkflowExpression] Func<bodyimpactInput> bodyimpact = null, [WorkflowExpression] Func<bodysourceInput> bodysource = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequesterId != null)
                {
                    body["requester_id"] = SourceExpressionConverter.ConvertToken(bodyrequesterId);
                    bodypropCount++;
                }

                if (bodyrequesterEmail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyrequesterEmail);
                    bodypropCount++;
                }

                if (bodyrequesterPhone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyrequesterPhone);
                    bodypropCount++;
                }

                if (bodyrequesterName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyrequesterName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                bodypropCount++;
                body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodyurgency != null)
                {
                    body["urgency"] = SourceExpressionConverter.Convert(bodyurgency);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["impact"] = SourceExpressionConverter.Convert(bodyimpact);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.Convert(bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUpdateTicketResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshservice")]
        public IBodyWorkflowAction<CreateUpdateTicketResponseV2> UpdateTicket([WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<int> bodyrequesterId = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<bodyurgencyInput> bodyurgency = null, [WorkflowExpression] Func<bodyimpactInput> bodyimpact = null, [WorkflowExpression] Func<bodysourceInput> bodysource = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequesterId != null)
                {
                    body["requester_id"] = SourceExpressionConverter.ConvertToken(bodyrequesterId);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodyurgency != null)
                {
                    body["urgency"] = SourceExpressionConverter.Convert(bodyurgency);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["impact"] = SourceExpressionConverter.Convert(bodyimpact);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.Convert(bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUpdateTicketResponseV2>(BuildSourceInput);
        }
    }

    public class FreshserviceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTicketResponseV2[]> OnTicketCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/v2/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTicketResponseV2[]>(BuildSourceInput, triggerName, recurrence);
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
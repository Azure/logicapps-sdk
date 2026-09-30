//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livechat
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LivechatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<ListAgentsResponseItem[]> ListAgents()
        {
            var apiCallPath = "/agents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAgentsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<CreateAgentResponse> CreateAgent([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyloginStatusInput> bodyloginStatus = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodypermissionInput> bodypermission = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodymaxChatCounts = null)
        {
            var apiCallPath = "/agents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["login"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyloginStatus != null)
            {
                body["login_status"] = ExpressionConverter.ConvertO(bodyloginStatus);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["job_title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypermission != null)
            {
                body["permission"] = ExpressionConverter.ConvertO(bodypermission);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodymaxChatCounts != null)
            {
                body["max_chats_count"] = ExpressionConverter.ConvertO(bodymaxChatCounts);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<DeleteAgentResponse> DeleteAgent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> login)
        {
            var apiCallPath = String.Format("/agents/{0}", ExpressionConverter.ConvertWithUrlEncoding(login, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<ListTicketsResponseItem[]> ListTickets()
        {
            var apiCallPath = "/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTicketsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<TicketResponse> CreateTicket([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodyrequesterrequesterSEmail = null, [WorkflowExpression] Func<string> bodyrequesterrequesterSName = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyassigneeassigneeId = null, [WorkflowExpression] Func<bodysourcesourceTypeInput> bodysourcesourceType = null, [WorkflowExpression] Func<string> bodysourcesourceURL = null)
        {
            var apiCallPath = "/tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            if (bodyrequesterrequesterSEmail != null)
            {
                requesterObject["mail"] = ExpressionConverter.ConvertO(bodyrequesterrequesterSEmail);
                requesterObjectpropCount++;
            }

            if (bodyrequesterrequesterSName != null)
            {
                requesterObject["name"] = ExpressionConverter.ConvertO(bodyrequesterrequesterSName);
                requesterObjectpropCount++;
            }

            if (requesterObjectpropCount > 0)
            {
                body["requester"] = requesterObject;
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            var assigneeObject = new JObject();
            var assigneeObjectpropCount = 0;
            if (bodyassigneeassigneeId != null)
            {
                assigneeObject["id"] = ExpressionConverter.ConvertO(bodyassigneeassigneeId);
                assigneeObjectpropCount++;
            }

            if (assigneeObjectpropCount > 0)
            {
                body["assignee"] = assigneeObject;
                bodypropCount++;
            }

            var sourceObject = new JObject();
            var sourceObjectpropCount = 0;
            if (bodysourcesourceType != null)
            {
                sourceObject["type"] = ExpressionConverter.ConvertO(bodysourcesourceType);
                sourceObjectpropCount++;
            }

            if (bodysourcesourceURL != null)
            {
                sourceObject["url"] = ExpressionConverter.ConvertO(bodysourcesourceURL);
                sourceObjectpropCount++;
            }

            if (sourceObjectpropCount > 0)
            {
                body["source"] = sourceObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<TicketResponse> UpdateTicket([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> ticketId, [WorkflowExpression] Func<string> bodyrequesterrequesterSEmail, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodyrequesterrequesterSName = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyassigneeassigneeId = null, [WorkflowExpression] Func<bodysourcesourceTypeInput> bodysourcesourceType = null, [WorkflowExpression] Func<string> bodysourcesourceURL = null)
        {
            var apiCallPath = String.Format("/tickets/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            requesterObjectpropCount++;
            requesterObject["mail"] = ExpressionConverter.ConvertO(bodyrequesterrequesterSEmail);
            if (bodyrequesterrequesterSName != null)
            {
                requesterObject["name"] = ExpressionConverter.ConvertO(bodyrequesterrequesterSName);
                requesterObjectpropCount++;
            }

            if (requesterObjectpropCount > 0)
            {
                body["requester"] = requesterObject;
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            var assigneeObject = new JObject();
            var assigneeObjectpropCount = 0;
            if (bodyassigneeassigneeId != null)
            {
                assigneeObject["id"] = ExpressionConverter.ConvertO(bodyassigneeassigneeId);
                assigneeObjectpropCount++;
            }

            if (assigneeObjectpropCount > 0)
            {
                body["assignee"] = assigneeObject;
                bodypropCount++;
            }

            var sourceObject = new JObject();
            var sourceObjectpropCount = 0;
            if (bodysourcesourceType != null)
            {
                sourceObject["type"] = ExpressionConverter.ConvertO(bodysourcesourceType);
                sourceObjectpropCount++;
            }

            if (bodysourcesourceURL != null)
            {
                sourceObject["url"] = ExpressionConverter.ConvertO(bodysourcesourceURL);
                sourceObjectpropCount++;
            }

            if (sourceObjectpropCount > 0)
            {
                body["source"] = sourceObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<TicketResponse> GetTicket([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> ticketId)
        {
            var apiCallPath = String.Format("/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TicketResponse>(callPayload);
        }
    }

    public class LivechatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTicketCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/ticket_created_webhook/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["event_type"] = Convert.ToString("ticket_created");
            callPayload.Queries["data_types[]"] = Convert.ToString("ticket");
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookChatStarted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/chat_starts_webhook/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["event_type"] = Convert.ToString("chat_started");
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookChatEnded(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/chat_ends_webhook/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["event_type"] = Convert.ToString("chat_ended");
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class ListAgentsResponseItem
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("login")]
        public string LoginEmail { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }
    }

    public class CreateAgentResponse
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("groups")]
        public CreateAgentResponseGroupsArrayTypeItem[] GroupsArray { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("license_id")]
        public JToken LicenseId { get; set; }

        [JsonProperty("login")]
        public string Email { get; set; }

        [JsonProperty("login_status")]
        public string LoginStatus { get; set; }

        [JsonProperty("max_chats_count")]
        public int MaxChatCounts { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateAgentResponseGroupsArrayTypeItem
    {
        [JsonProperty("id")]
        public int GroupId { get; set; }

        [JsonProperty("name")]
        public string GroupName { get; set; }
    }

    public enum bodyloginStatusInput
    {
        [EnumMember(Value = "accepting chats")]
        AcceptingChats,
        [EnumMember(Value = "not accepting chats")]
        NotAcceptingChats
    }

    public enum bodypermissionInput
    {
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "normal")]
        Normal
    }

    public class DeleteAgentResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class ListTicketsResponseItem
    {
        [JsonProperty("date")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("id")]
        public string TicketId { get; set; }

        [JsonProperty("modified")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("requester")]
        public ListTicketsResponseItemRequesterType Requester { get; set; }

        [JsonProperty("source")]
        public ListTicketsResponseItemSourceType Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class ListTicketsResponseItemRequesterType
    {
        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListTicketsResponseItemSourceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class TicketResponse
    {
        [JsonProperty("groups")]
        public TicketResponseGroupTypeItem[] Group { get; set; }

        [JsonProperty("date")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("events")]
        public TicketResponseEventsTypeItem[] Events { get; set; }

        [JsonProperty("id")]
        public string TicketId { get; set; }

        [JsonProperty("requester")]
        public TicketResponseRequesterType Requester { get; set; }

        [JsonProperty("source")]
        public TicketResponseSourceType Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class TicketResponseGroupTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TicketResponseEventsTypeItem
    {
        [JsonProperty("author")]
        public TicketResponseEventsTypeItemAuthorType Author { get; set; }

        [JsonProperty("date")]
        public string EventDateTime { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("source")]
        public TicketResponseEventsTypeItemSourceType Source { get; set; }

        [JsonProperty("type")]
        public string EventType { get; set; }
    }

    public class TicketResponseEventsTypeItemAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TicketResponseEventsTypeItemSourceType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class TicketResponseRequesterType
    {
        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TicketResponseSourceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public enum bodysourcesourceTypeInput
    {
        [EnumMember(Value = "chat-window")]
        ChatWindow,
        [EnumMember(Value = "mail")]
        Mail,
        [EnumMember(Value = "lc2")]
        Lc2
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Livechat;

    public partial class WorkflowManagedActions
    {
        public LivechatActions Livechat(string connectionId) => new LivechatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LivechatTriggers Livechat(string connectionId) => new LivechatTriggers(connectionId);
    }
}
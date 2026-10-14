//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livechat
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<CreateAgentResponse> CreateAgent(Expression<Func<string>> bodyemail, Expression<Func<string>> bodyname, Expression<Func<bodyloginStatusInput>> bodyloginStatus = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodypermissionInput>> bodypermission = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodymaxChatCounts = null)
        {
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyloginStatus = bodyloginStatus == null ? null : WorkflowExpression.Compile(bodyloginStatus);
            WorkflowExpression.Validate(__workflow_bodyloginStatus, nameof(bodyloginStatus), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodypermission = bodypermission == null ? null : WorkflowExpression.Compile(bodypermission);
            WorkflowExpression.Validate(__workflow_bodypermission, nameof(bodypermission), required: false);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodymaxChatCounts = bodymaxChatCounts == null ? null : WorkflowExpression.Compile(bodymaxChatCounts);
            WorkflowExpression.Validate(__workflow_bodymaxChatCounts, nameof(bodymaxChatCounts), required: false);
            return new DeferredBodyAction<CreateAgentResponse>(() =>
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["login"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyloginStatus != null)
                {
                    body["login_status"] = ExpressionConverter.ConvertO(__workflow_bodyloginStatus);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodypermission != null)
                {
                    body["permission"] = ExpressionConverter.ConvertO(__workflow_bodypermission);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodymaxChatCounts != null)
                {
                    body["max_chats_count"] = ExpressionConverter.ConvertO(__workflow_bodymaxChatCounts);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<DeleteAgentResponse> DeleteAgent(Expression<Func<string>> login)
        {
            var __workflow_login = login == null ? null : WorkflowExpression.Compile(login);
            WorkflowExpression.Validate(__workflow_login, nameof(login), required: true);
            return new DeferredBodyAction<DeleteAgentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/agents/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_login, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteAgentResponse>(callPayload);
            });
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
        public IBodyWorkflowAction<TicketResponse> CreateTicket(Expression<Func<string>> bodymessage, Expression<Func<string>> bodyrequesterrequesterSEmail = null, Expression<Func<string>> bodyrequesterrequesterSName = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodyassigneeassigneeId = null, Expression<Func<bodysourcesourceTypeInput>> bodysourcesourceType = null, Expression<Func<string>> bodysourcesourceURL = null)
        {
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyrequesterrequesterSEmail = bodyrequesterrequesterSEmail == null ? null : WorkflowExpression.Compile(bodyrequesterrequesterSEmail);
            WorkflowExpression.Validate(__workflow_bodyrequesterrequesterSEmail, nameof(bodyrequesterrequesterSEmail), required: false);
            var __workflow_bodyrequesterrequesterSName = bodyrequesterrequesterSName == null ? null : WorkflowExpression.Compile(bodyrequesterrequesterSName);
            WorkflowExpression.Validate(__workflow_bodyrequesterrequesterSName, nameof(bodyrequesterrequesterSName), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodyassigneeassigneeId = bodyassigneeassigneeId == null ? null : WorkflowExpression.Compile(bodyassigneeassigneeId);
            WorkflowExpression.Validate(__workflow_bodyassigneeassigneeId, nameof(bodyassigneeassigneeId), required: false);
            var __workflow_bodysourcesourceType = bodysourcesourceType == null ? null : WorkflowExpression.Compile(bodysourcesourceType);
            WorkflowExpression.Validate(__workflow_bodysourcesourceType, nameof(bodysourcesourceType), required: false);
            var __workflow_bodysourcesourceURL = bodysourcesourceURL == null ? null : WorkflowExpression.Compile(bodysourcesourceURL);
            WorkflowExpression.Validate(__workflow_bodysourcesourceURL, nameof(bodysourcesourceURL), required: false);
            return new DeferredBodyAction<TicketResponse>(() =>
            {
                var apiCallPath = "/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (__workflow_bodyrequesterrequesterSEmail != null)
                {
                    requesterObject["mail"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterrequesterSEmail);
                    requesterObjectpropCount++;
                }

                if (__workflow_bodyrequesterrequesterSName != null)
                {
                    requesterObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterrequesterSName);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                if (__workflow_bodyassigneeassigneeId != null)
                {
                    assigneeObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeassigneeId);
                    assigneeObjectpropCount++;
                }

                if (assigneeObjectpropCount > 0)
                {
                    body["assignee"] = assigneeObject;
                    bodypropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (__workflow_bodysourcesourceType != null)
                {
                    sourceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodysourcesourceType);
                    sourceObjectpropCount++;
                }

                if (__workflow_bodysourcesourceURL != null)
                {
                    sourceObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysourcesourceURL);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<TicketResponse> UpdateTicket(Expression<Func<string>> ticketId, Expression<Func<string>> bodyrequesterrequesterSEmail, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyrequesterrequesterSName = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodyassigneeassigneeId = null, Expression<Func<bodysourcesourceTypeInput>> bodysourcesourceType = null, Expression<Func<string>> bodysourcesourceURL = null)
        {
            var __workflow_ticketId = ticketId == null ? null : WorkflowExpression.Compile(ticketId);
            WorkflowExpression.Validate(__workflow_ticketId, nameof(ticketId), required: true);
            var __workflow_bodyrequesterrequesterSEmail = bodyrequesterrequesterSEmail == null ? null : WorkflowExpression.Compile(bodyrequesterrequesterSEmail);
            WorkflowExpression.Validate(__workflow_bodyrequesterrequesterSEmail, nameof(bodyrequesterrequesterSEmail), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyrequesterrequesterSName = bodyrequesterrequesterSName == null ? null : WorkflowExpression.Compile(bodyrequesterrequesterSName);
            WorkflowExpression.Validate(__workflow_bodyrequesterrequesterSName, nameof(bodyrequesterrequesterSName), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodyassigneeassigneeId = bodyassigneeassigneeId == null ? null : WorkflowExpression.Compile(bodyassigneeassigneeId);
            WorkflowExpression.Validate(__workflow_bodyassigneeassigneeId, nameof(bodyassigneeassigneeId), required: false);
            var __workflow_bodysourcesourceType = bodysourcesourceType == null ? null : WorkflowExpression.Compile(bodysourcesourceType);
            WorkflowExpression.Validate(__workflow_bodysourcesourceType, nameof(bodysourcesourceType), required: false);
            var __workflow_bodysourcesourceURL = bodysourcesourceURL == null ? null : WorkflowExpression.Compile(bodysourcesourceURL);
            WorkflowExpression.Validate(__workflow_bodysourcesourceURL, nameof(bodysourcesourceURL), required: false);
            return new DeferredBodyAction<TicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tickets/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ticketId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                requesterObjectpropCount++;
                requesterObject["mail"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterrequesterSEmail);
                if (__workflow_bodyrequesterrequesterSName != null)
                {
                    requesterObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterrequesterSName);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                if (__workflow_bodyassigneeassigneeId != null)
                {
                    assigneeObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeassigneeId);
                    assigneeObjectpropCount++;
                }

                if (assigneeObjectpropCount > 0)
                {
                    body["assignee"] = assigneeObject;
                    bodypropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (__workflow_bodysourcesourceType != null)
                {
                    sourceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodysourcesourceType);
                    sourceObjectpropCount++;
                }

                if (__workflow_bodysourcesourceURL != null)
                {
                    sourceObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysourcesourceURL);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<TicketResponse> GetTicket(Expression<Func<string>> ticketId)
        {
            var __workflow_ticketId = ticketId == null ? null : WorkflowExpression.Compile(ticketId);
            WorkflowExpression.Validate(__workflow_ticketId, nameof(ticketId), required: true);
            return new DeferredBodyAction<TicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TicketResponse>(callPayload);
            });
        }
    }

    public class LivechatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTicketCreated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger WebhookChatStarted(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger WebhookChatEnded(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyloginStatusInput
    {
        [EnumMember(Value = "accepting chats")]
        AcceptingChats,
        [EnumMember(Value = "not accepting chats")]
        NotAcceptingChats
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

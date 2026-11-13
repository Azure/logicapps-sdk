//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohoteaminbox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohoteaminboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoteaminbox")]
        public IBodyWorkflowAction<SendMailResponse, ApiConnectionActionConfiguration> SendMail(Expression<Func<string>> workspaceId, Expression<Func<string>> teamId, Expression<Func<string>> teaminboxId, Expression<Func<SendMailBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_teaminboxId = WorkflowExpression.Compile(teaminboxId, nameof(teaminboxId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/workspaces/{0}/teams/{1}/channels/{2}/compose/mail", __workflow_workspaceId.WithUrlEncoding(1), __workflow_teamId.WithUrlEncoding(1), __workflow_teaminboxId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoteaminbox")]
        public IBodyWorkflowAction<SearchMailResponse, ApiConnectionActionConfiguration> SearchMail(Expression<Func<string>> workspaceId, Expression<Func<QueryInput>> query = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<SearchMailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/workspaces/{0}/search", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                else
                    callPayload.Body = new QueryInput().ToJToken();
                return new ApiConnectionAction<SearchMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoteaminbox")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<string>> workspaceId, Expression<Func<string>> teamId, Expression<Func<CreateContactBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/workspaces/{0}/teams/{1}/contacts", __workflow_workspaceId.WithUrlEncoding(1), __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }
    }

    public class ZohoteaminboxTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendMailResponse
    {
        [JsonProperty("data")]
        public SendMailResponseDataType Data { get; set; }

        [JsonProperty("status")]
        public SendMailResponseStatusType Status { get; set; }
    }

    public class SendMailResponseDataType
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("type")]
        public string ChannelType { get; set; }

        [JsonProperty("tdetails")]
        public SendMailResponseDataTypeThreadDetailsType ThreadDetails { get; set; }

        [JsonProperty("archived")]
        public bool ArchivedThread { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("from")]
        public string FromAddress { get; set; }

        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }
    }

    public class SendMailResponseDataTypeThreadDetailsType
    {
        [JsonProperty("PRIORITY")]
        public int Priority { get; set; }

        [JsonProperty("FROM")]
        public string From { get; set; }

        [JsonProperty("CONTENT")]
        public string EmailContent { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }

        [JsonProperty("SENTTIMEINMILLIS")]
        public string SentTime { get; set; }

        [JsonProperty("SUBJECT")]
        public string Subject { get; set; }

        [JsonProperty("TO")]
        public string To { get; set; }
    }

    public class SendMailResponseStatusType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class SendMailBodyInput
    {
        public SendMailBodyInput(string from, string to, string emailSubject)
        {
            this.From = from;
            this.To = to;
            this.EmailSubject = emailSubject;
        }

        [JsonProperty("fromAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("toAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("ccAddress")]
        public string CC { get; set; }

        [JsonProperty("bccAddress")]
        public string BCC { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailSubject { get; set; }

        [JsonProperty("text")]
        public string EmailBody { get; set; }

        [JsonProperty("entity_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EntityType { get; set; } = 1;

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Encoding { get; set; } = "UTF-8";

        [JsonProperty("mailFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        internal double MailFormat { get; set; } = 2;

        [JsonProperty("archive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Archive { get; set; } = false;
    }

    public class SearchMailResponse
    {
        [JsonProperty("data")]
        public SearchMailResponseDataType Data { get; set; }
    }

    public class SearchMailResponseDataType
    {
        [JsonProperty("messages")]
        public SearchMailResponseDataTypeMessagesTypeItem[] Messages { get; set; }
    }

    public class SearchMailResponseDataTypeMessagesTypeItem
    {
        [JsonProperty("subject")]
        public string MessageSubject { get; set; }

        [JsonProperty("type")]
        public string ChannelType { get; set; }

        [JsonProperty("archived")]
        public bool ArchivedStatus { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("read")]
        public bool ReadStatus { get; set; }

        [JsonProperty("threadCount")]
        public int TotalThreadCount { get; set; }

        [JsonProperty("entityId")]
        public string ThreadId { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("following")]
        public bool FollowingStatus { get; set; }

        [JsonProperty("spam")]
        public bool SpamStatus { get; set; }

        [JsonProperty("inboxId")]
        public string InboxId { get; set; }

        [JsonProperty("drafted")]
        public bool DraftStatus { get; set; }

        [JsonProperty("trashed")]
        public bool TrashStatus { get; set; }
    }

    public class QueryInput
    {
        [JsonProperty("contains")]
        public string Contains { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("is_trashed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeTrash { get; set; } = false;

        [JsonProperty("is_spam", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeSpam { get; set; } = false;
    }

    public class CreateContactResponse
    {
        [JsonProperty("data")]
        public CreateContactResponseDataType Data { get; set; }
    }

    public class CreateContactResponseDataType
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }
    }

    public class CreateContactBodyInput
    {
        public CreateContactBodyInput(string contactName)
        {
            this.ContactName = contactName;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactName { get; set; }

        [JsonProperty("email_id")]
        public string ContactEmail { get; set; }

        [JsonProperty("description")]
        public string ContactDescription { get; set; }

        [JsonProperty("mobile")]
        public string ContactMobileNumber { get; set; }

        [JsonProperty("facebook_profile_url")]
        public string Facebook { get; set; }

        [JsonProperty("instagram_profile_url")]
        public string Instagram { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zohoteaminbox;

    public partial class WorkflowManagedActions
    {
        public ZohoteaminboxActions Zohoteaminbox(string connectionId) => new ZohoteaminboxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZohoteaminboxTriggers Zohoteaminbox(string connectionId) => new ZohoteaminboxTriggers(connectionId);
    }
}
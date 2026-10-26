//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailinatorip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailinatoripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<InboxGetResponse, ApiConnectionActionConfiguration> InboxGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<int>> skip = null, Expression<Func<bool>> decodeSubject = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_inbox = WorkflowExpression.Compile(inbox, nameof(inbox), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_decodeSubject = WorkflowExpression.Compile(decodeSubject, nameof(decodeSubject), required: false);
            return new DeferredBodyAction<InboxGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}/inboxes/{1}", __workflow_domain.WithUrlEncoding(1), __workflow_inbox.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_decodeSubject != null)
                    callPayload.Queries["decode_subject"] = ExpressionConverter.Convert(__workflow_decodeSubject);
                return new ApiConnectionAction<InboxGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageGetResponse, ApiConnectionActionConfiguration> MessageGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_inbox = WorkflowExpression.Compile(inbox, nameof(inbox), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}", __workflow_domain.WithUrlEncoding(1), __workflow_inbox.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageDeleteResponse, ApiConnectionActionConfiguration> MessageDelete(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_inbox = WorkflowExpression.Compile(inbox, nameof(inbox), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}", __workflow_domain.WithUrlEncoding(1), __workflow_inbox.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageAttachmentsGetResponse, ApiConnectionActionConfiguration> MessageAttachmentsGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_inbox = WorkflowExpression.Compile(inbox, nameof(inbox), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageAttachmentsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}/attachments", __workflow_domain.WithUrlEncoding(1), __workflow_inbox.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageAttachmentsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageLinksGetResponse, ApiConnectionActionConfiguration> MessageLinksGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_inbox = WorkflowExpression.Compile(inbox, nameof(inbox), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageLinksGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}/links", __workflow_domain.WithUrlEncoding(1), __workflow_inbox.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageLinksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessagePostResponse, ApiConnectionActionConfiguration> Message(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<MessagePostInput>> body = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_inbox = WorkflowExpression.Compile(inbox, nameof(inbox), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}/inboxes/{1}/messages", __workflow_domain.WithUrlEncoding(1), __workflow_inbox.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<StatsGetResponse, ApiConnectionActionConfiguration> StatsGet()
        {
            return new DeferredBodyAction<StatsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<DomainsGetResponse, ApiConnectionActionConfiguration> DomainsGet()
        {
            return new DeferredBodyAction<DomainsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/domains/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DomainsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<DomainGetResponse, ApiConnectionActionConfiguration> DomainGet(Expression<Func<string>> domainId)
        {
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<DomainGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}", __workflow_domainId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DomainGetResponse>(callPayload);
            });
        }
    }

    public class MailinatoripTriggers([ConnectionName] string connectionId)
    {
    }

    public class InboxGetResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("msgs")]
        public InboxGetResponseMsgsTypeItem[] Msgs { get; set; }
    }

    public class InboxGetResponseMsgsTypeItem
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("seconds_ago")]
        public int SecondsAgo { get; set; }
    }

    public class MessageGetResponse
    {
        [JsonProperty("fromfull")]
        public string Fromfull { get; set; }

        [JsonProperty("headers")]
        public MessageGetResponseHeadersType Headers { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("parts")]
        public MessageGetResponsePartsTypeItem[] Parts { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("seconds_ago")]
        public int SecondsAgo { get; set; }
    }

    public class MessageGetResponseHeadersType
    {
        [JsonProperty("mime-version")]
        public string MimeVersion { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }
    }

    public class MessageGetResponsePartsTypeItem
    {
        [JsonProperty("headers")]
        public MessageGetResponsePartsTypeItemHeadersType Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class MessageGetResponsePartsTypeItemHeadersType
    {
        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("content-disposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("content-transfer-encoding")]
        public string ContentTransferEncoding { get; set; }
    }

    public class MessageDeleteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("messages_deleted")]
        public int MessagesDeleted { get; set; }
    }

    public class MessageAttachmentsGetResponse
    {
        [JsonProperty("attachments")]
        public MessageAttachmentsGetResponseAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class MessageAttachmentsGetResponseAttachmentsTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content-disposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("content-transfer-encoding")]
        public string ContentTransferEncoding { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("attachment-id")]
        public int AttachmentId { get; set; }
    }

    public class MessageLinksGetResponse
    {
        [JsonProperty("links")]
        public string[] Links { get; set; }
    }

    public class MessagePostResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MessagePostInput
    {
        [JsonProperty("fromfull")]
        public string Fromfull { get; set; }

        [JsonProperty("headers")]
        public MessagePostInputHeadersType Headers { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("parts")]
        public MessagePostInputPartsTypeItem[] Parts { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("time")]
        public int? Time { get; set; }

        [JsonProperty("seconds_ago")]
        public int? SecondsAgo { get; set; }
    }

    public class MessagePostInputHeadersType
    {
        [JsonProperty("mime-version")]
        public string MimeVersion { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }
    }

    public class MessagePostInputPartsTypeItem
    {
        [JsonProperty("headers")]
        public MessagePostInputPartsTypeItemHeadersType Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class MessagePostInputPartsTypeItemHeadersType
    {
        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("content-disposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("content-transfer-encoding")]
        public string ContentTransferEncoding { get; set; }
    }

    public class StatsGetResponse
    {
        [JsonProperty("stats")]
        public StatsGetResponseStatsTypeItem[] Stats { get; set; }
    }

    public class StatsGetResponseStatsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("retrieved")]
        public StatsGetResponseStatsTypeItemRetrievedType Retrieved { get; set; }

        [JsonProperty("sent")]
        public StatsGetResponseStatsTypeItemSentType Sent { get; set; }
    }

    public class StatsGetResponseStatsTypeItemRetrievedType
    {
        [JsonProperty("web_private")]
        public int WebPrivate { get; set; }

        [JsonProperty("web_public")]
        public int WebPublic { get; set; }

        [JsonProperty("api_email")]
        public int ApiEmail { get; set; }

        [JsonProperty("api_error")]
        public int ApiError { get; set; }
    }

    public class StatsGetResponseStatsTypeItemSentType
    {
        [JsonProperty("sms")]
        public int Sms { get; set; }

        [JsonProperty("email")]
        public int Email { get; set; }
    }

    public class DomainsGetResponse
    {
        [JsonProperty("domains")]
        public DomainsGetResponseDomainsTypeItem[] Domains { get; set; }
    }

    public class DomainsGetResponseDomainsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class DomainGetResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownerid")]
        public string Ownerid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailinatorip;

    public partial class WorkflowManagedActions
    {
        public MailinatoripActions Mailinatorip(string connectionId) => new MailinatoripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailinatoripTriggers Mailinatorip(string connectionId) => new MailinatoripTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailinatorip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MailinatoripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<InboxGetResponse> InboxGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<int>> skip = null, Expression<Func<bool>> decodeSubject = null)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: true);
            var __workflow_inbox = inbox == null ? null : WorkflowExpression.Compile(inbox);
            WorkflowExpression.Validate(__workflow_inbox, nameof(inbox), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_decodeSubject = decodeSubject == null ? null : WorkflowExpression.Compile(decodeSubject);
            WorkflowExpression.Validate(__workflow_decodeSubject, nameof(decodeSubject), required: false);
            return new DeferredBodyAction<InboxGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domain, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_inbox, 1));
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
        public IBodyWorkflowAction<MessageGetResponse> MessageGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: true);
            var __workflow_inbox = inbox == null ? null : WorkflowExpression.Compile(inbox);
            WorkflowExpression.Validate(__workflow_inbox, nameof(inbox), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domain, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageDeleteResponse> MessageDelete(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: true);
            var __workflow_inbox = inbox == null ? null : WorkflowExpression.Compile(inbox);
            WorkflowExpression.Validate(__workflow_inbox, nameof(inbox), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domain, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageAttachmentsGetResponse> MessageAttachmentsGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: true);
            var __workflow_inbox = inbox == null ? null : WorkflowExpression.Compile(inbox);
            WorkflowExpression.Validate(__workflow_inbox, nameof(inbox), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageAttachmentsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domain, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageAttachmentsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageLinksGetResponse> MessageLinksGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: true);
            var __workflow_inbox = inbox == null ? null : WorkflowExpression.Compile(inbox);
            WorkflowExpression.Validate(__workflow_inbox, nameof(inbox), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageLinksGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}/links", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domain, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageLinksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessagePostResponse> Message(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> bodyfromfull = null, Expression<Func<string>> bodyheadersmimeVersion = null, Expression<Func<string>> bodyheadersdate = null, Expression<Func<string>> bodyheaderssubject = null, Expression<Func<string>> bodyheaderscontentType = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodypartsInputItem[]>> bodyparts = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyid = null, Expression<Func<int>> bodytime = null, Expression<Func<int>> bodysecondsAgo = null)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: true);
            var __workflow_inbox = inbox == null ? null : WorkflowExpression.Compile(inbox);
            WorkflowExpression.Validate(__workflow_inbox, nameof(inbox), required: true);
            var __workflow_bodyfromfull = bodyfromfull == null ? null : WorkflowExpression.Compile(bodyfromfull);
            WorkflowExpression.Validate(__workflow_bodyfromfull, nameof(bodyfromfull), required: false);
            var __workflow_bodyheadersmimeVersion = bodyheadersmimeVersion == null ? null : WorkflowExpression.Compile(bodyheadersmimeVersion);
            WorkflowExpression.Validate(__workflow_bodyheadersmimeVersion, nameof(bodyheadersmimeVersion), required: false);
            var __workflow_bodyheadersdate = bodyheadersdate == null ? null : WorkflowExpression.Compile(bodyheadersdate);
            WorkflowExpression.Validate(__workflow_bodyheadersdate, nameof(bodyheadersdate), required: false);
            var __workflow_bodyheaderssubject = bodyheaderssubject == null ? null : WorkflowExpression.Compile(bodyheaderssubject);
            WorkflowExpression.Validate(__workflow_bodyheaderssubject, nameof(bodyheaderssubject), required: false);
            var __workflow_bodyheaderscontentType = bodyheaderscontentType == null ? null : WorkflowExpression.Compile(bodyheaderscontentType);
            WorkflowExpression.Validate(__workflow_bodyheaderscontentType, nameof(bodyheaderscontentType), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodyparts = bodyparts == null ? null : WorkflowExpression.Compile(bodyparts);
            WorkflowExpression.Validate(__workflow_bodyparts, nameof(bodyparts), required: false);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: false);
            var __workflow_bodytime = bodytime == null ? null : WorkflowExpression.Compile(bodytime);
            WorkflowExpression.Validate(__workflow_bodytime, nameof(bodytime), required: false);
            var __workflow_bodysecondsAgo = bodysecondsAgo == null ? null : WorkflowExpression.Compile(bodysecondsAgo);
            WorkflowExpression.Validate(__workflow_bodysecondsAgo, nameof(bodysecondsAgo), required: false);
            return new DeferredBodyAction<MessagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domain, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_inbox, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfromfull != null)
                {
                    body["fromfull"] = ExpressionConverter.ConvertO(__workflow_bodyfromfull);
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (__workflow_bodyheadersmimeVersion != null)
                {
                    headersObject["mime-version"] = ExpressionConverter.ConvertO(__workflow_bodyheadersmimeVersion);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersdate != null)
                {
                    headersObject["date"] = ExpressionConverter.ConvertO(__workflow_bodyheadersdate);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheaderssubject != null)
                {
                    headersObject["subject"] = ExpressionConverter.ConvertO(__workflow_bodyheaderssubject);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheaderscontentType != null)
                {
                    headersObject["content-type"] = ExpressionConverter.ConvertO(__workflow_bodyheaderscontentType);
                    headersObjectpropCount++;
                }

                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodyparts != null)
                {
                    body["parts"] = ExpressionConverter.ConvertO(__workflow_bodyparts);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodytime != null)
                {
                    body["time"] = ExpressionConverter.ConvertO(__workflow_bodytime);
                    bodypropCount++;
                }

                if (__workflow_bodysecondsAgo != null)
                {
                    body["seconds_ago"] = ExpressionConverter.ConvertO(__workflow_bodysecondsAgo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<StatsGetResponse> StatsGet()
        {
            var apiCallPath = "/team/stats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<DomainsGetResponse> DomainsGet()
        {
            var apiCallPath = "/domains/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DomainsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<DomainGetResponse> DomainGet(Expression<Func<string>> domainId)
        {
            var __workflow_domainId = domainId == null ? null : WorkflowExpression.Compile(domainId);
            WorkflowExpression.Validate(__workflow_domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<DomainGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domainId, 1));
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

    public class bodypartsInputItem
    {
        [JsonProperty("headers")]
        public bodypartsInputItemHeadersType Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class bodypartsInputItemHeadersType
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

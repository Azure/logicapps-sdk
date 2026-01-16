//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailinatorip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailinatoripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<InboxGetResponse> InboxGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<int>> skip = null, Expression<Func<bool>> decodeSubject = null)
        {
            var apiCallPath = String.Format("/domains/{0}/inboxes/{1}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1), ExpressionConverter.ConvertWithUrlEncoding(inbox, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            if (decodeSubject != null)
                callPayload.Queries["decode_subject"] = ExpressionConverter.Convert(decodeSubject);
            return new ApiConnectionAction<InboxGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageGetResponse> MessageGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/domains/{0}/inboxes/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1), ExpressionConverter.ConvertWithUrlEncoding(inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageDeleteResponse> MessageDelete(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/domains/{0}/inboxes/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1), ExpressionConverter.ConvertWithUrlEncoding(inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageAttachmentsGetResponse> MessageAttachmentsGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/domains/{0}/inboxes/{1}/messages/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(domain, 1), ExpressionConverter.ConvertWithUrlEncoding(inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageAttachmentsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageLinksGetResponse> MessageLinksGet(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/domains/{0}/inboxes/{1}/messages/{2}/links", ExpressionConverter.ConvertWithUrlEncoding(domain, 1), ExpressionConverter.ConvertWithUrlEncoding(inbox, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageLinksGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessagePostResponse> MessagePost(Expression<Func<string>> domain, Expression<Func<string>> inbox, Expression<Func<string>> bodyfromfull = null, Expression<Func<string>> bodyheadersmimeVersion = null, Expression<Func<string>> bodyheadersdate = null, Expression<Func<string>> bodyheaderssubject = null, Expression<Func<string>> bodyheaderscontentType = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodypartsInputItem[]>> bodyparts = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyid = null, Expression<Func<int>> bodytime = null, Expression<Func<int>> bodysecondsAgo = null)
        {
            var apiCallPath = String.Format("/domains/{0}/inboxes/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(domain, 1), ExpressionConverter.ConvertWithUrlEncoding(inbox, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfromfull != null)
            {
                body["fromfull"] = ExpressionConverter.ConvertO(bodyfromfull);
                bodypropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (bodyheadersmimeVersion != null)
            {
                headersObject["mime-version"] = ExpressionConverter.ConvertO(bodyheadersmimeVersion);
                headersObjectpropCount++;
            }

            if (bodyheadersdate != null)
            {
                headersObject["date"] = ExpressionConverter.ConvertO(bodyheadersdate);
                headersObjectpropCount++;
            }

            if (bodyheaderssubject != null)
            {
                headersObject["subject"] = ExpressionConverter.ConvertO(bodyheaderssubject);
                headersObjectpropCount++;
            }

            if (bodyheaderscontentType != null)
            {
                headersObject["content-type"] = ExpressionConverter.ConvertO(bodyheaderscontentType);
                headersObjectpropCount++;
            }

            if (headersObjectpropCount > 0)
            {
                body["headers"] = headersObject;
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodyparts != null)
            {
                body["parts"] = ExpressionConverter.ConvertO(bodyparts);
                bodypropCount++;
            }

            if (bodyfrom != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
            }

            if (bodyto != null)
            {
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodytime != null)
            {
                body["time"] = ExpressionConverter.ConvertO(bodytime);
                bodypropCount++;
            }

            if (bodysecondsAgo != null)
            {
                body["seconds_ago"] = ExpressionConverter.ConvertO(bodysecondsAgo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MessagePostResponse>(callPayload);
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
            var apiCallPath = String.Format("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(domainId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DomainGetResponse>(callPayload);
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
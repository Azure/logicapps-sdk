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
        public IBodyWorkflowAction<InboxGetResponse> InboxGet([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> inbox, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> decodeSubject = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(inbox, nameof(inbox), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(decodeSubject, nameof(decodeSubject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inbox, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (decodeSubject != null)
                    callPayload.Queries["decode_subject"] = SourceExpressionConverter.ConvertO(decodeSubject);
                return callPayload;
            }

            return new ApiConnectionAction<InboxGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageGetResponse> MessageGet([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> inbox, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(inbox, nameof(inbox), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inbox, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageDeleteResponse> MessageDelete([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> inbox, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(inbox, nameof(inbox), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inbox, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageAttachmentsGetResponse> MessageAttachmentsGet([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> inbox, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(inbox, nameof(inbox), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inbox, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageAttachmentsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessageLinksGetResponse> MessageLinksGet([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> inbox, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(inbox, nameof(inbox), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages/{2}/links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inbox, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageLinksGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> inbox, [WorkflowExpression] Func<string> bodyfromfull = null, [WorkflowExpression] Func<string> bodyheadersmimeVersion = null, [WorkflowExpression] Func<string> bodyheadersdate = null, [WorkflowExpression] Func<string> bodyheaderssubject = null, [WorkflowExpression] Func<string> bodyheaderscontentType = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodypartsInputItem[]> bodyparts = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<int> bodytime = null, [WorkflowExpression] Func<int> bodysecondsAgo = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(inbox, nameof(inbox), required: true);
            SourceExpression.Validate(bodyfromfull, nameof(bodyfromfull), required: false);
            SourceExpression.Validate(bodyheadersmimeVersion, nameof(bodyheadersmimeVersion), required: false);
            SourceExpression.Validate(bodyheadersdate, nameof(bodyheadersdate), required: false);
            SourceExpression.Validate(bodyheaderssubject, nameof(bodyheaderssubject), required: false);
            SourceExpression.Validate(bodyheaderscontentType, nameof(bodyheaderscontentType), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodyparts, nameof(bodyparts), required: false);
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: false);
            SourceExpression.Validate(bodysecondsAgo, nameof(bodysecondsAgo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}/inboxes/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inbox, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfromfull != null)
                {
                    body["fromfull"] = SourceExpressionConverter.ConvertToken(bodyfromfull);
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (bodyheadersmimeVersion != null)
                {
                    headersObject["mime-version"] = SourceExpressionConverter.ConvertToken(bodyheadersmimeVersion);
                    headersObjectpropCount++;
                }

                if (bodyheadersdate != null)
                {
                    headersObject["date"] = SourceExpressionConverter.ConvertToken(bodyheadersdate);
                    headersObjectpropCount++;
                }

                if (bodyheaderssubject != null)
                {
                    headersObject["subject"] = SourceExpressionConverter.ConvertToken(bodyheaderssubject);
                    headersObjectpropCount++;
                }

                if (bodyheaderscontentType != null)
                {
                    headersObject["content-type"] = SourceExpressionConverter.ConvertToken(bodyheaderscontentType);
                    headersObjectpropCount++;
                }

                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodyparts != null)
                {
                    body["parts"] = SourceExpressionConverter.ConvertToken(bodyparts);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodytime != null)
                {
                    body["time"] = SourceExpressionConverter.ConvertToken(bodytime);
                    bodypropCount++;
                }

                if (bodysecondsAgo != null)
                {
                    body["seconds_ago"] = SourceExpressionConverter.ConvertToken(bodysecondsAgo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<StatsGetResponse> StatsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/team/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<DomainsGetResponse> DomainsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domains/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DomainsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailinatorip")]
        public IBodyWorkflowAction<DomainGetResponse> DomainGet([WorkflowExpression] Func<string> domainId)
        {
            SourceExpression.Validate(domainId, nameof(domainId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DomainGetResponse>(BuildSourceInput);
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
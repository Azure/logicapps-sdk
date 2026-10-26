//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Messagebirdsmsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MessagebirdsmsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "messagebirdsmsip")]
        public IBodyWorkflowAction<MessagesGetResponse, ApiConnectionActionConfiguration> MessagesGet(Expression<Func<string>> originator = null, Expression<Func<string>> recipient = null, Expression<Func<directionInput>> direction = null, Expression<Func<string>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> searchterm = null, Expression<Func<typeInput>> type = null, Expression<Func<int>> contactId = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> from = null, Expression<Func<string>> until = null)
        {
            var __workflow_originator = WorkflowExpression.Compile(originator, nameof(originator), required: false);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_searchterm = WorkflowExpression.Compile(searchterm, nameof(searchterm), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_until = WorkflowExpression.Compile(until, nameof(until), required: false);
            return new DeferredBodyAction<MessagesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_originator != null)
                    callPayload.Queries["originator"] = ExpressionConverter.Convert(__workflow_originator);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                callPayload.Queries["direction"] = Convert.ToString("mt");
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_searchterm != null)
                    callPayload.Queries["searchterm"] = ExpressionConverter.Convert(__workflow_searchterm);
                callPayload.Queries["type"] = Convert.ToString("sms");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_contactId != null)
                    callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                callPayload.Queries["status"] = Convert.ToString("sent");
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_until != null)
                    callPayload.Queries["until"] = ExpressionConverter.Convert(__workflow_until);
                return new ApiConnectionAction<MessagesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "messagebirdsmsip")]
        public IBodyWorkflowAction<MessagesPostResponse, ApiConnectionActionConfiguration> Messages(Expression<Func<MessagesPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessagesPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessagesPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "messagebirdsmsip")]
        public IBodyWorkflowAction<MessageGetResponse, ApiConnectionActionConfiguration> MessageGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "messagebirdsmsip")]
        public IBodyWorkflowAction<BatchPostResponseItem[], ApiConnectionActionConfiguration> Batch(Expression<Func<BatchPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BatchPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/batches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BatchPostResponseItem[]>(callPayload);
            });
        }
    }

    public class MessagebirdsmsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MessagesGetResponse
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("links")]
        public MessagesGetResponseLinksType Links { get; set; }

        [JsonProperty("items")]
        public MessagesGetResponseItemsTypeItem[] Items { get; set; }
    }

    public class MessagesGetResponseLinksType
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class MessagesGetResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("validity")]
        public string Validity { get; set; }

        [JsonProperty("gateway")]
        public int Gateway { get; set; }

        [JsonProperty("typeDetails")]
        public JToken TypeDetails { get; set; }

        [JsonProperty("datacoding")]
        public string Datacoding { get; set; }

        [JsonProperty("mclass")]
        public int Mclass { get; set; }

        [JsonProperty("scheduledDatetime")]
        public string ScheduledDatetime { get; set; }

        [JsonProperty("createdDatetime")]
        public string CreatedDatetime { get; set; }

        [JsonProperty("recipients")]
        public MessagesGetResponseItemsTypeItemRecipientsType Recipients { get; set; }
    }

    public class MessagesGetResponseItemsTypeItemRecipientsType
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalSentCount")]
        public int TotalSentCount { get; set; }

        [JsonProperty("totalDeliveredCount")]
        public int TotalDeliveredCount { get; set; }

        [JsonProperty("totalDeliveryFailedCount")]
        public int TotalDeliveryFailedCount { get; set; }

        [JsonProperty("items")]
        public MessagesGetResponseItemsTypeItemRecipientsTypeItemsTypeItem[] Items { get; set; }
    }

    public class MessagesGetResponseItemsTypeItemRecipientsTypeItemsTypeItem
    {
        [JsonProperty("recipient")]
        public int Recipient { get; set; }

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("statusErrorCode")]
        public string StatusErrorCode { get; set; }

        [JsonProperty("statusDatetime")]
        public string StatusDatetime { get; set; }

        [JsonProperty("recipientCountry")]
        public string RecipientCountry { get; set; }

        [JsonProperty("recipientCountryPrefix")]
        public int RecipientCountryPrefix { get; set; }

        [JsonProperty("recipientOperator")]
        public string RecipientOperator { get; set; }

        [JsonProperty("mccmnc")]
        public string Mccmnc { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("mnc")]
        public string Mnc { get; set; }

        [JsonProperty("messageLength")]
        public int MessageLength { get; set; }

        [JsonProperty("messagePartCount")]
        public int MessagePartCount { get; set; }

        [JsonProperty("price")]
        public MessagesGetResponseItemsTypeItemRecipientsTypeItemsTypeItemPriceType Price { get; set; }
    }

    public class MessagesGetResponseItemsTypeItemRecipientsTypeItemsTypeItemPriceType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum directionInput
    {
        [EnumMember(Value = "mt")]
        Mt,
        [EnumMember(Value = "mo")]
        Mo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "flash")]
        Flash
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "scheduled")]
        Scheduled,
        [EnumMember(Value = "buffered")]
        Buffered,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "delivery_failed")]
        DeliveryFailed
    }

    public class MessagesPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("validity")]
        public string Validity { get; set; }

        [JsonProperty("gateway")]
        public int Gateway { get; set; }

        [JsonProperty("typeDetails")]
        public JToken TypeDetails { get; set; }

        [JsonProperty("datacoding")]
        public string Datacoding { get; set; }

        [JsonProperty("mclass")]
        public int Mclass { get; set; }

        [JsonProperty("scheduledDatetime")]
        public string ScheduledDatetime { get; set; }

        [JsonProperty("createdDatetime")]
        public string CreatedDatetime { get; set; }

        [JsonProperty("recipients")]
        public MessagesPostResponseRecipientsType Recipients { get; set; }
    }

    public class MessagesPostResponseRecipientsType
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalSentCount")]
        public int TotalSentCount { get; set; }

        [JsonProperty("totalDeliveredCount")]
        public int TotalDeliveredCount { get; set; }

        [JsonProperty("totalDeliveryFailedCount")]
        public int TotalDeliveryFailedCount { get; set; }

        [JsonProperty("items")]
        public MessagesPostResponseRecipientsTypeItemsTypeItem[] Items { get; set; }
    }

    public class MessagesPostResponseRecipientsTypeItemsTypeItem
    {
        [JsonProperty("recipient")]
        public int Recipient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDatetime")]
        public string StatusDatetime { get; set; }
    }

    public class MessagesPostInput
    {
        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Recipients { get; set; }

        [JsonProperty("originator", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Originator { get; set; }

        [JsonProperty("shortcode")]
        public int? Shortcode { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("groupIds")]
        public string[] GroupIds { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public MessagesPostInputTypeType? Type { get; set; } = MessagesPostInputTypeType.Sms;

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reportUrl")]
        public string ReportUrl { get; set; }

        [JsonProperty("validity")]
        public int? Validity { get; set; }

        [JsonProperty("gateway")]
        public int? Gateway { get; set; }

        [JsonProperty("datacoding")]
        public string Datacoding { get; set; }

        [JsonProperty("mclass", DefaultValueHandling = DefaultValueHandling.Include)]
        public MessagesPostInputMclassType? Mclass { get; set; } = MessagesPostInputMclassType._1;

        [JsonProperty("shortenUrls")]
        public bool? ShortenUrls { get; set; }

        [JsonProperty("scheduledDatetime")]
        public string ScheduledDatetime { get; set; }

        [JsonProperty("createdDatetime")]
        public string CreatedDatetime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessagesPostInputTypeType
    {
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "flash")]
        Flash
    }

    public enum MessagesPostInputMclassType
    {
        _1 = 1,
        _0 = 0
    }

    public class MessageGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("validity")]
        public string Validity { get; set; }

        [JsonProperty("gateway")]
        public int Gateway { get; set; }

        [JsonProperty("typeDetails")]
        public JToken TypeDetails { get; set; }

        [JsonProperty("datacoding")]
        public string Datacoding { get; set; }

        [JsonProperty("mclass")]
        public int Mclass { get; set; }

        [JsonProperty("scheduledDatetime")]
        public string ScheduledDatetime { get; set; }

        [JsonProperty("createdDatetime")]
        public string CreatedDatetime { get; set; }

        [JsonProperty("recipients")]
        public MessageGetResponseRecipientsType Recipients { get; set; }
    }

    public class MessageGetResponseRecipientsType
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalSentCount")]
        public int TotalSentCount { get; set; }

        [JsonProperty("totalDeliveredCount")]
        public int TotalDeliveredCount { get; set; }

        [JsonProperty("totalDeliveryFailedCount")]
        public int TotalDeliveryFailedCount { get; set; }

        [JsonProperty("items")]
        public MessageGetResponseRecipientsTypeItemsTypeItem[] Items { get; set; }
    }

    public class MessageGetResponseRecipientsTypeItemsTypeItem
    {
        [JsonProperty("recipient")]
        public int Recipient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("statusErrorCode")]
        public string StatusErrorCode { get; set; }

        [JsonProperty("statusDatetime")]
        public string StatusDatetime { get; set; }

        [JsonProperty("recipientCountry")]
        public string RecipientCountry { get; set; }

        [JsonProperty("recipientCountryPrefix")]
        public int RecipientCountryPrefix { get; set; }

        [JsonProperty("recipientOperator")]
        public string RecipientOperator { get; set; }

        [JsonProperty("mccmnc")]
        public string Mccmnc { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        [JsonProperty("mnc")]
        public string Mnc { get; set; }

        [JsonProperty("messageLength")]
        public int MessageLength { get; set; }

        [JsonProperty("messagePartCount")]
        public int MessagePartCount { get; set; }

        [JsonProperty("price")]
        public MessageGetResponseRecipientsTypeItemsTypeItemPriceType Price { get; set; }
    }

    public class MessageGetResponseRecipientsTypeItemsTypeItemPriceType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BatchPostResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("validity")]
        public string Validity { get; set; }

        [JsonProperty("gateway")]
        public int Gateway { get; set; }

        [JsonProperty("typeDetails")]
        public JToken TypeDetails { get; set; }

        [JsonProperty("datacoding")]
        public string Datacoding { get; set; }

        [JsonProperty("mclass")]
        public int Mclass { get; set; }

        [JsonProperty("scheduledDatetime")]
        public string ScheduledDatetime { get; set; }

        [JsonProperty("createdDatetime")]
        public string CreatedDatetime { get; set; }

        [JsonProperty("recipients")]
        public BatchPostResponseItemRecipientsType Recipients { get; set; }
    }

    public class BatchPostResponseItemRecipientsType
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalSentCount")]
        public int TotalSentCount { get; set; }

        [JsonProperty("totalDeliveredCount")]
        public int TotalDeliveredCount { get; set; }

        [JsonProperty("totalDeliveryFailedCount")]
        public int TotalDeliveryFailedCount { get; set; }

        [JsonProperty("items")]
        public BatchPostResponseItemRecipientsTypeItemsTypeItem[] Items { get; set; }
    }

    public class BatchPostResponseItemRecipientsTypeItemsTypeItem
    {
        [JsonProperty("recipient")]
        public int Recipient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDatetime")]
        public string StatusDatetime { get; set; }
    }

    public class BatchPostInput
    {
        [JsonProperty("messages")]
        public BatchPostInputMessagesTypeItem[] Messages { get; set; }
    }

    public class BatchPostInputMessagesTypeItem
    {
        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Messagebirdsmsip;

    public partial class WorkflowManagedActions
    {
        public MessagebirdsmsipActions Messagebirdsmsip(string connectionId) => new MessagebirdsmsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MessagebirdsmsipTriggers Messagebirdsmsip(string connectionId) => new MessagebirdsmsipTriggers(connectionId);
    }
}
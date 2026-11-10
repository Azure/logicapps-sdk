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
        public IBodyWorkflowAction<MessagesGetResponse, ApiConnectionActionConfiguration> MessagesGet(Expression<Func<string>> originator = null, Expression<Func<string>> recipient = null, Expression<Func<DirectionInput>> direction = null, Expression<Func<string>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> searchterm = null, Expression<Func<TypeInput>> type = null, Expression<Func<int>> contactId = null, Expression<Func<StatusInput>> status = null, Expression<Func<string>> from = null, Expression<Func<string>> until = null)
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
        public IBodyWorkflowAction<MessagesResponse, ApiConnectionActionConfiguration> Messages(Expression<Func<MessagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MessagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessagesResponse>(callPayload);
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
        public IBodyWorkflowAction<BatchResponseItem[], ApiConnectionActionConfiguration> Batch(Expression<Func<BatchBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BatchResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/batches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BatchResponseItem[]>(callPayload);
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
    public enum DirectionInput
    {
        [EnumMember(Value = "mt")]
        Mt,
        [EnumMember(Value = "mo")]
        Mo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TypeInput
    {
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "flash")]
        Flash
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusInput
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

    public class MessagesResponse
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
        public MessagesResponseRecipientsType Recipients { get; set; }
    }

    public class MessagesResponseRecipientsType
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
        public MessagesResponseRecipientsTypeItemsTypeItem[] Items { get; set; }
    }

    public class MessagesResponseRecipientsTypeItemsTypeItem
    {
        [JsonProperty("recipient")]
        public int Recipient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDatetime")]
        public string StatusDatetime { get; set; }
    }

    public class MessagesBodyInput
    {
        public MessagesBodyInput(string[] recipients, string originator, string body)
        {
            this.Recipients = recipients;
            this.Originator = originator;
            this.Body = body;
        }

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
        public BodyInputTypeType? Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Messagebirdsmsip.BodyInputTypeType.Sms;

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
        public BodyInputMclassType? Mclass { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Messagebirdsmsip.BodyInputMclassType._1;

        [JsonProperty("shortenUrls")]
        public bool? ShortenUrls { get; set; }

        [JsonProperty("scheduledDatetime")]
        public string ScheduledDatetime { get; set; }

        [JsonProperty("createdDatetime")]
        public string CreatedDatetime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "flash")]
        Flash
    }

    public enum BodyInputMclassType
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

    public class BatchResponseItem
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
        public BatchResponseItemRecipientsType Recipients { get; set; }
    }

    public class BatchResponseItemRecipientsType
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
        public BatchResponseItemRecipientsTypeItemsTypeItem[] Items { get; set; }
    }

    public class BatchResponseItemRecipientsTypeItemsTypeItem
    {
        [JsonProperty("recipient")]
        public int Recipient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDatetime")]
        public string StatusDatetime { get; set; }
    }

    public class BatchBodyInput
    {
        [JsonProperty("messages")]
        public BodyInputMessagesTypeItem[] Messages { get; set; }
    }

    public class BodyInputMessagesTypeItem
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infobip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfobipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infobip")]
        public IBodyWorkflowAction<SendSMSSuccessResponseBody, ApiConnectionActionConfiguration> SendInfobipSMS(Expression<Func<SendInfobipSMSInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<SendSMSSuccessResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms/1/text/single";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<SendSMSSuccessResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infobip")]
        public IBodyWorkflowAction<VoiceCallSuccessResponseBody, ApiConnectionActionConfiguration> MakeInfobipVoiceCall(Expression<Func<MakeInfobipVoiceCallInput>> requestBody = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<VoiceCallSuccessResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tts/3/single";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<VoiceCallSuccessResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infobip")]
        public IBodyWorkflowAction<BalanceSuccessResponseBody, ApiConnectionActionConfiguration> CheckCurrentBalance()
        {
            return new DeferredBodyAction<BalanceSuccessResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account/1/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BalanceSuccessResponseBody>(callPayload);
            });
        }
    }

    public class InfobipTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateInfobipSMSWebhook(Expression<Func<CreateInfobipSMSWebhookInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/sms/1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendSMSSuccessResponseBody
    {
        [JsonProperty("messages")]
        public SendSMSSuccessResponseBodyMessagesTypeItem[] Messages { get; set; }
    }

    public class SendSMSSuccessResponseBodyMessagesTypeItem
    {
        [JsonProperty("to")]
        public string DestinationPhoneNumber { get; set; }

        [JsonProperty("messageId")]
        public string UniqueMessageId { get; set; }

        [JsonProperty("status")]
        public SendSMSSuccessResponseBodyMessagesTypeItemStatusType Status { get; set; }
    }

    public class SendSMSSuccessResponseBodyMessagesTypeItemStatusType
    {
        [JsonProperty("id")]
        public double MessageSendingStatusId { get; set; }

        [JsonProperty("name")]
        public string MessageSendingStatus { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfMessageSendingStatus { get; set; }
    }

    public class SendInfobipSMSInput
    {
        [JsonProperty("from")]
        public string SenderSPhoneNumber { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientSPhoneNumber { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }

    public class VoiceCallSuccessResponseBody
    {
        [JsonProperty("messages")]
        public VoiceCallSuccessResponseBodyMessagesTypeItem[] Messages { get; set; }
    }

    public class VoiceCallSuccessResponseBodyMessagesTypeItem
    {
        [JsonProperty("to")]
        public string DestinationPhoneNumber { get; set; }

        [JsonProperty("messageId")]
        public string UniqueMessageId { get; set; }

        [JsonProperty("status")]
        public VoiceCallSuccessResponseBodyMessagesTypeItemStatusType Status { get; set; }
    }

    public class VoiceCallSuccessResponseBodyMessagesTypeItemStatusType
    {
        [JsonProperty("id")]
        public double MessageSendingStatusId { get; set; }

        [JsonProperty("name")]
        public string MessageSendingStatus { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfMessageSendingStatus { get; set; }
    }

    public class MakeInfobipVoiceCallInput
    {
        [JsonProperty("from")]
        public string CallerSPhoneNumber { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientSPhoneNumber { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public MakeInfobipVoiceCallInputLanguageType Language { get; set; } = MakeInfobipVoiceCallInputLanguageType.En;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MakeInfobipVoiceCallInputLanguageType
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh-cn")]
        ZhCn,
        [EnumMember(Value = "zh-tw")]
        ZhTw,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-pt")]
        PtPt,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "tr")]
        Tr
    }

    public class BalanceSuccessResponseBody
    {
        [JsonProperty("balance")]
        public double CurrentAccountBalance { get; set; }

        [JsonProperty("currency")]
        public string CurrencyUsedToExpressTheBalanceIn { get; set; }
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("config")]
        public WebhookCreationResponseConfigType Config { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("test_url")]
        public string TestUrl { get; set; }

        [JsonProperty("ping_url")]
        public string PingUrl { get; set; }

        [JsonProperty("last_response")]
        public WebhookCreationResponseLastResponseType LastResponse { get; set; }
    }

    public class WebhookCreationResponseConfigType
    {
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class WebhookCreationResponseLastResponseType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateInfobipSMSWebhookInput
    {
        [JsonProperty("phoneNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PhoneNumber { get; set; }

        [JsonProperty("keyword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Keyword { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infobip;

    public partial class WorkflowManagedActions
    {
        public InfobipActions Infobip(string connectionId) => new InfobipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfobipTriggers Infobip(string connectionId) => new InfobipTriggers(connectionId);
    }
}
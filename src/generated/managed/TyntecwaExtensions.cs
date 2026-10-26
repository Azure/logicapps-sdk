//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecwaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<TestPhoneNumberResponse, ApiConnectionActionConfiguration> TestPhoneNumber(Expression<Func<string>> whatsAppBusinessNumber)
        {
            var __workflow_whatsAppBusinessNumber = WorkflowExpression.Compile(whatsAppBusinessNumber, nameof(whatsAppBusinessNumber), required: true);
            return new DeferredBodyAction<TestPhoneNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/channels/whatsapp/phone-numbers/{0}", __workflow_whatsAppBusinessNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TestPhoneNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTextResponse, ApiConnectionActionConfiguration> SendWhatsAppText(Expression<Func<SendWhatsAppTextInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppContactResponse, ApiConnectionActionConfiguration> SendWhatsAppContact(Expression<Func<SendWhatsAppContactInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppLocationResponse, ApiConnectionActionConfiguration> SendWhatsAppLocation(Expression<Func<SendWhatsAppLocationInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse, ApiConnectionActionConfiguration> SendWhatsAppQuickReply(Expression<Func<SendWhatsAppQuickReplyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppQuickReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppQuickReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductListResponse, ApiConnectionActionConfiguration> SendWhatsAppProductList(Expression<Func<SendWhatsAppProductListInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppProductListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppProductListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductResponse, ApiConnectionActionConfiguration> SendWhatsAppProduct(Expression<Func<SendWhatsAppProductInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppProductResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppProductResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppListResponse, ApiConnectionActionConfiguration> SendWhatsAppList(Expression<Func<SendWhatsAppListInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendsWhatsAppImageResponse, ApiConnectionActionConfiguration> SendsWhatsAppImage(Expression<Func<SendsWhatsAppImageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendsWhatsAppImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendsWhatsAppImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppVideoResponse, ApiConnectionActionConfiguration> SendWhatsAppVideo(Expression<Func<SendWhatsAppVideoInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppVideoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppVideoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse, ApiConnectionActionConfiguration> SendWhatsAppDocument(Expression<Func<SendWhatsAppDocumentInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppAudioResponse, ApiConnectionActionConfiguration> SendWhatsAppAudio(Expression<Func<SendWhatsAppAudioInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppAudioResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/audio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppAudioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppStickerResponse, ApiConnectionActionConfiguration> SendWhatsAppSticker(Expression<Func<SendWhatsAppStickerInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppStickerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/sticker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppStickerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateText(Expression<Func<SendWhatsAppTemplateTextInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateLocation(Expression<Func<SendWhatsAppTemplateLocationInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateImage(Expression<Func<SendWhatsAppTemplateImageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateDocument(Expression<Func<SendWhatsAppTemplateDocumentInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateVideo(Expression<Func<SendWhatsAppTemplateVideoInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateVideoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateVideoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateDynamicButton(Expression<Func<SendWhatsAppTemplateDynamicButtonInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDynamicButtonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-dynamic-button";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateDynamicButtonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateQuickReply(Expression<Func<SendWhatsAppTemplateQuickReplyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateQuickReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateQuickReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<StatusCheckV3Response, ApiConnectionActionConfiguration> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/messages/{0}/status", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Incoming(Expression<Func<string>> wABA, Expression<Func<IncomingV2Input>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_wABA = WorkflowExpression.Compile(wABA, nameof(wABA), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", __workflow_wABA.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TestPhoneNumberResponse
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("displayPhoneNumber")]
        public string DisplayPhoneNumber { get; set; }

        [JsonProperty("verifiedName")]
        public string VerifiedName { get; set; }

        [JsonProperty("qualityRating")]
        public string QualityRating { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("whatsAppAccountId")]
        public string WhatsAppAccountId { get; set; }

        [JsonProperty("managedBy")]
        public TestPhoneNumberResponseManagedByType ManagedBy { get; set; }

        [JsonProperty("messagingVia")]
        public TestPhoneNumberResponseMessagingViaType MessagingVia { get; set; }

        [JsonProperty("messagingTier")]
        public string MessagingTier { get; set; }

        [JsonProperty("qualityScore")]
        public TestPhoneNumberResponseQualityScoreType QualityScore { get; set; }
    }

    public class TestPhoneNumberResponseManagedByType
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }

    public class TestPhoneNumberResponseMessagingViaType
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }

    public class TestPhoneNumberResponseQualityScoreType
    {
        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class SendWhatsAppTextResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTextInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTextInputContentType Content { get; set; }
    }

    public class SendWhatsAppTextInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "text";

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class SendWhatsAppContactResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppContactInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppContactInputContentType Content { get; set; }
    }

    public class SendWhatsAppContactInputContentType
    {
        [JsonProperty("contacts")]
        public SendWhatsAppContactInputContentTypeContactsTypeItem[] Contacts { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "contacts";
    }

    public class SendWhatsAppContactInputContentTypeContactsTypeItem
    {
        [JsonProperty("addresses")]
        public SendWhatsAppContactInputContentTypeContactsTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("name")]
        public SendWhatsAppContactInputContentTypeContactsTypeItemNameType Name { get; set; }
    }

    public class SendWhatsAppContactInputContentTypeContactsTypeItemAddressesTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class SendWhatsAppContactInputContentTypeContactsTypeItemNameType
    {
        [JsonProperty("formattedName")]
        public string FormattedName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class SendWhatsAppLocationResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppLocationInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppLocationInputContentType Content { get; set; }
    }

    public class SendWhatsAppLocationInputContentType
    {
        [JsonProperty("location")]
        public SendWhatsAppLocationInputContentTypeLocationType Location { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "location";
    }

    public class SendWhatsAppLocationInputContentTypeLocationType
    {
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class SendWhatsAppQuickReplyResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppQuickReplyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyInputContentType Content { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveType Interactive { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "buttons";

        [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("buttons", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItem[] Buttons { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeHeaderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeBodyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeFooterType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItem
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "reply";

        [JsonProperty("reply")]
        public SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItemReplyType Reply { get; set; }
    }

    public class SendWhatsAppQuickReplyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItemReplyType
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SendWhatsAppProductListResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppProductListInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductListInputContentType Content { get; set; }
    }

    public class SendWhatsAppProductListInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductListInputContentTypeInteractiveType Interactive { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "productList";

        [JsonProperty("components")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("productList")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeProductListType ProductList { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeHeaderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeBodyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeFooterType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeProductListType
    {
        [JsonProperty("catalogId")]
        public string CatalogId { get; set; }

        [JsonProperty("sections")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItem[] Sections { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItem
    {
        [JsonProperty("items")]
        public SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class SendWhatsAppProductListInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItemItemsTypeItem
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }
    }

    public class SendWhatsAppProductResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppProductInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductInputContentType Content { get; set; }
    }

    public class SendWhatsAppProductInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductInputContentTypeInteractiveType Interactive { get; set; }
    }

    public class SendWhatsAppProductInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "product";

        [JsonProperty("components")]
        public SendWhatsAppProductInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppProductInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("product")]
        public SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeProductType Product { get; set; }
    }

    public class SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeHeaderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeBodyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeFooterType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppProductInputContentTypeInteractiveTypeComponentsTypeProductType
    {
        [JsonProperty("catalogId")]
        public string CatalogId { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }
    }

    public class SendWhatsAppListResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppListInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppListInputContentType Content { get; set; }
    }

    public class SendWhatsAppListInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppListInputContentTypeInteractiveType Interactive { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "list";

        [JsonProperty("components")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("list")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeListType List { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeHeaderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeBodyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeFooterType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeListType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sections")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItem[] Sections { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rows")]
        public SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItemRowsTypeItem[] Rows { get; set; }
    }

    public class SendWhatsAppListInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItemRowsTypeItem
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SendsWhatsAppImageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendsWhatsAppImageInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendsWhatsAppImageInputContentType Content { get; set; }
    }

    public class SendsWhatsAppImageInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "image";

        [JsonProperty("image")]
        public SendsWhatsAppImageInputContentTypeImageType Image { get; set; }
    }

    public class SendsWhatsAppImageInputContentTypeImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }

    public class SendWhatsAppVideoResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppVideoInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppVideoInputContentType Content { get; set; }
    }

    public class SendWhatsAppVideoInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "video";

        [JsonProperty("video")]
        public SendWhatsAppVideoInputContentTypeVideoType Video { get; set; }
    }

    public class SendWhatsAppVideoInputContentTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }

    public class SendWhatsAppDocumentResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppDocumentInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppDocumentInputContentType Content { get; set; }
    }

    public class SendWhatsAppDocumentInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "document";

        [JsonProperty("document")]
        public SendWhatsAppDocumentInputContentTypeDocumentType Document { get; set; }
    }

    public class SendWhatsAppDocumentInputContentTypeDocumentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class SendWhatsAppAudioResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppAudioInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppAudioInputContentType Content { get; set; }
    }

    public class SendWhatsAppAudioInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "audio";

        [JsonProperty("audio")]
        public SendWhatsAppAudioInputContentTypeAudioType Audio { get; set; }
    }

    public class SendWhatsAppAudioInputContentTypeAudioType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppStickerResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppStickerInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppStickerInputContentType Content { get; set; }
    }

    public class SendWhatsAppStickerInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "sticker";

        [JsonProperty("sticker")]
        public SendWhatsAppStickerInputContentTypeStickerType Sticker { get; set; }
    }

    public class SendWhatsAppStickerInputContentTypeStickerType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateTextResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateTextInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateTextInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateTextInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateTextInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateTextInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateTextInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateTextInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateTextInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateTextInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateTextInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateTextInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateLocationResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateLocationInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateLocationInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateLocationInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("location")]
        public SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemLocationType Location { get; set; }

        [JsonProperty("header-type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HeaderType { get; set; } = "location";
    }

    public class SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemLocationType
    {
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class SendWhatsAppTemplateLocationInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateImageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateImageInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateImageInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateImageInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemImageType Image { get; set; }
    }

    public class SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateImageInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "image";

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateDocumentResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateDocumentInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateDocumentInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("document")]
        public SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemDocumentType Document { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemDocumentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateDocumentInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateVideoResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateVideoInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("content")]
        public SendWhatsAppTemplateVideoInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateVideoInputContentType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("template")]
        public SendWhatsAppTemplateVideoInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateVideoInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("video")]
        public SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemVideoType Video { get; set; }
    }

    public class SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateVideoInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateDynamicButtonInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("body")]
        public SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }

        [JsonProperty("button")]
        public SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateTypeComponentsTypeButtonTypeItem[] Button { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonInputContentTypeTemplateTypeComponentsTypeButtonTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateQuickReplyInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateQuickReplyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateQuickReplyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("body")]
        public SendWhatsAppTemplateQuickReplyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }

        [JsonProperty("button")]
        public SendWhatsAppTemplateQuickReplyInputContentTypeTemplateTypeComponentsTypeButtonTypeItem[] Button { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyInputContentTypeTemplateTypeComponentsTypeButtonTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }
    }

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class IncomingV2Input
    {
        [JsonProperty("inboundMessageUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string InboundMessageUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa;

    public partial class WorkflowManagedActions
    {
        public TyntecwaActions Tyntecwa(string connectionId) => new TyntecwaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TyntecwaTriggers Tyntecwa(string connectionId) => new TyntecwaTriggers(connectionId);
    }
}
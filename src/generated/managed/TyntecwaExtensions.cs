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
        public IBodyWorkflowAction<SendWhatsAppTextResponse, ApiConnectionActionConfiguration> SendWhatsAppText(Expression<Func<SendWhatsAppTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendWhatsAppTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppContactResponse, ApiConnectionActionConfiguration> SendWhatsAppContact(Expression<Func<SendWhatsAppContactBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppContactBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppLocationResponse, ApiConnectionActionConfiguration> SendWhatsAppLocation(Expression<Func<SendWhatsAppLocationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppLocationBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse, ApiConnectionActionConfiguration> SendWhatsAppQuickReply(Expression<Func<SendWhatsAppQuickReplyBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendWhatsAppQuickReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppQuickReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductListResponse, ApiConnectionActionConfiguration> SendWhatsAppProductList(Expression<Func<SendWhatsAppProductListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppProductListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppProductListBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppProductListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductResponse, ApiConnectionActionConfiguration> SendWhatsAppProduct(Expression<Func<SendWhatsAppProductBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppProductResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppProductBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppProductResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppListResponse, ApiConnectionActionConfiguration> SendWhatsAppList(Expression<Func<SendWhatsAppListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppListBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendsWhatsAppImageResponse, ApiConnectionActionConfiguration> SendsWhatsAppImage(Expression<Func<SendsWhatsAppImageBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendsWhatsAppImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendsWhatsAppImageBodyInput().ToJToken();
                return new ApiConnectionAction<SendsWhatsAppImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppVideoResponse, ApiConnectionActionConfiguration> SendWhatsAppVideo(Expression<Func<SendWhatsAppVideoBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppVideoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppVideoBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppVideoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse, ApiConnectionActionConfiguration> SendWhatsAppDocument(Expression<Func<SendWhatsAppDocumentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppDocumentBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppAudioResponse, ApiConnectionActionConfiguration> SendWhatsAppAudio(Expression<Func<SendWhatsAppAudioBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppAudioResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/audio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppAudioBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppAudioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppStickerResponse, ApiConnectionActionConfiguration> SendWhatsAppSticker(Expression<Func<SendWhatsAppStickerBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppStickerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/sticker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppStickerBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppStickerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateText(Expression<Func<SendWhatsAppTemplateTextBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppTemplateTextBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppTemplateTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateLocation(Expression<Func<SendWhatsAppTemplateLocationBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendWhatsAppTemplateLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateImage(Expression<Func<SendWhatsAppTemplateImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendWhatsAppTemplateImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendWhatsAppTemplateImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateDocument(Expression<Func<SendWhatsAppTemplateDocumentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppTemplateDocumentBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppTemplateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateVideo(Expression<Func<SendWhatsAppTemplateVideoBodyInput>> body = null)
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
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateDynamicButton(Expression<Func<SendWhatsAppTemplateDynamicButtonBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDynamicButtonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-dynamic-button";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppTemplateDynamicButtonBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppTemplateDynamicButtonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateQuickReply(Expression<Func<SendWhatsAppTemplateQuickReplyBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateQuickReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new SendWhatsAppTemplateQuickReplyBodyInput().ToJToken();
                return new ApiConnectionAction<SendWhatsAppTemplateQuickReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<StatusCheckResponse, ApiConnectionActionConfiguration> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/messages/{0}/status", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckResponse>(callPayload);
            });
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> Incoming(Expression<Func<string>> waba)
        {
            var __workflow_waba = WorkflowExpression.Compile(waba, nameof(waba), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", __workflow_waba.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new IncomingBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
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

    public class SendWhatsAppTextBodyInput
    {
        public SendWhatsAppTextBodyInput(string from, string to, SendWhatsAppTextBodyInputContentType content)
        {
            this.From = from;
            this.To = to;
            this.Content = content;
        }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTextBodyInputContentType Content { get; set; }
    }

    public class SendWhatsAppTextBodyInputContentType
    {
        public SendWhatsAppTextBodyInputContentType(string text)
        {
            this.Text = text;
        }

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

    public class SendWhatsAppContactBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppContactBodyInputContentType Content { get; set; } = new SendWhatsAppContactBodyInputContentType();
    }

    public class SendWhatsAppContactBodyInputContentType
    {
        [JsonProperty("contacts")]
        public BodyInputContentTypeContactsTypeItem[] Contacts { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "contacts";
    }

    public class BodyInputContentTypeContactsTypeItem
    {
        [JsonProperty("addresses")]
        public BodyInputContentTypeContactsTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("name")]
        public BodyInputContentTypeContactsTypeItemNameType Name { get; set; }
    }

    public class BodyInputContentTypeContactsTypeItemAddressesTypeItem
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

    public class BodyInputContentTypeContactsTypeItemNameType
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

    public class SendWhatsAppLocationBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppLocationBodyInputContentType Content { get; set; } = new SendWhatsAppLocationBodyInputContentType();
    }

    public class SendWhatsAppLocationBodyInputContentType
    {
        [JsonProperty("location")]
        public BodyInputContentTypeLocationType Location { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "location";
    }

    public class BodyInputContentTypeLocationType
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

    public class SendWhatsAppQuickReplyBodyInput
    {
        public SendWhatsAppQuickReplyBodyInput(SendWhatsAppQuickReplyBodyInputContentType content)
        {
            this.Content = content;
        }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyBodyInputContentType Content { get; set; }
    }

    public class SendWhatsAppQuickReplyBodyInputContentType
    {
        public SendWhatsAppQuickReplyBodyInputContentType(SendWhatsAppQuickReplyBodyInputContentTypeInteractiveType interactive)
        {
            this.Interactive = interactive;
        }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyBodyInputContentTypeInteractiveType Interactive { get; set; }
    }

    public class SendWhatsAppQuickReplyBodyInputContentTypeInteractiveType
    {
        public SendWhatsAppQuickReplyBodyInputContentTypeInteractiveType(SendWhatsAppQuickReplyBodyInputContentTypeInteractiveTypeComponentsType components)
        {
            this.Components = components;
        }

        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "buttons";

        [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppQuickReplyBodyInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppQuickReplyBodyInputContentTypeInteractiveTypeComponentsType
    {
        public SendWhatsAppQuickReplyBodyInputContentTypeInteractiveTypeComponentsType(BodyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItem[] buttons)
        {
            this.Buttons = buttons;
        }

        [JsonProperty("header")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("buttons", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItem[] Buttons { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeHeaderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeBodyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeFooterType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItem
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "reply";

        [JsonProperty("reply")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItemReplyType Reply { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeButtonsTypeItemReplyType
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

    public class SendWhatsAppProductListBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductListBodyInputContentType Content { get; set; } = new SendWhatsAppProductListBodyInputContentType();
    }

    public class SendWhatsAppProductListBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductListBodyInputContentTypeInteractiveType Interactive { get; set; } = new SendWhatsAppProductListBodyInputContentTypeInteractiveType();
    }

    public class SendWhatsAppProductListBodyInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "productList";

        [JsonProperty("components")]
        public SendWhatsAppProductListBodyInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppProductListBodyInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("productList")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeProductListType ProductList { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeProductListType
    {
        [JsonProperty("catalogId")]
        public string CatalogId { get; set; }

        [JsonProperty("sections")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItem[] Sections { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItem
    {
        [JsonProperty("items")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeProductListTypeSectionsTypeItemItemsTypeItem
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

    public class SendWhatsAppProductBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductBodyInputContentType Content { get; set; } = new SendWhatsAppProductBodyInputContentType();
    }

    public class SendWhatsAppProductBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppProductBodyInputContentTypeInteractiveType Interactive { get; set; } = new SendWhatsAppProductBodyInputContentTypeInteractiveType();
    }

    public class SendWhatsAppProductBodyInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "product";

        [JsonProperty("components")]
        public SendWhatsAppProductBodyInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppProductBodyInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("product")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeProductType Product { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeProductType
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

    public class SendWhatsAppListBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppListBodyInputContentType Content { get; set; } = new SendWhatsAppListBodyInputContentType();
    }

    public class SendWhatsAppListBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "interactive";

        [JsonProperty("interactive", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppListBodyInputContentTypeInteractiveType Interactive { get; set; } = new SendWhatsAppListBodyInputContentTypeInteractiveType();
    }

    public class SendWhatsAppListBodyInputContentTypeInteractiveType
    {
        [JsonProperty("subType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubType { get; set; } = "list";

        [JsonProperty("components")]
        public SendWhatsAppListBodyInputContentTypeInteractiveTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppListBodyInputContentTypeInteractiveTypeComponentsType
    {
        [JsonProperty("header")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeHeaderType Header { get; set; }

        [JsonProperty("body")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeBodyType Body { get; set; }

        [JsonProperty("footer")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeFooterType Footer { get; set; }

        [JsonProperty("list")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeListType List { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeListType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sections")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItem[] Sections { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rows")]
        public BodyInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItemRowsTypeItem[] Rows { get; set; }
    }

    public class BodyInputContentTypeInteractiveTypeComponentsTypeListTypeSectionsTypeItemRowsTypeItem
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

    public class SendsWhatsAppImageBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendsWhatsAppImageBodyInputContentType Content { get; set; } = new SendsWhatsAppImageBodyInputContentType();
    }

    public class SendsWhatsAppImageBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "image";

        [JsonProperty("image")]
        public BodyInputContentTypeImageType Image { get; set; }
    }

    public class BodyInputContentTypeImageType
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

    public class SendWhatsAppVideoBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppVideoBodyInputContentType Content { get; set; } = new SendWhatsAppVideoBodyInputContentType();
    }

    public class SendWhatsAppVideoBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "video";

        [JsonProperty("video")]
        public BodyInputContentTypeVideoType Video { get; set; }
    }

    public class BodyInputContentTypeVideoType
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

    public class SendWhatsAppDocumentBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppDocumentBodyInputContentType Content { get; set; } = new SendWhatsAppDocumentBodyInputContentType();
    }

    public class SendWhatsAppDocumentBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "document";

        [JsonProperty("document")]
        public BodyInputContentTypeDocumentType Document { get; set; }
    }

    public class BodyInputContentTypeDocumentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }
    }

    public class SendWhatsAppAudioResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppAudioBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppAudioBodyInputContentType Content { get; set; } = new SendWhatsAppAudioBodyInputContentType();
    }

    public class SendWhatsAppAudioBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "audio";

        [JsonProperty("audio")]
        public BodyInputContentTypeAudioType Audio { get; set; }
    }

    public class BodyInputContentTypeAudioType
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

    public class SendWhatsAppStickerBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppStickerBodyInputContentType Content { get; set; } = new SendWhatsAppStickerBodyInputContentType();
    }

    public class SendWhatsAppStickerBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "sticker";

        [JsonProperty("sticker")]
        public BodyInputContentTypeStickerType Sticker { get; set; }
    }

    public class BodyInputContentTypeStickerType
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

    public class SendWhatsAppTemplateTextBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateTextBodyInputContentType Content { get; set; } = new SendWhatsAppTemplateTextBodyInputContentType();
    }

    public class SendWhatsAppTemplateTextBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateTextBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateTextBodyInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateTextBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateTextBodyInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateTextBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateTextBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
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

    public class SendWhatsAppTemplateLocationBodyInput
    {
        public SendWhatsAppTemplateLocationBodyInput(SendWhatsAppTemplateLocationBodyInputContentType content)
        {
            this.Content = content;
        }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationBodyInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateLocationBodyInputContentType
    {
        public SendWhatsAppTemplateLocationBodyInputContentType(SendWhatsAppTemplateLocationBodyInputContentTypeTemplateType template)
        {
            this.Template = template;
        }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateLocationBodyInputContentTypeTemplateType
    {
        public SendWhatsAppTemplateLocationBodyInputContentTypeTemplateType(SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsType components)
        {
            this.Components = components;
        }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsType
    {
        public SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsType(SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] header)
        {
            this.Header = header;
        }

        [JsonProperty("header", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateLocationBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("location")]
        public BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemLocationType Location { get; set; }

        [JsonProperty("header-type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HeaderType { get; set; } = "location";
    }

    public class BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemLocationType
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

    public class SendWhatsAppTemplateImageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateImageBodyInput
    {
        public SendWhatsAppTemplateImageBodyInput(SendWhatsAppTemplateImageBodyInputContentType content)
        {
            this.Content = content;
        }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageBodyInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateImageBodyInputContentType
    {
        public SendWhatsAppTemplateImageBodyInputContentType(SendWhatsAppTemplateImageBodyInputContentTypeTemplateType template)
        {
            this.Template = template;
        }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateImageBodyInputContentTypeTemplateType
    {
        public SendWhatsAppTemplateImageBodyInputContentTypeTemplateType(SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsType components)
        {
            this.Components = components;
        }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsType
    {
        public SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsType(SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] body)
        {
            this.Body = body;
        }

        [JsonProperty("header")]
        public SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemImageType Image { get; set; }
    }

    public class BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateImageBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem
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

    public class SendWhatsAppTemplateDocumentBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateDocumentBodyInputContentType Content { get; set; } = new SendWhatsAppTemplateDocumentBodyInputContentType();
    }

    public class SendWhatsAppTemplateDocumentBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("document")]
        public BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemDocumentType Document { get; set; }
    }

    public class BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemDocumentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateVideoResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateVideoBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("content")]
        public SendWhatsAppTemplateVideoBodyInputContentType Content { get; set; }
    }

    public class SendWhatsAppTemplateVideoBodyInputContentType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("template")]
        public SendWhatsAppTemplateVideoBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateVideoBodyInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateVideoBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateVideoBodyInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("header")]
        public SendWhatsAppTemplateVideoBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendWhatsAppTemplateVideoBodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("video")]
        public BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemVideoType Video { get; set; }
    }

    public class BodyInputContentTypeTemplateTypeComponentsTypeHeaderTypeItemVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateDynamicButtonBodyInputContentType Content { get; set; } = new SendWhatsAppTemplateDynamicButtonBodyInputContentType();
    }

    public class SendWhatsAppTemplateDynamicButtonBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateDynamicButtonBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonBodyInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateDynamicButtonBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonBodyInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }

        [JsonProperty("button")]
        public SendWhatsAppTemplateDynamicButtonBodyInputContentTypeTemplateTypeComponentsTypeButtonTypeItem[] Button { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonBodyInputContentTypeTemplateTypeComponentsTypeButtonTypeItem
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

    public class SendWhatsAppTemplateQuickReplyBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "whatsapp";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendWhatsAppTemplateQuickReplyBodyInputContentType Content { get; set; } = new SendWhatsAppTemplateQuickReplyBodyInputContentType();
    }

    public class SendWhatsAppTemplateQuickReplyBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "template";

        [JsonProperty("template")]
        public SendWhatsAppTemplateQuickReplyBodyInputContentTypeTemplateType Template { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyBodyInputContentTypeTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateLanguage")]
        public string TemplateLanguage { get; set; }

        [JsonProperty("components")]
        public SendWhatsAppTemplateQuickReplyBodyInputContentTypeTemplateTypeComponentsType Components { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyBodyInputContentTypeTemplateTypeComponentsType
    {
        [JsonProperty("body")]
        public SendWhatsAppTemplateDocumentBodyInputContentTypeTemplateTypeComponentsTypeBodyTypeItem[] Body { get; set; }

        [JsonProperty("button")]
        public SendWhatsAppTemplateQuickReplyBodyInputContentTypeTemplateTypeComponentsTypeButtonTypeItem[] Button { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyBodyInputContentTypeTemplateTypeComponentsTypeButtonTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }
    }

    public class StatusCheckResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class IncomingBodyInput
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
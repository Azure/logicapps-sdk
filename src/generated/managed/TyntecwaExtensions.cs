//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecwaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<TestPhoneNumberResponse> TestPhoneNumber(Expression<Func<string>> whatsAppBusinessNumber)
        {
            var apiCallPath = String.Format("/conversations/v3/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(whatsAppBusinessNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TestPhoneNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheckV3(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse> SendWhatsAppTemplateVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodychannel = null, Expression<Func<string>> bodycontentcontentType = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-video";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
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

            if (bodychannel != null)
            {
                body["channel"] = ExpressionConverter.ConvertO(bodychannel);
                bodypropCount++;
            }

            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            if (bodycontentcontentType != null)
            {
                contentObject["contentType"] = ExpressionConverter.ConvertO(bodycontentcontentType);
                contentObjectpropCount++;
            }

            var templateObject = new JObject();
            var templateObjectpropCount = 0;
            if (bodycontenttemplatetemplateId != null)
            {
                templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                templateObjectpropCount++;
            }

            if (bodycontenttemplatetemplateLanguage != null)
            {
                templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                templateObjectpropCount++;
            }

            var componentsObject = new JObject();
            var componentsObjectpropCount = 0;
            if (bodycontenttemplatecomponentsheader != null)
            {
                componentsObject["header"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsheader);
                componentsObjectpropCount++;
            }

            if (bodycontenttemplatecomponentsbody != null)
            {
                componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                componentsObjectpropCount++;
            }

            if (componentsObjectpropCount > 0)
            {
                templateObject["components"] = componentsObject;
                templateObjectpropCount++;
            }

            if (templateObjectpropCount > 0)
            {
                contentObject["template"] = templateObject;
                contentObjectpropCount++;
            }

            if (contentObjectpropCount > 0)
            {
                body["content"] = contentObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateVideoResponse>(callPayload);
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger IncomingV2(Expression<Func<string>> wABA, string triggerName = null)
        {
            var apiCallPath = String.Format("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(wABA, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["inboundMessageUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateVideoResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("video")]
        public bodycontenttemplatecomponentsheaderInputItemVideoType Video { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItemVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class bodycontenttemplatecomponentsbodyInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
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
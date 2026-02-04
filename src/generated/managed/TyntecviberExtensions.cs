//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecviber
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecviberActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberTextV3Response> SendViberTextV3(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<string>> bodycontenttext = null)
        {
            var apiCallPath = "/conversations/v3/power-automate/messages/viber/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            body["channel"] = "viber";
            bodypropCount++;
            bodypropCount++;
            body["rateType"] = ExpressionConverter.ConvertO(bodyrateType);
            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            contentObject["contentType"] = "text";
            contentObjectpropCount++;
            if (bodycontenttext != null)
            {
                contentObject["text"] = ExpressionConverter.ConvertO(bodycontenttext);
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

            return new ApiConnectionAction<SendViberTextV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberImageV3Response> SendViberImageV3(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<string>> bodycontentimageurl)
        {
            var apiCallPath = "/conversations/v3/power-automate/messages/viber/image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            body["channel"] = "viber";
            bodypropCount++;
            bodypropCount++;
            body["rateType"] = ExpressionConverter.ConvertO(bodyrateType);
            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            contentObject["contentType"] = "image";
            contentObjectpropCount++;
            var imageObject = new JObject();
            var imageObjectpropCount = 0;
            imageObjectpropCount++;
            imageObject["url"] = ExpressionConverter.ConvertO(bodycontentimageurl);
            if (imageObjectpropCount > 0)
            {
                contentObject["image"] = imageObject;
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

            return new ApiConnectionAction<SendViberImageV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberFileV3Response> SendViberFileV3(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodymessagePurpose, Expression<Func<string>> bodycontentfileurl, Expression<Func<string>> bodycontentfilefilename, Expression<Func<string>> bodycontentfilefiletype)
        {
            var apiCallPath = "/conversations/v3/power-automate/messages/viber/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            body["channel"] = "viber";
            bodypropCount++;
            bodypropCount++;
            body["messagePurpose"] = ExpressionConverter.ConvertO(bodymessagePurpose);
            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            contentObject["contentType"] = "file";
            contentObjectpropCount++;
            var fileObject = new JObject();
            var fileObjectpropCount = 0;
            fileObjectpropCount++;
            fileObject["url"] = ExpressionConverter.ConvertO(bodycontentfileurl);
            fileObjectpropCount++;
            fileObject["filename"] = ExpressionConverter.ConvertO(bodycontentfilefilename);
            fileObjectpropCount++;
            fileObject["filetype"] = ExpressionConverter.ConvertO(bodycontentfilefiletype);
            if (fileObjectpropCount > 0)
            {
                contentObject["file"] = fileObject;
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

            return new ApiConnectionAction<SendViberFileV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberComplexV3Response> SendViberComplexV3(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<bodycontentcomponentsbodyInputItem[]>> bodycontentcomponentsbody = null)
        {
            var apiCallPath = "/conversations/v3/power-automate/messages/viber/components";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            body["channel"] = "viber";
            bodypropCount++;
            bodypropCount++;
            body["rateType"] = ExpressionConverter.ConvertO(bodyrateType);
            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            contentObject["contentType"] = "components";
            contentObjectpropCount++;
            var componentsObject = new JObject();
            var componentsObjectpropCount = 0;
            if (bodycontentcomponentsbody != null)
            {
                componentsObject["body"] = ExpressionConverter.ConvertO(bodycontentcomponentsbody);
                componentsObjectpropCount++;
            }

            if (componentsObjectpropCount > 0)
            {
                contentObject["components"] = componentsObject;
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

            return new ApiConnectionAction<SendViberComplexV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheckV3(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
        }
    }

    public class TyntecviberTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger IncomingV3(Expression<Func<string>> viberServiceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(viberServiceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["inboundMessageUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class SendViberTextV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberImageV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberFileV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberComplexV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontentcomponentsbodyInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public bodycontentcomponentsbodyInputItemImageType Image { get; set; }

        [JsonProperty("button")]
        public bodycontentcomponentsbodyInputItemButtonType Button { get; set; }
    }

    public class bodycontentcomponentsbodyInputItemImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class bodycontentcomponentsbodyInputItemButtonType
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }
    }

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("deliveryChannel")]
        public string DeliveryChannel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecviber;

    public partial class WorkflowManagedActions
    {
        public TyntecviberActions Tyntecviber(string connectionId) => new TyntecviberActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TyntecviberTriggers Tyntecviber(string connectionId) => new TyntecviberTriggers(connectionId);
    }
}
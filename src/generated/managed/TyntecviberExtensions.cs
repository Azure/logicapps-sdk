//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecviber
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TyntecviberActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberComplexV3Response> SendViberComplex(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<bodycontentcomponentsbodyInputItem[]>> bodycontentcomponentsbody = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodyrateType = bodyrateType == null ? null : WorkflowExpression.Compile(bodyrateType);
            WorkflowExpression.Validate(__workflow_bodyrateType, nameof(bodyrateType), required: true);
            var __workflow_bodycontentcomponentsbody = bodycontentcomponentsbody == null ? null : WorkflowExpression.Compile(bodycontentcomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontentcomponentsbody, nameof(bodycontentcomponentsbody), required: false);
            return new DeferredBodyAction<SendViberComplexV3Response>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/components";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["rateType"] = ExpressionConverter.ConvertO(__workflow_bodyrateType);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "components";
                contentObjectpropCount++;
                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontentcomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontentcomponentsbody);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberFileV3Response> SendViberFile(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodymessagePurpose, Expression<Func<string>> bodycontentfileurl, Expression<Func<string>> bodycontentfilefilename, Expression<Func<string>> bodycontentfilefiletype)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodymessagePurpose = bodymessagePurpose == null ? null : WorkflowExpression.Compile(bodymessagePurpose);
            WorkflowExpression.Validate(__workflow_bodymessagePurpose, nameof(bodymessagePurpose), required: true);
            var __workflow_bodycontentfileurl = bodycontentfileurl == null ? null : WorkflowExpression.Compile(bodycontentfileurl);
            WorkflowExpression.Validate(__workflow_bodycontentfileurl, nameof(bodycontentfileurl), required: true);
            var __workflow_bodycontentfilefilename = bodycontentfilefilename == null ? null : WorkflowExpression.Compile(bodycontentfilefilename);
            WorkflowExpression.Validate(__workflow_bodycontentfilefilename, nameof(bodycontentfilefilename), required: true);
            var __workflow_bodycontentfilefiletype = bodycontentfilefiletype == null ? null : WorkflowExpression.Compile(bodycontentfilefiletype);
            WorkflowExpression.Validate(__workflow_bodycontentfilefiletype, nameof(bodycontentfilefiletype), required: true);
            return new DeferredBodyAction<SendViberFileV3Response>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["messagePurpose"] = ExpressionConverter.ConvertO(__workflow_bodymessagePurpose);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "file";
                contentObjectpropCount++;
                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentfileurl);
                fileObjectpropCount++;
                fileObject["filename"] = ExpressionConverter.ConvertO(__workflow_bodycontentfilefilename);
                fileObjectpropCount++;
                fileObject["filetype"] = ExpressionConverter.ConvertO(__workflow_bodycontentfilefiletype);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberImageV3Response> SendViberImage(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<string>> bodycontentimageurl)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodyrateType = bodyrateType == null ? null : WorkflowExpression.Compile(bodyrateType);
            WorkflowExpression.Validate(__workflow_bodyrateType, nameof(bodyrateType), required: true);
            var __workflow_bodycontentimageurl = bodycontentimageurl == null ? null : WorkflowExpression.Compile(bodycontentimageurl);
            WorkflowExpression.Validate(__workflow_bodycontentimageurl, nameof(bodycontentimageurl), required: true);
            return new DeferredBodyAction<SendViberImageV3Response>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["rateType"] = ExpressionConverter.ConvertO(__workflow_bodyrateType);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "image";
                contentObjectpropCount++;
                var imageObject = new JObject();
                var imageObjectpropCount = 0;
                imageObjectpropCount++;
                imageObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentimageurl);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberTextV3Response> SendViberText(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<string>> bodycontenttext = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodyrateType = bodyrateType == null ? null : WorkflowExpression.Compile(bodyrateType);
            WorkflowExpression.Validate(__workflow_bodyrateType, nameof(bodyrateType), required: true);
            var __workflow_bodycontenttext = bodycontenttext == null ? null : WorkflowExpression.Compile(bodycontenttext);
            WorkflowExpression.Validate(__workflow_bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendViberTextV3Response>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["rateType"] = ExpressionConverter.ConvertO(__workflow_bodyrateType);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (__workflow_bodycontenttext != null)
                {
                    contentObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontenttext);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecviberTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Incoming(Expression<Func<string>> viberServiceId, FlowRecurrence recurrence = null)
        {
            var __workflow_viberServiceId = viberServiceId == null ? null : WorkflowExpression.Compile(viberServiceId);
            WorkflowExpression.Validate(__workflow_viberServiceId, nameof(viberServiceId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_viberServiceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["inboundMessageUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
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

    public class SendViberFileV3Response
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

    public class SendViberTextV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
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

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecviber
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecviberActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberComplexV3Response, ApiConnectionActionConfiguration> SendViberComplex(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<bodycontentcomponentsbodyInputItem[]>> bodycontentcomponentsbody = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodyrateType = WorkflowExpression.Compile(bodyrateType, nameof(bodyrateType), required: true);
            var __workflow_bodycontentcomponentsbody = WorkflowExpression.Compile(bodycontentcomponentsbody, nameof(bodycontentcomponentsbody), required: false);
            return new DeferredBodyAction<SendViberComplexV3Response, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendViberFileV3Response, ApiConnectionActionConfiguration> SendViberFile(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodymessagePurpose, Expression<Func<string>> bodycontentFileurl, Expression<Func<string>> bodycontentFilefilename, Expression<Func<string>> bodycontentFilefiletype)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodymessagePurpose = WorkflowExpression.Compile(bodymessagePurpose, nameof(bodymessagePurpose), required: true);
            var __workflow_bodycontentFileurl = WorkflowExpression.Compile(bodycontentFileurl, nameof(bodycontentFileurl), required: true);
            var __workflow_bodycontentFilefilename = WorkflowExpression.Compile(bodycontentFilefilename, nameof(bodycontentFilefilename), required: true);
            var __workflow_bodycontentFilefiletype = WorkflowExpression.Compile(bodycontentFilefiletype, nameof(bodycontentFilefiletype), required: true);
            return new DeferredBodyAction<SendViberFileV3Response, ApiConnectionActionConfiguration>(() =>
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
                var @fileObject = new JObject();
                var @fileObjectpropCount = 0;
                @fileObjectpropCount++;
                @fileObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentFileurl);
                @fileObjectpropCount++;
                @fileObject["filename"] = ExpressionConverter.ConvertO(__workflow_bodycontentFilefilename);
                @fileObjectpropCount++;
                @fileObject["filetype"] = ExpressionConverter.ConvertO(__workflow_bodycontentFilefiletype);
                if (@fileObjectpropCount > 0)
                {
                    contentObject["file"] = @fileObject;
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
        public IBodyWorkflowAction<SendViberImageV3Response, ApiConnectionActionConfiguration> SendViberImage(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<string>> bodycontentimageurl)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodyrateType = WorkflowExpression.Compile(bodyrateType, nameof(bodyrateType), required: true);
            var __workflow_bodycontentimageurl = WorkflowExpression.Compile(bodycontentimageurl, nameof(bodycontentimageurl), required: true);
            return new DeferredBodyAction<SendViberImageV3Response, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendViberTextV3Response, ApiConnectionActionConfiguration> SendViberText(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodyrateType, Expression<Func<string>> bodycontenttext = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodyrateType = WorkflowExpression.Compile(bodyrateType, nameof(bodyrateType), required: true);
            var __workflow_bodycontenttext = WorkflowExpression.Compile(bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendViberTextV3Response, ApiConnectionActionConfiguration>(() =>
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

    public class TyntecviberTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Incoming(Expression<Func<string>> viberServiceId, FlowRecurrence recurrence = null)
        {
            var __workflow_viberServiceId = WorkflowExpression.Compile(viberServiceId, nameof(viberServiceId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", __workflow_viberServiceId.WithUrlEncoding(1)));
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
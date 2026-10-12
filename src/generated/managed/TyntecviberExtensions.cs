//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecviber
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecviberActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        [WorkflowExpressionFactory(nameof(__BuildSendViberComplex))]
        public IBodyWorkflowAction<SendViberComplexV3Response> SendViberComplex([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyrateType, [WorkflowExpression] Func<bodycontentcomponentsbodyInputItem[]> bodycontentcomponentsbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendViberComplexV3Response> __BuildSendViberComplex(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodyrateType, WorkflowExpression<bodycontentcomponentsbodyInputItem[]> bodycontentcomponentsbody = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyrateType, nameof(bodyrateType), required: true);
            WorkflowExpression.Validate(bodycontentcomponentsbody, nameof(bodycontentcomponentsbody), required: false);
            return new DeferredBodyAction<SendViberComplexV3Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        [WorkflowExpressionFactory(nameof(__BuildSendViberFile))]
        public IBodyWorkflowAction<SendViberFileV3Response> SendViberFile([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodymessagePurpose, [WorkflowExpression] Func<string> bodycontentfileurl, [WorkflowExpression] Func<string> bodycontentfilefilename, [WorkflowExpression] Func<string> bodycontentfilefiletype)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendViberFileV3Response> __BuildSendViberFile(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodymessagePurpose, WorkflowExpression<string> bodycontentfileurl, WorkflowExpression<string> bodycontentfilefilename, WorkflowExpression<string> bodycontentfilefiletype)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodymessagePurpose, nameof(bodymessagePurpose), required: true);
            WorkflowExpression.Validate(bodycontentfileurl, nameof(bodycontentfileurl), required: true);
            WorkflowExpression.Validate(bodycontentfilefilename, nameof(bodycontentfilefilename), required: true);
            WorkflowExpression.Validate(bodycontentfilefiletype, nameof(bodycontentfilefiletype), required: true);
            return new DeferredBodyAction<SendViberFileV3Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        [WorkflowExpressionFactory(nameof(__BuildSendViberImage))]
        public IBodyWorkflowAction<SendViberImageV3Response> SendViberImage([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyrateType, [WorkflowExpression] Func<string> bodycontentimageurl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendViberImageV3Response> __BuildSendViberImage(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodyrateType, WorkflowExpression<string> bodycontentimageurl)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyrateType, nameof(bodyrateType), required: true);
            WorkflowExpression.Validate(bodycontentimageurl, nameof(bodycontentimageurl), required: true);
            return new DeferredBodyAction<SendViberImageV3Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        [WorkflowExpressionFactory(nameof(__BuildSendViberText))]
        public IBodyWorkflowAction<SendViberTextV3Response> SendViberText([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyrateType, [WorkflowExpression] Func<string> bodycontenttext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendViberTextV3Response> __BuildSendViberText(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodyrateType, WorkflowExpression<string> bodycontenttext = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyrateType, nameof(bodyrateType), required: true);
            WorkflowExpression.Validate(bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendViberTextV3Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        [WorkflowExpressionFactory(nameof(__BuildStatusCheck))]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatusCheckV3Response> __BuildStatusCheck(WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecviberTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildIncoming))]
        public IWorkflowTrigger Incoming([WorkflowExpression] Func<string> viberServiceId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildIncoming(WorkflowExpression<string> viberServiceId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(viberServiceId, nameof(viberServiceId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(viberServiceId, 1));
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
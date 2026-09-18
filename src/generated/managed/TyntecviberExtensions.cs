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
        public IBodyWorkflowAction<SendViberComplexV3Response> SendViberComplex([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyrateType, [WorkflowExpression] Func<bodycontentcomponentsbodyInputItem[]> bodycontentcomponentsbody = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyrateType, nameof(bodyrateType), required: true);
            SourceExpression.Validate(bodycontentcomponentsbody, nameof(bodycontentcomponentsbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/components";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["rateType"] = SourceExpressionConverter.ConvertToken(bodyrateType);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "components";
                contentObjectpropCount++;
                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontentcomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontentcomponentsbody);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendViberComplexV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberFileV3Response> SendViberFile([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodymessagePurpose, [WorkflowExpression] Func<string> bodycontentfileurl, [WorkflowExpression] Func<string> bodycontentfilefilename, [WorkflowExpression] Func<string> bodycontentfilefiletype)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodymessagePurpose, nameof(bodymessagePurpose), required: true);
            SourceExpression.Validate(bodycontentfileurl, nameof(bodycontentfileurl), required: true);
            SourceExpression.Validate(bodycontentfilefilename, nameof(bodycontentfilefilename), required: true);
            SourceExpression.Validate(bodycontentfilefiletype, nameof(bodycontentfilefiletype), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["messagePurpose"] = SourceExpressionConverter.ConvertToken(bodymessagePurpose);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "file";
                contentObjectpropCount++;
                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentfileurl);
                fileObjectpropCount++;
                fileObject["filename"] = SourceExpressionConverter.ConvertToken(bodycontentfilefilename);
                fileObjectpropCount++;
                fileObject["filetype"] = SourceExpressionConverter.ConvertToken(bodycontentfilefiletype);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendViberFileV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberImageV3Response> SendViberImage([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyrateType, [WorkflowExpression] Func<string> bodycontentimageurl)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyrateType, nameof(bodyrateType), required: true);
            SourceExpression.Validate(bodycontentimageurl, nameof(bodycontentimageurl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["rateType"] = SourceExpressionConverter.ConvertToken(bodyrateType);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "image";
                contentObjectpropCount++;
                var imageObject = new JObject();
                var imageObjectpropCount = 0;
                imageObjectpropCount++;
                imageObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentimageurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendViberImageV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberTextV3Response> SendViberText([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyrateType, [WorkflowExpression] Func<string> bodycontenttext = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyrateType, nameof(bodyrateType), required: true);
            SourceExpression.Validate(bodycontenttext, nameof(bodycontenttext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                body["channel"] = "viber";
                bodypropCount++;
                bodypropCount++;
                body["rateType"] = SourceExpressionConverter.ConvertToken(bodyrateType);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (bodycontenttext != null)
                {
                    contentObject["text"] = SourceExpressionConverter.ConvertToken(bodycontenttext);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendViberTextV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck([WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatusCheckV3Response>(BuildSourceInput);
        }
    }

    public class TyntecviberTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Incoming([WorkflowExpression] Func<string> viberServiceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(viberServiceId, nameof(viberServiceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(viberServiceId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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
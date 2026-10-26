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
        public IBodyWorkflowAction<SendViberComplexV3Response, ApiConnectionActionConfiguration> SendViberComplex(Expression<Func<SendViberComplexV3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberComplexV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/components";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberComplexV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberFileV3Response, ApiConnectionActionConfiguration> SendViberFile(Expression<Func<SendViberFileV3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberFileV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberFileV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberImageV3Response, ApiConnectionActionConfiguration> SendViberImage(Expression<Func<SendViberImageV3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberImageV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberImageV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberTextV3Response, ApiConnectionActionConfiguration> SendViberText(Expression<Func<SendViberTextV3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberTextV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Incoming(Expression<Func<string>> viberServiceId, Expression<Func<IncomingV3Input>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_viberServiceId = WorkflowExpression.Compile(viberServiceId, nameof(viberServiceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", __workflow_viberServiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class SendViberComplexV3Input
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "viber";

        [JsonProperty("rateType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RateType { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendViberComplexV3InputContentType Content { get; set; }
    }

    public class SendViberComplexV3InputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "components";

        [JsonProperty("components")]
        public SendViberComplexV3InputContentTypeComponentsType Components { get; set; }
    }

    public class SendViberComplexV3InputContentTypeComponentsType
    {
        [JsonProperty("body")]
        public SendViberComplexV3InputContentTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class SendViberComplexV3InputContentTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public SendViberComplexV3InputContentTypeComponentsTypeBodyTypeItemImageType Image { get; set; }

        [JsonProperty("button")]
        public SendViberComplexV3InputContentTypeComponentsTypeBodyTypeItemButtonType Button { get; set; }
    }

    public class SendViberComplexV3InputContentTypeComponentsTypeBodyTypeItemImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendViberComplexV3InputContentTypeComponentsTypeBodyTypeItemButtonType
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

    public class SendViberFileV3Input
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "viber";

        [JsonProperty("messagePurpose", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessagePurpose { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendViberFileV3InputContentType Content { get; set; }
    }

    public class SendViberFileV3InputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "file";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendViberFileV3InputContentTypeFileType File { get; set; }
    }

    public class SendViberFileV3InputContentTypeFileType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }

        [JsonProperty("filetype", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filetype { get; set; }
    }

    public class SendViberImageV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberImageV3Input
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "viber";

        [JsonProperty("rateType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RateType { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendViberImageV3InputContentType Content { get; set; }
    }

    public class SendViberImageV3InputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "image";

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendViberImageV3InputContentTypeImageType Image { get; set; }
    }

    public class SendViberImageV3InputContentTypeImageType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }
    }

    public class SendViberTextV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberTextV3Input
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "viber";

        [JsonProperty("rateType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RateType { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendViberTextV3InputContentType Content { get; set; }
    }

    public class SendViberTextV3InputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "text";

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
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

    public class IncomingV3Input
    {
        [JsonProperty("inboundMessageUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string InboundMessageUrl { get; set; } = "#{listCallbackUrl()}";
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
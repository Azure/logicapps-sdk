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
        public IBodyWorkflowAction<SendViberComplexResponse, ApiConnectionActionConfiguration> SendViberComplex(Expression<Func<SendViberComplexBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberComplexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/components";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberComplexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberFileResponse, ApiConnectionActionConfiguration> SendViberFile(Expression<Func<SendViberFileBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberImageResponse, ApiConnectionActionConfiguration> SendViberImage(Expression<Func<SendViberImageBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<SendViberTextResponse, ApiConnectionActionConfiguration> SendViberText(Expression<Func<SendViberTextBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendViberTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/viber/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendViberTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
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
                callPayload.Body = new IncomingBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendViberComplexResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberComplexBodyInput
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
        public SendViberComplexBodyInputContentType Content { get; set; } = new SendViberComplexBodyInputContentType();
    }

    public class SendViberComplexBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "components";

        [JsonProperty("components")]
        public BodyInputContentTypeComponentsType Components { get; set; }
    }

    public class BodyInputContentTypeComponentsType
    {
        [JsonProperty("body")]
        public BodyInputContentTypeComponentsTypeBodyTypeItem[] Body { get; set; }
    }

    public class BodyInputContentTypeComponentsTypeBodyTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public BodyInputContentTypeComponentsTypeBodyTypeItemImageType Image { get; set; }

        [JsonProperty("button")]
        public BodyInputContentTypeComponentsTypeBodyTypeItemButtonType Button { get; set; }
    }

    public class BodyInputContentTypeComponentsTypeBodyTypeItemImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BodyInputContentTypeComponentsTypeBodyTypeItemButtonType
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }
    }

    public class SendViberFileResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberFileBodyInput
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
        public SendViberFileBodyInputContentType Content { get; set; } = new SendViberFileBodyInputContentType();
    }

    public class SendViberFileBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "file";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputContentTypeFileType File { get; set; }
    }

    public class BodyInputContentTypeFileType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }

        [JsonProperty("filetype", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filetype { get; set; }
    }

    public class SendViberImageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberImageBodyInput
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
        public SendViberImageBodyInputContentType Content { get; set; } = new SendViberImageBodyInputContentType();
    }

    public class SendViberImageBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "image";

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputContentTypeImageType Image { get; set; }
    }

    public class BodyInputContentTypeImageType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }
    }

    public class SendViberTextResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendViberTextBodyInput
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
        public SendViberTextBodyInputContentType Content { get; set; } = new SendViberTextBodyInputContentType();
    }

    public class SendViberTextBodyInputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "text";

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class StatusCheckResponse
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

    public class IncomingBodyInput
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
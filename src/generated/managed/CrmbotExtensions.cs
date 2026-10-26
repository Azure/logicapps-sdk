//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Crmbot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CrmbotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildCustomMessageResponse, ApiConnectionActionConfiguration> BuildCustomMessage(Expression<Func<BuildCustomMessageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BuildCustomMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/message/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BuildCustomMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildTextMessageResponse, ApiConnectionActionConfiguration> BuildTextMessage(Expression<Func<BuildTextMessageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BuildTextMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/message/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BuildTextMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildCardMessageResponse, ApiConnectionActionConfiguration> BuildCardMessage(Expression<Func<BuildCardMessageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BuildCardMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/message/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BuildCardMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse, ApiConnectionActionConfiguration> BuildQuickrepliesMessage(Expression<Func<BuildQuickrepliesMessageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BuildQuickrepliesMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/message/quickreplies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BuildQuickrepliesMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildMediaMessageResponse, ApiConnectionActionConfiguration> BuildMediaMessage(Expression<Func<BuildMediaMessageInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BuildMediaMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/message/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BuildMediaMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendResponse(Expression<Func<SendResponseInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector/response";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendProactiveMessage(Expression<Func<SendProactiveMessageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector/proactive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CrmbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> IntentDetected(Expression<Func<IntentDetectedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BuildCustomMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildCustomMessageInput
    {
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Platform { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class BuildTextMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildTextMessageInput
    {
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Platform { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class BuildCardMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildCardMessageInput
    {
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Platform { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isCarousel", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsCarousel { get; set; } = false;

        [JsonProperty("buttontitle1")]
        public string Buttontitle1 { get; set; }

        [JsonProperty("buttonpostback1")]
        public string Buttonpostback1 { get; set; }

        [JsonProperty("buttontitle2")]
        public string Buttontitle2 { get; set; }

        [JsonProperty("buttonpostback2")]
        public string Buttonpostback2 { get; set; }

        [JsonProperty("buttontitle3")]
        public string Buttontitle3 { get; set; }

        [JsonProperty("buttonpostback3")]
        public string Buttonpostback3 { get; set; }
    }

    public class BuildQuickrepliesMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildQuickrepliesMessageInput
    {
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Platform { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class BuildMediaMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildMediaMessageInput
    {
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Platform { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("mediaType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BuildMediaMessageInputMediaTypeType MediaType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BuildMediaMessageInputMediaTypeType
    {
        [EnumMember(Value = "1")]
        Image,
        [EnumMember(Value = "2")]
        Video
    }

    public class SendResponseInput
    {
        [JsonProperty("sessionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty("useGlossary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseGlossary { get; set; }

        [JsonProperty("targetLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetLanguage { get; set; }

        [JsonProperty("webhookResponse")]
        public SendResponseInputWebhookResponseType WebhookResponse { get; set; }
    }

    public class SendResponseInputWebhookResponseType
    {
        public JToken[] FulfillmentMessages { get; set; }

        [JsonProperty("EventName")]
        public string SelectTheEventYouWouldLikeToInvoke { get; set; }

        [JsonProperty("OutputContextName")]
        public string ApplySpecificContextToResponse { get; set; }

        [JsonProperty("OutputContextLifespan")]
        public int? DurationOfContext { get; set; }
    }

    public class SendProactiveMessageInput
    {
        [JsonProperty("sessionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty("useGlossary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseGlossary { get; set; }

        [JsonProperty("targetLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetLanguage { get; set; }

        [JsonProperty("webhookResponse")]
        public SendProactiveMessageInputWebhookResponseType WebhookResponse { get; set; }
    }

    public class SendProactiveMessageInputWebhookResponseType
    {
        public JToken[] FulfillmentMessages { get; set; }
    }

    public class IntentDetectedInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("intent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectIntentYouWouldLikeToTriggerOn { get; set; }

        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Include)]
        public IntentDetectedInputUseUnspecifiedIfYourFlowIsPlatformAgnosticType UseUnspecifiedIfYourFlowIsPlatformAgnostic { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IntentDetectedInputUseUnspecifiedIfYourFlowIsPlatformAgnosticType
    {
        Unspecified,
        Messenger,
        [EnumMember(Value = "Google Assistant")]
        GoogleAssistant,
        Skype,
        Slack
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Crmbot;

    public partial class WorkflowManagedActions
    {
        public CrmbotActions Crmbot(string connectionId) => new CrmbotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CrmbotTriggers Crmbot(string connectionId) => new CrmbotTriggers(connectionId);
    }
}
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
        public IBodyWorkflowAction<BuildCustomMessageResponse> BuildCustomMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytext)
        {
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<BuildCustomMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildCustomMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildTextMessageResponse> BuildTextMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytext)
        {
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<BuildTextMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildTextMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildCardMessageResponse> BuildCardMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytitle, Expression<Func<bool>> bodyisCarousel, Expression<Func<string>> bodysubtitle = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodybuttontitle1 = null, Expression<Func<string>> bodybuttonpostback1 = null, Expression<Func<string>> bodybuttontitle2 = null, Expression<Func<string>> bodybuttonpostback2 = null, Expression<Func<string>> bodybuttontitle3 = null, Expression<Func<string>> bodybuttonpostback3 = null)
        {
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyisCarousel = WorkflowExpression.Compile(bodyisCarousel, nameof(bodyisCarousel), required: true);
            var __workflow_bodysubtitle = WorkflowExpression.Compile(bodysubtitle, nameof(bodysubtitle), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodybuttontitle1 = WorkflowExpression.Compile(bodybuttontitle1, nameof(bodybuttontitle1), required: false);
            var __workflow_bodybuttonpostback1 = WorkflowExpression.Compile(bodybuttonpostback1, nameof(bodybuttonpostback1), required: false);
            var __workflow_bodybuttontitle2 = WorkflowExpression.Compile(bodybuttontitle2, nameof(bodybuttontitle2), required: false);
            var __workflow_bodybuttonpostback2 = WorkflowExpression.Compile(bodybuttonpostback2, nameof(bodybuttonpostback2), required: false);
            var __workflow_bodybuttontitle3 = WorkflowExpression.Compile(bodybuttontitle3, nameof(bodybuttontitle3), required: false);
            var __workflow_bodybuttonpostback3 = WorkflowExpression.Compile(bodybuttonpostback3, nameof(bodybuttonpostback3), required: false);
            return new DeferredBodyAction<BuildCardMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodysubtitle != null)
                {
                    body["subtitle"] = ExpressionConverter.ConvertO(__workflow_bodysubtitle);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["isCarousel"] = ExpressionConverter.ConvertO(__workflow_bodyisCarousel);
                if (__workflow_bodybuttontitle1 != null)
                {
                    body["buttontitle1"] = ExpressionConverter.ConvertO(__workflow_bodybuttontitle1);
                    bodypropCount++;
                }

                if (__workflow_bodybuttonpostback1 != null)
                {
                    body["buttonpostback1"] = ExpressionConverter.ConvertO(__workflow_bodybuttonpostback1);
                    bodypropCount++;
                }

                if (__workflow_bodybuttontitle2 != null)
                {
                    body["buttontitle2"] = ExpressionConverter.ConvertO(__workflow_bodybuttontitle2);
                    bodypropCount++;
                }

                if (__workflow_bodybuttonpostback2 != null)
                {
                    body["buttonpostback2"] = ExpressionConverter.ConvertO(__workflow_bodybuttonpostback2);
                    bodypropCount++;
                }

                if (__workflow_bodybuttontitle3 != null)
                {
                    body["buttontitle3"] = ExpressionConverter.ConvertO(__workflow_bodybuttontitle3);
                    bodypropCount++;
                }

                if (__workflow_bodybuttonpostback3 != null)
                {
                    body["buttonpostback3"] = ExpressionConverter.ConvertO(__workflow_bodybuttonpostback3);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildCardMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse> BuildQuickrepliesMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytitle, Expression<Func<string>> bodytext)
        {
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<BuildQuickrepliesMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/quickreplies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildQuickrepliesMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildMediaMessageResponse> BuildMediaMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodyurl, Expression<Func<bodymediaTypeInput>> bodymediaType)
        {
            var __workflow_bodyplatform = WorkflowExpression.Compile(bodyplatform, nameof(bodyplatform), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodymediaType = WorkflowExpression.Compile(bodymediaType, nameof(bodymediaType), required: true);
            return new DeferredBodyAction<BuildMediaMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyplatform);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                bodypropCount++;
                body["mediaType"] = ExpressionConverter.ConvertO(__workflow_bodymediaType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildMediaMessageResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction SendResponse(Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodyuseGlossary, Expression<Func<string>> bodytargetLanguage, Expression<Func<JToken[]>> bodywebhookResponsefulfillmentMessages = null, Expression<Func<string>> bodywebhookResponseselectTheEventYouWouldLikeToInvoke = null, Expression<Func<string>> bodywebhookResponseapplySpecificContextToResponse = null, Expression<Func<int>> bodywebhookResponsedurationOfContext = null)
        {
            var __workflow_bodysessionId = WorkflowExpression.Compile(bodysessionId, nameof(bodysessionId), required: true);
            var __workflow_bodyuseGlossary = WorkflowExpression.Compile(bodyuseGlossary, nameof(bodyuseGlossary), required: true);
            var __workflow_bodytargetLanguage = WorkflowExpression.Compile(bodytargetLanguage, nameof(bodytargetLanguage), required: true);
            var __workflow_bodywebhookResponsefulfillmentMessages = WorkflowExpression.Compile(bodywebhookResponsefulfillmentMessages, nameof(bodywebhookResponsefulfillmentMessages), required: false);
            var __workflow_bodywebhookResponseselectTheEventYouWouldLikeToInvoke = WorkflowExpression.Compile(bodywebhookResponseselectTheEventYouWouldLikeToInvoke, nameof(bodywebhookResponseselectTheEventYouWouldLikeToInvoke), required: false);
            var __workflow_bodywebhookResponseapplySpecificContextToResponse = WorkflowExpression.Compile(bodywebhookResponseapplySpecificContextToResponse, nameof(bodywebhookResponseapplySpecificContextToResponse), required: false);
            var __workflow_bodywebhookResponsedurationOfContext = WorkflowExpression.Compile(bodywebhookResponsedurationOfContext, nameof(bodywebhookResponsedurationOfContext), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector/response";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sessionId"] = ExpressionConverter.ConvertO(__workflow_bodysessionId);
                bodypropCount++;
                body["useGlossary"] = ExpressionConverter.ConvertO(__workflow_bodyuseGlossary);
                bodypropCount++;
                body["targetLanguage"] = ExpressionConverter.ConvertO(__workflow_bodytargetLanguage);
                var webhookResponseObject = new JObject();
                var webhookResponseObjectpropCount = 0;
                if (__workflow_bodywebhookResponsefulfillmentMessages != null)
                {
                    webhookResponseObject["FulfillmentMessages"] = ExpressionConverter.ConvertO(__workflow_bodywebhookResponsefulfillmentMessages);
                    webhookResponseObjectpropCount++;
                }

                if (__workflow_bodywebhookResponseselectTheEventYouWouldLikeToInvoke != null)
                {
                    webhookResponseObject["EventName"] = ExpressionConverter.ConvertO(__workflow_bodywebhookResponseselectTheEventYouWouldLikeToInvoke);
                    webhookResponseObjectpropCount++;
                }

                if (__workflow_bodywebhookResponseapplySpecificContextToResponse != null)
                {
                    webhookResponseObject["OutputContextName"] = ExpressionConverter.ConvertO(__workflow_bodywebhookResponseapplySpecificContextToResponse);
                    webhookResponseObjectpropCount++;
                }

                if (__workflow_bodywebhookResponsedurationOfContext != null)
                {
                    webhookResponseObject["OutputContextLifespan"] = ExpressionConverter.ConvertO(__workflow_bodywebhookResponsedurationOfContext);
                    webhookResponseObjectpropCount++;
                }

                if (webhookResponseObjectpropCount > 0)
                {
                    body["webhookResponse"] = webhookResponseObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction SendProactiveMessage(Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodyuseGlossary, Expression<Func<string>> bodytargetLanguage, Expression<Func<JToken[]>> bodywebhookResponsefulfillmentMessages = null)
        {
            var __workflow_bodysessionId = WorkflowExpression.Compile(bodysessionId, nameof(bodysessionId), required: true);
            var __workflow_bodyuseGlossary = WorkflowExpression.Compile(bodyuseGlossary, nameof(bodyuseGlossary), required: true);
            var __workflow_bodytargetLanguage = WorkflowExpression.Compile(bodytargetLanguage, nameof(bodytargetLanguage), required: true);
            var __workflow_bodywebhookResponsefulfillmentMessages = WorkflowExpression.Compile(bodywebhookResponsefulfillmentMessages, nameof(bodywebhookResponsefulfillmentMessages), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector/proactive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sessionId"] = ExpressionConverter.ConvertO(__workflow_bodysessionId);
                bodypropCount++;
                body["useGlossary"] = ExpressionConverter.ConvertO(__workflow_bodyuseGlossary);
                bodypropCount++;
                body["targetLanguage"] = ExpressionConverter.ConvertO(__workflow_bodytargetLanguage);
                var webhookResponseObject = new JObject();
                var webhookResponseObjectpropCount = 0;
                if (__workflow_bodywebhookResponsefulfillmentMessages != null)
                {
                    webhookResponseObject["FulfillmentMessages"] = ExpressionConverter.ConvertO(__workflow_bodywebhookResponsefulfillmentMessages);
                    webhookResponseObjectpropCount++;
                }

                if (webhookResponseObjectpropCount > 0)
                {
                    body["webhookResponse"] = webhookResponseObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class CrmbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> IntentDetected(Expression<Func<string>> bodyselectIntentYouWouldLikeToTriggerOn, Expression<Func<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput>> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyselectIntentYouWouldLikeToTriggerOn = WorkflowExpression.Compile(bodyselectIntentYouWouldLikeToTriggerOn, nameof(bodyselectIntentYouWouldLikeToTriggerOn), required: true);
            var __workflow_bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic = WorkflowExpression.Compile(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, nameof(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyselectIntentYouWouldLikeToTriggerOn);
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(__workflow_bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class BuildCustomMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildTextMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildCardMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildQuickrepliesMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class BuildMediaMessageResponse
    {
        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymediaTypeInput
    {
        [EnumMember(Value = "1")]
        Image,
        [EnumMember(Value = "2")]
        Video
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput
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

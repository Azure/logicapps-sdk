//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Crmbot
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CrmbotActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildBuildCustomMessage))]
        public IBodyWorkflowAction<BuildCustomMessageResponse> BuildCustomMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildCustomMessageResponse> __BuildBuildCustomMessage(WorkflowExpression<string> bodyplatform, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<BuildCustomMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildCustomMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildBuildTextMessage))]
        public IBodyWorkflowAction<BuildTextMessageResponse> BuildTextMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildTextMessageResponse> __BuildBuildTextMessage(WorkflowExpression<string> bodyplatform, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<BuildTextMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildTextMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildBuildCardMessage))]
        public IBodyWorkflowAction<BuildCardMessageResponse> BuildCardMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bool> bodyisCarousel, [WorkflowExpression] Func<string> bodysubtitle = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodybuttontitle1 = null, [WorkflowExpression] Func<string> bodybuttonpostback1 = null, [WorkflowExpression] Func<string> bodybuttontitle2 = null, [WorkflowExpression] Func<string> bodybuttonpostback2 = null, [WorkflowExpression] Func<string> bodybuttontitle3 = null, [WorkflowExpression] Func<string> bodybuttonpostback3 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildCardMessageResponse> __BuildBuildCardMessage(WorkflowExpression<string> bodyplatform, WorkflowExpression<string> bodytitle, WorkflowExpression<bool> bodyisCarousel, WorkflowExpression<string> bodysubtitle = null, WorkflowExpression<string> bodyurl = null, WorkflowExpression<string> bodybuttontitle1 = null, WorkflowExpression<string> bodybuttonpostback1 = null, WorkflowExpression<string> bodybuttontitle2 = null, WorkflowExpression<string> bodybuttonpostback2 = null, WorkflowExpression<string> bodybuttontitle3 = null, WorkflowExpression<string> bodybuttonpostback3 = null)
        {
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyisCarousel, nameof(bodyisCarousel), required: true);
            WorkflowExpression.Validate(bodysubtitle, nameof(bodysubtitle), required: false);
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowExpression.Validate(bodybuttontitle1, nameof(bodybuttontitle1), required: false);
            WorkflowExpression.Validate(bodybuttonpostback1, nameof(bodybuttonpostback1), required: false);
            WorkflowExpression.Validate(bodybuttontitle2, nameof(bodybuttontitle2), required: false);
            WorkflowExpression.Validate(bodybuttonpostback2, nameof(bodybuttonpostback2), required: false);
            WorkflowExpression.Validate(bodybuttontitle3, nameof(bodybuttontitle3), required: false);
            WorkflowExpression.Validate(bodybuttonpostback3, nameof(bodybuttonpostback3), required: false);
            return new DeferredBodyAction<BuildCardMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodysubtitle != null)
                {
                    body["subtitle"] = ExpressionConverter.ConvertO(bodysubtitle);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["isCarousel"] = ExpressionConverter.ConvertO(bodyisCarousel);
                if (bodybuttontitle1 != null)
                {
                    body["buttontitle1"] = ExpressionConverter.ConvertO(bodybuttontitle1);
                    bodypropCount++;
                }

                if (bodybuttonpostback1 != null)
                {
                    body["buttonpostback1"] = ExpressionConverter.ConvertO(bodybuttonpostback1);
                    bodypropCount++;
                }

                if (bodybuttontitle2 != null)
                {
                    body["buttontitle2"] = ExpressionConverter.ConvertO(bodybuttontitle2);
                    bodypropCount++;
                }

                if (bodybuttonpostback2 != null)
                {
                    body["buttonpostback2"] = ExpressionConverter.ConvertO(bodybuttonpostback2);
                    bodypropCount++;
                }

                if (bodybuttontitle3 != null)
                {
                    body["buttontitle3"] = ExpressionConverter.ConvertO(bodybuttontitle3);
                    bodypropCount++;
                }

                if (bodybuttonpostback3 != null)
                {
                    body["buttonpostback3"] = ExpressionConverter.ConvertO(bodybuttonpostback3);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildCardMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildBuildQuickrepliesMessage))]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse> BuildQuickrepliesMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse> __BuildBuildQuickrepliesMessage(WorkflowExpression<string> bodyplatform, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<BuildQuickrepliesMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/quickreplies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildQuickrepliesMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildBuildMediaMessage))]
        public IBodyWorkflowAction<BuildMediaMessageResponse> BuildMediaMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bodymediaTypeInput> bodymediaType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildMediaMessageResponse> __BuildBuildMediaMessage(WorkflowExpression<string> bodyplatform, WorkflowExpression<string> bodyurl, WorkflowExpression<bodymediaTypeInput> bodymediaType)
        {
            WorkflowExpression.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowExpression.Validate(bodymediaType, nameof(bodymediaType), required: true);
            return new DeferredBodyAction<BuildMediaMessageResponse>(() =>
            {
                var apiCallPath = "/runtime/api/message/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(bodyplatform);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
                body["mediaType"] = ExpressionConverter.ConvertO(bodymediaType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuildMediaMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildSendResponse))]
        public IWorkflowAction SendResponse([WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodyuseGlossary, [WorkflowExpression] Func<string> bodytargetLanguage, [WorkflowExpression] Func<JToken[]> bodywebhookResponsefulfillmentMessages = null, [WorkflowExpression] Func<string> bodywebhookResponseselectTheEventYouWouldLikeToInvoke = null, [WorkflowExpression] Func<string> bodywebhookResponseapplySpecificContextToResponse = null, [WorkflowExpression] Func<int> bodywebhookResponsedurationOfContext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendResponse(WorkflowExpression<string> bodysessionId, WorkflowExpression<bool> bodyuseGlossary, WorkflowExpression<string> bodytargetLanguage, WorkflowExpression<JToken[]> bodywebhookResponsefulfillmentMessages = null, WorkflowExpression<string> bodywebhookResponseselectTheEventYouWouldLikeToInvoke = null, WorkflowExpression<string> bodywebhookResponseapplySpecificContextToResponse = null, WorkflowExpression<int> bodywebhookResponsedurationOfContext = null)
        {
            WorkflowExpression.Validate(bodysessionId, nameof(bodysessionId), required: true);
            WorkflowExpression.Validate(bodyuseGlossary, nameof(bodyuseGlossary), required: true);
            WorkflowExpression.Validate(bodytargetLanguage, nameof(bodytargetLanguage), required: true);
            WorkflowExpression.Validate(bodywebhookResponsefulfillmentMessages, nameof(bodywebhookResponsefulfillmentMessages), required: false);
            WorkflowExpression.Validate(bodywebhookResponseselectTheEventYouWouldLikeToInvoke, nameof(bodywebhookResponseselectTheEventYouWouldLikeToInvoke), required: false);
            WorkflowExpression.Validate(bodywebhookResponseapplySpecificContextToResponse, nameof(bodywebhookResponseapplySpecificContextToResponse), required: false);
            WorkflowExpression.Validate(bodywebhookResponsedurationOfContext, nameof(bodywebhookResponsedurationOfContext), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector/response";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sessionId"] = ExpressionConverter.ConvertO(bodysessionId);
                bodypropCount++;
                body["useGlossary"] = ExpressionConverter.ConvertO(bodyuseGlossary);
                bodypropCount++;
                body["targetLanguage"] = ExpressionConverter.ConvertO(bodytargetLanguage);
                var webhookResponseObject = new JObject();
                var webhookResponseObjectpropCount = 0;
                if (bodywebhookResponsefulfillmentMessages != null)
                {
                    webhookResponseObject["FulfillmentMessages"] = ExpressionConverter.ConvertO(bodywebhookResponsefulfillmentMessages);
                    webhookResponseObjectpropCount++;
                }

                if (bodywebhookResponseselectTheEventYouWouldLikeToInvoke != null)
                {
                    webhookResponseObject["EventName"] = ExpressionConverter.ConvertO(bodywebhookResponseselectTheEventYouWouldLikeToInvoke);
                    webhookResponseObjectpropCount++;
                }

                if (bodywebhookResponseapplySpecificContextToResponse != null)
                {
                    webhookResponseObject["OutputContextName"] = ExpressionConverter.ConvertO(bodywebhookResponseapplySpecificContextToResponse);
                    webhookResponseObjectpropCount++;
                }

                if (bodywebhookResponsedurationOfContext != null)
                {
                    webhookResponseObject["OutputContextLifespan"] = ExpressionConverter.ConvertO(bodywebhookResponsedurationOfContext);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [WorkflowExpressionFactory(nameof(__BuildSendProactiveMessage))]
        public IWorkflowAction SendProactiveMessage([WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodyuseGlossary, [WorkflowExpression] Func<string> bodytargetLanguage, [WorkflowExpression] Func<JToken[]> bodywebhookResponsefulfillmentMessages = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendProactiveMessage(WorkflowExpression<string> bodysessionId, WorkflowExpression<bool> bodyuseGlossary, WorkflowExpression<string> bodytargetLanguage, WorkflowExpression<JToken[]> bodywebhookResponsefulfillmentMessages = null)
        {
            WorkflowExpression.Validate(bodysessionId, nameof(bodysessionId), required: true);
            WorkflowExpression.Validate(bodyuseGlossary, nameof(bodyuseGlossary), required: true);
            WorkflowExpression.Validate(bodytargetLanguage, nameof(bodytargetLanguage), required: true);
            WorkflowExpression.Validate(bodywebhookResponsefulfillmentMessages, nameof(bodywebhookResponsefulfillmentMessages), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/runtime/api/flowconnector/proactive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sessionId"] = ExpressionConverter.ConvertO(bodysessionId);
                bodypropCount++;
                body["useGlossary"] = ExpressionConverter.ConvertO(bodyuseGlossary);
                bodypropCount++;
                body["targetLanguage"] = ExpressionConverter.ConvertO(bodytargetLanguage);
                var webhookResponseObject = new JObject();
                var webhookResponseObjectpropCount = 0;
                if (bodywebhookResponsefulfillmentMessages != null)
                {
                    webhookResponseObject["FulfillmentMessages"] = ExpressionConverter.ConvertO(bodywebhookResponsefulfillmentMessages);
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
            });
        }
    }

    public class CrmbotTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildIntentDetected))]
        public IBodyWorkflowTrigger<JToken> IntentDetected([WorkflowExpression] Func<string> bodyselectIntentYouWouldLikeToTriggerOn,[WorkflowExpression] Func<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildIntentDetected(WorkflowExpression<string> bodyselectIntentYouWouldLikeToTriggerOn,WorkflowExpression<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyselectIntentYouWouldLikeToTriggerOn, nameof(bodyselectIntentYouWouldLikeToTriggerOn), required: true);
            WorkflowExpression.Validate(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, nameof(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic), required: true);
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
                body["intent"] = ExpressionConverter.ConvertO(bodyselectIntentYouWouldLikeToTriggerOn);
                bodypropCount++;
                body["platform"] = ExpressionConverter.ConvertO(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
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

    public enum bodymediaTypeInput
    {
        [EnumMember(Value = "1")]
        Image,
        [EnumMember(Value = "2")]
        Video
    }

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
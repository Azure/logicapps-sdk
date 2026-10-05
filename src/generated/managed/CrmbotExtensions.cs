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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildCustomMessageResponse> __BuildBuildCustomMessage(WorkflowValue<string> bodyplatform, WorkflowValue<string> bodytext)
        {
            WorkflowValue.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildTextMessageResponse> __BuildBuildTextMessage(WorkflowValue<string> bodyplatform, WorkflowValue<string> bodytext)
        {
            WorkflowValue.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildCardMessageResponse> __BuildBuildCardMessage(WorkflowValue<string> bodyplatform, WorkflowValue<string> bodytitle, WorkflowValue<bool> bodyisCarousel, WorkflowValue<string> bodysubtitle = null, WorkflowValue<string> bodyurl = null, WorkflowValue<string> bodybuttontitle1 = null, WorkflowValue<string> bodybuttonpostback1 = null, WorkflowValue<string> bodybuttontitle2 = null, WorkflowValue<string> bodybuttonpostback2 = null, WorkflowValue<string> bodybuttontitle3 = null, WorkflowValue<string> bodybuttonpostback3 = null)
        {
            WorkflowValue.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodyisCarousel, nameof(bodyisCarousel), required: true);
            WorkflowValue.Validate(bodysubtitle, nameof(bodysubtitle), required: false);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowValue.Validate(bodybuttontitle1, nameof(bodybuttontitle1), required: false);
            WorkflowValue.Validate(bodybuttonpostback1, nameof(bodybuttonpostback1), required: false);
            WorkflowValue.Validate(bodybuttontitle2, nameof(bodybuttontitle2), required: false);
            WorkflowValue.Validate(bodybuttonpostback2, nameof(bodybuttonpostback2), required: false);
            WorkflowValue.Validate(bodybuttontitle3, nameof(bodybuttontitle3), required: false);
            WorkflowValue.Validate(bodybuttonpostback3, nameof(bodybuttonpostback3), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse> __BuildBuildQuickrepliesMessage(WorkflowValue<string> bodyplatform, WorkflowValue<string> bodytitle, WorkflowValue<string> bodytext)
        {
            WorkflowValue.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildMediaMessageResponse> __BuildBuildMediaMessage(WorkflowValue<string> bodyplatform, WorkflowValue<string> bodyurl, WorkflowValue<bodymediaTypeInput> bodymediaType)
        {
            WorkflowValue.Validate(bodyplatform, nameof(bodyplatform), required: true);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodymediaType, nameof(bodymediaType), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendResponse(WorkflowValue<string> bodysessionId, WorkflowValue<bool> bodyuseGlossary, WorkflowValue<string> bodytargetLanguage, WorkflowValue<JToken[]> bodywebhookResponsefulfillmentMessages = null, WorkflowValue<string> bodywebhookResponseselectTheEventYouWouldLikeToInvoke = null, WorkflowValue<string> bodywebhookResponseapplySpecificContextToResponse = null, WorkflowValue<int> bodywebhookResponsedurationOfContext = null)
        {
            WorkflowValue.Validate(bodysessionId, nameof(bodysessionId), required: true);
            WorkflowValue.Validate(bodyuseGlossary, nameof(bodyuseGlossary), required: true);
            WorkflowValue.Validate(bodytargetLanguage, nameof(bodytargetLanguage), required: true);
            WorkflowValue.Validate(bodywebhookResponsefulfillmentMessages, nameof(bodywebhookResponsefulfillmentMessages), required: false);
            WorkflowValue.Validate(bodywebhookResponseselectTheEventYouWouldLikeToInvoke, nameof(bodywebhookResponseselectTheEventYouWouldLikeToInvoke), required: false);
            WorkflowValue.Validate(bodywebhookResponseapplySpecificContextToResponse, nameof(bodywebhookResponseapplySpecificContextToResponse), required: false);
            WorkflowValue.Validate(bodywebhookResponsedurationOfContext, nameof(bodywebhookResponsedurationOfContext), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendProactiveMessage(WorkflowValue<string> bodysessionId, WorkflowValue<bool> bodyuseGlossary, WorkflowValue<string> bodytargetLanguage, WorkflowValue<JToken[]> bodywebhookResponsefulfillmentMessages = null)
        {
            WorkflowValue.Validate(bodysessionId, nameof(bodysessionId), required: true);
            WorkflowValue.Validate(bodyuseGlossary, nameof(bodyuseGlossary), required: true);
            WorkflowValue.Validate(bodytargetLanguage, nameof(bodytargetLanguage), required: true);
            WorkflowValue.Validate(bodywebhookResponsefulfillmentMessages, nameof(bodywebhookResponsefulfillmentMessages), required: false);
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
        public IBodyWorkflowTrigger<JToken> IntentDetected([WorkflowExpression] Func<string> bodyselectIntentYouWouldLikeToTriggerOn, [WorkflowExpression] Func<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildIntentDetected(WorkflowValue<string> bodyselectIntentYouWouldLikeToTriggerOn, WorkflowValue<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyselectIntentYouWouldLikeToTriggerOn, nameof(bodyselectIntentYouWouldLikeToTriggerOn), required: true);
            WorkflowValue.Validate(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, nameof(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic), required: true);
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

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
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

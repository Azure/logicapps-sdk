//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Crmbot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CrmbotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildCustomMessageResponse> BuildCustomMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytext)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/message/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuildCustomMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildTextMessageResponse> BuildTextMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytext)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/message/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuildTextMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildCardMessageResponse> BuildCardMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bool> bodyisCarousel, [WorkflowExpression] Func<string> bodysubtitle = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodybuttontitle1 = null, [WorkflowExpression] Func<string> bodybuttonpostback1 = null, [WorkflowExpression] Func<string> bodybuttontitle2 = null, [WorkflowExpression] Func<string> bodybuttonpostback2 = null, [WorkflowExpression] Func<string> bodybuttontitle3 = null, [WorkflowExpression] Func<string> bodybuttonpostback3 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/message/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodysubtitle != null)
                {
                    body["subtitle"] = SourceExpressionConverter.ConvertToken(bodysubtitle);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["isCarousel"] = SourceExpressionConverter.ConvertToken(bodyisCarousel);
                if (bodybuttontitle1 != null)
                {
                    body["buttontitle1"] = SourceExpressionConverter.ConvertToken(bodybuttontitle1);
                    bodypropCount++;
                }

                if (bodybuttonpostback1 != null)
                {
                    body["buttonpostback1"] = SourceExpressionConverter.ConvertToken(bodybuttonpostback1);
                    bodypropCount++;
                }

                if (bodybuttontitle2 != null)
                {
                    body["buttontitle2"] = SourceExpressionConverter.ConvertToken(bodybuttontitle2);
                    bodypropCount++;
                }

                if (bodybuttonpostback2 != null)
                {
                    body["buttonpostback2"] = SourceExpressionConverter.ConvertToken(bodybuttonpostback2);
                    bodypropCount++;
                }

                if (bodybuttontitle3 != null)
                {
                    body["buttontitle3"] = SourceExpressionConverter.ConvertToken(bodybuttontitle3);
                    bodypropCount++;
                }

                if (bodybuttonpostback3 != null)
                {
                    body["buttonpostback3"] = SourceExpressionConverter.ConvertToken(bodybuttonpostback3);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuildCardMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse> BuildQuickrepliesMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytext)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/message/quickreplies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuildQuickrepliesMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildMediaMessageResponse> BuildMediaMessage([WorkflowExpression] Func<string> bodyplatform, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<bodymediaTypeInput> bodymediaType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/message/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["platform"] = SourceExpressionConverter.ConvertToken(bodyplatform);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
                body["mediaType"] = SourceExpressionConverter.Convert(bodymediaType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuildMediaMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction SendResponse([WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodyuseGlossary, [WorkflowExpression] Func<string> bodytargetLanguage, [WorkflowExpression] Func<JToken[]> bodywebhookResponsefulfillmentMessages = null, [WorkflowExpression] Func<string> bodywebhookResponseselectTheEventYouWouldLikeToInvoke = null, [WorkflowExpression] Func<string> bodywebhookResponseapplySpecificContextToResponse = null, [WorkflowExpression] Func<int> bodywebhookResponsedurationOfContext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/flowconnector/response";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sessionId"] = SourceExpressionConverter.ConvertToken(bodysessionId);
                bodypropCount++;
                body["useGlossary"] = SourceExpressionConverter.ConvertToken(bodyuseGlossary);
                bodypropCount++;
                body["targetLanguage"] = SourceExpressionConverter.ConvertToken(bodytargetLanguage);
                var webhookResponseObject = new JObject();
                var webhookResponseObjectpropCount = 0;
                if (bodywebhookResponsefulfillmentMessages != null)
                {
                    webhookResponseObject["FulfillmentMessages"] = SourceExpressionConverter.ConvertToken(bodywebhookResponsefulfillmentMessages);
                    webhookResponseObjectpropCount++;
                }

                if (bodywebhookResponseselectTheEventYouWouldLikeToInvoke != null)
                {
                    webhookResponseObject["EventName"] = SourceExpressionConverter.ConvertToken(bodywebhookResponseselectTheEventYouWouldLikeToInvoke);
                    webhookResponseObjectpropCount++;
                }

                if (bodywebhookResponseapplySpecificContextToResponse != null)
                {
                    webhookResponseObject["OutputContextName"] = SourceExpressionConverter.ConvertToken(bodywebhookResponseapplySpecificContextToResponse);
                    webhookResponseObjectpropCount++;
                }

                if (bodywebhookResponsedurationOfContext != null)
                {
                    webhookResponseObject["OutputContextLifespan"] = SourceExpressionConverter.ConvertToken(bodywebhookResponsedurationOfContext);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction SendProactiveMessage([WorkflowExpression] Func<string> bodysessionId, [WorkflowExpression] Func<bool> bodyuseGlossary, [WorkflowExpression] Func<string> bodytargetLanguage, [WorkflowExpression] Func<JToken[]> bodywebhookResponsefulfillmentMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/flowconnector/proactive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sessionId"] = SourceExpressionConverter.ConvertToken(bodysessionId);
                bodypropCount++;
                body["useGlossary"] = SourceExpressionConverter.ConvertToken(bodyuseGlossary);
                bodypropCount++;
                body["targetLanguage"] = SourceExpressionConverter.ConvertToken(bodytargetLanguage);
                var webhookResponseObject = new JObject();
                var webhookResponseObjectpropCount = 0;
                if (bodywebhookResponsefulfillmentMessages != null)
                {
                    webhookResponseObject["FulfillmentMessages"] = SourceExpressionConverter.ConvertToken(bodywebhookResponsefulfillmentMessages);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CrmbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> IntentDetected([WorkflowExpression] Func<string> bodyselectIntentYouWouldLikeToTriggerOn, [WorkflowExpression] Func<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/api/flowconnector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["intent"] = SourceExpressionConverter.ConvertToken(bodyselectIntentYouWouldLikeToTriggerOn);
                bodypropCount++;
                body["platform"] = SourceExpressionConverter.Convert(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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
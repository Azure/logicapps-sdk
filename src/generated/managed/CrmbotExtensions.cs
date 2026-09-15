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
        public IBodyWorkflowAction<BuildCustomMessageResponse> BuildCustomMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytext)
        {
            var apiCallPath = "/runtime/api/message/custom";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuildCustomMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildTextMessageResponse> BuildTextMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytext)
        {
            var apiCallPath = "/runtime/api/message/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuildTextMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildCardMessageResponse> BuildCardMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytitle, Expression<Func<bool>> bodyisCarousel, Expression<Func<string>> bodysubtitle = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodybuttontitle1 = null, Expression<Func<string>> bodybuttonpostback1 = null, Expression<Func<string>> bodybuttontitle2 = null, Expression<Func<string>> bodybuttonpostback2 = null, Expression<Func<string>> bodybuttontitle3 = null, Expression<Func<string>> bodybuttonpostback3 = null)
        {
            var apiCallPath = "/runtime/api/message/card";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodysubtitle != null)
            {
                body["subtitle"] = CSharpExpressionConverter.ConvertToken(bodysubtitle);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
            }

            bodypropCount++;
            body["isCarousel"] = CSharpExpressionConverter.ConvertToken(bodyisCarousel);
            if (bodybuttontitle1 != null)
            {
                body["buttontitle1"] = CSharpExpressionConverter.ConvertToken(bodybuttontitle1);
                bodypropCount++;
            }

            if (bodybuttonpostback1 != null)
            {
                body["buttonpostback1"] = CSharpExpressionConverter.ConvertToken(bodybuttonpostback1);
                bodypropCount++;
            }

            if (bodybuttontitle2 != null)
            {
                body["buttontitle2"] = CSharpExpressionConverter.ConvertToken(bodybuttontitle2);
                bodypropCount++;
            }

            if (bodybuttonpostback2 != null)
            {
                body["buttonpostback2"] = CSharpExpressionConverter.ConvertToken(bodybuttonpostback2);
                bodypropCount++;
            }

            if (bodybuttontitle3 != null)
            {
                body["buttontitle3"] = CSharpExpressionConverter.ConvertToken(bodybuttontitle3);
                bodypropCount++;
            }

            if (bodybuttonpostback3 != null)
            {
                body["buttonpostback3"] = CSharpExpressionConverter.ConvertToken(bodybuttonpostback3);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuildCardMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildQuickrepliesMessageResponse> BuildQuickrepliesMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodytitle, Expression<Func<string>> bodytext)
        {
            var apiCallPath = "/runtime/api/message/quickreplies";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuildQuickrepliesMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IBodyWorkflowAction<BuildMediaMessageResponse> BuildMediaMessage(Expression<Func<string>> bodyplatform, Expression<Func<string>> bodyurl, Expression<Func<bodymediaTypeInput>> bodymediaType)
        {
            var apiCallPath = "/runtime/api/message/media";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["platform"] = CSharpExpressionConverter.ConvertToken(bodyplatform);
            bodypropCount++;
            body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
            bodypropCount++;
            body["mediaType"] = CSharpExpressionConverter.Convert(bodymediaType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuildMediaMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction SendResponse(Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodyuseGlossary, Expression<Func<string>> bodytargetLanguage, Expression<Func<JToken[]>> bodywebhookResponsefulfillmentMessages = null, Expression<Func<string>> bodywebhookResponseselectTheEventYouWouldLikeToInvoke = null, Expression<Func<string>> bodywebhookResponseapplySpecificContextToResponse = null, Expression<Func<int>> bodywebhookResponsedurationOfContext = null)
        {
            var apiCallPath = "/runtime/api/flowconnector/response";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sessionId"] = CSharpExpressionConverter.ConvertToken(bodysessionId);
            bodypropCount++;
            body["useGlossary"] = CSharpExpressionConverter.ConvertToken(bodyuseGlossary);
            bodypropCount++;
            body["targetLanguage"] = CSharpExpressionConverter.ConvertToken(bodytargetLanguage);
            var webhookResponseObject = new JObject();
            var webhookResponseObjectpropCount = 0;
            if (bodywebhookResponsefulfillmentMessages != null)
            {
                webhookResponseObject["FulfillmentMessages"] = CSharpExpressionConverter.ConvertToken(bodywebhookResponsefulfillmentMessages);
                webhookResponseObjectpropCount++;
            }

            if (bodywebhookResponseselectTheEventYouWouldLikeToInvoke != null)
            {
                webhookResponseObject["EventName"] = CSharpExpressionConverter.ConvertToken(bodywebhookResponseselectTheEventYouWouldLikeToInvoke);
                webhookResponseObjectpropCount++;
            }

            if (bodywebhookResponseapplySpecificContextToResponse != null)
            {
                webhookResponseObject["OutputContextName"] = CSharpExpressionConverter.ConvertToken(bodywebhookResponseapplySpecificContextToResponse);
                webhookResponseObjectpropCount++;
            }

            if (bodywebhookResponsedurationOfContext != null)
            {
                webhookResponseObject["OutputContextLifespan"] = CSharpExpressionConverter.ConvertToken(bodywebhookResponsedurationOfContext);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "crmbot")]
        public IWorkflowAction SendProactiveMessage(Expression<Func<string>> bodysessionId, Expression<Func<bool>> bodyuseGlossary, Expression<Func<string>> bodytargetLanguage, Expression<Func<JToken[]>> bodywebhookResponsefulfillmentMessages = null)
        {
            var apiCallPath = "/runtime/api/flowconnector/proactive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sessionId"] = CSharpExpressionConverter.ConvertToken(bodysessionId);
            bodypropCount++;
            body["useGlossary"] = CSharpExpressionConverter.ConvertToken(bodyuseGlossary);
            bodypropCount++;
            body["targetLanguage"] = CSharpExpressionConverter.ConvertToken(bodytargetLanguage);
            var webhookResponseObject = new JObject();
            var webhookResponseObjectpropCount = 0;
            if (bodywebhookResponsefulfillmentMessages != null)
            {
                webhookResponseObject["FulfillmentMessages"] = CSharpExpressionConverter.ConvertToken(bodywebhookResponsefulfillmentMessages);
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
        }
    }

    public class CrmbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> IntentDetected(Expression<Func<string>> bodyselectIntentYouWouldLikeToTriggerOn, Expression<Func<bodyuseUnspecifiedIfYourFlowIsPlatformAgnosticInput>> bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/runtime/api/flowconnector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["intent"] = CSharpExpressionConverter.ConvertToken(bodyselectIntentYouWouldLikeToTriggerOn);
            bodypropCount++;
            body["platform"] = CSharpExpressionConverter.Convert(bodyuseUnspecifiedIfYourFlowIsPlatformAgnostic);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
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
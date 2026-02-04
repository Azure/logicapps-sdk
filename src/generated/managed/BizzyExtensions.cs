//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BizzyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReply(Expression<Func<string>> contentreplyText, Expression<Func<string>> contentreplyActivity, Expression<Func<bool>> contentshowInChat = null, Expression<Func<string>> contentcustomChannelData = null, Expression<Func<string>> contentsignalResponseJSON = null, Expression<Func<string>> contentmessageID = null)
        {
            var apiCallPath = "/api/triggers/bot/reply";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["message"] = ExpressionConverter.ConvertO(contentreplyText);
            contentpropCount++;
            content["activityJson"] = ExpressionConverter.ConvertO(contentreplyActivity);
            if (contentshowInChat != null)
            {
                content["showInChat"] = ExpressionConverter.ConvertO(contentshowInChat);
                contentpropCount++;
            }

            if (contentcustomChannelData != null)
            {
                content["customChannelDataJson"] = ExpressionConverter.ConvertO(contentcustomChannelData);
                contentpropCount++;
            }

            if (contentsignalResponseJSON != null)
            {
                content["signalResponse"] = ExpressionConverter.ConvertO(contentsignalResponseJSON);
                contentpropCount++;
            }

            if (contentmessageID != null)
            {
                content["messageId"] = ExpressionConverter.ConvertO(contentmessageID);
                contentpropCount++;
            }

            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction<BotReplyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCard(Expression<Func<string>> selectedCard, Expression<Func<object>> content = null)
        {
            var apiCallPath = String.Format("/api/triggers/bot/adaptiveCards/{0}/replyWithAdaptiveCard", ExpressionConverter.ConvertWithUrlEncoding(selectedCard, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(content);
            return new ApiConnectionAction<BotReplyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<JToken> GenerateAdaptiveCard(Expression<Func<string>> selectedCard, Expression<Func<object>> content = null)
        {
            var apiCallPath = String.Format("/api/triggers/bot/adaptiveCards/{0}/generateAdaptiveCard", ExpressionConverter.ConvertWithUrlEncoding(selectedCard, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(content);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCardSet(Expression<Func<cardSetdisplayStyleInput>> cardSetdisplayStyle, Expression<Func<string>> cardSetreplyActivity, Expression<Func<bool>> cardSetshowInTab = null, Expression<Func<string>> cardSettabButtonLabel = null, Expression<Func<string>> cardSettabButtonMessage = null)
        {
            var apiCallPath = "/api/triggers/bot/adaptiveCards/sendCardSet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var cardSet = new JObject();
            var cardSetpropCount = 0;
            var cardsObject = new JObject();
            var cardsObjectpropCount = 0;
            if (cardsObjectpropCount > 0)
            {
                cardSet["cards"] = cardsObject;
                cardSetpropCount++;
            }

            cardSetpropCount++;
            cardSet["displayStyle"] = ExpressionConverter.ConvertO(cardSetdisplayStyle);
            cardSetpropCount++;
            cardSet["activityJson"] = ExpressionConverter.ConvertO(cardSetreplyActivity);
            if (cardSetshowInTab != null)
            {
                cardSet["showInTab"] = ExpressionConverter.ConvertO(cardSetshowInTab);
                cardSetpropCount++;
            }

            if (cardSettabButtonLabel != null)
            {
                cardSet["deepLinkButtonLabel"] = ExpressionConverter.ConvertO(cardSettabButtonLabel);
                cardSetpropCount++;
            }

            if (cardSettabButtonMessage != null)
            {
                cardSet["deepLinkMessage"] = ExpressionConverter.ConvertO(cardSettabButtonMessage);
                cardSetpropCount++;
            }

            if (cardSetpropCount > 0)
            {
                callPayload.Body = cardSet;
            }

            return new ApiConnectionAction<BotReplyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> UpdateAdaptiveCard(Expression<Func<string>> cardInforeplyActivity)
        {
            var apiCallPath = "/api/triggers/bot/adaptiveCards/updateCard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var cardInfo = new JObject();
            var cardInfopropCount = 0;
            var cardObject = new JObject();
            var cardObjectpropCount = 0;
            if (cardObjectpropCount > 0)
            {
                cardInfo["card"] = cardObject;
                cardInfopropCount++;
            }

            cardInfopropCount++;
            cardInfo["activityJson"] = ExpressionConverter.ConvertO(cardInforeplyActivity);
            if (cardInfopropCount > 0)
            {
                callPayload.Body = cardInfo;
            }

            return new ApiConnectionAction<BotReplyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotConversationStartResponse> StartConversation(Expression<Func<string>> contenttargetBot, Expression<Func<string>> contentconversationText, Expression<Func<string>> contentuser)
        {
            var apiCallPath = "/api/triggers/bot/startConversation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["EnterpriseBot"] = ExpressionConverter.ConvertO(contenttargetBot);
            contentpropCount++;
            content["message"] = ExpressionConverter.ConvertO(contentconversationText);
            contentpropCount++;
            content["user"] = ExpressionConverter.ConvertO(contentuser);
            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction<BotConversationStartResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotGroupConversationStartResponse> StartGroupConversation(Expression<Func<string>> contenttargetBot, Expression<Func<string>> contentchannelName, Expression<Func<string>> contentconversationText)
        {
            var apiCallPath = "/api/triggers/bot/startGroupConversation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["EnterpriseBot"] = ExpressionConverter.ConvertO(contenttargetBot);
            var teamIDStrObject = new JObject();
            var teamIDStrObjectpropCount = 0;
            if (teamIDStrObjectpropCount > 0)
            {
                content["teamIDStr"] = teamIDStrObject;
                contentpropCount++;
            }

            contentpropCount++;
            content["channelId"] = ExpressionConverter.ConvertO(contentchannelName);
            contentpropCount++;
            content["message"] = ExpressionConverter.ConvertO(contentconversationText);
            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction<BotGroupConversationStartResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IWorkflowAction SendBridgeEvent(Expression<Func<string>> contentreplyActivity)
        {
            var apiCallPath = "/api/triggers/bot/sendBridgeEvent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["activityJson"] = ExpressionConverter.ConvertO(contentreplyActivity);
            var eventObjectObject = new JObject();
            var eventObjectObjectpropCount = 0;
            if (eventObjectObjectpropCount > 0)
            {
                content["eventObject"] = eventObjectObject;
                contentpropCount++;
            }

            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponse(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseDATE(Expression<Func<webHookdateScopeInput>> webHookdateScope, Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_Date";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["dateScope"] = ExpressionConverter.ConvertO(webHookdateScope);
            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICE(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookchoiceValues, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null, Expression<Func<bool>> webHooklistenForVoiceResponse = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_Choice";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            webHookpropCount++;
            webHook["choices"] = ExpressionConverter.ConvertO(webHookchoiceValues);
            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHooklistenForVoiceResponse != null)
            {
                webHook["listenForInput"] = ExpressionConverter.ConvertO(webHooklistenForVoiceResponse);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICELIST(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHookiconURL = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null, Expression<Func<bool>> webHooklistenForVoiceResponse = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_ChoiceList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            if (webHookiconURL != null)
            {
                webHook["icon"] = ExpressionConverter.ConvertO(webHookiconURL);
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            var choicesObject = new JObject();
            var choicesObjectpropCount = 0;
            if (choicesObjectpropCount > 0)
            {
                webHook["choices"] = choicesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHooklistenForVoiceResponse != null)
            {
                webHook["listenForInput"] = ExpressionConverter.ConvertO(webHooklistenForVoiceResponse);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponsePEOPLE(Expression<Func<string>> webHookmessage, Expression<Func<webHookmodeInput>> webHookmode, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHooksearchString = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null, Expression<Func<bool>> webHooklistenForVoiceResponse = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_People";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            webHookpropCount++;
            webHook["mode"] = ExpressionConverter.ConvertO(webHookmode);
            if (webHooksearchString != null)
            {
                webHook["searchstr"] = ExpressionConverter.ConvertO(webHooksearchString);
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHooklistenForVoiceResponse != null)
            {
                webHook["listenForInput"] = ExpressionConverter.ConvertO(webHooklistenForVoiceResponse);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseINTENTVECTOR(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHooklUISIntentVector, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_IntentVector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            webHookpropCount++;
            webHook["intentVector"] = ExpressionConverter.ConvertO(webHooklUISIntentVector);
            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseMEMORY(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookmemoryType, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHookiconURL = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<string>> webHooktargetUser = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_Memory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["message"] = ExpressionConverter.ConvertO(webHookmessage);
            webHookpropCount++;
            webHook["type"] = ExpressionConverter.ConvertO(webHookmemoryType);
            webHookpropCount++;
            webHook["activityJson"] = ExpressionConverter.ConvertO(webHookreplyActivity);
            if (webHookiconURL != null)
            {
                webHook["icon"] = ExpressionConverter.ConvertO(webHookiconURL);
                webHookpropCount++;
            }

            if (webHookacceptResponseFrom != null)
            {
                webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                webHookpropCount++;
            }

            if (webHooktargetUser != null)
            {
                webHook["targetUserMemory"] = ExpressionConverter.ConvertO(webHooktargetUser);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookshowInChat != null)
            {
                webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseADAPTIVECARD(Expression<Func<string>> selectedCard, Expression<Func<object>> webHook = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerResponse_AdaptiveCard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["selectedCard"] = ExpressionConverter.Convert(selectedCard);
            callPayload.Body = ExpressionConverter.ConvertO(webHook);
            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInitiateBridge(Expression<Func<webHookparticipantsInputItem[]>> webHookparticipants, Expression<Func<string>> webHookendChatCommand, Expression<Func<int>> webHookidleTimeout, Expression<Func<string[]>> webHookfilters = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerBridge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["participants"] = ExpressionConverter.ConvertO(webHookparticipants);
            webHookpropCount++;
            webHook["endBridgeCommand"] = ExpressionConverter.ConvertO(webHookendChatCommand);
            webHookpropCount++;
            webHook["idleTimeoutDuration"] = ExpressionConverter.ConvertO(webHookidleTimeout);
            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionAction<WebHook>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseSaveBotMemory> SaveBotMemory(Expression<Func<string>> contentuserPrincipalName, Expression<Func<string>> contentmemoryType, Expression<Func<string>> contenttitle, Expression<Func<string>> contentvalue)
        {
            var apiCallPath = "/api/triggers/bot/saveBotMemory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["user"] = ExpressionConverter.ConvertO(contentuserPrincipalName);
            contentpropCount++;
            content["type"] = ExpressionConverter.ConvertO(contentmemoryType);
            contentpropCount++;
            content["title"] = ExpressionConverter.ConvertO(contenttitle);
            contentpropCount++;
            content["value"] = ExpressionConverter.ConvertO(contentvalue);
            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction<ResponseSaveBotMemory>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseDeleteBotMemory> DeleteBotMemory(Expression<Func<string>> contentuserPrincipalName, Expression<Func<string>> contentmemoryType, Expression<Func<string>> contentvalue)
        {
            var apiCallPath = "/api/triggers/bot/deleteBotMemory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            contentpropCount++;
            content["user"] = ExpressionConverter.ConvertO(contentuserPrincipalName);
            contentpropCount++;
            content["type"] = ExpressionConverter.ConvertO(contentmemoryType);
            contentpropCount++;
            content["value"] = ExpressionConverter.ConvertO(contentvalue);
            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction<ResponseDeleteBotMemory>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<MemoryItem[]> GetMemoryItemsByType(Expression<Func<string>> checkMemoryInfouserPrincipalName, Expression<Func<string>> checkMemoryInfomemoryType)
        {
            var apiCallPath = "/api/triggers/bot/CheckMemoryByType";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var checkMemoryInfo = new JObject();
            var checkMemoryInfopropCount = 0;
            checkMemoryInfopropCount++;
            checkMemoryInfo["user"] = ExpressionConverter.ConvertO(checkMemoryInfouserPrincipalName);
            checkMemoryInfopropCount++;
            checkMemoryInfo["type"] = ExpressionConverter.ConvertO(checkMemoryInfomemoryType);
            if (checkMemoryInfopropCount > 0)
            {
                callPayload.Body = checkMemoryInfo;
            }

            return new ApiConnectionAction<MemoryItem[]>(callPayload);
        }
    }

    public class BizzyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsPost(Expression<Func<string>> webHooktriggerDescription, Expression<Func<webHookbotTriggerTypeInput>> webHookbotTriggerType, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHookkeywords = null, Expression<Func<string>> webHookDeprecatedLUISAPIKey = null, Expression<Func<string>> webHookDeprecatedLUISApp = null, Expression<Func<string>> webHookDeprecatedLUISIntent = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/triggers/webhooks/register";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["triggerDescription"] = ExpressionConverter.ConvertO(webHooktriggerDescription);
            webHookpropCount++;
            webHook["triggerType"] = ExpressionConverter.ConvertO(webHookbotTriggerType);
            if (webHookkeywords != null)
            {
                webHook["keywords"] = ExpressionConverter.ConvertO(webHookkeywords);
                webHookpropCount++;
            }

            if (webHookDeprecatedLUISAPIKey != null)
            {
                webHook["luisApiKey"] = ExpressionConverter.ConvertO(webHookDeprecatedLUISAPIKey);
                webHookpropCount++;
            }

            if (webHookDeprecatedLUISApp != null)
            {
                webHook["luisAppId"] = ExpressionConverter.ConvertO(webHookDeprecatedLUISApp);
                webHookpropCount++;
            }

            if (webHookDeprecatedLUISIntent != null)
            {
                webHook["luisIntent"] = ExpressionConverter.ConvertO(webHookDeprecatedLUISIntent);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionTrigger<WebHook>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsVectorPost(Expression<Func<string>> webHooktriggerDescription, Expression<Func<webHookbotTriggerTypeInput>> webHookbotTriggerType, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHooklUISIntentVector = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/triggers/webhooks/registerVector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHook = new JObject();
            var webHookpropCount = 0;
            webHook["webHookUri"] = "@listCallbackUrl()";
            webHookpropCount++;
            if (webHookfilters != null)
            {
                webHook["filters"] = ExpressionConverter.ConvertO(webHookfilters);
                webHookpropCount++;
            }

            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                webHook["headers"] = headersObject;
                webHookpropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                webHook["properties"] = propertiesObject;
                webHookpropCount++;
            }

            webHookpropCount++;
            webHook["triggerDescription"] = ExpressionConverter.ConvertO(webHooktriggerDescription);
            webHookpropCount++;
            webHook["triggerType"] = ExpressionConverter.ConvertO(webHookbotTriggerType);
            if (webHooklUISIntentVector != null)
            {
                webHook["intentVector"] = ExpressionConverter.ConvertO(webHooklUISIntentVector);
                webHookpropCount++;
            }

            if (webHookallowBranching != null)
            {
                webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                webHookpropCount++;
            }

            if (webHookpropCount > 0)
            {
                callPayload.Body = webHook;
            }

            return new ApiConnectionTrigger<WebHook>(callPayload, triggerName, recurrence);
        }
    }

    public class BotReplyResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }
    }

    public enum cardSetdisplayStyleInput
    {
        Carousel,
        List
    }

    public class BotConversationStartResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("activityJson")]
        public string ReplyActivity { get; set; }
    }

    public class BotGroupConversationStartResponse
    {
        [JsonProperty("id")]
        public string ConversationId { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("activityJson")]
        public string ReplyActivity { get; set; }
    }

    public class WebHook
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("webHookUri")]
        public string WebHookUri { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public enum webHookacceptResponseFromInput
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    public enum webHookdateScopeInput
    {
        [EnumMember(Value = "Date Only")]
        DateOnly,
        [EnumMember(Value = "Time Only")]
        TimeOnly,
        [EnumMember(Value = "Date and Time")]
        DateAndTime
    }

    public enum webHookallowBranchingInput
    {
        No,
        Yes
    }

    public enum webHookmodeInput
    {
        Single,
        Multiple
    }

    public class webHookparticipantsInputItem
    {
        [JsonProperty("chatUserName")]
        public string UserName { get; set; }

        [JsonProperty("chatInitiationMessage")]
        public string InitiationMessage { get; set; }

        [JsonProperty("activityJson")]
        public string ReplyActivity { get; set; }
    }

    public class ResponseSaveBotMemory
    {
        [JsonProperty("text")]
        public string BotMemorySaveResult { get; set; }
    }

    public class ResponseDeleteBotMemory
    {
        [JsonProperty("text")]
        public string BotMemoryDeleteResult { get; set; }
    }

    public class MemoryItem
    {
        [JsonProperty("title")]
        public string MemoryItemTitle { get; set; }

        [JsonProperty("value")]
        public string MemoryItemValue { get; set; }
    }

    public enum webHookbotTriggerTypeInput
    {
        Shared,
        Personal
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy;

    public partial class WorkflowManagedActions
    {
        public BizzyActions Bizzy(string connectionId) => new BizzyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BizzyTriggers Bizzy(string connectionId) => new BizzyTriggers(connectionId);
    }
}
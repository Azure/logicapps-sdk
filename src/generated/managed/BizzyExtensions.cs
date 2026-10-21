//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BizzyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReply(Expression<Func<string>> contentreplyText, Expression<Func<string>> contentreplyActivity, Expression<Func<bool>> contentshowInChat = null, Expression<Func<string>> contentcustomChannelData = null, Expression<Func<string>> contentsignalResponseJSON = null, Expression<Func<string>> contentmessageID = null)
        {
            var __workflow_contentreplyText = WorkflowExpression.Compile(contentreplyText, nameof(contentreplyText), required: true);
            var __workflow_contentreplyActivity = WorkflowExpression.Compile(contentreplyActivity, nameof(contentreplyActivity), required: true);
            var __workflow_contentshowInChat = WorkflowExpression.Compile(contentshowInChat, nameof(contentshowInChat), required: false);
            var __workflow_contentcustomChannelData = WorkflowExpression.Compile(contentcustomChannelData, nameof(contentcustomChannelData), required: false);
            var __workflow_contentsignalResponseJSON = WorkflowExpression.Compile(contentsignalResponseJSON, nameof(contentsignalResponseJSON), required: false);
            var __workflow_contentmessageID = WorkflowExpression.Compile(contentmessageID, nameof(contentmessageID), required: false);
            return new DeferredBodyAction<BotReplyResponse>(() =>
            {
                var apiCallPath = "/api/triggers/bot/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["message"] = ExpressionConverter.ConvertO(__workflow_contentreplyText);
                contentpropCount++;
                content["activityJson"] = ExpressionConverter.ConvertO(__workflow_contentreplyActivity);
                if (__workflow_contentshowInChat != null)
                {
                    if (__workflow_contentshowInChat != null)
                    {
                        content["showInChat"] = ExpressionConverter.ConvertO(__workflow_contentshowInChat);
                        contentpropCount++;
                    }

                    contentpropCount++;
                }
                else
                {
                    content["showInChat"] = true;
                    contentpropCount++;
                }

                if (__workflow_contentcustomChannelData != null)
                {
                    content["customChannelDataJson"] = ExpressionConverter.ConvertO(__workflow_contentcustomChannelData);
                    contentpropCount++;
                }

                if (__workflow_contentsignalResponseJSON != null)
                {
                    content["signalResponse"] = ExpressionConverter.ConvertO(__workflow_contentsignalResponseJSON);
                    contentpropCount++;
                }

                if (__workflow_contentmessageID != null)
                {
                    content["messageId"] = ExpressionConverter.ConvertO(__workflow_contentmessageID);
                    contentpropCount++;
                }

                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCard(Expression<Func<string>> selectedCard, Expression<Func<object>> content = null)
        {
            var __workflow_selectedCard = WorkflowExpression.Compile(selectedCard, nameof(selectedCard), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<BotReplyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/bot/adaptiveCards/{0}/replyWithAdaptiveCard", __workflow_selectedCard.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<JToken> GenerateAdaptiveCard(Expression<Func<string>> selectedCard, Expression<Func<object>> content = null)
        {
            var __workflow_selectedCard = WorkflowExpression.Compile(selectedCard, nameof(selectedCard), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/bot/adaptiveCards/{0}/generateAdaptiveCard", __workflow_selectedCard.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCardSet(Expression<Func<cardSetdisplayStyleInput>> cardSetdisplayStyle, Expression<Func<string>> cardSetreplyActivity, Expression<Func<bool>> cardSetshowInTab = null, Expression<Func<string>> cardSettabButtonLabel = null, Expression<Func<string>> cardSettabButtonMessage = null)
        {
            var __workflow_cardSetdisplayStyle = WorkflowExpression.Compile(cardSetdisplayStyle, nameof(cardSetdisplayStyle), required: true);
            var __workflow_cardSetreplyActivity = WorkflowExpression.Compile(cardSetreplyActivity, nameof(cardSetreplyActivity), required: true);
            var __workflow_cardSetshowInTab = WorkflowExpression.Compile(cardSetshowInTab, nameof(cardSetshowInTab), required: false);
            var __workflow_cardSettabButtonLabel = WorkflowExpression.Compile(cardSettabButtonLabel, nameof(cardSettabButtonLabel), required: false);
            var __workflow_cardSettabButtonMessage = WorkflowExpression.Compile(cardSettabButtonMessage, nameof(cardSettabButtonMessage), required: false);
            return new DeferredBodyAction<BotReplyResponse>(() =>
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
                cardSet["displayStyle"] = ExpressionConverter.ConvertO(__workflow_cardSetdisplayStyle);
                cardSetpropCount++;
                cardSet["activityJson"] = ExpressionConverter.ConvertO(__workflow_cardSetreplyActivity);
                if (__workflow_cardSetshowInTab != null)
                {
                    if (__workflow_cardSetshowInTab != null)
                    {
                        cardSet["showInTab"] = ExpressionConverter.ConvertO(__workflow_cardSetshowInTab);
                        cardSetpropCount++;
                    }

                    cardSetpropCount++;
                }
                else
                {
                    cardSet["showInTab"] = false;
                    cardSetpropCount++;
                }

                if (__workflow_cardSettabButtonLabel != null)
                {
                    cardSet["deepLinkButtonLabel"] = ExpressionConverter.ConvertO(__workflow_cardSettabButtonLabel);
                    cardSetpropCount++;
                }

                if (__workflow_cardSettabButtonMessage != null)
                {
                    cardSet["deepLinkMessage"] = ExpressionConverter.ConvertO(__workflow_cardSettabButtonMessage);
                    cardSetpropCount++;
                }

                if (cardSetpropCount > 0)
                {
                    callPayload.Body = cardSet;
                }

                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> UpdateAdaptiveCard(Expression<Func<string>> cardInforeplyActivity)
        {
            var __workflow_cardInforeplyActivity = WorkflowExpression.Compile(cardInforeplyActivity, nameof(cardInforeplyActivity), required: true);
            return new DeferredBodyAction<BotReplyResponse>(() =>
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
                cardInfo["activityJson"] = ExpressionConverter.ConvertO(__workflow_cardInforeplyActivity);
                if (cardInfopropCount > 0)
                {
                    callPayload.Body = cardInfo;
                }

                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotConversationStartResponse> StartConversation(Expression<Func<string>> contenttargetBot, Expression<Func<string>> contentconversationText, Expression<Func<string>> contentuser)
        {
            var __workflow_contenttargetBot = WorkflowExpression.Compile(contenttargetBot, nameof(contenttargetBot), required: true);
            var __workflow_contentconversationText = WorkflowExpression.Compile(contentconversationText, nameof(contentconversationText), required: true);
            var __workflow_contentuser = WorkflowExpression.Compile(contentuser, nameof(contentuser), required: true);
            return new DeferredBodyAction<BotConversationStartResponse>(() =>
            {
                var apiCallPath = "/api/triggers/bot/startConversation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["EnterpriseBot"] = ExpressionConverter.ConvertO(__workflow_contenttargetBot);
                contentpropCount++;
                content["message"] = ExpressionConverter.ConvertO(__workflow_contentconversationText);
                contentpropCount++;
                content["user"] = ExpressionConverter.ConvertO(__workflow_contentuser);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction<BotConversationStartResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotGroupConversationStartResponse> StartGroupConversation(Expression<Func<string>> contenttargetBot, Expression<Func<string>> contentchannelName, Expression<Func<string>> contentconversationText)
        {
            var __workflow_contenttargetBot = WorkflowExpression.Compile(contenttargetBot, nameof(contenttargetBot), required: true);
            var __workflow_contentchannelName = WorkflowExpression.Compile(contentchannelName, nameof(contentchannelName), required: true);
            var __workflow_contentconversationText = WorkflowExpression.Compile(contentconversationText, nameof(contentconversationText), required: true);
            return new DeferredBodyAction<BotGroupConversationStartResponse>(() =>
            {
                var apiCallPath = "/api/triggers/bot/startGroupConversation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["EnterpriseBot"] = ExpressionConverter.ConvertO(__workflow_contenttargetBot);
                var teamIDStrObject = new JObject();
                var teamIDStrObjectpropCount = 0;
                if (teamIDStrObjectpropCount > 0)
                {
                    content["teamIDStr"] = teamIDStrObject;
                    contentpropCount++;
                }

                contentpropCount++;
                content["channelId"] = ExpressionConverter.ConvertO(__workflow_contentchannelName);
                contentpropCount++;
                content["message"] = ExpressionConverter.ConvertO(__workflow_contentconversationText);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction<BotGroupConversationStartResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IWorkflowAction SendBridgeEvent(Expression<Func<string>> contentreplyActivity)
        {
            var __workflow_contentreplyActivity = WorkflowExpression.Compile(contentreplyActivity, nameof(contentreplyActivity), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/triggers/bot/sendBridgeEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["activityJson"] = ExpressionConverter.ConvertO(__workflow_contentreplyActivity);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponse(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseDATE(Expression<Func<webHookdateScopeInput>> webHookdateScope, Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var __workflow_webHookdateScope = WorkflowExpression.Compile(webHookdateScope, nameof(webHookdateScope), required: true);
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["dateScope"] = ExpressionConverter.ConvertO(__workflow_webHookdateScope);
                webHookpropCount++;
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICE(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookchoiceValues, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null, Expression<Func<bool>> webHooklistenForVoiceResponse = null)
        {
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHookchoiceValues = WorkflowExpression.Compile(webHookchoiceValues, nameof(webHookchoiceValues), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            var __workflow_webHooklistenForVoiceResponse = WorkflowExpression.Compile(webHooklistenForVoiceResponse, nameof(webHooklistenForVoiceResponse), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                webHookpropCount++;
                webHook["choices"] = ExpressionConverter.ConvertO(__workflow_webHookchoiceValues);
                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (__workflow_webHooklistenForVoiceResponse != null)
                {
                    if (__workflow_webHooklistenForVoiceResponse != null)
                    {
                        webHook["listenForInput"] = ExpressionConverter.ConvertO(__workflow_webHooklistenForVoiceResponse);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["listenForInput"] = false;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICELIST(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHookiconURL = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null, Expression<Func<bool>> webHooklistenForVoiceResponse = null)
        {
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookiconURL = WorkflowExpression.Compile(webHookiconURL, nameof(webHookiconURL), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            var __workflow_webHooklistenForVoiceResponse = WorkflowExpression.Compile(webHooklistenForVoiceResponse, nameof(webHooklistenForVoiceResponse), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_ChoiceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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

                if (__workflow_webHookiconURL != null)
                {
                    webHook["icon"] = ExpressionConverter.ConvertO(__workflow_webHookiconURL);
                    webHookpropCount++;
                }

                webHookpropCount++;
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                var choicesObject = new JObject();
                var choicesObjectpropCount = 0;
                if (choicesObjectpropCount > 0)
                {
                    webHook["choices"] = choicesObject;
                    webHookpropCount++;
                }

                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (__workflow_webHooklistenForVoiceResponse != null)
                {
                    if (__workflow_webHooklistenForVoiceResponse != null)
                    {
                        webHook["listenForInput"] = ExpressionConverter.ConvertO(__workflow_webHooklistenForVoiceResponse);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["listenForInput"] = false;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponsePEOPLE(Expression<Func<string>> webHookmessage, Expression<Func<webHookmodeInput>> webHookmode, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHooksearchString = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null, Expression<Func<bool>> webHooklistenForVoiceResponse = null)
        {
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHookmode = WorkflowExpression.Compile(webHookmode, nameof(webHookmode), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHooksearchString = WorkflowExpression.Compile(webHooksearchString, nameof(webHooksearchString), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            var __workflow_webHooklistenForVoiceResponse = WorkflowExpression.Compile(webHooklistenForVoiceResponse, nameof(webHooklistenForVoiceResponse), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_People";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                webHookpropCount++;
                webHook["mode"] = ExpressionConverter.ConvertO(__workflow_webHookmode);
                if (__workflow_webHooksearchString != null)
                {
                    webHook["searchstr"] = ExpressionConverter.ConvertO(__workflow_webHooksearchString);
                    webHookpropCount++;
                }

                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (__workflow_webHooklistenForVoiceResponse != null)
                {
                    if (__workflow_webHooklistenForVoiceResponse != null)
                    {
                        webHook["listenForInput"] = ExpressionConverter.ConvertO(__workflow_webHooklistenForVoiceResponse);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["listenForInput"] = false;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseINTENTVECTOR(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHooklUISIntentVector, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHooklUISIntentVector = WorkflowExpression.Compile(webHooklUISIntentVector, nameof(webHooklUISIntentVector), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_IntentVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                webHookpropCount++;
                webHook["intentVector"] = ExpressionConverter.ConvertO(__workflow_webHooklUISIntentVector);
                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseMEMORY(Expression<Func<string>> webHookmessage, Expression<Func<string>> webHookmemoryType, Expression<Func<string>> webHookreplyActivity, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHookiconURL = null, Expression<Func<webHookacceptResponseFromInput>> webHookacceptResponseFrom = null, Expression<Func<string>> webHooktargetUser = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, Expression<Func<bool>> webHookshowInChat = null)
        {
            var __workflow_webHookmessage = WorkflowExpression.Compile(webHookmessage, nameof(webHookmessage), required: true);
            var __workflow_webHookmemoryType = WorkflowExpression.Compile(webHookmemoryType, nameof(webHookmemoryType), required: true);
            var __workflow_webHookreplyActivity = WorkflowExpression.Compile(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookiconURL = WorkflowExpression.Compile(webHookiconURL, nameof(webHookiconURL), required: false);
            var __workflow_webHookacceptResponseFrom = WorkflowExpression.Compile(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            var __workflow_webHooktargetUser = WorkflowExpression.Compile(webHooktargetUser, nameof(webHooktargetUser), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            var __workflow_webHookshowInChat = WorkflowExpression.Compile(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Memory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["message"] = ExpressionConverter.ConvertO(__workflow_webHookmessage);
                webHookpropCount++;
                webHook["type"] = ExpressionConverter.ConvertO(__workflow_webHookmemoryType);
                webHookpropCount++;
                webHook["activityJson"] = ExpressionConverter.ConvertO(__workflow_webHookreplyActivity);
                if (__workflow_webHookiconURL != null)
                {
                    webHook["icon"] = ExpressionConverter.ConvertO(__workflow_webHookiconURL);
                    webHookpropCount++;
                }

                if (__workflow_webHookacceptResponseFrom != null)
                {
                    if (__workflow_webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(__workflow_webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (__workflow_webHooktargetUser != null)
                {
                    webHook["targetUserMemory"] = ExpressionConverter.ConvertO(__workflow_webHooktargetUser);
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (__workflow_webHookshowInChat != null)
                {
                    if (__workflow_webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(__workflow_webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseADAPTIVECARD(Expression<Func<string>> selectedCard, Expression<Func<object>> webHook = null)
        {
            var __workflow_selectedCard = WorkflowExpression.Compile(selectedCard, nameof(selectedCard), required: true);
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_AdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["selectedCard"] = ExpressionConverter.Convert(__workflow_selectedCard);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInitiateBridge(Expression<Func<webHookparticipantsInputItem[]>> webHookparticipants, Expression<Func<string>> webHookendChatCommand, Expression<Func<int>> webHookidleTimeout, Expression<Func<string[]>> webHookfilters = null)
        {
            var __workflow_webHookparticipants = WorkflowExpression.Compile(webHookparticipants, nameof(webHookparticipants), required: true);
            var __workflow_webHookendChatCommand = WorkflowExpression.Compile(webHookendChatCommand, nameof(webHookendChatCommand), required: true);
            var __workflow_webHookidleTimeout = WorkflowExpression.Compile(webHookidleTimeout, nameof(webHookidleTimeout), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["participants"] = ExpressionConverter.ConvertO(__workflow_webHookparticipants);
                webHookpropCount++;
                webHook["endBridgeCommand"] = ExpressionConverter.ConvertO(__workflow_webHookendChatCommand);
                webHookpropCount++;
                webHook["idleTimeoutDuration"] = ExpressionConverter.ConvertO(__workflow_webHookidleTimeout);
                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionAction<WebHook>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseSaveBotMemory> SaveBotMemory(Expression<Func<string>> contentuserPrincipalName, Expression<Func<string>> contentmemoryType, Expression<Func<string>> contenttitle, Expression<Func<string>> contentvalue)
        {
            var __workflow_contentuserPrincipalName = WorkflowExpression.Compile(contentuserPrincipalName, nameof(contentuserPrincipalName), required: true);
            var __workflow_contentmemoryType = WorkflowExpression.Compile(contentmemoryType, nameof(contentmemoryType), required: true);
            var __workflow_contenttitle = WorkflowExpression.Compile(contenttitle, nameof(contenttitle), required: true);
            var __workflow_contentvalue = WorkflowExpression.Compile(contentvalue, nameof(contentvalue), required: true);
            return new DeferredBodyAction<ResponseSaveBotMemory>(() =>
            {
                var apiCallPath = "/api/triggers/bot/saveBotMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["user"] = ExpressionConverter.ConvertO(__workflow_contentuserPrincipalName);
                contentpropCount++;
                content["type"] = ExpressionConverter.ConvertO(__workflow_contentmemoryType);
                contentpropCount++;
                content["title"] = ExpressionConverter.ConvertO(__workflow_contenttitle);
                contentpropCount++;
                content["value"] = ExpressionConverter.ConvertO(__workflow_contentvalue);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction<ResponseSaveBotMemory>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseDeleteBotMemory> DeleteBotMemory(Expression<Func<string>> contentuserPrincipalName, Expression<Func<string>> contentmemoryType, Expression<Func<string>> contentvalue)
        {
            var __workflow_contentuserPrincipalName = WorkflowExpression.Compile(contentuserPrincipalName, nameof(contentuserPrincipalName), required: true);
            var __workflow_contentmemoryType = WorkflowExpression.Compile(contentmemoryType, nameof(contentmemoryType), required: true);
            var __workflow_contentvalue = WorkflowExpression.Compile(contentvalue, nameof(contentvalue), required: true);
            return new DeferredBodyAction<ResponseDeleteBotMemory>(() =>
            {
                var apiCallPath = "/api/triggers/bot/deleteBotMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["user"] = ExpressionConverter.ConvertO(__workflow_contentuserPrincipalName);
                contentpropCount++;
                content["type"] = ExpressionConverter.ConvertO(__workflow_contentmemoryType);
                contentpropCount++;
                content["value"] = ExpressionConverter.ConvertO(__workflow_contentvalue);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction<ResponseDeleteBotMemory>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<MemoryItem[]> GetMemoryItemsByType(Expression<Func<string>> checkMemoryInfouserPrincipalName, Expression<Func<string>> checkMemoryInfomemoryType)
        {
            var __workflow_checkMemoryInfouserPrincipalName = WorkflowExpression.Compile(checkMemoryInfouserPrincipalName, nameof(checkMemoryInfouserPrincipalName), required: true);
            var __workflow_checkMemoryInfomemoryType = WorkflowExpression.Compile(checkMemoryInfomemoryType, nameof(checkMemoryInfomemoryType), required: true);
            return new DeferredBodyAction<MemoryItem[]>(() =>
            {
                var apiCallPath = "/api/triggers/bot/CheckMemoryByType";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var checkMemoryInfo = new JObject();
                var checkMemoryInfopropCount = 0;
                checkMemoryInfopropCount++;
                checkMemoryInfo["user"] = ExpressionConverter.ConvertO(__workflow_checkMemoryInfouserPrincipalName);
                checkMemoryInfopropCount++;
                checkMemoryInfo["type"] = ExpressionConverter.ConvertO(__workflow_checkMemoryInfomemoryType);
                if (checkMemoryInfopropCount > 0)
                {
                    callPayload.Body = checkMemoryInfo;
                }

                return new ApiConnectionAction<MemoryItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class BizzyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsPost(Expression<Func<string>> webHooktriggerDescription, Expression<Func<webHookbotTriggerTypeInput>> webHookbotTriggerType, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHookkeywords = null, Expression<Func<string>> webHookDeprecatedLUISAPIKey = null, Expression<Func<string>> webHookDeprecatedLUISApp = null, Expression<Func<string>> webHookDeprecatedLUISIntent = null, FlowRecurrence recurrence = null)
        {
            var __workflow_webHooktriggerDescription = WorkflowExpression.Compile(webHooktriggerDescription, nameof(webHooktriggerDescription), required: true);
            var __workflow_webHookbotTriggerType = WorkflowExpression.Compile(webHookbotTriggerType, nameof(webHookbotTriggerType), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHookkeywords = WorkflowExpression.Compile(webHookkeywords, nameof(webHookkeywords), required: false);
            var __workflow_webHookDeprecatedLUISAPIKey = WorkflowExpression.Compile(webHookDeprecatedLUISAPIKey, nameof(webHookDeprecatedLUISAPIKey), required: false);
            var __workflow_webHookDeprecatedLUISApp = WorkflowExpression.Compile(webHookDeprecatedLUISApp, nameof(webHookDeprecatedLUISApp), required: false);
            var __workflow_webHookDeprecatedLUISIntent = WorkflowExpression.Compile(webHookDeprecatedLUISIntent, nameof(webHookDeprecatedLUISIntent), required: false);
            return new DeferredBodyTrigger<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["triggerDescription"] = ExpressionConverter.ConvertO(__workflow_webHooktriggerDescription);
                webHookpropCount++;
                webHook["triggerType"] = ExpressionConverter.ConvertO(__workflow_webHookbotTriggerType);
                if (__workflow_webHookkeywords != null)
                {
                    webHook["keywords"] = ExpressionConverter.ConvertO(__workflow_webHookkeywords);
                    webHookpropCount++;
                }

                if (__workflow_webHookDeprecatedLUISAPIKey != null)
                {
                    webHook["luisApiKey"] = ExpressionConverter.ConvertO(__workflow_webHookDeprecatedLUISAPIKey);
                    webHookpropCount++;
                }

                if (__workflow_webHookDeprecatedLUISApp != null)
                {
                    webHook["luisAppId"] = ExpressionConverter.ConvertO(__workflow_webHookDeprecatedLUISApp);
                    webHookpropCount++;
                }

                if (__workflow_webHookDeprecatedLUISIntent != null)
                {
                    webHook["luisIntent"] = ExpressionConverter.ConvertO(__workflow_webHookDeprecatedLUISIntent);
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionTrigger<WebHook>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsVectorPost(Expression<Func<string>> webHooktriggerDescription, Expression<Func<webHookbotTriggerTypeInput>> webHookbotTriggerType, Expression<Func<string[]>> webHookfilters = null, Expression<Func<string>> webHooklUISIntentVector = null, Expression<Func<webHookallowBranchingInput>> webHookallowBranching = null, FlowRecurrence recurrence = null)
        {
            var __workflow_webHooktriggerDescription = WorkflowExpression.Compile(webHooktriggerDescription, nameof(webHooktriggerDescription), required: true);
            var __workflow_webHookbotTriggerType = WorkflowExpression.Compile(webHookbotTriggerType, nameof(webHookbotTriggerType), required: true);
            var __workflow_webHookfilters = WorkflowExpression.Compile(webHookfilters, nameof(webHookfilters), required: false);
            var __workflow_webHooklUISIntentVector = WorkflowExpression.Compile(webHooklUISIntentVector, nameof(webHooklUISIntentVector), required: false);
            var __workflow_webHookallowBranching = WorkflowExpression.Compile(webHookallowBranching, nameof(webHookallowBranching), required: false);
            return new DeferredBodyTrigger<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
                webHookpropCount++;
                if (__workflow_webHookfilters != null)
                {
                    webHook["filters"] = ExpressionConverter.ConvertO(__workflow_webHookfilters);
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
                webHook["triggerDescription"] = ExpressionConverter.ConvertO(__workflow_webHooktriggerDescription);
                webHookpropCount++;
                webHook["triggerType"] = ExpressionConverter.ConvertO(__workflow_webHookbotTriggerType);
                if (__workflow_webHooklUISIntentVector != null)
                {
                    webHook["intentVector"] = ExpressionConverter.ConvertO(__workflow_webHooklUISIntentVector);
                    webHookpropCount++;
                }

                if (__workflow_webHookallowBranching != null)
                {
                    if (__workflow_webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(__workflow_webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }

                return new ApiConnectionTrigger<WebHook>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
    }

    public class BotReplyResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum webHookacceptResponseFromInput
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum webHookdateScopeInput
    {
        [EnumMember(Value = "Date Only")]
        DateOnly,
        [EnumMember(Value = "Time Only")]
        TimeOnly,
        [EnumMember(Value = "Date and Time")]
        DateAndTime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum webHookallowBranchingInput
    {
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

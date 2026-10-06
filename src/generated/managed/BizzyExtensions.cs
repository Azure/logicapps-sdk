//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BizzyActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildSendReply))]
        public IBodyWorkflowAction<BotReplyResponse> SendReply([WorkflowExpression] Func<string> contentreplyText, [WorkflowExpression] Func<string> contentreplyActivity, [WorkflowExpression] Func<bool> contentshowInChat = null, [WorkflowExpression] Func<string> contentcustomChannelData = null, [WorkflowExpression] Func<string> contentsignalResponseJSON = null, [WorkflowExpression] Func<string> contentmessageID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotReplyResponse> __BuildSendReply(WorkflowExpression<string> contentreplyText, WorkflowExpression<string> contentreplyActivity, WorkflowExpression<bool> contentshowInChat = null, WorkflowExpression<string> contentcustomChannelData = null, WorkflowExpression<string> contentsignalResponseJSON = null, WorkflowExpression<string> contentmessageID = null)
        {
            WorkflowExpression.Validate(contentreplyText, nameof(contentreplyText), required: true);
            WorkflowExpression.Validate(contentreplyActivity, nameof(contentreplyActivity), required: true);
            WorkflowExpression.Validate(contentshowInChat, nameof(contentshowInChat), required: false);
            WorkflowExpression.Validate(contentcustomChannelData, nameof(contentcustomChannelData), required: false);
            WorkflowExpression.Validate(contentsignalResponseJSON, nameof(contentsignalResponseJSON), required: false);
            WorkflowExpression.Validate(contentmessageID, nameof(contentmessageID), required: false);
            return new DeferredBodyAction<BotReplyResponse>(() =>
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
                    if (contentshowInChat != null)
                    {
                        content["showInChat"] = ExpressionConverter.ConvertO(contentshowInChat);
                        contentpropCount++;
                    }

                    contentpropCount++;
                }
                else
                {
                    content["showInChat"] = true;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildSendReplyWithAdaptiveCard))]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCard([WorkflowExpression] Func<string> selectedCard, [WorkflowExpression] Func<object> content = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotReplyResponse> __BuildSendReplyWithAdaptiveCard(WorkflowExpression<string> selectedCard, WorkflowExpression<object> content = null)
        {
            WorkflowExpression.Validate(selectedCard, nameof(selectedCard), required: true);
            WorkflowExpression.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<BotReplyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/triggers/bot/adaptiveCards/{0}/replyWithAdaptiveCard", ExpressionConverter.ConvertWithUrlEncoding(selectedCard, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(content);
                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateAdaptiveCard))]
        public IBodyWorkflowAction<JToken> GenerateAdaptiveCard([WorkflowExpression] Func<string> selectedCard, [WorkflowExpression] Func<object> content = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGenerateAdaptiveCard(WorkflowExpression<string> selectedCard, WorkflowExpression<object> content = null)
        {
            WorkflowExpression.Validate(selectedCard, nameof(selectedCard), required: true);
            WorkflowExpression.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/triggers/bot/adaptiveCards/{0}/generateAdaptiveCard", ExpressionConverter.ConvertWithUrlEncoding(selectedCard, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(content);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildSendReplyWithAdaptiveCardSet))]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCardSet([WorkflowExpression] Func<cardSetdisplayStyleInput> cardSetdisplayStyle, [WorkflowExpression] Func<string> cardSetreplyActivity, [WorkflowExpression] Func<bool> cardSetshowInTab = null, [WorkflowExpression] Func<string> cardSettabButtonLabel = null, [WorkflowExpression] Func<string> cardSettabButtonMessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotReplyResponse> __BuildSendReplyWithAdaptiveCardSet(WorkflowExpression<cardSetdisplayStyleInput> cardSetdisplayStyle, WorkflowExpression<string> cardSetreplyActivity, WorkflowExpression<bool> cardSetshowInTab = null, WorkflowExpression<string> cardSettabButtonLabel = null, WorkflowExpression<string> cardSettabButtonMessage = null)
        {
            WorkflowExpression.Validate(cardSetdisplayStyle, nameof(cardSetdisplayStyle), required: true);
            WorkflowExpression.Validate(cardSetreplyActivity, nameof(cardSetreplyActivity), required: true);
            WorkflowExpression.Validate(cardSetshowInTab, nameof(cardSetshowInTab), required: false);
            WorkflowExpression.Validate(cardSettabButtonLabel, nameof(cardSettabButtonLabel), required: false);
            WorkflowExpression.Validate(cardSettabButtonMessage, nameof(cardSettabButtonMessage), required: false);
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
                cardSet["displayStyle"] = ExpressionConverter.ConvertO(cardSetdisplayStyle);
                cardSetpropCount++;
                cardSet["activityJson"] = ExpressionConverter.ConvertO(cardSetreplyActivity);
                if (cardSetshowInTab != null)
                {
                    if (cardSetshowInTab != null)
                    {
                        cardSet["showInTab"] = ExpressionConverter.ConvertO(cardSetshowInTab);
                        cardSetpropCount++;
                    }

                    cardSetpropCount++;
                }
                else
                {
                    cardSet["showInTab"] = false;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAdaptiveCard))]
        public IBodyWorkflowAction<BotReplyResponse> UpdateAdaptiveCard([WorkflowExpression] Func<string> cardInforeplyActivity)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotReplyResponse> __BuildUpdateAdaptiveCard(WorkflowExpression<string> cardInforeplyActivity)
        {
            WorkflowExpression.Validate(cardInforeplyActivity, nameof(cardInforeplyActivity), required: true);
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
                cardInfo["activityJson"] = ExpressionConverter.ConvertO(cardInforeplyActivity);
                if (cardInfopropCount > 0)
                {
                    callPayload.Body = cardInfo;
                }

                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildStartConversation))]
        public IBodyWorkflowAction<BotConversationStartResponse> StartConversation([WorkflowExpression] Func<string> contenttargetBot, [WorkflowExpression] Func<string> contentconversationText, [WorkflowExpression] Func<string> contentuser)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotConversationStartResponse> __BuildStartConversation(WorkflowExpression<string> contenttargetBot, WorkflowExpression<string> contentconversationText, WorkflowExpression<string> contentuser)
        {
            WorkflowExpression.Validate(contenttargetBot, nameof(contenttargetBot), required: true);
            WorkflowExpression.Validate(contentconversationText, nameof(contentconversationText), required: true);
            WorkflowExpression.Validate(contentuser, nameof(contentuser), required: true);
            return new DeferredBodyAction<BotConversationStartResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildStartGroupConversation))]
        public IBodyWorkflowAction<BotGroupConversationStartResponse> StartGroupConversation([WorkflowExpression] Func<string> contenttargetBot, [WorkflowExpression] Func<string> contentchannelName, [WorkflowExpression] Func<string> contentconversationText)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotGroupConversationStartResponse> __BuildStartGroupConversation(WorkflowExpression<string> contenttargetBot, WorkflowExpression<string> contentchannelName, WorkflowExpression<string> contentconversationText)
        {
            WorkflowExpression.Validate(contenttargetBot, nameof(contenttargetBot), required: true);
            WorkflowExpression.Validate(contentchannelName, nameof(contentchannelName), required: true);
            WorkflowExpression.Validate(contentconversationText, nameof(contentconversationText), required: true);
            return new DeferredBodyAction<BotGroupConversationStartResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildSendBridgeEvent))]
        public IWorkflowAction SendBridgeEvent([WorkflowExpression] Func<string> contentreplyActivity)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendBridgeEvent(WorkflowExpression<string> contentreplyActivity)
        {
            WorkflowExpression.Validate(contentreplyActivity, nameof(contentreplyActivity), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponse))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponse([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponse(WorkflowExpression<string> webHookmessage, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<bool> webHookshowInChat = null)
        {
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponseDATE))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseDATE([WorkflowExpression] Func<webHookdateScopeInput> webHookdateScope, [WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponseDATE(WorkflowExpression<webHookdateScopeInput> webHookdateScope, WorkflowExpression<string> webHookmessage, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, WorkflowExpression<bool> webHookshowInChat = null)
        {
            WorkflowExpression.Validate(webHookdateScope, nameof(webHookdateScope), required: true);
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponseCHOICE))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICE([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookchoiceValues, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null, [WorkflowExpression] Func<bool> webHooklistenForVoiceResponse = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponseCHOICE(WorkflowExpression<string> webHookmessage, WorkflowExpression<string> webHookchoiceValues, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, WorkflowExpression<bool> webHookshowInChat = null, WorkflowExpression<bool> webHooklistenForVoiceResponse = null)
        {
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHookchoiceValues, nameof(webHookchoiceValues), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            WorkflowExpression.Validate(webHooklistenForVoiceResponse, nameof(webHooklistenForVoiceResponse), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHooklistenForVoiceResponse != null)
                {
                    if (webHooklistenForVoiceResponse != null)
                    {
                        webHook["listenForInput"] = ExpressionConverter.ConvertO(webHooklistenForVoiceResponse);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponseCHOICELIST))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICELIST([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHookiconURL = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null, [WorkflowExpression] Func<bool> webHooklistenForVoiceResponse = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponseCHOICELIST(WorkflowExpression<string> webHookmessage, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<string> webHookiconURL = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, WorkflowExpression<bool> webHookshowInChat = null, WorkflowExpression<bool> webHooklistenForVoiceResponse = null)
        {
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookiconURL, nameof(webHookiconURL), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            WorkflowExpression.Validate(webHooklistenForVoiceResponse, nameof(webHooklistenForVoiceResponse), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_ChoiceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHooklistenForVoiceResponse != null)
                {
                    if (webHooklistenForVoiceResponse != null)
                    {
                        webHook["listenForInput"] = ExpressionConverter.ConvertO(webHooklistenForVoiceResponse);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponsePEOPLE))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponsePEOPLE([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<webHookmodeInput> webHookmode, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHooksearchString = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null, [WorkflowExpression] Func<bool> webHooklistenForVoiceResponse = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponsePEOPLE(WorkflowExpression<string> webHookmessage, WorkflowExpression<webHookmodeInput> webHookmode, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<string> webHooksearchString = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, WorkflowExpression<bool> webHookshowInChat = null, WorkflowExpression<bool> webHooklistenForVoiceResponse = null)
        {
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHookmode, nameof(webHookmode), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHooksearchString, nameof(webHooksearchString), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            WorkflowExpression.Validate(webHooklistenForVoiceResponse, nameof(webHooklistenForVoiceResponse), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_People";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["showInChat"] = true;
                    webHookpropCount++;
                }

                if (webHooklistenForVoiceResponse != null)
                {
                    if (webHooklistenForVoiceResponse != null)
                    {
                        webHook["listenForInput"] = ExpressionConverter.ConvertO(webHooklistenForVoiceResponse);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponseINTENTVECTOR))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseINTENTVECTOR([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHooklUISIntentVector, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponseINTENTVECTOR(WorkflowExpression<string> webHookmessage, WorkflowExpression<string> webHooklUISIntentVector, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, WorkflowExpression<bool> webHookshowInChat = null)
        {
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHooklUISIntentVector, nameof(webHooklUISIntentVector), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_IntentVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponseMEMORY))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseMEMORY([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookmemoryType, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHookiconURL = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<string> webHooktargetUser = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponseMEMORY(WorkflowExpression<string> webHookmessage, WorkflowExpression<string> webHookmemoryType, WorkflowExpression<string> webHookreplyActivity, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<string> webHookiconURL = null, WorkflowExpression<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, WorkflowExpression<string> webHooktargetUser = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, WorkflowExpression<bool> webHookshowInChat = null)
        {
            WorkflowExpression.Validate(webHookmessage, nameof(webHookmessage), required: true);
            WorkflowExpression.Validate(webHookmemoryType, nameof(webHookmemoryType), required: true);
            WorkflowExpression.Validate(webHookreplyActivity, nameof(webHookreplyActivity), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookiconURL, nameof(webHookiconURL), required: false);
            WorkflowExpression.Validate(webHookacceptResponseFrom, nameof(webHookacceptResponseFrom), required: false);
            WorkflowExpression.Validate(webHooktargetUser, nameof(webHooktargetUser), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            WorkflowExpression.Validate(webHookshowInChat, nameof(webHookshowInChat), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Memory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = ExpressionConverter.ConvertO(webHookacceptResponseFrom);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["acceptResponseFrom"] = "Original User";
                    webHookpropCount++;
                }

                if (webHooktargetUser != null)
                {
                    webHook["targetUserMemory"] = ExpressionConverter.ConvertO(webHooktargetUser);
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
                        webHookpropCount++;
                    }

                    webHookpropCount++;
                }
                else
                {
                    webHook["allowBranching"] = "No";
                    webHookpropCount++;
                }

                if (webHookshowInChat != null)
                {
                    if (webHookshowInChat != null)
                    {
                        webHook["showInChat"] = ExpressionConverter.ConvertO(webHookshowInChat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInputResponseADAPTIVECARD))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseADAPTIVECARD([WorkflowExpression] Func<string> selectedCard, [WorkflowExpression] Func<object> webHook = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInputResponseADAPTIVECARD(WorkflowExpression<string> selectedCard, WorkflowExpression<object> webHook = null)
        {
            WorkflowExpression.Validate(selectedCard, nameof(selectedCard), required: true);
            WorkflowExpression.Validate(webHook, nameof(webHook), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_AdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["selectedCard"] = ExpressionConverter.Convert(selectedCard);
                callPayload.Body = ExpressionConverter.ConvertO(webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsInitiateBridge))]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInitiateBridge([WorkflowExpression] Func<webHookparticipantsInputItem[]> webHookparticipants, [WorkflowExpression] Func<string> webHookendChatCommand, [WorkflowExpression] Func<int> webHookidleTimeout, [WorkflowExpression] Func<string[]> webHookfilters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebHook> __BuildWebHookRegistrationsInitiateBridge(WorkflowExpression<webHookparticipantsInputItem[]> webHookparticipants, WorkflowExpression<string> webHookendChatCommand, WorkflowExpression<int> webHookidleTimeout, WorkflowExpression<string[]> webHookfilters = null)
        {
            WorkflowExpression.Validate(webHookparticipants, nameof(webHookparticipants), required: true);
            WorkflowExpression.Validate(webHookendChatCommand, nameof(webHookendChatCommand), required: true);
            WorkflowExpression.Validate(webHookidleTimeout, nameof(webHookidleTimeout), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            return new DeferredBodyAction<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildSaveBotMemory))]
        public IBodyWorkflowAction<ResponseSaveBotMemory> SaveBotMemory([WorkflowExpression] Func<string> contentuserPrincipalName, [WorkflowExpression] Func<string> contentmemoryType, [WorkflowExpression] Func<string> contenttitle, [WorkflowExpression] Func<string> contentvalue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseSaveBotMemory> __BuildSaveBotMemory(WorkflowExpression<string> contentuserPrincipalName, WorkflowExpression<string> contentmemoryType, WorkflowExpression<string> contenttitle, WorkflowExpression<string> contentvalue)
        {
            WorkflowExpression.Validate(contentuserPrincipalName, nameof(contentuserPrincipalName), required: true);
            WorkflowExpression.Validate(contentmemoryType, nameof(contentmemoryType), required: true);
            WorkflowExpression.Validate(contenttitle, nameof(contenttitle), required: true);
            WorkflowExpression.Validate(contentvalue, nameof(contentvalue), required: true);
            return new DeferredBodyAction<ResponseSaveBotMemory>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteBotMemory))]
        public IBodyWorkflowAction<ResponseDeleteBotMemory> DeleteBotMemory([WorkflowExpression] Func<string> contentuserPrincipalName, [WorkflowExpression] Func<string> contentmemoryType, [WorkflowExpression] Func<string> contentvalue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseDeleteBotMemory> __BuildDeleteBotMemory(WorkflowExpression<string> contentuserPrincipalName, WorkflowExpression<string> contentmemoryType, WorkflowExpression<string> contentvalue)
        {
            WorkflowExpression.Validate(contentuserPrincipalName, nameof(contentuserPrincipalName), required: true);
            WorkflowExpression.Validate(contentmemoryType, nameof(contentmemoryType), required: true);
            WorkflowExpression.Validate(contentvalue, nameof(contentvalue), required: true);
            return new DeferredBodyAction<ResponseDeleteBotMemory>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [WorkflowExpressionFactory(nameof(__BuildGetMemoryItemsByType))]
        public IBodyWorkflowAction<MemoryItem[]> GetMemoryItemsByType([WorkflowExpression] Func<string> checkMemoryInfouserPrincipalName, [WorkflowExpression] Func<string> checkMemoryInfomemoryType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MemoryItem[]> __BuildGetMemoryItemsByType(WorkflowExpression<string> checkMemoryInfouserPrincipalName, WorkflowExpression<string> checkMemoryInfomemoryType)
        {
            WorkflowExpression.Validate(checkMemoryInfouserPrincipalName, nameof(checkMemoryInfouserPrincipalName), required: true);
            WorkflowExpression.Validate(checkMemoryInfomemoryType, nameof(checkMemoryInfomemoryType), required: true);
            return new DeferredBodyAction<MemoryItem[]>(() =>
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
            });
        }
    }

    public class BizzyTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsPost))]
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsPost([WorkflowExpression] Func<string> webHooktriggerDescription, [WorkflowExpression] Func<webHookbotTriggerTypeInput> webHookbotTriggerType, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHookkeywords = null, [WorkflowExpression] Func<string> webHookDeprecatedLUISAPIKey = null, [WorkflowExpression] Func<string> webHookDeprecatedLUISApp = null, [WorkflowExpression] Func<string> webHookDeprecatedLUISIntent = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHook> __BuildWebHookRegistrationsPost(WorkflowExpression<string> webHooktriggerDescription, WorkflowExpression<webHookbotTriggerTypeInput> webHookbotTriggerType, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<string> webHookkeywords = null, WorkflowExpression<string> webHookDeprecatedLUISAPIKey = null, WorkflowExpression<string> webHookDeprecatedLUISApp = null, WorkflowExpression<string> webHookDeprecatedLUISIntent = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(webHooktriggerDescription, nameof(webHooktriggerDescription), required: true);
            WorkflowExpression.Validate(webHookbotTriggerType, nameof(webHookbotTriggerType), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHookkeywords, nameof(webHookkeywords), required: false);
            WorkflowExpression.Validate(webHookDeprecatedLUISAPIKey, nameof(webHookDeprecatedLUISAPIKey), required: false);
            WorkflowExpression.Validate(webHookDeprecatedLUISApp, nameof(webHookDeprecatedLUISApp), required: false);
            WorkflowExpression.Validate(webHookDeprecatedLUISIntent, nameof(webHookDeprecatedLUISIntent), required: false);
            return new DeferredBodyTrigger<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWebHookRegistrationsVectorPost))]
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsVectorPost([WorkflowExpression] Func<string> webHooktriggerDescription, [WorkflowExpression] Func<webHookbotTriggerTypeInput> webHookbotTriggerType, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHooklUISIntentVector = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHook> __BuildWebHookRegistrationsVectorPost(WorkflowExpression<string> webHooktriggerDescription, WorkflowExpression<webHookbotTriggerTypeInput> webHookbotTriggerType, WorkflowExpression<string[]> webHookfilters = null, WorkflowExpression<string> webHooklUISIntentVector = null, WorkflowExpression<webHookallowBranchingInput> webHookallowBranching = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(webHooktriggerDescription, nameof(webHooktriggerDescription), required: true);
            WorkflowExpression.Validate(webHookbotTriggerType, nameof(webHookbotTriggerType), required: true);
            WorkflowExpression.Validate(webHookfilters, nameof(webHookfilters), required: false);
            WorkflowExpression.Validate(webHooklUISIntentVector, nameof(webHooklUISIntentVector), required: false);
            WorkflowExpression.Validate(webHookallowBranching, nameof(webHookallowBranching), required: false);
            return new DeferredBodyTrigger<WebHook>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHook = new JObject();
                var webHookpropCount = 0;
                webHook["webHookUri"] = "#{listCallbackUrl()}";
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
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = ExpressionConverter.ConvertO(webHookallowBranching);
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

                return new ApiConnectionTrigger<WebHook>(callPayload, triggerName, recurrence);
            }, triggerName);
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
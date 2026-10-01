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
        public IBodyWorkflowAction<BotReplyResponse> SendReply([WorkflowExpression] Func<string> contentreplyText, [WorkflowExpression] Func<string> contentreplyActivity, [WorkflowExpression] Func<bool> contentshowInChat = null, [WorkflowExpression] Func<string> contentcustomChannelData = null, [WorkflowExpression] Func<string> contentsignalResponseJSON = null, [WorkflowExpression] Func<string> contentmessageId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["message"] = SourceExpressionConverter.ConvertToken(contentreplyText);
                contentpropCount++;
                content["activityJson"] = SourceExpressionConverter.ConvertToken(contentreplyActivity);
                if (contentshowInChat != null)
                {
                    if (contentshowInChat != null)
                    {
                        content["showInChat"] = SourceExpressionConverter.ConvertToken(contentshowInChat);
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
                    content["customChannelDataJson"] = SourceExpressionConverter.ConvertToken(contentcustomChannelData);
                    contentpropCount++;
                }

                if (contentsignalResponseJSON != null)
                {
                    content["signalResponse"] = SourceExpressionConverter.ConvertToken(contentsignalResponseJSON);
                    contentpropCount++;
                }

                if (contentmessageId != null)
                {
                    content["messageId"] = SourceExpressionConverter.ConvertToken(contentmessageId);
                    contentpropCount++;
                }

                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BotReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCard([WorkflowExpression] Func<string> selectedCard, [WorkflowExpression] Func<object> content = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/bot/adaptiveCards/{0}/replyWithAdaptiveCard", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(selectedCard, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(content);
                return callPayload;
            }

            return new ApiConnectionAction<BotReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<JToken> GenerateAdaptiveCard([WorkflowExpression] Func<string> selectedCard, [WorkflowExpression] Func<object> content = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/triggers/bot/adaptiveCards/{0}/generateAdaptiveCard", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(selectedCard, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(content);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> SendReplyWithAdaptiveCardSet([WorkflowExpression] Func<cardSetdisplayStyleInput> cardSetdisplayStyle, [WorkflowExpression] Func<string> cardSetreplyActivity, [WorkflowExpression] Func<bool> cardSetshowInTab = null, [WorkflowExpression] Func<string> cardSettabButtonLabel = null, [WorkflowExpression] Func<string> cardSettabButtonMessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                cardSet["displayStyle"] = SourceExpressionConverter.Convert(cardSetdisplayStyle);
                cardSetpropCount++;
                cardSet["activityJson"] = SourceExpressionConverter.ConvertToken(cardSetreplyActivity);
                if (cardSetshowInTab != null)
                {
                    if (cardSetshowInTab != null)
                    {
                        cardSet["showInTab"] = SourceExpressionConverter.ConvertToken(cardSetshowInTab);
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
                    cardSet["deepLinkButtonLabel"] = SourceExpressionConverter.ConvertToken(cardSettabButtonLabel);
                    cardSetpropCount++;
                }

                if (cardSettabButtonMessage != null)
                {
                    cardSet["deepLinkMessage"] = SourceExpressionConverter.ConvertToken(cardSettabButtonMessage);
                    cardSetpropCount++;
                }

                if (cardSetpropCount > 0)
                {
                    callPayload.Body = cardSet;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BotReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse> UpdateAdaptiveCard([WorkflowExpression] Func<string> cardInforeplyActivity)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                cardInfo["activityJson"] = SourceExpressionConverter.ConvertToken(cardInforeplyActivity);
                if (cardInfopropCount > 0)
                {
                    callPayload.Body = cardInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BotReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotConversationStartResponse> StartConversation([WorkflowExpression] Func<string> contenttargetBot, [WorkflowExpression] Func<string> contentconversationText, [WorkflowExpression] Func<string> contentuser)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/startConversation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["EnterpriseBot"] = SourceExpressionConverter.ConvertToken(contenttargetBot);
                contentpropCount++;
                content["message"] = SourceExpressionConverter.ConvertToken(contentconversationText);
                contentpropCount++;
                content["user"] = SourceExpressionConverter.ConvertToken(contentuser);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BotConversationStartResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotGroupConversationStartResponse> StartGroupConversation([WorkflowExpression] Func<string> contenttargetBot, [WorkflowExpression] Func<string> contentchannelName, [WorkflowExpression] Func<string> contentconversationText)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/startGroupConversation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["EnterpriseBot"] = SourceExpressionConverter.ConvertToken(contenttargetBot);
                var teamIdStrObject = new JObject();
                var teamIdStrObjectpropCount = 0;
                if (teamIdStrObjectpropCount > 0)
                {
                    content["teamIDStr"] = teamIdStrObject;
                    contentpropCount++;
                }

                contentpropCount++;
                content["channelId"] = SourceExpressionConverter.ConvertToken(contentchannelName);
                contentpropCount++;
                content["message"] = SourceExpressionConverter.ConvertToken(contentconversationText);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BotGroupConversationStartResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IWorkflowAction SendBridgeEvent([WorkflowExpression] Func<string> contentreplyActivity)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/sendBridgeEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["activityJson"] = SourceExpressionConverter.ConvertToken(contentreplyActivity);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponse([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseDATE([WorkflowExpression] Func<webHookdateScopeInput> webHookdateScope, [WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["dateScope"] = SourceExpressionConverter.Convert(webHookdateScope);
                webHookpropCount++;
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICE([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookchoiceValues, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null, [WorkflowExpression] Func<bool> webHooklistenForVoiceResponse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                webHookpropCount++;
                webHook["choices"] = SourceExpressionConverter.ConvertToken(webHookchoiceValues);
                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                        webHook["listenForInput"] = SourceExpressionConverter.ConvertToken(webHooklistenForVoiceResponse);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseCHOICELIST([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHookiconURL = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null, [WorkflowExpression] Func<bool> webHooklistenForVoiceResponse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                    webHook["icon"] = SourceExpressionConverter.ConvertToken(webHookiconURL);
                    webHookpropCount++;
                }

                webHookpropCount++;
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                var choicesObject = new JObject();
                var choicesObjectpropCount = 0;
                if (choicesObjectpropCount > 0)
                {
                    webHook["choices"] = choicesObject;
                    webHookpropCount++;
                }

                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                        webHook["listenForInput"] = SourceExpressionConverter.ConvertToken(webHooklistenForVoiceResponse);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponsePEOPLE([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<webHookmodeInput> webHookmode, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHooksearchString = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null, [WorkflowExpression] Func<bool> webHooklistenForVoiceResponse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                webHookpropCount++;
                webHook["mode"] = SourceExpressionConverter.Convert(webHookmode);
                if (webHooksearchString != null)
                {
                    webHook["searchstr"] = SourceExpressionConverter.ConvertToken(webHooksearchString);
                    webHookpropCount++;
                }

                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                        webHook["listenForInput"] = SourceExpressionConverter.ConvertToken(webHooklistenForVoiceResponse);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseINTENTVECTOR([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHooklUISIntentVector, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                webHookpropCount++;
                webHook["intentVector"] = SourceExpressionConverter.ConvertToken(webHooklUISIntentVector);
                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseMEMORY([WorkflowExpression] Func<string> webHookmessage, [WorkflowExpression] Func<string> webHookmemoryType, [WorkflowExpression] Func<string> webHookreplyActivity, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHookiconURL = null, [WorkflowExpression] Func<webHookacceptResponseFromInput> webHookacceptResponseFrom = null, [WorkflowExpression] Func<string> webHooktargetUser = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, [WorkflowExpression] Func<bool> webHookshowInChat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["message"] = SourceExpressionConverter.ConvertToken(webHookmessage);
                webHookpropCount++;
                webHook["type"] = SourceExpressionConverter.ConvertToken(webHookmemoryType);
                webHookpropCount++;
                webHook["activityJson"] = SourceExpressionConverter.ConvertToken(webHookreplyActivity);
                if (webHookiconURL != null)
                {
                    webHook["icon"] = SourceExpressionConverter.ConvertToken(webHookiconURL);
                    webHookpropCount++;
                }

                if (webHookacceptResponseFrom != null)
                {
                    if (webHookacceptResponseFrom != null)
                    {
                        webHook["acceptResponseFrom"] = SourceExpressionConverter.Convert(webHookacceptResponseFrom);
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
                    webHook["targetUserMemory"] = SourceExpressionConverter.ConvertToken(webHooktargetUser);
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                        webHook["showInChat"] = SourceExpressionConverter.ConvertToken(webHookshowInChat);
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
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInputResponseADAPTIVECARD([WorkflowExpression] Func<string> selectedCard, [WorkflowExpression] Func<object> webHook = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_AdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["selectedCard"] = SourceExpressionConverter.ConvertO(selectedCard);
                callPayload.Body = SourceExpressionConverter.ConvertToken(webHook);
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook> WebHookRegistrationsInitiateBridge([WorkflowExpression] Func<webHookparticipantsInputItem[]> webHookparticipants, [WorkflowExpression] Func<string> webHookendChatCommand, [WorkflowExpression] Func<int> webHookidleTimeout, [WorkflowExpression] Func<string[]> webHookfilters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["participants"] = SourceExpressionConverter.ConvertToken(webHookparticipants);
                webHookpropCount++;
                webHook["endBridgeCommand"] = SourceExpressionConverter.ConvertToken(webHookendChatCommand);
                webHookpropCount++;
                webHook["idleTimeoutDuration"] = SourceExpressionConverter.ConvertToken(webHookidleTimeout);
                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WebHook>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseSaveBotMemory> SaveBotMemory([WorkflowExpression] Func<string> contentuserPrincipalName, [WorkflowExpression] Func<string> contentmemoryType, [WorkflowExpression] Func<string> contenttitle, [WorkflowExpression] Func<string> contentvalue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/saveBotMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["user"] = SourceExpressionConverter.ConvertToken(contentuserPrincipalName);
                contentpropCount++;
                content["type"] = SourceExpressionConverter.ConvertToken(contentmemoryType);
                contentpropCount++;
                content["title"] = SourceExpressionConverter.ConvertToken(contenttitle);
                contentpropCount++;
                content["value"] = SourceExpressionConverter.ConvertToken(contentvalue);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseSaveBotMemory>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseDeleteBotMemory> DeleteBotMemory([WorkflowExpression] Func<string> contentuserPrincipalName, [WorkflowExpression] Func<string> contentmemoryType, [WorkflowExpression] Func<string> contentvalue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/deleteBotMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["user"] = SourceExpressionConverter.ConvertToken(contentuserPrincipalName);
                contentpropCount++;
                content["type"] = SourceExpressionConverter.ConvertToken(contentmemoryType);
                contentpropCount++;
                content["value"] = SourceExpressionConverter.ConvertToken(contentvalue);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseDeleteBotMemory>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<MemoryItem[]> GetMemoryItemsByType([WorkflowExpression] Func<string> checkMemoryInfouserPrincipalName, [WorkflowExpression] Func<string> checkMemoryInfomemoryType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/triggers/bot/CheckMemoryByType";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var checkMemoryInfo = new JObject();
                var checkMemoryInfopropCount = 0;
                checkMemoryInfopropCount++;
                checkMemoryInfo["user"] = SourceExpressionConverter.ConvertToken(checkMemoryInfouserPrincipalName);
                checkMemoryInfopropCount++;
                checkMemoryInfo["type"] = SourceExpressionConverter.ConvertToken(checkMemoryInfomemoryType);
                if (checkMemoryInfopropCount > 0)
                {
                    callPayload.Body = checkMemoryInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MemoryItem[]>(BuildSourceInput);
        }
    }

    public class BizzyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsPost([WorkflowExpression] Func<string> webHooktriggerDescription, [WorkflowExpression] Func<webHookbotTriggerTypeInput> webHookbotTriggerType, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHookkeywords = null, [WorkflowExpression] Func<string> webHookDeprecatedLUISAPIKey = null, [WorkflowExpression] Func<string> webHookDeprecatedLUISApp = null, [WorkflowExpression] Func<string> webHookDeprecatedLUISIntent = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["triggerDescription"] = SourceExpressionConverter.ConvertToken(webHooktriggerDescription);
                webHookpropCount++;
                webHook["triggerType"] = SourceExpressionConverter.Convert(webHookbotTriggerType);
                if (webHookkeywords != null)
                {
                    webHook["keywords"] = SourceExpressionConverter.ConvertToken(webHookkeywords);
                    webHookpropCount++;
                }

                if (webHookDeprecatedLUISAPIKey != null)
                {
                    webHook["luisApiKey"] = SourceExpressionConverter.ConvertToken(webHookDeprecatedLUISAPIKey);
                    webHookpropCount++;
                }

                if (webHookDeprecatedLUISApp != null)
                {
                    webHook["luisAppId"] = SourceExpressionConverter.ConvertToken(webHookDeprecatedLUISApp);
                    webHookpropCount++;
                }

                if (webHookDeprecatedLUISIntent != null)
                {
                    webHook["luisIntent"] = SourceExpressionConverter.ConvertToken(webHookDeprecatedLUISIntent);
                    webHookpropCount++;
                }

                if (webHookpropCount > 0)
                {
                    callPayload.Body = webHook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHook>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebHook> WebHookRegistrationsVectorPost([WorkflowExpression] Func<string> webHooktriggerDescription, [WorkflowExpression] Func<webHookbotTriggerTypeInput> webHookbotTriggerType, [WorkflowExpression] Func<string[]> webHookfilters = null, [WorkflowExpression] Func<string> webHooklUISIntentVector = null, [WorkflowExpression] Func<webHookallowBranchingInput> webHookallowBranching = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    webHook["filters"] = SourceExpressionConverter.ConvertToken(webHookfilters);
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
                webHook["triggerDescription"] = SourceExpressionConverter.ConvertToken(webHooktriggerDescription);
                webHookpropCount++;
                webHook["triggerType"] = SourceExpressionConverter.Convert(webHookbotTriggerType);
                if (webHooklUISIntentVector != null)
                {
                    webHook["intentVector"] = SourceExpressionConverter.ConvertToken(webHooklUISIntentVector);
                    webHookpropCount++;
                }

                if (webHookallowBranching != null)
                {
                    if (webHookallowBranching != null)
                    {
                        webHook["allowBranching"] = SourceExpressionConverter.Convert(webHookallowBranching);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHook>(BuildSourceInput, triggerName, recurrence);
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
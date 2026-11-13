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
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> SendReply(Expression<Func<SendReplyContentInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<BotReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> SendReplyWithAdaptiveCard(Expression<Func<string>> selectedCard, Expression<Func<object>> content)
        {
            var __workflow_selectedCard = WorkflowExpression.Compile(selectedCard, nameof(selectedCard), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<BotReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/bot/adaptiveCards/{0}/replyWithAdaptiveCard", __workflow_selectedCard.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateAdaptiveCard(Expression<Func<string>> selectedCard, Expression<Func<object>> content = null)
        {
            var __workflow_selectedCard = WorkflowExpression.Compile(selectedCard, nameof(selectedCard), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/triggers/bot/adaptiveCards/{0}/generateAdaptiveCard", __workflow_selectedCard.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_content != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> SendReplyWithAdaptiveCardSet(Expression<Func<CardSetInput>> cardSet)
        {
            var __workflow_cardSet = WorkflowExpression.Compile(cardSet, nameof(cardSet), required: true);
            return new DeferredBodyAction<BotReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/adaptiveCards/sendCardSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_cardSet);
                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> UpdateAdaptiveCard(Expression<Func<CardInfoInput>> cardInfo)
        {
            var __workflow_cardInfo = WorkflowExpression.Compile(cardInfo, nameof(cardInfo), required: true);
            return new DeferredBodyAction<BotReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/adaptiveCards/updateCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_cardInfo);
                return new ApiConnectionAction<BotReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotConversationStartResponse, ApiConnectionActionConfiguration> StartConversation(Expression<Func<StartConversationContentInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<BotConversationStartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/startConversation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<BotConversationStartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<BotGroupConversationStartResponse, ApiConnectionActionConfiguration> StartGroupConversation(Expression<Func<StartGroupConversationContentInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<BotGroupConversationStartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/startGroupConversation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<BotGroupConversationStartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendBridgeEvent(Expression<Func<SendBridgeEventContentInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/sendBridgeEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponse(Expression<Func<WebHookRegistrationsInputResponseWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseDATE(Expression<Func<WebHookRegistrationsInputResponseDATEWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Date";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseCHOICE(Expression<Func<WebHookRegistrationsInputResponseCHOICEWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseCHOICELIST(Expression<Func<WebHookRegistrationsInputResponseCHOICELISTWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_ChoiceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponsePEOPLE(Expression<Func<WebHookRegistrationsInputResponsePEOPLEWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_People";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseINTENTVECTOR(Expression<Func<WebHookRegistrationsInputResponseINTENTVECTORWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_IntentVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseMEMORY(Expression<Func<WebHookRegistrationsInputResponseMEMORYWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_Memory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseADAPTIVECARD(Expression<Func<string>> selectedCard, Expression<Func<object>> webHook = null)
        {
            var __workflow_selectedCard = WorkflowExpression.Compile(selectedCard, nameof(selectedCard), required: true);
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: false);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerResponse_AdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["selectedCard"] = ExpressionConverter.Convert(__workflow_selectedCard);
                if (__workflow_webHook != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInitiateBridge(Expression<Func<WebHookRegistrationsInitiateBridgeWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyAction<WebHook, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionAction<WebHook>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseSaveBotMemory, ApiConnectionActionConfiguration> SaveBotMemory(Expression<Func<SaveBotMemoryContentInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<ResponseSaveBotMemory, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/saveBotMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<ResponseSaveBotMemory>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<ResponseDeleteBotMemory, ApiConnectionActionConfiguration> DeleteBotMemory(Expression<Func<DeleteBotMemoryContentInput>> content)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            return new DeferredBodyAction<ResponseDeleteBotMemory, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/deleteBotMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<ResponseDeleteBotMemory>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bizzy")]
        public IBodyWorkflowAction<MemoryItem[], ApiConnectionActionConfiguration> GetMemoryItemsByType(Expression<Func<CheckMemoryInfoInput>> checkMemoryInfo)
        {
            var __workflow_checkMemoryInfo = WorkflowExpression.Compile(checkMemoryInfo, nameof(checkMemoryInfo), required: true);
            return new DeferredBodyAction<MemoryItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/bot/CheckMemoryByType";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_checkMemoryInfo);
                return new ApiConnectionAction<MemoryItem[]>(callPayload);
            });
        }
    }

    public class BizzyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHook, ApiConnectionPollingTriggerConfiguration> WebHookRegistrationsPost(Expression<Func<WebHookRegistrationsPostWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WebHook, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionPollingTrigger<WebHook>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebHook, ApiConnectionPollingTriggerConfiguration> WebHookRegistrationsVectorPost(Expression<Func<WebHookRegistrationsVectorPostWebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WebHook, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionPollingTrigger<WebHook>(callPayload);
            });
        }
    }

    public class BotReplyResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }
    }

    public class SendReplyContentInput
    {
        public SendReplyContentInput(string replyText, string replyActivity)
        {
            this.ReplyText = replyText;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyText { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("customChannelDataJson")]
        public string CustomChannelData { get; set; }

        [JsonProperty("signalResponse")]
        public string SignalResponseJSON { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    public class CardSetInput
    {
        public CardSetInput(JToken adaptiveCardSet, string replyActivity)
        {
            this.AdaptiveCardSet = adaptiveCardSet;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("cards", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdaptiveCardSet { get; set; }

        [JsonProperty("displayStyle", DefaultValueHandling = DefaultValueHandling.Include)]
        public CardSetInputDisplayStyleType DisplayStyle { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.CardSetInputDisplayStyleType.Carousel;

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("showInTab", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInTab { get; set; } = false;

        [JsonProperty("deepLinkButtonLabel")]
        public string TabButtonLabel { get; set; }

        [JsonProperty("deepLinkMessage")]
        public string TabButtonMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CardSetInputDisplayStyleType
    {
        Carousel,
        List
    }

    public class CardInfoInput
    {
        public CardInfoInput(JToken adaptiveCard, string replyActivity)
        {
            this.AdaptiveCard = adaptiveCard;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("card", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdaptiveCard { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }
    }

    public class BotConversationStartResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("activityJson")]
        public string ReplyActivity { get; set; }
    }

    public class StartConversationContentInput
    {
        public StartConversationContentInput(string conversationText, string user)
        {
            this.ConversationText = conversationText;
            this.User = user;
        }

        [JsonProperty("EnterpriseBot", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetBot { get; set; } = "AtBot";

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationText { get; set; }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }
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

    public class StartGroupConversationContentInput
    {
        public StartGroupConversationContentInput(JToken channelListing, string channelName, string conversationText)
        {
            this.ChannelListing = channelListing;
            this.ChannelName = channelName;
            this.ConversationText = conversationText;
        }

        [JsonProperty("EnterpriseBot", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetBot { get; set; } = "AtBot";

        [JsonProperty("teamIDStr", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ChannelListing { get; set; }

        [JsonProperty("channelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationText { get; set; }
    }

    public class SendBridgeEventContentInput
    {
        public SendBridgeEventContentInput(string replyActivity, JToken eventJSON)
        {
            this.ReplyActivity = replyActivity;
            this.EventJSON = eventJSON;
        }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("eventObject", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken EventJSON { get; set; }
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

    public class WebHookRegistrationsInputResponseWebHookInput
    {
        public WebHookRegistrationsInputResponseWebHookInput(string message, string replyActivity)
        {
            this.Message = message;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    public class WebHookRegistrationsInputResponseDATEWebHookInput
    {
        public WebHookRegistrationsInputResponseDATEWebHookInput(string message, string replyActivity)
        {
            this.Message = message;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("dateScope", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputDateScopeType DateScope { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputDateScopeType.DateOnly;

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookInputDateScopeType
    {
        [EnumMember(Value = "Date Only")]
        DateOnly,
        [EnumMember(Value = "Time Only")]
        TimeOnly,
        [EnumMember(Value = "Date and Time")]
        DateAndTime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInputResponseCHOICEWebHookInput
    {
        public WebHookRegistrationsInputResponseCHOICEWebHookInput(string message, string choiceValues, string replyActivity)
        {
            this.Message = message;
            this.ChoiceValues = choiceValues;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("choices", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChoiceValues { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("listenForInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListenForVoiceResponse { get; set; } = false;
    }

    public class WebHookRegistrationsInputResponseCHOICELISTWebHookInput
    {
        public WebHookRegistrationsInputResponseCHOICELISTWebHookInput(string message, JToken choiceValues, string replyActivity)
        {
            this.Message = message;
            this.ChoiceValues = choiceValues;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("icon")]
        public string IconURL { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("choices", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ChoiceValues { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("listenForInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListenForVoiceResponse { get; set; } = false;
    }

    public class WebHookRegistrationsInputResponsePEOPLEWebHookInput
    {
        public WebHookRegistrationsInputResponsePEOPLEWebHookInput(string message, string replyActivity)
        {
            this.Message = message;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputModeType Mode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputModeType.Single;

        [JsonProperty("searchstr")]
        public string SearchString { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("listenForInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListenForVoiceResponse { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookInputModeType
    {
        Single,
        Multiple
    }

    public class WebHookRegistrationsInputResponseINTENTVECTORWebHookInput
    {
        public WebHookRegistrationsInputResponseINTENTVECTORWebHookInput(string message, string lUISIntentVector, string replyActivity)
        {
            this.Message = message;
            this.LUISIntentVector = lUISIntentVector;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("intentVector", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LUISIntentVector { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    public class WebHookRegistrationsInputResponseMEMORYWebHookInput
    {
        public WebHookRegistrationsInputResponseMEMORYWebHookInput(string message, string memoryType, string replyActivity)
        {
            this.Message = message;
            this.MemoryType = memoryType;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MemoryType { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("icon")]
        public string IconURL { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("targetUserMemory")]
        public string TargetUser { get; set; }

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    public class WebHookRegistrationsInitiateBridgeWebHookInput
    {
        public WebHookRegistrationsInitiateBridgeWebHookInput(WebHookInputParticipantsTypeItem[] participants)
        {
            this.Participants = participants;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("participants", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("endBridgeCommand", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndChatCommand { get; set; } = "#stop";

        [JsonProperty("idleTimeoutDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int IdleTimeout { get; set; } = 3;
    }

    public class WebHookInputParticipantsTypeItem
    {
        public WebHookInputParticipantsTypeItem(string userName, string replyActivity)
        {
            this.UserName = userName;
            this.ReplyActivity = replyActivity;
        }

        [JsonProperty("chatUserName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("chatInitiationMessage")]
        public string InitiationMessage { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }
    }

    public class ResponseSaveBotMemory
    {
        [JsonProperty("text")]
        public string BotMemorySaveResult { get; set; }
    }

    public class SaveBotMemoryContentInput
    {
        public SaveBotMemoryContentInput(string userPrincipalName, string memoryType, string title, string value)
        {
            this.UserPrincipalName = userPrincipalName;
            this.MemoryType = memoryType;
            this.Title = title;
            this.Value = value;
        }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MemoryType { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class ResponseDeleteBotMemory
    {
        [JsonProperty("text")]
        public string BotMemoryDeleteResult { get; set; }
    }

    public class DeleteBotMemoryContentInput
    {
        public DeleteBotMemoryContentInput(string userPrincipalName, string memoryType, string value)
        {
            this.UserPrincipalName = userPrincipalName;
            this.MemoryType = memoryType;
            this.Value = value;
        }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MemoryType { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class MemoryItem
    {
        [JsonProperty("title")]
        public string MemoryItemTitle { get; set; }

        [JsonProperty("value")]
        public string MemoryItemValue { get; set; }
    }

    public class CheckMemoryInfoInput
    {
        public CheckMemoryInfoInput(string userPrincipalName, string memoryType)
        {
            this.UserPrincipalName = userPrincipalName;
            this.MemoryType = memoryType;
        }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MemoryType { get; set; }
    }

    public class WebHookRegistrationsPostWebHookInput
    {
        public WebHookRegistrationsPostWebHookInput(string triggerDescription)
        {
            this.TriggerDescription = triggerDescription;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("triggerDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TriggerDescription { get; set; }

        [JsonProperty("triggerType", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputBotTriggerTypeType BotTriggerType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputBotTriggerTypeType.Shared;

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("luisApiKey")]
        public string DeprecatedLUISAPIKey { get; set; }

        [JsonProperty("luisAppId")]
        public string DeprecatedLUISApp { get; set; }

        [JsonProperty("luisIntent")]
        public string DeprecatedLUISIntent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookInputBotTriggerTypeType
    {
        Shared,
        Personal
    }

    public class WebHookRegistrationsVectorPostWebHookInput
    {
        public WebHookRegistrationsVectorPostWebHookInput(string triggerDescription)
        {
            this.TriggerDescription = triggerDescription;
        }

        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("triggerDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TriggerDescription { get; set; }

        [JsonProperty("triggerType", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputBotTriggerTypeType BotTriggerType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputBotTriggerTypeType.Shared;

        [JsonProperty("intentVector")]
        public string LUISIntentVector { get; set; }

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputAllowBranchingType? AllowBranching { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Bizzy.WebHookInputAllowBranchingType.No;
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
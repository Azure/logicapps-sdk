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
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> SendReply(Expression<Func<SendReplyInput>> content)
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
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> SendReplyWithAdaptiveCardSet(Expression<Func<SendReplyWithAdaptiveCardSetInput>> cardSet)
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
        public IBodyWorkflowAction<BotReplyResponse, ApiConnectionActionConfiguration> UpdateAdaptiveCard(Expression<Func<UpdateAdaptiveCardInput>> cardInfo)
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
        public IBodyWorkflowAction<BotConversationStartResponse, ApiConnectionActionConfiguration> StartConversation(Expression<Func<StartConversationInput>> content)
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
        public IBodyWorkflowAction<BotGroupConversationStartResponse, ApiConnectionActionConfiguration> StartGroupConversation(Expression<Func<StartGroupConversationInput>> content)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SendBridgeEvent(Expression<Func<SendBridgeEventInput>> content)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponse(Expression<Func<WebHookRegistrationsInputResponseInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseDATE(Expression<Func<WebHookRegistrationsInputResponseDATEInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseCHOICE(Expression<Func<WebHookRegistrationsInputResponseCHOICEInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseCHOICELIST(Expression<Func<WebHookRegistrationsInputResponseCHOICELISTInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponsePEOPLE(Expression<Func<WebHookRegistrationsInputResponsePEOPLEInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseINTENTVECTOR(Expression<Func<WebHookRegistrationsInputResponseINTENTVECTORInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInputResponseMEMORY(Expression<Func<WebHookRegistrationsInputResponseMEMORYInput>> webHook)
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
        public IBodyWorkflowAction<WebHook, ApiConnectionActionConfiguration> WebHookRegistrationsInitiateBridge(Expression<Func<WebHookRegistrationsInitiateBridgeInput>> webHook)
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
        public IBodyWorkflowAction<ResponseSaveBotMemory, ApiConnectionActionConfiguration> SaveBotMemory(Expression<Func<SaveBotMemoryInput>> content)
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
        public IBodyWorkflowAction<ResponseDeleteBotMemory, ApiConnectionActionConfiguration> DeleteBotMemory(Expression<Func<DeleteBotMemoryInput>> content)
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
        public IBodyWorkflowAction<MemoryItem[], ApiConnectionActionConfiguration> GetMemoryItemsByType(Expression<Func<GetMemoryItemsByTypeInput>> checkMemoryInfo)
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
        public IBodyWorkflowTrigger<WebHook, ApiConnectionTriggerConfiguration> WebHookRegistrationsPost(Expression<Func<WebHookRegistrationsPostInput>> webHook, FlowRecurrence recurrence = null)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WebHook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionTrigger<WebHook>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebHook, ApiConnectionTriggerConfiguration> WebHookRegistrationsVectorPost(Expression<Func<WebHookRegistrationsVectorPostInput>> webHook, FlowRecurrence recurrence = null)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WebHook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers/webhooks/registerVector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionTrigger<WebHook>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BotReplyResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }
    }

    public class SendReplyInput
    {
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

    public class SendReplyWithAdaptiveCardSetInput
    {
        [JsonProperty("cards", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdaptiveCardSet { get; set; }

        [JsonProperty("displayStyle", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendReplyWithAdaptiveCardSetInputDisplayStyleType DisplayStyle { get; set; } = SendReplyWithAdaptiveCardSetInputDisplayStyleType.Carousel;

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
    public enum SendReplyWithAdaptiveCardSetInputDisplayStyleType
    {
        Carousel,
        List
    }

    public class UpdateAdaptiveCardInput
    {
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

    public class StartConversationInput
    {
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

    public class StartGroupConversationInput
    {
        [JsonProperty("EnterpriseBot", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetBot { get; set; } = "AtBot";

        [JsonProperty("teamIDStr", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ChannelListing { get; set; }

        [JsonProperty("channelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationText { get; set; }
    }

    public class SendBridgeEventInput
    {
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

    public class WebHookRegistrationsInputResponseInput
    {
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
        public WebHookRegistrationsInputResponseInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponseInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    public class WebHookRegistrationsInputResponseDATEInput
    {
        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("dateScope", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseDATEInputDateScopeType DateScope { get; set; } = WebHookRegistrationsInputResponseDATEInputDateScopeType.DateOnly;

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseDATEInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponseDATEInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseDATEInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsInputResponseDATEInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseDATEInputDateScopeType
    {
        [EnumMember(Value = "Date Only")]
        DateOnly,
        [EnumMember(Value = "Time Only")]
        TimeOnly,
        [EnumMember(Value = "Date and Time")]
        DateAndTime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseDATEInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseDATEInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInputResponseCHOICEInput
    {
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
        public WebHookRegistrationsInputResponseCHOICEInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponseCHOICEInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseCHOICEInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsInputResponseCHOICEInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("listenForInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListenForVoiceResponse { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseCHOICEInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseCHOICEInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInputResponseCHOICELISTInput
    {
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
        public WebHookRegistrationsInputResponseCHOICELISTInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponseCHOICELISTInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseCHOICELISTInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsInputResponseCHOICELISTInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("listenForInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListenForVoiceResponse { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseCHOICELISTInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseCHOICELISTInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInputResponsePEOPLEInput
    {
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
        public WebHookRegistrationsInputResponsePEOPLEInputModeType Mode { get; set; } = WebHookRegistrationsInputResponsePEOPLEInputModeType.Single;

        [JsonProperty("searchstr")]
        public string SearchString { get; set; }

        [JsonProperty("activityJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplyActivity { get; set; }

        [JsonProperty("acceptResponseFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponsePEOPLEInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponsePEOPLEInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponsePEOPLEInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsInputResponsePEOPLEInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;

        [JsonProperty("listenForInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListenForVoiceResponse { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponsePEOPLEInputModeType
    {
        Single,
        Multiple
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponsePEOPLEInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponsePEOPLEInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInputResponseINTENTVECTORInput
    {
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
        public WebHookRegistrationsInputResponseINTENTVECTORInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponseINTENTVECTORInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseINTENTVECTORInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsInputResponseINTENTVECTORInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseINTENTVECTORInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseINTENTVECTORInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInputResponseMEMORYInput
    {
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
        public WebHookRegistrationsInputResponseMEMORYInputAcceptResponseFromType? AcceptResponseFrom { get; set; } = WebHookRegistrationsInputResponseMEMORYInputAcceptResponseFromType.OriginalUser;

        [JsonProperty("targetUserMemory")]
        public string TargetUser { get; set; }

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInputResponseMEMORYInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsInputResponseMEMORYInputAllowBranchingType.No;

        [JsonProperty("showInChat", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowInChat { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseMEMORYInputAcceptResponseFromType
    {
        [EnumMember(Value = "Original User")]
        OriginalUser,
        [EnumMember(Value = "Any User")]
        AnyUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsInputResponseMEMORYInputAllowBranchingType
    {
        No,
        Yes
    }

    public class WebHookRegistrationsInitiateBridgeInput
    {
        [JsonProperty("webHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public string[] Filters { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("participants", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsInitiateBridgeInputParticipantsTypeItem[] Participants { get; set; }

        [JsonProperty("endBridgeCommand", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndChatCommand { get; set; } = "#stop";

        [JsonProperty("idleTimeoutDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int IdleTimeout { get; set; } = 3;
    }

    public class WebHookRegistrationsInitiateBridgeInputParticipantsTypeItem
    {
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

    public class SaveBotMemoryInput
    {
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

    public class DeleteBotMemoryInput
    {
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

    public class GetMemoryItemsByTypeInput
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MemoryType { get; set; }
    }

    public class WebHookRegistrationsPostInput
    {
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
        public WebHookRegistrationsPostInputBotTriggerTypeType BotTriggerType { get; set; } = WebHookRegistrationsPostInputBotTriggerTypeType.Shared;

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
    public enum WebHookRegistrationsPostInputBotTriggerTypeType
    {
        Shared,
        Personal
    }

    public class WebHookRegistrationsVectorPostInput
    {
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
        public WebHookRegistrationsVectorPostInputBotTriggerTypeType BotTriggerType { get; set; } = WebHookRegistrationsVectorPostInputBotTriggerTypeType.Shared;

        [JsonProperty("intentVector")]
        public string LUISIntentVector { get; set; }

        [JsonProperty("allowBranching", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsVectorPostInputAllowBranchingType? AllowBranching { get; set; } = WebHookRegistrationsVectorPostInputAllowBranchingType.No;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsVectorPostInputBotTriggerTypeType
    {
        Shared,
        Personal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebHookRegistrationsVectorPostInputAllowBranchingType
    {
        No,
        Yes
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
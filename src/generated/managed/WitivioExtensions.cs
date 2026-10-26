//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Witivio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WitivioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendFeedback(Expression<Func<string>> botId, Expression<Func<SendFeedbackInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/feedback", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> botId, Expression<Func<SendMessageInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> StartEscalation(Expression<Func<string>> botId, Expression<Func<StartEscalationInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/startescalation", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendAdaptiveResponse, ApiConnectionActionConfiguration> SendAdaptive(Expression<Func<string>> botId, Expression<Func<SendAdaptiveInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendAdaptiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/adaptive", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendAdaptiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputResponse, ApiConnectionActionConfiguration> SendMessageInput(Expression<Func<string>> botId, Expression<Func<SendMessageInputInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageInputResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message/input", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageInputResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputListResponse, ApiConnectionActionConfiguration> SendMessageInputList(Expression<Func<string>> botId, Expression<Func<SendMessageInputListInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageInputListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message/input/list", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageInputListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputArrayResponse, ApiConnectionActionConfiguration> SendMessageInputArray(Expression<Func<string>> botId, Expression<Func<SendMessageInputArrayInput>> body)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageInputArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message/input/array", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageInputArrayResponse>(callPayload);
            });
        }
    }

    public class WitivioTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<string>> licenceId, Expression<Func<string>> botId, Expression<Func<string>> language, Expression<Func<string>> profileId, Expression<Func<string>> questionId, Expression<Func<WebhookTriggerInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_licenceId = WorkflowExpression.Compile(licenceId, nameof(licenceId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/conversations/{0}/{1}/questions/{2}/triggers/register", __workflow_botId.WithUrlEncoding(1), __workflow_language.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = ExpressionConverter.Convert(__workflow_licenceId);
                callPayload.Queries["profileId"] = ExpressionConverter.Convert(__workflow_profileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookEscalationTrigger(Expression<Func<string>> licenceId, Expression<Func<string>> botId, Expression<Func<string>> language, Expression<Func<string>> profileId, Expression<Func<string>> escalationId, Expression<Func<WebhookEscalationTriggerInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_licenceId = WorkflowExpression.Compile(licenceId, nameof(licenceId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_escalationId = WorkflowExpression.Compile(escalationId, nameof(escalationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/escalation/{0}/{1}/triggers/{2}/register", __workflow_botId.WithUrlEncoding(1), __workflow_language.WithUrlEncoding(1), __workflow_escalationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = ExpressionConverter.Convert(__workflow_licenceId);
                callPayload.Queries["profileId"] = ExpressionConverter.Convert(__workflow_profileId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendFeedbackInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("answer", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AnswerObject { get; set; }
    }

    public class SendMessageResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendMessageInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }

    public class StartEscalationInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("initialQuestion", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InitialQuestion { get; set; }

        [JsonProperty("userProfile", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken UserProfile { get; set; }

        [JsonProperty("escalationOptions")]
        public JToken EscalationOptions { get; set; }
    }

    public class SendAdaptiveResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendAdaptiveInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AdaptiveCardJson { get; set; }
    }

    public class SendMessageInputResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("files")]
        public JToken[] Files { get; set; }
    }

    public class SendMessageInputInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("isFileWaiting", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool FileWaiting { get; set; }
    }

    public class SendMessageInputListResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendMessageInputListInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("choice1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstChoice { get; set; }

        [JsonProperty("choice2", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecondChoice { get; set; }

        [JsonProperty("choice3")]
        public string ThirdChoice { get; set; }

        [JsonProperty("choice4")]
        public string FourthChoice { get; set; }

        [JsonProperty("choice5")]
        public string FifthChoice { get; set; }

        [JsonProperty("choice6")]
        public string SixthChoice { get; set; }

        [JsonProperty("choice7")]
        public string SeventhChoice { get; set; }

        [JsonProperty("choice8")]
        public string EigthChoice { get; set; }

        [JsonProperty("choice9")]
        public string NinethChoice { get; set; }

        [JsonProperty("choice10")]
        public string TenthChoice { get; set; }
    }

    public class SendMessageInputArrayResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("body")]
        public JToken Body { get; set; }
    }

    public class SendMessageInputArrayInput
    {
        [JsonProperty("conversationContext", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ConversationContext { get; set; }

        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("listChoice", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] ListOfChoices { get; set; }

        [JsonProperty("jsonPath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ValueToSelectInList { get; set; }
    }

    public class WebhookTriggerInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookEscalationTriggerInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Witivio;

    public partial class WorkflowManagedActions
    {
        public WitivioActions Witivio(string connectionId) => new WitivioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WitivioTriggers Witivio(string connectionId) => new WitivioTriggers(connectionId);
    }
}
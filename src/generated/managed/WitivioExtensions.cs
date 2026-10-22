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
        public IWorkflowAction<ApiConnectionActionConfiguration> SendFeedback(Expression<Func<string>> botId)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/feedback", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                var answerObject = new JObject();
                var answerObjectpropCount = 0;
                if (answerObjectpropCount > 0)
                {
                    body["answer"] = answerObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> botId, Expression<Func<string>> bodymessage)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> StartEscalation(Expression<Func<string>> botId, Expression<Func<string>> bodyinitialQuestion)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodyinitialQuestion = WorkflowExpression.Compile(bodyinitialQuestion, nameof(bodyinitialQuestion), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/startescalation", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["initialQuestion"] = ExpressionConverter.ConvertO(__workflow_bodyinitialQuestion);
                var userProfileObject = new JObject();
                var userProfileObjectpropCount = 0;
                if (userProfileObjectpropCount > 0)
                {
                    body["userProfile"] = userProfileObject;
                    bodypropCount++;
                }

                var escalationOptionsObject = new JObject();
                var escalationOptionsObjectpropCount = 0;
                if (escalationOptionsObjectpropCount > 0)
                {
                    body["escalationOptions"] = escalationOptionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendAdaptiveResponse, ApiConnectionActionConfiguration> SendAdaptive(Expression<Func<string>> botId, Expression<Func<string>> bodyadaptiveCardJson)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodyadaptiveCardJson = WorkflowExpression.Compile(bodyadaptiveCardJson, nameof(bodyadaptiveCardJson), required: true);
            return new DeferredBodyAction<SendAdaptiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/adaptive", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodyadaptiveCardJson);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendAdaptiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputResponse, ApiConnectionActionConfiguration> SendMessageInput(Expression<Func<string>> botId, Expression<Func<string>> bodyquestion, Expression<Func<bool>> bodyfileWaiting)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodyquestion = WorkflowExpression.Compile(bodyquestion, nameof(bodyquestion), required: true);
            var __workflow_bodyfileWaiting = WorkflowExpression.Compile(bodyfileWaiting, nameof(bodyfileWaiting), required: true);
            return new DeferredBodyAction<SendMessageInputResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message/input", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(__workflow_bodyquestion);
                bodypropCount++;
                body["isFileWaiting"] = ExpressionConverter.ConvertO(__workflow_bodyfileWaiting);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageInputResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputListResponse, ApiConnectionActionConfiguration> SendMessageInputList(Expression<Func<string>> botId, Expression<Func<string>> bodyquestion, Expression<Func<string>> bodyfirstChoice, Expression<Func<string>> bodysecondChoice, Expression<Func<string>> bodythirdChoice = null, Expression<Func<string>> bodyfourthChoice = null, Expression<Func<string>> bodyfifthChoice = null, Expression<Func<string>> bodysixthChoice = null, Expression<Func<string>> bodyseventhChoice = null, Expression<Func<string>> bodyeigthChoice = null, Expression<Func<string>> bodyninethChoice = null, Expression<Func<string>> bodytenthChoice = null)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodyquestion = WorkflowExpression.Compile(bodyquestion, nameof(bodyquestion), required: true);
            var __workflow_bodyfirstChoice = WorkflowExpression.Compile(bodyfirstChoice, nameof(bodyfirstChoice), required: true);
            var __workflow_bodysecondChoice = WorkflowExpression.Compile(bodysecondChoice, nameof(bodysecondChoice), required: true);
            var __workflow_bodythirdChoice = WorkflowExpression.Compile(bodythirdChoice, nameof(bodythirdChoice), required: false);
            var __workflow_bodyfourthChoice = WorkflowExpression.Compile(bodyfourthChoice, nameof(bodyfourthChoice), required: false);
            var __workflow_bodyfifthChoice = WorkflowExpression.Compile(bodyfifthChoice, nameof(bodyfifthChoice), required: false);
            var __workflow_bodysixthChoice = WorkflowExpression.Compile(bodysixthChoice, nameof(bodysixthChoice), required: false);
            var __workflow_bodyseventhChoice = WorkflowExpression.Compile(bodyseventhChoice, nameof(bodyseventhChoice), required: false);
            var __workflow_bodyeigthChoice = WorkflowExpression.Compile(bodyeigthChoice, nameof(bodyeigthChoice), required: false);
            var __workflow_bodyninethChoice = WorkflowExpression.Compile(bodyninethChoice, nameof(bodyninethChoice), required: false);
            var __workflow_bodytenthChoice = WorkflowExpression.Compile(bodytenthChoice, nameof(bodytenthChoice), required: false);
            return new DeferredBodyAction<SendMessageInputListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message/input/list", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(__workflow_bodyquestion);
                bodypropCount++;
                body["choice1"] = ExpressionConverter.ConvertO(__workflow_bodyfirstChoice);
                bodypropCount++;
                body["choice2"] = ExpressionConverter.ConvertO(__workflow_bodysecondChoice);
                if (__workflow_bodythirdChoice != null)
                {
                    body["choice3"] = ExpressionConverter.ConvertO(__workflow_bodythirdChoice);
                    bodypropCount++;
                }

                if (__workflow_bodyfourthChoice != null)
                {
                    body["choice4"] = ExpressionConverter.ConvertO(__workflow_bodyfourthChoice);
                    bodypropCount++;
                }

                if (__workflow_bodyfifthChoice != null)
                {
                    body["choice5"] = ExpressionConverter.ConvertO(__workflow_bodyfifthChoice);
                    bodypropCount++;
                }

                if (__workflow_bodysixthChoice != null)
                {
                    body["choice6"] = ExpressionConverter.ConvertO(__workflow_bodysixthChoice);
                    bodypropCount++;
                }

                if (__workflow_bodyseventhChoice != null)
                {
                    body["choice7"] = ExpressionConverter.ConvertO(__workflow_bodyseventhChoice);
                    bodypropCount++;
                }

                if (__workflow_bodyeigthChoice != null)
                {
                    body["choice8"] = ExpressionConverter.ConvertO(__workflow_bodyeigthChoice);
                    bodypropCount++;
                }

                if (__workflow_bodyninethChoice != null)
                {
                    body["choice9"] = ExpressionConverter.ConvertO(__workflow_bodyninethChoice);
                    bodypropCount++;
                }

                if (__workflow_bodytenthChoice != null)
                {
                    body["choice10"] = ExpressionConverter.ConvertO(__workflow_bodytenthChoice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageInputListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputArrayResponse, ApiConnectionActionConfiguration> SendMessageInputArray(Expression<Func<string>> botId, Expression<Func<string>> bodyquestion, Expression<Func<JToken[]>> bodylistOfChoices, Expression<Func<string>> bodyvalueToSelectInList)
        {
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodyquestion = WorkflowExpression.Compile(bodyquestion, nameof(bodyquestion), required: true);
            var __workflow_bodylistOfChoices = WorkflowExpression.Compile(bodylistOfChoices, nameof(bodylistOfChoices), required: true);
            var __workflow_bodyvalueToSelectInList = WorkflowExpression.Compile(bodyvalueToSelectInList, nameof(bodyvalueToSelectInList), required: true);
            return new DeferredBodyAction<SendMessageInputArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/botproxy/{0}/message/input/array", __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var conversationContextObject = new JObject();
                var conversationContextObjectpropCount = 0;
                if (conversationContextObjectpropCount > 0)
                {
                    body["conversationContext"] = conversationContextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(__workflow_bodyquestion);
                bodypropCount++;
                body["listChoice"] = ExpressionConverter.ConvertO(__workflow_bodylistOfChoices);
                bodypropCount++;
                body["jsonPath"] = ExpressionConverter.ConvertO(__workflow_bodyvalueToSelectInList);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageInputArrayResponse>(callPayload);
            });
        }
    }

    public class WitivioTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<string>> licenceId, Expression<Func<string>> botId, Expression<Func<string>> language, Expression<Func<string>> profileId, Expression<Func<string>> questionId, FlowRecurrence recurrence = null)
        {
            var __workflow_licenceId = WorkflowExpression.Compile(licenceId, nameof(licenceId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_questionId = WorkflowExpression.Compile(questionId, nameof(questionId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/conversations/{0}/{1}/questions/{2}/triggers/register", __workflow_botId.WithUrlEncoding(1), __workflow_language.WithUrlEncoding(1), __workflow_questionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = ExpressionConverter.Convert(__workflow_licenceId);
                callPayload.Queries["profileId"] = ExpressionConverter.Convert(__workflow_profileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookEscalationTrigger(Expression<Func<string>> licenceId, Expression<Func<string>> botId, Expression<Func<string>> language, Expression<Func<string>> profileId, Expression<Func<string>> escalationId, FlowRecurrence recurrence = null)
        {
            var __workflow_licenceId = WorkflowExpression.Compile(licenceId, nameof(licenceId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_escalationId = WorkflowExpression.Compile(escalationId, nameof(escalationId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/escalation/{0}/{1}/triggers/{2}/register", __workflow_botId.WithUrlEncoding(1), __workflow_language.WithUrlEncoding(1), __workflow_escalationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = ExpressionConverter.Convert(__workflow_licenceId);
                callPayload.Queries["profileId"] = ExpressionConverter.Convert(__workflow_profileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendMessageResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendAdaptiveResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendMessageInputResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("files")]
        public JToken[] Files { get; set; }
    }

    public class SendMessageInputListResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendMessageInputArrayResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("body")]
        public JToken Body { get; set; }
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

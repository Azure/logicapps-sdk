//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Witivio
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WitivioActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [WorkflowExpressionFactory(nameof(__BuildSendFeedback))]
        public IWorkflowAction SendFeedback([WorkflowExpression] Func<string> botId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendFeedback(WorkflowExpression<string> botId)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/feedback", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodymessage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowExpression<string> botId, WorkflowExpression<string> bodymessage)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [WorkflowExpressionFactory(nameof(__BuildStartEscalation))]
        public IBodyWorkflowAction<JToken> StartEscalation([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyinitialQuestion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildStartEscalation(WorkflowExpression<string> botId, WorkflowExpression<string> bodyinitialQuestion)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodyinitialQuestion, nameof(bodyinitialQuestion), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/startescalation", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
                body["initialQuestion"] = ExpressionConverter.ConvertO(bodyinitialQuestion);
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
        [WorkflowExpressionFactory(nameof(__BuildSendAdaptive))]
        public IBodyWorkflowAction<SendAdaptiveResponse> SendAdaptive([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyadaptiveCardJson)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendAdaptiveResponse> __BuildSendAdaptive(WorkflowExpression<string> botId, WorkflowExpression<string> bodyadaptiveCardJson)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodyadaptiveCardJson, nameof(bodyadaptiveCardJson), required: true);
            return new DeferredBodyAction<SendAdaptiveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/adaptive", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
                body["message"] = ExpressionConverter.ConvertO(bodyadaptiveCardJson);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendAdaptiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageInput))]
        public IBodyWorkflowAction<SendMessageInputResponse> SendMessageInput([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<bool> bodyfileWaiting)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageInputResponse> __BuildSendMessageInput(WorkflowExpression<string> botId, WorkflowExpression<string> bodyquestion, WorkflowExpression<bool> bodyfileWaiting)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            WorkflowExpression.Validate(bodyfileWaiting, nameof(bodyfileWaiting), required: true);
            return new DeferredBodyAction<SendMessageInputResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message/input", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
                body["question"] = ExpressionConverter.ConvertO(bodyquestion);
                bodypropCount++;
                body["isFileWaiting"] = ExpressionConverter.ConvertO(bodyfileWaiting);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageInputResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageInputList))]
        public IBodyWorkflowAction<SendMessageInputListResponse> SendMessageInputList([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<string> bodyfirstChoice, [WorkflowExpression] Func<string> bodysecondChoice, [WorkflowExpression] Func<string> bodythirdChoice = null, [WorkflowExpression] Func<string> bodyfourthChoice = null, [WorkflowExpression] Func<string> bodyfifthChoice = null, [WorkflowExpression] Func<string> bodysixthChoice = null, [WorkflowExpression] Func<string> bodyseventhChoice = null, [WorkflowExpression] Func<string> bodyeigthChoice = null, [WorkflowExpression] Func<string> bodyninethChoice = null, [WorkflowExpression] Func<string> bodytenthChoice = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageInputListResponse> __BuildSendMessageInputList(WorkflowExpression<string> botId, WorkflowExpression<string> bodyquestion, WorkflowExpression<string> bodyfirstChoice, WorkflowExpression<string> bodysecondChoice, WorkflowExpression<string> bodythirdChoice = null, WorkflowExpression<string> bodyfourthChoice = null, WorkflowExpression<string> bodyfifthChoice = null, WorkflowExpression<string> bodysixthChoice = null, WorkflowExpression<string> bodyseventhChoice = null, WorkflowExpression<string> bodyeigthChoice = null, WorkflowExpression<string> bodyninethChoice = null, WorkflowExpression<string> bodytenthChoice = null)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            WorkflowExpression.Validate(bodyfirstChoice, nameof(bodyfirstChoice), required: true);
            WorkflowExpression.Validate(bodysecondChoice, nameof(bodysecondChoice), required: true);
            WorkflowExpression.Validate(bodythirdChoice, nameof(bodythirdChoice), required: false);
            WorkflowExpression.Validate(bodyfourthChoice, nameof(bodyfourthChoice), required: false);
            WorkflowExpression.Validate(bodyfifthChoice, nameof(bodyfifthChoice), required: false);
            WorkflowExpression.Validate(bodysixthChoice, nameof(bodysixthChoice), required: false);
            WorkflowExpression.Validate(bodyseventhChoice, nameof(bodyseventhChoice), required: false);
            WorkflowExpression.Validate(bodyeigthChoice, nameof(bodyeigthChoice), required: false);
            WorkflowExpression.Validate(bodyninethChoice, nameof(bodyninethChoice), required: false);
            WorkflowExpression.Validate(bodytenthChoice, nameof(bodytenthChoice), required: false);
            return new DeferredBodyAction<SendMessageInputListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message/input/list", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
                body["question"] = ExpressionConverter.ConvertO(bodyquestion);
                bodypropCount++;
                body["choice1"] = ExpressionConverter.ConvertO(bodyfirstChoice);
                bodypropCount++;
                body["choice2"] = ExpressionConverter.ConvertO(bodysecondChoice);
                if (bodythirdChoice != null)
                {
                    body["choice3"] = ExpressionConverter.ConvertO(bodythirdChoice);
                    bodypropCount++;
                }

                if (bodyfourthChoice != null)
                {
                    body["choice4"] = ExpressionConverter.ConvertO(bodyfourthChoice);
                    bodypropCount++;
                }

                if (bodyfifthChoice != null)
                {
                    body["choice5"] = ExpressionConverter.ConvertO(bodyfifthChoice);
                    bodypropCount++;
                }

                if (bodysixthChoice != null)
                {
                    body["choice6"] = ExpressionConverter.ConvertO(bodysixthChoice);
                    bodypropCount++;
                }

                if (bodyseventhChoice != null)
                {
                    body["choice7"] = ExpressionConverter.ConvertO(bodyseventhChoice);
                    bodypropCount++;
                }

                if (bodyeigthChoice != null)
                {
                    body["choice8"] = ExpressionConverter.ConvertO(bodyeigthChoice);
                    bodypropCount++;
                }

                if (bodyninethChoice != null)
                {
                    body["choice9"] = ExpressionConverter.ConvertO(bodyninethChoice);
                    bodypropCount++;
                }

                if (bodytenthChoice != null)
                {
                    body["choice10"] = ExpressionConverter.ConvertO(bodytenthChoice);
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
        [WorkflowExpressionFactory(nameof(__BuildSendMessageInputArray))]
        public IBodyWorkflowAction<SendMessageInputArrayResponse> SendMessageInputArray([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<JToken[]> bodylistOfChoices, [WorkflowExpression] Func<string> bodyvalueToSelectInList)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageInputArrayResponse> __BuildSendMessageInputArray(WorkflowExpression<string> botId, WorkflowExpression<string> bodyquestion, WorkflowExpression<JToken[]> bodylistOfChoices, WorkflowExpression<string> bodyvalueToSelectInList)
        {
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            WorkflowExpression.Validate(bodylistOfChoices, nameof(bodylistOfChoices), required: true);
            WorkflowExpression.Validate(bodyvalueToSelectInList, nameof(bodyvalueToSelectInList), required: true);
            return new DeferredBodyAction<SendMessageInputArrayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message/input/array", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
                body["question"] = ExpressionConverter.ConvertO(bodyquestion);
                bodypropCount++;
                body["listChoice"] = ExpressionConverter.ConvertO(bodylistOfChoices);
                bodypropCount++;
                body["jsonPath"] = ExpressionConverter.ConvertO(bodyvalueToSelectInList);
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

        [WorkflowExpressionFactory(nameof(__BuildWebhookTrigger))]
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> licenceId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> questionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookTrigger(WorkflowExpression<string> licenceId, WorkflowExpression<string> botId, WorkflowExpression<string> language, WorkflowExpression<string> profileId, WorkflowExpression<string> questionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(licenceId, nameof(licenceId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: true);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: true);
            WorkflowExpression.Validate(questionId, nameof(questionId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/conversations/{0}/{1}/questions/{2}/triggers/register", ExpressionConverter.ConvertWithUrlEncoding(botId, 1), ExpressionConverter.ConvertWithUrlEncoding(language, 1), ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = ExpressionConverter.Convert(licenceId);
                callPayload.Queries["profileId"] = ExpressionConverter.Convert(profileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookEscalationTrigger))]
        public IWorkflowTrigger WebhookEscalationTrigger([WorkflowExpression] Func<string> licenceId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> escalationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookEscalationTrigger(WorkflowExpression<string> licenceId, WorkflowExpression<string> botId, WorkflowExpression<string> language, WorkflowExpression<string> profileId, WorkflowExpression<string> escalationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(licenceId, nameof(licenceId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: true);
            WorkflowExpression.Validate(profileId, nameof(profileId), required: true);
            WorkflowExpression.Validate(escalationId, nameof(escalationId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/escalation/{0}/{1}/triggers/{2}/register", ExpressionConverter.ConvertWithUrlEncoding(botId, 1), ExpressionConverter.ConvertWithUrlEncoding(language, 1), ExpressionConverter.ConvertWithUrlEncoding(escalationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = ExpressionConverter.Convert(licenceId);
                callPayload.Queries["profileId"] = ExpressionConverter.Convert(profileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
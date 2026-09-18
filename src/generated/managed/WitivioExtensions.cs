//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Witivio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WitivioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IWorkflowAction SendFeedback([WorkflowExpression] Func<string> botId)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/feedback", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodymessage)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<JToken> StartEscalation([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyinitialQuestion)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(bodyinitialQuestion, nameof(bodyinitialQuestion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/startescalation", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                body["initialQuestion"] = SourceExpressionConverter.ConvertToken(bodyinitialQuestion);
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
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendAdaptiveResponse> SendAdaptive([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyadaptiveCardJson)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(bodyadaptiveCardJson, nameof(bodyadaptiveCardJson), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/adaptive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                body["message"] = SourceExpressionConverter.ConvertToken(bodyadaptiveCardJson);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendAdaptiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputResponse> SendMessageInput([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<bool> bodyfileWaiting)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            SourceExpression.Validate(bodyfileWaiting, nameof(bodyfileWaiting), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message/input", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                bodypropCount++;
                body["isFileWaiting"] = SourceExpressionConverter.ConvertToken(bodyfileWaiting);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageInputResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputListResponse> SendMessageInputList([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<string> bodyfirstChoice, [WorkflowExpression] Func<string> bodysecondChoice, [WorkflowExpression] Func<string> bodythirdChoice = null, [WorkflowExpression] Func<string> bodyfourthChoice = null, [WorkflowExpression] Func<string> bodyfifthChoice = null, [WorkflowExpression] Func<string> bodysixthChoice = null, [WorkflowExpression] Func<string> bodyseventhChoice = null, [WorkflowExpression] Func<string> bodyeigthChoice = null, [WorkflowExpression] Func<string> bodyninethChoice = null, [WorkflowExpression] Func<string> bodytenthChoice = null)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            SourceExpression.Validate(bodyfirstChoice, nameof(bodyfirstChoice), required: true);
            SourceExpression.Validate(bodysecondChoice, nameof(bodysecondChoice), required: true);
            SourceExpression.Validate(bodythirdChoice, nameof(bodythirdChoice), required: false);
            SourceExpression.Validate(bodyfourthChoice, nameof(bodyfourthChoice), required: false);
            SourceExpression.Validate(bodyfifthChoice, nameof(bodyfifthChoice), required: false);
            SourceExpression.Validate(bodysixthChoice, nameof(bodysixthChoice), required: false);
            SourceExpression.Validate(bodyseventhChoice, nameof(bodyseventhChoice), required: false);
            SourceExpression.Validate(bodyeigthChoice, nameof(bodyeigthChoice), required: false);
            SourceExpression.Validate(bodyninethChoice, nameof(bodyninethChoice), required: false);
            SourceExpression.Validate(bodytenthChoice, nameof(bodytenthChoice), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message/input/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                bodypropCount++;
                body["choice1"] = SourceExpressionConverter.ConvertToken(bodyfirstChoice);
                bodypropCount++;
                body["choice2"] = SourceExpressionConverter.ConvertToken(bodysecondChoice);
                if (bodythirdChoice != null)
                {
                    body["choice3"] = SourceExpressionConverter.ConvertToken(bodythirdChoice);
                    bodypropCount++;
                }

                if (bodyfourthChoice != null)
                {
                    body["choice4"] = SourceExpressionConverter.ConvertToken(bodyfourthChoice);
                    bodypropCount++;
                }

                if (bodyfifthChoice != null)
                {
                    body["choice5"] = SourceExpressionConverter.ConvertToken(bodyfifthChoice);
                    bodypropCount++;
                }

                if (bodysixthChoice != null)
                {
                    body["choice6"] = SourceExpressionConverter.ConvertToken(bodysixthChoice);
                    bodypropCount++;
                }

                if (bodyseventhChoice != null)
                {
                    body["choice7"] = SourceExpressionConverter.ConvertToken(bodyseventhChoice);
                    bodypropCount++;
                }

                if (bodyeigthChoice != null)
                {
                    body["choice8"] = SourceExpressionConverter.ConvertToken(bodyeigthChoice);
                    bodypropCount++;
                }

                if (bodyninethChoice != null)
                {
                    body["choice9"] = SourceExpressionConverter.ConvertToken(bodyninethChoice);
                    bodypropCount++;
                }

                if (bodytenthChoice != null)
                {
                    body["choice10"] = SourceExpressionConverter.ConvertToken(bodytenthChoice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageInputListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputArrayResponse> SendMessageInputArray([WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<JToken[]> bodylistOfChoices, [WorkflowExpression] Func<string> bodyvalueToSelectInList)
        {
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(bodyquestion, nameof(bodyquestion), required: true);
            SourceExpression.Validate(bodylistOfChoices, nameof(bodylistOfChoices), required: true);
            SourceExpression.Validate(bodyvalueToSelectInList, nameof(bodyvalueToSelectInList), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/botproxy/{0}/message/input/array", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
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
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                bodypropCount++;
                body["listChoice"] = SourceExpressionConverter.ConvertToken(bodylistOfChoices);
                bodypropCount++;
                body["jsonPath"] = SourceExpressionConverter.ConvertToken(bodyvalueToSelectInList);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageInputArrayResponse>(BuildSourceInput);
        }
    }

    public class WitivioTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> licenceId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> questionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(licenceId, nameof(licenceId), required: true);
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(language, nameof(language), required: true);
            SourceExpression.Validate(profileId, nameof(profileId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/conversations/{0}/{1}/questions/{2}/triggers/register", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(language, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = SourceExpressionConverter.ConvertO(licenceId);
                callPayload.Queries["profileId"] = SourceExpressionConverter.ConvertO(profileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookEscalationTrigger([WorkflowExpression] Func<string> licenceId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> escalationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(licenceId, nameof(licenceId), required: true);
            SourceExpression.Validate(botId, nameof(botId), required: true);
            SourceExpression.Validate(language, nameof(language), required: true);
            SourceExpression.Validate(profileId, nameof(profileId), required: true);
            SourceExpression.Validate(escalationId, nameof(escalationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/escalation/{0}/{1}/triggers/{2}/register", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(language, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(escalationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["licenceId"] = SourceExpressionConverter.ConvertO(licenceId);
                callPayload.Queries["profileId"] = SourceExpressionConverter.ConvertO(profileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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
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
        public IWorkflowAction SendFeedback(Expression<Func<string>> botId)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/feedback", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> botId, Expression<Func<string>> bodymessage)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/message", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<JToken> StartEscalation(Expression<Func<string>> botId, Expression<Func<string>> bodyinitialQuestion)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/startescalation", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendAdaptiveResponse> SendAdaptive(Expression<Func<string>> botId, Expression<Func<string>> bodyadaptiveCardJson)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/adaptive", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputResponse> SendMessageInput(Expression<Func<string>> botId, Expression<Func<string>> bodyquestion, Expression<Func<bool>> bodyfileWaiting)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/message/input", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputListResponse> SendMessageInputList(Expression<Func<string>> botId, Expression<Func<string>> bodyquestion, Expression<Func<string>> bodyfirstChoice, Expression<Func<string>> bodysecondChoice, Expression<Func<string>> bodythirdChoice = null, Expression<Func<string>> bodyfourthChoice = null, Expression<Func<string>> bodyfifthChoice = null, Expression<Func<string>> bodysixthChoice = null, Expression<Func<string>> bodyseventhChoice = null, Expression<Func<string>> bodyeigthChoice = null, Expression<Func<string>> bodyninethChoice = null, Expression<Func<string>> bodytenthChoice = null)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/message/input/list", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "witivio")]
        public IBodyWorkflowAction<SendMessageInputArrayResponse> SendMessageInputArray(Expression<Func<string>> botId, Expression<Func<string>> bodyquestion, Expression<Func<JToken[]>> bodylistOfChoices, Expression<Func<string>> bodyvalueToSelectInList)
        {
            var apiCallPath = String.Format("/api/botproxy/{0}/message/input/array", ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }
    }

    public class WitivioTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger(Expression<Func<string>> licenceId, Expression<Func<string>> botId, Expression<Func<string>> language, Expression<Func<string>> profileId, Expression<Func<string>> questionId, string triggerName = null)
        {
            var apiCallPath = String.Format("/api/conversations/{0}/{1}/questions/{2}/triggers/register", ExpressionConverter.ConvertWithUrlEncoding(botId, 1), ExpressionConverter.ConvertWithUrlEncoding(language, 1), ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["licenceId"] = ExpressionConverter.Convert(licenceId);
            callPayload.Queries["profileId"] = ExpressionConverter.Convert(profileId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger WebhookEscalationTrigger(Expression<Func<string>> licenceId, Expression<Func<string>> botId, Expression<Func<string>> language, Expression<Func<string>> profileId, Expression<Func<string>> escalationId, string triggerName = null)
        {
            var apiCallPath = String.Format("/api/escalation/{0}/{1}/triggers/{2}/register", ExpressionConverter.ConvertWithUrlEncoding(botId, 1), ExpressionConverter.ConvertWithUrlEncoding(language, 1), ExpressionConverter.ConvertWithUrlEncoding(escalationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["licenceId"] = ExpressionConverter.Convert(licenceId);
            callPayload.Queries["profileId"] = ExpressionConverter.Convert(profileId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglepalmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> ListModels([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> pageToken = null)
        {
            var apiCallPath = String.Format("/{0}/models", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (pageToken != null)
                callPayload.Queries["pageToken"] = ExpressionConverter.Convert(pageToken);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GetModel([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> name)
        {
            var apiCallPath = String.Format("/{0}/models/{1}", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateText([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> modelType, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<string> bodypromptprompt, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodycandidateCount = null, [WorkflowExpression] Func<int> bodymaxOutputTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<JToken[]> bodysafetySettings = null, [WorkflowExpression] Func<string[]> bodystopSequences = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}:generateText", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelType, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            promptObjectpropCount++;
            promptObject["text"] = ExpressionConverter.ConvertO(bodypromptprompt);
            if (promptObjectpropCount > 0)
            {
                body["prompt"] = promptObject;
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                bodypropCount++;
            }

            if (bodycandidateCount != null)
            {
                body["candidateCount"] = ExpressionConverter.ConvertO(bodycandidateCount);
                bodypropCount++;
            }

            if (bodymaxOutputTokens != null)
            {
                body["maxOutputTokens"] = ExpressionConverter.ConvertO(bodymaxOutputTokens);
                bodypropCount++;
            }

            if (bodytopP != null)
            {
                body["topP"] = ExpressionConverter.ConvertO(bodytopP);
                bodypropCount++;
            }

            if (bodytopK != null)
            {
                body["topK"] = ExpressionConverter.ConvertO(bodytopK);
                bodypropCount++;
            }

            if (bodysafetySettings != null)
            {
                body["safetySettings"] = ExpressionConverter.ConvertO(bodysafetySettings);
                bodypropCount++;
            }

            if (bodystopSequences != null)
            {
                body["stopSequences"] = ExpressionConverter.ConvertO(bodystopSequences);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateMessage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<bodypromptmessagesInputItem[]> bodypromptmessages = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodytopK = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:generateMessage", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            if (bodypromptmessages != null)
            {
                promptObject["messages"] = ExpressionConverter.ConvertO(bodypromptmessages);
                promptObjectpropCount++;
            }

            if (promptObjectpropCount > 0)
            {
                body["prompt"] = promptObject;
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                bodypropCount++;
            }

            if (bodytopP != null)
            {
                body["topP"] = ExpressionConverter.ConvertO(bodytopP);
                bodypropCount++;
            }

            if (bodytopK != null)
            {
                body["topK"] = ExpressionConverter.ConvertO(bodytopK);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountTextTokens([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<string> bodyprompttext = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:countTextTokens", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            if (bodyprompttext != null)
            {
                promptObject["text"] = ExpressionConverter.ConvertO(bodyprompttext);
                promptObjectpropCount++;
            }

            if (promptObjectpropCount > 0)
            {
                body["prompt"] = promptObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountMessageTokens([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<bodypromptmessagesInputItem[]> bodypromptmessages = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:countMessageTokens", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            if (bodypromptmessages != null)
            {
                promptObject["messages"] = ExpressionConverter.ConvertO(bodypromptmessages);
                promptObjectpropCount++;
            }

            if (promptObjectpropCount > 0)
            {
                body["prompt"] = promptObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<EmbedTextResponse> EmbedText([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<string> bodytext)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:embedText", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmbedTextResponse>(callPayload);
        }
    }

    public class GooglepalmTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodypromptmessagesInputItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class EmbedTextResponse
    {
        [JsonProperty("embedding")]
        public EmbedTextResponseEmbeddingType Embedding { get; set; }
    }

    public class EmbedTextResponseEmbeddingType
    {
        [JsonProperty("value")]
        public double[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm;

    public partial class WorkflowManagedActions
    {
        public GooglepalmActions Googlepalm(string connectionId) => new GooglepalmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglepalmTriggers Googlepalm(string connectionId) => new GooglepalmTriggers(connectionId);
    }
}
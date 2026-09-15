//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglepalmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> ListModels(Expression<Func<string>> aPIVersion, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageToken = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/models", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (pageToken != null)
                callPayload.Queries["pageToken"] = CSharpExpressionConverter.ConvertO(pageToken);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GetModel(Expression<Func<string>> aPIVersion, Expression<Func<string>> name)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateText(Expression<Func<string>> aPIVersion, Expression<Func<string>> modelType, Expression<Func<string>> modelName, Expression<Func<string>> bodypromptprompt, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodycandidateCount = null, Expression<Func<int>> bodymaxOutputTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null, Expression<Func<JToken[]>> bodysafetySettings = null, Expression<Func<string[]>> bodystopSequences = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}:generateText", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            promptObjectpropCount++;
            promptObject["text"] = CSharpExpressionConverter.ConvertToken(bodypromptprompt);
            if (promptObjectpropCount > 0)
            {
                body["prompt"] = promptObject;
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = CSharpExpressionConverter.ConvertToken(bodytemperature);
                bodypropCount++;
            }

            if (bodycandidateCount != null)
            {
                body["candidateCount"] = CSharpExpressionConverter.ConvertToken(bodycandidateCount);
                bodypropCount++;
            }

            if (bodymaxOutputTokens != null)
            {
                body["maxOutputTokens"] = CSharpExpressionConverter.ConvertToken(bodymaxOutputTokens);
                bodypropCount++;
            }

            if (bodytopP != null)
            {
                body["topP"] = CSharpExpressionConverter.ConvertToken(bodytopP);
                bodypropCount++;
            }

            if (bodytopK != null)
            {
                body["topK"] = CSharpExpressionConverter.ConvertToken(bodytopK);
                bodypropCount++;
            }

            if (bodysafetySettings != null)
            {
                body["safetySettings"] = CSharpExpressionConverter.ConvertToken(bodysafetySettings);
                bodypropCount++;
            }

            if (bodystopSequences != null)
            {
                body["stopSequences"] = CSharpExpressionConverter.ConvertToken(bodystopSequences);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateMessage(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<bodypromptmessagesInputItem[]>> bodypromptmessages = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:generateMessage", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            if (bodypromptmessages != null)
            {
                promptObject["messages"] = CSharpExpressionConverter.ConvertToken(bodypromptmessages);
                promptObjectpropCount++;
            }

            if (promptObjectpropCount > 0)
            {
                body["prompt"] = promptObject;
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = CSharpExpressionConverter.ConvertToken(bodytemperature);
                bodypropCount++;
            }

            if (bodytopP != null)
            {
                body["topP"] = CSharpExpressionConverter.ConvertToken(bodytopP);
                bodypropCount++;
            }

            if (bodytopK != null)
            {
                body["topK"] = CSharpExpressionConverter.ConvertToken(bodytopK);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountTextTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodyprompttext = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countTextTokens", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            if (bodyprompttext != null)
            {
                promptObject["text"] = CSharpExpressionConverter.ConvertToken(bodyprompttext);
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
        public IBodyWorkflowAction<JToken> CountMessageTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<bodypromptmessagesInputItem[]>> bodypromptmessages = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countMessageTokens", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var promptObject = new JObject();
            var promptObjectpropCount = 0;
            if (bodypromptmessages != null)
            {
                promptObject["messages"] = CSharpExpressionConverter.ConvertToken(bodypromptmessages);
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
        public IBodyWorkflowAction<EmbedTextResponse> EmbedText(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodytext)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:embedText", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(aPIVersion, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
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
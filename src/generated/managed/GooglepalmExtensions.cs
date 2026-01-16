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
        public IBodyWorkflowAction<JToken> GetModel(Expression<Func<string>> aPIVersion, Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/{0}/models/{1}", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateText(Expression<Func<string>> aPIVersion, Expression<Func<string>> modelType, Expression<Func<string>> modelName, Expression<Func<string>> bodypromptprompt, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodycandidateCount = null, Expression<Func<int>> bodymaxOutputTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null, Expression<Func<JToken[]>> bodysafetySettings = null, Expression<Func<string[]>> bodystopSequences = null)
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
        public IBodyWorkflowAction<EmbedTextResponse> EmbedText(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodytext)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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
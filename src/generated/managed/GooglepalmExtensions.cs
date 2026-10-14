//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GooglepalmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> ListModels(Expression<Func<string>> aPIVersion, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageToken = null)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_pageToken = pageToken == null ? null : WorkflowExpression.Compile(pageToken);
            WorkflowExpression.Validate(__workflow_pageToken, nameof(pageToken), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageToken != null)
                    callPayload.Queries["pageToken"] = ExpressionConverter.Convert(__workflow_pageToken);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GetModel(Expression<Func<string>> aPIVersion, Expression<Func<string>> name)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateText(Expression<Func<string>> aPIVersion, Expression<Func<string>> modelType, Expression<Func<string>> modelName, Expression<Func<string>> bodypromptprompt, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodycandidateCount = null, Expression<Func<int>> bodymaxOutputTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null, Expression<Func<JToken[]>> bodysafetySettings = null, Expression<Func<string[]>> bodystopSequences = null)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_modelType = modelType == null ? null : WorkflowExpression.Compile(modelType);
            WorkflowExpression.Validate(__workflow_modelType, nameof(modelType), required: true);
            var __workflow_modelName = modelName == null ? null : WorkflowExpression.Compile(modelName);
            WorkflowExpression.Validate(__workflow_modelName, nameof(modelName), required: true);
            var __workflow_bodypromptprompt = bodypromptprompt == null ? null : WorkflowExpression.Compile(bodypromptprompt);
            WorkflowExpression.Validate(__workflow_bodypromptprompt, nameof(bodypromptprompt), required: true);
            var __workflow_bodytemperature = bodytemperature == null ? null : WorkflowExpression.Compile(bodytemperature);
            WorkflowExpression.Validate(__workflow_bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodycandidateCount = bodycandidateCount == null ? null : WorkflowExpression.Compile(bodycandidateCount);
            WorkflowExpression.Validate(__workflow_bodycandidateCount, nameof(bodycandidateCount), required: false);
            var __workflow_bodymaxOutputTokens = bodymaxOutputTokens == null ? null : WorkflowExpression.Compile(bodymaxOutputTokens);
            WorkflowExpression.Validate(__workflow_bodymaxOutputTokens, nameof(bodymaxOutputTokens), required: false);
            var __workflow_bodytopP = bodytopP == null ? null : WorkflowExpression.Compile(bodytopP);
            WorkflowExpression.Validate(__workflow_bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodytopK = bodytopK == null ? null : WorkflowExpression.Compile(bodytopK);
            WorkflowExpression.Validate(__workflow_bodytopK, nameof(bodytopK), required: false);
            var __workflow_bodysafetySettings = bodysafetySettings == null ? null : WorkflowExpression.Compile(bodysafetySettings);
            WorkflowExpression.Validate(__workflow_bodysafetySettings, nameof(bodysafetySettings), required: false);
            var __workflow_bodystopSequences = bodystopSequences == null ? null : WorkflowExpression.Compile(bodystopSequences);
            WorkflowExpression.Validate(__workflow_bodystopSequences, nameof(bodystopSequences), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}:generateText", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_modelType, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                promptObjectpropCount++;
                promptObject["text"] = ExpressionConverter.ConvertO(__workflow_bodypromptprompt);
                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
                    bodypropCount++;
                }

                if (__workflow_bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(__workflow_bodytemperature);
                    bodypropCount++;
                }

                if (__workflow_bodycandidateCount != null)
                {
                    body["candidateCount"] = ExpressionConverter.ConvertO(__workflow_bodycandidateCount);
                    bodypropCount++;
                }

                if (__workflow_bodymaxOutputTokens != null)
                {
                    body["maxOutputTokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxOutputTokens);
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    body["topP"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                    bodypropCount++;
                }

                if (__workflow_bodytopK != null)
                {
                    body["topK"] = ExpressionConverter.ConvertO(__workflow_bodytopK);
                    bodypropCount++;
                }

                if (__workflow_bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(__workflow_bodysafetySettings);
                    bodypropCount++;
                }

                if (__workflow_bodystopSequences != null)
                {
                    body["stopSequences"] = ExpressionConverter.ConvertO(__workflow_bodystopSequences);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> GenerateMessage(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<bodypromptmessagesInputItem[]>> bodypromptmessages = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = model == null ? null : WorkflowExpression.Compile(model);
            WorkflowExpression.Validate(__workflow_model, nameof(model), required: true);
            var __workflow_bodypromptmessages = bodypromptmessages == null ? null : WorkflowExpression.Compile(bodypromptmessages);
            WorkflowExpression.Validate(__workflow_bodypromptmessages, nameof(bodypromptmessages), required: false);
            var __workflow_bodytemperature = bodytemperature == null ? null : WorkflowExpression.Compile(bodytemperature);
            WorkflowExpression.Validate(__workflow_bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodytopP = bodytopP == null ? null : WorkflowExpression.Compile(bodytopP);
            WorkflowExpression.Validate(__workflow_bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodytopK = bodytopK == null ? null : WorkflowExpression.Compile(bodytopK);
            WorkflowExpression.Validate(__workflow_bodytopK, nameof(bodytopK), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:generateMessage", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                if (__workflow_bodypromptmessages != null)
                {
                    promptObject["messages"] = ExpressionConverter.ConvertO(__workflow_bodypromptmessages);
                    promptObjectpropCount++;
                }

                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
                    bodypropCount++;
                }

                if (__workflow_bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(__workflow_bodytemperature);
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    body["topP"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                    bodypropCount++;
                }

                if (__workflow_bodytopK != null)
                {
                    body["topK"] = ExpressionConverter.ConvertO(__workflow_bodytopK);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountTextTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodyprompttext = null)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = model == null ? null : WorkflowExpression.Compile(model);
            WorkflowExpression.Validate(__workflow_model, nameof(model), required: true);
            var __workflow_bodyprompttext = bodyprompttext == null ? null : WorkflowExpression.Compile(bodyprompttext);
            WorkflowExpression.Validate(__workflow_bodyprompttext, nameof(bodyprompttext), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countTextTokens", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                if (__workflow_bodyprompttext != null)
                {
                    promptObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyprompttext);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken> CountMessageTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<bodypromptmessagesInputItem[]>> bodypromptmessages = null)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = model == null ? null : WorkflowExpression.Compile(model);
            WorkflowExpression.Validate(__workflow_model, nameof(model), required: true);
            var __workflow_bodypromptmessages = bodypromptmessages == null ? null : WorkflowExpression.Compile(bodypromptmessages);
            WorkflowExpression.Validate(__workflow_bodypromptmessages, nameof(bodypromptmessages), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countMessageTokens", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                if (__workflow_bodypromptmessages != null)
                {
                    promptObject["messages"] = ExpressionConverter.ConvertO(__workflow_bodypromptmessages);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<EmbedTextResponse> EmbedText(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodytext)
        {
            var __workflow_aPIVersion = aPIVersion == null ? null : WorkflowExpression.Compile(aPIVersion);
            WorkflowExpression.Validate(__workflow_aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = model == null ? null : WorkflowExpression.Compile(model);
            WorkflowExpression.Validate(__workflow_model, nameof(model), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<EmbedTextResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:embedText", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmbedTextResponse>(callPayload);
            });
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

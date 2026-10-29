//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlepalm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglepalmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListModels(Expression<Func<string>> aPIVersion, Expression<Func<int>> pageSize = null, Expression<Func<string>> pageToken = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageToken = WorkflowExpression.Compile(pageToken, nameof(pageToken), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models", __workflow_aPIVersion.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetModel(Expression<Func<string>> aPIVersion, Expression<Func<string>> name)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateText(Expression<Func<string>> aPIVersion, Expression<Func<string>> modelType, Expression<Func<string>> modelName, Expression<Func<string>> bodypromptprompt, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodycandidateCount = null, Expression<Func<int>> bodymaxOutputTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null, Expression<Func<JToken[]>> bodysafetySettings = null, Expression<Func<string[]>> bodystopSequences = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_modelType = WorkflowExpression.Compile(modelType, nameof(modelType), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodypromptprompt = WorkflowExpression.Compile(bodypromptprompt, nameof(bodypromptprompt), required: true);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodycandidateCount = WorkflowExpression.Compile(bodycandidateCount, nameof(bodycandidateCount), required: false);
            var __workflow_bodymaxOutputTokens = WorkflowExpression.Compile(bodymaxOutputTokens, nameof(bodymaxOutputTokens), required: false);
            var __workflow_bodytopP = WorkflowExpression.Compile(bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodytopK = WorkflowExpression.Compile(bodytopK, nameof(bodytopK), required: false);
            var __workflow_bodysafetySettings = WorkflowExpression.Compile(bodysafetySettings, nameof(bodysafetySettings), required: false);
            var __workflow_bodystopSequences = WorkflowExpression.Compile(bodystopSequences, nameof(bodystopSequences), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}:generateText", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_modelType.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateMessage(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<bodypromptmessagesInputItem[]>> bodypromptmessages = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodytopK = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_bodypromptmessages = WorkflowExpression.Compile(bodypromptmessages, nameof(bodypromptmessages), required: false);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodytopP = WorkflowExpression.Compile(bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodytopK = WorkflowExpression.Compile(bodytopK, nameof(bodytopK), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:generateMessage", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CountTextTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodyprompttext = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_bodyprompttext = WorkflowExpression.Compile(bodyprompttext, nameof(bodyprompttext), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countTextTokens", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CountMessageTokens(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<bodypromptmessagesInputItem[]>> bodypromptmessages = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_bodypromptmessages = WorkflowExpression.Compile(bodypromptmessages, nameof(bodypromptmessages), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countMessageTokens", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<EmbedTextResponse, ApiConnectionActionConfiguration> EmbedText(Expression<Func<string>> aPIVersion, Expression<Func<string>> model, Expression<Func<string>> bodytext)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<EmbedTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:embedText", __workflow_aPIVersion.WithUrlEncoding(1), __workflow_model.WithUrlEncoding(1)));
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
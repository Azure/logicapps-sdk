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
        [WorkflowExpressionFactory(nameof(__BuildListModels))]
        public IBodyWorkflowAction<JToken> ListModels([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> pageToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildListModels(WorkflowExpression<string> aPIVersion, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> pageToken = null)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(pageToken, nameof(pageToken), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (pageToken != null)
                    callPayload.Queries["pageToken"] = ExpressionConverter.Convert(pageToken);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        [WorkflowExpressionFactory(nameof(__BuildGetModel))]
        public IBodyWorkflowAction<JToken> GetModel([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetModel(WorkflowExpression<string> aPIVersion, WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateText))]
        public IBodyWorkflowAction<JToken> GenerateText([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> modelType, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<string> bodypromptprompt, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodycandidateCount = null, [WorkflowExpression] Func<int> bodymaxOutputTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<JToken[]> bodysafetySettings = null, [WorkflowExpression] Func<string[]> bodystopSequences = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGenerateText(WorkflowExpression<string> aPIVersion, WorkflowExpression<string> modelType, WorkflowExpression<string> modelName, WorkflowExpression<string> bodypromptprompt, WorkflowExpression<double> bodytemperature = null, WorkflowExpression<int> bodycandidateCount = null, WorkflowExpression<int> bodymaxOutputTokens = null, WorkflowExpression<double> bodytopP = null, WorkflowExpression<int> bodytopK = null, WorkflowExpression<JToken[]> bodysafetySettings = null, WorkflowExpression<string[]> bodystopSequences = null)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(modelType, nameof(modelType), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodypromptprompt, nameof(bodypromptprompt), required: true);
            WorkflowExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowExpression.Validate(bodycandidateCount, nameof(bodycandidateCount), required: false);
            WorkflowExpression.Validate(bodymaxOutputTokens, nameof(bodymaxOutputTokens), required: false);
            WorkflowExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            WorkflowExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            WorkflowExpression.Validate(bodystopSequences, nameof(bodystopSequences), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}:generateText", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelType, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateMessage))]
        public IBodyWorkflowAction<JToken> GenerateMessage([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<bodypromptmessagesInputItem[]> bodypromptmessages = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodytopK = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGenerateMessage(WorkflowExpression<string> aPIVersion, WorkflowExpression<string> model, WorkflowExpression<bodypromptmessagesInputItem[]> bodypromptmessages = null, WorkflowExpression<double> bodytemperature = null, WorkflowExpression<double> bodytopP = null, WorkflowExpression<int> bodytopK = null)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(bodypromptmessages, nameof(bodypromptmessages), required: false);
            WorkflowExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:generateMessage", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        [WorkflowExpressionFactory(nameof(__BuildCountTextTokens))]
        public IBodyWorkflowAction<JToken> CountTextTokens([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<string> bodyprompttext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCountTextTokens(WorkflowExpression<string> aPIVersion, WorkflowExpression<string> model, WorkflowExpression<string> bodyprompttext = null)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(bodyprompttext, nameof(bodyprompttext), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countTextTokens", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        [WorkflowExpressionFactory(nameof(__BuildCountMessageTokens))]
        public IBodyWorkflowAction<JToken> CountMessageTokens([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<bodypromptmessagesInputItem[]> bodypromptmessages = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCountMessageTokens(WorkflowExpression<string> aPIVersion, WorkflowExpression<string> model, WorkflowExpression<bodypromptmessagesInputItem[]> bodypromptmessages = null)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(bodypromptmessages, nameof(bodypromptmessages), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countMessageTokens", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlepalm")]
        [WorkflowExpressionFactory(nameof(__BuildEmbedText))]
        public IBodyWorkflowAction<EmbedTextResponse> EmbedText([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> model, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmbedTextResponse> __BuildEmbedText(WorkflowExpression<string> aPIVersion, WorkflowExpression<string> model, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<EmbedTextResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:embedText", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
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
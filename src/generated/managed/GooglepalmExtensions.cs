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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildListModels(WorkflowValue<string> aPIVersion, WorkflowValue<int> pageSize = null, WorkflowValue<string> pageToken = null)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(pageToken, nameof(pageToken), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetModel(WorkflowValue<string> aPIVersion, WorkflowValue<string> name)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGenerateText(WorkflowValue<string> aPIVersion, WorkflowValue<string> modelType, WorkflowValue<string> modelName, WorkflowValue<string> bodypromptprompt, WorkflowValue<double> bodytemperature = null, WorkflowValue<int> bodycandidateCount = null, WorkflowValue<int> bodymaxOutputTokens = null, WorkflowValue<double> bodytopP = null, WorkflowValue<int> bodytopK = null, WorkflowValue<JToken[]> bodysafetySettings = null, WorkflowValue<string[]> bodystopSequences = null)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(modelType, nameof(modelType), required: true);
            WorkflowValue.Validate(modelName, nameof(modelName), required: true);
            WorkflowValue.Validate(bodypromptprompt, nameof(bodypromptprompt), required: true);
            WorkflowValue.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowValue.Validate(bodycandidateCount, nameof(bodycandidateCount), required: false);
            WorkflowValue.Validate(bodymaxOutputTokens, nameof(bodymaxOutputTokens), required: false);
            WorkflowValue.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowValue.Validate(bodytopK, nameof(bodytopK), required: false);
            WorkflowValue.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            WorkflowValue.Validate(bodystopSequences, nameof(bodystopSequences), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGenerateMessage(WorkflowValue<string> aPIVersion, WorkflowValue<string> model, WorkflowValue<bodypromptmessagesInputItem[]> bodypromptmessages = null, WorkflowValue<double> bodytemperature = null, WorkflowValue<double> bodytopP = null, WorkflowValue<int> bodytopK = null)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(model, nameof(model), required: true);
            WorkflowValue.Validate(bodypromptmessages, nameof(bodypromptmessages), required: false);
            WorkflowValue.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowValue.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowValue.Validate(bodytopK, nameof(bodytopK), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCountTextTokens(WorkflowValue<string> aPIVersion, WorkflowValue<string> model, WorkflowValue<string> bodyprompttext = null)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(model, nameof(model), required: true);
            WorkflowValue.Validate(bodyprompttext, nameof(bodyprompttext), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCountMessageTokens(WorkflowValue<string> aPIVersion, WorkflowValue<string> model, WorkflowValue<bodypromptmessagesInputItem[]> bodypromptmessages = null)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(model, nameof(model), required: true);
            WorkflowValue.Validate(bodypromptmessages, nameof(bodypromptmessages), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmbedTextResponse> __BuildEmbedText(WorkflowValue<string> aPIVersion, WorkflowValue<string> model, WorkflowValue<string> bodytext)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(model, nameof(model), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
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

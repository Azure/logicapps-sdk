//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlegemini
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglegeminiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateTextContent))]
        public IBodyWorkflowAction<GenerateTextContentResponse> GenerateTextContent([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents = null, [WorkflowExpression] Func<bodysafetySettingsInputItem[]> bodysafetySettings = null, [WorkflowExpression] Func<int> bodygenerationConfigmaxOutputTokens = null, [WorkflowExpression] Func<double> bodygenerationConfigtemperature = null, [WorkflowExpression] Func<double> bodygenerationConfigtopP = null, [WorkflowExpression] Func<int> bodygenerationConfigtopK = null, [WorkflowExpression] Func<int> bodygenerationConfigcandidateCount = null, [WorkflowExpression] Func<string[]> bodygenerationConfigstopSequences = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateTextContentResponse> __BuildGenerateTextContent(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName, WorkflowExpression<bodycontentsInputItem[]> bodycontents = null, WorkflowExpression<bodysafetySettingsInputItem[]> bodysafetySettings = null, WorkflowExpression<int> bodygenerationConfigmaxOutputTokens = null, WorkflowExpression<double> bodygenerationConfigtemperature = null, WorkflowExpression<double> bodygenerationConfigtopP = null, WorkflowExpression<int> bodygenerationConfigtopK = null, WorkflowExpression<int> bodygenerationConfigcandidateCount = null, WorkflowExpression<string[]> bodygenerationConfigstopSequences = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            WorkflowExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            WorkflowExpression.Validate(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            WorkflowExpression.Validate(bodygenerationConfigcandidateCount, nameof(bodygenerationConfigcandidateCount), required: false);
            WorkflowExpression.Validate(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            return new DeferredBodyAction<GenerateTextContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:generateContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = ExpressionConverter.ConvertO(bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = ExpressionConverter.ConvertO(bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = ExpressionConverter.ConvertO(bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = ExpressionConverter.ConvertO(bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigcandidateCount != null)
                {
                    generationConfigObject["candidateCount"] = ExpressionConverter.ConvertO(bodygenerationConfigcandidateCount);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = ExpressionConverter.ConvertO(bodygenerationConfigstopSequences);
                    generationConfigObjectpropCount++;
                }

                if (generationConfigObjectpropCount > 0)
                {
                    body["generationConfig"] = generationConfigObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateTextContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateStreamContent))]
        public IBodyWorkflowAction<GenerateStreamContentResponseItem[]> GenerateStreamContent([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents = null, [WorkflowExpression] Func<bodysafetySettingsInputItem[]> bodysafetySettings = null, [WorkflowExpression] Func<double> bodygenerationConfigtemperature = null, [WorkflowExpression] Func<int> bodygenerationConfigmaxOutputTokens = null, [WorkflowExpression] Func<double> bodygenerationConfigtopP = null, [WorkflowExpression] Func<int> bodygenerationConfigtopK = null, [WorkflowExpression] Func<int> bodygenerationConfigcandidateCount = null, [WorkflowExpression] Func<string[]> bodygenerationConfigstopSequences = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateStreamContentResponseItem[]> __BuildGenerateStreamContent(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName, WorkflowExpression<bodycontentsInputItem[]> bodycontents = null, WorkflowExpression<bodysafetySettingsInputItem[]> bodysafetySettings = null, WorkflowExpression<double> bodygenerationConfigtemperature = null, WorkflowExpression<int> bodygenerationConfigmaxOutputTokens = null, WorkflowExpression<double> bodygenerationConfigtopP = null, WorkflowExpression<int> bodygenerationConfigtopK = null, WorkflowExpression<int> bodygenerationConfigcandidateCount = null, WorkflowExpression<string[]> bodygenerationConfigstopSequences = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            WorkflowExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            WorkflowExpression.Validate(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            WorkflowExpression.Validate(bodygenerationConfigcandidateCount, nameof(bodygenerationConfigcandidateCount), required: false);
            WorkflowExpression.Validate(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            return new DeferredBodyAction<GenerateStreamContentResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:streamGenerateContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = ExpressionConverter.ConvertO(bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = ExpressionConverter.ConvertO(bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = ExpressionConverter.ConvertO(bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = ExpressionConverter.ConvertO(bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigcandidateCount != null)
                {
                    generationConfigObject["candidateCount"] = ExpressionConverter.ConvertO(bodygenerationConfigcandidateCount);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = ExpressionConverter.ConvertO(bodygenerationConfigstopSequences);
                    generationConfigObjectpropCount++;
                }

                if (generationConfigObjectpropCount > 0)
                {
                    body["generationConfig"] = generationConfigObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateStreamContentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateMultiModalContent))]
        public IBodyWorkflowAction<GenerateMultiModalContentResponse> GenerateMultiModalContent([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem2[]> bodycontents = null, [WorkflowExpression] Func<bodysafetySettingsInputItem[]> bodysafetySettings = null, [WorkflowExpression] Func<int> bodygenerationConfigmaxOutputTokens = null, [WorkflowExpression] Func<double> bodygenerationConfigtemperature = null, [WorkflowExpression] Func<double> bodygenerationConfigtopP = null, [WorkflowExpression] Func<int> bodygenerationConfigtopK = null, [WorkflowExpression] Func<string[]> bodygenerationConfigstopSequences = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateMultiModalContentResponse> __BuildGenerateMultiModalContent(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName, WorkflowExpression<bodycontentsInputItem2[]> bodycontents = null, WorkflowExpression<bodysafetySettingsInputItem[]> bodysafetySettings = null, WorkflowExpression<int> bodygenerationConfigmaxOutputTokens = null, WorkflowExpression<double> bodygenerationConfigtemperature = null, WorkflowExpression<double> bodygenerationConfigtopP = null, WorkflowExpression<int> bodygenerationConfigtopK = null, WorkflowExpression<string[]> bodygenerationConfigstopSequences = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            WorkflowExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            WorkflowExpression.Validate(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            WorkflowExpression.Validate(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            WorkflowExpression.Validate(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            return new DeferredBodyAction<GenerateMultiModalContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}-vision:generateContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = ExpressionConverter.ConvertO(bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = ExpressionConverter.ConvertO(bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = ExpressionConverter.ConvertO(bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = ExpressionConverter.ConvertO(bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = ExpressionConverter.ConvertO(bodygenerationConfigstopSequences);
                    generationConfigObjectpropCount++;
                }

                if (generationConfigObjectpropCount > 0)
                {
                    body["generationConfig"] = generationConfigObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateMultiModalContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildCountTokens))]
        public IBodyWorkflowAction<CountTokensResponse> CountTokens([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem22[]> bodycontents = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CountTokensResponse> __BuildCountTokens(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName, WorkflowExpression<bodycontentsInputItem22[]> bodycontents = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            return new DeferredBodyAction<CountTokensResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countTokens", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CountTokensResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllModels))]
        public IBodyWorkflowAction<GetAllModelsResponse> GetAllModels([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllModelsResponse> __BuildGetAllModels(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<GetAllModelsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllModelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildGetModelDetails))]
        public IBodyWorkflowAction<GetModelDetailsResponse> GetModelDetails([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetModelDetailsResponse> __BuildGetModelDetails(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            return new DeferredBodyAction<GetModelDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetModelDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateEmbedding))]
        public IBodyWorkflowAction<GenerateEmbeddingResponse> GenerateEmbedding([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<string> bodymodelResourceName, [WorkflowExpression] Func<bodycontentpartsInputItem[]> bodycontentparts = null, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateEmbeddingResponse> __BuildGenerateEmbedding(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName, WorkflowExpression<string> bodymodelResourceName, WorkflowExpression<bodycontentpartsInputItem[]> bodycontentparts = null, WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodymodelResourceName, nameof(bodymodelResourceName), required: true);
            WorkflowExpression.Validate(bodycontentparts, nameof(bodycontentparts), required: false);
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<GenerateEmbeddingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:embedContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodymodelResourceName);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentparts != null)
                {
                    contentObject["parts"] = ExpressionConverter.ConvertO(bodycontentparts);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateEmbeddingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [WorkflowExpressionFactory(nameof(__BuildBatchEmbedContents))]
        public IBodyWorkflowAction<BatchEmbedContentsResponse> BatchEmbedContents([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodyrequestsInputItem[]> bodyrequests)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BatchEmbedContentsResponse> __BuildBatchEmbedContents(WorkflowExpression<string> apiVersion, WorkflowExpression<string> modelName, WorkflowExpression<bodyrequestsInputItem[]> bodyrequests)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(modelName, nameof(modelName), required: true);
            WorkflowExpression.Validate(bodyrequests, nameof(bodyrequests), required: true);
            return new DeferredBodyAction<BatchEmbedContentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:batchEmbedContents", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requests"] = ExpressionConverter.ConvertO(bodyrequests);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BatchEmbedContentsResponse>(callPayload);
            });
        }
    }

    public class GooglegeminiTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateTextContentResponse
    {
        [JsonProperty("candidates")]
        public GenerateTextContentResponseCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("promptFeedback")]
        public GenerateTextContentResponsePromptFeedbackType PromptFeedback { get; set; }
    }

    public class GenerateTextContentResponseCandidatesTypeItem
    {
        [JsonProperty("content")]
        public GenerateTextContentResponseCandidatesTypeItemContentType Content { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("safetyRatings")]
        public GenerateTextContentResponseCandidatesTypeItemSafetyRatingsTypeItem[] SafetyRatings { get; set; }
    }

    public class GenerateTextContentResponseCandidatesTypeItemContentType
    {
        [JsonProperty("parts")]
        public GenerateTextContentResponseCandidatesTypeItemContentTypePartsTypeItem[] Parts { get; set; }
    }

    public class GenerateTextContentResponseCandidatesTypeItemContentTypePartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GenerateTextContentResponseCandidatesTypeItemSafetyRatingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }
    }

    public class GenerateTextContentResponsePromptFeedbackType
    {
        [JsonProperty("safetyRatings")]
        public GenerateTextContentResponsePromptFeedbackTypeSafetyRatingsTypeItem[] SafetyRatings { get; set; }
    }

    public class GenerateTextContentResponsePromptFeedbackTypeSafetyRatingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }
    }

    public class bodycontentsInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("parts")]
        public bodycontentsInputItemPartsTypeItem[] Parts { get; set; }
    }

    public class bodycontentsInputItemPartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodysafetySettingsInputItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("threshold")]
        public string Threshold { get; set; }
    }

    public class GenerateStreamContentResponseItem
    {
        [JsonProperty("candidates")]
        public GenerateStreamContentResponseItemCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("promptFeedback")]
        public GenerateStreamContentResponseItemPromptFeedbackType PromptFeedback { get; set; }
    }

    public class GenerateStreamContentResponseItemCandidatesTypeItem
    {
        [JsonProperty("content")]
        public GenerateStreamContentResponseItemCandidatesTypeItemContentType Content { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("safetyRatings")]
        public GenerateStreamContentResponseItemCandidatesTypeItemSafetyRatingsTypeItem[] SafetyRatings { get; set; }
    }

    public class GenerateStreamContentResponseItemCandidatesTypeItemContentType
    {
        [JsonProperty("parts")]
        public GenerateStreamContentResponseItemCandidatesTypeItemContentTypePartsTypeItem[] Parts { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class GenerateStreamContentResponseItemCandidatesTypeItemContentTypePartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GenerateStreamContentResponseItemCandidatesTypeItemSafetyRatingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }
    }

    public class GenerateStreamContentResponseItemPromptFeedbackType
    {
        [JsonProperty("safetyRatings")]
        public GenerateStreamContentResponseItemPromptFeedbackTypeSafetyRatingsTypeItem[] SafetyRatings { get; set; }
    }

    public class GenerateStreamContentResponseItemPromptFeedbackTypeSafetyRatingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }
    }

    public class GenerateMultiModalContentResponse
    {
        [JsonProperty("candidates")]
        public GenerateMultiModalContentResponseCandidatesTypeItem[] Candidates { get; set; }

        [JsonProperty("promptFeedback")]
        public GenerateMultiModalContentResponsePromptFeedbackType PromptFeedback { get; set; }
    }

    public class GenerateMultiModalContentResponseCandidatesTypeItem
    {
        [JsonProperty("content")]
        public GenerateMultiModalContentResponseCandidatesTypeItemContentType Content { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("safetyRatings")]
        public GenerateMultiModalContentResponseCandidatesTypeItemSafetyRatingsTypeItem[] SafetyRatings { get; set; }
    }

    public class GenerateMultiModalContentResponseCandidatesTypeItemContentType
    {
        [JsonProperty("parts")]
        public JToken[] Parts { get; set; }
    }

    public class GenerateMultiModalContentResponseCandidatesTypeItemSafetyRatingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }
    }

    public class GenerateMultiModalContentResponsePromptFeedbackType
    {
        [JsonProperty("safetyRatings")]
        public GenerateMultiModalContentResponsePromptFeedbackTypeSafetyRatingsTypeItem[] SafetyRatings { get; set; }
    }

    public class GenerateMultiModalContentResponsePromptFeedbackTypeSafetyRatingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }
    }

    public class bodycontentsInputItem2
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("parts")]
        public JToken[] Parts { get; set; }
    }

    public class CountTokensResponse
    {
        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }
    }

    public class bodycontentsInputItem22
    {
        [JsonProperty("parts")]
        public bodycontentsInputItemPartsTypeItem[] Parts { get; set; }
    }

    public class GetAllModelsResponse
    {
        [JsonProperty("models")]
        public GetAllModelsResponseModelsTypeItem[] Models { get; set; }
    }

    public class GetAllModelsResponseModelsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inputTokenLimit")]
        public int InputTokenLimit { get; set; }

        [JsonProperty("outputTokenLimit")]
        public int OutputTokenLimit { get; set; }

        [JsonProperty("supportedGenerationMethods")]
        public string[] SupportedGenerationMethods { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("topP")]
        public double TopP { get; set; }

        [JsonProperty("topK")]
        public double TopK { get; set; }
    }

    public class GetModelDetailsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inputTokenLimit")]
        public int InputTokenLimit { get; set; }

        [JsonProperty("outputTokenLimit")]
        public int OutputTokenLimit { get; set; }

        [JsonProperty("supportedGenerationMethods")]
        public string[] SupportedGenerationMethods { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("topP")]
        public double TopP { get; set; }

        [JsonProperty("topK")]
        public double TopK { get; set; }
    }

    public class GenerateEmbeddingResponse
    {
        [JsonProperty("embedding")]
        public GenerateEmbeddingResponseEmbeddingType Embedding { get; set; }
    }

    public class GenerateEmbeddingResponseEmbeddingType
    {
        [JsonProperty("values")]
        public double[] Values { get; set; }
    }

    public class bodycontentpartsInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytaskTypeInput
    {
        [EnumMember(Value = "RETRIEVAL_QUERY")]
        RETRIEVALQUERY,
        [EnumMember(Value = "RETRIEVAL_DOCUMENT")]
        RETRIEVALDOCUMENT,
        [EnumMember(Value = "SEMANTIC_SIMILARITY")]
        SEMANTICSIMILARITY,
        CLASSIFICATION,
        CLUSTERING,
        [EnumMember(Value = "TASK_TYPE_UNSPECIFIED")]
        TASKTYPEUNSPECIFIED
    }

    public class BatchEmbedContentsResponse
    {
        [JsonProperty("embeddings")]
        public BatchEmbedContentsResponseEmbeddingsTypeItem[] Embeddings { get; set; }
    }

    public class BatchEmbedContentsResponseEmbeddingsTypeItem
    {
        [JsonProperty("values")]
        public double[] Values { get; set; }
    }

    public class bodyrequestsInputItem
    {
        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("content")]
        public bodyrequestsInputItemContentType Content { get; set; }
    }

    public class bodyrequestsInputItemContentType
    {
        [JsonProperty("parts")]
        public bodyrequestsInputItemContentTypePartsTypeItem[] Parts { get; set; }
    }

    public class bodyrequestsInputItemContentTypePartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlegemini;

    public partial class WorkflowManagedActions
    {
        public GooglegeminiActions Googlegemini(string connectionId) => new GooglegeminiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglegeminiTriggers Googlegemini(string connectionId) => new GooglegeminiTriggers(connectionId);
    }
}
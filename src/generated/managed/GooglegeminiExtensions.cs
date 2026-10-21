//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlegemini
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglegeminiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateTextContentResponse> GenerateTextContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem[]>> bodycontents = null, Expression<Func<bodysafetySettingsInputItem[]>> bodysafetySettings = null, Expression<Func<int>> bodygenerationConfigmaxOutputTokens = null, Expression<Func<double>> bodygenerationConfigtemperature = null, Expression<Func<double>> bodygenerationConfigtopP = null, Expression<Func<int>> bodygenerationConfigtopK = null, Expression<Func<int>> bodygenerationConfigcandidateCount = null, Expression<Func<string[]>> bodygenerationConfigstopSequences = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodycontents = WorkflowExpression.Compile(bodycontents, nameof(bodycontents), required: false);
            var __workflow_bodysafetySettings = WorkflowExpression.Compile(bodysafetySettings, nameof(bodysafetySettings), required: false);
            var __workflow_bodygenerationConfigmaxOutputTokens = WorkflowExpression.Compile(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            var __workflow_bodygenerationConfigtemperature = WorkflowExpression.Compile(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            var __workflow_bodygenerationConfigtopP = WorkflowExpression.Compile(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            var __workflow_bodygenerationConfigtopK = WorkflowExpression.Compile(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            var __workflow_bodygenerationConfigcandidateCount = WorkflowExpression.Compile(bodygenerationConfigcandidateCount, nameof(bodygenerationConfigcandidateCount), required: false);
            var __workflow_bodygenerationConfigstopSequences = WorkflowExpression.Compile(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            return new DeferredBodyAction<GenerateTextContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:generateContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                    bodypropCount++;
                }

                if (__workflow_bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(__workflow_bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (__workflow_bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigcandidateCount != null)
                {
                    generationConfigObject["candidateCount"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigcandidateCount);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigstopSequences);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateStreamContentResponseItem[]> GenerateStreamContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem[]>> bodycontents = null, Expression<Func<bodysafetySettingsInputItem[]>> bodysafetySettings = null, Expression<Func<double>> bodygenerationConfigtemperature = null, Expression<Func<int>> bodygenerationConfigmaxOutputTokens = null, Expression<Func<double>> bodygenerationConfigtopP = null, Expression<Func<int>> bodygenerationConfigtopK = null, Expression<Func<int>> bodygenerationConfigcandidateCount = null, Expression<Func<string[]>> bodygenerationConfigstopSequences = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodycontents = WorkflowExpression.Compile(bodycontents, nameof(bodycontents), required: false);
            var __workflow_bodysafetySettings = WorkflowExpression.Compile(bodysafetySettings, nameof(bodysafetySettings), required: false);
            var __workflow_bodygenerationConfigtemperature = WorkflowExpression.Compile(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            var __workflow_bodygenerationConfigmaxOutputTokens = WorkflowExpression.Compile(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            var __workflow_bodygenerationConfigtopP = WorkflowExpression.Compile(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            var __workflow_bodygenerationConfigtopK = WorkflowExpression.Compile(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            var __workflow_bodygenerationConfigcandidateCount = WorkflowExpression.Compile(bodygenerationConfigcandidateCount, nameof(bodygenerationConfigcandidateCount), required: false);
            var __workflow_bodygenerationConfigstopSequences = WorkflowExpression.Compile(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            return new DeferredBodyAction<GenerateStreamContentResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:streamGenerateContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                    bodypropCount++;
                }

                if (__workflow_bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(__workflow_bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (__workflow_bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigcandidateCount != null)
                {
                    generationConfigObject["candidateCount"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigcandidateCount);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigstopSequences);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateMultiModalContentResponse> GenerateMultiModalContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem2[]>> bodycontents = null, Expression<Func<bodysafetySettingsInputItem[]>> bodysafetySettings = null, Expression<Func<int>> bodygenerationConfigmaxOutputTokens = null, Expression<Func<double>> bodygenerationConfigtemperature = null, Expression<Func<double>> bodygenerationConfigtopP = null, Expression<Func<int>> bodygenerationConfigtopK = null, Expression<Func<string[]>> bodygenerationConfigstopSequences = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodycontents = WorkflowExpression.Compile(bodycontents, nameof(bodycontents), required: false);
            var __workflow_bodysafetySettings = WorkflowExpression.Compile(bodysafetySettings, nameof(bodysafetySettings), required: false);
            var __workflow_bodygenerationConfigmaxOutputTokens = WorkflowExpression.Compile(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            var __workflow_bodygenerationConfigtemperature = WorkflowExpression.Compile(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            var __workflow_bodygenerationConfigtopP = WorkflowExpression.Compile(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            var __workflow_bodygenerationConfigtopK = WorkflowExpression.Compile(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            var __workflow_bodygenerationConfigstopSequences = WorkflowExpression.Compile(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            return new DeferredBodyAction<GenerateMultiModalContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}-vision:generateContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                    bodypropCount++;
                }

                if (__workflow_bodysafetySettings != null)
                {
                    body["safetySettings"] = ExpressionConverter.ConvertO(__workflow_bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (__workflow_bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (__workflow_bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = ExpressionConverter.ConvertO(__workflow_bodygenerationConfigstopSequences);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<CountTokensResponse> CountTokens(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem22[]>> bodycontents = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodycontents = WorkflowExpression.Compile(bodycontents, nameof(bodycontents), required: false);
            return new DeferredBodyAction<CountTokensResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countTokens", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CountTokensResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetAllModelsResponse> GetAllModels(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<GetAllModelsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models", __workflow_apiVersion.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllModelsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetModelDetailsResponse> GetModelDetails(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            return new DeferredBodyAction<GetModelDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetModelDetailsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateEmbeddingResponse> GenerateEmbedding(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<string>> bodymodelResourceName, Expression<Func<bodycontentpartsInputItem[]>> bodycontentparts = null, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodymodelResourceName = WorkflowExpression.Compile(bodymodelResourceName, nameof(bodymodelResourceName), required: true);
            var __workflow_bodycontentparts = WorkflowExpression.Compile(bodycontentparts, nameof(bodycontentparts), required: false);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<GenerateEmbeddingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:embedContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodelResourceName);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (__workflow_bodycontentparts != null)
                {
                    contentObject["parts"] = ExpressionConverter.ConvertO(__workflow_bodycontentparts);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateEmbeddingResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<BatchEmbedContentsResponse> BatchEmbedContents(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodyrequestsInputItem[]>> bodyrequests)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_bodyrequests = WorkflowExpression.Compile(bodyrequests, nameof(bodyrequests), required: true);
            return new DeferredBodyAction<BatchEmbedContentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:batchEmbedContents", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requests"] = ExpressionConverter.ConvertO(__workflow_bodyrequests);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BatchEmbedContentsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

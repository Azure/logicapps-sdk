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
        public IBodyWorkflowAction<GenerateTextContentResponse, ApiConnectionActionConfiguration> GenerateTextContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<GenerateTextContentInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateTextContentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:generateContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateTextContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateStreamContentResponseItem[], ApiConnectionActionConfiguration> GenerateStreamContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<GenerateStreamContentInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateStreamContentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:streamGenerateContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateStreamContentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateMultiModalContentResponse, ApiConnectionActionConfiguration> GenerateMultiModalContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<GenerateMultiModalContentInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateMultiModalContentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}-vision:generateContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateMultiModalContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<CountTokensResponse, ApiConnectionActionConfiguration> CountTokens(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<CountTokensInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CountTokensResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:countTokens", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CountTokensResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetAllModelsResponse, ApiConnectionActionConfiguration> GetAllModels(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<GetAllModelsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models", __workflow_apiVersion.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllModelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetModelDetailsResponse, ApiConnectionActionConfiguration> GetModelDetails(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            return new DeferredBodyAction<GetModelDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetModelDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateEmbeddingResponse, ApiConnectionActionConfiguration> GenerateEmbedding(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<GenerateEmbeddingInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateEmbeddingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:embedContent", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateEmbeddingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<BatchEmbedContentsResponse, ApiConnectionActionConfiguration> BatchEmbedContents(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<BatchEmbedContentsInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_modelName = WorkflowExpression.Compile(modelName, nameof(modelName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BatchEmbedContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/models/{1}:batchEmbedContents", __workflow_apiVersion.WithUrlEncoding(1), __workflow_modelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class GenerateTextContentInput
    {
        [JsonProperty("contents")]
        public GenerateTextContentInputContentsTypeItem[] Contents { get; set; }

        [JsonProperty("safetySettings")]
        public GenerateTextContentInputSafetySettingsTypeItem[] SafetySettings { get; set; }

        [JsonProperty("generationConfig")]
        public GenerateTextContentInputGenerationConfigType GenerationConfig { get; set; }
    }

    public class GenerateTextContentInputContentsTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; } = "user";

        [JsonProperty("parts", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateTextContentInputContentsTypeItemPartsTypeItem[] Parts { get; set; }
    }

    public class GenerateTextContentInputContentsTypeItemPartsTypeItem
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class GenerateTextContentInputSafetySettingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("threshold")]
        public string Threshold { get; set; }
    }

    public class GenerateTextContentInputGenerationConfigType
    {
        [JsonProperty("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("topP")]
        public double? TopP { get; set; }

        [JsonProperty("topK")]
        public int? TopK { get; set; }

        [JsonProperty("candidateCount")]
        public int? CandidateCount { get; set; }

        [JsonProperty("stopSequences")]
        public string[] StopSequences { get; set; }
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

    public class GenerateStreamContentInput
    {
        [JsonProperty("contents")]
        public GenerateStreamContentInputContentsTypeItem[] Contents { get; set; }

        [JsonProperty("safetySettings")]
        public GenerateStreamContentInputSafetySettingsTypeItem[] SafetySettings { get; set; }

        [JsonProperty("generationConfig")]
        public GenerateStreamContentInputGenerationConfigType GenerationConfig { get; set; }
    }

    public class GenerateStreamContentInputContentsTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; } = "user";

        [JsonProperty("parts")]
        public GenerateStreamContentInputContentsTypeItemPartsTypeItem[] Parts { get; set; }
    }

    public class GenerateStreamContentInputContentsTypeItemPartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GenerateStreamContentInputSafetySettingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("threshold")]
        public string Threshold { get; set; }
    }

    public class GenerateStreamContentInputGenerationConfigType
    {
        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        [JsonProperty("topP")]
        public double? TopP { get; set; }

        [JsonProperty("topK")]
        public int? TopK { get; set; }

        [JsonProperty("candidateCount")]
        public int? CandidateCount { get; set; }

        [JsonProperty("stopSequences")]
        public string[] StopSequences { get; set; }
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

    public class GenerateMultiModalContentInput
    {
        [JsonProperty("contents")]
        public GenerateMultiModalContentInputContentsTypeItem[] Contents { get; set; }

        [JsonProperty("safetySettings")]
        public GenerateMultiModalContentInputSafetySettingsTypeItem[] SafetySettings { get; set; }

        [JsonProperty("generationConfig")]
        public GenerateMultiModalContentInputGenerationConfigType GenerationConfig { get; set; }
    }

    public class GenerateMultiModalContentInputContentsTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; } = "user";

        [JsonProperty("parts", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Parts { get; set; }
    }

    public class GenerateMultiModalContentInputSafetySettingsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("threshold")]
        public string Threshold { get; set; }
    }

    public class GenerateMultiModalContentInputGenerationConfigType
    {
        [JsonProperty("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("topP")]
        public double? TopP { get; set; }

        [JsonProperty("topK")]
        public int? TopK { get; set; }

        [JsonProperty("stopSequences")]
        public string[] StopSequences { get; set; }
    }

    public class CountTokensResponse
    {
        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }
    }

    public class CountTokensInput
    {
        [JsonProperty("contents")]
        public CountTokensInputContentsTypeItem[] Contents { get; set; }
    }

    public class CountTokensInputContentsTypeItem
    {
        [JsonProperty("parts")]
        public CountTokensInputContentsTypeItemPartsTypeItem[] Parts { get; set; }
    }

    public class CountTokensInputContentsTypeItemPartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
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

    public class GenerateEmbeddingInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ModelResourceName { get; set; } = "models/embedding-001";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateEmbeddingInputContentType Content { get; set; }

        [JsonProperty("taskType")]
        public GenerateEmbeddingInputTaskTypeType? TaskType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GenerateEmbeddingInputContentType
    {
        [JsonProperty("parts")]
        public GenerateEmbeddingInputContentTypePartsTypeItem[] Parts { get; set; }
    }

    public class GenerateEmbeddingInputContentTypePartsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateEmbeddingInputTaskTypeType
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

    public class BatchEmbedContentsInput
    {
        [JsonProperty("requests", DefaultValueHandling = DefaultValueHandling.Include)]
        public BatchEmbedContentsInputRequestsTypeItem[] Requests { get; set; }
    }

    public class BatchEmbedContentsInputRequestsTypeItem
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "models/embedding-001";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public BatchEmbedContentsInputRequestsTypeItemContentType Content { get; set; }
    }

    public class BatchEmbedContentsInputRequestsTypeItemContentType
    {
        [JsonProperty("parts")]
        public BatchEmbedContentsInputRequestsTypeItemContentTypePartsTypeItem[] Parts { get; set; }
    }

    public class BatchEmbedContentsInputRequestsTypeItemContentTypePartsTypeItem
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
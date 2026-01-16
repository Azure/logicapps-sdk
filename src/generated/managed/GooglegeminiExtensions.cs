//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlegemini
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglegeminiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateTextContentResponse> GenerateTextContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem[]>> bodycontents = null, Expression<Func<bodysafetySettingsInputItem[]>> bodysafetySettings = null, Expression<Func<int>> bodygenerationConfigmaxOutputTokens = null, Expression<Func<double>> bodygenerationConfigtemperature = null, Expression<Func<double>> bodygenerationConfigtopP = null, Expression<Func<int>> bodygenerationConfigtopK = null, Expression<Func<int>> bodygenerationConfigcandidateCount = null, Expression<Func<string[]>> bodygenerationConfigstopSequences = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:generateContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateStreamContentResponseItem[]> GenerateStreamContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem[]>> bodycontents = null, Expression<Func<bodysafetySettingsInputItem[]>> bodysafetySettings = null, Expression<Func<double>> bodygenerationConfigtemperature = null, Expression<Func<int>> bodygenerationConfigmaxOutputTokens = null, Expression<Func<double>> bodygenerationConfigtopP = null, Expression<Func<int>> bodygenerationConfigtopK = null, Expression<Func<int>> bodygenerationConfigcandidateCount = null, Expression<Func<string[]>> bodygenerationConfigstopSequences = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:streamGenerateContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateMultiModalContentResponse> GenerateMultiModalContent(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem2[]>> bodycontents = null, Expression<Func<bodysafetySettingsInputItem[]>> bodysafetySettings = null, Expression<Func<int>> bodygenerationConfigmaxOutputTokens = null, Expression<Func<double>> bodygenerationConfigtemperature = null, Expression<Func<double>> bodygenerationConfigtopP = null, Expression<Func<int>> bodygenerationConfigtopK = null, Expression<Func<string[]>> bodygenerationConfigstopSequences = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}-vision:generateContent", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<CountTokensResponse> CountTokens(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName, Expression<Func<bodycontentsInputItem22[]>> bodycontents = null)
        {
            var apiCallPath = String.Format("/{0}/models/{1}:countTokens", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetAllModelsResponse> GetAllModels(Expression<Func<string>> apiVersion)
        {
            var apiCallPath = String.Format("/{0}/models", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllModelsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetModelDetailsResponse> GetModelDetails(Expression<Func<string>> apiVersion, Expression<Func<string>> modelName)
        {
            var apiCallPath = String.Format("/{0}/models/{1}", ExpressionConverter.ConvertWithUrlEncoding(apiVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(modelName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetModelDetailsResponse>(callPayload);
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
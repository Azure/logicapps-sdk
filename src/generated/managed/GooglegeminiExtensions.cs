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
        public IBodyWorkflowAction<GenerateTextContentResponse> GenerateTextContent([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents = null, [WorkflowExpression] Func<bodysafetySettingsInputItem[]> bodysafetySettings = null, [WorkflowExpression] Func<int> bodygenerationConfigmaxOutputTokens = null, [WorkflowExpression] Func<double> bodygenerationConfigtemperature = null, [WorkflowExpression] Func<double> bodygenerationConfigtopP = null, [WorkflowExpression] Func<int> bodygenerationConfigtopK = null, [WorkflowExpression] Func<int> bodygenerationConfigcandidateCount = null, [WorkflowExpression] Func<string[]> bodygenerationConfigstopSequences = null)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            SourceExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            SourceExpression.Validate(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            SourceExpression.Validate(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            SourceExpression.Validate(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            SourceExpression.Validate(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            SourceExpression.Validate(bodygenerationConfigcandidateCount, nameof(bodygenerationConfigcandidateCount), required: false);
            SourceExpression.Validate(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:generateContent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = SourceExpressionConverter.ConvertToken(bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigcandidateCount != null)
                {
                    generationConfigObject["candidateCount"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigcandidateCount);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigstopSequences);
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
                return callPayload;
            }

            return new ApiConnectionAction<GenerateTextContentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateStreamContentResponseItem[]> GenerateStreamContent([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents = null, [WorkflowExpression] Func<bodysafetySettingsInputItem[]> bodysafetySettings = null, [WorkflowExpression] Func<double> bodygenerationConfigtemperature = null, [WorkflowExpression] Func<int> bodygenerationConfigmaxOutputTokens = null, [WorkflowExpression] Func<double> bodygenerationConfigtopP = null, [WorkflowExpression] Func<int> bodygenerationConfigtopK = null, [WorkflowExpression] Func<int> bodygenerationConfigcandidateCount = null, [WorkflowExpression] Func<string[]> bodygenerationConfigstopSequences = null)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            SourceExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            SourceExpression.Validate(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            SourceExpression.Validate(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            SourceExpression.Validate(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            SourceExpression.Validate(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            SourceExpression.Validate(bodygenerationConfigcandidateCount, nameof(bodygenerationConfigcandidateCount), required: false);
            SourceExpression.Validate(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:streamGenerateContent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = SourceExpressionConverter.ConvertToken(bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigcandidateCount != null)
                {
                    generationConfigObject["candidateCount"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigcandidateCount);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigstopSequences);
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
                return callPayload;
            }

            return new ApiConnectionAction<GenerateStreamContentResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateMultiModalContentResponse> GenerateMultiModalContent([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem2[]> bodycontents = null, [WorkflowExpression] Func<bodysafetySettingsInputItem[]> bodysafetySettings = null, [WorkflowExpression] Func<int> bodygenerationConfigmaxOutputTokens = null, [WorkflowExpression] Func<double> bodygenerationConfigtemperature = null, [WorkflowExpression] Func<double> bodygenerationConfigtopP = null, [WorkflowExpression] Func<int> bodygenerationConfigtopK = null, [WorkflowExpression] Func<string[]> bodygenerationConfigstopSequences = null)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            SourceExpression.Validate(bodysafetySettings, nameof(bodysafetySettings), required: false);
            SourceExpression.Validate(bodygenerationConfigmaxOutputTokens, nameof(bodygenerationConfigmaxOutputTokens), required: false);
            SourceExpression.Validate(bodygenerationConfigtemperature, nameof(bodygenerationConfigtemperature), required: false);
            SourceExpression.Validate(bodygenerationConfigtopP, nameof(bodygenerationConfigtopP), required: false);
            SourceExpression.Validate(bodygenerationConfigtopK, nameof(bodygenerationConfigtopK), required: false);
            SourceExpression.Validate(bodygenerationConfigstopSequences, nameof(bodygenerationConfigstopSequences), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}-vision:generateContent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                    bodypropCount++;
                }

                if (bodysafetySettings != null)
                {
                    body["safetySettings"] = SourceExpressionConverter.ConvertToken(bodysafetySettings);
                    bodypropCount++;
                }

                var generationConfigObject = new JObject();
                var generationConfigObjectpropCount = 0;
                if (bodygenerationConfigmaxOutputTokens != null)
                {
                    generationConfigObject["maxOutputTokens"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigmaxOutputTokens);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtemperature != null)
                {
                    generationConfigObject["temperature"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtemperature);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopP != null)
                {
                    generationConfigObject["topP"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtopP);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigtopK != null)
                {
                    generationConfigObject["topK"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigtopK);
                    generationConfigObjectpropCount++;
                }

                if (bodygenerationConfigstopSequences != null)
                {
                    generationConfigObject["stopSequences"] = SourceExpressionConverter.ConvertToken(bodygenerationConfigstopSequences);
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
                return callPayload;
            }

            return new ApiConnectionAction<GenerateMultiModalContentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<CountTokensResponse> CountTokens([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodycontentsInputItem22[]> bodycontents = null)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:countTokens", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontents != null)
                {
                    body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CountTokensResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetAllModelsResponse> GetAllModels([WorkflowExpression] Func<string> apiVersion)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllModelsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GetModelDetailsResponse> GetModelDetails([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetModelDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<GenerateEmbeddingResponse> GenerateEmbedding([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<string> bodymodelResourceName, [WorkflowExpression] Func<bodycontentpartsInputItem[]> bodycontentparts = null, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodymodelResourceName, nameof(bodymodelResourceName), required: true);
            SourceExpression.Validate(bodycontentparts, nameof(bodycontentparts), required: false);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:embedContent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodelResourceName);
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentparts != null)
                {
                    contentObject["parts"] = SourceExpressionConverter.ConvertToken(bodycontentparts);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateEmbeddingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlegemini")]
        public IBodyWorkflowAction<BatchEmbedContentsResponse> BatchEmbedContents([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> modelName, [WorkflowExpression] Func<bodyrequestsInputItem[]> bodyrequests)
        {
            SourceExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            SourceExpression.Validate(modelName, nameof(modelName), required: true);
            SourceExpression.Validate(bodyrequests, nameof(bodyrequests), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/models/{1}:batchEmbedContents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(apiVersion, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requests"] = SourceExpressionConverter.ConvertToken(bodyrequests);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BatchEmbedContentsResponse>(BuildSourceInput);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Openaigpt4ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ChatPostResponse> Chat([WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<string> bodystop = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodymaxTokens != null)
                {
                    body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodyn != null)
                {
                    body["n"] = SourceExpressionConverter.ConvertToken(bodyn);
                    bodypropCount++;
                }

                if (bodystop != null)
                {
                    body["stop"] = SourceExpressionConverter.ConvertToken(bodystop);
                    bodypropCount++;
                }

                if (bodypresencePenalty != null)
                {
                    body["presence_penalty"] = SourceExpressionConverter.ConvertToken(bodypresencePenalty);
                    bodypropCount++;
                }

                if (bodyfrequencyPenalty != null)
                {
                    body["frequency_penalty"] = SourceExpressionConverter.ConvertToken(bodyfrequencyPenalty);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChatPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ModelsGetResponse> ModelsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningPostResponse> FineTuning([WorkflowExpression] Func<string> bodytrainingFile, [WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyvalidationFile = null, [WorkflowExpression] Func<int> bodyhyperparametersnEpochs = null, [WorkflowExpression] Func<string> bodysuffix = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/fine_tuning/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["training_file"] = SourceExpressionConverter.ConvertToken(bodytrainingFile);
                if (bodyvalidationFile != null)
                {
                    body["validation_file"] = SourceExpressionConverter.ConvertToken(bodyvalidationFile);
                    bodypropCount++;
                }

                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                var hyperparametersObject = new JObject();
                var hyperparametersObjectpropCount = 0;
                if (bodyhyperparametersnEpochs != null)
                {
                    hyperparametersObject["n_epochs"] = SourceExpressionConverter.ConvertToken(bodyhyperparametersnEpochs);
                    hyperparametersObjectpropCount++;
                }

                if (hyperparametersObjectpropCount > 0)
                {
                    body["hyperparameters"] = hyperparametersObject;
                    bodypropCount++;
                }

                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FineTuningPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningGetResponse> FineTuningGet([WorkflowExpression] Func<string> fineTuningJobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/fine_tuning/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fineTuningJobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FineTuningGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningCancelPostResponse> FineTuningCancel([WorkflowExpression] Func<string> fineTuningJobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/fine_tuning/jobs/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fineTuningJobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FineTuningCancelPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningEventsGetResponse> FineTuningEventsGet([WorkflowExpression] Func<string> fineTuningJobId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/fine_tuning/jobs/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fineTuningJobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<FineTuningEventsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ModerationPostResponse> Moderation([WorkflowExpression] Func<string> bodyinput, [WorkflowExpression] Func<bodymodelInput> bodymodel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/moderations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                if (bodymodel != null)
                {
                    if (bodymodel != null)
                    {
                        body["model"] = SourceExpressionConverter.Convert(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "text-moderation-latest";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModerationPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<EmbedPostResponse> Embed([WorkflowExpression] Func<string> bodyinput, [WorkflowExpression] Func<string> bodymodel = null, [WorkflowExpression] Func<bodyencodingFormatInput> bodyencodingFormat = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                if (bodymodel != null)
                {
                    if (bodymodel != null)
                    {
                        body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "gpt-4-1106-preview";
                    bodypropCount++;
                }

                if (bodyencodingFormat != null)
                {
                    if (bodyencodingFormat != null)
                    {
                        body["encoding_format"] = SourceExpressionConverter.Convert(bodyencodingFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["encoding_format"] = "float";
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmbedPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<AudioSpeechPostResponse> AudioSpeech([WorkflowExpression] Func<bodymodelInput> bodymodel, [WorkflowExpression] Func<string> bodyinput, [WorkflowExpression] Func<bodyvoiceInput> bodyvoice, [WorkflowExpression] Func<bodyresponseFormatInput> bodyresponseFormat = null, [WorkflowExpression] Func<double> bodyspeed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/audio/speech";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.Convert(bodymodel);
                bodypropCount++;
                body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                bodypropCount++;
                body["voice"] = SourceExpressionConverter.Convert(bodyvoice);
                if (bodyresponseFormat != null)
                {
                    if (bodyresponseFormat != null)
                    {
                        body["response_format"] = SourceExpressionConverter.Convert(bodyresponseFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["response_format"] = "mp3";
                    bodypropCount++;
                }

                if (bodyspeed != null)
                {
                    if (bodyspeed != null)
                    {
                        body["speed"] = SourceExpressionConverter.ConvertToken(bodyspeed);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["speed"] = 1;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AudioSpeechPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ImagePostResponse> Image([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<bodymodelInput> bodymodel = null, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<bodyqualityInput> bodyquality = null, [WorkflowExpression] Func<bodysizeInput> bodysize = null, [WorkflowExpression] Func<bodystyleInput> bodystyle = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/images/generations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymodel != null)
                {
                    if (bodymodel != null)
                    {
                        body["model"] = SourceExpressionConverter.Convert(bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "dall-e-2";
                    bodypropCount++;
                }

                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodyn != null)
                {
                    body["n"] = SourceExpressionConverter.ConvertToken(bodyn);
                    bodypropCount++;
                }

                if (bodyquality != null)
                {
                    if (bodyquality != null)
                    {
                        body["quality"] = SourceExpressionConverter.Convert(bodyquality);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["quality"] = "standard";
                    bodypropCount++;
                }

                body["response_format"] = "url";
                bodypropCount++;
                if (bodysize != null)
                {
                    if (bodysize != null)
                    {
                        body["size"] = SourceExpressionConverter.Convert(bodysize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["size"] = "1024x1024";
                    bodypropCount++;
                }

                if (bodystyle != null)
                {
                    body["style"] = SourceExpressionConverter.Convert(bodystyle);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImagePostResponse>(BuildSourceInput);
        }
    }

    public class Openaigpt4ipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ChatPostResponse
    {
        [JsonProperty("first_content")]
        public string FirstContent { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("choices")]
        public ChatPostResponseChoicesTypeItem[] Choices { get; set; }

        [JsonProperty("usage")]
        public ChatPostResponseUsageType Usage { get; set; }
    }

    public class ChatPostResponseChoicesTypeItem
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("message")]
        public ChatPostResponseChoicesTypeItemMessageType Message { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }
    }

    public class ChatPostResponseChoicesTypeItemMessageType
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ChatPostResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class bodymessagesInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ModelsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public ModelsGetResponseDataTypeItem[] Data { get; set; }
    }

    public class ModelsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("owned_by")]
        public string OwnedBy { get; set; }

        [JsonProperty("permission")]
        public ModelsGetResponseDataTypeItemPermissionTypeItem[] Permission { get; set; }

        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    public class ModelsGetResponseDataTypeItemPermissionTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("allow_create_engine")]
        public bool AllowCreateEngine { get; set; }

        [JsonProperty("allow_sampling")]
        public bool AllowSampling { get; set; }

        [JsonProperty("allow_logprobs")]
        public bool AllowLogprobs { get; set; }

        [JsonProperty("allow_search_indices")]
        public bool AllowSearchIndices { get; set; }

        [JsonProperty("allow_view")]
        public bool AllowView { get; set; }

        [JsonProperty("allow_fine_tuning")]
        public bool AllowFineTuning { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("is_blocking")]
        public bool IsBlocking { get; set; }
    }

    public class FineTuningPostResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("fine_tuned_model")]
        public string FineTunedModel { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("result_files")]
        public string[] ResultFiles { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("validation_file")]
        public string ValidationFile { get; set; }

        [JsonProperty("training_file")]
        public string TrainingFile { get; set; }
    }

    public class FineTuningGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("finished_at")]
        public int FinishedAt { get; set; }

        [JsonProperty("fine_tuned_model")]
        public string FineTunedModel { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("result_files")]
        public string[] ResultFiles { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("validation_file")]
        public string ValidationFile { get; set; }

        [JsonProperty("training_file")]
        public string TrainingFile { get; set; }

        [JsonProperty("hyperparameters")]
        public FineTuningGetResponseHyperparametersType Hyperparameters { get; set; }

        [JsonProperty("trained_tokens")]
        public int TrainedTokens { get; set; }
    }

    public class FineTuningGetResponseHyperparametersType
    {
        [JsonProperty("n_epochs")]
        public int NEpochs { get; set; }
    }

    public class FineTuningCancelPostResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("fine_tuned_model")]
        public string FineTunedModel { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("result_files")]
        public string[] ResultFiles { get; set; }

        [JsonProperty("hyperparameters")]
        public FineTuningCancelPostResponseHyperparametersType Hyperparameters { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("validation_file")]
        public string ValidationFile { get; set; }

        [JsonProperty("training_file")]
        public string TrainingFile { get; set; }
    }

    public class FineTuningCancelPostResponseHyperparametersType
    {
        [JsonProperty("n_epochs")]
        public int NEpochs { get; set; }
    }

    public class FineTuningEventsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public FineTuningEventsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class FineTuningEventsGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ModerationPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("results")]
        public ModerationPostResponseResultsTypeItem[] Results { get; set; }
    }

    public class ModerationPostResponseResultsTypeItem
    {
        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        [JsonProperty("categories")]
        public ModerationPostResponseResultsTypeItemCategoriesType Categories { get; set; }

        [JsonProperty("category_scores")]
        public ModerationPostResponseResultsTypeItemCategoryScoresType CategoryScores { get; set; }
    }

    public class ModerationPostResponseResultsTypeItemCategoriesType
    {
        [JsonProperty("sexual")]
        public bool Sexual { get; set; }

        [JsonProperty("hate")]
        public bool Hate { get; set; }

        [JsonProperty("harassment")]
        public bool Harassment { get; set; }

        [JsonProperty("self-harm")]
        public bool SelfHarm { get; set; }

        [JsonProperty("sexual/minors")]
        public bool SexualMinors { get; set; }

        [JsonProperty("hate/threatening")]
        public bool HateThreatening { get; set; }

        [JsonProperty("violence/graphic")]
        public bool ViolenceGraphic { get; set; }

        [JsonProperty("self-harm/intent")]
        public bool SelfHarmIntent { get; set; }

        [JsonProperty("self-harm/instructions")]
        public bool SelfHarmInstructions { get; set; }

        [JsonProperty("harassment/threatening")]
        public bool HarassmentThreatening { get; set; }

        [JsonProperty("violence")]
        public bool Violence { get; set; }
    }

    public class ModerationPostResponseResultsTypeItemCategoryScoresType
    {
        [JsonProperty("sexual")]
        public double Sexual { get; set; }

        [JsonProperty("hate")]
        public double Hate { get; set; }

        [JsonProperty("harassment")]
        public double Harassment { get; set; }

        [JsonProperty("self-harm")]
        public double SelfHarm { get; set; }

        [JsonProperty("sexual/minors")]
        public double SexualMinors { get; set; }

        [JsonProperty("hate/threatening")]
        public double HateThreatening { get; set; }

        [JsonProperty("violence/graphic")]
        public double ViolenceGraphic { get; set; }

        [JsonProperty("self-harm/intent")]
        public double SelfHarmIntent { get; set; }

        [JsonProperty("self-harm/instructions")]
        public double SelfHarmInstructions { get; set; }

        [JsonProperty("harassment/threatening")]
        public double HarassmentThreatening { get; set; }

        [JsonProperty("violence")]
        public double Violence { get; set; }
    }

    public enum bodymodelInput
    {
        [EnumMember(Value = "dall-e-2")]
        DallE2,
        [EnumMember(Value = "dall-e-3")]
        DallE3
    }

    public class EmbedPostResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public EmbedPostResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("usage")]
        public EmbedPostResponseUsageType Usage { get; set; }
    }

    public class EmbedPostResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("embedding")]
        public double[] Embedding { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class EmbedPostResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public enum bodyencodingFormatInput
    {
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "base64")]
        Base64
    }

    public class AudioSpeechPostResponse
    {
        [JsonProperty("$content")]
        public string Content { get; set; }

        [JsonProperty("$content-type")]
        public string ContentType { get; set; }
    }

    public enum bodyvoiceInput
    {
        [EnumMember(Value = "alloy")]
        Alloy,
        [EnumMember(Value = "echo")]
        Echo,
        [EnumMember(Value = "fable")]
        Fable,
        [EnumMember(Value = "onyx")]
        Onyx,
        [EnumMember(Value = "nova")]
        Nova,
        [EnumMember(Value = "shimmer")]
        Shimmer
    }

    public enum bodyresponseFormatInput
    {
        [EnumMember(Value = "mp3")]
        Mp3,
        [EnumMember(Value = "opus")]
        Opus,
        [EnumMember(Value = "aac")]
        Aac,
        [EnumMember(Value = "flac")]
        Flac
    }

    public class ImagePostResponse
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("data")]
        public ImagePostResponseDataTypeItem[] Data { get; set; }
    }

    public class ImagePostResponseDataTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("revised_prompt")]
        public string RevisedPrompt { get; set; }
    }

    public enum bodyqualityInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "hd")]
        Hd
    }

    public enum bodysizeInput
    {
        [EnumMember(Value = "1024x1024")]
        _1024x1024,
        [EnumMember(Value = "256x256")]
        _256x256,
        [EnumMember(Value = "512x512")]
        _512x512,
        [EnumMember(Value = "1792x1024")]
        _1792x1024,
        [EnumMember(Value = "1024x1792")]
        _1024x1792
    }

    public enum bodystyleInput
    {
        [EnumMember(Value = "vivid")]
        Vivid,
        [EnumMember(Value = "natural")]
        Natural
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip;

    public partial class WorkflowManagedActions
    {
        public Openaigpt4ipActions Openaigpt4ip(string connectionId) => new Openaigpt4ipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Openaigpt4ipTriggers Openaigpt4ip(string connectionId) => new Openaigpt4ipTriggers(connectionId);
    }
}
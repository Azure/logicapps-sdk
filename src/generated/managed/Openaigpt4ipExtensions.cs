//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Openaigpt4ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ChatResponse, ApiConnectionActionConfiguration> Chat(Expression<Func<ChatBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ChatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ModelsGetResponse, ApiConnectionActionConfiguration> ModelsGet()
        {
            return new DeferredBodyAction<ModelsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningResponse, ApiConnectionActionConfiguration> FineTuning(Expression<Func<FineTuningBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FineTuningResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/fine_tuning/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FineTuningResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningGetResponse, ApiConnectionActionConfiguration> FineTuningGet(Expression<Func<string>> fineTuningJobId)
        {
            var __workflow_fineTuningJobId = WorkflowExpression.Compile(fineTuningJobId, nameof(fineTuningJobId), required: true);
            return new DeferredBodyAction<FineTuningGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/fine_tuning/jobs/{0}", __workflow_fineTuningJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FineTuningGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningCancelResponse, ApiConnectionActionConfiguration> FineTuningCancel(Expression<Func<string>> fineTuningJobId)
        {
            var __workflow_fineTuningJobId = WorkflowExpression.Compile(fineTuningJobId, nameof(fineTuningJobId), required: true);
            return new DeferredBodyAction<FineTuningCancelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/fine_tuning/jobs/{0}/cancel", __workflow_fineTuningJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FineTuningCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<FineTuningEventsGetResponse, ApiConnectionActionConfiguration> FineTuningEventsGet(Expression<Func<string>> fineTuningJobId, Expression<Func<string>> after = null, Expression<Func<int>> limit = null)
        {
            var __workflow_fineTuningJobId = WorkflowExpression.Compile(fineTuningJobId, nameof(fineTuningJobId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<FineTuningEventsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/fine_tuning/jobs/{0}/events", __workflow_fineTuningJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<FineTuningEventsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ModerationResponse, ApiConnectionActionConfiguration> Moderation(Expression<Func<ModerationBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ModerationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/moderations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModerationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<EmbedResponse, ApiConnectionActionConfiguration> Embed(Expression<Func<EmbedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmbedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmbedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<AudioSpeechResponse, ApiConnectionActionConfiguration> AudioSpeech(Expression<Func<AudioSpeechBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AudioSpeechResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/audio/speech";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AudioSpeechResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaigpt4ip")]
        public IBodyWorkflowAction<ImageResponse, ApiConnectionActionConfiguration> Image(Expression<Func<ImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/images/generations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImageResponse>(callPayload);
            });
        }
    }

    public class Openaigpt4ipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ChatResponse
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
        public ChatResponseChoicesTypeItem[] Choices { get; set; }

        [JsonProperty("usage")]
        public ChatResponseUsageType Usage { get; set; }
    }

    public class ChatResponseChoicesTypeItem
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("message")]
        public ChatResponseChoicesTypeItemMessageType Message { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }
    }

    public class ChatResponseChoicesTypeItemMessageType
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ChatResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class ChatBodyInput
    {
        public ChatBodyInput(BodyInputMessagesTypeItem[] messages)
        {
            this.Messages = messages;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "gpt-4-turbo";

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("top_p")]
        public double? TopP { get; set; }

        [JsonProperty("n")]
        public int? N { get; set; }

        [JsonProperty("stop")]
        public string Stop { get; set; }

        [JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        [JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class BodyInputMessagesTypeItem
    {
        public BodyInputMessagesTypeItem(string content)
        {
            this.Content = content;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; } = "user";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class FineTuningResponse
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

    public class FineTuningBodyInput
    {
        public FineTuningBodyInput(string trainingFile, string model)
        {
            this.TrainingFile = trainingFile;
            this.Model = model;
        }

        [JsonProperty("training_file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TrainingFile { get; set; }

        [JsonProperty("validation_file")]
        public string ValidationFile { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; }

        [JsonProperty("hyperparameters")]
        public BodyInputHyperparametersType Hyperparameters { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class BodyInputHyperparametersType
    {
        [JsonProperty("n_epochs")]
        public int? NEpochs { get; set; }
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

    public class FineTuningCancelResponse
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
        public FineTuningCancelResponseHyperparametersType Hyperparameters { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("validation_file")]
        public string ValidationFile { get; set; }

        [JsonProperty("training_file")]
        public string TrainingFile { get; set; }
    }

    public class FineTuningCancelResponseHyperparametersType
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

    public class ModerationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("results")]
        public ModerationResponseResultsTypeItem[] Results { get; set; }
    }

    public class ModerationResponseResultsTypeItem
    {
        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        [JsonProperty("categories")]
        public ModerationResponseResultsTypeItemCategoriesType Categories { get; set; }

        [JsonProperty("category_scores")]
        public ModerationResponseResultsTypeItemCategoryScoresType CategoryScores { get; set; }
    }

    public class ModerationResponseResultsTypeItemCategoriesType
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

    public class ModerationResponseResultsTypeItemCategoryScoresType
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

    public class ModerationBodyInput
    {
        public ModerationBodyInput(string input)
        {
            this.Input = input;
        }

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public ModerationBodyInputModelType? Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.ModerationBodyInputModelType.TextModerationLatest;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ModerationBodyInputModelType
    {
        [EnumMember(Value = "text-moderation-latest")]
        TextModerationLatest,
        [EnumMember(Value = "text-moderation-stable")]
        TextModerationStable
    }

    public class EmbedResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public EmbedResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("usage")]
        public EmbedResponseUsageType Usage { get; set; }
    }

    public class EmbedResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("embedding")]
        public double[] Embedding { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class EmbedResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class EmbedBodyInput
    {
        public EmbedBodyInput(string input)
        {
            this.Input = input;
        }

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "gpt-4-1106-preview";

        [JsonProperty("encoding_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEncodingFormatType? EncodingFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.BodyInputEncodingFormatType.Float;

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEncodingFormatType
    {
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "base64")]
        Base64
    }

    public class AudioSpeechResponse
    {
        [JsonProperty("$content")]
        public string Content { get; set; }

        [JsonProperty("$content-type")]
        public string ContentType { get; set; }
    }

    public class AudioSpeechBodyInput
    {
        public AudioSpeechBodyInput(string input)
        {
            this.Input = input;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public AudioSpeechBodyInputModelType Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.AudioSpeechBodyInputModelType.Tts1;

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; }

        [JsonProperty("voice", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputVoiceType Voice { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.BodyInputVoiceType.Alloy;

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.BodyInputResponseFormatType.Mp3;

        [JsonProperty("speed", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Speed { get; set; } = 1;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AudioSpeechBodyInputModelType
    {
        [EnumMember(Value = "tts-1")]
        Tts1,
        [EnumMember(Value = "tts-1-hd")]
        Tts1Hd
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputVoiceType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputResponseFormatType
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

    public class ImageResponse
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("data")]
        public ImageResponseDataTypeItem[] Data { get; set; }
    }

    public class ImageResponseDataTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("revised_prompt")]
        public string RevisedPrompt { get; set; }
    }

    public class ImageBodyInput
    {
        public ImageBodyInput(string prompt)
        {
            this.Prompt = prompt;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageBodyInputModelType? Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.ImageBodyInputModelType.DallE2;

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("n")]
        public int? N { get; set; }

        [JsonProperty("quality", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityType? Quality { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.BodyInputQualityType.Standard;

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResponseFormat { get; set; } = "url";

        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSizeType? Size { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openaigpt4ip.BodyInputSizeType._1024x1024;

        [JsonProperty("style")]
        public BodyInputStyleType? Style { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageBodyInputModelType
    {
        [EnumMember(Value = "dall-e-2")]
        DallE2,
        [EnumMember(Value = "dall-e-3")]
        DallE3
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputQualityType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "hd")]
        Hd
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSizeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStyleType
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
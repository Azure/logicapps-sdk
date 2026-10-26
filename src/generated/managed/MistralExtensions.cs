//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mistral
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MistralActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<ChatCompletionResponse, ApiConnectionActionConfiguration> CreateChatCompletion(Expression<Func<CreateChatCompletionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ChatCompletionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<EmbeddingResponse, ApiConnectionActionConfiguration> CreateEmbedding(Expression<Func<CreateEmbeddingInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmbeddingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmbeddingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<ModelList, ApiConnectionActionConfiguration> ListModels()
        {
            return new DeferredBodyAction<ModelList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelList>(callPayload);
            });
        }
    }

    public class MistralTriggers([ConnectionName] string connectionId)
    {
    }

    public class ChatCompletionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("choices")]
        public ChatCompletionResponseChoicesTypeItem[] Choices { get; set; }

        [JsonProperty("usage")]
        public ChatCompletionResponseUsageType Usage { get; set; }
    }

    public class ChatCompletionResponseChoicesTypeItem
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("message")]
        public ChatCompletionResponseChoicesTypeItemMessageType Message { get; set; }

        [JsonProperty("finish_reason")]
        public ChatCompletionResponseChoicesTypeItemFinishReasonType FinishReason { get; set; }
    }

    public class ChatCompletionResponseChoicesTypeItemMessageType
    {
        [JsonProperty("role")]
        public ChatCompletionResponseChoicesTypeItemMessageTypeRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatCompletionResponseChoicesTypeItemMessageTypeRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChatCompletionResponseChoicesTypeItemFinishReasonType
    {
        [EnumMember(Value = "stop")]
        Stop,
        [EnumMember(Value = "length")]
        Length,
        [EnumMember(Value = "model_length")]
        ModelLength
    }

    public class ChatCompletionResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class CreateChatCompletionInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; }

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateChatCompletionInputMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 0.7;

        [JsonProperty("top_p", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TopP { get; set; } = 1;

        [JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        [JsonProperty("stream", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Stream { get; set; } = false;

        [JsonProperty("safe_prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SafePrompt { get; set; } = false;

        [JsonProperty("random_seed")]
        public int? RandomSeed { get; set; }
    }

    public class CreateChatCompletionInputMessagesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateChatCompletionInputMessagesTypeItemRoleType? Role { get; set; } = CreateChatCompletionInputMessagesTypeItemRoleType.User;

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateChatCompletionInputMessagesTypeItemRoleType
    {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant,
        [EnumMember(Value = "tool")]
        Tool
    }

    public class EmbeddingResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public EmbeddingResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("usage")]
        public EmbeddingResponseUsageType Usage { get; set; }
    }

    public class EmbeddingResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("embedding")]
        public double[] Embedding { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class EmbeddingResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class CreateEmbeddingInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "mistral-embed";

        [JsonProperty("input")]
        public string[] Input { get; set; }

        [JsonProperty("encoding_format")]
        public CreateEmbeddingInputEncodingFormatType? EncodingFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddingInputEncodingFormatType
    {
        [EnumMember(Value = "float")]
        Float
    }

    public class ModelList
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public Model[] Data { get; set; }
    }

    public class Model
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("owned_by")]
        public string OwnedBy { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mistral;

    public partial class WorkflowManagedActions
    {
        public MistralActions Mistral(string connectionId) => new MistralActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MistralTriggers Mistral(string connectionId) => new MistralTriggers(connectionId);
    }
}
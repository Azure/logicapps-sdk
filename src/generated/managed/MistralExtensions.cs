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
        public IBodyWorkflowAction<ChatCompletionResponse, ApiConnectionActionConfiguration> CreateChatCompletion(Expression<Func<string>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<bool>> bodystream = null, Expression<Func<bool>> bodysafePrompt = null, Expression<Func<int>> bodyrandomSeed = null)
        {
            var __workflow_bodymodel = WorkflowExpression.Compile(bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: true);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodytopP = WorkflowExpression.Compile(bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodymaxTokens = WorkflowExpression.Compile(bodymaxTokens, nameof(bodymaxTokens), required: false);
            var __workflow_bodystream = WorkflowExpression.Compile(bodystream, nameof(bodystream), required: false);
            var __workflow_bodysafePrompt = WorkflowExpression.Compile(bodysafePrompt, nameof(bodysafePrompt), required: false);
            var __workflow_bodyrandomSeed = WorkflowExpression.Compile(bodyrandomSeed, nameof(bodyrandomSeed), required: false);
            return new DeferredBodyAction<ChatCompletionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                if (__workflow_bodytemperature != null)
                {
                    if (__workflow_bodytemperature != null)
                    {
                        body["temperature"] = ExpressionConverter.ConvertO(__workflow_bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 0.7;
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    if (__workflow_bodytopP != null)
                    {
                        body["top_p"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["top_p"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodymaxTokens != null)
                {
                    body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
                    bodypropCount++;
                }

                if (__workflow_bodystream != null)
                {
                    if (__workflow_bodystream != null)
                    {
                        body["stream"] = ExpressionConverter.ConvertO(__workflow_bodystream);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["stream"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodysafePrompt != null)
                {
                    if (__workflow_bodysafePrompt != null)
                    {
                        body["safe_prompt"] = ExpressionConverter.ConvertO(__workflow_bodysafePrompt);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["safe_prompt"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyrandomSeed != null)
                {
                    body["random_seed"] = ExpressionConverter.ConvertO(__workflow_bodyrandomSeed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<EmbeddingResponse, ApiConnectionActionConfiguration> CreateEmbedding(Expression<Func<string>> bodymodel = null, Expression<Func<string[]>> bodyinput = null, Expression<Func<bodyencodingFormatInput>> bodyencodingFormat = null)
        {
            var __workflow_bodymodel = WorkflowExpression.Compile(bodymodel, nameof(bodymodel), required: false);
            var __workflow_bodyinput = WorkflowExpression.Compile(bodyinput, nameof(bodyinput), required: false);
            var __workflow_bodyencodingFormat = WorkflowExpression.Compile(bodyencodingFormat, nameof(bodyencodingFormat), required: false);
            return new DeferredBodyAction<EmbeddingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymodel != null)
                {
                    if (__workflow_bodymodel != null)
                    {
                        body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["model"] = "mistral-embed";
                    bodypropCount++;
                }

                if (__workflow_bodyinput != null)
                {
                    body["input"] = ExpressionConverter.ConvertO(__workflow_bodyinput);
                    bodypropCount++;
                }

                if (__workflow_bodyencodingFormat != null)
                {
                    body["encoding_format"] = ExpressionConverter.ConvertO(__workflow_bodyencodingFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class bodymessagesInputItem
    {
        [JsonProperty("role")]
        public bodymessagesInputItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymessagesInputItemRoleType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyencodingFormatInput
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
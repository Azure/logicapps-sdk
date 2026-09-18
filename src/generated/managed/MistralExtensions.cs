//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mistral
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MistralActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<ChatCompletionResponse> CreateChatCompletion([WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<bool> bodystream = null, [WorkflowExpression] Func<bool> bodysafePrompt = null, [WorkflowExpression] Func<int> bodyrandomSeed = null)
        {
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            SourceExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            SourceExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            SourceExpression.Validate(bodymaxTokens, nameof(bodymaxTokens), required: false);
            SourceExpression.Validate(bodystream, nameof(bodystream), required: false);
            SourceExpression.Validate(bodysafePrompt, nameof(bodysafePrompt), required: false);
            SourceExpression.Validate(bodyrandomSeed, nameof(bodyrandomSeed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 0.7;
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    if (bodytopP != null)
                    {
                        body["top_p"] = SourceExpressionConverter.ConvertToken(bodytopP);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["top_p"] = 1;
                    bodypropCount++;
                }

                if (bodymaxTokens != null)
                {
                    body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                    bodypropCount++;
                }

                if (bodystream != null)
                {
                    if (bodystream != null)
                    {
                        body["stream"] = SourceExpressionConverter.ConvertToken(bodystream);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["stream"] = false;
                    bodypropCount++;
                }

                if (bodysafePrompt != null)
                {
                    if (bodysafePrompt != null)
                    {
                        body["safe_prompt"] = SourceExpressionConverter.ConvertToken(bodysafePrompt);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["safe_prompt"] = false;
                    bodypropCount++;
                }

                if (bodyrandomSeed != null)
                {
                    body["random_seed"] = SourceExpressionConverter.ConvertToken(bodyrandomSeed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChatCompletionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<EmbeddingResponse> CreateEmbedding([WorkflowExpression] Func<string> bodymodel = null, [WorkflowExpression] Func<string[]> bodyinput = null, [WorkflowExpression] Func<bodyencodingFormatInput> bodyencodingFormat = null)
        {
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            SourceExpression.Validate(bodyinput, nameof(bodyinput), required: false);
            SourceExpression.Validate(bodyencodingFormat, nameof(bodyencodingFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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
                    body["model"] = "mistral-embed";
                    bodypropCount++;
                }

                if (bodyinput != null)
                {
                    body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                    bodypropCount++;
                }

                if (bodyencodingFormat != null)
                {
                    body["encoding_format"] = SourceExpressionConverter.Convert(bodyencodingFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmbeddingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mistral")]
        public IBodyWorkflowAction<ModelList> ListModels()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelList>(BuildSourceInput);
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

    public enum ChatCompletionResponseChoicesTypeItemMessageTypeRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

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
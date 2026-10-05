//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        [WorkflowExpressionFactory(nameof(__BuildChatCompletion))]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion([WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<string[]> bodystop = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChatCompletionResponse> __BuildChatCompletion(WorkflowValue<string> bodymodel, WorkflowValue<bodymessagesInputItem[]> bodymessages, WorkflowValue<int> bodyn = null, WorkflowValue<double> bodytemperature = null, WorkflowValue<int> bodymaxTokens = null, WorkflowValue<double> bodytopP = null, WorkflowValue<double> bodyfrequencyPenalty = null, WorkflowValue<double> bodypresencePenalty = null, WorkflowValue<string[]> bodystop = null)
        {
            WorkflowValue.Validate(bodymodel, nameof(bodymodel), required: true);
            WorkflowValue.Validate(bodymessages, nameof(bodymessages), required: true);
            WorkflowValue.Validate(bodyn, nameof(bodyn), required: false);
            WorkflowValue.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowValue.Validate(bodymaxTokens, nameof(bodymaxTokens), required: false);
            WorkflowValue.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowValue.Validate(bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            WorkflowValue.Validate(bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            WorkflowValue.Validate(bodystop, nameof(bodystop), required: false);
            return new DeferredBodyAction<ChatCompletionResponse>(() =>
            {
                var apiCallPath = "/v1/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(bodymessages);
                if (bodyn != null)
                {
                    if (bodyn != null)
                    {
                        body["n"] = ExpressionConverter.ConvertO(bodyn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["n"] = 1;
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 1;
                    bodypropCount++;
                }

                if (bodymaxTokens != null)
                {
                    body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(bodytopP);
                    bodypropCount++;
                }

                if (bodyfrequencyPenalty != null)
                {
                    if (bodyfrequencyPenalty != null)
                    {
                        body["frequency_penalty"] = ExpressionConverter.ConvertO(bodyfrequencyPenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["frequency_penalty"] = 0;
                    bodypropCount++;
                }

                if (bodypresencePenalty != null)
                {
                    if (bodypresencePenalty != null)
                    {
                        body["presence_penalty"] = ExpressionConverter.ConvertO(bodypresencePenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["presence_penalty"] = 0;
                    bodypropCount++;
                }

                if (bodystop != null)
                {
                    body["stop"] = ExpressionConverter.ConvertO(bodystop);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        [WorkflowExpressionFactory(nameof(__BuildEmbeddings))]
        public IBodyWorkflowAction<EmbeddingsResponse> Embeddings([WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyinput)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmbeddingsResponse> __BuildEmbeddings(WorkflowValue<string> bodymodel, WorkflowValue<string> bodyinput)
        {
            WorkflowValue.Validate(bodymodel, nameof(bodymodel), required: true);
            WorkflowValue.Validate(bodyinput, nameof(bodyinput), required: true);
            return new DeferredBodyAction<EmbeddingsResponse>(() =>
            {
                var apiCallPath = "/v1/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                bodypropCount++;
                body["input"] = ExpressionConverter.ConvertO(bodyinput);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmbeddingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateImage))]
        public IBodyWorkflowAction<CreateImageResponse> CreateImage([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<bodysizeInput> bodysize = null, [WorkflowExpression] Func<bodyresponseFormatInput> bodyresponseFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateImageResponse> __BuildCreateImage(WorkflowValue<string> bodyprompt, WorkflowValue<int> bodyn = null, WorkflowValue<bodysizeInput> bodysize = null, WorkflowValue<bodyresponseFormatInput> bodyresponseFormat = null)
        {
            WorkflowValue.Validate(bodyprompt, nameof(bodyprompt), required: true);
            WorkflowValue.Validate(bodyn, nameof(bodyn), required: false);
            WorkflowValue.Validate(bodysize, nameof(bodysize), required: false);
            WorkflowValue.Validate(bodyresponseFormat, nameof(bodyresponseFormat), required: false);
            return new DeferredBodyAction<CreateImageResponse>(() =>
            {
                var apiCallPath = "/v1/images/generations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                if (bodyn != null)
                {
                    if (bodyn != null)
                    {
                        body["n"] = ExpressionConverter.ConvertO(bodyn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["n"] = 1;
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    if (bodysize != null)
                    {
                        body["size"] = ExpressionConverter.ConvertO(bodysize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["size"] = "1024x1024";
                    bodypropCount++;
                }

                if (bodyresponseFormat != null)
                {
                    if (bodyresponseFormat != null)
                    {
                        body["response_format"] = ExpressionConverter.ConvertO(bodyresponseFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["response_format"] = "url";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        [WorkflowExpressionFactory(nameof(__BuildCompletion))]
        public IBodyWorkflowAction<CompletionV2Response> Completion([WorkflowExpression] Func<bodyengineInput> bodyengine, [WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<int> bodybestOf = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<string[]> bodystop = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompletionV2Response> __BuildCompletion(WorkflowValue<bodyengineInput> bodyengine, WorkflowValue<string> bodyprompt, WorkflowValue<int> bodyn = null, WorkflowValue<int> bodybestOf = null, WorkflowValue<double> bodytemperature = null, WorkflowValue<int> bodymaxTokens = null, WorkflowValue<double> bodytopP = null, WorkflowValue<double> bodyfrequencyPenalty = null, WorkflowValue<double> bodypresencePenalty = null, WorkflowValue<string[]> bodystop = null)
        {
            WorkflowValue.Validate(bodyengine, nameof(bodyengine), required: true);
            WorkflowValue.Validate(bodyprompt, nameof(bodyprompt), required: true);
            WorkflowValue.Validate(bodyn, nameof(bodyn), required: false);
            WorkflowValue.Validate(bodybestOf, nameof(bodybestOf), required: false);
            WorkflowValue.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowValue.Validate(bodymaxTokens, nameof(bodymaxTokens), required: false);
            WorkflowValue.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowValue.Validate(bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            WorkflowValue.Validate(bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            WorkflowValue.Validate(bodystop, nameof(bodystop), required: false);
            return new DeferredBodyAction<CompletionV2Response>(() =>
            {
                var apiCallPath = "/v1/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodyengine);
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                if (bodyn != null)
                {
                    if (bodyn != null)
                    {
                        body["n"] = ExpressionConverter.ConvertO(bodyn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["n"] = 1;
                    bodypropCount++;
                }

                if (bodybestOf != null)
                {
                    if (bodybestOf != null)
                    {
                        body["best_of"] = ExpressionConverter.ConvertO(bodybestOf);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["best_of"] = 1;
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 1;
                    bodypropCount++;
                }

                if (bodymaxTokens != null)
                {
                    if (bodymaxTokens != null)
                    {
                        body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_tokens"] = 100;
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(bodytopP);
                    bodypropCount++;
                }

                if (bodyfrequencyPenalty != null)
                {
                    if (bodyfrequencyPenalty != null)
                    {
                        body["frequency_penalty"] = ExpressionConverter.ConvertO(bodyfrequencyPenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["frequency_penalty"] = 0;
                    bodypropCount++;
                }

                if (bodypresencePenalty != null)
                {
                    if (bodypresencePenalty != null)
                    {
                        body["presence_penalty"] = ExpressionConverter.ConvertO(bodypresencePenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["presence_penalty"] = 0;
                    bodypropCount++;
                }

                if (bodystop != null)
                {
                    body["stop"] = ExpressionConverter.ConvertO(bodystop);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CompletionV2Response>(callPayload);
            });
        }
    }

    public class OpenaiipTriggers([ConnectionName] string connectionId)
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
        public string FinishReason { get; set; }
    }

    public class ChatCompletionResponseChoicesTypeItemMessageType
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
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
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class EmbeddingsResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public EmbeddingsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("usage")]
        public EmbeddingsResponseUsageType Usage { get; set; }
    }

    public class EmbeddingsResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("embedding")]
        public double[] Embedding { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class EmbeddingsResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class CreateImageResponse
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("data")]
        public CreateImageResponseDataTypeItem[] Data { get; set; }
    }

    public class CreateImageResponseDataTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("b64_json")]
        public string B64Json { get; set; }
    }

    public enum bodysizeInput
    {
        [EnumMember(Value = "256x256")]
        _256x256,
        [EnumMember(Value = "512x512")]
        _512x512,
        [EnumMember(Value = "1024x1024")]
        _1024x1024
    }

    public enum bodyresponseFormatInput
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "b64_json")]
        B64Json
    }

    public class CompletionV2Response
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
        public CompletionV2ResponseChoicesTypeItem[] Choices { get; set; }
    }

    public class CompletionV2ResponseChoicesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("usage")]
        public CompletionV2ResponseChoicesTypeItemUsageType Usage { get; set; }
    }

    public class CompletionV2ResponseChoicesTypeItemUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public enum bodyengineInput
    {
        [EnumMember(Value = "text-davinci-002")]
        DaVinciMostExpensive,
        [EnumMember(Value = "text-curie-001")]
        Curie,
        [EnumMember(Value = "text-babbage-001")]
        Babbage,
        [EnumMember(Value = "text-ada-001")]
        AdaCheapest
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openaiip;

    public partial class WorkflowManagedActions
    {
        public OpenaiipActions Openaiip(string connectionId) => new OpenaiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenaiipTriggers Openaiip(string connectionId) => new OpenaiipTriggers(connectionId);
    }
}

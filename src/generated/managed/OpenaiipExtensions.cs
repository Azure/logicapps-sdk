//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion([WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<string[]> bodystop = null)
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
                if (bodyn != null)
                {
                    if (bodyn != null)
                    {
                        body["n"] = SourceExpressionConverter.ConvertToken(bodyn);
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
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
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
                    body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodyfrequencyPenalty != null)
                {
                    if (bodyfrequencyPenalty != null)
                    {
                        body["frequency_penalty"] = SourceExpressionConverter.ConvertToken(bodyfrequencyPenalty);
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
                        body["presence_penalty"] = SourceExpressionConverter.ConvertToken(bodypresencePenalty);
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
                    body["stop"] = SourceExpressionConverter.ConvertToken(bodystop);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<EmbeddingsResponse> Embeddings([WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyinput)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                bodypropCount++;
                body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmbeddingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<CreateImageResponse> CreateImage([WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<bodysizeInput> bodysize = null, [WorkflowExpression] Func<bodyresponseFormatInput> bodyresponseFormat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/images/generations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodyn != null)
                {
                    if (bodyn != null)
                    {
                        body["n"] = SourceExpressionConverter.ConvertToken(bodyn);
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
                    body["response_format"] = "url";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<CompletionV2Response> Completion([WorkflowExpression] Func<bodyengineInput> bodyengine, [WorkflowExpression] Func<string> bodyprompt, [WorkflowExpression] Func<int> bodyn = null, [WorkflowExpression] Func<int> bodybestOf = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<string[]> bodystop = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.Convert(bodyengine);
                bodypropCount++;
                body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                if (bodyn != null)
                {
                    if (bodyn != null)
                    {
                        body["n"] = SourceExpressionConverter.ConvertToken(bodyn);
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
                        body["best_of"] = SourceExpressionConverter.ConvertToken(bodybestOf);
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
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
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
                        body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
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
                    body["top_p"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodyfrequencyPenalty != null)
                {
                    if (bodyfrequencyPenalty != null)
                    {
                        body["frequency_penalty"] = SourceExpressionConverter.ConvertToken(bodyfrequencyPenalty);
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
                        body["presence_penalty"] = SourceExpressionConverter.ConvertToken(bodypresencePenalty);
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
                    body["stop"] = SourceExpressionConverter.ConvertToken(bodystop);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CompletionV2Response>(BuildSourceInput);
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
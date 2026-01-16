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
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion(Expression<Func<string>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages, Expression<Func<int>> bodyn = null, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<double>> bodyfrequencyPenalty = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<string[]>> bodystop = null)
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
                body["n"] = ExpressionConverter.ConvertO(bodyn);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
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
                body["frequency_penalty"] = ExpressionConverter.ConvertO(bodyfrequencyPenalty);
                bodypropCount++;
            }

            if (bodypresencePenalty != null)
            {
                body["presence_penalty"] = ExpressionConverter.ConvertO(bodypresencePenalty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<CompletionV2Response> CompletionV2(Expression<Func<bodyengineInput>> bodyengine, Expression<Func<string>> bodyprompt, Expression<Func<int>> bodyn = null, Expression<Func<int>> bodybestOf = null, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<double>> bodyfrequencyPenalty = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<string[]>> bodystop = null)
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
                body["n"] = ExpressionConverter.ConvertO(bodyn);
                bodypropCount++;
            }

            if (bodybestOf != null)
            {
                body["best_of"] = ExpressionConverter.ConvertO(bodybestOf);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
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
                body["frequency_penalty"] = ExpressionConverter.ConvertO(bodyfrequencyPenalty);
                bodypropCount++;
            }

            if (bodypresencePenalty != null)
            {
                body["presence_penalty"] = ExpressionConverter.ConvertO(bodypresencePenalty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<EmbeddingsResponse> Embeddings(Expression<Func<string>> bodymodel, Expression<Func<string>> bodyinput)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<CreateImageResponse> CreateImage(Expression<Func<string>> bodyprompt, Expression<Func<int>> bodyn = null, Expression<Func<bodysizeInput>> bodysize = null, Expression<Func<bodyresponseFormatInput>> bodyresponseFormat = null)
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
                body["n"] = ExpressionConverter.ConvertO(bodyn);
                bodypropCount++;
            }

            if (bodysize != null)
            {
                body["size"] = ExpressionConverter.ConvertO(bodysize);
                bodypropCount++;
            }

            if (bodyresponseFormat != null)
            {
                body["response_format"] = ExpressionConverter.ConvertO(bodyresponseFormat);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateImageResponse>(callPayload);
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
        public string Object { get; set; }

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

    public class CompletionV2Response
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

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

    public class EmbeddingsResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
        public string Object { get; set; }

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
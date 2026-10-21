//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion(Expression<Func<string>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages, Expression<Func<int>> bodyn = null, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<double>> bodyfrequencyPenalty = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<string[]>> bodystop = null)
        {
            var __workflow_bodymodel = WorkflowExpression.Compile(bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: true);
            var __workflow_bodyn = WorkflowExpression.Compile(bodyn, nameof(bodyn), required: false);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodymaxTokens = WorkflowExpression.Compile(bodymaxTokens, nameof(bodymaxTokens), required: false);
            var __workflow_bodytopP = WorkflowExpression.Compile(bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodyfrequencyPenalty = WorkflowExpression.Compile(bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            var __workflow_bodypresencePenalty = WorkflowExpression.Compile(bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            var __workflow_bodystop = WorkflowExpression.Compile(bodystop, nameof(bodystop), required: false);
            return new DeferredBodyAction<ChatCompletionResponse>(() =>
            {
                var apiCallPath = "/v1/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                if (__workflow_bodyn != null)
                {
                    if (__workflow_bodyn != null)
                    {
                        body["n"] = ExpressionConverter.ConvertO(__workflow_bodyn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["n"] = 1;
                    bodypropCount++;
                }

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
                    body["temperature"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodymaxTokens != null)
                {
                    body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                    bodypropCount++;
                }

                if (__workflow_bodyfrequencyPenalty != null)
                {
                    if (__workflow_bodyfrequencyPenalty != null)
                    {
                        body["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_bodyfrequencyPenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["frequency_penalty"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodypresencePenalty != null)
                {
                    if (__workflow_bodypresencePenalty != null)
                    {
                        body["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_bodypresencePenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["presence_penalty"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodystop != null)
                {
                    body["stop"] = ExpressionConverter.ConvertO(__workflow_bodystop);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<EmbeddingsResponse> Embeddings(Expression<Func<string>> bodymodel, Expression<Func<string>> bodyinput)
        {
            var __workflow_bodymodel = WorkflowExpression.Compile(bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodyinput = WorkflowExpression.Compile(bodyinput, nameof(bodyinput), required: true);
            return new DeferredBodyAction<EmbeddingsResponse>(() =>
            {
                var apiCallPath = "/v1/embeddings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                bodypropCount++;
                body["input"] = ExpressionConverter.ConvertO(__workflow_bodyinput);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmbeddingsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<CreateImageResponse> CreateImage(Expression<Func<string>> bodyprompt, Expression<Func<int>> bodyn = null, Expression<Func<bodysizeInput>> bodysize = null, Expression<Func<bodyresponseFormatInput>> bodyresponseFormat = null)
        {
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodyn = WorkflowExpression.Compile(bodyn, nameof(bodyn), required: false);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: false);
            var __workflow_bodyresponseFormat = WorkflowExpression.Compile(bodyresponseFormat, nameof(bodyresponseFormat), required: false);
            return new DeferredBodyAction<CreateImageResponse>(() =>
            {
                var apiCallPath = "/v1/images/generations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (__workflow_bodyn != null)
                {
                    if (__workflow_bodyn != null)
                    {
                        body["n"] = ExpressionConverter.ConvertO(__workflow_bodyn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["n"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodysize != null)
                {
                    if (__workflow_bodysize != null)
                    {
                        body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["size"] = "1024x1024";
                    bodypropCount++;
                }

                if (__workflow_bodyresponseFormat != null)
                {
                    if (__workflow_bodyresponseFormat != null)
                    {
                        body["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyresponseFormat);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiip")]
        public IBodyWorkflowAction<CompletionV2Response> Completion(Expression<Func<bodyengineInput>> bodyengine, Expression<Func<string>> bodyprompt, Expression<Func<int>> bodyn = null, Expression<Func<int>> bodybestOf = null, Expression<Func<double>> bodytemperature = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<double>> bodytopP = null, Expression<Func<double>> bodyfrequencyPenalty = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<string[]>> bodystop = null)
        {
            var __workflow_bodyengine = WorkflowExpression.Compile(bodyengine, nameof(bodyengine), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: true);
            var __workflow_bodyn = WorkflowExpression.Compile(bodyn, nameof(bodyn), required: false);
            var __workflow_bodybestOf = WorkflowExpression.Compile(bodybestOf, nameof(bodybestOf), required: false);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodymaxTokens = WorkflowExpression.Compile(bodymaxTokens, nameof(bodymaxTokens), required: false);
            var __workflow_bodytopP = WorkflowExpression.Compile(bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodyfrequencyPenalty = WorkflowExpression.Compile(bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            var __workflow_bodypresencePenalty = WorkflowExpression.Compile(bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            var __workflow_bodystop = WorkflowExpression.Compile(bodystop, nameof(bodystop), required: false);
            return new DeferredBodyAction<CompletionV2Response>(() =>
            {
                var apiCallPath = "/v1/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodyengine);
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (__workflow_bodyn != null)
                {
                    if (__workflow_bodyn != null)
                    {
                        body["n"] = ExpressionConverter.ConvertO(__workflow_bodyn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["n"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodybestOf != null)
                {
                    if (__workflow_bodybestOf != null)
                    {
                        body["best_of"] = ExpressionConverter.ConvertO(__workflow_bodybestOf);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["best_of"] = 1;
                    bodypropCount++;
                }

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
                    body["temperature"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodymaxTokens != null)
                {
                    if (__workflow_bodymaxTokens != null)
                    {
                        body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_tokens"] = 100;
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                    bodypropCount++;
                }

                if (__workflow_bodyfrequencyPenalty != null)
                {
                    if (__workflow_bodyfrequencyPenalty != null)
                    {
                        body["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_bodyfrequencyPenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["frequency_penalty"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodypresencePenalty != null)
                {
                    if (__workflow_bodypresencePenalty != null)
                    {
                        body["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_bodypresencePenalty);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["presence_penalty"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodystop != null)
                {
                    body["stop"] = ExpressionConverter.ConvertO(__workflow_bodystop);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CompletionV2Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysizeInput
    {
        [EnumMember(Value = "256x256")]
        _256x256,
        [EnumMember(Value = "512x512")]
        _512x512,
        [EnumMember(Value = "1024x1024")]
        _1024x1024
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

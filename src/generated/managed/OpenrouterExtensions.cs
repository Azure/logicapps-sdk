//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openrouter
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenrouterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openrouter")]
        public IBodyWorkflowAction<GetCreditsResponse> GetCredits()
        {
            var apiCallPath = "/v1/credits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCreditsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openrouter")]
        public IBodyWorkflowAction<ListModelEndpointsResponse> ListModelEndpoints(Expression<Func<string>> author, Expression<Func<string>> slug)
        {
            var __workflow_author = WorkflowExpression.Compile(author, nameof(author), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            return new DeferredBodyAction<ListModelEndpointsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/models/{0}/{1}/endpoints", __workflow_author.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListModelEndpointsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openrouter")]
        public IBodyWorkflowAction<ListModelsResponse> ListModels()
        {
            var apiCallPath = "/v1/models";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListModelsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openrouter")]
        public IBodyWorkflowAction<GetGenerationResponse> GetGeneration(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetGenerationResponse>(() =>
            {
                var apiCallPath = "/v1/generation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetGenerationResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openrouter")]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion(Expression<Func<string>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages)
        {
            var __workflow_bodymodel = WorkflowExpression.Compile(bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: true);
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
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openrouter")]
        public IBodyWorkflowAction<CompletionResponse> Completion(Expression<Func<string>> bodymodel, Expression<Func<string>> bodyprompt)
        {
            var __workflow_bodymodel = WorkflowExpression.Compile(bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodyprompt = WorkflowExpression.Compile(bodyprompt, nameof(bodyprompt), required: true);
            return new DeferredBodyAction<CompletionResponse>(() =>
            {
                var apiCallPath = "/v1/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                bodypropCount++;
                body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CompletionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class OpenrouterTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCreditsResponse
    {
        [JsonProperty("data")]
        public GetCreditsResponseDataType Data { get; set; }
    }

    public class GetCreditsResponseDataType
    {
        [JsonProperty("total_credits")]
        public double TotalCredits { get; set; }

        [JsonProperty("total_usage")]
        public double TotalUsage { get; set; }
    }

    public class ListModelEndpointsResponse
    {
        [JsonProperty("data")]
        public ListModelEndpointsResponseDataType Data { get; set; }
    }

    public class ListModelEndpointsResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("architecture")]
        public ListModelEndpointsResponseDataTypeArchitectureType Architecture { get; set; }

        [JsonProperty("endpoints")]
        public ListModelEndpointsResponseDataTypeEndpointsTypeItem[] Endpoints { get; set; }
    }

    public class ListModelEndpointsResponseDataTypeArchitectureType
    {
        [JsonProperty("tokenizer")]
        public string Tokenizer { get; set; }

        [JsonProperty("instruct_type")]
        public string InstructType { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }
    }

    public class ListModelEndpointsResponseDataTypeEndpointsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("context_length")]
        public double ContextLength { get; set; }

        [JsonProperty("pricing")]
        public ListModelEndpointsResponseDataTypeEndpointsTypeItemPricingType Pricing { get; set; }

        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }

        [JsonProperty("supported_parameters")]
        public string[] SupportedParameters { get; set; }
    }

    public class ListModelEndpointsResponseDataTypeEndpointsTypeItemPricingType
    {
        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("completion")]
        public string Completion { get; set; }
    }

    public class ListModelsResponse
    {
        [JsonProperty("data")]
        public ListModelsResponseDataTypeItem[] Data { get; set; }
    }

    public class ListModelsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("pricing")]
        public ListModelsResponseDataTypeItemPricingType Pricing { get; set; }
    }

    public class ListModelsResponseDataTypeItemPricingType
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("completion")]
        public string Completion { get; set; }
    }

    public class GetGenerationResponse
    {
        [JsonProperty("data")]
        public GetGenerationResponseDataType Data { get; set; }
    }

    public class GetGenerationResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("usage")]
        public double Usage { get; set; }

        [JsonProperty("is_byok")]
        public bool IsByok { get; set; }

        [JsonProperty("upstream_id")]
        public string UpstreamId { get; set; }

        [JsonProperty("cache_discount")]
        public double CacheDiscount { get; set; }

        [JsonProperty("app_id")]
        public int AppId { get; set; }

        [JsonProperty("streamed")]
        public bool Streamed { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }

        [JsonProperty("latency")]
        public int Latency { get; set; }

        [JsonProperty("moderation_latency")]
        public int ModerationLatency { get; set; }

        [JsonProperty("generation_time")]
        public int GenerationTime { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("native_finish_reason")]
        public string NativeFinishReason { get; set; }

        [JsonProperty("tokens_prompt")]
        public int TokensPrompt { get; set; }

        [JsonProperty("tokens_completion")]
        public int TokensCompletion { get; set; }

        [JsonProperty("native_tokens_prompt")]
        public int NativeTokensPrompt { get; set; }

        [JsonProperty("native_tokens_completion")]
        public int NativeTokensCompletion { get; set; }

        [JsonProperty("native_tokens_reasoning")]
        public int NativeTokensReasoning { get; set; }

        [JsonProperty("num_media_prompt")]
        public int NumMediaPrompt { get; set; }

        [JsonProperty("num_media_completion")]
        public int NumMediaCompletion { get; set; }

        [JsonProperty("num_search_results")]
        public int NumSearchResults { get; set; }
    }

    public class ChatCompletionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("choices")]
        public ChatCompletionResponseChoicesTypeItem[] Choices { get; set; }
    }

    public class ChatCompletionResponseChoicesTypeItem
    {
        [JsonProperty("message")]
        public ChatCompletionResponseChoicesTypeItemMessageType Message { get; set; }
    }

    public class ChatCompletionResponseChoicesTypeItemMessageType
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
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
        Assistant
    }

    public class CompletionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("choices")]
        public CompletionResponseChoicesTypeItem[] Choices { get; set; }
    }

    public class CompletionResponseChoicesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openrouter;

    public partial class WorkflowManagedActions
    {
        public OpenrouterActions Openrouter(string connectionId) => new OpenrouterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenrouterTriggers Openrouter(string connectionId) => new OpenrouterTriggers(connectionId);
    }
}

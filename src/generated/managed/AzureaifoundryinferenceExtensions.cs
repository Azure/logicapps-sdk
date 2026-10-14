//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaifoundryinference
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzureaifoundryinferenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaifoundryinference")]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion(Expression<Func<string>> apiVersion = null, Expression<Func<bodymessagesInputItem[]>> bodymessages = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodytopP = null, Expression<Func<int>> bodymaxTokens = null, Expression<Func<string>> bodymodel = null)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: false);
            var __workflow_bodymessages = bodymessages == null ? null : WorkflowExpression.Compile(bodymessages);
            WorkflowExpression.Validate(__workflow_bodymessages, nameof(bodymessages), required: false);
            var __workflow_bodytemperature = bodytemperature == null ? null : WorkflowExpression.Compile(bodytemperature);
            WorkflowExpression.Validate(__workflow_bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodytopP = bodytopP == null ? null : WorkflowExpression.Compile(bodytopP);
            WorkflowExpression.Validate(__workflow_bodytopP, nameof(bodytopP), required: false);
            var __workflow_bodymaxTokens = bodymaxTokens == null ? null : WorkflowExpression.Compile(bodymaxTokens);
            WorkflowExpression.Validate(__workflow_bodymaxTokens, nameof(bodymaxTokens), required: false);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: false);
            return new DeferredBodyAction<ChatCompletionResponse>(() =>
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_apiVersion != null)
                    callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessages != null)
                {
                    body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                    bodypropCount++;
                }

                if (__workflow_bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(__workflow_bodytemperature);
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                    bodypropCount++;
                }

                if (__workflow_bodymaxTokens != null)
                {
                    body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
                    bodypropCount++;
                }

                if (__workflow_bodymodel != null)
                {
                    body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            });
        }
    }

    public class AzureaifoundryinferenceTriggers([ConnectionName] string connectionId)
    {
    }

    public class ChatCompletionResponse
    {
        [JsonProperty("choices")]
        public Choice[] Choices { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("prompt_filter_results")]
        public PromptFilterResult[] PromptFilterResults { get; set; }

        [JsonProperty("usage")]
        public Usage Usage { get; set; }
    }

    public class Choice
    {
        [JsonProperty("content_filter_results")]
        public JToken ContentFilterResults { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("logprobs")]
        public string Logprobs { get; set; }

        [JsonProperty("message")]
        public ChoiceMessageType Message { get; set; }
    }

    public class ChoiceMessageType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("refusal")]
        public string Refusal { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class PromptFilterResult
    {
        [JsonProperty("prompt_index")]
        public int PromptIndex { get; set; }

        [JsonProperty("content_filter_results")]
        public JToken ContentFilterResults { get; set; }
    }

    public class Usage
    {
        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("completion_tokens_details")]
        public CompletionTokensDetails CompletionTokensDetails { get; set; }

        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("prompt_tokens_details")]
        public PromptTokensDetails PromptTokensDetails { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class CompletionTokensDetails
    {
        [JsonProperty("accepted_prediction_tokens")]
        public int AcceptedPredictionTokens { get; set; }

        [JsonProperty("reasoning_tokens")]
        public int ReasoningTokens { get; set; }

        [JsonProperty("rejected_prediction_tokens")]
        public int RejectedPredictionTokens { get; set; }
    }

    public class PromptTokensDetails
    {
        [JsonProperty("cached_tokens")]
        public int CachedTokens { get; set; }
    }

    public class bodymessagesInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public JToken[] Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureaifoundryinference;

    public partial class WorkflowManagedActions
    {
        public AzureaifoundryinferenceActions Azureaifoundryinference(string connectionId) => new AzureaifoundryinferenceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureaifoundryinferenceTriggers Azureaifoundryinference(string connectionId) => new AzureaifoundryinferenceTriggers(connectionId);
    }
}

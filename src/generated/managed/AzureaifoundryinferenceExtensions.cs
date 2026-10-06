//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaifoundryinference
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaifoundryinferenceActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaifoundryinference")]
        [WorkflowExpressionFactory(nameof(__BuildChatCompletion))]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion([WorkflowExpression] Func<string> apiVersion = null, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<string> bodymodel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaifoundryinference")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChatCompletionResponse> __BuildChatCompletion(WorkflowExpression<string> apiVersion = null, WorkflowExpression<bodymessagesInputItem[]> bodymessages = null, WorkflowExpression<double> bodytemperature = null, WorkflowExpression<double> bodytopP = null, WorkflowExpression<int> bodymaxTokens = null, WorkflowExpression<string> bodymodel = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: false);
            WorkflowExpression.Validate(bodymessages, nameof(bodymessages), required: false);
            WorkflowExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            WorkflowExpression.Validate(bodymaxTokens, nameof(bodymaxTokens), required: false);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            return new DeferredBodyAction<ChatCompletionResponse>(() =>
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apiVersion != null)
                    callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessages != null)
                {
                    body["messages"] = ExpressionConverter.ConvertO(bodymessages);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(bodytopP);
                    bodypropCount++;
                }

                if (bodymaxTokens != null)
                {
                    body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
                    bodypropCount++;
                }

                if (bodymodel != null)
                {
                    body["model"] = ExpressionConverter.ConvertO(bodymodel);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Perplexityai
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PerplexityaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perplexityai")]
        public IBodyWorkflowAction<CompletionResponse, ApiConnectionActionConfiguration> Completion(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CompletionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CompletionResponse>(callPayload);
            });
        }
    }

    public class PerplexityaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompletionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("choices")]
        public CompletionResponseChoicesTypeItem[] Choices { get; set; }

        [JsonProperty("usage")]
        public CompletionResponseUsageType Usage { get; set; }
    }

    public class CompletionResponseChoicesTypeItem
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("message")]
        public CompletionResponseChoicesTypeItemMessageType Message { get; set; }

        [JsonProperty("delta")]
        public CompletionResponseChoicesTypeItemDeltaType Delta { get; set; }
    }

    public class CompletionResponseChoicesTypeItemMessageType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class CompletionResponseChoicesTypeItemDeltaType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class CompletionResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputModelType Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Perplexityai.BodyInputModelType.Mistral7bInstruct;

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("top_p")]
        public double? TopP { get; set; }

        [JsonProperty("top_k")]
        public double? TopK { get; set; }

        [JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        [JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputModelType
    {
        [EnumMember(Value = "mistral-7b-instruct")]
        Mistral7bInstruct,
        [EnumMember(Value = "sonar-small-chat")]
        SonarSmallChat,
        [EnumMember(Value = "sonar-small-online")]
        SonarSmallOnline,
        [EnumMember(Value = "sonar-medium-chat")]
        SonarMediumChat,
        [EnumMember(Value = "sonar-medium-online")]
        SonarMediumOnline,
        [EnumMember(Value = "mixtral-8x7b-instruct")]
        Mixtral8x7bInstruct
    }

    public class BodyInputMessagesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMessagesTypeItemRoleType Role { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Perplexityai.BodyInputMessagesTypeItemRoleType.System;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputMessagesTypeItemRoleType
    {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Perplexityai;

    public partial class WorkflowManagedActions
    {
        public PerplexityaiActions Perplexityai(string connectionId) => new PerplexityaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PerplexityaiTriggers Perplexityai(string connectionId) => new PerplexityaiTriggers(connectionId);
    }
}
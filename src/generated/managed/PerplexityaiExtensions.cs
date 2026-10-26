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
        public IBodyWorkflowAction<CompletionPostResponse, ApiConnectionActionConfiguration> Completion(Expression<Func<CompletionPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CompletionPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CompletionPostResponse>(callPayload);
            });
        }
    }

    public class PerplexityaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompletionPostResponse
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
        public CompletionPostResponseChoicesTypeItem[] Choices { get; set; }

        [JsonProperty("usage")]
        public CompletionPostResponseUsageType Usage { get; set; }
    }

    public class CompletionPostResponseChoicesTypeItem
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("message")]
        public CompletionPostResponseChoicesTypeItemMessageType Message { get; set; }

        [JsonProperty("delta")]
        public CompletionPostResponseChoicesTypeItemDeltaType Delta { get; set; }
    }

    public class CompletionPostResponseChoicesTypeItemMessageType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class CompletionPostResponseChoicesTypeItemDeltaType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class CompletionPostResponseUsageType
    {
        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class CompletionPostInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompletionPostInputModelType Model { get; set; } = CompletionPostInputModelType.Mistral7bInstruct;

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompletionPostInputMessagesTypeItem[] Messages { get; set; }

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
    public enum CompletionPostInputModelType
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

    public class CompletionPostInputMessagesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompletionPostInputMessagesTypeItemRoleType Role { get; set; } = CompletionPostInputMessagesTypeItemRoleType.System;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompletionPostInputMessagesTypeItemRoleType
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
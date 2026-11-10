//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnthropicipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anthropicip")]
        public IBodyWorkflowAction<MessageResponse, ApiConnectionActionConfiguration> Message(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["anthropic-version"] = Convert.ToString("2023-06-01");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessageResponse>(callPayload);
            });
        }
    }

    public class AnthropicipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MessageResponse
    {
        [JsonProperty("content")]
        public MessageResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("stop_reason")]
        public string StopReason { get; set; }

        [JsonProperty("stop_sequence")]
        public string StopSequence { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public MessageResponseUsageType Usage { get; set; }
    }

    public class MessageResponseContentTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("thinking")]
        public string Thinking { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("input")]
        public JToken Input { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MessageResponseUsageType
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(BodyInputMessagesTypeItem[] messages)
        {
            this.Messages = messages;
        }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputModelType Model { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip.BodyInputModelType.ClaudeOpus40;

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("max_tokens", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MaxTokens { get; set; } = 100;

        [JsonProperty("thinking")]
        public BodyInputThinkingType Thinking { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("stop_sequences")]
        public string[] StopSequences { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("tools")]
        public BodyInputToolsTypeItem[] Tools { get; set; }

        [JsonProperty("top_k")]
        public int? TopK { get; set; }

        [JsonProperty("top_p")]
        public double? TopP { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputModelType
    {
        [EnumMember(Value = "claude-opus-4-0")]
        ClaudeOpus40,
        [EnumMember(Value = "claude-sonnet-4-0")]
        ClaudeSonnet40,
        [EnumMember(Value = "claude-3-7-sonnet-latest")]
        Claude37SonnetLatest,
        [EnumMember(Value = "claude-3-5-sonnet-latest")]
        Claude35SonnetLatest,
        [EnumMember(Value = "claude-3-5-haiku-latest")]
        Claude35HaikuLatest,
        [EnumMember(Value = "claude-3-opus-latest")]
        Claude3OpusLatest
    }

    public class BodyInputMessagesTypeItem
    {
        public BodyInputMessagesTypeItem(string content)
        {
            this.Content = content;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMessagesTypeItemRoleType Role { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip.BodyInputMessagesTypeItemRoleType.User;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputMessagesTypeItemRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class BodyInputThinkingType
    {
        [JsonProperty("type")]
        public bool? Type { get; set; }

        [JsonProperty("budget_tokens")]
        public int? BudgetTokens { get; set; }
    }

    public class BodyInputToolsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("input_schema")]
        public JToken InputSchema { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip;

    public partial class WorkflowManagedActions
    {
        public AnthropicipActions Anthropicip(string connectionId) => new AnthropicipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnthropicipTriggers Anthropicip(string connectionId) => new AnthropicipTriggers(connectionId);
    }
}
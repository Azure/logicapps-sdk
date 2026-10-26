//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bastiongpt
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BastiongptActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<AskQuestionResponse, ApiConnectionActionConfiguration> AskQuestion(Expression<Func<AskQuestionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AskQuestionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Ask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AskQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<ChatCompletionResponse, ApiConnectionActionConfiguration> ChatCompletion(Expression<Func<ChatCompletionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ChatCompletionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ChatCompletion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatCompletionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<TranscriptResponse, ApiConnectionActionConfiguration> GetTranscript(Expression<Func<string>> transcriptId)
        {
            var __workflow_transcriptId = WorkflowExpression.Compile(transcriptId, nameof(transcriptId), required: true);
            return new DeferredBodyAction<TranscriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/TranscribeFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["transcriptId"] = ExpressionConverter.Convert(__workflow_transcriptId);
                return new ApiConnectionAction<TranscriptResponse>(callPayload);
            });
        }
    }

    public class BastiongptTriggers([ConnectionName] string connectionId)
    {
    }

    public class AskQuestionResponse
    {
        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("finish_reason")]
        public string FinishReason { get; set; }

        [JsonProperty("response_id")]
        public string ResponseId { get; set; }

        [JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class AskQuestionInput
    {
        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("max_tokens", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MaxTokens { get; set; } = 1000;

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 0;
    }

    public class ChatCompletionResponse
    {
        [JsonProperty("choices")]
        public Choice[] Choices { get; set; }

        [JsonProperty("id")]
        public string ResponseId { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("usage")]
        public Usage Usage { get; set; }
    }

    public class Choice
    {
        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }

        [JsonProperty("message")]
        public ChoiceMessageType Message { get; set; }
    }

    public class ChoiceMessageType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class Usage
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("completionTokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }
    }

    public class ChatCompletionInput
    {
        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public Message[] Messages { get; set; }

        [JsonProperty("max_tokens", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MaxTokens { get; set; } = 1000;

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 0;

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }
    }

    public class Message
    {
        [JsonProperty("role")]
        public MessageRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageRoleType
    {
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class TranscriptResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("segments")]
        public TranscriptSegment[] Segments { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class TranscriptSegment
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("speaker")]
        public string Speaker { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bastiongpt;

    public partial class WorkflowManagedActions
    {
        public BastiongptActions Bastiongpt(string connectionId) => new BastiongptActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BastiongptTriggers Bastiongpt(string connectionId) => new BastiongptTriggers(connectionId);
    }
}
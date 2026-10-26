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
        public IBodyWorkflowAction<AskQuestionResponse, ApiConnectionActionConfiguration> AskQuestion(Expression<Func<string>> bodyquestion, Expression<Func<int>> bodymaxTokens, Expression<Func<string>> bodyinstructions = null, Expression<Func<string>> bodydocumentId = null, Expression<Func<double>> bodytemperature = null)
        {
            var __workflow_bodyquestion = WorkflowExpression.Compile(bodyquestion, nameof(bodyquestion), required: true);
            var __workflow_bodymaxTokens = WorkflowExpression.Compile(bodymaxTokens, nameof(bodymaxTokens), required: true);
            var __workflow_bodyinstructions = WorkflowExpression.Compile(bodyinstructions, nameof(bodyinstructions), required: false);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: false);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            return new DeferredBodyAction<AskQuestionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Ask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = ExpressionConverter.ConvertO(__workflow_bodyquestion);
                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentId != null)
                {
                    body["document_id"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
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
                    body["temperature"] = 0;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AskQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<ChatCompletionResponse, ApiConnectionActionConfiguration> ChatCompletion(Expression<Func<Message[]>> bodymessages, Expression<Func<int>> bodymaxTokens, Expression<Func<double>> bodytemperature = null, Expression<Func<string>> bodydocumentId = null)
        {
            var __workflow_bodymessages = WorkflowExpression.Compile(bodymessages, nameof(bodymessages), required: true);
            var __workflow_bodymaxTokens = WorkflowExpression.Compile(bodymaxTokens, nameof(bodymaxTokens), required: true);
            var __workflow_bodytemperature = WorkflowExpression.Compile(bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: false);
            return new DeferredBodyAction<ChatCompletionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ChatCompletion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                bodypropCount++;
                body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
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
                    body["temperature"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodydocumentId != null)
                {
                    body["document_id"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
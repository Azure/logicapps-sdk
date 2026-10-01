//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bastiongpt
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BastiongptActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<AskQuestionResponse> AskQuestion([WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<int> bodymaxTokens, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<string> bodydocumentId = null, [WorkflowExpression] Func<double> bodytemperature = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Ask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodydocumentId != null)
                {
                    body["document_id"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
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
                return callPayload;
            }

            return new ApiConnectionAction<AskQuestionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<ChatCompletionResponse> ChatCompletion([WorkflowExpression] Func<Message[]> bodymessages, [WorkflowExpression] Func<int> bodymaxTokens, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<string> bodydocumentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ChatCompletion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                bodypropCount++;
                body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                if (bodytemperature != null)
                {
                    if (bodytemperature != null)
                    {
                        body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["temperature"] = 0;
                    bodypropCount++;
                }

                if (bodydocumentId != null)
                {
                    body["document_id"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChatCompletionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bastiongpt")]
        public IBodyWorkflowAction<TranscriptResponse> GetTranscript([WorkflowExpression] Func<string> transcriptId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get/TranscribeFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["transcriptId"] = SourceExpressionConverter.ConvertO(transcriptId);
                return callPayload;
            }

            return new ApiConnectionAction<TranscriptResponse>(BuildSourceInput);
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
        public string ResponseID { get; set; }

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
        public string ResponseID { get; set; }

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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Perplexityai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PerplexityaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perplexityai")]
        public IBodyWorkflowAction<CompletionPostResponse> Completion([WorkflowExpression] Func<bodymodelInput> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<int> bodymaxTokens = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<double> bodytopP = null, [WorkflowExpression] Func<double> bodytopK = null, [WorkflowExpression] Func<double> bodypresencePenalty = null, [WorkflowExpression] Func<double> bodyfrequencyPenalty = null)
        {
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            SourceExpression.Validate(bodymaxTokens, nameof(bodymaxTokens), required: false);
            SourceExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            SourceExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            SourceExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            SourceExpression.Validate(bodypresencePenalty, nameof(bodypresencePenalty), required: false);
            SourceExpression.Validate(bodyfrequencyPenalty, nameof(bodyfrequencyPenalty), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chat/completions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.Convert(bodymodel);
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodymaxTokens != null)
                {
                    body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodytopK != null)
                {
                    body["top_k"] = SourceExpressionConverter.ConvertToken(bodytopK);
                    bodypropCount++;
                }

                if (bodypresencePenalty != null)
                {
                    body["presence_penalty"] = SourceExpressionConverter.ConvertToken(bodypresencePenalty);
                    bodypropCount++;
                }

                if (bodyfrequencyPenalty != null)
                {
                    body["frequency_penalty"] = SourceExpressionConverter.ConvertToken(bodyfrequencyPenalty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CompletionPostResponse>(BuildSourceInput);
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

    public enum bodymodelInput
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

    public class bodymessagesInputItem
    {
        [JsonProperty("role")]
        public bodymessagesInputItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public enum bodymessagesInputItemRoleType
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
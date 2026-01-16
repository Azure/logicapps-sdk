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
        public IBodyWorkflowAction<CompletionPostResponse> CompletionPost(Expression<Func<bodymodelInput>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages, Expression<Func<int>> bodymaxTokens = null, Expression<Func<double>> bodytemperature = null, Expression<Func<double>> bodytopP = null, Expression<Func<double>> bodytopK = null, Expression<Func<double>> bodypresencePenalty = null, Expression<Func<double>> bodyfrequencyPenalty = null)
        {
            var apiCallPath = "/chat/completions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["model"] = ExpressionConverter.ConvertO(bodymodel);
            bodypropCount++;
            body["messages"] = ExpressionConverter.ConvertO(bodymessages);
            if (bodymaxTokens != null)
            {
                body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
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

            if (bodytopK != null)
            {
                body["top_k"] = ExpressionConverter.ConvertO(bodytopK);
                bodypropCount++;
            }

            if (bodypresencePenalty != null)
            {
                body["presence_penalty"] = ExpressionConverter.ConvertO(bodypresencePenalty);
                bodypropCount++;
            }

            if (bodyfrequencyPenalty != null)
            {
                body["frequency_penalty"] = ExpressionConverter.ConvertO(bodyfrequencyPenalty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CompletionPostResponse>(callPayload);
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
        public string Object { get; set; }

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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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
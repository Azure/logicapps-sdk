//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnthropicipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anthropicip")]
        public IBodyWorkflowAction<MessagePostResponse> Message(Expression<Func<bodymodelInput>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages, Expression<Func<int>> bodymaxTokens, Expression<Func<bool>> bodythinkingtype = null, Expression<Func<int>> bodythinkingbudgetTokens = null, Expression<Func<string[]>> bodystopSequences = null, Expression<Func<string>> bodysystem = null, Expression<Func<double>> bodytemperature = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null, Expression<Func<int>> bodytopK = null, Expression<Func<double>> bodytopP = null)
        {
            var apiCallPath = "/v1/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["anthropic-version"] = Convert.ToString("2023-06-01");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["model"] = ExpressionConverter.ConvertO(bodymodel);
            bodypropCount++;
            body["messages"] = ExpressionConverter.ConvertO(bodymessages);
            bodypropCount++;
            body["max_tokens"] = ExpressionConverter.ConvertO(bodymaxTokens);
            var thinkingObject = new JObject();
            var thinkingObjectpropCount = 0;
            if (bodythinkingtype != null)
            {
                thinkingObject["type"] = ExpressionConverter.ConvertO(bodythinkingtype);
                thinkingObjectpropCount++;
            }

            if (bodythinkingbudgetTokens != null)
            {
                thinkingObject["budget_tokens"] = ExpressionConverter.ConvertO(bodythinkingbudgetTokens);
                thinkingObjectpropCount++;
            }

            if (thinkingObjectpropCount > 0)
            {
                body["thinking"] = thinkingObject;
                bodypropCount++;
            }

            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            if (bodystopSequences != null)
            {
                body["stop_sequences"] = ExpressionConverter.ConvertO(bodystopSequences);
                bodypropCount++;
            }

            if (bodysystem != null)
            {
                body["system"] = ExpressionConverter.ConvertO(bodysystem);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = ExpressionConverter.ConvertO(bodytemperature);
                bodypropCount++;
            }

            if (bodytools != null)
            {
                body["tools"] = ExpressionConverter.ConvertO(bodytools);
                bodypropCount++;
            }

            if (bodytopK != null)
            {
                body["top_k"] = ExpressionConverter.ConvertO(bodytopK);
                bodypropCount++;
            }

            if (bodytopP != null)
            {
                body["top_p"] = ExpressionConverter.ConvertO(bodytopP);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MessagePostResponse>(callPayload);
        }
    }

    public class AnthropicipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MessagePostResponse
    {
        [JsonProperty("content")]
        public MessagePostResponseContentTypeItem[] Content { get; set; }

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
        public MessagePostResponseUsageType Usage { get; set; }
    }

    public class MessagePostResponseContentTypeItem
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

    public class MessagePostResponseUsageType
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }
    }

    public enum bodymodelInput
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

    public class bodymessagesInputItem
    {
        [JsonProperty("role")]
        public bodymessagesInputItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public enum bodymessagesInputItemRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class bodytoolsInputItem
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
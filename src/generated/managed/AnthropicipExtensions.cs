//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AnthropicipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anthropicip")]
        public IBodyWorkflowAction<MessagePostResponse> Message(Expression<Func<bodymodelInput>> bodymodel, Expression<Func<bodymessagesInputItem[]>> bodymessages, Expression<Func<int>> bodymaxTokens, Expression<Func<bool>> bodythinkingtype = null, Expression<Func<int>> bodythinkingbudgetTokens = null, Expression<Func<string[]>> bodystopSequences = null, Expression<Func<string>> bodysystem = null, Expression<Func<double>> bodytemperature = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null, Expression<Func<int>> bodytopK = null, Expression<Func<double>> bodytopP = null)
        {
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodymessages = bodymessages == null ? null : WorkflowExpression.Compile(bodymessages);
            WorkflowExpression.Validate(__workflow_bodymessages, nameof(bodymessages), required: true);
            var __workflow_bodymaxTokens = bodymaxTokens == null ? null : WorkflowExpression.Compile(bodymaxTokens);
            WorkflowExpression.Validate(__workflow_bodymaxTokens, nameof(bodymaxTokens), required: true);
            var __workflow_bodythinkingtype = bodythinkingtype == null ? null : WorkflowExpression.Compile(bodythinkingtype);
            WorkflowExpression.Validate(__workflow_bodythinkingtype, nameof(bodythinkingtype), required: false);
            var __workflow_bodythinkingbudgetTokens = bodythinkingbudgetTokens == null ? null : WorkflowExpression.Compile(bodythinkingbudgetTokens);
            WorkflowExpression.Validate(__workflow_bodythinkingbudgetTokens, nameof(bodythinkingbudgetTokens), required: false);
            var __workflow_bodystopSequences = bodystopSequences == null ? null : WorkflowExpression.Compile(bodystopSequences);
            WorkflowExpression.Validate(__workflow_bodystopSequences, nameof(bodystopSequences), required: false);
            var __workflow_bodysystem = bodysystem == null ? null : WorkflowExpression.Compile(bodysystem);
            WorkflowExpression.Validate(__workflow_bodysystem, nameof(bodysystem), required: false);
            var __workflow_bodytemperature = bodytemperature == null ? null : WorkflowExpression.Compile(bodytemperature);
            WorkflowExpression.Validate(__workflow_bodytemperature, nameof(bodytemperature), required: false);
            var __workflow_bodytools = bodytools == null ? null : WorkflowExpression.Compile(bodytools);
            WorkflowExpression.Validate(__workflow_bodytools, nameof(bodytools), required: false);
            var __workflow_bodytopK = bodytopK == null ? null : WorkflowExpression.Compile(bodytopK);
            WorkflowExpression.Validate(__workflow_bodytopK, nameof(bodytopK), required: false);
            var __workflow_bodytopP = bodytopP == null ? null : WorkflowExpression.Compile(bodytopP);
            WorkflowExpression.Validate(__workflow_bodytopP, nameof(bodytopP), required: false);
            return new DeferredBodyAction<MessagePostResponse>(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["anthropic-version"] = Convert.ToString("2023-06-01");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                bodypropCount++;
                body["max_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxTokens);
                var thinkingObject = new JObject();
                var thinkingObjectpropCount = 0;
                if (__workflow_bodythinkingtype != null)
                {
                    thinkingObject["type"] = ExpressionConverter.ConvertO(__workflow_bodythinkingtype);
                    thinkingObjectpropCount++;
                }

                if (__workflow_bodythinkingbudgetTokens != null)
                {
                    thinkingObject["budget_tokens"] = ExpressionConverter.ConvertO(__workflow_bodythinkingbudgetTokens);
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

                if (__workflow_bodystopSequences != null)
                {
                    body["stop_sequences"] = ExpressionConverter.ConvertO(__workflow_bodystopSequences);
                    bodypropCount++;
                }

                if (__workflow_bodysystem != null)
                {
                    body["system"] = ExpressionConverter.ConvertO(__workflow_bodysystem);
                    bodypropCount++;
                }

                if (__workflow_bodytemperature != null)
                {
                    body["temperature"] = ExpressionConverter.ConvertO(__workflow_bodytemperature);
                    bodypropCount++;
                }

                if (__workflow_bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(__workflow_bodytools);
                    bodypropCount++;
                }

                if (__workflow_bodytopK != null)
                {
                    body["top_k"] = ExpressionConverter.ConvertO(__workflow_bodytopK);
                    bodypropCount++;
                }

                if (__workflow_bodytopP != null)
                {
                    body["top_p"] = ExpressionConverter.ConvertO(__workflow_bodytopP);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

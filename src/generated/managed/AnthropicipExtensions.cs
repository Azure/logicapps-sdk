//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anthropicip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnthropicipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anthropicip")]
        [WorkflowExpressionFactory(nameof(__BuildMessage))]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<bodymodelInput> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<int> bodymaxTokens, [WorkflowExpression] Func<bool> bodythinkingtype = null, [WorkflowExpression] Func<int> bodythinkingbudgetTokens = null, [WorkflowExpression] Func<string[]> bodystopSequences = null, [WorkflowExpression] Func<string> bodysystem = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<double> bodytopP = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessagePostResponse> __BuildMessage(WorkflowValue<bodymodelInput> bodymodel, WorkflowValue<bodymessagesInputItem[]> bodymessages, WorkflowValue<int> bodymaxTokens, WorkflowValue<bool> bodythinkingtype = null, WorkflowValue<int> bodythinkingbudgetTokens = null, WorkflowValue<string[]> bodystopSequences = null, WorkflowValue<string> bodysystem = null, WorkflowValue<double> bodytemperature = null, WorkflowValue<bodytoolsInputItem[]> bodytools = null, WorkflowValue<int> bodytopK = null, WorkflowValue<double> bodytopP = null)
        {
            WorkflowValue.Validate(bodymodel, nameof(bodymodel), required: true);
            WorkflowValue.Validate(bodymessages, nameof(bodymessages), required: true);
            WorkflowValue.Validate(bodymaxTokens, nameof(bodymaxTokens), required: true);
            WorkflowValue.Validate(bodythinkingtype, nameof(bodythinkingtype), required: false);
            WorkflowValue.Validate(bodythinkingbudgetTokens, nameof(bodythinkingbudgetTokens), required: false);
            WorkflowValue.Validate(bodystopSequences, nameof(bodystopSequences), required: false);
            WorkflowValue.Validate(bodysystem, nameof(bodysystem), required: false);
            WorkflowValue.Validate(bodytemperature, nameof(bodytemperature), required: false);
            WorkflowValue.Validate(bodytools, nameof(bodytools), required: false);
            WorkflowValue.Validate(bodytopK, nameof(bodytopK), required: false);
            WorkflowValue.Validate(bodytopP, nameof(bodytopP), required: false);
            return new DeferredBodyAction<MessagePostResponse>(() =>
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

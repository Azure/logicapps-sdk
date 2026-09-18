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
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<bodymodelInput> bodymodel, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages, [WorkflowExpression] Func<int> bodymaxTokens, [WorkflowExpression] Func<bool> bodythinkingtype = null, [WorkflowExpression] Func<int> bodythinkingbudgetTokens = null, [WorkflowExpression] Func<string[]> bodystopSequences = null, [WorkflowExpression] Func<string> bodysystem = null, [WorkflowExpression] Func<double> bodytemperature = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<double> bodytopP = null)
        {
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            SourceExpression.Validate(bodymaxTokens, nameof(bodymaxTokens), required: true);
            SourceExpression.Validate(bodythinkingtype, nameof(bodythinkingtype), required: false);
            SourceExpression.Validate(bodythinkingbudgetTokens, nameof(bodythinkingbudgetTokens), required: false);
            SourceExpression.Validate(bodystopSequences, nameof(bodystopSequences), required: false);
            SourceExpression.Validate(bodysystem, nameof(bodysystem), required: false);
            SourceExpression.Validate(bodytemperature, nameof(bodytemperature), required: false);
            SourceExpression.Validate(bodytools, nameof(bodytools), required: false);
            SourceExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            SourceExpression.Validate(bodytopP, nameof(bodytopP), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["anthropic-version"] = Convert.ToString("2023-06-01");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.Convert(bodymodel);
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                bodypropCount++;
                body["max_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxTokens);
                var thinkingObject = new JObject();
                var thinkingObjectpropCount = 0;
                if (bodythinkingtype != null)
                {
                    thinkingObject["type"] = SourceExpressionConverter.ConvertToken(bodythinkingtype);
                    thinkingObjectpropCount++;
                }

                if (bodythinkingbudgetTokens != null)
                {
                    thinkingObject["budget_tokens"] = SourceExpressionConverter.ConvertToken(bodythinkingbudgetTokens);
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
                    body["stop_sequences"] = SourceExpressionConverter.ConvertToken(bodystopSequences);
                    bodypropCount++;
                }

                if (bodysystem != null)
                {
                    body["system"] = SourceExpressionConverter.ConvertToken(bodysystem);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = SourceExpressionConverter.ConvertToken(bodytools);
                    bodypropCount++;
                }

                if (bodytopK != null)
                {
                    body["top_k"] = SourceExpressionConverter.ConvertToken(bodytopK);
                    bodypropCount++;
                }

                if (bodytopP != null)
                {
                    body["top_p"] = SourceExpressionConverter.ConvertToken(bodytopP);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessagePostResponse>(BuildSourceInput);
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
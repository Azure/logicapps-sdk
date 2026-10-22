//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilitervisionagents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TilitervisionagentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilitervisionagents")]
        public IBodyWorkflowAction<AgentResponse, ApiConnectionActionConfiguration> RunVisionAgent(Expression<Func<agentNameInput>> agentName, Expression<Func<string>> payloadinputFileB64, Expression<Func<string>> payloadexpectedText = null, Expression<Func<string>> payloadobjectType = null, Expression<Func<string[]>> payloadexpectedObjects = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_payloadinputFileB64 = WorkflowExpression.Compile(payloadinputFileB64, nameof(payloadinputFileB64), required: true);
            var __workflow_payloadexpectedText = WorkflowExpression.Compile(payloadexpectedText, nameof(payloadexpectedText), required: false);
            var __workflow_payloadobjectType = WorkflowExpression.Compile(payloadobjectType, nameof(payloadobjectType), required: false);
            var __workflow_payloadexpectedObjects = WorkflowExpression.Compile(payloadexpectedObjects, nameof(payloadexpectedObjects), required: false);
            return new DeferredBodyAction<AgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/agents/{0}/v1/inference", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var payload = new JObject();
                var payloadpropCount = 0;
                payloadpropCount++;
                payload["input_file_b64"] = ExpressionConverter.ConvertO(__workflow_payloadinputFileB64);
                if (__workflow_payloadexpectedText != null)
                {
                    payload["expected_text"] = ExpressionConverter.ConvertO(__workflow_payloadexpectedText);
                    payloadpropCount++;
                }

                if (__workflow_payloadobjectType != null)
                {
                    payload["object_type"] = ExpressionConverter.ConvertO(__workflow_payloadobjectType);
                    payloadpropCount++;
                }

                if (__workflow_payloadexpectedObjects != null)
                {
                    payload["expected_objects"] = ExpressionConverter.ConvertO(__workflow_payloadexpectedObjects);
                    payloadpropCount++;
                }

                if (payloadpropCount > 0)
                {
                    callPayload.Body = payload;
                }

                return new ApiConnectionAction<AgentResponse>(callPayload);
            });
        }
    }

    public class TilitervisionagentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AgentResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("agent_type")]
        public string AgentType { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("metadata")]
        public AgentResponseMetadataType Metadata { get; set; }
    }

    public class AgentResponseMetadataType
    {
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum agentNameInput
    {
        [EnumMember(Value = "cleanliness-score")]
        CleanlinessScore,
        [EnumMember(Value = "damage-detector")]
        DamageDetector,
        [EnumMember(Value = "label-reader-validator")]
        LabelReaderValidator,
        [EnumMember(Value = "object-counter")]
        ObjectCounter,
        [EnumMember(Value = "object-validator")]
        ObjectValidator,
        [EnumMember(Value = "object-detection")]
        ObjectDetection,
        [EnumMember(Value = "receipt-processor")]
        ReceiptProcessor,
        [EnumMember(Value = "text-extractor")]
        TextExtractor,
        [EnumMember(Value = "people-counter")]
        PeopleCounter,
        [EnumMember(Value = "fitting-room-assessment")]
        FittingRoomAssessment,
        [EnumMember(Value = "reverse-vending-machine")]
        ReverseVendingMachine,
        [EnumMember(Value = "tyre-recognition")]
        TyreRecognition
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tilitervisionagents;

    public partial class WorkflowManagedActions
    {
        public TilitervisionagentsActions Tilitervisionagents(string connectionId) => new TilitervisionagentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TilitervisionagentsTriggers Tilitervisionagents(string connectionId) => new TilitervisionagentsTriggers(connectionId);
    }
}

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilitervisionagents
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TilitervisionagentsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilitervisionagents")]
        [WorkflowExpressionFactory(nameof(__BuildRunVisionAgent))]
        public IBodyWorkflowAction<AgentResponse> RunVisionAgent([WorkflowExpression] Func<agentNameInput> agentName, [WorkflowExpression] Func<string> payloadinputFileB64, [WorkflowExpression] Func<string> payloadexpectedText = null, [WorkflowExpression] Func<string> payloadobjectType = null, [WorkflowExpression] Func<string[]> payloadexpectedObjects = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AgentResponse> __BuildRunVisionAgent(WorkflowExpression<agentNameInput> agentName, WorkflowExpression<string> payloadinputFileB64, WorkflowExpression<string> payloadexpectedText = null, WorkflowExpression<string> payloadobjectType = null, WorkflowExpression<string[]> payloadexpectedObjects = null)
        {
            WorkflowExpression.Validate(agentName, nameof(agentName), required: true);
            WorkflowExpression.Validate(payloadinputFileB64, nameof(payloadinputFileB64), required: true);
            WorkflowExpression.Validate(payloadexpectedText, nameof(payloadexpectedText), required: false);
            WorkflowExpression.Validate(payloadobjectType, nameof(payloadobjectType), required: false);
            WorkflowExpression.Validate(payloadexpectedObjects, nameof(payloadexpectedObjects), required: false);
            return new DeferredBodyAction<AgentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/agents/{0}/v1/inference", ExpressionConverter.ConvertWithUrlEncoding(agentName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var payload = new JObject();
                var payloadpropCount = 0;
                payloadpropCount++;
                payload["input_file_b64"] = ExpressionConverter.ConvertO(payloadinputFileB64);
                if (payloadexpectedText != null)
                {
                    payload["expected_text"] = ExpressionConverter.ConvertO(payloadexpectedText);
                    payloadpropCount++;
                }

                if (payloadobjectType != null)
                {
                    payload["object_type"] = ExpressionConverter.ConvertO(payloadobjectType);
                    payloadpropCount++;
                }

                if (payloadexpectedObjects != null)
                {
                    payload["expected_objects"] = ExpressionConverter.ConvertO(payloadexpectedObjects);
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
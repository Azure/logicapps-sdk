//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hl7Operations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hl7OperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hl7Operations")]
        public IBodyWorkflowAction<Hl7DecodeOutput> Hl7Decode(Expression<Func<object>> messageToDecode, Expression<Func<Hl7DecodeAcknowledgementModeType>> acknowledgementMode = null)
        {
            var parameters = new JObject();
            parameters["messageToDecode"] = ExpressionConverter.ConvertO(messageToDecode);
            if (acknowledgementMode != null)
            {
                parameters["acknowledgementMode"] = ExpressionConverter.ConvertO(acknowledgementMode);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/hl7Operations", operationId: "hl7Decode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<Hl7DecodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hl7Operations")]
        public IBodyWorkflowAction<Hl7EncodeOutput> Hl7Encode(Expression<Func<object>> messageToEncode, Expression<Func<object>> headerToEncode)
        {
            var parameters = new JObject();
            parameters["messageToEncode"] = ExpressionConverter.ConvertO(messageToEncode);
            parameters["headerToEncode"] = ExpressionConverter.ConvertO(headerToEncode);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/hl7Operations", operationId: "hl7Encode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<Hl7EncodeOutput>(input);
        }
    }

    public class Hl7OperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class Hl7DecodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("headerContent")]
        public JToken HeaderContent { get; set; }

        [JsonProperty("properties")]
        public Hl7DecodeOutputPropertiesType Properties { get; set; }

        [JsonProperty("errors")]
        public Hl7DecodeOutputErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("acknowledgementHeader")]
        public JToken AcknowledgementHeader { get; set; }

        [JsonProperty("applicationAcknowledgement")]
        public JToken ApplicationAcknowledgement { get; set; }

        [JsonProperty("acceptAcknowledgement")]
        public JToken AcceptAcknowledgement { get; set; }
    }

    public class Hl7DecodeOutputPropertiesType
    {
        public string Schema { get; set; }
    }

    public class Hl7DecodeOutputErrorsTypeItem
    {
        [JsonProperty("explicitLoopId")]
        public JToken ExplicitLoopId { get; set; }

        [JsonProperty("segmentId")]
        public JToken SegmentId { get; set; }

        [JsonProperty("positionInTransactionSet")]
        public JToken PositionInTransactionSet { get; set; }

        [JsonProperty("errorCode")]
        public JToken ErrorCode { get; set; }

        [JsonProperty("errorDescription")]
        public JToken ErrorDescription { get; set; }
    }

    public enum Hl7DecodeAcknowledgementModeType
    {
        None,
        Original,
        Enhanced
    }

    public class Hl7EncodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("messageHeaders")]
        public JToken MessageHeaders { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hl7Operations;

    public partial class WorkflowServiceProviderActions
    {
        public Hl7OperationsActions Hl7Operations(string connectionId) => new Hl7OperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public Hl7OperationsTriggers Hl7Operations(string connectionId) => new Hl7OperationsTriggers(connectionId);
    }
}
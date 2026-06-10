//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.SwiftOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SwiftOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "swiftOperations")]
        public IBodyWorkflowAction<SwiftMTEncodeOutput> SwiftMTEncode(Expression<Func<object>> messageToEncode, Expression<Func<SwiftMTEncodeMessageValidationType>> messageValidation)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageToEncode"] = ExpressionConverter.ConvertO(messageToEncode);
            serviceProviderParameters["messageValidation"] = ExpressionConverter.ConvertO(messageValidation);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/swiftOperations", operationId: "SwiftMTEncode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<SwiftMTEncodeOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "swiftOperations")]
        public IBodyWorkflowAction<SwiftMTDecodeOutput> SwiftMTDecode(Expression<Func<object>> messageToDecode, Expression<Func<SwiftMTDecodeMessageValidationType>> messageValidation)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageToDecode"] = ExpressionConverter.ConvertO(messageToDecode);
            serviceProviderParameters["messageValidation"] = ExpressionConverter.ConvertO(messageValidation);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/swiftOperations", operationId: "SwiftMTDecode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<SwiftMTDecodeOutput>(serviceProviderInput);
        }
    }

    public class SwiftOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SwiftMTEncodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        [JsonProperty("validationErrors")]
        public JToken ValidationErrors { get; set; }
    }

    public enum SwiftMTEncodeMessageValidationType
    {
        Enable,
        Disable
    }

    public class SwiftMTDecodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        [JsonProperty("validationErrors")]
        public JToken ValidationErrors { get; set; }
    }

    public enum SwiftMTDecodeMessageValidationType
    {
        Enable,
        Disable
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.SwiftOperations;

    public partial class WorkflowServiceProviderActions
    {
        public SwiftOperationsActions SwiftOperations(string connectionId) => new SwiftOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public SwiftOperationsTriggers SwiftOperations(string connectionId) => new SwiftOperationsTriggers(connectionId);
    }
}
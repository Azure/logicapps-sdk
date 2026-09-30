//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Mllp
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class MllpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "mllp")]
        public IWorkflowAction SendMessage([WorkflowExpression] Func<object> message)
        {
            SourceExpression.Validate(message, nameof(message), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["message"] = SourceExpressionConverter.ConvertToken(message);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mllp", operationId: "sendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }
    }

    public class MllpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/mllp", operationId: "receiveMessage", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveMessageOutput>(BuildSourceInput);
        }
    }

    public class ReceiveMessageOutput
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Mllp;

    public partial class WorkflowServiceProviderActions
    {
        public MllpActions Mllp(string connectionId) => new MllpActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public MllpTriggers Mllp(string connectionId) => new MllpTriggers(connectionId);
    }
}
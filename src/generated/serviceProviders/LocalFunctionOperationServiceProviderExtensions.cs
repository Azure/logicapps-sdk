//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.LocalFunctionOperation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LocalFunctionOperationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "localFunctionOperation")]
        public IBodyWorkflowAction<JToken> InvokeFunction(Expression<Func<string>> functionName, Expression<Func<object>> parameters)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["functionName"] = ExpressionConverter.ConvertO(functionName);
            serviceProviderParameters["parameters"] = ExpressionConverter.ConvertO(parameters);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/localFunctionOperation", operationId: "invokeFunction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }
    }

    public class LocalFunctionOperationTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.LocalFunctionOperation;

    public partial class WorkflowServiceProviderActions
    {
        public LocalFunctionOperationActions LocalFunctionOperation(string connectionId) => new LocalFunctionOperationActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public LocalFunctionOperationTriggers LocalFunctionOperation(string connectionId) => new LocalFunctionOperationTriggers(connectionId);
    }
}
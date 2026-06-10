//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.IbmiProgramCall
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IbmiProgramCallActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "ibmiProgramCall")]
        public IBodyWorkflowAction<JToken> ExecuteMethod(Expression<Func<string>> hidx, Expression<Func<string>> method, Expression<Func<object>> inputParameters)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            serviceProviderParameters["method"] = ExpressionConverter.ConvertO(method);
            serviceProviderParameters["inputParameters"] = ExpressionConverter.ConvertO(inputParameters);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "executeMethod", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }
    }

    public class IbmiProgramCallTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.IbmiProgramCall;

    public partial class WorkflowServiceProviderActions
    {
        public IbmiProgramCallActions IbmiProgramCall(string connectionId) => new IbmiProgramCallActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public IbmiProgramCallTriggers IbmiProgramCall(string connectionId) => new IbmiProgramCallTriggers(connectionId);
    }
}
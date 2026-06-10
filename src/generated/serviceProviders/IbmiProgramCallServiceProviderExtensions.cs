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
            var parameters = new JObject();
            parameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            parameters["method"] = ExpressionConverter.ConvertO(method);
            parameters["inputParameters"] = ExpressionConverter.ConvertO(inputParameters);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "executeMethod", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
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
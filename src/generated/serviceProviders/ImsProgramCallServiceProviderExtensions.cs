//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ImsProgramCall
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImsProgramCallActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IBodyWorkflowAction<JToken> ExecuteMethod(Expression<Func<string>> hidx, Expression<Func<string>> method, Expression<Func<object>> inputParameters)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            serviceProviderParameters["method"] = ExpressionConverter.ConvertO(method);
            serviceProviderParameters["inputParameters"] = ExpressionConverter.ConvertO(inputParameters);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "executeMethod", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }
    }

    public class ImsProgramCallTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ImsProgramCall;

    public partial class WorkflowServiceProviderActions
    {
        public ImsProgramCallActions ImsProgramCall(string connectionId) => new ImsProgramCallActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public ImsProgramCallTriggers ImsProgramCall(string connectionId) => new ImsProgramCallTriggers(connectionId);
    }
}
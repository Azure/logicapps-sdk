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
            var parameters = new JObject();
            parameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            parameters["method"] = ExpressionConverter.ConvertO(method);
            parameters["inputParameters"] = ExpressionConverter.ConvertO(inputParameters);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "executeMethod", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
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
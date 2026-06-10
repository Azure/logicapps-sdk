//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Si3270
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Si3270Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "si3270")]
        public IBodyWorkflowAction<JToken> ExecuteMethod(Expression<Func<string>> hidx, Expression<Func<string>> method, Expression<Func<object>> inputParameters)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            serviceProviderParameters["method"] = ExpressionConverter.ConvertO(method);
            serviceProviderParameters["inputParameters"] = ExpressionConverter.ConvertO(inputParameters);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/si3270", operationId: "executeMethod", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }
    }

    public class Si3270Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Si3270;

    public partial class WorkflowServiceProviderActions
    {
        public Si3270Actions Si3270(string connectionId) => new Si3270Actions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public Si3270Triggers Si3270(string connectionId) => new Si3270Triggers(connectionId);
    }
}
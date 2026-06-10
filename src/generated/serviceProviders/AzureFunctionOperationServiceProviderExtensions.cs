//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFunctionOperation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureFunctionOperationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureFunctionOperation")]
        public IBodyWorkflowAction<JToken> AzureFunction(Expression<Func<AzureFunctionMethodType>> method, Expression<Func<object>> body = null, Expression<Func<object>> headers = null, Expression<Func<object>> queries = null)
        {
            var parameters = new JObject();
            parameters["method"] = ExpressionConverter.ConvertO(method);
            if (body != null)
            {
                parameters["body"] = ExpressionConverter.ConvertO(body);
            }

            if (headers != null)
            {
                parameters["headers"] = ExpressionConverter.ConvertO(headers);
            }

            if (queries != null)
            {
                parameters["queries"] = ExpressionConverter.ConvertO(queries);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/connectionProviders/azureFunctionOperation", operationId: "azureFunction", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }
    }

    public class AzureFunctionOperationTriggers([ConnectionName] string connectionId)
    {
    }

    public enum AzureFunctionMethodType
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFunctionOperation;

    public partial class WorkflowServiceProviderActions
    {
        public AzureFunctionOperationActions AzureFunctionOperation(string connectionId) => new AzureFunctionOperationActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureFunctionOperationTriggers AzureFunctionOperation(string connectionId) => new AzureFunctionOperationTriggers(connectionId);
    }
}
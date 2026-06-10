//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ApiManagementOperation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApiManagementOperationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "apiManagementOperation")]
        public IOutputWorkflowAction<JToken> ApiManagement(Expression<Func<ApiManagementApiManagementType>> apiManagement, Expression<Func<object>> operationDetails = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["apiManagement"] = ExpressionConverter.ConvertO(apiManagement);
            if (operationDetails != null)
            {
                serviceProviderParameters["operationDetails"] = ExpressionConverter.ConvertO(operationDetails);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/connectionProviders/apiManagementOperation", operationId: "apiManagement", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }
    }

    public class ApiManagementOperationTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApiManagementApiManagementType
    {
        [JsonProperty("operationId")]
        public string OperationId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ApiManagementOperation;

    public partial class WorkflowServiceProviderActions
    {
        public ApiManagementOperationActions ApiManagementOperation(string connectionId) => new ApiManagementOperationActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public ApiManagementOperationTriggers ApiManagementOperation(string connectionId) => new ApiManagementOperationTriggers(connectionId);
    }
}
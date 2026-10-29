//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Testconnector
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TestconnectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "testconnector")]
        public IBodyWorkflowAction<HealthResponse, ApiConnectionActionConfiguration> Health()
        {
            return new DeferredBodyAction<HealthResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HealthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "testconnector")]
        public IBodyWorkflowAction<ClientErrorResponse, ApiConnectionActionConfiguration> ClientError()
        {
            return new DeferredBodyAction<ClientErrorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clientError/basic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientErrorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "testconnector")]
        public IBodyWorkflowAction<ServerErrorResponse, ApiConnectionActionConfiguration> ServerError()
        {
            return new DeferredBodyAction<ServerErrorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/serverError/basic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ServerErrorResponse>(callPayload);
            });
        }
    }

    public class TestconnectorTriggers([ConnectionName] string connectionId)
    {
    }

    public class HealthResponse
    {
        public string Message { get; set; }
    }

    public class ClientErrorResponse
    {
        public string Message { get; set; }
    }

    public class ServerErrorResponse
    {
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Testconnector;

    public partial class WorkflowManagedActions
    {
        public TestconnectorActions Testconnector(string connectionId) => new TestconnectorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TestconnectorTriggers Testconnector(string connectionId) => new TestconnectorTriggers(connectionId);
    }
}
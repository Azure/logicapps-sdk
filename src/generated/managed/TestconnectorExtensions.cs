//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Testconnector
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TestconnectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "testconnector")]
        public IBodyWorkflowAction<HealthResponse> Health()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HealthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "testconnector")]
        public IBodyWorkflowAction<ClientErrorResponse> ClientError()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/clientError/basic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ClientErrorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "testconnector")]
        public IBodyWorkflowAction<ServerErrorResponse> ServerError()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/serverError/basic";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ServerErrorResponse>(BuildSourceInput);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDev
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDevActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "31e69824-e44f-4f78-82a7-bc920103a817-greenwood-cemetery-mcp-dev")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDevTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDev;

    public partial class WorkflowManagedActions
    {
        public _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDevActions _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDev(string connectionId) => new _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDevActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDevTriggers _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDev(string connectionId) => new _31e69824E44f4f7882a7Bc920103a817GreenwoodCemeteryMcpDevTriggers(connectionId);
    }
}
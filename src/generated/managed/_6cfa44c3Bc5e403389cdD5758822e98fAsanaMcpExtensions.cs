//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._6cfa44c3Bc5e403389cdD5758822e98fAsanaMcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "6cfa44c3-bc5e-4033-89cd-d5758822e98f-asana-mcp")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._6cfa44c3Bc5e403389cdD5758822e98fAsanaMcp;

    public partial class WorkflowManagedActions
    {
        public _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcpActions _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcp(string connectionId) => new _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcpTriggers _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcp(string connectionId) => new _6cfa44c3Bc5e403389cdD5758822e98fAsanaMcpTriggers(connectionId);
    }
}
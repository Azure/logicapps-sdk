//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "e14c8bb8-3c6b-422e-a6e9-b236c3f8e5df-s360mcp")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcp;

    public partial class WorkflowManagedActions
    {
        public E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcpActions E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcp(string connectionId) => new E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcpTriggers E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcp(string connectionId) => new E14c8bb83c6b422eA6e9B236c3f8e5dfS360mcpTriggers(connectionId);
    }
}
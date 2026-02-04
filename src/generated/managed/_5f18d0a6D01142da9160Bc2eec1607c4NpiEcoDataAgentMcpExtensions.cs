//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "5f18d0a6-d011-42da-9160-bc2eec1607c4-npi-eco-data-agent-mcp")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcp;

    public partial class WorkflowManagedActions
    {
        public _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcpActions _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcp(string connectionId) => new _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcpTriggers _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcp(string connectionId) => new _5f18d0a6D01142da9160Bc2eec1607c4NpiEcoDataAgentMcpTriggers(connectionId);
    }
}
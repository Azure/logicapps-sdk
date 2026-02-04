//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._27a7f831Ef394febB1a3E1f40f1b8335Atlassian
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _27a7f831Ef394febB1a3E1f40f1b8335AtlassianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "27a7f831-ef39-4feb-b1a3-e1f40f1b8335-atlassian")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _27a7f831Ef394febB1a3E1f40f1b8335AtlassianTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._27a7f831Ef394febB1a3E1f40f1b8335Atlassian;

    public partial class WorkflowManagedActions
    {
        public _27a7f831Ef394febB1a3E1f40f1b8335AtlassianActions _27a7f831Ef394febB1a3E1f40f1b8335Atlassian(string connectionId) => new _27a7f831Ef394febB1a3E1f40f1b8335AtlassianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _27a7f831Ef394febB1a3E1f40f1b8335AtlassianTriggers _27a7f831Ef394febB1a3E1f40f1b8335Atlassian(string connectionId) => new _27a7f831Ef394febB1a3E1f40f1b8335AtlassianTriggers(connectionId);
    }
}
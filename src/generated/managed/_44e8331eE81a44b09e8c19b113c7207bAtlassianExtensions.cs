//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._44e8331eE81a44b09e8c19b113c7207bAtlassian
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _44e8331eE81a44b09e8c19b113c7207bAtlassianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "44e8331e-e81a-44b0-9e8c-19b113c7207b-atlassian")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _44e8331eE81a44b09e8c19b113c7207bAtlassianTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._44e8331eE81a44b09e8c19b113c7207bAtlassian;

    public partial class WorkflowManagedActions
    {
        public _44e8331eE81a44b09e8c19b113c7207bAtlassianActions _44e8331eE81a44b09e8c19b113c7207bAtlassian(string connectionId) => new _44e8331eE81a44b09e8c19b113c7207bAtlassianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _44e8331eE81a44b09e8c19b113c7207bAtlassianTriggers _44e8331eE81a44b09e8c19b113c7207bAtlassian(string connectionId) => new _44e8331eE81a44b09e8c19b113c7207bAtlassianTriggers(connectionId);
    }
}
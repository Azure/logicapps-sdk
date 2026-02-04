//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._39d384e3A4df4ee6Bf956200e8682a2fAtlassian3
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "39d384e3-a4df-4ee6-bf95-6200e8682a2f-atlassian3")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._39d384e3A4df4ee6Bf956200e8682a2fAtlassian3;

    public partial class WorkflowManagedActions
    {
        public _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3Actions _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3(string connectionId) => new _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3Triggers _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3(string connectionId) => new _39d384e3A4df4ee6Bf956200e8682a2fAtlassian3Triggers(connectionId);
    }
}
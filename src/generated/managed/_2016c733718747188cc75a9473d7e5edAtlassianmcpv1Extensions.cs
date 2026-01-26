//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._2016c733718747188cc75a9473d7e5edAtlassianmcpv1
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _2016c733718747188cc75a9473d7e5edAtlassianmcpv1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "2016c733-7187-4718-8cc7-5a9473d7e5ed-atlassianmcpv1")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _2016c733718747188cc75a9473d7e5edAtlassianmcpv1Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._2016c733718747188cc75a9473d7e5edAtlassianmcpv1;

    public partial class WorkflowManagedActions
    {
        public _2016c733718747188cc75a9473d7e5edAtlassianmcpv1Actions _2016c733718747188cc75a9473d7e5edAtlassianmcpv1(string connectionId) => new _2016c733718747188cc75a9473d7e5edAtlassianmcpv1Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _2016c733718747188cc75a9473d7e5edAtlassianmcpv1Triggers _2016c733718747188cc75a9473d7e5edAtlassianmcpv1(string connectionId) => new _2016c733718747188cc75a9473d7e5edAtlassianmcpv1Triggers(connectionId);
    }
}
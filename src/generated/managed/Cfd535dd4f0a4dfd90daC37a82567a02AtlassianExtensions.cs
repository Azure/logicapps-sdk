//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cfd535dd4f0a4dfd90daC37a82567a02Atlassian
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Cfd535dd4f0a4dfd90daC37a82567a02AtlassianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cfd535dd-4f0a-4dfd-90da-c37a82567a02-atlassian")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class Cfd535dd4f0a4dfd90daC37a82567a02AtlassianTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cfd535dd4f0a4dfd90daC37a82567a02Atlassian;

    public partial class WorkflowManagedActions
    {
        public Cfd535dd4f0a4dfd90daC37a82567a02AtlassianActions Cfd535dd4f0a4dfd90daC37a82567a02Atlassian(string connectionId) => new Cfd535dd4f0a4dfd90daC37a82567a02AtlassianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Cfd535dd4f0a4dfd90daC37a82567a02AtlassianTriggers Cfd535dd4f0a4dfd90daC37a82567a02Atlassian(string connectionId) => new Cfd535dd4f0a4dfd90daC37a82567a02AtlassianTriggers(connectionId);
    }
}
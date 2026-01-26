//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.B9bf77b2C94b4002B21d3ade3612a309Atlassian
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class B9bf77b2C94b4002B21d3ade3612a309AtlassianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b9bf77b2-c94b-4002-b21d-3ade3612a309-atlassian")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class B9bf77b2C94b4002B21d3ade3612a309AtlassianTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.B9bf77b2C94b4002B21d3ade3612a309Atlassian;

    public partial class WorkflowManagedActions
    {
        public B9bf77b2C94b4002B21d3ade3612a309AtlassianActions B9bf77b2C94b4002B21d3ade3612a309Atlassian(string connectionId) => new B9bf77b2C94b4002B21d3ade3612a309AtlassianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public B9bf77b2C94b4002B21d3ade3612a309AtlassianTriggers B9bf77b2C94b4002B21d3ade3612a309Atlassian(string connectionId) => new B9bf77b2C94b4002B21d3ade3612a309AtlassianTriggers(connectionId);
    }
}
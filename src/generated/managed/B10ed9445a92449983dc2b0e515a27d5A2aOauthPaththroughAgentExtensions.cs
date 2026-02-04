//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgent
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b10ed944-5a92-4499-83dc-2b0e515a27d5-a2a-oauth-paththrough-agent")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgentTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgent;

    public partial class WorkflowManagedActions
    {
        public B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgentActions B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgent(string connectionId) => new B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgentTriggers B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgent(string connectionId) => new B10ed9445a92449983dc2b0e515a27d5A2aOauthPaththroughAgentTriggers(connectionId);
    }
}
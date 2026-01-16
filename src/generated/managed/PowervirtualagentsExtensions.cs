//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powervirtualagents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowervirtualagentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powervirtualagents")]
        public IWorkflowAction PowerVirtualAgents()
        {
            var apiCallPath = "/hybridtriggers/powerVirtualAgents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class PowervirtualagentsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powervirtualagents;

    public partial class WorkflowManagedActions
    {
        public PowervirtualagentsActions Powervirtualagents(string connectionId) => new PowervirtualagentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowervirtualagentsTriggers Powervirtualagents(string connectionId) => new PowervirtualagentsTriggers(connectionId);
    }
}
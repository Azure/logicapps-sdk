//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.M365messagecenter
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class M365messagecenterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "m365messagecenter")]
        public IWorkflowAction SyncMessages()
        {
            var apiCallPath = "/admin/api/messagecenter/SyncMessagesToPlanner";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class M365messagecenterTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.M365messagecenter;

    public partial class WorkflowManagedActions
    {
        public M365messagecenterActions M365messagecenter(string connectionId) => new M365messagecenterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public M365messagecenterTriggers M365messagecenter(string connectionId) => new M365messagecenterTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securitycopilot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecuritycopilotActions([ConnectionName] string connectionId)
    {
    }

    public class SecuritycopilotTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Securitycopilot;

    public partial class WorkflowManagedActions
    {
        public SecuritycopilotActions Securitycopilot(string connectionId) => new SecuritycopilotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecuritycopilotTriggers Securitycopilot(string connectionId) => new SecuritycopilotTriggers(connectionId);
    }
}
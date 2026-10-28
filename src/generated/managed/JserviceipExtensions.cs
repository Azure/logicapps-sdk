//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jserviceip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JserviceipActions([ConnectionName] string connectionId)
    {
    }

    public class JserviceipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jserviceip;

    public partial class WorkflowManagedActions
    {
        public JserviceipActions Jserviceip(string connectionId) => new JserviceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JserviceipTriggers Jserviceip(string connectionId) => new JserviceipTriggers(connectionId);
    }
}
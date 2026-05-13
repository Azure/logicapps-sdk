//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Supermcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SupermcpActions([ConnectionName] string connectionId)
    {
    }

    public class SupermcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Supermcp;

    public partial class WorkflowManagedActions
    {
        public SupermcpActions Supermcp(string connectionId) => new SupermcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SupermcpTriggers Supermcp(string connectionId) => new SupermcpTriggers(connectionId);
    }
}
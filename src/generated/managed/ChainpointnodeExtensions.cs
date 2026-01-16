//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Chainpointnode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ChainpointnodeActions([ConnectionName] string connectionId)
    {
    }

    public class ChainpointnodeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Chainpointnode;

    public partial class WorkflowManagedActions
    {
        public ChainpointnodeActions Chainpointnode(string connectionId) => new ChainpointnodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ChainpointnodeTriggers Chainpointnode(string connectionId) => new ChainpointnodeTriggers(connectionId);
    }
}
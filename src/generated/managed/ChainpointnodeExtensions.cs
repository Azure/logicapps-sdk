//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Chainpointnode
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

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Chainpointnode;

    public partial class WorkflowManagedActions
    {
        public ChainpointnodeActions Chainpointnode(string connectionId) => new ChainpointnodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ChainpointnodeTriggers Chainpointnode(string connectionId) => new ChainpointnodeTriggers(connectionId);
    }
}
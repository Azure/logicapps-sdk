//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Consensysethereum
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConsensysethereumActions([ConnectionName] string connectionId)
    {
    }

    public class ConsensysethereumTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Consensysethereum;

    public partial class WorkflowManagedActions
    {
        public ConsensysethereumActions Consensysethereum(string connectionId) => new ConsensysethereumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConsensysethereumTriggers Consensysethereum(string connectionId) => new ConsensysethereumTriggers(connectionId);
    }
}
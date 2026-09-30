//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blockchainethereum
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlockchainethereumActions([ConnectionName] string connectionId)
    {
    }

    public class BlockchainethereumTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blockchainethereum;

    public partial class WorkflowManagedActions
    {
        public BlockchainethereumActions Blockchainethereum(string connectionId) => new BlockchainethereumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlockchainethereumTriggers Blockchainethereum(string connectionId) => new BlockchainethereumTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nftmaniaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NftmaniaipActions([ConnectionName] string connectionId)
    {
    }

    public class NftmaniaipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nftmaniaip;

    public partial class WorkflowManagedActions
    {
        public NftmaniaipActions Nftmaniaip(string connectionId) => new NftmaniaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NftmaniaipTriggers Nftmaniaip(string connectionId) => new NftmaniaipTriggers(connectionId);
    }
}
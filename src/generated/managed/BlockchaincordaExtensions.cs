//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blockchaincorda
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlockchaincordaActions([ConnectionName] string connectionId)
    {
    }

    public class BlockchaincordaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blockchaincorda;

    public partial class WorkflowManagedActions
    {
        public BlockchaincordaActions Blockchaincorda(string connectionId) => new BlockchaincordaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlockchaincordaTriggers Blockchaincorda(string connectionId) => new BlockchaincordaTriggers(connectionId);
    }
}
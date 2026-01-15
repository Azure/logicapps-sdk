//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Bitlyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitlyipActions([ConnectionName] string connectionId)
    {
    }

    public class BitlyipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Bitlyip;

    public partial class WorkflowManagedActions
    {
        public BitlyipActions Bitlyip(string connectionId) => new BitlyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BitlyipTriggers Bitlyip(string connectionId) => new BitlyipTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Raribleip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RaribleipActions([ConnectionName] string connectionId)
    {
    }

    public class RaribleipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Raribleip;

    public partial class WorkflowManagedActions
    {
        public RaribleipActions Raribleip(string connectionId) => new RaribleipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RaribleipTriggers Raribleip(string connectionId) => new RaribleipTriggers(connectionId);
    }
}
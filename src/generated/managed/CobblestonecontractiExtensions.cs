//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cobblestonecontracti
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CobblestonecontractiActions([ConnectionName] string connectionId)
    {
    }

    public class CobblestonecontractiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cobblestonecontracti;

    public partial class WorkflowManagedActions
    {
        public CobblestonecontractiActions Cobblestonecontracti(string connectionId) => new CobblestonecontractiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CobblestonecontractiTriggers Cobblestonecontracti(string connectionId) => new CobblestonecontractiTriggers(connectionId);
    }
}
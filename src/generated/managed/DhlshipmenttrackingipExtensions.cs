//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dhlshipmenttrackingip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DhlshipmenttrackingipActions([ConnectionName] string connectionId)
    {
    }

    public class DhlshipmenttrackingipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dhlshipmenttrackingip;

    public partial class WorkflowManagedActions
    {
        public DhlshipmenttrackingipActions Dhlshipmenttrackingip(string connectionId) => new DhlshipmenttrackingipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DhlshipmenttrackingipTriggers Dhlshipmenttrackingip(string connectionId) => new DhlshipmenttrackingipTriggers(connectionId);
    }
}
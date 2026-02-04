//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wunderlist
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WunderlistActions([ConnectionName] string connectionId)
    {
    }

    public class WunderlistTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wunderlist;

    public partial class WorkflowManagedActions
    {
        public WunderlistActions Wunderlist(string connectionId) => new WunderlistActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WunderlistTriggers Wunderlist(string connectionId) => new WunderlistTriggers(connectionId);
    }
}
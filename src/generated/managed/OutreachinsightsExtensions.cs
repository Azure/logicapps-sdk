//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Outreachinsights
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OutreachinsightsActions([ConnectionName] string connectionId)
    {
    }

    public class OutreachinsightsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Outreachinsights;

    public partial class WorkflowManagedActions
    {
        public OutreachinsightsActions Outreachinsights(string connectionId) => new OutreachinsightsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OutreachinsightsTriggers Outreachinsights(string connectionId) => new OutreachinsightsTriggers(connectionId);
    }
}
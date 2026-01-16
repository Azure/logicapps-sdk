//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Isoplanner
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IsoplannerActions([ConnectionName] string connectionId)
    {
    }

    public class IsoplannerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Isoplanner;

    public partial class WorkflowManagedActions
    {
        public IsoplannerActions Isoplanner(string connectionId) => new IsoplannerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IsoplannerTriggers Isoplanner(string connectionId) => new IsoplannerTriggers(connectionId);
    }
}
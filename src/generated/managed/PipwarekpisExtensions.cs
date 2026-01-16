//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipwarekpis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipwarekpisActions([ConnectionName] string connectionId)
    {
    }

    public class PipwarekpisTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pipwarekpis;

    public partial class WorkflowManagedActions
    {
        public PipwarekpisActions Pipwarekpis(string connectionId) => new PipwarekpisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PipwarekpisTriggers Pipwarekpis(string connectionId) => new PipwarekpisTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Legiscan
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LegiscanActions([ConnectionName] string connectionId)
    {
    }

    public class LegiscanTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Legiscan;

    public partial class WorkflowManagedActions
    {
        public LegiscanActions Legiscan(string connectionId) => new LegiscanActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LegiscanTriggers Legiscan(string connectionId) => new LegiscanTriggers(connectionId);
    }
}
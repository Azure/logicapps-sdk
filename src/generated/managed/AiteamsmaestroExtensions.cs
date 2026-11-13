//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aiteamsmaestro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AiteamsmaestroActions([ConnectionName] string connectionId)
    {
    }

    public class AiteamsmaestroTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aiteamsmaestro;

    public partial class WorkflowManagedActions
    {
        public AiteamsmaestroActions Aiteamsmaestro(string connectionId) => new AiteamsmaestroActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AiteamsmaestroTriggers Aiteamsmaestro(string connectionId) => new AiteamsmaestroTriggers(connectionId);
    }
}
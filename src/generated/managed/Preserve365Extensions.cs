//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Preserve365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Preserve365Actions([ConnectionName] string connectionId)
    {
    }

    public class Preserve365Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Preserve365;

    public partial class WorkflowManagedActions
    {
        public Preserve365Actions Preserve365(string connectionId) => new Preserve365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Preserve365Triggers Preserve365(string connectionId) => new Preserve365Triggers(connectionId);
    }
}
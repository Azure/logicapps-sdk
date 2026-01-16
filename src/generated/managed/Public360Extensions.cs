//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Public360
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Public360Actions([ConnectionName] string connectionId)
    {
    }

    public class Public360Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Public360;

    public partial class WorkflowManagedActions
    {
        public Public360Actions Public360(string connectionId) => new Public360Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Public360Triggers Public360(string connectionId) => new Public360Triggers(connectionId);
    }
}
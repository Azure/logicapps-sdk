//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Metatask
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MetataskActions([ConnectionName] string connectionId)
    {
    }

    public class MetataskTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Metatask;

    public partial class WorkflowManagedActions
    {
        public MetataskActions Metatask(string connectionId) => new MetataskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MetataskTriggers Metatask(string connectionId) => new MetataskTriggers(connectionId);
    }
}
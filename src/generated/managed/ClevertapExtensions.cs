//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clevertap
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClevertapActions([ConnectionName] string connectionId)
    {
    }

    public class ClevertapTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clevertap;

    public partial class WorkflowManagedActions
    {
        public ClevertapActions Clevertap(string connectionId) => new ClevertapActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClevertapTriggers Clevertap(string connectionId) => new ClevertapTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._3eevents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _3eeventsActions([ConnectionName] string connectionId)
    {
    }

    public class _3eeventsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._3eevents;

    public partial class WorkflowManagedActions
    {
        public _3eeventsActions _3eevents(string connectionId) => new _3eeventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _3eeventsTriggers _3eevents(string connectionId) => new _3eeventsTriggers(connectionId);
    }
}
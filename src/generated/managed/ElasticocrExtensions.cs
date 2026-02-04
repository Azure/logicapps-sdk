//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Elasticocr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElasticocrActions([ConnectionName] string connectionId)
    {
    }

    public class ElasticocrTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Elasticocr;

    public partial class WorkflowManagedActions
    {
        public ElasticocrActions Elasticocr(string connectionId) => new ElasticocrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElasticocrTriggers Elasticocr(string connectionId) => new ElasticocrTriggers(connectionId);
    }
}
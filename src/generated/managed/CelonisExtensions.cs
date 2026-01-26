//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Celonis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CelonisActions([ConnectionName] string connectionId)
    {
    }

    public class CelonisTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Celonis;

    public partial class WorkflowManagedActions
    {
        public CelonisActions Celonis(string connectionId) => new CelonisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CelonisTriggers Celonis(string connectionId) => new CelonisTriggers(connectionId);
    }
}
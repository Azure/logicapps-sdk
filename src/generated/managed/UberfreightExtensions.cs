//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uberfreight
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UberfreightActions([ConnectionName] string connectionId)
    {
    }

    public class UberfreightTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Uberfreight;

    public partial class WorkflowManagedActions
    {
        public UberfreightActions Uberfreight(string connectionId) => new UberfreightActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UberfreightTriggers Uberfreight(string connectionId) => new UberfreightTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Secib
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecibActions([ConnectionName] string connectionId)
    {
    }

    public class SecibTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Secib;

    public partial class WorkflowManagedActions
    {
        public SecibActions Secib(string connectionId) => new SecibActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecibTriggers Secib(string connectionId) => new SecibTriggers(connectionId);
    }
}
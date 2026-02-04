//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsfraudprotect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicsfraudprotectActions([ConnectionName] string connectionId)
    {
    }

    public class DynamicsfraudprotectTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsfraudprotect;

    public partial class WorkflowManagedActions
    {
        public DynamicsfraudprotectActions Dynamicsfraudprotect(string connectionId) => new DynamicsfraudprotectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicsfraudprotectTriggers Dynamicsfraudprotect(string connectionId) => new DynamicsfraudprotectTriggers(connectionId);
    }
}
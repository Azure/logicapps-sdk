//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wauld
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WauldActions([ConnectionName] string connectionId)
    {
    }

    public class WauldTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wauld;

    public partial class WorkflowManagedActions
    {
        public WauldActions Wauld(string connectionId) => new WauldActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WauldTriggers Wauld(string connectionId) => new WauldTriggers(connectionId);
    }
}
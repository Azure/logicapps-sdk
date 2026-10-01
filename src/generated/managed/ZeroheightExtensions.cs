//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zeroheight
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZeroheightActions([ConnectionName] string connectionId)
    {
    }

    public class ZeroheightTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zeroheight;

    public partial class WorkflowManagedActions
    {
        public ZeroheightActions Zeroheight(string connectionId) => new ZeroheightActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZeroheightTriggers Zeroheight(string connectionId) => new ZeroheightTriggers(connectionId);
    }
}
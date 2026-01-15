//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Indpayables
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndpayablesActions([ConnectionName] string connectionId)
    {
    }

    public class IndpayablesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Indpayables;

    public partial class WorkflowManagedActions
    {
        public IndpayablesActions Indpayables(string connectionId) => new IndpayablesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndpayablesTriggers Indpayables(string connectionId) => new IndpayablesTriggers(connectionId);
    }
}
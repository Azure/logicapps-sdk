//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Indkycindia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndkycindiaActions([ConnectionName] string connectionId)
    {
    }

    public class IndkycindiaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Indkycindia;

    public partial class WorkflowManagedActions
    {
        public IndkycindiaActions Indkycindia(string connectionId) => new IndkycindiaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndkycindiaTriggers Indkycindia(string connectionId) => new IndkycindiaTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zenkraft
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZenkraftActions([ConnectionName] string connectionId)
    {
    }

    public class ZenkraftTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zenkraft;

    public partial class WorkflowManagedActions
    {
        public ZenkraftActions Zenkraft(string connectionId) => new ZenkraftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZenkraftTriggers Zenkraft(string connectionId) => new ZenkraftTriggers(connectionId);
    }
}
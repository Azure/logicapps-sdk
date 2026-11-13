//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nomasign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NomasignActions([ConnectionName] string connectionId)
    {
    }

    public class NomasignTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nomasign;

    public partial class WorkflowManagedActions
    {
        public NomasignActions Nomasign(string connectionId) => new NomasignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NomasignTriggers Nomasign(string connectionId) => new NomasignTriggers(connectionId);
    }
}
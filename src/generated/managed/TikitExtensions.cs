//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tikit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TikitActions([ConnectionName] string connectionId)
    {
    }

    public class TikitTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tikit;

    public partial class WorkflowManagedActions
    {
        public TikitActions Tikit(string connectionId) => new TikitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TikitTriggers Tikit(string connectionId) => new TikitTriggers(connectionId);
    }
}
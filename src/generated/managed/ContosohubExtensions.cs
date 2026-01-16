//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contosohub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContosohubActions([ConnectionName] string connectionId)
    {
    }

    public class ContosohubTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Contosohub;

    public partial class WorkflowManagedActions
    {
        public ContosohubActions Contosohub(string connectionId) => new ContosohubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ContosohubTriggers Contosohub(string connectionId) => new ContosohubTriggers(connectionId);
    }
}
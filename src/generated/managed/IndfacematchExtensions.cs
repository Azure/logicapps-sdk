//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Indfacematch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndfacematchActions([ConnectionName] string connectionId)
    {
    }

    public class IndfacematchTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Indfacematch;

    public partial class WorkflowManagedActions
    {
        public IndfacematchActions Indfacematch(string connectionId) => new IndfacematchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndfacematchTriggers Indfacematch(string connectionId) => new IndfacematchTriggers(connectionId);
    }
}
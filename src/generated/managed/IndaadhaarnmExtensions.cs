//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Indaadhaarnm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndaadhaarnmActions([ConnectionName] string connectionId)
    {
    }

    public class IndaadhaarnmTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Indaadhaarnm;

    public partial class WorkflowManagedActions
    {
        public IndaadhaarnmActions Indaadhaarnm(string connectionId) => new IndaadhaarnmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndaadhaarnmTriggers Indaadhaarnm(string connectionId) => new IndaadhaarnmTriggers(connectionId);
    }
}
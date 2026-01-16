//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reliefwebip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReliefwebipActions([ConnectionName] string connectionId)
    {
    }

    public class ReliefwebipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Reliefwebip;

    public partial class WorkflowManagedActions
    {
        public ReliefwebipActions Reliefwebip(string connectionId) => new ReliefwebipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReliefwebipTriggers Reliefwebip(string connectionId) => new ReliefwebipTriggers(connectionId);
    }
}
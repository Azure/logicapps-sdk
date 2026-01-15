//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Azureeventgrid
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureeventgridActions([ConnectionName] string connectionId)
    {
    }

    public class AzureeventgridTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Azureeventgrid;

    public partial class WorkflowManagedActions
    {
        public AzureeventgridActions Azureeventgrid(string connectionId) => new AzureeventgridActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureeventgridTriggers Azureeventgrid(string connectionId) => new AzureeventgridTriggers(connectionId);
    }
}
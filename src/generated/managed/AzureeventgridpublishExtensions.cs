//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgridpublish
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureeventgridpublishActions([ConnectionName] string connectionId)
    {
    }

    public class AzureeventgridpublishTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgridpublish;

    public partial class WorkflowManagedActions
    {
        public AzureeventgridpublishActions Azureeventgridpublish(string connectionId) => new AzureeventgridpublishActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureeventgridpublishTriggers Azureeventgridpublish(string connectionId) => new AzureeventgridpublishTriggers(connectionId);
    }
}
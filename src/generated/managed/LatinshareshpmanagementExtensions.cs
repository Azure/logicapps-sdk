//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Latinshareshpmanagement
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LatinshareshpmanagementActions([ConnectionName] string connectionId)
    {
    }

    public class LatinshareshpmanagementTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Latinshareshpmanagement;

    public partial class WorkflowManagedActions
    {
        public LatinshareshpmanagementActions Latinshareshpmanagement(string connectionId) => new LatinshareshpmanagementActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LatinshareshpmanagementTriggers Latinshareshpmanagement(string connectionId) => new LatinshareshpmanagementTriggers(connectionId);
    }
}
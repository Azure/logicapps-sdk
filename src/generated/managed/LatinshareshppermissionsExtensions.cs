//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Latinshareshppermissions
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LatinshareshppermissionsActions([ConnectionName] string connectionId)
    {
    }

    public class LatinshareshppermissionsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Latinshareshppermissions;

    public partial class WorkflowManagedActions
    {
        public LatinshareshppermissionsActions Latinshareshppermissions(string connectionId) => new LatinshareshppermissionsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LatinshareshppermissionsTriggers Latinshareshppermissions(string connectionId) => new LatinshareshppermissionsTriggers(connectionId);
    }
}
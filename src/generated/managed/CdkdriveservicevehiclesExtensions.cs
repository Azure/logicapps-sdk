//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cdkdriveservicevehicles
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdkdriveservicevehiclesActions([ConnectionName] string connectionId)
    {
    }

    public class CdkdriveservicevehiclesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cdkdriveservicevehicles;

    public partial class WorkflowManagedActions
    {
        public CdkdriveservicevehiclesActions Cdkdriveservicevehicles(string connectionId) => new CdkdriveservicevehiclesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdkdriveservicevehiclesTriggers Cdkdriveservicevehicles(string connectionId) => new CdkdriveservicevehiclesTriggers(connectionId);
    }
}
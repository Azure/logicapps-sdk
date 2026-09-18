//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Geotax
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GeotaxActions([ConnectionName] string connectionId)
    {
    }

    public class GeotaxTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Geotax;

    public partial class WorkflowManagedActions
    {
        public GeotaxActions Geotax(string connectionId) => new GeotaxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GeotaxTriggers Geotax(string connectionId) => new GeotaxTriggers(connectionId);
    }
}
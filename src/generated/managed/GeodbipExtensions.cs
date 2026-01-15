//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Geodbip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GeodbipActions([ConnectionName] string connectionId)
    {
    }

    public class GeodbipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Geodbip;

    public partial class WorkflowManagedActions
    {
        public GeodbipActions Geodbip(string connectionId) => new GeodbipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GeodbipTriggers Geodbip(string connectionId) => new GeodbipTriggers(connectionId);
    }
}
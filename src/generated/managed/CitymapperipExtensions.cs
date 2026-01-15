//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Citymapperip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CitymapperipActions([ConnectionName] string connectionId)
    {
    }

    public class CitymapperipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Citymapperip;

    public partial class WorkflowManagedActions
    {
        public CitymapperipActions Citymapperip(string connectionId) => new CitymapperipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CitymapperipTriggers Citymapperip(string connectionId) => new CitymapperipTriggers(connectionId);
    }
}
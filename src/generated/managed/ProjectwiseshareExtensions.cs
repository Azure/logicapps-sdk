//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Projectwiseshare
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectwiseshareActions([ConnectionName] string connectionId)
    {
    }

    public class ProjectwiseshareTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Projectwiseshare;

    public partial class WorkflowManagedActions
    {
        public ProjectwiseshareActions Projectwiseshare(string connectionId) => new ProjectwiseshareActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProjectwiseshareTriggers Projectwiseshare(string connectionId) => new ProjectwiseshareTriggers(connectionId);
    }
}
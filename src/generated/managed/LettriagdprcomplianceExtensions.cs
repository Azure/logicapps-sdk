//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Lettriagdprcompliance
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LettriagdprcomplianceActions([ConnectionName] string connectionId)
    {
    }

    public class LettriagdprcomplianceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Lettriagdprcompliance;

    public partial class WorkflowManagedActions
    {
        public LettriagdprcomplianceActions Lettriagdprcompliance(string connectionId) => new LettriagdprcomplianceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LettriagdprcomplianceTriggers Lettriagdprcompliance(string connectionId) => new LettriagdprcomplianceTriggers(connectionId);
    }
}
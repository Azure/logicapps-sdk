//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Hubspotsettingsv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotsettingsv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Hubspotsettingsv2Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Hubspotsettingsv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotsettingsv2Actions Hubspotsettingsv2(string connectionId) => new Hubspotsettingsv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotsettingsv2Triggers Hubspotsettingsv2(string connectionId) => new Hubspotsettingsv2Triggers(connectionId);
    }
}
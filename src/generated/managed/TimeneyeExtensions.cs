//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Timeneye
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TimeneyeActions([ConnectionName] string connectionId)
    {
    }

    public class TimeneyeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Timeneye;

    public partial class WorkflowManagedActions
    {
        public TimeneyeActions Timeneye(string connectionId) => new TimeneyeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TimeneyeTriggers Timeneye(string connectionId) => new TimeneyeTriggers(connectionId);
    }
}
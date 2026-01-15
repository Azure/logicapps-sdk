//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Signl4mobilealerting
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Signl4mobilealertingActions([ConnectionName] string connectionId)
    {
    }

    public class Signl4mobilealertingTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Signl4mobilealerting;

    public partial class WorkflowManagedActions
    {
        public Signl4mobilealertingActions Signl4mobilealerting(string connectionId) => new Signl4mobilealertingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Signl4mobilealertingTriggers Signl4mobilealerting(string connectionId) => new Signl4mobilealertingTriggers(connectionId);
    }
}
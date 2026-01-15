//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tribal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TribalActions([ConnectionName] string connectionId)
    {
    }

    public class TribalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Tribal;

    public partial class WorkflowManagedActions
    {
        public TribalActions Tribal(string connectionId) => new TribalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TribalTriggers Tribal(string connectionId) => new TribalTriggers(connectionId);
    }
}
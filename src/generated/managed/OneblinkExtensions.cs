//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oneblink
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OneblinkActions([ConnectionName] string connectionId)
    {
    }

    public class OneblinkTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oneblink;

    public partial class WorkflowManagedActions
    {
        public OneblinkActions Oneblink(string connectionId) => new OneblinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OneblinkTriggers Oneblink(string connectionId) => new OneblinkTriggers(connectionId);
    }
}
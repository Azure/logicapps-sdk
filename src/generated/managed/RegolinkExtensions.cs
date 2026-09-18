//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Regolink
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RegolinkActions([ConnectionName] string connectionId)
    {
    }

    public class RegolinkTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Regolink;

    public partial class WorkflowManagedActions
    {
        public RegolinkActions Regolink(string connectionId) => new RegolinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RegolinkTriggers Regolink(string connectionId) => new RegolinkTriggers(connectionId);
    }
}
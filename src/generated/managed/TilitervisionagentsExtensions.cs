//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilitervisionagents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TilitervisionagentsActions([ConnectionName] string connectionId)
    {
    }

    public class TilitervisionagentsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tilitervisionagents;

    public partial class WorkflowManagedActions
    {
        public TilitervisionagentsActions Tilitervisionagents(string connectionId) => new TilitervisionagentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TilitervisionagentsTriggers Tilitervisionagents(string connectionId) => new TilitervisionagentsTriggers(connectionId);
    }
}
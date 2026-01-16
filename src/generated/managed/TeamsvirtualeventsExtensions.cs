//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamsvirtualevents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamsvirtualeventsActions([ConnectionName] string connectionId)
    {
    }

    public class TeamsvirtualeventsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teamsvirtualevents;

    public partial class WorkflowManagedActions
    {
        public TeamsvirtualeventsActions Teamsvirtualevents(string connectionId) => new TeamsvirtualeventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TeamsvirtualeventsTriggers Teamsvirtualevents(string connectionId) => new TeamsvirtualeventsTriggers(connectionId);
    }
}
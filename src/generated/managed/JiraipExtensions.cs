//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jiraip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JiraipActions([ConnectionName] string connectionId)
    {
    }

    public class JiraipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jiraip;

    public partial class WorkflowManagedActions
    {
        public JiraipActions Jiraip(string connectionId) => new JiraipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JiraipTriggers Jiraip(string connectionId) => new JiraipTriggers(connectionId);
    }
}
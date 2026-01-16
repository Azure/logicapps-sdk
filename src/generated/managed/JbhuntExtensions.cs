//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jbhunt
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JbhuntActions([ConnectionName] string connectionId)
    {
    }

    public class JbhuntTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jbhunt;

    public partial class WorkflowManagedActions
    {
        public JbhuntActions Jbhunt(string connectionId) => new JbhuntActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JbhuntTriggers Jbhunt(string connectionId) => new JbhuntTriggers(connectionId);
    }
}
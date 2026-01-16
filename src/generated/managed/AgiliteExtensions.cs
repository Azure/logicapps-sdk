//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Agilite
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AgiliteActions([ConnectionName] string connectionId)
    {
    }

    public class AgiliteTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Agilite;

    public partial class WorkflowManagedActions
    {
        public AgiliteActions Agilite(string connectionId) => new AgiliteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AgiliteTriggers Agilite(string connectionId) => new AgiliteTriggers(connectionId);
    }
}
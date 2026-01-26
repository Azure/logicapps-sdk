//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Legalbotaitools
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LegalbotaitoolsActions([ConnectionName] string connectionId)
    {
    }

    public class LegalbotaitoolsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Legalbotaitools;

    public partial class WorkflowManagedActions
    {
        public LegalbotaitoolsActions Legalbotaitools(string connectionId) => new LegalbotaitoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LegalbotaitoolsTriggers Legalbotaitools(string connectionId) => new LegalbotaitoolsTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cdkeleadsalesopportunities
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdkeleadsalesopportunitiesActions([ConnectionName] string connectionId)
    {
    }

    public class CdkeleadsalesopportunitiesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cdkeleadsalesopportunities;

    public partial class WorkflowManagedActions
    {
        public CdkeleadsalesopportunitiesActions Cdkeleadsalesopportunities(string connectionId) => new CdkeleadsalesopportunitiesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdkeleadsalesopportunitiesTriggers Cdkeleadsalesopportunities(string connectionId) => new CdkeleadsalesopportunitiesTriggers(connectionId);
    }
}
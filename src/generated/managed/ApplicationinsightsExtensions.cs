//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Applicationinsights
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApplicationinsightsActions([ConnectionName] string connectionId)
    {
    }

    public class ApplicationinsightsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Applicationinsights;

    public partial class WorkflowManagedActions
    {
        public ApplicationinsightsActions Applicationinsights(string connectionId) => new ApplicationinsightsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApplicationinsightsTriggers Applicationinsights(string connectionId) => new ApplicationinsightsTriggers(connectionId);
    }
}
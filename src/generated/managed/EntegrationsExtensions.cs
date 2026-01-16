//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Entegrations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EntegrationsActions([ConnectionName] string connectionId)
    {
    }

    public class EntegrationsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Entegrations;

    public partial class WorkflowManagedActions
    {
        public EntegrationsActions Entegrations(string connectionId) => new EntegrationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EntegrationsTriggers Entegrations(string connectionId) => new EntegrationsTriggers(connectionId);
    }
}
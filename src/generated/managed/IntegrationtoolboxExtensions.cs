//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Integrationtoolbox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntegrationtoolboxActions([ConnectionName] string connectionId)
    {
    }

    public class IntegrationtoolboxTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Integrationtoolbox;

    public partial class WorkflowManagedActions
    {
        public IntegrationtoolboxActions Integrationtoolbox(string connectionId) => new IntegrationtoolboxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntegrationtoolboxTriggers Integrationtoolbox(string connectionId) => new IntegrationtoolboxTriggers(connectionId);
    }
}
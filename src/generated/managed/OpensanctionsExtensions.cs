//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opensanctions
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpensanctionsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensanctions")]
        public IBodyWorkflowAction<JToken> CatalogCatalogGet()
        {
            var apiCallPath = "/catalog";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class OpensanctionsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opensanctions;

    public partial class WorkflowManagedActions
    {
        public OpensanctionsActions Opensanctions(string connectionId) => new OpensanctionsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpensanctionsTriggers Opensanctions(string connectionId) => new OpensanctionsTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opensanctions
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpensanctionsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensanctions")]
        public IBodyWorkflowAction<AlgorithmResponse, ApiConnectionActionConfiguration> AlgorithmsAlgorithmsGet()
        {
            return new DeferredBodyAction<AlgorithmResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/algorithms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlgorithmResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensanctions")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CatalogCatalogGet()
        {
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class OpensanctionsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AlgorithmResponse
    {
        [JsonProperty("algorithms")]
        public Algorithm[] Algorithms { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("best")]
        public string Best { get; set; }
    }

    public class Algorithm
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("features")]
        public JToken Features { get; set; }

        [JsonProperty("docs")]
        public AlgorithmDocs Docs { get; set; }
    }

    public class AlgorithmDocs
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("config")]
        public JToken Config { get; set; }

        [JsonProperty("features")]
        public JToken Features { get; set; }
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
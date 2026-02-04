//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gienitsservermcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GienitsservermcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gienitsservermcp")]
        public IBodyWorkflowAction<QueryResponse> GieniTSserver(Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = "/sse";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            return new ApiConnectionAction<QueryResponse>(callPayload);
        }
    }

    public class GienitsservermcpTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gienitsservermcp;

    public partial class WorkflowManagedActions
    {
        public GienitsservermcpActions Gienitsservermcp(string connectionId) => new GienitsservermcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GienitsservermcpTriggers Gienitsservermcp(string connectionId) => new GienitsservermcpTriggers(connectionId);
    }
}
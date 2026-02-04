//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fabricdataagent
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FabricdataagentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fabricdataagent")]
        public IBodyWorkflowAction<QueryResponse> InvokeMCP(Expression<Func<string>> workspaceId, Expression<Func<string>> artifactId, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = String.Format("/v1/workspaces/{0}/dataagents/{1}/__private/modelcontextprotocol/invoke", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(artifactId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
                queryRequestpropCount++;
            }

            var @paramsObject = new JObject();
            var @paramsObjectpropCount = 0;
            if (@paramsObjectpropCount > 0)
            {
                queryRequest["params"] = @paramsObject;
                queryRequestpropCount++;
            }

            var resultObject = new JObject();
            var resultObjectpropCount = 0;
            if (resultObjectpropCount > 0)
            {
                queryRequest["result"] = resultObject;
                queryRequestpropCount++;
            }

            var errorObject = new JObject();
            var errorObjectpropCount = 0;
            if (errorObjectpropCount > 0)
            {
                queryRequest["error"] = errorObject;
                queryRequestpropCount++;
            }

            queryRequest["callbackEndpoint"] = "@listCallbackUrl()";
            queryRequestpropCount++;
            if (queryRequestpropCount > 0)
            {
                callPayload.Body = queryRequest;
            }

            return new ApiConnectionAction<QueryResponse>(callPayload);
        }
    }

    public class FabricdataagentTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fabricdataagent;

    public partial class WorkflowManagedActions
    {
        public FabricdataagentActions Fabricdataagent(string connectionId) => new FabricdataagentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FabricdataagentTriggers Fabricdataagent(string connectionId) => new FabricdataagentTriggers(connectionId);
    }
}
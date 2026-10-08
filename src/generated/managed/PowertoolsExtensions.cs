//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powertools
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowertoolsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertools")]
        [WorkflowExpressionFactory(nameof(__BuildInvokeMCP))]
        public IBodyWorkflowAction<QueryResponse> InvokeMCP([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryResponse> __BuildInvokeMCP(WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<QueryResponse>(() =>
            {
                var apiCallPath = "/mcp/";
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

                queryRequest["callbackEndpoint"] = "#{listCallbackUrl()}";
                queryRequestpropCount++;
                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }

                return new ApiConnectionAction<QueryResponse>(callPayload);
            });
        }
    }

    public class PowertoolsTriggers([ConnectionName] string connectionId)
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

        [JsonProperty("isError")]
        public bool IsError { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powertools;

    public partial class WorkflowManagedActions
    {
        public PowertoolsActions Powertools(string connectionId) => new PowertoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowertoolsTriggers Powertools(string connectionId) => new PowertoolsTriggers(connectionId);
    }
}
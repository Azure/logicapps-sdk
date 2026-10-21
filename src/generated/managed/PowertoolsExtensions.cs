//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powertools
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowertoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertools")]
        public IBodyWorkflowAction<QueryResponse> InvokeMCP(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<QueryResponse>(() =>
            {
                var apiCallPath = "/mcp/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

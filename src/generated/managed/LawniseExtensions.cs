//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lawnise
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawniseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawnise")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<QueryRequestInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/lawnise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawnise")]
        public IBodyWorkflowAction<HealthCheckResponse, ApiConnectionActionConfiguration> HealthCheck()
        {
            return new DeferredBodyAction<HealthCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HealthCheckResponse>(callPayload);
            });
        }
    }

    public class LawniseTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryRequestInput
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

    public class HealthCheckResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lawnise;

    public partial class WorkflowManagedActions
    {
        public LawniseActions Lawnise(string connectionId) => new LawniseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LawniseTriggers Lawnise(string connectionId) => new LawniseTriggers(connectionId);
    }
}
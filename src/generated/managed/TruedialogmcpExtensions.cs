//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogmcp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TruedialogmcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogmcp")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<QueryRequestInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogmcp")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> HealthCheck()
        {
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TruedialogmcpTriggers([ConnectionName] string connectionId)
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogmcp;

    public partial class WorkflowManagedActions
    {
        public TruedialogmcpActions Truedialogmcp(string connectionId) => new TruedialogmcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TruedialogmcpTriggers Truedialogmcp(string connectionId) => new TruedialogmcpTriggers(connectionId);
    }
}
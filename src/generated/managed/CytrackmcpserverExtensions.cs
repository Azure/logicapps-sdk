//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cytrackmcpserver
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CytrackmcpserverActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cytrackmcpserver")]
        public IBodyWorkflowAction<InvokeServerResponse, ApiConnectionActionConfiguration> InvokeServer(Expression<Func<string>> mcpSessionId = null, Expression<Func<InvokeServerInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredBodyAction<InvokeServerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Cytrack-Channel"] = Convert.ToString("msteams");
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<InvokeServerResponse>(callPayload);
            });
        }
    }

    public class CytrackmcpserverTriggers([ConnectionName] string connectionId)
    {
    }

    public class InvokeServerResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class InvokeServerInput
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cytrackmcpserver;

    public partial class WorkflowManagedActions
    {
        public CytrackmcpserverActions Cytrackmcpserver(string connectionId) => new CytrackmcpserverActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CytrackmcpserverTriggers Cytrackmcpserver(string connectionId) => new CytrackmcpserverTriggers(connectionId);
    }
}
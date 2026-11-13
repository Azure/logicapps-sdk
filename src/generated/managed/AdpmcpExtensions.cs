//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adpmcp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdpmcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpmcp")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeMcp(Expression<Func<string>> mcpSessionId = null, Expression<Func<QueryRequestInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hcm/v1/mcp-orchestration/adp-simplified/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AdpmcpTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adpmcp;

    public partial class WorkflowManagedActions
    {
        public AdpmcpActions Adpmcp(string connectionId) => new AdpmcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdpmcpTriggers Adpmcp(string connectionId) => new AdpmcpTriggers(connectionId);
    }
}
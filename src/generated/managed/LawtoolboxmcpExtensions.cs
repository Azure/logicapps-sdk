//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lawtoolboxmcp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawtoolboxmcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawtoolboxmcp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InvokeServer(Expression<Func<string>> mcpSessionId = null, Expression<Func<InvokeServerInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawtoolboxmcp")]
        public IBodyWorkflowAction<GetProtectedResourceMetadataResponse, ApiConnectionActionConfiguration> GetProtectedResourceMetadata()
        {
            return new DeferredBodyAction<GetProtectedResourceMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/.well-known/oauth-protected-resource";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProtectedResourceMetadataResponse>(callPayload);
            });
        }
    }

    public class LawtoolboxmcpTriggers([ConnectionName] string connectionId)
    {
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

    public class GetProtectedResourceMetadataResponse
    {
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("authorization_servers")]
        public string[] AuthorizationServers { get; set; }

        [JsonProperty("bearer_methods_supported")]
        public string[] BearerMethodsSupported { get; set; }

        [JsonProperty("scopes_supported")]
        public string[] ScopesSupported { get; set; }

        [JsonProperty("resource_documentation")]
        public string ResourceDocumentation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lawtoolboxmcp;

    public partial class WorkflowManagedActions
    {
        public LawtoolboxmcpActions Lawtoolboxmcp(string connectionId) => new LawtoolboxmcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LawtoolboxmcpTriggers Lawtoolboxmcp(string connectionId) => new LawtoolboxmcpTriggers(connectionId);
    }
}
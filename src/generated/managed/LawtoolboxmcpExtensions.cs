//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lawtoolboxmcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawtoolboxmcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawtoolboxmcp")]
        public IWorkflowAction InvokeServer([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = SourceExpressionConverter.ConvertO(mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
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

                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawtoolboxmcp")]
        public IBodyWorkflowAction<GetProtectedResourceMetadataResponse> GetProtectedResourceMetadata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/.well-known/oauth-protected-resource";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProtectedResourceMetadataResponse>(BuildSourceInput);
        }
    }

    public class LawtoolboxmcpTriggers([ConnectionName] string connectionId)
    {
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
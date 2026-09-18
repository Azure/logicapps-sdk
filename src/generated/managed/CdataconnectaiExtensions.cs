//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cdataconnectai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdataconnectaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdataconnectai")]
        public IWorkflowAction InvokeMCP([WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            SourceExpression.Validate(accept, nameof(accept), required: false);
            SourceExpression.Validate(mcpSessionId, nameof(mcpSessionId), required: false);
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json, text/event-stream");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdataconnectai")]
        public IBodyWorkflowAction<OAuthAuthorizationServerMetadataResponse> OAuthAuthorizationServerMetadata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/.well-known/oauth-authorization-server";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OAuthAuthorizationServerMetadataResponse>(BuildSourceInput);
        }
    }

    public class CdataconnectaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class OAuthAuthorizationServerMetadataResponse
    {
        [JsonProperty("authorization_endpoint")]
        public string AuthorizationEndpoint { get; set; }

        [JsonProperty("code_challenge_methods_supported")]
        public string[] CodeChallengeMethodsSupported { get; set; }

        [JsonProperty("grant_types_supported")]
        public string[] GrantTypesSupported { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("registration_endpoint")]
        public string RegistrationEndpoint { get; set; }

        [JsonProperty("response_types_supported")]
        public string[] ResponseTypesSupported { get; set; }

        [JsonProperty("scopes_supported")]
        public string[] ScopesSupported { get; set; }

        [JsonProperty("token_endpoint")]
        public string TokenEndpoint { get; set; }

        [JsonProperty("token_endpoint_auth_methods_supported")]
        public string[] TokenEndpointAuthMethodsSupported { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cdataconnectai;

    public partial class WorkflowManagedActions
    {
        public CdataconnectaiActions Cdataconnectai(string connectionId) => new CdataconnectaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdataconnectaiTriggers Cdataconnectai(string connectionId) => new CdataconnectaiTriggers(connectionId);
    }
}
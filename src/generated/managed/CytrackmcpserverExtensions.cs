//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cytrackmcpserver
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CytrackmcpserverActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cytrackmcpserver")]
        public IBodyWorkflowAction<InvokeServerResponse> InvokeServer([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            SourceExpression.Validate(mcpSessionId, nameof(mcpSessionId), required: false);
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Cytrack-Channel"] = Convert.ToString("msteams");
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

            return new ApiConnectionAction<InvokeServerResponse>(BuildSourceInput);
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
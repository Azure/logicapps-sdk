//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobiletextalertsmcps
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobiletextalertsmcpsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobiletextalertsmcps")]
        public IWorkflowAction InvokeServer([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            var apiCallPath = "/mcp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mcpSessionId != null)
                callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(mcpSessionId);
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

            if (queryRequestpropCount > 0)
            {
                callPayload.Body = queryRequest;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class MobiletextalertsmcpsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mobiletextalertsmcps;

    public partial class WorkflowManagedActions
    {
        public MobiletextalertsmcpsActions Mobiletextalertsmcps(string connectionId) => new MobiletextalertsmcpsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MobiletextalertsmcpsTriggers Mobiletextalertsmcps(string connectionId) => new MobiletextalertsmcpsTriggers(connectionId);
    }
}
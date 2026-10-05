//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.A365teamsmcp
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class A365teamsmcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "a365teamsmcp")]
        [WorkflowExpressionFactory(nameof(__BuildMcpTeamsServer))]
        public IWorkflowAction McpTeamsServer([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMcpTeamsServer(WorkflowValue<string> mcpSessionId = null, WorkflowValue<string> queryRequestjsonrpc = null, WorkflowValue<string> queryRequestid = null, WorkflowValue<string> queryRequestmethod = null)
        {
            WorkflowValue.Validate(mcpSessionId, nameof(mcpSessionId), required: false);
            WorkflowValue.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowValue.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowValue.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/servers/mcp_TeamsServer";
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
            });
        }
    }

    public class A365teamsmcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.A365teamsmcp;

    public partial class WorkflowManagedActions
    {
        public A365teamsmcpActions A365teamsmcp(string connectionId) => new A365teamsmcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public A365teamsmcpTriggers A365teamsmcp(string connectionId) => new A365teamsmcpTriggers(connectionId);
    }
}

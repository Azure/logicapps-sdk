//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.D365customerservicemcpserver
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class D365customerservicemcpserverActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d365customerservicemcpserver")]
        public IWorkflowAction MsdynServiceMCPServer(Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/servers/msdyn_ServiceMCPServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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

    public class D365customerservicemcpserverTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.D365customerservicemcpserver;

    public partial class WorkflowManagedActions
    {
        public D365customerservicemcpserverActions D365customerservicemcpserver(string connectionId) => new D365customerservicemcpserverActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public D365customerservicemcpserverTriggers D365customerservicemcpserver(string connectionId) => new D365customerservicemcpserverTriggers(connectionId);
    }
}

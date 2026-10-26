//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearchfoundryiq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchfoundryiqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearchfoundryiq")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AzureAISearchKBRetrieveMcp(Expression<Func<string>> knowledgeBaseName, Expression<Func<string>> apiVersion, Expression<Func<string>> mcpSessionId = null, Expression<Func<AzureAISearchKBRetrieveMcpInput>> queryRequest = null)
        {
            var __workflow_knowledgeBaseName = WorkflowExpression.Compile(knowledgeBaseName, nameof(knowledgeBaseName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/knowledgebases/{0}/mcp", __workflow_knowledgeBaseName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzureaisearchfoundryiqTriggers([ConnectionName] string connectionId)
    {
    }

    public class AzureAISearchKBRetrieveMcpInput
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearchfoundryiq;

    public partial class WorkflowManagedActions
    {
        public AzureaisearchfoundryiqActions Azureaisearchfoundryiq(string connectionId) => new AzureaisearchfoundryiqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureaisearchfoundryiqTriggers Azureaisearchfoundryiq(string connectionId) => new AzureaisearchfoundryiqTriggers(connectionId);
    }
}
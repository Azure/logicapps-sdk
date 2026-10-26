//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordliftgraphql
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordliftgraphqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordliftgraphql")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ExecuteGraphQL(Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<ExecuteGraphQLInput>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WordliftgraphqlTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExecuteGraphQLInput
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wordliftgraphql;

    public partial class WorkflowManagedActions
    {
        public WordliftgraphqlActions Wordliftgraphql(string connectionId) => new WordliftgraphqlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WordliftgraphqlTriggers Wordliftgraphql(string connectionId) => new WordliftgraphqlTriggers(connectionId);
    }
}
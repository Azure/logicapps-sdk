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
        public IWorkflowAction ExecuteGraphQL(Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyquery = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                var variablesObject = new JObject();
                var variablesObjectpropCount = 0;
                if (variablesObjectpropCount > 0)
                {
                    body["variables"] = variablesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class WordliftgraphqlTriggers([ConnectionName] string connectionId)
    {
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

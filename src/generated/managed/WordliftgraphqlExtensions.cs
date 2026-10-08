//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordliftgraphql
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordliftgraphqlActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordliftgraphql")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteGraphQL))]
        public IWorkflowAction ExecuteGraphQL([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildExecuteGraphQL(WorkflowExpression<string> contentType = null, WorkflowExpression<string> accept = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(accept, nameof(accept), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
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
            });
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
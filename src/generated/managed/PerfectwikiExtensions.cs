//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Perfectwiki
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PerfectwikiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perfectwiki")]
        public IWorkflowAction GetCurrentUser()
        {
            var apiCallPath = "/chatgpt/users/session";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perfectwiki")]
        [WorkflowExpressionFactory(nameof(__BuildQueryKnowledgebase))]
        public IWorkflowAction QueryKnowledgebase([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> chatId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildQueryKnowledgebase(WorkflowValue<string> q, WorkflowValue<string> chatId)
        {
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(chatId, nameof(chatId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/chatgpt/organization/bot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["chatId"] = ExpressionConverter.Convert(chatId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PerfectwikiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Perfectwiki;

    public partial class WorkflowManagedActions
    {
        public PerfectwikiActions Perfectwiki(string connectionId) => new PerfectwikiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PerfectwikiTriggers Perfectwiki(string connectionId) => new PerfectwikiTriggers(connectionId);
    }
}

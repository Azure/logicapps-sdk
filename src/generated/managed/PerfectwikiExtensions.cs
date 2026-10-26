//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Perfectwiki
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PerfectwikiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perfectwiki")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCurrentUser()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chatgpt/users/session";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "perfectwiki")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QueryKnowledgebase(Expression<Func<string>> q, Expression<Func<string>> chatId)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_chatId = WorkflowExpression.Compile(chatId, nameof(chatId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chatgpt/organization/bot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["chatId"] = ExpressionConverter.Convert(__workflow_chatId);
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
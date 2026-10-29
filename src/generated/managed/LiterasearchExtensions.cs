//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Literasearch
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LiterasearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMatterList(Expression<Func<string>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetMatterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request"] = ExpressionConverter.Convert(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMatterNarrative(Expression<Func<string>> matterId)
        {
            var __workflow_matterId = WorkflowExpression.Compile(matterId, nameof(matterId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetMatterNarrative";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["matterId"] = ExpressionConverter.Convert(__workflow_matterId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMatterDetail(Expression<Func<string>> matterId)
        {
            var __workflow_matterId = WorkflowExpression.Compile(matterId, nameof(matterId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetMatterDetail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["matterId"] = ExpressionConverter.Convert(__workflow_matterId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LiterasearchTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Literasearch;

    public partial class WorkflowManagedActions
    {
        public LiterasearchActions Literasearch(string connectionId) => new LiterasearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LiterasearchTriggers Literasearch(string connectionId) => new LiterasearchTriggers(connectionId);
    }
}

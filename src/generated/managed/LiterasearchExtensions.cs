//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Literasearch
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LiterasearchActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        [WorkflowExpressionFactory(nameof(__BuildGetMatterList))]
        public IWorkflowAction GetMatterList([WorkflowExpression] Func<string> request)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetMatterList(WorkflowExpression<string> request)
        {
            WorkflowExpression.Validate(request, nameof(request), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/GetMatterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request"] = ExpressionConverter.Convert(request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        [WorkflowExpressionFactory(nameof(__BuildGetMatterNarrative))]
        public IWorkflowAction GetMatterNarrative([WorkflowExpression] Func<string> matterId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetMatterNarrative(WorkflowExpression<string> matterId)
        {
            WorkflowExpression.Validate(matterId, nameof(matterId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/GetMatterNarrative";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["matterId"] = ExpressionConverter.Convert(matterId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        [WorkflowExpressionFactory(nameof(__BuildGetMatterDetail))]
        public IWorkflowAction GetMatterDetail([WorkflowExpression] Func<string> matterId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetMatterDetail(WorkflowExpression<string> matterId)
        {
            WorkflowExpression.Validate(matterId, nameof(matterId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/GetMatterDetail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["matterId"] = ExpressionConverter.Convert(matterId);
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
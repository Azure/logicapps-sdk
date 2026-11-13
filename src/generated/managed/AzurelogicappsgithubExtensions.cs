//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurelogicappsgithub
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurelogicappsgithubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughDelete(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Passthrough(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughPut(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsgithub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughGet(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzurelogicappsgithubTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurelogicappsgithub;

    public partial class WorkflowManagedActions
    {
        public AzurelogicappsgithubActions Azurelogicappsgithub(string connectionId) => new AzurelogicappsgithubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurelogicappsgithubTriggers Azurelogicappsgithub(string connectionId) => new AzurelogicappsgithubTriggers(connectionId);
    }
}
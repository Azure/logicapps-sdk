//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurelogicappsado
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurelogicappsadoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsado")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughPOST(Expression<Func<string>> Path)
        {
            var __workflow_Path = WorkflowExpression.Compile(Path, nameof(Path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_Path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsado")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughPUT(Expression<Func<string>> Path)
        {
            var __workflow_Path = WorkflowExpression.Compile(Path, nameof(Path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_Path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsado")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughDELETE(Expression<Func<string>> Path)
        {
            var __workflow_Path = WorkflowExpression.Compile(Path, nameof(Path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_Path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurelogicappsado")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PassthroughGET(Expression<Func<string>> Path)
        {
            var __workflow_Path = WorkflowExpression.Compile(Path, nameof(Path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_Path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzurelogicappsadoTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurelogicappsado;

    public partial class WorkflowManagedActions
    {
        public AzurelogicappsadoActions Azurelogicappsado(string connectionId) => new AzurelogicappsadoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurelogicappsadoTriggers Azurelogicappsado(string connectionId) => new AzurelogicappsadoTriggers(connectionId);
    }
}
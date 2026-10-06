//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlephotosip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglephotosipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction ListAlbums()
        {
            var apiCallPath = "/v1/albums";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAlbum))]
        public IWorkflowAction CreateAlbum([WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateAlbum(WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/albums";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction ListItems()
        {
            var apiCallPath = "/v1/mediaItems";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateItems))]
        public IWorkflowAction CreateItems([WorkflowExpression] Func<string> mediaItemIds)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateItems(WorkflowExpression<string> mediaItemIds)
        {
            WorkflowExpression.Validate(mediaItemIds, nameof(mediaItemIds), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/mediaItems:batchGet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mediaItemIds"] = ExpressionConverter.Convert(mediaItemIds);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction ListSharedAlbums()
        {
            var apiCallPath = "/v1/sharedAlbums";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class GooglephotosipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlephotosip;

    public partial class WorkflowManagedActions
    {
        public GooglephotosipActions Googlephotosip(string connectionId) => new GooglephotosipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglephotosipTriggers Googlephotosip(string connectionId) => new GooglephotosipTriggers(connectionId);
    }
}
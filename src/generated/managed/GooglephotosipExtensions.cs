//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlephotosip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IWorkflowAction CreateAlbum(Expression<Func<string>> body = null)
        {
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/albums";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IWorkflowAction CreateItems(Expression<Func<string>> mediaItemIds)
        {
            var __workflow_mediaItemIds = mediaItemIds == null ? null : WorkflowExpression.Compile(mediaItemIds);
            WorkflowExpression.Validate(__workflow_mediaItemIds, nameof(mediaItemIds), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/mediaItems:batchGet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mediaItemIds"] = ExpressionConverter.Convert(__workflow_mediaItemIds);
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

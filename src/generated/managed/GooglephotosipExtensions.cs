//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlephotosip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglephotosipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction ListAlbums()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/albums";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction CreateAlbum([WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/albums";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction ListItems()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/mediaItems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction CreateItems([WorkflowExpression] Func<string> mediaItemIds)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/mediaItems:batchGet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mediaItemIds"] = SourceExpressionConverter.ConvertO(mediaItemIds);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlephotosip")]
        public IWorkflowAction ListSharedAlbums()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/sharedAlbums";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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
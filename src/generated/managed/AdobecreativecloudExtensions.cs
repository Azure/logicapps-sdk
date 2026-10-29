//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobecreativecloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobecreativecloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<CreatedAssetDetails, ApiConnectionActionConfiguration> CreateAsset(Expression<Func<string>> path, Expression<Func<string>> name, Expression<Func<string>> body)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatedAssetDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/asset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatedAssetDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetContentById(Expression<Func<string>> assetId)
        {
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/asset/id/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["asset_id"] = ExpressionConverter.Convert(__workflow_assetId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<AssetMetadata, ApiConnectionActionConfiguration> GetMetadataById(Expression<Func<string>> assetId)
        {
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<AssetMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/asset/id/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["asset_id"] = ExpressionConverter.Convert(__workflow_assetId);
                return new ApiConnectionAction<AssetMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAssetByPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/asset/path";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Headers["If-Match"] = Convert.ToString("*");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetContentByPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/asset/path/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<AssetMetadata, ApiConnectionActionConfiguration> GetMetadataByPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<AssetMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/asset/path/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<AssetMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<DirectoryListing, ApiConnectionActionConfiguration> ListFilesInDirectory(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<DirectoryListing, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/directory/path/assets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<DirectoryListing>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<CreatedAssetDetails, ApiConnectionActionConfiguration> CopyAsset(Expression<Func<CopyAssetInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatedAssetDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storage/cc/op/copy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatedAssetDetails>(callPayload);
            });
        }
    }

    public class AdobecreativecloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookSubscribeToAssetCreatedEvents(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook1/csm/cc/events/asset_created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebhookSubscribeToAssetCreatedEventsInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookSubscribeToAssetUpdatedEvents(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook2/csm/cc/events/asset_updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebhookSubscribeToAssetUpdatedEventsInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreatedAssetDetails
    {
        [JsonProperty("urn")]
        public string AssetId { get; set; }

        [JsonProperty("name")]
        public string AssetName { get; set; }

        [JsonProperty("path")]
        public string AssetPath { get; set; }

        [JsonProperty("link")]
        public string AssetLink { get; set; }
    }

    public class AssetMetadata
    {
        [JsonProperty("urn")]
        public string AssetId { get; set; }

        [JsonProperty("name")]
        public string AssetName { get; set; }

        [JsonProperty("path")]
        public string AssetPath { get; set; }

        [JsonProperty("type")]
        public string AssetContentType { get; set; }

        [JsonProperty("created")]
        public string CreatedAt { get; set; }

        [JsonProperty("modified")]
        public string LastModifiedAt { get; set; }

        [JsonProperty("etag")]
        public string AssetETag { get; set; }

        [JsonProperty("size")]
        public string AssetSize { get; set; }

        [JsonProperty("link")]
        public string AssetLink { get; set; }
    }

    public class DirectoryListing
    {
        [JsonProperty("children")]
        public AssetMetadata[] ListOfAssets { get; set; }
    }

    public class CopyAssetInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceAssetPath { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationAssetPath { get; set; }
    }

    public class WebhookSubscribeToAssetCreatedEventsInput
    {
        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookSubscribeToAssetUpdatedEventsInput
    {
        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobecreativecloud;

    public partial class WorkflowManagedActions
    {
        public AdobecreativecloudActions Adobecreativecloud(string connectionId) => new AdobecreativecloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobecreativecloudTriggers Adobecreativecloud(string connectionId) => new AdobecreativecloudTriggers(connectionId);
    }
}
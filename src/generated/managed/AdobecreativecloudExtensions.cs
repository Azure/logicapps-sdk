//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobecreativecloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobecreativecloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<CreatedAssetDetails> CreateAsset(Expression<Func<string>> path, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/storage/cc/asset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreatedAssetDetails>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<string> GetContentById(Expression<Func<string>> assetId)
        {
            var apiCallPath = "/storage/cc/asset/id/content";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["asset_id"] = ExpressionConverter.Convert(assetId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<AssetMetadata> GetMetadataById(Expression<Func<string>> assetId)
        {
            var apiCallPath = "/storage/cc/asset/id/metadata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["asset_id"] = ExpressionConverter.Convert(assetId);
            return new ApiConnectionAction<AssetMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IWorkflowAction DeleteAssetByPath(Expression<Func<string>> path)
        {
            var apiCallPath = "/storage/cc/asset/path";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Headers["If-Match"] = Convert.ToString("*");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<string> GetContentByPath(Expression<Func<string>> path)
        {
            var apiCallPath = "/storage/cc/asset/path/content";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<AssetMetadata> GetMetadataByPath(Expression<Func<string>> path)
        {
            var apiCallPath = "/storage/cc/asset/path/metadata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<AssetMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<DirectoryListing> ListFilesInDirectory(Expression<Func<string>> path)
        {
            var apiCallPath = "/storage/cc/directory/path/assets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<DirectoryListing>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<CreatedAssetDetails> CopyAsset(Expression<Func<string>> bodysourceAssetPath, Expression<Func<string>> bodydestinationAssetPath)
        {
            var apiCallPath = "/storage/cc/op/copy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodysourceAssetPath);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodydestinationAssetPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatedAssetDetails>(callPayload);
        }
    }

    public class AdobecreativecloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookSubscribeToAssetCreatedEvents()
        {
            var apiCallPath = "/webhook1/csm/cc/events/asset_created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger WebhookSubscribeToAssetUpdatedEvents()
        {
            var apiCallPath = "/webhook2/csm/cc/events/asset_updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class CreatedAssetDetails
    {
        [JsonProperty("urn")]
        public string AssetID { get; set; }

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
        public string AssetID { get; set; }

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
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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
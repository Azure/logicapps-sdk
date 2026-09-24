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
        public IBodyWorkflowAction<CreatedAssetDetails> CreateAsset([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/asset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CreatedAssetDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<string> GetContentById([WorkflowExpression] Func<string> assetId)
        {
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/asset/id/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["asset_id"] = SourceExpressionConverter.ConvertO(assetId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<AssetMetadata> GetMetadataById([WorkflowExpression] Func<string> assetId)
        {
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/asset/id/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["asset_id"] = SourceExpressionConverter.ConvertO(assetId);
                return callPayload;
            }

            return new ApiConnectionAction<AssetMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IWorkflowAction DeleteAssetByPath([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/asset/path";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Headers["If-Match"] = Convert.ToString("*");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<string> GetContentByPath([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/asset/path/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<AssetMetadata> GetMetadataByPath([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/asset/path/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<AssetMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<DirectoryListing> ListFilesInDirectory([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/directory/path/assets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<DirectoryListing>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobecreativecloud")]
        public IBodyWorkflowAction<CreatedAssetDetails> CopyAsset([WorkflowExpression] Func<string> bodysourceAssetPath, [WorkflowExpression] Func<string> bodydestinationAssetPath)
        {
            SourceExpression.Validate(bodysourceAssetPath, nameof(bodysourceAssetPath), required: true);
            SourceExpression.Validate(bodydestinationAssetPath, nameof(bodydestinationAssetPath), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storage/cc/op/copy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodysourceAssetPath);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodydestinationAssetPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatedAssetDetails>(BuildSourceInput);
        }
    }

    public class AdobecreativecloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookSubscribeToAssetCreatedEvents(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook1/csm/cc/events/asset_created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookSubscribeToAssetUpdatedEvents(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook2/csm/cc/events/asset_updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Qppngintegrationhub
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class QppngintegrationhubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<WebhookSuccessResponse, ApiConnectionActionConfiguration> DeleteWebhookTrigger(Expression<Func<string>> userName, Expression<Func<string>> nameOrId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_nameOrId = WorkflowExpression.Compile(nameOrId, nameof(nameOrId), required: true);
            return new DeferredBodyAction<WebhookSuccessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/api/v3/registration/{0}", __workflow_nameOrId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<WebhookSuccessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetAttributeValues(Expression<Func<string>> userName, Expression<Func<string>> assetId, Expression<Func<SetAttributeValuesRequestBodyInputItem[]>> requestBody)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/setAttributeValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<Asset, ApiConnectionActionConfiguration> GetAsset(Expression<Func<string>> userName, Expression<Func<int>> assetId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<Asset, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/getAsset";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<Asset>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<AttributeValueInfo[], ApiConnectionActionConfiguration> GetAttributeValues(Expression<Func<string>> userName, Expression<Func<int>> assetId, Expression<Func<string>> attributeIds)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_attributeIds = WorkflowExpression.Compile(attributeIds, nameof(attributeIds), required: true);
            return new DeferredBodyAction<AttributeValueInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/getAttributeValues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Queries["attributeIds"] = ExpressionConverter.Convert(__workflow_attributeIds);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<AttributeValueInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IsGroupMember(Expression<Func<string>> userName, Expression<Func<int>> userId, Expression<Func<int>> groupId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/trusteeService/isGroupMember";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<ListResponseCollectionGroup, ApiConnectionActionConfiguration> GetCollectionGroups(Expression<Func<string>> userName, Expression<Func<int>> collectionId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            return new DeferredBodyAction<ListResponseCollectionGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/collectionService/getCollectionGroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["collectionId"] = ExpressionConverter.Convert(__workflow_collectionId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<ListResponseCollectionGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<UserInfo, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userName, Expression<Func<int>> userId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/trusteeService/getUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<UserInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<UserInfo, ApiConnectionActionConfiguration> GetUserByName(Expression<Func<string>> userName, Expression<Func<string>> userName2)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_userName2 = WorkflowExpression.Compile(userName2, nameof(userName2), required: true);
            return new DeferredBodyAction<UserInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/trusteeService/getUserByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userName"] = ExpressionConverter.Convert(__workflow_userName2);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<UserInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<AssetDownloadInfo, ApiConnectionActionConfiguration> GetAssetDownloadInfo(Expression<Func<string>> userName, Expression<Func<int>> assetId, Expression<Func<int>> minorVersion = null, Expression<Func<int>> majorVersion = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_minorVersion = WorkflowExpression.Compile(minorVersion, nameof(minorVersion), required: false);
            var __workflow_majorVersion = WorkflowExpression.Compile(majorVersion, nameof(majorVersion), required: false);
            return new DeferredBodyAction<AssetDownloadInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/getAssetDownloadInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Queries["minorVersion"] = Convert.ToString(0);
                if (__workflow_minorVersion != null)
                    callPayload.Queries["minorVersion"] = ExpressionConverter.Convert(__workflow_minorVersion);
                if (__workflow_majorVersion != null)
                    callPayload.Queries["majorVersion"] = ExpressionConverter.Convert(__workflow_majorVersion);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<AssetDownloadInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<UserInfo[], ApiConnectionActionConfiguration> GetGroupMembers(Expression<Func<string>> userName, Expression<Func<int>> groupId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<UserInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/trusteeService/getGroupMembers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<UserInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<AttributeValueInfo[], ApiConnectionActionConfiguration> GetAttributeValuesByName(Expression<Func<string>> userName, Expression<Func<int>> assetId, Expression<Func<string>> attributes)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_attributes = WorkflowExpression.Compile(attributes, nameof(attributes), required: true);
            return new DeferredBodyAction<AttributeValueInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/getAttributeValuesByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Queries["attributes"] = ExpressionConverter.Convert(__workflow_attributes);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<AttributeValueInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<DownloadBlobResponse, ApiConnectionActionConfiguration> DownloadBlob(Expression<Func<string>> authTokenforHeader, Expression<Func<string>> fileIdentifier, Expression<Func<string>> contextId)
        {
            var __workflow_authTokenforHeader = WorkflowExpression.Compile(authTokenforHeader, nameof(authTokenforHeader), required: true);
            var __workflow_fileIdentifier = WorkflowExpression.Compile(fileIdentifier, nameof(fileIdentifier), required: true);
            var __workflow_contextId = WorkflowExpression.Compile(contextId, nameof(contextId), required: true);
            return new DeferredBodyAction<DownloadBlobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/blob/{0}/{1}", __workflow_contextId.WithUrlEncoding(1), __workflow_fileIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["authTokenforHeader"] = ExpressionConverter.Convert(__workflow_authTokenforHeader);
                return new ApiConnectionAction<DownloadBlobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadBlob(Expression<Func<string>> userName, Expression<Func<string>> fileIdentifier, Expression<Func<string>> contextId, Expression<Func<object>> inputStreamResource)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_fileIdentifier = WorkflowExpression.Compile(fileIdentifier, nameof(fileIdentifier), required: true);
            var __workflow_contextId = WorkflowExpression.Compile(contextId, nameof(contextId), required: true);
            var __workflow_inputStreamResource = WorkflowExpression.Compile(inputStreamResource, nameof(inputStreamResource), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/blob/{0}/{1}", __workflow_contextId.WithUrlEncoding(1), __workflow_fileIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputStreamResource);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<ListResponseQueryResultElement, ApiConnectionActionConfiguration> GetPaginatedQueryResultsWithFilters(Expression<Func<string>> userName, Expression<Func<int>> queryId, Expression<Func<QueryFiltersAndDisplayInput>> queryFiltersAndDisplay)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_queryId = WorkflowExpression.Compile(queryId, nameof(queryId), required: true);
            var __workflow_queryFiltersAndDisplay = WorkflowExpression.Compile(queryFiltersAndDisplay, nameof(queryFiltersAndDisplay), required: true);
            return new DeferredBodyAction<ListResponseQueryResultElement, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/queryService/getPaginatedQueryResultsWithFilters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queryId"] = ExpressionConverter.Convert(__workflow_queryId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryFiltersAndDisplay);
                return new ApiConnectionAction<ListResponseQueryResultElement>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<AssetUploadInfo, ApiConnectionActionConfiguration> InitCheckin(Expression<Func<string>> userName, Expression<Func<bool>> createMinorVersion, Expression<Func<AssetInput>> asset)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_createMinorVersion = WorkflowExpression.Compile(createMinorVersion, nameof(createMinorVersion), required: true);
            var __workflow_asset = WorkflowExpression.Compile(asset, nameof(asset), required: true);
            return new DeferredBodyAction<AssetUploadInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/initCheckin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["createMinorVersion"] = ExpressionConverter.Convert(__workflow_createMinorVersion);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_asset);
                return new ApiConnectionAction<AssetUploadInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<Workflow, ApiConnectionActionConfiguration> GetWorkflowByName(Expression<Func<string>> userName, Expression<Func<string>> workflowName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_workflowName = WorkflowExpression.Compile(workflowName, nameof(workflowName), required: true);
            return new DeferredBodyAction<Workflow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/workflowService/getWorkflowByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workflowName"] = ExpressionConverter.Convert(__workflow_workflowName);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<Workflow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<AssetRelation[], ApiConnectionActionConfiguration> GetChildAssetRelations(Expression<Func<string>> userName, Expression<Func<int>> parentAssetId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            return new DeferredBodyAction<AssetRelation[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/getChildAssetRelations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parentAssetId"] = ExpressionConverter.Convert(__workflow_parentAssetId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<AssetRelation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<Attribute[], ApiConnectionActionConfiguration> GetAttributesByName(Expression<Func<string>> userName, Expression<Func<string>> attributeNames)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_attributeNames = WorkflowExpression.Compile(attributeNames, nameof(attributeNames), required: true);
            return new DeferredBodyAction<Attribute[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/attributeService/getAttributesByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attributeNames"] = ExpressionConverter.Convert(__workflow_attributeNames);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<Attribute[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddAttributeToContentTypes(Expression<Func<string>> userName, Expression<Func<int>> attributeId, Expression<Func<string>> contentTypeIds)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_attributeId = WorkflowExpression.Compile(attributeId, nameof(attributeId), required: true);
            var __workflow_contentTypeIds = WorkflowExpression.Compile(contentTypeIds, nameof(contentTypeIds), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/contentStructureService/addAttributeToContentTypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attributeId"] = ExpressionConverter.Convert(__workflow_attributeId);
                callPayload.Queries["contentTypeIds"] = ExpressionConverter.Convert(__workflow_contentTypeIds);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<ContentTypeInfo[], ApiConnectionActionConfiguration> GetContentTypesInfoByName(Expression<Func<string>> userName, Expression<Func<string>> contentTypeName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_contentTypeName = WorkflowExpression.Compile(contentTypeName, nameof(contentTypeName), required: true);
            return new DeferredBodyAction<ContentTypeInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/contentStructureService/getContentTypesInfoByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentTypeName"] = ExpressionConverter.Convert(__workflow_contentTypeName);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<ContentTypeInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<QueryDefinition[], ApiConnectionActionConfiguration> GetAllQueries(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredBodyAction<QueryDefinition[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/queryService/getAllQueries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<QueryDefinition[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<ListResponseUser, ApiConnectionActionConfiguration> GetAllUsers(Expression<Func<string>> userName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredBodyAction<ListResponseUser, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/trusteeService/getAllUsers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<ListResponseUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PublishAssetAsync(Expression<Func<string>> userName, Expression<Func<string>> assetId, Expression<Func<string>> publishingChannelId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_publishingChannelId = WorkflowExpression.Compile(publishingChannelId, nameof(publishingChannelId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/publishingService/publishAssetAsync";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Queries["publishingChannelId"] = ExpressionConverter.Convert(__workflow_publishingChannelId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<PublishingStatusInfo, ApiConnectionActionConfiguration> GetPublishingStatus(Expression<Func<string>> userName, Expression<Func<string>> contextId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_contextId = WorkflowExpression.Compile(contextId, nameof(contextId), required: true);
            return new DeferredBodyAction<PublishingStatusInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/publishingService/getPublishingStatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contextId"] = ExpressionConverter.Convert(__workflow_contextId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<PublishingStatusInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<Asset, ApiConnectionActionConfiguration> CheckOut(Expression<Func<string>> userName, Expression<Func<int>> assetId, Expression<Func<CheckOutRequestBodyInputItem[]>> requestBody)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<Asset, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/checkOut";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(__workflow_assetId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<Asset>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<AssetRelation[], ApiConnectionActionConfiguration> GetParentAssetRelations(Expression<Func<string>> userName, Expression<Func<int>> childAssetId)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_childAssetId = WorkflowExpression.Compile(childAssetId, nameof(childAssetId), required: true);
            return new DeferredBodyAction<AssetRelation[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/assetService/getParentAssetRelations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childAssetId"] = ExpressionConverter.Convert(__workflow_childAssetId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<AssetRelation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<TokenFromAuthWrapperResponse, ApiConnectionActionConfiguration> TokenFromAuthWrapper(Expression<Func<string>> username, Expression<Func<string>> password)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: true);
            return new DeferredBodyAction<TokenFromAuthWrapperResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/auth/token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["password"] = ExpressionConverter.Convert(__workflow_password);
                return new ApiConnectionAction<TokenFromAuthWrapperResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "qppngintegrationhub")]
        public IBodyWorkflowAction<Group, ApiConnectionActionConfiguration> GetGroupByName(Expression<Func<string>> userName, Expression<Func<string>> groupName)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_groupName = WorkflowExpression.Compile(groupName, nameof(groupName), required: true);
            return new DeferredBodyAction<Group, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/trusteeService/getGroupByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupName"] = ExpressionConverter.Convert(__workflow_groupName);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<Group>(callPayload);
            });
        }
    }

    public class QppngintegrationhubTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSuccessResponse, ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<string>> userName, Expression<Func<RequestBodyOfWebhookInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredBodyTrigger<WebhookSuccessResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/api/v3/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["user_name"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger<WebhookSuccessResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebhookSuccessResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class SetAttributeValuesRequestBodyInputItem
    {
        [JsonProperty("attributeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? AttributeId { get; set; } = 25;

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Type { get; set; } = 7;

        [JsonProperty("multiValued", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MultiValued { get; set; } = true;

        [JsonProperty("attributeValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AttributeValue { get; set; } = JToken.Parse("{\"domainValues\":[{\"id\":5015}]}");
    }

    public class Asset
    {
        [JsonProperty("assetId")]
        public int AssetId { get; set; }

        [JsonProperty("assetVersion")]
        public AssetVersion AssetVersion { get; set; }

        [JsonProperty("attributeValues")]
        public AttributeValueInfo[] AttributeValues { get; set; }
    }

    public class AssetVersion
    {
        [JsonProperty("majorVersion")]
        public int MajorVersion { get; set; }

        [JsonProperty("minorVersion")]
        public int MinorVersion { get; set; }

        [JsonProperty("branchId")]
        public int BranchId { get; set; }

        [JsonProperty("systemName")]
        public string SystemName { get; set; }
    }

    public class AttributeValueInfo
    {
        [JsonProperty("attributeId")]
        public int AttributeId { get; set; }

        [JsonProperty("attributeName")]
        public string AttributeName { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("multiValued")]
        public bool MultiValued { get; set; }

        [JsonProperty("attributeValue")]
        public JToken AttributeValue { get; set; }
    }

    public class ListResponseCollectionGroup
    {
        [JsonProperty("get_count")]
        public int GetCount { get; set; }

        [JsonProperty("get_nextLink")]
        public string GetNextLink { get; set; }

        [JsonProperty("get_value")]
        public CollectionGroup[] GetValue { get; set; }
    }

    public class CollectionGroup
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupInfo")]
        public GroupInfo GroupInfo { get; set; }

        [JsonProperty("overriddenUserClassId")]
        public int OverriddenUserClassId { get; set; }
    }

    public class GroupInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("childDomainValues")]
        public DomainValue[] ChildDomainValues { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("user")]
        public bool User { get; set; }

        [JsonProperty("ldapProfileId")]
        public int LdapProfileId { get; set; }

        [JsonProperty("defaultUserClassId")]
        public int DefaultUserClassId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("ldapDistinguishedName")]
        public string LdapDistinguishedName { get; set; }

        [JsonProperty("nativeTrustee")]
        public bool NativeTrustee { get; set; }
    }

    public class DomainValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("childDomainValues")]
        public string ChildDomainValues { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("childDomainValues")]
        public DomainValue[] ChildDomainValues { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("user")]
        public bool User { get; set; }

        [JsonProperty("ldapProfileId")]
        public int LdapProfileId { get; set; }

        [JsonProperty("defaultUserClassId")]
        public int DefaultUserClassId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("ldapDistinguishedName")]
        public string LdapDistinguishedName { get; set; }

        [JsonProperty("nativeTrustee")]
        public bool NativeTrustee { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("externallyAuthenticated")]
        public bool ExternallyAuthenticated { get; set; }

        [JsonProperty("nameForAuthentication")]
        public string NameForAuthentication { get; set; }
    }

    public class AssetDownloadInfo
    {
        [JsonProperty("contextId")]
        public string ContextId { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class DownloadBlobResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class ListResponseQueryResultElement
    {
        [JsonProperty("get_count")]
        public int GetCount { get; set; }

        [JsonProperty("get_nextLink")]
        public string GetNextLink { get; set; }

        [JsonProperty("get_value")]
        public QueryResultElement[] GetValue { get; set; }
    }

    public class QueryResultElement
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("childAvailable")]
        public bool ChildAvailable { get; set; }

        [JsonProperty("elementType")]
        public int ElementType { get; set; }
    }

    public class QueryFiltersAndDisplayInput
    {
        [JsonProperty("queryId")]
        public int? QueryId { get; set; }

        [JsonProperty("queryName")]
        public string QueryName { get; set; }

        [JsonProperty("ownerId")]
        public int? OwnerId { get; set; }

        [JsonProperty("parameterized")]
        public bool? Parameterized { get; set; }

        [JsonProperty("queryDisplay", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetPaginatedQueryResultsWithFiltersQueryDisplay QueryDisplay { get; set; } = new GetPaginatedQueryResultsWithFiltersQueryDisplay();

        [JsonProperty("queryConditions")]
        public GetPaginatedQueryResultsWithFiltersQueryCondition[] QueryConditions { get; set; }

        [JsonProperty("queryContext")]
        public GetPaginatedQueryResultsWithFiltersQueryContext QueryContext { get; set; }

        [JsonProperty("queryResults")]
        public JToken QueryResults { get; set; }
    }

    public class GetPaginatedQueryResultsWithFiltersQueryDisplay
    {
        [JsonProperty("displayColumns")]
        public GetPaginatedQueryResultsWithFiltersDisplayColumn[] DisplayColumns { get; set; }

        [JsonProperty("sorting")]
        public GetPaginatedQueryResultsWithFiltersSortInfo[] Sorting { get; set; }

        [JsonProperty("displayMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DisplayMode { get; set; } = 6;

        [JsonProperty("groupingAttributes")]
        public GetPaginatedQueryResultsWithFiltersGroupingInfo[] GroupingAttributes { get; set; }

        [JsonProperty("exploreMode")]
        public int? ExploreMode { get; set; }
    }

    public class GetPaginatedQueryResultsWithFiltersDisplayColumn
    {
        [JsonProperty("columnId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnId { get; set; } = 2;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Width { get; set; } = 300;

        [JsonProperty("attributeColumn", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AttributeColumn { get; set; } = true;
    }

    public class GetPaginatedQueryResultsWithFiltersSortInfo
    {
        [JsonProperty("columnId")]
        public int? ColumnId { get; set; }

        [JsonProperty("descending")]
        public bool? Descending { get; set; }

        [JsonProperty("attributeColumn")]
        public bool? AttributeColumn { get; set; }
    }

    public class GetPaginatedQueryResultsWithFiltersGroupingInfo
    {
        [JsonProperty("attributeId")]
        public int? AttributeId { get; set; }

        [JsonProperty("descending")]
        public bool? Descending { get; set; }
    }

    public class GetPaginatedQueryResultsWithFiltersQueryCondition
    {
        [JsonProperty("logicalOperator", DefaultValueHandling = DefaultValueHandling.Include)]
        public int LogicalOperator { get; set; } = 1;

        [JsonProperty("comparisonOperator", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ComparisonOperator { get; set; } = 1;

        [JsonProperty("negated", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Negated { get; set; } = false;

        [JsonProperty("parameterized", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Parameterized { get; set; } = false;

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Type { get; set; } = 1;

        [JsonProperty("attributeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int AttributeId { get; set; } = 1531;

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; } = "SVVnOQW9MEqC9GN5mcsr4GQALPdn";
    }

    public class GetPaginatedQueryResultsWithFiltersQueryContext
    {
        [JsonProperty("contentType")]
        public int? ContentType { get; set; }

        [JsonProperty("collections")]
        public int[] Collections { get; set; }

        [JsonProperty("recursive")]
        public bool? Recursive { get; set; }

        [JsonProperty("includeAllVersions")]
        public bool? IncludeAllVersions { get; set; }

        [JsonProperty("includeBranches")]
        public bool? IncludeBranches { get; set; }
    }

    public class AssetUploadInfo
    {
        [JsonProperty("contextId")]
        public string ContextId { get; set; }

        [JsonProperty("uploadUrl")]
        public string UploadUrl { get; set; }
    }

    public class AssetInput
    {
        [JsonProperty("assetId")]
        public int? AssetId { get; set; }
    }

    public class Workflow
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("childDomainValues")]
        public DomainValue[] ChildDomainValues { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("statuses")]
        public Status[] Statuses { get; set; }

        [JsonProperty("createdBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModifiedBy")]
        public int LastModifiedBy { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("constrainedStatusTransition")]
        public bool ConstrainedStatusTransition { get; set; }

        [JsonProperty("statusRoutingUserclasses")]
        public StatusRoutingUserClasses[] StatusRoutingUserclasses { get; set; }

        [JsonProperty("statusTransitions")]
        public StatusTransition[] StatusTransitions { get; set; }
    }

    public class Status
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("childDomainValues")]
        public DomainValue[] ChildDomainValues { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("workflowId")]
        public int WorkflowId { get; set; }

        [JsonProperty("colorRed")]
        public int ColorRed { get; set; }

        [JsonProperty("colorGreen")]
        public int ColorGreen { get; set; }

        [JsonProperty("colorBlue")]
        public int ColorBlue { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class StatusRoutingUserClasses
    {
        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("routingUserClassIds")]
        public int[] RoutingUserClassIds { get; set; }

        [JsonProperty("userClassBasedRouting")]
        public bool UserClassBasedRouting { get; set; }
    }

    public class StatusTransition
    {
        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("workflowInitiatingStatus")]
        public bool WorkflowInitiatingStatus { get; set; }

        [JsonProperty("nextPossibleStatusIds")]
        public int[] NextPossibleStatusIds { get; set; }
    }

    public class AssetRelation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parentAssetId")]
        public int ParentAssetId { get; set; }

        [JsonProperty("parentAssetVersion")]
        public AssetVersion ParentAssetVersion { get; set; }

        [JsonProperty("childAssetId")]
        public int ChildAssetId { get; set; }

        [JsonProperty("childAssetVersion")]
        public AssetVersion ChildAssetVersion { get; set; }

        [JsonProperty("relationTypeId")]
        public int RelationTypeId { get; set; }

        [JsonProperty("relationState")]
        public int RelationState { get; set; }

        [JsonProperty("lockedToChildVersion")]
        public bool LockedToChildVersion { get; set; }

        [JsonProperty("freezeToCurrentVersion")]
        public bool FreezeToCurrentVersion { get; set; }

        [JsonProperty("relationAttributes")]
        public AttributeValueInfo[] RelationAttributes { get; set; }
    }

    public class Attribute
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("valueType")]
        public int ValueType { get; set; }

        [JsonProperty("userDefined")]
        public bool UserDefined { get; set; }

        [JsonProperty("queryable")]
        public bool Queryable { get; set; }

        [JsonProperty("multiValued")]
        public bool MultiValued { get; set; }

        [JsonProperty("modificationLevel")]
        public int ModificationLevel { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("creator")]
        public int Creator { get; set; }

        [JsonProperty("lastModifier")]
        public int LastModifier { get; set; }

        [JsonProperty("displayable")]
        public bool Displayable { get; set; }

        [JsonProperty("limitedAccess")]
        public bool LimitedAccess { get; set; }

        [JsonProperty("limitedAccessChangeable")]
        public bool LimitedAccessChangeable { get; set; }

        [JsonProperty("constraintsChangeable")]
        public bool ConstraintsChangeable { get; set; }

        [JsonProperty("valuePreferencesChangeable")]
        public bool ValuePreferencesChangeable { get; set; }

        [JsonProperty("booleanValuePreferences")]
        public BooleanValuePreferences BooleanValuePreferences { get; set; }

        [JsonProperty("numericValuePreferences")]
        public NumericValuePreferences NumericValuePreferences { get; set; }

        [JsonProperty("dateValuePreferences")]
        public DateValuePreferences DateValuePreferences { get; set; }

        [JsonProperty("dateTimeValuePreferences")]
        public DateTimeValuePreferences DateTimeValuePreferences { get; set; }

        [JsonProperty("timeValuePreferences")]
        public TimeValuePreferences TimeValuePreferences { get; set; }

        [JsonProperty("measurementValuePreferences")]
        public MeasurementValuePreferences MeasurementValuePreferences { get; set; }

        [JsonProperty("textValuePreferences")]
        public TextValuePreferences TextValuePreferences { get; set; }

        [JsonProperty("domainValueListPreferences")]
        public DomainValueListPreferences DomainValueListPreferences { get; set; }

        [JsonProperty("domainValuePreferences")]
        public DomainValuePreferences DomainValuePreferences { get; set; }
    }

    public class BooleanValuePreferences
    {
        [JsonProperty("defaultValue")]
        public BooleanValue DefaultValue { get; set; }
    }

    public class BooleanValue
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class NumericValuePreferences
    {
        [JsonProperty("minimumPossibleValue")]
        public NumericValue MinimumPossibleValue { get; set; }

        [JsonProperty("maximumPossibleValue")]
        public NumericValue MaximumPossibleValue { get; set; }

        [JsonProperty("defaultValue")]
        public NumericValue DefaultValue { get; set; }
    }

    public class NumericValue
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class DateValuePreferences
    {
        [JsonProperty("minimumPossibleValue")]
        public DateValue MinimumPossibleValue { get; set; }

        [JsonProperty("maximumPossibleValue")]
        public DateValue MaximumPossibleValue { get; set; }

        [JsonProperty("defaultValue")]
        public DateValue DefaultValue { get; set; }
    }

    public class DateValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DateTimeValuePreferences
    {
        [JsonProperty("minimumPossibleValue")]
        public DateTimeValue MinimumPossibleValue { get; set; }

        [JsonProperty("maximumPossibleValue")]
        public DateTimeValue MaximumPossibleValue { get; set; }

        [JsonProperty("defaultValue")]
        public DateTimeValue DefaultValue { get; set; }
    }

    public class DateTimeValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TimeValuePreferences
    {
        [JsonProperty("minimumPossibleValue")]
        public TimeValue MinimumPossibleValue { get; set; }

        [JsonProperty("maximumPossibleValue")]
        public TimeValue MaximumPossibleValue { get; set; }

        [JsonProperty("defaultValue")]
        public TimeValue DefaultValue { get; set; }
    }

    public class TimeValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class MeasurementValuePreferences
    {
        [JsonProperty("measurementUnit")]
        public int MeasurementUnit { get; set; }

        [JsonProperty("onlyMeasurementUnitChangeable")]
        public bool OnlyMeasurementUnitChangeable { get; set; }

        [JsonProperty("minimumPossibleValue")]
        public MeasurementValue MinimumPossibleValue { get; set; }

        [JsonProperty("maximumPossibleValue")]
        public MeasurementValue MaximumPossibleValue { get; set; }

        [JsonProperty("defaultValue")]
        public MeasurementValue DefaultValue { get; set; }
    }

    public class MeasurementValue
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class TextValuePreferences
    {
        [JsonProperty("defaultValue")]
        public TextValue DefaultValue { get; set; }

        [JsonProperty("maxLengthPossible")]
        public int MaxLengthPossible { get; set; }

        [JsonProperty("textSearchEnabled")]
        public bool TextSearchEnabled { get; set; }
    }

    public class TextValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DomainValueListPreferences
    {
        [JsonProperty("defaultValue")]
        public DomainValueList DefaultValue { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }
    }

    public class DomainValueList
    {
        [JsonProperty("domainValues")]
        public DomainValue[] DomainValues { get; set; }
    }

    public class DomainValuePreferences
    {
        [JsonProperty("defaultValue")]
        public DomainValue DefaultValue { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }
    }

    public class ContentTypeInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("childDomainValues")]
        public DomainValue[] ChildDomainValues { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("systemDefined")]
        public bool SystemDefined { get; set; }

        [JsonProperty("childrenAvailable")]
        public bool ChildrenAvailable { get; set; }

        [JsonProperty("extensible")]
        public bool Extensible { get; set; }
    }

    public class QueryDefinition
    {
        [JsonProperty("queryId")]
        public int QueryId { get; set; }

        [JsonProperty("queryName")]
        public string QueryName { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty("parameterized")]
        public bool Parameterized { get; set; }

        [JsonProperty("queryDisplay")]
        public GetAllQueriesQueryDisplayResponse QueryDisplay { get; set; }

        [JsonProperty("queryConditions")]
        public GetAllQueriesQueryConditionResponse[] QueryConditions { get; set; }

        [JsonProperty("queryContext")]
        public GetAllQueriesQueryContextResponse QueryContext { get; set; }

        [JsonProperty("queryResults")]
        public JToken QueryResults { get; set; }
    }

    public class GetAllQueriesQueryDisplayResponse
    {
        [JsonProperty("displayColumns")]
        public GetAllQueriesDisplayColumnResponse[] DisplayColumns { get; set; }

        [JsonProperty("sorting")]
        public GetAllQueriesSortInfoResponse[] Sorting { get; set; }

        [JsonProperty("displayMode")]
        public int DisplayMode { get; set; }

        [JsonProperty("groupingAttributes")]
        public GetAllQueriesGroupingInfoResponse[] GroupingAttributes { get; set; }

        [JsonProperty("exploreMode")]
        public int ExploreMode { get; set; }
    }

    public class GetAllQueriesDisplayColumnResponse
    {
        [JsonProperty("columnId")]
        public int ColumnId { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("attributeColumn")]
        public bool AttributeColumn { get; set; }
    }

    public class GetAllQueriesSortInfoResponse
    {
        [JsonProperty("columnId")]
        public int ColumnId { get; set; }

        [JsonProperty("descending")]
        public bool Descending { get; set; }

        [JsonProperty("attributeColumn")]
        public bool AttributeColumn { get; set; }
    }

    public class GetAllQueriesGroupingInfoResponse
    {
        [JsonProperty("attributeId")]
        public int AttributeId { get; set; }

        [JsonProperty("descending")]
        public bool Descending { get; set; }
    }

    public class GetAllQueriesQueryConditionResponse
    {
        [JsonProperty("logicalOperator")]
        public int LogicalOperator { get; set; }

        [JsonProperty("comparisonOperator")]
        public int ComparisonOperator { get; set; }

        [JsonProperty("negated")]
        public bool Negated { get; set; }

        [JsonProperty("parameterized")]
        public bool Parameterized { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("attributeId")]
        public int AttributeId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetAllQueriesQueryContextResponse
    {
        [JsonProperty("contentType")]
        public int ContentType { get; set; }

        [JsonProperty("collections")]
        public int[] Collections { get; set; }

        [JsonProperty("recursive")]
        public bool Recursive { get; set; }

        [JsonProperty("includeAllVersions")]
        public bool IncludeAllVersions { get; set; }

        [JsonProperty("includeBranches")]
        public bool IncludeBranches { get; set; }
    }

    public class ListResponseUser
    {
        [JsonProperty("get_count")]
        public int GetCount { get; set; }

        [JsonProperty("get_nextLink")]
        public string GetNextLink { get; set; }

        [JsonProperty("get_value")]
        public UserInfo[] GetValue { get; set; }
    }

    public class PublishingStatusInfo
    {
        [JsonProperty("publishingFailedException")]
        public PublishingFailedException PublishingFailedException { get; set; }

        [JsonProperty("publishingOutputDownloadInfo")]
        public PublishingOutputDownloadInfo[] PublishingOutputDownloadInfo { get; set; }

        [JsonProperty("publishingStatus")]
        public string PublishingStatus { get; set; }
    }

    public class PublishingFailedException
    {
        [JsonProperty("additionalInfo")]
        public string[] AdditionalInfo { get; set; }

        [JsonProperty("cause")]
        public Throwable Cause { get; set; }

        [JsonProperty("exceptionCode")]
        public string ExceptionCode { get; set; }

        [JsonProperty("localizedMessage")]
        public string LocalizedMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stackTrace")]
        public StackTraceElement[] StackTrace { get; set; }

        [JsonProperty("suppressed")]
        public Throwable[] Suppressed { get; set; }
    }

    public class Throwable
    {
        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("localizedMessage")]
        public string LocalizedMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stackTrace")]
        public StackTraceElement[] StackTrace { get; set; }

        [JsonProperty("suppressed")]
        public string[] Suppressed { get; set; }
    }

    public class StackTraceElement
    {
        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("methodName")]
        public string MethodName { get; set; }

        [JsonProperty("nativeMethod")]
        public bool NativeMethod { get; set; }
    }

    public class PublishingOutputDownloadInfo
    {
        [JsonProperty("attributesMap")]
        public JToken AttributesMap { get; set; }

        [JsonProperty("directDownload")]
        public bool DirectDownload { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class CheckOutRequestBodyInputItem
    {
        [JsonProperty("attributeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? AttributeId { get; set; } = 16;

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Type { get; set; } = 1;

        [JsonProperty("attributeValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AttributeValue { get; set; } = JToken.Parse("{\"value\":\"c:/checkedoutfiles\"}");
    }

    public class TokenFromAuthWrapperResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_expires_in")]
        public int RefreshExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("not-before-policy")]
        public int NotBeforePolicy { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class Group
    {
        [JsonProperty("childDomainValues")]
        public DomainValue[] ChildDomainValues { get; set; }

        [JsonProperty("defaultUserClassId")]
        public int DefaultUserClassId { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("domainId")]
        public int DomainId { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("ldapDistinguishedName")]
        public string LdapDistinguishedName { get; set; }

        [JsonProperty("ldapProfileId")]
        public int LdapProfileId { get; set; }

        [JsonProperty("memberIds")]
        public int[] MemberIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nativeTrustee")]
        public bool NativeTrustee { get; set; }

        [JsonProperty("sourceReference")]
        public string SourceReference { get; set; }

        [JsonProperty("user")]
        public bool User { get; set; }
    }

    public class RequestBodyOfWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebhookName { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebhookType { get; set; } = "EVENT";

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestBodyOfWebhookInputObjectEntityType ObjectEntity { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Qppngintegrationhub.RequestBodyOfWebhookInputObjectEntityType.ASSET;

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestBodyOfWebhookInputChangeTypeTypeItem[] ChangeType { get; set; } = new RequestBodyOfWebhookInputChangeTypeTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Qppngintegrationhub.RequestBodyOfWebhookInputChangeTypeTypeItem.ASSETADDED
        };

        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filter")]
        public string FilterCriteria { get; set; }

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VersionUsed { get; set; } = "1.0";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestBodyOfWebhookInputObjectEntityType
    {
        COLLECTION,
        DOMAIN,
        [EnumMember(Value = "SERVER_STATUS")]
        SERVERSTATUS,
        ATTRIBUTE,
        USERCLASS,
        FORM,
        ASSET,
        [EnumMember(Value = "RELATION_TYPE")]
        RELATIONTYPE,
        [EnumMember(Value = "ASSET_RELATION")]
        ASSETRELATION,
        PUBLISHING,
        USER,
        GROUP,
        ARTICLE,
        QUERY,
        [EnumMember(Value = "CONTENT_TYPE")]
        CONTENTTYPE,
        CUSTOM,
        SCHEDULER,
        [EnumMember(Value = "SYSTEM_PREFERENCE")]
        SYSTEMPREFERENCE,
        WORKFLOW,
        [EnumMember(Value = "SERVER_SHUTDOWN")]
        SERVERSHUTDOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestBodyOfWebhookInputChangeTypeTypeItem
    {
        [EnumMember(Value = "COLLECTION_ADDED")]
        COLLECTIONADDED,
        [EnumMember(Value = "COLLECTION_CHANGED")]
        COLLECTIONCHANGED,
        [EnumMember(Value = "COLLECTION_DEFAULT_JOBJACKET_CHANGED")]
        COLLECTIONDEFAULTJOBJACKETCHANGED,
        [EnumMember(Value = "COLLECTION_DELETED")]
        COLLECTIONDELETED,
        [EnumMember(Value = "COLLECTION_GROUPS_CHANGED")]
        COLLECTIONGROUPSCHANGED,
        [EnumMember(Value = "COLLECTION_JOBJACKETS_CHANGED")]
        COLLECTIONJOBJACKETSCHANGED,
        [EnumMember(Value = "COLLECTION_MOVED")]
        COLLECTIONMOVED,
        [EnumMember(Value = "COLLECTION_REVISION_CONTROLS_CHANGED")]
        COLLECTIONREVISIONCONTROLSCHANGED,
        [EnumMember(Value = "COLLECTION_ROUTINGS_CHANGED")]
        COLLECTIONROUTINGSCHANGED,
        [EnumMember(Value = "COLLECTION_USERS_CHANGED")]
        COLLECTIONUSERSCHANGED,
        [EnumMember(Value = "COLLECTION_WORKFLOWS_CHANGED")]
        COLLECTIONWORKFLOWSCHANGED,
        [EnumMember(Value = "DOMAIN_ADDED")]
        DOMAINADDED,
        [EnumMember(Value = "DOMAIN_DEFINITION_CHANGED")]
        DOMAINDEFINITIONCHANGED,
        [EnumMember(Value = "DOMAIN_DELETED")]
        DOMAINDELETED,
        [EnumMember(Value = "DOMAIN_VALUES_CHANGED")]
        DOMAINVALUESCHANGED,
        [EnumMember(Value = "DOMAIN_VALUES_MOVED")]
        DOMAINVALUESMOVED,
        [EnumMember(Value = "DOMAIN_VALUE_XML_CHANGED")]
        DOMAINVALUEXMLCHANGED,
        [EnumMember(Value = "SERVER_STATUS_CHANGED")]
        SERVERSTATUSCHANGED,
        [EnumMember(Value = "ATTRIBUTE_ADDED")]
        ATTRIBUTEADDED,
        [EnumMember(Value = "ATTRIBUTE_CHANGED")]
        ATTRIBUTECHANGED,
        [EnumMember(Value = "ATTRIBUTE_DELETED")]
        ATTRIBUTEDELETED,
        [EnumMember(Value = "USERCLASS_ADDED")]
        USERCLASSADDED,
        [EnumMember(Value = "USERCLASS_CHANGED")]
        USERCLASSCHANGED,
        [EnumMember(Value = "USERCLASS_DELETED")]
        USERCLASSDELETED,
        [EnumMember(Value = "USERCLASS_REASSIGNED")]
        USERCLASSREASSIGNED,
        [EnumMember(Value = "USERCLASS_STATUS_PRIVILEGES_CHANGED")]
        USERCLASSSTATUSPRIVILEGESCHANGED,
        [EnumMember(Value = "USERCLASS_STATUS_PRIVILEGES_DELETED")]
        USERCLASSSTATUSPRIVILEGESDELETED,
        [EnumMember(Value = "FORM_ADDED")]
        FORMADDED,
        [EnumMember(Value = "FORM_CHANGED")]
        FORMCHANGED,
        [EnumMember(Value = "FORM_DELETED")]
        FORMDELETED,
        [EnumMember(Value = "ASSET_ADDED")]
        ASSETADDED,
        [EnumMember(Value = "ASSET_CHANGED")]
        ASSETCHANGED,
        [EnumMember(Value = "ASSET_CHECKOUT")]
        ASSETCHECKOUT,
        [EnumMember(Value = "ASSET_CHECKOUT_ABORT")]
        ASSETCHECKOUTABORT,
        [EnumMember(Value = "ASSET_DELETED")]
        ASSETDELETED,
        [EnumMember(Value = "ASSET_DOWNLOADED")]
        ASSETDOWNLOADED,
        [EnumMember(Value = "ASSET_DOWNLOAD_INFO_REQUESTED")]
        ASSETDOWNLOADINFOREQUESTED,
        [EnumMember(Value = "ASSET_DRAFT_ADDED")]
        ASSETDRAFTADDED,
        [EnumMember(Value = "ASSET_DRAFT_DOWNLOADED")]
        ASSETDRAFTDOWNLOADED,
        [EnumMember(Value = "ASSET_DRAFT_DOWNLOAD_INFO_REQUESTED")]
        ASSETDRAFTDOWNLOADINFOREQUESTED,
        [EnumMember(Value = "ASSET_ESIGN_STATUS")]
        ASSETESIGNSTATUS,
        [EnumMember(Value = "ASSET_RENDITION_CREATED")]
        ASSETRENDITIONCREATED,
        [EnumMember(Value = "ASSET_RENDITION_DOWNLOAD_INFO_REQUESTED")]
        ASSETRENDITIONDOWNLOADINFOREQUESTED,
        [EnumMember(Value = "ASSET_RENDITION_PART_DOWNLOAD_INFO_REQUESTED")]
        ASSETRENDITIONPARTDOWNLOADINFOREQUESTED,
        [EnumMember(Value = "ASSET_VERSION_ADDED")]
        ASSETVERSIONADDED,
        [EnumMember(Value = "ASSET_VERSION_DELETED")]
        ASSETVERSIONDELETED,
        [EnumMember(Value = "ASSET_WORKFLOW_CHANGED")]
        ASSETWORKFLOWCHANGED,
        [EnumMember(Value = "BRANCH_CHANGED")]
        BRANCHCHANGED,
        [EnumMember(Value = "BRANCH_CREATED")]
        BRANCHCREATED,
        [EnumMember(Value = "BRANCH_DELETED")]
        BRANCHDELETED,
        [EnumMember(Value = "RELATION_ATTRIBUTE_MAPPINGS_CHANGED")]
        RELATIONATTRIBUTEMAPPINGSCHANGED,
        [EnumMember(Value = "RELATION_TYPE_ADDED")]
        RELATIONTYPEADDED,
        [EnumMember(Value = "RELATION_TYPE_CHANGED")]
        RELATIONTYPECHANGED,
        [EnumMember(Value = "RELATION_TYPE_DELETED")]
        RELATIONTYPEDELETED,
        [EnumMember(Value = "ASSET_RELATION_ADDED")]
        ASSETRELATIONADDED,
        [EnumMember(Value = "ASSET_RELATION_CHILD_VERSION_CHANGED")]
        ASSETRELATIONCHILDVERSIONCHANGED,
        [EnumMember(Value = "ASSET_RELATION_DELETED")]
        ASSETRELATIONDELETED,
        DATADOC,
        DELIVER,
        PUBLISH,
        [EnumMember(Value = "LICENSE_ASSIGNED")]
        LICENSEASSIGNED,
        [EnumMember(Value = "LICENSE_REVOKED")]
        LICENSEREVOKED,
        [EnumMember(Value = "ROLE_FOR_USER_CHANGED")]
        ROLEFORUSERCHANGED,
        [EnumMember(Value = "USER_ADDED")]
        USERADDED,
        [EnumMember(Value = "USER_CHANGED")]
        USERCHANGED,
        [EnumMember(Value = "USER_DELETED")]
        USERDELETED,
        [EnumMember(Value = "USER_MEMBERSHIP_CHANGED")]
        USERMEMBERSHIPCHANGED,
        [EnumMember(Value = "USER_PASSWORD_CHANGED")]
        USERPASSWORDCHANGED,
        [EnumMember(Value = "USER_REDLINING_COLOR_CHANGED")]
        USERREDLININGCOLORCHANGED,
        [EnumMember(Value = "GROUP_ADDED")]
        GROUPADDED,
        [EnumMember(Value = "GROUP_CHANGED")]
        GROUPCHANGED,
        [EnumMember(Value = "GROUP_DELETED")]
        GROUPDELETED,
        [EnumMember(Value = "ARTICLE_GEOMETRY_UPDATED")]
        ARTICLEGEOMETRYUPDATED,
        [EnumMember(Value = "QUERY_CHANGED")]
        QUERYCHANGED,
        [EnumMember(Value = "QUERY_CREATED")]
        QUERYCREATED,
        [EnumMember(Value = "QUERY_DELETED")]
        QUERYDELETED,
        [EnumMember(Value = "QUERY_REASSIGNED")]
        QUERYREASSIGNED,
        [EnumMember(Value = "QUERY_SHARED")]
        QUERYSHARED,
        [EnumMember(Value = "QUERY_SHARING_REMOVED")]
        QUERYSHARINGREMOVED,
        [EnumMember(Value = "CONTENT_TYPE_ADDED")]
        CONTENTTYPEADDED,
        [EnumMember(Value = "CONTENT_TYPE_ATTRIBUTES_UPDATED")]
        CONTENTTYPEATTRIBUTESUPDATED,
        [EnumMember(Value = "CONTENT_TYPE_CHANGED")]
        CONTENTTYPECHANGED,
        [EnumMember(Value = "CONTENT_TYPE_DELETED")]
        CONTENTTYPEDELETED,
        [EnumMember(Value = "CUSTOM_CEDEV")]
        CUSTOMCEDEV,
        [EnumMember(Value = "CUSTOM_EVENT")]
        CUSTOMEVENT,
        [EnumMember(Value = "HKV_DEV")]
        HKVDEV,
        [EnumMember(Value = "HKV_DEV3X")]
        HKVDEV3X,
        [EnumMember(Value = "LOGGED_OUT")]
        LOGGEDOUT,
        [EnumMember(Value = "LOGIN_FAILED")]
        LOGINFAILED,
        [EnumMember(Value = "LOGIN_SUCCESS")]
        LOGINSUCCESS,
        [EnumMember(Value = "SCHEDULE_REACHED")]
        SCHEDULEREACHED,
        [EnumMember(Value = "SYSTEM_PREFERENCE_CHANGED")]
        SYSTEMPREFERENCECHANGED,
        [EnumMember(Value = "ATTRIBUTE_CONSTRAINTS_CHANGED")]
        ATTRIBUTECONSTRAINTSCHANGED,
        [EnumMember(Value = "CHECK_IN_RULE_EVALUATION_CHANGED")]
        CHECKINRULEEVALUATIONCHANGED,
        [EnumMember(Value = "PRINT_RULE_EVALUATION_CHANGED")]
        PRINTRULEEVALUATIONCHANGED,
        [EnumMember(Value = "REDLINING_CHANGED")]
        REDLININGCHANGED,
        [EnumMember(Value = "STATUS_ADDED")]
        STATUSADDED,
        [EnumMember(Value = "STATUS_CHANGED")]
        STATUSCHANGED,
        [EnumMember(Value = "STATUS_DELETED")]
        STATUSDELETED,
        [EnumMember(Value = "STATUS_PRIVILEGES_CHANGED")]
        STATUSPRIVILEGESCHANGED,
        [EnumMember(Value = "STATUS_PRIVILEGES_DELETED")]
        STATUSPRIVILEGESDELETED,
        [EnumMember(Value = "STATUS_REASSIGNED")]
        STATUSREASSIGNED,
        [EnumMember(Value = "STATUS_ROUTING_USERCLASSES_CHANGED")]
        STATUSROUTINGUSERCLASSESCHANGED,
        [EnumMember(Value = "STATUS_TRANSITION_CHANGED")]
        STATUSTRANSITIONCHANGED,
        [EnumMember(Value = "WORKFLOW_ADDED")]
        WORKFLOWADDED,
        [EnumMember(Value = "WORKFLOW_CHANGED")]
        WORKFLOWCHANGED,
        [EnumMember(Value = "WORKFLOW_CONTENT_TYPES_CHANGED")]
        WORKFLOWCONTENTTYPESCHANGED,
        [EnumMember(Value = "WORKFLOW_DELETED")]
        WORKFLOWDELETED,
        [EnumMember(Value = "WORKFLOW_OVERRIDDEN_ATTRIBUTE_CONSTRAINTS_CHANGED")]
        WORKFLOWOVERRIdDENATTRIBUTECONSTRAINTSCHANGED,
        [EnumMember(Value = "WORKFLOW_OVERRIDDEN_STATUS_TRANSITIONS_CHANGED")]
        WORKFLOWOVERRIdDENSTATUSTRANSITIONSCHANGED,
        [EnumMember(Value = "SERVER_SHUTDOWN_TIME_APPROACHING")]
        SERVERSHUTDOWNTIMEAPPROACHING
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Qppngintegrationhub;

    public partial class WorkflowManagedActions
    {
        public QppngintegrationhubActions Qppngintegrationhub(string connectionId) => new QppngintegrationhubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public QppngintegrationhubTriggers Qppngintegrationhub(string connectionId) => new QppngintegrationhubTriggers(connectionId);
    }
}
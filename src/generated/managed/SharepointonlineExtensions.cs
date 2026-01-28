//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SharepointonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetAllTables(Expression<Func<string>> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/alltables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> ApproveHubSiteJoin(Expression<Func<string>> dataset, Expression<Func<string>> joiningSiteId)
        {
            var apiCallPath = String.Format("/datasets/{0}/approvehubsitejoin", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["joiningSiteId"] = ExpressionConverter.Convert(joiningSiteId);
            return new ApiConnectionAction<ApproveHubSiteJoinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CancelHubSiteJoinApproval(Expression<Func<string>> dataset, Expression<Func<string>> approvalCorrelationId = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/cancelhubsitejoinapproval", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SharingLinkPermission> CreateSharingLink(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> permissionlinkType, Expression<Func<string>> permissionlinkScope, Expression<Func<string>> permissionlinkExpiration = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/codeless/_api/v2.0/sites/root/lists/{1}/items/{2}/driveItem/createLink", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var permission = new JObject();
            var permissionpropCount = 0;
            permissionpropCount++;
            permission["type"] = ExpressionConverter.ConvertO(permissionlinkType);
            permissionpropCount++;
            permission["scope"] = ExpressionConverter.ConvertO(permissionlinkScope);
            if (permissionlinkExpiration != null)
            {
                permission["expirationDateTime"] = ExpressionConverter.ConvertO(permissionlinkExpiration);
                permissionpropCount++;
            }

            if (permissionpropCount > 0)
            {
                callPayload.Body = permission;
            }

            return new ApiConnectionAction<SharingLinkPermission>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/copyFile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFileAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfileToCopy, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFileIsAlreadyThere)
        {
            var apiCallPath = String.Format("/datasets/{0}/copyFileAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFileId"] = ExpressionConverter.ConvertO(parametersfileToCopy);
            parameterspropCount++;
            parameters["destinationDataset"] = ExpressionConverter.ConvertO(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(parametersifAnotherFileIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFolderAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfolderToCopy, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFolderIsAlreadyThere)
        {
            var apiCallPath = String.Format("/datasets/{0}/copyFolderAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFolderId"] = ExpressionConverter.ConvertO(parametersfolderToCopy);
            parameterspropCount++;
            parameters["destinationDataset"] = ExpressionConverter.ConvertO(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(parametersifAnotherFolderIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolderV2(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/extractFolderV2", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateFile(Expression<Func<string>> dataset, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadataResponse> UpdateFile(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder(Expression<Func<string>> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFileContentByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFolder", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFolderByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction HttpRequest(Expression<Func<string>> dataset, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parametersuri, Expression<Func<string>> parametersbody = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/httprequest", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["method"] = ExpressionConverter.ConvertO(parametersmethod);
            parameterspropCount++;
            parameters["uri"] = ExpressionConverter.ConvertO(parametersuri);
            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                parameters["headers"] = headersObject;
                parameterspropCount++;
            }

            if (parametersbody != null)
            {
                parameters["body"] = ExpressionConverter.ConvertO(parametersbody);
                parameterspropCount++;
            }

            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction JoinHubSite(Expression<Func<string>> dataset, Expression<Func<string>> hubSiteId, Expression<Func<string>> approvalToken = null, Expression<Func<string>> approvalCorrelationId = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/joinhubsite", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["hubSiteId"] = ExpressionConverter.Convert(hubSiteId);
            if (approvalToken != null)
                callPayload.Queries["approvalToken"] = ExpressionConverter.Convert(approvalToken);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFileAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfileToMove, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFileIsAlreadyThere)
        {
            var apiCallPath = String.Format("/datasets/{0}/moveFileAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFileId"] = ExpressionConverter.ConvertO(parametersfileToMove);
            parameterspropCount++;
            parameters["destinationDataset"] = ExpressionConverter.ConvertO(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(parametersifAnotherFileIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFolderAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfolderToMove, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFolderIsAlreadyThere)
        {
            var apiCallPath = String.Format("/datasets/{0}/moveFolderAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFolderId"] = ExpressionConverter.ConvertO(parametersfolderToMove);
            parameterspropCount++;
            parameters["destinationDataset"] = ExpressionConverter.ConvertO(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(parametersifAnotherFolderIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction NotifyHubSiteJoinApprovalStarted(Expression<Func<string>> dataset, Expression<Func<string>> approvalCorrelationId = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/notifyhubsitejoinapprovalstarted", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewDocumentSet(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> parametersdocumentSetPath, Expression<Func<string>> parameterscontentTypeId, Expression<Func<object>> parametersdynamicProperties = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/createnewdocumentset", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["path"] = ExpressionConverter.ConvertO(parametersdocumentSetPath);
            parameterspropCount++;
            parameters["contentTypeId"] = ExpressionConverter.ConvertO(parameterscontentTypeId);
            if (parametersdynamicProperties != null)
            {
                parameters["DynamicProperties"] = ExpressionConverter.ConvertO(parametersdynamicProperties);
                parameterspropCount++;
            }

            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewFolder(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> parametersfolderPath, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/createnewfolder", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["path"] = ExpressionConverter.ConvertO(parametersfolderPath);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListExpandedUser> SearchForUser(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> entityId, Expression<Func<string>> searchValue, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/entities/{2}/searchforuser", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(entityId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchValue"] = ExpressionConverter.Convert(searchValue);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<SPListExpandedUser>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> viewScopeOption = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/getfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (viewScopeOption != null)
                callPayload.Queries["viewScopeOption"] = ExpressionConverter.Convert(viewScopeOption);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> viewScopeOption = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (viewScopeOption != null)
                callPayload.Queries["viewScopeOption"] = ExpressionConverter.Convert(viewScopeOption);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApprovalData> CreateApprovalRequest(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<int>> approvalType, Expression<Func<object>> approvalSchema = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/approval", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["approvalType"] = ExpressionConverter.Convert(approvalType);
            callPayload.Body = ExpressionConverter.ConvertO(approvalSchema);
            return new ApiConnectionAction<ApprovalData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItemChanges(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> since, Expression<Func<string>> until = null, Expression<Func<bool>> includeDrafts = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/changes", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (until != null)
                callPayload.Queries["until"] = ExpressionConverter.Convert(until);
            callPayload.Queries["includeDrafts"] = Convert.ToString(false);
            if (includeDrafts != null)
                callPayload.Queries["includeDrafts"] = ExpressionConverter.Convert(includeDrafts);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckInFile(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parametercomments, Expression<Func<int>> parametercheckInType)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/checkinfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameter = new JObject();
            var parameterpropCount = 0;
            parameterpropCount++;
            parameter["comment"] = ExpressionConverter.ConvertO(parametercomments);
            parameterpropCount++;
            parameter["checkinType"] = ExpressionConverter.ConvertO(parametercheckInType);
            if (parameterpropCount > 0)
            {
                callPayload.Body = parameter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckOutFile(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/checkoutfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DiscardFileCheckOut(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/discardfilecheckout", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> GetFileItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/getfileitem", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction GrantAccess(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parameterrecipients, Expression<Func<string>> parameterroles, Expression<Func<string>> parametermessage = null, Expression<Func<bool>> parameternotifyRecipients = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/grantaccess", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameter = new JObject();
            var parameterpropCount = 0;
            parameterpropCount++;
            parameter["recipients"] = ExpressionConverter.ConvertO(parameterrecipients);
            parameterpropCount++;
            parameter["roleValue"] = ExpressionConverter.ConvertO(parameterroles);
            if (parametermessage != null)
            {
                parameter["emailBody"] = ExpressionConverter.ConvertO(parametermessage);
                parameterpropCount++;
            }

            if (parameternotifyRecipients != null)
            {
                parameter["sendEmail"] = ExpressionConverter.ConvertO(parameternotifyRecipients);
                parameterpropCount++;
            }

            if (parameterpropCount > 0)
            {
                callPayload.Body = parameter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchFileItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/patchfileitem", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> PatchFileItemWithPredictedValues(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parametersmodelId = null, Expression<Func<string>> parameterspredictResult = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/patchfileitemwithpredictedvalues", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            if (parametersmodelId != null)
            {
                parameters["modelId"] = ExpressionConverter.ConvertO(parametersmodelId);
                parameterspropCount++;
            }

            if (parameterspredictResult != null)
            {
                parameters["predictResult"] = ExpressionConverter.ConvertO(parameterspredictResult);
                parameterspropCount++;
            }

            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SetApprovalStatusOutput> SetApprovalStatus(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<approvalActionInput>> approvalAction, Expression<Func<string>> comments = null, Expression<Func<string>> entityTag = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/setapprovalstatus", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["approvalAction"] = ExpressionConverter.Convert(approvalAction);
            callPayload.Queries["comments"] = Convert.ToString("");
            if (comments != null)
                callPayload.Queries["comments"] = ExpressionConverter.Convert(comments);
            callPayload.Queries["entityTag"] = Convert.ToString("");
            if (entityTag != null)
                callPayload.Queries["entityTag"] = ExpressionConverter.Convert(entityTag);
            return new ApiConnectionAction<SetApprovalStatusOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction UnshareItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/unshare", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment[]> GetItemAttachments(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> itemId)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(itemId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPListItemAttachment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment> CreateAttachment(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> displayName, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["displayName"] = ExpressionConverter.Convert(displayName);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<SPListItemAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteAttachment(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetAttachmentContent(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}/$value", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateContentAssemblyDocument(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> template, Expression<Func<object>> item = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> fileName = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/templates/{2}/createnewdocument", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(template, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (fileName != null)
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Table[]> GetTableViews(Expression<Func<string>> dataset, Expression<Func<string>> table)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/views", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Table[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateAgreementsSolutionDocument(Expression<Func<string>> dataset, Expression<Func<string>> template, Expression<Func<object>> item = null, Expression<Func<string>> documentName = null, Expression<Func<string>> table = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/agreements/templates/{1}/createnewdocument", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(template, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (documentName != null)
                callPayload.Queries["documentName"] = ExpressionConverter.Convert(documentName);
            if (table != null)
                callPayload.Queries["table"] = ExpressionConverter.Convert(table);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }
    }

    public class SharepointonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> GetOnChangedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onchangeditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> GetOnDeletedFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/ondeletedfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> GetOnDeletedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/ondeleteditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> GetOnNewFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onnewfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> GetOnNewItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> GetOnUpdatedFileClassifiedTimes(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onupdatedfileclassifiedtimes", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> GetOnUpdatedFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onupdatedfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> GetOnUpdatedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnNewFile(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/triggers/onnewfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/triggers/onupdatedfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["includeFileContent"] = Convert.ToString(true);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class ApproveHubSiteJoinResponse
    {
        public string ApprovalToken { get; set; }
    }

    public class SharingLinkPermission
    {
        [JsonProperty("link")]
        public SharingLinkInfo Link { get; set; }
    }

    public class SharingLinkInfo
    {
        [JsonProperty("webUrl")]
        public string SharingLink { get; set; }
    }

    public class BlobMetadata
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public class SPBlobMetadataResponse
    {
        public int ItemId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public class BlobMetadataResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public enum parametersmethodInput
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }

    public class SPListExpandedUser
    {
        public string Claims { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        [JsonProperty("@odata.type")]
        public string Type { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class ApprovalData
    {
        [JsonProperty("ApprovalId")]
        public string ApprovalRequestID { get; set; }
    }

    public class SetApprovalStatusOutput
    {
        public string ETag { get; set; }
        public string ApprovalLink { get; set; }
        public string PublishStartDate { get; set; }
        public string ContentApprovalStatus { get; set; }
        public string ScheduledVersion { get; set; }
    }

    public enum approvalActionInput
    {
        Submit,
        Approve,
        Reject
    }

    public class SPListItemAttachment
    {
        public string Id { get; set; }
        public string AbsoluteUri { get; set; }
        public string DisplayName { get; set; }
    }

    public class DeletedItemList
    {
        [JsonProperty("value")]
        public DeletedItem[] Value { get; set; }
    }

    public class DeletedItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonProperty("FileNameWithExtension")]
        public string FilenameWithExtension { get; set; }

        [JsonProperty("DeletedByUserName")]
        public string DeletedBy { get; set; }
        public string TimeDeleted { get; set; }
        public bool IsFolder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline;

    public partial class WorkflowManagedActions
    {
        public SharepointonlineActions Sharepointonline(string connectionId) => new SharepointonlineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SharepointonlineTriggers Sharepointonline(string connectionId) => new SharepointonlineTriggers(connectionId);
    }
}
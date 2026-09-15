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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/alltables", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> ApproveHubSiteJoin(Expression<Func<string>> dataset, Expression<Func<string>> joiningSiteId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/approvehubsitejoin", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["joiningSiteId"] = CSharpExpressionConverter.ConvertO(joiningSiteId);
            return new ApiConnectionAction<ApproveHubSiteJoinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CancelHubSiteJoinApproval(Expression<Func<string>> dataset, Expression<Func<string>> approvalCorrelationId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/cancelhubsitejoinapproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = CSharpExpressionConverter.ConvertO(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SharingLinkPermission> CreateSharingLink(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> permissionlinkType, Expression<Func<string>> permissionlinkScope, Expression<Func<string>> permissionlinkExpiration = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/codeless/_api/v2.0/sites/root/lists/{1}/items/{2}/driveItem/createLink", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var permission = new JObject();
            var permissionpropCount = 0;
            permissionpropCount++;
            permission["type"] = CSharpExpressionConverter.ConvertToken(permissionlinkType);
            permissionpropCount++;
            permission["scope"] = CSharpExpressionConverter.ConvertToken(permissionlinkScope);
            if (permissionlinkExpiration != null)
            {
                permission["expirationDateTime"] = CSharpExpressionConverter.ConvertToken(permissionlinkExpiration);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = CSharpExpressionConverter.ConvertO(source);
            callPayload.Queries["destination"] = CSharpExpressionConverter.ConvertO(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = CSharpExpressionConverter.ConvertO(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFileAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfileToCopy, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFileIsAlreadyThere)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFileAsync", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFileId"] = CSharpExpressionConverter.ConvertToken(parametersfileToCopy);
            parameterspropCount++;
            parameters["destinationDataset"] = CSharpExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = CSharpExpressionConverter.ConvertToken(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = CSharpExpressionConverter.ConvertToken(parametersifAnotherFileIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFolderAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfolderToCopy, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFolderIsAlreadyThere)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFolderAsync", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFolderId"] = CSharpExpressionConverter.ConvertToken(parametersfolderToCopy);
            parameterspropCount++;
            parameters["destinationDataset"] = CSharpExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = CSharpExpressionConverter.ConvertToken(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = CSharpExpressionConverter.ConvertToken(parametersifAnotherFolderIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateFile(Expression<Func<string>> dataset, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadataResponse> UpdateFile(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}/content", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = CSharpExpressionConverter.ConvertO(inferContentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder(Expression<Func<string>> dataset)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            callPayload.SetHiddenQueryDefault("queryParametersSingleEncoded", true);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileContentByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = CSharpExpressionConverter.ConvertO(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolder", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolderByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction HttpRequest(Expression<Func<string>> dataset, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parametersuri, Expression<Func<string>> parametersbody = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/httprequest", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["method"] = CSharpExpressionConverter.Convert(parametersmethod);
            parameterspropCount++;
            parameters["uri"] = CSharpExpressionConverter.ConvertToken(parametersuri);
            var headersObject = new JObject();
            var headersObjectpropCount = 0;
            if (headersObjectpropCount > 0)
            {
                parameters["headers"] = headersObject;
                parameterspropCount++;
            }

            if (parametersbody != null)
            {
                parameters["body"] = CSharpExpressionConverter.ConvertToken(parametersbody);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/joinhubsite", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["hubSiteId"] = CSharpExpressionConverter.ConvertO(hubSiteId);
            if (approvalToken != null)
                callPayload.Queries["approvalToken"] = CSharpExpressionConverter.ConvertO(approvalToken);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = CSharpExpressionConverter.ConvertO(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFileAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfileToMove, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFileIsAlreadyThere)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFileAsync", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFileId"] = CSharpExpressionConverter.ConvertToken(parametersfileToMove);
            parameterspropCount++;
            parameters["destinationDataset"] = CSharpExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = CSharpExpressionConverter.ConvertToken(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = CSharpExpressionConverter.ConvertToken(parametersifAnotherFileIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFolderAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfolderToMove, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFolderIsAlreadyThere)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFolderAsync", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["sourceFolderId"] = CSharpExpressionConverter.ConvertToken(parametersfolderToMove);
            parameterspropCount++;
            parameters["destinationDataset"] = CSharpExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
            parameterspropCount++;
            parameters["destinationFolderPath"] = CSharpExpressionConverter.ConvertToken(parametersdestinationFolder);
            parameterspropCount++;
            parameters["nameConflictBehavior"] = CSharpExpressionConverter.ConvertToken(parametersifAnotherFolderIsAlreadyThere);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction NotifyHubSiteJoinApprovalStarted(Expression<Func<string>> dataset, Expression<Func<string>> approvalCorrelationId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/notifyhubsitejoinapprovalstarted", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = CSharpExpressionConverter.ConvertO(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewDocumentSet(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> parametersdocumentSetPath, Expression<Func<string>> parameterscontentTypeId, Expression<Func<object>> parametersdynamicProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewdocumentset", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["path"] = CSharpExpressionConverter.ConvertToken(parametersdocumentSetPath);
            parameterspropCount++;
            parameters["contentTypeId"] = CSharpExpressionConverter.ConvertToken(parameterscontentTypeId);
            if (parametersdynamicProperties != null)
            {
                parameters["DynamicProperties"] = CSharpExpressionConverter.ConvertToken(parametersdynamicProperties);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewfolder", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            var parameters = new JObject();
            var parameterspropCount = 0;
            parameterspropCount++;
            parameters["path"] = CSharpExpressionConverter.ConvertToken(parametersfolderPath);
            if (parameterspropCount > 0)
            {
                callPayload.Body = parameters;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListExpandedUser> SearchForUser(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> entityId, Expression<Func<string>> searchValue, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/entities/{2}/searchforuser", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchValue"] = CSharpExpressionConverter.ConvertO(searchValue);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionAction<SPListExpandedUser>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> viewScopeOption = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/getfileitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (viewScopeOption != null)
                callPayload.Queries["viewScopeOption"] = CSharpExpressionConverter.ConvertO(viewScopeOption);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> viewScopeOption = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (viewScopeOption != null)
                callPayload.Queries["viewScopeOption"] = CSharpExpressionConverter.ConvertO(viewScopeOption);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApprovalData> CreateApprovalRequest(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<int>> approvalType, Expression<Func<object>> approvalSchema = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/approval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["approvalType"] = CSharpExpressionConverter.ConvertO(approvalType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(approvalSchema);
            return new ApiConnectionAction<ApprovalData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItemChanges(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> since, Expression<Func<string>> until = null, Expression<Func<bool>> includeDrafts = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/changes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["since"] = CSharpExpressionConverter.ConvertO(since);
            if (until != null)
                callPayload.Queries["until"] = CSharpExpressionConverter.ConvertO(until);
            callPayload.Queries["includeDrafts"] = Convert.ToString(false);
            if (includeDrafts != null)
                callPayload.Queries["includeDrafts"] = CSharpExpressionConverter.ConvertO(includeDrafts);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckInFile(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parametercomments, Expression<Func<int>> parametercheckInType)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkinfile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameter = new JObject();
            var parameterpropCount = 0;
            parameterpropCount++;
            parameter["comment"] = CSharpExpressionConverter.ConvertToken(parametercomments);
            parameterpropCount++;
            parameter["checkinType"] = CSharpExpressionConverter.ConvertToken(parametercheckInType);
            if (parameterpropCount > 0)
            {
                callPayload.Body = parameter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckOutFile(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkoutfile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DiscardFileCheckOut(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/discardfilecheckout", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> GetFileItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/getfileitem", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction GrantAccess(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parameterrecipients, Expression<Func<string>> parameterroles, Expression<Func<string>> parametermessage = null, Expression<Func<bool>> parameternotifyRecipients = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/grantaccess", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameter = new JObject();
            var parameterpropCount = 0;
            parameterpropCount++;
            parameter["recipients"] = CSharpExpressionConverter.ConvertToken(parameterrecipients);
            parameterpropCount++;
            parameter["roleValue"] = CSharpExpressionConverter.ConvertToken(parameterroles);
            if (parametermessage != null)
            {
                parameter["emailBody"] = CSharpExpressionConverter.ConvertToken(parametermessage);
                parameterpropCount++;
            }

            if (parameternotifyRecipients != null)
            {
                parameter["sendEmail"] = CSharpExpressionConverter.ConvertToken(parameternotifyRecipients);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitem", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> PatchFileItemWithPredictedValues(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parametersmodelId = null, Expression<Func<string>> parameterspredictResult = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitemwithpredictedvalues", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var parameters = new JObject();
            var parameterspropCount = 0;
            if (parametersmodelId != null)
            {
                parameters["modelId"] = CSharpExpressionConverter.ConvertToken(parametersmodelId);
                parameterspropCount++;
            }

            if (parameterspredictResult != null)
            {
                parameters["predictResult"] = CSharpExpressionConverter.ConvertToken(parameterspredictResult);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/setapprovalstatus", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["approvalAction"] = CSharpExpressionConverter.Convert(approvalAction);
            callPayload.Queries["comments"] = Convert.ToString("");
            if (comments != null)
                callPayload.Queries["comments"] = CSharpExpressionConverter.ConvertO(comments);
            callPayload.Queries["entityTag"] = Convert.ToString("");
            if (entityTag != null)
                callPayload.Queries["entityTag"] = CSharpExpressionConverter.ConvertO(entityTag);
            return new ApiConnectionAction<SetApprovalStatusOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction UnshareItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/unshare", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment[]> GetItemAttachments(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> itemId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(itemId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPListItemAttachment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment> CreateAttachment(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> displayName, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["displayName"] = CSharpExpressionConverter.ConvertO(displayName);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<SPListItemAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteAttachment(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetAttachmentContent(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}/$value", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateContentAssemblyDocument(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> template, Expression<Func<object>> item = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> fileName = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/templates/{2}/createnewdocument", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(template, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (fileName != null)
                callPayload.Queries["fileName"] = CSharpExpressionConverter.ConvertO(fileName);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Table[]> GetTableViews(Expression<Func<string>> dataset, Expression<Func<string>> table)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/views", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Table[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateAgreementsSolutionDocument(Expression<Func<string>> dataset, Expression<Func<string>> template, Expression<Func<object>> item = null, Expression<Func<string>> documentName = null, Expression<Func<string>> table = null, Expression<Func<string>> view = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/agreements/templates/{1}/createnewdocument", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(template, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (documentName != null)
                callPayload.Queries["documentName"] = CSharpExpressionConverter.ConvertO(documentName);
            if (table != null)
                callPayload.Queries["table"] = CSharpExpressionConverter.ConvertO(table);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/extractFolderV2", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = CSharpExpressionConverter.ConvertO(source);
            callPayload.Queries["destination"] = CSharpExpressionConverter.ConvertO(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = CSharpExpressionConverter.ConvertO(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }
    }

    public class SharepointonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnChangedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onchangeditems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeletedfileitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeleteditems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewfileitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileClassifiedTimes(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileclassifiedtimes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdateditems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnNewFile(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onnewfile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = CSharpExpressionConverter.ConvertO(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onupdatedfile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            callPayload.Queries["includeFileContent"] = Convert.ToString(true);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = CSharpExpressionConverter.ConvertO(inferContentType);
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
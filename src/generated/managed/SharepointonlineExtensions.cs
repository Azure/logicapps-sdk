//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SharepointonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetAllTables([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/alltables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> ApproveHubSiteJoin([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> joiningSiteId)
        {
            var apiCallPath = String.Format("/datasets/{0}/approvehubsitejoin", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["joiningSiteId"] = ExpressionConverter.Convert(joiningSiteId);
            return new ApiConnectionAction<ApproveHubSiteJoinResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CancelHubSiteJoinApproval([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/cancelhubsitejoinapproval", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SharingLinkPermission> CreateSharingLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> permissionlinkType, [WorkflowExpression] Func<string> permissionlinkScope, [WorkflowExpression] Func<string> permissionlinkExpiration = null)
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
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFileAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> parametersfileToCopy, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFileIsAlreadyThere)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFolderAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> parametersfolderToCopy, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFolderIsAlreadyThere)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadata([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadataResponse> UpdateFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
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
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadataByPath([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> path)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadata([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFolder", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadataByPath([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> path)
        {
            var apiCallPath = String.Format("/datasets/{0}/GetFolderByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction HttpRequest([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parametersuri, [WorkflowExpression] Func<string> parametersbody = null)
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
        public IWorkflowAction JoinHubSite([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> hubSiteId, [WorkflowExpression] Func<string> approvalToken = null, [WorkflowExpression] Func<string> approvalCorrelationId = null)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFileAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> parametersfileToMove, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFileIsAlreadyThere)
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
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFolderAsync([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> parametersfolderToMove, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFolderIsAlreadyThere)
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
        public IWorkflowAction NotifyHubSiteJoinApprovalStarted([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/notifyhubsitejoinapprovalstarted", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (approvalCorrelationId != null)
                callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewDocumentSet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> parametersdocumentSetPath, [WorkflowExpression] Func<string> parameterscontentTypeId, [WorkflowExpression] Func<object> parametersdynamicProperties = null)
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
        public IBodyWorkflowAction<JToken> CreateNewFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> parametersfolderPath, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<SPListExpandedUser> SearchForUser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> searchValue, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<ItemsList> GetFileItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> viewScopeOption = null, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> viewScopeOption = null, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<ApprovalData> CreateApprovalRequest([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> approvalType, [WorkflowExpression] Func<object> approvalSchema = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/approval", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["approvalType"] = ExpressionConverter.Convert(approvalType);
            callPayload.Body = ExpressionConverter.ConvertO(approvalSchema);
            return new ApiConnectionAction<ApprovalData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItemChanges([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> since, [WorkflowExpression] Func<string> until = null, [WorkflowExpression] Func<bool> includeDrafts = null, [WorkflowExpression] Func<string> view = null)
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
        public IWorkflowAction CheckInFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parametercomments, [WorkflowExpression] Func<int> parametercheckInType)
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
        public IWorkflowAction CheckOutFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/checkoutfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DiscardFileCheckOut([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/discardfilecheckout", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> GetFileItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> view = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/getfileitem", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction GrantAccess([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parameterrecipients, [WorkflowExpression] Func<string> parameterroles, [WorkflowExpression] Func<string> parametermessage = null, [WorkflowExpression] Func<bool> parameternotifyRecipients = null)
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
        public IBodyWorkflowAction<JToken> PatchFileItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<Item> PatchFileItemWithPredictedValues([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parametersmodelId = null, [WorkflowExpression] Func<string> parameterspredictResult = null)
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
        public IBodyWorkflowAction<SetApprovalStatusOutput> SetApprovalStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<approvalActionInput> approvalAction, [WorkflowExpression] Func<string> comments = null, [WorkflowExpression] Func<string> entityTag = null)
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
        public IWorkflowAction UnshareItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/unshare", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment[]> GetItemAttachments([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> itemId)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(itemId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SPListItemAttachment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment> CreateAttachment([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> displayName, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["displayName"] = ExpressionConverter.Convert(displayName);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<SPListItemAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteAttachment([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<int> itemId, [WorkflowExpression] Func<string> attachmentId)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetAttachmentContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<int> itemId, [WorkflowExpression] Func<string> attachmentId)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}/$value", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateContentAssemblyDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> template, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> fileName = null, [WorkflowExpression] Func<string> view = null)
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
        public IBodyWorkflowAction<Table[]> GetTableViews([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/views", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Table[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateAgreementsSolutionDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> template, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> documentName = null, [WorkflowExpression] Func<string> table = null, [WorkflowExpression] Func<string> view = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
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
    }

    public class SharepointonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnChangedItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
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

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedFileItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/ondeletedfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/ondeleteditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewFileItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
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

        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileClassifiedTimes([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
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

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
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

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
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

        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
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
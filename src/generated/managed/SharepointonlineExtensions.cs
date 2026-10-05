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
        [WorkflowExpressionFactory(nameof(__BuildGetAllTables))]
        public IBodyWorkflowAction<TablesList> GetAllTables([WorkflowExpression] Func<string> dataset)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TablesList> __BuildGetAllTables(WorkflowValue<string> dataset)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/alltables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildApproveHubSiteJoin))]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> ApproveHubSiteJoin([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> joiningSiteId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> __BuildApproveHubSiteJoin(WorkflowValue<string> dataset, WorkflowValue<string> joiningSiteId)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(joiningSiteId, nameof(joiningSiteId), required: true);
            return new DeferredBodyAction<ApproveHubSiteJoinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/approvehubsitejoin", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["joiningSiteId"] = ExpressionConverter.Convert(joiningSiteId);
                return new ApiConnectionAction<ApproveHubSiteJoinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCancelHubSiteJoinApproval))]
        public IWorkflowAction CancelHubSiteJoinApproval([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelHubSiteJoinApproval(WorkflowValue<string> dataset, WorkflowValue<string> approvalCorrelationId = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/cancelhubsitejoinapproval", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSharingLink))]
        public IBodyWorkflowAction<SharingLinkPermission> CreateSharingLink([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> permissionlinkType, [WorkflowExpression] Func<string> permissionlinkScope, [WorkflowExpression] Func<string> permissionlinkExpiration = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharingLinkPermission> __BuildCreateSharingLink(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> permissionlinkType, WorkflowValue<string> permissionlinkScope, WorkflowValue<string> permissionlinkExpiration = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(permissionlinkType, nameof(permissionlinkType), required: true);
            WorkflowValue.Validate(permissionlinkScope, nameof(permissionlinkScope), required: true);
            WorkflowValue.Validate(permissionlinkExpiration, nameof(permissionlinkExpiration), required: false);
            return new DeferredBodyAction<SharingLinkPermission>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/codeless/_api/v2.0/sites/root/lists/{1}/items/{2}/driveItem/createLink", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyFile(WorkflowValue<string> dataset, WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFileAsync))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFileAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfileToCopy, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFileIsAlreadyThere)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildCopyFileAsync(WorkflowValue<string> dataset, WorkflowValue<string> parametersfileToCopy, WorkflowValue<string> parametersdestinationSiteAddress, WorkflowValue<string> parametersdestinationFolder, WorkflowValue<int> parametersifAnotherFileIsAlreadyThere)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(parametersfileToCopy, nameof(parametersfileToCopy), required: true);
            WorkflowValue.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            WorkflowValue.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            WorkflowValue.Validate(parametersifAnotherFileIsAlreadyThere, nameof(parametersifAnotherFileIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFileAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFolderAsync))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFolderAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfolderToCopy, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFolderIsAlreadyThere)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildCopyFolderAsync(WorkflowValue<string> dataset, WorkflowValue<string> parametersfolderToCopy, WorkflowValue<string> parametersdestinationSiteAddress, WorkflowValue<string> parametersdestinationFolder, WorkflowValue<int> parametersifAnotherFolderIsAlreadyThere)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(parametersfolderToCopy, nameof(parametersfolderToCopy), required: true);
            WorkflowValue.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            WorkflowValue.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            WorkflowValue.Validate(parametersifAnotherFolderIsAlreadyThere, nameof(parametersifAnotherFolderIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFolderAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildCreateFile(WorkflowValue<string> dataset, WorkflowValue<string> folderPath, WorkflowValue<string> name, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadata))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadata([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildGetFileMetadata(WorkflowValue<string> dataset, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<BlobMetadataResponse> UpdateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadataResponse> __BuildUpdateFile(WorkflowValue<string> dataset, WorkflowValue<string> id, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFile(WorkflowValue<string> dataset, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContent(WorkflowValue<string> dataset, WorkflowValue<string> id, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildListRootFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder([WorkflowExpression] Func<string> dataset)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildListRootFolder(WorkflowValue<string> dataset)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildListFolder(WorkflowValue<string> dataset, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadataByPath))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadataByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildGetFileMetadataByPath(WorkflowValue<string> dataset, WorkflowValue<string> path)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentByPath))]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContentByPath(WorkflowValue<string> dataset, WorkflowValue<string> path, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileContentByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFolderMetadata))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadata([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildGetFolderMetadata(WorkflowValue<string> dataset, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolder", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFolderMetadataByPath))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadataByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildGetFolderMetadataByPath(WorkflowValue<string> dataset, WorkflowValue<string> path)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolderByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IWorkflowAction HttpRequest([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parametersuri, [WorkflowExpression] Func<string> parametersbody = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHttpRequest(WorkflowValue<string> dataset, WorkflowValue<parametersmethodInput> parametersmethod, WorkflowValue<string> parametersuri, WorkflowValue<string> parametersbody = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(parametersmethod, nameof(parametersmethod), required: true);
            WorkflowValue.Validate(parametersuri, nameof(parametersuri), required: true);
            WorkflowValue.Validate(parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/httprequest", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildJoinHubSite))]
        public IWorkflowAction JoinHubSite([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> hubSiteId, [WorkflowExpression] Func<string> approvalToken = null, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildJoinHubSite(WorkflowValue<string> dataset, WorkflowValue<string> hubSiteId, WorkflowValue<string> approvalToken = null, WorkflowValue<string> approvalCorrelationId = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(hubSiteId, nameof(hubSiteId), required: true);
            WorkflowValue.Validate(approvalToken, nameof(approvalToken), required: false);
            WorkflowValue.Validate(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/joinhubsite", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hubSiteId"] = ExpressionConverter.Convert(hubSiteId);
                if (approvalToken != null)
                    callPayload.Queries["approvalToken"] = ExpressionConverter.Convert(approvalToken);
                if (approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFileAsync))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFileAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfileToMove, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFileIsAlreadyThere)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildMoveFileAsync(WorkflowValue<string> dataset, WorkflowValue<string> parametersfileToMove, WorkflowValue<string> parametersdestinationSiteAddress, WorkflowValue<string> parametersdestinationFolder, WorkflowValue<int> parametersifAnotherFileIsAlreadyThere)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(parametersfileToMove, nameof(parametersfileToMove), required: true);
            WorkflowValue.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            WorkflowValue.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            WorkflowValue.Validate(parametersifAnotherFileIsAlreadyThere, nameof(parametersifAnotherFileIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFileAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFolderAsync))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFolderAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfolderToMove, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFolderIsAlreadyThere)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildMoveFolderAsync(WorkflowValue<string> dataset, WorkflowValue<string> parametersfolderToMove, WorkflowValue<string> parametersdestinationSiteAddress, WorkflowValue<string> parametersdestinationFolder, WorkflowValue<int> parametersifAnotherFolderIsAlreadyThere)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(parametersfolderToMove, nameof(parametersfolderToMove), required: true);
            WorkflowValue.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            WorkflowValue.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            WorkflowValue.Validate(parametersifAnotherFolderIsAlreadyThere, nameof(parametersifAnotherFolderIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFolderAsync", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildNotifyHubSiteJoinApprovalStarted))]
        public IWorkflowAction NotifyHubSiteJoinApprovalStarted([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNotifyHubSiteJoinApprovalStarted(WorkflowValue<string> dataset, WorkflowValue<string> approvalCorrelationId = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/notifyhubsitejoinapprovalstarted", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(approvalCorrelationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> dataset)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TablesList> __BuildGetTables(WorkflowValue<string> dataset)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNewDocumentSet))]
        public IBodyWorkflowAction<JToken> CreateNewDocumentSet([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> parametersdocumentSetPath, [WorkflowExpression] Func<string> parameterscontentTypeId, [WorkflowExpression] Func<object> parametersdynamicProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateNewDocumentSet(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> parametersdocumentSetPath, WorkflowValue<string> parameterscontentTypeId, WorkflowValue<object> parametersdynamicProperties = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(parametersdocumentSetPath, nameof(parametersdocumentSetPath), required: true);
            WorkflowValue.Validate(parameterscontentTypeId, nameof(parameterscontentTypeId), required: true);
            WorkflowValue.Validate(parametersdynamicProperties, nameof(parametersdynamicProperties), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewdocumentset", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNewFolder))]
        public IBodyWorkflowAction<JToken> CreateNewFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> parametersfolderPath, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateNewFolder(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> parametersfolderPath, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(parametersfolderPath, nameof(parametersfolderPath), required: true);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewfolder", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildSearchForUser))]
        public IBodyWorkflowAction<SPListExpandedUser> SearchForUser([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> searchValue, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPListExpandedUser> __BuildSearchForUser(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> entityId, WorkflowValue<string> searchValue, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(searchValue, nameof(searchValue), required: true);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<SPListExpandedUser>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/entities/{2}/searchforuser", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(entityId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(searchValue);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionAction<SPListExpandedUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileItems))]
        public IBodyWorkflowAction<ItemsList> GetFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> viewScopeOption = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetFileItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<string> folderPath = null, WorkflowValue<string> viewScopeOption = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(viewScopeOption, nameof(viewScopeOption), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/getfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> viewScopeOption = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<string> folderPath = null, WorkflowValue<string> viewScopeOption = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(viewScopeOption, nameof(viewScopeOption), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildPostItem))]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<object> item = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<object> item = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateApprovalRequest))]
        public IBodyWorkflowAction<ApprovalData> CreateApprovalRequest([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> approvalType, [WorkflowExpression] Func<object> approvalSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApprovalData> __BuildCreateApprovalRequest(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<int> approvalType, WorkflowValue<object> approvalSchema = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(approvalType, nameof(approvalType), required: true);
            WorkflowValue.Validate(approvalSchema, nameof(approvalSchema), required: false);
            return new DeferredBodyAction<ApprovalData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/approval", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["approvalType"] = ExpressionConverter.Convert(approvalType);
                callPayload.Body = ExpressionConverter.ConvertO(approvalSchema);
                return new ApiConnectionAction<ApprovalData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemChanges))]
        public IBodyWorkflowAction<JToken> GetItemChanges([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> since, [WorkflowExpression] Func<string> until = null, [WorkflowExpression] Func<bool> includeDrafts = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItemChanges(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> since, WorkflowValue<string> until = null, WorkflowValue<bool> includeDrafts = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(since, nameof(since), required: true);
            WorkflowValue.Validate(until, nameof(until), required: false);
            WorkflowValue.Validate(includeDrafts, nameof(includeDrafts), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/changes", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCheckInFile))]
        public IWorkflowAction CheckInFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parametercomments, [WorkflowExpression] Func<int> parametercheckInType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckInFile(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> parametercomments, WorkflowValue<int> parametercheckInType)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(parametercomments, nameof(parametercomments), required: true);
            WorkflowValue.Validate(parametercheckInType, nameof(parametercheckInType), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkinfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCheckOutFile))]
        public IWorkflowAction CheckOutFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckOutFile(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkoutfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildDiscardFileCheckOut))]
        public IWorkflowAction DiscardFileCheckOut([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDiscardFileCheckOut(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/discardfilecheckout", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileItem))]
        public IBodyWorkflowAction<Item> GetFileItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildGetFileItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/getfileitem", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGrantAccess))]
        public IWorkflowAction GrantAccess([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parameterrecipients, [WorkflowExpression] Func<string> parameterroles, [WorkflowExpression] Func<string> parametermessage = null, [WorkflowExpression] Func<bool> parameternotifyRecipients = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGrantAccess(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> parameterrecipients, WorkflowValue<string> parameterroles, WorkflowValue<string> parametermessage = null, WorkflowValue<bool> parameternotifyRecipients = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(parameterrecipients, nameof(parameterrecipients), required: true);
            WorkflowValue.Validate(parameterroles, nameof(parameterroles), required: true);
            WorkflowValue.Validate(parametermessage, nameof(parametermessage), required: false);
            WorkflowValue.Validate(parameternotifyRecipients, nameof(parameternotifyRecipients), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/grantaccess", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildPatchFileItem))]
        public IBodyWorkflowAction<JToken> PatchFileItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchFileItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<object> item = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitem", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildPatchFileItemWithPredictedValues))]
        public IBodyWorkflowAction<Item> PatchFileItemWithPredictedValues([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parametersmodelId = null, [WorkflowExpression] Func<string> parameterspredictResult = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildPatchFileItemWithPredictedValues(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<string> parametersmodelId = null, WorkflowValue<string> parameterspredictResult = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(parametersmodelId, nameof(parametersmodelId), required: false);
            WorkflowValue.Validate(parameterspredictResult, nameof(parameterspredictResult), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitemwithpredictedvalues", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildSetApprovalStatus))]
        public IBodyWorkflowAction<SetApprovalStatusOutput> SetApprovalStatus([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<approvalActionInput> approvalAction, [WorkflowExpression] Func<string> comments = null, [WorkflowExpression] Func<string> entityTag = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetApprovalStatusOutput> __BuildSetApprovalStatus(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id, WorkflowValue<approvalActionInput> approvalAction, WorkflowValue<string> comments = null, WorkflowValue<string> entityTag = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(approvalAction, nameof(approvalAction), required: true);
            WorkflowValue.Validate(comments, nameof(comments), required: false);
            WorkflowValue.Validate(entityTag, nameof(entityTag), required: false);
            return new DeferredBodyAction<SetApprovalStatusOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/setapprovalstatus", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildUnshareItem))]
        public IWorkflowAction UnshareItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnshareItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/unshare", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemAttachments))]
        public IBodyWorkflowAction<SPListItemAttachment[]> GetItemAttachments([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPListItemAttachment[]> __BuildGetItemAttachments(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> itemId)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(itemId, nameof(itemId), required: true);
            return new DeferredBodyAction<SPListItemAttachment[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(itemId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SPListItemAttachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAttachment))]
        public IBodyWorkflowAction<SPListItemAttachment> CreateAttachment([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> displayName, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPListItemAttachment> __BuildCreateAttachment(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> itemId, WorkflowValue<string> displayName, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(itemId, nameof(itemId), required: true);
            WorkflowValue.Validate(displayName, nameof(displayName), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<SPListItemAttachment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["displayName"] = ExpressionConverter.Convert(displayName);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SPListItemAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAttachment))]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> attachmentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAttachment(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> itemId, WorkflowValue<string> attachmentId)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(itemId, nameof(itemId), required: true);
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachmentContent))]
        public IBodyWorkflowAction<string> GetAttachmentContent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> attachmentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetAttachmentContent(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> itemId, WorkflowValue<string> attachmentId)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(itemId, nameof(itemId), required: true);
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}/$value", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncodingWithInt(itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContentAssemblyDocument))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateContentAssemblyDocument([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> template, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> fileName = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildCreateContentAssemblyDocument(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> template, WorkflowValue<object> item = null, WorkflowValue<string> folderPath = null, WorkflowValue<string> fileName = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(template, nameof(template), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(fileName, nameof(fileName), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/templates/{2}/createnewdocument", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(template, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetTableViews))]
        public IBodyWorkflowAction<Table[]> GetTableViews([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Table[]> __BuildGetTableViews(WorkflowValue<string> dataset, WorkflowValue<string> table)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyAction<Table[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/views", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Table[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAgreementsSolutionDocument))]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateAgreementsSolutionDocument([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> template, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> documentName = null, [WorkflowExpression] Func<string> table = null, [WorkflowExpression] Func<string> view = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPBlobMetadataResponse> __BuildCreateAgreementsSolutionDocument(WorkflowValue<string> dataset, WorkflowValue<string> template, WorkflowValue<object> item = null, WorkflowValue<string> documentName = null, WorkflowValue<string> table = null, WorkflowValue<string> view = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(template, nameof(template), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(documentName, nameof(documentName), required: false);
            WorkflowValue.Validate(table, nameof(table), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/agreements/templates/{1}/createnewdocument", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(template, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildExtractFolder(WorkflowValue<string> dataset, WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/extractFolderV2", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }
    }

    public class SharepointonlineTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnChangedItems))]
        public IBodyWorkflowTrigger<ItemsList> OnChangedItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnChangedItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> folderPath = null, WorkflowValue<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onchangeditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnDeletedFileItems))]
        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<DeletedItemList> __BuildOnDeletedFileItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> folderPath = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            return new DeferredBodyTrigger<DeletedItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeletedfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnDeletedItems))]
        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<DeletedItemList> __BuildOnDeletedItems(WorkflowValue<string> dataset, WorkflowValue<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            return new DeferredBodyTrigger<DeletedItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeleteditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<DeletedItemList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFileItems))]
        public IBodyWorkflowTrigger<ItemsList> OnNewFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnNewFileItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> folderPath = null, WorkflowValue<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewItems))]
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnNewItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFileClassifiedTimes))]
        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileClassifiedTimes([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnUpdatedFileClassifiedTimes(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> folderPath = null, WorkflowValue<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileclassifiedtimes", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFileItems))]
        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnUpdatedFileItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> folderPath = null, WorkflowValue<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileitems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedItems))]
        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ItemsList> __BuildOnUpdatedItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFile))]
        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnNewFile(WorkflowValue<string> dataset, WorkflowValue<string> folderId, WorkflowValue<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onnewfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFile))]
        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnUpdatedFile(WorkflowValue<string> dataset, WorkflowValue<string> folderId, WorkflowValue<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onupdatedfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
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

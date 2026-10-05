//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onedrive
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnedriveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadata))]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildGetFileMetadata(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildUpdateFile(WorkflowValue<string> id, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFile(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadataByPath))]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath([WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildGetFileMetadataByPath(WorkflowValue<string> path)
        {
            WorkflowValue.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentByPath))]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContentByPath(WorkflowValue<string> path, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileContentByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContent(WorkflowValue<string> id, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCreateFile(WorkflowValue<string> folderPath, WorkflowValue<string> name, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyFile(WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/copyFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildCopyDriveFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyDriveFile(WorkflowValue<string> id, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildCopyDriveFileByPath))]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFileByPath([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyDriveFileByPath(WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/CopyFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFile))]
        public IBodyWorkflowAction<BlobMetadata> MoveFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildMoveFile(WorkflowValue<string> id, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/move", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFileByPath))]
        public IBodyWorkflowAction<BlobMetadata> MoveFileByPath([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildMoveFileByPath(WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/MoveFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildConvertFile))]
        public IBodyWorkflowAction<string> ConvertFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertFile(WorkflowValue<string> id, WorkflowValue<typeInput> type = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/convert", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("PDF");
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildConvertFileByPath))]
        public IBodyWorkflowAction<string> ConvertFileByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertFileByPath(WorkflowValue<string> path, WorkflowValue<typeInput> type = null)
        {
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/datasets/default/ConvertFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["type"] = Convert.ToString("PDF");
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileTags))]
        public IBodyWorkflowAction<TagsInfo> GetFileTags([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagsInfo> __BuildGetFileTags(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TagsInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagsInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildAddFileTag))]
        public IBodyWorkflowAction<TagsInfo> AddFileTag([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> tag)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagsInfo> __BuildAddFileTag(WorkflowValue<string> id, WorkflowValue<string> tag)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(tag, nameof(tag), required: true);
            return new DeferredBodyAction<TagsInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                return new ApiConnectionAction<TagsInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveFileTag))]
        public IWorkflowAction RemoveFileTag([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> tag)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveFileTag(WorkflowValue<string> id, WorkflowValue<string> tag)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(tag, nameof(tag), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileThumbnail))]
        public IBodyWorkflowAction<Thumbnail> GetFileThumbnail([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<sizeInput> size)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Thumbnail> __BuildGetFileThumbnail(WorkflowValue<string> id, WorkflowValue<sizeInput> size)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(size, nameof(size), required: true);
            return new DeferredBodyAction<Thumbnail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                return new ApiConnectionAction<Thumbnail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder()
        {
            var apiCallPath = "/datasets/default/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildFindFiles))]
        public IBodyWorkflowAction<BlobMetadata[]> FindFiles([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<findModeInput> findMode, [WorkflowExpression] Func<int> maxFileCount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildFindFiles(WorkflowValue<string> query, WorkflowValue<string> id, WorkflowValue<findModeInput> findMode, WorkflowValue<int> maxFileCount = null)
        {
            WorkflowValue.Validate(query, nameof(query), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(findMode, nameof(findMode), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/folders/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                callPayload.Queries["findMode"] = ExpressionConverter.Convert(findMode);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildFindFilesByPath))]
        public IBodyWorkflowAction<BlobMetadata[]> FindFilesByPath([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<findModeInput> findMode, [WorkflowExpression] Func<int> maxFileCount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildFindFilesByPath(WorkflowValue<string> query, WorkflowValue<string> path, WorkflowValue<findModeInput> findMode, WorkflowValue<int> maxFileCount = null)
        {
            WorkflowValue.Validate(query, nameof(query), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(findMode, nameof(findMode), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/findFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["findMode"] = ExpressionConverter.Convert(findMode);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildCreateShareLink))]
        public IBodyWorkflowAction<SharingLink> CreateShareLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharingLink> __BuildCreateShareLink(WorkflowValue<string> id, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<SharingLink>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/shareV2", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildCreateShareLinkByPath))]
        public IBodyWorkflowAction<SharingLink> CreateShareLinkByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharingLink> __BuildCreateShareLinkByPath(WorkflowValue<string> path, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<SharingLink>(() =>
            {
                var apiCallPath = "/datasets/default/CreateShareLinkByPathV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildExtractFolder(WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/extractFolderV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<BlobMetadataPage> ListFolder([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadataPage> __BuildListFolder(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadataPage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/foldersV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["skipToken"] = Convert.ToString("");
                callPayload.Queries["top"] = Convert.ToString(20);
                return new ApiConnectionAction<BlobMetadataPage>(callPayload);
            });
        }
    }

    public class OnedriveTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnDeletedFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnDeletedFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnDeletedFiles(WorkflowValue<string> folderId, WorkflowValue<bool> includeSubfolders = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/ondeletedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(includeSubfolders);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFile))]
        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnNewFile(WorkflowValue<string> folderId, WorkflowValue<bool> includeSubfolders = null, WorkflowValue<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onnewfilev2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(includeSubfolders);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnNewFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnNewFiles(WorkflowValue<string> folderId, WorkflowValue<bool> includeSubfolders = null, WorkflowValue<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onnewfilesv2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(includeSubfolders);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFile))]
        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnUpdatedFile(WorkflowValue<string> folderId, WorkflowValue<bool> includeSubfolders = null, WorkflowValue<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfilev2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(includeSubfolders);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnUpdatedFiles(WorkflowValue<string> folderId, WorkflowValue<bool> includeSubfolders = null, WorkflowValue<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onupdatedfilesv2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(includeSubfolders);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class BlobMetadata
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("NameNoExt")]
        public string NameWithoutExtension { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }

        [JsonProperty("LastModified")]
        public string LastModifiedTime { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
        public string LastModifiedBy { get; set; }
    }

    public enum typeInput
    {
        View,
        Edit,
        Embed
    }

    public class TagsInfo
    {
        public string[] Tags { get; set; }
    }

    public class Thumbnail
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public enum sizeInput
    {
        Small,
        Medium,
        Large
    }

    public enum findModeInput
    {
        OneDriveSearch,
        Pattern
    }

    public class SharingLink
    {
        [JsonProperty("WebUrl")]
        public string WebURL { get; set; }
    }

    public class BlobMetadataPage
    {
        [JsonProperty("value")]
        public BlobMetadata[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Onedrive;

    public partial class WorkflowManagedActions
    {
        public OnedriveActions Onedrive(string connectionId) => new OnedriveActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OnedriveTriggers Onedrive(string connectionId) => new OnedriveTriggers(connectionId);
    }
}

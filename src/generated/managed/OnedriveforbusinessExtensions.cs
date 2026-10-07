//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onedriveforbusiness
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnedriveforbusinessActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadata))]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildGetFileMetadata(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildUpdateFile(WorkflowExpression<string> id, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFile(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadataByPath))]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath([WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildGetFileMetadataByPath(WorkflowExpression<string> path)
        {
            WorkflowExpression.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentByPath))]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContentByPath(WorkflowExpression<string> path, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(path, nameof(path), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContent(WorkflowExpression<string> id, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCreateFile(WorkflowExpression<string> folderPath, WorkflowExpression<string> name, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyFile(WorkflowExpression<string> source, WorkflowExpression<string> destination, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCopyDriveFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyDriveFile(WorkflowExpression<string> id, WorkflowExpression<string> destination, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCopyDriveFileByPath))]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFileByPath([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyDriveFileByPath(WorkflowExpression<string> source, WorkflowExpression<string> destination, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFile))]
        public IBodyWorkflowAction<BlobMetadata> MoveFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildMoveFile(WorkflowExpression<string> id, WorkflowExpression<string> destination, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFileByPath))]
        public IBodyWorkflowAction<BlobMetadata> MoveFileByPath([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildMoveFileByPath(WorkflowExpression<string> source, WorkflowExpression<string> destination, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildConvertFile))]
        public IBodyWorkflowAction<string> ConvertFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertFile(WorkflowExpression<string> id, WorkflowExpression<typeInput> type = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildConvertFileByPath))]
        public IBodyWorkflowAction<string> ConvertFileByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertFileByPath(WorkflowExpression<string> path, WorkflowExpression<typeInput> type = null)
        {
            WorkflowExpression.Validate(path, nameof(path), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileThumbnail))]
        public IBodyWorkflowAction<Thumbnail> GetFileThumbnail([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<sizeInput> size)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Thumbnail> __BuildGetFileThumbnail(WorkflowExpression<string> id, WorkflowExpression<sizeInput> size)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(size, nameof(size), required: true);
            return new DeferredBodyAction<Thumbnail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                return new ApiConnectionAction<Thumbnail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder()
        {
            var apiCallPath = "/datasets/default/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildFindFiles))]
        public IBodyWorkflowAction<BlobMetadata[]> FindFiles([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<findModeInput> findMode, [WorkflowExpression] Func<int> maxFileCount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildFindFiles(WorkflowExpression<string> query, WorkflowExpression<string> id, WorkflowExpression<findModeInput> findMode, WorkflowExpression<int> maxFileCount = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(findMode, nameof(findMode), required: true);
            WorkflowExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildFindFilesByPath))]
        public IBodyWorkflowAction<BlobMetadata[]> FindFilesByPath([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<findModeInput> findMode, [WorkflowExpression] Func<int> maxFileCount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildFindFilesByPath(WorkflowExpression<string> query, WorkflowExpression<string> path, WorkflowExpression<findModeInput> findMode, WorkflowExpression<int> maxFileCount = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(path, nameof(path), required: true);
            WorkflowExpression.Validate(findMode, nameof(findMode), required: true);
            WorkflowExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateShareLink))]
        public IBodyWorkflowAction<SharingLink> CreateShareLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<scopeInput> scope = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharingLink> __BuildCreateShareLink(WorkflowExpression<string> id, WorkflowExpression<typeInput> type, WorkflowExpression<scopeInput> scope = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(scope, nameof(scope), required: false);
            return new DeferredBodyAction<SharingLink>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/shareV2", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                callPayload.Queries["scope"] = Convert.ToString("Anonymous");
                if (scope != null)
                    callPayload.Queries["scope"] = ExpressionConverter.Convert(scope);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateShareLinkByPath))]
        public IBodyWorkflowAction<SharingLink> CreateShareLinkByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<scopeInput> scope = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharingLink> __BuildCreateShareLinkByPath(WorkflowExpression<string> path, WorkflowExpression<typeInput> type, WorkflowExpression<scopeInput> scope = null)
        {
            WorkflowExpression.Validate(path, nameof(path), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(scope, nameof(scope), required: false);
            return new DeferredBodyAction<SharingLink>(() =>
            {
                var apiCallPath = "/datasets/default/CreateShareLinkByPathV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                callPayload.Queries["scope"] = Convert.ToString("Anonymous");
                if (scope != null)
                    callPayload.Queries["scope"] = ExpressionConverter.Convert(scope);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildExtractFolder(WorkflowExpression<string> source, WorkflowExpression<string> destination, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(source, nameof(source), required: true);
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<BlobMetadataPage> ListFolder([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadataPage> __BuildListFolder(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
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

    public class OnedriveforbusinessTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewFile))]
        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression] Func<string> folderId,[WorkflowExpression] Func<bool> includeSubfolders = null,[WorkflowExpression] Func<bool> inferContentType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnNewFile(WorkflowExpression<string> folderId,WorkflowExpression<bool> includeSubfolders = null,WorkflowExpression<bool> inferContentType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
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
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnNewFiles([WorkflowExpression] Func<string> folderId,[WorkflowExpression] Func<bool> includeSubfolders = null,[WorkflowExpression] Func<int> maxFileCount = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnNewFiles(WorkflowExpression<string> folderId,WorkflowExpression<bool> includeSubfolders = null,WorkflowExpression<int> maxFileCount = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
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
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFile))]
        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> folderId,[WorkflowExpression] Func<bool> includeSubfolders = null,[WorkflowExpression] Func<bool> inferContentType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnUpdatedFile(WorkflowExpression<string> folderId,WorkflowExpression<bool> includeSubfolders = null,WorkflowExpression<bool> inferContentType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
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
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> folderId,[WorkflowExpression] Func<bool> includeSubfolders = null,[WorkflowExpression] Func<int> maxFileCount = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnUpdatedFiles(WorkflowExpression<string> folderId,WorkflowExpression<bool> includeSubfolders = null,WorkflowExpression<int> maxFileCount = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(includeSubfolders, nameof(includeSubfolders), required: false);
            WorkflowExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
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
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        View,
        Edit
    }

    public class Thumbnail
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sizeInput
    {
        Small,
        Medium,
        Large
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum scopeInput
    {
        Anonymous,
        Organization
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Onedriveforbusiness;

    public partial class WorkflowManagedActions
    {
        public OnedriveforbusinessActions Onedriveforbusiness(string connectionId) => new OnedriveforbusinessActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OnedriveforbusinessTriggers Onedriveforbusiness(string connectionId) => new OnedriveforbusinessTriggers(connectionId);
    }
}
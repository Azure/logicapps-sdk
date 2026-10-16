//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onedrive
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OnedriveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile(Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileContentByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/copyFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFile(Expression<Func<string>> id, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFileByPath(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/CopyFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> MoveFile(Expression<Func<string>> id, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/move", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> MoveFileByPath(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/MoveFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> ConvertFile(Expression<Func<string>> id, Expression<Func<typeInput>> type = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/convert", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("PDF");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> ConvertFileByPath(Expression<Func<string>> path, Expression<Func<typeInput>> type = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/datasets/default/ConvertFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["type"] = Convert.ToString("PDF");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<TagsInfo> GetFileTags(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TagsInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagsInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<TagsInfo> AddFileTag(Expression<Func<string>> id, Expression<Func<string>> tag)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: true);
            return new DeferredBodyAction<TagsInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                return new ApiConnectionAction<TagsInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IWorkflowAction RemoveFileTag(Expression<Func<string>> id, Expression<Func<string>> tag)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<Thumbnail> GetFileThumbnail(Expression<Func<string>> id, Expression<Func<sizeInput>> size)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: true);
            return new DeferredBodyAction<Thumbnail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
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
        public IBodyWorkflowAction<BlobMetadata[]> FindFiles(Expression<Func<string>> query, Expression<Func<string>> id, Expression<Func<findModeInput>> findMode, Expression<Func<int>> maxFileCount = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_findMode = WorkflowExpression.Compile(findMode, nameof(findMode), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/folders/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["findMode"] = ExpressionConverter.Convert(__workflow_findMode);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata[]> FindFilesByPath(Expression<Func<string>> query, Expression<Func<string>> path, Expression<Func<findModeInput>> findMode, Expression<Func<int>> maxFileCount = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_findMode = WorkflowExpression.Compile(findMode, nameof(findMode), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/findFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["findMode"] = ExpressionConverter.Convert(__workflow_findMode);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<SharingLink> CreateShareLink(Expression<Func<string>> id, Expression<Func<typeInput>> type)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<SharingLink>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/shareV2", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<SharingLink> CreateShareLinkByPath(Expression<Func<string>> path, Expression<Func<typeInput>> type)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<SharingLink>(() =>
            {
                var apiCallPath = "/datasets/default/CreateShareLinkByPathV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/extractFolderV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadataPage> ListFolder(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadataPage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/foldersV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
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
        public IBodyWorkflowTrigger<BlobMetadata[]> OnDeletedFiles(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_includeSubfolders = WorkflowExpression.Compile(includeSubfolders, nameof(includeSubfolders), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/ondeletedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (__workflow_includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(__workflow_includeSubfolders);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string> OnNewFile(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_includeSubfolders = WorkflowExpression.Compile(includeSubfolders, nameof(includeSubfolders), required: false);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onnewfilev2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (__workflow_includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(__workflow_includeSubfolders);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnNewFiles(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<int>> maxFileCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_includeSubfolders = WorkflowExpression.Compile(includeSubfolders, nameof(includeSubfolders), required: false);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onnewfilesv2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (__workflow_includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(__workflow_includeSubfolders);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_includeSubfolders = WorkflowExpression.Compile(includeSubfolders, nameof(includeSubfolders), required: false);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfilev2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (__workflow_includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(__workflow_includeSubfolders);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["simulate"] = Convert.ToString(false);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<int>> maxFileCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_includeSubfolders = WorkflowExpression.Compile(includeSubfolders, nameof(includeSubfolders), required: false);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onupdatedfilesv2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeSubfolders"] = Convert.ToString(false);
                if (__workflow_includeSubfolders != null)
                    callPayload.Queries["includeSubfolders"] = ExpressionConverter.Convert(__workflow_includeSubfolders);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
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

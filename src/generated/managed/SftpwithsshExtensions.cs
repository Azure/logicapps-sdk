//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sftpwithssh
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SftpwithsshActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildUpdateFile(WorkflowValue<string> id, WorkflowValue<string> body = null, WorkflowValue<bool> readFileMetadataFromServer = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(readFileMetadataFromServer);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> skipDeleteIfFileNotFoundOnServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFile(WorkflowValue<string> id, WorkflowValue<bool> skipDeleteIfFileNotFoundOnServer = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(skipDeleteIfFileNotFoundOnServer, nameof(skipDeleteIfFileNotFoundOnServer), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
                if (skipDeleteIfFileNotFoundOnServer != null)
                    callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = ExpressionConverter.Convert(skipDeleteIfFileNotFoundOnServer);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCreateFile(WorkflowValue<string> folderPath, WorkflowValue<string> name, WorkflowValue<string> body = null, WorkflowValue<bool> readFileMetadataFromServer = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(readFileMetadataFromServer);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildRenameFile))]
        public IBodyWorkflowAction<BlobMetadataResponse> RenameFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> newName, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadataResponse> __BuildRenameFile(WorkflowValue<string> id, WorkflowValue<string> newName, WorkflowValue<bool> readFileMetadataFromServer = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(newName, nameof(newName), required: true);
            WorkflowValue.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            return new DeferredBodyAction<BlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/rename", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["newName"] = ExpressionConverter.Convert(newName);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(readFileMetadataFromServer);
                return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyFile(WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null, WorkflowValue<bool> readFileMetadataFromServer = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            WorkflowValue.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(readFileMetadataFromServer);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildListFolder(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder()
        {
            var apiCallPath = "/datasets/default/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<BlobMetadata> CreateFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCreateFolder(WorkflowValue<string> folderPath, WorkflowValue<string> name)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }
    }

    public class SftpwithsshTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFile))]
        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeFileContent = null, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnUpdatedFile(WorkflowValue<string> folderId, WorkflowValue<bool> includeFileContent = null, WorkflowValue<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(includeFileContent, nameof(includeFileContent), required: false);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                if (includeFileContent != null)
                    callPayload.Queries["includeFileContent"] = ExpressionConverter.Convert(includeFileContent);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnUpdatedFiles(WorkflowValue<string> folderId, WorkflowValue<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
                callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sftpwithssh;

    public partial class WorkflowManagedActions
    {
        public SftpwithsshActions Sftpwithssh(string connectionId) => new SftpwithsshActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SftpwithsshTriggers Sftpwithssh(string connectionId) => new SftpwithsshTriggers(connectionId);
    }
}

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sftpwithssh
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SftpwithsshActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile(Expression<Func<string>> id, Expression<Func<string>> body = null, Expression<Func<bool>> readFileMetadataFromServer = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_readFileMetadataFromServer = WorkflowExpression.Compile(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (__workflow_readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(__workflow_readFileMetadataFromServer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> id, Expression<Func<bool>> skipDeleteIfFileNotFoundOnServer = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_skipDeleteIfFileNotFoundOnServer = WorkflowExpression.Compile(skipDeleteIfFileNotFoundOnServer, nameof(skipDeleteIfFileNotFoundOnServer), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
                if (__workflow_skipDeleteIfFileNotFoundOnServer != null)
                    callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = ExpressionConverter.Convert(__workflow_skipDeleteIfFileNotFoundOnServer);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}/content", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<bool>> readFileMetadataFromServer = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_readFileMetadataFromServer = WorkflowExpression.Compile(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (__workflow_readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(__workflow_readFileMetadataFromServer);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadataResponse> RenameFile(Expression<Func<string>> id, Expression<Func<string>> newName, Expression<Func<bool>> readFileMetadataFromServer = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_newName = WorkflowExpression.Compile(newName, nameof(newName), required: true);
            var __workflow_readFileMetadataFromServer = WorkflowExpression.Compile(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            return new DeferredBodyAction<BlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}/rename", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["newName"] = ExpressionConverter.Convert(__workflow_newName);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (__workflow_readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(__workflow_readFileMetadataFromServer);
                return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null, Expression<Func<bool>> readFileMetadataFromServer = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            var __workflow_readFileMetadataFromServer = WorkflowExpression.Compile(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (__workflow_readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = ExpressionConverter.Convert(__workflow_readFileMetadataFromServer);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/folders/{0}", __workflow_id.WithUrlEncoding(2)));
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
        public IBodyWorkflowAction<BlobMetadata> CreateFolder(Expression<Func<string>> folderPath, Expression<Func<string>> name)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = "/datasets/default/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }
    }

    public class SftpwithsshTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> OnUpdatedFile(Expression<Func<string>> folderId, Expression<Func<bool>> includeFileContent = null, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_includeFileContent = WorkflowExpression.Compile(includeFileContent, nameof(includeFileContent), required: false);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                if (__workflow_includeFileContent != null)
                    callPayload.Queries["includeFileContent"] = ExpressionConverter.Convert(__workflow_includeFileContent);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles(Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
                callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
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

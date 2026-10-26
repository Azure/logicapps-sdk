//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DropboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata, ApiConnectionActionConfiguration> GetFileMetadata(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata, ApiConnectionActionConfiguration> UpdateFile(Expression<Func<string>> id, Expression<Func<string>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BlobMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFile(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/default/files/{0}", __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata, ApiConnectionActionConfiguration> GetFileMetadataByPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<BlobMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/GetFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFileContentByPath(Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFileContent(Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata, ApiConnectionActionConfiguration> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BlobMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata, ApiConnectionActionConfiguration> CopyFile(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata, ApiConnectionActionConfiguration>(() =>
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
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[], ApiConnectionActionConfiguration> ExtractFolder(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[], ApiConnectionActionConfiguration>(() =>
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

    public class DropboxTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> OnNewFile(Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onnewfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> OnUpdatedFile(Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BlobMetadata[], ApiConnectionTriggerConfiguration> OnNewFiles(Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onnewfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<BlobMetadata[], ApiConnectionTriggerConfiguration> OnUpdatedFiles(Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datasets/default/triggers/batch/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox;

    public partial class WorkflowManagedActions
    {
        public DropboxActions Dropbox(string connectionId) => new DropboxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DropboxTriggers Dropbox(string connectionId) => new DropboxTriggers(connectionId);
    }
}
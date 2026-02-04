//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DropboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile(Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath(Expression<Func<string>> path)
        {
            var apiCallPath = "/datasets/default/GetFileByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/datasets/default/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
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
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder()
        {
            var apiCallPath = "/datasets/default/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolderV2(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
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
        }
    }

    public class DropboxTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> OnNewFile(Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datasets/default/triggers/onnewfile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile(Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datasets/default/triggers/onupdatedfile";
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

        public IBodyWorkflowTrigger<BlobMetadata[]> OnNewFiles(Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datasets/default/triggers/batch/onnewfile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["maxFileCount"] = Convert.ToString(10);
            if (maxFileCount != null)
                callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
            return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles(Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datasets/default/triggers/batch/onupdatedfile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["maxFileCount"] = Convert.ToString(10);
            if (maxFileCount != null)
                callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
            return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
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
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
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IWorkflowAction DeleteFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath([WorkflowExpression] Func<string> path)
        {
            var apiCallPath = "/datasets/default/GetFileByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            var apiCallPath = "/datasets/default/GetFileContentByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = "/datasets/default/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFileByPath([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> MoveFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/move", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata> MoveFileByPath([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> ConvertFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<typeInput> type = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/convert", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = Convert.ToString("PDF");
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<string> ConvertFileByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<typeInput> type = null)
        {
            var apiCallPath = "/datasets/default/ConvertFileByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["type"] = Convert.ToString("PDF");
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<TagsInfo> GetFileTags([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagsInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<TagsInfo> AddFileTag([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> tag)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
            return new ApiConnectionAction<TagsInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IWorkflowAction RemoveFileTag([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> tag)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<Thumbnail> GetFileThumbnail([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<sizeInput> size)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<Thumbnail>(callPayload);
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
        public IBodyWorkflowAction<BlobMetadata[]> FindFiles([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> query, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<findModeInput> findMode, [WorkflowExpression] Func<int> maxFileCount = null)
        {
            var apiCallPath = String.Format("/datasets/default/folders/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            callPayload.Queries["findMode"] = ExpressionConverter.Convert(findMode);
            callPayload.Queries["maxFileCount"] = Convert.ToString(10);
            if (maxFileCount != null)
                callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata[]> FindFilesByPath([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<findModeInput> findMode, [WorkflowExpression] Func<int> maxFileCount = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<SharingLink> CreateShareLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<typeInput> type)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/shareV2", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<SharingLink>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<SharingLink> CreateShareLinkByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<typeInput> type)
        {
            var apiCallPath = "/datasets/default/CreateShareLinkByPathV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<SharingLink>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedrive")]
        public IBodyWorkflowAction<BlobMetadataPage> ListFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/foldersV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["skipToken"] = Convert.ToString("");
            callPayload.Queries["top"] = Convert.ToString(20);
            return new ApiConnectionAction<BlobMetadataPage>(callPayload);
        }
    }

    public class OnedriveTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BlobMetadata[]> OnDeletedFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnNewFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeSubfolders = null, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
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
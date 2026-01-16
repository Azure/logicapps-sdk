//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onedriveforbusiness
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnedriveforbusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile(Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath(Expression<Func<string>> path)
        {
            var apiCallPath = "/datasets/default/GetFileByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<SharingLink> CreateShareLinkV2(Expression<Func<string>> id, Expression<Func<typeInput>> type, Expression<Func<scopeInput>> scope = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/shareV2", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Queries["scope"] = Convert.ToString("Anonymous");
            if (scope != null)
                callPayload.Queries["scope"] = ExpressionConverter.Convert(scope);
            return new ApiConnectionAction<SharingLink>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<SharingLink> CreateShareLinkByPathV2(Expression<Func<string>> path, Expression<Func<typeInput>> type, Expression<Func<scopeInput>> scope = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/datasets/default/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
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
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFile(Expression<Func<string>> id, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> CopyDriveFileByPath(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> MoveFile(Expression<Func<string>> id, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata> MoveFileByPath(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<string> ConvertFile(Expression<Func<string>> id, Expression<Func<typeInput>> type = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/convert", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = Convert.ToString("PDF");
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<string> ConvertFileByPath(Expression<Func<string>> path, Expression<Func<typeInput>> type = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<Thumbnail> GetFileThumbnail(Expression<Func<string>> id, Expression<Func<sizeInput>> size)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<Thumbnail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadataPage> ListFolderV2(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/default/foldersV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["skipToken"] = Convert.ToString("");
            callPayload.Queries["top"] = Convert.ToString(20);
            return new ApiConnectionAction<BlobMetadataPage>(callPayload);
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
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata[]> FindFiles(Expression<Func<string>> query, Expression<Func<string>> id, Expression<Func<findModeInput>> findMode, Expression<Func<int>> maxFileCount = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onedriveforbusiness")]
        public IBodyWorkflowAction<BlobMetadata[]> FindFilesByPath(Expression<Func<string>> query, Expression<Func<string>> path, Expression<Func<findModeInput>> findMode, Expression<Func<int>> maxFileCount = null)
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
    }

    public class OnedriveforbusinessTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<string> OnNewFileV2(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<bool>> inferContentType = null, string triggerName = null)
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
            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> OnUpdatedFileV2(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<bool>> inferContentType = null, string triggerName = null)
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
            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<BlobMetadata[]> OnNewFilesV2(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<int>> maxFileCount = null, string triggerName = null)
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
            return new ApiConnectionTrigger<BlobMetadata[]>(callPayload);
        }

        public IOutputWorkflowTrigger<BlobMetadata[]> OnUpdatedFilesV2(Expression<Func<string>> folderId, Expression<Func<bool>> includeSubfolders = null, Expression<Func<int>> maxFileCount = null, string triggerName = null)
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
            return new ApiConnectionTrigger<BlobMetadata[]>(callPayload);
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

    public class SharingLink
    {
        [JsonProperty("WebUrl")]
        public string WebURL { get; set; }
    }

    public enum typeInput
    {
        PDF,
        GLB,
        HTML,
        JPG
    }

    public enum scopeInput
    {
        Anonymous,
        Organization
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

    public class BlobMetadataPage
    {
        [JsonProperty("value")]
        public BlobMetadata[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public enum findModeInput
    {
        OneDriveSearch,
        Pattern
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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
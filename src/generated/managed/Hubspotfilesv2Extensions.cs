//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotfilesv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotfilesv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IWorkflowAction DeleteFilesV3FilesFileIdGdprDeleteArchiveGDPR(Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/files/v3/files/{0}/gdpr-delete", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<File> GetFilesV3FilesFileIdGetById(Expression<Func<string>> fileId, Expression<Func<string>> properties = null)
        {
            var apiCallPath = String.Format("/files/v3/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            return new ApiConnectionAction<File>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IWorkflowAction DeleteFilesV3FilesFileIdArchive(Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/files/v3/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<File> PutFilesV3FilesFileIdReplace(Expression<Func<string>> fileId, Expression<Func<object>> file = null, Expression<Func<string>> charsetHunch = null, Expression<Func<string>> options = null)
        {
            var apiCallPath = String.Format("/files/v3/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<File>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<File> PatchFilesV3FilesFileIdUpdateProperties(Expression<Func<string>> fileId, Expression<Func<bodyaccessInput>> bodyaccess = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderPath = null, Expression<Func<bool>> bodyisUsableInContent = null, Expression<Func<int>> bodyexpiresAt = null)
        {
            var apiCallPath = String.Format("/files/v3/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccess != null)
            {
                body["access"] = ExpressionConverter.ConvertO(bodyaccess);
                bodypropCount++;
            }

            if (bodyparentFolderId != null)
            {
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyparentFolderPath != null)
            {
                body["parentFolderPath"] = ExpressionConverter.ConvertO(bodyparentFolderPath);
                bodypropCount++;
            }

            if (bodyisUsableInContent != null)
            {
                body["isUsableInContent"] = ExpressionConverter.ConvertO(bodyisUsableInContent);
                bodypropCount++;
            }

            if (bodyexpiresAt != null)
            {
                body["expiresAt"] = ExpressionConverter.ConvertO(bodyexpiresAt);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<File>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<File> PostFilesV3FilesUpload(Expression<Func<object>> file, Expression<Func<string>> fileName, Expression<Func<optionsAccessInput>> optionsAccess, Expression<Func<string>> folderId = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> charsetHunch = null, Expression<Func<int>> optionsTtl = null)
        {
            var apiCallPath = "/files/v3/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<File>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<SignedUrl> GetFilesV3FilesFileIdSignedUrlGetSignedUrl(Expression<Func<string>> fileId, Expression<Func<sizeInput>> size = null, Expression<Func<int>> expirationSeconds = null, Expression<Func<bool>> upscale = null)
        {
            var apiCallPath = String.Format("/files/v3/files/{0}/signed-url", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (expirationSeconds != null)
                callPayload.Queries["expirationSeconds"] = ExpressionConverter.Convert(expirationSeconds);
            if (upscale != null)
                callPayload.Queries["upscale"] = ExpressionConverter.Convert(upscale);
            return new ApiConnectionAction<SignedUrl>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<ImportFromUrlTaskLocator> PostFilesV3FilesImportFromUrlAsyncImportFromUrl(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyfolderPath = null, Expression<Func<bodyaccessInput>> bodyaccess = null, Expression<Func<bodyduplicateValidationScopeInput>> bodyduplicateValidationScope = null, Expression<Func<string>> bodyname = null, Expression<Func<bodyduplicateValidationStrategyInput>> bodyduplicateValidationStrategy = null, Expression<Func<string>> bodyttl = null, Expression<Func<bool>> bodyoverwrite = null, Expression<Func<string>> bodyfolderId = null)
        {
            var apiCallPath = "/files/v3/files/import-from-url/async";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfolderPath != null)
            {
                body["folderPath"] = ExpressionConverter.ConvertO(bodyfolderPath);
                bodypropCount++;
            }

            if (bodyaccess != null)
            {
                body["access"] = ExpressionConverter.ConvertO(bodyaccess);
                bodypropCount++;
            }

            if (bodyduplicateValidationScope != null)
            {
                body["duplicateValidationScope"] = ExpressionConverter.ConvertO(bodyduplicateValidationScope);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyduplicateValidationStrategy != null)
            {
                body["duplicateValidationStrategy"] = ExpressionConverter.ConvertO(bodyduplicateValidationStrategy);
                bodypropCount++;
            }

            if (bodyttl != null)
            {
                body["ttl"] = ExpressionConverter.ConvertO(bodyttl);
                bodypropCount++;
            }

            if (bodyoverwrite != null)
            {
                body["overwrite"] = ExpressionConverter.ConvertO(bodyoverwrite);
                bodypropCount++;
            }

            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyfolderId != null)
            {
                body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ImportFromUrlTaskLocator>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<FileStat> GetFilesV3FilesStatPathGetMetadata(Expression<Func<string>> path, Expression<Func<string[]>> properties = null)
        {
            var apiCallPath = String.Format("/files/v3/files/stat/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            return new ApiConnectionAction<FileStat>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<CollectionResponseFile> GetFilesV3FilesSearchDoSearch(Expression<Func<string[]>> properties = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<string>> id = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAtLte = null, Expression<Func<string>> createdAtGte = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAtLte = null, Expression<Func<string>> updatedAtGte = null, Expression<Func<string>> name = null, Expression<Func<string>> path = null, Expression<Func<int>> parentFolderId = null, Expression<Func<int>> size = null, Expression<Func<int>> height = null, Expression<Func<int>> width = null, Expression<Func<string>> encoding = null, Expression<Func<string>> type = null, Expression<Func<string>> extension = null, Expression<Func<string>> url = null, Expression<Func<bool>> isUsableInContent = null, Expression<Func<bool>> allowsAnonymousAccess = null)
        {
            var apiCallPath = "/files/v3/files/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAtLte != null)
                callPayload.Queries["createdAtLte"] = ExpressionConverter.Convert(createdAtLte);
            if (createdAtGte != null)
                callPayload.Queries["createdAtGte"] = ExpressionConverter.Convert(createdAtGte);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAtLte != null)
                callPayload.Queries["updatedAtLte"] = ExpressionConverter.Convert(updatedAtLte);
            if (updatedAtGte != null)
                callPayload.Queries["updatedAtGte"] = ExpressionConverter.Convert(updatedAtGte);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (path != null)
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            if (parentFolderId != null)
                callPayload.Queries["parentFolderId"] = ExpressionConverter.Convert(parentFolderId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (height != null)
                callPayload.Queries["height"] = ExpressionConverter.Convert(height);
            if (width != null)
                callPayload.Queries["width"] = ExpressionConverter.Convert(width);
            if (encoding != null)
                callPayload.Queries["encoding"] = ExpressionConverter.Convert(encoding);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (extension != null)
                callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
            if (url != null)
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
            if (isUsableInContent != null)
                callPayload.Queries["isUsableInContent"] = ExpressionConverter.Convert(isUsableInContent);
            if (allowsAnonymousAccess != null)
                callPayload.Queries["allowsAnonymousAccess"] = ExpressionConverter.Convert(allowsAnonymousAccess);
            return new ApiConnectionAction<CollectionResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<FileActionResponse> GetFilesV3FilesImportFromUrlAsyncTasksTaskIdStatusCheckImport(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/files/v3/files/import-from-url/async/tasks/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<Folder> GetFilesV3FoldersFolderIdGetById(Expression<Func<string>> folderId, Expression<Func<string[]>> properties = null)
        {
            var apiCallPath = String.Format("/files/v3/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            return new ApiConnectionAction<Folder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IWorkflowAction DeleteFilesV3FoldersFolderIdArchive(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/files/v3/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<Folder> PostFilesV3FoldersCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyparentPath = null)
        {
            var apiCallPath = "/files/v3/folders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyparentFolderId != null)
            {
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                bodypropCount++;
            }

            if (bodyparentPath != null)
            {
                body["parentPath"] = ExpressionConverter.ConvertO(bodyparentPath);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Folder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<CollectionResponseFolder> GetFilesV3FoldersSearchDoSearch(Expression<Func<string[]>> properties = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<int>> limit = null, Expression<Func<string[]>> sort = null, Expression<Func<string>> id = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAtLte = null, Expression<Func<string>> createdAtGte = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAtLte = null, Expression<Func<string>> updatedAtGte = null, Expression<Func<string>> name = null, Expression<Func<string>> path = null, Expression<Func<int>> parentFolderId = null)
        {
            var apiCallPath = "/files/v3/folders/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdAtLte != null)
                callPayload.Queries["createdAtLte"] = ExpressionConverter.Convert(createdAtLte);
            if (createdAtGte != null)
                callPayload.Queries["createdAtGte"] = ExpressionConverter.Convert(createdAtGte);
            if (updatedAt != null)
                callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(updatedAt);
            if (updatedAtLte != null)
                callPayload.Queries["updatedAtLte"] = ExpressionConverter.Convert(updatedAtLte);
            if (updatedAtGte != null)
                callPayload.Queries["updatedAtGte"] = ExpressionConverter.Convert(updatedAtGte);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (path != null)
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            if (parentFolderId != null)
                callPayload.Queries["parentFolderId"] = ExpressionConverter.Convert(parentFolderId);
            return new ApiConnectionAction<CollectionResponseFolder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<FolderActionResponse> GetFilesV3FoldersUpdateAsyncTasksTaskIdStatusCheckUpdateStatus(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/files/v3/folders/update/async/tasks/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FolderActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotfilesv2")]
        public IBodyWorkflowAction<FolderUpdateTaskLocator> PostFilesV3FoldersUpdateAsyncUpdateProperties(Expression<Func<string>> bodyid, Expression<Func<int>> bodyparentFolderId = null, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = "/files/v3/folders/update/async";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyparentFolderId != null)
            {
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FolderUpdateTaskLocator>(callPayload);
        }
    }

    public class Hubspotfilesv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class File
    {
        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("access")]
        public Access Access { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isUsableInContent")]
        public bool IsUsableInContent { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("expiresAt")]
        public int ExpiresAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("defaultHostingUrl")]
        public string DefaultHostingUrl { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public enum Access
    {
        [EnumMember(Value = "PUBLIC_INDEXABLE")]
        PUBLICINDEXABLE,
        [EnumMember(Value = "PUBLIC_NOT_INDEXABLE")]
        PUBLICNOTINDEXABLE,
        [EnumMember(Value = "HIDDEN_INDEXABLE")]
        HIDDENINDEXABLE,
        [EnumMember(Value = "HIDDEN_NOT_INDEXABLE")]
        HIDDENNOTINDEXABLE,
        [EnumMember(Value = "HIDDEN_PRIVATE")]
        HIDDENPRIVATE,
        PRIVATE
    }

    public enum bodyaccessInput
    {
        [EnumMember(Value = "PUBLIC_INDEXABLE")]
        PUBLICINDEXABLE,
        [EnumMember(Value = "PUBLIC_NOT_INDEXABLE")]
        PUBLICNOTINDEXABLE,
        [EnumMember(Value = "HIDDEN_INDEXABLE")]
        HIDDENINDEXABLE,
        [EnumMember(Value = "HIDDEN_NOT_INDEXABLE")]
        HIDDENNOTINDEXABLE,
        [EnumMember(Value = "HIDDEN_PRIVATE")]
        HIDDENPRIVATE,
        PRIVATE
    }

    public enum optionsAccessInput
    {
        [EnumMember(Value = "PUBLIC_INDEXABLE")]
        PUBLICINDEXABLE,
        [EnumMember(Value = "PUBLIC_NOT_INDEXABLE")]
        PUBLICNOTINDEXABLE,
        PRIVATE
    }

    public class SignedUrl
    {
        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public enum sizeInput
    {
        [EnumMember(Value = "thumb")]
        Thumb,
        [EnumMember(Value = "icon")]
        Icon,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "preview")]
        Preview
    }

    public class ImportFromUrlTaskLocator
    {
        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum bodyduplicateValidationScopeInput
    {
        [EnumMember(Value = "ENTIRE_PORTAL")]
        ENTIREPORTAL,
        [EnumMember(Value = "EXACT_FOLDER")]
        EXACTFOLDER
    }

    public enum bodyduplicateValidationStrategyInput
    {
        NONE,
        REJECT,
        [EnumMember(Value = "RETURN_EXISTING")]
        RETURNEXISTING
    }

    public class FileStat
    {
        [JsonProperty("file")]
        public File File { get; set; }

        [JsonProperty("folder")]
        public Folder Folder { get; set; }
    }

    public class Folder
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class CollectionResponseFile
    {
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonProperty("results")]
        public File[] Results { get; set; }
    }

    public class Paging
    {
        [JsonProperty("next")]
        public NextPage Next { get; set; }

        [JsonProperty("prev")]
        public PreviousPage Prev { get; set; }
    }

    public class NextPage
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }
    }

    public class PreviousPage
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class FileActionResponse
    {
        [JsonProperty("result")]
        public File Result { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("numErrors")]
        public int NumErrors { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("errors")]
        public StandardError[] Errors { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class StandardError
    {
        [JsonProperty("subCategory")]
        public JToken SubCategory { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public ErrorDetail[] Errors { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ErrorDetail
    {
        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public enum Status
    {
        PENDING,
        PROCESSING,
        CANCELED,
        COMPLETE
    }

    public class CollectionResponseFolder
    {
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonProperty("results")]
        public Folder[] Results { get; set; }
    }

    public class FolderActionResponse
    {
        [JsonProperty("result")]
        public Folder Result { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("numErrors")]
        public int NumErrors { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("errors")]
        public StandardError[] Errors { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class FolderUpdateTaskLocator
    {
        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotfilesv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotfilesv2Actions Hubspotfilesv2(string connectionId) => new Hubspotfilesv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotfilesv2Triggers Hubspotfilesv2(string connectionId) => new Hubspotfilesv2Triggers(connectionId);
    }
}
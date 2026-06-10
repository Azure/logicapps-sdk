//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sftp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SftpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<GetFileContentOutput> GetFileContent(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getFileContent", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetFileContentOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<UploadFileContentOutput> UploadFileContent(Expression<Func<string>> filePath, Expression<Func<bool>> overWriteFileIfExists, Expression<Func<string>> content = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (content != null)
            {
                parameters["content"] = ExpressionConverter.ConvertO(content);
            }

            parameters["overWriteFileIfExists"] = ExpressionConverter.ConvertO(overWriteFileIfExists);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "uploadFileContent", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<UploadFileContentOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IOutputWorkflowAction<JToken> GetMetadata(Expression<Func<string>> fileOrFolderPath)
        {
            var parameters = new JObject();
            parameters["fileOrFolderPath"] = ExpressionConverter.ConvertO(fileOrFolderPath);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getMetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder(Expression<Func<string>> folderPath, Expression<Func<bool>> filesOnly = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (filesOnly != null)
            {
                parameters["filesOnly"] = ExpressionConverter.ConvertO(filesOnly);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "listFolder", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListFolderOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<DeleteFileOutput> DeleteFile(Expression<Func<string>> filePath, Expression<Func<bool>> skipDelete = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (skipDelete != null)
            {
                parameters["skipDelete"] = ExpressionConverter.ConvertO(skipDelete);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "deleteFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<DeleteFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<CreateFolderOutput> CreateFolder(Expression<Func<string>> folderPath)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "createFolder", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateFolderOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<RenameFileOutput> RenameFile(Expression<Func<string>> filePath, Expression<Func<string>> newFileName, Expression<Func<bool>> fetchMetadata = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            parameters["newFileName"] = ExpressionConverter.ConvertO(newFileName);
            if (fetchMetadata != null)
            {
                parameters["fetchMetadata"] = ExpressionConverter.ConvertO(fetchMetadata);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "renameFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<RenameFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile(Expression<Func<string>> sourceFilePath, Expression<Func<string>> destinationFilePath, Expression<Func<bool>> overWriteFileIfExists = null)
        {
            var parameters = new JObject();
            parameters["sourceFilePath"] = ExpressionConverter.ConvertO(sourceFilePath);
            parameters["destinationFilePath"] = ExpressionConverter.ConvertO(destinationFilePath);
            if (overWriteFileIfExists != null)
            {
                parameters["overWriteFileIfExists"] = ExpressionConverter.ConvertO(overWriteFileIfExists);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "copyFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CopyFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<JToken> GetFileContentV2(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getFileContentV2", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> folderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null, Expression<Func<string>> content = null)
        {
            var parameters = new JObject();
            if (filePath != null)
            {
                parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            }

            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (overwriteExistingFilesBehaviour != null)
            {
                parameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            if (content != null)
            {
                parameters["content"] = ExpressionConverter.ConvertO(content);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "extractArchive", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IOutputWorkflowAction<JToken> DeleteFolder(Expression<Func<string>> folderPath, Expression<Func<bool>> recursiveDelete = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (recursiveDelete != null)
            {
                parameters["recursiveDelete"] = ExpressionConverter.ConvertO(recursiveDelete);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "deleteFolder", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }
    }

    public class SftpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<bool>> includeFileContent = null, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFilesCutoffTimestamp = null, Expression<Func<string[]>> ignoreFileExtensions = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (includeFileContent != null)
            {
                parameters["includeFileContent"] = ExpressionConverter.ConvertO(includeFileContent);
            }

            if (maxFileCount != null)
            {
                parameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
            }

            if (oldFilesCutoffTimestamp != null)
            {
                parameters["oldFilesCutoffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutoffTimestamp);
            }

            if (ignoreFileExtensions != null)
            {
                parameters["ignoreFileExtensions"] = ExpressionConverter.ConvertO(ignoreFileExtensions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(input, triggerName);
        }

        public IBodyWorkflowTrigger<WhenFileIsAddedOrModifiedOutput> WhenFileIsAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<bool>> includeFileContent = null, Expression<Func<string>> oldFilesCutoffTimestamp = null, Expression<Func<string[]>> ignoreFileExtensions = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (includeFileContent != null)
            {
                parameters["includeFileContent"] = ExpressionConverter.ConvertO(includeFileContent);
            }

            if (oldFilesCutoffTimestamp != null)
            {
                parameters["oldFilesCutoffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutoffTimestamp);
            }

            if (ignoreFileExtensions != null)
            {
                parameters["ignoreFileExtensions"] = ExpressionConverter.ConvertO(ignoreFileExtensions);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFileIsAddedOrModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenFileIsAddedOrModifiedOutput>(input, triggerName);
        }
    }

    public class GetFileContentOutput
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class UploadFileContentOutput
    {
        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }
    }

    public class ListFolderOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("absolutePath")]
        public string AbsolutePath { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("lastAccessTime")]
        public string LastAccessTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("isDirectory")]
        public bool IsDirectory { get; set; }

        [JsonProperty("readPermission")]
        public bool ReadPermission { get; set; }

        [JsonProperty("writePermission")]
        public bool WritePermission { get; set; }

        [JsonProperty("executePermission")]
        public bool ExecutePermission { get; set; }
    }

    public class DeleteFileOutput
    {
        [JsonProperty("fileDeleted")]
        public bool FileDeleted { get; set; }
    }

    public class CreateFolderOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("absolutePath")]
        public string AbsolutePath { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("lastAccessTime")]
        public string LastAccessTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("isDirectory")]
        public bool IsDirectory { get; set; }

        [JsonProperty("readPermission")]
        public bool ReadPermission { get; set; }

        [JsonProperty("writePermission")]
        public bool WritePermission { get; set; }

        [JsonProperty("executePermission")]
        public bool ExecutePermission { get; set; }
    }

    public class RenameFileOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("absolutePath")]
        public string AbsolutePath { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("lastAccessTime")]
        public string LastAccessTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("isDirectory")]
        public bool IsDirectory { get; set; }

        [JsonProperty("readPermission")]
        public bool ReadPermission { get; set; }

        [JsonProperty("writePermission")]
        public bool WritePermission { get; set; }

        [JsonProperty("executePermission")]
        public bool ExecutePermission { get; set; }
    }

    public class CopyFileOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("absolutePath")]
        public string AbsolutePath { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("lastAccessTime")]
        public string LastAccessTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("isDirectory")]
        public bool IsDirectory { get; set; }

        [JsonProperty("readPermission")]
        public bool ReadPermission { get; set; }

        [JsonProperty("writePermission")]
        public bool WritePermission { get; set; }

        [JsonProperty("executePermission")]
        public bool ExecutePermission { get; set; }
    }

    public class ExtractArchiveOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("actualFileSize")]
        public int ActualFileSize { get; set; }

        [JsonProperty("compressedFileSize")]
        public int CompressedFileSize { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }
    }

    public enum ExtractArchiveOverwriteExistingFilesBehaviourType
    {
        Fail,
        Skip,
        Overwrite
    }

    public class WhenFilesAreAddedOrModifiedOutputItem
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("fileMetadata")]
        public WhenFilesAreAddedOrModifiedOutputItemFileMetadataType FileMetadata { get; set; }
    }

    public class WhenFilesAreAddedOrModifiedOutputItemFileMetadataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }
    }

    public class WhenFileIsAddedOrModifiedOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("fileMetadata")]
        public WhenFileIsAddedOrModifiedOutputFileMetadataType FileMetadata { get; set; }
    }

    public class WhenFileIsAddedOrModifiedOutputFileMetadataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("pathRelativeToRootDirectory")]
        public string PathRelativeToRootDirectory { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sftp;

    public partial class WorkflowServiceProviderActions
    {
        public SftpActions Sftp(string connectionId) => new SftpActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public SftpTriggers Sftp(string connectionId) => new SftpTriggers(connectionId);
    }
}
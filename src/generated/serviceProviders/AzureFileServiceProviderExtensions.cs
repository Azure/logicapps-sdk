//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFile
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureFileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile(Expression<Func<string>> sourceFilePath, Expression<Func<string>> destinationFilePath, Expression<Func<bool>> overwrite = null)
        {
            var parameters = new JObject();
            parameters["SourceFilePath"] = ExpressionConverter.ConvertO(sourceFilePath);
            parameters["destinationFilePath"] = ExpressionConverter.ConvertO(destinationFilePath);
            if (overwrite != null)
            {
                parameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "copyFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CopyFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> destinationFolderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null, Expression<Func<object>> fileContent = null)
        {
            var parameters = new JObject();
            if (filePath != null)
            {
                parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            }

            parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(destinationFolderPath);
            if (overwriteExistingFilesBehaviour != null)
            {
                parameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            if (fileContent != null)
            {
                parameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "extractArchive", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> fileName, Expression<Func<object>> fileContent, Expression<Func<bool>> overwrite = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            parameters["fileName"] = ExpressionConverter.ConvertO(fileName);
            parameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
            if (overwrite != null)
            {
                parameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "createFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IOutputWorkflowAction<JToken> DeleteFile(Expression<Func<string>> fileId)
        {
            var parameters = new JObject();
            parameters["fileId"] = ExpressionConverter.ConvertO(fileId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "deleteFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContent(Expression<Func<string>> fileId, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["fileId"] = ExpressionConverter.ConvertO(fileId);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContent", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContentV2(Expression<Func<string>> fileId, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["fileId"] = ExpressionConverter.ConvertO(fileId);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContentV2", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContentByPath(Expression<Func<string>> fileId, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["fileId"] = ExpressionConverter.ConvertO(fileId);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContentByPath", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata(Expression<Func<string>> fileId)
        {
            var parameters = new JObject();
            parameters["fileId"] = ExpressionConverter.ConvertO(fileId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetFileMetadataOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<GetFileMetadataByPathOutput> GetFileMetadataByPath(Expression<Func<string>> filePath)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadataByPath", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetFileMetadataByPathOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder(Expression<Func<string>> folderId)
        {
            var parameters = new JObject();
            parameters["folderId"] = ExpressionConverter.ConvertO(folderId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "listFolder", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListFolderOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile(Expression<Func<string>> fileId, Expression<Func<object>> fileContent)
        {
            var parameters = new JObject();
            parameters["fileId"] = ExpressionConverter.ConvertO(fileId);
            parameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "updateFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<UpdateFileOutput>(input);
        }
    }

    public class AzureFileTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFilesCutOffTimestamp = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (maxFileCount != null)
            {
                parameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
            }

            if (oldFilesCutOffTimestamp != null)
            {
                parameters["oldFilesCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutOffTimestamp);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAdded", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(input, triggerName);
        }

        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFilesCutOffTimestamp = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (maxFileCount != null)
            {
                parameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
            }

            if (oldFilesCutOffTimestamp != null)
            {
                parameters["oldFilesCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutOffTimestamp);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(input, triggerName);
        }
    }

    public class CopyFileOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
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

    public class CreateFileOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class GetFileMetadataOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class GetFileMetadataByPathOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class ListFolderOutputItem
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class UpdateFileOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class WhenFilesAreAddedOutputItem
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class WhenFilesAreAddedOrModifiedOutputItem
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFile;

    public partial class WorkflowServiceProviderActions
    {
        public AzureFileActions AzureFile(string connectionId) => new AzureFileActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureFileTriggers AzureFile(string connectionId) => new AzureFileTriggers(connectionId);
    }
}
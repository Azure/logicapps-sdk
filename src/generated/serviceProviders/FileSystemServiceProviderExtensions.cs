//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.FileSystem
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FileSystemActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction AppendFile(Expression<Func<string>> filePath, Expression<Func<object>> body, Expression<Func<bool>> createFileIfNotPresent = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            parameters["body"] = ExpressionConverter.ConvertO(body);
            if (createFileIfNotPresent != null)
            {
                parameters["createFileIfNotPresent"] = ExpressionConverter.ConvertO(createFileIfNotPresent);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "appendFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction CopyFile(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var parameters = new JObject();
            parameters["source"] = ExpressionConverter.ConvertO(source);
            parameters["destination"] = ExpressionConverter.ConvertO(destination);
            if (overwrite != null)
            {
                parameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "copyFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile(Expression<Func<string>> filePath, Expression<Func<object>> body = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (body != null)
            {
                parameters["body"] = ExpressionConverter.ConvertO(body);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "createFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IOutputWorkflowAction<JToken> DeleteFile(Expression<Func<string>> filePath, Expression<Func<bool>> skipIfFileNotPresent = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (skipIfFileNotPresent != null)
            {
                parameters["skipIfFileNotPresent"] = ExpressionConverter.ConvertO(skipIfFileNotPresent);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "deleteFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<JToken> GetFileContent(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContent", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContentV2", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata(Expression<Func<string>> filePath)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileMetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetFileMetadataOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder(Expression<Func<string>> folderPath, Expression<Func<bool>> enableRecursiveListing = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (enableRecursiveListing != null)
            {
                parameters["enableRecursiveListing"] = ExpressionConverter.ConvertO(enableRecursiveListing);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "listFolder", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListFolderOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction RenameFile(Expression<Func<string>> filePath, Expression<Func<string>> newName)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            parameters["newName"] = ExpressionConverter.ConvertO(newName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "renameFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile(Expression<Func<string>> filePath, Expression<Func<object>> body)
        {
            var parameters = new JObject();
            parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            parameters["body"] = ExpressionConverter.ConvertO(body);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "updateFile", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<UpdateFileOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> folderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveOverwriteType>> overwrite = null, Expression<Func<object>> body = null)
        {
            var parameters = new JObject();
            if (filePath != null)
            {
                parameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            }

            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (overwrite != null)
            {
                parameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
            }

            if (body != null)
            {
                parameters["body"] = ExpressionConverter.ConvertO(body);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "extractArchive", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(input);
        }
    }

    public class FileSystemTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFileCutOffTimestamp = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (maxFileCount != null)
            {
                parameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
            }

            if (oldFileCutOffTimestamp != null)
            {
                parameters["oldFileCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFileCutOffTimestamp);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAdded", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(input, triggerName);
        }

        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFileCutOffTimestamp = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            if (maxFileCount != null)
            {
                parameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
            }

            if (oldFileCutOffTimestamp != null)
            {
                parameters["oldFileCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFileCutOffTimestamp);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(input, triggerName);
        }
    }

    public class CreateFileOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public class GetFileMetadataOutput
    {
        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("contentType")]
        public int ContentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }
    }

    public class ListFolderOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }
    }

    public class UpdateFileOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
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

    public enum ExtractArchiveOverwriteType
    {
        Fail,
        Skip,
        Overwrite
    }

    public class WhenFilesAreAddedOutputItem
    {
        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("contentType")]
        public int ContentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }
    }

    public class WhenFilesAreAddedOrModifiedOutputItem
    {
        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("contentType")]
        public int ContentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.FileSystem;

    public partial class WorkflowServiceProviderActions
    {
        public FileSystemActions FileSystem(string connectionId) => new FileSystemActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public FileSystemTriggers FileSystem(string connectionId) => new FileSystemTriggers(connectionId);
    }
}
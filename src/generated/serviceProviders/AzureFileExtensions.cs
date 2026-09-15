//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFile
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureFileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile(Expression<Func<string>> sourceFilePath, Expression<Func<string>> destinationFilePath, Expression<Func<bool>> overwrite = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["SourceFilePath"] = CSharpExpressionConverter.ConvertToken(sourceFilePath);
            serviceProviderParameters["destinationFilePath"] = CSharpExpressionConverter.ConvertToken(destinationFilePath);
            if (overwrite != null)
            {
                serviceProviderParameters["overwrite"] = CSharpExpressionConverter.ConvertToken(overwrite);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "copyFile", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CopyFileOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> destinationFolderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null, Expression<Func<object>> fileContent = null)
        {
            var serviceProviderParameters = new JObject();
            if (filePath != null)
            {
                serviceProviderParameters["filePath"] = CSharpExpressionConverter.ConvertToken(filePath);
            }

            serviceProviderParameters["destinationFolderPath"] = CSharpExpressionConverter.ConvertToken(destinationFolderPath);
            if (overwriteExistingFilesBehaviour != null)
            {
                serviceProviderParameters["overwriteExistingFilesBehaviour"] = CSharpExpressionConverter.ConvertToken(overwriteExistingFilesBehaviour);
            }

            if (fileContent != null)
            {
                serviceProviderParameters["fileContent"] = CSharpExpressionConverter.ConvertToken(fileContent);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "extractArchive", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile(Expression<Func<string>> folderPath, Expression<Func<string>> fileName, Expression<Func<object>> fileContent, Expression<Func<bool>> overwrite = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["folderPath"] = CSharpExpressionConverter.ConvertToken(folderPath);
            serviceProviderParameters["fileName"] = CSharpExpressionConverter.ConvertToken(fileName);
            serviceProviderParameters["fileContent"] = CSharpExpressionConverter.ConvertToken(fileContent);
            if (overwrite != null)
            {
                serviceProviderParameters["overwrite"] = CSharpExpressionConverter.ConvertToken(overwrite);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "createFile", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateFileOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IOutputWorkflowAction<bool> DeleteFile(Expression<Func<string>> fileId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["fileId"] = CSharpExpressionConverter.ConvertToken(fileId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "deleteFile", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<bool>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContent(Expression<Func<string>> fileId, Expression<Func<bool>> inferContentType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["fileId"] = CSharpExpressionConverter.ConvertToken(fileId);
            if (inferContentType != null)
            {
                serviceProviderParameters["inferContentType"] = CSharpExpressionConverter.ConvertToken(inferContentType);
            }
            else
            {
                serviceProviderParameters["inferContentType"] = true;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContent", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContentV2(Expression<Func<string>> fileId, Expression<Func<bool>> inferContentType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["fileId"] = CSharpExpressionConverter.ConvertToken(fileId);
            if (inferContentType != null)
            {
                serviceProviderParameters["inferContentType"] = CSharpExpressionConverter.ConvertToken(inferContentType);
            }
            else
            {
                serviceProviderParameters["inferContentType"] = true;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContentV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContentByPath(Expression<Func<string>> fileId, Expression<Func<bool>> inferContentType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["fileId"] = CSharpExpressionConverter.ConvertToken(fileId);
            if (inferContentType != null)
            {
                serviceProviderParameters["inferContentType"] = CSharpExpressionConverter.ConvertToken(inferContentType);
            }
            else
            {
                serviceProviderParameters["inferContentType"] = true;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContentByPath", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata(Expression<Func<string>> fileId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["fileId"] = CSharpExpressionConverter.ConvertToken(fileId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadata", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<GetFileMetadataByPathOutput> GetFileMetadataByPath(Expression<Func<string>> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = CSharpExpressionConverter.ConvertToken(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadataByPath", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetFileMetadataByPathOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder(Expression<Func<string>> folderId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["folderId"] = CSharpExpressionConverter.ConvertToken(folderId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "listFolder", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListFolderOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile(Expression<Func<string>> fileId, Expression<Func<object>> fileContent)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["fileId"] = CSharpExpressionConverter.ConvertToken(fileId);
            serviceProviderParameters["fileContent"] = CSharpExpressionConverter.ConvertToken(fileContent);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "updateFile", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<UpdateFileOutput>(serviceProviderInput);
        }
    }

    public class AzureFileTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["folderPath"] = CSharpExpressionConverter.ConvertToken(folderPath);
            if (maxFileCount != null)
            {
                serviceProviderParameters["maxFileCount"] = CSharpExpressionConverter.ConvertToken(maxFileCount);
            }

            if (oldFilesCutOffTimestamp != null)
            {
                serviceProviderParameters["oldFilesCutOffTimestamp"] = CSharpExpressionConverter.ConvertToken(oldFilesCutOffTimestamp);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAdded", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["folderPath"] = CSharpExpressionConverter.ConvertToken(folderPath);
            if (maxFileCount != null)
            {
                serviceProviderParameters["maxFileCount"] = CSharpExpressionConverter.ConvertToken(maxFileCount);
            }

            if (oldFilesCutOffTimestamp != null)
            {
                serviceProviderParameters["oldFilesCutOffTimestamp"] = CSharpExpressionConverter.ConvertToken(oldFilesCutOffTimestamp);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
        }
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractArchiveInputOverwriteExistingFilesBehaviourType
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
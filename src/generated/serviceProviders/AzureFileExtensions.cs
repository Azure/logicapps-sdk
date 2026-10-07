//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFile
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureFileActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile([WorkflowExpression] Func<string> sourceFilePath, [WorkflowExpression] Func<string> destinationFilePath, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CopyFileOutput> __BuildCopyFile(WorkflowExpression<string> sourceFilePath, WorkflowExpression<string> destinationFilePath, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(sourceFilePath, nameof(sourceFilePath), required: true);
            WorkflowExpression.Validate(destinationFilePath, nameof(destinationFilePath), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<CopyFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["SourceFilePath"] = ExpressionConverter.ConvertO(sourceFilePath);
                serviceProviderParameters["destinationFilePath"] = ExpressionConverter.ConvertO(destinationFilePath);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CopyFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchive))]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> destinationFolderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<object> fileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> __BuildExtractArchive(WorkflowExpression<string> destinationFolderPath, WorkflowExpression<string> filePath = null, WorkflowExpression<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, WorkflowExpression<object> fileContent = null)
        {
            WorkflowExpression.Validate(destinationFolderPath, nameof(destinationFolderPath), required: true);
            WorkflowExpression.Validate(filePath, nameof(filePath), required: false);
            WorkflowExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            WorkflowExpression.Validate(fileContent, nameof(fileContent), required: false);
            return new DeferredBodyAction<ExtractArchiveOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (filePath != null)
                {
                    serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                }

                serviceProviderParameters["destinationFolderPath"] = ExpressionConverter.ConvertO(destinationFolderPath);
                if (overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
                }

                if (fileContent != null)
                {
                    serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFileOutput> __BuildCreateFile(WorkflowExpression<string> folderPath, WorkflowExpression<string> fileName, WorkflowExpression<object> fileContent, WorkflowExpression<bool> overwrite = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(fileContent, nameof(fileContent), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<CreateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                serviceProviderParameters["fileName"] = ExpressionConverter.ConvertO(fileName);
                serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "createFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IOutputWorkflowAction<bool> DeleteFile([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<bool> __BuildDeleteFile(WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredOutputAction<bool>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = ExpressionConverter.ConvertO(fileId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "deleteFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<bool>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<JToken> GetFileContent([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFileContent(WorkflowExpression<string> fileId, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = ExpressionConverter.ConvertO(fileId);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentV2))]
        public IBodyWorkflowAction<JToken> GetFileContentV2([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFileContentV2(WorkflowExpression<string> fileId, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = ExpressionConverter.ConvertO(fileId);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentByPath))]
        public IBodyWorkflowAction<JToken> GetFileContentByPath([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFileContentByPath(WorkflowExpression<string> fileId, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = ExpressionConverter.ConvertO(fileId);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadata))]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileMetadataOutput> __BuildGetFileMetadata(WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetFileMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = ExpressionConverter.ConvertO(fileId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadataByPath))]
        public IBodyWorkflowAction<GetFileMetadataByPathOutput> GetFileMetadataByPath([WorkflowExpression] Func<string> filePath)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileMetadataByPathOutput> __BuildGetFileMetadataByPath(WorkflowExpression<string> filePath)
        {
            WorkflowExpression.Validate(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<GetFileMetadataByPathOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadataByPath", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileMetadataByPathOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder([WorkflowExpression] Func<string> folderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFolderOutputItem[]> __BuildListFolder(WorkflowExpression<string> folderId)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<ListFolderOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderId"] = ExpressionConverter.ConvertO(folderId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListFolderOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<object> fileContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateFileOutput> __BuildUpdateFile(WorkflowExpression<string> fileId, WorkflowExpression<object> fileContent)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            WorkflowExpression.Validate(fileContent, nameof(fileContent), required: true);
            return new DeferredBodyAction<UpdateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = ExpressionConverter.ConvertO(fileId);
                serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UpdateFileOutput>(serviceProviderInput);
            });
        }
    }

    public class AzureFileTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWhenFilesAreAdded))]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> __BuildWhenFilesAreAdded(WorkflowExpression<string> folderPath, WorkflowExpression<int> maxFileCount = null, WorkflowExpression<string> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            WorkflowExpression.Validate(oldFilesCutOffTimestamp, nameof(oldFilesCutOffTimestamp), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
                }

                if (oldFilesCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAdded", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenFilesAreAddedOrModified))]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> __BuildWhenFilesAreAddedOrModified(WorkflowExpression<string> folderPath, WorkflowExpression<int> maxFileCount = null, WorkflowExpression<string> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            WorkflowExpression.Validate(oldFilesCutOffTimestamp, nameof(oldFilesCutOffTimestamp), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
                }

                if (oldFilesCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
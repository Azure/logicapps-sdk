//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.FileSystem
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class FileSystemActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildAppendFile))]
        public IWorkflowAction AppendFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> body, [WorkflowExpression] Func<bool> createFileIfNotPresent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAppendFile(WorkflowValue<string> filePath, WorkflowValue<object> body, WorkflowValue<bool> createFileIfNotPresent = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(body, nameof(body), required: true);
            WorkflowValue.Validate(createFileIfNotPresent, nameof(createFileIfNotPresent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
                if (createFileIfNotPresent != null)
                {
                    serviceProviderParameters["createFileIfNotPresent"] = ExpressionConverter.ConvertO(createFileIfNotPresent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "appendFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IWorkflowAction CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCopyFile(WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["source"] = ExpressionConverter.ConvertO(source);
                serviceProviderParameters["destination"] = ExpressionConverter.ConvertO(destination);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFileOutput> __BuildCreateFile(WorkflowValue<string> filePath, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                if (body != null)
                {
                    serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "createFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IOutputWorkflowAction<JToken> DeleteFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipIfFileNotPresent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeleteFile(WorkflowValue<string> filePath, WorkflowValue<bool> skipIfFileNotPresent = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(skipIfFileNotPresent, nameof(skipIfFileNotPresent), required: false);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                if (skipIfFileNotPresent != null)
                {
                    serviceProviderParameters["skipIfFileNotPresent"] = ExpressionConverter.ConvertO(skipIfFileNotPresent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "deleteFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<JToken> GetFileContent([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFileContent(WorkflowValue<string> filePath, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentV2))]
        public IBodyWorkflowAction<JToken> GetFileContentV2([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFileContentV2(WorkflowValue<string> filePath, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadata))]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata([WorkflowExpression] Func<string> filePath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileMetadataOutput> __BuildGetFileMetadata(WorkflowValue<string> filePath)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<GetFileMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> enableRecursiveListing = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFolderOutputItem[]> __BuildListFolder(WorkflowValue<string> folderPath, WorkflowValue<bool> enableRecursiveListing = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(enableRecursiveListing, nameof(enableRecursiveListing), required: false);
            return new DeferredBodyAction<ListFolderOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (enableRecursiveListing != null)
                {
                    serviceProviderParameters["enableRecursiveListing"] = ExpressionConverter.ConvertO(enableRecursiveListing);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListFolderOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildRenameFile))]
        public IWorkflowAction RenameFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<string> newName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenameFile(WorkflowValue<string> filePath, WorkflowValue<string> newName)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(newName, nameof(newName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                serviceProviderParameters["newName"] = ExpressionConverter.ConvertO(newName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "renameFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> body)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateFileOutput> __BuildUpdateFile(WorkflowValue<string> filePath, WorkflowValue<object> body)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UpdateFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchive))]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteType> overwrite = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> __BuildExtractArchive(WorkflowValue<string> folderPath, WorkflowValue<string> filePath = null, WorkflowValue<ExtractArchiveInputOverwriteType> overwrite = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(filePath, nameof(filePath), required: false);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractArchiveOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (filePath != null)
                {
                    serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                }

                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = ExpressionConverter.ConvertO(overwrite);
                }

                if (body != null)
                {
                    serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
            });
        }
    }

    public class FileSystemTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildWhenFilesAreAdded))]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> __BuildWhenFilesAreAdded(WorkflowValue<string> folderPath, WorkflowValue<int> maxFileCount = null, WorkflowValue<string> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            WorkflowValue.Validate(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
                }

                if (oldFileCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFileCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFileCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAdded", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenFilesAreAddedOrModified))]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> __BuildWhenFilesAreAddedOrModified(WorkflowValue<string> folderPath, WorkflowValue<int> maxFileCount = null, WorkflowValue<string> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            WorkflowValue.Validate(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
                }

                if (oldFileCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFileCutOffTimestamp"] = ExpressionConverter.ConvertO(oldFileCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, "ServiceProviderTrigger");
        }
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractArchiveInputOverwriteType
    {
        Fail,
        Skip,
        Overwrite
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

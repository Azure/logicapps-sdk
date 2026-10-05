//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sftp
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SftpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<GetFileContentOutput> GetFileContent([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileContentOutput> __BuildGetFileContent(WorkflowValue<string> filePath, WorkflowValue<bool> inferContentType = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<GetFileContentOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileContentOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFileContent))]
        public IBodyWorkflowAction<UploadFileContentOutput> UploadFileContent([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> overWriteFileIfExists, [WorkflowExpression] Func<string> content = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFileContentOutput> __BuildUploadFileContent(WorkflowValue<string> filePath, WorkflowValue<bool> overWriteFileIfExists, WorkflowValue<string> content = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(overWriteFileIfExists, nameof(overWriteFileIfExists), required: true);
            WorkflowValue.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<UploadFileContentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                if (content != null)
                {
                    serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
                }

                serviceProviderParameters["overWriteFileIfExists"] = ExpressionConverter.ConvertO(overWriteFileIfExists);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "uploadFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UploadFileContentOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildGetMetadata))]
        public IOutputWorkflowAction<JToken> GetMetadata([WorkflowExpression] Func<string> fileOrFolderPath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildGetMetadata(WorkflowValue<string> fileOrFolderPath)
        {
            WorkflowValue.Validate(fileOrFolderPath, nameof(fileOrFolderPath), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileOrFolderPath"] = ExpressionConverter.ConvertO(fileOrFolderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> filesOnly = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFolderOutputItem[]> __BuildListFolder(WorkflowValue<string> folderPath, WorkflowValue<bool> filesOnly = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(filesOnly, nameof(filesOnly), required: false);
            return new DeferredBodyAction<ListFolderOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (filesOnly != null)
                {
                    serviceProviderParameters["filesOnly"] = ExpressionConverter.ConvertO(filesOnly);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListFolderOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IBodyWorkflowAction<DeleteFileOutput> DeleteFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipDelete = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteFileOutput> __BuildDeleteFile(WorkflowValue<string> filePath, WorkflowValue<bool> skipDelete = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(skipDelete, nameof(skipDelete), required: false);
            return new DeferredBodyAction<DeleteFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                if (skipDelete != null)
                {
                    serviceProviderParameters["skipDelete"] = ExpressionConverter.ConvertO(skipDelete);
                }
                else
                {
                    serviceProviderParameters["skipDelete"] = false;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "deleteFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<CreateFolderOutput> CreateFolder([WorkflowExpression] Func<string> folderPath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFolderOutput> __BuildCreateFolder(WorkflowValue<string> folderPath)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<CreateFolderOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "createFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateFolderOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildRenameFile))]
        public IBodyWorkflowAction<RenameFileOutput> RenameFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<string> newFileName, [WorkflowExpression] Func<bool> fetchMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenameFileOutput> __BuildRenameFile(WorkflowValue<string> filePath, WorkflowValue<string> newFileName, WorkflowValue<bool> fetchMetadata = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(newFileName, nameof(newFileName), required: true);
            WorkflowValue.Validate(fetchMetadata, nameof(fetchMetadata), required: false);
            return new DeferredBodyAction<RenameFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                serviceProviderParameters["newFileName"] = ExpressionConverter.ConvertO(newFileName);
                if (fetchMetadata != null)
                {
                    serviceProviderParameters["fetchMetadata"] = ExpressionConverter.ConvertO(fetchMetadata);
                }
                else
                {
                    serviceProviderParameters["fetchMetadata"] = false;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "renameFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<RenameFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile([WorkflowExpression] Func<string> sourceFilePath, [WorkflowExpression] Func<string> destinationFilePath, [WorkflowExpression] Func<bool> overWriteFileIfExists = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CopyFileOutput> __BuildCopyFile(WorkflowValue<string> sourceFilePath, WorkflowValue<string> destinationFilePath, WorkflowValue<bool> overWriteFileIfExists = null)
        {
            WorkflowValue.Validate(sourceFilePath, nameof(sourceFilePath), required: true);
            WorkflowValue.Validate(destinationFilePath, nameof(destinationFilePath), required: true);
            WorkflowValue.Validate(overWriteFileIfExists, nameof(overWriteFileIfExists), required: false);
            return new DeferredBodyAction<CopyFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceFilePath"] = ExpressionConverter.ConvertO(sourceFilePath);
                serviceProviderParameters["destinationFilePath"] = ExpressionConverter.ConvertO(destinationFilePath);
                if (overWriteFileIfExists != null)
                {
                    serviceProviderParameters["overWriteFileIfExists"] = ExpressionConverter.ConvertO(overWriteFileIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CopyFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchive))]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<string> content = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> __BuildExtractArchive(WorkflowValue<string> folderPath, WorkflowValue<string> filePath = null, WorkflowValue<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, WorkflowValue<string> content = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(filePath, nameof(filePath), required: false);
            WorkflowValue.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            WorkflowValue.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<ExtractArchiveOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (filePath != null)
                {
                    serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                }

                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
                }

                if (content != null)
                {
                    serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFolder))]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> recursiveDelete = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFolder(WorkflowValue<string> folderPath, WorkflowValue<bool> recursiveDelete = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(recursiveDelete, nameof(recursiveDelete), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (recursiveDelete != null)
                {
                    serviceProviderParameters["recursiveDelete"] = ExpressionConverter.ConvertO(recursiveDelete);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "deleteFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }
    }

    public class SftpTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildWhenFilesAreAddedOrModified))]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> includeFileContent = null, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFilesCutoffTimestamp = null, [WorkflowExpression] Func<string[]> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> __BuildWhenFilesAreAddedOrModified(WorkflowValue<string> folderPath, WorkflowValue<bool> includeFileContent = null, WorkflowValue<int> maxFileCount = null, WorkflowValue<string> oldFilesCutoffTimestamp = null, WorkflowValue<string[]> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(includeFileContent, nameof(includeFileContent), required: false);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            WorkflowValue.Validate(oldFilesCutoffTimestamp, nameof(oldFilesCutoffTimestamp), required: false);
            WorkflowValue.Validate(ignoreFileExtensions, nameof(ignoreFileExtensions), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (includeFileContent != null)
                {
                    serviceProviderParameters["includeFileContent"] = ExpressionConverter.ConvertO(includeFileContent);
                }
                else
                {
                    serviceProviderParameters["includeFileContent"] = false;
                }

                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(maxFileCount);
                }

                if (oldFilesCutoffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutoffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutoffTimestamp);
                }

                if (ignoreFileExtensions != null)
                {
                    serviceProviderParameters["ignoreFileExtensions"] = ExpressionConverter.ConvertO(ignoreFileExtensions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildWhenFileIsAddedOrModified))]
        public IBodyWorkflowTrigger<WhenFileIsAddedOrModifiedOutput> WhenFileIsAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> includeFileContent = null, [WorkflowExpression] Func<string> oldFilesCutoffTimestamp = null, [WorkflowExpression] Func<string[]> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFileIsAddedOrModifiedOutput> __BuildWhenFileIsAddedOrModified(WorkflowValue<string> folderPath, WorkflowValue<bool> includeFileContent = null, WorkflowValue<string> oldFilesCutoffTimestamp = null, WorkflowValue<string[]> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(includeFileContent, nameof(includeFileContent), required: false);
            WorkflowValue.Validate(oldFilesCutoffTimestamp, nameof(oldFilesCutoffTimestamp), required: false);
            WorkflowValue.Validate(ignoreFileExtensions, nameof(ignoreFileExtensions), required: false);
            return new DeferredBodyTrigger<WhenFileIsAddedOrModifiedOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                if (includeFileContent != null)
                {
                    serviceProviderParameters["includeFileContent"] = ExpressionConverter.ConvertO(includeFileContent);
                }
                else
                {
                    serviceProviderParameters["includeFileContent"] = false;
                }

                if (oldFilesCutoffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutoffTimestamp"] = ExpressionConverter.ConvertO(oldFilesCutoffTimestamp);
                }

                if (ignoreFileExtensions != null)
                {
                    serviceProviderParameters["ignoreFileExtensions"] = ExpressionConverter.ConvertO(ignoreFileExtensions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFileIsAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFileIsAddedOrModifiedOutput>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, "ServiceProviderTrigger");
        }
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractArchiveInputOverwriteExistingFilesBehaviourType
    {
        Fail,
        Skip,
        Overwrite
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

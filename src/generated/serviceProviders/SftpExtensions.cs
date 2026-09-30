//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sftp
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SftpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<GetFileContentOutput> GetFileContent([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = SourceExpressionConverter.ConvertToken(inferContentType);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetFileContentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<AppendFileOutput> AppendFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<string> content, [WorkflowExpression] Func<bool> fetchMetadata = null, [WorkflowExpression] Func<bool> createFile = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(content, nameof(content), required: true);
            SourceExpression.Validate(fetchMetadata, nameof(fetchMetadata), required: false);
            SourceExpression.Validate(createFile, nameof(createFile), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["content"] = SourceExpressionConverter.ConvertToken(content);
                if (fetchMetadata != null)
                {
                    serviceProviderParameters["fetchMetadata"] = SourceExpressionConverter.ConvertToken(fetchMetadata);
                }
                else
                {
                    serviceProviderParameters["fetchMetadata"] = false;
                }

                if (createFile != null)
                {
                    serviceProviderParameters["createFile"] = SourceExpressionConverter.ConvertToken(createFile);
                }
                else
                {
                    serviceProviderParameters["createFile"] = false;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "appendFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<AppendFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<UploadFileContentOutput> UploadFileContent([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> overWriteFileIfExists, [WorkflowExpression] Func<string> content = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(overWriteFileIfExists, nameof(overWriteFileIfExists), required: true);
            SourceExpression.Validate(content, nameof(content), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                if (content != null)
                {
                    serviceProviderParameters["content"] = SourceExpressionConverter.ConvertToken(content);
                }

                serviceProviderParameters["overWriteFileIfExists"] = SourceExpressionConverter.ConvertToken(overWriteFileIfExists);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "uploadFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<UploadFileContentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IOutputWorkflowAction<JToken> GetMetadata([WorkflowExpression] Func<string> fileOrFolderPath)
        {
            SourceExpression.Validate(fileOrFolderPath, nameof(fileOrFolderPath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileOrFolderPath"] = SourceExpressionConverter.ConvertToken(fileOrFolderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> filesOnly = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(filesOnly, nameof(filesOnly), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (filesOnly != null)
                {
                    serviceProviderParameters["filesOnly"] = SourceExpressionConverter.ConvertToken(filesOnly);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListFolderOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<DeleteFileOutput> DeleteFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipDelete = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(skipDelete, nameof(skipDelete), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                if (skipDelete != null)
                {
                    serviceProviderParameters["skipDelete"] = SourceExpressionConverter.ConvertToken(skipDelete);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<DeleteFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<CreateFolderOutput> CreateFolder([WorkflowExpression] Func<string> folderPath)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "createFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateFolderOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<RenameFileOutput> RenameFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<string> newFileName, [WorkflowExpression] Func<bool> fetchMetadata = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(newFileName, nameof(newFileName), required: true);
            SourceExpression.Validate(fetchMetadata, nameof(fetchMetadata), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["newFileName"] = SourceExpressionConverter.ConvertToken(newFileName);
                if (fetchMetadata != null)
                {
                    serviceProviderParameters["fetchMetadata"] = SourceExpressionConverter.ConvertToken(fetchMetadata);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<RenameFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile([WorkflowExpression] Func<string> sourceFilePath, [WorkflowExpression] Func<string> destinationFilePath, [WorkflowExpression] Func<bool> overWriteFileIfExists = null)
        {
            SourceExpression.Validate(sourceFilePath, nameof(sourceFilePath), required: true);
            SourceExpression.Validate(destinationFilePath, nameof(destinationFilePath), required: true);
            SourceExpression.Validate(overWriteFileIfExists, nameof(overWriteFileIfExists), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceFilePath"] = SourceExpressionConverter.ConvertToken(sourceFilePath);
                serviceProviderParameters["destinationFilePath"] = SourceExpressionConverter.ConvertToken(destinationFilePath);
                if (overWriteFileIfExists != null)
                {
                    serviceProviderParameters["overWriteFileIfExists"] = SourceExpressionConverter.ConvertToken(overWriteFileIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CopyFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<JToken> GetFileContentV2([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = SourceExpressionConverter.ConvertToken(inferContentType);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<string> content = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(filePath, nameof(filePath), required: false);
            SourceExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            SourceExpression.Validate(content, nameof(content), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (filePath != null)
                {
                    serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                }

                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = SourceExpressionConverter.ConvertToken(overwriteExistingFilesBehaviour);
                }

                if (content != null)
                {
                    serviceProviderParameters["content"] = SourceExpressionConverter.ConvertToken(content);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> recursiveDelete = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(recursiveDelete, nameof(recursiveDelete), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (recursiveDelete != null)
                {
                    serviceProviderParameters["recursiveDelete"] = SourceExpressionConverter.ConvertToken(recursiveDelete);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "deleteFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }
    }

    public class SftpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> includeFileContent = null, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFilesCutoffTimestamp = null, [WorkflowExpression] Func<string[]> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(includeFileContent, nameof(includeFileContent), required: false);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            SourceExpression.Validate(oldFilesCutoffTimestamp, nameof(oldFilesCutoffTimestamp), required: false);
            SourceExpression.Validate(ignoreFileExtensions, nameof(ignoreFileExtensions), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (includeFileContent != null)
                {
                    serviceProviderParameters["includeFileContent"] = SourceExpressionConverter.ConvertToken(includeFileContent);
                }
                else
                {
                    serviceProviderParameters["includeFileContent"] = false;
                }

                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = SourceExpressionConverter.ConvertToken(maxFileCount);
                }

                if (oldFilesCutoffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutoffTimestamp"] = SourceExpressionConverter.ConvertToken(oldFilesCutoffTimestamp);
                }

                if (ignoreFileExtensions != null)
                {
                    serviceProviderParameters["ignoreFileExtensions"] = SourceExpressionConverter.ConvertToken(ignoreFileExtensions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WhenFileIsAddedOrModifiedOutput> WhenFileIsAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> includeFileContent = null, [WorkflowExpression] Func<string> oldFilesCutoffTimestamp = null, [WorkflowExpression] Func<string[]> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(includeFileContent, nameof(includeFileContent), required: false);
            SourceExpression.Validate(oldFilesCutoffTimestamp, nameof(oldFilesCutoffTimestamp), required: false);
            SourceExpression.Validate(ignoreFileExtensions, nameof(ignoreFileExtensions), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (includeFileContent != null)
                {
                    serviceProviderParameters["includeFileContent"] = SourceExpressionConverter.ConvertToken(includeFileContent);
                }
                else
                {
                    serviceProviderParameters["includeFileContent"] = false;
                }

                if (oldFilesCutoffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutoffTimestamp"] = SourceExpressionConverter.ConvertToken(oldFilesCutoffTimestamp);
                }

                if (ignoreFileExtensions != null)
                {
                    serviceProviderParameters["ignoreFileExtensions"] = SourceExpressionConverter.ConvertToken(ignoreFileExtensions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFileIsAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFileIsAddedOrModifiedOutput>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }
    }

    public class GetFileContentOutput
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class AppendFileOutput
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
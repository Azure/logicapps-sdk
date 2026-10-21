//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sftp
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SftpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<GetFileContentOutput> GetFileContent(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<GetFileContentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(__workflow_inferContentType);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<UploadFileContentOutput> UploadFileContent(Expression<Func<string>> filePath, Expression<Func<bool>> overWriteFileIfExists, Expression<Func<string>> content = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_overWriteFileIfExists = WorkflowExpression.Compile(overWriteFileIfExists, nameof(overWriteFileIfExists), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<UploadFileContentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_content != null)
                {
                    serviceProviderParameters["content"] = ExpressionConverter.ConvertO(__workflow_content);
                }

                serviceProviderParameters["overWriteFileIfExists"] = ExpressionConverter.ConvertO(__workflow_overWriteFileIfExists);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "uploadFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UploadFileContentOutput>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IOutputWorkflowAction<JToken> GetMetadata(Expression<Func<string>> fileOrFolderPath)
        {
            var __workflow_fileOrFolderPath = WorkflowExpression.Compile(fileOrFolderPath, nameof(fileOrFolderPath), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileOrFolderPath"] = ExpressionConverter.ConvertO(__workflow_fileOrFolderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "getMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder(Expression<Func<string>> folderPath, Expression<Func<bool>> filesOnly = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_filesOnly = WorkflowExpression.Compile(filesOnly, nameof(filesOnly), required: false);
            return new DeferredBodyAction<ListFolderOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_filesOnly != null)
                {
                    serviceProviderParameters["filesOnly"] = ExpressionConverter.ConvertO(__workflow_filesOnly);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListFolderOutputItem[]>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<DeleteFileOutput> DeleteFile(Expression<Func<string>> filePath, Expression<Func<bool>> skipDelete = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_skipDelete = WorkflowExpression.Compile(skipDelete, nameof(skipDelete), required: false);
            return new DeferredBodyAction<DeleteFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_skipDelete != null)
                {
                    serviceProviderParameters["skipDelete"] = ExpressionConverter.ConvertO(__workflow_skipDelete);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<CreateFolderOutput> CreateFolder(Expression<Func<string>> folderPath)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<CreateFolderOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "createFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateFolderOutput>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<RenameFileOutput> RenameFile(Expression<Func<string>> filePath, Expression<Func<string>> newFileName, Expression<Func<bool>> fetchMetadata = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_newFileName = WorkflowExpression.Compile(newFileName, nameof(newFileName), required: true);
            var __workflow_fetchMetadata = WorkflowExpression.Compile(fetchMetadata, nameof(fetchMetadata), required: false);
            return new DeferredBodyAction<RenameFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                serviceProviderParameters["newFileName"] = ExpressionConverter.ConvertO(__workflow_newFileName);
                if (__workflow_fetchMetadata != null)
                {
                    serviceProviderParameters["fetchMetadata"] = ExpressionConverter.ConvertO(__workflow_fetchMetadata);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile(Expression<Func<string>> sourceFilePath, Expression<Func<string>> destinationFilePath, Expression<Func<bool>> overWriteFileIfExists = null)
        {
            var __workflow_sourceFilePath = WorkflowExpression.Compile(sourceFilePath, nameof(sourceFilePath), required: true);
            var __workflow_destinationFilePath = WorkflowExpression.Compile(destinationFilePath, nameof(destinationFilePath), required: true);
            var __workflow_overWriteFileIfExists = WorkflowExpression.Compile(overWriteFileIfExists, nameof(overWriteFileIfExists), required: false);
            return new DeferredBodyAction<CopyFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceFilePath"] = ExpressionConverter.ConvertO(__workflow_sourceFilePath);
                serviceProviderParameters["destinationFilePath"] = ExpressionConverter.ConvertO(__workflow_destinationFilePath);
                if (__workflow_overWriteFileIfExists != null)
                {
                    serviceProviderParameters["overWriteFileIfExists"] = ExpressionConverter.ConvertO(__workflow_overWriteFileIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CopyFileOutput>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<JToken> GetFileContentV2(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(__workflow_inferContentType);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> folderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null, Expression<Func<string>> content = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: false);
            var __workflow_overwriteExistingFilesBehaviour = WorkflowExpression.Compile(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<ExtractArchiveOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_filePath != null)
                {
                    serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                }

                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(__workflow_overwriteExistingFilesBehaviour);
                }

                if (__workflow_content != null)
                {
                    serviceProviderParameters["content"] = ExpressionConverter.ConvertO(__workflow_content);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Sftp")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> folderPath, Expression<Func<bool>> recursiveDelete = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_recursiveDelete = WorkflowExpression.Compile(recursiveDelete, nameof(recursiveDelete), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_recursiveDelete != null)
                {
                    serviceProviderParameters["recursiveDelete"] = ExpressionConverter.ConvertO(__workflow_recursiveDelete);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "deleteFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }
    }

    public class SftpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<bool>> includeFileContent = null, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFilesCutoffTimestamp = null, Expression<Func<string[]>> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_includeFileContent = WorkflowExpression.Compile(includeFileContent, nameof(includeFileContent), required: false);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            var __workflow_oldFilesCutoffTimestamp = WorkflowExpression.Compile(oldFilesCutoffTimestamp, nameof(oldFilesCutoffTimestamp), required: false);
            var __workflow_ignoreFileExtensions = WorkflowExpression.Compile(ignoreFileExtensions, nameof(ignoreFileExtensions), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_includeFileContent != null)
                {
                    serviceProviderParameters["includeFileContent"] = ExpressionConverter.ConvertO(__workflow_includeFileContent);
                }
                else
                {
                    serviceProviderParameters["includeFileContent"] = false;
                }

                if (__workflow_maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(__workflow_maxFileCount);
                }

                if (__workflow_oldFilesCutoffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutoffTimestamp"] = ExpressionConverter.ConvertO(__workflow_oldFilesCutoffTimestamp);
                }

                if (__workflow_ignoreFileExtensions != null)
                {
                    serviceProviderParameters["ignoreFileExtensions"] = ExpressionConverter.ConvertO(__workflow_ignoreFileExtensions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, WorkflowTriggerSettings.RetryPolicy | WorkflowTriggerSettings.SecureInputs | WorkflowTriggerSettings.SecureOutputs | WorkflowTriggerSettings.Concurrency);
        }

        public IBodyWorkflowTrigger<WhenFileIsAddedOrModifiedOutput> WhenFileIsAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<bool>> includeFileContent = null, Expression<Func<string>> oldFilesCutoffTimestamp = null, Expression<Func<string[]>> ignoreFileExtensions = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_includeFileContent = WorkflowExpression.Compile(includeFileContent, nameof(includeFileContent), required: false);
            var __workflow_oldFilesCutoffTimestamp = WorkflowExpression.Compile(oldFilesCutoffTimestamp, nameof(oldFilesCutoffTimestamp), required: false);
            var __workflow_ignoreFileExtensions = WorkflowExpression.Compile(ignoreFileExtensions, nameof(ignoreFileExtensions), required: false);
            return new DeferredBodyTrigger<WhenFileIsAddedOrModifiedOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_includeFileContent != null)
                {
                    serviceProviderParameters["includeFileContent"] = ExpressionConverter.ConvertO(__workflow_includeFileContent);
                }
                else
                {
                    serviceProviderParameters["includeFileContent"] = false;
                }

                if (__workflow_oldFilesCutoffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutoffTimestamp"] = ExpressionConverter.ConvertO(__workflow_oldFilesCutoffTimestamp);
                }

                if (__workflow_ignoreFileExtensions != null)
                {
                    serviceProviderParameters["ignoreFileExtensions"] = ExpressionConverter.ConvertO(__workflow_ignoreFileExtensions);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Sftp", operationId: "whenFileIsAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFileIsAddedOrModifiedOutput>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, WorkflowTriggerSettings.RetryPolicy | WorkflowTriggerSettings.SecureInputs | WorkflowTriggerSettings.SecureOutputs | WorkflowTriggerSettings.Concurrency);
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
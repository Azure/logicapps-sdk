//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class FileSystemActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction<AppendFileActionConfiguration> AppendFile(Expression<Func<string>> filePath, Expression<Func<object>> body, Expression<Func<bool>> createFileIfNotPresent = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_createFileIfNotPresent = WorkflowExpression.Compile(createFileIfNotPresent, nameof(createFileIfNotPresent), required: false);
            return new DeferredWorkflowAction<AppendFileActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
                if (__workflow_createFileIfNotPresent != null)
                {
                    serviceProviderParameters["createFileIfNotPresent"] = ExpressionConverter.ConvertO(__workflow_createFileIfNotPresent);
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
        public IWorkflowAction<CopyFileActionConfiguration> CopyFile(Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredWorkflowAction<CopyFileActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["source"] = ExpressionConverter.ConvertO(__workflow_source);
                serviceProviderParameters["destination"] = ExpressionConverter.ConvertO(__workflow_destination);
                if (__workflow_overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = ExpressionConverter.ConvertO(__workflow_overwrite);
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
        public IBodyWorkflowAction<CreateFileOutput, CreateFileActionConfiguration> CreateFile(Expression<Func<string>> filePath, Expression<Func<object>> body = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateFileOutput, CreateFileActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_body != null)
                {
                    serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
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
        public IWorkflowAction<DeleteFileActionConfiguration> DeleteFile(Expression<Func<string>> filePath, Expression<Func<bool>> skipIfFileNotPresent = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_skipIfFileNotPresent = WorkflowExpression.Compile(skipIfFileNotPresent, nameof(skipIfFileNotPresent), required: false);
            return new DeferredWorkflowAction<DeleteFileActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_skipIfFileNotPresent != null)
                {
                    serviceProviderParameters["skipIfFileNotPresent"] = ExpressionConverter.ConvertO(__workflow_skipIfFileNotPresent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "deleteFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<JToken, GetFileContentActionConfiguration> GetFileContent(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken, GetFileContentActionConfiguration>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<JToken, GetFileContentV2ActionConfiguration> GetFileContentV2(Expression<Func<string>> filePath, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<JToken, GetFileContentV2ActionConfiguration>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<GetFileMetadataOutput, GetFileMetadataActionConfiguration> GetFileMetadata(Expression<Func<string>> filePath)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<GetFileMetadataOutput, GetFileMetadataActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<ListFolderOutputItem[], ListFolderActionConfiguration> ListFolder(Expression<Func<string>> folderPath, Expression<Func<bool>> enableRecursiveListing = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_enableRecursiveListing = WorkflowExpression.Compile(enableRecursiveListing, nameof(enableRecursiveListing), required: false);
            return new DeferredBodyAction<ListFolderOutputItem[], ListFolderActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_enableRecursiveListing != null)
                {
                    serviceProviderParameters["enableRecursiveListing"] = ExpressionConverter.ConvertO(__workflow_enableRecursiveListing);
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
        public IWorkflowAction<RenameFileActionConfiguration> RenameFile(Expression<Func<string>> filePath, Expression<Func<string>> newName)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_newName = WorkflowExpression.Compile(newName, nameof(newName), required: true);
            return new DeferredWorkflowAction<RenameFileActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                serviceProviderParameters["newName"] = ExpressionConverter.ConvertO(__workflow_newName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "renameFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<UpdateFileOutput, UpdateFileActionConfiguration> UpdateFile(Expression<Func<string>> filePath, Expression<Func<object>> body)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateFileOutput, UpdateFileActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UpdateFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[], ExtractArchiveActionConfiguration> ExtractArchive(Expression<Func<string>> folderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveInputOverwriteType>> overwrite = null, Expression<Func<object>> body = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractArchiveOutputItem[], ExtractArchiveActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_filePath != null)
                {
                    serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                }

                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = ExpressionConverter.ConvertO(__workflow_overwrite);
                }

                if (__workflow_body != null)
                {
                    serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
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

    public sealed class AppendFileActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CopyFileActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CreateFileActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class DeleteFileActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetFileContentActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetFileContentV2ActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetFileMetadataActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ListFolderActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class RenameFileActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class UpdateFileActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ExtractArchiveActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class FileSystemTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[], WhenFilesAreAddedTriggerConfiguration> WhenFilesAreAdded(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            var __workflow_oldFileCutOffTimestamp = WorkflowExpression.Compile(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOutputItem[], WhenFilesAreAddedTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(__workflow_maxFileCount);
                }

                if (__workflow_oldFileCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFileCutOffTimestamp"] = ExpressionConverter.ConvertO(__workflow_oldFileCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAdded", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[], WhenFilesAreAddedOrModifiedTriggerConfiguration> WhenFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            var __workflow_oldFileCutOffTimestamp = WorkflowExpression.Compile(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            return new DeferredBodyTrigger<WhenFilesAreAddedOrModifiedOutputItem[], WhenFilesAreAddedOrModifiedTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                if (__workflow_maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = ExpressionConverter.ConvertO(__workflow_maxFileCount);
                }

                if (__workflow_oldFileCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFileCutOffTimestamp"] = ExpressionConverter.ConvertO(__workflow_oldFileCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }
    }

    public sealed class WhenFilesAreAddedTriggerConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class WhenFilesAreAddedOrModifiedTriggerConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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
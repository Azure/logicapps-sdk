//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Ftp
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class FtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<JToken> GetFtpFileContent(Expression<Func<string>> filePath)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<JToken> GetFtpFileContentV2(Expression<Func<string>> filePath)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata(Expression<Func<string>> filePath)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<GetFileMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile(Expression<Func<string>> filePath, Expression<Func<object>> fileContent, Expression<Func<bool>> getAllFileMetadata = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: true);
            var __workflow_getAllFileMetadata = WorkflowExpression.Compile(getAllFileMetadata, nameof(getAllFileMetadata), required: false);
            return new DeferredBodyAction<CreateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(__workflow_fileContent);
                if (__workflow_getAllFileMetadata != null)
                {
                    serviceProviderParameters["getAllFileMetadata"] = ExpressionConverter.ConvertO(__workflow_getAllFileMetadata);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "createFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile(Expression<Func<string>> filePath, Expression<Func<object>> fileContent, Expression<Func<bool>> getAllFileMetadata = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: true);
            var __workflow_getAllFileMetadata = WorkflowExpression.Compile(getAllFileMetadata, nameof(getAllFileMetadata), required: false);
            return new DeferredBodyAction<UpdateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(__workflow_fileContent);
                if (__workflow_getAllFileMetadata != null)
                {
                    serviceProviderParameters["getAllFileMetadata"] = ExpressionConverter.ConvertO(__workflow_getAllFileMetadata);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UpdateFileOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IOutputWorkflowAction<JToken> DeleteFtpFile(Expression<Func<string>> filePath, Expression<Func<bool>> skipIfFileNotPresent = null)
        {
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_skipIfFileNotPresent = WorkflowExpression.Compile(skipIfFileNotPresent, nameof(skipIfFileNotPresent), required: false);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(__workflow_filePath);
                if (__workflow_skipIfFileNotPresent != null)
                {
                    serviceProviderParameters["skipIfFileNotPresent"] = ExpressionConverter.ConvertO(__workflow_skipIfFileNotPresent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "deleteFtpFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ListFilesInFolderOutputItem[]> ListFilesInFolder(Expression<Func<string>> folderPath)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<ListFilesInFolderOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(__workflow_folderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "listFilesInFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListFilesInFolderOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> folderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null, Expression<Func<object>> fileContent = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: false);
            var __workflow_overwriteExistingFilesBehaviour = WorkflowExpression.Compile(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: false);
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

                if (__workflow_fileContent != null)
                {
                    serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(__workflow_fileContent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
            });
        }
    }

    public class FtpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]> WhenFtpFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFileCutOffTimestamp = null, Expression<Func<bool>> ignoreSubFolders = null, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_maxFileCount = WorkflowExpression.Compile(maxFileCount, nameof(maxFileCount), required: false);
            var __workflow_oldFileCutOffTimestamp = WorkflowExpression.Compile(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            var __workflow_ignoreSubFolders = WorkflowExpression.Compile(ignoreSubFolders, nameof(ignoreSubFolders), required: false);
            return new DeferredBodyTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]>(() =>
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

                if (__workflow_ignoreSubFolders != null)
                {
                    serviceProviderParameters["ignoreSubFolders"] = ExpressionConverter.ConvertO(__workflow_ignoreSubFolders);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "whenFtpFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }
    }

    public class WhenFtpFilesAreAddedOrModifiedOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }
    }

    public class GetFileMetadataOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }
    }

    public class CreateFileOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

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

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }
    }

    public class ListFilesInFolderOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Ftp;

    public partial class WorkflowServiceProviderActions
    {
        public FtpActions Ftp(string connectionId) => new FtpActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public FtpTriggers Ftp(string connectionId) => new FtpTriggers(connectionId);
    }
}

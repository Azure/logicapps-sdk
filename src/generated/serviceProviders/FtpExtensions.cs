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

    public class FtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        [WorkflowExpressionFactory(nameof(__BuildGetFtpFileContent))]
        public IBodyWorkflowAction<JToken> GetFtpFileContent([WorkflowExpression] Func<string> filePath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFtpFileContent(WorkflowValue<string> filePath)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        [WorkflowExpressionFactory(nameof(__BuildGetFtpFileContentV2))]
        public IBodyWorkflowAction<JToken> GetFtpFileContentV2([WorkflowExpression] Func<string> filePath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFtpFileContentV2(WorkflowValue<string> filePath)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> getAllFileMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFileOutput> __BuildCreateFile(WorkflowValue<string> filePath, WorkflowValue<object> fileContent, WorkflowValue<bool> getAllFileMetadata = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(fileContent, nameof(fileContent), required: true);
            WorkflowValue.Validate(getAllFileMetadata, nameof(getAllFileMetadata), required: false);
            return new DeferredBodyAction<CreateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
                if (getAllFileMetadata != null)
                {
                    serviceProviderParameters["getAllFileMetadata"] = ExpressionConverter.ConvertO(getAllFileMetadata);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> getAllFileMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateFileOutput> __BuildUpdateFile(WorkflowValue<string> filePath, WorkflowValue<object> fileContent, WorkflowValue<bool> getAllFileMetadata = null)
        {
            WorkflowValue.Validate(filePath, nameof(filePath), required: true);
            WorkflowValue.Validate(fileContent, nameof(fileContent), required: true);
            WorkflowValue.Validate(getAllFileMetadata, nameof(getAllFileMetadata), required: false);
            return new DeferredBodyAction<UpdateFileOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
                serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
                if (getAllFileMetadata != null)
                {
                    serviceProviderParameters["getAllFileMetadata"] = ExpressionConverter.ConvertO(getAllFileMetadata);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteFtpFile))]
        public IOutputWorkflowAction<JToken> DeleteFtpFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipIfFileNotPresent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeleteFtpFile(WorkflowValue<string> filePath, WorkflowValue<bool> skipIfFileNotPresent = null)
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "deleteFtpFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        [WorkflowExpressionFactory(nameof(__BuildListFilesInFolder))]
        public IBodyWorkflowAction<ListFilesInFolderOutputItem[]> ListFilesInFolder([WorkflowExpression] Func<string> folderPath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFilesInFolderOutputItem[]> __BuildListFilesInFolder(WorkflowValue<string> folderPath)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<ListFilesInFolderOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "listFilesInFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListFilesInFolderOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchive))]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<object> fileContent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> __BuildExtractArchive(WorkflowValue<string> folderPath, WorkflowValue<string> filePath = null, WorkflowValue<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, WorkflowValue<object> fileContent = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(filePath, nameof(filePath), required: false);
            WorkflowValue.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            WorkflowValue.Validate(fileContent, nameof(fileContent), required: false);
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

                if (fileContent != null)
                {
                    serviceProviderParameters["fileContent"] = ExpressionConverter.ConvertO(fileContent);
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
        [WorkflowExpressionFactory(nameof(__BuildWhenFtpFilesAreAddedOrModified))]
        public IBodyWorkflowTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]> WhenFtpFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, [WorkflowExpression] Func<bool> ignoreSubFolders = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]> __BuildWhenFtpFilesAreAddedOrModified(WorkflowValue<string> folderPath, WorkflowValue<int> maxFileCount = null, WorkflowValue<string> oldFileCutOffTimestamp = null, WorkflowValue<bool> ignoreSubFolders = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            WorkflowValue.Validate(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            WorkflowValue.Validate(ignoreSubFolders, nameof(ignoreSubFolders), required: false);
            return new DeferredBodyTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]>(() =>
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

                if (ignoreSubFolders != null)
                {
                    serviceProviderParameters["ignoreSubFolders"] = ExpressionConverter.ConvertO(ignoreSubFolders);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "whenFtpFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            }, "ServiceProviderTrigger");
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

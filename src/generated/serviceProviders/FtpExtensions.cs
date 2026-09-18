//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Ftp
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class FtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<JToken> GetFtpFileContent([WorkflowExpression] Func<string> filePath)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<JToken> GetFtpFileContentV2([WorkflowExpression] Func<string> filePath)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata([WorkflowExpression] Func<string> filePath)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetFileMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> getAllFileMetadata = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(fileContent, nameof(fileContent), required: true);
            SourceExpression.Validate(getAllFileMetadata, nameof(getAllFileMetadata), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["fileContent"] = SourceExpressionConverter.ConvertToken(fileContent);
                if (getAllFileMetadata != null)
                {
                    serviceProviderParameters["getAllFileMetadata"] = SourceExpressionConverter.ConvertToken(getAllFileMetadata);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "createFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> getAllFileMetadata = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(fileContent, nameof(fileContent), required: true);
            SourceExpression.Validate(getAllFileMetadata, nameof(getAllFileMetadata), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["fileContent"] = SourceExpressionConverter.ConvertToken(fileContent);
                if (getAllFileMetadata != null)
                {
                    serviceProviderParameters["getAllFileMetadata"] = SourceExpressionConverter.ConvertToken(getAllFileMetadata);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<UpdateFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IOutputWorkflowAction<JToken> DeleteFtpFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipIfFileNotPresent = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(skipIfFileNotPresent, nameof(skipIfFileNotPresent), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                if (skipIfFileNotPresent != null)
                {
                    serviceProviderParameters["skipIfFileNotPresent"] = SourceExpressionConverter.ConvertToken(skipIfFileNotPresent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "deleteFtpFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ListFilesInFolderOutputItem[]> ListFilesInFolder([WorkflowExpression] Func<string> folderPath)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "listFilesInFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListFilesInFolderOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<object> fileContent = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(filePath, nameof(filePath), required: false);
            SourceExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            SourceExpression.Validate(fileContent, nameof(fileContent), required: false);
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

                if (fileContent != null)
                {
                    serviceProviderParameters["fileContent"] = SourceExpressionConverter.ConvertToken(fileContent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(BuildSourceInput);
        }
    }

    public class FtpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]> WhenFtpFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, [WorkflowExpression] Func<bool> ignoreSubFolders = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            SourceExpression.Validate(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
            SourceExpression.Validate(ignoreSubFolders, nameof(ignoreSubFolders), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = SourceExpressionConverter.ConvertToken(maxFileCount);
                }

                if (oldFileCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFileCutOffTimestamp"] = SourceExpressionConverter.ConvertToken(oldFileCutOffTimestamp);
                }

                if (ignoreSubFolders != null)
                {
                    serviceProviderParameters["ignoreSubFolders"] = SourceExpressionConverter.ConvertToken(ignoreSubFolders);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "whenFtpFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
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
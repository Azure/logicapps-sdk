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
        public IBodyWorkflowAction<JToken> GetFtpFileContent([WorkflowExpression] Func<string> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContent", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<JToken> GetFtpFileContentV2([WorkflowExpression] Func<string> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFtpFileContentV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata([WorkflowExpression] Func<string> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "getFileMetadata", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> getAllFileMetadata = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> getAllFileMetadata = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IOutputWorkflowAction<JToken> DeleteFtpFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipIfFileNotPresent = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ListFilesInFolderOutputItem[]> ListFilesInFolder([WorkflowExpression] Func<string> folderPath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Ftp", operationId: "listFilesInFolder", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListFilesInFolderOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<object> fileContent = null)
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
        }
    }

    public class FtpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]> WhenFtpFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, [WorkflowExpression] Func<bool> ignoreSubFolders = null, FlowRecurrence recurrence = null)
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
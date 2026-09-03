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
        public IBodyWorkflowAction<JToken> GetFtpFileContent(Expression<Func<string>> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "getFtpFileContent", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<JToken> GetFtpFileContentV2(Expression<Func<string>> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "getFtpFileContentV2", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata(Expression<Func<string>> filePath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "getFileMetadata", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetFileMetadataOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile(Expression<Func<string>> filePath, Expression<Func<object>> fileContent, Expression<Func<bool>> getAllFileMetadata = null)
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "createFile", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateFileOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile(Expression<Func<string>> filePath, Expression<Func<object>> fileContent, Expression<Func<bool>> getAllFileMetadata = null)
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "updateFile", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<UpdateFileOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IOutputWorkflowAction<JToken> DeleteFtpFile(Expression<Func<string>> filePath, Expression<Func<bool>> skipIfFileNotPresent = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["filePath"] = ExpressionConverter.ConvertO(filePath);
            if (skipIfFileNotPresent != null)
            {
                serviceProviderParameters["skipIfFileNotPresent"] = ExpressionConverter.ConvertO(skipIfFileNotPresent);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "deleteFtpFile", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ListFilesInFolderOutputItem[]> ListFilesInFolder(Expression<Func<string>> folderPath)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["folderPath"] = ExpressionConverter.ConvertO(folderPath);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "listFilesInFolder", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListFilesInFolderOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Ftp")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive(Expression<Func<string>> folderPath, Expression<Func<string>> filePath = null, Expression<Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null, Expression<Func<object>> fileContent = null)
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "extractArchive", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(serviceProviderInput);
        }
    }

    public class FtpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFtpFilesAreAddedOrModifiedOutputItem[]> WhenFtpFilesAreAddedOrModified(Expression<Func<string>> folderPath, Expression<Func<int>> maxFileCount = null, Expression<Func<string>> oldFileCutOffTimestamp = null, Expression<Func<bool>> ignoreSubFolders = null, FlowRecurrence recurrence = null)
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/Ftp", "whenFtpFilesAreAddedOrModified", connectionId),
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
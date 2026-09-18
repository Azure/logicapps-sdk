//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFile
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureFileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<CopyFileOutput> CopyFile([WorkflowExpression] Func<string> sourceFilePath, [WorkflowExpression] Func<string> destinationFilePath, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(sourceFilePath, nameof(sourceFilePath), required: true);
            SourceExpression.Validate(destinationFilePath, nameof(destinationFilePath), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["SourceFilePath"] = SourceExpressionConverter.ConvertToken(sourceFilePath);
                serviceProviderParameters["destinationFilePath"] = SourceExpressionConverter.ConvertToken(destinationFilePath);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = SourceExpressionConverter.ConvertToken(overwrite);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CopyFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> destinationFolderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null, [WorkflowExpression] Func<object> fileContent = null)
        {
            SourceExpression.Validate(destinationFolderPath, nameof(destinationFolderPath), required: true);
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

                serviceProviderParameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(destinationFolderPath);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<object> fileContent, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(fileContent, nameof(fileContent), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                serviceProviderParameters["fileName"] = SourceExpressionConverter.ConvertToken(fileName);
                serviceProviderParameters["fileContent"] = SourceExpressionConverter.ConvertToken(fileContent);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = SourceExpressionConverter.ConvertToken(overwrite);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "createFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IOutputWorkflowAction<bool> DeleteFile([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = SourceExpressionConverter.ConvertToken(fileId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "deleteFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<bool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContent([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = SourceExpressionConverter.ConvertToken(fileId);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContentV2([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = SourceExpressionConverter.ConvertToken(fileId);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<JToken> GetFileContentByPath([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = SourceExpressionConverter.ConvertToken(fileId);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileContentByPath", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = SourceExpressionConverter.ConvertToken(fileId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetFileMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<GetFileMetadataByPathOutput> GetFileMetadataByPath([WorkflowExpression] Func<string> filePath)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "getFileMetadataByPath", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetFileMetadataByPathOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder([WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderId"] = SourceExpressionConverter.ConvertToken(folderId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListFolderOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureFile")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<object> fileContent)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(fileContent, nameof(fileContent), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileId"] = SourceExpressionConverter.ConvertToken(fileId);
                serviceProviderParameters["fileContent"] = SourceExpressionConverter.ConvertToken(fileContent);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<UpdateFileOutput>(BuildSourceInput);
        }
    }

    public class AzureFileTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            SourceExpression.Validate(oldFilesCutOffTimestamp, nameof(oldFilesCutOffTimestamp), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = SourceExpressionConverter.ConvertToken(maxFileCount);
                }

                if (oldFilesCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutOffTimestamp"] = SourceExpressionConverter.ConvertToken(oldFilesCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAdded", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFilesCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            SourceExpression.Validate(oldFilesCutOffTimestamp, nameof(oldFilesCutOffTimestamp), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (maxFileCount != null)
                {
                    serviceProviderParameters["maxFileCount"] = SourceExpressionConverter.ConvertToken(maxFileCount);
                }

                if (oldFilesCutOffTimestamp != null)
                {
                    serviceProviderParameters["oldFilesCutOffTimestamp"] = SourceExpressionConverter.ConvertToken(oldFilesCutOffTimestamp);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureFile", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }
    }

    public class WhenFilesAreAddedOutputItem
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class WhenFilesAreAddedOrModifiedOutputItem
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class CopyFileOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
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

    public class CreateFileOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class GetFileMetadataOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class GetFileMetadataByPathOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class ListFolderOutputItem
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }

    public class UpdateFileOutput
    {
        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isFolder")]
        public string IsFolder { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureFile;

    public partial class WorkflowServiceProviderActions
    {
        public AzureFileActions AzureFile(string connectionId) => new AzureFileActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureFileTriggers AzureFile(string connectionId) => new AzureFileTriggers(connectionId);
    }
}
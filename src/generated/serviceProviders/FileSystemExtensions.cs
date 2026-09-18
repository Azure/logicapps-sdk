//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.FileSystem
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class FileSystemActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction AppendFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> body, [WorkflowExpression] Func<bool> createFileIfNotPresent = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(body, nameof(body), required: true);
            SourceExpression.Validate(createFileIfNotPresent, nameof(createFileIfNotPresent), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                if (createFileIfNotPresent != null)
                {
                    serviceProviderParameters["createFileIfNotPresent"] = SourceExpressionConverter.ConvertToken(createFileIfNotPresent);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "appendFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["source"] = SourceExpressionConverter.ConvertToken(source);
                serviceProviderParameters["destination"] = SourceExpressionConverter.ConvertToken(destination);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = SourceExpressionConverter.ConvertToken(overwrite);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "copyFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<CreateFileOutput> CreateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                if (body != null)
                {
                    serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "createFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IOutputWorkflowAction<JToken> DeleteFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> skipIfFileNotPresent = null)
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "deleteFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<JToken> GetFileContent([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<bool> inferContentType = null)
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileContentV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<GetFileMetadataOutput> GetFileMetadata([WorkflowExpression] Func<string> filePath)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "getFileMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetFileMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<ListFolderOutputItem[]> ListFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<bool> enableRecursiveListing = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(enableRecursiveListing, nameof(enableRecursiveListing), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (enableRecursiveListing != null)
                {
                    serviceProviderParameters["enableRecursiveListing"] = SourceExpressionConverter.ConvertToken(enableRecursiveListing);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "listFolder", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListFolderOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IWorkflowAction RenameFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<string> newName)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(newName, nameof(newName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["newName"] = SourceExpressionConverter.ConvertToken(newName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "renameFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<UpdateFileOutput> UpdateFile([WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<object> body)
        {
            SourceExpression.Validate(filePath, nameof(filePath), required: true);
            SourceExpression.Validate(body, nameof(body), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "updateFile", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<UpdateFileOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "FileSystem")]
        public IBodyWorkflowAction<ExtractArchiveOutputItem[]> ExtractArchive([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> filePath = null, [WorkflowExpression] Func<ExtractArchiveInputOverwriteType> overwrite = null, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(filePath, nameof(filePath), required: false);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (filePath != null)
                {
                    serviceProviderParameters["filePath"] = SourceExpressionConverter.ConvertToken(filePath);
                }

                serviceProviderParameters["folderPath"] = SourceExpressionConverter.ConvertToken(folderPath);
                if (overwrite != null)
                {
                    serviceProviderParameters["overwrite"] = SourceExpressionConverter.ConvertToken(overwrite);
                }

                if (body != null)
                {
                    serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "extractArchive", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveOutputItem[]>(BuildSourceInput);
        }
    }

    public class FileSystemTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenFilesAreAddedOutputItem[]> WhenFilesAreAdded([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            SourceExpression.Validate(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
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

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAdded", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFilesAreAddedOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<WhenFilesAreAddedOrModifiedOutputItem[]> WhenFilesAreAddedOrModified([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<int> maxFileCount = null, [WorkflowExpression] Func<string> oldFileCutOffTimestamp = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            SourceExpression.Validate(oldFileCutOffTimestamp, nameof(oldFileCutOffTimestamp), required: false);
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

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/FileSystem", operationId: "whenFilesAreAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenFilesAreAddedOrModifiedOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }
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
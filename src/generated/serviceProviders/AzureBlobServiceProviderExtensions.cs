//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureBlobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<BlobExistsOutput> BlobExists(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "blobExists", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<BlobExistsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlob", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlobFromUri(Expression<Func<string>> blobUri)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlobFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobOutput> ReadBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "readBlob", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ReadBlobOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobFromUriOutput> ReadBlobFromUri(Expression<Func<string>> blobUri, Expression<Func<bool>> inferContentType = null)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            if (inferContentType != null)
            {
                parameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "readBlobFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ReadBlobFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<UploadBlobOutput> UploadBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<object>> content, Expression<Func<UploadBlobOverrideIfExistsType>> overrideIfExists = null)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            parameters["content"] = ExpressionConverter.ConvertO(content);
            if (overrideIfExists != null)
            {
                parameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "uploadBlob", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<UploadBlobOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<UploadBlobFromUriOutput> UploadBlobFromUri(Expression<Func<string>> blobUri, Expression<Func<object>> content, Expression<Func<UploadBlobFromUriOverrideIfExistsType>> overrideIfExists = null)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            parameters["content"] = ExpressionConverter.ConvertO(content);
            if (overrideIfExists != null)
            {
                parameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "uploadBlobFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<UploadBlobFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobsOutput> ListBlobs(Expression<Func<string>> containerName, Expression<Func<string>> blobNamePrefix = null, Expression<Func<string>> pageMarker = null, Expression<Func<bool>> excludeSubFolderBlobs = null)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            if (blobNamePrefix != null)
            {
                parameters["blobNamePrefix"] = ExpressionConverter.ConvertO(blobNamePrefix);
            }

            if (pageMarker != null)
            {
                parameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
            }

            if (excludeSubFolderBlobs != null)
            {
                parameters["excludeSubFolderBlobs"] = ExpressionConverter.ConvertO(excludeSubFolderBlobs);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobs", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListBlobsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobsFromUriOutput> ListBlobsFromUri(Expression<Func<string>> blobUri, Expression<Func<string>> pageMarker = null)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            if (pageMarker != null)
            {
                parameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobsFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListBlobsFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobDirectoriesOutput> ListBlobDirectories(Expression<Func<string>> containerName, Expression<Func<string>> blobNamePrefix = null)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            if (blobNamePrefix != null)
            {
                parameters["blobNamePrefix"] = ExpressionConverter.ConvertO(blobNamePrefix);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobDirectories", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListBlobDirectoriesOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListContainersOutput> ListContainers(Expression<Func<string>> pageMarker = null)
        {
            var parameters = new JObject();
            if (pageMarker != null)
            {
                parameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listContainers", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListContainersOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobSASUriOutput> GetBlobSASUri(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<string>> groupPolicyIdentifier = null, Expression<Func<GetBlobSASUriPermissionsType>> permissions = null, Expression<Func<string>> startTime = null, Expression<Func<string>> expiryTime = null, Expression<Func<GetBlobSASUriSharedAccessProtocolType>> sharedAccessProtocol = null, Expression<Func<string>> ipAddressRange = null)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            if (groupPolicyIdentifier != null)
            {
                parameters["groupPolicyIdentifier"] = ExpressionConverter.ConvertO(groupPolicyIdentifier);
            }

            if (permissions != null)
            {
                parameters["permissions"] = ExpressionConverter.ConvertO(permissions);
            }

            if (startTime != null)
            {
                parameters["startTime"] = ExpressionConverter.ConvertO(startTime);
            }

            if (expiryTime != null)
            {
                parameters["expiryTime"] = ExpressionConverter.ConvertO(expiryTime);
            }

            if (sharedAccessProtocol != null)
            {
                parameters["sharedAccessProtocol"] = ExpressionConverter.ConvertO(sharedAccessProtocol);
            }

            if (ipAddressRange != null)
            {
                parameters["ipAddressRange"] = ExpressionConverter.ConvertO(ipAddressRange);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobSASUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetBlobSASUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobSASUriFromUriOutput> GetBlobSASUriFromUri(Expression<Func<string>> blobUri, Expression<Func<string>> groupPolicyIdentifier = null, Expression<Func<GetBlobSASUriFromUriPermissionsType>> permissions = null, Expression<Func<string>> startTime = null, Expression<Func<string>> expiryTime = null, Expression<Func<GetBlobSASUriFromUriSharedAccessProtocolType>> sharedAccessProtocol = null, Expression<Func<string>> ipAddressRange = null)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            if (groupPolicyIdentifier != null)
            {
                parameters["groupPolicyIdentifier"] = ExpressionConverter.ConvertO(groupPolicyIdentifier);
            }

            if (permissions != null)
            {
                parameters["permissions"] = ExpressionConverter.ConvertO(permissions);
            }

            if (startTime != null)
            {
                parameters["startTime"] = ExpressionConverter.ConvertO(startTime);
            }

            if (expiryTime != null)
            {
                parameters["expiryTime"] = ExpressionConverter.ConvertO(expiryTime);
            }

            if (sharedAccessProtocol != null)
            {
                parameters["sharedAccessProtocol"] = ExpressionConverter.ConvertO(sharedAccessProtocol);
            }

            if (ipAddressRange != null)
            {
                parameters["ipAddressRange"] = ExpressionConverter.ConvertO(ipAddressRange);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobSASUriFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetBlobSASUriFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataOutput> GetBlobMetadata(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetBlobMetadataOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataFromUriOutput> GetBlobMetadataFromUri(Expression<Func<string>> blobUri)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadataFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetBlobMetadataFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetContainerMetadataOutput> GetContainerMetadata(Expression<Func<string>> containerName)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getContainerMetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetContainerMetadataOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobOutput> CopyBlob(Expression<Func<string>> sourceContainerName, Expression<Func<string>> sourceBlobName, Expression<Func<string>> destinationContainerName, Expression<Func<string>> destinationBlobName, Expression<Func<bool>> overrideIfExists = null)
        {
            var parameters = new JObject();
            parameters["sourceContainerName"] = ExpressionConverter.ConvertO(sourceContainerName);
            parameters["sourceBlobName"] = ExpressionConverter.ConvertO(sourceBlobName);
            parameters["destinationContainerName"] = ExpressionConverter.ConvertO(destinationContainerName);
            parameters["destinationBlobName"] = ExpressionConverter.ConvertO(destinationBlobName);
            if (overrideIfExists != null)
            {
                parameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "copyBlob", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CopyBlobOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobFromUriOutput> CopyBlobFromUri(Expression<Func<string>> sourceBlobUri, Expression<Func<string>> destinationBlobUri, Expression<Func<bool>> overrideIfExists = null)
        {
            var parameters = new JObject();
            parameters["sourceBlobUri"] = ExpressionConverter.ConvertO(sourceBlobUri);
            parameters["destinationBlobUri"] = ExpressionConverter.ConvertO(destinationBlobUri);
            if (overrideIfExists != null)
            {
                parameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "copyBlobFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CopyBlobFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetAccessPoliciesOutputItem[]> GetAccessPolicies(Expression<Func<string>> containerName)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getAccessPolicies", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetAccessPoliciesOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTier(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<SetBlobTierBlobAccessTierType>> blobAccessTier)
        {
            var parameters = new JObject();
            parameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            parameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            parameters["blobAccessTier"] = ExpressionConverter.ConvertO(blobAccessTier);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTier", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTierFromUri(Expression<Func<string>> blobUri, Expression<Func<SetBlobTierFromUriBlobAccessTierType>> blobAccessTier)
        {
            var parameters = new JObject();
            parameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            parameters["blobAccessTier"] = ExpressionConverter.ConvertO(blobAccessTier);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTierFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromBlobPathOutput> ExtractArchiveFromBlobPath(Expression<Func<string>> sourceContainerName, Expression<Func<string>> sourceBlobName, Expression<Func<string>> destinationContainerName, Expression<Func<string>> destinationFolderPath, Expression<Func<ExtractArchiveFromBlobPathOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var parameters = new JObject();
            parameters["sourceContainerName"] = ExpressionConverter.ConvertO(sourceContainerName);
            parameters["sourceBlobName"] = ExpressionConverter.ConvertO(sourceBlobName);
            parameters["destinationContainerName"] = ExpressionConverter.ConvertO(destinationContainerName);
            parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(destinationFolderPath);
            if (overwriteExistingFilesBehaviour != null)
            {
                parameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromBlobPath", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExtractArchiveFromBlobPathOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromUriOutput> ExtractArchiveFromUri(Expression<Func<string>> sourceBlobUri, Expression<Func<string>> destinationBlobUri, Expression<Func<ExtractArchiveFromUriOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var parameters = new JObject();
            parameters["sourceBlobUri"] = ExpressionConverter.ConvertO(sourceBlobUri);
            parameters["destinationBlobUri"] = ExpressionConverter.ConvertO(destinationBlobUri);
            if (overwriteExistingFilesBehaviour != null)
            {
                parameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromUri", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExtractArchiveFromUriOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromContentOutput> ExtractArchiveFromContent(Expression<Func<string>> destinationContainerName, Expression<Func<string>> content = null, Expression<Func<string>> destinationFolderPath = null, Expression<Func<ExtractArchiveFromContentOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var parameters = new JObject();
            if (content != null)
            {
                parameters["content"] = ExpressionConverter.ConvertO(content);
            }

            parameters["destinationContainerName"] = ExpressionConverter.ConvertO(destinationContainerName);
            if (destinationFolderPath != null)
            {
                parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(destinationFolderPath);
            }

            if (overwriteExistingFilesBehaviour != null)
            {
                parameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromContent", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExtractArchiveFromContentOutput>(input);
        }
    }

    public class AzureBlobTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenABlobIsAddedOrModifiedOutput> WhenABlobIsAddedOrModified(Expression<Func<string>> path, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["path"] = ExpressionConverter.ConvertO(path);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "whenABlobIsAddedOrModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenABlobIsAddedOrModifiedOutput>(input, triggerName);
        }
    }

    public class BlobExistsOutput
    {
        [JsonProperty("isBlobExists")]
        public bool IsBlobExists { get; set; }

        [JsonProperty("properties")]
        public BlobExistsOutputPropertiesType Properties { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class BlobExistsOutputPropertiesType
    {
        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class ReadBlobOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("properties")]
        public ReadBlobOutputPropertiesType Properties { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ReadBlobOutputPropertiesType
    {
        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class ReadBlobFromUriOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("properties")]
        public ReadBlobFromUriOutputPropertiesType Properties { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ReadBlobFromUriOutputPropertiesType
    {
        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class UploadBlobOutput
    {
        [JsonProperty("properties")]
        public UploadBlobOutputPropertiesType Properties { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UploadBlobOutputPropertiesType
    {
        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public enum UploadBlobOverrideIfExistsType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class UploadBlobFromUriOutput
    {
        [JsonProperty("properties")]
        public UploadBlobFromUriOutputPropertiesType Properties { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UploadBlobFromUriOutputPropertiesType
    {
        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public enum UploadBlobFromUriOverrideIfExistsType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class ListBlobsOutput
    {
        [JsonProperty("blobs")]
        public ListBlobsOutputBlobsTypeItem[] Blobs { get; set; }

        [JsonProperty("pageMarker")]
        public string PageMarker { get; set; }
    }

    public class ListBlobsOutputBlobsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class ListBlobsFromUriOutput
    {
        [JsonProperty("blobs")]
        public ListBlobsFromUriOutputBlobsTypeItem[] Blobs { get; set; }

        [JsonProperty("pageMarker")]
        public string PageMarker { get; set; }
    }

    public class ListBlobsFromUriOutputBlobsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class ListBlobDirectoriesOutput
    {
        [JsonProperty("blobDirectories")]
        public ListBlobDirectoriesOutputBlobDirectoriesTypeItem[] BlobDirectories { get; set; }
    }

    public class ListBlobDirectoriesOutputBlobDirectoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListContainersOutput
    {
        [JsonProperty("containers")]
        public ListContainersOutputContainersTypeItem[] Containers { get; set; }

        [JsonProperty("pageMarker")]
        public string PageMarker { get; set; }
    }

    public class ListContainersOutputContainersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class GetBlobSASUriOutput
    {
        [JsonProperty("blobUri")]
        public JToken BlobUri { get; set; }
    }

    public enum GetBlobSASUriPermissionsType
    {
        Read,
        Write,
        Add,
        Create,
        Delete,
        All,
        List,
        [EnumMember(Value = "Read,Write")]
        ReadWrite,
        [EnumMember(Value = "Read,Write,List")]
        ReadWriteList,
        [EnumMember(Value = "Read,Write,List,Delete")]
        ReadWriteListDelete
    }

    public enum GetBlobSASUriSharedAccessProtocolType
    {
        Https,
        HttpsAndHttp
    }

    public class GetBlobSASUriFromUriOutput
    {
        [JsonProperty("blobUri")]
        public JToken BlobUri { get; set; }
    }

    public enum GetBlobSASUriFromUriPermissionsType
    {
        Read,
        Write,
        Add,
        Create,
        Delete,
        All,
        List,
        [EnumMember(Value = "Read,Write")]
        ReadWrite,
        [EnumMember(Value = "Read,Write,List")]
        ReadWriteList,
        [EnumMember(Value = "Read,Write,List,Delete")]
        ReadWriteListDelete
    }

    public enum GetBlobSASUriFromUriSharedAccessProtocolType
    {
        Https,
        HttpsAndHttp
    }

    public class GetBlobMetadataOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class GetBlobMetadataFromUriOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class GetContainerMetadataOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class CopyBlobOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class CopyBlobFromUriOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }

    public class GetAccessPoliciesOutputItem
    {
        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("policyExpiresOn")]
        public string PolicyExpiresOn { get; set; }

        [JsonProperty("policyStartsOn")]
        public string PolicyStartsOn { get; set; }
    }

    public enum SetBlobTierBlobAccessTierType
    {
        Hot,
        Cool,
        Archive
    }

    public enum SetBlobTierFromUriBlobAccessTierType
    {
        Hot,
        Cool,
        Archive
    }

    public class ExtractArchiveFromBlobPathOutput
    {
        [JsonProperty("extractedBlobs")]
        public ExtractArchiveFromBlobPathOutputExtractedBlobsTypeItem[] ExtractedBlobs { get; set; }
    }

    public class ExtractArchiveFromBlobPathOutputExtractedBlobsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("actualSize")]
        public string ActualSize { get; set; }

        [JsonProperty("compressedSize")]
        public string CompressedSize { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public enum ExtractArchiveFromBlobPathOverwriteExistingFilesBehaviourType
    {
        Fail,
        Skip,
        Overwrite
    }

    public class ExtractArchiveFromUriOutput
    {
        [JsonProperty("extractedBlobs")]
        public ExtractArchiveFromUriOutputExtractedBlobsTypeItem[] ExtractedBlobs { get; set; }
    }

    public class ExtractArchiveFromUriOutputExtractedBlobsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("actualSize")]
        public string ActualSize { get; set; }

        [JsonProperty("compressedSize")]
        public string CompressedSize { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public enum ExtractArchiveFromUriOverwriteExistingFilesBehaviourType
    {
        Fail,
        Skip,
        Overwrite
    }

    public class ExtractArchiveFromContentOutput
    {
        [JsonProperty("extractedBlobs")]
        public ExtractArchiveFromContentOutputExtractedBlobsTypeItem[] ExtractedBlobs { get; set; }
    }

    public class ExtractArchiveFromContentOutputExtractedBlobsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("actualSize")]
        public string ActualSize { get; set; }

        [JsonProperty("compressedSize")]
        public string CompressedSize { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public enum ExtractArchiveFromContentOverwriteExistingFilesBehaviourType
    {
        Fail,
        Skip,
        Overwrite
    }

    public class WhenABlobIsAddedOrModifiedOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("containerInfo")]
        public WhenABlobIsAddedOrModifiedOutputContainerInfoType ContainerInfo { get; set; }

        [JsonProperty("properties")]
        public WhenABlobIsAddedOrModifiedOutputPropertiesType Properties { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class WhenABlobIsAddedOrModifiedOutputContainerInfoType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public string Properties { get; set; }
    }

    public class WhenABlobIsAddedOrModifiedOutputPropertiesType
    {
        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("blobType")]
        public string BlobType { get; set; }

        [JsonProperty("blobFullPathWithContainer")]
        public string BlobFullPathWithContainer { get; set; }

        [JsonProperty("contentDisposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLanguage")]
        public string ContentLanguage { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob;

    public partial class WorkflowServiceProviderActions
    {
        public AzureBlobActions AzureBlob(string connectionId) => new AzureBlobActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureBlobTriggers AzureBlob(string connectionId) => new AzureBlobTriggers(connectionId);
    }
}
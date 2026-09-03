//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureBlobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<BlobExistsOutput> BlobExists(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "blobExists", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BlobExistsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "deleteBlob", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlobFromUri(Expression<Func<string>> blobUri)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "deleteBlobFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobOutput> ReadBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<bool>> inferContentType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            if (inferContentType != null)
            {
                serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "readBlob", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ReadBlobOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobFromUriOutput> ReadBlobFromUri(Expression<Func<string>> blobUri, Expression<Func<bool>> inferContentType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            if (inferContentType != null)
            {
                serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "readBlobFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ReadBlobFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<UploadBlobOutput> UploadBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<object>> content, Expression<Func<UploadBlobInputOverrideIfExistsType>> overrideIfExists = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            if (overrideIfExists != null)
            {
                serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "uploadBlob", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<UploadBlobOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<UploadBlobFromUriOutput> UploadBlobFromUri(Expression<Func<string>> blobUri, Expression<Func<object>> content, Expression<Func<UploadBlobFromUriInputOverrideIfExistsType>> overrideIfExists = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            if (overrideIfExists != null)
            {
                serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "uploadBlobFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<UploadBlobFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobsOutput> ListBlobs(Expression<Func<string>> containerName, Expression<Func<string>> blobNamePrefix = null, Expression<Func<string>> pageMarker = null, Expression<Func<bool>> excludeSubFolderBlobs = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            if (blobNamePrefix != null)
            {
                serviceProviderParameters["blobNamePrefix"] = ExpressionConverter.ConvertO(blobNamePrefix);
            }

            if (pageMarker != null)
            {
                serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
            }

            if (excludeSubFolderBlobs != null)
            {
                serviceProviderParameters["excludeSubFolderBlobs"] = ExpressionConverter.ConvertO(excludeSubFolderBlobs);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "listBlobs", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListBlobsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobsFromUriOutput> ListBlobsFromUri(Expression<Func<string>> blobUri, Expression<Func<string>> pageMarker = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            if (pageMarker != null)
            {
                serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "listBlobsFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListBlobsFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobDirectoriesOutput> ListBlobDirectories(Expression<Func<string>> containerName, Expression<Func<string>> blobNamePrefix = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            if (blobNamePrefix != null)
            {
                serviceProviderParameters["blobNamePrefix"] = ExpressionConverter.ConvertO(blobNamePrefix);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "listBlobDirectories", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListBlobDirectoriesOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListContainersOutput> ListContainers(Expression<Func<string>> pageMarker = null)
        {
            var serviceProviderParameters = new JObject();
            if (pageMarker != null)
            {
                serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "listContainers", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListContainersOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobSASUriOutput> GetBlobSASUri(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<string>> groupPolicyIdentifier = null, Expression<Func<GetBlobSASUriInputPermissionsType>> permissions = null, Expression<Func<string>> startTime = null, Expression<Func<string>> expiryTime = null, Expression<Func<GetBlobSASUriInputSharedAccessProtocolType>> sharedAccessProtocol = null, Expression<Func<string>> ipAddressRange = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            if (groupPolicyIdentifier != null)
            {
                serviceProviderParameters["groupPolicyIdentifier"] = ExpressionConverter.ConvertO(groupPolicyIdentifier);
            }

            if (permissions != null)
            {
                serviceProviderParameters["permissions"] = ExpressionConverter.ConvertO(permissions);
            }

            if (startTime != null)
            {
                serviceProviderParameters["startTime"] = ExpressionConverter.ConvertO(startTime);
            }

            if (expiryTime != null)
            {
                serviceProviderParameters["expiryTime"] = ExpressionConverter.ConvertO(expiryTime);
            }

            if (sharedAccessProtocol != null)
            {
                serviceProviderParameters["sharedAccessProtocol"] = ExpressionConverter.ConvertO(sharedAccessProtocol);
            }

            if (ipAddressRange != null)
            {
                serviceProviderParameters["ipAddressRange"] = ExpressionConverter.ConvertO(ipAddressRange);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "getBlobSASUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetBlobSASUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobSASUriFromUriOutput> GetBlobSASUriFromUri(Expression<Func<string>> blobUri, Expression<Func<string>> groupPolicyIdentifier = null, Expression<Func<GetBlobSASUriFromUriInputPermissionsType>> permissions = null, Expression<Func<string>> startTime = null, Expression<Func<string>> expiryTime = null, Expression<Func<GetBlobSASUriFromUriInputSharedAccessProtocolType>> sharedAccessProtocol = null, Expression<Func<string>> ipAddressRange = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            if (groupPolicyIdentifier != null)
            {
                serviceProviderParameters["groupPolicyIdentifier"] = ExpressionConverter.ConvertO(groupPolicyIdentifier);
            }

            if (permissions != null)
            {
                serviceProviderParameters["permissions"] = ExpressionConverter.ConvertO(permissions);
            }

            if (startTime != null)
            {
                serviceProviderParameters["startTime"] = ExpressionConverter.ConvertO(startTime);
            }

            if (expiryTime != null)
            {
                serviceProviderParameters["expiryTime"] = ExpressionConverter.ConvertO(expiryTime);
            }

            if (sharedAccessProtocol != null)
            {
                serviceProviderParameters["sharedAccessProtocol"] = ExpressionConverter.ConvertO(sharedAccessProtocol);
            }

            if (ipAddressRange != null)
            {
                serviceProviderParameters["ipAddressRange"] = ExpressionConverter.ConvertO(ipAddressRange);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "getBlobSASUriFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetBlobSASUriFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataOutput> GetBlobMetadata(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "getBlobMetadata", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetBlobMetadataOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataFromUriOutput> GetBlobMetadataFromUri(Expression<Func<string>> blobUri)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "getBlobMetadataFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetBlobMetadataFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetContainerMetadataOutput> GetContainerMetadata(Expression<Func<string>> containerName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "getContainerMetadata", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetContainerMetadataOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobOutput> CopyBlob(Expression<Func<string>> sourceContainerName, Expression<Func<string>> sourceBlobName, Expression<Func<string>> destinationContainerName, Expression<Func<string>> destinationBlobName, Expression<Func<bool>> overrideIfExists = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sourceContainerName"] = ExpressionConverter.ConvertO(sourceContainerName);
            serviceProviderParameters["sourceBlobName"] = ExpressionConverter.ConvertO(sourceBlobName);
            serviceProviderParameters["destinationContainerName"] = ExpressionConverter.ConvertO(destinationContainerName);
            serviceProviderParameters["destinationBlobName"] = ExpressionConverter.ConvertO(destinationBlobName);
            if (overrideIfExists != null)
            {
                serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "copyBlob", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CopyBlobOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobFromUriOutput> CopyBlobFromUri(Expression<Func<string>> sourceBlobUri, Expression<Func<string>> destinationBlobUri, Expression<Func<bool>> overrideIfExists = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sourceBlobUri"] = ExpressionConverter.ConvertO(sourceBlobUri);
            serviceProviderParameters["destinationBlobUri"] = ExpressionConverter.ConvertO(destinationBlobUri);
            if (overrideIfExists != null)
            {
                serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(overrideIfExists);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "copyBlobFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CopyBlobFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetAccessPoliciesOutputItem[]> GetAccessPolicies(Expression<Func<string>> containerName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "getAccessPolicies", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetAccessPoliciesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTier(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<SetBlobTierInputBlobAccessTierType>> blobAccessTier)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
            serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
            serviceProviderParameters["blobAccessTier"] = ExpressionConverter.ConvertO(blobAccessTier);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "setBlobTier", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTierFromUri(Expression<Func<string>> blobUri, Expression<Func<SetBlobTierFromUriInputBlobAccessTierType>> blobAccessTier)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
            serviceProviderParameters["blobAccessTier"] = ExpressionConverter.ConvertO(blobAccessTier);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "setBlobTierFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromBlobPathOutput> ExtractArchiveFromBlobPath(Expression<Func<string>> sourceContainerName, Expression<Func<string>> sourceBlobName, Expression<Func<string>> destinationContainerName, Expression<Func<string>> destinationFolderPath, Expression<Func<ExtractArchiveFromBlobPathInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sourceContainerName"] = ExpressionConverter.ConvertO(sourceContainerName);
            serviceProviderParameters["sourceBlobName"] = ExpressionConverter.ConvertO(sourceBlobName);
            serviceProviderParameters["destinationContainerName"] = ExpressionConverter.ConvertO(destinationContainerName);
            serviceProviderParameters["destinationFolderPath"] = ExpressionConverter.ConvertO(destinationFolderPath);
            if (overwriteExistingFilesBehaviour != null)
            {
                serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "extractArchiveFromBlobPath", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ExtractArchiveFromBlobPathOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromUriOutput> ExtractArchiveFromUri(Expression<Func<string>> sourceBlobUri, Expression<Func<string>> destinationBlobUri, Expression<Func<ExtractArchiveFromUriInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sourceBlobUri"] = ExpressionConverter.ConvertO(sourceBlobUri);
            serviceProviderParameters["destinationBlobUri"] = ExpressionConverter.ConvertO(destinationBlobUri);
            if (overwriteExistingFilesBehaviour != null)
            {
                serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "extractArchiveFromUri", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ExtractArchiveFromUriOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromContentOutput> ExtractArchiveFromContent(Expression<Func<string>> destinationContainerName, Expression<Func<string>> content = null, Expression<Func<string>> destinationFolderPath = null, Expression<Func<ExtractArchiveFromContentInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var serviceProviderParameters = new JObject();
            if (content != null)
            {
                serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            }

            serviceProviderParameters["destinationContainerName"] = ExpressionConverter.ConvertO(destinationContainerName);
            if (destinationFolderPath != null)
            {
                serviceProviderParameters["destinationFolderPath"] = ExpressionConverter.ConvertO(destinationFolderPath);
            }

            if (overwriteExistingFilesBehaviour != null)
            {
                serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(overwriteExistingFilesBehaviour);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "extractArchiveFromContent", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ExtractArchiveFromContentOutput>(serviceProviderInput);
        }
    }

    public class AzureBlobTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenABlobIsAddedOrModifiedOutput> WhenABlobIsAddedOrModified(Expression<Func<string>> path)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["path"] = ExpressionConverter.ConvertO(path);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/AzureBlob", "whenABlobIsAddedOrModified", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<WhenABlobIsAddedOrModifiedOutput>(serviceProviderInput);
        }
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UploadBlobInputOverrideIfExistsType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UploadBlobFromUriInputOverrideIfExistsType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetBlobSASUriInputPermissionsType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetBlobSASUriInputSharedAccessProtocolType
    {
        Https,
        HttpsAndHttp
    }

    public class GetBlobSASUriFromUriOutput
    {
        [JsonProperty("blobUri")]
        public JToken BlobUri { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetBlobSASUriFromUriInputPermissionsType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetBlobSASUriFromUriInputSharedAccessProtocolType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SetBlobTierInputBlobAccessTierType
    {
        Hot,
        Cool,
        Archive
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SetBlobTierFromUriInputBlobAccessTierType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractArchiveFromBlobPathInputOverwriteExistingFilesBehaviourType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractArchiveFromUriInputOverwriteExistingFilesBehaviourType
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtractArchiveFromContentInputOverwriteExistingFilesBehaviourType
    {
        Fail,
        Skip,
        Overwrite
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
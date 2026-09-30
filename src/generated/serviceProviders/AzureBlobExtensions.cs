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
        public IBodyWorkflowAction<BlobExistsOutput> BlobExists([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "blobExists", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<BlobExistsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlob([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlobFromUri([WorkflowExpression] Func<string> blobUri)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobOutput> ReadBlob([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = SourceExpressionConverter.ConvertToken(inferContentType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "readBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ReadBlobOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobFromUriOutput> ReadBlobFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = SourceExpressionConverter.ConvertToken(inferContentType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "readBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ReadBlobFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<UploadBlobOutput> UploadBlob([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<object> content, [WorkflowExpression] Func<UploadBlobInputOverrideIfExistsType> overrideIfExists = null)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            SourceExpression.Validate(content, nameof(content), required: true);
            SourceExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                serviceProviderParameters["content"] = SourceExpressionConverter.ConvertToken(content);
                if (overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = SourceExpressionConverter.ConvertToken(overrideIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "uploadBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<UploadBlobOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<UploadBlobFromUriOutput> UploadBlobFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<object> content, [WorkflowExpression] Func<UploadBlobFromUriInputOverrideIfExistsType> overrideIfExists = null)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            SourceExpression.Validate(content, nameof(content), required: true);
            SourceExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                serviceProviderParameters["content"] = SourceExpressionConverter.ConvertToken(content);
                if (overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = SourceExpressionConverter.ConvertToken(overrideIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "uploadBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<UploadBlobFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobsOutput> ListBlobs([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobNamePrefix = null, [WorkflowExpression] Func<string> pageMarker = null, [WorkflowExpression] Func<bool> excludeSubFolderBlobs = null)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobNamePrefix, nameof(blobNamePrefix), required: false);
            SourceExpression.Validate(pageMarker, nameof(pageMarker), required: false);
            SourceExpression.Validate(excludeSubFolderBlobs, nameof(excludeSubFolderBlobs), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                if (blobNamePrefix != null)
                {
                    serviceProviderParameters["blobNamePrefix"] = SourceExpressionConverter.ConvertToken(blobNamePrefix);
                }

                if (pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = SourceExpressionConverter.ConvertToken(pageMarker);
                }

                if (excludeSubFolderBlobs != null)
                {
                    serviceProviderParameters["excludeSubFolderBlobs"] = SourceExpressionConverter.ConvertToken(excludeSubFolderBlobs);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobs", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListBlobsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobsFromUriOutput> ListBlobsFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<string> pageMarker = null)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            SourceExpression.Validate(pageMarker, nameof(pageMarker), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                if (pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = SourceExpressionConverter.ConvertToken(pageMarker);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobsFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListBlobsFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListBlobDirectoriesOutput> ListBlobDirectories([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobNamePrefix = null)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobNamePrefix, nameof(blobNamePrefix), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                if (blobNamePrefix != null)
                {
                    serviceProviderParameters["blobNamePrefix"] = SourceExpressionConverter.ConvertToken(blobNamePrefix);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobDirectories", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListBlobDirectoriesOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ListContainersOutput> ListContainers([WorkflowExpression] Func<string> pageMarker = null)
        {
            SourceExpression.Validate(pageMarker, nameof(pageMarker), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = SourceExpressionConverter.ConvertToken(pageMarker);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listContainers", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListContainersOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobSASUriOutput> GetBlobSASUri([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<string> groupPolicyIdentifier = null, [WorkflowExpression] Func<GetBlobSASUriInputPermissionsType> permissions = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> expiryTime = null, [WorkflowExpression] Func<GetBlobSASUriInputSharedAccessProtocolType> sharedAccessProtocol = null, [WorkflowExpression] Func<string> ipAddressRange = null)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            SourceExpression.Validate(groupPolicyIdentifier, nameof(groupPolicyIdentifier), required: false);
            SourceExpression.Validate(permissions, nameof(permissions), required: false);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(expiryTime, nameof(expiryTime), required: false);
            SourceExpression.Validate(sharedAccessProtocol, nameof(sharedAccessProtocol), required: false);
            SourceExpression.Validate(ipAddressRange, nameof(ipAddressRange), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                if (groupPolicyIdentifier != null)
                {
                    serviceProviderParameters["groupPolicyIdentifier"] = SourceExpressionConverter.ConvertToken(groupPolicyIdentifier);
                }

                if (permissions != null)
                {
                    serviceProviderParameters["permissions"] = SourceExpressionConverter.ConvertToken(permissions);
                }

                if (startTime != null)
                {
                    serviceProviderParameters["startTime"] = SourceExpressionConverter.ConvertToken(startTime);
                }

                if (expiryTime != null)
                {
                    serviceProviderParameters["expiryTime"] = SourceExpressionConverter.ConvertToken(expiryTime);
                }

                if (sharedAccessProtocol != null)
                {
                    serviceProviderParameters["sharedAccessProtocol"] = SourceExpressionConverter.ConvertToken(sharedAccessProtocol);
                }

                if (ipAddressRange != null)
                {
                    serviceProviderParameters["ipAddressRange"] = SourceExpressionConverter.ConvertToken(ipAddressRange);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobSASUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetBlobSASUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobSASUriFromUriOutput> GetBlobSASUriFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<string> groupPolicyIdentifier = null, [WorkflowExpression] Func<GetBlobSASUriFromUriInputPermissionsType> permissions = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> expiryTime = null, [WorkflowExpression] Func<GetBlobSASUriFromUriInputSharedAccessProtocolType> sharedAccessProtocol = null, [WorkflowExpression] Func<string> ipAddressRange = null)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            SourceExpression.Validate(groupPolicyIdentifier, nameof(groupPolicyIdentifier), required: false);
            SourceExpression.Validate(permissions, nameof(permissions), required: false);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(expiryTime, nameof(expiryTime), required: false);
            SourceExpression.Validate(sharedAccessProtocol, nameof(sharedAccessProtocol), required: false);
            SourceExpression.Validate(ipAddressRange, nameof(ipAddressRange), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                if (groupPolicyIdentifier != null)
                {
                    serviceProviderParameters["groupPolicyIdentifier"] = SourceExpressionConverter.ConvertToken(groupPolicyIdentifier);
                }

                if (permissions != null)
                {
                    serviceProviderParameters["permissions"] = SourceExpressionConverter.ConvertToken(permissions);
                }

                if (startTime != null)
                {
                    serviceProviderParameters["startTime"] = SourceExpressionConverter.ConvertToken(startTime);
                }

                if (expiryTime != null)
                {
                    serviceProviderParameters["expiryTime"] = SourceExpressionConverter.ConvertToken(expiryTime);
                }

                if (sharedAccessProtocol != null)
                {
                    serviceProviderParameters["sharedAccessProtocol"] = SourceExpressionConverter.ConvertToken(sharedAccessProtocol);
                }

                if (ipAddressRange != null)
                {
                    serviceProviderParameters["ipAddressRange"] = SourceExpressionConverter.ConvertToken(ipAddressRange);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobSASUriFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetBlobSASUriFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataOutput> GetBlobMetadata([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetBlobMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataFromUriOutput> GetBlobMetadataFromUri([WorkflowExpression] Func<string> blobUri)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadataFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetBlobMetadataFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetContainerMetadataOutput> GetContainerMetadata([WorkflowExpression] Func<string> containerName)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getContainerMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetContainerMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobOutput> CopyBlob([WorkflowExpression] Func<string> sourceContainerName, [WorkflowExpression] Func<string> sourceBlobName, [WorkflowExpression] Func<string> destinationContainerName, [WorkflowExpression] Func<string> destinationBlobName, [WorkflowExpression] Func<bool> overrideIfExists = null)
        {
            SourceExpression.Validate(sourceContainerName, nameof(sourceContainerName), required: true);
            SourceExpression.Validate(sourceBlobName, nameof(sourceBlobName), required: true);
            SourceExpression.Validate(destinationContainerName, nameof(destinationContainerName), required: true);
            SourceExpression.Validate(destinationBlobName, nameof(destinationBlobName), required: true);
            SourceExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceContainerName"] = SourceExpressionConverter.ConvertToken(sourceContainerName);
                serviceProviderParameters["sourceBlobName"] = SourceExpressionConverter.ConvertToken(sourceBlobName);
                serviceProviderParameters["destinationContainerName"] = SourceExpressionConverter.ConvertToken(destinationContainerName);
                serviceProviderParameters["destinationBlobName"] = SourceExpressionConverter.ConvertToken(destinationBlobName);
                if (overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = SourceExpressionConverter.ConvertToken(overrideIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "copyBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CopyBlobOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobFromUriOutput> CopyBlobFromUri([WorkflowExpression] Func<string> sourceBlobUri, [WorkflowExpression] Func<string> destinationBlobUri, [WorkflowExpression] Func<bool> overrideIfExists = null)
        {
            SourceExpression.Validate(sourceBlobUri, nameof(sourceBlobUri), required: true);
            SourceExpression.Validate(destinationBlobUri, nameof(destinationBlobUri), required: true);
            SourceExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceBlobUri"] = SourceExpressionConverter.ConvertToken(sourceBlobUri);
                serviceProviderParameters["destinationBlobUri"] = SourceExpressionConverter.ConvertToken(destinationBlobUri);
                if (overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = SourceExpressionConverter.ConvertToken(overrideIfExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "copyBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CopyBlobFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetAccessPoliciesOutputItem[]> GetAccessPolicies([WorkflowExpression] Func<string> containerName)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getAccessPolicies", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetAccessPoliciesOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTier([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<SetBlobTierInputBlobAccessTierType> blobAccessTier)
        {
            SourceExpression.Validate(containerName, nameof(containerName), required: true);
            SourceExpression.Validate(blobName, nameof(blobName), required: true);
            SourceExpression.Validate(blobAccessTier, nameof(blobAccessTier), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = SourceExpressionConverter.ConvertToken(containerName);
                serviceProviderParameters["blobName"] = SourceExpressionConverter.ConvertToken(blobName);
                serviceProviderParameters["blobAccessTier"] = SourceExpressionConverter.ConvertToken(blobAccessTier);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTier", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTierFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<SetBlobTierFromUriInputBlobAccessTierType> blobAccessTier)
        {
            SourceExpression.Validate(blobUri, nameof(blobUri), required: true);
            SourceExpression.Validate(blobAccessTier, nameof(blobAccessTier), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = SourceExpressionConverter.ConvertToken(blobUri);
                serviceProviderParameters["blobAccessTier"] = SourceExpressionConverter.ConvertToken(blobAccessTier);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTierFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromBlobPathOutput> ExtractArchiveFromBlobPath([WorkflowExpression] Func<string> sourceContainerName, [WorkflowExpression] Func<string> sourceBlobName, [WorkflowExpression] Func<string> destinationContainerName, [WorkflowExpression] Func<string> destinationFolderPath, [WorkflowExpression] Func<ExtractArchiveFromBlobPathInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            SourceExpression.Validate(sourceContainerName, nameof(sourceContainerName), required: true);
            SourceExpression.Validate(sourceBlobName, nameof(sourceBlobName), required: true);
            SourceExpression.Validate(destinationContainerName, nameof(destinationContainerName), required: true);
            SourceExpression.Validate(destinationFolderPath, nameof(destinationFolderPath), required: true);
            SourceExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceContainerName"] = SourceExpressionConverter.ConvertToken(sourceContainerName);
                serviceProviderParameters["sourceBlobName"] = SourceExpressionConverter.ConvertToken(sourceBlobName);
                serviceProviderParameters["destinationContainerName"] = SourceExpressionConverter.ConvertToken(destinationContainerName);
                serviceProviderParameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(destinationFolderPath);
                if (overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = SourceExpressionConverter.ConvertToken(overwriteExistingFilesBehaviour);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromBlobPath", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveFromBlobPathOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromUriOutput> ExtractArchiveFromUri([WorkflowExpression] Func<string> sourceBlobUri, [WorkflowExpression] Func<string> destinationBlobUri, [WorkflowExpression] Func<ExtractArchiveFromUriInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            SourceExpression.Validate(sourceBlobUri, nameof(sourceBlobUri), required: true);
            SourceExpression.Validate(destinationBlobUri, nameof(destinationBlobUri), required: true);
            SourceExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceBlobUri"] = SourceExpressionConverter.ConvertToken(sourceBlobUri);
                serviceProviderParameters["destinationBlobUri"] = SourceExpressionConverter.ConvertToken(destinationBlobUri);
                if (overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = SourceExpressionConverter.ConvertToken(overwriteExistingFilesBehaviour);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveFromUriOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromContentOutput> ExtractArchiveFromContent([WorkflowExpression] Func<string> destinationContainerName, [WorkflowExpression] Func<string> content = null, [WorkflowExpression] Func<string> destinationFolderPath = null, [WorkflowExpression] Func<ExtractArchiveFromContentInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            SourceExpression.Validate(destinationContainerName, nameof(destinationContainerName), required: true);
            SourceExpression.Validate(content, nameof(content), required: false);
            SourceExpression.Validate(destinationFolderPath, nameof(destinationFolderPath), required: false);
            SourceExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (content != null)
                {
                    serviceProviderParameters["content"] = SourceExpressionConverter.ConvertToken(content);
                }

                serviceProviderParameters["destinationContainerName"] = SourceExpressionConverter.ConvertToken(destinationContainerName);
                if (destinationFolderPath != null)
                {
                    serviceProviderParameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(destinationFolderPath);
                }

                if (overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = SourceExpressionConverter.ConvertToken(overwriteExistingFilesBehaviour);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExtractArchiveFromContentOutput>(BuildSourceInput);
        }
    }

    public class AzureBlobTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenABlobIsAddedOrModifiedOutput> WhenABlobIsAddedOrModified([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["path"] = SourceExpressionConverter.ConvertToken(path);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "whenABlobIsAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenABlobIsAddedOrModifiedOutput>(BuildSourceInput);
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

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
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

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
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
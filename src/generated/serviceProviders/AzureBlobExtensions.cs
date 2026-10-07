//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureBlobActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildBlobExists))]
        public IBodyWorkflowAction<BlobExistsOutput> BlobExists([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobExistsOutput> __BuildBlobExists(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            return new DeferredBodyAction<BlobExistsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "blobExists", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<BlobExistsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteBlob))]
        public IWorkflowAction DeleteBlob([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteBlob(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteBlobFromUri))]
        public IWorkflowAction DeleteBlobFromUri([WorkflowExpression] Func<string> blobUri)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteBlobFromUri(WorkflowExpression<string> blobUri)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildReadBlob))]
        public IBodyWorkflowAction<ReadBlobOutput> ReadBlob([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadBlobOutput> __BuildReadBlob(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<ReadBlobOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "readBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReadBlobOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildReadBlobFromUri))]
        public IBodyWorkflowAction<ReadBlobFromUriOutput> ReadBlobFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadBlobFromUriOutput> __BuildReadBlobFromUri(WorkflowExpression<string> blobUri, WorkflowExpression<bool> inferContentType = null)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            WorkflowExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<ReadBlobFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
                if (inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(inferContentType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "readBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReadBlobFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildUploadBlob))]
        public IBodyWorkflowAction<UploadBlobOutput> UploadBlob([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<object> content, [WorkflowExpression] Func<UploadBlobInputOverrideIfExistsType> overrideIfExists = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadBlobOutput> __BuildUploadBlob(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName, WorkflowExpression<object> content, WorkflowExpression<UploadBlobInputOverrideIfExistsType> overrideIfExists = null)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            WorkflowExpression.Validate(content, nameof(content), required: true);
            WorkflowExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<UploadBlobOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "uploadBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UploadBlobOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildUploadBlobFromUri))]
        public IBodyWorkflowAction<UploadBlobFromUriOutput> UploadBlobFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<object> content, [WorkflowExpression] Func<UploadBlobFromUriInputOverrideIfExistsType> overrideIfExists = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadBlobFromUriOutput> __BuildUploadBlobFromUri(WorkflowExpression<string> blobUri, WorkflowExpression<object> content, WorkflowExpression<UploadBlobFromUriInputOverrideIfExistsType> overrideIfExists = null)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            WorkflowExpression.Validate(content, nameof(content), required: true);
            WorkflowExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<UploadBlobFromUriOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "uploadBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UploadBlobFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildListBlobs))]
        public IBodyWorkflowAction<ListBlobsOutput> ListBlobs([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobNamePrefix = null, [WorkflowExpression] Func<string> pageMarker = null, [WorkflowExpression] Func<bool> excludeSubFolderBlobs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListBlobsOutput> __BuildListBlobs(WorkflowExpression<string> containerName, WorkflowExpression<string> blobNamePrefix = null, WorkflowExpression<string> pageMarker = null, WorkflowExpression<bool> excludeSubFolderBlobs = null)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobNamePrefix, nameof(blobNamePrefix), required: false);
            WorkflowExpression.Validate(pageMarker, nameof(pageMarker), required: false);
            WorkflowExpression.Validate(excludeSubFolderBlobs, nameof(excludeSubFolderBlobs), required: false);
            return new DeferredBodyAction<ListBlobsOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobs", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListBlobsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildListBlobsFromUri))]
        public IBodyWorkflowAction<ListBlobsFromUriOutput> ListBlobsFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<string> pageMarker = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListBlobsFromUriOutput> __BuildListBlobsFromUri(WorkflowExpression<string> blobUri, WorkflowExpression<string> pageMarker = null)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            WorkflowExpression.Validate(pageMarker, nameof(pageMarker), required: false);
            return new DeferredBodyAction<ListBlobsFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
                if (pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobsFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListBlobsFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildListBlobDirectories))]
        public IBodyWorkflowAction<ListBlobDirectoriesOutput> ListBlobDirectories([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobNamePrefix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListBlobDirectoriesOutput> __BuildListBlobDirectories(WorkflowExpression<string> containerName, WorkflowExpression<string> blobNamePrefix = null)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobNamePrefix, nameof(blobNamePrefix), required: false);
            return new DeferredBodyAction<ListBlobDirectoriesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                if (blobNamePrefix != null)
                {
                    serviceProviderParameters["blobNamePrefix"] = ExpressionConverter.ConvertO(blobNamePrefix);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listBlobDirectories", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListBlobDirectoriesOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildListContainers))]
        public IBodyWorkflowAction<ListContainersOutput> ListContainers([WorkflowExpression] Func<string> pageMarker = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListContainersOutput> __BuildListContainers(WorkflowExpression<string> pageMarker = null)
        {
            WorkflowExpression.Validate(pageMarker, nameof(pageMarker), required: false);
            return new DeferredBodyAction<ListContainersOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(pageMarker);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "listContainers", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListContainersOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildGetBlobSASUri))]
        public IBodyWorkflowAction<GetBlobSASUriOutput> GetBlobSASUri([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<string> groupPolicyIdentifier = null, [WorkflowExpression] Func<GetBlobSASUriInputPermissionsType> permissions = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> expiryTime = null, [WorkflowExpression] Func<GetBlobSASUriInputSharedAccessProtocolType> sharedAccessProtocol = null, [WorkflowExpression] Func<string> ipAddressRange = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBlobSASUriOutput> __BuildGetBlobSASUri(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName, WorkflowExpression<string> groupPolicyIdentifier = null, WorkflowExpression<GetBlobSASUriInputPermissionsType> permissions = null, WorkflowExpression<string> startTime = null, WorkflowExpression<string> expiryTime = null, WorkflowExpression<GetBlobSASUriInputSharedAccessProtocolType> sharedAccessProtocol = null, WorkflowExpression<string> ipAddressRange = null)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            WorkflowExpression.Validate(groupPolicyIdentifier, nameof(groupPolicyIdentifier), required: false);
            WorkflowExpression.Validate(permissions, nameof(permissions), required: false);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(expiryTime, nameof(expiryTime), required: false);
            WorkflowExpression.Validate(sharedAccessProtocol, nameof(sharedAccessProtocol), required: false);
            WorkflowExpression.Validate(ipAddressRange, nameof(ipAddressRange), required: false);
            return new DeferredBodyAction<GetBlobSASUriOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobSASUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetBlobSASUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildGetBlobSASUriFromUri))]
        public IBodyWorkflowAction<GetBlobSASUriFromUriOutput> GetBlobSASUriFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<string> groupPolicyIdentifier = null, [WorkflowExpression] Func<GetBlobSASUriFromUriInputPermissionsType> permissions = null, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> expiryTime = null, [WorkflowExpression] Func<GetBlobSASUriFromUriInputSharedAccessProtocolType> sharedAccessProtocol = null, [WorkflowExpression] Func<string> ipAddressRange = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBlobSASUriFromUriOutput> __BuildGetBlobSASUriFromUri(WorkflowExpression<string> blobUri, WorkflowExpression<string> groupPolicyIdentifier = null, WorkflowExpression<GetBlobSASUriFromUriInputPermissionsType> permissions = null, WorkflowExpression<string> startTime = null, WorkflowExpression<string> expiryTime = null, WorkflowExpression<GetBlobSASUriFromUriInputSharedAccessProtocolType> sharedAccessProtocol = null, WorkflowExpression<string> ipAddressRange = null)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            WorkflowExpression.Validate(groupPolicyIdentifier, nameof(groupPolicyIdentifier), required: false);
            WorkflowExpression.Validate(permissions, nameof(permissions), required: false);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(expiryTime, nameof(expiryTime), required: false);
            WorkflowExpression.Validate(sharedAccessProtocol, nameof(sharedAccessProtocol), required: false);
            WorkflowExpression.Validate(ipAddressRange, nameof(ipAddressRange), required: false);
            return new DeferredBodyAction<GetBlobSASUriFromUriOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobSASUriFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetBlobSASUriFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildGetBlobMetadata))]
        public IBodyWorkflowAction<GetBlobMetadataOutput> GetBlobMetadata([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBlobMetadataOutput> __BuildGetBlobMetadata(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            return new DeferredBodyAction<GetBlobMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetBlobMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildGetBlobMetadataFromUri))]
        public IBodyWorkflowAction<GetBlobMetadataFromUriOutput> GetBlobMetadataFromUri([WorkflowExpression] Func<string> blobUri)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBlobMetadataFromUriOutput> __BuildGetBlobMetadataFromUri(WorkflowExpression<string> blobUri)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            return new DeferredBodyAction<GetBlobMetadataFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadataFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetBlobMetadataFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildGetContainerMetadata))]
        public IBodyWorkflowAction<GetContainerMetadataOutput> GetContainerMetadata([WorkflowExpression] Func<string> containerName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContainerMetadataOutput> __BuildGetContainerMetadata(WorkflowExpression<string> containerName)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            return new DeferredBodyAction<GetContainerMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getContainerMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetContainerMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildCopyBlob))]
        public IBodyWorkflowAction<CopyBlobOutput> CopyBlob([WorkflowExpression] Func<string> sourceContainerName, [WorkflowExpression] Func<string> sourceBlobName, [WorkflowExpression] Func<string> destinationContainerName, [WorkflowExpression] Func<string> destinationBlobName, [WorkflowExpression] Func<bool> overrideIfExists = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CopyBlobOutput> __BuildCopyBlob(WorkflowExpression<string> sourceContainerName, WorkflowExpression<string> sourceBlobName, WorkflowExpression<string> destinationContainerName, WorkflowExpression<string> destinationBlobName, WorkflowExpression<bool> overrideIfExists = null)
        {
            WorkflowExpression.Validate(sourceContainerName, nameof(sourceContainerName), required: true);
            WorkflowExpression.Validate(sourceBlobName, nameof(sourceBlobName), required: true);
            WorkflowExpression.Validate(destinationContainerName, nameof(destinationContainerName), required: true);
            WorkflowExpression.Validate(destinationBlobName, nameof(destinationBlobName), required: true);
            WorkflowExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<CopyBlobOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "copyBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CopyBlobOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildCopyBlobFromUri))]
        public IBodyWorkflowAction<CopyBlobFromUriOutput> CopyBlobFromUri([WorkflowExpression] Func<string> sourceBlobUri, [WorkflowExpression] Func<string> destinationBlobUri, [WorkflowExpression] Func<bool> overrideIfExists = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CopyBlobFromUriOutput> __BuildCopyBlobFromUri(WorkflowExpression<string> sourceBlobUri, WorkflowExpression<string> destinationBlobUri, WorkflowExpression<bool> overrideIfExists = null)
        {
            WorkflowExpression.Validate(sourceBlobUri, nameof(sourceBlobUri), required: true);
            WorkflowExpression.Validate(destinationBlobUri, nameof(destinationBlobUri), required: true);
            WorkflowExpression.Validate(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<CopyBlobFromUriOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "copyBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CopyBlobFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildGetAccessPolicies))]
        public IBodyWorkflowAction<GetAccessPoliciesOutputItem[]> GetAccessPolicies([WorkflowExpression] Func<string> containerName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAccessPoliciesOutputItem[]> __BuildGetAccessPolicies(WorkflowExpression<string> containerName)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            return new DeferredBodyAction<GetAccessPoliciesOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getAccessPolicies", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetAccessPoliciesOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildSetBlobTier))]
        public IWorkflowAction SetBlobTier([WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> blobName, [WorkflowExpression] Func<SetBlobTierInputBlobAccessTierType> blobAccessTier)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetBlobTier(WorkflowExpression<string> containerName, WorkflowExpression<string> blobName, WorkflowExpression<SetBlobTierInputBlobAccessTierType> blobAccessTier)
        {
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(blobName, nameof(blobName), required: true);
            WorkflowExpression.Validate(blobAccessTier, nameof(blobAccessTier), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(blobName);
                serviceProviderParameters["blobAccessTier"] = ExpressionConverter.ConvertO(blobAccessTier);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTier", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildSetBlobTierFromUri))]
        public IWorkflowAction SetBlobTierFromUri([WorkflowExpression] Func<string> blobUri, [WorkflowExpression] Func<SetBlobTierFromUriInputBlobAccessTierType> blobAccessTier)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetBlobTierFromUri(WorkflowExpression<string> blobUri, WorkflowExpression<SetBlobTierFromUriInputBlobAccessTierType> blobAccessTier)
        {
            WorkflowExpression.Validate(blobUri, nameof(blobUri), required: true);
            WorkflowExpression.Validate(blobAccessTier, nameof(blobAccessTier), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(blobUri);
                serviceProviderParameters["blobAccessTier"] = ExpressionConverter.ConvertO(blobAccessTier);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTierFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchiveFromBlobPath))]
        public IBodyWorkflowAction<ExtractArchiveFromBlobPathOutput> ExtractArchiveFromBlobPath([WorkflowExpression] Func<string> sourceContainerName, [WorkflowExpression] Func<string> sourceBlobName, [WorkflowExpression] Func<string> destinationContainerName, [WorkflowExpression] Func<string> destinationFolderPath, [WorkflowExpression] Func<ExtractArchiveFromBlobPathInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveFromBlobPathOutput> __BuildExtractArchiveFromBlobPath(WorkflowExpression<string> sourceContainerName, WorkflowExpression<string> sourceBlobName, WorkflowExpression<string> destinationContainerName, WorkflowExpression<string> destinationFolderPath, WorkflowExpression<ExtractArchiveFromBlobPathInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            WorkflowExpression.Validate(sourceContainerName, nameof(sourceContainerName), required: true);
            WorkflowExpression.Validate(sourceBlobName, nameof(sourceBlobName), required: true);
            WorkflowExpression.Validate(destinationContainerName, nameof(destinationContainerName), required: true);
            WorkflowExpression.Validate(destinationFolderPath, nameof(destinationFolderPath), required: true);
            WorkflowExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            return new DeferredBodyAction<ExtractArchiveFromBlobPathOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromBlobPath", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveFromBlobPathOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchiveFromUri))]
        public IBodyWorkflowAction<ExtractArchiveFromUriOutput> ExtractArchiveFromUri([WorkflowExpression] Func<string> sourceBlobUri, [WorkflowExpression] Func<string> destinationBlobUri, [WorkflowExpression] Func<ExtractArchiveFromUriInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveFromUriOutput> __BuildExtractArchiveFromUri(WorkflowExpression<string> sourceBlobUri, WorkflowExpression<string> destinationBlobUri, WorkflowExpression<ExtractArchiveFromUriInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            WorkflowExpression.Validate(sourceBlobUri, nameof(sourceBlobUri), required: true);
            WorkflowExpression.Validate(destinationBlobUri, nameof(destinationBlobUri), required: true);
            WorkflowExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            return new DeferredBodyAction<ExtractArchiveFromUriOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [WorkflowExpressionFactory(nameof(__BuildExtractArchiveFromContent))]
        public IBodyWorkflowAction<ExtractArchiveFromContentOutput> ExtractArchiveFromContent([WorkflowExpression] Func<string> destinationContainerName, [WorkflowExpression] Func<string> content = null, [WorkflowExpression] Func<string> destinationFolderPath = null, [WorkflowExpression] Func<ExtractArchiveFromContentInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractArchiveFromContentOutput> __BuildExtractArchiveFromContent(WorkflowExpression<string> destinationContainerName, WorkflowExpression<string> content = null, WorkflowExpression<string> destinationFolderPath = null, WorkflowExpression<ExtractArchiveFromContentInputOverwriteExistingFilesBehaviourType> overwriteExistingFilesBehaviour = null)
        {
            WorkflowExpression.Validate(destinationContainerName, nameof(destinationContainerName), required: true);
            WorkflowExpression.Validate(content, nameof(content), required: false);
            WorkflowExpression.Validate(destinationFolderPath, nameof(destinationFolderPath), required: false);
            WorkflowExpression.Validate(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            return new DeferredBodyAction<ExtractArchiveFromContentOutput>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "extractArchiveFromContent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExtractArchiveFromContentOutput>(serviceProviderInput);
            });
        }
    }

    public class AzureBlobTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWhenABlobIsAddedOrModified))]
        public IBodyWorkflowTrigger<WhenABlobIsAddedOrModifiedOutput> WhenABlobIsAddedOrModified([WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenABlobIsAddedOrModifiedOutput> __BuildWhenABlobIsAddedOrModified(WorkflowExpression<string> path)
        {
            WorkflowExpression.Validate(path, nameof(path), required: true);
            return new DeferredBodyTrigger<WhenABlobIsAddedOrModifiedOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["path"] = ExpressionConverter.ConvertO(path);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "whenABlobIsAddedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenABlobIsAddedOrModifiedOutput>(serviceProviderInput);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetBlobTierInputBlobAccessTierType
    {
        Hot,
        Cool,
        Archive
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
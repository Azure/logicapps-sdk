//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureBlobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<BlobExistsOutput> BlobExists(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            return new DeferredBodyAction<BlobExistsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "blobExists", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<BlobExistsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction DeleteBlobFromUri(Expression<Func<string>> blobUri)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "deleteBlobFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ReadBlobOutput> ReadBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<ReadBlobOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                if (__workflow_inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(__workflow_inferContentType);
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
        public IBodyWorkflowAction<ReadBlobFromUriOutput> ReadBlobFromUri(Expression<Func<string>> blobUri, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<ReadBlobFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                if (__workflow_inferContentType != null)
                {
                    serviceProviderParameters["inferContentType"] = ExpressionConverter.ConvertO(__workflow_inferContentType);
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
        public IBodyWorkflowAction<UploadBlobOutput> UploadBlob(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<object>> content, Expression<Func<UploadBlobInputOverrideIfExistsType>> overrideIfExists = null)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            var __workflow_overrideIfExists = WorkflowExpression.Compile(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<UploadBlobOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                serviceProviderParameters["content"] = ExpressionConverter.ConvertO(__workflow_content);
                if (__workflow_overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(__workflow_overrideIfExists);
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
        public IBodyWorkflowAction<UploadBlobFromUriOutput> UploadBlobFromUri(Expression<Func<string>> blobUri, Expression<Func<object>> content, Expression<Func<UploadBlobFromUriInputOverrideIfExistsType>> overrideIfExists = null)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            var __workflow_overrideIfExists = WorkflowExpression.Compile(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<UploadBlobFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                serviceProviderParameters["content"] = ExpressionConverter.ConvertO(__workflow_content);
                if (__workflow_overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(__workflow_overrideIfExists);
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
        public IBodyWorkflowAction<ListBlobsOutput> ListBlobs(Expression<Func<string>> containerName, Expression<Func<string>> blobNamePrefix = null, Expression<Func<string>> pageMarker = null, Expression<Func<bool>> excludeSubFolderBlobs = null)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobNamePrefix = WorkflowExpression.Compile(blobNamePrefix, nameof(blobNamePrefix), required: false);
            var __workflow_pageMarker = WorkflowExpression.Compile(pageMarker, nameof(pageMarker), required: false);
            var __workflow_excludeSubFolderBlobs = WorkflowExpression.Compile(excludeSubFolderBlobs, nameof(excludeSubFolderBlobs), required: false);
            return new DeferredBodyAction<ListBlobsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                if (__workflow_blobNamePrefix != null)
                {
                    serviceProviderParameters["blobNamePrefix"] = ExpressionConverter.ConvertO(__workflow_blobNamePrefix);
                }

                if (__workflow_pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(__workflow_pageMarker);
                }

                if (__workflow_excludeSubFolderBlobs != null)
                {
                    serviceProviderParameters["excludeSubFolderBlobs"] = ExpressionConverter.ConvertO(__workflow_excludeSubFolderBlobs);
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
        public IBodyWorkflowAction<ListBlobsFromUriOutput> ListBlobsFromUri(Expression<Func<string>> blobUri, Expression<Func<string>> pageMarker = null)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            var __workflow_pageMarker = WorkflowExpression.Compile(pageMarker, nameof(pageMarker), required: false);
            return new DeferredBodyAction<ListBlobsFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                if (__workflow_pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(__workflow_pageMarker);
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
        public IBodyWorkflowAction<ListBlobDirectoriesOutput> ListBlobDirectories(Expression<Func<string>> containerName, Expression<Func<string>> blobNamePrefix = null)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobNamePrefix = WorkflowExpression.Compile(blobNamePrefix, nameof(blobNamePrefix), required: false);
            return new DeferredBodyAction<ListBlobDirectoriesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                if (__workflow_blobNamePrefix != null)
                {
                    serviceProviderParameters["blobNamePrefix"] = ExpressionConverter.ConvertO(__workflow_blobNamePrefix);
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
        public IBodyWorkflowAction<ListContainersOutput> ListContainers(Expression<Func<string>> pageMarker = null)
        {
            var __workflow_pageMarker = WorkflowExpression.Compile(pageMarker, nameof(pageMarker), required: false);
            return new DeferredBodyAction<ListContainersOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_pageMarker != null)
                {
                    serviceProviderParameters["pageMarker"] = ExpressionConverter.ConvertO(__workflow_pageMarker);
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
        public IBodyWorkflowAction<GetBlobSASUriOutput> GetBlobSASUri(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<string>> groupPolicyIdentifier = null, Expression<Func<GetBlobSASUriInputPermissionsType>> permissions = null, Expression<Func<string>> startTime = null, Expression<Func<string>> expiryTime = null, Expression<Func<GetBlobSASUriInputSharedAccessProtocolType>> sharedAccessProtocol = null, Expression<Func<string>> ipAddressRange = null)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            var __workflow_groupPolicyIdentifier = WorkflowExpression.Compile(groupPolicyIdentifier, nameof(groupPolicyIdentifier), required: false);
            var __workflow_permissions = WorkflowExpression.Compile(permissions, nameof(permissions), required: false);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_expiryTime = WorkflowExpression.Compile(expiryTime, nameof(expiryTime), required: false);
            var __workflow_sharedAccessProtocol = WorkflowExpression.Compile(sharedAccessProtocol, nameof(sharedAccessProtocol), required: false);
            var __workflow_ipAddressRange = WorkflowExpression.Compile(ipAddressRange, nameof(ipAddressRange), required: false);
            return new DeferredBodyAction<GetBlobSASUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                if (__workflow_groupPolicyIdentifier != null)
                {
                    serviceProviderParameters["groupPolicyIdentifier"] = ExpressionConverter.ConvertO(__workflow_groupPolicyIdentifier);
                }

                if (__workflow_permissions != null)
                {
                    serviceProviderParameters["permissions"] = ExpressionConverter.ConvertO(__workflow_permissions);
                }

                if (__workflow_startTime != null)
                {
                    serviceProviderParameters["startTime"] = ExpressionConverter.ConvertO(__workflow_startTime);
                }

                if (__workflow_expiryTime != null)
                {
                    serviceProviderParameters["expiryTime"] = ExpressionConverter.ConvertO(__workflow_expiryTime);
                }

                if (__workflow_sharedAccessProtocol != null)
                {
                    serviceProviderParameters["sharedAccessProtocol"] = ExpressionConverter.ConvertO(__workflow_sharedAccessProtocol);
                }

                if (__workflow_ipAddressRange != null)
                {
                    serviceProviderParameters["ipAddressRange"] = ExpressionConverter.ConvertO(__workflow_ipAddressRange);
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
        public IBodyWorkflowAction<GetBlobSASUriFromUriOutput> GetBlobSASUriFromUri(Expression<Func<string>> blobUri, Expression<Func<string>> groupPolicyIdentifier = null, Expression<Func<GetBlobSASUriFromUriInputPermissionsType>> permissions = null, Expression<Func<string>> startTime = null, Expression<Func<string>> expiryTime = null, Expression<Func<GetBlobSASUriFromUriInputSharedAccessProtocolType>> sharedAccessProtocol = null, Expression<Func<string>> ipAddressRange = null)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            var __workflow_groupPolicyIdentifier = WorkflowExpression.Compile(groupPolicyIdentifier, nameof(groupPolicyIdentifier), required: false);
            var __workflow_permissions = WorkflowExpression.Compile(permissions, nameof(permissions), required: false);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_expiryTime = WorkflowExpression.Compile(expiryTime, nameof(expiryTime), required: false);
            var __workflow_sharedAccessProtocol = WorkflowExpression.Compile(sharedAccessProtocol, nameof(sharedAccessProtocol), required: false);
            var __workflow_ipAddressRange = WorkflowExpression.Compile(ipAddressRange, nameof(ipAddressRange), required: false);
            return new DeferredBodyAction<GetBlobSASUriFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                if (__workflow_groupPolicyIdentifier != null)
                {
                    serviceProviderParameters["groupPolicyIdentifier"] = ExpressionConverter.ConvertO(__workflow_groupPolicyIdentifier);
                }

                if (__workflow_permissions != null)
                {
                    serviceProviderParameters["permissions"] = ExpressionConverter.ConvertO(__workflow_permissions);
                }

                if (__workflow_startTime != null)
                {
                    serviceProviderParameters["startTime"] = ExpressionConverter.ConvertO(__workflow_startTime);
                }

                if (__workflow_expiryTime != null)
                {
                    serviceProviderParameters["expiryTime"] = ExpressionConverter.ConvertO(__workflow_expiryTime);
                }

                if (__workflow_sharedAccessProtocol != null)
                {
                    serviceProviderParameters["sharedAccessProtocol"] = ExpressionConverter.ConvertO(__workflow_sharedAccessProtocol);
                }

                if (__workflow_ipAddressRange != null)
                {
                    serviceProviderParameters["ipAddressRange"] = ExpressionConverter.ConvertO(__workflow_ipAddressRange);
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
        public IBodyWorkflowAction<GetBlobMetadataOutput> GetBlobMetadata(Expression<Func<string>> containerName, Expression<Func<string>> blobName)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            return new DeferredBodyAction<GetBlobMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetBlobMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetBlobMetadataFromUriOutput> GetBlobMetadataFromUri(Expression<Func<string>> blobUri)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            return new DeferredBodyAction<GetBlobMetadataFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getBlobMetadataFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetBlobMetadataFromUriOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<GetContainerMetadataOutput> GetContainerMetadata(Expression<Func<string>> containerName)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            return new DeferredBodyAction<GetContainerMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getContainerMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetContainerMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<CopyBlobOutput> CopyBlob(Expression<Func<string>> sourceContainerName, Expression<Func<string>> sourceBlobName, Expression<Func<string>> destinationContainerName, Expression<Func<string>> destinationBlobName, Expression<Func<bool>> overrideIfExists = null)
        {
            var __workflow_sourceContainerName = WorkflowExpression.Compile(sourceContainerName, nameof(sourceContainerName), required: true);
            var __workflow_sourceBlobName = WorkflowExpression.Compile(sourceBlobName, nameof(sourceBlobName), required: true);
            var __workflow_destinationContainerName = WorkflowExpression.Compile(destinationContainerName, nameof(destinationContainerName), required: true);
            var __workflow_destinationBlobName = WorkflowExpression.Compile(destinationBlobName, nameof(destinationBlobName), required: true);
            var __workflow_overrideIfExists = WorkflowExpression.Compile(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<CopyBlobOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceContainerName"] = ExpressionConverter.ConvertO(__workflow_sourceContainerName);
                serviceProviderParameters["sourceBlobName"] = ExpressionConverter.ConvertO(__workflow_sourceBlobName);
                serviceProviderParameters["destinationContainerName"] = ExpressionConverter.ConvertO(__workflow_destinationContainerName);
                serviceProviderParameters["destinationBlobName"] = ExpressionConverter.ConvertO(__workflow_destinationBlobName);
                if (__workflow_overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(__workflow_overrideIfExists);
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
        public IBodyWorkflowAction<CopyBlobFromUriOutput> CopyBlobFromUri(Expression<Func<string>> sourceBlobUri, Expression<Func<string>> destinationBlobUri, Expression<Func<bool>> overrideIfExists = null)
        {
            var __workflow_sourceBlobUri = WorkflowExpression.Compile(sourceBlobUri, nameof(sourceBlobUri), required: true);
            var __workflow_destinationBlobUri = WorkflowExpression.Compile(destinationBlobUri, nameof(destinationBlobUri), required: true);
            var __workflow_overrideIfExists = WorkflowExpression.Compile(overrideIfExists, nameof(overrideIfExists), required: false);
            return new DeferredBodyAction<CopyBlobFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceBlobUri"] = ExpressionConverter.ConvertO(__workflow_sourceBlobUri);
                serviceProviderParameters["destinationBlobUri"] = ExpressionConverter.ConvertO(__workflow_destinationBlobUri);
                if (__workflow_overrideIfExists != null)
                {
                    serviceProviderParameters["overrideIfExists"] = ExpressionConverter.ConvertO(__workflow_overrideIfExists);
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
        public IBodyWorkflowAction<GetAccessPoliciesOutputItem[]> GetAccessPolicies(Expression<Func<string>> containerName)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            return new DeferredBodyAction<GetAccessPoliciesOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "getAccessPolicies", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetAccessPoliciesOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTier(Expression<Func<string>> containerName, Expression<Func<string>> blobName, Expression<Func<SetBlobTierInputBlobAccessTierType>> blobAccessTier)
        {
            var __workflow_containerName = WorkflowExpression.Compile(containerName, nameof(containerName), required: true);
            var __workflow_blobName = WorkflowExpression.Compile(blobName, nameof(blobName), required: true);
            var __workflow_blobAccessTier = WorkflowExpression.Compile(blobAccessTier, nameof(blobAccessTier), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["containerName"] = ExpressionConverter.ConvertO(__workflow_containerName);
                serviceProviderParameters["blobName"] = ExpressionConverter.ConvertO(__workflow_blobName);
                serviceProviderParameters["blobAccessTier"] = ExpressionConverter.ConvertO(__workflow_blobAccessTier);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTier", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IWorkflowAction SetBlobTierFromUri(Expression<Func<string>> blobUri, Expression<Func<SetBlobTierFromUriInputBlobAccessTierType>> blobAccessTier)
        {
            var __workflow_blobUri = WorkflowExpression.Compile(blobUri, nameof(blobUri), required: true);
            var __workflow_blobAccessTier = WorkflowExpression.Compile(blobAccessTier, nameof(blobAccessTier), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["blobUri"] = ExpressionConverter.ConvertO(__workflow_blobUri);
                serviceProviderParameters["blobAccessTier"] = ExpressionConverter.ConvertO(__workflow_blobAccessTier);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureBlob", operationId: "setBlobTierFromUri", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureBlob")]
        public IBodyWorkflowAction<ExtractArchiveFromBlobPathOutput> ExtractArchiveFromBlobPath(Expression<Func<string>> sourceContainerName, Expression<Func<string>> sourceBlobName, Expression<Func<string>> destinationContainerName, Expression<Func<string>> destinationFolderPath, Expression<Func<ExtractArchiveFromBlobPathInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var __workflow_sourceContainerName = WorkflowExpression.Compile(sourceContainerName, nameof(sourceContainerName), required: true);
            var __workflow_sourceBlobName = WorkflowExpression.Compile(sourceBlobName, nameof(sourceBlobName), required: true);
            var __workflow_destinationContainerName = WorkflowExpression.Compile(destinationContainerName, nameof(destinationContainerName), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: true);
            var __workflow_overwriteExistingFilesBehaviour = WorkflowExpression.Compile(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            return new DeferredBodyAction<ExtractArchiveFromBlobPathOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceContainerName"] = ExpressionConverter.ConvertO(__workflow_sourceContainerName);
                serviceProviderParameters["sourceBlobName"] = ExpressionConverter.ConvertO(__workflow_sourceBlobName);
                serviceProviderParameters["destinationContainerName"] = ExpressionConverter.ConvertO(__workflow_destinationContainerName);
                serviceProviderParameters["destinationFolderPath"] = ExpressionConverter.ConvertO(__workflow_destinationFolderPath);
                if (__workflow_overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(__workflow_overwriteExistingFilesBehaviour);
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
        public IBodyWorkflowAction<ExtractArchiveFromUriOutput> ExtractArchiveFromUri(Expression<Func<string>> sourceBlobUri, Expression<Func<string>> destinationBlobUri, Expression<Func<ExtractArchiveFromUriInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var __workflow_sourceBlobUri = WorkflowExpression.Compile(sourceBlobUri, nameof(sourceBlobUri), required: true);
            var __workflow_destinationBlobUri = WorkflowExpression.Compile(destinationBlobUri, nameof(destinationBlobUri), required: true);
            var __workflow_overwriteExistingFilesBehaviour = WorkflowExpression.Compile(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            return new DeferredBodyAction<ExtractArchiveFromUriOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sourceBlobUri"] = ExpressionConverter.ConvertO(__workflow_sourceBlobUri);
                serviceProviderParameters["destinationBlobUri"] = ExpressionConverter.ConvertO(__workflow_destinationBlobUri);
                if (__workflow_overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(__workflow_overwriteExistingFilesBehaviour);
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
        public IBodyWorkflowAction<ExtractArchiveFromContentOutput> ExtractArchiveFromContent(Expression<Func<string>> destinationContainerName, Expression<Func<string>> content = null, Expression<Func<string>> destinationFolderPath = null, Expression<Func<ExtractArchiveFromContentInputOverwriteExistingFilesBehaviourType>> overwriteExistingFilesBehaviour = null)
        {
            var __workflow_destinationContainerName = WorkflowExpression.Compile(destinationContainerName, nameof(destinationContainerName), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_overwriteExistingFilesBehaviour = WorkflowExpression.Compile(overwriteExistingFilesBehaviour, nameof(overwriteExistingFilesBehaviour), required: false);
            return new DeferredBodyAction<ExtractArchiveFromContentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_content != null)
                {
                    serviceProviderParameters["content"] = ExpressionConverter.ConvertO(__workflow_content);
                }

                serviceProviderParameters["destinationContainerName"] = ExpressionConverter.ConvertO(__workflow_destinationContainerName);
                if (__workflow_destinationFolderPath != null)
                {
                    serviceProviderParameters["destinationFolderPath"] = ExpressionConverter.ConvertO(__workflow_destinationFolderPath);
                }

                if (__workflow_overwriteExistingFilesBehaviour != null)
                {
                    serviceProviderParameters["overwriteExistingFilesBehaviour"] = ExpressionConverter.ConvertO(__workflow_overwriteExistingFilesBehaviour);
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
        public IBodyWorkflowTrigger<WhenABlobIsAddedOrModifiedOutput> WhenABlobIsAddedOrModified(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyTrigger<WhenABlobIsAddedOrModifiedOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["path"] = ExpressionConverter.ConvertO(__workflow_path);
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

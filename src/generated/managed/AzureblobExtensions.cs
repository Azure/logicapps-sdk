//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureblob
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureblobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildCopyFile))]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCopyFile(WorkflowValue<string> dataset, WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/copyFile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBlockBlob))]
        public IWorkflowAction CreateBlockBlob([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateBlockBlob(WorkflowValue<string> storageAccountName, WorkflowValue<string> folderPath, WorkflowValue<string> name, WorkflowValue<string> body = null, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/codeless/datasets/{0}/CreateBlockBlob", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildCreateFile(WorkflowValue<string> dataset, WorkflowValue<string> folderPath, WorkflowValue<string> name, WorkflowValue<string> body = null, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildCreateShareLinkByPath))]
        public IBodyWorkflowAction<SharedAccessSignature> CreateShareLinkByPath([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<string> policygroupPolicyIdentifier = null, [WorkflowExpression] Func<policypermissionsInput> policypermissions = null, [WorkflowExpression] Func<string> policystartTime = null, [WorkflowExpression] Func<string> policyexpiryTime = null, [WorkflowExpression] Func<policysharedAccessProtocolInput> policysharedAccessProtocol = null, [WorkflowExpression] Func<string> policyiPAddressOrIPAddressRange = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharedAccessSignature> __BuildCreateShareLinkByPath(WorkflowValue<string> storageAccountName, WorkflowValue<string> path, WorkflowValue<string> policygroupPolicyIdentifier = null, WorkflowValue<policypermissionsInput> policypermissions = null, WorkflowValue<string> policystartTime = null, WorkflowValue<string> policyexpiryTime = null, WorkflowValue<policysharedAccessProtocolInput> policysharedAccessProtocol = null, WorkflowValue<string> policyiPAddressOrIPAddressRange = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(policygroupPolicyIdentifier, nameof(policygroupPolicyIdentifier), required: false);
            WorkflowValue.Validate(policypermissions, nameof(policypermissions), required: false);
            WorkflowValue.Validate(policystartTime, nameof(policystartTime), required: false);
            WorkflowValue.Validate(policyexpiryTime, nameof(policyexpiryTime), required: false);
            WorkflowValue.Validate(policysharedAccessProtocol, nameof(policysharedAccessProtocol), required: false);
            WorkflowValue.Validate(policyiPAddressOrIPAddressRange, nameof(policyiPAddressOrIPAddressRange), required: false);
            return new DeferredBodyAction<SharedAccessSignature>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/CreateSharedLinkByPath", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                var policy = new JObject();
                var policypropCount = 0;
                if (policygroupPolicyIdentifier != null)
                {
                    policy["GroupPolicyIdentifier"] = ExpressionConverter.ConvertO(policygroupPolicyIdentifier);
                    policypropCount++;
                }

                if (policypermissions != null)
                {
                    if (policypermissions != null)
                    {
                        policy["Permissions"] = ExpressionConverter.ConvertO(policypermissions);
                        policypropCount++;
                    }

                    policypropCount++;
                }
                else
                {
                    policy["Permissions"] = "Read";
                    policypropCount++;
                }

                if (policystartTime != null)
                {
                    policy["StartTime"] = ExpressionConverter.ConvertO(policystartTime);
                    policypropCount++;
                }

                if (policyexpiryTime != null)
                {
                    policy["ExpiryTime"] = ExpressionConverter.ConvertO(policyexpiryTime);
                    policypropCount++;
                }

                if (policysharedAccessProtocol != null)
                {
                    policy["AccessProtocol"] = ExpressionConverter.ConvertO(policysharedAccessProtocol);
                    policypropCount++;
                }

                if (policyiPAddressOrIPAddressRange != null)
                {
                    policy["IpAddressOrRange"] = ExpressionConverter.ConvertO(policyiPAddressOrIPAddressRange);
                    policypropCount++;
                }

                if (policypropCount > 0)
                {
                    callPayload.Body = policy;
                }

                return new ApiConnectionAction<SharedAccessSignature>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFile(WorkflowValue<string> dataset, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFolder))]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata[]> __BuildExtractFolder(WorkflowValue<string> dataset, WorkflowValue<string> source, WorkflowValue<string> destination, WorkflowValue<bool> overwrite = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/extractFolderV2", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildGetAccessPolicies))]
        public IBodyWorkflowAction<SharedAccessSignatureBlobPolicy[]> GetAccessPolicies([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SharedAccessSignatureBlobPolicy[]> __BuildGetAccessPolicies(WorkflowValue<string> storageAccountName, WorkflowValue<string> path)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<SharedAccessSignatureBlobPolicy[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/policies", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                return new ApiConnectionAction<SharedAccessSignatureBlobPolicy[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContent(WorkflowValue<string> dataset, WorkflowValue<string> id, WorkflowValue<bool> inferContentType = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContentByPath))]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContentByPath(WorkflowValue<string> dataset, WorkflowValue<string> path, WorkflowValue<bool> inferContentType = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(inferContentType, nameof(inferContentType), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileContentByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadata))]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadata([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> __BuildGetFileMetadata(WorkflowValue<string> dataset, WorkflowValue<string> id, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<DataWithSensitivityLabelInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileMetadataByPath))]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadataByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> __BuildGetFileMetadataByPath(WorkflowValue<string> dataset, WorkflowValue<string> path, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<DataWithSensitivityLabelInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildListFolder))]
        public IBodyWorkflowAction<ListOfBlobsWithSensitivityLabels> ListFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> nextPageMarker = null, [WorkflowExpression] Func<bool> useFlatListing = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOfBlobsWithSensitivityLabels> __BuildListFolder(WorkflowValue<string> dataset, WorkflowValue<string> id, WorkflowValue<string> nextPageMarker = null, WorkflowValue<bool> useFlatListing = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(nextPageMarker, nameof(nextPageMarker), required: false);
            WorkflowValue.Validate(useFlatListing, nameof(useFlatListing), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<ListOfBlobsWithSensitivityLabels>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nextPageMarker"] = Convert.ToString("");
                if (nextPageMarker != null)
                    callPayload.Queries["nextPageMarker"] = ExpressionConverter.Convert(nextPageMarker);
                callPayload.Queries["useFlatListing"] = Convert.ToString(false);
                if (useFlatListing != null)
                    callPayload.Queries["useFlatListing"] = ExpressionConverter.Convert(useFlatListing);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<ListOfBlobsWithSensitivityLabels>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildListRootFolder))]
        public IBodyWorkflowAction<BlobMetadataPage> ListRootFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> nextPageMarker = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadataPage> __BuildListRootFolder(WorkflowValue<string> dataset, WorkflowValue<string> nextPageMarker = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(nextPageMarker, nameof(nextPageMarker), required: false);
            return new DeferredBodyAction<BlobMetadataPage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nextPageMarker"] = Convert.ToString("");
                if (nextPageMarker != null)
                    callPayload.Queries["nextPageMarker"] = ExpressionConverter.Convert(nextPageMarker);
                callPayload.Queries["useFlatListing"] = Convert.ToString(false);
                return new ApiConnectionAction<BlobMetadataPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildSetBlobTierByPath))]
        public IWorkflowAction SetBlobTierByPath([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<newTierInput> newTier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetBlobTierByPath(WorkflowValue<string> storageAccountName, WorkflowValue<string> path, WorkflowValue<newTierInput> newTier)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(path, nameof(path), required: true);
            WorkflowValue.Validate(newTier, nameof(newTier), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/SetBlobTierByPath", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["newTier"] = ExpressionConverter.Convert(newTier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFile))]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlobMetadata> __BuildUpdateFile(WorkflowValue<string> dataset, WorkflowValue<string> id, WorkflowValue<string> body = null, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }
    }

    public class AzureblobTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnUpdatedFiles))]
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BlobMetadata[]> __BuildOnUpdatedFiles(WorkflowValue<string> dataset, WorkflowValue<string> folderId, WorkflowValue<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/triggers/batch/onupdatedfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
                callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class BlobMetadata
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public class SharedAccessSignature
    {
        public string WebUrl { get; set; }
    }

    public enum policypermissionsInput
    {
        Read,
        Write,
        Add,
        Create,
        Delete,
        List,
        [EnumMember(Value = "Read,Write")]
        ReadWrite,
        [EnumMember(Value = "Read,Write,List")]
        ReadWriteList,
        [EnumMember(Value = "Read,Write,List,Delete")]
        ReadWriteListDelete
    }

    public enum policysharedAccessProtocolInput
    {
        HttpsOnly,
        HttpsOrHttp
    }

    public class SharedAccessSignatureBlobPolicy
    {
        public string GroupPolicyIdentifier { get; set; }
        public SharedAccessSignatureBlobPolicyPermissionsType Permissions { get; set; }
        public string StartTime { get; set; }
        public string ExpiryTime { get; set; }

        [JsonProperty("AccessProtocol")]
        public SharedAccessSignatureBlobPolicySharedAccessProtocolType SharedAccessProtocol { get; set; }

        [JsonProperty("IpAddressOrRange")]
        public string IPAddressOrIPAddressRange { get; set; }
    }

    public enum SharedAccessSignatureBlobPolicyPermissionsType
    {
        Read,
        Write,
        Add,
        Create,
        Delete,
        List,
        [EnumMember(Value = "Read,Write")]
        ReadWrite,
        [EnumMember(Value = "Read,Write,List")]
        ReadWriteList,
        [EnumMember(Value = "Read,Write,List,Delete")]
        ReadWriteListDelete
    }

    public enum SharedAccessSignatureBlobPolicySharedAccessProtocolType
    {
        HttpsOnly,
        HttpsOrHttp
    }

    public class DataWithSensitivityLabelInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    public class ListOfBlobsWithSensitivityLabels
    {
        [JsonProperty("value")]
        public DataWithSensitivityLabelInfo[] Value { get; set; }
    }

    public class BlobMetadataPage
    {
        [JsonProperty("value")]
        public BlobMetadata[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("nextPageMarker")]
        public string NextPageMarker { get; set; }
    }

    public enum newTierInput
    {
        Hot,
        Cool,
        Archive
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureblob;

    public partial class WorkflowManagedActions
    {
        public AzureblobActions Azureblob(string connectionId) => new AzureblobActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureblobTriggers Azureblob(string connectionId) => new AzureblobTriggers(connectionId);
    }
}

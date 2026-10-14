//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureblob
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzureblobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: true);
            var __workflow_destination = destination == null ? null : WorkflowExpression.Compile(destination);
            WorkflowExpression.Validate(__workflow_destination, nameof(destination), required: true);
            var __workflow_overwrite = overwrite == null ? null : WorkflowExpression.Compile(overwrite);
            WorkflowExpression.Validate(__workflow_overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/copyFile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction CreateBlockBlob(Expression<Func<string>> storageAccountName, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_folderPath = folderPath == null ? null : WorkflowExpression.Compile(folderPath);
            WorkflowExpression.Validate(__workflow_folderPath, nameof(folderPath), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/codeless/datasets/{0}/CreateBlockBlob", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile(Expression<Func<string>> dataset, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_folderPath = folderPath == null ? null : WorkflowExpression.Compile(folderPath);
            WorkflowExpression.Validate(__workflow_folderPath, nameof(folderPath), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignature> CreateShareLinkByPath(Expression<Func<string>> storageAccountName, Expression<Func<string>> path, Expression<Func<string>> policygroupPolicyIdentifier = null, Expression<Func<policypermissionsInput>> policypermissions = null, Expression<Func<string>> policystartTime = null, Expression<Func<string>> policyexpiryTime = null, Expression<Func<policysharedAccessProtocolInput>> policysharedAccessProtocol = null, Expression<Func<string>> policyiPAddressOrIPAddressRange = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: true);
            var __workflow_policygroupPolicyIdentifier = policygroupPolicyIdentifier == null ? null : WorkflowExpression.Compile(policygroupPolicyIdentifier);
            WorkflowExpression.Validate(__workflow_policygroupPolicyIdentifier, nameof(policygroupPolicyIdentifier), required: false);
            var __workflow_policypermissions = policypermissions == null ? null : WorkflowExpression.Compile(policypermissions);
            WorkflowExpression.Validate(__workflow_policypermissions, nameof(policypermissions), required: false);
            var __workflow_policystartTime = policystartTime == null ? null : WorkflowExpression.Compile(policystartTime);
            WorkflowExpression.Validate(__workflow_policystartTime, nameof(policystartTime), required: false);
            var __workflow_policyexpiryTime = policyexpiryTime == null ? null : WorkflowExpression.Compile(policyexpiryTime);
            WorkflowExpression.Validate(__workflow_policyexpiryTime, nameof(policyexpiryTime), required: false);
            var __workflow_policysharedAccessProtocol = policysharedAccessProtocol == null ? null : WorkflowExpression.Compile(policysharedAccessProtocol);
            WorkflowExpression.Validate(__workflow_policysharedAccessProtocol, nameof(policysharedAccessProtocol), required: false);
            var __workflow_policyiPAddressOrIPAddressRange = policyiPAddressOrIPAddressRange == null ? null : WorkflowExpression.Compile(policyiPAddressOrIPAddressRange);
            WorkflowExpression.Validate(__workflow_policyiPAddressOrIPAddressRange, nameof(policyiPAddressOrIPAddressRange), required: false);
            return new DeferredBodyAction<SharedAccessSignature>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/CreateSharedLinkByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                var policy = new JObject();
                var policypropCount = 0;
                if (__workflow_policygroupPolicyIdentifier != null)
                {
                    policy["GroupPolicyIdentifier"] = ExpressionConverter.ConvertO(__workflow_policygroupPolicyIdentifier);
                    policypropCount++;
                }

                if (__workflow_policypermissions != null)
                {
                    if (__workflow_policypermissions != null)
                    {
                        policy["Permissions"] = ExpressionConverter.ConvertO(__workflow_policypermissions);
                        policypropCount++;
                    }

                    policypropCount++;
                }
                else
                {
                    policy["Permissions"] = "Read";
                    policypropCount++;
                }

                if (__workflow_policystartTime != null)
                {
                    policy["StartTime"] = ExpressionConverter.ConvertO(__workflow_policystartTime);
                    policypropCount++;
                }

                if (__workflow_policyexpiryTime != null)
                {
                    policy["ExpiryTime"] = ExpressionConverter.ConvertO(__workflow_policyexpiryTime);
                    policypropCount++;
                }

                if (__workflow_policysharedAccessProtocol != null)
                {
                    policy["AccessProtocol"] = ExpressionConverter.ConvertO(__workflow_policysharedAccessProtocol);
                    policypropCount++;
                }

                if (__workflow_policyiPAddressOrIPAddressRange != null)
                {
                    policy["IpAddressOrRange"] = ExpressionConverter.ConvertO(__workflow_policyiPAddressOrIPAddressRange);
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
        public IWorkflowAction DeleteFile(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: true);
            var __workflow_destination = destination == null ? null : WorkflowExpression.Compile(destination);
            WorkflowExpression.Validate(__workflow_destination, nameof(destination), required: true);
            var __workflow_overwrite = overwrite == null ? null : WorkflowExpression.Compile(overwrite);
            WorkflowExpression.Validate(__workflow_overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/extractFolderV2", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignatureBlobPolicy[]> GetAccessPolicies(Expression<Func<string>> storageAccountName, Expression<Func<string>> path)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: true);
            return new DeferredBodyAction<SharedAccessSignatureBlobPolicy[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/policies", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<SharedAccessSignatureBlobPolicy[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_inferContentType = inferContentType == null ? null : WorkflowExpression.Compile(inferContentType);
            WorkflowExpression.Validate(__workflow_inferContentType, nameof(inferContentType), required: false);
            var __workflow_extractSensitivityLabel = extractSensitivityLabel == null ? null : WorkflowExpression.Compile(extractSensitivityLabel);
            WorkflowExpression.Validate(__workflow_extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = purviewAccountName == null ? null : WorkflowExpression.Compile(purviewAccountName);
            WorkflowExpression.Validate(__workflow_purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: true);
            var __workflow_inferContentType = inferContentType == null ? null : WorkflowExpression.Compile(inferContentType);
            WorkflowExpression.Validate(__workflow_inferContentType, nameof(inferContentType), required: false);
            var __workflow_extractSensitivityLabel = extractSensitivityLabel == null ? null : WorkflowExpression.Compile(extractSensitivityLabel);
            WorkflowExpression.Validate(__workflow_extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = purviewAccountName == null ? null : WorkflowExpression.Compile(purviewAccountName);
            WorkflowExpression.Validate(__workflow_purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileContentByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_extractSensitivityLabel = extractSensitivityLabel == null ? null : WorkflowExpression.Compile(extractSensitivityLabel);
            WorkflowExpression.Validate(__workflow_extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = purviewAccountName == null ? null : WorkflowExpression.Compile(purviewAccountName);
            WorkflowExpression.Validate(__workflow_purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<DataWithSensitivityLabelInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: true);
            var __workflow_extractSensitivityLabel = extractSensitivityLabel == null ? null : WorkflowExpression.Compile(extractSensitivityLabel);
            WorkflowExpression.Validate(__workflow_extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = purviewAccountName == null ? null : WorkflowExpression.Compile(purviewAccountName);
            WorkflowExpression.Validate(__workflow_purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<DataWithSensitivityLabelInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<ListOfBlobsWithSensitivityLabels> ListFolder(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> nextPageMarker = null, Expression<Func<bool>> useFlatListing = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_nextPageMarker = nextPageMarker == null ? null : WorkflowExpression.Compile(nextPageMarker);
            WorkflowExpression.Validate(__workflow_nextPageMarker, nameof(nextPageMarker), required: false);
            var __workflow_useFlatListing = useFlatListing == null ? null : WorkflowExpression.Compile(useFlatListing);
            WorkflowExpression.Validate(__workflow_useFlatListing, nameof(useFlatListing), required: false);
            var __workflow_extractSensitivityLabel = extractSensitivityLabel == null ? null : WorkflowExpression.Compile(extractSensitivityLabel);
            WorkflowExpression.Validate(__workflow_extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = purviewAccountName == null ? null : WorkflowExpression.Compile(purviewAccountName);
            WorkflowExpression.Validate(__workflow_purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<ListOfBlobsWithSensitivityLabels>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nextPageMarker"] = Convert.ToString("");
                if (__workflow_nextPageMarker != null)
                    callPayload.Queries["nextPageMarker"] = ExpressionConverter.Convert(__workflow_nextPageMarker);
                callPayload.Queries["useFlatListing"] = Convert.ToString(false);
                if (__workflow_useFlatListing != null)
                    callPayload.Queries["useFlatListing"] = ExpressionConverter.Convert(__workflow_useFlatListing);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                return new ApiConnectionAction<ListOfBlobsWithSensitivityLabels>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadataPage> ListRootFolder(Expression<Func<string>> dataset, Expression<Func<string>> nextPageMarker = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_nextPageMarker = nextPageMarker == null ? null : WorkflowExpression.Compile(nextPageMarker);
            WorkflowExpression.Validate(__workflow_nextPageMarker, nameof(nextPageMarker), required: false);
            return new DeferredBodyAction<BlobMetadataPage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nextPageMarker"] = Convert.ToString("");
                if (__workflow_nextPageMarker != null)
                    callPayload.Queries["nextPageMarker"] = ExpressionConverter.Convert(__workflow_nextPageMarker);
                callPayload.Queries["useFlatListing"] = Convert.ToString(false);
                return new ApiConnectionAction<BlobMetadataPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction SetBlobTierByPath(Expression<Func<string>> storageAccountName, Expression<Func<string>> path, Expression<Func<newTierInput>> newTier)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: true);
            var __workflow_newTier = newTier == null ? null : WorkflowExpression.Compile(newTier);
            WorkflowExpression.Validate(__workflow_newTier, nameof(newTier), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/SetBlobTierByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["newTier"] = ExpressionConverter.Convert(__workflow_newTier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }
    }

    public class AzureblobTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_maxFileCount = maxFileCount == null ? null : WorkflowExpression.Compile(maxFileCount);
            WorkflowExpression.Validate(__workflow_maxFileCount, nameof(maxFileCount), required: false);
            return new DeferredBodyTrigger<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/triggers/batch/onupdatedfile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (__workflow_maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(__workflow_maxFileCount);
                callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
                return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

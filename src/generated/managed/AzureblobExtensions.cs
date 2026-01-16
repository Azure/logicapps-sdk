//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureblob
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureblobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadataV2(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
            return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFileV2(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction DeleteFileV2(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadataByPathV2(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
            return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContentByPathV2(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/GetFileContentByPath", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContentV2(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> CreateFileV2(Expression<Func<string>> dataset, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> CopyFileV2(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/copyFile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<ListOfBlobsWithSensitivityLabels> ListFolderV4(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> nextPageMarker = null, Expression<Func<bool>> useFlatListing = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/foldersV2/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadataPage> ListRootFolderV4(Expression<Func<string>> dataset, Expression<Func<string>> nextPageMarker = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/foldersV2", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["nextPageMarker"] = Convert.ToString("");
            if (nextPageMarker != null)
                callPayload.Queries["nextPageMarker"] = ExpressionConverter.Convert(nextPageMarker);
            callPayload.Queries["useFlatListing"] = Convert.ToString(false);
            return new ApiConnectionAction<BlobMetadataPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolderV3(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/extractFolderV2", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignature> CreateShareLinkByPathV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> path, Expression<Func<string>> policygroupPolicyIdentifier = null, Expression<Func<policypermissionsInput>> policypermissions = null, Expression<Func<string>> policystartTime = null, Expression<Func<string>> policyexpiryTime = null, Expression<Func<policysharedAccessProtocolInput>> policysharedAccessProtocol = null, Expression<Func<string>> policyiPAddressOrIPAddressRange = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/CreateSharedLinkByPath", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
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
                policy["Permissions"] = ExpressionConverter.ConvertO(policypermissions);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction SetBlobTierByPathV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> path, Expression<Func<newTierInput>> newTier)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/SetBlobTierByPath", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["newTier"] = ExpressionConverter.Convert(newTier);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignatureBlobPolicy[]> GetAccessPoliciesV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/policies", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<SharedAccessSignatureBlobPolicy[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction CreateBlockBlobV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = String.Format("/v2/codeless/datasets/{0}/CreateBlockBlob", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AzureblobTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<BlobMetadata[]> OnUpdatedFilesV2(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0}/triggers/batch/onupdatedfile", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["maxFileCount"] = Convert.ToString(10);
            if (maxFileCount != null)
                callPayload.Queries["maxFileCount"] = ExpressionConverter.Convert(maxFileCount);
            callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
            return new ApiConnectionTrigger<BlobMetadata[]>(callPayload);
        }
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

    public enum newTierInput
    {
        Hot,
        Cool,
        Archive
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
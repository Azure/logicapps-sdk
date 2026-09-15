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
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/copyFile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = CSharpExpressionConverter.ConvertO(source);
            callPayload.Queries["destination"] = CSharpExpressionConverter.ConvertO(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = CSharpExpressionConverter.ConvertO(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction CreateBlockBlob(Expression<Func<string>> storageAccountName, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/codeless/datasets/{0}/CreateBlockBlob", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile(Expression<Func<string>> dataset, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignature> CreateShareLinkByPath(Expression<Func<string>> storageAccountName, Expression<Func<string>> path, Expression<Func<string>> policygroupPolicyIdentifier = null, Expression<Func<policypermissionsInput>> policypermissions = null, Expression<Func<string>> policystartTime = null, Expression<Func<string>> policyexpiryTime = null, Expression<Func<policysharedAccessProtocolInput>> policysharedAccessProtocol = null, Expression<Func<string>> policyiPAddressOrIPAddressRange = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/CreateSharedLinkByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            var policy = new JObject();
            var policypropCount = 0;
            if (policygroupPolicyIdentifier != null)
            {
                policy["GroupPolicyIdentifier"] = CSharpExpressionConverter.ConvertToken(policygroupPolicyIdentifier);
                policypropCount++;
            }

            if (policypermissions != null)
            {
                if (policypermissions != null)
                {
                    policy["Permissions"] = CSharpExpressionConverter.Convert(policypermissions);
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
                policy["StartTime"] = CSharpExpressionConverter.ConvertToken(policystartTime);
                policypropCount++;
            }

            if (policyexpiryTime != null)
            {
                policy["ExpiryTime"] = CSharpExpressionConverter.ConvertToken(policyexpiryTime);
                policypropCount++;
            }

            if (policysharedAccessProtocol != null)
            {
                policy["AccessProtocol"] = CSharpExpressionConverter.Convert(policysharedAccessProtocol);
                policypropCount++;
            }

            if (policyiPAddressOrIPAddressRange != null)
            {
                policy["IpAddressOrRange"] = CSharpExpressionConverter.ConvertToken(policyiPAddressOrIPAddressRange);
                policypropCount++;
            }

            if (policypropCount > 0)
            {
                callPayload.Body = policy;
            }

            return new ApiConnectionAction<SharedAccessSignature>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/extractFolderV2", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = CSharpExpressionConverter.ConvertO(source);
            callPayload.Queries["destination"] = CSharpExpressionConverter.ConvertO(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = CSharpExpressionConverter.ConvertO(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignatureBlobPolicy[]> GetAccessPolicies(Expression<Func<string>> storageAccountName, Expression<Func<string>> path)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/policies", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            return new ApiConnectionAction<SharedAccessSignatureBlobPolicy[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}/content", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = CSharpExpressionConverter.ConvertO(inferContentType);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileContentByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = CSharpExpressionConverter.ConvertO(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<DataWithSensitivityLabelInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<ListOfBlobsWithSensitivityLabels> ListFolder(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> nextPageMarker = null, Expression<Func<bool>> useFlatListing = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["nextPageMarker"] = Convert.ToString("");
            if (nextPageMarker != null)
                callPayload.Queries["nextPageMarker"] = CSharpExpressionConverter.ConvertO(nextPageMarker);
            callPayload.Queries["useFlatListing"] = Convert.ToString(false);
            if (useFlatListing != null)
                callPayload.Queries["useFlatListing"] = CSharpExpressionConverter.ConvertO(useFlatListing);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<ListOfBlobsWithSensitivityLabels>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadataPage> ListRootFolder(Expression<Func<string>> dataset, Expression<Func<string>> nextPageMarker = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["nextPageMarker"] = Convert.ToString("");
            if (nextPageMarker != null)
                callPayload.Queries["nextPageMarker"] = CSharpExpressionConverter.ConvertO(nextPageMarker);
            callPayload.Queries["useFlatListing"] = Convert.ToString(false);
            return new ApiConnectionAction<BlobMetadataPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction SetBlobTierByPath(Expression<Func<string>> storageAccountName, Expression<Func<string>> path, Expression<Func<newTierInput>> newTier)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/SetBlobTierByPath", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = CSharpExpressionConverter.ConvertO(path);
            callPayload.Queries["newTier"] = CSharpExpressionConverter.Convert(newTier);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }
    }

    public class AzureblobTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<int>> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/triggers/batch/onupdatedfile", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            callPayload.Queries["maxFileCount"] = Convert.ToString(10);
            if (maxFileCount != null)
                callPayload.Queries["maxFileCount"] = CSharpExpressionConverter.ConvertO(maxFileCount);
            callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
            return new ApiConnectionTrigger<BlobMetadata[]>(callPayload, triggerName, recurrence);
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
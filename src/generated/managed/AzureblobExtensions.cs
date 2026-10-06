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
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/copyFile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["destination"] = SourceExpressionConverter.ConvertO(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction CreateBlockBlob([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/codeless/datasets/{0}/CreateBlockBlob", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignature> CreateShareLinkByPath([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<string> policygroupPolicyIdentifier = null, [WorkflowExpression] Func<policypermissionsInput> policypermissions = null, [WorkflowExpression] Func<string> policystartTime = null, [WorkflowExpression] Func<string> policyexpiryTime = null, [WorkflowExpression] Func<policysharedAccessProtocolInput> policysharedAccessProtocol = null, [WorkflowExpression] Func<string> policyiPAddressOrIPAddressRange = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/CreateSharedLinkByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                var policy = new JObject();
                var policypropCount = 0;
                if (policygroupPolicyIdentifier != null)
                {
                    policy["GroupPolicyIdentifier"] = SourceExpressionConverter.ConvertToken(policygroupPolicyIdentifier);
                    policypropCount++;
                }

                if (policypermissions != null)
                {
                    if (policypermissions != null)
                    {
                        policy["Permissions"] = SourceExpressionConverter.Convert(policypermissions);
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
                    policy["StartTime"] = SourceExpressionConverter.ConvertToken(policystartTime);
                    policypropCount++;
                }

                if (policyexpiryTime != null)
                {
                    policy["ExpiryTime"] = SourceExpressionConverter.ConvertToken(policyexpiryTime);
                    policypropCount++;
                }

                if (policysharedAccessProtocol != null)
                {
                    policy["AccessProtocol"] = SourceExpressionConverter.Convert(policysharedAccessProtocol);
                    policypropCount++;
                }

                if (policyiPAddressOrIPAddressRange != null)
                {
                    policy["IpAddressOrRange"] = SourceExpressionConverter.ConvertToken(policyiPAddressOrIPAddressRange);
                    policypropCount++;
                }

                if (policypropCount > 0)
                {
                    callPayload.Body = policy;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SharedAccessSignature>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/extractFolderV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["destination"] = SourceExpressionConverter.ConvertO(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<SharedAccessSignatureBlobPolicy[]> GetAccessPolicies([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> path)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/policies", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<SharedAccessSignatureBlobPolicy[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileContentByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadata([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<DataWithSensitivityLabelInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<DataWithSensitivityLabelInfo> GetFileMetadataByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/GetFileByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<DataWithSensitivityLabelInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<ListOfBlobsWithSensitivityLabels> ListFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> nextPageMarker = null, [WorkflowExpression] Func<bool> useFlatListing = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nextPageMarker"] = Convert.ToString("");
                if (nextPageMarker != null)
                    callPayload.Queries["nextPageMarker"] = SourceExpressionConverter.ConvertO(nextPageMarker);
                callPayload.Queries["useFlatListing"] = Convert.ToString(false);
                if (useFlatListing != null)
                    callPayload.Queries["useFlatListing"] = SourceExpressionConverter.ConvertO(useFlatListing);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<ListOfBlobsWithSensitivityLabels>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadataPage> ListRootFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> nextPageMarker = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/foldersV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nextPageMarker"] = Convert.ToString("");
                if (nextPageMarker != null)
                    callPayload.Queries["nextPageMarker"] = SourceExpressionConverter.ConvertO(nextPageMarker);
                callPayload.Queries["useFlatListing"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadataPage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IWorkflowAction SetBlobTierByPath([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<newTierInput> newTier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/SetBlobTierByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["newTier"] = SourceExpressionConverter.Convert(newTier);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureblob")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }
    }

    public class AzureblobTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0}/triggers/batch/onupdatedfile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = SourceExpressionConverter.ConvertO(maxFileCount);
                callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionTrigger<BlobMetadata[]>(BuildSourceInput, triggerName, recurrence);
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
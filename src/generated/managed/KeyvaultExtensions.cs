//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Keyvault
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KeyvaultActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadataCollection> ListKeys()
        {
            var apiCallPath = "/keys";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<KeyMetadataCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadataCollection> ListKeyVersions(Expression<Func<string>> keyName)
        {
            var apiCallPath = String.Format("/keys/{0}/versions", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<KeyMetadataCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadata> GetKeyMetadata(Expression<Func<string>> keyName)
        {
            var apiCallPath = String.Format("/keys/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<KeyMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadata> GetKeyVersionMetadata(Expression<Func<string>> keyName, Expression<Func<string>> keyVersion)
        {
            var apiCallPath = String.Format("/keys/{0}/versions/{1}/metadata", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(keyVersion, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<KeyMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptData(Expression<Func<string>> keyName, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputrawData)
        {
            var apiCallPath = String.Format("/keys/{0}/encrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var operationInput = new JObject();
            var operationInputpropCount = 0;
            operationInputpropCount++;
            operationInput["algorithm"] = ExpressionConverter.ConvertO(operationInputalgorithm);
            operationInputpropCount++;
            operationInput["rawData"] = ExpressionConverter.ConvertO(operationInputrawData);
            if (operationInputpropCount > 0)
            {
                callPayload.Body = operationInput;
            }

            return new ApiConnectionAction<KeyEncryptOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptDataWithVersion(Expression<Func<string>> keyName, Expression<Func<string>> keyVersion, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputrawData)
        {
            var apiCallPath = String.Format("/keys/{0}/versions/{1}/encrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(keyVersion, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var operationInput = new JObject();
            var operationInputpropCount = 0;
            operationInputpropCount++;
            operationInput["algorithm"] = ExpressionConverter.ConvertO(operationInputalgorithm);
            operationInputpropCount++;
            operationInput["rawData"] = ExpressionConverter.ConvertO(operationInputrawData);
            if (operationInputpropCount > 0)
            {
                callPayload.Body = operationInput;
            }

            return new ApiConnectionAction<KeyEncryptOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptData(Expression<Func<string>> keyName, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputencryptedData)
        {
            var apiCallPath = String.Format("/keys/{0}/decrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var operationInput = new JObject();
            var operationInputpropCount = 0;
            operationInputpropCount++;
            operationInput["algorithm"] = ExpressionConverter.ConvertO(operationInputalgorithm);
            operationInputpropCount++;
            operationInput["encryptedData"] = ExpressionConverter.ConvertO(operationInputencryptedData);
            if (operationInputpropCount > 0)
            {
                callPayload.Body = operationInput;
            }

            return new ApiConnectionAction<KeyDecryptOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptDataWithVersion(Expression<Func<string>> keyName, Expression<Func<string>> keyVersion, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputencryptedData)
        {
            var apiCallPath = String.Format("/keys/{0}/versions/{1}/decrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(keyVersion, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var operationInput = new JObject();
            var operationInputpropCount = 0;
            operationInputpropCount++;
            operationInput["algorithm"] = ExpressionConverter.ConvertO(operationInputalgorithm);
            operationInputpropCount++;
            operationInput["encryptedData"] = ExpressionConverter.ConvertO(operationInputencryptedData);
            if (operationInputpropCount > 0)
            {
                callPayload.Body = operationInput;
            }

            return new ApiConnectionAction<KeyDecryptOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadataCollection> ListSecrets()
        {
            var apiCallPath = "/secrets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SecretMetadataCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadataCollection> ListSecretVersions(Expression<Func<string>> secretName)
        {
            var apiCallPath = String.Format("/secrets/{0}/versions", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SecretMetadataCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadata> GetSecretMetadata(Expression<Func<string>> secretName)
        {
            var apiCallPath = String.Format("/secrets/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SecretMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadata> GetSecretVersionMetadata(Expression<Func<string>> secretName, Expression<Func<string>> secretVersion)
        {
            var apiCallPath = String.Format("/secrets/{0}/versions/{1}/metadata", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1), ExpressionConverter.ConvertWithUrlEncoding(secretVersion, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SecretMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<Secret> GetSecret(Expression<Func<string>> secretName)
        {
            var apiCallPath = String.Format("/secrets/{0}/value", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Secret>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<Secret> GetSecretVersion(Expression<Func<string>> secretName, Expression<Func<string>> secretVersion)
        {
            var apiCallPath = String.Format("/secrets/{0}/versions/{1}/value", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1), ExpressionConverter.ConvertWithUrlEncoding(secretVersion, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Secret>(callPayload);
        }
    }

    public class KeyvaultTriggers([ConnectionName] string connectionId)
    {
    }

    public class KeyMetadataCollection
    {
        [JsonProperty("value")]
        public KeyMetadata[] Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }

    public class KeyMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("validityStartTime")]
        public string ValidityStartTime { get; set; }

        [JsonProperty("validityEndTime")]
        public string ValidityEndTime { get; set; }

        [JsonProperty("allowedOperations")]
        public string[] AllowedOperations { get; set; }

        [JsonProperty("keyType")]
        public string KeyType { get; set; }
    }

    public class KeyEncryptOutput
    {
        [JsonProperty("encryptedData")]
        public string EncryptedData { get; set; }
    }

    public enum operationInputalgorithmInput
    {
        [EnumMember(Value = "RSA-OAEP-256")]
        RSAOAEP256,
        [EnumMember(Value = "RSA-OAEP")]
        RSAOAEP,
        [EnumMember(Value = "RSA1_5")]
        RSA15
    }

    public class KeyDecryptOutput
    {
        [JsonProperty("rawData")]
        public string RawData { get; set; }
    }

    public class SecretMetadataCollection
    {
        [JsonProperty("value")]
        public SecretMetadata[] Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }

    public class SecretMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("validityStartTime")]
        public string ValidityStartTime { get; set; }

        [JsonProperty("validityEndTime")]
        public string ValidityEndTime { get; set; }
    }

    public class Secret
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("validityStartTime")]
        public string ValidityStartTime { get; set; }

        [JsonProperty("validityEndTime")]
        public string ValidityEndTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Keyvault;

    public partial class WorkflowManagedActions
    {
        public KeyvaultActions Keyvault(string connectionId) => new KeyvaultActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KeyvaultTriggers Keyvault(string connectionId) => new KeyvaultTriggers(connectionId);
    }
}
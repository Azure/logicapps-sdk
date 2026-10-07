//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Keyvault
{
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
        [WorkflowExpressionFactory(nameof(__BuildListKeyVersions))]
        public IBodyWorkflowAction<KeyMetadataCollection> ListKeyVersions([WorkflowExpression] Func<string> keyName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyMetadataCollection> __BuildListKeyVersions(WorkflowExpression<string> keyName)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<KeyMetadataCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KeyMetadataCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildGetKeyMetadata))]
        public IBodyWorkflowAction<KeyMetadata> GetKeyMetadata([WorkflowExpression] Func<string> keyName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyMetadata> __BuildGetKeyMetadata(WorkflowExpression<string> keyName)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<KeyMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KeyMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildGetKeyVersionMetadata))]
        public IBodyWorkflowAction<KeyMetadata> GetKeyVersionMetadata([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> keyVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyMetadata> __BuildGetKeyVersionMetadata(WorkflowExpression<string> keyName, WorkflowExpression<string> keyVersion)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            WorkflowExpression.Validate(keyVersion, nameof(keyVersion), required: true);
            return new DeferredBodyAction<KeyMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/metadata", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(keyVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KeyMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildEncryptData))]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptData([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputrawData)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyEncryptOutput> __BuildEncryptData(WorkflowExpression<string> keyName, WorkflowExpression<operationInputalgorithmInput> operationInputalgorithm, WorkflowExpression<string> operationInputrawData)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            WorkflowExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            WorkflowExpression.Validate(operationInputrawData, nameof(operationInputrawData), required: true);
            return new DeferredBodyAction<KeyEncryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/encrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildEncryptDataWithVersion))]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptDataWithVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> keyVersion, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputrawData)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyEncryptOutput> __BuildEncryptDataWithVersion(WorkflowExpression<string> keyName, WorkflowExpression<string> keyVersion, WorkflowExpression<operationInputalgorithmInput> operationInputalgorithm, WorkflowExpression<string> operationInputrawData)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            WorkflowExpression.Validate(keyVersion, nameof(keyVersion), required: true);
            WorkflowExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            WorkflowExpression.Validate(operationInputrawData, nameof(operationInputrawData), required: true);
            return new DeferredBodyAction<KeyEncryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/encrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(keyVersion, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildDecryptData))]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptData([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputencryptedData)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyDecryptOutput> __BuildDecryptData(WorkflowExpression<string> keyName, WorkflowExpression<operationInputalgorithmInput> operationInputalgorithm, WorkflowExpression<string> operationInputencryptedData)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            WorkflowExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            WorkflowExpression.Validate(operationInputencryptedData, nameof(operationInputencryptedData), required: true);
            return new DeferredBodyAction<KeyDecryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/decrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildDecryptDataWithVersion))]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptDataWithVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> keyVersion, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputencryptedData)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyDecryptOutput> __BuildDecryptDataWithVersion(WorkflowExpression<string> keyName, WorkflowExpression<string> keyVersion, WorkflowExpression<operationInputalgorithmInput> operationInputalgorithm, WorkflowExpression<string> operationInputencryptedData)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: true);
            WorkflowExpression.Validate(keyVersion, nameof(keyVersion), required: true);
            WorkflowExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            WorkflowExpression.Validate(operationInputencryptedData, nameof(operationInputencryptedData), required: true);
            return new DeferredBodyAction<KeyDecryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/decrypt", ExpressionConverter.ConvertWithUrlEncoding(keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(keyVersion, 1));
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildListSecretVersions))]
        public IBodyWorkflowAction<SecretMetadataCollection> ListSecretVersions([WorkflowExpression] Func<string> secretName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SecretMetadataCollection> __BuildListSecretVersions(WorkflowExpression<string> secretName)
        {
            WorkflowExpression.Validate(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<SecretMetadataCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretMetadataCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecretMetadata))]
        public IBodyWorkflowAction<SecretMetadata> GetSecretMetadata([WorkflowExpression] Func<string> secretName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SecretMetadata> __BuildGetSecretMetadata(WorkflowExpression<string> secretName)
        {
            WorkflowExpression.Validate(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<SecretMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecretVersionMetadata))]
        public IBodyWorkflowAction<SecretMetadata> GetSecretVersionMetadata([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> secretVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SecretMetadata> __BuildGetSecretVersionMetadata(WorkflowExpression<string> secretName, WorkflowExpression<string> secretVersion)
        {
            WorkflowExpression.Validate(secretName, nameof(secretName), required: true);
            WorkflowExpression.Validate(secretVersion, nameof(secretVersion), required: true);
            return new DeferredBodyAction<SecretMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions/{1}/metadata", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1), ExpressionConverter.ConvertWithUrlEncoding(secretVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecret))]
        public IBodyWorkflowAction<Secret> GetSecret([WorkflowExpression] Func<string> secretName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Secret> __BuildGetSecret(WorkflowExpression<string> secretName)
        {
            WorkflowExpression.Validate(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<Secret>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/value", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Secret>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecretVersion))]
        public IBodyWorkflowAction<Secret> GetSecretVersion([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> secretVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Secret> __BuildGetSecretVersion(WorkflowExpression<string> secretName, WorkflowExpression<string> secretVersion)
        {
            WorkflowExpression.Validate(secretName, nameof(secretName), required: true);
            WorkflowExpression.Validate(secretVersion, nameof(secretVersion), required: true);
            return new DeferredBodyAction<Secret>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions/{1}/value", ExpressionConverter.ConvertWithUrlEncoding(secretName, 1), ExpressionConverter.ConvertWithUrlEncoding(secretVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Secret>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

namespace Microsoft.Azure.Workflows.Sdk
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
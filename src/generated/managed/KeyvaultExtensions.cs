//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Keyvault
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<KeyMetadataCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KeyMetadataCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadata> GetKeyMetadata(Expression<Func<string>> keyName)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<KeyMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KeyMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadata> GetKeyVersionMetadata(Expression<Func<string>> keyName, Expression<Func<string>> keyVersion)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_keyVersion = WorkflowExpression.Compile(keyVersion, nameof(keyVersion), required: true);
            return new DeferredBodyAction<KeyMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/metadata", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KeyMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptData(Expression<Func<string>> keyName, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputrawData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_operationInputalgorithm = WorkflowExpression.Compile(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            var __workflow_operationInputrawData = WorkflowExpression.Compile(operationInputrawData, nameof(operationInputrawData), required: true);
            return new DeferredBodyAction<KeyEncryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/encrypt", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = ExpressionConverter.ConvertO(__workflow_operationInputalgorithm);
                operationInputpropCount++;
                operationInput["rawData"] = ExpressionConverter.ConvertO(__workflow_operationInputrawData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }

                return new ApiConnectionAction<KeyEncryptOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptDataWithVersion(Expression<Func<string>> keyName, Expression<Func<string>> keyVersion, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputrawData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_keyVersion = WorkflowExpression.Compile(keyVersion, nameof(keyVersion), required: true);
            var __workflow_operationInputalgorithm = WorkflowExpression.Compile(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            var __workflow_operationInputrawData = WorkflowExpression.Compile(operationInputrawData, nameof(operationInputrawData), required: true);
            return new DeferredBodyAction<KeyEncryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/encrypt", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyVersion, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = ExpressionConverter.ConvertO(__workflow_operationInputalgorithm);
                operationInputpropCount++;
                operationInput["rawData"] = ExpressionConverter.ConvertO(__workflow_operationInputrawData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }

                return new ApiConnectionAction<KeyEncryptOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptData(Expression<Func<string>> keyName, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputencryptedData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_operationInputalgorithm = WorkflowExpression.Compile(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            var __workflow_operationInputencryptedData = WorkflowExpression.Compile(operationInputencryptedData, nameof(operationInputencryptedData), required: true);
            return new DeferredBodyAction<KeyDecryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/decrypt", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = ExpressionConverter.ConvertO(__workflow_operationInputalgorithm);
                operationInputpropCount++;
                operationInput["encryptedData"] = ExpressionConverter.ConvertO(__workflow_operationInputencryptedData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }

                return new ApiConnectionAction<KeyDecryptOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptDataWithVersion(Expression<Func<string>> keyName, Expression<Func<string>> keyVersion, Expression<Func<operationInputalgorithmInput>> operationInputalgorithm, Expression<Func<string>> operationInputencryptedData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_keyVersion = WorkflowExpression.Compile(keyVersion, nameof(keyVersion), required: true);
            var __workflow_operationInputalgorithm = WorkflowExpression.Compile(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            var __workflow_operationInputencryptedData = WorkflowExpression.Compile(operationInputencryptedData, nameof(operationInputencryptedData), required: true);
            return new DeferredBodyAction<KeyDecryptOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/decrypt", ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_keyVersion, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = ExpressionConverter.ConvertO(__workflow_operationInputalgorithm);
                operationInputpropCount++;
                operationInput["encryptedData"] = ExpressionConverter.ConvertO(__workflow_operationInputencryptedData);
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
        public IBodyWorkflowAction<SecretMetadataCollection> ListSecretVersions(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<SecretMetadataCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretMetadataCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadata> GetSecretMetadata(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<SecretMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadata> GetSecretVersionMetadata(Expression<Func<string>> secretName, Expression<Func<string>> secretVersion)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            var __workflow_secretVersion = WorkflowExpression.Compile(secretVersion, nameof(secretVersion), required: true);
            return new DeferredBodyAction<SecretMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions/{1}/metadata", ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<Secret> GetSecret(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<Secret>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/value", ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Secret>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<Secret> GetSecretVersion(Expression<Func<string>> secretName, Expression<Func<string>> secretVersion)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            var __workflow_secretVersion = WorkflowExpression.Compile(secretVersion, nameof(secretVersion), required: true);
            return new DeferredBodyAction<Secret>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions/{1}/value", ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_secretVersion, 1));
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

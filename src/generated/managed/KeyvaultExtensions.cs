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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/keys";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<KeyMetadataCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadataCollection> ListKeyVersions([WorkflowExpression] Func<string> keyName)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<KeyMetadataCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadata> GetKeyMetadata([WorkflowExpression] Func<string> keyName)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/metadata", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<KeyMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyMetadata> GetKeyVersionMetadata([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> keyVersion)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            SourceExpression.Validate(keyVersion, nameof(keyVersion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/metadata", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<KeyMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptData([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputrawData)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            SourceExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            SourceExpression.Validate(operationInputrawData, nameof(operationInputrawData), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/encrypt", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = SourceExpressionConverter.Convert(operationInputalgorithm);
                operationInputpropCount++;
                operationInput["rawData"] = SourceExpressionConverter.ConvertToken(operationInputrawData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KeyEncryptOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyEncryptOutput> EncryptDataWithVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> keyVersion, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputrawData)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            SourceExpression.Validate(keyVersion, nameof(keyVersion), required: true);
            SourceExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            SourceExpression.Validate(operationInputrawData, nameof(operationInputrawData), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/encrypt", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyVersion, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = SourceExpressionConverter.Convert(operationInputalgorithm);
                operationInputpropCount++;
                operationInput["rawData"] = SourceExpressionConverter.ConvertToken(operationInputrawData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KeyEncryptOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptData([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputencryptedData)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            SourceExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            SourceExpression.Validate(operationInputencryptedData, nameof(operationInputencryptedData), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/decrypt", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = SourceExpressionConverter.Convert(operationInputalgorithm);
                operationInputpropCount++;
                operationInput["encryptedData"] = SourceExpressionConverter.ConvertToken(operationInputencryptedData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KeyDecryptOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<KeyDecryptOutput> DecryptDataWithVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> keyVersion, [WorkflowExpression] Func<operationInputalgorithmInput> operationInputalgorithm, [WorkflowExpression] Func<string> operationInputencryptedData)
        {
            SourceExpression.Validate(keyName, nameof(keyName), required: true);
            SourceExpression.Validate(keyVersion, nameof(keyVersion), required: true);
            SourceExpression.Validate(operationInputalgorithm, nameof(operationInputalgorithm), required: true);
            SourceExpression.Validate(operationInputencryptedData, nameof(operationInputencryptedData), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keys/{0}/versions/{1}/decrypt", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyVersion, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var operationInput = new JObject();
                var operationInputpropCount = 0;
                operationInputpropCount++;
                operationInput["algorithm"] = SourceExpressionConverter.Convert(operationInputalgorithm);
                operationInputpropCount++;
                operationInput["encryptedData"] = SourceExpressionConverter.ConvertToken(operationInputencryptedData);
                if (operationInputpropCount > 0)
                {
                    callPayload.Body = operationInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KeyDecryptOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadataCollection> ListSecrets()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secrets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SecretMetadataCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadataCollection> ListSecretVersions([WorkflowExpression] Func<string> secretName)
        {
            SourceExpression.Validate(secretName, nameof(secretName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SecretMetadataCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadata> GetSecretMetadata([WorkflowExpression] Func<string> secretName)
        {
            SourceExpression.Validate(secretName, nameof(secretName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}/metadata", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SecretMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<SecretMetadata> GetSecretVersionMetadata([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> secretVersion)
        {
            SourceExpression.Validate(secretName, nameof(secretName), required: true);
            SourceExpression.Validate(secretVersion, nameof(secretVersion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions/{1}/metadata", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SecretMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<Secret> GetSecret([WorkflowExpression] Func<string> secretName)
        {
            SourceExpression.Validate(secretName, nameof(secretName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}/value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Secret>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keyvault")]
        public IBodyWorkflowAction<Secret> GetSecretVersion([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> secretVersion)
        {
            SourceExpression.Validate(secretName, nameof(secretName), required: true);
            SourceExpression.Validate(secretVersion, nameof(secretVersion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}/versions/{1}/value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(secretVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Secret>(BuildSourceInput);
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
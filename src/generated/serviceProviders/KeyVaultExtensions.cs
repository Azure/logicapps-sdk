//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.KeyVault
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class KeyVaultActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecret))]
        public IBodyWorkflowAction<GetSecretOutput> GetSecret([WorkflowExpression] Func<string> secretName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSecretOutput> __BuildGetSecret(WorkflowValue<string> secretName)
        {
            WorkflowValue.Validate(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<GetSecretOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecret", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecretVersion))]
        public IBodyWorkflowAction<GetSecretVersionOutput> GetSecretVersion([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> version)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSecretVersionOutput> __BuildGetSecretVersion(WorkflowValue<string> secretName, WorkflowValue<string> version)
        {
            WorkflowValue.Validate(secretName, nameof(secretName), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            return new DeferredBodyAction<GetSecretVersionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(secretName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretVersionOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListSecretMetadataOutputItem[]> ListSecretMetadata()
        {
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listSecretMetadata", connectionName: connectionId)
            };
            return new ServiceProviderAction<ListSecretMetadataOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecretMetadata))]
        public IBodyWorkflowAction<GetSecretMetadataOutput> GetSecretMetadata([WorkflowExpression] Func<string> secretName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSecretMetadataOutput> __BuildGetSecretMetadata(WorkflowValue<string> secretName)
        {
            WorkflowValue.Validate(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<GetSecretMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildGetSecretVersionMetadata))]
        public IBodyWorkflowAction<GetSecretVersionMetadataOutput> GetSecretVersionMetadata([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> version)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSecretVersionMetadataOutput> __BuildGetSecretVersionMetadata(WorkflowValue<string> secretName, WorkflowValue<string> version)
        {
            WorkflowValue.Validate(secretName, nameof(secretName), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            return new DeferredBodyAction<GetSecretVersionMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(secretName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretVersionMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildListSecretVersionMetadata))]
        public IBodyWorkflowAction<ListSecretVersionMetadataOutputItem[]> ListSecretVersionMetadata([WorkflowExpression] Func<string> secretName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSecretVersionMetadataOutputItem[]> __BuildListSecretVersionMetadata(WorkflowValue<string> secretName)
        {
            WorkflowValue.Validate(secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<ListSecretVersionMetadataOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listSecretVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListSecretVersionMetadataOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildGetKeyMetadata))]
        public IBodyWorkflowAction<GetKeyMetadataOutput> GetKeyMetadata([WorkflowExpression] Func<string> keyName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetKeyMetadataOutput> __BuildGetKeyMetadata(WorkflowValue<string> keyName)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<GetKeyMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getKeyMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetKeyMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListKeyMetadataOutputItem[]> ListKeyMetadata()
        {
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listKeyMetadata", connectionName: connectionId)
            };
            return new ServiceProviderAction<ListKeyMetadataOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildGetKeyVersionMetadata))]
        public IBodyWorkflowAction<GetKeyVersionMetadataOutput> GetKeyVersionMetadata([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> version)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetKeyVersionMetadataOutput> __BuildGetKeyVersionMetadata(WorkflowValue<string> keyName, WorkflowValue<string> version)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            return new DeferredBodyAction<GetKeyVersionMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getKeyVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetKeyVersionMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildListKeyVersionMetadata))]
        public IBodyWorkflowAction<ListKeyVersionMetadataOutputItem[]> ListKeyVersionMetadata([WorkflowExpression] Func<string> keyName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListKeyVersionMetadataOutputItem[]> __BuildListKeyVersionMetadata(WorkflowValue<string> keyName)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<ListKeyVersionMetadataOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listKeyVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListKeyVersionMetadataOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildDecryptDataWithKey))]
        public IBodyWorkflowAction<DecryptDataWithKeyOutput> DecryptDataWithKey([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<DecryptDataWithKeyInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> encryptedData)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DecryptDataWithKeyOutput> __BuildDecryptDataWithKey(WorkflowValue<string> keyName, WorkflowValue<DecryptDataWithKeyInputAlgorithmType> algorithm, WorkflowValue<string> encryptedData)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            WorkflowValue.Validate(algorithm, nameof(algorithm), required: true);
            WorkflowValue.Validate(encryptedData, nameof(encryptedData), required: true);
            return new DeferredBodyAction<DecryptDataWithKeyOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(algorithm);
                serviceProviderParameters["encryptedData"] = ExpressionConverter.ConvertO(encryptedData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "decryptDataWithKey", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DecryptDataWithKeyOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildDecryptDataWithKeyVersion))]
        public IBodyWorkflowAction<DecryptDataWithKeyVersionOutput> DecryptDataWithKeyVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<DecryptDataWithKeyVersionInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> encryptedData)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DecryptDataWithKeyVersionOutput> __BuildDecryptDataWithKeyVersion(WorkflowValue<string> keyName, WorkflowValue<string> version, WorkflowValue<DecryptDataWithKeyVersionInputAlgorithmType> algorithm, WorkflowValue<string> encryptedData)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            WorkflowValue.Validate(algorithm, nameof(algorithm), required: true);
            WorkflowValue.Validate(encryptedData, nameof(encryptedData), required: true);
            return new DeferredBodyAction<DecryptDataWithKeyVersionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(version);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(algorithm);
                serviceProviderParameters["encryptedData"] = ExpressionConverter.ConvertO(encryptedData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "decryptDataWithKeyVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DecryptDataWithKeyVersionOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildEncryptDataWithKey))]
        public IBodyWorkflowAction<EncryptDataWithKeyOutput> EncryptDataWithKey([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<EncryptDataWithKeyInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> rawData)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EncryptDataWithKeyOutput> __BuildEncryptDataWithKey(WorkflowValue<string> keyName, WorkflowValue<EncryptDataWithKeyInputAlgorithmType> algorithm, WorkflowValue<string> rawData)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            WorkflowValue.Validate(algorithm, nameof(algorithm), required: true);
            WorkflowValue.Validate(rawData, nameof(rawData), required: true);
            return new DeferredBodyAction<EncryptDataWithKeyOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(algorithm);
                serviceProviderParameters["rawData"] = ExpressionConverter.ConvertO(rawData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "encryptDataWithKey", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<EncryptDataWithKeyOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        [WorkflowExpressionFactory(nameof(__BuildEncryptDataWithKeyVersion))]
        public IBodyWorkflowAction<EncryptDataWithKeyVersionOutput> EncryptDataWithKeyVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<EncryptDataWithKeyVersionInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> rawData)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EncryptDataWithKeyVersionOutput> __BuildEncryptDataWithKeyVersion(WorkflowValue<string> keyName, WorkflowValue<string> version, WorkflowValue<EncryptDataWithKeyVersionInputAlgorithmType> algorithm, WorkflowValue<string> rawData)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            WorkflowValue.Validate(algorithm, nameof(algorithm), required: true);
            WorkflowValue.Validate(rawData, nameof(rawData), required: true);
            return new DeferredBodyAction<EncryptDataWithKeyVersionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(keyName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(version);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(algorithm);
                serviceProviderParameters["rawData"] = ExpressionConverter.ConvertO(rawData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "encryptDataWithKeyVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<EncryptDataWithKeyVersionOutput>(serviceProviderInput);
            });
        }
    }

    public class GetSecretOutput
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

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

    public class GetSecretVersionOutput
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

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

    public class ListSecretMetadataOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

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

    public class GetSecretMetadataOutput
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

    public class GetSecretVersionMetadataOutput
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

    public class ListSecretVersionMetadataOutputItem
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

    public class GetKeyMetadataOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("allowedOperations")]
        public string[] AllowedOperations { get; set; }

        [JsonProperty("keyType")]
        public string KeyType { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("validityStartTime")]
        public string ValidityStartTime { get; set; }

        [JsonProperty("validityEndTime")]
        public string ValidityEndTime { get; set; }
    }

    public class ListKeyMetadataOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

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

    public class GetKeyVersionMetadataOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("allowedOperations")]
        public string[] AllowedOperations { get; set; }

        [JsonProperty("keyType")]
        public string KeyType { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [JsonProperty("validityStartTime")]
        public string ValidityStartTime { get; set; }

        [JsonProperty("validityEndTime")]
        public string ValidityEndTime { get; set; }
    }

    public class ListKeyVersionMetadataOutputItem
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
    }

    public class DecryptDataWithKeyOutput
    {
        [JsonProperty("rawData")]
        public string RawData { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DecryptDataWithKeyInputAlgorithmType
    {
        [EnumMember(Value = "RSA-OAEP")]
        RSAOAEP,
        [EnumMember(Value = "RSA-OAEP-256")]
        RSAOAEP256,
        [EnumMember(Value = "RSA1_5")]
        RSA15
    }

    public class DecryptDataWithKeyVersionOutput
    {
        [JsonProperty("rawData")]
        public string RawData { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DecryptDataWithKeyVersionInputAlgorithmType
    {
        [EnumMember(Value = "RSA-OAEP")]
        RSAOAEP,
        [EnumMember(Value = "RSA-OAEP-256")]
        RSAOAEP256,
        [EnumMember(Value = "RSA1_5")]
        RSA15
    }

    public class EncryptDataWithKeyOutput
    {
        [JsonProperty("encryptedData")]
        public string EncryptedData { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptDataWithKeyInputAlgorithmType
    {
        [EnumMember(Value = "RSA-OAEP")]
        RSAOAEP,
        [EnumMember(Value = "RSA-OAEP-256")]
        RSAOAEP256,
        [EnumMember(Value = "RSA1_5")]
        RSA15
    }

    public class EncryptDataWithKeyVersionOutput
    {
        [JsonProperty("encryptedData")]
        public string EncryptedData { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptDataWithKeyVersionInputAlgorithmType
    {
        [EnumMember(Value = "RSA-OAEP")]
        RSAOAEP,
        [EnumMember(Value = "RSA-OAEP-256")]
        RSAOAEP256,
        [EnumMember(Value = "RSA1_5")]
        RSA15
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.KeyVault;

    public partial class WorkflowServiceProviderActions
    {
        public KeyVaultActions KeyVault(string connectionId) => new KeyVaultActions(connectionId);
    }
}

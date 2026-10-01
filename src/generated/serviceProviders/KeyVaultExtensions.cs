//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.KeyVault
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class KeyVaultActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretOutput> GetSecret([WorkflowExpression] Func<string> secretName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = SourceExpressionConverter.ConvertToken(secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecret", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetSecretOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretVersionOutput> GetSecretVersion([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> version)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = SourceExpressionConverter.ConvertToken(secretName);
                serviceProviderParameters["version"] = SourceExpressionConverter.ConvertToken(version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetSecretVersionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListSecretMetadataOutputItem[]> ListSecretMetadata()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listSecretMetadata", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListSecretMetadataOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretMetadataOutput> GetSecretMetadata([WorkflowExpression] Func<string> secretName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = SourceExpressionConverter.ConvertToken(secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetSecretMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretVersionMetadataOutput> GetSecretVersionMetadata([WorkflowExpression] Func<string> secretName, [WorkflowExpression] Func<string> version)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = SourceExpressionConverter.ConvertToken(secretName);
                serviceProviderParameters["version"] = SourceExpressionConverter.ConvertToken(version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetSecretVersionMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListSecretVersionMetadataOutputItem[]> ListSecretVersionMetadata([WorkflowExpression] Func<string> secretName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = SourceExpressionConverter.ConvertToken(secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listSecretVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListSecretVersionMetadataOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetKeyMetadataOutput> GetKeyMetadata([WorkflowExpression] Func<string> keyName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getKeyMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetKeyMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListKeyMetadataOutputItem[]> ListKeyMetadata()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listKeyMetadata", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListKeyMetadataOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetKeyVersionMetadataOutput> GetKeyVersionMetadata([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> version)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                serviceProviderParameters["version"] = SourceExpressionConverter.ConvertToken(version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getKeyVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetKeyVersionMetadataOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListKeyVersionMetadataOutputItem[]> ListKeyVersionMetadata([WorkflowExpression] Func<string> keyName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listKeyVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListKeyVersionMetadataOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<DecryptDataWithKeyOutput> DecryptDataWithKey([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<DecryptDataWithKeyInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> encryptedData)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                serviceProviderParameters["algorithm"] = SourceExpressionConverter.ConvertToken(algorithm);
                serviceProviderParameters["encryptedData"] = SourceExpressionConverter.ConvertToken(encryptedData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "decryptDataWithKey", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<DecryptDataWithKeyOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<DecryptDataWithKeyVersionOutput> DecryptDataWithKeyVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<DecryptDataWithKeyVersionInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> encryptedData)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                serviceProviderParameters["version"] = SourceExpressionConverter.ConvertToken(version);
                serviceProviderParameters["algorithm"] = SourceExpressionConverter.ConvertToken(algorithm);
                serviceProviderParameters["encryptedData"] = SourceExpressionConverter.ConvertToken(encryptedData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "decryptDataWithKeyVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<DecryptDataWithKeyVersionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<EncryptDataWithKeyOutput> EncryptDataWithKey([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<EncryptDataWithKeyInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> rawData)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                serviceProviderParameters["algorithm"] = SourceExpressionConverter.ConvertToken(algorithm);
                serviceProviderParameters["rawData"] = SourceExpressionConverter.ConvertToken(rawData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "encryptDataWithKey", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<EncryptDataWithKeyOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<EncryptDataWithKeyVersionOutput> EncryptDataWithKeyVersion([WorkflowExpression] Func<string> keyName, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<EncryptDataWithKeyVersionInputAlgorithmType> algorithm, [WorkflowExpression] Func<string> rawData)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = SourceExpressionConverter.ConvertToken(keyName);
                serviceProviderParameters["version"] = SourceExpressionConverter.ConvertToken(version);
                serviceProviderParameters["algorithm"] = SourceExpressionConverter.ConvertToken(algorithm);
                serviceProviderParameters["rawData"] = SourceExpressionConverter.ConvertToken(rawData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "encryptDataWithKeyVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<EncryptDataWithKeyVersionOutput>(BuildSourceInput);
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
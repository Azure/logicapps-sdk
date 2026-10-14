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
    using System.Linq.Expressions;

    public class KeyVaultActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretOutput> GetSecret(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = secretName == null ? null : WorkflowExpression.Compile(secretName);
            WorkflowExpression.Validate(__workflow_secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<GetSecretOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(__workflow_secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecret", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretVersionOutput> GetSecretVersion(Expression<Func<string>> secretName, Expression<Func<string>> version)
        {
            var __workflow_secretName = secretName == null ? null : WorkflowExpression.Compile(secretName);
            WorkflowExpression.Validate(__workflow_secretName, nameof(secretName), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            return new DeferredBodyAction<GetSecretVersionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(__workflow_secretName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(__workflow_version);
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
        public IBodyWorkflowAction<GetSecretMetadataOutput> GetSecretMetadata(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = secretName == null ? null : WorkflowExpression.Compile(secretName);
            WorkflowExpression.Validate(__workflow_secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<GetSecretMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(__workflow_secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretVersionMetadataOutput> GetSecretVersionMetadata(Expression<Func<string>> secretName, Expression<Func<string>> version)
        {
            var __workflow_secretName = secretName == null ? null : WorkflowExpression.Compile(secretName);
            WorkflowExpression.Validate(__workflow_secretName, nameof(secretName), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            return new DeferredBodyAction<GetSecretVersionMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(__workflow_secretName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(__workflow_version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getSecretVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSecretVersionMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListSecretVersionMetadataOutputItem[]> ListSecretVersionMetadata(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = secretName == null ? null : WorkflowExpression.Compile(secretName);
            WorkflowExpression.Validate(__workflow_secretName, nameof(secretName), required: true);
            return new DeferredBodyAction<ListSecretVersionMetadataOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["secretName"] = ExpressionConverter.ConvertO(__workflow_secretName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listSecretVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListSecretVersionMetadataOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetKeyMetadataOutput> GetKeyMetadata(Expression<Func<string>> keyName)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<GetKeyMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
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
        public IBodyWorkflowAction<GetKeyVersionMetadataOutput> GetKeyVersionMetadata(Expression<Func<string>> keyName, Expression<Func<string>> version)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            return new DeferredBodyAction<GetKeyVersionMetadataOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(__workflow_version);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "getKeyVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetKeyVersionMetadataOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListKeyVersionMetadataOutputItem[]> ListKeyVersionMetadata(Expression<Func<string>> keyName)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            return new DeferredBodyAction<ListKeyVersionMetadataOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listKeyVersionMetadata", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListKeyVersionMetadataOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<DecryptDataWithKeyOutput> DecryptDataWithKey(Expression<Func<string>> keyName, Expression<Func<DecryptDataWithKeyInputAlgorithmType>> algorithm, Expression<Func<string>> encryptedData)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            var __workflow_algorithm = algorithm == null ? null : WorkflowExpression.Compile(algorithm);
            WorkflowExpression.Validate(__workflow_algorithm, nameof(algorithm), required: true);
            var __workflow_encryptedData = encryptedData == null ? null : WorkflowExpression.Compile(encryptedData);
            WorkflowExpression.Validate(__workflow_encryptedData, nameof(encryptedData), required: true);
            return new DeferredBodyAction<DecryptDataWithKeyOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(__workflow_algorithm);
                serviceProviderParameters["encryptedData"] = ExpressionConverter.ConvertO(__workflow_encryptedData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "decryptDataWithKey", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DecryptDataWithKeyOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<DecryptDataWithKeyVersionOutput> DecryptDataWithKeyVersion(Expression<Func<string>> keyName, Expression<Func<string>> version, Expression<Func<DecryptDataWithKeyVersionInputAlgorithmType>> algorithm, Expression<Func<string>> encryptedData)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_algorithm = algorithm == null ? null : WorkflowExpression.Compile(algorithm);
            WorkflowExpression.Validate(__workflow_algorithm, nameof(algorithm), required: true);
            var __workflow_encryptedData = encryptedData == null ? null : WorkflowExpression.Compile(encryptedData);
            WorkflowExpression.Validate(__workflow_encryptedData, nameof(encryptedData), required: true);
            return new DeferredBodyAction<DecryptDataWithKeyVersionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(__workflow_version);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(__workflow_algorithm);
                serviceProviderParameters["encryptedData"] = ExpressionConverter.ConvertO(__workflow_encryptedData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "decryptDataWithKeyVersion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DecryptDataWithKeyVersionOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<EncryptDataWithKeyOutput> EncryptDataWithKey(Expression<Func<string>> keyName, Expression<Func<EncryptDataWithKeyInputAlgorithmType>> algorithm, Expression<Func<string>> rawData)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            var __workflow_algorithm = algorithm == null ? null : WorkflowExpression.Compile(algorithm);
            WorkflowExpression.Validate(__workflow_algorithm, nameof(algorithm), required: true);
            var __workflow_rawData = rawData == null ? null : WorkflowExpression.Compile(rawData);
            WorkflowExpression.Validate(__workflow_rawData, nameof(rawData), required: true);
            return new DeferredBodyAction<EncryptDataWithKeyOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(__workflow_algorithm);
                serviceProviderParameters["rawData"] = ExpressionConverter.ConvertO(__workflow_rawData);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "encryptDataWithKey", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<EncryptDataWithKeyOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<EncryptDataWithKeyVersionOutput> EncryptDataWithKeyVersion(Expression<Func<string>> keyName, Expression<Func<string>> version, Expression<Func<EncryptDataWithKeyVersionInputAlgorithmType>> algorithm, Expression<Func<string>> rawData)
        {
            var __workflow_keyName = keyName == null ? null : WorkflowExpression.Compile(keyName);
            WorkflowExpression.Validate(__workflow_keyName, nameof(keyName), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_algorithm = algorithm == null ? null : WorkflowExpression.Compile(algorithm);
            WorkflowExpression.Validate(__workflow_algorithm, nameof(algorithm), required: true);
            var __workflow_rawData = rawData == null ? null : WorkflowExpression.Compile(rawData);
            WorkflowExpression.Validate(__workflow_rawData, nameof(rawData), required: true);
            return new DeferredBodyAction<EncryptDataWithKeyVersionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["keyName"] = ExpressionConverter.ConvertO(__workflow_keyName);
                serviceProviderParameters["version"] = ExpressionConverter.ConvertO(__workflow_version);
                serviceProviderParameters["algorithm"] = ExpressionConverter.ConvertO(__workflow_algorithm);
                serviceProviderParameters["rawData"] = ExpressionConverter.ConvertO(__workflow_rawData);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

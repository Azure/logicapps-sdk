//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.KeyVault
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class KeyVaultActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretOutput> GetSecret(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretVersionOutput> GetSecretVersion(Expression<Func<string>> secretName, Expression<Func<string>> version)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListSecretMetadataOutputItem[]> ListSecretMetadata()
        {
            return new DeferredBodyAction<ListSecretMetadataOutputItem[]>(() =>
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listSecretMetadata", connectionName: connectionId)
                };
                return new ServiceProviderAction<ListSecretMetadataOutputItem[]>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretMetadataOutput> GetSecretMetadata(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetSecretVersionMetadataOutput> GetSecretVersionMetadata(Expression<Func<string>> secretName, Expression<Func<string>> version)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListSecretVersionMetadataOutputItem[]> ListSecretVersionMetadata(Expression<Func<string>> secretName)
        {
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetKeyMetadataOutput> GetKeyMetadata(Expression<Func<string>> keyName)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListKeyMetadataOutputItem[]> ListKeyMetadata()
        {
            return new DeferredBodyAction<ListKeyMetadataOutputItem[]>(() =>
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/keyVault", operationId: "listKeyMetadata", connectionName: connectionId)
                };
                return new ServiceProviderAction<ListKeyMetadataOutputItem[]>(serviceProviderInput);
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<GetKeyVersionMetadataOutput> GetKeyVersionMetadata(Expression<Func<string>> keyName, Expression<Func<string>> version)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<ListKeyVersionMetadataOutputItem[]> ListKeyVersionMetadata(Expression<Func<string>> keyName)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<DecryptDataWithKeyOutput> DecryptDataWithKey(Expression<Func<string>> keyName, Expression<Func<DecryptDataWithKeyInputAlgorithmType>> algorithm, Expression<Func<string>> encryptedData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_algorithm = WorkflowExpression.Compile(algorithm, nameof(algorithm), required: true);
            var __workflow_encryptedData = WorkflowExpression.Compile(encryptedData, nameof(encryptedData), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<DecryptDataWithKeyVersionOutput> DecryptDataWithKeyVersion(Expression<Func<string>> keyName, Expression<Func<string>> version, Expression<Func<DecryptDataWithKeyVersionInputAlgorithmType>> algorithm, Expression<Func<string>> encryptedData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_algorithm = WorkflowExpression.Compile(algorithm, nameof(algorithm), required: true);
            var __workflow_encryptedData = WorkflowExpression.Compile(encryptedData, nameof(encryptedData), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<EncryptDataWithKeyOutput> EncryptDataWithKey(Expression<Func<string>> keyName, Expression<Func<EncryptDataWithKeyInputAlgorithmType>> algorithm, Expression<Func<string>> rawData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_algorithm = WorkflowExpression.Compile(algorithm, nameof(algorithm), required: true);
            var __workflow_rawData = WorkflowExpression.Compile(rawData, nameof(rawData), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "keyVault")]
        public IBodyWorkflowAction<EncryptDataWithKeyVersionOutput> EncryptDataWithKeyVersion(Expression<Func<string>> keyName, Expression<Func<string>> version, Expression<Func<EncryptDataWithKeyVersionInputAlgorithmType>> algorithm, Expression<Func<string>> rawData)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_algorithm = WorkflowExpression.Compile(algorithm, nameof(algorithm), required: true);
            var __workflow_rawData = WorkflowExpression.Compile(rawData, nameof(rawData), required: true);
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
            }, WorkflowActionSettings.RetryPolicy | WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.FlatFileOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlatFileOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "flatFileOperations")]
        public IBodyWorkflowAction<JToken> FlatFileDecoding(Expression<Func<object>> content, Expression<Func<FlatFileDecodingSchemaType>> schema)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["schema"] = ExpressionConverter.ConvertO(schema);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/flatFileOperations", operationId: "flatFileDecoding", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "flatFileOperations")]
        public IBodyWorkflowAction<JToken> FlatFileEncoding(Expression<Func<object>> content, Expression<Func<FlatFileEncodingSchemaType>> schema, Expression<Func<FlatFileEncodingEmptyNodeGenerationModeType>> emptyNodeGenerationMode = null, Expression<Func<bool>> xmlNormalization = null)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["schema"] = ExpressionConverter.ConvertO(schema);
            if (emptyNodeGenerationMode != null)
            {
                parameters["emptyNodeGenerationMode"] = ExpressionConverter.ConvertO(emptyNodeGenerationMode);
            }

            if (xmlNormalization != null)
            {
                parameters["xmlNormalization"] = ExpressionConverter.ConvertO(xmlNormalization);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/flatFileOperations", operationId: "flatFileEncoding", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "flatFileOperations")]
        public IBodyWorkflowAction<JToken> FlatFileSchemaGeneration(Expression<Func<object>> content, Expression<Func<FlatFileSchemaGenerationRecordStructureType>> recordStructure, Expression<Func<bool>> hasHeader, Expression<Func<string>> rootElementName = null, Expression<Func<string>> targetNamespace = null, Expression<Func<string>> recordDelimiter = null, Expression<Func<FlatFileSchemaGenerationRecordDelimiterOrderType>> recordDelimiterOrder = null, Expression<Func<string>> recordName = null)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["recordStructure"] = ExpressionConverter.ConvertO(recordStructure);
            if (rootElementName != null)
            {
                parameters["rootElementName"] = ExpressionConverter.ConvertO(rootElementName);
            }

            if (targetNamespace != null)
            {
                parameters["targetNamespace"] = ExpressionConverter.ConvertO(targetNamespace);
            }

            parameters["hasHeader"] = ExpressionConverter.ConvertO(hasHeader);
            if (recordDelimiter != null)
            {
                parameters["recordDelimiter"] = ExpressionConverter.ConvertO(recordDelimiter);
            }

            if (recordDelimiterOrder != null)
            {
                parameters["recordDelimiterOrder"] = ExpressionConverter.ConvertO(recordDelimiterOrder);
            }

            if (recordName != null)
            {
                parameters["recordName"] = ExpressionConverter.ConvertO(recordName);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/flatFileOperations", operationId: "flatFileSchemaGeneration", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }
    }

    public class FlatFileOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class FlatFileDecodingSchemaType
    {
        [JsonProperty("source")]
        public FlatFileDecodingSchemaTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum FlatFileDecodingSchemaTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class FlatFileEncodingSchemaType
    {
        [JsonProperty("source")]
        public FlatFileEncodingSchemaTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum FlatFileEncodingSchemaTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public enum FlatFileEncodingEmptyNodeGenerationModeType
    {
        ForcedDisabled,
        HonorSchemaNodeProperty,
        ForcedEnabled
    }

    public enum FlatFileSchemaGenerationRecordStructureType
    {
        Delimited,
        Positional
    }

    public enum FlatFileSchemaGenerationRecordDelimiterOrderType
    {
        Infix,
        Prefix,
        Postfix
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.FlatFileOperations;

    public partial class WorkflowServiceProviderActions
    {
        public FlatFileOperationsActions FlatFileOperations(string connectionId) => new FlatFileOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public FlatFileOperationsTriggers FlatFileOperations(string connectionId) => new FlatFileOperationsTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azureaisearch
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["documents"] = CSharpExpressionConverter.ConvertToken(documents);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocuments", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["document"] = CSharpExpressionConverter.ConvertToken(document);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> VectorSearch(Expression<Func<string>> indexName, Expression<Func<VectorSearchInputSearchVectorType>> searchVector, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<VectorSearchInputSearchModeType>> searchMode = null, Expression<Func<string>> filter = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["searchVector"] = CSharpExpressionConverter.ConvertToken(searchVector);
            serviceProviderParameters["kNearestNeighbors"] = CSharpExpressionConverter.ConvertToken(kNearestNeighbors);
            if (search != null)
            {
                serviceProviderParameters["search"] = CSharpExpressionConverter.ConvertToken(search);
            }

            if (searchMode != null)
            {
                serviceProviderParameters["searchMode"] = CSharpExpressionConverter.ConvertToken(searchMode);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = CSharpExpressionConverter.ConvertToken(filter);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "vectorSearch", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> searchText, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<JToken[]>> vectorizedSearchFields = null, Expression<Func<JToken[]>> selectFields = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["searchText"] = CSharpExpressionConverter.ConvertToken(searchText);
            serviceProviderParameters["kNearestNeighbors"] = CSharpExpressionConverter.ConvertToken(kNearestNeighbors);
            if (search != null)
            {
                serviceProviderParameters["search"] = CSharpExpressionConverter.ConvertToken(search);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = CSharpExpressionConverter.ConvertToken(filter);
            }

            if (vectorizedSearchFields != null)
            {
                serviceProviderParameters["vectorizedSearchFields"] = CSharpExpressionConverter.ConvertToken(vectorizedSearchFields);
            }

            if (selectFields != null)
            {
                serviceProviderParameters["selectFields"] = CSharpExpressionConverter.ConvertToken(selectFields);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "integratedVectorSearch", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["document"] = CSharpExpressionConverter.ConvertToken(document);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["documents"] = CSharpExpressionConverter.ConvertToken(documents);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocuments", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> MergeDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["document"] = CSharpExpressionConverter.ConvertToken(document);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "mergeDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput> KnowledgeAgentRetrieval(Expression<Func<string>> indexName, Expression<Func<string>> agentName, Expression<Func<KnowledgeAgentRetrievalInputAgentMessageContentTypeItem[]>> agentMessageContent)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = CSharpExpressionConverter.ConvertToken(indexName);
            serviceProviderParameters["agentName"] = CSharpExpressionConverter.ConvertToken(agentName);
            serviceProviderParameters["agentMessageContent"] = CSharpExpressionConverter.ConvertToken(agentMessageContent);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "knowledgeAgentRetrieval", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<KnowledgeAgentRetrievalOutput>(serviceProviderInput);
        }
    }

    public class VectorSearchInputSearchVectorType
    {
        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("vector", DefaultValueHandling = DefaultValueHandling.Include)]
        public double[] Vector { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum VectorSearchInputSearchModeType
    {
        Any,
        All
    }

    public class KnowledgeAgentRetrievalOutput
    {
        [JsonProperty("value")]
        public KnowledgeAgentRetrievalOutputValueType Value { get; set; }

        [JsonProperty("hasValue")]
        public bool HasValue { get; set; }
    }

    public class KnowledgeAgentRetrievalOutputValueType
    {
        [JsonProperty("response")]
        public JToken[] Response { get; set; }

        [JsonProperty("activity")]
        public JToken[] Activity { get; set; }

        [JsonProperty("references")]
        public JToken[] References { get; set; }
    }

    public class KnowledgeAgentRetrievalInputAgentMessageContentTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        [System.ComponentModel.DefaultValue(KnowledgeAgentRetrievalInputAgentMessageContentTypeItemRoleType.User)]
        public KnowledgeAgentRetrievalInputAgentMessageContentTypeItemRoleType Role { get; set; } = KnowledgeAgentRetrievalInputAgentMessageContentTypeItemRoleType.User;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum KnowledgeAgentRetrievalInputAgentMessageContentTypeItemRoleType
    {
        User,
        Assistant
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azureaisearch;

    public partial class WorkflowServiceProviderActions
    {
        public AzureaisearchActions Azureaisearch(string connectionId) => new AzureaisearchActions(connectionId);
    }
}
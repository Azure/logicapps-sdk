//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azureaisearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["documents"] = ExpressionConverter.ConvertO(documents);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocuments", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["document"] = ExpressionConverter.ConvertO(document);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> VectorSearch(Expression<Func<string>> indexName, Expression<Func<VectorSearchSearchVectorType>> searchVector, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<VectorSearchSearchModeType>> searchMode = null, Expression<Func<string>> filter = null)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["searchVector"] = ExpressionConverter.ConvertO(searchVector);
            parameters["kNearestNeighbors"] = ExpressionConverter.ConvertO(kNearestNeighbors);
            if (search != null)
            {
                parameters["search"] = ExpressionConverter.ConvertO(search);
            }

            if (searchMode != null)
            {
                parameters["searchMode"] = ExpressionConverter.ConvertO(searchMode);
            }

            if (filter != null)
            {
                parameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "vectorSearch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> searchText, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<JToken[]>> vectorizedSearchFields = null, Expression<Func<JToken[]>> selectFields = null)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["searchText"] = ExpressionConverter.ConvertO(searchText);
            parameters["kNearestNeighbors"] = ExpressionConverter.ConvertO(kNearestNeighbors);
            if (search != null)
            {
                parameters["search"] = ExpressionConverter.ConvertO(search);
            }

            if (filter != null)
            {
                parameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            if (vectorizedSearchFields != null)
            {
                parameters["vectorizedSearchFields"] = ExpressionConverter.ConvertO(vectorizedSearchFields);
            }

            if (selectFields != null)
            {
                parameters["selectFields"] = ExpressionConverter.ConvertO(selectFields);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "integratedVectorSearch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["document"] = ExpressionConverter.ConvertO(document);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["documents"] = ExpressionConverter.ConvertO(documents);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocuments", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> MergeDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["document"] = ExpressionConverter.ConvertO(document);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "mergeDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput> KnowledgeAgentRetrieval(Expression<Func<string>> indexName, Expression<Func<string>> agentName, Expression<Func<KnowledgeAgentRetrievalAgentMessageContentTypeItem[]>> agentMessageContent)
        {
            var parameters = new JObject();
            parameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            parameters["agentName"] = ExpressionConverter.ConvertO(agentName);
            parameters["agentMessageContent"] = ExpressionConverter.ConvertO(agentMessageContent);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "knowledgeAgentRetrieval", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<KnowledgeAgentRetrievalOutput>(input);
        }
    }

    public class AzureaisearchTriggers([ConnectionName] string connectionId)
    {
    }

    public class VectorSearchSearchVectorType
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("vector")]
        public double[] Vector { get; set; }
    }

    public enum VectorSearchSearchModeType
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
        public string[] Response { get; set; }

        [JsonProperty("activity")]
        public string[] Activity { get; set; }

        [JsonProperty("references")]
        public string[] References { get; set; }
    }

    public class KnowledgeAgentRetrievalAgentMessageContentTypeItem
    {
        [JsonProperty("role")]
        public KnowledgeAgentRetrievalAgentMessageContentTypeItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public enum KnowledgeAgentRetrievalAgentMessageContentTypeItemRoleType
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

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureaisearchTriggers Azureaisearch(string connectionId) => new AzureaisearchTriggers(connectionId);
    }
}
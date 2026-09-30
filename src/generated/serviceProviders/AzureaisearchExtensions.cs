//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azureaisearch
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documents)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["documents"] = ExpressionConverter.ConvertO(documents);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocuments", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocument([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<object> document)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["document"] = ExpressionConverter.ConvertO(document);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> VectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<VectorSearchInputSearchVectorType> searchVector, [WorkflowExpression] Func<int> kNearestNeighbors, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<VectorSearchInputSearchModeType> searchMode = null, [WorkflowExpression] Func<string> filter = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["searchVector"] = ExpressionConverter.ConvertO(searchVector);
            serviceProviderParameters["kNearestNeighbors"] = ExpressionConverter.ConvertO(kNearestNeighbors);
            if (search != null)
            {
                serviceProviderParameters["search"] = ExpressionConverter.ConvertO(search);
            }

            if (searchMode != null)
            {
                serviceProviderParameters["searchMode"] = ExpressionConverter.ConvertO(searchMode);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "vectorSearch", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IntegratedVectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> searchText, [WorkflowExpression] Func<int> kNearestNeighbors, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<JToken[]> vectorizedSearchFields = null, [WorkflowExpression] Func<JToken[]> selectFields = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["searchText"] = ExpressionConverter.ConvertO(searchText);
            serviceProviderParameters["kNearestNeighbors"] = ExpressionConverter.ConvertO(kNearestNeighbors);
            if (search != null)
            {
                serviceProviderParameters["search"] = ExpressionConverter.ConvertO(search);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            if (vectorizedSearchFields != null)
            {
                serviceProviderParameters["vectorizedSearchFields"] = ExpressionConverter.ConvertO(vectorizedSearchFields);
            }

            if (selectFields != null)
            {
                serviceProviderParameters["selectFields"] = ExpressionConverter.ConvertO(selectFields);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "integratedVectorSearch", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocument([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<object> document)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["document"] = ExpressionConverter.ConvertO(document);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documents)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["documents"] = ExpressionConverter.ConvertO(documents);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocuments", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> MergeDocument([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<object> document)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["document"] = ExpressionConverter.ConvertO(document);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "mergeDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput> KnowledgeAgentRetrieval([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> agentName, [WorkflowExpression] Func<KnowledgeAgentRetrievalInputAgentMessageContentTypeItem[]> agentMessageContent)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(indexName);
            serviceProviderParameters["agentName"] = ExpressionConverter.ConvertO(agentName);
            serviceProviderParameters["agentMessageContent"] = ExpressionConverter.ConvertO(agentMessageContent);
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
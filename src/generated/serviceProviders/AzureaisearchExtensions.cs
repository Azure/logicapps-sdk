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
    using System.Linq.Expressions;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["documents"] = ExpressionConverter.ConvertO(__workflow_documents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> IndexDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["document"] = ExpressionConverter.ConvertO(__workflow_document);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> VectorSearch(Expression<Func<string>> indexName, Expression<Func<VectorSearchInputSearchVectorType>> searchVector, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<VectorSearchInputSearchModeType>> searchMode = null, Expression<Func<string>> filter = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_searchVector = WorkflowExpression.Compile(searchVector, nameof(searchVector), required: true);
            var __workflow_kNearestNeighbors = WorkflowExpression.Compile(kNearestNeighbors, nameof(kNearestNeighbors), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_searchMode = WorkflowExpression.Compile(searchMode, nameof(searchMode), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["searchVector"] = ExpressionConverter.ConvertO(__workflow_searchVector);
                serviceProviderParameters["kNearestNeighbors"] = ExpressionConverter.ConvertO(__workflow_kNearestNeighbors);
                if (__workflow_search != null)
                {
                    serviceProviderParameters["search"] = ExpressionConverter.ConvertO(__workflow_search);
                }

                if (__workflow_searchMode != null)
                {
                    serviceProviderParameters["searchMode"] = ExpressionConverter.ConvertO(__workflow_searchMode);
                }

                if (__workflow_filter != null)
                {
                    serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(__workflow_filter);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "vectorSearch", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> searchText, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<JToken[]>> vectorizedSearchFields = null, Expression<Func<JToken[]>> selectFields = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: true);
            var __workflow_kNearestNeighbors = WorkflowExpression.Compile(kNearestNeighbors, nameof(kNearestNeighbors), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_vectorizedSearchFields = WorkflowExpression.Compile(vectorizedSearchFields, nameof(vectorizedSearchFields), required: false);
            var __workflow_selectFields = WorkflowExpression.Compile(selectFields, nameof(selectFields), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["searchText"] = ExpressionConverter.ConvertO(__workflow_searchText);
                serviceProviderParameters["kNearestNeighbors"] = ExpressionConverter.ConvertO(__workflow_kNearestNeighbors);
                if (__workflow_search != null)
                {
                    serviceProviderParameters["search"] = ExpressionConverter.ConvertO(__workflow_search);
                }

                if (__workflow_filter != null)
                {
                    serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(__workflow_filter);
                }

                if (__workflow_vectorizedSearchFields != null)
                {
                    serviceProviderParameters["vectorizedSearchFields"] = ExpressionConverter.ConvertO(__workflow_vectorizedSearchFields);
                }

                if (__workflow_selectFields != null)
                {
                    serviceProviderParameters["selectFields"] = ExpressionConverter.ConvertO(__workflow_selectFields);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "integratedVectorSearch", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["document"] = ExpressionConverter.ConvertO(__workflow_document);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["documents"] = ExpressionConverter.ConvertO(__workflow_documents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IOutputWorkflowAction<JToken> MergeDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["document"] = ExpressionConverter.ConvertO(__workflow_document);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "mergeDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput> KnowledgeAgentRetrieval(Expression<Func<string>> indexName, Expression<Func<string>> agentName, Expression<Func<KnowledgeAgentRetrievalInputAgentMessageContentTypeItem[]>> agentMessageContent)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_agentMessageContent = WorkflowExpression.Compile(agentMessageContent, nameof(agentMessageContent), required: true);
            return new DeferredBodyAction<KnowledgeAgentRetrievalOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["agentName"] = ExpressionConverter.ConvertO(__workflow_agentName);
                serviceProviderParameters["agentMessageContent"] = ExpressionConverter.ConvertO(__workflow_agentMessageContent);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "knowledgeAgentRetrieval", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<KnowledgeAgentRetrievalOutput>(serviceProviderInput);
            });
        }
    }

    public class VectorSearchInputSearchVectorType
    {
        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("vector", DefaultValueHandling = DefaultValueHandling.Include)]
        public double[] Vector { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

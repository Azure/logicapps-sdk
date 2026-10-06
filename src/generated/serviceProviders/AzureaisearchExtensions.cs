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
        [WorkflowExpressionFactory(nameof(__BuildIndexDocuments))]
        public IOutputWorkflowAction<JToken> IndexDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documents)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildIndexDocuments(WorkflowExpression<string> indexName, WorkflowExpression<JToken[]> documents)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(documents, nameof(documents), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildIndexDocument))]
        public IOutputWorkflowAction<JToken> IndexDocument([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<object> document)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildIndexDocument(WorkflowExpression<string> indexName, WorkflowExpression<object> document)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(document, nameof(document), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildVectorSearch))]
        public IBodyWorkflowAction<JToken> VectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<VectorSearchInputSearchVectorType> searchVector, [WorkflowExpression] Func<int> kNearestNeighbors, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<VectorSearchInputSearchModeType> searchMode = null, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildVectorSearch(WorkflowExpression<string> indexName, WorkflowExpression<VectorSearchInputSearchVectorType> searchVector, WorkflowExpression<int> kNearestNeighbors, WorkflowExpression<string> search = null, WorkflowExpression<VectorSearchInputSearchModeType> searchMode = null, WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(searchVector, nameof(searchVector), required: true);
            WorkflowExpression.Validate(kNearestNeighbors, nameof(kNearestNeighbors), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(searchMode, nameof(searchMode), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildIntegratedVectorSearch))]
        public IBodyWorkflowAction<JToken> IntegratedVectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> searchText, [WorkflowExpression] Func<int> kNearestNeighbors, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<JToken[]> vectorizedSearchFields = null, [WorkflowExpression] Func<JToken[]> selectFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildIntegratedVectorSearch(WorkflowExpression<string> indexName, WorkflowExpression<string> searchText, WorkflowExpression<int> kNearestNeighbors, WorkflowExpression<string> search = null, WorkflowExpression<string> filter = null, WorkflowExpression<JToken[]> vectorizedSearchFields = null, WorkflowExpression<JToken[]> selectFields = null)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(searchText, nameof(searchText), required: true);
            WorkflowExpression.Validate(kNearestNeighbors, nameof(kNearestNeighbors), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(vectorizedSearchFields, nameof(vectorizedSearchFields), required: false);
            WorkflowExpression.Validate(selectFields, nameof(selectFields), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IOutputWorkflowAction<JToken> DeleteDocument([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<object> document)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeleteDocument(WorkflowExpression<string> indexName, WorkflowExpression<object> document)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(document, nameof(document), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocuments))]
        public IOutputWorkflowAction<JToken> DeleteDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documents)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeleteDocuments(WorkflowExpression<string> indexName, WorkflowExpression<JToken[]> documents)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(documents, nameof(documents), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildMergeDocument))]
        public IOutputWorkflowAction<JToken> MergeDocument([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<object> document)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildMergeDocument(WorkflowExpression<string> indexName, WorkflowExpression<object> document)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(document, nameof(document), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildKnowledgeAgentRetrieval))]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput> KnowledgeAgentRetrieval([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> agentName, [WorkflowExpression] Func<KnowledgeAgentRetrievalInputAgentMessageContentTypeItem[]> agentMessageContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput> __BuildKnowledgeAgentRetrieval(WorkflowExpression<string> indexName, WorkflowExpression<string> agentName, WorkflowExpression<KnowledgeAgentRetrievalInputAgentMessageContentTypeItem[]> agentMessageContent)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(agentName, nameof(agentName), required: true);
            WorkflowExpression.Validate(agentMessageContent, nameof(agentMessageContent), required: true);
            return new DeferredBodyAction<KnowledgeAgentRetrievalOutput>(() =>
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
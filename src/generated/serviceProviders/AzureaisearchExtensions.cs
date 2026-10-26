//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azureaisearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IWorkflowAction<IndexDocumentsActionConfiguration> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: true);
            return new DeferredWorkflowAction<IndexDocumentsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["documents"] = ExpressionConverter.ConvertO(__workflow_documents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<IndexDocumentsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IWorkflowAction<IndexDocumentActionConfiguration> IndexDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredWorkflowAction<IndexDocumentActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["document"] = ExpressionConverter.ConvertO(__workflow_document);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "indexDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<IndexDocumentActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken, VectorSearchActionConfiguration> VectorSearch(Expression<Func<string>> indexName, Expression<Func<VectorSearchInputSearchVectorType>> searchVector, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<VectorSearchInputSearchModeType>> searchMode = null, Expression<Func<string>> filter = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_searchVector = WorkflowExpression.Compile(searchVector, nameof(searchVector), required: true);
            var __workflow_kNearestNeighbors = WorkflowExpression.Compile(kNearestNeighbors, nameof(kNearestNeighbors), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_searchMode = WorkflowExpression.Compile(searchMode, nameof(searchMode), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<JToken, VectorSearchActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<JToken, VectorSearchActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken, IntegratedVectorSearchActionConfiguration> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> searchText, Expression<Func<int>> kNearestNeighbors, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<JToken[]>> vectorizedSearchFields = null, Expression<Func<JToken[]>> selectFields = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: true);
            var __workflow_kNearestNeighbors = WorkflowExpression.Compile(kNearestNeighbors, nameof(kNearestNeighbors), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_vectorizedSearchFields = WorkflowExpression.Compile(vectorizedSearchFields, nameof(vectorizedSearchFields), required: false);
            var __workflow_selectFields = WorkflowExpression.Compile(selectFields, nameof(selectFields), required: false);
            return new DeferredBodyAction<JToken, IntegratedVectorSearchActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<JToken, IntegratedVectorSearchActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IWorkflowAction<DeleteDocumentActionConfiguration> DeleteDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredWorkflowAction<DeleteDocumentActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["document"] = ExpressionConverter.ConvertO(__workflow_document);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteDocumentActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IWorkflowAction<DeleteDocumentsActionConfiguration> DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documents)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: true);
            return new DeferredWorkflowAction<DeleteDocumentsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["documents"] = ExpressionConverter.ConvertO(__workflow_documents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "deleteDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteDocumentsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IWorkflowAction<MergeDocumentActionConfiguration> MergeDocument(Expression<Func<string>> indexName, Expression<Func<object>> document)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredWorkflowAction<MergeDocumentActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["indexName"] = ExpressionConverter.ConvertO(__workflow_indexName);
                serviceProviderParameters["document"] = ExpressionConverter.ConvertO(__workflow_document);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureaisearch", operationId: "mergeDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<MergeDocumentActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<KnowledgeAgentRetrievalOutput, KnowledgeAgentRetrievalActionConfiguration> KnowledgeAgentRetrieval(Expression<Func<string>> indexName, Expression<Func<string>> agentName, Expression<Func<KnowledgeAgentRetrievalInputAgentMessageContentTypeItem[]>> agentMessageContent)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_agentMessageContent = WorkflowExpression.Compile(agentMessageContent, nameof(agentMessageContent), required: true);
            return new DeferredBodyAction<KnowledgeAgentRetrievalOutput, KnowledgeAgentRetrievalActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<KnowledgeAgentRetrievalOutput, KnowledgeAgentRetrievalActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class IndexDocumentsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class IndexDocumentActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class VectorSearchActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class IntegratedVectorSearchActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeleteDocumentActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeleteDocumentsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class MergeDocumentActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class KnowledgeAgentRetrievalActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
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
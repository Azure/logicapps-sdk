//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearch
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> IndexDocument(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/indexDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                var documentToIndex = new JObject();
                var documentToIndexpropCount = 0;
                if (documentToIndexpropCount > 0)
                {
                    callPayload.Body = documentToIndex;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentToIndex = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentToIndex = WorkflowExpression.Compile(documentToIndex, nameof(documentToIndex), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/indexDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentToIndex);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetIndexesSchema(Expression<Func<bool>> onlyIntegratedVectorIndexes = null)
        {
            var __workflow_onlyIntegratedVectorIndexes = WorkflowExpression.Compile(onlyIntegratedVectorIndexes, nameof(onlyIntegratedVectorIndexes), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/indexesSchema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["onlyIntegratedVectorIndexes"] = Convert.ToString(true);
                if (__workflow_onlyIntegratedVectorIndexes != null)
                    callPayload.Queries["onlyIntegratedVectorIndexes"] = ExpressionConverter.Convert(__workflow_onlyIntegratedVectorIndexes);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetIndexStatistics(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/indexStatistics/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> integratedVectorSearchRequestsearchText = null, Expression<Func<string[]>> integratedVectorSearchRequestvectorizedSearchFields = null, Expression<Func<string[]>> integratedVectorSearchRequestselectFields = null, Expression<Func<string>> integratedVectorSearchRequestfilterCondition = null, Expression<Func<string>> integratedVectorSearchRequestsessionId = null, Expression<Func<int>> integratedVectorSearchRequestnearestNeighbors = null, Expression<Func<int>> integratedVectorSearchRequesttopSearches = null, Expression<Func<int>> integratedVectorSearchRequestskipSearches = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_integratedVectorSearchRequestsearchText = WorkflowExpression.Compile(integratedVectorSearchRequestsearchText, nameof(integratedVectorSearchRequestsearchText), required: false);
            var __workflow_integratedVectorSearchRequestvectorizedSearchFields = WorkflowExpression.Compile(integratedVectorSearchRequestvectorizedSearchFields, nameof(integratedVectorSearchRequestvectorizedSearchFields), required: false);
            var __workflow_integratedVectorSearchRequestselectFields = WorkflowExpression.Compile(integratedVectorSearchRequestselectFields, nameof(integratedVectorSearchRequestselectFields), required: false);
            var __workflow_integratedVectorSearchRequestfilterCondition = WorkflowExpression.Compile(integratedVectorSearchRequestfilterCondition, nameof(integratedVectorSearchRequestfilterCondition), required: false);
            var __workflow_integratedVectorSearchRequestsessionId = WorkflowExpression.Compile(integratedVectorSearchRequestsessionId, nameof(integratedVectorSearchRequestsessionId), required: false);
            var __workflow_integratedVectorSearchRequestnearestNeighbors = WorkflowExpression.Compile(integratedVectorSearchRequestnearestNeighbors, nameof(integratedVectorSearchRequestnearestNeighbors), required: false);
            var __workflow_integratedVectorSearchRequesttopSearches = WorkflowExpression.Compile(integratedVectorSearchRequesttopSearches, nameof(integratedVectorSearchRequesttopSearches), required: false);
            var __workflow_integratedVectorSearchRequestskipSearches = WorkflowExpression.Compile(integratedVectorSearchRequestskipSearches, nameof(integratedVectorSearchRequestskipSearches), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integratedVectorSearch/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var integratedVectorSearchRequest = new JObject();
                var integratedVectorSearchRequestpropCount = 0;
                if (__workflow_integratedVectorSearchRequestsearchText != null)
                {
                    integratedVectorSearchRequest["searchText"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestsearchText);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequestvectorizedSearchFields != null)
                {
                    integratedVectorSearchRequest["vectorizedSearchFields"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestvectorizedSearchFields);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequestselectFields != null)
                {
                    integratedVectorSearchRequest["selectFields"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestselectFields);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequestfilterCondition != null)
                {
                    integratedVectorSearchRequest["filterCondition"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestfilterCondition);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequestsessionId != null)
                {
                    integratedVectorSearchRequest["sessionId"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestsessionId);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequestnearestNeighbors != null)
                {
                    integratedVectorSearchRequest["nearestNeighbors"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestnearestNeighbors);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequesttopSearches != null)
                {
                    integratedVectorSearchRequest["top"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequesttopSearches);
                    integratedVectorSearchRequestpropCount++;
                }

                if (__workflow_integratedVectorSearchRequestskipSearches != null)
                {
                    integratedVectorSearchRequest["skipSearches"] = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequestskipSearches);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestpropCount > 0)
                {
                    callPayload.Body = integratedVectorSearchRequest;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> SemanticHybridSearch(Expression<Func<string>> indexName, Expression<Func<string>> semanticHybridSearchRequestsearchText = null, Expression<Func<string[]>> semanticHybridSearchRequestvectorizedSearchFields = null, Expression<Func<string>> semanticHybridSearchRequestsemanticConfiguration = null, Expression<Func<string[]>> semanticHybridSearchRequestselectFields = null, Expression<Func<string>> semanticHybridSearchRequestfilterCondition = null, Expression<Func<string>> semanticHybridSearchRequestsessionId = null, Expression<Func<int>> semanticHybridSearchRequestnearestNeighbors = null, Expression<Func<int>> semanticHybridSearchRequesttopSearches = null, Expression<Func<int>> semanticHybridSearchRequestskipSearches = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_semanticHybridSearchRequestsearchText = WorkflowExpression.Compile(semanticHybridSearchRequestsearchText, nameof(semanticHybridSearchRequestsearchText), required: false);
            var __workflow_semanticHybridSearchRequestvectorizedSearchFields = WorkflowExpression.Compile(semanticHybridSearchRequestvectorizedSearchFields, nameof(semanticHybridSearchRequestvectorizedSearchFields), required: false);
            var __workflow_semanticHybridSearchRequestsemanticConfiguration = WorkflowExpression.Compile(semanticHybridSearchRequestsemanticConfiguration, nameof(semanticHybridSearchRequestsemanticConfiguration), required: false);
            var __workflow_semanticHybridSearchRequestselectFields = WorkflowExpression.Compile(semanticHybridSearchRequestselectFields, nameof(semanticHybridSearchRequestselectFields), required: false);
            var __workflow_semanticHybridSearchRequestfilterCondition = WorkflowExpression.Compile(semanticHybridSearchRequestfilterCondition, nameof(semanticHybridSearchRequestfilterCondition), required: false);
            var __workflow_semanticHybridSearchRequestsessionId = WorkflowExpression.Compile(semanticHybridSearchRequestsessionId, nameof(semanticHybridSearchRequestsessionId), required: false);
            var __workflow_semanticHybridSearchRequestnearestNeighbors = WorkflowExpression.Compile(semanticHybridSearchRequestnearestNeighbors, nameof(semanticHybridSearchRequestnearestNeighbors), required: false);
            var __workflow_semanticHybridSearchRequesttopSearches = WorkflowExpression.Compile(semanticHybridSearchRequesttopSearches, nameof(semanticHybridSearchRequesttopSearches), required: false);
            var __workflow_semanticHybridSearchRequestskipSearches = WorkflowExpression.Compile(semanticHybridSearchRequestskipSearches, nameof(semanticHybridSearchRequestskipSearches), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/semanticHybridSearch/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var semanticHybridSearchRequest = new JObject();
                var semanticHybridSearchRequestpropCount = 0;
                if (__workflow_semanticHybridSearchRequestsearchText != null)
                {
                    semanticHybridSearchRequest["searchText"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestsearchText);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestvectorizedSearchFields != null)
                {
                    semanticHybridSearchRequest["vectorizedSearchFields"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestvectorizedSearchFields);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestsemanticConfiguration != null)
                {
                    semanticHybridSearchRequest["semanticConfiguration"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestsemanticConfiguration);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestselectFields != null)
                {
                    semanticHybridSearchRequest["selectFields"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestselectFields);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestfilterCondition != null)
                {
                    semanticHybridSearchRequest["filterCondition"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestfilterCondition);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestsessionId != null)
                {
                    semanticHybridSearchRequest["sessionId"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestsessionId);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestnearestNeighbors != null)
                {
                    semanticHybridSearchRequest["nearestNeighbors"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestnearestNeighbors);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequesttopSearches != null)
                {
                    semanticHybridSearchRequest["top"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequesttopSearches);
                    semanticHybridSearchRequestpropCount++;
                }

                if (__workflow_semanticHybridSearchRequestskipSearches != null)
                {
                    semanticHybridSearchRequest["skipSearches"] = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequestskipSearches);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestpropCount > 0)
                {
                    callPayload.Body = semanticHybridSearchRequest;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                var documentToDelete = new JObject();
                var documentToDeletepropCount = 0;
                if (documentToDeletepropCount > 0)
                {
                    callPayload.Body = documentToDelete;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentsToDelete = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentsToDelete = WorkflowExpression.Compile(documentsToDelete, nameof(documentsToDelete), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentsToDelete);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MergeDocument(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mergeDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                var documentToMerge = new JObject();
                var documentToMergepropCount = 0;
                if (documentToMergepropCount > 0)
                {
                    callPayload.Body = documentToMerge;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> VectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> vectorFieldsName, Expression<Func<int>> nearestNeighbors, Expression<Func<double[]>> vectorFieldsValue = null, Expression<Func<string>> searchQuery = null, Expression<Func<searchModeInput>> searchMode = null, Expression<Func<string>> filterCondition = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_vectorFieldsName = WorkflowExpression.Compile(vectorFieldsName, nameof(vectorFieldsName), required: true);
            var __workflow_nearestNeighbors = WorkflowExpression.Compile(nearestNeighbors, nameof(nearestNeighbors), required: true);
            var __workflow_vectorFieldsValue = WorkflowExpression.Compile(vectorFieldsValue, nameof(vectorFieldsValue), required: false);
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: false);
            var __workflow_searchMode = WorkflowExpression.Compile(searchMode, nameof(searchMode), required: false);
            var __workflow_filterCondition = WorkflowExpression.Compile(filterCondition, nameof(filterCondition), required: false);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/vectorSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Queries["vectorFieldsName"] = ExpressionConverter.Convert(__workflow_vectorFieldsName);
                callPayload.Queries["nearestNeighbors"] = ExpressionConverter.Convert(__workflow_nearestNeighbors);
                if (__workflow_searchQuery != null)
                    callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(__workflow_searchQuery);
                if (__workflow_searchMode != null)
                    callPayload.Queries["searchMode"] = ExpressionConverter.Convert(__workflow_searchMode);
                if (__workflow_filterCondition != null)
                    callPayload.Queries["filterCondition"] = ExpressionConverter.Convert(__workflow_filterCondition);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_vectorFieldsValue);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }
    }

    public class AzureaisearchTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchModeInput
    {
        Any,
        All
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearch;

    public partial class WorkflowManagedActions
    {
        public AzureaisearchActions Azureaisearch(string connectionId) => new AzureaisearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureaisearchTriggers Azureaisearch(string connectionId) => new AzureaisearchTriggers(connectionId);
    }
}

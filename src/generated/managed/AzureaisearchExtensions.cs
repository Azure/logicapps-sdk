//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearch
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IndexDocument(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentToIndex = null)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            var __workflow_documentToIndex = documentToIndex == null ? null : WorkflowExpression.Compile(documentToIndex);
            WorkflowExpression.Validate(__workflow_documentToIndex, nameof(documentToIndex), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken[]> GetIndexesSchema(Expression<Func<bool>> onlyIntegratedVectorIndexes = null)
        {
            var __workflow_onlyIntegratedVectorIndexes = onlyIntegratedVectorIndexes == null ? null : WorkflowExpression.Compile(onlyIntegratedVectorIndexes);
            WorkflowExpression.Validate(__workflow_onlyIntegratedVectorIndexes, nameof(onlyIntegratedVectorIndexes), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
        public IBodyWorkflowAction<JToken> GetIndexStatistics(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/indexStatistics/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_indexName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> integratedVectorSearchRequestsearchText = null, Expression<Func<string[]>> integratedVectorSearchRequestvectorizedSearchFields = null, Expression<Func<string[]>> integratedVectorSearchRequestselectFields = null, Expression<Func<string>> integratedVectorSearchRequestfilterCondition = null, Expression<Func<string>> integratedVectorSearchRequestsessionId = null, Expression<Func<int>> integratedVectorSearchRequestnearestNeighbors = null, Expression<Func<int>> integratedVectorSearchRequesttopSearches = null, Expression<Func<int>> integratedVectorSearchRequestskipSearches = null)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            var __workflow_integratedVectorSearchRequestsearchText = integratedVectorSearchRequestsearchText == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestsearchText);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestsearchText, nameof(integratedVectorSearchRequestsearchText), required: false);
            var __workflow_integratedVectorSearchRequestvectorizedSearchFields = integratedVectorSearchRequestvectorizedSearchFields == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestvectorizedSearchFields);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestvectorizedSearchFields, nameof(integratedVectorSearchRequestvectorizedSearchFields), required: false);
            var __workflow_integratedVectorSearchRequestselectFields = integratedVectorSearchRequestselectFields == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestselectFields);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestselectFields, nameof(integratedVectorSearchRequestselectFields), required: false);
            var __workflow_integratedVectorSearchRequestfilterCondition = integratedVectorSearchRequestfilterCondition == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestfilterCondition);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestfilterCondition, nameof(integratedVectorSearchRequestfilterCondition), required: false);
            var __workflow_integratedVectorSearchRequestsessionId = integratedVectorSearchRequestsessionId == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestsessionId);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestsessionId, nameof(integratedVectorSearchRequestsessionId), required: false);
            var __workflow_integratedVectorSearchRequestnearestNeighbors = integratedVectorSearchRequestnearestNeighbors == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestnearestNeighbors);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestnearestNeighbors, nameof(integratedVectorSearchRequestnearestNeighbors), required: false);
            var __workflow_integratedVectorSearchRequesttopSearches = integratedVectorSearchRequesttopSearches == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequesttopSearches);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequesttopSearches, nameof(integratedVectorSearchRequesttopSearches), required: false);
            var __workflow_integratedVectorSearchRequestskipSearches = integratedVectorSearchRequestskipSearches == null ? null : WorkflowExpression.Compile(integratedVectorSearchRequestskipSearches);
            WorkflowExpression.Validate(__workflow_integratedVectorSearchRequestskipSearches, nameof(integratedVectorSearchRequestskipSearches), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integratedVectorSearch/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_indexName, 1));
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
        public IBodyWorkflowAction<JToken[]> SemanticHybridSearch(Expression<Func<string>> indexName, Expression<Func<string>> semanticHybridSearchRequestsearchText = null, Expression<Func<string[]>> semanticHybridSearchRequestvectorizedSearchFields = null, Expression<Func<string>> semanticHybridSearchRequestsemanticConfiguration = null, Expression<Func<string[]>> semanticHybridSearchRequestselectFields = null, Expression<Func<string>> semanticHybridSearchRequestfilterCondition = null, Expression<Func<string>> semanticHybridSearchRequestsessionId = null, Expression<Func<int>> semanticHybridSearchRequestnearestNeighbors = null, Expression<Func<int>> semanticHybridSearchRequesttopSearches = null, Expression<Func<int>> semanticHybridSearchRequestskipSearches = null)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            var __workflow_semanticHybridSearchRequestsearchText = semanticHybridSearchRequestsearchText == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestsearchText);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestsearchText, nameof(semanticHybridSearchRequestsearchText), required: false);
            var __workflow_semanticHybridSearchRequestvectorizedSearchFields = semanticHybridSearchRequestvectorizedSearchFields == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestvectorizedSearchFields);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestvectorizedSearchFields, nameof(semanticHybridSearchRequestvectorizedSearchFields), required: false);
            var __workflow_semanticHybridSearchRequestsemanticConfiguration = semanticHybridSearchRequestsemanticConfiguration == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestsemanticConfiguration);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestsemanticConfiguration, nameof(semanticHybridSearchRequestsemanticConfiguration), required: false);
            var __workflow_semanticHybridSearchRequestselectFields = semanticHybridSearchRequestselectFields == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestselectFields);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestselectFields, nameof(semanticHybridSearchRequestselectFields), required: false);
            var __workflow_semanticHybridSearchRequestfilterCondition = semanticHybridSearchRequestfilterCondition == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestfilterCondition);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestfilterCondition, nameof(semanticHybridSearchRequestfilterCondition), required: false);
            var __workflow_semanticHybridSearchRequestsessionId = semanticHybridSearchRequestsessionId == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestsessionId);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestsessionId, nameof(semanticHybridSearchRequestsessionId), required: false);
            var __workflow_semanticHybridSearchRequestnearestNeighbors = semanticHybridSearchRequestnearestNeighbors == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestnearestNeighbors);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestnearestNeighbors, nameof(semanticHybridSearchRequestnearestNeighbors), required: false);
            var __workflow_semanticHybridSearchRequesttopSearches = semanticHybridSearchRequesttopSearches == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequesttopSearches);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequesttopSearches, nameof(semanticHybridSearchRequesttopSearches), required: false);
            var __workflow_semanticHybridSearchRequestskipSearches = semanticHybridSearchRequestskipSearches == null ? null : WorkflowExpression.Compile(semanticHybridSearchRequestskipSearches);
            WorkflowExpression.Validate(__workflow_semanticHybridSearchRequestskipSearches, nameof(semanticHybridSearchRequestskipSearches), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/semanticHybridSearch/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_indexName, 1));
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
        public IWorkflowAction DeleteDocument(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentsToDelete = null)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            var __workflow_documentsToDelete = documentsToDelete == null ? null : WorkflowExpression.Compile(documentsToDelete);
            WorkflowExpression.Validate(__workflow_documentsToDelete, nameof(documentsToDelete), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction MergeDocument(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<string[]> VectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> vectorFieldsName, Expression<Func<int>> nearestNeighbors, Expression<Func<double[]>> vectorFieldsValue = null, Expression<Func<string>> searchQuery = null, Expression<Func<searchModeInput>> searchMode = null, Expression<Func<string>> filterCondition = null)
        {
            var __workflow_indexName = indexName == null ? null : WorkflowExpression.Compile(indexName);
            WorkflowExpression.Validate(__workflow_indexName, nameof(indexName), required: true);
            var __workflow_vectorFieldsName = vectorFieldsName == null ? null : WorkflowExpression.Compile(vectorFieldsName);
            WorkflowExpression.Validate(__workflow_vectorFieldsName, nameof(vectorFieldsName), required: true);
            var __workflow_nearestNeighbors = nearestNeighbors == null ? null : WorkflowExpression.Compile(nearestNeighbors);
            WorkflowExpression.Validate(__workflow_nearestNeighbors, nameof(nearestNeighbors), required: true);
            var __workflow_vectorFieldsValue = vectorFieldsValue == null ? null : WorkflowExpression.Compile(vectorFieldsValue);
            WorkflowExpression.Validate(__workflow_vectorFieldsValue, nameof(vectorFieldsValue), required: false);
            var __workflow_searchQuery = searchQuery == null ? null : WorkflowExpression.Compile(searchQuery);
            WorkflowExpression.Validate(__workflow_searchQuery, nameof(searchQuery), required: false);
            var __workflow_searchMode = searchMode == null ? null : WorkflowExpression.Compile(searchMode);
            WorkflowExpression.Validate(__workflow_searchMode, nameof(searchMode), required: false);
            var __workflow_filterCondition = filterCondition == null ? null : WorkflowExpression.Compile(filterCondition);
            WorkflowExpression.Validate(__workflow_filterCondition, nameof(filterCondition), required: false);
            return new DeferredBodyAction<string[]>(() =>
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

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IndexDocument(Expression<Func<string>> indexName)
        {
            var apiCallPath = "/indexDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
            var documentToIndex = new JObject();
            var documentToIndexpropCount = 0;
            if (documentToIndexpropCount > 0)
            {
                callPayload.Body = documentToIndex;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentToIndex = null)
        {
            var apiCallPath = "/indexDocuments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
            callPayload.Body = ExpressionConverter.ConvertO(documentToIndex);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> GetIndexesSchema(Expression<Func<bool>> onlyIntegratedVectorIndexes = null)
        {
            var apiCallPath = "/indexesSchema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["onlyIntegratedVectorIndexes"] = Convert.ToString(true);
            if (onlyIntegratedVectorIndexes != null)
                callPayload.Queries["onlyIntegratedVectorIndexes"] = ExpressionConverter.Convert(onlyIntegratedVectorIndexes);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> GetIndexStatistics(Expression<Func<string>> indexName)
        {
            var apiCallPath = String.Format("/indexStatistics/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> integratedVectorSearchRequestsearchText = null, Expression<Func<string[]>> integratedVectorSearchRequestvectorizedSearchFields = null, Expression<Func<string[]>> integratedVectorSearchRequestselectFields = null, Expression<Func<string>> integratedVectorSearchRequestfilterCondition = null, Expression<Func<string>> integratedVectorSearchRequestsessionId = null, Expression<Func<int>> integratedVectorSearchRequestnearestNeighbors = null, Expression<Func<int>> integratedVectorSearchRequesttopSearches = null, Expression<Func<int>> integratedVectorSearchRequestskipSearches = null)
        {
            var apiCallPath = String.Format("/integratedVectorSearch/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var integratedVectorSearchRequest = new JObject();
            var integratedVectorSearchRequestpropCount = 0;
            if (integratedVectorSearchRequestsearchText != null)
            {
                integratedVectorSearchRequest["searchText"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestsearchText);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestvectorizedSearchFields != null)
            {
                integratedVectorSearchRequest["vectorizedSearchFields"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestvectorizedSearchFields);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestselectFields != null)
            {
                integratedVectorSearchRequest["selectFields"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestselectFields);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestfilterCondition != null)
            {
                integratedVectorSearchRequest["filterCondition"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestfilterCondition);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestsessionId != null)
            {
                integratedVectorSearchRequest["sessionId"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestsessionId);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestnearestNeighbors != null)
            {
                integratedVectorSearchRequest["nearestNeighbors"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestnearestNeighbors);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequesttopSearches != null)
            {
                integratedVectorSearchRequest["top"] = ExpressionConverter.ConvertO(integratedVectorSearchRequesttopSearches);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestskipSearches != null)
            {
                integratedVectorSearchRequest["skipSearches"] = ExpressionConverter.ConvertO(integratedVectorSearchRequestskipSearches);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestpropCount > 0)
            {
                callPayload.Body = integratedVectorSearchRequest;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> SemanticHybridSearch(Expression<Func<string>> indexName, Expression<Func<string>> semanticHybridSearchRequestsearchText = null, Expression<Func<string[]>> semanticHybridSearchRequestvectorizedSearchFields = null, Expression<Func<string>> semanticHybridSearchRequestsemanticConfiguration = null, Expression<Func<string[]>> semanticHybridSearchRequestselectFields = null, Expression<Func<string>> semanticHybridSearchRequestfilterCondition = null, Expression<Func<string>> semanticHybridSearchRequestsessionId = null, Expression<Func<int>> semanticHybridSearchRequestnearestNeighbors = null, Expression<Func<int>> semanticHybridSearchRequesttopSearches = null, Expression<Func<int>> semanticHybridSearchRequestskipSearches = null)
        {
            var apiCallPath = String.Format("/semanticHybridSearch/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var semanticHybridSearchRequest = new JObject();
            var semanticHybridSearchRequestpropCount = 0;
            if (semanticHybridSearchRequestsearchText != null)
            {
                semanticHybridSearchRequest["searchText"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestsearchText);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestvectorizedSearchFields != null)
            {
                semanticHybridSearchRequest["vectorizedSearchFields"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestvectorizedSearchFields);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestsemanticConfiguration != null)
            {
                semanticHybridSearchRequest["semanticConfiguration"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestsemanticConfiguration);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestselectFields != null)
            {
                semanticHybridSearchRequest["selectFields"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestselectFields);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestfilterCondition != null)
            {
                semanticHybridSearchRequest["filterCondition"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestfilterCondition);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestsessionId != null)
            {
                semanticHybridSearchRequest["sessionId"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestsessionId);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestnearestNeighbors != null)
            {
                semanticHybridSearchRequest["nearestNeighbors"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestnearestNeighbors);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequesttopSearches != null)
            {
                semanticHybridSearchRequest["top"] = ExpressionConverter.ConvertO(semanticHybridSearchRequesttopSearches);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestskipSearches != null)
            {
                semanticHybridSearchRequest["skipSearches"] = ExpressionConverter.ConvertO(semanticHybridSearchRequestskipSearches);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestpropCount > 0)
            {
                callPayload.Body = semanticHybridSearchRequest;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> indexName)
        {
            var apiCallPath = "/deleteDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
            var documentToDelete = new JObject();
            var documentToDeletepropCount = 0;
            if (documentToDeletepropCount > 0)
            {
                callPayload.Body = documentToDelete;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentsToDelete = null)
        {
            var apiCallPath = "/deleteDocuments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
            callPayload.Body = ExpressionConverter.ConvertO(documentsToDelete);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction MergeDocument(Expression<Func<string>> indexName)
        {
            var apiCallPath = "/mergeDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
            var documentToMerge = new JObject();
            var documentToMergepropCount = 0;
            if (documentToMergepropCount > 0)
            {
                callPayload.Body = documentToMerge;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<string[]> VectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> vectorFieldsName, Expression<Func<int>> nearestNeighbors, Expression<Func<double[]>> vectorFieldsValue = null, Expression<Func<string>> searchQuery = null, Expression<Func<searchModeInput>> searchMode = null, Expression<Func<string>> filterCondition = null)
        {
            var apiCallPath = "/vectorSearch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
            callPayload.Queries["vectorFieldsName"] = ExpressionConverter.Convert(vectorFieldsName);
            callPayload.Queries["nearestNeighbors"] = ExpressionConverter.Convert(nearestNeighbors);
            if (searchQuery != null)
                callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(searchQuery);
            if (searchMode != null)
                callPayload.Queries["searchMode"] = ExpressionConverter.Convert(searchMode);
            if (filterCondition != null)
                callPayload.Queries["filterCondition"] = ExpressionConverter.Convert(filterCondition);
            callPayload.Body = ExpressionConverter.ConvertO(vectorFieldsValue);
            return new ApiConnectionAction<string[]>(callPayload);
        }
    }

    public class AzureaisearchTriggers([ConnectionName] string connectionId)
    {
    }

    public enum searchModeInput
    {
        Any,
        All
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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
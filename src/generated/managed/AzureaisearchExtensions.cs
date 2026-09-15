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
            callPayload.Queries["indexName"] = CSharpExpressionConverter.ConvertO(indexName);
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
            callPayload.Queries["indexName"] = CSharpExpressionConverter.ConvertO(indexName);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(documentToIndex);
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
                callPayload.Queries["onlyIntegratedVectorIndexes"] = CSharpExpressionConverter.ConvertO(onlyIntegratedVectorIndexes);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> GetIndexStatistics(Expression<Func<string>> indexName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/indexStatistics/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> integratedVectorSearchRequestsearchText = null, Expression<Func<string[]>> integratedVectorSearchRequestvectorizedSearchFields = null, Expression<Func<string[]>> integratedVectorSearchRequestselectFields = null, Expression<Func<string>> integratedVectorSearchRequestfilterCondition = null, Expression<Func<string>> integratedVectorSearchRequestsessionId = null, Expression<Func<int>> integratedVectorSearchRequestnearestNeighbors = null, Expression<Func<int>> integratedVectorSearchRequesttopSearches = null, Expression<Func<int>> integratedVectorSearchRequestskipSearches = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/integratedVectorSearch/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var integratedVectorSearchRequest = new JObject();
            var integratedVectorSearchRequestpropCount = 0;
            if (integratedVectorSearchRequestsearchText != null)
            {
                integratedVectorSearchRequest["searchText"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestsearchText);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestvectorizedSearchFields != null)
            {
                integratedVectorSearchRequest["vectorizedSearchFields"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestvectorizedSearchFields);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestselectFields != null)
            {
                integratedVectorSearchRequest["selectFields"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestselectFields);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestfilterCondition != null)
            {
                integratedVectorSearchRequest["filterCondition"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestfilterCondition);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestsessionId != null)
            {
                integratedVectorSearchRequest["sessionId"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestsessionId);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestnearestNeighbors != null)
            {
                integratedVectorSearchRequest["nearestNeighbors"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestnearestNeighbors);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequesttopSearches != null)
            {
                integratedVectorSearchRequest["top"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequesttopSearches);
                integratedVectorSearchRequestpropCount++;
            }

            if (integratedVectorSearchRequestskipSearches != null)
            {
                integratedVectorSearchRequest["skipSearches"] = CSharpExpressionConverter.ConvertToken(integratedVectorSearchRequestskipSearches);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/semanticHybridSearch/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var semanticHybridSearchRequest = new JObject();
            var semanticHybridSearchRequestpropCount = 0;
            if (semanticHybridSearchRequestsearchText != null)
            {
                semanticHybridSearchRequest["searchText"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestsearchText);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestvectorizedSearchFields != null)
            {
                semanticHybridSearchRequest["vectorizedSearchFields"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestvectorizedSearchFields);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestsemanticConfiguration != null)
            {
                semanticHybridSearchRequest["semanticConfiguration"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestsemanticConfiguration);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestselectFields != null)
            {
                semanticHybridSearchRequest["selectFields"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestselectFields);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestfilterCondition != null)
            {
                semanticHybridSearchRequest["filterCondition"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestfilterCondition);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestsessionId != null)
            {
                semanticHybridSearchRequest["sessionId"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestsessionId);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestnearestNeighbors != null)
            {
                semanticHybridSearchRequest["nearestNeighbors"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestnearestNeighbors);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequesttopSearches != null)
            {
                semanticHybridSearchRequest["top"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequesttopSearches);
                semanticHybridSearchRequestpropCount++;
            }

            if (semanticHybridSearchRequestskipSearches != null)
            {
                semanticHybridSearchRequest["skipSearches"] = CSharpExpressionConverter.ConvertToken(semanticHybridSearchRequestskipSearches);
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
            callPayload.Queries["indexName"] = CSharpExpressionConverter.ConvertO(indexName);
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
            callPayload.Queries["indexName"] = CSharpExpressionConverter.ConvertO(indexName);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(documentsToDelete);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction MergeDocument(Expression<Func<string>> indexName)
        {
            var apiCallPath = "/mergeDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indexName"] = CSharpExpressionConverter.ConvertO(indexName);
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
            callPayload.Queries["indexName"] = CSharpExpressionConverter.ConvertO(indexName);
            callPayload.Queries["vectorFieldsName"] = CSharpExpressionConverter.ConvertO(vectorFieldsName);
            callPayload.Queries["nearestNeighbors"] = CSharpExpressionConverter.ConvertO(nearestNeighbors);
            if (searchQuery != null)
                callPayload.Queries["searchQuery"] = CSharpExpressionConverter.ConvertO(searchQuery);
            if (searchMode != null)
                callPayload.Queries["searchMode"] = CSharpExpressionConverter.Convert(searchMode);
            if (filterCondition != null)
                callPayload.Queries["filterCondition"] = CSharpExpressionConverter.ConvertO(filterCondition);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(vectorFieldsValue);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureaisearch
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureaisearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildIndexDocument))]
        public IBodyWorkflowAction<JToken> IndexDocument([WorkflowExpression] Func<string> indexName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildIndexDocument(WorkflowValue<string> indexName)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildIndexDocuments))]
        public IBodyWorkflowAction<JToken> IndexDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documentToIndex = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildIndexDocuments(WorkflowValue<string> indexName, WorkflowValue<JToken[]> documentToIndex = null)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            WorkflowValue.Validate(documentToIndex, nameof(documentToIndex), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/indexDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
                callPayload.Body = ExpressionConverter.ConvertO(documentToIndex);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildGetIndexesSchema))]
        public IBodyWorkflowAction<JToken[]> GetIndexesSchema([WorkflowExpression] Func<bool> onlyIntegratedVectorIndexes = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetIndexesSchema(WorkflowValue<bool> onlyIntegratedVectorIndexes = null)
        {
            WorkflowValue.Validate(onlyIntegratedVectorIndexes, nameof(onlyIntegratedVectorIndexes), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/indexesSchema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["onlyIntegratedVectorIndexes"] = Convert.ToString(true);
                if (onlyIntegratedVectorIndexes != null)
                    callPayload.Queries["onlyIntegratedVectorIndexes"] = ExpressionConverter.Convert(onlyIntegratedVectorIndexes);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildGetIndexStatistics))]
        public IBodyWorkflowAction<JToken> GetIndexStatistics([WorkflowExpression] Func<string> indexName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetIndexStatistics(WorkflowValue<string> indexName)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/indexStatistics/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildIntegratedVectorSearch))]
        public IBodyWorkflowAction<JToken[]> IntegratedVectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> integratedVectorSearchRequestsearchText = null, [WorkflowExpression] Func<string[]> integratedVectorSearchRequestvectorizedSearchFields = null, [WorkflowExpression] Func<string[]> integratedVectorSearchRequestselectFields = null, [WorkflowExpression] Func<string> integratedVectorSearchRequestfilterCondition = null, [WorkflowExpression] Func<string> integratedVectorSearchRequestsessionId = null, [WorkflowExpression] Func<int> integratedVectorSearchRequestnearestNeighbors = null, [WorkflowExpression] Func<int> integratedVectorSearchRequesttopSearches = null, [WorkflowExpression] Func<int> integratedVectorSearchRequestskipSearches = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildIntegratedVectorSearch(WorkflowValue<string> indexName, WorkflowValue<string> integratedVectorSearchRequestsearchText = null, WorkflowValue<string[]> integratedVectorSearchRequestvectorizedSearchFields = null, WorkflowValue<string[]> integratedVectorSearchRequestselectFields = null, WorkflowValue<string> integratedVectorSearchRequestfilterCondition = null, WorkflowValue<string> integratedVectorSearchRequestsessionId = null, WorkflowValue<int> integratedVectorSearchRequestnearestNeighbors = null, WorkflowValue<int> integratedVectorSearchRequesttopSearches = null, WorkflowValue<int> integratedVectorSearchRequestskipSearches = null)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            WorkflowValue.Validate(integratedVectorSearchRequestsearchText, nameof(integratedVectorSearchRequestsearchText), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequestvectorizedSearchFields, nameof(integratedVectorSearchRequestvectorizedSearchFields), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequestselectFields, nameof(integratedVectorSearchRequestselectFields), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequestfilterCondition, nameof(integratedVectorSearchRequestfilterCondition), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequestsessionId, nameof(integratedVectorSearchRequestsessionId), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequestnearestNeighbors, nameof(integratedVectorSearchRequestnearestNeighbors), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequesttopSearches, nameof(integratedVectorSearchRequesttopSearches), required: false);
            WorkflowValue.Validate(integratedVectorSearchRequestskipSearches, nameof(integratedVectorSearchRequestskipSearches), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integratedVectorSearch/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildSemanticHybridSearch))]
        public IBodyWorkflowAction<JToken[]> SemanticHybridSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> semanticHybridSearchRequestsearchText = null, [WorkflowExpression] Func<string[]> semanticHybridSearchRequestvectorizedSearchFields = null, [WorkflowExpression] Func<string> semanticHybridSearchRequestsemanticConfiguration = null, [WorkflowExpression] Func<string[]> semanticHybridSearchRequestselectFields = null, [WorkflowExpression] Func<string> semanticHybridSearchRequestfilterCondition = null, [WorkflowExpression] Func<string> semanticHybridSearchRequestsessionId = null, [WorkflowExpression] Func<int> semanticHybridSearchRequestnearestNeighbors = null, [WorkflowExpression] Func<int> semanticHybridSearchRequesttopSearches = null, [WorkflowExpression] Func<int> semanticHybridSearchRequestskipSearches = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildSemanticHybridSearch(WorkflowValue<string> indexName, WorkflowValue<string> semanticHybridSearchRequestsearchText = null, WorkflowValue<string[]> semanticHybridSearchRequestvectorizedSearchFields = null, WorkflowValue<string> semanticHybridSearchRequestsemanticConfiguration = null, WorkflowValue<string[]> semanticHybridSearchRequestselectFields = null, WorkflowValue<string> semanticHybridSearchRequestfilterCondition = null, WorkflowValue<string> semanticHybridSearchRequestsessionId = null, WorkflowValue<int> semanticHybridSearchRequestnearestNeighbors = null, WorkflowValue<int> semanticHybridSearchRequesttopSearches = null, WorkflowValue<int> semanticHybridSearchRequestskipSearches = null)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            WorkflowValue.Validate(semanticHybridSearchRequestsearchText, nameof(semanticHybridSearchRequestsearchText), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestvectorizedSearchFields, nameof(semanticHybridSearchRequestvectorizedSearchFields), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestsemanticConfiguration, nameof(semanticHybridSearchRequestsemanticConfiguration), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestselectFields, nameof(semanticHybridSearchRequestselectFields), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestfilterCondition, nameof(semanticHybridSearchRequestfilterCondition), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestsessionId, nameof(semanticHybridSearchRequestsessionId), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestnearestNeighbors, nameof(semanticHybridSearchRequestnearestNeighbors), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequesttopSearches, nameof(semanticHybridSearchRequesttopSearches), required: false);
            WorkflowValue.Validate(semanticHybridSearchRequestskipSearches, nameof(semanticHybridSearchRequestskipSearches), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/semanticHybridSearch/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> indexName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowValue<string> indexName)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocuments))]
        public IWorkflowAction DeleteDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documentsToDelete = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocuments(WorkflowValue<string> indexName, WorkflowValue<JToken[]> documentsToDelete = null)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            WorkflowValue.Validate(documentsToDelete, nameof(documentsToDelete), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/deleteDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(indexName);
                callPayload.Body = ExpressionConverter.ConvertO(documentsToDelete);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildMergeDocument))]
        public IWorkflowAction MergeDocument([WorkflowExpression] Func<string> indexName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMergeDocument(WorkflowValue<string> indexName)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        [WorkflowExpressionFactory(nameof(__BuildVectorSearch))]
        public IBodyWorkflowAction<string[]> VectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> vectorFieldsName, [WorkflowExpression] Func<int> nearestNeighbors, [WorkflowExpression] Func<double[]> vectorFieldsValue = null, [WorkflowExpression] Func<string> searchQuery = null, [WorkflowExpression] Func<searchModeInput> searchMode = null, [WorkflowExpression] Func<string> filterCondition = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildVectorSearch(WorkflowValue<string> indexName, WorkflowValue<string> vectorFieldsName, WorkflowValue<int> nearestNeighbors, WorkflowValue<double[]> vectorFieldsValue = null, WorkflowValue<string> searchQuery = null, WorkflowValue<searchModeInput> searchMode = null, WorkflowValue<string> filterCondition = null)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            WorkflowValue.Validate(vectorFieldsName, nameof(vectorFieldsName), required: true);
            WorkflowValue.Validate(nearestNeighbors, nameof(nearestNeighbors), required: true);
            WorkflowValue.Validate(vectorFieldsValue, nameof(vectorFieldsValue), required: false);
            WorkflowValue.Validate(searchQuery, nameof(searchQuery), required: false);
            WorkflowValue.Validate(searchMode, nameof(searchMode), required: false);
            WorkflowValue.Validate(filterCondition, nameof(filterCondition), required: false);
            return new DeferredBodyAction<string[]>(() =>
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
            });
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

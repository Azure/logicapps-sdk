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
        public IBodyWorkflowAction<JToken> IndexDocument([WorkflowExpression] Func<string> indexName)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/indexDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = SourceExpressionConverter.ConvertO(indexName);
                var documentToIndex = new JObject();
                var documentToIndexpropCount = 0;
                if (documentToIndexpropCount > 0)
                {
                    callPayload.Body = documentToIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> IndexDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documentToIndex = null)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            SourceExpression.Validate(documentToIndex, nameof(documentToIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/indexDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = SourceExpressionConverter.ConvertO(indexName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(documentToIndex);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> GetIndexesSchema([WorkflowExpression] Func<bool> onlyIntegratedVectorIndexes = null)
        {
            SourceExpression.Validate(onlyIntegratedVectorIndexes, nameof(onlyIntegratedVectorIndexes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/indexesSchema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["onlyIntegratedVectorIndexes"] = Convert.ToString(true);
                if (onlyIntegratedVectorIndexes != null)
                    callPayload.Queries["onlyIntegratedVectorIndexes"] = SourceExpressionConverter.ConvertO(onlyIntegratedVectorIndexes);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken> GetIndexStatistics([WorkflowExpression] Func<string> indexName)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/indexStatistics/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> IntegratedVectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> integratedVectorSearchRequestsearchText = null, [WorkflowExpression] Func<string[]> integratedVectorSearchRequestvectorizedSearchFields = null, [WorkflowExpression] Func<string[]> integratedVectorSearchRequestselectFields = null, [WorkflowExpression] Func<string> integratedVectorSearchRequestfilterCondition = null, [WorkflowExpression] Func<string> integratedVectorSearchRequestsessionId = null, [WorkflowExpression] Func<int> integratedVectorSearchRequestnearestNeighbors = null, [WorkflowExpression] Func<int> integratedVectorSearchRequesttopSearches = null, [WorkflowExpression] Func<int> integratedVectorSearchRequestskipSearches = null)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            SourceExpression.Validate(integratedVectorSearchRequestsearchText, nameof(integratedVectorSearchRequestsearchText), required: false);
            SourceExpression.Validate(integratedVectorSearchRequestvectorizedSearchFields, nameof(integratedVectorSearchRequestvectorizedSearchFields), required: false);
            SourceExpression.Validate(integratedVectorSearchRequestselectFields, nameof(integratedVectorSearchRequestselectFields), required: false);
            SourceExpression.Validate(integratedVectorSearchRequestfilterCondition, nameof(integratedVectorSearchRequestfilterCondition), required: false);
            SourceExpression.Validate(integratedVectorSearchRequestsessionId, nameof(integratedVectorSearchRequestsessionId), required: false);
            SourceExpression.Validate(integratedVectorSearchRequestnearestNeighbors, nameof(integratedVectorSearchRequestnearestNeighbors), required: false);
            SourceExpression.Validate(integratedVectorSearchRequesttopSearches, nameof(integratedVectorSearchRequesttopSearches), required: false);
            SourceExpression.Validate(integratedVectorSearchRequestskipSearches, nameof(integratedVectorSearchRequestskipSearches), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integratedVectorSearch/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var integratedVectorSearchRequest = new JObject();
                var integratedVectorSearchRequestpropCount = 0;
                if (integratedVectorSearchRequestsearchText != null)
                {
                    integratedVectorSearchRequest["searchText"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestsearchText);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestvectorizedSearchFields != null)
                {
                    integratedVectorSearchRequest["vectorizedSearchFields"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestvectorizedSearchFields);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestselectFields != null)
                {
                    integratedVectorSearchRequest["selectFields"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestselectFields);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestfilterCondition != null)
                {
                    integratedVectorSearchRequest["filterCondition"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestfilterCondition);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestsessionId != null)
                {
                    integratedVectorSearchRequest["sessionId"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestsessionId);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestnearestNeighbors != null)
                {
                    integratedVectorSearchRequest["nearestNeighbors"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestnearestNeighbors);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequesttopSearches != null)
                {
                    integratedVectorSearchRequest["top"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequesttopSearches);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestskipSearches != null)
                {
                    integratedVectorSearchRequest["skipSearches"] = SourceExpressionConverter.ConvertToken(integratedVectorSearchRequestskipSearches);
                    integratedVectorSearchRequestpropCount++;
                }

                if (integratedVectorSearchRequestpropCount > 0)
                {
                    callPayload.Body = integratedVectorSearchRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[]> SemanticHybridSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> semanticHybridSearchRequestsearchText = null, [WorkflowExpression] Func<string[]> semanticHybridSearchRequestvectorizedSearchFields = null, [WorkflowExpression] Func<string> semanticHybridSearchRequestsemanticConfiguration = null, [WorkflowExpression] Func<string[]> semanticHybridSearchRequestselectFields = null, [WorkflowExpression] Func<string> semanticHybridSearchRequestfilterCondition = null, [WorkflowExpression] Func<string> semanticHybridSearchRequestsessionId = null, [WorkflowExpression] Func<int> semanticHybridSearchRequestnearestNeighbors = null, [WorkflowExpression] Func<int> semanticHybridSearchRequesttopSearches = null, [WorkflowExpression] Func<int> semanticHybridSearchRequestskipSearches = null)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            SourceExpression.Validate(semanticHybridSearchRequestsearchText, nameof(semanticHybridSearchRequestsearchText), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestvectorizedSearchFields, nameof(semanticHybridSearchRequestvectorizedSearchFields), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestsemanticConfiguration, nameof(semanticHybridSearchRequestsemanticConfiguration), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestselectFields, nameof(semanticHybridSearchRequestselectFields), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestfilterCondition, nameof(semanticHybridSearchRequestfilterCondition), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestsessionId, nameof(semanticHybridSearchRequestsessionId), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestnearestNeighbors, nameof(semanticHybridSearchRequestnearestNeighbors), required: false);
            SourceExpression.Validate(semanticHybridSearchRequesttopSearches, nameof(semanticHybridSearchRequesttopSearches), required: false);
            SourceExpression.Validate(semanticHybridSearchRequestskipSearches, nameof(semanticHybridSearchRequestskipSearches), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/semanticHybridSearch/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var semanticHybridSearchRequest = new JObject();
                var semanticHybridSearchRequestpropCount = 0;
                if (semanticHybridSearchRequestsearchText != null)
                {
                    semanticHybridSearchRequest["searchText"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestsearchText);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestvectorizedSearchFields != null)
                {
                    semanticHybridSearchRequest["vectorizedSearchFields"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestvectorizedSearchFields);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestsemanticConfiguration != null)
                {
                    semanticHybridSearchRequest["semanticConfiguration"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestsemanticConfiguration);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestselectFields != null)
                {
                    semanticHybridSearchRequest["selectFields"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestselectFields);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestfilterCondition != null)
                {
                    semanticHybridSearchRequest["filterCondition"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestfilterCondition);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestsessionId != null)
                {
                    semanticHybridSearchRequest["sessionId"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestsessionId);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestnearestNeighbors != null)
                {
                    semanticHybridSearchRequest["nearestNeighbors"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestnearestNeighbors);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequesttopSearches != null)
                {
                    semanticHybridSearchRequest["top"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequesttopSearches);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestskipSearches != null)
                {
                    semanticHybridSearchRequest["skipSearches"] = SourceExpressionConverter.ConvertToken(semanticHybridSearchRequestskipSearches);
                    semanticHybridSearchRequestpropCount++;
                }

                if (semanticHybridSearchRequestpropCount > 0)
                {
                    callPayload.Body = semanticHybridSearchRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> indexName)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = SourceExpressionConverter.ConvertO(indexName);
                var documentToDelete = new JObject();
                var documentToDeletepropCount = 0;
                if (documentToDeletepropCount > 0)
                {
                    callPayload.Body = documentToDelete;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction DeleteDocuments([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<JToken[]> documentsToDelete = null)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            SourceExpression.Validate(documentsToDelete, nameof(documentsToDelete), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = SourceExpressionConverter.ConvertO(indexName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(documentsToDelete);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction MergeDocument([WorkflowExpression] Func<string> indexName)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mergeDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = SourceExpressionConverter.ConvertO(indexName);
                var documentToMerge = new JObject();
                var documentToMergepropCount = 0;
                if (documentToMergepropCount > 0)
                {
                    callPayload.Body = documentToMerge;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<string[]> VectorSearch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<string> vectorFieldsName, [WorkflowExpression] Func<int> nearestNeighbors, [WorkflowExpression] Func<double[]> vectorFieldsValue = null, [WorkflowExpression] Func<string> searchQuery = null, [WorkflowExpression] Func<searchModeInput> searchMode = null, [WorkflowExpression] Func<string> filterCondition = null)
        {
            SourceExpression.Validate(indexName, nameof(indexName), required: true);
            SourceExpression.Validate(vectorFieldsName, nameof(vectorFieldsName), required: true);
            SourceExpression.Validate(nearestNeighbors, nameof(nearestNeighbors), required: true);
            SourceExpression.Validate(vectorFieldsValue, nameof(vectorFieldsValue), required: false);
            SourceExpression.Validate(searchQuery, nameof(searchQuery), required: false);
            SourceExpression.Validate(searchMode, nameof(searchMode), required: false);
            SourceExpression.Validate(filterCondition, nameof(filterCondition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/vectorSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = SourceExpressionConverter.ConvertO(indexName);
                callPayload.Queries["vectorFieldsName"] = SourceExpressionConverter.ConvertO(vectorFieldsName);
                callPayload.Queries["nearestNeighbors"] = SourceExpressionConverter.ConvertO(nearestNeighbors);
                if (searchQuery != null)
                    callPayload.Queries["searchQuery"] = SourceExpressionConverter.ConvertO(searchQuery);
                if (searchMode != null)
                    callPayload.Queries["searchMode"] = SourceExpressionConverter.Convert(searchMode);
                if (filterCondition != null)
                    callPayload.Queries["filterCondition"] = SourceExpressionConverter.ConvertO(filterCondition);
                callPayload.Body = SourceExpressionConverter.ConvertToken(vectorFieldsValue);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
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
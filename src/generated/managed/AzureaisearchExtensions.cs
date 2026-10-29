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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> IndexDocument(Expression<Func<string>> indexName, Expression<Func<object>> documentToIndex)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentToIndex = WorkflowExpression.Compile(documentToIndex, nameof(documentToIndex), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/indexDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentToIndex);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> IndexDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentToIndex)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentToIndex = WorkflowExpression.Compile(documentToIndex, nameof(documentToIndex), required: true);
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
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> IntegratedVectorSearch(Expression<Func<string>> indexName, Expression<Func<IntegratedVectorSearchInput>> integratedVectorSearchRequest)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_integratedVectorSearchRequest = WorkflowExpression.Compile(integratedVectorSearchRequest, nameof(integratedVectorSearchRequest), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integratedVectorSearch/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_integratedVectorSearchRequest);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> SemanticHybridSearch(Expression<Func<string>> indexName, Expression<Func<SemanticHybridSearchInput>> semanticHybridSearchRequest)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_semanticHybridSearchRequest = WorkflowExpression.Compile(semanticHybridSearchRequest, nameof(semanticHybridSearchRequest), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/semanticHybridSearch/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_semanticHybridSearchRequest);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> indexName, Expression<Func<object>> documentToDelete)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentToDelete = WorkflowExpression.Compile(documentToDelete, nameof(documentToDelete), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentToDelete);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocuments(Expression<Func<string>> indexName, Expression<Func<JToken[]>> documentsToDelete)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentsToDelete = WorkflowExpression.Compile(documentsToDelete, nameof(documentsToDelete), required: true);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> MergeDocument(Expression<Func<string>> indexName, Expression<Func<object>> documentToMerge)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_documentToMerge = WorkflowExpression.Compile(documentToMerge, nameof(documentToMerge), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mergeDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentToMerge);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> VectorSearch(Expression<Func<string>> indexName, Expression<Func<string>> vectorFieldsName, Expression<Func<double[]>> vectorFieldsValue, Expression<Func<int>> nearestNeighbors, Expression<Func<string>> searchQuery = null, Expression<Func<searchModeInput>> searchMode = null, Expression<Func<string>> filterCondition = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_vectorFieldsName = WorkflowExpression.Compile(vectorFieldsName, nameof(vectorFieldsName), required: true);
            var __workflow_vectorFieldsValue = WorkflowExpression.Compile(vectorFieldsValue, nameof(vectorFieldsValue), required: true);
            var __workflow_nearestNeighbors = WorkflowExpression.Compile(nearestNeighbors, nameof(nearestNeighbors), required: true);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureaisearch")]
        public IBodyWorkflowAction<AgenticRetrievalOutput, ApiConnectionActionConfiguration> KnowledgeAgentRetrieval(Expression<Func<string>> indexName, Expression<Func<string>> agentName, Expression<Func<AgenticRetrievalInput[]>> userQuery)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_userQuery = WorkflowExpression.Compile(userQuery, nameof(userQuery), required: true);
            return new DeferredBodyAction<AgenticRetrievalOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/knowledgeAgentRetrieval";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["indexName"] = ExpressionConverter.Convert(__workflow_indexName);
                callPayload.Queries["agentName"] = ExpressionConverter.Convert(__workflow_agentName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_userQuery);
                return new ApiConnectionAction<AgenticRetrievalOutput>(callPayload);
            });
        }
    }

    public class AzureaisearchTriggers([ConnectionName] string connectionId)
    {
    }

    public class IntegratedVectorSearchInput
    {
        [JsonProperty("searchText")]
        public string SearchText { get; set; }

        [JsonProperty("vectorizedSearchFields")]
        public string[] VectorizedSearchFields { get; set; }

        [JsonProperty("selectFields")]
        public string[] SelectFields { get; set; }

        [JsonProperty("filterCondition")]
        public string FilterCondition { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("nearestNeighbors")]
        public int? NearestNeighbors { get; set; }

        [JsonProperty("top")]
        public int? TopSearches { get; set; }

        [JsonProperty("skipSearches")]
        public int? SkipSearches { get; set; }
    }

    public class SemanticHybridSearchInput
    {
        [JsonProperty("searchText")]
        public string SearchText { get; set; }

        [JsonProperty("vectorizedSearchFields")]
        public string[] VectorizedSearchFields { get; set; }

        [JsonProperty("semanticConfiguration")]
        public string SemanticConfiguration { get; set; }

        [JsonProperty("selectFields")]
        public string[] SelectFields { get; set; }

        [JsonProperty("filterCondition")]
        public string FilterCondition { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("nearestNeighbors")]
        public int? NearestNeighbors { get; set; }

        [JsonProperty("top")]
        public int? TopSearches { get; set; }

        [JsonProperty("skipSearches")]
        public int? SkipSearches { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchModeInput
    {
        Any,
        All
    }

    public class AgenticRetrievalOutput
    {
        [JsonProperty("response")]
        public AgenticRetrievalOutputResponse[] Response { get; set; }

        [JsonProperty("activity")]
        public AgenticRetrievalOutputActivity[] Activity { get; set; }

        [JsonProperty("references")]
        public AgenticRetrievalOutputReferences[] References { get; set; }
    }

    public class AgenticRetrievalOutputResponse
    {
        [JsonProperty("role")]
        public string AgentMessageResponseRole { get; set; }

        [JsonProperty("content")]
        public AgenticRetrievalOutputResponseContent[] Content { get; set; }
    }

    public class AgenticRetrievalOutputResponseContent
    {
        [JsonProperty("type")]
        public string AgentMessageResponseType { get; set; }

        [JsonProperty("text")]
        public JToken[] AgentMessageResponseText { get; set; }
    }

    public class AgenticRetrievalOutputActivity
    {
        [JsonProperty("type")]
        public string AgentMessageActivity { get; set; }

        [JsonProperty("id")]
        public string AgentMessageId { get; set; }

        [JsonProperty("inputTokens")]
        public string AgentMessageInputTokens { get; set; }

        [JsonProperty("outputTokens")]
        public string AgentMessageOutputTokens { get; set; }

        [JsonProperty("targetIndex")]
        public string AgentMessageTargetIndex { get; set; }

        [JsonProperty("query")]
        public AgenticRetrievalOutputActivityQueryType Query { get; set; }

        [JsonProperty("queryTime")]
        public string AgentMessageQueryTime { get; set; }

        [JsonProperty("count")]
        public string AgentMessageCount { get; set; }
    }

    public class AgenticRetrievalOutputActivityQueryType
    {
        [JsonProperty("search")]
        public string AgentMessageSearchQuery { get; set; }

        [JsonProperty("filter")]
        public string AgentMessageQueryFilter { get; set; }
    }

    public class AgenticRetrievalOutputReferences
    {
        [JsonProperty("type")]
        public string AgentMessageReferenceType { get; set; }

        [JsonProperty("id")]
        public string AgentMessageReferenceId { get; set; }

        [JsonProperty("activitySource")]
        public string AgentMessageReferenceActivitySource { get; set; }

        [JsonProperty("docKey")]
        public string AgentMessageReferenceDocumentKey { get; set; }

        [JsonProperty("sourceData")]
        public string AgentMessageReferenceSourceData { get; set; }
    }

    public class AgenticRetrievalInput
    {
        [JsonProperty("role")]
        public AgenticRetrievalInputRoleType Role { get; set; }

        [JsonProperty("content")]
        public string AgentMessageContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgenticRetrievalInputRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<PostDocumentsResponse> CreateDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<bool> xMsDocumentdbIsUpsert = null, [WorkflowExpression] Func<string> xMsDocumentdbPreTriggerInclude = null, [WorkflowExpression] Func<string> xMsDocumentdbPostTriggerInclude = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = SourceExpressionConverter.ConvertO(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = SourceExpressionConverter.ConvertO(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = SourceExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = SourceExpressionConverter.ConvertO(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = SourceExpressionConverter.ConvertO(xMsActivityId);
                if (xMsDocumentdbIsUpsert != null)
                    callPayload.Headers["x-ms-documentdb-is-upsert"] = SourceExpressionConverter.ConvertO(xMsDocumentdbIsUpsert);
                if (xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = SourceExpressionConverter.ConvertO(xMsDocumentdbPreTriggerInclude);
                if (xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = SourceExpressionConverter.ConvertO(xMsDocumentdbPostTriggerInclude);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> CreateStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> bodyfunctionDefinition = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfunctionDefinition != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodyfunctionDefinition);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateStoredProcedureResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<string> xMsDocumentdbPreTriggerInclude = null, [WorkflowExpression] Func<string> xMsDocumentdbPostTriggerInclude = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = SourceExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = SourceExpressionConverter.ConvertO(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = SourceExpressionConverter.ConvertO(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = SourceExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = SourceExpressionConverter.ConvertO(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = SourceExpressionConverter.ConvertO(xMsActivityId);
                if (xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = SourceExpressionConverter.ConvertO(xMsDocumentdbPreTriggerInclude);
                if (xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = SourceExpressionConverter.ConvertO(xMsDocumentdbPostTriggerInclude);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<string> DeleteStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> sprocId, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sprocId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<JToken> ExecuteStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> sprocId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<string> parameters = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sprocId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = SourceExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                callPayload.Body = SourceExpressionConverter.ConvertToken(parameters);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetDocumentV2Response> GetDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = SourceExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = SourceExpressionConverter.ConvertO(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = SourceExpressionConverter.ConvertO(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = SourceExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = SourceExpressionConverter.ConvertO(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = SourceExpressionConverter.ConvertO(xMsActivityId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetDocumentsV3Response> GetDocuments([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = SourceExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = SourceExpressionConverter.ConvertO(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = SourceExpressionConverter.ConvertO(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = SourceExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = SourceExpressionConverter.ConvertO(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = SourceExpressionConverter.ConvertO(xMsActivityId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentsV3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetStoredProceduresResponse> GetStoredProcedures([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                return callPayload;
            }

            return new ApiConnectionAction<GetStoredProceduresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<QueryDocumentsV5Response> QueryDocuments([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> queryText = null, [WorkflowExpression] Func<string> partitionKey = null, [WorkflowExpression] Func<int> maxItemCount = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<consistencyLevelInput> consistencyLevel = null, [WorkflowExpression] Func<string> sessionToken = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v5/cosmosdb/{0}/dbs/{1}/colls/{2}/query", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (queryText != null)
                    callPayload.Queries["queryText"] = SourceExpressionConverter.ConvertO(queryText);
                if (partitionKey != null)
                    callPayload.Queries["partitionKey"] = SourceExpressionConverter.ConvertO(partitionKey);
                if (maxItemCount != null)
                    callPayload.Queries["maxItemCount"] = SourceExpressionConverter.ConvertO(maxItemCount);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                if (consistencyLevel != null)
                    callPayload.Queries["consistencyLevel"] = SourceExpressionConverter.Convert(consistencyLevel);
                if (sessionToken != null)
                    callPayload.Queries["sessionToken"] = SourceExpressionConverter.ConvertO(sessionToken);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = SourceExpressionConverter.ConvertO(purviewAccountName);
                return callPayload;
            }

            return new ApiConnectionAction<QueryDocumentsV5Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<PutDocumentResponse> ReplaceDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<string> xMsDocumentdbPreTriggerInclude = null, [WorkflowExpression] Func<string> xMsDocumentdbPostTriggerInclude = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = SourceExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = SourceExpressionConverter.ConvertO(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = SourceExpressionConverter.ConvertO(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = SourceExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = SourceExpressionConverter.ConvertO(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = SourceExpressionConverter.ConvertO(xMsActivityId);
                if (xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = SourceExpressionConverter.ConvertO(xMsDocumentdbPreTriggerInclude);
                if (xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = SourceExpressionConverter.ConvertO(xMsDocumentdbPostTriggerInclude);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> ReplaceStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> sprocId, [WorkflowExpression] Func<string> bodyfunctionDefinition = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sprocId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = SourceExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfunctionDefinition != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodyfunctionDefinition);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateStoredProcedureResponse>(BuildSourceInput);
        }
    }

    public class DocumentdbTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostDocumentsResponse
    {
        [JsonProperty("_rid")]
        public string Rid { get; set; }

        [JsonProperty("_ts")]
        public int Ts { get; set; }

        [JsonProperty("_self")]
        public string Self { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_attachments")]
        public string Attachments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum xMsConsistencyLevelInput
    {
        Strong,
        Bounded,
        Session,
        Eventual
    }

    public enum xMsVersionInput
    {
        [EnumMember(Value = "2017-05-03")]
        _20170503,
        [EnumMember(Value = "2018-12-31")]
        _20181231
    }

    public class CreateStoredProcedureResponse
    {
        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_rid")]
        public string Rid { get; set; }

        [JsonProperty("_self")]
        public string Self { get; set; }

        [JsonProperty("_ts")]
        public int Ts { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetDocumentV2Response
    {
        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }
    }

    public class DataWithSensitivityLabelInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    public class GetDocumentsV3Response
    {
        [JsonProperty("_rid")]
        public string Rid { get; set; }
        public JToken[] Documents { get; set; }

        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }
    }

    public class GetStoredProceduresResponse
    {
        [JsonProperty("_count")]
        public int Count { get; set; }

        [JsonProperty("_rid")]
        public string Rid { get; set; }
        public GetStoredProceduresResponseStoredProceduresTypeItem[] StoredProcedures { get; set; }
    }

    public class GetStoredProceduresResponseStoredProceduresTypeItem
    {
        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_rid")]
        public string Rid { get; set; }

        [JsonProperty("_self")]
        public string Self { get; set; }

        [JsonProperty("_ts")]
        public int Ts { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryDocumentsV5Response
    {
        [JsonProperty("value")]
        public JToken[] Documents { get; set; }
        public string ContinuationToken { get; set; }

        [JsonProperty("Count")]
        public int NumberOfDocuments { get; set; }
        public double RequestCharge { get; set; }
        public string SessionToken { get; set; }
        public string ActivityId { get; set; }

        [JsonProperty("@metadata")]
        public DataWithSensitivityLabelInfo[] Metadata { get; set; }
    }

    public enum consistencyLevelInput
    {
        Strong,
        BoundedStaleness,
        Session,
        Eventual,
        ConsistentPrefix
    }

    public class PutDocumentResponse
    {
        [JsonProperty("_rid")]
        public string Rid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentdb;

    public partial class WorkflowManagedActions
    {
        public DocumentdbActions Documentdb(string connectionId) => new DocumentdbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentdbTriggers Documentdb(string connectionId) => new DocumentdbTriggers(connectionId);
    }
}
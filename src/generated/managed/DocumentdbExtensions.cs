//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdb
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<PostDocumentsResponse> CreateDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<bool> xMsDocumentdbIsUpsert = null, [WorkflowExpression] Func<string> xMsDocumentdbPreTriggerInclude = null, [WorkflowExpression] Func<string> xMsDocumentdbPostTriggerInclude = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostDocumentsResponse> __BuildCreateDocument(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<double> xMsMaxItemCount = null, WorkflowValue<string> xMsContinuation = null, WorkflowValue<xMsConsistencyLevelInput> xMsConsistencyLevel = null, WorkflowValue<string> xMsSessionToken = null, WorkflowValue<string> xMsActivityId = null, WorkflowValue<bool> xMsDocumentdbIsUpsert = null, WorkflowValue<string> xMsDocumentdbPreTriggerInclude = null, WorkflowValue<string> xMsDocumentdbPostTriggerInclude = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            WorkflowValue.Validate(xMsContinuation, nameof(xMsContinuation), required: false);
            WorkflowValue.Validate(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            WorkflowValue.Validate(xMsSessionToken, nameof(xMsSessionToken), required: false);
            WorkflowValue.Validate(xMsActivityId, nameof(xMsActivityId), required: false);
            WorkflowValue.Validate(xMsDocumentdbIsUpsert, nameof(xMsDocumentdbIsUpsert), required: false);
            WorkflowValue.Validate(xMsDocumentdbPreTriggerInclude, nameof(xMsDocumentdbPreTriggerInclude), required: false);
            WorkflowValue.Validate(xMsDocumentdbPostTriggerInclude, nameof(xMsDocumentdbPostTriggerInclude), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<PostDocumentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(xMsActivityId);
                if (xMsDocumentdbIsUpsert != null)
                    callPayload.Headers["x-ms-documentdb-is-upsert"] = ExpressionConverter.Convert(xMsDocumentdbIsUpsert);
                if (xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = ExpressionConverter.Convert(xMsDocumentdbPreTriggerInclude);
                if (xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = ExpressionConverter.Convert(xMsDocumentdbPostTriggerInclude);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildCreateStoredProcedure))]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> CreateStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> bodyfunctionDefinition = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> __BuildCreateStoredProcedure(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> bodyfunctionDefinition = null, WorkflowValue<string> bodyid = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(bodyfunctionDefinition, nameof(bodyfunctionDefinition), required: false);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<CreateStoredProcedureResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfunctionDefinition != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodyfunctionDefinition);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateStoredProcedureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<string> xMsDocumentdbPreTriggerInclude = null, [WorkflowExpression] Func<string> xMsDocumentdbPostTriggerInclude = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> documentId, WorkflowValue<string> xMsDocumentdbRawPartitionkey = null, WorkflowValue<double> xMsMaxItemCount = null, WorkflowValue<string> xMsContinuation = null, WorkflowValue<xMsConsistencyLevelInput> xMsConsistencyLevel = null, WorkflowValue<string> xMsSessionToken = null, WorkflowValue<string> xMsActivityId = null, WorkflowValue<string> xMsDocumentdbPreTriggerInclude = null, WorkflowValue<string> xMsDocumentdbPostTriggerInclude = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            WorkflowValue.Validate(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            WorkflowValue.Validate(xMsContinuation, nameof(xMsContinuation), required: false);
            WorkflowValue.Validate(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            WorkflowValue.Validate(xMsSessionToken, nameof(xMsSessionToken), required: false);
            WorkflowValue.Validate(xMsActivityId, nameof(xMsActivityId), required: false);
            WorkflowValue.Validate(xMsDocumentdbPreTriggerInclude, nameof(xMsDocumentdbPreTriggerInclude), required: false);
            WorkflowValue.Validate(xMsDocumentdbPostTriggerInclude, nameof(xMsDocumentdbPostTriggerInclude), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(xMsActivityId);
                if (xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = ExpressionConverter.Convert(xMsDocumentdbPreTriggerInclude);
                if (xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = ExpressionConverter.Convert(xMsDocumentdbPostTriggerInclude);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteStoredProcedure))]
        public IBodyWorkflowAction<string> DeleteStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> sprocId, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteStoredProcedure(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> sprocId, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(sprocId, nameof(sprocId), required: true);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1), ExpressionConverter.ConvertWithUrlEncoding(sprocId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteStoredProcedure))]
        public IBodyWorkflowAction<JToken> ExecuteStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> sprocId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<string> parameters = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExecuteStoredProcedure(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> sprocId, WorkflowValue<string> xMsDocumentdbRawPartitionkey = null, WorkflowValue<string> parameters = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(sprocId, nameof(sprocId), required: true);
            WorkflowValue.Validate(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            WorkflowValue.Validate(parameters, nameof(parameters), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1), ExpressionConverter.ConvertWithUrlEncoding(sprocId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(xMsDocumentdbRawPartitionkey);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                callPayload.Body = ExpressionConverter.ConvertO(parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocument))]
        public IBodyWorkflowAction<GetDocumentV2Response> GetDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentV2Response> __BuildGetDocument(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> documentId, WorkflowValue<string> xMsDocumentdbRawPartitionkey = null, WorkflowValue<double> xMsMaxItemCount = null, WorkflowValue<string> xMsContinuation = null, WorkflowValue<xMsConsistencyLevelInput> xMsConsistencyLevel = null, WorkflowValue<string> xMsSessionToken = null, WorkflowValue<string> xMsActivityId = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            WorkflowValue.Validate(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            WorkflowValue.Validate(xMsContinuation, nameof(xMsContinuation), required: false);
            WorkflowValue.Validate(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            WorkflowValue.Validate(xMsSessionToken, nameof(xMsSessionToken), required: false);
            WorkflowValue.Validate(xMsActivityId, nameof(xMsActivityId), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<GetDocumentV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(xMsActivityId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                return new ApiConnectionAction<GetDocumentV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocuments))]
        public IBodyWorkflowAction<GetDocumentsV3Response> GetDocuments([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentsV3Response> __BuildGetDocuments(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> xMsDocumentdbRawPartitionkey = null, WorkflowValue<double> xMsMaxItemCount = null, WorkflowValue<string> xMsContinuation = null, WorkflowValue<xMsConsistencyLevelInput> xMsConsistencyLevel = null, WorkflowValue<string> xMsSessionToken = null, WorkflowValue<string> xMsActivityId = null, WorkflowValue<xMsVersionInput> xMsVersion = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            WorkflowValue.Validate(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            WorkflowValue.Validate(xMsContinuation, nameof(xMsContinuation), required: false);
            WorkflowValue.Validate(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            WorkflowValue.Validate(xMsSessionToken, nameof(xMsSessionToken), required: false);
            WorkflowValue.Validate(xMsActivityId, nameof(xMsActivityId), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<GetDocumentsV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(xMsActivityId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                return new ApiConnectionAction<GetDocumentsV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildGetStoredProcedures))]
        public IBodyWorkflowAction<GetStoredProceduresResponse> GetStoredProcedures([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStoredProceduresResponse> __BuildGetStoredProcedures(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<GetStoredProceduresResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                return new ApiConnectionAction<GetStoredProceduresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildQueryDocuments))]
        public IBodyWorkflowAction<QueryDocumentsV5Response> QueryDocuments([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> queryText = null, [WorkflowExpression] Func<string> partitionKey = null, [WorkflowExpression] Func<int> maxItemCount = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<consistencyLevelInput> consistencyLevel = null, [WorkflowExpression] Func<string> sessionToken = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<string> purviewAccountName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryDocumentsV5Response> __BuildQueryDocuments(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> containerId, WorkflowValue<string> queryText = null, WorkflowValue<string> partitionKey = null, WorkflowValue<int> maxItemCount = null, WorkflowValue<string> continuationToken = null, WorkflowValue<consistencyLevelInput> consistencyLevel = null, WorkflowValue<string> sessionToken = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<string> purviewAccountName = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(containerId, nameof(containerId), required: true);
            WorkflowValue.Validate(queryText, nameof(queryText), required: false);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: false);
            WorkflowValue.Validate(maxItemCount, nameof(maxItemCount), required: false);
            WorkflowValue.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowValue.Validate(consistencyLevel, nameof(consistencyLevel), required: false);
            WorkflowValue.Validate(sessionToken, nameof(sessionToken), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<QueryDocumentsV5Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v5/cosmosdb/{0}/dbs/{1}/colls/{2}/query", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (queryText != null)
                    callPayload.Queries["queryText"] = ExpressionConverter.Convert(queryText);
                if (partitionKey != null)
                    callPayload.Queries["partitionKey"] = ExpressionConverter.Convert(partitionKey);
                if (maxItemCount != null)
                    callPayload.Queries["maxItemCount"] = ExpressionConverter.Convert(maxItemCount);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
                if (consistencyLevel != null)
                    callPayload.Queries["consistencyLevel"] = ExpressionConverter.Convert(consistencyLevel);
                if (sessionToken != null)
                    callPayload.Queries["sessionToken"] = ExpressionConverter.Convert(sessionToken);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(purviewAccountName);
                return new ApiConnectionAction<QueryDocumentsV5Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceDocument))]
        public IBodyWorkflowAction<PutDocumentResponse> ReplaceDocument([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xMsDocumentdbRawPartitionkey = null, [WorkflowExpression] Func<double> xMsMaxItemCount = null, [WorkflowExpression] Func<string> xMsContinuation = null, [WorkflowExpression] Func<xMsConsistencyLevelInput> xMsConsistencyLevel = null, [WorkflowExpression] Func<string> xMsSessionToken = null, [WorkflowExpression] Func<string> xMsActivityId = null, [WorkflowExpression] Func<string> xMsDocumentdbPreTriggerInclude = null, [WorkflowExpression] Func<string> xMsDocumentdbPostTriggerInclude = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutDocumentResponse> __BuildReplaceDocument(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> documentId, WorkflowValue<string> xMsDocumentdbRawPartitionkey = null, WorkflowValue<double> xMsMaxItemCount = null, WorkflowValue<string> xMsContinuation = null, WorkflowValue<xMsConsistencyLevelInput> xMsConsistencyLevel = null, WorkflowValue<string> xMsSessionToken = null, WorkflowValue<string> xMsActivityId = null, WorkflowValue<string> xMsDocumentdbPreTriggerInclude = null, WorkflowValue<string> xMsDocumentdbPostTriggerInclude = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            WorkflowValue.Validate(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            WorkflowValue.Validate(xMsContinuation, nameof(xMsContinuation), required: false);
            WorkflowValue.Validate(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            WorkflowValue.Validate(xMsSessionToken, nameof(xMsSessionToken), required: false);
            WorkflowValue.Validate(xMsActivityId, nameof(xMsActivityId), required: false);
            WorkflowValue.Validate(xMsDocumentdbPreTriggerInclude, nameof(xMsDocumentdbPreTriggerInclude), required: false);
            WorkflowValue.Validate(xMsDocumentdbPostTriggerInclude, nameof(xMsDocumentdbPostTriggerInclude), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<PutDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(xMsDocumentdbRawPartitionkey);
                if (xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(xMsMaxItemCount);
                if (xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(xMsContinuation);
                if (xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(xMsConsistencyLevel);
                if (xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(xMsSessionToken);
                if (xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(xMsActivityId);
                if (xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = ExpressionConverter.Convert(xMsDocumentdbPreTriggerInclude);
                if (xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = ExpressionConverter.Convert(xMsDocumentdbPostTriggerInclude);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceStoredProcedure))]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> ReplaceStoredProcedure([WorkflowExpression] Func<string> cosmosDbAccountName, [WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> sprocId, [WorkflowExpression] Func<string> bodyfunctionDefinition = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<xMsVersionInput> xMsVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> __BuildReplaceStoredProcedure(WorkflowValue<string> cosmosDbAccountName, WorkflowValue<string> databaseId, WorkflowValue<string> collectionId, WorkflowValue<string> sprocId, WorkflowValue<string> bodyfunctionDefinition = null, WorkflowValue<string> bodyid = null, WorkflowValue<xMsVersionInput> xMsVersion = null)
        {
            WorkflowValue.Validate(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            WorkflowValue.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowValue.Validate(collectionId, nameof(collectionId), required: true);
            WorkflowValue.Validate(sprocId, nameof(sprocId), required: true);
            WorkflowValue.Validate(bodyfunctionDefinition, nameof(bodyfunctionDefinition), required: false);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<CreateStoredProcedureResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", ExpressionConverter.ConvertWithUrlEncoding(cosmosDbAccountName, 1), ExpressionConverter.ConvertWithUrlEncoding(databaseId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionId, 1), ExpressionConverter.ConvertWithUrlEncoding(sprocId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfunctionDefinition != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodyfunctionDefinition);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateStoredProcedureResponse>(callPayload);
            });
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

//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdb
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<PostDocumentsResponse, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<bool>> xMsDocumentdbIsUpsert = null, Expression<Func<string>> xMsDocumentdbPreTriggerInclude = null, Expression<Func<string>> xMsDocumentdbPostTriggerInclude = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_xMsMaxItemCount = WorkflowExpression.Compile(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            var __workflow_xMsContinuation = WorkflowExpression.Compile(xMsContinuation, nameof(xMsContinuation), required: false);
            var __workflow_xMsConsistencyLevel = WorkflowExpression.Compile(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            var __workflow_xMsSessionToken = WorkflowExpression.Compile(xMsSessionToken, nameof(xMsSessionToken), required: false);
            var __workflow_xMsActivityId = WorkflowExpression.Compile(xMsActivityId, nameof(xMsActivityId), required: false);
            var __workflow_xMsDocumentdbIsUpsert = WorkflowExpression.Compile(xMsDocumentdbIsUpsert, nameof(xMsDocumentdbIsUpsert), required: false);
            var __workflow_xMsDocumentdbPreTriggerInclude = WorkflowExpression.Compile(xMsDocumentdbPreTriggerInclude, nameof(xMsDocumentdbPreTriggerInclude), required: false);
            var __workflow_xMsDocumentdbPostTriggerInclude = WorkflowExpression.Compile(xMsDocumentdbPostTriggerInclude, nameof(xMsDocumentdbPostTriggerInclude), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<PostDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(__workflow_xMsMaxItemCount);
                if (__workflow_xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(__workflow_xMsContinuation);
                if (__workflow_xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(__workflow_xMsConsistencyLevel);
                if (__workflow_xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(__workflow_xMsSessionToken);
                if (__workflow_xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(__workflow_xMsActivityId);
                if (__workflow_xMsDocumentdbIsUpsert != null)
                    callPayload.Headers["x-ms-documentdb-is-upsert"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbIsUpsert);
                if (__workflow_xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbPreTriggerInclude);
                if (__workflow_xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbPostTriggerInclude);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
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
        public IBodyWorkflowAction<CreateStoredProcedureResponse, ApiConnectionActionConfiguration> CreateStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> bodyfunctionDefinition = null, Expression<Func<string>> bodyid = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_bodyfunctionDefinition = WorkflowExpression.Compile(bodyfunctionDefinition, nameof(bodyfunctionDefinition), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<CreateStoredProcedureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfunctionDefinition != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodyfunctionDefinition);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> documentId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<string>> xMsDocumentdbPreTriggerInclude = null, Expression<Func<string>> xMsDocumentdbPostTriggerInclude = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xMsDocumentdbRawPartitionkey = WorkflowExpression.Compile(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            var __workflow_xMsMaxItemCount = WorkflowExpression.Compile(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            var __workflow_xMsContinuation = WorkflowExpression.Compile(xMsContinuation, nameof(xMsContinuation), required: false);
            var __workflow_xMsConsistencyLevel = WorkflowExpression.Compile(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            var __workflow_xMsSessionToken = WorkflowExpression.Compile(xMsSessionToken, nameof(xMsSessionToken), required: false);
            var __workflow_xMsActivityId = WorkflowExpression.Compile(xMsActivityId, nameof(xMsActivityId), required: false);
            var __workflow_xMsDocumentdbPreTriggerInclude = WorkflowExpression.Compile(xMsDocumentdbPreTriggerInclude, nameof(xMsDocumentdbPreTriggerInclude), required: false);
            var __workflow_xMsDocumentdbPostTriggerInclude = WorkflowExpression.Compile(xMsDocumentdbPostTriggerInclude, nameof(xMsDocumentdbPostTriggerInclude), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbRawPartitionkey);
                if (__workflow_xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(__workflow_xMsMaxItemCount);
                if (__workflow_xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(__workflow_xMsContinuation);
                if (__workflow_xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(__workflow_xMsConsistencyLevel);
                if (__workflow_xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(__workflow_xMsSessionToken);
                if (__workflow_xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(__workflow_xMsActivityId);
                if (__workflow_xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbPreTriggerInclude);
                if (__workflow_xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbPostTriggerInclude);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> sprocId, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_sprocId = WorkflowExpression.Compile(sprocId, nameof(sprocId), required: true);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1), __workflow_sprocId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExecuteStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> sprocId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<string>> parameters = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_sprocId = WorkflowExpression.Compile(sprocId, nameof(sprocId), required: true);
            var __workflow_xMsDocumentdbRawPartitionkey = WorkflowExpression.Compile(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1), __workflow_sprocId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbRawPartitionkey);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetDocumentV2Response, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> documentId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xMsDocumentdbRawPartitionkey = WorkflowExpression.Compile(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            var __workflow_xMsMaxItemCount = WorkflowExpression.Compile(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            var __workflow_xMsContinuation = WorkflowExpression.Compile(xMsContinuation, nameof(xMsContinuation), required: false);
            var __workflow_xMsConsistencyLevel = WorkflowExpression.Compile(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            var __workflow_xMsSessionToken = WorkflowExpression.Compile(xMsSessionToken, nameof(xMsSessionToken), required: false);
            var __workflow_xMsActivityId = WorkflowExpression.Compile(xMsActivityId, nameof(xMsActivityId), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = WorkflowExpression.Compile(purviewAccountName, nameof(purviewAccountName), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<GetDocumentV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                if (__workflow_xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbRawPartitionkey);
                if (__workflow_xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(__workflow_xMsMaxItemCount);
                if (__workflow_xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(__workflow_xMsContinuation);
                if (__workflow_xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(__workflow_xMsConsistencyLevel);
                if (__workflow_xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(__workflow_xMsSessionToken);
                if (__workflow_xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(__workflow_xMsActivityId);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                return new ApiConnectionAction<GetDocumentV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetDocumentsV3Response, ApiConnectionActionConfiguration> GetDocuments(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<xMsVersionInput>> xMsVersion = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_xMsDocumentdbRawPartitionkey = WorkflowExpression.Compile(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            var __workflow_xMsMaxItemCount = WorkflowExpression.Compile(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            var __workflow_xMsContinuation = WorkflowExpression.Compile(xMsContinuation, nameof(xMsContinuation), required: false);
            var __workflow_xMsConsistencyLevel = WorkflowExpression.Compile(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            var __workflow_xMsSessionToken = WorkflowExpression.Compile(xMsSessionToken, nameof(xMsSessionToken), required: false);
            var __workflow_xMsActivityId = WorkflowExpression.Compile(xMsActivityId, nameof(xMsActivityId), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = WorkflowExpression.Compile(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<GetDocumentsV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                if (__workflow_xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbRawPartitionkey);
                if (__workflow_xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(__workflow_xMsMaxItemCount);
                if (__workflow_xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(__workflow_xMsContinuation);
                if (__workflow_xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(__workflow_xMsConsistencyLevel);
                if (__workflow_xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(__workflow_xMsSessionToken);
                if (__workflow_xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(__workflow_xMsActivityId);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                return new ApiConnectionAction<GetDocumentsV3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetStoredProceduresResponse, ApiConnectionActionConfiguration> GetStoredProcedures(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<GetStoredProceduresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                return new ApiConnectionAction<GetStoredProceduresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<QueryDocumentsV5Response, ApiConnectionActionConfiguration> QueryDocuments(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> queryText = null, Expression<Func<string>> partitionKey = null, Expression<Func<int>> maxItemCount = null, Expression<Func<string>> continuationToken = null, Expression<Func<consistencyLevelInput>> consistencyLevel = null, Expression<Func<string>> sessionToken = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_queryText = WorkflowExpression.Compile(queryText, nameof(queryText), required: false);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: false);
            var __workflow_maxItemCount = WorkflowExpression.Compile(maxItemCount, nameof(maxItemCount), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_consistencyLevel = WorkflowExpression.Compile(consistencyLevel, nameof(consistencyLevel), required: false);
            var __workflow_sessionToken = WorkflowExpression.Compile(sessionToken, nameof(sessionToken), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_purviewAccountName = WorkflowExpression.Compile(purviewAccountName, nameof(purviewAccountName), required: false);
            return new DeferredBodyAction<QueryDocumentsV5Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v5/cosmosdb/{0}/dbs/{1}/colls/{2}/query", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_queryText != null)
                    callPayload.Queries["queryText"] = ExpressionConverter.Convert(__workflow_queryText);
                if (__workflow_partitionKey != null)
                    callPayload.Queries["partitionKey"] = ExpressionConverter.Convert(__workflow_partitionKey);
                if (__workflow_maxItemCount != null)
                    callPayload.Queries["maxItemCount"] = ExpressionConverter.Convert(__workflow_maxItemCount);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                if (__workflow_consistencyLevel != null)
                    callPayload.Queries["consistencyLevel"] = ExpressionConverter.Convert(__workflow_consistencyLevel);
                if (__workflow_sessionToken != null)
                    callPayload.Queries["sessionToken"] = ExpressionConverter.Convert(__workflow_sessionToken);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_purviewAccountName != null)
                    callPayload.Queries["purviewAccountName"] = ExpressionConverter.Convert(__workflow_purviewAccountName);
                return new ApiConnectionAction<QueryDocumentsV5Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<PutDocumentResponse, ApiConnectionActionConfiguration> ReplaceDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> documentId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<string>> xMsDocumentdbPreTriggerInclude = null, Expression<Func<string>> xMsDocumentdbPostTriggerInclude = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xMsDocumentdbRawPartitionkey = WorkflowExpression.Compile(xMsDocumentdbRawPartitionkey, nameof(xMsDocumentdbRawPartitionkey), required: false);
            var __workflow_xMsMaxItemCount = WorkflowExpression.Compile(xMsMaxItemCount, nameof(xMsMaxItemCount), required: false);
            var __workflow_xMsContinuation = WorkflowExpression.Compile(xMsContinuation, nameof(xMsContinuation), required: false);
            var __workflow_xMsConsistencyLevel = WorkflowExpression.Compile(xMsConsistencyLevel, nameof(xMsConsistencyLevel), required: false);
            var __workflow_xMsSessionToken = WorkflowExpression.Compile(xMsSessionToken, nameof(xMsSessionToken), required: false);
            var __workflow_xMsActivityId = WorkflowExpression.Compile(xMsActivityId, nameof(xMsActivityId), required: false);
            var __workflow_xMsDocumentdbPreTriggerInclude = WorkflowExpression.Compile(xMsDocumentdbPreTriggerInclude, nameof(xMsDocumentdbPreTriggerInclude), required: false);
            var __workflow_xMsDocumentdbPostTriggerInclude = WorkflowExpression.Compile(xMsDocumentdbPostTriggerInclude, nameof(xMsDocumentdbPostTriggerInclude), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<PutDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsDocumentdbRawPartitionkey != null)
                    callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbRawPartitionkey);
                if (__workflow_xMsMaxItemCount != null)
                    callPayload.Headers["x-ms-max-item-count"] = ExpressionConverter.Convert(__workflow_xMsMaxItemCount);
                if (__workflow_xMsContinuation != null)
                    callPayload.Headers["x-ms-continuation"] = ExpressionConverter.Convert(__workflow_xMsContinuation);
                if (__workflow_xMsConsistencyLevel != null)
                    callPayload.Headers["x-ms-consistency-level"] = ExpressionConverter.Convert(__workflow_xMsConsistencyLevel);
                if (__workflow_xMsSessionToken != null)
                    callPayload.Headers["x-ms-session-token"] = ExpressionConverter.Convert(__workflow_xMsSessionToken);
                if (__workflow_xMsActivityId != null)
                    callPayload.Headers["x-ms-activity-id"] = ExpressionConverter.Convert(__workflow_xMsActivityId);
                if (__workflow_xMsDocumentdbPreTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbPreTriggerInclude);
                if (__workflow_xMsDocumentdbPostTriggerInclude != null)
                    callPayload.Headers["x-ms-documentdb-post-trigger-include"] = ExpressionConverter.Convert(__workflow_xMsDocumentdbPostTriggerInclude);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
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
        public IBodyWorkflowAction<CreateStoredProcedureResponse, ApiConnectionActionConfiguration> ReplaceStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> sprocId, Expression<Func<string>> bodyfunctionDefinition = null, Expression<Func<string>> bodyid = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var __workflow_cosmosDbAccountName = WorkflowExpression.Compile(cosmosDbAccountName, nameof(cosmosDbAccountName), required: true);
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_sprocId = WorkflowExpression.Compile(sprocId, nameof(sprocId), required: true);
            var __workflow_bodyfunctionDefinition = WorkflowExpression.Compile(bodyfunctionDefinition, nameof(bodyfunctionDefinition), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_xMsVersion = WorkflowExpression.Compile(xMsVersion, nameof(xMsVersion), required: false);
            return new DeferredBodyAction<CreateStoredProcedureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", __workflow_cosmosDbAccountName.WithUrlEncoding(1), __workflow_databaseId.WithUrlEncoding(1), __workflow_collectionId.WithUrlEncoding(1), __workflow_sprocId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsVersion != null)
                    callPayload.Headers["x-ms-version"] = ExpressionConverter.Convert(__workflow_xMsVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfunctionDefinition != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodyfunctionDefinition);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum xMsConsistencyLevelInput
    {
        Strong,
        Bounded,
        Session,
        Eventual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

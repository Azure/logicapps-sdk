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
        public IBodyWorkflowAction<PostDocumentsResponse> CreateDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<bool>> xMsDocumentdbIsUpsert = null, Expression<Func<string>> xMsDocumentdbPreTriggerInclude = null, Expression<Func<string>> xMsDocumentdbPostTriggerInclude = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsMaxItemCount != null)
                callPayload.Headers["x-ms-max-item-count"] = CSharpExpressionConverter.ConvertO(xMsMaxItemCount);
            if (xMsContinuation != null)
                callPayload.Headers["x-ms-continuation"] = CSharpExpressionConverter.ConvertO(xMsContinuation);
            if (xMsConsistencyLevel != null)
                callPayload.Headers["x-ms-consistency-level"] = CSharpExpressionConverter.Convert(xMsConsistencyLevel);
            if (xMsSessionToken != null)
                callPayload.Headers["x-ms-session-token"] = CSharpExpressionConverter.ConvertO(xMsSessionToken);
            if (xMsActivityId != null)
                callPayload.Headers["x-ms-activity-id"] = CSharpExpressionConverter.ConvertO(xMsActivityId);
            if (xMsDocumentdbIsUpsert != null)
                callPayload.Headers["x-ms-documentdb-is-upsert"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbIsUpsert);
            if (xMsDocumentdbPreTriggerInclude != null)
                callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbPreTriggerInclude);
            if (xMsDocumentdbPostTriggerInclude != null)
                callPayload.Headers["x-ms-documentdb-post-trigger-include"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbPostTriggerInclude);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostDocumentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> CreateStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> bodyfunctionDefinition = null, Expression<Func<string>> bodyid = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfunctionDefinition != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodyfunctionDefinition);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateStoredProcedureResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> documentId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<string>> xMsDocumentdbPreTriggerInclude = null, Expression<Func<string>> xMsDocumentdbPostTriggerInclude = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsDocumentdbRawPartitionkey != null)
                callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
            if (xMsMaxItemCount != null)
                callPayload.Headers["x-ms-max-item-count"] = CSharpExpressionConverter.ConvertO(xMsMaxItemCount);
            if (xMsContinuation != null)
                callPayload.Headers["x-ms-continuation"] = CSharpExpressionConverter.ConvertO(xMsContinuation);
            if (xMsConsistencyLevel != null)
                callPayload.Headers["x-ms-consistency-level"] = CSharpExpressionConverter.Convert(xMsConsistencyLevel);
            if (xMsSessionToken != null)
                callPayload.Headers["x-ms-session-token"] = CSharpExpressionConverter.ConvertO(xMsSessionToken);
            if (xMsActivityId != null)
                callPayload.Headers["x-ms-activity-id"] = CSharpExpressionConverter.ConvertO(xMsActivityId);
            if (xMsDocumentdbPreTriggerInclude != null)
                callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbPreTriggerInclude);
            if (xMsDocumentdbPostTriggerInclude != null)
                callPayload.Headers["x-ms-documentdb-post-trigger-include"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbPostTriggerInclude);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<string> DeleteStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> sprocId, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sprocId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<JToken> ExecuteStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> sprocId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<string>> parameters = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sprocId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsDocumentdbRawPartitionkey != null)
                callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetDocumentV2Response> GetDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> documentId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            if (xMsDocumentdbRawPartitionkey != null)
                callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
            if (xMsMaxItemCount != null)
                callPayload.Headers["x-ms-max-item-count"] = CSharpExpressionConverter.ConvertO(xMsMaxItemCount);
            if (xMsContinuation != null)
                callPayload.Headers["x-ms-continuation"] = CSharpExpressionConverter.ConvertO(xMsContinuation);
            if (xMsConsistencyLevel != null)
                callPayload.Headers["x-ms-consistency-level"] = CSharpExpressionConverter.Convert(xMsConsistencyLevel);
            if (xMsSessionToken != null)
                callPayload.Headers["x-ms-session-token"] = CSharpExpressionConverter.ConvertO(xMsSessionToken);
            if (xMsActivityId != null)
                callPayload.Headers["x-ms-activity-id"] = CSharpExpressionConverter.ConvertO(xMsActivityId);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            return new ApiConnectionAction<GetDocumentV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetDocumentsV3Response> GetDocuments(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<xMsVersionInput>> xMsVersion = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            if (xMsDocumentdbRawPartitionkey != null)
                callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
            if (xMsMaxItemCount != null)
                callPayload.Headers["x-ms-max-item-count"] = CSharpExpressionConverter.ConvertO(xMsMaxItemCount);
            if (xMsContinuation != null)
                callPayload.Headers["x-ms-continuation"] = CSharpExpressionConverter.ConvertO(xMsContinuation);
            if (xMsConsistencyLevel != null)
                callPayload.Headers["x-ms-consistency-level"] = CSharpExpressionConverter.Convert(xMsConsistencyLevel);
            if (xMsSessionToken != null)
                callPayload.Headers["x-ms-session-token"] = CSharpExpressionConverter.ConvertO(xMsSessionToken);
            if (xMsActivityId != null)
                callPayload.Headers["x-ms-activity-id"] = CSharpExpressionConverter.ConvertO(xMsActivityId);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            return new ApiConnectionAction<GetDocumentsV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<GetStoredProceduresResponse> GetStoredProcedures(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            return new ApiConnectionAction<GetStoredProceduresResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<QueryDocumentsV5Response> QueryDocuments(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> queryText = null, Expression<Func<string>> partitionKey = null, Expression<Func<int>> maxItemCount = null, Expression<Func<string>> continuationToken = null, Expression<Func<consistencyLevelInput>> consistencyLevel = null, Expression<Func<string>> sessionToken = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<string>> purviewAccountName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v5/cosmosdb/{0}/dbs/{1}/colls/{2}/query", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (queryText != null)
                callPayload.Queries["queryText"] = CSharpExpressionConverter.ConvertO(queryText);
            if (partitionKey != null)
                callPayload.Queries["partitionKey"] = CSharpExpressionConverter.ConvertO(partitionKey);
            if (maxItemCount != null)
                callPayload.Queries["maxItemCount"] = CSharpExpressionConverter.ConvertO(maxItemCount);
            if (continuationToken != null)
                callPayload.Queries["continuationToken"] = CSharpExpressionConverter.ConvertO(continuationToken);
            if (consistencyLevel != null)
                callPayload.Queries["consistencyLevel"] = CSharpExpressionConverter.Convert(consistencyLevel);
            if (sessionToken != null)
                callPayload.Queries["sessionToken"] = CSharpExpressionConverter.ConvertO(sessionToken);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (purviewAccountName != null)
                callPayload.Queries["purviewAccountName"] = CSharpExpressionConverter.ConvertO(purviewAccountName);
            return new ApiConnectionAction<QueryDocumentsV5Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<PutDocumentResponse> ReplaceDocument(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> documentId, Expression<Func<string>> xMsDocumentdbRawPartitionkey = null, Expression<Func<double>> xMsMaxItemCount = null, Expression<Func<string>> xMsContinuation = null, Expression<Func<xMsConsistencyLevelInput>> xMsConsistencyLevel = null, Expression<Func<string>> xMsSessionToken = null, Expression<Func<string>> xMsActivityId = null, Expression<Func<string>> xMsDocumentdbPreTriggerInclude = null, Expression<Func<string>> xMsDocumentdbPostTriggerInclude = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/docs/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsDocumentdbRawPartitionkey != null)
                callPayload.Headers["x-ms-documentdb-raw-partitionkey"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbRawPartitionkey);
            if (xMsMaxItemCount != null)
                callPayload.Headers["x-ms-max-item-count"] = CSharpExpressionConverter.ConvertO(xMsMaxItemCount);
            if (xMsContinuation != null)
                callPayload.Headers["x-ms-continuation"] = CSharpExpressionConverter.ConvertO(xMsContinuation);
            if (xMsConsistencyLevel != null)
                callPayload.Headers["x-ms-consistency-level"] = CSharpExpressionConverter.Convert(xMsConsistencyLevel);
            if (xMsSessionToken != null)
                callPayload.Headers["x-ms-session-token"] = CSharpExpressionConverter.ConvertO(xMsSessionToken);
            if (xMsActivityId != null)
                callPayload.Headers["x-ms-activity-id"] = CSharpExpressionConverter.ConvertO(xMsActivityId);
            if (xMsDocumentdbPreTriggerInclude != null)
                callPayload.Headers["x-ms-documentdb-pre-trigger-include"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbPreTriggerInclude);
            if (xMsDocumentdbPostTriggerInclude != null)
                callPayload.Headers["x-ms-documentdb-post-trigger-include"] = CSharpExpressionConverter.ConvertO(xMsDocumentdbPostTriggerInclude);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PutDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdb")]
        public IBodyWorkflowAction<CreateStoredProcedureResponse> ReplaceStoredProcedure(Expression<Func<string>> cosmosDbAccountName, Expression<Func<string>> databaseId, Expression<Func<string>> collectionId, Expression<Func<string>> sprocId, Expression<Func<string>> bodyfunctionDefinition = null, Expression<Func<string>> bodyid = null, Expression<Func<xMsVersionInput>> xMsVersion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cosmosdb/{0}/dbs/{1}/colls/{2}/sprocs/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cosmosDbAccountName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(databaseId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sprocId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsVersion != null)
                callPayload.Headers["x-ms-version"] = CSharpExpressionConverter.Convert(xMsVersion);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfunctionDefinition != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodyfunctionDefinition);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateStoredProcedureResponse>(callPayload);
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
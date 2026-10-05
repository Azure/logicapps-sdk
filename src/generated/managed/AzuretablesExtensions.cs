//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuretables
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuretablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEntity))]
        public IBodyWorkflowAction<InsertEntityResponse> CreateEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertEntityResponse> __BuildCreateEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<InsertEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }

                return new ApiConnectionAction<InsertEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTable))]
        public IBodyWorkflowAction<GetTableResponse> CreateTable([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName = null, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTableResponse> __BuildCreateTable(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName = null, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: false);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTableResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(tableName);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEntity))]
        public IWorkflowAction DeleteEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null, [WorkflowExpression] Func<string> ifMatch = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> partitionKey, WorkflowValue<string> rowKey, WorkflowValue<string> xMsClientRequestId = null, WorkflowValue<string> ifMatch = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowValue.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            WorkflowValue.Validate(ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                if (ifMatch != null)
                    callPayload.Headers["If-Match"] = ExpressionConverter.Convert(ifMatch);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTable))]
        public IWorkflowAction DeleteTable([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTable(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntities))]
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntities([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntitiesResponse> __BuildGetEntities(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> xMsClientRequestId = null, WorkflowValue<string> filter = null, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntitiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                return new ApiConnectionAction<GetEntitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntity))]
        public IBodyWorkflowAction<GetEntityResponse> GetEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntityResponse> __BuildGetEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> partitionKey, WorkflowValue<string> rowKey, WorkflowValue<string> xMsClientRequestId = null, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowValue.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                return new ApiConnectionAction<GetEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildGetTable))]
        public IBodyWorkflowAction<GetTableResponse> GetTable([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTableResponse> __BuildGetTable(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTableResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<GetTablesResponse> GetTables([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTablesResponse> __BuildGetTables(WorkflowValue<string> storageAccountName, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTablesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                return new ApiConnectionAction<GetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildInsertMergeEntity))]
        public IWorkflowAction InsertMergeEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildInsertMergeEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> partitionKey, WorkflowValue<string> rowKey, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowValue.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildInsertReplaceEntity))]
        public IWorkflowAction InsertReplaceEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildInsertReplaceEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> partitionKey, WorkflowValue<string> rowKey, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowValue.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildMergeEntity))]
        public IWorkflowAction MergeEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMergeEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> partitionKey, WorkflowValue<string> rowKey, WorkflowValue<string> ifMatch, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowValue.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowValue.Validate(ifMatch, nameof(ifMatch), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(ifMatch);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceEntity))]
        public IWorkflowAction ReplaceEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplaceEntity(WorkflowValue<string> storageAccountName, WorkflowValue<string> tableName, WorkflowValue<string> partitionKey, WorkflowValue<string> rowKey, WorkflowValue<string> ifMatch, WorkflowValue<string> xMsClientRequestId = null)
        {
            WorkflowValue.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowValue.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowValue.Validate(ifMatch, nameof(ifMatch), required: true);
            WorkflowValue.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(ifMatch);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzuretablesTriggers([ConnectionName] string connectionId)
    {
    }

    public class InsertEntityResponse
    {
        [JsonProperty("odata.metadata")]
        public string EntityMetadataLocation { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

        [JsonProperty("additionalProperties")]
        public string EntityData { get; set; }
    }

    public class GetTableResponse
    {
        [JsonProperty("odata.id")]
        public string TableLocation { get; set; }
        public string TableName { get; set; }
    }

    public class GetEntitiesResponse
    {
        [JsonProperty("odata.metadata")]
        public string TableMetadataLocation { get; set; }

        [JsonProperty("value")]
        public Item[] ListOfEntities { get; set; }
    }

    public class Item
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

        [JsonProperty("additionalProperties")]
        public string EntityData { get; set; }
    }

    public class GetEntityResponse
    {
        [JsonProperty("odata.metadata")]
        public string TableMetadataLocation { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

        [JsonProperty("additionalProperties")]
        public string EntityData { get; set; }
    }

    public class GetTablesResponse
    {
        [JsonProperty("odata.metadata")]
        public string AccountMetadataLocation { get; set; }

        [JsonProperty("value")]
        public GetTablesResponseListOfTablesTypeItem[] ListOfTables { get; set; }
    }

    public class GetTablesResponseListOfTablesTypeItem
    {
        [JsonProperty("odata.id")]
        public string TableLocation { get; set; }
        public string TableName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuretables;

    public partial class WorkflowManagedActions
    {
        public AzuretablesActions Azuretables(string connectionId) => new AzuretablesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuretablesTriggers Azuretables(string connectionId) => new AzuretablesTriggers(connectionId);
    }
}

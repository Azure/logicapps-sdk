//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuretables
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzuretablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<InsertEntityResponse> CreateEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<InsertEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
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
        public IBodyWorkflowAction<GetTableResponse> CreateTable(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName = null, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: false);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTableResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tableName);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction DeleteEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> ifMatch = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = rowKey == null ? null : WorkflowExpression.Compile(rowKey);
            WorkflowExpression.Validate(__workflow_rowKey, nameof(rowKey), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            var __workflow_ifMatch = ifMatch == null ? null : WorkflowExpression.Compile(ifMatch);
            WorkflowExpression.Validate(__workflow_ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rowKey, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                if (__workflow_ifMatch != null)
                    callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction DeleteTable(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntities(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntitiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction<GetEntitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntityResponse> GetEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> select = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = rowKey == null ? null : WorkflowExpression.Compile(rowKey);
            WorkflowExpression.Validate(__workflow_rowKey, nameof(rowKey), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rowKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction<GetEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTableResponse> GetTable(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTableResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTablesResponse> GetTables(Expression<Func<string>> storageAccountName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTablesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction<GetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction InsertMergeEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = rowKey == null ? null : WorkflowExpression.Compile(rowKey);
            WorkflowExpression.Validate(__workflow_rowKey, nameof(rowKey), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rowKey, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
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
        public IWorkflowAction InsertReplaceEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = rowKey == null ? null : WorkflowExpression.Compile(rowKey);
            WorkflowExpression.Validate(__workflow_rowKey, nameof(rowKey), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rowKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
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
        public IWorkflowAction MergeEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = rowKey == null ? null : WorkflowExpression.Compile(rowKey);
            WorkflowExpression.Validate(__workflow_rowKey, nameof(rowKey), required: true);
            var __workflow_ifMatch = ifMatch == null ? null : WorkflowExpression.Compile(ifMatch);
            WorkflowExpression.Validate(__workflow_ifMatch, nameof(ifMatch), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rowKey, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
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
        public IWorkflowAction ReplaceEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = partitionKey == null ? null : WorkflowExpression.Compile(partitionKey);
            WorkflowExpression.Validate(__workflow_partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = rowKey == null ? null : WorkflowExpression.Compile(rowKey);
            WorkflowExpression.Validate(__workflow_rowKey, nameof(rowKey), required: true);
            var __workflow_ifMatch = ifMatch == null ? null : WorkflowExpression.Compile(ifMatch);
            WorkflowExpression.Validate(__workflow_ifMatch, nameof(ifMatch), required: true);
            var __workflow_xMsClientRequestId = xMsClientRequestId == null ? null : WorkflowExpression.Compile(xMsClientRequestId);
            WorkflowExpression.Validate(__workflow_xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rowKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
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

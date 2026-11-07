//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuretables
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuretablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<InsertEntityResponse, ApiConnectionActionConfiguration> CreateEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<InsertEntityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<InsertEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTableResponse, ApiConnectionActionConfiguration> CreateTable(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables", __workflow_storageAccountName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tableName);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> ifMatch = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1), __workflow_partitionKey.WithUrlEncoding(1), __workflow_rowKey.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTable(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntitiesResponse, ApiConnectionActionConfiguration> GetEntities(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<GetEntityResponse, ApiConnectionActionConfiguration> GetEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> select = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1), __workflow_partitionKey.WithUrlEncoding(1), __workflow_rowKey.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<GetTableResponse, ApiConnectionActionConfiguration> GetTable(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTablesResponse, ApiConnectionActionConfiguration> GetTables(Expression<Func<string>> storageAccountName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredBodyAction<GetTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables", __workflow_storageAccountName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                return new ApiConnectionAction<GetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InsertMergeEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<object>> entity, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1), __workflow_partitionKey.WithUrlEncoding(1), __workflow_rowKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InsertReplaceEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<object>> entity, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1), __workflow_partitionKey.WithUrlEncoding(1), __workflow_rowKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MergeEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<object>> entity, Expression<Func<string>> ifMatch, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1), __workflow_partitionKey.WithUrlEncoding(1), __workflow_rowKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceEntity(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch, Expression<Func<object>> entity, Expression<Func<string>> xMsClientRequestId = null)
        {
            var __workflow_storageAccountName = WorkflowExpression.Compile(storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_xMsClientRequestId = WorkflowExpression.Compile(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", __workflow_storageAccountName.WithUrlEncoding(2), __workflow_tableName.WithUrlEncoding(1), __workflow_partitionKey.WithUrlEncoding(1), __workflow_rowKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                if (__workflow_xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(__workflow_xMsClientRequestId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
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
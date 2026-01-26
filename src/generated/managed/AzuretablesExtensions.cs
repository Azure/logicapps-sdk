//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuretables
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuretablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTablesResponse> GetTablesV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            return new ApiConnectionAction<GetTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTableResponse> CreateTableV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName = null, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            callPayload.Body = ExpressionConverter.ConvertO(tableName);
            return new ApiConnectionAction<GetTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTableResponse> GetTableV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            return new ApiConnectionAction<GetTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction DeleteTableV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntitiesV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            return new ApiConnectionAction<GetEntitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<InsertEntityResponse> CreateEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntityResponse> GetEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            return new ApiConnectionAction<GetEntityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction InsertReplaceEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction InsertMergeEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction ReplaceEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction DeleteEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> xMsClientRequestId = null, Expression<Func<string>> ifMatch = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsClientRequestId != null)
                callPayload.Headers["x-ms-client-request-id"] = ExpressionConverter.Convert(xMsClientRequestId);
            if (ifMatch != null)
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(ifMatch);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction MergeEntityV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch, Expression<Func<string>> xMsClientRequestId = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(partitionKey, 1), ExpressionConverter.ConvertWithUrlEncoding(rowKey, 1));
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
        }
    }

    public class AzuretablesTriggers([ConnectionName] string connectionId)
    {
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

    public class InsertEntityResponse
    {
        [JsonProperty("odata.metadata")]
        public string EntityMetadataLocation { get; set; }
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
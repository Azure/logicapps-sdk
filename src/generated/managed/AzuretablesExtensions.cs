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
        public IBodyWorkflowAction<InsertEntityResponse> CreateEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertEntityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTableResponse> CreateTable([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName = null, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: false);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(tableName);
                return callPayload;
            }

            return new ApiConnectionAction<GetTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction DeleteEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null, [WorkflowExpression] Func<string> ifMatch = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partitionKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                if (ifMatch != null)
                    callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction DeleteTable([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntities([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEntitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetEntityResponse> GetEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partitionKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEntityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTableResponse> GetTable([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IBodyWorkflowAction<GetTablesResponse> GetTables([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction InsertMergeEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partitionKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction InsertReplaceEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities(PartitionKey='{2}',RowKey='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partitionKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction MergeEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partitionKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuretables")]
        public IWorkflowAction ReplaceEntity([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> xMsClientRequestId = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: true);
            SourceExpression.Validate(xMsClientRequestId, nameof(xMsClientRequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/tables/{1}/entities/etag(PartitionKey='{2}',RowKey='{3}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partitionKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rowKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                if (xMsClientRequestId != null)
                    callPayload.Headers["x-ms-client-request-id"] = SourceExpressionConverter.ConvertO(xMsClientRequestId);
                var entity = new JObject();
                var entitypropCount = 0;
                if (entitypropCount > 0)
                {
                    callPayload.Body = entity;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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
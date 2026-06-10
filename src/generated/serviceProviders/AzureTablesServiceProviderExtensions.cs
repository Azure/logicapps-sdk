//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureTables
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureTablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<CreateTableOutput> CreateTable(Expression<Func<string>> tableName, Expression<Func<bool>> failIfTableExists = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (failIfTableExists != null)
            {
                parameters["failIfTableExists"] = ExpressionConverter.ConvertO(failIfTableExists);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "createTable", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateTableOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<ListTablesOutput> ListTables(Expression<Func<string>> continuationToken = null, Expression<Func<string>> filter = null, Expression<Func<int>> top = null)
        {
            var parameters = new JObject();
            if (continuationToken != null)
            {
                parameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            if (filter != null)
            {
                parameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            if (top != null)
            {
                parameters["top"] = ExpressionConverter.ConvertO(top);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "listTables", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListTablesOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction DeleteTable(Expression<Func<string>> tableName)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteTable", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpsertEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<bool>> failIfEntityExists = null, Expression<Func<UpsertEntityUpdateModeType>> updateMode = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            parameters["entity"] = ExpressionConverter.ConvertO(entity);
            if (failIfEntityExists != null)
            {
                parameters["failIfEntityExists"] = ExpressionConverter.ConvertO(failIfEntityExists);
            }

            if (updateMode != null)
            {
                parameters["updateMode"] = ExpressionConverter.ConvertO(updateMode);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "upsertEntity", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpdateEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<UpdateEntityUpdateModeType>> updateMode = null, Expression<Func<string>> ifMatch = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            parameters["entity"] = ExpressionConverter.ConvertO(entity);
            if (updateMode != null)
            {
                parameters["updateMode"] = ExpressionConverter.ConvertO(updateMode);
            }

            if (ifMatch != null)
            {
                parameters["ifMatch"] = ExpressionConverter.ConvertO(ifMatch);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "updateEntity", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction DeleteEntity(Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            parameters["rowKey"] = ExpressionConverter.ConvertO(rowKey);
            if (ifMatch != null)
            {
                parameters["ifMatch"] = ExpressionConverter.ConvertO(ifMatch);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteEntity", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<GetEntityOutput> GetEntity(Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string[]>> select = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            parameters["rowKey"] = ExpressionConverter.ConvertO(rowKey);
            if (select != null)
            {
                parameters["select"] = ExpressionConverter.ConvertO(select);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "getEntity", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetEntityOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<QueryEntitiesOutput> QueryEntities(Expression<Func<string>> tableName, Expression<Func<string>> continuationToken = null, Expression<Func<string>> filter = null, Expression<Func<string[]>> select = null, Expression<Func<int>> top = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (continuationToken != null)
            {
                parameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            if (filter != null)
            {
                parameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            if (select != null)
            {
                parameters["select"] = ExpressionConverter.ConvertO(select);
            }

            if (top != null)
            {
                parameters["top"] = ExpressionConverter.ConvertO(top);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "queryEntities", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<QueryEntitiesOutput>(input);
        }
    }

    public class AzureTablesTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateTableOutput
    {
        [JsonProperty("tableName")]
        public string TableName { get; set; }
    }

    public class ListTablesOutput
    {
        [JsonProperty("tables")]
        public ListTablesOutputTablesTypeItem[] Tables { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }

    public class ListTablesOutputTablesTypeItem
    {
        [JsonProperty("tableName")]
        public string TableName { get; set; }
    }

    public enum UpsertEntityUpdateModeType
    {
        Merge,
        Replace
    }

    public enum UpdateEntityUpdateModeType
    {
        Merge,
        Replace
    }

    public class GetEntityOutput
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Timestamp { get; set; }

        [JsonProperty("odata.etag")]
        public string Etag { get; set; }
    }

    public class QueryEntitiesOutput
    {
        [JsonProperty("entities")]
        public QueryEntitiesOutputEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }

    public class QueryEntitiesOutputEntitiesTypeItem
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Timestamp { get; set; }

        [JsonProperty("odata.etag")]
        public string Etag { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureTables;

    public partial class WorkflowServiceProviderActions
    {
        public AzureTablesActions AzureTables(string connectionId) => new AzureTablesActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureTablesTriggers AzureTables(string connectionId) => new AzureTablesTriggers(connectionId);
    }
}
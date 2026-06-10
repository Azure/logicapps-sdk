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
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (failIfTableExists != null)
            {
                serviceProviderParameters["failIfTableExists"] = ExpressionConverter.ConvertO(failIfTableExists);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "createTable", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateTableOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<ListTablesOutput> ListTables(Expression<Func<string>> continuationToken = null, Expression<Func<string>> filter = null, Expression<Func<int>> top = null)
        {
            var serviceProviderParameters = new JObject();
            if (continuationToken != null)
            {
                serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            if (top != null)
            {
                serviceProviderParameters["top"] = ExpressionConverter.ConvertO(top);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "listTables", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListTablesOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction DeleteTable(Expression<Func<string>> tableName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteTable", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpsertEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<bool>> failIfEntityExists = null, Expression<Func<UpsertEntityUpdateModeType>> updateMode = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            serviceProviderParameters["entity"] = ExpressionConverter.ConvertO(entity);
            if (failIfEntityExists != null)
            {
                serviceProviderParameters["failIfEntityExists"] = ExpressionConverter.ConvertO(failIfEntityExists);
            }

            if (updateMode != null)
            {
                serviceProviderParameters["updateMode"] = ExpressionConverter.ConvertO(updateMode);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "upsertEntity", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpdateEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<UpdateEntityUpdateModeType>> updateMode = null, Expression<Func<string>> ifMatch = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            serviceProviderParameters["entity"] = ExpressionConverter.ConvertO(entity);
            if (updateMode != null)
            {
                serviceProviderParameters["updateMode"] = ExpressionConverter.ConvertO(updateMode);
            }

            if (ifMatch != null)
            {
                serviceProviderParameters["ifMatch"] = ExpressionConverter.ConvertO(ifMatch);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "updateEntity", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction DeleteEntity(Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            serviceProviderParameters["rowKey"] = ExpressionConverter.ConvertO(rowKey);
            if (ifMatch != null)
            {
                serviceProviderParameters["ifMatch"] = ExpressionConverter.ConvertO(ifMatch);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteEntity", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<GetEntityOutput> GetEntity(Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string[]>> select = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            serviceProviderParameters["rowKey"] = ExpressionConverter.ConvertO(rowKey);
            if (select != null)
            {
                serviceProviderParameters["select"] = ExpressionConverter.ConvertO(select);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "getEntity", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetEntityOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<QueryEntitiesOutput> QueryEntities(Expression<Func<string>> tableName, Expression<Func<string>> continuationToken = null, Expression<Func<string>> filter = null, Expression<Func<string[]>> select = null, Expression<Func<int>> top = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (continuationToken != null)
            {
                serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(filter);
            }

            if (select != null)
            {
                serviceProviderParameters["select"] = ExpressionConverter.ConvertO(select);
            }

            if (top != null)
            {
                serviceProviderParameters["top"] = ExpressionConverter.ConvertO(top);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "queryEntities", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<QueryEntitiesOutput>(serviceProviderInput);
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
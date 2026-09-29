//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureTables
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureTablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<CreateTableOutput> CreateTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<bool> failIfTableExists = null)
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
        public IBodyWorkflowAction<ListTablesOutput> ListTables([WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null)
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
        public IWorkflowAction DeleteTable([WorkflowExpression] Func<string> tableName)
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
        public IWorkflowAction UpsertEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> entity, [WorkflowExpression] Func<bool> failIfEntityExists = null, [WorkflowExpression] Func<UpsertEntityInputUpdateModeType> updateMode = null)
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
        public IWorkflowAction UpdateEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> entity, [WorkflowExpression] Func<UpdateEntityInputUpdateModeType> updateMode = null, [WorkflowExpression] Func<string> ifMatch = null)
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
        public IWorkflowAction DeleteEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch = null)
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
        public IBodyWorkflowAction<GetEntityOutput> GetEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string[]> select = null)
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
        public IBodyWorkflowAction<QueryEntitiesOutput> QueryEntities([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string[]> select = null, [WorkflowExpression] Func<int> top = null)
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpsertEntityInputUpdateModeType
    {
        Merge,
        Replace
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpdateEntityInputUpdateModeType
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
}
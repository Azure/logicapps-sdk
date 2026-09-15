//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureTables
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureTablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<CreateTableOutput> CreateTable(Expression<Func<string>> tableName, Expression<Func<bool>> failIfTableExists = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            if (failIfTableExists != null)
            {
                serviceProviderParameters["failIfTableExists"] = CSharpExpressionConverter.ConvertToken(failIfTableExists);
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
                serviceProviderParameters["continuationToken"] = CSharpExpressionConverter.ConvertToken(continuationToken);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = CSharpExpressionConverter.ConvertToken(filter);
            }

            if (top != null)
            {
                serviceProviderParameters["top"] = CSharpExpressionConverter.ConvertToken(top);
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
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteTable", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpsertEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<bool>> failIfEntityExists = null, Expression<Func<UpsertEntityInputUpdateModeType>> updateMode = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            serviceProviderParameters["entity"] = CSharpExpressionConverter.ConvertToken(entity);
            if (failIfEntityExists != null)
            {
                serviceProviderParameters["failIfEntityExists"] = CSharpExpressionConverter.ConvertToken(failIfEntityExists);
            }

            if (updateMode != null)
            {
                serviceProviderParameters["updateMode"] = CSharpExpressionConverter.ConvertToken(updateMode);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "upsertEntity", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpdateEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<UpdateEntityInputUpdateModeType>> updateMode = null, Expression<Func<string>> ifMatch = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            serviceProviderParameters["entity"] = CSharpExpressionConverter.ConvertToken(entity);
            if (updateMode != null)
            {
                serviceProviderParameters["updateMode"] = CSharpExpressionConverter.ConvertToken(updateMode);
            }

            if (ifMatch != null)
            {
                serviceProviderParameters["ifMatch"] = CSharpExpressionConverter.ConvertToken(ifMatch);
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
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            serviceProviderParameters["rowKey"] = CSharpExpressionConverter.ConvertToken(rowKey);
            if (ifMatch != null)
            {
                serviceProviderParameters["ifMatch"] = CSharpExpressionConverter.ConvertToken(ifMatch);
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
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            serviceProviderParameters["rowKey"] = CSharpExpressionConverter.ConvertToken(rowKey);
            if (select != null)
            {
                serviceProviderParameters["select"] = CSharpExpressionConverter.ConvertToken(select);
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
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            if (continuationToken != null)
            {
                serviceProviderParameters["continuationToken"] = CSharpExpressionConverter.ConvertToken(continuationToken);
            }

            if (filter != null)
            {
                serviceProviderParameters["filter"] = CSharpExpressionConverter.ConvertToken(filter);
            }

            if (select != null)
            {
                serviceProviderParameters["select"] = CSharpExpressionConverter.ConvertToken(select);
            }

            if (top != null)
            {
                serviceProviderParameters["top"] = CSharpExpressionConverter.ConvertToken(top);
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
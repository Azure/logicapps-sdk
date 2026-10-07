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
        [WorkflowExpressionFactory(nameof(__BuildCreateTable))]
        public IBodyWorkflowAction<CreateTableOutput> CreateTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<bool> failIfTableExists = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTableOutput> __BuildCreateTable(WorkflowExpression<string> tableName, WorkflowExpression<bool> failIfTableExists = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(failIfTableExists, nameof(failIfTableExists), required: false);
            return new DeferredBodyAction<CreateTableOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildListTables))]
        public IBodyWorkflowAction<ListTablesOutput> ListTables([WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTablesOutput> __BuildListTables(WorkflowExpression<string> continuationToken = null, WorkflowExpression<string> filter = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListTablesOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTable))]
        public IWorkflowAction DeleteTable([WorkflowExpression] Func<string> tableName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTable(WorkflowExpression<string> tableName)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteTable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildUpsertEntity))]
        public IWorkflowAction UpsertEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> entity, [WorkflowExpression] Func<bool> failIfEntityExists = null, [WorkflowExpression] Func<UpsertEntityInputUpdateModeType> updateMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpsertEntity(WorkflowExpression<string> tableName, WorkflowExpression<object> entity, WorkflowExpression<bool> failIfEntityExists = null, WorkflowExpression<UpsertEntityInputUpdateModeType> updateMode = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(failIfEntityExists, nameof(failIfEntityExists), required: false);
            WorkflowExpression.Validate(updateMode, nameof(updateMode), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEntity))]
        public IWorkflowAction UpdateEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> entity, [WorkflowExpression] Func<UpdateEntityInputUpdateModeType> updateMode = null, [WorkflowExpression] Func<string> ifMatch = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateEntity(WorkflowExpression<string> tableName, WorkflowExpression<object> entity, WorkflowExpression<UpdateEntityInputUpdateModeType> updateMode = null, WorkflowExpression<string> ifMatch = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(updateMode, nameof(updateMode), required: false);
            WorkflowExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEntity))]
        public IWorkflowAction DeleteEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEntity(WorkflowExpression<string> tableName, WorkflowExpression<string> partitionKey, WorkflowExpression<string> rowKey, WorkflowExpression<string> ifMatch = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowExpression.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntity))]
        public IBodyWorkflowAction<GetEntityOutput> GetEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string[]> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntityOutput> __BuildGetEntity(WorkflowExpression<string> tableName, WorkflowExpression<string> partitionKey, WorkflowExpression<string> rowKey, WorkflowExpression<string[]> select = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowExpression.Validate(rowKey, nameof(rowKey), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntityOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [WorkflowExpressionFactory(nameof(__BuildQueryEntities))]
        public IBodyWorkflowAction<QueryEntitiesOutput> QueryEntities([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string[]> select = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryEntitiesOutput> __BuildQueryEntities(WorkflowExpression<string> tableName, WorkflowExpression<string> continuationToken = null, WorkflowExpression<string> filter = null, WorkflowExpression<string[]> select = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(tableName, nameof(tableName), required: true);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<QueryEntitiesOutput>(() =>
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
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpsertEntityInputUpdateModeType
    {
        Merge,
        Replace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
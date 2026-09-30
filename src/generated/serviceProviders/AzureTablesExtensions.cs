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
        public IBodyWorkflowAction<CreateTableOutput> CreateTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<bool> failIfTableExists = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(failIfTableExists, nameof(failIfTableExists), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (failIfTableExists != null)
                {
                    serviceProviderParameters["failIfTableExists"] = SourceExpressionConverter.ConvertToken(failIfTableExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "createTable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateTableOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction DeleteEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string> ifMatch = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                serviceProviderParameters["rowKey"] = SourceExpressionConverter.ConvertToken(rowKey);
                if (ifMatch != null)
                {
                    serviceProviderParameters["ifMatch"] = SourceExpressionConverter.ConvertToken(ifMatch);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction DeleteTable([WorkflowExpression] Func<string> tableName)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteTable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<GetEntityOutput> GetEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> rowKey, [WorkflowExpression] Func<string[]> select = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(rowKey, nameof(rowKey), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                serviceProviderParameters["rowKey"] = SourceExpressionConverter.ConvertToken(rowKey);
                if (select != null)
                {
                    serviceProviderParameters["select"] = SourceExpressionConverter.ConvertToken(select);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "getEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetEntityOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<ListTablesOutput> ListTables([WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = SourceExpressionConverter.ConvertToken(continuationToken);
                }

                if (filter != null)
                {
                    serviceProviderParameters["filter"] = SourceExpressionConverter.ConvertToken(filter);
                }

                if (top != null)
                {
                    serviceProviderParameters["top"] = SourceExpressionConverter.ConvertToken(top);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "listTables", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListTablesOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<QueryEntitiesOutput> QueryEntities([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string[]> select = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = SourceExpressionConverter.ConvertToken(continuationToken);
                }

                if (filter != null)
                {
                    serviceProviderParameters["filter"] = SourceExpressionConverter.ConvertToken(filter);
                }

                if (select != null)
                {
                    serviceProviderParameters["select"] = SourceExpressionConverter.ConvertToken(select);
                }

                if (top != null)
                {
                    serviceProviderParameters["top"] = SourceExpressionConverter.ConvertToken(top);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "queryEntities", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<QueryEntitiesOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpdateEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> entity, [WorkflowExpression] Func<UpdateEntityInputUpdateModeType> updateMode = null, [WorkflowExpression] Func<string> ifMatch = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(updateMode, nameof(updateMode), required: false);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                serviceProviderParameters["entity"] = SourceExpressionConverter.ConvertToken(entity);
                if (updateMode != null)
                {
                    serviceProviderParameters["updateMode"] = SourceExpressionConverter.ConvertToken(updateMode);
                }

                if (ifMatch != null)
                {
                    serviceProviderParameters["ifMatch"] = SourceExpressionConverter.ConvertToken(ifMatch);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "updateEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction UpsertEntity([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> entity, [WorkflowExpression] Func<bool> failIfEntityExists = null, [WorkflowExpression] Func<UpsertEntityInputUpdateModeType> updateMode = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(failIfEntityExists, nameof(failIfEntityExists), required: false);
            SourceExpression.Validate(updateMode, nameof(updateMode), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                serviceProviderParameters["entity"] = SourceExpressionConverter.ConvertToken(entity);
                if (failIfEntityExists != null)
                {
                    serviceProviderParameters["failIfEntityExists"] = SourceExpressionConverter.ConvertToken(failIfEntityExists);
                }

                if (updateMode != null)
                {
                    serviceProviderParameters["updateMode"] = SourceExpressionConverter.ConvertToken(updateMode);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "upsertEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }
    }

    public class CreateTableOutput
    {
        [JsonProperty("tableName")]
        public string TableName { get; set; }
    }

    public class GetEntityOutput
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Timestamp { get; set; }

        [JsonProperty("odata.etag")]
        public string Etag { get; set; }
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpdateEntityInputUpdateModeType
    {
        Merge,
        Replace
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpsertEntityInputUpdateModeType
    {
        Merge,
        Replace
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
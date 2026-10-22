//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureTables
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureTablesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<CreateTableOutput, CreateTableActionConfiguration> CreateTable(Expression<Func<string>> tableName, Expression<Func<bool>> failIfTableExists = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_failIfTableExists = WorkflowExpression.Compile(failIfTableExists, nameof(failIfTableExists), required: false);
            return new DeferredBodyAction<CreateTableOutput, CreateTableActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_failIfTableExists != null)
                {
                    serviceProviderParameters["failIfTableExists"] = ExpressionConverter.ConvertO(__workflow_failIfTableExists);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "createTable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<CreateTableOutput, CreateTableActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<ListTablesOutput, ListTablesActionConfiguration> ListTables(Expression<Func<string>> continuationToken = null, Expression<Func<string>> filter = null, Expression<Func<int>> top = null)
        {
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListTablesOutput, ListTablesActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(__workflow_continuationToken);
                }

                if (__workflow_filter != null)
                {
                    serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(__workflow_filter);
                }

                if (__workflow_top != null)
                {
                    serviceProviderParameters["top"] = ExpressionConverter.ConvertO(__workflow_top);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "listTables", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<ListTablesOutput, ListTablesActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction<DeleteTableActionConfiguration> DeleteTable(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredWorkflowAction<DeleteTableActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteTable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteTableActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction<UpsertEntityActionConfiguration> UpsertEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<bool>> failIfEntityExists = null, Expression<Func<UpsertEntityInputUpdateModeType>> updateMode = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_failIfEntityExists = WorkflowExpression.Compile(failIfEntityExists, nameof(failIfEntityExists), required: false);
            var __workflow_updateMode = WorkflowExpression.Compile(updateMode, nameof(updateMode), required: false);
            return new DeferredWorkflowAction<UpsertEntityActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                serviceProviderParameters["entity"] = ExpressionConverter.ConvertO(__workflow_entity);
                if (__workflow_failIfEntityExists != null)
                {
                    serviceProviderParameters["failIfEntityExists"] = ExpressionConverter.ConvertO(__workflow_failIfEntityExists);
                }

                if (__workflow_updateMode != null)
                {
                    serviceProviderParameters["updateMode"] = ExpressionConverter.ConvertO(__workflow_updateMode);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "upsertEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UpsertEntityActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction<UpdateEntityActionConfiguration> UpdateEntity(Expression<Func<string>> tableName, Expression<Func<object>> entity, Expression<Func<UpdateEntityInputUpdateModeType>> updateMode = null, Expression<Func<string>> ifMatch = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_updateMode = WorkflowExpression.Compile(updateMode, nameof(updateMode), required: false);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction<UpdateEntityActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                serviceProviderParameters["entity"] = ExpressionConverter.ConvertO(__workflow_entity);
                if (__workflow_updateMode != null)
                {
                    serviceProviderParameters["updateMode"] = ExpressionConverter.ConvertO(__workflow_updateMode);
                }

                if (__workflow_ifMatch != null)
                {
                    serviceProviderParameters["ifMatch"] = ExpressionConverter.ConvertO(__workflow_ifMatch);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "updateEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<UpdateEntityActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IWorkflowAction<DeleteEntityActionConfiguration> DeleteEntity(Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string>> ifMatch = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: false);
            return new DeferredWorkflowAction<DeleteEntityActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                serviceProviderParameters["rowKey"] = ExpressionConverter.ConvertO(__workflow_rowKey);
                if (__workflow_ifMatch != null)
                {
                    serviceProviderParameters["ifMatch"] = ExpressionConverter.ConvertO(__workflow_ifMatch);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "deleteEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteEntityActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<GetEntityOutput, GetEntityActionConfiguration> GetEntity(Expression<Func<string>> tableName, Expression<Func<string>> partitionKey, Expression<Func<string>> rowKey, Expression<Func<string[]>> select = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_rowKey = WorkflowExpression.Compile(rowKey, nameof(rowKey), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetEntityOutput, GetEntityActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                serviceProviderParameters["rowKey"] = ExpressionConverter.ConvertO(__workflow_rowKey);
                if (__workflow_select != null)
                {
                    serviceProviderParameters["select"] = ExpressionConverter.ConvertO(__workflow_select);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "getEntity", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetEntityOutput, GetEntityActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureTables")]
        public IBodyWorkflowAction<QueryEntitiesOutput, QueryEntitiesActionConfiguration> QueryEntities(Expression<Func<string>> tableName, Expression<Func<string>> continuationToken = null, Expression<Func<string>> filter = null, Expression<Func<string[]>> select = null, Expression<Func<int>> top = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<QueryEntitiesOutput, QueryEntitiesActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(__workflow_continuationToken);
                }

                if (__workflow_filter != null)
                {
                    serviceProviderParameters["filter"] = ExpressionConverter.ConvertO(__workflow_filter);
                }

                if (__workflow_select != null)
                {
                    serviceProviderParameters["select"] = ExpressionConverter.ConvertO(__workflow_select);
                }

                if (__workflow_top != null)
                {
                    serviceProviderParameters["top"] = ExpressionConverter.ConvertO(__workflow_top);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureTables", operationId: "queryEntities", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<QueryEntitiesOutput, QueryEntitiesActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class CreateTableActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ListTablesActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class DeleteTableActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class UpsertEntityActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class UpdateEntityActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class DeleteEntityActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetEntityActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class QueryEntitiesActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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
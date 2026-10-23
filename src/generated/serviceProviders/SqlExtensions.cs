//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[], ExecuteQueryActionConfiguration> ExecuteQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_queryParameters = WorkflowExpression.Compile(queryParameters, nameof(queryParameters), required: false);
            return new DeferredBodyAction<JToken[], ExecuteQueryActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["query"] = ExpressionConverter.ConvertO(__workflow_query);
                if (__workflow_queryParameters != null)
                {
                    serviceProviderParameters["queryParameters"] = ExpressionConverter.ConvertO(__workflow_queryParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken[], ExecuteQueryActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IWorkflowAction<InsertRowActionConfiguration> InsertRow(Expression<Func<string>> tableName, Expression<Func<object>> setColumns = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_setColumns = WorkflowExpression.Compile(setColumns, nameof(setColumns), required: false);
            return new DeferredWorkflowAction<InsertRowActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_setColumns != null)
                {
                    serviceProviderParameters["setColumns"] = ExpressionConverter.ConvertO(__workflow_setColumns);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<InsertRowActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[], DeleteRowsActionConfiguration> DeleteRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_primaryKey = WorkflowExpression.Compile(primaryKey, nameof(primaryKey), required: false);
            return new DeferredBodyAction<JToken[], DeleteRowsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(__workflow_columnValuesForWhereCondition);
                }

                if (__workflow_primaryKey != null)
                {
                    serviceProviderParameters["primaryKey"] = ExpressionConverter.ConvertO(__workflow_primaryKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "deleteRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken[], DeleteRowsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[], GetRowsActionConfiguration> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null, Expression<Func<object>> queries = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_primaryKey = WorkflowExpression.Compile(primaryKey, nameof(primaryKey), required: false);
            var __workflow_queries = WorkflowExpression.Compile(queries, nameof(queries), required: false);
            return new DeferredBodyAction<JToken[], GetRowsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(__workflow_columnValuesForWhereCondition);
                }

                if (__workflow_primaryKey != null)
                {
                    serviceProviderParameters["primaryKey"] = ExpressionConverter.ConvertO(__workflow_primaryKey);
                }

                if (__workflow_queries != null)
                {
                    serviceProviderParameters["queries"] = ExpressionConverter.ConvertO(__workflow_queries);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken[], GetRowsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetRowsV2Output, GetRowsV2ActionConfiguration> GetRowsV2(Expression<Func<string>> tableName, Expression<Func<object>> queries = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_queries = WorkflowExpression.Compile(queries, nameof(queries), required: false);
            return new DeferredBodyAction<GetRowsV2Output, GetRowsV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_queries != null)
                {
                    serviceProviderParameters["queries"] = ExpressionConverter.ConvertO(__workflow_queries);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRowsV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetRowsV2Output, GetRowsV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[], UpdateRowsActionConfiguration> UpdateRows(Expression<Func<string>> tableName, Expression<Func<object>> setColumns, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_setColumns = WorkflowExpression.Compile(setColumns, nameof(setColumns), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_primaryKey = WorkflowExpression.Compile(primaryKey, nameof(primaryKey), required: false);
            return new DeferredBodyAction<JToken[], UpdateRowsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(__workflow_columnValuesForWhereCondition);
                }

                serviceProviderParameters["setColumns"] = ExpressionConverter.ConvertO(__workflow_setColumns);
                if (__workflow_primaryKey != null)
                {
                    serviceProviderParameters["primaryKey"] = ExpressionConverter.ConvertO(__workflow_primaryKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "updateRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken[], UpdateRowsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesOutputItem[], GetTablesActionConfiguration> GetTables()
        {
            return new DeferredBodyAction<GetTablesOutputItem[], GetTablesActionConfiguration>(() =>
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getTables", connectionName: connectionId)
                };
                return new ServiceProviderBodyAction<GetTablesOutputItem[], GetTablesActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput, ExecuteStoredProcedureActionConfiguration> ExecuteStoredProcedure(Expression<Func<string>> storedProcedureName, Expression<Func<object>> storedProcedureParameters = null, Expression<Func<bool>> includeEmptyResultSets = null)
        {
            var __workflow_storedProcedureName = WorkflowExpression.Compile(storedProcedureName, nameof(storedProcedureName), required: true);
            var __workflow_storedProcedureParameters = WorkflowExpression.Compile(storedProcedureParameters, nameof(storedProcedureParameters), required: false);
            var __workflow_includeEmptyResultSets = WorkflowExpression.Compile(includeEmptyResultSets, nameof(includeEmptyResultSets), required: false);
            return new DeferredBodyAction<ExecuteStoredProcedureOutput, ExecuteStoredProcedureActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["storedProcedureName"] = ExpressionConverter.ConvertO(__workflow_storedProcedureName);
                if (__workflow_storedProcedureParameters != null)
                {
                    serviceProviderParameters["storedProcedureParameters"] = ExpressionConverter.ConvertO(__workflow_storedProcedureParameters);
                }

                if (__workflow_includeEmptyResultSets != null)
                {
                    serviceProviderParameters["includeEmptyResultSets"] = ExpressionConverter.ConvertO(__workflow_includeEmptyResultSets);
                }
                else
                {
                    serviceProviderParameters["includeEmptyResultSets"] = true;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeStoredProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<ExecuteStoredProcedureOutput, ExecuteStoredProcedureActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class ExecuteQueryActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class InsertRowActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class DeleteRowsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class GetRowsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class GetRowsV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class UpdateRowsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class GetTablesActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public sealed class ExecuteStoredProcedureActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken[], WhenARowIsUpdatedTriggerConfiguration> WhenARowIsUpdated(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[], WhenARowIsUpdatedTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsUpdated", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<JToken[], WhenARowIsUpdatedTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<JToken[], WhenARowIsDeletedTriggerConfiguration> WhenARowIsDeleted(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[], WhenARowIsDeletedTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsDeleted", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<JToken[], WhenARowIsDeletedTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<JToken[], WhenARowIsInsertedTriggerConfiguration> WhenARowIsInserted(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[], WhenARowIsInsertedTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsInserted", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<JToken[], WhenARowIsInsertedTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<JToken[], WhenARowIsModifiedTriggerConfiguration> WhenARowIsModified(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[], WhenARowIsModifiedTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<JToken[], WhenARowIsModifiedTriggerConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class WhenARowIsUpdatedTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class WhenARowIsDeletedTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class WhenARowIsInsertedTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class WhenARowIsModifiedTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class GetRowsV2Output
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class GetTablesOutputItem
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ExecuteStoredProcedureOutput
    {
        [JsonProperty("resultSets")]
        public JToken ResultSets { get; set; }

        [JsonProperty("outputParameters")]
        public JToken OutputParameters { get; set; }

        [JsonProperty("returnCode")]
        public int ReturnCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql;

    public partial class WorkflowServiceProviderActions
    {
        public SqlActions Sql(string connectionId) => new SqlActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public SqlTriggers Sql(string connectionId) => new SqlTriggers(connectionId);
    }
}
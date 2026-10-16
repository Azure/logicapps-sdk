//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_queryParameters = WorkflowExpression.Compile(queryParameters, nameof(queryParameters), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> InsertRow(Expression<Func<string>> tableName, Expression<Func<object>> setColumns = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_setColumns = WorkflowExpression.Compile(setColumns, nameof(setColumns), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> DeleteRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_primaryKey = WorkflowExpression.Compile(primaryKey, nameof(primaryKey), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null, Expression<Func<object>> queries = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_primaryKey = WorkflowExpression.Compile(primaryKey, nameof(primaryKey), required: false);
            var __workflow_queries = WorkflowExpression.Compile(queries, nameof(queries), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetRowsV2Output> GetRowsV2(Expression<Func<string>> tableName, Expression<Func<object>> queries = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_queries = WorkflowExpression.Compile(queries, nameof(queries), required: false);
            return new DeferredBodyAction<GetRowsV2Output>(() =>
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
                return new ServiceProviderAction<GetRowsV2Output>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> UpdateRows(Expression<Func<string>> tableName, Expression<Func<object>> setColumns, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_setColumns = WorkflowExpression.Compile(setColumns, nameof(setColumns), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_primaryKey = WorkflowExpression.Compile(primaryKey, nameof(primaryKey), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables()
        {
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getTables", connectionName: connectionId)
            };
            return new ServiceProviderAction<GetTablesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure(Expression<Func<string>> storedProcedureName, Expression<Func<object>> storedProcedureParameters = null, Expression<Func<bool>> includeEmptyResultSets = null)
        {
            var __workflow_storedProcedureName = WorkflowExpression.Compile(storedProcedureName, nameof(storedProcedureName), required: true);
            var __workflow_storedProcedureParameters = WorkflowExpression.Compile(storedProcedureParameters, nameof(storedProcedureParameters), required: false);
            var __workflow_includeEmptyResultSets = WorkflowExpression.Compile(includeEmptyResultSets, nameof(includeEmptyResultSets), required: false);
            return new DeferredBodyAction<ExecuteStoredProcedureOutput>(() =>
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
                return new ServiceProviderAction<ExecuteStoredProcedureOutput>(serviceProviderInput);
            });
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken[]> WhenARowIsUpdated(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsUpdated", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsDeleted(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsDeleted", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsInserted(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsInserted", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsModified(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyTrigger<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
            });
        }
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

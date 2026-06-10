//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var parameters = new JObject();
            parameters["query"] = ExpressionConverter.ConvertO(query);
            if (queryParameters != null)
            {
                parameters["queryParameters"] = ExpressionConverter.ConvertO(queryParameters);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeQuery", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> InsertRow(Expression<Func<string>> tableName, Expression<Func<object>> setColumns = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (setColumns != null)
            {
                parameters["setColumns"] = ExpressionConverter.ConvertO(setColumns);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "insertRow", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> DeleteRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                parameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            if (primaryKey != null)
            {
                parameters["primaryKey"] = ExpressionConverter.ConvertO(primaryKey);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "deleteRows", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null, Expression<Func<object>> queries = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                parameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            if (primaryKey != null)
            {
                parameters["primaryKey"] = ExpressionConverter.ConvertO(primaryKey);
            }

            if (queries != null)
            {
                parameters["queries"] = ExpressionConverter.ConvertO(queries);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRows", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetRowsV2Output> GetRowsV2(Expression<Func<string>> tableName, Expression<Func<object>> queries = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (queries != null)
            {
                parameters["queries"] = ExpressionConverter.ConvertO(queries);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRowsV2", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetRowsV2Output>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> UpdateRows(Expression<Func<string>> tableName, Expression<Func<object>> setColumns, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<string>> primaryKey = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                parameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            parameters["setColumns"] = ExpressionConverter.ConvertO(setColumns);
            if (primaryKey != null)
            {
                parameters["primaryKey"] = ExpressionConverter.ConvertO(primaryKey);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "updateRows", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables()
        {
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getTables", connectionName: connectionId)
            };
            return new ServiceProviderAction<GetTablesOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure(Expression<Func<string>> storedProcedureName, Expression<Func<object>> storedProcedureParameters = null, Expression<Func<bool>> includeEmptyResultSets = null)
        {
            var parameters = new JObject();
            parameters["storedProcedureName"] = ExpressionConverter.ConvertO(storedProcedureName);
            if (storedProcedureParameters != null)
            {
                parameters["storedProcedureParameters"] = ExpressionConverter.ConvertO(storedProcedureParameters);
            }

            if (includeEmptyResultSets != null)
            {
                parameters["includeEmptyResultSets"] = ExpressionConverter.ConvertO(includeEmptyResultSets);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeStoredProcedure", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExecuteStoredProcedureOutput>(input);
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string[]> WhenARowIsUpdated(Expression<Func<string>> tableName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsUpdated", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<string[]>(input, triggerName);
        }

        public IBodyWorkflowTrigger<string[]> WhenARowIsDeleted(Expression<Func<string>> tableName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsDeleted", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<string[]>(input, triggerName);
        }

        public IBodyWorkflowTrigger<string[]> WhenARowIsInserted(Expression<Func<string>> tableName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsInserted", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<string[]>(input, triggerName);
        }

        public IBodyWorkflowTrigger<string[]> WhenARowIsModified(Expression<Func<string>> tableName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<string[]>(input, triggerName);
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
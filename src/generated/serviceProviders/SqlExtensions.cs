//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<object> queryParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["query"] = ExpressionConverter.ConvertO(query);
            if (queryParameters != null)
            {
                serviceProviderParameters["queryParameters"] = ExpressionConverter.ConvertO(queryParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeQuery", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> InsertRow([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> setColumns = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (setColumns != null)
            {
                serviceProviderParameters["setColumns"] = ExpressionConverter.ConvertO(setColumns);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "insertRow", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> DeleteRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<string> primaryKey = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            if (primaryKey != null)
            {
                serviceProviderParameters["primaryKey"] = ExpressionConverter.ConvertO(primaryKey);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "deleteRows", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> GetRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<string> primaryKey = null, [WorkflowExpression] Func<object> queries = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            if (primaryKey != null)
            {
                serviceProviderParameters["primaryKey"] = ExpressionConverter.ConvertO(primaryKey);
            }

            if (queries != null)
            {
                serviceProviderParameters["queries"] = ExpressionConverter.ConvertO(queries);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRows", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetRowsV2Output> GetRowsV2([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> queries = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (queries != null)
            {
                serviceProviderParameters["queries"] = ExpressionConverter.ConvertO(queries);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRowsV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetRowsV2Output>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> UpdateRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> setColumns, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<string> primaryKey = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            serviceProviderParameters["setColumns"] = ExpressionConverter.ConvertO(setColumns);
            if (primaryKey != null)
            {
                serviceProviderParameters["primaryKey"] = ExpressionConverter.ConvertO(primaryKey);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "updateRows", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
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
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure([WorkflowExpression] Func<string> storedProcedureName, [WorkflowExpression] Func<object> storedProcedureParameters = null, [WorkflowExpression] Func<bool> includeEmptyResultSets = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["storedProcedureName"] = ExpressionConverter.ConvertO(storedProcedureName);
            if (storedProcedureParameters != null)
            {
                serviceProviderParameters["storedProcedureParameters"] = ExpressionConverter.ConvertO(storedProcedureParameters);
            }

            if (includeEmptyResultSets != null)
            {
                serviceProviderParameters["includeEmptyResultSets"] = ExpressionConverter.ConvertO(includeEmptyResultSets);
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
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken[]> WhenARowIsUpdated([WorkflowExpression] Func<string> tableName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsUpdated", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsDeleted([WorkflowExpression] Func<string> tableName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsDeleted", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsInserted([WorkflowExpression] Func<string> tableName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsInserted", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsModified([WorkflowExpression] Func<string> tableName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsModified", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<JToken[]>(serviceProviderInput);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Oracledb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OracledbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables(Expression<Func<bool>> ownedTables = null)
        {
            var parameters = new JObject();
            if (ownedTables != null)
            {
                parameters["ownedTables"] = ExpressionConverter.ConvertO(ownedTables);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getTables", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetTablesOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeQuery", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[]> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<int>> skipCount = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> orderBy = null, Expression<Func<string[]>> filterBy = null)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                parameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            if (skipCount != null)
            {
                parameters["skipCount"] = ExpressionConverter.ConvertO(skipCount);
            }

            if (maxCount != null)
            {
                parameters["maxCount"] = ExpressionConverter.ConvertO(maxCount);
            }

            if (orderBy != null)
            {
                parameters["orderBy"] = ExpressionConverter.ConvertO(orderBy);
            }

            if (filterBy != null)
            {
                parameters["filterBy"] = ExpressionConverter.ConvertO(filterBy);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getRows", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "insertRow", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure(Expression<Func<string>> storedProcedure, Expression<Func<object>> storedProcedureParameters = null)
        {
            var parameters = new JObject();
            parameters["storedProcedure"] = ExpressionConverter.ConvertO(storedProcedure);
            if (storedProcedureParameters != null)
            {
                parameters["storedProcedureParameters"] = ExpressionConverter.ConvertO(storedProcedureParameters);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeStoredProcedure", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExecuteStoredProcedureOutput>(input);
        }
    }

    public class OracledbTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetTablesOutputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ExecuteStoredProcedureOutput
    {
        [JsonProperty("resultSets")]
        public JToken[][] ResultSets { get; set; }

        [JsonProperty("outputParameters")]
        public JToken OutputParameters { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Oracledb;

    public partial class WorkflowServiceProviderActions
    {
        public OracledbActions Oracledb(string connectionId) => new OracledbActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public OracledbTriggers Oracledb(string connectionId) => new OracledbTriggers(connectionId);
    }
}
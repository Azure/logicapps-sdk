//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DB2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<DeleteRowOutput> DeleteRow(Expression<Func<string>> table, Expression<Func<object>> searchCondition)
        {
            var parameters = new JObject();
            parameters["table"] = ExpressionConverter.ConvertO(table);
            parameters["searchCondition"] = ExpressionConverter.ConvertO(searchCondition);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "deleteRow", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<DeleteRowOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<ExecuteNonQueryOutput> ExecuteNonQuery(Expression<Func<string>> statement, Expression<Func<object>> sqlParameters = null)
        {
            var parameters = new JObject();
            parameters["statement"] = ExpressionConverter.ConvertO(statement);
            if (sqlParameters != null)
            {
                parameters["sqlParameters"] = ExpressionConverter.ConvertO(sqlParameters);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeNonQuery", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<ExecuteNonQueryOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeQuery", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables(Expression<Func<string>> schema = null)
        {
            var parameters = new JObject();
            if (schema != null)
            {
                parameters["schema"] = ExpressionConverter.ConvertO(schema);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "getTables", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetTablesOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<InsertRowOutput> InsertRow(Expression<Func<string>> table, Expression<Func<object>> insertParameters)
        {
            var parameters = new JObject();
            parameters["table"] = ExpressionConverter.ConvertO(table);
            parameters["insertParameters"] = ExpressionConverter.ConvertO(insertParameters);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "insertRow", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<InsertRowOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[]> StoredProcedure(Expression<Func<string>> procedureName, Expression<Func<object>> procedureParameters = null)
        {
            var parameters = new JObject();
            parameters["procedureName"] = ExpressionConverter.ConvertO(procedureName);
            if (procedureParameters != null)
            {
                parameters["procedureParameters"] = ExpressionConverter.ConvertO(procedureParameters);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "storedProcedure", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<UpdateRowOutput> UpdateRow(Expression<Func<string>> table, Expression<Func<object>> updatedColumns, Expression<Func<object>> searchCondition)
        {
            var parameters = new JObject();
            parameters["table"] = ExpressionConverter.ConvertO(table);
            parameters["updatedColumns"] = ExpressionConverter.ConvertO(updatedColumns);
            parameters["searchCondition"] = ExpressionConverter.ConvertO(searchCondition);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "updateRow", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<UpdateRowOutput>(input);
        }
    }

    public class DB2Triggers([ConnectionName] string connectionId)
    {
    }

    public class DeleteRowOutput
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ExecuteNonQueryOutput
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetTablesOutputItem
    {
        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class InsertRowOutput
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class UpdateRowOutput
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2;

    public partial class WorkflowServiceProviderActions
    {
        public DB2Actions DB2(string connectionId) => new DB2Actions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public DB2Triggers DB2(string connectionId) => new DB2Triggers(connectionId);
    }
}
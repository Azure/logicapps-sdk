//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class DB2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<DeleteRowOutput> DeleteRow(Expression<Func<string>> table, Expression<Func<object>> searchCondition)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["table"] = ExpressionConverter.ConvertO(table);
            serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(searchCondition);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "deleteRow", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<DeleteRowOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<ExecuteNonQueryOutput> ExecuteNonQuery(Expression<Func<string>> statement, Expression<Func<object>> sqlParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["statement"] = ExpressionConverter.ConvertO(statement);
            if (sqlParameters != null)
            {
                serviceProviderParameters["sqlParameters"] = ExpressionConverter.ConvertO(sqlParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "executeNonQuery", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<ExecuteNonQueryOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["query"] = ExpressionConverter.ConvertO(query);
            if (queryParameters != null)
            {
                serviceProviderParameters["queryParameters"] = ExpressionConverter.ConvertO(queryParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "executeQuery", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables(Expression<Func<string>> schema = null)
        {
            var serviceProviderParameters = new JObject();
            if (schema != null)
            {
                serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "getTables", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetTablesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<InsertRowOutput> InsertRow(Expression<Func<string>> table, Expression<Func<object>> insertParameters)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["table"] = ExpressionConverter.ConvertO(table);
            serviceProviderParameters["insertParameters"] = ExpressionConverter.ConvertO(insertParameters);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "insertRow", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<InsertRowOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[]> StoredProcedure(Expression<Func<string>> procedureName, Expression<Func<object>> procedureParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["procedureName"] = ExpressionConverter.ConvertO(procedureName);
            if (procedureParameters != null)
            {
                serviceProviderParameters["procedureParameters"] = ExpressionConverter.ConvertO(procedureParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "storedProcedure", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<UpdateRowOutput> UpdateRow(Expression<Func<string>> table, Expression<Func<object>> updatedColumns, Expression<Func<object>> searchCondition)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["table"] = ExpressionConverter.ConvertO(table);
            serviceProviderParameters["updatedColumns"] = ExpressionConverter.ConvertO(updatedColumns);
            serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(searchCondition);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/DB2", "updateRow", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<UpdateRowOutput>(serviceProviderInput);
        }
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
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Jdbc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JdbcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<string[]> GetTables()
        {
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "getTables", connectionName: connectionId)
            };
            return new ServiceProviderAction<string[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<JToken[]> RawQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var parameters = new JObject();
            parameters["query"] = ExpressionConverter.ConvertO(query);
            if (queryParameters != null)
            {
                parameters["queryParameters"] = ExpressionConverter.ConvertO(queryParameters);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "rawQuery", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<GetSchemaOutputItem[]> GetSchema(Expression<Func<string>> tableName)
        {
            var parameters = new JObject();
            parameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "getSchema", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetSchemaOutputItem[]>(input);
        }
    }

    public class JdbcTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSchemaOutputItem
    {
        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("nullable")]
        public bool Nullable { get; set; }

        [JsonProperty("autoIncrement")]
        public bool AutoIncrement { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Jdbc;

    public partial class WorkflowServiceProviderActions
    {
        public JdbcActions Jdbc(string connectionId) => new JdbcActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public JdbcTriggers Jdbc(string connectionId) => new JdbcTriggers(connectionId);
    }
}
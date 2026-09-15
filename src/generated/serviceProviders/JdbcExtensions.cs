//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Jdbc
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class JdbcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<string[]> GetTables()
        {
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "getTables", connectionName: connectionId)
            };
            return new ServiceProviderAction<string[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<JToken[]> RawQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["query"] = CSharpExpressionConverter.ConvertToken(query);
            if (queryParameters != null)
            {
                serviceProviderParameters["queryParameters"] = CSharpExpressionConverter.ConvertToken(queryParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "rawQuery", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<GetSchemaOutputItem[]> GetSchema(Expression<Func<string>> tableName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "getSchema", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetSchemaOutputItem[]>(serviceProviderInput);
        }
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
}
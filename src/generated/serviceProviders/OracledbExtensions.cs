//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Oracledb
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class OracledbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables(Expression<Func<bool>> ownedTables = null)
        {
            var serviceProviderParameters = new JObject();
            if (ownedTables != null)
            {
                serviceProviderParameters["ownedTables"] = CSharpExpressionConverter.ConvertToken(ownedTables);
            }
            else
            {
                serviceProviderParameters["ownedTables"] = false;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getTables", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetTablesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["query"] = CSharpExpressionConverter.ConvertToken(query);
            if (queryParameters != null)
            {
                serviceProviderParameters["queryParameters"] = CSharpExpressionConverter.ConvertToken(queryParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeQuery", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[]> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<int>> skipCount = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> orderBy = null, Expression<Func<string[]>> filterBy = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            if (columnValuesForWhereCondition != null)
            {
                serviceProviderParameters["columnValuesForWhereCondition"] = CSharpExpressionConverter.ConvertToken(columnValuesForWhereCondition);
            }

            if (skipCount != null)
            {
                serviceProviderParameters["skipCount"] = CSharpExpressionConverter.ConvertToken(skipCount);
            }
            else
            {
                serviceProviderParameters["skipCount"] = 0;
            }

            if (maxCount != null)
            {
                serviceProviderParameters["maxCount"] = CSharpExpressionConverter.ConvertToken(maxCount);
            }
            else
            {
                serviceProviderParameters["maxCount"] = 0;
            }

            if (orderBy != null)
            {
                serviceProviderParameters["orderBy"] = CSharpExpressionConverter.ConvertToken(orderBy);
            }

            if (filterBy != null)
            {
                serviceProviderParameters["filterBy"] = CSharpExpressionConverter.ConvertToken(filterBy);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getRows", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken> InsertRow(Expression<Func<string>> tableName, Expression<Func<object>> setColumns = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            if (setColumns != null)
            {
                serviceProviderParameters["setColumns"] = CSharpExpressionConverter.ConvertToken(setColumns);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "insertRow", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure(Expression<Func<string>> storedProcedure, Expression<Func<object>> storedProcedureParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["storedProcedure"] = CSharpExpressionConverter.ConvertToken(storedProcedure);
            if (storedProcedureParameters != null)
            {
                serviceProviderParameters["storedProcedureParameters"] = CSharpExpressionConverter.ConvertToken(storedProcedureParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeStoredProcedure", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ExecuteStoredProcedureOutput>(serviceProviderInput);
        }
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
}
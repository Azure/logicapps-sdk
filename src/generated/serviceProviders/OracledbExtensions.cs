//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Oracledb
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class OracledbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables([WorkflowExpression] Func<bool> ownedTables = null)
        {
            var serviceProviderParameters = new JObject();
            if (ownedTables != null)
            {
                serviceProviderParameters["ownedTables"] = ExpressionConverter.ConvertO(ownedTables);
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeQuery", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[]> GetRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<int> skipCount = null, [WorkflowExpression] Func<int> maxCount = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<string[]> filterBy = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (columnValuesForWhereCondition != null)
            {
                serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(columnValuesForWhereCondition);
            }

            if (skipCount != null)
            {
                serviceProviderParameters["skipCount"] = ExpressionConverter.ConvertO(skipCount);
            }
            else
            {
                serviceProviderParameters["skipCount"] = 0;
            }

            if (maxCount != null)
            {
                serviceProviderParameters["maxCount"] = ExpressionConverter.ConvertO(maxCount);
            }
            else
            {
                serviceProviderParameters["maxCount"] = 0;
            }

            if (orderBy != null)
            {
                serviceProviderParameters["orderBy"] = ExpressionConverter.ConvertO(orderBy);
            }

            if (filterBy != null)
            {
                serviceProviderParameters["filterBy"] = ExpressionConverter.ConvertO(filterBy);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getRows", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "insertRow", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure([WorkflowExpression] Func<string> storedProcedure, [WorkflowExpression] Func<object> storedProcedureParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["storedProcedure"] = ExpressionConverter.ConvertO(storedProcedure);
            if (storedProcedureParameters != null)
            {
                serviceProviderParameters["storedProcedureParameters"] = ExpressionConverter.ConvertO(storedProcedureParameters);
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
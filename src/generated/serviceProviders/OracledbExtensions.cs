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
    using System.Linq.Expressions;

    public class OracledbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables(Expression<Func<bool>> ownedTables = null)
        {
            var __workflow_ownedTables = WorkflowExpression.Compile(ownedTables, nameof(ownedTables), required: false);
            return new DeferredBodyAction<GetTablesOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_ownedTables != null)
                {
                    serviceProviderParameters["ownedTables"] = ExpressionConverter.ConvertO(__workflow_ownedTables);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[]> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<int>> skipCount = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> orderBy = null, Expression<Func<string[]>> filterBy = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_skipCount = WorkflowExpression.Compile(skipCount, nameof(skipCount), required: false);
            var __workflow_maxCount = WorkflowExpression.Compile(maxCount, nameof(maxCount), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_filterBy = WorkflowExpression.Compile(filterBy, nameof(filterBy), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = ExpressionConverter.ConvertO(__workflow_columnValuesForWhereCondition);
                }

                if (__workflow_skipCount != null)
                {
                    serviceProviderParameters["skipCount"] = ExpressionConverter.ConvertO(__workflow_skipCount);
                }
                else
                {
                    serviceProviderParameters["skipCount"] = 0;
                }

                if (__workflow_maxCount != null)
                {
                    serviceProviderParameters["maxCount"] = ExpressionConverter.ConvertO(__workflow_maxCount);
                }
                else
                {
                    serviceProviderParameters["maxCount"] = 0;
                }

                if (__workflow_orderBy != null)
                {
                    serviceProviderParameters["orderBy"] = ExpressionConverter.ConvertO(__workflow_orderBy);
                }

                if (__workflow_filterBy != null)
                {
                    serviceProviderParameters["filterBy"] = ExpressionConverter.ConvertO(__workflow_filterBy);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure(Expression<Func<string>> storedProcedure, Expression<Func<object>> storedProcedureParameters = null)
        {
            var __workflow_storedProcedure = WorkflowExpression.Compile(storedProcedure, nameof(storedProcedure), required: true);
            var __workflow_storedProcedureParameters = WorkflowExpression.Compile(storedProcedureParameters, nameof(storedProcedureParameters), required: false);
            return new DeferredBodyAction<ExecuteStoredProcedureOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["storedProcedure"] = ExpressionConverter.ConvertO(__workflow_storedProcedure);
                if (__workflow_storedProcedureParameters != null)
                {
                    serviceProviderParameters["storedProcedureParameters"] = ExpressionConverter.ConvertO(__workflow_storedProcedureParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeStoredProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExecuteStoredProcedureOutput>(serviceProviderInput);
            });
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

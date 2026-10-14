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
            var __workflow_ownedTables = ownedTables == null ? null : WorkflowExpression.Compile(ownedTables);
            WorkflowExpression.Validate(__workflow_ownedTables, nameof(ownedTables), required: false);
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
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_queryParameters = queryParameters == null ? null : WorkflowExpression.Compile(queryParameters);
            WorkflowExpression.Validate(__workflow_queryParameters, nameof(queryParameters), required: false);
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
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = columnValuesForWhereCondition == null ? null : WorkflowExpression.Compile(columnValuesForWhereCondition);
            WorkflowExpression.Validate(__workflow_columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_skipCount = skipCount == null ? null : WorkflowExpression.Compile(skipCount);
            WorkflowExpression.Validate(__workflow_skipCount, nameof(skipCount), required: false);
            var __workflow_maxCount = maxCount == null ? null : WorkflowExpression.Compile(maxCount);
            WorkflowExpression.Validate(__workflow_maxCount, nameof(maxCount), required: false);
            var __workflow_orderBy = orderBy == null ? null : WorkflowExpression.Compile(orderBy);
            WorkflowExpression.Validate(__workflow_orderBy, nameof(orderBy), required: false);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: false);
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
            var __workflow_tableName = tableName == null ? null : WorkflowExpression.Compile(tableName);
            WorkflowExpression.Validate(__workflow_tableName, nameof(tableName), required: true);
            var __workflow_setColumns = setColumns == null ? null : WorkflowExpression.Compile(setColumns);
            WorkflowExpression.Validate(__workflow_setColumns, nameof(setColumns), required: false);
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
            var __workflow_storedProcedure = storedProcedure == null ? null : WorkflowExpression.Compile(storedProcedure);
            WorkflowExpression.Validate(__workflow_storedProcedure, nameof(storedProcedure), required: true);
            var __workflow_storedProcedureParameters = storedProcedureParameters == null ? null : WorkflowExpression.Compile(storedProcedureParameters);
            WorkflowExpression.Validate(__workflow_storedProcedureParameters, nameof(storedProcedureParameters), required: false);
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

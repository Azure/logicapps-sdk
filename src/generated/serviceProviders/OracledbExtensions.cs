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
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables([WorkflowExpression] Func<bool> ownedTables = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTablesOutputItem[]> __BuildGetTables(WorkflowValue<bool> ownedTables = null)
        {
            WorkflowValue.Validate(ownedTables, nameof(ownedTables), required: false);
            return new DeferredBodyAction<GetTablesOutputItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteQuery))]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<object> queryParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildExecuteQuery(WorkflowValue<string> query, WorkflowValue<object> queryParameters = null)
        {
            WorkflowValue.Validate(query, nameof(query), required: true);
            WorkflowValue.Validate(queryParameters, nameof(queryParameters), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        [WorkflowExpressionFactory(nameof(__BuildGetRows))]
        public IBodyWorkflowAction<JToken[]> GetRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<int> skipCount = null, [WorkflowExpression] Func<int> maxCount = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<string[]> filterBy = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetRows(WorkflowValue<string> tableName, WorkflowValue<object> columnValuesForWhereCondition = null, WorkflowValue<int> skipCount = null, WorkflowValue<int> maxCount = null, WorkflowValue<string> orderBy = null, WorkflowValue<string[]> filterBy = null)
        {
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            WorkflowValue.Validate(skipCount, nameof(skipCount), required: false);
            WorkflowValue.Validate(maxCount, nameof(maxCount), required: false);
            WorkflowValue.Validate(orderBy, nameof(orderBy), required: false);
            WorkflowValue.Validate(filterBy, nameof(filterBy), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        [WorkflowExpressionFactory(nameof(__BuildInsertRow))]
        public IBodyWorkflowAction<JToken> InsertRow([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> setColumns = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildInsertRow(WorkflowValue<string> tableName, WorkflowValue<object> setColumns = null)
        {
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(setColumns, nameof(setColumns), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteStoredProcedure))]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure([WorkflowExpression] Func<string> storedProcedure, [WorkflowExpression] Func<object> storedProcedureParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> __BuildExecuteStoredProcedure(WorkflowValue<string> storedProcedure, WorkflowValue<object> storedProcedureParameters = null)
        {
            WorkflowValue.Validate(storedProcedure, nameof(storedProcedure), required: true);
            WorkflowValue.Validate(storedProcedureParameters, nameof(storedProcedureParameters), required: false);
            return new DeferredBodyAction<ExecuteStoredProcedureOutput>(() =>
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

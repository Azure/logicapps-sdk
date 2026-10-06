//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class DB2Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRow))]
        public IOutputWorkflowAction<DeleteRowOutput> DeleteRow([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> searchCondition)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<DeleteRowOutput> __BuildDeleteRow(WorkflowExpression<string> table, WorkflowExpression<object> searchCondition)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(searchCondition, nameof(searchCondition), required: true);
            return new DeferredOutputAction<DeleteRowOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(table);
                serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "deleteRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<DeleteRowOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteNonQuery))]
        public IOutputWorkflowAction<ExecuteNonQueryOutput> ExecuteNonQuery([WorkflowExpression] Func<string> statement, [WorkflowExpression] Func<object> sqlParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<ExecuteNonQueryOutput> __BuildExecuteNonQuery(WorkflowExpression<string> statement, WorkflowExpression<object> sqlParameters = null)
        {
            WorkflowExpression.Validate(statement, nameof(statement), required: true);
            WorkflowExpression.Validate(sqlParameters, nameof(sqlParameters), required: false);
            return new DeferredOutputAction<ExecuteNonQueryOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["statement"] = ExpressionConverter.ConvertO(statement);
                if (sqlParameters != null)
                {
                    serviceProviderParameters["sqlParameters"] = ExpressionConverter.ConvertO(sqlParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeNonQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<ExecuteNonQueryOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteQuery))]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<object> queryParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildExecuteQuery(WorkflowExpression<string> query, WorkflowExpression<object> queryParameters = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(queryParameters, nameof(queryParameters), required: false);
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables([WorkflowExpression] Func<string> schema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTablesOutputItem[]> __BuildGetTables(WorkflowExpression<string> schema = null)
        {
            WorkflowExpression.Validate(schema, nameof(schema), required: false);
            return new DeferredBodyAction<GetTablesOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (schema != null)
                {
                    serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "getTables", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetTablesOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildInsertRow))]
        public IOutputWorkflowAction<InsertRowOutput> InsertRow([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> insertParameters)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<InsertRowOutput> __BuildInsertRow(WorkflowExpression<string> table, WorkflowExpression<object> insertParameters)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(insertParameters, nameof(insertParameters), required: true);
            return new DeferredOutputAction<InsertRowOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(table);
                serviceProviderParameters["insertParameters"] = ExpressionConverter.ConvertO(insertParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<InsertRowOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildStoredProcedure))]
        public IBodyWorkflowAction<JToken[]> StoredProcedure([WorkflowExpression] Func<string> procedureName, [WorkflowExpression] Func<object> procedureParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildStoredProcedure(WorkflowExpression<string> procedureName, WorkflowExpression<object> procedureParameters = null)
        {
            WorkflowExpression.Validate(procedureName, nameof(procedureName), required: true);
            WorkflowExpression.Validate(procedureParameters, nameof(procedureParameters), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["procedureName"] = ExpressionConverter.ConvertO(procedureName);
                if (procedureParameters != null)
                {
                    serviceProviderParameters["procedureParameters"] = ExpressionConverter.ConvertO(procedureParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "storedProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRow))]
        public IOutputWorkflowAction<UpdateRowOutput> UpdateRow([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> updatedColumns, [WorkflowExpression] Func<object> searchCondition)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<UpdateRowOutput> __BuildUpdateRow(WorkflowExpression<string> table, WorkflowExpression<object> updatedColumns, WorkflowExpression<object> searchCondition)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(updatedColumns, nameof(updatedColumns), required: true);
            WorkflowExpression.Validate(searchCondition, nameof(searchCondition), required: true);
            return new DeferredOutputAction<UpdateRowOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(table);
                serviceProviderParameters["updatedColumns"] = ExpressionConverter.ConvertO(updatedColumns);
                serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "updateRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<UpdateRowOutput>(serviceProviderInput);
            });
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
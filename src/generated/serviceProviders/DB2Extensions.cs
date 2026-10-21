//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class DB2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<DeleteRowOutput> DeleteRow(Expression<Func<string>> table, Expression<Func<object>> searchCondition)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_searchCondition = WorkflowExpression.Compile(searchCondition, nameof(searchCondition), required: true);
            return new DeferredOutputAction<DeleteRowOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(__workflow_table);
                serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(__workflow_searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "deleteRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<DeleteRowOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<ExecuteNonQueryOutput> ExecuteNonQuery(Expression<Func<string>> statement, Expression<Func<object>> sqlParameters = null)
        {
            var __workflow_statement = WorkflowExpression.Compile(statement, nameof(statement), required: true);
            var __workflow_sqlParameters = WorkflowExpression.Compile(sqlParameters, nameof(sqlParameters), required: false);
            return new DeferredOutputAction<ExecuteNonQueryOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["statement"] = ExpressionConverter.ConvertO(__workflow_statement);
                if (__workflow_sqlParameters != null)
                {
                    serviceProviderParameters["sqlParameters"] = ExpressionConverter.ConvertO(__workflow_sqlParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeNonQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<ExecuteNonQueryOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables(Expression<Func<string>> schema = null)
        {
            var __workflow_schema = WorkflowExpression.Compile(schema, nameof(schema), required: false);
            return new DeferredBodyAction<GetTablesOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_schema != null)
                {
                    serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(__workflow_schema);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "getTables", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetTablesOutputItem[]>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<InsertRowOutput> InsertRow(Expression<Func<string>> table, Expression<Func<object>> insertParameters)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_insertParameters = WorkflowExpression.Compile(insertParameters, nameof(insertParameters), required: true);
            return new DeferredOutputAction<InsertRowOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(__workflow_table);
                serviceProviderParameters["insertParameters"] = ExpressionConverter.ConvertO(__workflow_insertParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<InsertRowOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[]> StoredProcedure(Expression<Func<string>> procedureName, Expression<Func<object>> procedureParameters = null)
        {
            var __workflow_procedureName = WorkflowExpression.Compile(procedureName, nameof(procedureName), required: true);
            var __workflow_procedureParameters = WorkflowExpression.Compile(procedureParameters, nameof(procedureParameters), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["procedureName"] = ExpressionConverter.ConvertO(__workflow_procedureName);
                if (__workflow_procedureParameters != null)
                {
                    serviceProviderParameters["procedureParameters"] = ExpressionConverter.ConvertO(__workflow_procedureParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "storedProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<UpdateRowOutput> UpdateRow(Expression<Func<string>> table, Expression<Func<object>> updatedColumns, Expression<Func<object>> searchCondition)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_updatedColumns = WorkflowExpression.Compile(updatedColumns, nameof(updatedColumns), required: true);
            var __workflow_searchCondition = WorkflowExpression.Compile(searchCondition, nameof(searchCondition), required: true);
            return new DeferredOutputAction<UpdateRowOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(__workflow_table);
                serviceProviderParameters["updatedColumns"] = ExpressionConverter.ConvertO(__workflow_updatedColumns);
                serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(__workflow_searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "updateRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<UpdateRowOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class DB2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<DeleteRowOutput, DeleteRowActionConfiguration> DeleteRow(Expression<Func<string>> table, Expression<Func<object>> searchCondition)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_searchCondition = WorkflowExpression.Compile(searchCondition, nameof(searchCondition), required: true);
            return new DeferredOutputAction<DeleteRowOutput, DeleteRowActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(__workflow_table);
                serviceProviderParameters["searchCondition"] = ExpressionConverter.ConvertO(__workflow_searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "deleteRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<DeleteRowOutput, DeleteRowActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<ExecuteNonQueryOutput, ExecuteNonQueryActionConfiguration> ExecuteNonQuery(Expression<Func<string>> statement, Expression<Func<object>> sqlParameters = null)
        {
            var __workflow_statement = WorkflowExpression.Compile(statement, nameof(statement), required: true);
            var __workflow_sqlParameters = WorkflowExpression.Compile(sqlParameters, nameof(sqlParameters), required: false);
            return new DeferredOutputAction<ExecuteNonQueryOutput, ExecuteNonQueryActionConfiguration>(() =>
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
                return new ServiceProviderOutputAction<ExecuteNonQueryOutput, ExecuteNonQueryActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[], ExecuteQueryActionConfiguration> ExecuteQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_queryParameters = WorkflowExpression.Compile(queryParameters, nameof(queryParameters), required: false);
            return new DeferredBodyAction<JToken[], ExecuteQueryActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<JToken[], ExecuteQueryActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<GetTablesOutputItem[], GetTablesActionConfiguration> GetTables(Expression<Func<string>> schema = null)
        {
            var __workflow_schema = WorkflowExpression.Compile(schema, nameof(schema), required: false);
            return new DeferredBodyAction<GetTablesOutputItem[], GetTablesActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<GetTablesOutputItem[], GetTablesActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<InsertRowOutput, InsertRowActionConfiguration> InsertRow(Expression<Func<string>> table, Expression<Func<object>> insertParameters)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_insertParameters = WorkflowExpression.Compile(insertParameters, nameof(insertParameters), required: true);
            return new DeferredOutputAction<InsertRowOutput, InsertRowActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = ExpressionConverter.ConvertO(__workflow_table);
                serviceProviderParameters["insertParameters"] = ExpressionConverter.ConvertO(__workflow_insertParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<InsertRowOutput, InsertRowActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[], StoredProcedureActionConfiguration> StoredProcedure(Expression<Func<string>> procedureName, Expression<Func<object>> procedureParameters = null)
        {
            var __workflow_procedureName = WorkflowExpression.Compile(procedureName, nameof(procedureName), required: true);
            var __workflow_procedureParameters = WorkflowExpression.Compile(procedureParameters, nameof(procedureParameters), required: false);
            return new DeferredBodyAction<JToken[], StoredProcedureActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<JToken[], StoredProcedureActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<UpdateRowOutput, UpdateRowActionConfiguration> UpdateRow(Expression<Func<string>> table, Expression<Func<object>> updatedColumns, Expression<Func<object>> searchCondition)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_updatedColumns = WorkflowExpression.Compile(updatedColumns, nameof(updatedColumns), required: true);
            var __workflow_searchCondition = WorkflowExpression.Compile(searchCondition, nameof(searchCondition), required: true);
            return new DeferredOutputAction<UpdateRowOutput, UpdateRowActionConfiguration>(() =>
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
                return new ServiceProviderOutputAction<UpdateRowOutput, UpdateRowActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class DeleteRowActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ExecuteNonQueryActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ExecuteQueryActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetTablesActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class InsertRowActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class StoredProcedureActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class UpdateRowActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Oracledb
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class OracledbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<GetTablesOutputItem[], GetTablesActionConfiguration> GetTables(Expression<Func<bool>> ownedTables = null)
        {
            var __workflow_ownedTables = WorkflowExpression.Compile(ownedTables, nameof(ownedTables), required: false);
            return new DeferredBodyAction<GetTablesOutputItem[], GetTablesActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<GetTablesOutputItem[], GetTablesActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken[], ExecuteQueryActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[], GetRowsActionConfiguration> GetRows(Expression<Func<string>> tableName, Expression<Func<object>> columnValuesForWhereCondition = null, Expression<Func<int>> skipCount = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> orderBy = null, Expression<Func<string[]>> filterBy = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_columnValuesForWhereCondition = WorkflowExpression.Compile(columnValuesForWhereCondition, nameof(columnValuesForWhereCondition), required: false);
            var __workflow_skipCount = WorkflowExpression.Compile(skipCount, nameof(skipCount), required: false);
            var __workflow_maxCount = WorkflowExpression.Compile(maxCount, nameof(maxCount), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_filterBy = WorkflowExpression.Compile(filterBy, nameof(filterBy), required: false);
            return new DeferredBodyAction<JToken[], GetRowsActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<JToken[], GetRowsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken, InsertRowActionConfiguration> InsertRow(Expression<Func<string>> tableName, Expression<Func<object>> setColumns = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_setColumns = WorkflowExpression.Compile(setColumns, nameof(setColumns), required: false);
            return new DeferredBodyAction<JToken, InsertRowActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<JToken, InsertRowActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput, ExecuteStoredProcedureActionConfiguration> ExecuteStoredProcedure(Expression<Func<string>> storedProcedure, Expression<Func<object>> storedProcedureParameters = null)
        {
            var __workflow_storedProcedure = WorkflowExpression.Compile(storedProcedure, nameof(storedProcedure), required: true);
            var __workflow_storedProcedureParameters = WorkflowExpression.Compile(storedProcedureParameters, nameof(storedProcedureParameters), required: false);
            return new DeferredBodyAction<ExecuteStoredProcedureOutput, ExecuteStoredProcedureActionConfiguration>(() =>
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
                return new ServiceProviderBodyAction<ExecuteStoredProcedureOutput, ExecuteStoredProcedureActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class GetTablesActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ExecuteQueryActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetRowsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class InsertRowActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ExecuteStoredProcedureActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
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
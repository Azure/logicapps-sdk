//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Jdbc
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class JdbcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<string[]> GetTables()
        {
            return new DeferredBodyAction<string[]>(() =>
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "getTables", connectionName: connectionId)
                };
                return new ServiceProviderAction<string[]>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<JToken[]> RawQuery(Expression<Func<string>> query, Expression<Func<object>> queryParameters = null)
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "rawQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken[]>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Jdbc")]
        public IBodyWorkflowAction<GetSchemaOutputItem[]> GetSchema(Expression<Func<string>> tableName)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            return new DeferredBodyAction<GetSchemaOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Jdbc", operationId: "getSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSchemaOutputItem[]>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
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
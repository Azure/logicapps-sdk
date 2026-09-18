//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DB2
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class DB2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<DeleteRowOutput> DeleteRow([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> searchCondition)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(searchCondition, nameof(searchCondition), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = SourceExpressionConverter.ConvertToken(table);
                serviceProviderParameters["searchCondition"] = SourceExpressionConverter.ConvertToken(searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "deleteRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<DeleteRowOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<ExecuteNonQueryOutput> ExecuteNonQuery([WorkflowExpression] Func<string> statement, [WorkflowExpression] Func<object> sqlParameters = null)
        {
            SourceExpression.Validate(statement, nameof(statement), required: true);
            SourceExpression.Validate(sqlParameters, nameof(sqlParameters), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["statement"] = SourceExpressionConverter.ConvertToken(statement);
                if (sqlParameters != null)
                {
                    serviceProviderParameters["sqlParameters"] = SourceExpressionConverter.ConvertToken(sqlParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeNonQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<ExecuteNonQueryOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<object> queryParameters = null)
        {
            SourceExpression.Validate(query, nameof(query), required: true);
            SourceExpression.Validate(queryParameters, nameof(queryParameters), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["query"] = SourceExpressionConverter.ConvertToken(query);
                if (queryParameters != null)
                {
                    serviceProviderParameters["queryParameters"] = SourceExpressionConverter.ConvertToken(queryParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables([WorkflowExpression] Func<string> schema = null)
        {
            SourceExpression.Validate(schema, nameof(schema), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (schema != null)
                {
                    serviceProviderParameters["schema"] = SourceExpressionConverter.ConvertToken(schema);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "getTables", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetTablesOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<InsertRowOutput> InsertRow([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> insertParameters)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(insertParameters, nameof(insertParameters), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = SourceExpressionConverter.ConvertToken(table);
                serviceProviderParameters["insertParameters"] = SourceExpressionConverter.ConvertToken(insertParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<InsertRowOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IBodyWorkflowAction<JToken[]> StoredProcedure([WorkflowExpression] Func<string> procedureName, [WorkflowExpression] Func<object> procedureParameters = null)
        {
            SourceExpression.Validate(procedureName, nameof(procedureName), required: true);
            SourceExpression.Validate(procedureParameters, nameof(procedureParameters), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["procedureName"] = SourceExpressionConverter.ConvertToken(procedureName);
                if (procedureParameters != null)
                {
                    serviceProviderParameters["procedureParameters"] = SourceExpressionConverter.ConvertToken(procedureParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "storedProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "DB2")]
        public IOutputWorkflowAction<UpdateRowOutput> UpdateRow([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> updatedColumns, [WorkflowExpression] Func<object> searchCondition)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(updatedColumns, nameof(updatedColumns), required: true);
            SourceExpression.Validate(searchCondition, nameof(searchCondition), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["table"] = SourceExpressionConverter.ConvertToken(table);
                serviceProviderParameters["updatedColumns"] = SourceExpressionConverter.ConvertToken(updatedColumns);
                serviceProviderParameters["searchCondition"] = SourceExpressionConverter.ConvertToken(searchCondition);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/DB2", operationId: "updateRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<UpdateRowOutput>(BuildSourceInput);
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
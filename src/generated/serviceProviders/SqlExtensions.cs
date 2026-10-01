//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> ExecuteQuery([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<object> queryParameters = null)
        {
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> ExecuteQueryWithOutputAsDictionary([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<object> queryParameters = null, [WorkflowExpression] Func<bool> includeEmptyResultSets = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["query"] = SourceExpressionConverter.ConvertToken(query);
                if (queryParameters != null)
                {
                    serviceProviderParameters["queryParameters"] = SourceExpressionConverter.ConvertToken(queryParameters);
                }

                if (includeEmptyResultSets != null)
                {
                    serviceProviderParameters["includeEmptyResultSets"] = SourceExpressionConverter.ConvertToken(includeEmptyResultSets);
                }
                else
                {
                    serviceProviderParameters["includeEmptyResultSets"] = true;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeQueryWithOutputAsDictionary", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure([WorkflowExpression] Func<string> storedProcedureName, [WorkflowExpression] Func<object> storedProcedureParameters = null, [WorkflowExpression] Func<bool> includeEmptyResultSets = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["storedProcedureName"] = SourceExpressionConverter.ConvertToken(storedProcedureName);
                if (storedProcedureParameters != null)
                {
                    serviceProviderParameters["storedProcedureParameters"] = SourceExpressionConverter.ConvertToken(storedProcedureParameters);
                }

                if (includeEmptyResultSets != null)
                {
                    serviceProviderParameters["includeEmptyResultSets"] = SourceExpressionConverter.ConvertToken(includeEmptyResultSets);
                }
                else
                {
                    serviceProviderParameters["includeEmptyResultSets"] = true;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeStoredProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExecuteStoredProcedureOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken> InsertRow([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> setColumns = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (setColumns != null)
                {
                    serviceProviderParameters["setColumns"] = SourceExpressionConverter.ConvertToken(setColumns);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> DeleteRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<string> primaryKey = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = SourceExpressionConverter.ConvertToken(columnValuesForWhereCondition);
                }

                if (primaryKey != null)
                {
                    serviceProviderParameters["primaryKey"] = SourceExpressionConverter.ConvertToken(primaryKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "deleteRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> GetRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<string> primaryKey = null, [WorkflowExpression] Func<object> queries = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = SourceExpressionConverter.ConvertToken(columnValuesForWhereCondition);
                }

                if (primaryKey != null)
                {
                    serviceProviderParameters["primaryKey"] = SourceExpressionConverter.ConvertToken(primaryKey);
                }

                if (queries != null)
                {
                    serviceProviderParameters["queries"] = SourceExpressionConverter.ConvertToken(queries);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetRowsV2Output> GetRowsV2([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> queries = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (queries != null)
                {
                    serviceProviderParameters["queries"] = SourceExpressionConverter.ConvertToken(queries);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getRowsV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetRowsV2Output>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<JToken[]> UpdateRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> setColumns, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<string> primaryKey = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = SourceExpressionConverter.ConvertToken(columnValuesForWhereCondition);
                }

                serviceProviderParameters["setColumns"] = SourceExpressionConverter.ConvertToken(setColumns);
                if (primaryKey != null)
                {
                    serviceProviderParameters["primaryKey"] = SourceExpressionConverter.ConvertToken(primaryKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "updateRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "getTables", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetTablesOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sql")]
        public IBodyWorkflowAction<ExecuteStoredProcedureWithOutputAsDictionaryOutput> ExecuteStoredProcedureWithOutputAsDictionary([WorkflowExpression] Func<string> storedProcedureName, [WorkflowExpression] Func<object> storedProcedureParameters = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["storedProcedureName"] = SourceExpressionConverter.ConvertToken(storedProcedureName);
                if (storedProcedureParameters != null)
                {
                    serviceProviderParameters["storedProcedureParameters"] = SourceExpressionConverter.ConvertToken(storedProcedureParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "executeStoredProcedureWithOutputAsDictionary", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExecuteStoredProcedureWithOutputAsDictionaryOutput>(BuildSourceInput);
        }
    }

    public class SqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken[]> WhenARowIsUpdated([WorkflowExpression] Func<string> tableName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsUpdated", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<JToken[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsDeleted([WorkflowExpression] Func<string> tableName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsDeleted", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<JToken[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsInserted([WorkflowExpression] Func<string> tableName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsInserted", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<JToken[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<JToken[]> WhenARowIsModified([WorkflowExpression] Func<string> tableName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sql", operationId: "whenARowIsModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<JToken[]>(BuildSourceInput);
        }
    }

    public class ExecuteStoredProcedureOutput
    {
        [JsonProperty("resultSets")]
        public JToken ResultSets { get; set; }

        [JsonProperty("outputParameters")]
        public JToken OutputParameters { get; set; }

        [JsonProperty("returnCode")]
        public int ReturnCode { get; set; }
    }

    public class GetRowsV2Output
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class GetTablesOutputItem
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ExecuteStoredProcedureWithOutputAsDictionaryOutput
    {
        [JsonProperty("resultSets")]
        public JToken ResultSets { get; set; }

        [JsonProperty("outputParameters")]
        public JToken OutputParameters { get; set; }

        [JsonProperty("returnCode")]
        public int ReturnCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sql;

    public partial class WorkflowServiceProviderActions
    {
        public SqlActions Sql(string connectionId) => new SqlActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public SqlTriggers Sql(string connectionId) => new SqlTriggers(connectionId);
    }
}
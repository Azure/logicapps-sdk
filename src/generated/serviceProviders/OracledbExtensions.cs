//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Oracledb
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class OracledbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<GetTablesOutputItem[]> GetTables([WorkflowExpression] Func<bool> ownedTables = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (ownedTables != null)
                {
                    serviceProviderParameters["ownedTables"] = SourceExpressionConverter.ConvertToken(ownedTables);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetTablesOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeQuery", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<JToken[]> GetRows([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<object> columnValuesForWhereCondition = null, [WorkflowExpression] Func<int> skipCount = null, [WorkflowExpression] Func<int> maxCount = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<string[]> filterBy = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (columnValuesForWhereCondition != null)
                {
                    serviceProviderParameters["columnValuesForWhereCondition"] = SourceExpressionConverter.ConvertToken(columnValuesForWhereCondition);
                }

                if (skipCount != null)
                {
                    serviceProviderParameters["skipCount"] = SourceExpressionConverter.ConvertToken(skipCount);
                }
                else
                {
                    serviceProviderParameters["skipCount"] = 0;
                }

                if (maxCount != null)
                {
                    serviceProviderParameters["maxCount"] = SourceExpressionConverter.ConvertToken(maxCount);
                }
                else
                {
                    serviceProviderParameters["maxCount"] = 0;
                }

                if (orderBy != null)
                {
                    serviceProviderParameters["orderBy"] = SourceExpressionConverter.ConvertToken(orderBy);
                }

                if (filterBy != null)
                {
                    serviceProviderParameters["filterBy"] = SourceExpressionConverter.ConvertToken(filterBy);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "getRows", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "insertRow", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "oracledb")]
        public IBodyWorkflowAction<ExecuteStoredProcedureOutput> ExecuteStoredProcedure([WorkflowExpression] Func<string> storedProcedure, [WorkflowExpression] Func<object> storedProcedureParameters = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["storedProcedure"] = SourceExpressionConverter.ConvertToken(storedProcedure);
                if (storedProcedureParameters != null)
                {
                    serviceProviderParameters["storedProcedureParameters"] = SourceExpressionConverter.ConvertToken(storedProcedureParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/oracledb", operationId: "executeStoredProcedure", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ExecuteStoredProcedureOutput>(BuildSourceInput);
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
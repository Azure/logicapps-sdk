//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremysql
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremysqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<ProceduresList> GetStoredProcedures([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/procedures", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProceduresList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/procedures/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(parameters);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<object> queryactualParameters = null, [WorkflowExpression] Func<string> queryquery = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/query/mysql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var query = new JObject();
                var querypropCount = 0;
                if (queryactualParameters != null)
                {
                    query["actualParameters"] = SourceExpressionConverter.ConvertToken(queryactualParameters);
                    querypropCount++;
                }

                if (queryquery != null)
                {
                    query["query"] = SourceExpressionConverter.ConvertToken(queryquery);
                    querypropCount++;
                }

                var formalParametersObject = new JObject();
                var formalParametersObjectpropCount = 0;
                if (formalParametersObjectpropCount > 0)
                {
                    query["formalParameters"] = formalParametersObject;
                    querypropCount++;
                }

                if (querypropCount > 0)
                {
                    callPayload.Body = query;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class AzuremysqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onnewitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression] Func<string> server, [WorkflowExpression] Func<string> database, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onupdateditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(server, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(database, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ProceduresList
    {
        [JsonProperty("value")]
        public Procedure[] Value { get; set; }
    }

    public class Procedure
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuremysql;

    public partial class WorkflowManagedActions
    {
        public AzuremysqlActions Azuremysql(string connectionId) => new AzuremysqlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuremysqlTriggers Azuremysql(string connectionId) => new AzuremysqlTriggers(connectionId);
    }
}
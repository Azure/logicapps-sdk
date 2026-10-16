//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuremysql
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuremysqlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<ProceduresList> GetStoredProcedures(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            return new DeferredBodyAction<ProceduresList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/procedures", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProceduresList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_procedure = WorkflowExpression.Compile(procedure, nameof(procedure), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/procedures/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<object>> queryactualParameters = null, Expression<Func<string>> queryquery = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_queryactualParameters = WorkflowExpression.Compile(queryactualParameters, nameof(queryactualParameters), required: false);
            var __workflow_queryquery = WorkflowExpression.Compile(queryquery, nameof(queryquery), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/query/mysql", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var query = new JObject();
                var querypropCount = 0;
                if (__workflow_queryactualParameters != null)
                {
                    query["actualParameters"] = ExpressionConverter.ConvertO(__workflow_queryactualParameters);
                    querypropCount++;
                }

                if (__workflow_queryquery != null)
                {
                    query["query"] = ExpressionConverter.ConvertO(__workflow_queryquery);
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

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AzuremysqlTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0},{1}/tables/{2}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
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

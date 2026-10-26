//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sqldw
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SqldwActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExecutePassThroughNativeQuery(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<ExecutePassThroughNativeQueryV2Input>> query)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/{0},{1}/query/sql", __workflow_server.WithUrlEncoding(2), __workflow_database.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExecuteProcedure(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> procedure, Expression<Func<object>> parameters)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_procedure = WorkflowExpression.Compile(procedure, nameof(procedure), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/{0},{1}/procedures/{2}", __workflow_server.WithUrlEncoding(2), __workflow_database.WithUrlEncoding(2), __workflow_procedure.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<ItemsListV2, ApiConnectionActionConfiguration> GetItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", __workflow_server.WithUrlEncoding(2), __workflow_database.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<TablesList, ApiConnectionActionConfiguration> GetTables(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            return new DeferredBodyAction<TablesList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/datasets/{0},{1}/tables", __workflow_server.WithUrlEncoding(2), __workflow_database.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }
    }

    public class SqldwTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExecutePassThroughNativeQueryV2Input
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("formalParameters")]
        public JToken FormalParameters { get; set; }

        [JsonProperty("actualParameters")]
        public JToken ActualParameters { get; set; }
    }

    public class ItemsListV2
    {
        [JsonProperty("value")]
        public ItemV2[] Value { get; set; }
    }

    public class ItemV2
    {
        public string ItemInternalId { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sqldw;

    public partial class WorkflowManagedActions
    {
        public SqldwActions Sqldw(string connectionId) => new SqldwActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SqldwTriggers Sqldw(string connectionId) => new SqldwTriggers(connectionId);
    }
}
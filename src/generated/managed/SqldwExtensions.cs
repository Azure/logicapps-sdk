//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sqldw
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SqldwActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var __workflow_procedure = WorkflowExpression.Compile(procedure, nameof(procedure), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/procedures/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> queryquery = null, Expression<Func<object>> queryactualParameters = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_queryquery = WorkflowExpression.Compile(queryquery, nameof(queryquery), required: false);
            var __workflow_queryactualParameters = WorkflowExpression.Compile(queryactualParameters, nameof(queryactualParameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/query/sql", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var query = new JObject();
                var querypropCount = 0;
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

                if (__workflow_queryactualParameters != null)
                {
                    query["actualParameters"] = ExpressionConverter.ConvertO(__workflow_queryactualParameters);
                    querypropCount++;
                }

                if (querypropCount > 0)
                {
                    callPayload.Body = query;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<ItemsListV2> GetItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsListV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var __workflow_server = WorkflowExpression.Compile(server, nameof(server), required: true);
            var __workflow_database = WorkflowExpression.Compile(database, nameof(database), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_server, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_database, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }
    }

    public class SqldwTriggers([ConnectionName] string connectionId)
    {
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

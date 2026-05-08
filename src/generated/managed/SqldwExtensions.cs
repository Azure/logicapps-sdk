//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sqldw
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SqldwActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = String.Format("/datasets/default/procedures/{0}", ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> queryquery = null, Expression<Func<object>> queryactualParameters = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/query/sql", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var query = new JObject();
            var querypropCount = 0;
            if (queryquery != null)
            {
                query["query"] = ExpressionConverter.ConvertO(queryquery);
                querypropCount++;
            }

            var formalParametersObject = new JObject();
            var formalParametersObjectpropCount = 0;
            if (formalParametersObjectpropCount > 0)
            {
                query["formalParameters"] = formalParametersObject;
                querypropCount++;
            }

            if (queryactualParameters != null)
            {
                query["actualParameters"] = ExpressionConverter.ConvertO(queryactualParameters);
                querypropCount++;
            }

            if (querypropCount > 0)
            {
                callPayload.Body = query;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<ItemsListV2> GetItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<ItemsListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sqldw")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var apiCallPath = String.Format("/v2/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
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
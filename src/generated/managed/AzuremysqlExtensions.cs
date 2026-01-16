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
        public IBodyWorkflowAction<ProceduresList> GetStoredProcedures(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/procedures", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProceduresList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/procedures/{2}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> server, Expression<Func<string>> database)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuremysql")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<object>> queryactualParameters = null, Expression<Func<string>> queryquery = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/query/mysql", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var query = new JObject();
            var querypropCount = 0;
            if (queryactualParameters != null)
            {
                query["actualParameters"] = ExpressionConverter.ConvertO(queryactualParameters);
                querypropCount++;
            }

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

            if (querypropCount > 0)
            {
                callPayload.Body = query;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class AzuremysqlTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ItemsList> GetOnNewItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<ItemsList>(callPayload);
        }

        public IOutputWorkflowTrigger<ItemsList> GetOnUpdatedItems(Expression<Func<string>> server, Expression<Func<string>> database, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null, Expression<Func<string>> select = null, string triggerName = null)
        {
            var apiCallPath = String.Format("/datasets/{0},{1}/tables/{2}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(server, 2), ExpressionConverter.ConvertWithUrlEncoding(database, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<ItemsList>(callPayload);
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
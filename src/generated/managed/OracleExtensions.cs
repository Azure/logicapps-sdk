//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oracle
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OracleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<JToken> ExecuteProcedure(Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/procedures/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<TablesList> GetTables()
        {
            var apiCallPath = "/datasets/default/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oracle")]
        public IBodyWorkflowAction<JToken> ExecutePassThroughNativeQuery(Expression<Func<string>> queryquery = null, Expression<Func<object>> queryactualParameters = null)
        {
            var apiCallPath = "/datasets/default/query/oracle";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var query = new JObject();
            var querypropCount = 0;
            if (queryquery != null)
            {
                query["query"] = CSharpExpressionConverter.ConvertToken(queryquery);
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
                query["actualParameters"] = CSharpExpressionConverter.ConvertToken(queryactualParameters);
                querypropCount++;
            }

            if (querypropCount > 0)
            {
                callPayload.Body = query;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class OracleTriggers([ConnectionName] string connectionId)
    {
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
        public JToken DynamicProperties { get; set; }
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oracle;

    public partial class WorkflowManagedActions
    {
        public OracleActions Oracle(string connectionId) => new OracleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OracleTriggers Oracle(string connectionId) => new OracleTriggers(connectionId);
    }
}
//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlesheet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglesheetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<itemInput>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<itemInput>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<Item>(callPayload);
        }
    }

    public class GooglesheetTriggers([ConnectionName] string connectionId)
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

    public class itemInput
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlesheet;

    public partial class WorkflowManagedActions
    {
        public GooglesheetActions Googlesheet(string connectionId) => new GooglesheetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglesheetTriggers Googlesheet(string connectionId) => new GooglesheetTriggers(connectionId);
    }
}
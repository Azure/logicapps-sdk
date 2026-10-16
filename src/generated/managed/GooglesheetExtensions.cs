//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlesheet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglesheetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<itemInput>> item = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        public IBodyWorkflowAction<Item> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<itemInput>> item = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
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

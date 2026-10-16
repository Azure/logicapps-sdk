//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uservoice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class UservoiceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uservoice")]
        public IBodyWorkflowAction<TablesList> GetTables()
        {
            var apiCallPath = "/datasets/default/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uservoice")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uservoice")]
        public IBodyWorkflowAction<Item> PostItem(Expression<Func<string>> table, Expression<Func<itemInput>> item = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uservoice")]
        public IBodyWorkflowAction<Item> GetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uservoice")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uservoice")]
        public IBodyWorkflowAction<Item> PatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<itemInput>> item = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }
    }

    public class UservoiceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/default/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Uservoice;

    public partial class WorkflowManagedActions
    {
        public UservoiceActions Uservoice(string connectionId) => new UservoiceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UservoiceTriggers Uservoice(string connectionId) => new UservoiceTriggers(connectionId);
    }
}

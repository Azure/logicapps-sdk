//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlesheet
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglesheetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> dataset)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TablesList> __BuildGetTables(WorkflowValue<string> dataset)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<int> top = null, WorkflowValue<int> skip = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        [WorkflowExpressionFactory(nameof(__BuildPostItem))]
        public IBodyWorkflowAction<Item> PostItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<itemInput> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildPostItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<itemInput> item = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<Item> GetItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildGetItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlesheet")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<Item> PatchItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<itemInput> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildPatchItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<itemInput> item = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
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

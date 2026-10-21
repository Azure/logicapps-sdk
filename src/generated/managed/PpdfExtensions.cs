//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ppdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PpdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ppdf")]
        public IBodyWorkflowAction<DataSetsList> GetDataSets()
        {
            var apiCallPath = "/datasets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataSetsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ppdf")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables", __workflow_dataset.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ppdf")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/items", __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class PpdfTriggers([ConnectionName] string connectionId)
    {
    }

    public class DataSetsList
    {
        [JsonProperty("value")]
        public DataSet[] Value { get; set; }
    }

    public class DataSet
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
        public string ItemInternalId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ppdf;

    public partial class WorkflowManagedActions
    {
        public PpdfActions Ppdf(string connectionId) => new PpdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PpdfTriggers Ppdf(string connectionId) => new PpdfTriggers(connectionId);
    }
}

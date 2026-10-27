//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Customerinsights
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CustomerinsightsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IBodyWorkflowAction<PartitionDataResponse, ApiConnectionActionConfiguration> GetPartitionData(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> partitionUri, Expression<Func<string>> select = null, Expression<Func<int>> offsetStart = null, Expression<Func<int>> maxSize = null, Expression<Func<int>> maxResults = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_partitionUri = WorkflowExpression.Compile(partitionUri, nameof(partitionUri), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_offsetStart = WorkflowExpression.Compile(offsetStart, nameof(offsetStart), required: false);
            var __workflow_maxSize = WorkflowExpression.Compile(maxSize, nameof(maxSize), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<PartitionDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/data", __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partitionUri"] = ExpressionConverter.Convert(__workflow_partitionUri);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["offsetStart"] = Convert.ToString(0);
                if (__workflow_offsetStart != null)
                    callPayload.Queries["offsetStart"] = ExpressionConverter.Convert(__workflow_offsetStart);
                callPayload.Queries["maxSize"] = Convert.ToString(10485760);
                if (__workflow_maxSize != null)
                    callPayload.Queries["maxSize"] = ExpressionConverter.Convert(__workflow_maxSize);
                callPayload.Queries["maxResults"] = Convert.ToString(100000);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<PartitionDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IBodyWorkflowAction<TablesList, ApiConnectionActionConfiguration> GetTables(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables", __workflow_dataset.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> select = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/items", __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/items", __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/items/{2}", __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/items/{2}", __workflow_dataset.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IBodyWorkflowAction<PartitionListResponse, ApiConnectionActionConfiguration> GetPartitions(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> partitionDisplayName = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_partitionDisplayName = WorkflowExpression.Compile(partitionDisplayName, nameof(partitionDisplayName), required: false);
            return new DeferredBodyAction<PartitionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/tables/{1}/partitionsV2", __workflow_dataset.WithUrlEncoding(2), __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_partitionDisplayName != null)
                    callPayload.Queries["partitionDisplayName"] = ExpressionConverter.Convert(__workflow_partitionDisplayName);
                return new ApiConnectionAction<PartitionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "customerinsights")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendStatusReport(Expression<Func<string>> dataset, Expression<Func<reportTypeInput>> reportType, Expression<Func<object>> payload)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_reportType = WorkflowExpression.Compile(reportType, nameof(reportType), required: true);
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/reportV2/{1}", __workflow_dataset.WithUrlEncoding(2), __workflow_reportType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CustomerinsightsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<DataSourcesList, ApiConnectionTriggerConfiguration> OnDataSourceRefreshComplete(Expression<Func<string>> dataset, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyTrigger<DataSourcesList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/onupdateditemscomplete", __workflow_dataset.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<DataSourcesList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<DataSourcesList, ApiConnectionTriggerConfiguration> OnDataSourceRefreshFail(Expression<Func<string>> dataset, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyTrigger<DataSourcesList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/onupdateditemsfail", __workflow_dataset.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<DataSourcesList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SegmentData, ApiConnectionTriggerConfiguration> OnSegmentUpdated(Expression<Func<string>> dataset, Expression<Func<string>> segment, Expression<Func<int>> threshold, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_segment = WorkflowExpression.Compile(segment, nameof(segment), required: true);
            var __workflow_threshold = WorkflowExpression.Compile(threshold, nameof(threshold), required: true);
            return new DeferredBodyTrigger<SegmentData, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/onupdatedsegment/{1}/{2}", __workflow_dataset.WithUrlEncoding(2), __workflow_segment.WithUrlEncoding(2), __workflow_threshold.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<SegmentData>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<MeasureData, ApiConnectionTriggerConfiguration> OnBusinessMeasureUpdated(Expression<Func<string>> dataset, Expression<Func<string>> measure, Expression<Func<double>> threshold, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_measure = WorkflowExpression.Compile(measure, nameof(measure), required: true);
            var __workflow_threshold = WorkflowExpression.Compile(threshold, nameof(threshold), required: true);
            return new DeferredBodyTrigger<MeasureData, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/onupdatedbusinessmeasure/{1}/{2}", __workflow_dataset.WithUrlEncoding(2), __workflow_measure.WithUrlEncoding(2), __workflow_threshold.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<MeasureData>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullRefreshProcessData, ApiConnectionTriggerConfiguration> OnFullDagRefreshCompleted(Expression<Func<string>> dataset, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyTrigger<FullRefreshProcessData, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/onfulldagrefreshcompleted", __workflow_dataset.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<FullRefreshProcessData>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ProcessData, ApiConnectionTriggerConfiguration> OnProcessCompleted(Expression<Func<string>> dataset, Expression<Func<processInput>> process = null, Expression<Func<bool>> includingManualRefreshes = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_process = WorkflowExpression.Compile(process, nameof(process), required: false);
            var __workflow_includingManualRefreshes = WorkflowExpression.Compile(includingManualRefreshes, nameof(includingManualRefreshes), required: false);
            return new DeferredBodyTrigger<ProcessData, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/onprocesscompleted", __workflow_dataset.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["process"] = Convert.ToString("Unification");
                if (__workflow_process != null)
                    callPayload.Queries["process"] = ExpressionConverter.Convert(__workflow_process);
                callPayload.Queries["includingManualRefreshes"] = Convert.ToString(false);
                if (__workflow_includingManualRefreshes != null)
                    callPayload.Queries["includingManualRefreshes"] = ExpressionConverter.Convert(__workflow_includingManualRefreshes);
                return new ApiConnectionTrigger<ProcessData>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class PartitionDataResponse
    {
        public int OffsetStart { get; set; }
        public int OffsetEnd { get; set; }
        public int Size { get; set; }
        public JToken[] Items { get; set; }
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

    public class PartitionListResponse
    {
        public string Header { get; set; }
        public Table[] Partitions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum reportTypeInput
    {
        Export
    }

    public class DataSourcesList
    {
        [JsonProperty("value")]
        public DataSource[] Value { get; set; }
    }

    public class DataSource
    {
        public string RefreshType { get; set; }
        public string RefreshObjectId { get; set; }
        public int RefreshObjectVersion { get; set; }
        public string Operation { get; set; }
        public string JobType { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorSeverity { get; set; }
        public string StartTimeUtc { get; set; }
        public string EndTimeUtc { get; set; }
    }

    public class SegmentData
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string EvaluationDate { get; set; }
        public int EntityCount { get; set; }
        public int Threshold { get; set; }
    }

    public class MeasureData
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string EvaluationDate { get; set; }
        public double Value { get; set; }
        public string ValueDisplayName { get; set; }
        public double Threshold { get; set; }
    }

    public class FullRefreshProcessData
    {
        public int NumberOfFailedTasks { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Duration { get; set; }
        public string Status { get; set; }
        public string StatusPage { get; set; }
    }

    public class ProcessData
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Duration { get; set; }
        public string Status { get; set; }
        public string StatusPage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum processInput
    {
        Unification
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Customerinsights;

    public partial class WorkflowManagedActions
    {
        public CustomerinsightsActions Customerinsights(string connectionId) => new CustomerinsightsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CustomerinsightsTriggers Customerinsights(string connectionId) => new CustomerinsightsTriggers(connectionId);
    }
}
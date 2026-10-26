//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airtable
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirtableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<ListRecordsResponse, ApiConnectionActionConfiguration> ListRecords(Expression<Func<string>> baseId, Expression<Func<string>> table, Expression<Func<string>> filterByFormula = null, Expression<Func<int>> maxRecords = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> view = null, Expression<Func<string>> cellFormat = null, Expression<Func<string>> timeZone = null, Expression<Func<string>> userLocale = null)
        {
            var __workflow_baseId = WorkflowExpression.Compile(baseId, nameof(baseId), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filterByFormula = WorkflowExpression.Compile(filterByFormula, nameof(filterByFormula), required: false);
            var __workflow_maxRecords = WorkflowExpression.Compile(maxRecords, nameof(maxRecords), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            var __workflow_cellFormat = WorkflowExpression.Compile(cellFormat, nameof(cellFormat), required: false);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_userLocale = WorkflowExpression.Compile(userLocale, nameof(userLocale), required: false);
            return new DeferredBodyAction<ListRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}", __workflow_baseId.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filterByFormula != null)
                    callPayload.Queries["filterByFormula"] = ExpressionConverter.Convert(__workflow_filterByFormula);
                if (__workflow_maxRecords != null)
                    callPayload.Queries["maxRecords"] = ExpressionConverter.Convert(__workflow_maxRecords);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                if (__workflow_cellFormat != null)
                    callPayload.Queries["cellFormat"] = ExpressionConverter.Convert(__workflow_cellFormat);
                if (__workflow_timeZone != null)
                    callPayload.Queries["timeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_userLocale != null)
                    callPayload.Queries["userLocale"] = ExpressionConverter.Convert(__workflow_userLocale);
                return new ApiConnectionAction<ListRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<CreateaRecordResponse, ApiConnectionActionConfiguration> CreateaRecord(Expression<Func<string>> baseId, Expression<Func<string>> table, Expression<Func<object>> body)
        {
            var __workflow_baseId = WorkflowExpression.Compile(baseId, nameof(baseId), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateaRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}", __workflow_baseId.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<RetrieveaRecordResponse, ApiConnectionActionConfiguration> RetrieveaRecord(Expression<Func<string>> baseId, Expression<Func<string>> table, Expression<Func<string>> recordId)
        {
            var __workflow_baseId = WorkflowExpression.Compile(baseId, nameof(baseId), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<RetrieveaRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_baseId.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<DeleteaRecordResponse, ApiConnectionActionConfiguration> DeleteaRecord(Expression<Func<string>> baseId, Expression<Func<string>> table, Expression<Func<string>> recordId)
        {
            var __workflow_baseId = WorkflowExpression.Compile(baseId, nameof(baseId), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<DeleteaRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_baseId.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<UpdateaRecordResponse, ApiConnectionActionConfiguration> UpdateaRecord(Expression<Func<string>> baseId, Expression<Func<string>> table, Expression<Func<string>> recordId, Expression<Func<object>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_baseId = WorkflowExpression.Compile(baseId, nameof(baseId), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<UpdateaRecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_baseId.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateaRecordResponse>(callPayload);
            });
        }
    }

    public class AirtableTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListRecordsResponse
    {
        [JsonProperty("records")]
        public ListRecordsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ListRecordsResponseRecordsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class CreateaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class RetrieveaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class DeleteaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("error")]
        public DeleteaRecordResponseErrorType Error { get; set; }
    }

    public class DeleteaRecordResponseErrorType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airtable;

    public partial class WorkflowManagedActions
    {
        public AirtableActions Airtable(string connectionId) => new AirtableActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirtableTriggers Airtable(string connectionId) => new AirtableTriggers(connectionId);
    }
}
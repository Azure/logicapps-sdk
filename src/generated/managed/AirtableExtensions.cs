//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airtable
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AirtableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<ListRecordsResponse> ListRecords(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> filterByFormula = null, Expression<Func<int>> maxRecords = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> view = null, Expression<Func<string>> cellFormat = null, Expression<Func<string>> timeZone = null, Expression<Func<string>> userLocale = null)
        {
            var __workflow_baseID = baseID == null ? null : WorkflowExpression.Compile(baseID);
            WorkflowExpression.Validate(__workflow_baseID, nameof(baseID), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_filterByFormula = filterByFormula == null ? null : WorkflowExpression.Compile(filterByFormula);
            WorkflowExpression.Validate(__workflow_filterByFormula, nameof(filterByFormula), required: false);
            var __workflow_maxRecords = maxRecords == null ? null : WorkflowExpression.Compile(maxRecords);
            WorkflowExpression.Validate(__workflow_maxRecords, nameof(maxRecords), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_view = view == null ? null : WorkflowExpression.Compile(view);
            WorkflowExpression.Validate(__workflow_view, nameof(view), required: false);
            var __workflow_cellFormat = cellFormat == null ? null : WorkflowExpression.Compile(cellFormat);
            WorkflowExpression.Validate(__workflow_cellFormat, nameof(cellFormat), required: false);
            var __workflow_timeZone = timeZone == null ? null : WorkflowExpression.Compile(timeZone);
            WorkflowExpression.Validate(__workflow_timeZone, nameof(timeZone), required: false);
            var __workflow_userLocale = userLocale == null ? null : WorkflowExpression.Compile(userLocale);
            WorkflowExpression.Validate(__workflow_userLocale, nameof(userLocale), required: false);
            return new DeferredBodyAction<ListRecordsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1));
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
        public IBodyWorkflowAction<CreateaRecordResponse> CreateaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table)
        {
            var __workflow_baseID = baseID == null ? null : WorkflowExpression.Compile(baseID);
            WorkflowExpression.Validate(__workflow_baseID, nameof(baseID), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            return new DeferredBodyAction<CreateaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<RetrieveaRecordResponse> RetrieveaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> recordID)
        {
            var __workflow_baseID = baseID == null ? null : WorkflowExpression.Compile(baseID);
            WorkflowExpression.Validate(__workflow_baseID, nameof(baseID), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_recordID = recordID == null ? null : WorkflowExpression.Compile(recordID);
            WorkflowExpression.Validate(__workflow_recordID, nameof(recordID), required: true);
            return new DeferredBodyAction<RetrieveaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<DeleteaRecordResponse> DeleteaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> recordID)
        {
            var __workflow_baseID = baseID == null ? null : WorkflowExpression.Compile(baseID);
            WorkflowExpression.Validate(__workflow_baseID, nameof(baseID), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_recordID = recordID == null ? null : WorkflowExpression.Compile(recordID);
            WorkflowExpression.Validate(__workflow_recordID, nameof(recordID), required: true);
            return new DeferredBodyAction<DeleteaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<UpdateaRecordResponse> UpdateaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> recordID, Expression<Func<string>> contentType = null)
        {
            var __workflow_baseID = baseID == null ? null : WorkflowExpression.Compile(baseID);
            WorkflowExpression.Validate(__workflow_baseID, nameof(baseID), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_recordID = recordID == null ? null : WorkflowExpression.Compile(recordID);
            WorkflowExpression.Validate(__workflow_recordID, nameof(recordID), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<UpdateaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

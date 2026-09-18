//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtquery
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudfenxtqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiQueryExecutionJob> GetQueryJobStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<moduleInput> module, [WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<includeReadUrlInput> includeReadUrl = null, [WorkflowExpression] Func<contentDispositionInput> contentDisposition = null)
        {
            var apiCallPath = String.Format("/query/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["product"] = Convert.ToString("FE");
            callPayload.Queries["module"] = ExpressionConverter.Convert(module);
            callPayload.Queries["include_read_url"] = Convert.ToString("OnceCompleted");
            if (includeReadUrl != null)
                callPayload.Queries["include_read_url"] = ExpressionConverter.Convert(includeReadUrl);
            callPayload.Queries["content_disposition"] = Convert.ToString("Attachment");
            if (contentDisposition != null)
                callPayload.Queries["content_disposition"] = ExpressionConverter.Convert(contentDisposition);
            return new ApiConnectionAction<QueryApiQueryExecutionJob>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiQuerySummaryCollection> ListQueries([WorkflowExpression] Func<moduleInput> module, [WorkflowExpression] Func<int> queryTypeId = null, [WorkflowExpression] Func<int> category = null, [WorkflowExpression] Func<queryFormatInput> queryFormat = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<bool> myFavQueriesOnly = null, [WorkflowExpression] Func<bool> myQueriesOnly = null, [WorkflowExpression] Func<bool> mergedQueriesOnly = null, [WorkflowExpression] Func<sortColumnInput> sortColumn = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> addedBy = null, [WorkflowExpression] Func<bool> sortDescending = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/query/queries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["product"] = Convert.ToString("FE");
            callPayload.Queries["module"] = ExpressionConverter.Convert(module);
            if (queryTypeId != null)
                callPayload.Queries["query_type_id"] = ExpressionConverter.Convert(queryTypeId);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (queryFormat != null)
                callPayload.Queries["query_format"] = ExpressionConverter.Convert(queryFormat);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (myFavQueriesOnly != null)
                callPayload.Queries["my_fav_queries_only"] = ExpressionConverter.Convert(myFavQueriesOnly);
            if (myQueriesOnly != null)
                callPayload.Queries["my_queries_only"] = ExpressionConverter.Convert(myQueriesOnly);
            if (mergedQueriesOnly != null)
                callPayload.Queries["merged_queries_only"] = ExpressionConverter.Convert(mergedQueriesOnly);
            if (sortColumn != null)
                callPayload.Queries["sort_column"] = ExpressionConverter.Convert(sortColumn);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (addedBy != null)
                callPayload.Queries["added_by"] = ExpressionConverter.Convert(addedBy);
            if (sortDescending != null)
                callPayload.Queries["sort_descending"] = ExpressionConverter.Convert(sortDescending);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<QueryApiQuerySummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartAdHocQueryExecutionJob([WorkflowExpression] Func<moduleInput> module, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyformattingModeInput> bodyformattingMode = null, [WorkflowExpression] Func<string> bodyfilename = null)
        {
            var apiCallPath = "/query/queries/execute";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["product"] = Convert.ToString("FE");
            callPayload.Queries["module"] = ExpressionConverter.Convert(module);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            if (bodyoutputFormat != null)
            {
                if (bodyoutputFormat != null)
                {
                    body["output_format"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["output_format"] = "Csv";
                bodypropCount++;
            }

            if (bodyformattingMode != null)
            {
                if (bodyformattingMode != null)
                {
                    body["formatting_mode"] = ExpressionConverter.ConvertO(bodyformattingMode);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["formatting_mode"] = "None";
                bodypropCount++;
            }

            if (bodyfilename != null)
            {
                body["results_file_name"] = ExpressionConverter.ConvertO(bodyfilename);
                bodypropCount++;
            }

            body["ux_mode"] = "Asynchronous";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartQueryExecutionJob([WorkflowExpression] Func<moduleInput> module, [WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyquery, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyformattingModeInput> bodyformattingMode = null, [WorkflowExpression] Func<bodysQLGenerationModeInput> bodysQLGenerationMode = null, [WorkflowExpression] Func<bool> bodyuseStaticQuery = null, [WorkflowExpression] Func<string> bodyfilename = null)
        {
            var apiCallPath = "/query/queries/executebyid";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["product"] = Convert.ToString("FE");
            callPayload.Queries["module"] = ExpressionConverter.Convert(module);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["v_query_type_id"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyquery);
            if (bodyoutputFormat != null)
            {
                if (bodyoutputFormat != null)
                {
                    body["output_format"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["output_format"] = "Csv";
                bodypropCount++;
            }

            if (bodyformattingMode != null)
            {
                if (bodyformattingMode != null)
                {
                    body["formatting_mode"] = ExpressionConverter.ConvertO(bodyformattingMode);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["formatting_mode"] = "None";
                bodypropCount++;
            }

            if (bodysQLGenerationMode != null)
            {
                if (bodysQLGenerationMode != null)
                {
                    body["sql_generation_mode"] = ExpressionConverter.ConvertO(bodysQLGenerationMode);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["sql_generation_mode"] = "Query";
                bodypropCount++;
            }

            if (bodyuseStaticQuery != null)
            {
                body["use_static_query_id_set"] = ExpressionConverter.ConvertO(bodyuseStaticQuery);
                bodypropCount++;
            }

            if (bodyfilename != null)
            {
                body["results_file_name"] = ExpressionConverter.ConvertO(bodyfilename);
                bodypropCount++;
            }

            body["ux_mode"] = "Asynchronous";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartRefreshStaticQueryExecutionJob([WorkflowExpression] Func<moduleInput> module, [WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyquery)
        {
            var apiCallPath = "/query/queries/refreshstaticquery";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["product"] = Convert.ToString("FE");
            callPayload.Queries["module"] = ExpressionConverter.Convert(module);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["v_query_type_id"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyquery);
            body["ux_mode"] = "Asynchronous";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
        }
    }

    public class BlackbaudfenxtqueryTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryApiQueryExecutionJob
    {
        [JsonProperty("id")]
        public string JobID { get; set; }

        [JsonProperty("status")]
        public QueryApiQueryExecutionJobStatusType Status { get; set; }

        [JsonProperty("row_count")]
        public int RowCount { get; set; }

        [JsonProperty("sas_uri")]
        public string QueryResultsURI { get; set; }
    }

    public enum QueryApiQueryExecutionJobStatusType
    {
        Pending,
        Running,
        Completed,
        Failed,
        Cancelling,
        Cancelled,
        Throttled
    }

    public enum moduleInput
    {
        GeneralLedger,
        AccountsPayable,
        AccountsReceivable,
        FixedAssets,
        CashReceipts
    }

    public enum includeReadUrlInput
    {
        Never,
        OnceRunning,
        OnceCompleted
    }

    public enum contentDispositionInput
    {
        Inline,
        Attachment
    }

    public class QueryApiQuerySummaryCollection
    {
        [JsonProperty("queries")]
        public QueryApiQuerySummary[] Queries { get; set; }
    }

    public class QueryApiQuerySummary
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_id")]
        public int TypeID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_id")]
        public int CategoryID { get; set; }

        [JsonProperty("format")]
        public QueryApiQuerySummaryFormatType Format { get; set; }

        [JsonProperty("view_supported")]
        public bool ViewSupported { get; set; }

        [JsonProperty("edit_supported")]
        public bool EditSupported { get; set; }

        [JsonProperty("favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("has_ask_fields")]
        public bool HasAskFields { get; set; }

        [JsonProperty("created_by_query")]
        public bool CreatedByQuery { get; set; }

        [JsonProperty("supported_execution_modes")]
        public QueryApiQuerySummarySupportedExecutionModesType SupportedExecutionModes { get; set; }

        [JsonProperty("can_modify")]
        public bool CanModify { get; set; }

        [JsonProperty("can_execute")]
        public bool CanExecute { get; set; }

        [JsonProperty("others_can_modify")]
        public bool OthersCanModify { get; set; }

        [JsonProperty("others_can_execute")]
        public bool OthersCanExecute { get; set; }

        [JsonProperty("suppress_duplicates")]
        public bool SuppressDuplicates { get; set; }

        [JsonProperty("select_from_query_name")]
        public string SelectFromQueryName { get; set; }

        [JsonProperty("select_from_query_id")]
        public int SelectFromQueryID { get; set; }

        [JsonProperty("date_last_run")]
        public string LastRun { get; set; }

        [JsonProperty("num_records")]
        public int NumberOfRecords { get; set; }

        [JsonProperty("elapsed_ms")]
        public int ElapsedTime { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("added_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("date_changed")]
        public string DateChanged { get; set; }

        [JsonProperty("last_changed_by")]
        public string ChangedBy { get; set; }
    }

    public enum QueryApiQuerySummaryFormatType
    {
        Dynamic,
        Static
    }

    public enum QueryApiQuerySummarySupportedExecutionModesType
    {
        None,
        ById,
        AdHoc,
        Both
    }

    public enum queryFormatInput
    {
        Dynamic,
        Static
    }

    public enum sortColumnInput
    {
        Name,
        DateLastRun,
        DateChanged,
        ElapsedMs,
        DateAdded,
        AddedBy,
        LastChangedBy,
        Records
    }

    public class QueryApiExecuteQueryResponse
    {
        [JsonProperty("id")]
        public string JobID { get; set; }

        [JsonProperty("status")]
        public QueryApiExecuteQueryResponseStatusType Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public enum QueryApiExecuteQueryResponseStatusType
    {
        Pending,
        Running,
        Completed,
        Failed,
        Cancelling,
        Cancelled,
        Throttled
    }

    public enum bodyoutputFormatInput
    {
        Csv,
        Json,
        Jsonl
    }

    public enum bodyformattingModeInput
    {
        None,
        UI,
        Export
    }

    public enum bodysQLGenerationModeInput
    {
        Query,
        Export,
        Report
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtquery;

    public partial class WorkflowManagedActions
    {
        public BlackbaudfenxtqueryActions Blackbaudfenxtquery(string connectionId) => new BlackbaudfenxtqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudfenxtqueryTriggers Blackbaudfenxtquery(string connectionId) => new BlackbaudfenxtqueryTriggers(connectionId);
    }
}
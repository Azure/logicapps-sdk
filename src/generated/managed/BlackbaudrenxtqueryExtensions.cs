//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtquery
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtqueryActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        [WorkflowExpressionFactory(nameof(__BuildGetQueryJobStatus))]
        public IBodyWorkflowAction<QueryApiQueryExecutionJob> GetQueryJobStatus([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<includeReadUrlInput> includeReadUrl = null, [WorkflowExpression] Func<contentDispositionInput> contentDisposition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryApiQueryExecutionJob> __BuildGetQueryJobStatus(WorkflowExpression<string> jobId, WorkflowExpression<includeReadUrlInput> includeReadUrl = null, WorkflowExpression<contentDispositionInput> contentDisposition = null)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            WorkflowExpression.Validate(includeReadUrl, nameof(includeReadUrl), required: false);
            WorkflowExpression.Validate(contentDisposition, nameof(contentDisposition), required: false);
            return new DeferredBodyAction<QueryApiQueryExecutionJob>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/query/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Queries["include_read_url"] = Convert.ToString("OnceCompleted");
                if (includeReadUrl != null)
                    callPayload.Queries["include_read_url"] = ExpressionConverter.Convert(includeReadUrl);
                callPayload.Queries["content_disposition"] = Convert.ToString("Attachment");
                if (contentDisposition != null)
                    callPayload.Queries["content_disposition"] = ExpressionConverter.Convert(contentDisposition);
                return new ApiConnectionAction<QueryApiQueryExecutionJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        [WorkflowExpressionFactory(nameof(__BuildListQueries))]
        public IBodyWorkflowAction<QueryApiQuerySummaryCollection> ListQueries([WorkflowExpression] Func<int> queryTypeId = null, [WorkflowExpression] Func<int> category = null, [WorkflowExpression] Func<queryFormatInput> queryFormat = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<bool> myFavQueriesOnly = null, [WorkflowExpression] Func<bool> myQueriesOnly = null, [WorkflowExpression] Func<bool> mergedQueriesOnly = null, [WorkflowExpression] Func<listQueriesInput> listQueries = null, [WorkflowExpression] Func<sortColumnInput> sortColumn = null, [WorkflowExpression] Func<bool> sortDescending = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> addedBy = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryApiQuerySummaryCollection> __BuildListQueries(WorkflowExpression<int> queryTypeId = null, WorkflowExpression<int> category = null, WorkflowExpression<queryFormatInput> queryFormat = null, WorkflowExpression<string> searchText = null, WorkflowExpression<bool> myFavQueriesOnly = null, WorkflowExpression<bool> myQueriesOnly = null, WorkflowExpression<bool> mergedQueriesOnly = null, WorkflowExpression<listQueriesInput> listQueries = null, WorkflowExpression<sortColumnInput> sortColumn = null, WorkflowExpression<bool> sortDescending = null, WorkflowExpression<string> dateAdded = null, WorkflowExpression<string> addedBy = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(queryTypeId, nameof(queryTypeId), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(queryFormat, nameof(queryFormat), required: false);
            WorkflowExpression.Validate(searchText, nameof(searchText), required: false);
            WorkflowExpression.Validate(myFavQueriesOnly, nameof(myFavQueriesOnly), required: false);
            WorkflowExpression.Validate(myQueriesOnly, nameof(myQueriesOnly), required: false);
            WorkflowExpression.Validate(mergedQueriesOnly, nameof(mergedQueriesOnly), required: false);
            WorkflowExpression.Validate(listQueries, nameof(listQueries), required: false);
            WorkflowExpression.Validate(sortColumn, nameof(sortColumn), required: false);
            WorkflowExpression.Validate(sortDescending, nameof(sortDescending), required: false);
            WorkflowExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            WorkflowExpression.Validate(addedBy, nameof(addedBy), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<QueryApiQuerySummaryCollection>(() =>
            {
                var apiCallPath = "/query/queries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
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
                if (listQueries != null)
                    callPayload.Queries["list_queries"] = ExpressionConverter.Convert(listQueries);
                if (sortColumn != null)
                    callPayload.Queries["sort_column"] = ExpressionConverter.Convert(sortColumn);
                if (sortDescending != null)
                    callPayload.Queries["sort_descending"] = ExpressionConverter.Convert(sortDescending);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
                if (addedBy != null)
                    callPayload.Queries["added_by"] = ExpressionConverter.Convert(addedBy);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<QueryApiQuerySummaryCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        [WorkflowExpressionFactory(nameof(__BuildStartAdHocQueryExecutionJob))]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartAdHocQueryExecutionJob([WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyformattingModeInput> bodyformattingMode = null, [WorkflowExpression] Func<string> bodyfilename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> __BuildStartAdHocQueryExecutionJob(WorkflowExpression<bodyoutputFormatInput> bodyoutputFormat = null, WorkflowExpression<bodyformattingModeInput> bodyformattingMode = null, WorkflowExpression<string> bodyfilename = null)
        {
            WorkflowExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            WorkflowExpression.Validate(bodyformattingMode, nameof(bodyformattingMode), required: false);
            WorkflowExpression.Validate(bodyfilename, nameof(bodyfilename), required: false);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse>(() =>
            {
                var apiCallPath = "/query/queries/execute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        [WorkflowExpressionFactory(nameof(__BuildStartQueryExecutionJob))]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartQueryExecutionJob([WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyquery, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyformattingModeInput> bodyformattingMode = null, [WorkflowExpression] Func<bodysQLGenerationModeInput> bodysQLGenerationMode = null, [WorkflowExpression] Func<bool> bodyuseStaticQuery = null, [WorkflowExpression] Func<string> bodyfilename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> __BuildStartQueryExecutionJob(WorkflowExpression<int> bodytype, WorkflowExpression<int> bodyquery, WorkflowExpression<bodyoutputFormatInput> bodyoutputFormat = null, WorkflowExpression<bodyformattingModeInput> bodyformattingMode = null, WorkflowExpression<bodysQLGenerationModeInput> bodysQLGenerationMode = null, WorkflowExpression<bool> bodyuseStaticQuery = null, WorkflowExpression<string> bodyfilename = null)
        {
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            WorkflowExpression.Validate(bodyformattingMode, nameof(bodyformattingMode), required: false);
            WorkflowExpression.Validate(bodysQLGenerationMode, nameof(bodysQLGenerationMode), required: false);
            WorkflowExpression.Validate(bodyuseStaticQuery, nameof(bodyuseStaticQuery), required: false);
            WorkflowExpression.Validate(bodyfilename, nameof(bodyfilename), required: false);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse>(() =>
            {
                var apiCallPath = "/query/queries/executebyid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        [WorkflowExpressionFactory(nameof(__BuildStartRefreshStaticQueryExecutionJob))]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartRefreshStaticQueryExecutionJob([WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyquery)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> __BuildStartRefreshStaticQueryExecutionJob(WorkflowExpression<int> bodytype, WorkflowExpression<int> bodyquery)
        {
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse>(() =>
            {
                var apiCallPath = "/query/queries/refreshstaticquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
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
            });
        }
    }

    public class BlackbaudrenxtqueryTriggers([ConnectionName] string connectionId)
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum includeReadUrlInput
    {
        Never,
        OnceRunning,
        OnceCompleted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

        [JsonProperty("query_list")]
        public bool IsAQueryList { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQuerySummaryFormatType
    {
        Dynamic,
        Static
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQuerySummarySupportedExecutionModesType
    {
        None,
        ById,
        AdHoc,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum queryFormatInput
    {
        Dynamic,
        Static
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum listQueriesInput
    {
        Unset,
        NoListQueries
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputFormatInput
    {
        Csv,
        Json,
        Jsonl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyformattingModeInput
    {
        None,
        UI,
        Export
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysQLGenerationModeInput
    {
        Query,
        Export,
        Report
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtquery;

    public partial class WorkflowManagedActions
    {
        public BlackbaudrenxtqueryActions Blackbaudrenxtquery(string connectionId) => new BlackbaudrenxtqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudrenxtqueryTriggers Blackbaudrenxtquery(string connectionId) => new BlackbaudrenxtqueryTriggers(connectionId);
    }
}